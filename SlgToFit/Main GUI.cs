namespace SlfToFit
{
	public partial class Main_GUI : Form
	{
		private FileDecodeEncode _fileDecodeEncode;
		public Main_GUI()
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
				WriteErrorLine("Unable to open file");
			}
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			_fileDecodeEncode.RunDecodeEncode();
			_fileDecodeEncode = new();
		}

		public void WriteInfoLine(string text)
		{
			AppendTextOutput(text, null);
		}

		public void WriteErrorLine(string text)
		{
			AppendTextOutput(text, Color.Red);
		}

		private void AppendTextOutput(string text, Color? color)
		{
			if (outputTextBox.InvokeRequired)
			{
				outputTextBox.Invoke(new Action(() => AppendTextOutput(text, color)));
			}
			else
			{
				outputTextBox.SelectionStart = outputTextBox.TextLength;
				outputTextBox.SelectionLength = 0;
				if (color != null)
				{
					outputTextBox.SelectionColor = color.Value;
				}
				outputTextBox.AppendText(text + '\n');
				outputTextBox.SelectionColor = outputTextBox.ForeColor;
			}
		}
	}
}
