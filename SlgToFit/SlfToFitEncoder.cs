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
			
			FileIdMesg fileIdMesg = CreateFileIdMesg(slf, timeCreated);

			try
			{
				fitDest = new(outputPath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
				encoder = new(ProtocolVersion.V20);
				encoder.Open(fitDest);

				encoder.Write(fileIdMesg);
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

		private static FileIdMesg CreateFileIdMesg(Slf slf, Dynastream.Fit.DateTime timeCreated)
		{
			FileIdMesg fileIdMesg = new();
			fileIdMesg.SetType(Dynastream.Fit.File.Activity);
			fileIdMesg.SetManufacturer(Manufacturer.Sigmasport);
			fileIdMesg.SetProduct(slf.Computer.ProductId);
			// fileIdMesg.SetSerialNumber(slf.Computer.Serial);\
			fileIdMesg.SetTimeCreated(timeCreated);
			fileIdMesg.SetProductName(slf.Computer.Unit);
			return fileIdMesg;
		}
	}
}
