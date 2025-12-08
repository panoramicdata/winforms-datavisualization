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
	/// Summary description for PrePostPaint.
	/// </summary>
	public class PrePostPaint : UserControl
	{
		private Label label9;
		private Chart Chart1;
		private Panel panel1;
		private CheckBox ConnectionLine;
		private Button button1;
		private Label label1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public PrePostPaint()
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
			ChartArea chartArea2 = new ChartArea();
			Legend legend2 = new Legend();
			Series series2 = new Series();
			Title title2 = new Title();
            label9 = new Label();
            Chart1 = new Chart();
            panel1 = new Panel();
            button1 = new Button();
            ConnectionLine = new CheckBox();
            label1 = new Label();
            ((ISupportInitialize)(Chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 43);
            label9.TabIndex = 2;
            label9.Text = "This sample demonstrates how to draw custom items using the PrePaint and PostPain" +
                "t events.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            chartArea2.Area3DStyle.Inclination = 15;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Perspective = 10;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "Default";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Enabled = false;
            legend2.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Default";
            Chart1.Legends.Add(legend2);
            Chart1.Location = new Point(16, 65);
            Chart1.Name = "Chart1";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.BorderWidth = 3;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Default";
            series2.MarkerColor = System.Drawing.Color.AliceBlue;
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series2.Name = "Default";
            series2.ShadowColor = System.Drawing.Color.Black;
            series2.ShadowOffset = 2;
            Chart1.Series.Add(series2);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 0;
            title2.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title2.Name = "Title1";
            title2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title2.ShadowOffset = 3;
            title2.Text = "PrePaint and PostPaint Events";
            Chart1.Titles.Add(title2);
            Chart1.PostPaint += new EventHandler<ChartPaintEventArgs>(Chart1_PostPaint);
            Chart1.PrePaint += new EventHandler<ChartPaintEventArgs>(Chart1_PrePaint);
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ConnectionLine);
            panel1.Location = new Point(432, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.Control;
            button1.Location = new Point(88, 56);
            button1.Name = "button1";
            button1.Size = new Size(136, 23);
            button1.TabIndex = 1;
            button1.Text = "&Random Data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new EventHandler(button1_Click);
            // 
            // ConnectionLine
            // 
            ConnectionLine.Checked = true;
            ConnectionLine.CheckState = System.Windows.Forms.CheckState.Checked;
            ConnectionLine.Location = new Point(48, 16);
            ConnectionLine.Name = "ConnectionLine";
            ConnectionLine.Size = new Size(232, 32);
            ConnectionLine.TabIndex = 0;
            ConnectionLine.Text = "Show Max-Min &Connection Line";
            ConnectionLine.CheckedChanged += new EventHandler(ConnectionLine_CheckedChanged);
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 373);
            label1.Name = "label1";
            label1.Size = new Size(702, 40);
            label1.TabIndex = 3;
            label1.Text = "Data points with the maximum and minimum Y values are highlighted. Horizontal and" +
                " connection lines are also drawn in this sample.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PrePostPaint
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Chart1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PrePostPaint";
            Size = new Size(728, 440);
            Load += new EventHandler(PrePostPaint_Load);
            ((ISupportInitialize)(Chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion


		private void PrePostPaint_Load(object sender, EventArgs e)
		{
			// Populate series data with random data
			Random	random = new Random();
			for(int pointIndex = 0; pointIndex < 25; pointIndex++)
			{
				Chart1.Series["Default"].Points.AddXY(pointIndex, random.Next(5, 60));
			}

		}

		private void FindMaxMin( out double max, out double min, out double xMax, out double xMin )
		{

			max = double.MinValue;
			min = double.MaxValue;

			xMax = 0;
			xMin = 0;

			// Find Minimum and Maximum Y values and corresponding X positions
			foreach( DataPoint point in Chart1.Series["Default"].Points )
			{
				if( point.YValues[0] > max )
				{
					max = point.YValues[0];
					xMax = point.XValue;
				}

				if( point.YValues[0] < min )
				{
					min = point.YValues[0];
					xMin = point.XValue;
				}
			}
		}

		private void Chart1_PostPaint(object sender, ChartPaintEventArgs e)
		{
			if(e.ChartElement is ChartArea)
			{
				ChartArea area = (ChartArea)e.ChartElement;
				if(area.Name == "Default")
				{
					// If Connection line is not checked return
					if( !ConnectionLine.Checked )
						return;


					// Find Minimum and Maximum values
					FindMaxMin(out double max, out double min, out double xMax, out double xMin);

					// Take Graphics object from chart
					Graphics graph = e.ChartGraphics.Graphics;

					// Convert X and Y values to screen position
					float pixelYMax = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.Y,max);
					float pixelXMax = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X,xMax);
					float pixelYMin = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.Y,min);
					float pixelXMin = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X,xMin);

					PointF point1 = PointF.Empty;
					PointF point2 = PointF.Empty;

					// Set Maximum and minimum points
					point1.X = pixelXMax;
					point1.Y = pixelYMax;
					point2.X = pixelXMin;
					point2.Y = pixelYMin;

					// Convert relative coordinates to absolute coordinates.
					point1 = e.ChartGraphics.GetAbsolutePoint(point1);
					point2 = e.ChartGraphics.GetAbsolutePoint(point2);

					// Draw connection line
					graph.DrawLine(new Pen(Color.FromArgb(26, 59, 105), 2), point1,point2);
				}
			}
		
		}

		private void Chart1_PrePaint(object sender, ChartPaintEventArgs e)
		{
			if(e.ChartElement is ChartArea)
			{
				ChartArea area = (ChartArea)e.ChartElement;
				if(area.Name == "Default")
				{

					// Find Minimum and Maximum values
					FindMaxMin(out double max, out double min, out double xMax, out double xMin);

					// Take Graphics object from chart
					Graphics graph = e.ChartGraphics.Graphics;

					// Convert X and Y values to screen position
					float pixelYMax = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.Y,max);
					float pixelXMax = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X,xMax);
					float pixelYMin = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.Y,min);
					float pixelXMin = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X,xMin);

					float XMin = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X, area.AxisX.Minimum);
					float XMax = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X, area.AxisX.Maximum);

					// Specify with of triangle
					float width = 3;

					// Set Maximum points
					PointF [] points = new PointF[3];
					points[0].X = pixelXMax - width;
					points[0].Y = pixelYMax - width - 2;
					points[1].X = pixelXMax + width;
					points[1].Y = pixelYMax - width - 2;
					points[2].X = pixelXMax;
					points[2].Y = pixelYMax - 1;

					// Convert relative coordinates to absolute coordinates.
					points[0] = e.ChartGraphics.GetAbsolutePoint(points[0]);
					points[1] = e.ChartGraphics.GetAbsolutePoint(points[1]);
					points[2] = e.ChartGraphics.GetAbsolutePoint(points[2]);

					// Draw Maximum trangle
					Pen darkPen = new Pen(Color.FromArgb(26, 59, 105), 1);
					graph.FillPolygon(new SolidBrush(Color.FromArgb(220, 252, 180, 65)), points);
					graph.DrawPolygon(darkPen, points);
					
					points[0].X = XMin;
					points[1].X = XMax;
					points[0].Y = points[1].Y = pixelYMax;

					// Convert relative coordinates to absolute coordinates.
					points[0] = e.ChartGraphics.GetAbsolutePoint(points[0]);
					points[1] = e.ChartGraphics.GetAbsolutePoint(points[1]);

					graph.DrawLine(darkPen, points[0], points[1]);

					// Set Minimum points
					points = new PointF[3];
					points[0].X = pixelXMin - width;
					points[0].Y = pixelYMin + width + 2;
					points[1].X = pixelXMin + width;
					points[1].Y = pixelYMin + width + 2;
					points[2].X = pixelXMin;
					points[2].Y = pixelYMin + 1;

					// Convert relative coordinates to absolute coordinates.
					points[0] = e.ChartGraphics.GetAbsolutePoint(points[0]);
					points[1] = e.ChartGraphics.GetAbsolutePoint(points[1]);
					points[2] = e.ChartGraphics.GetAbsolutePoint(points[2]);

					// Draw Minimum trangle
					graph.FillPolygon(new SolidBrush(Color.FromArgb(220, 224, 64, 10)), points);
					graph.DrawPolygon(darkPen, points);
					points[0].X = XMin;
					points[1].X = XMax;
					points[0].Y = points[1].Y = pixelYMin;

					// Convert relative coordinates to absolute coordinates.
					points[0] = e.ChartGraphics.GetAbsolutePoint(points[0]);
					points[1] = e.ChartGraphics.GetAbsolutePoint(points[1]);

					graph.DrawLine(darkPen, points[0], points[1]);

				}
			}
		}

		private void ConnectionLine_CheckedChanged(object sender, EventArgs e)
		{
			Chart1.Invalidate();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Chart1.Series["Default"].Points.Clear();
			PrePostPaint_Load(sender, e);
			Chart1.Invalidate();
		}

	}
}
