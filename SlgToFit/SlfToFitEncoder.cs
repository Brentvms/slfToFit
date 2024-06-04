using Dynastream.Fit;
using SlfToFit.SlfEntities;
using System.Text;

namespace SlfToFit
{
	public static class SlfToFitEncoder
	{

		public static void Encode(Slf slf, string outputPath)
		{
			FileStream? fileStream = null;
			Encode? encoder = null;
			Dynastream.Fit.DateTime timeCreated = new(System.DateTime.Now);
			Dynastream.Fit.DateTime timeStarted = new(slf.GeneralInformation.StartDate);
			Dynastream.Fit.DateTime timeEnded = GlobalUtilities.AddSecondsToDynstreamDateTime(timeStarted, slf.GeneralInformation.ExcerciseTime);
			DeveloperDataIdMesg developerDataIdMesg = CreateDeveloperDataIdMesg();
			Dictionary<string, FieldDescriptionMesg> fieldDescriptionMesgs = CreateDeveloperDataFields();

			// all messages
			FileIdMesg fileIdMesg = CreateFileIdMesg(slf, timeCreated);
			HrZoneMesg[] hrZoneMesgs = CreateHrZoneMesgs(slf);
			PowerZoneMesg[] powerZoneMesgs = CreatePowerZoneMesgs(slf);
			DeviceInfoMesg deviceInfoMesg = CreateDeviceInformationMesg(slf, developerDataIdMesg, fieldDescriptionMesgs);
			ActivityMesg activityMesg = CreateActivityMesg(slf, developerDataIdMesg, fieldDescriptionMesgs);
			SessionMesg sessionMesg = CreateSessionMesg(slf, timeStarted, timeEnded);
			Mesg[] sessionAndEventMesgs = CreateSessionAndEventsMesgs(slf, timeStarted, timeEnded);

			try
			{
				fileStream = new(outputPath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
				encoder = new(ProtocolVersion.V20);
				encoder.Open(fileStream);
				
				// the first message must be FileId
				encoder.Write(fileIdMesg);
				
				// write the developer fields
				WriteDeveloperDataFields(encoder, developerDataIdMesg, fieldDescriptionMesgs);

				// write other general information
				encoder.Write(hrZoneMesgs);
				encoder.Write(powerZoneMesgs);
				encoder.Write(deviceInfoMesg);
				foreach(var mesg in sessionAndEventMesgs)
				{
					encoder.Write(mesg);
				}
				encoder.Write(sessionMesg);
				encoder.Write(activityMesg);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex);
				Console.ReadLine();
			}
			finally
			{
				encoder?.Close();
				fileStream?.Close();
			}
		}

		private static FileIdMesg CreateFileIdMesg(Slf slf, Dynastream.Fit.DateTime timeCreated)
		{
			FileIdMesg fileIdMesg = new();
			fileIdMesg.SetType(Dynastream.Fit.File.Activity);
			fileIdMesg.SetManufacturer(Manufacturer.Sigmasport);
			fileIdMesg.SetProduct(slf.Computer.ProductId);
			fileIdMesg.SetTimeCreated(timeCreated);
			fileIdMesg.SetProductName(slf.Computer.Unit);
			return fileIdMesg;
		}

		private static HrZoneMesg[] CreateHrZoneMesgs(Slf slf)
		{
			(int hrValue, string name)[] values =
				[
					(slf.GeneralInformation.IntensityZone1Start, "IntensityZone1Start"),
					(slf.GeneralInformation.IntensityZone2Start, "IntensityZone2Start"),
					(slf.GeneralInformation.IntensityZone3Start, "IntensityZone3Start"),
					(slf.GeneralInformation.IntensityZone4Start, "IntensityZone4Start"),
					(slf.GeneralInformation.IntensityZone4End, "IntensityZone4End")
				];
			return values.Select(x => CreateHrZoneMesg(x.hrValue, x.name)).ToArray();
		}

