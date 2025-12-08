using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for TemplateSampleControl.
	/// </summary>
	public class CustomDrawnTitles : UserControl
	{
		private Label labelSampleComment;
		private Panel panel1;
		private Chart Chart1;
		private Label label1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public CustomDrawnTitles()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

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
			DataPoint dataPoint1 = new DataPoint(1, 70);
			DataPoint dataPoint2 = new DataPoint(2, 80);
			DataPoint dataPoint3 = new DataPoint(3, 70);
			DataPoint dataPoint4 = new DataPoint(4, 88);
			Series series2 = new Series();
			DataPoint dataPoint5 = new DataPoint(1, 65);
			DataPoint dataPoint6 = new DataPoint(2, 70);
			DataPoint dataPoint7 = new DataPoint(3, 60);
			DataPoint dataPoint8 = new DataPoint(4, 75);
			Series series3 = new Series();
			DataPoint dataPoint9 = new DataPoint(1, 50);
			DataPoint dataPoint10 = new DataPoint(2, 55);
			DataPoint dataPoint11 = new DataPoint(3, 40);
			DataPoint dataPoint12 = new DataPoint(4, 70);
			Title title1 = new Title();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(CustomDrawnTitles));
            Chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            label1 = new Label();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
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
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 5;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 75F;
            chartArea1.Position.Width = 90F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 13F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5F;
            legend1.Position.Width = 40F;
            legend1.Position.X = 5F;
            legend1.Position.Y = 85F;
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.CustomProperties = "DrawingStyle=Cylinder";
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint9);
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 0;
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.Position.Auto = false;
            title1.Position.Height = 8.738057F;
            title1.Position.Width = 55F;
            title1.Position.X = 4F;
            title1.Position.Y = 4F;
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Draw an Image";
            Chart1.Titles.Add(title1);
            Chart1.PostPaint += new EventHandler<ChartPaintEventArgs>(Chart1_PostPaint);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F);
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 34);
            labelSampleComment.TabIndex = 2;
            labelSampleComment.Text = "This sample demonstrates how to draw an image on the chart.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 11F);
            label1.Location = new Point(16, 360);
            label1.Name = "label1";
            label1.Size = new Size(702, 56);
            label1.TabIndex = 3;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomDrawnTitles
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(Chart1);
            Font = new Font("Verdana", 9F);
            Name = "CustomDrawnTitles";
            Size = new Size(728, 448);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void Chart1_PostPaint(object sender, ChartPaintEventArgs e)
		{
			// Painting series object
			if(e.ChartElement is Series)
			{
				// Add custom painting only to the series with name "Sereis2"
				Series	series = (Series)e.ChartElement;
				if(series.Name == "Series2")
				{
					// Find data point with maximum Y value
					DataPoint	dataPoint = series.Points.FindMaxByValue();
					
					// Image path
					MainForm mainForm = (MainForm)ParentForm;
                    string fileNameString = mainForm.applicationPath + "\\Images\\money.png";

					// Load bitmap from file 
					Image bitmap = Bitmap.FromFile(fileNameString);

					// Set Red color as transparent
					ImageAttributes attrib = new ImageAttributes();
					attrib.SetColorKey(Color.Red, Color.Red, ColorAdjustType.Default);

					// Calculates marker position depending on the data point X and Y values
					RectangleF	imagePosition = RectangleF.Empty;
					imagePosition.X = (float)e.ChartGraphics.GetPositionFromAxis(
						"Default", AxisName.X, dataPoint.XValue);
					imagePosition.Y = (float)e.ChartGraphics.GetPositionFromAxis(
						"Default", AxisName.Y, dataPoint.YValues[0]);
					imagePosition = e.ChartGraphics.GetAbsoluteRectangle(imagePosition);
					imagePosition.Width = bitmap.Width;
					imagePosition.Height = bitmap.Height;
					imagePosition.Y -= bitmap.Height;
					imagePosition.X -= bitmap.Width /2;

					// Draw image
					e.ChartGraphics.Graphics.DrawImage(bitmap, 
						Rectangle.Round(imagePosition),
						0, 0, bitmap.Width, bitmap.Height,
						GraphicsUnit.Pixel, 
						attrib);

					// Dispose image object
					bitmap.Dispose();
				}
			}
		}


	}
}
