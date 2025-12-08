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
	/// Summary description for AnnotationAnchoring.
	/// </summary>
	public class AnnotationPositionChanging : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private CheckBox SnapToDataPoint;
		private Button ResetPosition;
		private Label label1;
		private Label AnchorXLocation;
		private Label AnchorX;
		private Label AnchorY;
		private Label label2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AnnotationPositionChanging()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			UpdateAnnotationPosition(Chart1.Annotations[0]);

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
			CalloutAnnotation calloutAnnotation1 = new CalloutAnnotation();
			ChartArea chartArea1 = new ChartArea();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(1, 700);
			DataPoint dataPoint2 = new DataPoint(2, 400);
			DataPoint dataPoint3 = new DataPoint(3, 200);
			DataPoint dataPoint4 = new DataPoint(4, 450);
			DataPoint dataPoint5 = new DataPoint(5, 300);
			DataPoint dataPoint6 = new DataPoint(6, 756);
			DataPoint dataPoint7 = new DataPoint(7, 398);
			DataPoint dataPoint8 = new DataPoint(8, 467);
			DataPoint dataPoint9 = new DataPoint(9, 612);
			DataPoint dataPoint10 = new DataPoint(10, 356);
			DataPoint dataPoint11 = new DataPoint(11, 678);
			Title title1 = new Title();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(AnnotationPositionChanging));
            label9 = new Label();
            panel1 = new Panel();
            AnchorY = new Label();
            AnchorX = new Label();
            label1 = new Label();
            AnchorXLocation = new Label();
            ResetPosition = new Button();
            SnapToDataPoint = new CheckBox();
            Chart1 = new Chart();
            label2 = new Label();
            panel1.SuspendLayout();
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
            label9.Text = "This sample demonstrates the AnnotationPositionChanging event. ";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(AnchorY);
            panel1.Controls.Add(AnchorX);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(AnchorXLocation);
            panel1.Controls.Add(ResetPosition);
            panel1.Controls.Add(SnapToDataPoint);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 19;
            // 
            // AnchorY
            // 
            AnchorY.ForeColor = System.Drawing.Color.Red;
            AnchorY.Location = new Point(168, 80);
            AnchorY.Name = "AnchorY";
            AnchorY.Size = new Size(72, 23);
            AnchorY.TabIndex = 8;
            AnchorY.Text = "label4";
            AnchorY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnchorX
            // 
            AnchorX.ForeColor = System.Drawing.Color.Red;
            AnchorX.Location = new Point(168, 48);
            AnchorX.Name = "AnchorX";
            AnchorX.Size = new Size(72, 23);
            AnchorX.TabIndex = 7;
            AnchorX.Text = "label4";
            AnchorX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new Point(24, 80);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 4;
            label1.Text = "Anchor Position Y:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AnchorXLocation
            // 
            AnchorXLocation.Location = new Point(16, 48);
            AnchorXLocation.Name = "AnchorXLocation";
            AnchorXLocation.Size = new Size(144, 23);
            AnchorXLocation.TabIndex = 3;
            AnchorXLocation.Text = "Anchor Position X:";
            AnchorXLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResetPosition
            // 
            ResetPosition.BackColor = System.Drawing.SystemColors.Control;
            ResetPosition.Location = new Point(64, 120);
            ResetPosition.Name = "ResetPosition";
            ResetPosition.Size = new Size(136, 23);
            ResetPosition.TabIndex = 2;
            ResetPosition.Text = "&Reset Position";
            ResetPosition.UseVisualStyleBackColor = false;
            ResetPosition.Click += new EventHandler(ResetPosition_Click);
            // 
            // SnapToDataPoint
            // 
            SnapToDataPoint.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            SnapToDataPoint.Checked = true;
            SnapToDataPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            SnapToDataPoint.Location = new Point(11, 16);
            SnapToDataPoint.Name = "SnapToDataPoint";
            SnapToDataPoint.Size = new Size(168, 24);
            SnapToDataPoint.TabIndex = 0;
            SnapToDataPoint.Text = "&Snap to DataPoint";
            SnapToDataPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Chart1
            // 
            calloutAnnotation1.AllowAnchorMoving = true;
            calloutAnnotation1.AllowSelecting = true;
            calloutAnnotation1.AnchorDataPointName = "Default\\r2";
            calloutAnnotation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            calloutAnnotation1.Font = new Font("Trebuchet MS", 9F);
            calloutAnnotation1.Name = "Callout1";
            calloutAnnotation1.Text = "Select this Annotation Object\\nand move the Anchor point";
            calloutAnnotation1.ToolTip = "Don\'t forget to move the anchor point";
            Chart1.Annotations.Add(calloutAnnotation1);
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
            chartArea1.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 67F;
            chartArea1.InnerPlotPosition.Width = 80F;
            chartArea1.InnerPlotPosition.X = 12F;
            chartArea1.InnerPlotPosition.Y = 22F;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 95F;
            chartArea1.Position.Width = 99F;
            chartArea1.Position.X = 1F;
            chartArea1.Position.Y = 1F;
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
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 0;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Position Changed Event";
            Chart1.Titles.Add(title1);
            Chart1.AnnotationPositionChanged += new EventHandler(Chart1_AnnotationPositionChanged);
            Chart1.AnnotationSelectionChanged += new EventHandler(Chart1_AnnotationSelectionChanged);
            Chart1.AnnotationPositionChanging += new EventHandler<AnnotationPositionChangingEventArgs>(Chart1_AnnotationPositionChanging);
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(16, 357);
            label2.Name = "label2";
            label2.Size = new Size(702, 57);
            label2.TabIndex = 20;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnnotationPositionChanging
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label2);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AnnotationPositionChanging";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void Chart1_AnnotationPositionChanging(object sender, AnnotationPositionChangingEventArgs e)
		{
			if(SnapToDataPoint.Checked)
			{
				// get the annotation object from the AnnotationPositionChangingEventArgs
				Annotation annotation = e.Annotation;

				if(!float.IsNaN(e.NewAnchorLocation.X))
				{
					// get the nearest point to the new location
					PointF point = FindNearestDataPoint(e.NewAnchorLocation.X, e.NewAnchorLocation.Y);

					annotation.AnchorDataPoint = Chart1.Series[0].Points[(int)point.X - 1];
					e.NewAnchorLocationX= point.X;
					e.NewAnchorLocationY = point.Y;
				}
			}
			else
			{
				if(!float.IsNaN(e.NewAnchorLocation.X) && e.NewAnchorLocation.X > Chart1.ChartAreas[0].AxisX.Maximum)
				{
					e.NewAnchorLocationX = (float)(Chart1.ChartAreas[0].AxisX.Maximum);
				}
				else if(!float.IsNaN(e.NewAnchorLocation.X) && e.NewAnchorLocation.X < Chart1.ChartAreas[0].AxisX.Minimum)
				{
					e.NewAnchorLocationX = 0;
				}

				if(!float.IsNaN(e.NewAnchorLocation.X) && e.NewAnchorLocation.Y > Chart1.ChartAreas[0].AxisY.Maximum)
				{
					e.NewAnchorLocationY = (float)(Chart1.ChartAreas[0].AxisY.Maximum);
				}
				else if(!float.IsNaN(e.NewAnchorLocation.Y) && e.NewAnchorLocation.Y < 1)
				{
					e.NewAnchorLocationY = 1;
				}

			}
		}

		private PointF FindNearestDataPoint(double X, double Y)
		{
			// get the int portion of the X value
            int curIndex = (int)Math.Round(X);

			// if curIndex is less than 1 curIndex is set to 1
			curIndex = (int)Math.Max(curIndex, 1);

			// if curIndex is greater than 11 curIndex is set to 11 (X Value of max point in series)
			curIndex = (int)Math.Min(curIndex, 11);

			// return the point value of the nearest point
			return new PointF(curIndex, (float)Chart1.Series[0].Points[curIndex-1].YValues[0]);
		}

		private void Chart1_AnnotationPositionChanged(object sender, EventArgs e)
		{
			Annotation annotation = (Annotation) sender;
			UpdateAnnotationPosition(annotation);
		}


		private void UpdateAnnotationPosition(Annotation annotation)
		{
			// update the UI for the new positions...

			if(SnapToDataPoint.Checked)
			{
				AnchorX.Text = annotation.AnchorDataPoint.XValue.ToString("#.#");
				AnchorY.Text = annotation.AnchorDataPoint.YValues[0].ToString("#.#");
			}
			else
			{
				AnchorX.Text = annotation.AnchorX.ToString("#.#");
				AnchorY.Text = annotation.AnchorY.ToString("#.#");
			}

			if(AnchorX.Text == "NaN")
				AnchorX.Text = "Auto";

			if(AnchorY.Text == "NaN")
				AnchorY.Text = "Auto";

		}

		private void ResetPosition_Click(object sender, EventArgs e)
		{
			Chart1.Annotations[0].AnchorX = double.NaN;
			Chart1.Annotations[0].AnchorY = double.NaN;
			Chart1.Annotations[0].AnchorDataPoint = Chart1.Series[0].Points[2];

			UpdateAnnotationPosition(Chart1.Annotations[0]);

			Chart1.Invalidate();
		}

        private void Chart1_AnnotationSelectionChanged(object sender, EventArgs e)
        {

        }

	}
}
