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
	/// Summary description for UsingPerspectives.
	/// </summary>
	public class UsingPerspectives : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label3;
		private NumericUpDown Rotation;
		private NumericUpDown Inclination;
		private Label label4;
		private Label label5;
		private NumericUpDown perspective;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public UsingPerspectives()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

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
			DataPoint dataPoint1 = new DataPoint(1, 70);
			DataPoint dataPoint2 = new DataPoint(2, 80);
			DataPoint dataPoint3 = new DataPoint(3, 70);
			DataPoint dataPoint4 = new DataPoint(4, 85);
			Series series2 = new Series();
			DataPoint dataPoint5 = new DataPoint(1, 65);
			DataPoint dataPoint6 = new DataPoint(2, 70);
			DataPoint dataPoint7 = new DataPoint(3, 60);
			DataPoint dataPoint8 = new DataPoint(4, 75);
			Series series3 = new Series();
			DataPoint dataPoint9 = new DataPoint(1, 50);
			DataPoint dataPoint10 = new DataPoint(2, 55);
			DataPoint dataPoint11 = new DataPoint(3, 40);
			DataPoint dataPoint12 = new DataPoint(4, 70);
			Title title1 = new Title();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            perspective = new NumericUpDown();
            Rotation = new NumericUpDown();
            Inclination = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)(perspective)).BeginInit();
            ((ISupportInitialize)(Rotation)).BeginInit();
            ((ISupportInitialize)(Inclination)).BeginInit();
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
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 30;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelAutoFitStyle = ((LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5F;
            legend1.Position.Width = 40F;
            legend1.Position.X = 5F;
            legend1.Position.Y = 85F;
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 48);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.Legend = "Legend2";
            series1.Name = "Series2";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.Name = "Series3";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.Legend = "Default";
            series3.Name = "Series4";
            series3.Points.Add(dataPoint9);
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 0;
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "3D Rotation and Perspective";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 32);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates perspective and rotation for a 3D chart area.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(perspective);
            panel1.Controls.Add(Rotation);
            panel1.Controls.Add(Inclination);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            // 
            // perspective
            // 
            perspective.Increment = new decimal([
            5,
            0,
            0,
            0]);
            perspective.Location = new Point(168, 8);
            perspective.Maximum = new decimal([
            1000,
            0,
            0,
            0]);
            perspective.Minimum = new decimal([
            1000,
            0,
            0,
            -2147483648]);
            perspective.Name = "perspective";
            perspective.Size = new Size(56, 22);
            perspective.TabIndex = 1;
            perspective.Value = new decimal([
            30,
            0,
            0,
            0]);
            perspective.ValueChanged += new EventHandler(perspective_ValueChanged);
            // 
            // Rotation
            // 
            Rotation.Increment = new decimal([
            5,
            0,
            0,
            0]);
            Rotation.Location = new Point(168, 72);
            Rotation.Maximum = new decimal([
            1000,
            0,
            0,
            0]);
            Rotation.Minimum = new decimal([
            1000,
            0,
            0,
            -2147483648]);
            Rotation.Name = "Rotation";
            Rotation.Size = new Size(56, 22);
            Rotation.TabIndex = 5;
            Rotation.Value = new decimal([
            30,
            0,
            0,
            0]);
            Rotation.ValueChanged += new EventHandler(Rotation_ValueChanged);
            // 
            // Inclination
            // 
            Inclination.Increment = new decimal([
            5,
            0,
            0,
            0]);
            Inclination.Location = new Point(168, 40);
            Inclination.Maximum = new decimal([
            1000,
            0,
            0,
            0]);
            Inclination.Minimum = new decimal([
            1000,
            0,
            0,
            -2147483648]);
            Inclination.Name = "Inclination";
            Inclination.Size = new Size(56, 22);
            Inclination.TabIndex = 3;
            Inclination.Value = new decimal([
            30,
            0,
            0,
            0]);
            Inclination.ValueChanged += new EventHandler(Inclination_ValueChanged);
            // 
            // label4
            // 
            label4.Location = new Point(62, 72);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 4;
            label4.Text = "Rotate &Y:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label4.Click += new EventHandler(label4_Click);
            // 
            // label5
            // 
            label5.Location = new Point(62, 40);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 2;
            label5.Text = "Rotate &X:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label5.Click += new EventHandler(label5_Click);
            // 
            // label3
            // 
            label3.Location = new Point(54, 8);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 0;
            label3.Text = "&Perspective:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UsingPerspectives
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "UsingPerspectives";
            Size = new Size(728, 360);
            Load += new EventHandler(BarColumnChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(perspective)).EndInit();
            ((ISupportInitialize)(Rotation)).EndInit();
            ((ISupportInitialize)(Inclination)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void BarColumnChartType_Load(object sender, EventArgs e)
		{
			chart1.ChartAreas[0].Area3DStyle.IsRightAngleAxes = false;
		}

		private void Inclination_ValueChanged(object sender, EventArgs e)
		{
			if(Inclination.Value > 90)
				Inclination.Value = -90;
			if(Inclination.Value < -90)
				Inclination.Value = 90;

			chart1.ChartAreas["Default"].Area3DStyle.Inclination = (int)Inclination.Value;
		}

		private void Rotation_ValueChanged(object sender, EventArgs e)
		{
			if(Rotation.Value > 180)
				Rotation.Value = -180;
			if(Rotation.Value < -180)
				Rotation.Value = 180;

			chart1.ChartAreas["Default"].Area3DStyle.Rotation = (int)Rotation.Value;
		}

		private void perspective_ValueChanged(object sender, EventArgs e)
		{
			if(perspective.Value > 100)
				perspective.Value = 0;
			if(perspective.Value < 0)
				perspective.Value = 100;
			chart1.ChartAreas[0].Area3DStyle.Perspective = (int)perspective.Value;
		}

		private void label4_Click(object sender, EventArgs e)
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