		private static HrZoneMesg CreateHrZoneMesg(int hrValue, string name)
		{
			HrZoneMesg hrZoneMesg = new();
			hrZoneMesg.SetHighBpm((byte)hrValue);
			hrZoneMesg.SetName(name);
			return hrZoneMesg;
		}

		private static PowerZoneMesg[] CreatePowerZoneMesgs(Slf slf)
		{
			(int powerValue, string name)[] values =
				[
					(slf.GeneralInformation.PowerZone1Start, "PowerZone1Start"),
					(slf.GeneralInformation.PowerZone2Start, "PowerZone2Start"),
					(slf.GeneralInformation.PowerZone3Start, "PowerZone3Start"),
					(slf.GeneralInformation.PowerZone4Start, "PowerZone4Start"),
					(slf.GeneralInformation.PowerZone5Start, "PowerZone5Start"),
					(slf.GeneralInformation.PowerZone6Start, "PowerZone6Start"),
					(slf.GeneralInformation.PowerZone7Start, "PowerZone7Start"),
					(slf.GeneralInformation.PowerZone7End, "PowerZone7End")
				];
			return values.Select(x => CreatePowerZoneMesg(x.powerValue, x.name)).ToArray();
		}

		private static PowerZoneMesg CreatePowerZoneMesg(int powerValue, string name)
		{
			PowerZoneMesg powerZoneMesg = new();
			powerZoneMesg.SetHighValue((ushort)powerValue);
			powerZoneMesg.SetName(name);
			return powerZoneMesg;
		}

		private static DeveloperDataIdMesg CreateDeveloperDataIdMesg()
		{
			DeveloperDataIdMesg developerIdMesg = new();
			byte[] appId = new Guid("b89b6d22-57bd-4d35-8063-99f06960c596").ToByteArray();
			for (int i = 0; i < appId.Length; i++)
			{
				developerIdMesg.SetApplicationId(i, appId[i]);
			}
			developerIdMesg.SetDeveloperDataIndex(0);
			developerIdMesg.SetApplicationVersion(100);
			return developerIdMesg;
		}
		private static Dictionary<string, FieldDescriptionMesg> CreateDeveloperDataFields()
		{
			Dictionary<string, FieldDescriptionMesg> fieldDescriptionMesgs = [];

			// create guid field
			FieldDescriptionMesg guidFieldDescriptionMesg = new();
			guidFieldDescriptionMesg.SetDeveloperDataIndex(0);
			guidFieldDescriptionMesg.SetFieldDefinitionNumber(0);
			guidFieldDescriptionMesg.SetFitBaseTypeId(FitBaseType.String);
			guidFieldDescriptionMesg.SetFieldName(0, "guid");
			fieldDescriptionMesgs.Add("guid", guidFieldDescriptionMesg);

			// create serial number field
			FieldDescriptionMesg serialNumberFieldDescriptionMesg = new();
			serialNumberFieldDescriptionMesg.SetDeveloperDataIndex(0);
			serialNumberFieldDescriptionMesg.SetFieldDefinitionNumber(1);
			serialNumberFieldDescriptionMesg.SetFitBaseTypeId(FitBaseType.String);
			serialNumberFieldDescriptionMesg.SetFieldName(0, "serialnumber");
			fieldDescriptionMesgs.Add("serialnumber", serialNumberFieldDescriptionMesg);

			return fieldDescriptionMesgs;
		}

		private static void WriteDeveloperDataFields(Encode encoder, DeveloperDataIdMesg developerDataIdMesg, Dictionary<string, FieldDescriptionMesg> fieldDescriptionsMesgs)
		{
			encoder.Write(developerDataIdMesg);
			foreach (var item in fieldDescriptionsMesgs)
			{
				encoder.Write(item.Value);
			}
		}

