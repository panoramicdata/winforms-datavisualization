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
	/// Summary description for ParetoChartType.
	/// </summary>
	public class ParetoChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxNumberOfPoints;
		private CheckBox checkBoxShow3D;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public ParetoChartType()
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
            checkBoxShow3D = new CheckBox();
            comboBoxNumberOfPoints = new ComboBox();
            label1 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BackSecondaryColor = System.Drawing.Color.White;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Interval = 25;
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
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
            chart1.Location = new Point(16, 43);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Default";
            chart1.Series.Add(series1);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 32);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample shows how to create a Pareto chart by using Column and Line charts to" +
                "gether. ";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxShow3D);
            panel1.Controls.Add(comboBoxNumberOfPoints);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // checkBoxShow3D
            // 
            checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.Location = new Point(14, 42);
            checkBoxShow3D.Name = "checkBoxShow3D";
            checkBoxShow3D.Size = new Size(168, 24);
            checkBoxShow3D.TabIndex = 2;
            checkBoxShow3D.Text = "Display chart as 3&D:";
            checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.CheckedChanged += new EventHandler(checkBoxShow3D_CheckedChanged);
            // 
            // comboBoxNumberOfPoints
            // 
            comboBoxNumberOfPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxNumberOfPoints.Items.AddRange([
            "5",
            "8",
            "10"]);
            comboBoxNumberOfPoints.Location = new Point(168, 8);
            comboBoxNumberOfPoints.Name = "comboBoxNumberOfPoints";
            comboBoxNumberOfPoints.Size = new Size(72, 22);
            comboBoxNumberOfPoints.TabIndex = 1;
            comboBoxNumberOfPoints.SelectedIndexChanged += new EventHandler(comboBoxNumberOfPoints_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(43, 8);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 0;
            label1.Text = "Number of Points:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ParetoChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "ParetoChartType";
            Size = new Size(728, 368);
            Load += new EventHandler(ParetoChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void comboBoxNumberOfPoints_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Number of data points
			int numOfPoints = int.Parse( comboBoxNumberOfPoints.Text );

			// Generate rundom data
			RandomData( chart1.Series["Default"], numOfPoints );

			// Make Pareto Chart
			if(chart1.Series.Count > 1)
				chart1.Series.RemoveAt(1);
			MakeParetoChart( chart1, "Default", "Pareto" );
						
			// Set chart types for output data
			chart1.Series["Pareto"].ChartType = SeriesChartType.Line;

			// Set Color of line Pareto chart
			chart1.Series["Pareto"].Color = Color.FromArgb(252, 180, 65);

			// set the markers for each point of the Pareto Line
			chart1.Series["Pareto"].IsValueShownAsLabel = true;
			chart1.Series["Pareto"].MarkerColor = Color.Red;
			chart1.Series["Pareto"].MarkerStyle = MarkerStyle.Circle;
			chart1.Series["Pareto"].MarkerBorderColor = Color.MidnightBlue;
			chart1.Series["Pareto"].MarkerSize = 8;
			chart1.Series["Pareto"].LabelFormat = "0.#";  // format with one decimal and leading zero
		} 

		private void ParetoChartType_Load(object sender, EventArgs e)
		{
			comboBoxNumberOfPoints.SelectedIndex = 0;
		}

		private void RandomData(Series series, int numOfPoints)
		{
			Random rand = new Random();

			// Generate random Y values
			series.Points.Clear();
			for( int point = 0; point < numOfPoints; point++ )
			{
				series.Points.AddY( rand.Next(250) + 1 );
			}
		}

		void MakeParetoChart(Chart chart, string srcSeriesName, string destSeriesName)
		{

			// get name of the ChartAre of the source series
			string strChartArea = chart.Series[srcSeriesName].ChartArea;

			// ensure the source series is a column chart type
			chart.Series[srcSeriesName].ChartType = SeriesChartType.Column;

			// sort the data in the series to be by values in descending order
			chart.DataManipulator.Sort(PointSortOrder.Descending, srcSeriesName);

			// find the total of all points in the source series
			double total = 0.0;
			foreach (DataPoint pt in chart.Series[srcSeriesName].Points)
				total += pt.YValues[0];

			// set the max value on the primary axis to total
			chart.ChartAreas[strChartArea].AxisY.Maximum = total;

			// create the destination series and add it to the chart
			Series destSeries = new Series(destSeriesName);
			chart.Series.Add(destSeries);

			// ensure the destination series is a Line or Spline chart type
			destSeries.ChartType = SeriesChartType.Line;

			destSeries.BorderWidth = 3;

			// assign the series to the same chart area as the column chart
			destSeries.ChartArea = chart.Series[srcSeriesName].ChartArea;

			// assign this series to use the secondary axis and set it maximum to be 100%
			destSeries.YAxisType = AxisType.Secondary;
			chart.ChartAreas[strChartArea].AxisY2.Maximum = 100; 

			// locale specific percentage format with no decimals
			chart.ChartAreas[strChartArea].AxisY2.LabelStyle.Format = "P0";

			// turn off the end point values of the primary X axis
			chart.ChartAreas[strChartArea].AxisX.LabelStyle.IsEndLabelVisible = false;

			// for each point in the source series find % of total and assign to series
			double percentage = 0.0;

			foreach(DataPoint pt in chart.Series[srcSeriesName].Points)
			{
				percentage += (pt.YValues[0] / total * 100.0);
				destSeries.Points.Add(Math.Round(percentage,2));
			}
		}

		private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxShow3D.Checked)
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
				chart1.ChartAreas["Default"].Area3DStyle.LightStyle = LightStyle.Realistic;
				chart1.ChartAreas["Default"].Area3DStyle.Inclination = 15;
				chart1.ChartAreas["Default"].Area3DStyle.Rotation = 15;
				//show marker lines
				chart1.Series["Pareto"]["ShowMarkerLines"] = "True";
				chart1.Series["Pareto"].IsValueShownAsLabel = false;
			}
			else
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;
				chart1.Series["Pareto"].IsValueShownAsLabel = true;
			}
		}
		
	}
}
