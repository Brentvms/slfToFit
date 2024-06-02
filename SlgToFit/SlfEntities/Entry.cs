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
		public readonly float Altitude = altitude/1000f;                                        // Altitude of the activity
		public readonly float AltitudeDifferencesDownhill = altitudeDifferencesDownhill/1000f;  // Differences in altitude downhill
		public readonly float AltitudeDifferencesUphill = altitudeDifferencesUphill/1000f;      // Differences in altitude uphill
		public readonly float Cadence = cadence;												// Cadence
		public readonly float Calories = calories;												// Calories burned
		public readonly float Distance = distance;												// Total distance covered
		public readonly float DistanceAbsolute = distanceAbsolute;								// Absolute distance covered
		public readonly float DistanceDownhill = distanceDownhill;								// Distance covered downhill
		public readonly float DistanceUphill = distanceUphill;									// Distance covered uphill
		public readonly float Heartrate = heartrate;											// Heart rate
		public readonly float Incline = incline;												// Incline
		public readonly float Latitude = latitude;												// Latitude
		public readonly float Longitude = longitude;											// Longitude
		public readonly float Power = power;													// Power
		public readonly float PowerPerKG = powerPerKG;											// Power per kilogram
		public readonly float RiseRate = riseRate;												// Rise rate
		public readonly float Speed = speed;													// Speed
		public readonly float Temperature = temperature;										// Temperature
		public readonly float TrainingTime = trainingTime/100f;									// Training time
		public readonly float TrainingTimeAbsolute = trainingTimeAbsolute/100f;					// Absolute training time
		public readonly float TrainingTimeDownhill = trainingTimeDownhill/100f;					// Training time downhill
		public readonly float TrainingTimeUphill = trainingTimeUphill/100f;						// Training time uphill
		public readonly float WorkInKJ = workInKJ;												// Work in kilojoules
		public readonly bool IsActive = isActive;												// Indicates if the activity is active
		public readonly float TimeBelowIntensityZones = timeBelowIntensityZones/100f;			// Time below intensity zones
		public readonly float TimeInIntensityZone1 = timeInIntensityZone1/100f;					// Time in intensity zone 1
		public readonly float TimeInIntensityZone2 = timeInIntensityZone2/100f;					// Time in intensity zone 2
		public readonly float TimeInIntensityZone3 = timeInIntensityZone3/100f;					// Time in intensity zone 3
		public readonly float TimeInIntensityZone4 = timeInIntensityZone4/100f;					// Time in intensity zone 4
		public readonly float TimeAboveIntensityZones = timeAboveIntensityZones/100f;			// Time above intensity zones
		public readonly float NormalizedPower = normalizedPower;								// Normalized power
		public readonly float RightBalance = rightBalance;										// Right balance
		public readonly float LeftBalance = leftBalance;										// Left balance
		public readonly float TimeInPowerZone1 = timeInPowerZone1/100f;							// Time in power zone 1
		public readonly float TimeInPowerZone2 = timeInPowerZone2/100f;							// Time in power zone 2
		public readonly float TimeInPowerZone3 = timeInPowerZone3/100f;							// Time in power zone 3
		public readonly float TimeInPowerZone4 = timeInPowerZone4/100f;							// Time in power zone 4
		public readonly float TimeInPowerZone5 = timeInPowerZone5/100f;							// Time in power zone 5
		public readonly float TimeInPowerZone6 = timeInPowerZone6/100f;							// Time in power zone 6
		public readonly float TimeInPowerZone7 = timeInPowerZone7/100f;							// Time in power zone 7
		public readonly float PedalingTime = pedalingTime/100f;									// Total pedaling time
		public readonly bool UseForChart = useForChart;											// Indicates if data is used for chart
		public readonly bool UseForTrack = useForTrack;											// Indicates if data is used for tracking
		public readonly float SpeedTime = speedTime/100f;										// Speed time

		public int IntLatitude {  get { return (int)(Latitude * (Math.Pow(2, 32) / 360)); } }
		public int IntLongitude { get { return (int)(Longitude * (Math.Pow(2, 32) / 360)); } }

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