		private static DeviceInfoMesg CreateDeviceInformationMesg(Slf slf, DeveloperDataIdMesg developerDataIdMesg, Dictionary<string, FieldDescriptionMesg> fieldDescriptionMesgs)
		{
			DeviceInfoMesg devInfoMesg = new();
			devInfoMesg.SetManufacturer(Manufacturer.Sigmasport);
			devInfoMesg.SetProduct(slf.Computer.ProductId);

			// custom serial number field
			DeveloperField serialNumberField = new(fieldDescriptionMesgs["serialnumber"], developerDataIdMesg);
			devInfoMesg.SetDeveloperField(serialNumberField);
			serialNumberField.SetValue(Encoding.UTF8.GetBytes(slf.Computer.Serial));

			return devInfoMesg;
		}

		private static ActivityMesg CreateActivityMesg(Slf slf, DeveloperDataIdMesg developerDataIdMesg, Dictionary<string, FieldDescriptionMesg> fieldDescriptionMesgs)
		{
			ActivityMesg activityMesg = new();
			activityMesg.SetNumSessions(1);
			activityMesg.SetTotalTimerTime(slf.GeneralInformation.TrainingTime);
			activityMesg.SetEvent(Event.Activity);
			activityMesg.SetEventType(EventType.Stop);

			// set guid for activity
			DeveloperField guidField = new(fieldDescriptionMesgs["guid"], developerDataIdMesg);
			activityMesg.SetDeveloperField(guidField);
			guidField.SetValue(Encoding.UTF8.GetBytes(slf.GeneralInformation.GUID));

			return activityMesg;
		}

		private static SessionMesg CreateSessionMesg(Slf slf, Dynastream.Fit.DateTime startTime, Dynastream.Fit.DateTime endTime)
		{
			SessionMesg sessionMesg = new();
			sessionMesg.SetMinHeartRate((byte)slf.GeneralInformation.MinimumHeartrate);
			sessionMesg.SetEventType(EventType.Stop);
			sessionMesg.SetStartTime(startTime);
			sessionMesg.SetSport(slf.GeneralInformation.Sport);
			sessionMesg.SetSubSport(slf.GeneralInformation.SubSport);
			sessionMesg.SetTotalElapsedTime(slf.GeneralInformation.ExcerciseTime);
			sessionMesg.SetTotalTimerTime(slf.GeneralInformation.TrainingTime);
			sessionMesg.SetTotalDistance(slf.GeneralInformation.Distance);
			sessionMesg.SetTotalCalories(slf.GeneralInformation.Calories);
			sessionMesg.SetAvgSpeed(slf.GeneralInformation.AverageSpeed);
			sessionMesg.SetMaxSpeed(slf.GeneralInformation.MaximumSpeed);
			sessionMesg.SetAvgHeartRate(slf.GeneralInformation.AverageHeartrate);
			sessionMesg.SetMaxHeartRate(slf.GeneralInformation.MaximumHeartrate);
			sessionMesg.SetAvgCadence(slf.GeneralInformation.AverageCadence);
			sessionMesg.SetMaxCadence(slf.GeneralInformation.MaximumCadence);
			sessionMesg.SetAvgPower(slf.GeneralInformation.AveragePower);
			sessionMesg.SetMaxPower(slf.GeneralInformation.MaximumPower);
			sessionMesg.SetTotalAscent(slf.GeneralInformation.AltitudeDifferencesUphill);
			sessionMesg.SetTotalDescent(slf.GeneralInformation.AltitudeDifferencesDownhill);
			sessionMesg.SetMinAltitude(slf.GeneralInformation.MinimumAltitude);
			sessionMesg.SetEvent(Event.Session);
			sessionMesg.SetTrigger(SessionTrigger.ActivityEnd);
			sessionMesg.SetNormalizedPower(slf.GeneralInformation.PowerNP);
			sessionMesg.SetTrainingStressScore(slf.GeneralInformation.PowerTSS);
			sessionMesg.SetIntensityFactor(slf.GeneralInformation.PowerIF);
			sessionMesg.SetLeftRightBalance(slf.GeneralInformation.AverageBalanceRight);
			sessionMesg.SetAvgRightTorqueEffectiveness(slf.GeneralInformation.TorqueEffectLeft);
			sessionMesg.SetAvgLeftPedalSmoothness(slf.GeneralInformation.PedalSmoothLeft);
			sessionMesg.SetAvgRightPedalSmoothness(slf.GeneralInformation.PedalSmoothRight);
			sessionMesg.SetThresholdPower(slf.GeneralInformation.PowerFTP);
			sessionMesg.SetTotalWork(slf.GeneralInformation.WorkinJ);
			sessionMesg.SetMaxAltitude(slf.GeneralInformation.MaximumAltitude);
			sessionMesg.SetAvgLeftTorqueEffectiveness(slf.GeneralInformation.TorqueEffectLeft);
			sessionMesg.SetAvgTemperature(slf.GeneralInformation.AverageTemperature);
			sessionMesg.SetMaxTemperature(slf.GeneralInformation.MaximumTemperature);
			sessionMesg.SetTimestamp(endTime);
			sessionMesg.SetNumLaps(slf.NumLaps);
			return sessionMesg;
		}

