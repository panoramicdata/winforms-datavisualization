using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Utilities;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for HistogramChart.
	/// </summary>
	public class HistogramChart: UserControl
	{
		private Label labelSampleComment;
		private Panel panel1;
		private bool		loadingData = false;
		private Chart chart1;
		private ComboBox comboBoxIntervalNumber;
		private Label label1;
		private CheckBox checkBoxShowPercents;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public HistogramChart()
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
			ChartArea chartArea2 = new ChartArea();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			Series series2 = new Series();
			Series series3 = new Series();
            labelSampleComment = new Label();
            panel1 = new Panel();
            checkBoxShowPercents = new CheckBox();
            label1 = new Label();
            comboBoxIntervalNumber = new ComboBox();
            chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(chart1)).BeginInit();
            SuspendLayout();
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 14);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 43);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to create a histogram chart that uses a given number" +
                " of intervals. ";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxShowPercents);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxIntervalNumber);
            panel1.Location = new Point(432, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 0;
            // 
            // checkBoxShowPercents
            // 
            checkBoxShowPercents.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowPercents.Checked = true;
            checkBoxShowPercents.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxShowPercents.Location = new Point(4, 40);
            checkBoxShowPercents.Name = "checkBoxShowPercents";
            checkBoxShowPercents.Size = new Size(177, 24);
            checkBoxShowPercents.TabIndex = 2;
            checkBoxShowPercents.Text = "Show &Percent Axis:";
            checkBoxShowPercents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowPercents.CheckedChanged += new EventHandler(checkBoxShowPercents_CheckedChanged);
            // 
            // label1
            // 
            label1.Location = new Point(0, 8);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 0;
            label1.Text = "&Number of Intervals:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxIntervalNumber
            // 
            comboBoxIntervalNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxIntervalNumber.Items.AddRange([
            "4",
            "10",
            "20",
            "30"]);
            comboBoxIntervalNumber.Location = new Point(168, 8);
            comboBoxIntervalNumber.Name = "comboBoxIntervalNumber";
            comboBoxIntervalNumber.Size = new Size(104, 22);
            comboBoxIntervalNumber.TabIndex = 1;
            comboBoxIntervalNumber.SelectedIndexChanged += new EventHandler(comboBoxIntervalNumber_SelectedIndexChanged);
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.AlignWithChartArea = "HistogramArea";
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.Size = 1.5F;
            chartArea1.AxisX.Title = "One axis data distribution chart";
            chartArea1.AxisX.TitleFont = new Font("Trebuchet MS", 8F);
            chartArea1.AxisY.IsReversed = true;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Maximum = 2;
            chartArea1.AxisY.Minimum = 0;
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 15F;
            chartArea1.Position.Width = 96F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 4F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Inclination = 15;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Perspective = 10;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep90)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea2.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.Title = "Histogram (Frequency Diagram)";
            chartArea2.AxisX.TitleFont = new Font("Trebuchet MS", 8F);
            chartArea2.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY2.IsLabelAutoFit = false;
            chartArea2.AxisY2.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.BackColor = System.Drawing.Color.OldLace;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "HistogramArea";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 77F;
            chartArea2.Position.Width = 93F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 18F;
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            chart1.ChartAreas.Add(chartArea2);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 65);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series1.Enabled = false;
            series1.Legend = "Default";
            series1.MarkerSize = 9;
            series1.Name = "RawData";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.MarkerSize = 8;
            series2.Name = "DataDistribution";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "HistogramArea";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Default";
            series3.Name = "Histogram";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            // 
            // HistogramChart
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "HistogramChart";
            Size = new Size(728, 480);
            Load += new EventHandler(PieChartType_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			if(!loadingData)
			{
				// Create a histogram series
				HistogramChartHelper histogramHelper = new HistogramChartHelper();
				histogramHelper.SegmentIntervalNumber = int.Parse(comboBoxIntervalNumber.Text);
				histogramHelper.ShowPercentOnSecondaryYAxis = checkBoxShowPercents.Checked;
				// NOTE: Interval width may be specified instead of interval number
				//histogramHelper.SegmentIntervalWidth = 15;
				histogramHelper.CreateHistogram(chart1, "RawData", "Histogram");

				// Set same X axis scale and interval in the single axis data distribution 
				// chart area as in the histogram chart area.
				chart1.ChartAreas["Default"].AxisX.Minimum = chart1.ChartAreas["HistogramArea"].AxisX.Minimum;
				chart1.ChartAreas["Default"].AxisX.Maximum = chart1.ChartAreas["HistogramArea"].AxisX.Maximum;
				chart1.ChartAreas["Default"].AxisX.Interval = chart1.ChartAreas["HistogramArea"].AxisX.Interval;
			}
		}

		private void PieChartType_Load(object sender, EventArgs e)
		{
			// Populate chart with random data
			Random rand = new Random();
			for(int index = 1; index < 70; index++) 
			{
				int maxValue = (int)Math.Pow(rand.Next(100, 1000) / 100.0 , 2.0);
				double newVal = 100 + rand.Next(0, (int)maxValue);
				chart1.Series["RawData"].Points.AddY(newVal);
				newVal = 100 + rand.Next(-(int)maxValue, 0);
				chart1.Series["RawData"].Points.AddY(newVal);
			}

			// Populate single axis data distribution series. Show Y value of the
			// data series as X value and set all Y values to 1.
			foreach(DataPoint dataPoint in chart1.Series["RawData"].Points)
			{
				chart1.Series["DataDistribution"].Points.AddXY(dataPoint.YValues[0], 1);
			}

			// Set current selection
			loadingData = true;
			comboBoxIntervalNumber.SelectedIndex = 1;
			loadingData = false;

			// Update chart
			UpdateChartSettings();
		}

		private void comboBoxIntervalNumber_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Update chart
			UpdateChartSettings();
		}

		private void checkBoxShowPercents_CheckedChanged(object sender, EventArgs e)
		{
			// Update chart
			UpdateChartSettings();
		}

	}
}
