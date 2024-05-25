using SlfToFit.SlfEntities;

namespace SlfToFit
{
	internal class Slf(DateTime fileDate, int revision, Computer computer, GeneralInformation generalInformation, Entry[] entries, Marker[] markers)
	{
		public readonly DateTime FileDate = fileDate;
		public readonly int Revision = revision;
		public readonly Computer Computer = computer;
		public readonly GeneralInformation GeneralInformation = generalInformation;
		public readonly Entry[] Entries = entries;
		public readonly Marker[] Markers = markers;
	}
}
