namespace SlfToFit
{
	public class FileDecodeEncode
	{
		private FileStream? _inputFileStream;
		public string? FileName { get; private set; }
		private FileStream? _outputFileStream;

		public void SetInputFile(FileStream inputFileStream, string fileName)
		{
			_inputFileStream = inputFileStream;
			FileName = fileName;
		}

		public void SetOutputFile(FileStream outputFileStream)
		{
			_outputFileStream = outputFileStream;
		}

		public void RunDecodeEncode()
		{
			if (_inputFileStream == null || _outputFileStream == null)
			{
				Console.Error.WriteLine("Not all values are initialized yet");
				return;
			}

			Slf? slf = SlfParser.ParseSlf(_inputFileStream);
			if (slf == null)
			{
				Console.Error.WriteLine("Parsing slf failed.");
				return;
			}
			SlfToFitEncoder encoder = new SlfToFitEncoder();
			encoder.Encode(slf, _outputFileStream);
		}
	}
}
