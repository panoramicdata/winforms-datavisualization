using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for PrinterFriendlyCharts.
	/// </summary>
	public class PrinterFriendlyCharts : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Button buttonPrint;
		private Button buttonPreview;
		private Label label1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public PrinterFriendlyCharts()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize combo boxes
		
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
			DataPoint dataPoint1 = new DataPoint(0, 3);
			DataPoint dataPoint2 = new DataPoint(0, 7);
			DataPoint dataPoint3 = new DataPoint(0, 4);
			DataPoint dataPoint4 = new DataPoint(0, 1);
			DataPoint dataPoint5 = new DataPoint(0, 8);
			DataPoint dataPoint6 = new DataPoint(0, 9);
			Series series2 = new Series();
			DataPoint dataPoint7 = new DataPoint(0, 6);
			DataPoint dataPoint8 = new DataPoint(0, 9);
			DataPoint dataPoint9 = new DataPoint(0, 7);
			DataPoint dataPoint10 = new DataPoint(0, 5);
			DataPoint dataPoint11 = new DataPoint(0, 6);
			DataPoint dataPoint12 = new DataPoint(0, 7);
			Title title1 = new Title();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            buttonPreview = new Button();
            buttonPrint = new Button();
            label1 = new Label();
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
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "Default";
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 40);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Printer Friendly Chart";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 32);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to create printer-friendly charts using serializatio" +
                "n.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonPreview);
            panel1.Controls.Add(buttonPrint);
            panel1.Location = new Point(432, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // buttonPreview
            // 
            buttonPreview.BackColor = System.Drawing.SystemColors.Control;
            buttonPreview.Location = new Point(48, 8);
            buttonPreview.Name = "buttonPreview";
            buttonPreview.Size = new Size(104, 23);
            buttonPreview.TabIndex = 0;
            buttonPreview.Text = "Previe&w";
            buttonPreview.UseVisualStyleBackColor = false;
            buttonPreview.Click += new EventHandler(buttonPreview_Click);
            // 
            // buttonPrint
            // 
            buttonPrint.BackColor = System.Drawing.SystemColors.Control;
            buttonPrint.Location = new Point(48, 48);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(104, 23);
            buttonPrint.TabIndex = 1;
            buttonPrint.Text = "&Print";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += new EventHandler(buttonPrint_Click);
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(13, 336);
            label1.Name = "label1";
            label1.Size = new Size(702, 48);
            label1.TabIndex = 3;
            label1.Text = "In this sample, a second chart is created and loaded with the data from the origi" +
                "nal chart. A printer friendly appearance is then applied to it, and the chart is" +
                " then printed.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PrinterFriendlyCharts
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PrinterFriendlyCharts";
            Size = new Size(728, 432);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			try
			{
				// Create printer friendly chart and print it
				Chart chart = CreatePrinterFriendlyChart(chart1);
				chart.Printing.Print(true);
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Chart Control for .NET Framework", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void buttonPreview_Click(object sender, EventArgs e)
		{
			try
			{
				// Create printer friendly chart and print preview it
				Chart chart = CreatePrinterFriendlyChart(chart1);
				chart.Printing.PrintPreview();
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Chart Control for .NET Framework", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		/// <summary>
		/// Method creates new printer friendly copy of the specified chart
		/// </summary>
		private Chart CreatePrinterFriendlyChart(Chart originalChart)
		{
			// Save original chart data points values and some additional properties into the stream
			MemoryStream memoryStream = new MemoryStream();
			originalChart.Serializer.Content = SerializationContents.Data;
			originalChart.Serializer.SerializableContent += ",*.ChartType,*.Title,*.TitleFont,Chart.Legend,*.Enabled,Chart.ChartAreas,ChartArea.Name";
			originalChart.Serializer.Save(memoryStream);

			// Create new chart control and load data from stream
			Chart	printerChart = new Chart();
			memoryStream.Seek(0, SeekOrigin.Begin);
			printerChart.Serializer.Load(memoryStream);
			memoryStream.Close();

			// Loop through all series
			Array	hatchingValues = Enum.GetValues(typeof(ChartHatchStyle));
			int		hatchingIndex = 1;
			foreach(Series series in printerChart.Series)
			{
				// Loop through all data points
				foreach(DataPoint point in series.Points)
				{
					// Set point colors and hatching
					point.BorderColor = Color.Black;
					point.Color = Color.White;
					point.BackSecondaryColor = Color.Black;
					point.BackHatchStyle = (ChartHatchStyle)hatchingValues.GetValue(hatchingIndex++);
					if(hatchingIndex >= hatchingValues.Length)
					{
						hatchingIndex = 1;
					}
				}
			}

			return printerChart;
		}

	}
}
