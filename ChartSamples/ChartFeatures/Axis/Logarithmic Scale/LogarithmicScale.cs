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
	/// Summary description for AxisScale.
	/// </summary>
	public class LogarithmicScale : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label1;
		private Label label2;
		private ComboBox Base;
		private ComboBox MinorInterval;
		private CheckBox Logaritmic;
		private Label label3;
		private ComboBox MajorInterval;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public LogarithmicScale()
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
			DataPoint dataPoint1 = new DataPoint(0, 400);
			DataPoint dataPoint2 = new DataPoint(0, 2600);
			DataPoint dataPoint3 = new DataPoint(0, 1700);
			DataPoint dataPoint4 = new DataPoint(0, 3000);
			DataPoint dataPoint5 = new DataPoint(0, 200);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 1600);
			DataPoint dataPoint7 = new DataPoint(0, 2400);
			DataPoint dataPoint8 = new DataPoint(0, 2500);
			DataPoint dataPoint9 = new DataPoint(0, 2800);
			DataPoint dataPoint10 = new DataPoint(0, 1000);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 2100);
			DataPoint dataPoint12 = new DataPoint(0, 2100);
			DataPoint dataPoint13 = new DataPoint(0, 3200);
			DataPoint dataPoint14 = new DataPoint(0, 2500);
			DataPoint dataPoint15 = new DataPoint(0, 1500);
			label9 = new Label();
			panel1 = new Panel();
			label3 = new Label();
			MajorInterval = new ComboBox();
			label2 = new Label();
			MinorInterval = new ComboBox();
			label1 = new Label();
			Base = new ComboBox();
			Logaritmic = new CheckBox();
			Chart1 = new Chart();
			panel1.SuspendLayout();
			((ISupportInitialize)(Chart1)).BeginInit();
			SuspendLayout();
			// 
			// label9
			// 
			label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			label9.Location = new Point(16, 14);
			label9.Name = "label9";
			label9.Size = new Size(702, 34);
			label9.TabIndex = 0;
			label9.Text = "This sample demonstrates how to use a logarithmic scale and a logarithmic base.";
			label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 label3,
																				 MajorInterval,
																				 label2,
																				 MinorInterval,
																				 label1,
																				 Base,
																				 Logaritmic]);
			panel1.Location = new Point(432, 68);
			panel1.Name = "panel1";
			panel1.Size = new Size(292, 288);
			panel1.TabIndex = 2;
			panel1.Paint += new PaintEventHandler(panel1_Paint);
			// 
			// label3
			// 
			label3.Location = new Point(4, 64);
			label3.Name = "label3";
			label3.Size = new Size(160, 23);
			label3.TabIndex = 3;
			label3.Text = "Ma&jor Interval:";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MajorInterval
			// 
			MajorInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			MajorInterval.Items.AddRange([
															   "1",
															   "2",
															   "3"]);
			MajorInterval.Location = new Point(168, 64);
			MajorInterval.Name = "MajorInterval";
			MajorInterval.Size = new Size(112, 22);
			MajorInterval.TabIndex = 4;
			MajorInterval.SelectedIndexChanged += new EventHandler(MajorInterval_SelectedIndexChanged);
			// 
			// label2
			// 
			label2.Location = new Point(4, 96);
			label2.Name = "label2";
			label2.Size = new Size(160, 23);
			label2.TabIndex = 5;
			label2.Text = "Mi&nor Interval:";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MinorInterval
			// 
			MinorInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			MinorInterval.Items.AddRange([
															   "1",
															   "2",
															   "5"]);
			MinorInterval.Location = new Point(168, 96);
			MinorInterval.Name = "MinorInterval";
			MinorInterval.Size = new Size(112, 22);
			MinorInterval.TabIndex = 6;
			MinorInterval.SelectedIndexChanged += new EventHandler(MinorInterval_SelectedIndexChanged);
			// 
			// label1
			// 
			label1.Location = new Point(8, 32);
			label1.Name = "label1";
			label1.Size = new Size(156, 23);
			label1.TabIndex = 1;
			label1.Text = "Logarithmic &Base:";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Base
			// 
			Base.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			Base.Items.AddRange([
													  "10",
													  "2",
													  "e"]);
			Base.Location = new Point(168, 32);
			Base.Name = "Base";
			Base.Size = new Size(112, 22);
			Base.TabIndex = 2;
			Base.SelectedIndexChanged += new EventHandler(Base_SelectedIndexChanged);
			// 
			// Logaritmic
			// 
			Logaritmic.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			Logaritmic.Location = new Point(12, 8);
			Logaritmic.Name = "Logaritmic";
			Logaritmic.Size = new Size(168, 16);
			Logaritmic.TabIndex = 0;
			Logaritmic.Text = "&Logarithmic:";
			Logaritmic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			Logaritmic.CheckedChanged += new EventHandler(Logaritmic_CheckedChanged);
			// 
			// Chart1
			// 
			Chart1.BackColor = System.Drawing.Color.WhiteSmoke;
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
			chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LabelStyle.Format = "N0";
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.AxisX2.MajorGrid.Enabled = false;
			chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LabelStyle.Format = "N0";
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
            chartArea1.AxisY.MinorGrid.Enabled = true;
			chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.AxisY2.MajorGrid.Enabled = false;
			chartArea1.BackColor = System.Drawing.Color.Gainsboro;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			Chart1.ChartAreas.Add(chartArea1);
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Enabled = false;
			legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			Chart1.Legends.Add(legend1);
			Chart1.Location = new Point(16, 60);
			Chart1.Name = "Chart1";
			Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.Name = "Series1";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series2.Name = "Series2";
			series2.Points.Add(dataPoint6);
			series2.Points.Add(dataPoint7);
			series2.Points.Add(dataPoint8);
			series2.Points.Add(dataPoint9);
			series2.Points.Add(dataPoint10);
			series3.Name = "Series3";
			series3.Points.Add(dataPoint11);
			series3.Points.Add(dataPoint12);
			series3.Points.Add(dataPoint13);
			series3.Points.Add(dataPoint14);
			series3.Points.Add(dataPoint15);
			Chart1.Series.Add(series1);
			Chart1.Series.Add(series2);
			Chart1.Series.Add(series3);
			Chart1.Size = new Size(412, 296);
			Chart1.TabIndex = 1;
			Chart1.Click += new EventHandler(Chart1_Click);
			// 
			// LogarithmicScale
			// 
			Controls.AddRange([
																		  Chart1,
																		  panel1,
																		  label9]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "LogarithmicScale";
			Size = new Size(728, 480);
			Load += new EventHandler(LogarithmicScale_Load);
			panel1.ResumeLayout(false);
			((ISupportInitialize)(Chart1)).EndInit();
			ResumeLayout(false);

		}
		#endregion

		private void LogarithmicScale_Load(object sender, EventArgs e)
		{
			// Initialize combo boxes
			Base.SelectedIndex = 0;
			MajorInterval.SelectedIndex = 0;
			MinorInterval.SelectedIndex = 0;
		}

		private void SetData()
		{
			// If the Major Interval is not set get out
			if( MajorInterval.Text == "" )
			{
				return;
			}
			
			// The logarithmic scale is enabled
			if( Logaritmic.Checked == true )
			{

				// Enable combo boxes
				Base.Enabled = true;
				MajorInterval.Enabled = true;
				MinorInterval.Enabled = true;

				// Enable logarithmic scale
				Chart1.ChartAreas[0].AxisY.IsLogarithmic = true;

				// Set logarithmic base
				if( Base.Text == "10" || Base.Text == "2" )
				{
					Chart1.ChartAreas[0].AxisY.LogarithmBase = double.Parse( Base.Text );
				}
				else
				{
					Chart1.ChartAreas[0].AxisY.LogarithmBase = Math.E;
				}	

				// Set the interval for the axis and minor intervals 
				// for gridlines and tick marks.
				if( Base.Text == "10" && Logaritmic.Checked == true )
				{
					MinorInterval.Enabled = true;
					Chart1.ChartAreas[0].AxisY.Interval = double.Parse( MajorInterval.Text );
					Chart1.ChartAreas[0].AxisY.MinorTickMark.Interval = double.Parse( MinorInterval.Text );
					Chart1.ChartAreas[0].AxisY.MinorGrid.Interval = double.Parse( MinorInterval.Text );
					Chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = true;
					Chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = true;
				}
				else
				{
					MinorInterval.Enabled = false;
					Chart1.ChartAreas[0].AxisY.Interval = double.Parse( MajorInterval.Text );
					Chart1.ChartAreas[0].AxisY.MinorTickMark.Interval = 0;
					Chart1.ChartAreas[0].AxisY.MinorGrid.Interval = 0;
					Chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
					Chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = false;
				}
			}
			else
			{
				// Logarithmic axis are disabled
				Chart1.ChartAreas[0].AxisY.IsLogarithmic = false;
				Base.Enabled = false;
				MajorInterval.Enabled = false;
				MinorInterval.Enabled = false;				
				Chart1.ChartAreas[0].AxisY.MinorGrid.Interval = 0;
				Chart1.ChartAreas[0].AxisY.MinorTickMark.Interval = 0;
				Chart1.ChartAreas[0].AxisY.LogarithmBase = 10;
				Chart1.ChartAreas[0].AxisY.Interval = 0;
				Chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = true;
				Chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = true;
			}
		}

		private void Chart1_Click(object sender, EventArgs e)
		{
		
		}

		private void Logaritmic_CheckedChanged(object sender, EventArgs e)
		{
			SetData();
		}

		private void Base_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetData();
		}

		private void MinorInterval_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetData();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		
		}

		private void MajorInterval_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetData();
		}

	}
}
