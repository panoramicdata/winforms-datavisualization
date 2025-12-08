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
	/// Summary description for AxisMargins.
	/// </summary>
	public class AxisMargins : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private RadioButton radioButtonArea;
		private RadioButton radioButtonSplineArea;
		private CheckBox checkBoxShowMargin;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AxisMargins()
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
			DataPoint dataPoint1 = new DataPoint(0, 5);
			DataPoint dataPoint2 = new DataPoint(0, 8.1000003814697266);
			DataPoint dataPoint3 = new DataPoint(0, 3.5999999046325684);
			DataPoint dataPoint4 = new DataPoint(0, 6.5);
			DataPoint dataPoint5 = new DataPoint(0, 4.3000001907348633);
			DataPoint dataPoint6 = new DataPoint(0, 2.7999999523162842);
			DataPoint dataPoint7 = new DataPoint(0, 7.8000001907348633);
			DataPoint dataPoint8 = new DataPoint(0, 5.5);
			DataPoint dataPoint9 = new DataPoint(0, 8.5);
			Series series2 = new Series();
			DataPoint dataPoint10 = new DataPoint(0, 2.2999999523162842);
			DataPoint dataPoint11 = new DataPoint(0, 5.5);
			DataPoint dataPoint12 = new DataPoint(0, 7.9000000953674316);
			DataPoint dataPoint13 = new DataPoint(0, 3.4000000953674316);
			DataPoint dataPoint14 = new DataPoint(0, 7.3000001907348633);
			DataPoint dataPoint15 = new DataPoint(0, 4.1999998092651367);
			DataPoint dataPoint16 = new DataPoint(0, 3.5999999046325684);
			DataPoint dataPoint17 = new DataPoint(0, 8.1000003814697266);
			DataPoint dataPoint18 = new DataPoint(0, 5.3000001907348633);
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            checkBoxShowMargin = new CheckBox();
            radioButtonSplineArea = new RadioButton();
            radioButtonArea = new RadioButton();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
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
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 48);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.Points.Add(dataPoint15);
            series2.Points.Add(dataPoint16);
            series2.Points.Add(dataPoint17);
            series2.Points.Add(dataPoint18);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 34);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to use axis margins.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxShowMargin);
            panel1.Controls.Add(radioButtonSplineArea);
            panel1.Controls.Add(radioButtonArea);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // checkBoxShowMargin
            // 
            checkBoxShowMargin.Location = new Point(13, 72);
            checkBoxShowMargin.Name = "checkBoxShowMargin";
            checkBoxShowMargin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            checkBoxShowMargin.Size = new Size(168, 24);
            checkBoxShowMargin.TabIndex = 2;
            checkBoxShowMargin.Text = "Show X Axis &Margin";
            checkBoxShowMargin.CheckedChanged += new EventHandler(checkBoxShowMargin_CheckedChanged);
            // 
            // radioButtonSplineArea
            // 
            radioButtonSplineArea.Location = new Point(12, 36);
            radioButtonSplineArea.Name = "radioButtonSplineArea";
            radioButtonSplineArea.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            radioButtonSplineArea.Size = new Size(168, 24);
            radioButtonSplineArea.TabIndex = 1;
            radioButtonSplineArea.Text = "&Line Chart";
            radioButtonSplineArea.CheckedChanged += new EventHandler(radioButtonSplineArea_CheckedChanged);
            // 
            // radioButtonArea
            // 
            radioButtonArea.Checked = true;
            radioButtonArea.Location = new Point(8, 8);
            radioButtonArea.Name = "radioButtonArea";
            radioButtonArea.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            radioButtonArea.Size = new Size(172, 24);
            radioButtonArea.TabIndex = 0;
            radioButtonArea.TabStop = true;
            radioButtonArea.Text = "&Area Chart";
            radioButtonArea.CheckedChanged += new EventHandler(radioButtonArea_CheckedChanged);
            // 
            // AxisMargins
            // 
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AxisMargins";
            Size = new Size(728, 480);
            Load += new EventHandler(AxisMargins_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			if(radioButtonArea.Checked)
			{
				// Set chart type to Area
				chart1.Series["Default"].ChartType = SeriesChartType.Area;
				chart1.Series["Series2"].ChartType = SeriesChartType.Area;
				chart1.Series["Default"].DeleteCustomProperty("LineTension");
				chart1.Series["Series2"].DeleteCustomProperty("LineTension");
				chart1.Series["Default"].BorderWidth = 1;
				chart1.Series["Series2"].BorderWidth = 1;
			}
			else
			{
				// Set chart type to line 
				chart1.Series["Default"].ChartType = SeriesChartType.Line;
				chart1.Series["Series2"].ChartType = SeriesChartType.Line;
				chart1.Series["Default"].BorderWidth = 2;
				chart1.Series["Series2"].BorderWidth = 2;
			}


			// Disable/enable X axis margin
			chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;

		}

		private void radioButtonArea_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void radioButtonSplineArea_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxShowMargin_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}


		private void AxisMargins_Load(object sender, EventArgs e)
		{
			checkBoxShowMargin.Checked = true;
		}


	}
}
