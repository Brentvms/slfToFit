namespace SlfToFit
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			InputContainer = new FlowLayoutPanel();
			InputLabel = new Label();
			inputFilePathTextBox = new TextBox();
			browseButton = new Button();
			inputFileDialog = new OpenFileDialog();
			InputContainer.SuspendLayout();
			SuspendLayout();
			// 
			// InputContainer
			// 
			InputContainer.Controls.Add(InputLabel);
			InputContainer.Controls.Add(inputFilePathTextBox);
			InputContainer.Controls.Add(browseButton);
			InputContainer.Location = new Point(12, 12);
			InputContainer.Name = "InputContainer";
			InputContainer.Size = new Size(718, 31);
			InputContainer.TabIndex = 0;
			// 
			// InputLabel
			// 
			InputLabel.AutoSize = true;
			InputLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			InputLabel.Location = new Point(5, 5);
			InputLabel.Margin = new Padding(5);
			InputLabel.Name = "InputLabel";
			InputLabel.Size = new Size(129, 17);
			InputLabel.TabIndex = 1;
			InputLabel.Text = "Input file destination:";
			InputLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// inputFilePathTextBox
			// 
			inputFilePathTextBox.Location = new Point(142, 3);
			inputFilePathTextBox.Name = "inputFilePathTextBox";
			inputFilePathTextBox.PlaceholderText = "System file path";
			inputFilePathTextBox.Size = new Size(483, 23);
			inputFilePathTextBox.TabIndex = 2;
			// 
			// browseButton
			// 
			browseButton.Location = new Point(631, 3);
			browseButton.Name = "browseButton";
			browseButton.Size = new Size(75, 23);
			browseButton.TabIndex = 3;
			browseButton.Text = "Browse";
			browseButton.UseVisualStyleBackColor = true;
			browseButton.Click += BrowseButton_Click;
			// 
			// inputFileDialog
			// 
			inputFileDialog.DefaultExt = "slf";
			inputFileDialog.FileName = "InputFileDialog";
			inputFileDialog.Filter = "Sigma Log Files (*.slf) | *.slf";
			inputFileDialog.InitialDirectory = "C:\\";
			inputFileDialog.Title = "Load Activity";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(InputContainer);
			Name = "Form1";
			Text = "Form1";
			InputContainer.ResumeLayout(false);
			InputContainer.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel InputContainer;
		private Label InputLabel;
		private OpenFileDialog inputFileDialog;
		private TextBox inputFilePathTextBox;
		private Button browseButton;
	}
}
