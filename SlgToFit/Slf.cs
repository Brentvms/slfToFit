using SlfToFit.SlfEntities;

namespace SlfToFit
{
	public class Slf(DateTime fileDate, int revision, Computer computer, GeneralInformation generalInformation, Entry[] entries, Marker[] markers)
	{
		public readonly DateTime FileDate = fileDate;                                   // Date on which the file was exported
		public readonly int Revision = revision;                                        // ??
		public readonly Computer Computer = computer;                                   // Computer entry
		public readonly GeneralInformation GeneralInformation = generalInformation;     // General information entry
		public readonly Entry[] Entries = entries;                                      // All record entries
		public readonly Marker[] Markers = markers;                                     // Markers for (only?) laps
		public ushort NumLaps { get { return (ushort) Markers.Count(marker => marker.Type == "l"); } }
	}
}
