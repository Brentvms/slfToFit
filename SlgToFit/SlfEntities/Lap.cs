namespace SlfToFit.SlfEntities
{
	public class Lap(
		int altitudeDownhill,
		int altitudeUphill,
		int averageAltitude,
		byte averageCadence,
		byte averageHeartrate,
		float averageInclineDownhill,
		float averageInclineUphill,
		ushort averagePower,
		float averageSpeed,
		ushort calories,
		string description,
		float distance,
		float distanceAbsolute,
		int duration,
		bool fastLap,
		float latitude,
		float longitude,
		int maximumAltitude,
		byte maximumCadence,
		byte maximumHeartrate,
		float maximumInclineDownhill,
		float maximumInclineUphill,
		ushort maximumPower,
		float maximumSpeed,
		byte minimumHeartrate,
		float minimumSpeed,
		int number,
		int time,
		int timeAbsolute,
		string title,
		string type,
		ushort normalizedPower,
		float averageBalance,
		int pedalingTime,
		float leftTorqueEffectivity,
		float rightTorqueEffectivity,
		float leftPedalingSmoothness,
		float rightPedalingSmoothness) : Marker(altitudeDownhill, altitudeUphill, averageAltitude, averageCadence, averageHeartrate, averageInclineDownhill, averageInclineUphill, averagePower, averageSpeed, calories, description, distance, distanceAbsolute, duration, fastLap, latitude, longitude, maximumAltitude, maximumCadence, maximumHeartrate, maximumInclineDownhill, maximumInclineUphill, maximumPower, maximumSpeed, minimumHeartrate, minimumSpeed, number, time, timeAbsolute, title, type, normalizedPower, averageBalance, pedalingTime, leftTorqueEffectivity, rightTorqueEffectivity, leftPedalingSmoothness, rightPedalingSmoothness)
	{
		public override float RelativeStartingTime { get { return TimeAbsolute - Time; } }

		public override float RelvativeEndingTime { get { return TimeAbsolute; } }

		public override float Duration { get { return Time; } }
	}
}
