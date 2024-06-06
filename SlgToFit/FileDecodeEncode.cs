namespace SlfToFit
{
	public class FileDecodeEncode(LoggingService loggingService)
	{
		private string? _inputFilePath;
		public string? FileName { get; private set; }
		private string? _outputFilePath;
		private LoggingService _loggingService = loggingService;

		public void SetInputFile(string inputFileStream, string fileName)
		{
			_inputFilePath = inputFileStream;
			FileName = Path.GetFileNameWithoutExtension(fileName);
		}

		public void SetOutputFile(string outputFilePath)
		{
			_outputFilePath = outputFilePath;
		}

		public bool RunDecodeEncode()
		{
			if (_inputFilePath == null || _outputFilePath == null)
			{
				_loggingService.WriteErrorLine("Not all paths are initialized yet");
				return false;
			}

			Slf? slf = SlfParser.ParseSlf(_inputFilePath, _loggingService);
			if (slf == null)
			{
				_loggingService.WriteErrorLine("Parsing slf failed.");
				return false;
			}
			SlfToFitEncoder.Encode(slf, _outputFilePath, _loggingService);
			return true;
		}
	}
}
