using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for EmptyPointAppearance.
	/// </summary>
	public class SavingAndCopyingImages : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Button Copy;
		private Button Save;
		private Label label2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public SavingAndCopyingImages()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ChartArea chartArea1 = new ChartArea();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(0, 400);
			DataPoint dataPoint2 = new DataPoint(0, 600);
			DataPoint dataPoint3 = new DataPoint(0, 1700);
			DataPoint dataPoint4 = new DataPoint(0, 1500);
			DataPoint dataPoint5 = new DataPoint(0, 950);
            label9 = new Label();
            panel1 = new Panel();
            Copy = new Button();
            Save = new Button();
            Chart1 = new Chart();
            label2 = new Label();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 37);
            label9.TabIndex = 2;
            label9.Text = "This sample shows how to save a chart as an image, and also demonstrates how to c" +
                "opy a chart image to the clipboard.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(Copy);
            panel1.Controls.Add(Save);
            panel1.Location = new Point(432, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 1;
            // 
            // Copy
            // 
            Copy.BackColor = System.Drawing.SystemColors.Control;
            Copy.Location = new Point(48, 56);
            Copy.Name = "Copy";
            Copy.Size = new Size(112, 23);
            Copy.TabIndex = 16;
            Copy.Text = "&Copy";
            Copy.UseVisualStyleBackColor = false;
            Copy.Click += new EventHandler(Copy_Click);
            // 
            // Save
            // 
            Save.BackColor = System.Drawing.SystemColors.Control;
            Save.Location = new Point(48, 16);
            Save.Name = "Save";
            Save.Size = new Size(112, 23);
            Save.TabIndex = 15;
            Save.Text = "&Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += new EventHandler(Save_Click);
            // 
            // Chart1
            // 
            Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            Chart1.BorderlineWidth = 2;
            Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "#";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 53);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "PieLabelStyle=Outside, PieDrawingStyle=SoftEdge";
            series1.Legend = "Default";
            series1.Name = "Default";
            dataPoint1.LegendText = "USA";
            dataPoint2.LegendText = "Canada";
            dataPoint3.LegendText = "France";
            dataPoint4.LegendText = "Japan";
            dataPoint5.LegendText = "Russia";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 0;
            Chart1.Click += new EventHandler(Chart1_Click);
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(13, 349);
            label2.Name = "label2";
            label2.Size = new Size(702, 48);
            label2.TabIndex = 4;
            label2.Text = "After copying the chart image to the clipboard, try pasting that image into anoth" +
                "er application.";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SavingAndCopyingImages
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label2);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "SavingAndCopyingImages";
            Size = new Size(728, 408);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void EmptyPointAppearance_Load(object sender, EventArgs e)
		{ 
		}
	
		private void button1_Click(object sender, EventArgs e)
		{
			// Create a new save file dialog
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
 
			// Sets the current file name filter string, which determines 
			// the choices that appear in the "Save as file type" or 
			// "Files of type" box in the dialog box.
			saveFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|EMF (*.emf)|*.emf|PNG (*.png)|*.png|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif";
			saveFileDialog1.FilterIndex = 2 ;
			saveFileDialog1.RestoreDirectory = true ;
 
			// Set image file format
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				ChartImageFormat format = ChartImageFormat.Bmp;

				if( saveFileDialog1.FileName.EndsWith( "bmp" ) )
				{
					format = ChartImageFormat.Bmp;
				}
				else if( saveFileDialog1.FileName.EndsWith( "jpg" ) )
				{
					format = ChartImageFormat.Jpeg;
				}
				else if( saveFileDialog1.FileName.EndsWith( "emf" ) )
				{
					format = ChartImageFormat.Emf;
				}
				else if( saveFileDialog1.FileName.EndsWith( "gif" ) )
				{
					format = ChartImageFormat.Gif;
				}
				else if( saveFileDialog1.FileName.EndsWith( "png" ) )
				{
					format = ChartImageFormat.Png;
				}
				else if( saveFileDialog1.FileName.EndsWith( "tif" ) )
				{
					format = ChartImageFormat.Tiff;
				}

				// Save image
				Chart1.SaveImage( saveFileDialog1.FileName, format );
				
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// create a memory stream to save the chart image    
			MemoryStream stream = new MemoryStream();     

			// save the chart image to the stream    
			Chart1.SaveImage(stream,System.Drawing.Imaging.ImageFormat.Bmp);     

			// create a bitmap using the stream    
			Bitmap bmp = new Bitmap(stream);     

			// save the bitmap to the clipboard    
			Clipboard.SetDataObject(bmp); 

		}

		private void Chart1_Click(object sender, EventArgs e)
		{
		
		}

		private void Save_Click(object sender, EventArgs e)
		{
			// Create a new save file dialog
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
 
			// Sets the current file name filter string, which determines 
			// the choices that appear in the "Save as file type" or 
			// "Files of type" box in the dialog box.
			saveFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|EMF-Plus (*.emf)|*.emf|EMF-Dual (*.emf)|*.emf|EMF (*.emf)|*.emf|PNG (*.png)|*.png|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif";
			saveFileDialog1.FilterIndex = 2 ;
			saveFileDialog1.RestoreDirectory = true ;
 
			// Set image file format
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{

				ChartImageFormat format = ChartImageFormat.Bmp;

				if( saveFileDialog1.FileName.EndsWith( "bmp" ) )
				{
					format = ChartImageFormat.Bmp;
				}
				else if( saveFileDialog1.FileName.EndsWith( "jpg" ) )
				{
					format = ChartImageFormat.Jpeg;
				}
				else if( saveFileDialog1.FileName.EndsWith( "emf" ) && saveFileDialog1.FilterIndex == 3)
				{
					format = ChartImageFormat.EmfDual;
				}
				else if( saveFileDialog1.FileName.EndsWith( "emf" ) && saveFileDialog1.FilterIndex == 4 )
				{
					format = ChartImageFormat.EmfPlus;
				}
				else if( saveFileDialog1.FileName.EndsWith( "emf" ) )
				{
					format = ChartImageFormat.Emf;
				}
				else if( saveFileDialog1.FileName.EndsWith( "gif" ) )
				{
					format = ChartImageFormat.Gif;
				}
				else if( saveFileDialog1.FileName.EndsWith( "png" ) )
				{
					format = ChartImageFormat.Png;
				}
				else if( saveFileDialog1.FileName.EndsWith( "tif" ) )
				{
					format = ChartImageFormat.Tiff;
				}

				// Save image
				Chart1.SaveImage( saveFileDialog1.FileName, format );
			}
		}

		private void Copy_Click(object sender, EventArgs e)
		{
			// create a memory stream to save the chart image    
			MemoryStream stream = new MemoryStream();     

			// save the chart image to the stream    
			Chart1.SaveImage(stream,System.Drawing.Imaging.ImageFormat.Bmp);     

			// create a bitmap using the stream    
			Bitmap bmp = new Bitmap(stream);     

			// save the bitmap to the clipboard    
			Clipboard.SetDataObject(bmp); 
		}
	}
}
