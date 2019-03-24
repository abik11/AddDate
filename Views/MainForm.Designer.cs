namespace Adddate.Views
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
         this.dirButton = new System.Windows.Forms.Button();
         this.dirLabel = new System.Windows.Forms.Label();
         this.addDateButton = new System.Windows.Forms.Button();
         this.imageCountLabel = new System.Windows.Forms.Label();
         this.dirBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
         this.imageSizeLabel = new System.Windows.Forms.Label();
         this.optionsButton = new System.Windows.Forms.Button();
         this.progressBar = new System.Windows.Forms.ProgressBar();
         this.timeLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // dirButton
         // 
         this.dirButton.Location = new System.Drawing.Point(12, 12);
         this.dirButton.Name = "dirButton";
         this.dirButton.Size = new System.Drawing.Size(93, 23);
         this.dirButton.TabIndex = 0;
         this.dirButton.Text = "Choose dir";
         this.dirButton.UseVisualStyleBackColor = true;
         this.dirButton.Click += new System.EventHandler(this.DirButtonClick);
         // 
         // dirLabel
         // 
         this.dirLabel.Location = new System.Drawing.Point(12, 68);
         this.dirLabel.Name = "dirLabel";
         this.dirLabel.Size = new System.Drawing.Size(290, 53);
         this.dirLabel.TabIndex = 1;
         // 
         // addDateButton
         // 
         this.addDateButton.Enabled = false;
         this.addDateButton.Location = new System.Drawing.Point(111, 12);
         this.addDateButton.Name = "addDateButton";
         this.addDateButton.Size = new System.Drawing.Size(97, 23);
         this.addDateButton.TabIndex = 2;
         this.addDateButton.Text = "Add date";
         this.addDateButton.UseVisualStyleBackColor = true;
         this.addDateButton.Click += new System.EventHandler(this.AddDateButtonClick);
         // 
         // imageCountLabel
         // 
         this.imageCountLabel.Location = new System.Drawing.Point(12, 38);
         this.imageCountLabel.Name = "imageCountLabel";
         this.imageCountLabel.Size = new System.Drawing.Size(290, 15);
         this.imageCountLabel.TabIndex = 3;
         // 
         // imageSizeLabel
         // 
         this.imageSizeLabel.Location = new System.Drawing.Point(12, 53);
         this.imageSizeLabel.Name = "imageSizeLabel";
         this.imageSizeLabel.Size = new System.Drawing.Size(290, 15);
         this.imageSizeLabel.TabIndex = 4;
         // 
         // optionsButton
         // 
         this.optionsButton.Location = new System.Drawing.Point(214, 12);
         this.optionsButton.Name = "optionsButton";
         this.optionsButton.Size = new System.Drawing.Size(99, 23);
         this.optionsButton.TabIndex = 5;
         this.optionsButton.Text = "Options";
         this.optionsButton.UseVisualStyleBackColor = true;
         this.optionsButton.Click += new System.EventHandler(this.OptionsButtonClick);
         // 
         // progressBar
         // 
         this.progressBar.Location = new System.Drawing.Point(12, 124);
         this.progressBar.Name = "progressBar";
         this.progressBar.Size = new System.Drawing.Size(301, 24);
         this.progressBar.TabIndex = 6;
         // 
         // timeLabel
         // 
         this.timeLabel.Location = new System.Drawing.Point(172, 151);
         this.timeLabel.Name = "timeLabel";
         this.timeLabel.Size = new System.Drawing.Size(142, 18);
         this.timeLabel.TabIndex = 8;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(325, 171);
         this.Controls.Add(this.timeLabel);
         this.Controls.Add(this.progressBar);
         this.Controls.Add(this.optionsButton);
         this.Controls.Add(this.imageSizeLabel);
         this.Controls.Add(this.imageCountLabel);
         this.Controls.Add(this.addDateButton);
         this.Controls.Add(this.dirLabel);
         this.Controls.Add(this.dirButton);
         this.MaximizeBox = false;
         this.MaximumSize = new System.Drawing.Size(341, 210);
         this.MinimumSize = new System.Drawing.Size(341, 210);
         this.Name = "MainForm";
         this.ShowIcon = false;
         this.Text = "Adddate 0.2";
         this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button optionsButton;
		private System.Windows.Forms.Label imageSizeLabel;
		private System.Windows.Forms.FolderBrowserDialog dirBrowserDialog;
		private System.Windows.Forms.Label imageCountLabel;
		private System.Windows.Forms.Button addDateButton;
		private System.Windows.Forms.Label dirLabel;
		private System.Windows.Forms.Button dirButton;
	}
}
