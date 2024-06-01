using System.Globalization;

namespace SlfToFit
{
	public static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
			//ApplicationConfiguration.Initialize();
			//Application.Run(new Form1());

			// test code for quick encode. NOT FOR PRODUCTION
			Slf? slf = SlfParser.ParseSlf("C:\\Users\\kriek\\source\\repos\\VincentKriek\\slgToFit\\Activities\\2024_05_22__14_49.slf");
			SlfToFitEncoder encoder = new SlfToFitEncoder();
			encoder.Encode(slf, "C:\\Users\\kriek\\Downloads\\test.fit");
		}
	}
}