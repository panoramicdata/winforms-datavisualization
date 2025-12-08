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
	/// Summary description for PieCollectedData.
	/// </summary>
	public class PieCollectedData : UserControl
	{
		// PieCollectedDataHelper is a helper class found in the samples Utilities folder. 
		PieCollectedDataHelper pieHelper = null;

		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxChartType;
		private Label label2;
		private ComboBox comboBoxCollectedPercentage;
		private bool		loadingData = false;
		private CheckBox checkBoxcollectSmallSegments;
		private Label label3;
		private ComboBox comboBoxsupplementalSize;
        private CheckBox checkBoxOriginalChart;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public PieCollectedData()
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
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            checkBoxOriginalChart = new CheckBox();
            comboBoxsupplementalSize = new ComboBox();
            label3 = new Label();
            checkBoxcollectSmallSegments = new CheckBox();
            comboBoxCollectedPercentage = new ComboBox();
            label2 = new Label();
            comboBoxChartType = new ComboBox();
            label1 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BackSecondaryColor = System.Drawing.Color.White;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Empty;
            chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 61);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieLabelStyle=Ellipse";
            series1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.ShadowOffset = 5;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 45);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to improve the readability of small segments in the " +
                "Pie or Doughnut chart types by displaying them in a supplemental pie chart serie" +
                "s.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxOriginalChart);
            panel1.Controls.Add(comboBoxsupplementalSize);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(checkBoxcollectSmallSegments);
            panel1.Controls.Add(comboBoxCollectedPercentage);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxChartType);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 0;
            // 
            // checkBoxOriginalChart
            // 
            checkBoxOriginalChart.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxOriginalChart.Location = new Point(-19, 7);
            checkBoxOriginalChart.Name = "checkBoxOriginalChart";
            checkBoxOriginalChart.Size = new Size(216, 24);
            checkBoxOriginalChart.TabIndex = 1;
            checkBoxOriginalChart.Text = "&Hide Supplemental Chart:";
            checkBoxOriginalChart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxOriginalChart.CheckedChanged += new EventHandler(checkBoxOriginalChart_CheckedChanged);
            // 
            // comboBoxsupplementalSize
            // 
            comboBoxsupplementalSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxsupplementalSize.Items.AddRange([
            "Smaller",
            "Same",
            "Larger"]);
            comboBoxsupplementalSize.Location = new Point(184, 104);
            comboBoxsupplementalSize.Name = "comboBoxsupplementalSize";
            comboBoxsupplementalSize.Size = new Size(104, 22);
            comboBoxsupplementalSize.TabIndex = 7;
            comboBoxsupplementalSize.SelectedIndexChanged += new EventHandler(comboBoxsupplementalSize_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(11, 104);
            label3.Name = "label3";
            label3.Size = new Size(168, 23);
            label3.TabIndex = 6;
            label3.Text = "Supplemental chart &Size:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxcollectSmallSegments
            // 
            checkBoxcollectSmallSegments.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxcollectSmallSegments.Location = new Point(5, 138);
            checkBoxcollectSmallSegments.Name = "checkBoxcollectSmallSegments";
            checkBoxcollectSmallSegments.Size = new Size(192, 24);
            checkBoxcollectSmallSegments.TabIndex = 0;
            checkBoxcollectSmallSegments.Text = "&Collect Small Segments:";
            checkBoxcollectSmallSegments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxcollectSmallSegments.CheckedChanged += new EventHandler(checkBoxcollectSmallSegments_CheckedChanged);
            // 
            // comboBoxCollectedPercentage
            // 
            comboBoxCollectedPercentage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxCollectedPercentage.Items.AddRange([
            "2",
            "3",
            "5"]);
            comboBoxCollectedPercentage.Location = new Point(184, 72);
            comboBoxCollectedPercentage.Name = "comboBoxCollectedPercentage";
            comboBoxCollectedPercentage.Size = new Size(104, 22);
            comboBoxCollectedPercentage.TabIndex = 5;
            comboBoxCollectedPercentage.SelectedIndexChanged += new EventHandler(comboBoxCollectedPercentage_SelectedIndexChanged_1);
            // 
            // label2
            // 
            label2.Location = new Point(19, 72);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 4;
            label2.Text = "Collected &Percentage:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxChartType
            // 
            comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxChartType.Items.AddRange([
            "Doughnut",
            "Pie"]);
            comboBoxChartType.Location = new Point(184, 40);
            comboBoxChartType.Name = "comboBoxChartType";
            comboBoxChartType.Size = new Size(104, 22);
            comboBoxChartType.TabIndex = 3;
            comboBoxChartType.SelectedIndexChanged += new EventHandler(comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(19, 40);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 2;
            label1.Text = "Chart &Type:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PieCollectedData
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PieCollectedData";
            Size = new Size(728, 424);
            Load += new EventHandler(PieChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			if(!loadingData)
			{
				// Set chart type 
				chart1.Series["Default"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), comboBoxChartType.Text, true );

				// Populate series data
				double[]	yValues = [65.62,  2.1, 85.73, 11.42, 34.45,  75.54, 5.7, 4.1];
				string[]	xValues = ["France", "Japan",  "USA", "Italy", "Germany", "Canada",  "Russia", "Spain"];
				chart1.Series["Default"].Points.DataBindXY(xValues, yValues);

				// Remove supplemental series and chart area if they already exsist
				if(chart1.Series.Count > 1)
				{
					chart1.Series.RemoveAt(1);
					chart1.ChartAreas.RemoveAt(1);

					// Reset automatic position for the default chart area
					chart1.ChartAreas["Default"].Position.Auto = true;
				}
				
				
				// Check if supplemental chart should be shown
				if(!checkBoxOriginalChart.Checked)
				{
					chart1.Series["Default"]["PieLabelStyle"] = "Inside";
					
					// Set the percentage of the total series values. This value determines 
					// if the data point value is a "small" value and should be shown as collected.
					pieHelper.CollectedPercentage = double.Parse(comboBoxCollectedPercentage.Text);

					// Indicates if small segments should be shown as one "collected" segment in 
					// the original series.
					pieHelper.ShowCollectedDataAsOneSlice = checkBoxcollectSmallSegments.Checked;

					// Size ratio between the original and supplemental chart areas.
					// Value of 1.0f indicates that same area size will be used.
					if(comboBoxsupplementalSize.SelectedIndex == 0)
					{
						pieHelper.SupplementedAreaSizeRatio = 0.9f;
					}
					else if(comboBoxsupplementalSize.SelectedIndex == 1)
					{
						pieHelper.SupplementedAreaSizeRatio = 1.0f;
					}
					else if(comboBoxsupplementalSize.SelectedIndex == 2)
					{
						pieHelper.SupplementedAreaSizeRatio = 1.1f;
					}

					// Set position in relative coordinates ( 0,0 - top left corner; 100,100 - bottom right corner)
					// where original and supplemental pie charts should be placed.
					pieHelper.ChartAreaPosition = new RectangleF(3f, 3f, 93f, 96f);

					// Show supplemental pie for the "Default" series
					pieHelper.ShowSmallSegmentsAsSupplementalPie("Default");
				}
				else
				{
					chart1.Series["Default"]["PieLabelStyle"] = "Outside";
					chart1.Series["Default"].LabelBackColor = Color.Empty;
				}
				// Enable/Disable controls
				comboBoxChartType.Enabled = !checkBoxOriginalChart.Checked;
				comboBoxCollectedPercentage.Enabled = !checkBoxOriginalChart.Checked;
				comboBoxsupplementalSize.Enabled = !checkBoxOriginalChart.Checked;
				checkBoxcollectSmallSegments.Enabled = !checkBoxOriginalChart.Checked;
			}
		}

		private void PieChartType_Load(object sender, EventArgs e)
		{
			// Set series font
			chart1.Series[0].Font = new Font("Trebuchet MS", 8, FontStyle.Bold);

			// Create pie chart helper class
			pieHelper = new PieCollectedDataHelper(chart1);
			pieHelper.CollectedLabel = String.Empty;
            
			// Set current selection
			loadingData = true;
			comboBoxChartType.SelectedIndex = 0;
			comboBoxCollectedPercentage.SelectedIndex = 1;
			comboBoxsupplementalSize.SelectedIndex = 0;
			loadingData = false;

			// Update chart
			UpdateChartSettings();
		}

		private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxCollectedPercentage_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxcollectSmallSegments_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxsupplementalSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxOriginalChart_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}
	}
}
