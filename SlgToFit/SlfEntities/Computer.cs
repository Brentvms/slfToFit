namespace SlfToFit.SlfEntities
{
	internal class Computer(string unit, string serial, string activityType, DateTime dateCode)
	{
		public readonly string Unit = UnitNameMap(unit);		// Model cycling computer
		public readonly string Serial = serial;					// Serial number
		public readonly string ActivityType = activityType;		// Type of activity recorded
		public readonly DateTime DateCode = dateCode;			// DateTime which the activity was recorded

		private static string UnitNameMap(string unit)
		{
			switch (unit)
			{
				case "rox110": return "ROX GPS 11.0";
				default: return "Sigma Cycling Computer";
			}
		}
	}
}
