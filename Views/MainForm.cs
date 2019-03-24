using Adddate.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Adddate.Views
{
	public partial class MainForm : Form
	{
      private readonly List<string> extensions = new List<string>()
         { ".jpg", ".png", ".jpeg", ".JPG", ".PNG", ".JPEG" };
      private string directory = String.Empty;
      private List<FileInfo> files = new List<FileInfo>();
      private Color color = Color.Gray;
      private Corner corner = Corner.TopLeft;
		
		public MainForm()
		{
			InitializeComponent();
         SetTexts();
      }
		
		void DirButtonClick(object sender, EventArgs e)
		{
			dirBrowserDialog.ShowDialog();
			directory = dirBrowserDialog.SelectedPath;
			if(directory != String.Empty)
         {
				dirLabel.Text = Strings.Strings.SelectedDir + directory;
				addDateButton.Enabled = true;
				
				files = new List<FileInfo>();
				DirectoryInfo dir = new DirectoryInfo(directory);
				long bytes = 0;
				int i = 0;
				foreach(FileInfo file in dir.GetFiles())
            {
					if(extensions.Contains(file.Extension))
               {
						files.Add(file);
						bytes += file.Length;
						i++;
					}
				}

				imageCountLabel.Text = Strings.Strings.FilesToProcess + i.ToString();
				imageSizeLabel.Text = Strings.Strings.MbToProcess + (bytes/(double)1000000).ToString("#.##");
			}
		}
		
		void AddDateButtonClick(object sender, EventArgs e)
		{	
			dirButton.Enabled = false;
			addDateButton.Enabled = false;
			optionsButton.Enabled = false;
			progressBar.Value = 0;
			progressBar.Minimum = 0;
			progressBar.Maximum = files.Count;
			
			Bitmap bmap = null;
			Graphics gfx = null;
			Font font = null;
			SolidBrush brush = new SolidBrush(color);
			string tmp = String.Empty;
         string lastWriteTime = String.Empty;
			
			Stopwatch swatch = Stopwatch.StartNew();
			for(int i = 0; i < files.Count; i++)
         {
				bmap = (Bitmap) Bitmap.FromFile(files[i].FullName);
				gfx = Graphics.FromImage(bmap);
				font = new Font("Arial", bmap.Width/50, FontStyle.Regular, GraphicsUnit.Pixel);
				tmp = files[i].Name.Substring(0, files[i].Name.IndexOf("."));
            lastWriteTime = files[i].LastWriteTime.ToString();

            if (corner == Corner.TopLeft)
					gfx.DrawString(lastWriteTime, font, brush, 20, 20);
				if(corner == Corner.TopRight)
					gfx.DrawString(lastWriteTime, font, brush, bmap.Width*(float)0.8, 20);
				if(corner == Corner.BottomLeft)
					gfx.DrawString(lastWriteTime, font, brush, 20, bmap.Height*(float)0.95);
				if(corner == Corner.BottomRight)
					gfx.DrawString(lastWriteTime, font, brush, bmap.Width*(float)0.8, bmap.Height*(float)0.95);
								
				bmap.Save(files[i].DirectoryName + "\\" + tmp + "_2" + files[i].Extension);
				gfx.Dispose();
            bmap.Dispose();
				progressBar.Value = i+1;
			}
			swatch.Stop();
			
			dirButton.Enabled = true;
			addDateButton.Enabled = true;
			optionsButton.Enabled = true;
			timeLabel.Text = Strings.Strings.ProcessingTime + (swatch.ElapsedMilliseconds/(float)1000).ToString("0.##") + "s";
		}
		
		void OptionsButtonClick(object sender, EventArgs e)
		{
			Options options = new Options(color, corner);
			if(options.ShowDialog() == DialogResult.OK)
         {
				this.color = options.Color;
				this.corner = options.Corner;
			}
		}

      void SetTexts()
      {
         dirButton.Text = Strings.Strings.SelectDir;
         addDateButton.Text = Strings.Strings.AddDate;
         optionsButton.Text = Strings.Strings.Options;
      }
	}
}