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
	public class MultipleLegends : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private ComboBox comboBox3;
		private ComboBox comboBox4;
		private ComboBox comboBox5;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Splitter splitter1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public MultipleLegends()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			comboBox1.SelectedIndex = 0;
			comboBox2.SelectedIndex = 0;
			comboBox3.SelectedIndex = 1;
			comboBox4.SelectedIndex = 1;
			comboBox5.SelectedIndex = 1;
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
			Legend legend2 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(0, "36,84");
			DataPoint dataPoint2 = new DataPoint(0, "29,86");
			DataPoint dataPoint3 = new DataPoint(0, "8,76");
			DataPoint dataPoint4 = new DataPoint(0, "15,97");
			DataPoint dataPoint5 = new DataPoint(0, "24,76");
			DataPoint dataPoint6 = new DataPoint(0, "15,73");
			Series series2 = new Series();
			DataPoint dataPoint7 = new DataPoint(0, "32,78");
			DataPoint dataPoint8 = new DataPoint(0, "33,73");
			DataPoint dataPoint9 = new DataPoint(0, "35,63");
			DataPoint dataPoint10 = new DataPoint(0, "25,90");
			DataPoint dataPoint11 = new DataPoint(0, "44,70");
			DataPoint dataPoint12 = new DataPoint(0, "30,70");
			Series series3 = new Series();
			DataPoint dataPoint13 = new DataPoint(0, 47);
			DataPoint dataPoint14 = new DataPoint(0, 44);
			DataPoint dataPoint15 = new DataPoint(0, 37);
			DataPoint dataPoint16 = new DataPoint(0, 47);
			DataPoint dataPoint17 = new DataPoint(0, 53);
			DataPoint dataPoint18 = new DataPoint(0, 42);
			Series series4 = new Series();
			DataPoint dataPoint19 = new DataPoint(0, 66);
			DataPoint dataPoint20 = new DataPoint(0, 65);
			DataPoint dataPoint21 = new DataPoint(0, 67);
			DataPoint dataPoint22 = new DataPoint(0, 66);
			DataPoint dataPoint23 = new DataPoint(0, 66);
			DataPoint dataPoint24 = new DataPoint(0, 57);
			Series series5 = new Series();
			DataPoint dataPoint25 = new DataPoint(0, 55);
			DataPoint dataPoint26 = new DataPoint(0, 60);
			DataPoint dataPoint27 = new DataPoint(0, 53);
			DataPoint dataPoint28 = new DataPoint(0, 27);
			DataPoint dataPoint29 = new DataPoint(0, 29);
			DataPoint dataPoint30 = new DataPoint(0, 25);
            label9 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Chart1 = new Chart();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 43);
            label9.TabIndex = 1;
            label9.Text = "This sample demonstrates the use of multiple legends and how to associate differe" +
                "nt series to them.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(comboBox5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(432, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(156, 16);
            label1.TabIndex = 0;
            label1.Text = "Series &1 legend:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange([
            "Default",
            "Second"]);
            comboBox1.Location = new Point(168, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(120, 22);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.Items.AddRange([
            "Default",
            "Second"]);
            comboBox2.Location = new Point(168, 40);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(120, 22);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox3.Items.AddRange([
            "Default",
            "Second"]);
            comboBox3.Location = new Point(168, 72);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(120, 22);
            comboBox3.TabIndex = 5;
            comboBox3.SelectedIndexChanged += new EventHandler(comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox4.Items.AddRange([
            "Default",
            "Second"]);
            comboBox4.Location = new Point(168, 104);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(120, 22);
            comboBox4.TabIndex = 7;
            comboBox4.SelectedIndexChanged += new EventHandler(comboBox4_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox5.Items.AddRange([
            "Default",
            "Second"]);
            comboBox5.Location = new Point(168, 136);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(120, 22);
            comboBox5.TabIndex = 9;
            comboBox5.SelectedIndexChanged += new EventHandler(comboBox5_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(8, 43);
            label2.Name = "label2";
            label2.Size = new Size(156, 16);
            label2.TabIndex = 2;
            label2.Text = "Series &2 legend:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(8, 75);
            label3.Name = "label3";
            label3.Size = new Size(156, 16);
            label3.TabIndex = 4;
            label3.Text = "Series &3 legend:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(8, 107);
            label4.Name = "label4";
            label4.Size = new Size(156, 16);
            label4.TabIndex = 6;
            label4.Text = "Series &4 legend:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(8, 139);
            label5.Name = "label5";
            label5.Size = new Size(156, 16);
            label5.TabIndex = 8;
            label5.Text = "Series &5 legend:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Chart1
            // 
            Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            Chart1.BackSecondaryColor = System.Drawing.Color.White;
            Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
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
            chartArea1.AxisX.IsMarginVisible = false;
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
            chartArea1.AxisY.IsLabelAutoFit = false;
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
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            legend1.DockedToChartArea = "Default";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Second";
            Chart1.Legends.Add(legend1);
            Chart1.Legends.Add(legend2);
            Chart1.Location = new Point(16, 65);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Default";
            series1.Name = "Series 1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.ShadowOffset = 1;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.BorderWidth = 2;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Default";
            series2.Name = "Series 2";
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.ShadowOffset = 1;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.BorderWidth = 2;
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Second";
            series3.Name = "Series 3";
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            series3.Points.Add(dataPoint16);
            series3.Points.Add(dataPoint17);
            series3.Points.Add(dataPoint18);
            series3.ShadowOffset = 1;
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series4.BorderWidth = 2;
            series4.ChartArea = "Default";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Second";
            series4.Name = "Series 4";
            series4.Points.Add(dataPoint19);
            series4.Points.Add(dataPoint20);
            series4.Points.Add(dataPoint21);
            series4.Points.Add(dataPoint22);
            series4.Points.Add(dataPoint23);
            series4.Points.Add(dataPoint24);
            series4.ShadowOffset = 1;
            series5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series5.BorderWidth = 2;
            series5.ChartArea = "Default";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Second";
            series5.Name = "Series 5";
            series5.Points.Add(dataPoint25);
            series5.Points.Add(dataPoint26);
            series5.Points.Add(dataPoint27);
            series5.Points.Add(dataPoint28);
            series5.Points.Add(dataPoint29);
            series5.Points.Add(dataPoint30);
            series5.ShadowOffset = 1;
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Series.Add(series4);
            Chart1.Series.Add(series5);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 2;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 480);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // MultipleLegends
            // 
            Controls.Add(splitter1);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "MultipleLegends";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void LegendFont_Load(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Series["Series 1"].Legend = comboBox1.SelectedItem.ToString();
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Series["Series 2"].Legend = comboBox2.SelectedItem.ToString();	
		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Series["Series 3"].Legend = comboBox3.SelectedItem.ToString();	
		}

		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Series["Series 4"].Legend = comboBox4.SelectedItem.ToString();
		}

		private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Series["Series 5"].Legend = comboBox5.SelectedItem.ToString();
		}
	}
}
