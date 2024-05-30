using SlfToFit;

namespace SlfToFitTests.Integration
{
	public class SlfParserIntegration
	{

		#region ParseSlf
		[Theory]
		[InlineData("C:\\Users\\kriek\\source\\repos\\VincentKriek\\slgToFit\\Activities\\2024_04_06__13_08.slf")]
		[InlineData("C:\\Users\\kriek\\source\\repos\\VincentKriek\\slgToFit\\Activities\\2024_05_22__14_49.slf")]
		public void ParseSlf_CorrectFilePath_ReturnsSlf(string filePath)
		{
			// Arrange

			// Act
			Exception exception = Record.Exception(() => SlfParser.ParseSlf(filePath));

			// Assert
			Assert.Null(exception);
		}

		[Fact]
		public void ParseSlf_NoFilePath_ReturnsNull()
		{
			// Arrange
			string filePath = "";

			// Act
			Slf? result = SlfParser.ParseSlf(filePath);

			// Assert
			Assert.Null(result);
		}

		#endregion
	}
}
