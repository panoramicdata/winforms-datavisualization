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
	/// Summary description for InterlacedStrips.
	/// </summary>
	public class InterlacedStrips : UserControl
	{
		private Label label7;
		private Label label9;
		private Panel panel1;
		private ComboBox LineColor;
		private Chart Chart1;
		private CheckBox StripsEnabledCheck;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public InterlacedStrips()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Add Colors to controls.
			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				LineColor.Items.Add(colorName);
			}

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
			DataPoint dataPoint1 = new DataPoint(0, "340,0");
			DataPoint dataPoint2 = new DataPoint(0, "760,0");
			DataPoint dataPoint3 = new DataPoint(0, "230,0");
			DataPoint dataPoint4 = new DataPoint(0, "470,0");
			DataPoint dataPoint5 = new DataPoint(0, "350,0");
			DataPoint dataPoint6 = new DataPoint(0, "840,0");
			DataPoint dataPoint7 = new DataPoint(0, "220,0");
			DataPoint dataPoint8 = new DataPoint(0, "750,0");
			Series series2 = new Series();
			DataPoint dataPoint9 = new DataPoint(0, "780,0");
			DataPoint dataPoint10 = new DataPoint(0, "670,0");
			DataPoint dataPoint11 = new DataPoint(0, "100,0");
			DataPoint dataPoint12 = new DataPoint(0, "560,0");
			DataPoint dataPoint13 = new DataPoint(0, "640,0");
			DataPoint dataPoint14 = new DataPoint(0, "230,0");
			DataPoint dataPoint15 = new DataPoint(0, "560,0");
			DataPoint dataPoint16 = new DataPoint(0, "440,0");
			Title title1 = new Title();
            LineColor = new ComboBox();
            label7 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            StripsEnabledCheck = new CheckBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // LineColor
            // 
            LineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LineColor.Location = new Point(168, 37);
            LineColor.Name = "LineColor";
            LineColor.Size = new Size(121, 22);
            LineColor.TabIndex = 2;
            LineColor.SelectedIndexChanged += new EventHandler(LineColor_SelectedIndexChanged);
            // 
            // label7
            // 
            label7.Location = new Point(9, 40);
            label7.Name = "label7";
            label7.Size = new Size(156, 16);
            label7.TabIndex = 1;
            label7.Text = "Strip &Color:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(24, 16);
            label9.Name = "label9";
            label9.Size = new Size(702, 41);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to add interlaced strip lines to an axis, and how to" +
                " set the appearance of strip lines.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(StripsEnabledCheck);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(LineColor);
            panel1.Location = new Point(432, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 296);
            panel1.TabIndex = 2;
            // 
            // StripsEnabledCheck
            // 
            StripsEnabledCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            StripsEnabledCheck.Checked = true;
            StripsEnabledCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            StripsEnabledCheck.Location = new Point(8, 8);
            StripsEnabledCheck.Name = "StripsEnabledCheck";
            StripsEnabledCheck.Size = new Size(176, 24);
            StripsEnabledCheck.TabIndex = 0;
            StripsEnabledCheck.Text = "Show &Strips:";
            StripsEnabledCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            StripsEnabledCheck.CheckedChanged += new EventHandler(Enabled_CheckedChanged);
            // 
            // Chart1
            // 
            Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            Chart1.BorderlineWidth = 2;
            Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(130)))));
            chartArea1.AxisY.IsInterlaced = true;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 65);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Default";
            series1.MarkerSize = 8;
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.ShadowOffset = 2;
            series1.YValuesPerPoint = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Default";
            series2.MarkerSize = 8;
            series2.Name = "Series2";
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.Points.Add(dataPoint15);
            series2.Points.Add(dataPoint16);
            series2.ShadowOffset = 2;
            series2.YValuesPerPoint = 2;
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Size = new Size(412, 306);
            Chart1.TabIndex = 1;
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Interlaced Strips";
            Chart1.Titles.Add(title1);
            // 
            // InterlacedStrips
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "InterlacedStrips";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void LineColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.ChartAreas["Default"].AxisY.InterlacedColor = Color.FromName(LineColor.SelectedItem.ToString());
		}

		private void Enabled_CheckedChanged(object sender, EventArgs e)
		{
			Chart1.ChartAreas["Default"].AxisY.IsInterlaced = StripsEnabledCheck.Checked;
			LineColor.Enabled = StripsEnabledCheck.Checked;
		}


	}
}
