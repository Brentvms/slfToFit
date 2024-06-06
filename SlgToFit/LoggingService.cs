namespace SlfToFit
{
	public class LoggingService(RichTextBox outputTextBox)
	{
		private readonly RichTextBox _outputTextBox = outputTextBox;

		public void WriteInfoLine(string text)
		{
			AppendTextOutput(text, null);
		}

		public void WriteErrorLine(string text)
		{
			AppendTextOutput(text, Color.Red);
		}

		public void WriteErrorLine(Exception exception)
		{
			WriteInfoLine(exception.ToString());
		}

		private void AppendTextOutput(string text, Color? color)
		{
			if (_outputTextBox.InvokeRequired)
			{
				_outputTextBox.Invoke(new Action(() => AppendTextOutput(text, color)));
			}
			else
			{
				_outputTextBox.SelectionStart = _outputTextBox.TextLength;
				_outputTextBox.SelectionLength = 0;
				if (color != null)
				{
					_outputTextBox.SelectionColor = color.Value;
				}
				_outputTextBox.AppendText(text + '\n');
				_outputTextBox.SelectionColor = _outputTextBox.ForeColor;
			}
		}
	}
}
