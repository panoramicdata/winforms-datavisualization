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
	/// Summary description for StripLines.
	/// </summary>
	public class StripLines : UserControl
	{
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private ComboBox StripEndColor;
		private ComboBox StripColor;
		private ComboBox LineColor;
		private ComboBox LineWidth;
		private ComboBox Interval;
		private ComboBox HatchStyle;
		private ComboBox Gradient;
		private ComboBox StripLinesStyle;
		private Label label1;
		private Label label11;
		private Label label10;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public StripLines()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Add Hatch styles to control.
			foreach(string colorName in Enum.GetNames(typeof(ChartHatchStyle)))
			{
				HatchStyle.Items.Add(colorName);
			}
			HatchStyle.SelectedIndex = 0;

			// Add Chart Gradient types to control.
			foreach(string colorName in Enum.GetNames(typeof(GradientStyle)))
			{
				Gradient.Items.Add(colorName);
			}
			Gradient.SelectedIndex = 1;

	
			// Add Border styles to control.
			foreach(string colorName in Enum.GetNames(typeof(ChartDashStyle)))
			{
				StripLinesStyle.Items.Add(colorName);
			}
			StripLinesStyle.SelectedIndex = 5;

			StripColor.SelectedIndex = 0;
			StripEndColor.SelectedIndex = 0;
			LineColor.SelectedIndex = 0;
			LineWidth.SelectedIndex = 0;
			Interval.SelectedIndex = 3;

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
			StripLine stripLine1 = new StripLine();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(0, 700);
			DataPoint dataPoint2 = new DataPoint(0, 400);
			DataPoint dataPoint3 = new DataPoint(0, 200);
			DataPoint dataPoint4 = new DataPoint(0, 450);
			DataPoint dataPoint5 = new DataPoint(0, 300);
			DataPoint dataPoint6 = new DataPoint(0, 245);
			DataPoint dataPoint7 = new DataPoint(0, 568);
			DataPoint dataPoint8 = new DataPoint(0, 345);
			DataPoint dataPoint9 = new DataPoint(0, 789);
			DataPoint dataPoint10 = new DataPoint(0, 834);
			DataPoint dataPoint11 = new DataPoint(0, 382);
			DataPoint dataPoint12 = new DataPoint(0, 599);
			DataPoint dataPoint13 = new DataPoint(0, 123);
			DataPoint dataPoint14 = new DataPoint(0, 223);
			Title title1 = new Title();
            StripEndColor = new ComboBox();
            StripColor = new ComboBox();
            HatchStyle = new ComboBox();
            Gradient = new ComboBox();
            LineColor = new ComboBox();
            StripLinesStyle = new ComboBox();
            LineWidth = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            Interval = new ComboBox();
            label11 = new Label();
            Chart1 = new Chart();
            label10 = new Label();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // StripEndColor
            // 
            StripEndColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StripEndColor.Items.AddRange([
            "DarkRed",
            "Green",
            "Yellow",
            "SlateGray",
            "Gold"]);
            StripEndColor.Location = new Point(168, 120);
            StripEndColor.Name = "StripEndColor";
            StripEndColor.Size = new Size(121, 22);
            StripEndColor.TabIndex = 9;
            StripEndColor.SelectedIndexChanged += new EventHandler(ControlChanged);
            // 
            // StripColor
            // 
            StripColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StripColor.Items.AddRange([
            "Red",
            "Gainsboro",
            "Khaki",
            "LightSteelBlue"]);
            StripColor.Location = new Point(168, 48);
            StripColor.Name = "StripColor";
            StripColor.Size = new Size(121, 22);
            StripColor.TabIndex = 3;
            StripColor.SelectedIndexChanged += new EventHandler(ControlChanged);
            // 
            // HatchStyle
            // 
            HatchStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            HatchStyle.Location = new Point(168, 96);
            HatchStyle.Name = "HatchStyle";
            HatchStyle.Size = new Size(121, 22);
            HatchStyle.TabIndex = 7;
            HatchStyle.SelectedIndexChanged += new EventHandler(HatchControlChanged);
            // 
            // Gradient
            // 
            Gradient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Gradient.Location = new Point(168, 72);
            Gradient.Name = "Gradient";
            Gradient.Size = new Size(121, 22);
            Gradient.TabIndex = 5;
            Gradient.SelectedIndexChanged += new EventHandler(GradienControlChanged);
            // 
            // LineColor
            // 
            LineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LineColor.Items.AddRange([
            "MidnightBlue",
            "Green",
            "Black",
            "Red"]);
            LineColor.Location = new Point(168, 184);
            LineColor.Name = "LineColor";
            LineColor.Size = new Size(121, 22);
            LineColor.TabIndex = 13;
            LineColor.SelectedIndexChanged += new EventHandler(ControlChanged);
            // 
            // StripLinesStyle
            // 
            StripLinesStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StripLinesStyle.Location = new Point(168, 160);
            StripLinesStyle.Name = "StripLinesStyle";
            StripLinesStyle.Size = new Size(121, 22);
            StripLinesStyle.TabIndex = 11;
            StripLinesStyle.SelectedIndexChanged += new EventHandler(ControlChanged);
            // 
            // LineWidth
            // 
            LineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LineWidth.Items.AddRange([
            "1",
            "2",
            "3",
            "4",
            "5"]);
            LineWidth.Location = new Point(168, 208);
            LineWidth.Name = "LineWidth";
            LineWidth.Size = new Size(121, 22);
            LineWidth.TabIndex = 15;
            LineWidth.SelectedIndexChanged += new EventHandler(ControlChanged);
            // 
            // label2
            // 
            label2.Location = new Point(20, 50);
            label2.Name = "label2";
            label2.Size = new Size(148, 16);
            label2.TabIndex = 2;
            label2.Text = "Back &Color:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(20, 122);
            label3.Name = "label3";
            label3.Size = new Size(148, 16);
            label3.TabIndex = 8;
            label3.Text = "S&econdary Back Color:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(20, 74);
            label4.Name = "label4";
            label4.Size = new Size(148, 16);
            label4.TabIndex = 4;
            label4.Text = "&Gradient Style:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(20, 98);
            label5.Name = "label5";
            label5.Size = new Size(148, 16);
            label5.TabIndex = 6;
            label5.Text = "&Hatch Style:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(19, 162);
            label6.Name = "label6";
            label6.Size = new Size(148, 16);
            label6.TabIndex = 10;
            label6.Text = "Border &Style:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(18, 186);
            label7.Name = "label7";
            label7.Size = new Size(148, 16);
            label7.TabIndex = 12;
            label7.Text = "&Border Color:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to set the appearance properties of the StripLine ob" +
                "ject.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Interval);
            panel1.Controls.Add(StripLinesStyle);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Gradient);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(HatchStyle);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LineWidth);
            panel1.Controls.Add(StripEndColor);
            panel1.Controls.Add(StripColor);
            panel1.Controls.Add(LineColor);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 296);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(20, 11);
            label1.Name = "label1";
            label1.Size = new Size(148, 16);
            label1.TabIndex = 0;
            label1.Text = "Strip &Interval:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Interval
            // 
            Interval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Interval.Items.AddRange([
            "2",
            "3",
            "4",
            "5"]);
            Interval.Location = new Point(168, 8);
            Interval.Name = "Interval";
            Interval.Size = new Size(121, 22);
            Interval.TabIndex = 1;
            Interval.SelectedIndexChanged += new EventHandler(ControlChanged);
            // 
            // label11
            // 
            label11.Location = new Point(18, 211);
            label11.Name = "label11";
            label11.Size = new Size(148, 16);
            label11.TabIndex = 14;
            label11.Text = "Border Si&ze:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            stripLine1.BackColor = System.Drawing.Color.Gainsboro;
            stripLine1.Interval = 2;
            stripLine1.IntervalOffset = 0.5;
            stripLine1.StripWidth = 1;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
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
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Default";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series1.MarkerSize = 8;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Default";
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
            series1.Points.Add(dataPoint12);
            series1.Points.Add(dataPoint13);
            series1.Points.Add(dataPoint14);
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 306);
            Chart1.TabIndex = 1;
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Strip Lines";
            Chart1.Titles.Add(title1);
            // 
            // label10
            // 
            label10.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new Point(16, 367);
            label10.Name = "label10";
            label10.Size = new Size(702, 34);
            label10.TabIndex = 3;
            label10.Text = "Chart interlaced strip lines can also be enabled setting the Axis.IsInterlaced pr" +
                "operty.";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StripLines
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label10);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "StripLines";
            Size = new Size(728, 424);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void ControlChanged(object sender, EventArgs e)
		{
			if(StripEndColor.SelectedIndex >= 0)
			{
				Chart1.ChartAreas[0].AxisX.StripLines[0].BackSecondaryColor =
					Color.FromName(StripEndColor.SelectedItem.ToString());
			}

			if(StripColor.SelectedIndex >= 0)
			{
				Chart1.ChartAreas[0].AxisX.StripLines[0].BackColor =
					Color.FromName(StripColor.SelectedItem.ToString());
			}

			if(LineColor.SelectedIndex >= 0)
			{
				Chart1.ChartAreas[0].AxisX.StripLines[0].BorderColor =
					Color.FromName(LineColor.SelectedItem.ToString());
			}

			if(LineWidth.SelectedIndex >= 0)
			{
				Chart1.ChartAreas[0].AxisX.StripLines[0].BorderWidth =
					int.Parse(LineWidth.SelectedItem.ToString());
			}

			if(Interval.SelectedIndex >= 0)
			{
				Chart1.ChartAreas[0].AxisX.StripLines[0].Interval = 
					int.Parse(Interval.SelectedItem.ToString());
			}

			if(HatchStyle.SelectedIndex >= 0)
			{
				// Set Hatch Style
				Chart1.ChartAreas[0].AxisX.StripLines[0].BackHatchStyle = 
					(ChartHatchStyle)ChartHatchStyle.Parse(typeof(ChartHatchStyle), HatchStyle.SelectedItem.ToString());

			}

			if(Gradient.SelectedIndex >= 0)
			{
				// Set Gradient Type
				Chart1.ChartAreas[0].AxisX.StripLines[0].BackGradientStyle = 
					(GradientStyle)GradientStyle.Parse(typeof(GradientStyle), Gradient.SelectedItem.ToString());

			}

			if(StripLinesStyle.SelectedIndex >= 0)
			{
				Chart1.ChartAreas[0].AxisX.StripLines[0].BorderDashStyle = 
					(ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), StripLinesStyle.SelectedItem.ToString());
			}

			// Enable/disable attribute	contros
			StripEndColor.Enabled = (Gradient.SelectedIndex != 0 || HatchStyle.SelectedIndex != 0);
			LineColor.Enabled = (StripLinesStyle.SelectedIndex != 0);
			LineWidth.Enabled = (StripLinesStyle.SelectedIndex != 0);
		}

		private void GradienControlChanged(object sender, EventArgs e)
		{
			ControlChanged(sender, e);

			if( Chart1.ChartAreas[0].AxisX.StripLines[0].BackGradientStyle != GradientStyle.None )
				HatchStyle.SelectedIndex = 0;
		
		}

		private void HatchControlChanged(object sender, EventArgs e)
		{
			ControlChanged(sender, e);

			if( Chart1.ChartAreas[0].AxisX.StripLines[0].BackHatchStyle != ChartHatchStyle.None )
					Gradient.SelectedIndex = 0;		
	
		}
	}
}
