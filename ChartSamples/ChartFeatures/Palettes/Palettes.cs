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
	/// Summary description for Palettes.
	/// </summary>
	public class Palettes : UserControl
	{
		private Label labelSampleComment;
		private Panel panel1;
		private ComboBox cb_Palette;
		private ComboBox cb_CustomPalette;
		private Chart chart2;

		Random random = new Random();
		private RadioButton rb_Palette;
		private RadioButton rb_CustomPalette;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public Palettes()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			chart2.Series.Clear();
			FillSeries(chart2, 5, 30);
			FillSeries(chart2, 20, 40);
			FillSeries(chart2, 40, 50);
			FillSeries(chart2, 11, 50);

			cb_CustomPalette.SelectedIndex = 0;
			cb_Palette.SelectedIndex = 0;
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
			ChartArea chartArea1 = ((ChartArea)(new ChartArea()));
			Legend legend1 = ((Legend)(new Legend()));
			Series series1 = ((Series)(new Series()));
			Series series2 = ((Series)(new Series()));
			Series series3 = ((Series)(new Series()));
			Series series4 = ((Series)(new Series()));
			Title title1 = ((Title)(new Title()));
            chart2 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            rb_CustomPalette = new RadioButton();
            rb_Palette = new RadioButton();
            cb_CustomPalette = new ComboBox();
            cb_Palette = new ComboBox();
            ((ISupportInitialize)(chart2)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart2
            // 
            chart2.BackColor = System.Drawing.Color.WhiteSmoke;
            chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart2.BackSecondaryColor = System.Drawing.Color.White;
            chart2.BorderlineColor = System.Drawing.Color.Navy;
            chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart2.BorderlineWidth = 2;
            chart2.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chart2.BorderSkin.Tag = null;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 8;
            chartArea1.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Interval = 0;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Interval = 0;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Interval = 0;
            chartArea1.AxisX.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.LabelStyle.Interval = 0;
            chartArea1.AxisX2.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisX2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorGrid.Interval = 0;
            chartArea1.AxisX2.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisX2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorTickMark.Interval = 0;
            chartArea1.AxisX2.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisX2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisY.LabelAutoFitStyle = ((LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Interval = 0;
            chartArea1.AxisY.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Interval = 0;
            chartArea1.AxisY.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.Interval = 0;
            chartArea1.AxisY.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.LabelStyle.Interval = 0;
            chartArea1.AxisY2.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisY2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorGrid.Interval = 0;
            chartArea1.AxisY2.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisY2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorTickMark.Interval = 0;
            chartArea1.AxisY2.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisY2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.InnerPlotPosition.Height = 85.94743F;
            chartArea1.InnerPlotPosition.Tag = null;
            chartArea1.InnerPlotPosition.Width = 88.8228F;
            chartArea1.InnerPlotPosition.X = 9.4162F;
            chartArea1.InnerPlotPosition.Y = 3.40178F;
            chartArea1.Name = "Default";
            chartArea1.Position.Height = 77.16559F;
            chartArea1.Position.Tag = null;
            chartArea1.Position.Width = 89.43796F;
            chartArea1.Position.X = 4.824818F;
            chartArea1.Position.Y = 16.02085F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart2.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            legend1.Position.Tag = null;
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(16, 56);
            chart2.Name = "chart2";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series1.BorderWidth = 3;
            series1.CustomProperties = "DrawingStyle=LightToDark";
            series1.EmptyPointStyle.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series1.EmptyPointStyle.Name = null;
            series1.Name = "Series1";
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series2.BorderWidth = 3;
            series2.CustomProperties = "DrawingStyle=LightToDark";
            series2.EmptyPointStyle.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series2.EmptyPointStyle.Name = null;
            series2.Name = "Series2";
            series2.YValuesPerPoint = 2;
            series3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series3.BorderWidth = 3;
            series3.CustomProperties = "DrawingStyle=LightToDark";
            series3.EmptyPointStyle.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series3.EmptyPointStyle.Name = null;
            series3.Name = "Series3";
            series3.YValuesPerPoint = 2;
            series4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series4.BorderWidth = 3;
            series4.CustomProperties = "DrawingStyle=LightToDark";
            series4.EmptyPointStyle.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series4.EmptyPointStyle.Name = null;
            series4.Name = "Series4";
            series4.YValuesPerPoint = 2;
            chart2.Series.Add(series1);
            chart2.Series.Add(series2);
            chart2.Series.Add(series3);
            chart2.Series.Add(series4);
            chart2.Size = new Size(412, 296);
            chart2.TabIndex = 0;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Position.Height = 7.478481F;
            title1.Position.Tag = null;
            title1.Position.Width = 89.43796F;
            title1.Position.X = 4.824818F;
            title1.Position.Y = 5.542373F;
            title1.Text = "Chart Control for .NET Framework";
            chart2.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 34);
            labelSampleComment.TabIndex = 2;
            labelSampleComment.Text = "This sample demonstrates how a chart palette can be specified.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(rb_CustomPalette);
            panel1.Controls.Add(rb_Palette);
            panel1.Controls.Add(cb_CustomPalette);
            panel1.Controls.Add(cb_Palette);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 288);
            panel1.TabIndex = 1;
            // 
            // rb_CustomPalette
            // 
            rb_CustomPalette.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            rb_CustomPalette.Location = new Point(24, 48);
            rb_CustomPalette.Name = "rb_CustomPalette";
            rb_CustomPalette.Size = new Size(136, 24);
            rb_CustomPalette.TabIndex = 6;
            rb_CustomPalette.Text = "Custom Palette:";
            rb_CustomPalette.CheckedChanged += new EventHandler(rb_CustomPalette_CheckedChanged);
            // 
            // rb_Palette
            // 
            rb_Palette.Checked = true;
            rb_Palette.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            rb_Palette.Location = new Point(24, 16);
            rb_Palette.Name = "rb_Palette";
            rb_Palette.Size = new Size(136, 24);
            rb_Palette.TabIndex = 5;
            rb_Palette.TabStop = true;
            rb_Palette.Text = "Standard Palette:";
            rb_Palette.CheckedChanged += new EventHandler(rb_Palette_CheckedChanged);
            // 
            // cb_CustomPalette
            // 
            cb_CustomPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_CustomPalette.Enabled = false;
            cb_CustomPalette.Items.AddRange([
            "CorporateGold",
            "CorporateBlue",
            "Pastel"]);
            cb_CustomPalette.Location = new Point(168, 48);
            cb_CustomPalette.Name = "cb_CustomPalette";
            cb_CustomPalette.Size = new Size(128, 22);
            cb_CustomPalette.TabIndex = 4;
            cb_CustomPalette.SelectedIndexChanged += new EventHandler(cb_CustomPalette_SelectedIndexChanged);
            // 
            // cb_Palette
            // 
            cb_Palette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_Palette.Items.AddRange([
            "BrightPastel",
            "EarthTones",
            "Pastel",
            "Excel",
            "SeaGreen"]);
            cb_Palette.Location = new Point(168, 16);
            cb_Palette.Name = "cb_Palette";
            cb_Palette.Size = new Size(128, 22);
            cb_Palette.TabIndex = 1;
            cb_Palette.SelectedIndexChanged += new EventHandler(cb_Palette_SelectedIndexChanged);
            // 
            // Palettes
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart2);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "Palettes";
            Size = new Size(760, 376);
            Load += new EventHandler(Palettes_Load);
            ((ISupportInitialize)(chart2)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void cb_CustomPalette_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateCustomPalette();
            chart2.Invalidate();
		}

		public void AddSeries(Chart chart, string seriesName)
		{
			Series s = new Series(seriesName);
			chart.Series.Add(s);
			chart.Series[seriesName].ChartType = SeriesChartType.Column;
			chart.Series[seriesName]["DrawingStyle"] = "Emboss";
		}

		public void GenerateData(Chart chart, string seriesName, int min, int max)
		{
			//random 
			DateTime dateSeries2;
			for (int pointIndex = 0; pointIndex < 5; pointIndex++)
			{
				dateSeries2 = DateTime.Now.AddDays(pointIndex);
				chart.Series[seriesName].Points.AddXY(dateSeries2, random.Next(min, max));
			}
		}

		
		public void FillSeries(Chart chart, int min, int max)
		{            
			// Add series to the chart
			string seriesName = "Series" + min;
			AddSeries(chart, seriesName);

			chart.Series[seriesName].BorderWidth = 3;
			chart.Series[seriesName].ShadowOffset = 1;

			// Fill the series with data
			GenerateData(chart, seriesName, min, max);
		}

		private void UpdateCustomPalette()
		{            
			Color[] colorSet;

            chart2.Palette = ChartColorPalette.None;
			if (cb_CustomPalette.SelectedItem.ToString() == "CorporateGold")
			{
				colorSet = [Color.FromArgb(224, 131, 10), Color.FromArgb(255, 227, 130), Color.FromArgb(251, 197, 65), Color.FromArgb(251, 180, 65)];
				chart2.PaletteCustomColors = colorSet;
			}

			else if (cb_CustomPalette.SelectedItem.ToString() == "CorporateBlue")
			{
				colorSet = [Color.FromArgb(5, 100, 146), Color.FromArgb(144, 218, 255), Color.FromArgb(149, 193, 254), Color.FromArgb(65, 140, 240)];
				chart2.PaletteCustomColors = colorSet;
			}

			else
			{
				colorSet = [Color.FromArgb(120, 147, 190), Color.FromArgb(241, 185, 168), Color.FromArgb(128, 184, 209), Color.FromArgb(243, 210, 136)];
				chart2.PaletteCustomColors = colorSet;
			}
		}
		

		private void UpdatePalette()
		{
			chart2.PaletteCustomColors = [];
			chart2.Palette = (ChartColorPalette)ChartColorPalette.Parse(typeof(ChartColorPalette), cb_Palette.SelectedItem.ToString());
		}

		private void cb_Palette_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdatePalette();
			chart2.Invalidate();
		}

		private void rb_CustomPalette_CheckedChanged(object sender, EventArgs e)
		{
			UpdateControls();
			UpdateCustomPalette();
        }

		private void UpdateControls()
		{			
			if (rb_CustomPalette.Checked) 
			{
				cb_Palette.Enabled = false;
				cb_CustomPalette.Enabled = true;
			}

			else 
			{
				cb_Palette.Enabled = true;
				cb_CustomPalette.Enabled = false;
			}
		}

		private void rb_Palette_CheckedChanged(object sender, EventArgs e)
		{
			UpdateControls();
			UpdatePalette();
		}

        private void Palettes_Load(object sender, EventArgs e)
        {

        }
	}
}
