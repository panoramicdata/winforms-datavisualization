using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Drawing2D;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for GroupingAnnotations.
	/// </summary>
	public class GroupingAnnotations : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label1;
	
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public GroupingAnnotations()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			CreateNewStarAnnotation();

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
			DataPoint dataPoint1 = new DataPoint(1, 7.1999998092651367);
			DataPoint dataPoint2 = new DataPoint(2, 8);
			DataPoint dataPoint3 = new DataPoint(3, 8);
			DataPoint dataPoint4 = new DataPoint(4, 9);
			DataPoint dataPoint5 = new DataPoint(5, 8);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(1, 3);
			DataPoint dataPoint7 = new DataPoint(2, 6.8000001907348633);
			DataPoint dataPoint8 = new DataPoint(3, 2);
			DataPoint dataPoint9 = new DataPoint(4, 6);
			DataPoint dataPoint10 = new DataPoint(5, 3);
            label9 = new Label();
            panel1 = new Panel();
            Chart1 = new Chart();
            label1 = new Label();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 43);
            label9.TabIndex = 18;
            label9.Text = "This sample demonstrates how chart annotations can be grouped together using the " +
                "AnnotationGroup object.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Location = new Point(432, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 0;
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
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Interval = 1;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Interval = 1;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Interval = 1;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Interval = 2.5;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Interval = 1;
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
            legend1.Position.Auto = false;
            legend1.Position.Height = 12F;
            legend1.Position.Width = 16F;
            legend1.Position.X = 78F;
            legend1.Position.Y = 8F;
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 65);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            Chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 376);
            label1.Name = "label1";
            label1.Size = new Size(702, 27);
            label1.TabIndex = 19;
            label1.Text = "Click on the star annotation group, and then move or resize it.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupingAnnotations
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label1);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "GroupingAnnotations";
            Size = new Size(728, 416);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		public void CreateNewStarAnnotation()

		{
			// Create annotation group and add it to the chart annotations collection
			AnnotationGroup star = new AnnotationGroup();
			star.X = 20;
			star.Y = 20;
			star.Width = 30;
			star.Height = 20;
            star.AllowSelecting = true;
            star.AllowMoving = true;
            star.AllowResizing = true;

			Chart1.Annotations.Add(star);

			// Add star shaped polygon annotation into the group

			PointF[] starPolygon = [
													new PointF(1,6), new PointF(27,23), new PointF(33,5), new PointF(44,22), new PointF(58,0),
													new PointF(57,19), new PointF(75,11), new PointF(70,28), new PointF(100,37), new PointF(81,53),
													new PointF(99,65), new PointF(75,67), new PointF(87,98), new PointF(63,69), new PointF(60,94),
													new PointF(47,69), new PointF(34,100), new PointF(32,69), new PointF(23,74), new PointF(26,61),
													new PointF(4,72), new PointF(22,49), new PointF(0,39), new PointF(23,32), new PointF(1,6) ];

			GraphicsPath starPath = new GraphicsPath();

			starPath.AddPolygon(starPolygon);
            PolygonAnnotation poly = new PolygonAnnotation();
            poly.Name = "Star";
            poly.GraphicsPath = starPath;
			star.Annotations.Add(poly);

			// Set star polygon annotation position and appearance
			star.Annotations["Star"].X = 0;
			star.Annotations["Star"].Y = 0;
			star.Annotations["Star"].Width = 100;
			star.Annotations["Star"].Height = 100;
			star.Annotations["Star"].LineColor = Color.FromArgb(64,64,64);
			star.Annotations["Star"].BackColor = Color.FromArgb(220,255,255,192);
			star.Annotations["Star"].ShadowOffset = 2;

			// Add text in the middle of the star shape
            TextAnnotation textAnnotation = new TextAnnotation();
            textAnnotation.Name = "StarText";
            textAnnotation.Text = "New !!!";
            textAnnotation.X = 20;
            textAnnotation.Y = 20;
            textAnnotation.Width = 60;
            textAnnotation.Height = 60;
            star.Annotations.Add(textAnnotation);
			star.Annotations["StarText"].Font = new Font("MS Sans Serif", 10, FontStyle.Bold|FontStyle.Italic);
			star.Annotations["StarText"].ForeColor= Color.FromArgb(26, 59, 105);
		}
	}
}
