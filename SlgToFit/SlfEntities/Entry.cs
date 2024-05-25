using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlfToFit.SlfEntities
{
	internal class Entry(
		int altitude,
		int altitudeDifferencesDownhill,
		int altitudeDifferencesUphill,
		int cadence,
		int calories,
		float distance,
		float distanceAbsolute,
		float distanceDownhill,
		float distanceUphill,
		int heartrate,
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
		int normalizedPower,
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
		public readonly int Altitude = altitude;
		public readonly int AltitudeDifferencesDownhill = altitudeDifferencesDownhill;
		public readonly int AltitudeDifferencesUphill = altitudeDifferencesUphill;
		public readonly int Cadence = cadence;
		public readonly int Calories = calories;
		public readonly float Distance = distance;
		public readonly float DistanceAbsolute = distanceAbsolute;
		public readonly float DistanceDownhill = distanceDownhill;
		public readonly float DistanceUphill = distanceUphill;
		public readonly int Heartrate = heartrate;
		public readonly float Incline = incline;
		public readonly float Latitude = latitude;
		public readonly float Longitude = longitude;
		public readonly float Power = power;
		public readonly float PowerPerKG = powerPerKG;
		public readonly float RiseRate = riseRate;
		public readonly float Speed = speed;
		public readonly float Temperature = temperature;
		public readonly int TrainingTime = trainingTime;
		public readonly int TrainingTimeAbsolute = trainingTimeAbsolute;
		public readonly int TrainingTimeDownhill = trainingTimeDownhill;
		public readonly int TrainingTimeUphill = trainingTimeUphill;
		public readonly float WorkInKJ = workInKJ;
		public readonly bool IsActive = isActive;
		public readonly int TimeBelowIntensityZones = timeBelowIntensityZones;
		public readonly int TimeInIntensityZone1 = timeInIntensityZone1;
		public readonly int TimeInIntensityZone2 = timeInIntensityZone2;
		public readonly int TimeInIntensityZone3 = timeInIntensityZone3;
		public readonly int TimeInIntensityZone4 = timeInIntensityZone4;
		public readonly int TimeAboveIntensityZones = timeAboveIntensityZones;
		public readonly int NormalizedPower = normalizedPower;
		public readonly float RightBalance = rightBalance;
		public readonly float LeftBalance = leftBalance;
		public readonly int TimeInPowerZone1 = timeInPowerZone1;
		public readonly int TimeInPowerZone2 = timeInPowerZone2;
		public readonly int TimeInPowerZone3 = timeInPowerZone3;
		public readonly int TimeInPowerZone4 = timeInPowerZone4;
		public readonly int TimeInPowerZone5 = timeInPowerZone5;
		public readonly int TimeInPowerZone6 = timeInPowerZone6;
		public readonly int TimeInPowerZone7 = timeInPowerZone7;
		public readonly int PedalingTime = pedalingTime;
		public readonly bool UseForChart = useForChart;
		public readonly bool UseForTrack = useForTrack;
		public readonly int SpeedTime = speedTime;
	}
}
