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
	/// Summary description for HighlightDateRange.
	/// </summary>
	public class HighlightDateRange : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label2;
		private ComboBox comboBoxPointsHighlight;
		private Label label1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public HighlightDateRange()
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
            comboBoxPointsHighlight = new ComboBox();
            label2 = new Label();
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "MMM d";
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Interval = 200;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Interval = 200;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.Interval = 200;
            chartArea1.AxisY.Maximum = 1000;
            chartArea1.AxisY.Minimum = 0;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.LabelStyle.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
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
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series1.CustomProperties = "DrawingStyle=LightToDark";
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart1.Series.Add(series1);
            chart1.Size = new Size(412, 306);
            chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 34);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to highlight a range of data using StripLine objects" +
                ". ";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxPointsHighlight);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // comboBoxPointsHighlight
            // 
            comboBoxPointsHighlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxPointsHighlight.Items.AddRange([
            "Weekends",
            "Weekdays",
            "Mondays",
            "Wednesdays",
            "Fridays",
            "Mondays and Fridays"]);
            comboBoxPointsHighlight.Location = new Point(168, 2);
            comboBoxPointsHighlight.Name = "comboBoxPointsHighlight";
            comboBoxPointsHighlight.Size = new Size(121, 22);
            comboBoxPointsHighlight.TabIndex = 1;
            comboBoxPointsHighlight.SelectedIndexChanged += new EventHandler(comboBoxPointsHighlight_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(32, 2);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 0;
            label2.Text = "Points to &Highlight:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 372);
            label1.Name = "label1";
            label1.Size = new Size(702, 40);
            label1.TabIndex = 3;
            label1.Text = "StripLine objects, unlike interlaced strip lines, have interval-related propertie" +
                "s that determine how often and where strip lines are displayed.";
            // 
            // HighlightDateRange
            // 
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "HighlightDateRange";
            Size = new Size(728, 480);
            Load += new EventHandler(Sample_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
		}

		private void FillData()
		{
			// Populate chart with random sales data
			Random		random = new Random();
			DateTime	xTime = new DateTime(2000, 8, 1, 0, 0, 0);
			chart1.Series["Default"].Points.Clear();
			for(int pointIndex = 0; pointIndex < 21; pointIndex++)
			{
				// Simulate lower sales on the weekends	
				double	yValue = random.Next(600, 950);
				if(xTime.DayOfWeek == DayOfWeek.Sunday || xTime.DayOfWeek == DayOfWeek.Saturday)
				{
					yValue = random.Next(100, 400);
				}
				chart1.Series["Default"].Points.AddXY(xTime, yValue);
				xTime = xTime.AddDays(1);
			}

			chart1.Invalidate();
		}



		private void Sample_Load(object sender, EventArgs e)
		{
			// Set current selection
			comboBoxPointsHighlight.SelectedIndex = 0;
			
			// Fill chart data
			FillData();
		}

		private void comboBoxPointsHighlight_SelectedIndexChanged(object sender, EventArgs e)
		{
			double offset = -1.5;
			double width = 2;
			chart1.ChartAreas["Default"].AxisX.StripLines.Clear();

			string SelectedText = comboBoxPointsHighlight.SelectedItem.ToString();

			if(SelectedText == "Weekends")
			{
				offset = -1.5;
				width = 2;
			}
			else if(SelectedText == "Weekdays")
			{
				offset = 0.5;
				width = 5;
			}
			else if(SelectedText == "Mondays")
			{
				offset = 0.5;
				width = 1;
			}
			else if(SelectedText == "Wednesdays")
			{
				offset = 2.5;
				width = 1;
			}
			else if(SelectedText == "Fridays")
			{
				offset = 4.5;
				width = 1;
			}
			else if(SelectedText == "Mondays and Fridays")
			{
				// Create a re-occurring strip line for the monday
				StripLine strip = new StripLine();
				strip.BackColor = Color.FromArgb(120, Color.Gray);
				strip.IntervalOffset = 0.5;
				strip.IntervalOffsetType = DateTimeIntervalType.Days; 
				strip.Interval = 1;
				strip.IntervalType = DateTimeIntervalType.Weeks; 
				strip.StripWidth = 1;
				strip.StripWidthType =  DateTimeIntervalType.Days; 
				chart1.ChartAreas["Default"].AxisX.StripLines.Add(strip);

				offset = 4.5;
				width = 1;
			}


			// Create a re-occurring strip line for the selected range or 
			// just the firday if monday and friday is the selection
			StripLine stripLine = new StripLine();
			stripLine.BackColor = Color.FromArgb(120, Color.Gray);
			stripLine.IntervalOffset = offset;
			stripLine.IntervalOffsetType = DateTimeIntervalType.Days; 
			stripLine.Interval = 1;
			stripLine.IntervalType = DateTimeIntervalType.Weeks; 
			stripLine.StripWidth = width;
			stripLine.StripWidthType =  DateTimeIntervalType.Days; 
			chart1.ChartAreas["Default"].AxisX.StripLines.Add(stripLine);

		}
	}
}
