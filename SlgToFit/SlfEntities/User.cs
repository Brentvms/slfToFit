namespace SlfToFit.SlfEntities
{
	internal class User(int color, string gender, string type)
	{
		public readonly int Color = color;			// Color code of user?
		public readonly string Gender = gender;		// Gender of user
		public readonly string Type = type;			// User type
	}
}