		private static LapMesg CreateLapMesg(Marker lap, Dynastream.Fit.DateTime startingTime, Slf slf, float timePaused, ushort index)
		{
			LapMesg lapMesg = new();
			lapMesg.SetEvent(Event.Lap);
			lapMesg.SetEventType(EventType.Stop);
			lapMesg.SetStartTime(GlobalUtilities.AddSecondsToDynstreamDateTime(startingTime, lap.RelativeStartingTime + timePaused));
			lapMesg.SetEndPositionLat(lap.IntLatitude);
			lapMesg.SetEndPositionLong(lap.IntLongitude);
			lapMesg.SetTotalElapsedTime(lap.Duration + slf.GetLapTimePaused(lap));
			lapMesg.SetTotalTimerTime(lap.Duration);
			lapMesg.SetTotalDistance(lap.Distance);
			lapMesg.SetTotalCalories(lap.Calories);
			lapMesg.SetAvgSpeed(lap.AverageSpeed);
			lapMesg.SetAvgHeartRate(lap.AverageHeartrate);
			lapMesg.SetAvgCadence(lap.AverageCadence);
			lapMesg.SetAvgPower(lap.AveragePower);
			lapMesg.SetTotalAscent(lap.AltitudeUphill);
			lapMesg.SetTotalDescent(lap.AltitudeDownhill);
			lapMesg.SetLapTrigger(lap.RelvativeEndingTime == slf.GeneralInformation.TrainingTime ? LapTrigger.SessionEnd : LapTrigger.Distance);
			lapMesg.SetTimestamp(GlobalUtilities.AddSecondsToDynstreamDateTime(startingTime, lap.RelvativeEndingTime + timePaused));
			lapMesg.SetSport(slf.GeneralInformation.Sport);
			lapMesg.SetMessageIndex(index);
			return lapMesg;
		}

