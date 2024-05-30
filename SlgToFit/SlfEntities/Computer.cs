using System.Reflection;
using System.Text;

namespace SlfToFit.SlfEntities
{
	public class Computer(string unit, string serial, string activityType, DateTime dateCode)
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

		#region @ToString

		public override string ToString()
		{
			return ToString(0);
		}

		public string ToString(int indentLevel)
		{
			const int spacesPerIndent = 4;
			string indent = new(' ', spacesPerIndent * indentLevel);
			StringBuilder builder = new();
			builder.Append(indent).Append(GetType().Name).Append(":\n");

			indent += "    ";
			FieldInfo[] properties = GetType().GetFields();
			foreach (FieldInfo property in properties)
			{
				builder.Append(indent).Append(property.Name).Append(": ").Append(property.GetValue(this)).Append('\n');
			}
			return builder.ToString().TrimEnd('\n', ' ');
		}

		#endregion
	}
}
