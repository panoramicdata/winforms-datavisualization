using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for CustomPrinting.
	/// </summary>
	public class CustomPrinting : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Button buttonPrintPreview;
		private Button buttonPrint;
		private Chart chart2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public CustomPrinting()
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
			DataPoint dataPoint1 = new DataPoint(0, 5);
			DataPoint dataPoint2 = new DataPoint(0, 9);
			DataPoint dataPoint3 = new DataPoint(0, 3);
			DataPoint dataPoint4 = new DataPoint(0, 1);
			DataPoint dataPoint5 = new DataPoint(0, 7);
			DataPoint dataPoint6 = new DataPoint(0, 3);
			DataPoint dataPoint7 = new DataPoint(0, 6);
			ComponentResourceManager resources = new ComponentResourceManager(typeof(CustomPrinting));
			ChartArea chartArea2 = new ChartArea();
			Legend legend2 = new Legend();
			Series series2 = new Series();
			DataPoint dataPoint8 = new DataPoint(0, 7);
			DataPoint dataPoint9 = new DataPoint(0, 4);
			DataPoint dataPoint10 = new DataPoint(0, 6);
			DataPoint dataPoint11 = new DataPoint(0, 1);
			DataPoint dataPoint12 = new DataPoint(0, 5);
			DataPoint dataPoint13 = new DataPoint(0, 8);
			DataPoint dataPoint14 = new DataPoint(0, 9);
			DataPoint dataPoint15 = new DataPoint(0, 4);
			DataPoint dataPoint16 = new DataPoint(0, 3);
			DataPoint dataPoint17 = new DataPoint(0, 7);
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            buttonPrint = new Button();
            buttonPrintPreview = new Button();
            chart2 = new Chart();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)(chart2)).BeginInit();
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
            chartArea1.AxisX.LabelStyle.Format = "MMM d";
            chartArea1.AxisX.LabelStyle.Interval = 1;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Interval = 1;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Interval = 1;
            chartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
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
            chart1.Location = new Point(16, 80);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Default";
            series1.Name = "Series1";
            dataPoint7.CustomProperties = "Exploded=true";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            chart1.Series.Add(series1);
            chart1.Size = new Size(256, 260);
            chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 14);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 60);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = resources.GetString("labelSampleComment.Text");
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonPrint);
            panel1.Controls.Add(buttonPrintPreview);
            panel1.Location = new Point(552, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 256);
            panel1.TabIndex = 2;
            // 
            // buttonPrint
            // 
            buttonPrint.BackColor = System.Drawing.SystemColors.Control;
            buttonPrint.Location = new Point(16, 40);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(128, 23);
            buttonPrint.TabIndex = 1;
            buttonPrint.Text = "Pri&nt";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += new EventHandler(buttonPrint_Click);
            // 
            // buttonPrintPreview
            // 
            buttonPrintPreview.BackColor = System.Drawing.SystemColors.Control;
            buttonPrintPreview.Location = new Point(16, 0);
            buttonPrintPreview.Name = "buttonPrintPreview";
            buttonPrintPreview.Size = new Size(128, 23);
            buttonPrintPreview.TabIndex = 0;
            buttonPrintPreview.Text = "Print &Preview";
            buttonPrintPreview.UseVisualStyleBackColor = false;
            buttonPrintPreview.Click += new EventHandler(buttonPreview_Click);
            // 
            // chart2
            // 
            chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart2.BackSecondaryColor = System.Drawing.Color.White;
            chart2.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart2.BorderlineWidth = 2;
            chart2.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea2.Area3DStyle.Inclination = 15;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Perspective = 10;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "Default";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            chart2.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Enabled = false;
            legend2.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Default";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(280, 80);
            chart2.Name = "chart2";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Default";
            series2.Name = "Default";
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.Points.Add(dataPoint15);
            series2.Points.Add(dataPoint16);
            series2.Points.Add(dataPoint17);
            chart2.Series.Add(series2);
            chart2.Size = new Size(256, 260);
            chart2.TabIndex = 3;
            // 
            // CustomPrinting
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(chart2);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "CustomPrinting";
            Size = new Size(728, 336);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(chart2)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void buttonPreview_Click(object sender, EventArgs e)
		{
			try
			{
				// Set new print document with custom page printing event handler
				chart1.Printing.PrintDocument = new PrintDocument();
				chart1.Printing.PrintDocument.PrintPage += new PrintPageEventHandler(pd_PrintPage);

				// Print preview chart
				chart1.Printing.PrintPreview();
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Chart Control for .NET Framework", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			try
			{
				// Set new print document with custom page printing event handler
				chart1.Printing.PrintDocument = new PrintDocument();
				chart1.Printing.PrintDocument.PrintPage += new PrintPageEventHandler(pd_PrintPage);

				// Print preview chart
				chart1.Printing.Print(true);
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Chart Control for .NET Framework", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		/// <summary>
		/// Handles PrintPage event of the document.
		/// </summary>
		/// <param name="sender">Sender object.</param>
		/// <param name="ev">Event parameters.</param>
		private void pd_PrintPage(object sender, PrintPageEventArgs ev) 
		{
			// Calculate title string position
			Rectangle	titlePosition = new Rectangle(ev.MarginBounds.X, ev.MarginBounds.Y, ev.MarginBounds.Width, ev.MarginBounds.Height);
			Font		fontTitle = new Font("Times New Roman", 16);
			string		chartTitle = "Two charts on the same page sample.";
			SizeF		titleSize = ev.Graphics.MeasureString(chartTitle, fontTitle);
			titlePosition.Height = (int)titleSize.Height;

			// Draw charts title
			StringFormat	format = new StringFormat();
			format.Alignment = StringAlignment.Center;
			ev.Graphics.DrawString(chartTitle, fontTitle, Brushes.Black, titlePosition, format);

			// Calculate first chart position rectangle
			Rectangle	chartPosition = new Rectangle(ev.MarginBounds.X, titlePosition.Bottom, chart1.Size.Width, chart1.Size.Height);

			// Align first chart position on the page
			float	chartWidthScale = ((float)ev.MarginBounds.Width/2f) / ((float)chartPosition.Width);
			float	chartHeightScale = ((float)ev.MarginBounds.Height) / ((float)chartPosition.Height);
			chartPosition.Width = (int)(chartPosition.Width * Math.Min(chartWidthScale, chartHeightScale));
			chartPosition.Height = (int)(chartPosition.Height * Math.Min(chartWidthScale, chartHeightScale));

			// Draw first chart on the printer graphics
			chart1.Printing.PrintPaint(ev.Graphics, chartPosition);

			// Adjust position rectangle for the second chart
			chartPosition.X += chartPosition.Width;

			// Draw second chart on the printer graphics
			chart2.Printing.PrintPaint(ev.Graphics, chartPosition);
		}

	}
}
