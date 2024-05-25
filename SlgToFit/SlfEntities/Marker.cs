using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlfToFit.SlfEntities
{
	internal class Marker(
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
		int minimumSpeed,
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
		public readonly int AltitudeDownhill = altitudeDownhill;
		public readonly int AltitudeUphill = altitudeUphill;
		public readonly int AverageAltitude = averageAltitude;
		public readonly int AverageCadence = averageCadence;
		public readonly int AverageHeartrate = averageHeartrate;
		public readonly float AverageInclineDownhill = averageInclineDownhill;
		public readonly float AverageInclineUphill = averageInclineUphill;
		public readonly int AveragePower = averagePower;
		public readonly float AverageSpeed = averageSpeed;
		public readonly int Calories = calories;
		public readonly string Description = description;
		public readonly float Distance = distance;
		public readonly float DistanceAbsolute = distanceAbsolute;
		public readonly int Duration = duration;
		public readonly bool FastLap = fastLap;
		public readonly float Latitude = latitude;
		public readonly float Longitude = longitude;
		public readonly int MaximumAltitude = maximumAltitude;
		public readonly int MaximumCadence = maximumCadence;
		public readonly int MaximumHeartrate = maximumHeartrate;
		public readonly float MaximumInclineDownhill = maximumInclineDownhill;
		public readonly float MaximumInclineUphill = maximumInclineUphill;
		public readonly int MaximumPower = maximumPower;
		public readonly float MaximumSpeed = maximumSpeed;
		public readonly int MinimumHeartrate = minimumHeartrate;
		public readonly int MinimumSpeed = minimumSpeed;
		public readonly int Number = number;
		public readonly int Time = time;
		public readonly int TimeAbsolute = timeAbsolute;
		public readonly string Title = title;
		public readonly string Type = type;
		public readonly int NormalizedPower = normalizedPower;
		public readonly float AverageBalance = averageBalance;
		public readonly int PedalingTime = pedalingTime;
		public readonly float LeftTorqueEffectivity = leftTorqueEffectivity;
		public readonly float RightTorqueEffectivity = rightTorqueEffectivity;
		public readonly float LeftPedalingSmoothness = leftPedalingSmoothness;
		public readonly float RightPedalingSmoothness = rightPedalingSmoothness;
	}
}
