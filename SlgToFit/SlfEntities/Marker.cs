using System.Reflection;
using System.Text;

namespace SlfToFit.SlfEntities
{
	public abstract class Marker(
		int altitudeDownhill,
		int altitudeUphill,
		int averageAltitude,
		int averageCadence,
		int averageHeartrate,
		float averageInclineDownhill,
		float averageInclineUphill,
		int averagePower,
		float averageSpeed,
		int calories,
		string description,
		float distance,
		float distanceAbsolute,
		int duration,
		bool fastLap,
		float latitude,
		float longitude,
		int maximumAltitude,
		int maximumCadence,
		int maximumHeartrate,
		float maximumInclineDownhill,
		float maximumInclineUphill,
		int maximumPower,
		float maximumSpeed,
		int minimumHeartrate,
		float minimumSpeed,
		int number,
		int time,
		int timeAbsolute,
		string title,
		string type,
		int normalizedPower,
		float averageBalance,
		int pedalingTime,
		float leftTorqueEffectivity,
		float rightTorqueEffectivity,
		float leftPedalingSmoothness,
		float rightPedalingSmoothness)
	{
		public readonly float AltitudeDownhill = altitudeDownhill/1000f;                    // Downhill altitude for this lap
		public readonly float AltitudeUphill = altitudeUphill/1000f;                        // Uphill altitude for this lap
		public readonly float AverageAltitude = averageAltitude/1000f;                      // Average altitude for this lap
		public readonly int AverageCadence = averageCadence;                                // Average cadence for this lap
		public readonly int AverageHeartrate = averageHeartrate;                            // Average heartrate for this lap
		public readonly float AverageInclineDownhill = averageInclineDownhill;              // Average incline downhill for this lap
		public readonly float AverageInclineUphill = averageInclineUphill;                  // Average incline uphill for this lap
		public readonly int AveragePower = averagePower;                                    // Average power for this lap
		public readonly float AverageSpeed = averageSpeed;                                  // Average speed for this lap
		public readonly int Calories = calories;                                            // Calories burned for this lap
		public readonly string Description = description;                                   // Description of this lap
		public readonly float Distance = distance;                                          // Total distance covered in this lap
		public readonly float DistanceAbsolute = distanceAbsolute;                          // Absolute distance covered in this lap
		protected readonly float _duration = duration/100f;									// Duration of marker. Only for pauses
		public readonly bool FastLap = fastLap;                                             // Indicates if it's the fastest lap
		public readonly float Latitude = latitude;                                          // Latitude for this lap
		public readonly float Longitude = longitude;                                        // Longitude for this lap
		public readonly int MaximumAltitude = maximumAltitude;                              // Maximum altitude reached in this lap
		public readonly int MaximumCadence = maximumCadence;                                // Maximum cadence in this lap
		public readonly int MaximumHeartrate = maximumHeartrate;                            // Maximum heartrate in this lap
		public readonly float MaximumInclineDownhill = maximumInclineDownhill;              // Maximum incline downhill in this lap
		public readonly float MaximumInclineUphill = maximumInclineUphill;                  // Maximum incline uphill in this lap
		public readonly int MaximumPower = maximumPower;                                    // Maximum power output in this lap
		public readonly float MaximumSpeed = maximumSpeed;                                  // Maximum speed reached in this lap
		public readonly int MinimumHeartrate = minimumHeartrate;                            // Minimum heartrate in this lap
		public readonly float MinimumSpeed = minimumSpeed;                                  // Minimum speed in this lap
		public readonly int Number = number;                                                // Number of this lap
		public readonly float Time = time/100f;                                              // Time of this lap
		public readonly float TimeAbsolute = timeAbsolute/100f;                              // Time up and until this lap
		public readonly string Title = title;                                               // Title of this lap
		public readonly string Type = type;                                                 // Type of this lap: l = lap, p = pause
		public readonly int NormalizedPower = normalizedPower;                              // Normalized power output in this lap
		public readonly float AverageBalance = averageBalance;                              // Average balance in this lap
		public readonly float PedalingTime = pedalingTime/100f;                              // Total pedaling time in this lap
		public readonly float LeftTorqueEffectivity = leftTorqueEffectivity;                // Left torque effectivity in this lap
		public readonly float RightTorqueEffectivity = rightTorqueEffectivity;              // Right torque effectivity in this lap
		public readonly float LeftPedalingSmoothness = leftPedalingSmoothness;              // Left pedaling smoothness in this lap
		public readonly float RightPedalingSmoothness = rightPedalingSmoothness;            // Right pedaling smoothness in this lap

		public abstract float RelativeStartingTime { get; }
		public abstract float RelvativeEndingTime { get; }
		public abstract float Duration { get; }
		public int IntLatitude { get { return (int)(Latitude * (Math.Pow(2, 32) / 360)); } }
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
