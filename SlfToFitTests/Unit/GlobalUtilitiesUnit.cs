using SlfToFit;

namespace SlfToFitTests.Unit
{
	public class GlobalUtilitiesUnit
	{

		#region SlgDateToDateTime
		[Theory]
		[InlineData("Sat Apr 6 13:08:26 GMT+0200 2024", 1712401706000)]
		[InlineData("Sat May 25 11:07:52 GMT+0200 2024", 1716628072000)]
		[InlineData("Thu Jan 1 00:00:00 GMT+0000 1970", 0)]
		public void SlgDateToDateTime_CorrectDateString_ReturnsDateTime(string dateString, long timeStamp)
		{
			// Arrange
			DateTime unixEpoch = DateTime.UnixEpoch;
			DateTime expectedDateTime = unixEpoch.AddMilliseconds(timeStamp);

			// Act
			DateTime actualDateTime = GlobalUtilities.SlgDateToDateTime(dateString);
			DateTime actualDateTimeUTC = actualDateTime.ToUniversalTime();

			// Assert
			Assert.StrictEqual(expectedDateTime, actualDateTimeUTC);
		}

		[Theory]
		[InlineData("")]
		[InlineData("asl;dkjf")]
		[InlineData("Thu Jan 1 00:00:00 GMT 1970")]
		public void SlgDateToDateTime_WrongDateString_ThrowsError(string dateString)
		{
			// Arrange

			// Act
			void act() => GlobalUtilities.SlgDateToDateTime(dateString);

			// Assert
			Assert.Throws<FormatException>(act);
		}
		#endregion
	}
}
