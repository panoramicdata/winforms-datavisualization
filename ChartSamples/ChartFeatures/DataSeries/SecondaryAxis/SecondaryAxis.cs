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
	public class SecondaryAxis : UserControl
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
		private Label label1;
		private Label label2;
		private Label label10;
		private Label label11;
		private ComboBox Series1X;
		private ComboBox Series1Y;
		private ComboBox Series2X;
		private ComboBox Series2Y;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public SecondaryAxis()
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
			DataPoint dataPoint1 = new DataPoint(0, 14);
			DataPoint dataPoint2 = new DataPoint(0, 13);
			DataPoint dataPoint3 = new DataPoint(0, 14);
			DataPoint dataPoint4 = new DataPoint(0, 18);
			DataPoint dataPoint5 = new DataPoint(0, 16);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 10);
			DataPoint dataPoint7 = new DataPoint(0, 15);
			DataPoint dataPoint8 = new DataPoint(0, 8);
			DataPoint dataPoint9 = new DataPoint(0, 12);
			DataPoint dataPoint10 = new DataPoint(0, 18);
            label9 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label2 = new Label();
            label1 = new Label();
            Series2Y = new ComboBox();
            Series2X = new ComboBox();
            Series1Y = new ComboBox();
            Series1X = new ComboBox();
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
            label9.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 32);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to plot a series on either the primary or secondary " +
                "axis.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Series2Y);
            panel1.Controls.Add(Series2X);
            panel1.Controls.Add(Series1Y);
            panel1.Controls.Add(Series1X);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // label11
            // 
            label11.Location = new Point(8, 104);
            label11.Name = "label11";
            label11.Size = new Size(156, 23);
            label11.TabIndex = 6;
            label11.Text = "Series2 Y &Axis:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Location = new Point(8, 72);
            label10.Name = "label10";
            label10.Size = new Size(156, 23);
            label10.TabIndex = 4;
            label10.Text = "Series&2 X Axis:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(8, 40);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 2;
            label2.Text = "Series1 &Y Axis:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 0;
            label1.Text = "Series&1 X Axis:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Series2Y
            // 
            Series2Y.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Series2Y.Items.AddRange([
            "Primary",
            "Secondary"]);
            Series2Y.Location = new Point(168, 104);
            Series2Y.Name = "Series2Y";
            Series2Y.Size = new Size(121, 22);
            Series2Y.TabIndex = 7;
            Series2Y.SelectedIndexChanged += new EventHandler(Series_SelectedIndexChanged);
            // 
            // Series2X
            // 
            Series2X.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Series2X.Items.AddRange([
            "Primary",
            "Secondary"]);
            Series2X.Location = new Point(168, 72);
            Series2X.Name = "Series2X";
            Series2X.Size = new Size(121, 22);
            Series2X.TabIndex = 5;
            Series2X.SelectedIndexChanged += new EventHandler(Series_SelectedIndexChanged);
            // 
            // Series1Y
            // 
            Series1Y.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Series1Y.Items.AddRange([
            "Primary",
            "Secondary"]);
            Series1Y.Location = new Point(168, 40);
            Series1Y.Name = "Series1Y";
            Series1Y.Size = new Size(121, 22);
            Series1Y.TabIndex = 3;
            Series1Y.SelectedIndexChanged += new EventHandler(Series_SelectedIndexChanged);
            // 
            // Series1X
            // 
            Series1X.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Series1X.Items.AddRange([
            "Primary",
            "Secondary"]);
            Series1X.Location = new Point(168, 8);
            Series1X.Name = "Series1X";
            Series1X.Size = new Size(121, 22);
            Series1X.TabIndex = 1;
            Series1X.SelectedIndexChanged += new EventHandler(Series_SelectedIndexChanged);
            // 
            // label8
            // 
            label8.Location = new Point(64, 472);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 7;
            label8.Text = "Shadow Offset:";
            // 
            // label7
            // 
            label7.Location = new Point(64, 449);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 6;
            label7.Text = "Border Style:";
            // 
            // label6
            // 
            label6.Location = new Point(64, 403);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 11;
            label6.Text = "Border Size:";
            // 
            // label5
            // 
            label5.Location = new Point(64, 380);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 10;
            label5.Text = "Border Color:";
            // 
            // label4
            // 
            label4.Location = new Point(64, 357);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 9;
            label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            label3.Location = new Point(64, 334);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 8;
            label3.Text = "Gradient:";
            // 
            // label15
            // 
            label15.Location = new Point(64, 426);
            label15.Name = "label15";
            label15.Size = new Size(100, 23);
            label15.TabIndex = 5;
            label15.Text = "Border Size:";
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
            chartArea1.AxisX2.IsLabelAutoFit = false;
            chartArea1.AxisX2.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "Default";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.CustomProperties = "DrawingStyle=LightToDark";
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.CustomProperties = "DrawingStyle=LightToDark";
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            // 
            // SecondaryAxis
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "SecondaryAxis";
            Size = new Size(728, 480);
            Load += new EventHandler(SecondaryAxis_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void SetSecondary()
		{
			if( Series1X.SelectedItem == null ||
				Series1Y.SelectedItem == null ||
				Series2X.SelectedItem == null ||
				Series2Y.SelectedItem == null )
			{
				return;
			}

			Chart1.Series["Series1"].XAxisType = (AxisType)AxisType.Parse(typeof(AxisType), Series1X.GetItemText(Series1X.SelectedItem));
			Chart1.Series["Series1"].YAxisType = (AxisType)AxisType.Parse(typeof(AxisType), Series1Y.GetItemText(Series1Y.SelectedItem));
			Chart1.Series["Series2"].XAxisType = (AxisType)AxisType.Parse(typeof(AxisType), Series2X.GetItemText(Series2X.SelectedItem));
			Chart1.Series["Series2"].YAxisType = (AxisType)AxisType.Parse(typeof(AxisType), Series2Y.GetItemText(Series2Y.SelectedItem));
		}

		private void Series_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetSecondary();
		}
		

		private void SecondaryAxis_Load(object sender, EventArgs e)
		{
			// Initialize Combo boxes
			Series1X.SelectedIndex = 0;
			Series1Y.SelectedIndex = 0;
			Series2X.SelectedIndex = 0;
			Series2Y.SelectedIndex = 0;
		}

		
		

	}
}
