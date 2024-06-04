namespace SlfToFit
{
	public partial class Form1 : Form
	{
		private FileDecodeEncode _fileDecodeEncode;
		public Form1()
		{
			InitializeComponent();
			_fileDecodeEncode = new FileDecodeEncode();
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
				Console.Error.WriteLine("Unable to open file");
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
				Console.Error.WriteLine("Unable to open file");
			}
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			_fileDecodeEncode.RunDecodeEncode();
			_fileDecodeEncode = new();
		}
	}
}
