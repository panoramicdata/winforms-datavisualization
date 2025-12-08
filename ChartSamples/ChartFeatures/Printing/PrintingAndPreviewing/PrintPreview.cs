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
	/// Summary description for PrintPreview.
	/// </summary>
	public class PrintPreview : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Button buttonPrint;
		private Button buttonPreview;
		private Button buttonPageSetup;
		private CheckBox checkBoxShowPrinterDialog;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public PrintPreview()
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
			DataPoint dataPoint1 = new DataPoint(0, 6);
			DataPoint dataPoint2 = new DataPoint(0, 12);
			DataPoint dataPoint3 = new DataPoint(0, 8);
			DataPoint dataPoint4 = new DataPoint(0, 9);
			DataPoint dataPoint5 = new DataPoint(0, 7);
			DataPoint dataPoint6 = new DataPoint(0, 10);
			DataPoint dataPoint7 = new DataPoint(0, 5);
			DataPoint dataPoint8 = new DataPoint(0, 2);
			DataPoint dataPoint9 = new DataPoint(0, 4);
			DataPoint dataPoint10 = new DataPoint(0, 7);
			DataPoint dataPoint11 = new DataPoint(0, 6);
			Series series2 = new Series();
			DataPoint dataPoint12 = new DataPoint(0, 3);
			DataPoint dataPoint13 = new DataPoint(0, 7);
			DataPoint dataPoint14 = new DataPoint(0, 4);
			DataPoint dataPoint15 = new DataPoint(0, 1);
			DataPoint dataPoint16 = new DataPoint(0, 8);
			DataPoint dataPoint17 = new DataPoint(0, 7);
			DataPoint dataPoint18 = new DataPoint(0, 1);
			DataPoint dataPoint19 = new DataPoint(0, 2);
			DataPoint dataPoint20 = new DataPoint(0, 1);
			DataPoint dataPoint21 = new DataPoint(0, 2);
			DataPoint dataPoint22 = new DataPoint(0, 1);
			Title title1 = new Title();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            checkBoxShowPrinterDialog = new CheckBox();
            buttonPageSetup = new Button();
            buttonPreview = new Button();
            buttonPrint = new Button();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Enable3D = true;
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
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "Default";
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 63);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.LegendText = "Product A";
            series1.Name = "Series2";
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
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.LegendText = "Product B";
            series2.Name = "Default";
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
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Printing Sample";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 14);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 43);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates printing and previewing. Page settings are accessible th" +
                "rough the Page Setup dialog.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxShowPrinterDialog);
            panel1.Controls.Add(buttonPageSetup);
            panel1.Controls.Add(buttonPreview);
            panel1.Controls.Add(buttonPrint);
            panel1.Location = new Point(432, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // checkBoxShowPrinterDialog
            // 
            checkBoxShowPrinterDialog.Checked = true;
            checkBoxShowPrinterDialog.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxShowPrinterDialog.Location = new Point(168, 40);
            checkBoxShowPrinterDialog.Name = "checkBoxShowPrinterDialog";
            checkBoxShowPrinterDialog.Size = new Size(120, 40);
            checkBoxShowPrinterDialog.TabIndex = 2;
            checkBoxShowPrinterDialog.Text = "Show Printer &Dialog";
            // 
            // buttonPageSetup
            // 
            buttonPageSetup.BackColor = System.Drawing.SystemColors.Control;
            buttonPageSetup.Location = new Point(48, 8);
            buttonPageSetup.Name = "buttonPageSetup";
            buttonPageSetup.Size = new Size(104, 23);
            buttonPageSetup.TabIndex = 0;
            buttonPageSetup.Text = "Page &Setup";
            buttonPageSetup.UseVisualStyleBackColor = false;
            buttonPageSetup.Click += new EventHandler(buttonPageSetup_Click);
            // 
            // buttonPreview
            // 
            buttonPreview.BackColor = System.Drawing.SystemColors.Control;
            buttonPreview.Location = new Point(48, 88);
            buttonPreview.Name = "buttonPreview";
            buttonPreview.Size = new Size(104, 23);
            buttonPreview.TabIndex = 3;
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
            // PrintPreview
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PrintPreview";
            Size = new Size(728, 480);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void buttonPageSetup_Click(object sender, EventArgs e)
		{
			try
			{
				chart1.Printing.PageSetup();
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
				chart1.Printing.Print(checkBoxShowPrinterDialog.Checked);
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
				chart1.Printing.PrintPreview();
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Chart Control for .NET Framework", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

	}
}
