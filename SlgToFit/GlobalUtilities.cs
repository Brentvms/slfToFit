using System.Globalization;

namespace SlfToFit
{
	public static class GlobalUtilities
	{
		public static DateTime SlgDateToDateTime(string slgDate)
		{
			return DateTime.ParseExact(slgDate, "ddd MMM d HH:mm:ss 'GMT'zzz yyyy", CultureInfo.InvariantCulture);
		}
	}
}
