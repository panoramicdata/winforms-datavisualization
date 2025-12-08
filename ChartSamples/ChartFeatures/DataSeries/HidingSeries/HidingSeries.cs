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
	/// Summary description for AxisAppearance.
	/// </summary>
	public class HidingSeries : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label15;
		private CheckBox HideSeries1;
		private CheckBox HideSeries2;
		private CheckBox HideSeries3;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public HidingSeries()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
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
			DataPoint dataPoint3 = new DataPoint(0, 8);
			DataPoint dataPoint4 = new DataPoint(0, 6);
			DataPoint dataPoint5 = new DataPoint(0, 7);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 4);
			DataPoint dataPoint7 = new DataPoint(0, 3);
			DataPoint dataPoint8 = new DataPoint(0, 6);
			DataPoint dataPoint9 = new DataPoint(0, 5);
			DataPoint dataPoint10 = new DataPoint(0, 8);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 4);
			DataPoint dataPoint12 = new DataPoint(0, 7);
			DataPoint dataPoint13 = new DataPoint(0, 5);
			DataPoint dataPoint14 = new DataPoint(0, 8);
			DataPoint dataPoint15 = new DataPoint(0, 6);
			Series series4 = new Series();
			DataPoint dataPoint16 = new DataPoint(0, 6);
			DataPoint dataPoint17 = new DataPoint(0, 2);
			DataPoint dataPoint18 = new DataPoint(0, 4);
			DataPoint dataPoint19 = new DataPoint(0, 5);
			DataPoint dataPoint20 = new DataPoint(0, 9);
			label9 = new Label();
			panel1 = new Panel();
			HideSeries3 = new CheckBox();
			HideSeries2 = new CheckBox();
			HideSeries1 = new CheckBox();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label15 = new Label();
			Chart1 = new Chart();
			panel1.SuspendLayout();
			((ISupportInitialize)(Chart1)).BeginInit();
			SuspendLayout();
			// 
			// label9
			// 
			label9.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			label9.Location = new Point(16, 8);
			label9.Name = "label9";
			label9.Size = new Size(702, 34);
			label9.TabIndex = 0;
			label9.Text = "This sample demonstrates how to hide a data series.";
			label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 HideSeries3,
																				 HideSeries2,
																				 HideSeries1,
																				 label8,
																				 label7,
																				 label6,
																				 label5,
																				 label4,
																				 label3,
																				 label15]);
			panel1.Location = new Point(432, 56);
			panel1.Name = "panel1";
			panel1.Size = new Size(292, 288);
			panel1.TabIndex = 2;
			// 
			// HideSeries3
			// 
			HideSeries3.Location = new Point(48, 72);
			HideSeries3.Name = "HideSeries3";
			HideSeries3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			HideSeries3.Size = new Size(172, 24);
			HideSeries3.TabIndex = 2;
			HideSeries3.Text = "Hide Series &3";
			HideSeries3.CheckedChanged += new EventHandler(Hide_CheckedChanged);
			// 
			// HideSeries2
			// 
			HideSeries2.Location = new Point(48, 40);
			HideSeries2.Name = "HideSeries2";
			HideSeries2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			HideSeries2.Size = new Size(172, 24);
			HideSeries2.TabIndex = 1;
			HideSeries2.Text = "Hide Series &2";
			HideSeries2.CheckedChanged += new EventHandler(Hide_CheckedChanged);
			// 
			// HideSeries1
			// 
			HideSeries1.Location = new Point(48, 8);
			HideSeries1.Name = "HideSeries1";
			HideSeries1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			HideSeries1.Size = new Size(172, 24);
			HideSeries1.TabIndex = 0;
			HideSeries1.Text = "Hide Series &1";
			HideSeries1.CheckedChanged += new EventHandler(Hide_CheckedChanged);
			// 
			// label8
			// 
			label8.Location = new Point(64, 472);
			label8.Name = "label8";
			label8.TabIndex = 7;
			label8.Text = "Shadow Offset:";
			// 
			// label7
			// 
			label7.Location = new Point(64, 449);
			label7.Name = "label7";
			label7.TabIndex = 6;
			label7.Text = "Border Style:";
			// 
			// label6
			// 
			label6.Location = new Point(64, 403);
			label6.Name = "label6";
			label6.TabIndex = 3;
			label6.Text = "Border Size:";
			// 
			// label5
			// 
			label5.Location = new Point(64, 380);
			label5.Name = "label5";
			label5.TabIndex = 2;
			label5.Text = "Border Color:";
			// 
			// label4
			// 
			label4.Location = new Point(64, 357);
			label4.Name = "label4";
			label4.TabIndex = 1;
			label4.Text = "Hatch Style:";
			// 
			// label3
			// 
			label3.Location = new Point(64, 334);
			label3.Name = "label3";
			label3.TabIndex = 0;
			label3.Text = "Gradient:";
			// 
			// label15
			// 
			label15.Location = new Point(64, 426);
			label15.Name = "label15";
			label15.TabIndex = 5;
			label15.Text = "Border Size:";
			// 
			// Chart1
			// 
			Chart1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(223)), ((System.Byte)(240)));
			Chart1.BackSecondaryColor = System.Drawing.Color.White;
			Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			Chart1.BorderlineWidth = 2;
			Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LabelStyle.Format = "dd MMM";
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(165)), ((System.Byte)(191)), ((System.Byte)(228)));
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			Chart1.ChartAreas.Add(chartArea1);
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
			legend1.DockedToChartArea = "Default";
			legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Table;
			legend1.Name = "Default";
			Chart1.Legends.Add(legend1);
			Chart1.Location = new Point(16, 56);
			Chart1.Name = "Chart1";
			Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartArea = "Default";
			series1.Name = "Series1";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series2.ChartArea = "Default";
			series2.Name = "Series4";
			series2.Points.Add(dataPoint6);
			series2.Points.Add(dataPoint7);
			series2.Points.Add(dataPoint8);
			series2.Points.Add(dataPoint9);
			series2.Points.Add(dataPoint10);
			series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series3.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series3.BorderWidth = 2;
			series3.ChartArea = "Default";
			series3.ChartType = SeriesChartType.Spline;
			series3.Name = "Series2";
			series3.Points.Add(dataPoint11);
			series3.Points.Add(dataPoint12);
			series3.Points.Add(dataPoint13);
			series3.Points.Add(dataPoint14);
			series3.Points.Add(dataPoint15);
			series3.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			series3.ShadowOffset = 2;
			series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series4.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series4.BorderWidth = 2;
			series4.ChartArea = "Default";
			series4.ChartType = SeriesChartType.StepLine;
			series4.Color = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series4.Name = "Series3";
			series4.Points.Add(dataPoint16);
			series4.Points.Add(dataPoint17);
			series4.Points.Add(dataPoint18);
			series4.Points.Add(dataPoint19);
			series4.Points.Add(dataPoint20);
			series4.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			series4.ShadowOffset = 2;
			series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			Chart1.Series.Add(series1);
			Chart1.Series.Add(series2);
			Chart1.Series.Add(series3);
			Chart1.Series.Add(series4);
			Chart1.Size = new Size(412, 296);
			Chart1.TabIndex = 1;
			Chart1.Click += new EventHandler(Chart1_Click);
			// 
			// HidingSeries
			// 
			Controls.AddRange([
																		  Chart1,
																		  panel1,
																		  label9]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "HidingSeries";
			Size = new Size(728, 480);
			Load += new EventHandler(HidingSeries_Load);
			panel1.ResumeLayout(false);
			((ISupportInitialize)(Chart1)).EndInit();
			ResumeLayout(false);

		}
		#endregion

		
		private void HideSeries()
		{
			Chart1.Series["Series1"].ChartArea = "Default";
			Chart1.Series["Series2"].ChartArea = "Default";
			Chart1.Series["Series3"].ChartArea = "Default";

			// Hide series by setting the Chart Area name to empty string
			Chart1.Series["Series1"].Enabled = !HideSeries1.Checked;
			Chart1.Series["Series2"].Enabled = !HideSeries2.Checked;
			Chart1.Series["Series3"].Enabled = !HideSeries3.Checked;
		}
				
		private void Hide_CheckedChanged(object sender, EventArgs e)
		{
			HideSeries();
		}

		private void Chart1_Click(object sender, EventArgs e)
		{
		
		}

		private void HidingSeries_Load(object sender, EventArgs e)
		{
			HideSeries();
		}


	}
}
