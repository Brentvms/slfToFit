namespace SlfToFit
{
	public partial class Main_GUI : Form
	{
		private FileDecodeEncode _fileDecodeEncode;
		private LoggingService _loggingService;
		public Main_GUI()
		{
			InitializeComponent();
			_loggingService = new(outputTextBox);
			_fileDecodeEncode = new(_loggingService);
		}

		private void BrowseInputButton_Click(object sender, EventArgs e)
		{
			if (inputFileDialog.ShowDialog() == DialogResult.OK)
			{
				inputFilePathTextBox.Text = inputFileDialog.FileName;
				_fileDecodeEncode.SetInputFile(inputFileDialog.FileName, inputFileDialog.SafeFileName);
			}
			else
			{
				_loggingService.WriteErrorLine("Unable to open file");
			}
		}

		private void BrowseOutputButton_Click(object sender, EventArgs e)
		{
			outputFileDialog.FileName = _fileDecodeEncode.FileName;

			if (outputFileDialog.ShowDialog() == DialogResult.OK)
			{
				outputFilePathTextBox.Text = outputFileDialog.FileName;
				_fileDecodeEncode.SetOutputFile(outputFileDialog.FileName);
			}
			else
			{
				_loggingService.WriteErrorLine("Unable to open file");
			}
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			if (_fileDecodeEncode.RunDecodeEncode())
			{
				_fileDecodeEncode = new(_loggingService);
				_loggingService.WriteInfoLine("You can encode another file, or close the application now.");
			}
		}
	}
}
