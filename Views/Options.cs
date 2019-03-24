using Adddate.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Adddate.Views
{
	public partial class Options : Form
	{
		public Color Color { get; private set; }		
		public Corner Corner { get; private set; }
		
		public Options(Color color, Corner corner)
		{
			InitializeComponent();
         SetTexts();
         this.Color = color;
			this.Corner = corner;
			whereToComboBox.SelectedIndex = (int)corner;
			colorLabel.BackColor = color;
		}
		
		void OkButtonClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		
		void ColorButtonClick(object sender, EventArgs e)
		{
			colorDialog.ShowDialog();
			Color = colorDialog.Color;
			colorLabel.BackColor = Color;
		}
		
		void WhereToComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			Corner = (Corner)whereToComboBox.SelectedIndex;
		}
		
		void ColorLabelClick(object sender, EventArgs e)
		{
			colorDialog.ShowDialog();
			Color = colorDialog.Color;
			colorLabel.BackColor = Color;
		}

      void SetTexts()
      {
         whereToPutDateLabel.Text = Strings.Strings.WhereToPutDate;
         colorButton.Text = Strings.Strings.SelectColor;
         okButton.Text = Strings.Strings.ConfirmChoice;
      }
   }
}