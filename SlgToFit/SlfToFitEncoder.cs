using Dynastream.Fit;
using System.Text;

namespace SlfToFit
{
	public class SlfToFitEncoder
	{
		private readonly Dictionary<string, FieldDescriptionMesg> DeveloperFields = [];
		private DeveloperDataIdMesg? DeveloperDataIdMesg;

		public void Encode(Slf slf, string outputPath)
		{
			FileStream? fitDest = null;
			Encode? encoder = null;
			Dynastream.Fit.DateTime timeCreated = new(System.DateTime.Now);
			Dynastream.Fit.DateTime timeStarted = new(slf.GeneralInformation.StartDate);
			CreateDeveloperDataFields();

			// all messages
			FileIdMesg fileIdMesg = CreateFileIdMesg(slf, timeCreated);
			DeviceInfoMesg deviceInfoMesg = CreateDeviceInformationMesg(slf);
			ActivityMesg activityMesg = CreateActivityMesg(slf);

			try
			{
				fitDest = new(outputPath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
				encoder = new(ProtocolVersion.V20);
				encoder.Open(fitDest);
				
				// the first message must be FileId
				encoder.Write(fileIdMesg);
				
				// write the developer fields
				WriteDeveloperDataFields(encoder);

				// write other general information
				encoder.Write(deviceInfoMesg);
				encoder.Write(activityMesg);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex);
				Console.ReadLine();
			}
			finally
			{
				encoder?.Close();
				fitDest?.Close();
			}
		}

		private FileIdMesg CreateFileIdMesg(Slf slf, Dynastream.Fit.DateTime timeCreated)
		{
			FileIdMesg fileIdMesg = new();
			fileIdMesg.SetType(Dynastream.Fit.File.Activity);
			fileIdMesg.SetManufacturer(Manufacturer.Sigmasport);
			fileIdMesg.SetProduct(slf.Computer.ProductId);
			fileIdMesg.SetTimeCreated(timeCreated);
			fileIdMesg.SetProductName(slf.Computer.Unit);
			return fileIdMesg;
		}


		private void CreateDeveloperDataFields()
		{
			// setup developerID
			DeveloperDataIdMesg developerIdMesg = new();
			byte[] appId = new Guid("b89b6d22-57bd-4d35-8063-99f06960c596").ToByteArray();
			for (int i = 0; i < appId.Length; i++)
			{
				developerIdMesg.SetApplicationId(i, appId[i]);
			}
			developerIdMesg.SetDeveloperDataIndex(0);
			developerIdMesg.SetApplicationVersion(100);
			DeveloperDataIdMesg = developerIdMesg;

			// create guid field
			FieldDescriptionMesg guidFieldDescriptionMesg = new();
			guidFieldDescriptionMesg.SetDeveloperDataIndex(0);
			guidFieldDescriptionMesg.SetFieldDefinitionNumber(0);
			guidFieldDescriptionMesg.SetFitBaseTypeId(FitBaseType.String);
			guidFieldDescriptionMesg.SetFieldName(0, "guid");
			DeveloperFields.Add("guid", guidFieldDescriptionMesg);

			// create serial number field
			FieldDescriptionMesg serialNumberFieldDescriptionMesg = new();
			serialNumberFieldDescriptionMesg.SetDeveloperDataIndex(0);
			serialNumberFieldDescriptionMesg.SetFieldDefinitionNumber(1);
			serialNumberFieldDescriptionMesg.SetFitBaseTypeId(FitBaseType.String);
			serialNumberFieldDescriptionMesg.SetFieldName(0, "serialnumber");
			serialNumberFieldDescriptionMesg.SetUnits(0, "null");
			DeveloperFields.Add("serialnumber", serialNumberFieldDescriptionMesg);
		}

		private void WriteDeveloperDataFields(Encode encoder)
		{
			encoder.Write(DeveloperDataIdMesg);
			foreach (var item in DeveloperFields)
			{
				encoder.Write(item.Value);
			}
		}

		private DeviceInfoMesg CreateDeviceInformationMesg(Slf slf)
		{
			DeviceInfoMesg devInfoMesg = new();
			devInfoMesg.SetManufacturer(Manufacturer.Sigmasport);
			devInfoMesg.SetProduct(slf.Computer.ProductId);

			// custom serial number field
			DeveloperField serialNumberField = new(DeveloperFields["serialnumber"], DeveloperDataIdMesg);
			devInfoMesg.SetDeveloperField(serialNumberField);
			serialNumberField.SetValue(Encoding.UTF8.GetBytes(slf.Computer.Serial));

			return devInfoMesg;
		}

		private ActivityMesg CreateActivityMesg(Slf slf)
		{
			ActivityMesg activityMesg = new();
			activityMesg.SetNumSessions(1);
			activityMesg.SetTotalTimerTime(slf.GeneralInformation.ExcerciseTime);
			activityMesg.SetEvent(Event.Activity);
			activityMesg.SetEventType(EventType.Stop);
			return activityMesg;
		}
	}
}
