using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlfToFit.SlfEntities
{
	internal class Computer(string unit, string serial, string activityType, DateTime dateCode)
	{
		public readonly string Unit = UnitNameMap(unit);
		public readonly string Serial = serial;
		public readonly string ActivityType = activityType;
		public readonly DateTime DateCode = dateCode;

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