		private static Mesg[] CreateSessionAndEventsMesgs(Slf slf, Dynastream.Fit.DateTime startingTime, Dynastream.Fit.DateTime endingTime)
		{
			List<Mesg> messages = [];
			int pauseIndex = 0;
			ushort lapIndex = 0;
			float timePaused = 0f;
			float totalCalories = 0f;
			float totalDistance = 0f;

			// Start activity
			EventMesg startEvent = new();
			startEvent.SetEvent(Event.Timer);
			startEvent.SetTimestamp(startingTime);
			startEvent.SetTimerTrigger((byte)TimerTrigger.Manual);
			startEvent.SetEventType(EventType.Start);
			messages.Add(startEvent);

			// Create pause and session messages
			for (int i = 0; i < slf.Entries.Length; i++)
			{
				while (lapIndex < slf.Laps.Length && slf.Laps[lapIndex].RelvativeEndingTime < slf.Entries[i].TrainingTimeAbsolute)
				{
					LapMesg lapMesg = CreateLapMesg(slf.Laps[lapIndex], startingTime, slf, timePaused, lapIndex);
					messages.Add(lapMesg);
					lapIndex++;
				}
				while (pauseIndex < slf.Pauses.Length && slf.Pauses[pauseIndex].RelativeStartingTime < slf.Entries[i].TrainingTimeAbsolute)
				{
					(EventMesg startPause, EventMesg stopPause) = CreatePauseMesg(slf.Pauses[pauseIndex], startingTime, timePaused);
					messages.Add(startPause);
					messages.Add(stopPause);
					timePaused += slf.Pauses[pauseIndex].Duration;
					pauseIndex++;
				}

				totalCalories += slf.Entries[i].Calories;
				totalDistance += slf.Entries[i].Distance;
				messages.Add(CreateRecordMesg(slf.Entries[i], startingTime, timePaused, (ushort)Math.Round(totalCalories), totalDistance));
			}
			// Add last lap mesg
			if (slf.Laps[^1].RelvativeEndingTime == slf.Entries[^1].TrainingTimeAbsolute)
			{
				LapMesg lapMesg = CreateLapMesg(slf.Laps[^1], startingTime, slf, timePaused, lapIndex);
				messages.Add(lapMesg);
			}

			// Stop activity
			EventMesg stopEvent = new();
			stopEvent.SetEvent(Event.Timer);
			stopEvent.SetTimestamp(endingTime);
			stopEvent.SetTimerTrigger((byte)TimerTrigger.Manual);
			stopEvent.SetEventType(EventType.StopAll);
			messages.Add(stopEvent);

			return [.. messages];
		}

		private static (EventMesg, EventMesg) CreatePauseMesg(Marker pauseMarker, Dynastream.Fit.DateTime startingTime, float timePaused)
		{
			EventMesg startPauseMesg = new();
			startPauseMesg.SetEvent(Event.Timer);
			startPauseMesg.SetEventType(EventType.Stop);
			startPauseMesg.SetTimestamp(GlobalUtilities.AddSecondsToDynstreamDateTime(startingTime, timePaused + pauseMarker.RelativeStartingTime));
			startPauseMesg.SetTimerTrigger((byte)TimerTrigger.Manual);

			EventMesg endPauseMesg = new();
			endPauseMesg.SetEvent(Event.Timer);
			endPauseMesg.SetEventType(EventType.Start);
			endPauseMesg.SetTimestamp(GlobalUtilities.AddSecondsToDynstreamDateTime(startingTime, timePaused + pauseMarker.RelvativeEndingTime));
			endPauseMesg.SetTimerTrigger((byte)TimerTrigger.Manual);

			return (startPauseMesg, endPauseMesg);
		}

		private static RecordMesg CreateRecordMesg(Entry entry, Dynastream.Fit.DateTime startingTime, float timePaused, ushort totalCalories, float totalDistance)
		{
			RecordMesg recordMesg = new();
			recordMesg.SetPositionLat(entry.IntLatitude);
			recordMesg.SetPositionLong(entry.IntLongitude);
			recordMesg.SetAltitude(entry.Altitude);
			recordMesg.SetHeartRate(entry.Heartrate);
			recordMesg.SetCadence(entry.Cadence);
			recordMesg.SetDistance(totalDistance);
			recordMesg.SetSpeed(entry.Speed);
			recordMesg.SetPower(entry.Power);
			recordMesg.SetGrade(entry.Incline);
			recordMesg.SetTemperature(entry.Temperature);
			recordMesg.SetCalories(totalCalories);
			recordMesg.SetTimestamp(GlobalUtilities.AddSecondsToDynstreamDateTime(startingTime, entry.TrainingTimeAbsolute + timePaused));
			recordMesg.SetLeftRightBalance(entry.RightBalance);
			recordMesg.SetAltitude(entry.Altitude);
			return recordMesg;
		}
	}
}
