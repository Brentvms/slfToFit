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
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			//ApplicationConfiguration.Initialize();
			//Application.Run(new Form1());

			// test code for quick encode. NOT FOR PRODUCTION
			Slf? slf = SlfParser.ParseSlf("C:\\Users\\kriek\\source\\repos\\VincentKriek\\slgToFit\\Activities\\2024_04_06__13_08.slf");
			SlfToFitEncoder.Encode(slf, "C:\\Users\\kriek\\Downloads\\test.fit");
		}
	}
}