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
	/// Summary description for BoxPlotChartType.
	/// </summary>
	public class BoxPlotChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxPercentiles;
		private CheckBox checkBoxShowAverage;
		private CheckBox checkBoxShowMedian;
		private CheckBox checkBoxShowUnusual;
		private Label label5;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public BoxPlotChartType()
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
			DataPoint dataPoint1 = new DataPoint(2, 0);
			DataPoint dataPoint2 = new DataPoint(2, 0);
			DataPoint dataPoint3 = new DataPoint(2, 0);
			DataPoint dataPoint4 = new DataPoint(2, 0);
			DataPoint dataPoint5 = new DataPoint(2, 0);
			DataPoint dataPoint6 = new DataPoint(2, 0);
			DataPoint dataPoint7 = new DataPoint(2, 0);
			DataPoint dataPoint8 = new DataPoint(2, 0);
			Title title1 = new Title();
			Title title2 = new Title();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            checkBoxShowUnusual = new CheckBox();
            checkBoxShowMedian = new CheckBox();
            checkBoxShowAverage = new CheckBox();
            comboBoxPercentiles = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Graphics;
            chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BackSecondaryColor = System.Drawing.Color.White;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Maximum = 100;
            chartArea1.AxisY.Minimum = 0;
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Data Chart Area";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 82F;
            chartArea1.Position.Width = 60F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 12F;
            chartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea2.AlignWithChartArea = "Data Chart Area";
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Maximum = 10;
            chartArea2.AxisX.Minimum = 0;
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.Maximum = 100;
            chartArea2.AxisY.Minimum = 0;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Empty;
            chartArea2.Name = "Box Chart Area";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 82F;
            chartArea2.Position.Width = 39F;
            chartArea2.Position.X = 61F;
            chartArea2.Position.Y = 12F;
            chart1.ChartAreas.Add(chartArea1);
            chart1.ChartAreas.Add(chartArea2);
            legend1.Enabled = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 56);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.ChartArea = "Data Chart Area";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Default";
            series1.MarkerSize = 8;
            series1.Name = "DataSeries";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.ShadowOffset = 1;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.ChartArea = "Box Chart Area";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series2.CustomProperties = "BoxPlotSeries=DataSeries, PointWidth=1.2";
            series2.Legend = "Default";
            series2.Name = "BoxPlotSeries";
            series2.YValuesPerPoint = 6;
            series3.ChartArea = "Box Chart Area";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.CustomProperties = "LabelStyle=Right";
            series3.Font = new Font("Microsoft Sans Serif", 7F);
            series3.Legend = "Default";
            series3.Name = "BoxPlotLabels";
            dataPoint1.Color = System.Drawing.Color.Transparent;
            dataPoint2.Color = System.Drawing.Color.Transparent;
            dataPoint3.Color = System.Drawing.Color.Transparent;
            dataPoint4.Color = System.Drawing.Color.Transparent;
            dataPoint5.Color = System.Drawing.Color.Transparent;
            dataPoint6.Color = System.Drawing.Color.Transparent;
            dataPoint7.Color = System.Drawing.Color.Transparent;
            dataPoint8.Color = System.Drawing.Color.Transparent;
            series3.Points.Add(dataPoint1);
            series3.Points.Add(dataPoint2);
            series3.Points.Add(dataPoint3);
            series3.Points.Add(dataPoint4);
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            series3.Points.Add(dataPoint7);
            series3.Points.Add(dataPoint8);
            series3.SmartLabelStyle.Enabled = false;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(460, 296);
            chart1.TabIndex = 1;
            title1.DockedToChartArea = "Data Chart Area";
            title1.DockingOffset = -8;
            title1.Font = new Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Position.Auto = false;
            title1.Position.Height = 5.813029F;
            title1.Position.Width = 48.49561F;
            title1.Position.X = 10F;
            title1.Position.Y = 6F;
            title1.Text = "Data Series";
            title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title2.DockedToChartArea = "Box Chart Area";
            title2.DockingOffset = -7;
            title2.Font = new Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title2";
            title2.Position.Auto = false;
            title2.Position.Height = 5.813029F;
            title2.Position.Width = 29.7426F;
            title2.Position.X = 69.30817F;
            title2.Position.Y = 6F;
            title2.Text = "Data Distribution";
            chart1.Titles.Add(title1);
            chart1.Titles.Add(title2);
            chart1.PrePaint += new EventHandler<ChartPaintEventArgs>(chart1_PrePaint);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 48);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to use a Box Plot chart. ";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxShowUnusual);
            panel1.Controls.Add(checkBoxShowMedian);
            panel1.Controls.Add(checkBoxShowAverage);
            panel1.Controls.Add(comboBoxPercentiles);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(480, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 280);
            panel1.TabIndex = 2;
            // 
            // checkBoxShowUnusual
            // 
            checkBoxShowUnusual.Checked = true;
            checkBoxShowUnusual.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxShowUnusual.Location = new Point(32, 120);
            checkBoxShowUnusual.Name = "checkBoxShowUnusual";
            checkBoxShowUnusual.Size = new Size(192, 24);
            checkBoxShowUnusual.TabIndex = 4;
            checkBoxShowUnusual.Text = "Show &Unusual Points";
            checkBoxShowUnusual.CheckedChanged += new EventHandler(checkBoxShowUnusual_CheckedChanged);
            // 
            // checkBoxShowMedian
            // 
            checkBoxShowMedian.Checked = true;
            checkBoxShowMedian.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxShowMedian.Location = new Point(32, 88);
            checkBoxShowMedian.Name = "checkBoxShowMedian";
            checkBoxShowMedian.Size = new Size(192, 24);
            checkBoxShowMedian.TabIndex = 3;
            checkBoxShowMedian.Text = "Show &Median Line";
            checkBoxShowMedian.CheckedChanged += new EventHandler(checkBoxShowMedian_CheckedChanged);
            // 
            // checkBoxShowAverage
            // 
            checkBoxShowAverage.Checked = true;
            checkBoxShowAverage.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxShowAverage.Location = new Point(32, 56);
            checkBoxShowAverage.Name = "checkBoxShowAverage";
            checkBoxShowAverage.Size = new Size(192, 24);
            checkBoxShowAverage.TabIndex = 2;
            checkBoxShowAverage.Text = "Show &Average Line";
            checkBoxShowAverage.CheckedChanged += new EventHandler(checkBoxShow3D_CheckedChanged);
            // 
            // comboBoxPercentiles
            // 
            comboBoxPercentiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxPercentiles.Items.AddRange([
            "15/85th Percentile",
            "10/90th Percentile",
            "5/95th Percentile",
            "0/100th Percentile (Min/Max)"]);
            comboBoxPercentiles.Location = new Point(32, 24);
            comboBoxPercentiles.Name = "comboBoxPercentiles";
            comboBoxPercentiles.Size = new Size(168, 22);
            comboBoxPercentiles.TabIndex = 1;
            comboBoxPercentiles.SelectedIndexChanged += new EventHandler(comboBoxExploded_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(32, 2);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 0;
            label1.Text = "Whiskers &Percentiles:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label5.Font = new Font("Verdana", 11F);
            label5.Location = new Point(16, 352);
            label5.Name = "label5";
            label5.Size = new Size(696, 48);
            label5.TabIndex = 23;
            label5.Text = "The box and its whiskers can use different percentiles of the data series. Unusua" +
                "l data points, median and average lines can also be shown or hidden.";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BoxPlotChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "BoxPlotChartType";
            Size = new Size(728, 480);
            Load += new EventHandler(PieChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Set whiskers percentile
			int whiskerPercentile = (3 - comboBoxPercentiles.SelectedIndex) * 5;
			chart1.Series["BoxPlotSeries"]["BoxPlotWhiskerPercentile"] = whiskerPercentile.ToString();

			// Show/Hide Average line
			chart1.Series["BoxPlotSeries"]["BoxPlotShowAverage"] = (checkBoxShowAverage.Checked) ? "true" : "false";

			// Show/Hide Median line
			chart1.Series["BoxPlotSeries"]["BoxPlotShowMedian"] = (checkBoxShowMedian.Checked) ? "true" : "false";
			
			// Show/Hide Unusual points
			chart1.Series["BoxPlotSeries"]["BoxPlotShowUnusualValues"] = (checkBoxShowUnusual.Checked) ? "true" : "false";
		}

		private void PieChartType_Load(object sender, EventArgs e)
		{
			// Populate series data
			double[]	yValues = [55.62, 45.54, 73.45, 9.73, 88.42, 45.9, 63.6, 85.1, 67.2, 23.6];
			chart1.Series["DataSeries"].Points.DataBindY(yValues);

			// Specify data series name for the Box Plot
			chart1.Series["BoxPlotSeries"]["BoxPlotSeries"] = "DataSeries";

			// Set selection
			comboBoxPercentiles.SelectedIndex = 1;

			UpdateChartSettings();	
		}

		private void comboBoxExploded_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void checkBoxShowMedian_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void checkBoxShowUnusual_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void chart1_PrePaint(object sender, ChartPaintEventArgs e)
		{
			if(e.ChartElement is Chart)
			{
				// Position point chart type series on the points of the box plot to display labels
				chart1.Series["BoxPlotLabels"].Points[0].YValues[0] = chart1.Series["BoxPlotSeries"].Points[0].YValues[0];
				chart1.Series["BoxPlotLabels"].Points[1].YValues[0] = chart1.Series["BoxPlotSeries"].Points[0].YValues[1];
				chart1.Series["BoxPlotLabels"].Points[2].YValues[0] = chart1.Series["BoxPlotSeries"].Points[0].YValues[2];
				chart1.Series["BoxPlotLabels"].Points[3].YValues[0] = chart1.Series["BoxPlotSeries"].Points[0].YValues[3];
				chart1.Series["BoxPlotLabels"].Points[4].YValues[0] = chart1.Series["BoxPlotSeries"].Points[0].YValues[4];
				chart1.Series["BoxPlotLabels"].Points[5].YValues[0] = chart1.Series["BoxPlotSeries"].Points[0].YValues[5];

				chart1.Series["BoxPlotLabels"].Points[6].Label = "";
				chart1.Series["BoxPlotLabels"].Points[7].Label = "";
				if(checkBoxShowUnusual.Checked)
				{
					if(chart1.Series["BoxPlotSeries"].Points[0].YValues.Length > 6)
					{
						chart1.Series["BoxPlotLabels"].Points[6].YValues[0] = chart1.Series["BoxPlotSeries"].Points[0].YValues[6] - 3;
						chart1.Series["BoxPlotLabels"].Points[6].Label = "Unusual data point";
					}
					if(chart1.Series["BoxPlotSeries"].Points[0].YValues.Length > 8)
					{
						chart1.Series["BoxPlotLabels"].Points[7].YValues[0] = chart1.Series["BoxPlotSeries"].Points[0].YValues[8] + 3;
						chart1.Series["BoxPlotLabels"].Points[7].Label = "Unusual data point";
					}
					else if(chart1.Series["BoxPlotSeries"].Points[0].YValues.Length > 7)
					{
						chart1.Series["BoxPlotLabels"].Points[7].YValues[0] = chart1.Series["BoxPlotSeries"].Points[0].YValues[7] + 3;
						chart1.Series["BoxPlotLabels"].Points[7].Label = "Unusual data point";
					}
				}
				

				// Define labels
				int whiskerPercentile = (3 - comboBoxPercentiles.SelectedIndex) * 5;
				chart1.Series["BoxPlotLabels"].Points[0].Label = whiskerPercentile.ToString() + "th Percentile";
				chart1.Series["BoxPlotLabels"].Points[1].Label = (100 - whiskerPercentile).ToString() + "th Percentile";
				if(whiskerPercentile == 0)
				{
					chart1.Series["BoxPlotLabels"].Points[0].Label = "Minimum";
					chart1.Series["BoxPlotLabels"].Points[1].Label = "Maximum";
				}
				chart1.Series["BoxPlotLabels"].Points[2].Label = "25th Percentile (LQ)";
				chart1.Series["BoxPlotLabels"].Points[3].Label = "75th Percentile (UQ)";
				chart1.Series["BoxPlotLabels"].Points[4].Label = (checkBoxShowAverage.Checked) ? "Average/Mean" : "";
				chart1.Series["BoxPlotLabels"].Points[5].Label = (checkBoxShowMedian.Checked) ? "Median" : "";

				// Add strip lines
				chart1.ChartAreas["Data Chart Area"].AxisY.StripLines.Clear();
				StripLine stripLine = new StripLine();
				stripLine.BackColor = Color.FromArgb(60, 252, 180, 65);
				stripLine.IntervalOffset = chart1.Series["BoxPlotLabels"].Points[2].YValues[0];
				stripLine.StripWidth = chart1.Series["BoxPlotLabels"].Points[3].YValues[0] - stripLine.IntervalOffset;
				stripLine.Text = "data points\n50% of";
				stripLine.Font = new Font("Microsoft Sans Serif", 7);
				stripLine.TextOrientation = TextOrientation.Rotated270;
                stripLine.TextLineAlignment = StringAlignment.Center;
                stripLine.TextAlignment = StringAlignment.Near;
				chart1.ChartAreas["Data Chart Area"].AxisY.StripLines.Add(stripLine);

				stripLine = new StripLine();
				stripLine.BackColor = Color.FromArgb(60, 252, 180, 65);
				stripLine.IntervalOffset = chart1.Series["BoxPlotLabels"].Points[0].YValues[0];
				stripLine.StripWidth = chart1.Series["BoxPlotLabels"].Points[1].YValues[0] - stripLine.IntervalOffset;
				stripLine.ForeColor = Color.FromArgb(120, Color.Black);
                stripLine.Text = (100 - whiskerPercentile * 2).ToString() + "% of data points";
				stripLine.Font = new Font("Microsoft Sans Serif", 7);
                stripLine.TextOrientation = TextOrientation.Rotated270;
                stripLine.TextLineAlignment = StringAlignment.Center;
				chart1.ChartAreas["Data Chart Area"].AxisY.StripLines.Add(stripLine);


			}
		}

	}
}
