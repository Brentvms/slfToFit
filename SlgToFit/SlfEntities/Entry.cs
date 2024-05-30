using System.Reflection;
using System.Text;

namespace SlfToFit.SlfEntities
{
	public class Entry(
		int altitude,
		int altitudeDifferencesDownhill,
		int altitudeDifferencesUphill,
		float cadence,
		float calories,
		float distance,
		float distanceAbsolute,
		float distanceDownhill,
		float distanceUphill,
		float heartrate,
		float incline,
		float latitude,
		float longitude,
		float power,
		float powerPerKG,
		float riseRate,
		float speed,
		float temperature,
		int trainingTime,
		int trainingTimeAbsolute,
		int trainingTimeDownhill,
		int trainingTimeUphill,
		float workInKJ,
		bool isActive,
		int timeBelowIntensityZones,
		int timeInIntensityZone1,
		int timeInIntensityZone2,
		int timeInIntensityZone3,
		int timeInIntensityZone4,
		int timeAboveIntensityZones,
		float normalizedPower,
		float rightBalance,
		float leftBalance,
		int timeInPowerZone1,
		int timeInPowerZone2,
		int timeInPowerZone3,
		int timeInPowerZone4,
		int timeInPowerZone5,
		int timeInPowerZone6,
		int timeInPowerZone7,
		int pedalingTime,
		bool useForChart,
		bool useForTrack,
		int speedTime)
	{
		public readonly int Altitude = altitude;                                            // Altitude of the activity
		public readonly int AltitudeDifferencesDownhill = altitudeDifferencesDownhill;      // Differences in altitude downhill
		public readonly int AltitudeDifferencesUphill = altitudeDifferencesUphill;          // Differences in altitude uphill
		public readonly float Cadence = cadence;                                            // Cadence
		public readonly float Calories = calories;                                          // Calories burned
		public readonly float Distance = distance;                                          // Total distance covered
		public readonly float DistanceAbsolute = distanceAbsolute;                          // Absolute distance covered
		public readonly float DistanceDownhill = distanceDownhill;                          // Distance covered downhill
		public readonly float DistanceUphill = distanceUphill;                              // Distance covered uphill
		public readonly float Heartrate = heartrate;                                        // Heart rate
		public readonly float Incline = incline;                                            // Incline
		public readonly float Latitude = latitude;                                          // Latitude
		public readonly float Longitude = longitude;                                        // Longitude
		public readonly float Power = power;                                                // Power
		public readonly float PowerPerKG = powerPerKG;                                      // Power per kilogram
		public readonly float RiseRate = riseRate;                                          // Rise rate
		public readonly float Speed = speed;                                                // Speed
		public readonly float Temperature = temperature;                                    // Temperature
		public readonly int TrainingTime = trainingTime;                                    // Training time
		public readonly int TrainingTimeAbsolute = trainingTimeAbsolute;                    // Absolute training time
		public readonly int TrainingTimeDownhill = trainingTimeDownhill;                    // Training time downhill
		public readonly int TrainingTimeUphill = trainingTimeUphill;                        // Training time uphill
		public readonly float WorkInKJ = workInKJ;                                          // Work in kilojoules
		public readonly bool IsActive = isActive;                                           // Indicates if the activity is active
		public readonly int TimeBelowIntensityZones = timeBelowIntensityZones;              // Time below intensity zones
		public readonly int TimeInIntensityZone1 = timeInIntensityZone1;                    // Time in intensity zone 1
		public readonly int TimeInIntensityZone2 = timeInIntensityZone2;                    // Time in intensity zone 2
		public readonly int TimeInIntensityZone3 = timeInIntensityZone3;                    // Time in intensity zone 3
		public readonly int TimeInIntensityZone4 = timeInIntensityZone4;                    // Time in intensity zone 4
		public readonly int TimeAboveIntensityZones = timeAboveIntensityZones;              // Time above intensity zones
		public readonly float NormalizedPower = normalizedPower;                            // Normalized power
		public readonly float RightBalance = rightBalance;                                  // Right balance
		public readonly float LeftBalance = leftBalance;                                    // Left balance
		public readonly int TimeInPowerZone1 = timeInPowerZone1;                            // Time in power zone 1
		public readonly int TimeInPowerZone2 = timeInPowerZone2;                            // Time in power zone 2
		public readonly int TimeInPowerZone3 = timeInPowerZone3;                            // Time in power zone 3
		public readonly int TimeInPowerZone4 = timeInPowerZone4;                            // Time in power zone 4
		public readonly int TimeInPowerZone5 = timeInPowerZone5;                            // Time in power zone 5
		public readonly int TimeInPowerZone6 = timeInPowerZone6;                            // Time in power zone 6
		public readonly int TimeInPowerZone7 = timeInPowerZone7;                            // Time in power zone 7
		public readonly int PedalingTime = pedalingTime;                                    // Total pedaling time
		public readonly bool UseForChart = useForChart;                                     // Indicates if data is used for chart
		public readonly bool UseForTrack = useForTrack;                                     // Indicates if data is used for tracking
		public readonly int SpeedTime = speedTime;                                          // Speed time

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
