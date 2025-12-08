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
	/// Summary description for PrintingSettings.
	/// </summary>
	public class PrintingSettings : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Button buttonPreview;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxOrientation;
		private Label label2;
		private ComboBox comboBoxMargin;
		private ComboBox comboBoxResolution;
		private Label label3;
		private Button buttonPrint;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public PrintingSettings()
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
			DataPoint dataPoint1 = new DataPoint(0, "3,0");
			DataPoint dataPoint2 = new DataPoint(0, "7,0");
			DataPoint dataPoint3 = new DataPoint(0, "4,0");
			DataPoint dataPoint4 = new DataPoint(0, "1,0");
			DataPoint dataPoint5 = new DataPoint(0, "8,0");
			DataPoint dataPoint6 = new DataPoint(0, "9,0");
			DataPoint dataPoint7 = new DataPoint(0, "1,0");
			DataPoint dataPoint8 = new DataPoint(0, "2,0");
			DataPoint dataPoint9 = new DataPoint(0, "8,0");
			DataPoint dataPoint10 = new DataPoint(0, "6,0");
			DataPoint dataPoint11 = new DataPoint(0, "1,0");
			Series series2 = new Series();
			DataPoint dataPoint12 = new DataPoint(0, 5);
			DataPoint dataPoint13 = new DataPoint(0, 8);
			DataPoint dataPoint14 = new DataPoint(0, 2);
			DataPoint dataPoint15 = new DataPoint(0, 5);
			DataPoint dataPoint16 = new DataPoint(0, 6);
			DataPoint dataPoint17 = new DataPoint(0, 3);
			DataPoint dataPoint18 = new DataPoint(0, 9);
			DataPoint dataPoint19 = new DataPoint(0, 8);
			DataPoint dataPoint20 = new DataPoint(0, 4);
			DataPoint dataPoint21 = new DataPoint(0, 7);
			DataPoint dataPoint22 = new DataPoint(0, 2);
            chart1 = new Chart();
            labelSampleComment = new Label();
            buttonPreview = new Button();
            panel1 = new Panel();
            buttonPrint = new Button();
            comboBoxResolution = new ComboBox();
            label3 = new Label();
            comboBoxMargin = new ComboBox();
            label2 = new Label();
            comboBoxOrientation = new ComboBox();
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
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 83);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.LegendText = "Stage 1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.Points.Add(dataPoint10);
            series1.Points.Add(dataPoint11);
            series1.YValuesPerPoint = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.BorderWidth = 3;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Default";
            series2.LegendText = "Stage 2";
            series2.MarkerColor = System.Drawing.Color.Gold;
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series2";
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.Points.Add(dataPoint15);
            series2.Points.Add(dataPoint16);
            series2.Points.Add(dataPoint17);
            series2.Points.Add(dataPoint18);
            series2.Points.Add(dataPoint19);
            series2.Points.Add(dataPoint20);
            series2.Points.Add(dataPoint21);
            series2.Points.Add(dataPoint22);
            series2.ShadowColor = System.Drawing.Color.Black;
            series2.ShadowOffset = 2;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 64);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to programmatically change page settings like orient" +
                "ation and margins. Note that reducing page resolution also reduces the size of d" +
                "ata send to the printer.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPreview
            // 
            buttonPreview.BackColor = System.Drawing.SystemColors.Control;
            buttonPreview.Location = new Point(96, 128);
            buttonPreview.Name = "buttonPreview";
            buttonPreview.Size = new Size(120, 23);
            buttonPreview.TabIndex = 6;
            buttonPreview.Text = "Print Previe&w";
            buttonPreview.UseVisualStyleBackColor = false;
            buttonPreview.Click += new EventHandler(buttonPreview_Click);
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonPrint);
            panel1.Controls.Add(comboBoxResolution);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxMargin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxOrientation);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonPreview);
            panel1.Location = new Point(432, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // buttonPrint
            // 
            buttonPrint.BackColor = System.Drawing.SystemColors.Control;
            buttonPrint.Location = new Point(96, 168);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(120, 23);
            buttonPrint.TabIndex = 7;
            buttonPrint.Text = "&Print";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += new EventHandler(buttonPrint_Click);
            // 
            // comboBoxResolution
            // 
            comboBoxResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxResolution.Items.AddRange([
            "Low",
            "Medium",
            "High"]);
            comboBoxResolution.Location = new Point(168, 72);
            comboBoxResolution.Name = "comboBoxResolution";
            comboBoxResolution.Size = new Size(120, 22);
            comboBoxResolution.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new Point(8, 72);
            label3.Name = "label3";
            label3.Size = new Size(152, 23);
            label3.TabIndex = 4;
            label3.Text = "&Resolution:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMargin
            // 
            comboBoxMargin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxMargin.Items.AddRange([
            "0.5",
            "1",
            "1.5",
            "2"]);
            comboBoxMargin.Location = new Point(168, 40);
            comboBoxMargin.Name = "comboBoxMargin";
            comboBoxMargin.Size = new Size(120, 22);
            comboBoxMargin.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(8, 40);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 2;
            label2.Text = "All Side &Margin (inch):";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxOrientation
            // 
            comboBoxOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxOrientation.Items.AddRange([
            "Portrait",
            "Landscape"]);
            comboBoxOrientation.Location = new Point(168, 8);
            comboBoxOrientation.Name = "comboBoxOrientation";
            comboBoxOrientation.Size = new Size(120, 22);
            comboBoxOrientation.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 0;
            label1.Text = "Page &Orientation:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PrintingSettings
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PrintingSettings";
            Size = new Size(728, 480);
            Load += new EventHandler(PrintingSettings_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void SetPrintingSettings()
		{
			// Set page orientation
			if(comboBoxOrientation.Text == "Landscape")
			{
				chart1.Printing.PrintDocument.DefaultPageSettings.Landscape = true;
			}
			else
			{
				chart1.Printing.PrintDocument.DefaultPageSettings.Landscape = false;
			}

			// Set page margins
			int	margin = (int)(float.Parse(comboBoxMargin.Text) * 100f);
			chart1.Printing.PrintDocument.DefaultPageSettings.Margins =
                new System.Drawing.Printing.Margins(margin, margin, margin, margin);

			// Set printer resolution
			foreach(PrinterResolution pr in chart1.Printing.PrintDocument.PrinterSettings.PrinterResolutions)
			{
				if(pr.Kind.ToString() == comboBoxResolution.Text)
				{
					chart1.Printing.PrintDocument.DefaultPageSettings.PrinterResolution = pr;
				}
			}
		}

		private void buttonPreview_Click(object sender, EventArgs e)
		{
			try
			{
				// Set settings
				SetPrintingSettings();

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
				// Set settings
				SetPrintingSettings();

				// Print chart
				chart1.Printing.Print(true);
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Chart Control for .NET Framework", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void PrintingSettings_Load(object sender, EventArgs e)
		{
			comboBoxOrientation.SelectedIndex = 0;
			comboBoxMargin.SelectedIndex = 1;
			comboBoxResolution.SelectedIndex = 1;
		}

	}
}
