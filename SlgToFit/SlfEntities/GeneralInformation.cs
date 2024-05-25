using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlfToFit.SlfEntities
{
	internal class GeneralInformation(
		User user,
		string sport,
		string gUID,
		int age,
		int altitudeDifferencesDownhill,
		int altitudeDifferencesUphill,
		int averageAltitude,
		int averageCadence,
		int averageHeartrate,
		float averageInclineUphill,
		float averageInclineDownhill,
		int averagePower,
		float averatePowerWattPerKG,
		float averageRiseRate,
		float averageRiseRateUphill,
		float averageRiseRateDownhill,
		float averageSpeed,
		float averageSpeedDownhill,
		float averageSpeedUphill,
		float averageTemperature,
		string bike,
		int bikeWeight,
		int bodyHeight,
		int bodyWeight,
		bool calibration,
		int calories,
		string dataType,
		string description,
		float distance,
		float distanceDownhill,
		float distanceUphill,
		int excerciseTime,
		string externalLink,
		int hrMax,
		int intensityZone1Start,
		int intensityZone2Start,
		int intensityZone3Start,
		int intensityZone4Start,
		int intensityZone4End,
		float latitudeEnd,
		float latitudeStart,
		int linkedRouteId,
		int logVersion,
		float longitudeEnd,
		float longitudeStart,
		float manualTemperature,
		int maximumAltitude,
		int maximumCadence,
		int maximumHeartrate,
		float maximumIncline,
		float maximumInclineDownhill,
		float maximumInclineUphill,
		int maximumPower,
		float maximumRiseRate,
		float maximumSpeed,
		float maximumTemperature,
		int minimumAltitude,
		int minimumCadence,
		int minimumHeartrate,
		float minimumIncline,
		int minimumPower,
		float minimumRiseRate,
		float minimumSpeed,
		int minimumTemperature,
		string name,
		int pauseTime,
		int powerZone1Start,
		int powerZone2Start,
		int powerZone3Start,
		int powerZone4Start,
		int powerZone5Start,
		int powerZone6Start,
		int powerZone7Start,
		int powerZone7End,
		int rating,
		int feeling,
		int trainingTimeDownhill,
		int trainingTimeUphill,
		int samplingRate,
		int shoulderWidth,
		DateTime startDate,
		bool statistic,
		int timeInIntensityZone1,
		int timeInIntensityZone2,
		int timeInIntensityZone3,
		int timeInIntensityZone4,
		int timeInPowerZone1,
		int timeInPowerZone2,
		int timeInPowerZone3,
		int timeInPowerZone4,
		int timeInPowerZone5,
		int timeInPowerZone6,
		int timeInPowerZone7,
		int timeOverIntensityZone,
		int timeUnderIntensityZone,
		int trackProfile,
		int trainingTime,
		int unitId,
		int weather,
		int wheelSize,
		int wind,
		int workinKJ,
		int best5KTime,
		int best5KEntry,
		int best20minPower,
		int best20minPowerEntry,
		int powerNP,
		int powerTSS,
		int powerFTP,
		int pedalingTime,
		float pedalingIndex,
		float averageBalanceRight,
		float averageBalanceLeft,
		float powerIF,
		float torqueEffectLeft,
		float torqueEffectRight,
		float pedalSmoothLeft,
		float pedalSmoothRight,
		float averageCadenceCalc,
		float averagePowerCalc,
		string[] activityStatus,
		bool activityTrackerDayComplete,
		Dictionary<string, int> sharingInfo)
	{
		public readonly User User = user;
		public readonly string Sport = sport;
		public readonly string GUID = gUID;
		public readonly int Age = age;
		public readonly int AltitudeDifferencesDownhill = altitudeDifferencesDownhill;
		public readonly int AltitudeDifferencesUphill = altitudeDifferencesUphill;
		public readonly int AverageAltitude = averageAltitude;
		public readonly int AverageCadence = averageCadence;
		public readonly int AverageHeartrate = averageHeartrate;
		public readonly float AverageInclineUphill = averageInclineUphill;
		public readonly float AverageInclineDownhill = averageInclineDownhill;
		public readonly int AveragePower = averagePower;
		public readonly float AveratePowerWattPerKG = averatePowerWattPerKG;
		public readonly float AverageRiseRate = averageRiseRate;
		public readonly float AverageRiseRateUphill = averageRiseRateUphill;
		public readonly float AverageRiseRateDownhill = averageRiseRateDownhill;
		public readonly float AverageSpeed = averageSpeed;
		public readonly float AverageSpeedDownhill = averageSpeedDownhill;
		public readonly float AverageSpeedUphill = averageSpeedUphill;
		public readonly float AverageTemperature = averageTemperature;
		public readonly string Bike = bike;
		public readonly int BikeWeight = bikeWeight;
		public readonly int BodyHeight = bodyHeight;
		public readonly int BodyWeight = bodyWeight;
		public readonly bool Calibration = calibration;
		public readonly int Calories = calories;
		public readonly string DataType = dataType;
		public readonly string Description = description;
		public readonly float Distance = distance;
		public readonly float DistanceDownhill = distanceDownhill;
		public readonly float DistanceUphill = distanceUphill;
		public readonly int ExcerciseTime = excerciseTime;
		public readonly string ExternalLink = externalLink;
		public readonly int HrMax = hrMax;
		public readonly int IntensityZone1Start = intensityZone1Start;
		public readonly int IntensityZone2Start = intensityZone2Start;
		public readonly int IntensityZone3Start = intensityZone3Start;
		public readonly int IntensityZone4Start = intensityZone4Start;
		public readonly int IntensityZone4End = intensityZone4End;
		public readonly float LatitudeEnd = latitudeEnd;
		public readonly float LatitudeStart = latitudeStart;
		public readonly int LinkedRouteId = linkedRouteId;
		public readonly int LogVersion = logVersion;
		public readonly float LongitudeEnd = longitudeEnd;
		public readonly float LongitudeStart = longitudeStart;
		public readonly float ManualTemperature = manualTemperature;
		public readonly int MaximumAltitude = maximumAltitude;
		public readonly int MaximumCadence = maximumCadence;
		public readonly int MaximumHeartrate = maximumHeartrate;
		public readonly float MaximumIncline = maximumIncline;
		public readonly float MaximumInclineDownhill = maximumInclineDownhill;
		public readonly float MaximumInclineUphill = maximumInclineUphill;
		public readonly int MaximumPower = maximumPower;
		public readonly float MaximumRiseRate = maximumRiseRate;
		public readonly float MaximumSpeed = maximumSpeed;
		public readonly float MaximumTemperature = maximumTemperature;
		public readonly int MinimumAltitude = minimumAltitude;
		public readonly int MinimumCadence = minimumCadence;
		public readonly int MinimumHeartrate = minimumHeartrate;
		public readonly float MinimumIncline = minimumIncline;
		public readonly int MinimumPower = minimumPower;
		public readonly float MinimumRiseRate = minimumRiseRate;
		public readonly float MinimumSpeed = minimumSpeed;
		public readonly int MinimumTemperature = minimumTemperature;
		public readonly string Name = name;
		public readonly int PauseTime = pauseTime;
		public readonly int PowerZone1Start = powerZone1Start;
		public readonly int PowerZone2Start = powerZone2Start;
		public readonly int PowerZone3Start = powerZone3Start;
		public readonly int PowerZone4Start = powerZone4Start;
		public readonly int PowerZone5Start = powerZone5Start;
		public readonly int PowerZone6Start = powerZone6Start;
		public readonly int PowerZone7Start = powerZone7Start;
		public readonly int PowerZone7End = powerZone7End;
		public readonly int Rating = rating;
		public readonly int Feeling = feeling;
		public readonly int TrainingTimeDownhill = trainingTimeDownhill;
		public readonly int TrainingTimeUphill = trainingTimeUphill;
		public readonly int SamplingRate = samplingRate;
		public readonly int ShoulderWidth = shoulderWidth;
		public readonly DateTime StartDate = startDate;
		public readonly bool Statistic = statistic;
		public readonly int TimeInIntensityZone1 = timeInIntensityZone1;
		public readonly int TimeInIntensityZone2 = timeInIntensityZone2;
		public readonly int TimeInIntensityZone3 = timeInIntensityZone3;
		public readonly int TimeInIntensityZone4 = timeInIntensityZone4;
		public readonly int TimeInPowerZone1 = timeInPowerZone1;
		public readonly int TimeInPowerZone2 = timeInPowerZone2;
		public readonly int TimeInPowerZone3 = timeInPowerZone3;
		public readonly int TimeInPowerZone4 = timeInPowerZone4;
		public readonly int TimeInPowerZone5 = timeInPowerZone5;
		public readonly int TimeInPowerZone6 = timeInPowerZone6;
		public readonly int TimeInPowerZone7 = timeInPowerZone7;
		public readonly int TimeOverIntensityZone = timeOverIntensityZone;
		public readonly int TimeUnderIntensityZone = timeUnderIntensityZone;
		public readonly int TrackProfile = trackProfile;
		public readonly int TrainingTime = trainingTime;
		public readonly int UnitId = unitId;
		public readonly int weather = weather;
		public readonly int WheelSize = wheelSize;
		public readonly int Wind = wind;
		public readonly int WorkinKJ = workinKJ;
		public readonly int Best5KTime = best5KTime;
		public readonly int best5KEntry = best5KEntry;
		public readonly int best20minPower = best20minPower;
		public readonly int best20minPowerEntry = best20minPowerEntry;
		public readonly int PowerNP = powerNP;
		public readonly int PowerTSS = powerTSS;
		public readonly int PowerFTP = powerFTP;
		public readonly int PedalingTime = pedalingTime;
		public readonly float PedalingIndex = pedalingIndex;
		public readonly float AverageBalanceRight = averageBalanceRight;
		public readonly float AverageBalanceLeft = averageBalanceLeft;
		public readonly float PowerIF = powerIF;
		public readonly float TorqueEffectLeft = torqueEffectLeft;
		public readonly float TorqueEffectRight = torqueEffectRight;
		public readonly float PedalSmoothLeft = pedalSmoothLeft;
		public readonly float PedalSmoothRight = pedalSmoothRight;
		public readonly float AverageCadenceCalc = averageCadenceCalc;
		public readonly float AveragePowerCalc = averagePowerCalc;
		public readonly string[] ActivityStatus = activityStatus;
		public readonly bool ActivityTrackerDayComplete = activityTrackerDayComplete;
		public readonly Dictionary<string, int> SharingInfo = sharingInfo;
	}
}
