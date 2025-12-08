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
	/// Summary description for UsingGaps3D.
	/// </summary>
	public class UsingGaps3D : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private NumericUpDown Rotation;
		private Label label4;
		private Label label6;
		private Label label5;
		private NumericUpDown pointGapDepth;
		private NumericUpDown pointDepth;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public UsingGaps3D()
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
            label6 = new Label();
            pointGapDepth = new NumericUpDown();
            label5 = new Label();
            pointDepth = new NumericUpDown();
            Rotation = new NumericUpDown();
            label4 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)(pointGapDepth)).BeginInit();
            ((ISupportInitialize)(pointDepth)).BeginInit();
            ((ISupportInitialize)(Rotation)).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 18;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 8;
            chartArea1.Area3DStyle.Rotation = 40;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelAutoFitStyle = ((LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
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
            chart1.Location = new Point(16, 65);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
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
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Default";
            series2.Name = "Series3";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.CustomProperties = "DrawingStyle=Cylinder";
            series3.Legend = "Default";
            series3.Name = "Series4";
            series3.Points.Add(dataPoint9);
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "3D Z Space Control";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 45);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to adjust the PointDepth and the PointGapDepth prope" +
                "rties, which are used to control the depth of each plotted series in a 3D chart " +
                "area.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pointGapDepth);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pointDepth);
            panel1.Controls.Add(Rotation);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(432, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.Location = new Point(8, 40);
            label6.Name = "label6";
            label6.Size = new Size(160, 16);
            label6.TabIndex = 2;
            label6.Text = "Point &Gap Depth:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointGapDepth
            // 
            pointGapDepth.Increment = new decimal([
            25,
            0,
            0,
            0]);
            pointGapDepth.Location = new Point(168, 40);
            pointGapDepth.Maximum = new decimal([
            1000,
            0,
            0,
            0]);
            pointGapDepth.Name = "pointGapDepth";
            pointGapDepth.Size = new Size(56, 22);
            pointGapDepth.TabIndex = 3;
            pointGapDepth.Value = new decimal([
            100,
            0,
            0,
            0]);
            pointGapDepth.ValueChanged += new EventHandler(pointGapDepth_ValueChanged);
            // 
            // label5
            // 
            label5.Location = new Point(16, 8);
            label5.Name = "label5";
            label5.Size = new Size(152, 16);
            label5.TabIndex = 0;
            label5.Text = "Point &Depth:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointDepth
            // 
            pointDepth.Increment = new decimal([
            25,
            0,
            0,
            0]);
            pointDepth.Location = new Point(168, 8);
            pointDepth.Maximum = new decimal([
            1000,
            0,
            0,
            0]);
            pointDepth.Name = "pointDepth";
            pointDepth.Size = new Size(56, 22);
            pointDepth.TabIndex = 1;
            pointDepth.Value = new decimal([
            100,
            0,
            0,
            0]);
            pointDepth.ValueChanged += new EventHandler(pointDepth_ValueChanged);
            // 
            // Rotation
            // 
            Rotation.Increment = new decimal([
            10,
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
            40,
            0,
            0,
            0]);
            Rotation.ValueChanged += new EventHandler(Rotation_ValueChanged);
            // 
            // label4
            // 
            label4.Location = new Point(24, 72);
            label4.Name = "label4";
            label4.Size = new Size(144, 23);
            label4.TabIndex = 4;
            label4.Text = "Rotate &Y:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UsingGaps3D
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "UsingGaps3D";
            Size = new Size(728, 368);
            Load += new EventHandler(BarColumnChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(pointGapDepth)).EndInit();
            ((ISupportInitialize)(pointDepth)).EndInit();
            ((ISupportInitialize)(Rotation)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void BarColumnChartType_Load(object sender, EventArgs e)
		{
		}

		private void Rotation_ValueChanged(object sender, EventArgs e)
		{
			if(Rotation.Value > 180)
				Rotation.Value = -180;
			if(Rotation.Value < -180)
				Rotation.Value = 180;

			chart1.ChartAreas["Default"].Area3DStyle.Rotation = (int)Rotation.Value;
		}

		private void pointDepth_ValueChanged(object sender, EventArgs e)
		{
			chart1.ChartAreas[0].Area3DStyle.PointDepth = (int)pointDepth.Value;
		}

		private void pointGapDepth_ValueChanged(object sender, EventArgs e)
		{
			chart1.ChartAreas[0].Area3DStyle.PointGapDepth = (int)pointGapDepth.Value;
		}

	}
}
