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
	/// Summary description for AxisTitle.
	/// </summary>
	public class MultipleLegendsWithCheckBox : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private CheckBox checkBox1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public MultipleLegendsWithCheckBox()
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
			ChartArea chartArea2 = new ChartArea();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(0, 12);
			DataPoint dataPoint2 = new DataPoint(0, 12);
			DataPoint dataPoint3 = new DataPoint(0, 8);
			DataPoint dataPoint4 = new DataPoint(0, 15);
			DataPoint dataPoint5 = new DataPoint(0, 24);
			DataPoint dataPoint6 = new DataPoint(0, 15);
			Series series2 = new Series();
			DataPoint dataPoint7 = new DataPoint(0, 20);
			DataPoint dataPoint8 = new DataPoint(0, 33);
			DataPoint dataPoint9 = new DataPoint(0, 96);
			DataPoint dataPoint10 = new DataPoint(0, 66);
			DataPoint dataPoint11 = new DataPoint(0, 8);
			DataPoint dataPoint12 = new DataPoint(0, 30);
			Title title1 = new Title();
			Title title2 = new Title();
			label9 = new Label();
			panel1 = new Panel();
			checkBox1 = new CheckBox();
			Chart1 = new Chart();
			panel1.SuspendLayout();
			((ISupportInitialize)(Chart1)).BeginInit();
			SuspendLayout();
			// 
			// label9
			// 
			label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			label9.Location = new Point(16, 8);
			label9.Name = "label9";
			label9.Size = new Size(702, 34);
			label9.TabIndex = 0;
			label9.Text = "This sample demonstrates how to seperate one legend into two seperate legends.";
			label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 checkBox1]);
			panel1.Location = new Point(432, 56);
			panel1.Name = "panel1";
			panel1.Size = new Size(292, 288);
			panel1.TabIndex = 1;
			// 
			// checkBox1
			// 
			checkBox1.Location = new Point(48, 8);
			checkBox1.Name = "checkBox1";
			checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			checkBox1.Size = new Size(192, 16);
			checkBox1.TabIndex = 0;
			checkBox1.Text = "&Use two separate legends";
			checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
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
			chartArea1.Area3DStyle.Enable3D = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.PointGapDepth = 0;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BackColor = System.Drawing.Color.Transparent;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.Position.Auto = false;
			chartArea1.Position.Height = 42.32203F;
			chartArea1.Position.Width = 86F;
			chartArea1.Position.X = 4.824818F;
			chartArea1.Position.Y = 5.542373F;
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			chartArea2.AlignWithChartArea = "Default";
			chartArea2.Area3DStyle.IsClustered = true;
			chartArea2.Area3DStyle.Enable3D = true;
			chartArea2.Area3DStyle.Perspective = 10;
			chartArea2.Area3DStyle.PointGapDepth = 0;
			chartArea2.Area3DStyle.IsRightAngleAxes = false;
			chartArea2.Area3DStyle.WallWidth = 0;
			chartArea2.Area3DStyle.Inclination = 15;
			chartArea2.Area3DStyle.Rotation = 10;
			chartArea2.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.BackColor = System.Drawing.Color.Transparent;
			chartArea2.BackSecondaryColor = System.Drawing.Color.White;
			chartArea2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.Name = "Chart Area 2";
			chartArea2.Position.Auto = false;
			chartArea2.Position.Height = 42.32203F;
			chartArea2.Position.Width = 80F;
			chartArea2.Position.X = 4.824818F;
			chartArea2.Position.Y = 50.86441F;
			chartArea2.ShadowColor = System.Drawing.Color.Transparent;
			Chart1.ChartAreas.Add(chartArea1);
			Chart1.ChartAreas.Add(chartArea2);
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.BorderColor = System.Drawing.Color.Gray;
			legend1.IsDockedInsideChartArea = false;
			legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			Chart1.Legends.Add(legend1);
			Chart1.Location = new Point(16, 48);
			Chart1.Name = "Chart1";
			Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartArea = "Default";
			series1.ChartType = SeriesChartType.Pie;
			series1.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(65)), ((System.Byte)(140)), ((System.Byte)(240)));
			series1.Name = "Series 1";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.Points.Add(dataPoint6);
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series2.ChartArea = "Chart Area 2";
			series2.ChartType = SeriesChartType.Pie;
			series2.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(252)), ((System.Byte)(180)), ((System.Byte)(65)));
			series2.Name = "Series 2";
			series2.Points.Add(dataPoint7);
			series2.Points.Add(dataPoint8);
			series2.Points.Add(dataPoint9);
			series2.Points.Add(dataPoint10);
			series2.Points.Add(dataPoint11);
			series2.Points.Add(dataPoint12);
			Chart1.Series.Add(series1);
			Chart1.Series.Add(series2);
			Chart1.Size = new Size(412, 296);
			Chart1.TabIndex = 1;
			title1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
			title1.DockedToChartArea = "Default";
			title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
			title1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(32)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			title1.ShadowOffset = -3;
			title1.Text = "Series 1";
			title2.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
			title2.DockedToChartArea = "Chart Area 2";
			title2.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
			title2.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(32)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			title2.ShadowOffset = -3;
			title2.Text = "Series 2";
			Chart1.Titles.Add(title1);
			Chart1.Titles.Add(title2);
			// 
			// MultipleLegendsWithCheckBox
			// 
			Controls.AddRange([
																		  Chart1,
																		  panel1,
																		  label9]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "MultipleLegendsWithCheckBox";
			Size = new Size(728, 480);
			panel1.ResumeLayout(false);
			((ISupportInitialize)(Chart1)).EndInit();
			ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				// Add a second legend
				Legend secondLegend = new Legend("Second");
				secondLegend.BackColor = Color.FromArgb(((System.Byte)(220)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
				secondLegend.BorderColor = Color.Gray;
				secondLegend.Font = Chart1.Legends["Default"].Font;

				Chart1.Legends.Add(secondLegend);

				// Associate Series 2 with the second legend 
				Chart1.Series["Series 2"].Legend = "Second";

				// Dock the default legend inside the first chart area
				Chart1.Legends["Default"].IsDockedInsideChartArea = true;
				Chart1.Legends["Default"].DockedToChartArea = "Default";

				// Dock the second legend inside the second chart area
				secondLegend.IsDockedInsideChartArea = true;
				secondLegend.DockedToChartArea = "Chart Area 2";
			}
			else // button not checked
			{
				// Remove the second legend
				Legend secondLegend = Chart1.Legends["Second"];
				Chart1.Legends.Remove(secondLegend);

				// Assosiate Series 2 with the default legend
				Chart1.Series["Series 2"].Legend = "Default";

				// Undock the default legend from the first chart area
				Chart1.Legends["Default"].IsDockedInsideChartArea = false;
				Chart1.Legends["Default"].DockedToChartArea = "";
			}
		}

	}
}
