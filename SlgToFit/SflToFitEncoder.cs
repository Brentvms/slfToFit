using Dynastream.Fit;

namespace SlfToFit
{
	public static class SlfToFitEncoder
	{
		public static void Encode(Slf slf, string outputPath)
		{
			FileStream? fitDest = null;
			Encode? encoder = null;
			Dynastream.Fit.DateTime timeCreated = new(System.DateTime.Now);

			try
			{
				fitDest = new(outputPath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
				encoder = new(ProtocolVersion.V20);
				encoder.Open(fitDest);
				CreateDeveloperDataFields(encoder);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex);
			}
			finally
			{
				encoder?.Close();
				fitDest?.Close();
			}
		}

		private static void CreateDeveloperDataFields(Encode encoder)
		{
			// setup developerID
			DeveloperDataIdMesg developerIdMesg = new();
			byte[] appId = new Guid("b89b6d22-57bd-4d35-8063-99f06960c596").ToByteArray();
			for (int i = 0; i < appId.Length; i++)
			{
				developerIdMesg.SetApplicationId(i, appId[i]);
			}
			developerIdMesg.SetDeveloperDataIndex(0);
			developerIdMesg.SetApplicationVersion(010);
			encoder.Write(developerIdMesg);

			// create guid field
			FieldDescriptionMesg guidFieldDescriptionMesg = new();
			guidFieldDescriptionMesg.SetDeveloperDataIndex(0);
			guidFieldDescriptionMesg.SetFieldDefinitionNumber(0);
			guidFieldDescriptionMesg.SetFitBaseTypeId(FitBaseType.String);
			guidFieldDescriptionMesg.SetFieldName(0, "guid");
			encoder.Write(guidFieldDescriptionMesg);
		}
	}
}