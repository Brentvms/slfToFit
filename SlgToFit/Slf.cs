using SlfToFit.SlfEntities;

namespace SlfToFit
{
	public class Slf(DateTime fileDate, int revision, Computer computer, GeneralInformation generalInformation, Entry[] entries, Marker[] markers)
	{
		public readonly DateTime FileDate = fileDate;											// Date on which the file was exported
		public readonly int Revision = revision;												// ??
		public readonly Computer Computer = computer;											// Computer entry
		public readonly GeneralInformation GeneralInformation = generalInformation;				// General information entry
		public readonly Entry[] Entries = entries;												// All record entries
		public readonly Marker[] Markers = markers;												// Markers for laps and pauses
		public readonly Marker[] Laps = markers.Where(marker => marker.Type == "l").ToArray();	// Lap markers 
		public readonly Marker[] Pauses = markers.Where(marker => marker.Type == "p").ToArray();// Pause markers

		public float GetLapTimePaused(Marker lap)
		{
			float lower = lap.RelativeStartingTime;
			float upper = lap.TimeAbsolute;
			Marker[] pausesInLap = Pauses.Where(pause => pause.TimeAbsolute - pause.Duration >= lower || pause.TimeAbsolute <= upper).ToArray();
			return pausesInLap.Aggregate(0f, (acc, marker) =>
			{
				if (marker.RelativeStartingTime < lower)
				{
					return acc + marker.TimeAbsolute - lower;
				}
				if (marker.TimeAbsolute > upper)
				{
					return acc + upper - (marker.TimeAbsolute - marker.Duration);
				}
				return acc + marker.Duration;
			});
		}
	}
}
