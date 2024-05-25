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
		public readonly int AltitudeDownhill = altitudeDownhill;                            // Downhill altitude for this lap
		public readonly int AltitudeUphill = altitudeUphill;                                // Uphill altitude for this lap
		public readonly int AverageAltitude = averageAltitude;                              // Average altitude for this lap
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
		public readonly int Duration = duration;                                            // Duration of this lap
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
		public readonly int MinimumSpeed = minimumSpeed;                                    // Minimum speed in this lap
		public readonly int Number = number;                                                // Number of this lap
		public readonly int Time = time;                                                    // Time of this lap
		public readonly int TimeAbsolute = timeAbsolute;                                    // Absolute time of this lap
		public readonly string Title = title;                                               // Title of this lap
		public readonly string Type = type;                                                 // Type of this lap
		public readonly int NormalizedPower = normalizedPower;                              // Normalized power output in this lap
		public readonly float AverageBalance = averageBalance;                              // Average balance in this lap
		public readonly int PedalingTime = pedalingTime;                                    // Total pedaling time in this lap
		public readonly float LeftTorqueEffectivity = leftTorqueEffectivity;                // Left torque effectivity in this lap
		public readonly float RightTorqueEffectivity = rightTorqueEffectivity;              // Right torque effectivity in this lap
		public readonly float LeftPedalingSmoothness = leftPedalingSmoothness;              // Left pedaling smoothness in this lap
		public readonly float RightPedalingSmoothness = rightPedalingSmoothness;            // Right pedaling smoothness in this lap

	}
}
