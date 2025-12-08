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
	/// Summary description for GridLinesTicks.
	/// </summary>
	public class GridLinesTicks : UserControl
	{
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private ComboBox MajorInterval;
		private ComboBox MajorLineColor;
		private ComboBox MajorLineDashStyle;
		private ComboBox MajorLineWidth;
		private ComboBox Major;
		private Label label1;
		private Label label2;
		private ComboBox Minor;
		private ComboBox MinorLineDashStyle;
		private Label label3;
		private Label label4;
		private ComboBox MinorInterval;
		private Label label10;
		private Label label11;
		private ComboBox MinorLineWidth;
		private ComboBox MinorLineColor;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public GridLinesTicks()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Populate list of intervals
			double[] intervals = [0.1, 0.2, 0.5];
			foreach(double interval in intervals)
			{
				MinorInterval.Items.Add(interval.ToString());
			}
	
			foreach(string lineName in Enum.GetNames(typeof(ChartDashStyle)))
			{
				MinorLineDashStyle.Items.Add(lineName);
				MajorLineDashStyle.Items.Add(lineName);
			}
			MajorLineDashStyle.SelectedIndex = 5;
			MinorLineDashStyle.SelectedIndex = 5;

			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				MinorLineColor.Items.Add(colorName);
				MajorLineColor.Items.Add(colorName);
			}

			MajorLineColor.SelectedIndex = MajorLineColor.Items.IndexOf("DimGray");
			MinorLineColor.SelectedIndex = MinorLineColor.Items.IndexOf("LightGray");;

			MajorLineWidth.SelectedIndex = 1;
			MinorLineWidth.SelectedIndex = 0;

			Major.SelectedIndex = 0;
			Minor.SelectedIndex = 0;

			MajorInterval.SelectedIndex = 0;
			MinorInterval.SelectedIndex = 0;

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
			DataPoint dataPoint1 = new DataPoint(0, 700);
			DataPoint dataPoint2 = new DataPoint(0, 400);
			DataPoint dataPoint3 = new DataPoint(0, 500);
			DataPoint dataPoint4 = new DataPoint(0, 600);
			DataPoint dataPoint5 = new DataPoint(0, 450);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 600);
			DataPoint dataPoint7 = new DataPoint(0, 500);
			DataPoint dataPoint8 = new DataPoint(0, 600);
			DataPoint dataPoint9 = new DataPoint(0, 500);
			DataPoint dataPoint10 = new DataPoint(0, 550);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 500);
			DataPoint dataPoint12 = new DataPoint(0, 600);
			DataPoint dataPoint13 = new DataPoint(0, 700);
			DataPoint dataPoint14 = new DataPoint(0, 400);
			DataPoint dataPoint15 = new DataPoint(0, 600);
			Title title1 = new Title();
            MajorInterval = new ComboBox();
            MajorLineColor = new ComboBox();
            MajorLineDashStyle = new ComboBox();
            MajorLineWidth = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            Minor = new ComboBox();
            MinorLineDashStyle = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            MinorInterval = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            MinorLineWidth = new ComboBox();
            MinorLineColor = new ComboBox();
            label1 = new Label();
            Major = new ComboBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // MajorInterval
            // 
            MajorInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MajorInterval.Items.AddRange([
            "1",
            "2",
            "3"]);
            MajorInterval.Location = new Point(168, 136);
            MajorInterval.Name = "MajorInterval";
            MajorInterval.Size = new Size(121, 22);
            MajorInterval.TabIndex = 9;
            MajorInterval.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // MajorLineColor
            // 
            MajorLineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MajorLineColor.Location = new Point(168, 72);
            MajorLineColor.Name = "MajorLineColor";
            MajorLineColor.Size = new Size(121, 22);
            MajorLineColor.TabIndex = 5;
            MajorLineColor.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // MajorLineDashStyle
            // 
            MajorLineDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MajorLineDashStyle.Location = new Point(168, 40);
            MajorLineDashStyle.Name = "MajorLineDashStyle";
            MajorLineDashStyle.Size = new Size(121, 22);
            MajorLineDashStyle.TabIndex = 3;
            MajorLineDashStyle.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // MajorLineWidth
            // 
            MajorLineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MajorLineWidth.Items.AddRange([
            "1",
            "2",
            "3",
            "4"]);
            MajorLineWidth.Location = new Point(168, 104);
            MajorLineWidth.Name = "MajorLineWidth";
            MajorLineWidth.Size = new Size(121, 22);
            MajorLineWidth.TabIndex = 7;
            MajorLineWidth.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // label5
            // 
            label5.Location = new Point(86, 144);
            label5.Name = "label5";
            label5.Size = new Size(80, 16);
            label5.TabIndex = 8;
            label5.Text = "&Interval:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(86, 48);
            label6.Name = "label6";
            label6.Size = new Size(80, 16);
            label6.TabIndex = 2;
            label6.Text = "Line &Style:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(86, 80);
            label7.Name = "label7";
            label7.Size = new Size(80, 16);
            label7.TabIndex = 4;
            label7.Text = "Line &Color:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new Point(86, 112);
            label8.Name = "label8";
            label8.Size = new Size(80, 16);
            label8.TabIndex = 6;
            label8.Text = "Line &Width:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to set the appearance of grid lines and tick marks.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Minor);
            panel1.Controls.Add(MinorLineDashStyle);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(MinorInterval);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(MinorLineWidth);
            panel1.Controls.Add(MinorLineColor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Major);
            panel1.Controls.Add(MajorLineDashStyle);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(MajorInterval);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(MajorLineWidth);
            panel1.Controls.Add(MajorLineColor);
            panel1.Location = new Point(432, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 340);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(86, 184);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 10;
            label2.Text = "Mi&nor:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Minor
            // 
            Minor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Minor.Items.AddRange([
            "Grid Lines",
            "Tick Marks"]);
            Minor.Location = new Point(168, 176);
            Minor.Name = "Minor";
            Minor.Size = new Size(121, 22);
            Minor.TabIndex = 11;
            Minor.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // MinorLineDashStyle
            // 
            MinorLineDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MinorLineDashStyle.Location = new Point(168, 208);
            MinorLineDashStyle.Name = "MinorLineDashStyle";
            MinorLineDashStyle.Size = new Size(121, 22);
            MinorLineDashStyle.TabIndex = 13;
            MinorLineDashStyle.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(86, 312);
            label3.Name = "label3";
            label3.Size = new Size(80, 16);
            label3.TabIndex = 18;
            label3.Text = "In&terval:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(86, 216);
            label4.Name = "label4";
            label4.Size = new Size(80, 16);
            label4.TabIndex = 12;
            label4.Text = "Line S&tyle:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MinorInterval
            // 
            MinorInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MinorInterval.Location = new Point(168, 304);
            MinorInterval.Name = "MinorInterval";
            MinorInterval.Size = new Size(121, 22);
            MinorInterval.TabIndex = 19;
            MinorInterval.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // label10
            // 
            label10.Location = new Point(86, 248);
            label10.Name = "label10";
            label10.Size = new Size(80, 16);
            label10.TabIndex = 14;
            label10.Text = "Line C&olor:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Location = new Point(86, 280);
            label11.Name = "label11";
            label11.Size = new Size(80, 16);
            label11.TabIndex = 16;
            label11.Text = "Line Wi&dth:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MinorLineWidth
            // 
            MinorLineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MinorLineWidth.Items.AddRange([
            "1",
            "2",
            "3",
            "4"]);
            MinorLineWidth.Location = new Point(168, 272);
            MinorLineWidth.Name = "MinorLineWidth";
            MinorLineWidth.Size = new Size(121, 22);
            MinorLineWidth.TabIndex = 17;
            MinorLineWidth.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // MinorLineColor
            // 
            MinorLineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MinorLineColor.Location = new Point(168, 240);
            MinorLineColor.Name = "MinorLineColor";
            MinorLineColor.Size = new Size(121, 22);
            MinorLineColor.TabIndex = 15;
            MinorLineColor.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(86, 16);
            label1.Name = "label1";
            label1.Size = new Size(80, 16);
            label1.TabIndex = 0;
            label1.Text = "Ma&jor:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Major
            // 
            Major.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Major.Items.AddRange([
            "Grid Lines",
            "Tick Marks"]);
            Major.Location = new Point(168, 8);
            Major.Name = "Major";
            Major.Size = new Size(121, 22);
            Major.TabIndex = 1;
            Major.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // Chart1
            // 
            Chart1.BackColor = System.Drawing.Color.WhiteSmoke;
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
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Size = 2F;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 60);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Size = new Size(412, 306);
            Chart1.TabIndex = 1;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Grid Lines and Tick Marks";
            Chart1.Titles.Add(title1);
            // 
            // GridLinesTicks
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "GridLinesTicks";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void ControlSelectedIndexChanged(object sender, EventArgs e)
		{
			// Disable all elements
			Chart1.ChartAreas["Default"].AxisX.MajorGrid.Enabled = false;
			Chart1.ChartAreas["Default"].AxisX.MajorTickMark.Enabled = false;
			Chart1.ChartAreas["Default"].AxisX.MinorGrid.Enabled = false;
			Chart1.ChartAreas["Default"].AxisX.MinorTickMark.Enabled = false;

			// Enable Major selected element
			if(Major.SelectedIndex >= 0)
			{
				switch( Major.SelectedItem.ToString())
				{
					case "Grid Lines":
						Chart1.ChartAreas["Default"].AxisX.MajorGrid.Enabled = true;
						break;
					case "Tick Marks":
						Chart1.ChartAreas["Default"].AxisX.MajorTickMark.Enabled = true;
						break;
				}
			}

			// Enable Minor selected element
			if(Minor.SelectedIndex >= 0)
			{
				switch( Minor.SelectedItem.ToString() )
				{
					case "Grid Lines":
						Chart1.ChartAreas["Default"].AxisX.MinorGrid.Enabled = true;
						break;
					case "Tick Marks":
						Chart1.ChartAreas["Default"].AxisX.MinorTickMark.Enabled = true;
						break;
				}
			}

			// Set Grid lines and tick marks interval
			if(MajorInterval.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MajorGrid.Interval = double.Parse( MajorInterval.SelectedItem.ToString() );
				Chart1.ChartAreas["Default"].AxisX.MajorTickMark.Interval = double.Parse( MajorInterval.SelectedItem.ToString() );
			}

			if(MinorInterval.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MinorGrid.Interval = double.Parse( MinorInterval.SelectedItem.ToString() );
				Chart1.ChartAreas["Default"].AxisX.MinorTickMark.Interval = double.Parse( MinorInterval.SelectedItem.ToString() );
			}

			// Set Line Color
			if(MajorLineColor.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MajorGrid.LineColor = Color.FromName(MajorLineColor.SelectedItem.ToString());
				Chart1.ChartAreas["Default"].AxisX.MajorTickMark.LineColor = Color.FromName(MajorLineColor.SelectedItem.ToString());
			}
			
			if(MinorLineColor.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MinorGrid.LineColor = Color.FromName(MinorLineColor.SelectedItem.ToString());
				Chart1.ChartAreas["Default"].AxisX.MinorTickMark.LineColor = Color.FromName(MinorLineColor.SelectedItem.ToString());
			}
			
			// Set Line Style
			if(MajorLineDashStyle.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MajorGrid.LineDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), MajorLineDashStyle.SelectedItem.ToString());
				Chart1.ChartAreas["Default"].AxisX.MajorTickMark.LineDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), MajorLineDashStyle.SelectedItem.ToString());
			}

			if(MinorLineDashStyle.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MinorGrid.LineDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), MinorLineDashStyle.SelectedItem.ToString());
				Chart1.ChartAreas["Default"].AxisX.MinorTickMark.LineDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), MinorLineDashStyle.SelectedItem.ToString());
			}
			
			// Set Line Width
			if(MajorLineWidth.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MajorGrid.LineWidth = int.Parse(MajorLineWidth.SelectedItem.ToString());
				Chart1.ChartAreas["Default"].AxisX.MajorTickMark.LineWidth = int.Parse(MajorLineWidth.SelectedItem.ToString());
			}

			if(MinorLineWidth.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MinorGrid.LineWidth = int.Parse(MinorLineWidth.SelectedItem.ToString());
				Chart1.ChartAreas["Default"].AxisX.MinorTickMark.LineWidth = int.Parse(MinorLineWidth.SelectedItem.ToString());
			}
		}
	}
}
