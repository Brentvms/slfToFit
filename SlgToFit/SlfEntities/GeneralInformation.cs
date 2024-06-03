using Dynastream.Fit;
using System.Reflection;
using System.Text;

namespace SlfToFit.SlfEntities
{
	public class GeneralInformation(
		User user,
		string sport,
		string gUID,
		int age,
		ushort altitudeDifferencesDownhill,
		ushort altitudeDifferencesUphill,
		int averageAltitude,
		byte averageCadence,
		byte averageHeartrate,
		float averageInclineUphill,
		float averageInclineDownhill,
		ushort averagePower,
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
		ushort calories,
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
		float maximumAltitude,
		byte maximumCadence,
		byte maximumHeartrate,
		float maximumIncline,
		float maximumInclineDownhill,
		float maximumInclineUphill,
		ushort maximumPower,
		float maximumRiseRate,
		float maximumSpeed,
		float maximumTemperature,
		float minimumAltitude,
		int minimumCadence,
		byte minimumHeartrate,
		float minimumIncline,
		int minimumPower,
		float minimumRiseRate,
		float minimumSpeed,
		float minimumTemperature,
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
		System.DateTime startDate,
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
		uint workinKJ,
		float best5KTime,
		float best5KEntry,
		float best20minPower,
		float best20minPowerEntry,
		float powerNP,
		float powerTSS,
		float powerFTP,
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
		Dictionary<string, ulong> sharingInfo)
	{
		public readonly User User = user;                                                   // User that recorded the activity
		public readonly Sport Sport = SportMap(sport);                                      // Type of sport that is recorded
		public readonly SubSport SubSport = SubSportMap(sport);								// Type of subsport that is recorded
		public readonly string GUID = gUID;                                                 // GUID of the activity
		public readonly int Age = age;                                                      // Age of the user
		public readonly ushort AltitudeDifferencesDownhill = altitudeDifferencesDownhill;   // Differences in altitude downhill
		public readonly ushort AltitudeDifferencesUphill = altitudeDifferencesUphill;       // Differences in altitude uphill
		public readonly int AverageAltitude = averageAltitude;                              // Average altitude recorded
		public readonly byte AverageCadence = averageCadence;                               // Average cadence
		public readonly byte AverageHeartrate = averageHeartrate;                           // Average heartrate
		public readonly float AverageInclineUphill = averageInclineUphill;                  // Average incline uphill
		public readonly float AverageInclineDownhill = averageInclineDownhill;              // Average incline downhill
		public readonly ushort AveragePower = averagePower;                                 // Average power
		public readonly float AveratePowerWattPerKG = averatePowerWattPerKG;                // Average power per kilogram
		public readonly float AverageRiseRate = averageRiseRate;                            // Average rise rate
		public readonly float AverageRiseRateUphill = averageRiseRateUphill;                // Average rise rate uphill
		public readonly float AverageRiseRateDownhill = averageRiseRateDownhill;            // Average rise rate downhill
		public readonly float AverageSpeed = averageSpeed;                                  // Average speed
		public readonly float AverageSpeedDownhill = averageSpeedDownhill;                  // Average speed downhill
		public readonly float AverageSpeedUphill = averageSpeedUphill;                      // Average speed uphill
		public readonly sbyte AverageTemperature = (sbyte)averageTemperature;               // Average temperature
		public readonly string Bike = bike;                                                 // Bike used for the activity
		public readonly int BikeWeight = bikeWeight;                                        // Weight of the bike
		public readonly int BodyHeight = bodyHeight;                                        // Height of the user
		public readonly int BodyWeight = bodyWeight;                                        // Weight of the user
		public readonly bool Calibration = calibration;                                     // Indicates if calibration was performed
		public readonly ushort Calories = calories;                                            // Calories burned
		public readonly string DataType = dataType;                                         // Type of data
		public readonly string Description = description;                                   // Description of the activity
		public readonly float Distance = distance;                                          // Total distance covered
		public readonly float DistanceDownhill = distanceDownhill;                          // Distance covered downhill
		public readonly float DistanceUphill = distanceUphill;                              // Distance covered uphill
		public readonly float ExcerciseTime = excerciseTime/100f;                            // Total exercise time
		public readonly string ExternalLink = externalLink;                                 // External link related to the activity
		public readonly int HrMax = hrMax;                                                  // Maximum heart rate
		public readonly int IntensityZone1Start = intensityZone1Start;                      // Start of intensity zone 1
		public readonly int IntensityZone2Start = intensityZone2Start;                      // Start of intensity zone 2
		public readonly int IntensityZone3Start = intensityZone3Start;                      // Start of intensity zone 3
		public readonly int IntensityZone4Start = intensityZone4Start;                      // Start of intensity zone 4
		public readonly int IntensityZone4End = intensityZone4End;                          // End of intensity zone 4
		public readonly float LatitudeEnd = latitudeEnd;                                    // End latitude
		public readonly float LatitudeStart = latitudeStart;                                // Start latitude
		public readonly int LinkedRouteId = linkedRouteId;                                  // ID of the linked route
		public readonly int LogVersion = logVersion;                                        // Version of the log
		public readonly float LongitudeEnd = longitudeEnd;                                  // End longitude
		public readonly float LongitudeStart = longitudeStart;                              // Start longitude
		public readonly float ManualTemperature = manualTemperature;                        // Manually recorded temperature
		public readonly float MaximumAltitude = maximumAltitude;                            // Maximum altitude
		public readonly byte MaximumCadence = maximumCadence;                               // Maximum cadence
		public readonly byte MaximumHeartrate = maximumHeartrate;                           // Maximum heart rate
		public readonly float MaximumIncline = maximumIncline;                              // Maximum incline
		public readonly float MaximumInclineDownhill = maximumInclineDownhill;              // Maximum incline downhill
		public readonly float MaximumInclineUphill = maximumInclineUphill;                  // Maximum incline uphill
		public readonly ushort MaximumPower = maximumPower;                                 // Maximum power
		public readonly float MaximumRiseRate = maximumRiseRate;                            // Maximum rise rate
		public readonly float MaximumSpeed = maximumSpeed;                                  // Maximum speed
		public readonly sbyte MaximumTemperature = (sbyte)maximumTemperature;               // Maximum temperature
		public readonly float MinimumAltitude = minimumAltitude;                            // Minimum altitude
		public readonly int MinimumCadence = minimumCadence;                                // Minimum cadence
		public readonly int MinimumHeartrate = minimumHeartrate;                            // Minimum heart rate
		public readonly float MinimumIncline = minimumIncline;                              // Minimum incline
		public readonly int MinimumPower = minimumPower;                                    // Minimum power
		public readonly float MinimumRiseRate = minimumRiseRate;                            // Minimum rise rate
		public readonly float MinimumSpeed = minimumSpeed;                                  // Minimum speed
		public readonly sbyte MinimumTemperature = (sbyte)minimumTemperature;               // Minimum temperature
		public readonly string Name = name;                                                 // Name of the activity
		public readonly float PauseTime = pauseTime/100f;                                   // Total pause time
		public readonly int PowerZone1Start = powerZone1Start;                              // Start of power zone 1
		public readonly int PowerZone2Start = powerZone2Start;                              // Start of power zone 2
		public readonly int PowerZone3Start = powerZone3Start;                              // Start of power zone 3
		public readonly int PowerZone4Start = powerZone4Start;                              // Start of power zone 4
		public readonly int PowerZone5Start = powerZone5Start;                              // Start of power zone 5
		public readonly int PowerZone6Start = powerZone6Start;                              // Start of power zone 6
		public readonly int PowerZone7Start = powerZone7Start;                              // Start of power zone 7
		public readonly int PowerZone7End = powerZone7End;                                  // End of power zone 7
		public readonly int Rating = rating;                                                // Rating of the activity
		public readonly int Feeling = feeling;                                              // User's feeling during the activity
		public readonly float TrainingTimeDownhill = trainingTimeDownhill/100f;             // Training time downhill
		public readonly float TrainingTimeUphill = trainingTimeUphill/100f;                 // Training time uphill
		public readonly int SamplingRate = samplingRate;                                    // Sampling rate
		public readonly int ShoulderWidth = shoulderWidth;                                  // Shoulder width of the user
		public readonly System.DateTime StartDate = startDate;                              // Start date of the activity
		public readonly bool Statistic = statistic;                                         // Indicates if it's a statistical activity
		public readonly float TimeInIntensityZone1 = timeInIntensityZone1/100f;             // Time in intensity zone 1
		public readonly float TimeInIntensityZone2 = timeInIntensityZone2/100f;             // Time in intensity zone 2
		public readonly float TimeInIntensityZone3 = timeInIntensityZone3/100f;             // Time in intensity zone 3
		public readonly float TimeInIntensityZone4 = timeInIntensityZone4/100f;             // Time in intensity zone 4
		public readonly float TimeInPowerZone1 = timeInPowerZone1/100f;                     // Time in power zone 1
		public readonly float TimeInPowerZone2 = timeInPowerZone2/100f;                     // Time in power zone 2
		public readonly float TimeInPowerZone3 = timeInPowerZone3/100f;                     // Time in power zone 3
		public readonly float TimeInPowerZone4 = timeInPowerZone4/100f;                     // Time in power zone 4
		public readonly float TimeInPowerZone5 = timeInPowerZone5/100f;                     // Time in power zone 5
		public readonly float TimeInPowerZone6 = timeInPowerZone6/100f;                     // Time in power zone 6
		public readonly float TimeInPowerZone7 = timeInPowerZone7/100f;                     // Time in power zone 7
		public readonly float TimeOverIntensityZone = timeOverIntensityZone/100f;           // Time over intensity zone
		public readonly float TimeUnderIntensityZone = timeUnderIntensityZone/100f;         // Time under intensity zone
		public readonly int TrackProfile = trackProfile;                                    // Profile of the track
		public readonly float TrainingTime = trainingTime/100f;                             // Total training time
		public readonly int UnitId = unitId;                                                // Unit ID
		public readonly int Weather = weather;                                              // Weather conditions
		public readonly int WheelSize = wheelSize;                                          // Size of the wheel
		public readonly int Wind = wind;                                                    // Wind conditions
		public readonly uint WorkinJ = workinKJ*1000;                                       // Work in kilojoules
		public readonly float Best5KTime = best5KTime/100f;                                 // Best 5K time
		public readonly float Best5KEntry = best5KEntry;                                    // Entry for best 5K time
		public readonly float Best20minPower = best20minPower;                              // Best 20-minute power
		public readonly float Best20minPowerEntry = best20minPowerEntry;                    // Entry for best 20-minute power
		public readonly ushort PowerNP = (ushort)powerNP;                                   // Normalized power
		public readonly float PowerTSS = powerTSS;                                          // Training stress score
		public readonly ushort PowerFTP = (ushort)powerFTP;                                 // Functional threshold power
		public readonly float PedalingTime = pedalingTime/100f;								// Total pedaling time
		public readonly float PedalingIndex = pedalingIndex;								// Pedaling index
		public readonly ushort AverageBalanceRight = (ushort)averageBalanceRight;           // Average balance - right
		public readonly ushort AverageBalanceLeft = (ushort)averageBalanceLeft;             // Average balance - left
		public readonly float PowerIF = powerIF;                                            // Intensity factor
		public readonly float TorqueEffectLeft = torqueEffectLeft;                          // Torque effect - left
		public readonly float TorqueEffectRight = torqueEffectRight;                        // Torque effect - right
		public readonly float PedalSmoothLeft = pedalSmoothLeft;                            // Pedal smoothness - left
		public readonly float PedalSmoothRight = pedalSmoothRight;                          // Pedal smoothness - right
		public readonly float AverageCadenceCalc = averageCadenceCalc;                      // Calculated average cadence
		public readonly float AveragePowerCalc = averagePowerCalc;                          // Calculated average power
		public readonly string[] ActivityStatus = activityStatus;                           // Status of the activity
		public readonly bool ActivityTrackerDayComplete = activityTrackerDayComplete;       // Indicates if the activity tracker day is complete
		public readonly Dictionary<string, ulong> SharingInfo = sharingInfo;                // Information about sharing

		private static Sport SportMap(string sport)
		{
			return sport switch
			{
				"racing_bycicle" => Sport.Cycling,
				_ => throw new NotImplementedException("Sport is not implemented in mapping")
			};
		}

		private static SubSport SubSportMap(string sport)
		{
			return sport switch
			{
				"racing_bycicle" => SubSport.Road,
				_ => throw new NotImplementedException("Subsport is not implemented in mapping")
			};
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
				if (property.Name == "User")
				{
					builder.Append(User.ToString(indentLevel + 1)).Append("\n");
				}
				else
				{
					builder.Append(indent).Append(property.Name).Append(": ").Append(property.GetValue(this)).Append('\n');
				}
			}
			return builder.ToString().TrimEnd('\n', ' ');
		}

		#endregion
	}
}
