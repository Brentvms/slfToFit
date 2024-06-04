namespace SlfToFit
{
	public class FileDecodeEncode
	{
		private string? _inputFilePath;
		public string? FileName { get; private set; }
		private string? _outputFilePath;

		public void SetInputFile(string inputFileStream, string fileName)
		{
			_inputFilePath = inputFileStream;
			FileName = Path.GetFileNameWithoutExtension(fileName);
		}

		public void SetOutputFile(string outputFilePath)
		{
			_outputFilePath = outputFilePath;
		}

		public void RunDecodeEncode()
		{
			if (_inputFilePath == null || _outputFilePath == null)
			{
				Console.Error.WriteLine("Not all values are initialized yet");
				return;
			}

			Slf? slf = SlfParser.ParseSlf(_inputFilePath);
			if (slf == null)
			{
				Console.Error.WriteLine("Parsing slf failed.");
				return;
			}
			SlfToFitEncoder.Encode(slf, _outputFilePath);
		}
	}
}
