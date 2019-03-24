namespace Adddate.Views
{
	partial class Options
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
         this.colorButton = new System.Windows.Forms.Button();
         this.whereToPutDateLabel = new System.Windows.Forms.Label();
         this.whereToComboBox = new System.Windows.Forms.ComboBox();
         this.okButton = new System.Windows.Forms.Button();
         this.colorDialog = new System.Windows.Forms.ColorDialog();
         this.colorLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // colorButton
         // 
         this.colorButton.Location = new System.Drawing.Point(12, 33);
         this.colorButton.Name = "colorButton";
         this.colorButton.Size = new System.Drawing.Size(125, 23);
         this.colorButton.TabIndex = 0;
         this.colorButton.Text = "Select color";
         this.colorButton.UseVisualStyleBackColor = true;
         this.colorButton.Click += new System.EventHandler(this.ColorButtonClick);
         // 
         // whereToPutDateLabel
         // 
         this.whereToPutDateLabel.Location = new System.Drawing.Point(12, 9);
         this.whereToPutDateLabel.Name = "whereToPutDateLabel";
         this.whereToPutDateLabel.Size = new System.Drawing.Size(125, 19);
         this.whereToPutDateLabel.TabIndex = 1;
         this.whereToPutDateLabel.Text = "Where to put date:";
         // 
         // whereToComboBox
         // 
         this.whereToComboBox.FormattingEnabled = true;
         this.whereToComboBox.Items.AddRange(new object[] {
            "Lewy górny róg",
            "Prawy górny róg",
            "Lewy dolny róg",
            "Prawy dolny róg"});
         this.whereToComboBox.Location = new System.Drawing.Point(143, 6);
         this.whereToComboBox.Name = "whereToComboBox";
         this.whereToComboBox.Size = new System.Drawing.Size(121, 21);
         this.whereToComboBox.TabIndex = 2;
         this.whereToComboBox.SelectedIndexChanged += new System.EventHandler(this.WhereToComboBoxSelectedIndexChanged);
         // 
         // okButton
         // 
         this.okButton.Location = new System.Drawing.Point(69, 62);
         this.okButton.Name = "okButton";
         this.okButton.Size = new System.Drawing.Size(121, 23);
         this.okButton.TabIndex = 3;
         this.okButton.Text = "Confirm";
         this.okButton.UseVisualStyleBackColor = true;
         this.okButton.Click += new System.EventHandler(this.OkButtonClick);
         // 
         // colorLabel
         // 
         this.colorLabel.Location = new System.Drawing.Point(143, 33);
         this.colorLabel.Name = "colorLabel";
         this.colorLabel.Size = new System.Drawing.Size(121, 23);
         this.colorLabel.TabIndex = 4;
         this.colorLabel.Click += new System.EventHandler(this.ColorLabelClick);
         // 
         // Options
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(275, 88);
         this.Controls.Add(this.colorLabel);
         this.Controls.Add(this.okButton);
         this.Controls.Add(this.whereToComboBox);
         this.Controls.Add(this.whereToPutDateLabel);
         this.Controls.Add(this.colorButton);
         this.MaximizeBox = false;
         this.MaximumSize = new System.Drawing.Size(291, 127);
         this.MinimizeBox = false;
         this.MinimumSize = new System.Drawing.Size(291, 127);
         this.Name = "Options";
         this.Text = "Opcje";
         this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label colorLabel;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.ComboBox whereToComboBox;
		private System.Windows.Forms.Label whereToPutDateLabel;
		private System.Windows.Forms.Button colorButton;
	}
}
