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
	}
}