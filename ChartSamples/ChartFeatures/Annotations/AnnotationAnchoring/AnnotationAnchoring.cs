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
	/// Summary description for AnnotationAppearance.
	/// </summary>
	public class AnnotationAnchoring : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AnnotationAnchoring()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			AddLineAnnotation();
			AddCalloutAnnotation();
			AddRectangleAnnotation();
			
		}

		
		private void AddCalloutAnnotation()
		{
			// create a callout annotation
			CalloutAnnotation annotation = new CalloutAnnotation();

			// setup visual attributes
			annotation.AnchorDataPoint = Chart1.Series[0].Points[2];
			annotation.Text = "Attached to Point";
			annotation.BackColor = Color.FromArgb(255,255,192);
			annotation.ClipToChartArea = "Default";

			// prevent moving or selecting
			annotation.AllowMoving = false;
			annotation.AllowAnchorMoving = false;
			annotation.AllowSelecting = false;
	
			// add the annotation to the collection
			Chart1.Annotations.Add(annotation);
		}

		private void AddRectangleAnnotation()
		{
			// create a rectangle annotation
			RectangleAnnotation annotation = new RectangleAnnotation();

			// setup visual attributes
			annotation.Text = "Attached to\nChart Picture";
			annotation.BackColor = Color.FromArgb(255,255,192);
			annotation.AnchorX = 30;
			annotation.AnchorY = 25;
		
			// prevent moving or selecting
			annotation.AllowMoving = false;
			annotation.AllowAnchorMoving = false;
			annotation.AllowSelecting = false;

			// add the annotation to the collection
			Chart1.Annotations.Add(annotation);
		}

		private void AddLineAnnotation()
		{
			// create a line annotation
			LineAnnotation annotation = new LineAnnotation();

			// setup visual attributes
			annotation.StartCap = LineAnchorCapStyle.Arrow;
			annotation.EndCap = LineAnchorCapStyle.Arrow;
			annotation.LineWidth = 3;
			annotation.LineColor = Color.OrangeRed;
			annotation.ShadowOffset = 2;
			annotation.ClipToChartArea = "Default";

			// prevent moving or selecting
			annotation.AllowMoving = false;
			annotation.AllowAnchorMoving = false;
			annotation.AllowSelecting = false;

			if(Chart1.Series[0].Points.Count > 10)
			{
				// Use the Anchor Method to anchor to points 8 and 10...
                annotation.SetAnchor(Chart1.Series[0].Points[8], Chart1.Series[0].Points[10]);
			}


			// add the annotation to the collection
			Chart1.Annotations.Add(annotation);
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
			DataPoint dataPoint1 = new DataPoint(0, 500);
			DataPoint dataPoint2 = new DataPoint(0, 400);
			DataPoint dataPoint3 = new DataPoint(0, 200);
			DataPoint dataPoint4 = new DataPoint(0, 450);
			DataPoint dataPoint5 = new DataPoint(0, 700);
			DataPoint dataPoint6 = new DataPoint(0, 400);
			DataPoint dataPoint7 = new DataPoint(0, 230);
			DataPoint dataPoint8 = new DataPoint(0, 75);
			DataPoint dataPoint9 = new DataPoint(0, 750);
			DataPoint dataPoint10 = new DataPoint(0, 450);
			DataPoint dataPoint11 = new DataPoint(0, 660);
			DataPoint dataPoint12 = new DataPoint(0, 544);
			DataPoint dataPoint13 = new DataPoint(0, 233);
			DataPoint dataPoint14 = new DataPoint(0, 544);
			DataPoint dataPoint15 = new DataPoint(0, 356);
			DataPoint dataPoint16 = new DataPoint(0, 744);
			DataPoint dataPoint17 = new DataPoint(0, 345);
			ComponentResourceManager resources = new ComponentResourceManager(typeof(AnnotationAnchoring));
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
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 1;
            label9.Text = "This sample demonstrates the behavior of the Annotation object with anchoring. ";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 19;
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
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.ScaleView.Position = 2;
            chartArea1.AxisX.ScaleView.Size = 10;
            chartArea1.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
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
            series1.ChartArea = "Default";
            series1.Legend = "Default";
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
            series1.Points.Add(dataPoint15);
            series1.Points.Add(dataPoint16);
            series1.Points.Add(dataPoint17);
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 357);
            label1.Name = "label1";
            label1.Size = new Size(702, 78);
            label1.TabIndex = 20;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnnotationAnchoring
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label1);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Name = "AnnotationAnchoring";
            Size = new Size(728, 480);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


	}
}
