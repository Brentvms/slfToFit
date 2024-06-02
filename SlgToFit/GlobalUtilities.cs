using System.Globalization;

namespace SlfToFit
{
	public static class GlobalUtilities
	{
		public static DateTime SlgDateToDateTime(string slgDate)
		{
			return DateTime.ParseExact(slgDate, "ddd MMM d HH:mm:ss 'GMT'zzz yyyy", CultureInfo.InvariantCulture).ToUniversalTime();
		}

		public static Dynastream.Fit.DateTime AddSecondsToDynstreamDateTime(Dynastream.Fit.DateTime dt, float seconds)
		{
			return new Dynastream.Fit.DateTime(dt.GetDateTime().AddSeconds(seconds));
		}
	}
}
