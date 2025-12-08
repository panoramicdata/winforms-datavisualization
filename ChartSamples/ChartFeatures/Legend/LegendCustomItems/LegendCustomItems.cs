using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for Borders.
	/// </summary>
	public class LegendCustomItems : UserControl
	{
		private Label label9;
		private Chart Chart1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public LegendCustomItems()
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
			DataPoint dataPoint1 = new DataPoint(0, 600);
			DataPoint dataPoint2 = new DataPoint(0, 400);
			DataPoint dataPoint3 = new DataPoint(0, 200);
			DataPoint dataPoint4 = new DataPoint(0, 560);
			DataPoint dataPoint5 = new DataPoint(0, 300);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 550);
			DataPoint dataPoint7 = new DataPoint(0, 580);
			DataPoint dataPoint8 = new DataPoint(0, 300);
			DataPoint dataPoint9 = new DataPoint(0, 425);
			DataPoint dataPoint10 = new DataPoint(0, 400);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 500);
			DataPoint dataPoint12 = new DataPoint(0, 500);
			DataPoint dataPoint13 = new DataPoint(0, 350);
			DataPoint dataPoint14 = new DataPoint(0, 300);
			DataPoint dataPoint15 = new DataPoint(0, 520);
			Title title1 = new Title();
            label9 = new Label();
            Chart1 = new Chart();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 43);
            label9.TabIndex = 2;
            label9.Text = "This sample demonstrates how to add custom items to the legend. These legend item" +
                "s can be a strip line, custom image, or any custom drawn item.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
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
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 60);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.CustomProperties = "DrawingStyle=Wedge";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "Default";
            series2.CustomProperties = "DrawingStyle=Wedge";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series3.ChartArea = "Default";
            series3.CustomProperties = "DrawingStyle=Wedge";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 0;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Custom Legend Items";
            Chart1.Titles.Add(title1);
            // 
            // LegendCustomItems
            // 
            Controls.Add(Chart1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "LegendCustomItems";
            Size = new Size(800, 480);
            Load += new EventHandler(LegendCustomItems_Load);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void LegendCustomItems_Load(object sender, EventArgs e)
		{
			// Disable legend item for the first series
			Chart1.Series[0].IsVisibleInLegend = false;

			// Add simple custom legend item
			Chart1.Legends["Default"].CustomItems.Add(Color.FromArgb(32, 120,147,190), "Critical Values");

			// Add custom legend item with line style
			LegendItem legendItem = new LegendItem();
			legendItem.Name = "Line Style Item";
			legendItem.ImageStyle = LegendImageStyle.Line;
			legendItem.ShadowOffset = 1;
			legendItem.Color = Color.LightBlue;
			legendItem.MarkerStyle = MarkerStyle.Circle;
			Chart1.Legends["Default"].CustomItems.Add(legendItem);

			// Add custom legend item with marker style
			legendItem = new LegendItem();
			legendItem.Name = "Marker Style Item";
			legendItem.ImageStyle = LegendImageStyle.Marker;
			legendItem.ShadowOffset = 1;
			legendItem.Color = Color.Yellow;
			legendItem.MarkerStyle = MarkerStyle.Cross;
			legendItem.MarkerSize = 10;
			legendItem.MarkerBorderColor = Color.Black;
			Chart1.Legends["Default"].CustomItems.Add(legendItem);

            // Add custom legend item with image
            MainForm mainForm = (MainForm)ParentForm;
            string imageFileName = mainForm.CurrentSamplePath;
			imageFileName += "\\Flag.gif";

			legendItem = new LegendItem();
			legendItem.Name = "Image Style Item";
			legendItem.Image = imageFileName;
			legendItem.BackImageTransparentColor = Color.White;
			Chart1.Legends["Default"].CustomItems.Add(legendItem);

			// Add a strip line
			StripLine stripLine = new StripLine();
			stripLine.BackColor = Chart1.Legends["Default"].CustomItems[0].Color;
			stripLine.IntervalOffset = 500;
			stripLine.StripWidth = 300;
			Chart1.ChartAreas["Default"].AxisY.StripLines.Add(stripLine);

		}
	}
}
