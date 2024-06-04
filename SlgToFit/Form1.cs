namespace SlfToFit
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BrowseButton_Click(object sender, EventArgs e)
		{
			if (inputFileDialog.ShowDialog() == DialogResult.OK)
			{
				inputFilePathTextBox.Text = inputFileDialog.FileName;
			}
		}
	}
}
