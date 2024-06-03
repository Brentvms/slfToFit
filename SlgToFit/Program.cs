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
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}