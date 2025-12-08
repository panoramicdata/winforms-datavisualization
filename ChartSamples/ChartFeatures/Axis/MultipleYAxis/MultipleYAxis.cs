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
	/// Summary description for MultipleYAxis.
	/// </summary>
	public class MultipleYAxis : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private CheckBox checkBoxUseMultipleYAxis;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public MultipleYAxis()
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
			Series series2 = new Series();
			Series series3 = new Series();
            label9 = new Label();
            panel1 = new Panel();
            checkBoxUseMultipleYAxis = new CheckBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to display a data series using multiple Y axes. ";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxUseMultipleYAxis);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // checkBoxUseMultipleYAxis
            // 
            checkBoxUseMultipleYAxis.Location = new Point(48, 8);
            checkBoxUseMultipleYAxis.Name = "checkBoxUseMultipleYAxis";
            checkBoxUseMultipleYAxis.Size = new Size(172, 24);
            checkBoxUseMultipleYAxis.TabIndex = 0;
            checkBoxUseMultipleYAxis.Text = "Use Multiple &Y Axis: ";
            checkBoxUseMultipleYAxis.CheckedChanged += new EventHandler(checkBoxUseMultipleYAxis_CheckedChanged);
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
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "MM/dd";
            chartArea1.AxisX.LabelStyle.Interval = 0;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Size = 2F;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Format = "N0";
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.ShadowOffset = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.BorderWidth = 2;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.ShadowOffset = 2;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.BorderWidth = 2;
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series3.ShadowOffset = 2;
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Size = new Size(412, 306);
            Chart1.TabIndex = 1;
            // 
            // MultipleYAxis
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "MultipleYAxis";
            Size = new Size(728, 480);
            Load += new EventHandler(MultipleYAxis_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void checkBoxUseMultipleYAxis_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxUseMultipleYAxis.Checked)
			{
				// Set custom chart area position
				Chart1.ChartAreas["Default"].Position = new ElementPosition(25,10,68,85);
				Chart1.ChartAreas["Default"].InnerPlotPosition = new ElementPosition(10,0,90,90);

				// Create extra Y axis for second and third series
				CreateYAxis(Chart1, Chart1.ChartAreas["Default"], Chart1.Series["Series2"], 13, 8);
				CreateYAxis(Chart1, Chart1.ChartAreas["Default"], Chart1.Series["Series3"], 22, 8);
			}
			else
			{
				// Set default chart areas
				Chart1.Series["Series2"].ChartArea = "Default";
				Chart1.Series["Series3"].ChartArea = "Default";

				// Remove newly created series and chart areas
				while(Chart1.Series.Count > 3)
				{
					Chart1.Series.RemoveAt(3);
				}
				while(Chart1.ChartAreas.Count > 1)
				{
					Chart1.ChartAreas.RemoveAt(1);
				}

				// Set default chart are position to Auto
				Chart1.ChartAreas["Default"].Position.Auto = true;
				Chart1.ChartAreas["Default"].InnerPlotPosition.Auto = true;

			}
		}

		private void MultipleYAxis_Load(object sender, EventArgs e)
		{
			// Populate series with random data of different scale
			Random		random = new Random();
			DateTime	dateX = DateTime.Now.Date;
			for(int pointIndex = 0; pointIndex < 13; pointIndex++)
			{
				Chart1.Series["Series1"].Points.AddXY(dateX, random.Next(5,100));
				Chart1.Series["Series2"].Points.AddXY(dateX, random.Next(8000, 8200));
				Chart1.Series["Series3"].Points.AddXY(dateX, random.Next(1000,3000));
				dateX = dateX.AddDays(1);
			}
			checkBoxUseMultipleYAxis.Checked = true;
		}

		/// <summary>
		/// Creates Y axis for the specified series.
		/// </summary>
		/// <param name="chart">Chart control.</param>
		/// <param name="area">Original chart area.</param>
		/// <param name="series">Series.</param>
		/// <param name="axisOffset">New Y axis offset in relative coordinates.</param>
		/// <param name="labelsSize">Extar space for new Y axis labels in relative coordinates.</param>
		public void CreateYAxis(Chart chart, ChartArea area, Series series, float axisOffset, float labelsSize)
		{
			// Create new chart area for original series
			ChartArea areaSeries = chart.ChartAreas.Add("ChartArea_" + series.Name);
			areaSeries.BackColor = Color.Transparent;
			areaSeries.BorderColor = Color.Transparent;
			areaSeries.Position.FromRectangleF(area.Position.ToRectangleF());
			areaSeries.InnerPlotPosition.FromRectangleF(area.InnerPlotPosition.ToRectangleF());
			areaSeries.AxisX.MajorGrid.Enabled = false;
			areaSeries.AxisX.MajorTickMark.Enabled = false;
			areaSeries.AxisX.LabelStyle.Enabled = false;
			areaSeries.AxisY.MajorGrid.Enabled = false;
			areaSeries.AxisY.MajorTickMark.Enabled = false;
			areaSeries.AxisY.LabelStyle.Enabled = false;
			areaSeries.AxisY.IsStartedFromZero = area.AxisY.IsStartedFromZero;


			series.ChartArea = areaSeries.Name;

			// Create new chart area for axis
			ChartArea areaAxis = chart.ChartAreas.Add("AxisY_" + series.ChartArea);
			areaAxis.BackColor = Color.Transparent;
			areaAxis.BorderColor = Color.Transparent;
			areaAxis.Position.FromRectangleF(chart.ChartAreas[series.ChartArea].Position.ToRectangleF());
			areaAxis.InnerPlotPosition.FromRectangleF(chart.ChartAreas[series.ChartArea].InnerPlotPosition.ToRectangleF());

			// Create a copy of specified series
			Series seriesCopy = chart.Series.Add(series.Name + "_Copy");
			seriesCopy.ChartType = series.ChartType;
			foreach(DataPoint point in series.Points)
			{
				seriesCopy.Points.AddXY(point.XValue, point.YValues[0]);
			}

			// Hide copied series
			seriesCopy.IsVisibleInLegend = false;
			seriesCopy.Color = Color.Transparent;
			seriesCopy.BorderColor = Color.Transparent;
			seriesCopy.ChartArea = areaAxis.Name;

			// Disable drid lines & tickmarks
			areaAxis.AxisX.LineWidth = 0;
			areaAxis.AxisX.MajorGrid.Enabled = false;
			areaAxis.AxisX.MajorTickMark.Enabled = false;
			areaAxis.AxisX.LabelStyle.Enabled = false;
			areaAxis.AxisY.MajorGrid.Enabled = false;
			areaAxis.AxisY.IsStartedFromZero = area.AxisY.IsStartedFromZero;
			areaAxis.AxisY.LabelStyle.Font = area.AxisY.LabelStyle.Font;

			// Adjust area position
			areaAxis.Position.X -= axisOffset;
			areaAxis.InnerPlotPosition.X += labelsSize;

		}


	}
}
