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
	public class AxisScale : UserControl
	{
		private Label label5;
		private Label label6;
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private ComboBox MinValue;
		private ComboBox MaxValue;
		private CheckBox AutoCheck;
		private CheckBox LogCheck;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AxisScale()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			MaxValue.SelectedIndex = 1;
			MinValue.SelectedIndex = 0;
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
			DataPoint dataPoint1 = new DataPoint(0, 550);
			DataPoint dataPoint2 = new DataPoint(0, 900);
			DataPoint dataPoint3 = new DataPoint(0, 1800);
			DataPoint dataPoint4 = new DataPoint(0, 1500);
			DataPoint dataPoint5 = new DataPoint(0, 700);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 900);
			DataPoint dataPoint7 = new DataPoint(0, 1800);
			DataPoint dataPoint8 = new DataPoint(0, 1400);
			DataPoint dataPoint9 = new DataPoint(0, 2000);
			DataPoint dataPoint10 = new DataPoint(0, 2000);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 1800);
			DataPoint dataPoint12 = new DataPoint(0, 2400);
			DataPoint dataPoint13 = new DataPoint(0, 800);
			DataPoint dataPoint14 = new DataPoint(0, 550);
			DataPoint dataPoint15 = new DataPoint(0, 2200);
            MinValue = new ComboBox();
            MaxValue = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            AutoCheck = new CheckBox();
            LogCheck = new CheckBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // MinValue
            // 
            MinValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MinValue.Items.AddRange([
            "0",
            "250",
            "500"]);
            MinValue.Location = new Point(168, 96);
            MinValue.Name = "MinValue";
            MinValue.Size = new Size(120, 22);
            MinValue.TabIndex = 5;
            MinValue.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // MaxValue
            // 
            MaxValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MaxValue.Items.AddRange([
            "3000",
            "5000",
            "10000"]);
            MaxValue.Location = new Point(168, 64);
            MaxValue.Name = "MaxValue";
            MaxValue.Size = new Size(120, 22);
            MaxValue.TabIndex = 3;
            MaxValue.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // label5
            // 
            label5.Location = new Point(0, 96);
            label5.Name = "label5";
            label5.Size = new Size(164, 16);
            label5.TabIndex = 4;
            label5.Text = "Mi&nimum:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label5.Click += new EventHandler(label5_Click);
            // 
            // label6
            // 
            label6.Location = new Point(0, 72);
            label6.Name = "label6";
            label6.Size = new Size(164, 16);
            label6.TabIndex = 2;
            label6.Text = "Ma&ximum:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label6.Click += new EventHandler(label6_Click);
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 43);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to use a logarithmic scale, as well as how to set th" +
                "e minimum and maximum axis values.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(AutoCheck);
            panel1.Controls.Add(LogCheck);
            panel1.Controls.Add(MaxValue);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(MinValue);
            panel1.Location = new Point(432, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            // 
            // AutoCheck
            // 
            AutoCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            AutoCheck.Checked = true;
            AutoCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            AutoCheck.Location = new Point(0, 40);
            AutoCheck.Name = "AutoCheck";
            AutoCheck.Size = new Size(180, 24);
            AutoCheck.TabIndex = 1;
            AutoCheck.Text = "&Auto Scale:";
            AutoCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            AutoCheck.CheckedChanged += new EventHandler(ControlChange);
            // 
            // LogCheck
            // 
            LogCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            LogCheck.Location = new Point(8, 8);
            LogCheck.Name = "LogCheck";
            LogCheck.Size = new Size(172, 24);
            LogCheck.TabIndex = 0;
            LogCheck.Text = "&Logarithmic:";
            LogCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            LogCheck.CheckedChanged += new EventHandler(ControlChange);
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
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "#";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 65);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.CustomProperties = "DrawingStyle=Wedge";
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series2.ChartArea = "Default";
            series2.CustomProperties = "DrawingStyle=Wedge";
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series3.ChartArea = "Default";
            series3.CustomProperties = "DrawingStyle=Wedge";
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
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            // 
            // AxisScale
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AxisScale";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void AxisScale_Load(object sender, EventArgs e)
		{ 
		}

		private void ControlChange(object sender, EventArgs e)
		{
			Chart1.ChartAreas["Default"].AxisY.IsLogarithmic = LogCheck.Checked;

			if(LogCheck.Checked)
			{
				AutoCheck.Enabled = false;
				AutoCheck.Checked = true;
			}
			else
				AutoCheck.Enabled = true;


			MaxValue.Enabled = !AutoCheck.Checked;
			MinValue.Enabled = !AutoCheck.Checked;

			if(MaxValue.SelectedIndex >= 0 && 
				MinValue.SelectedIndex >= 0 && 
				!AutoCheck.Checked)
			{
				double maxval= double.Parse(MaxValue.SelectedItem.ToString());
				double minval= double.Parse(MinValue.SelectedItem.ToString());

				Chart1.ChartAreas["Default"].AxisY.Maximum = maxval;
				Chart1.ChartAreas["Default"].AxisY.Minimum = minval;
			}
			else
			{
				Chart1.ChartAreas["Default"].AxisY.Maximum = double.NaN;
				Chart1.ChartAreas["Default"].AxisY.Minimum = double.NaN;
			}
		}

		private void label6_Click(object sender, EventArgs e)
		{
		
		}

		private void label5_Click(object sender, EventArgs e)
		{
		
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		
		}

	}
}
