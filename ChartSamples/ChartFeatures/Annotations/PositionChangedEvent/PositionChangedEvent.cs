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
	/// Summary description for AnnotationPositioning.
	/// </summary>
	public class PositionChangedEvent : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label2;
		private Label label3;
		private TextBox AnnotationX;
		private TextBox AnnotationY;
		private CheckBox AllowMoving;
		private CheckBox ClipToChartArea;
		private Label label1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public PositionChangedEvent()
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
			CalloutAnnotation calloutAnnotation1 = new CalloutAnnotation();
			ChartArea chartArea1 = new ChartArea();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(0, 70);
			DataPoint dataPoint2 = new DataPoint(0, 40);
			DataPoint dataPoint3 = new DataPoint(0, 30);
			DataPoint dataPoint4 = new DataPoint(0, 79);
			DataPoint dataPoint5 = new DataPoint(0, 91);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 78);
			DataPoint dataPoint7 = new DataPoint(0, 39);
			DataPoint dataPoint8 = new DataPoint(0, 67);
			DataPoint dataPoint9 = new DataPoint(0, 34);
			DataPoint dataPoint10 = new DataPoint(0, 60);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 81);
			DataPoint dataPoint12 = new DataPoint(0, 55);
			DataPoint dataPoint13 = new DataPoint(0, 47);
			DataPoint dataPoint14 = new DataPoint(0, 67);
			DataPoint dataPoint15 = new DataPoint(0, 87);
            label9 = new Label();
            panel1 = new Panel();
            ClipToChartArea = new CheckBox();
            AnnotationY = new TextBox();
            AnnotationX = new TextBox();
            label2 = new Label();
            label3 = new Label();
            AllowMoving = new CheckBox();
            Chart1 = new Chart();
            label1 = new Label();
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
            label9.TabIndex = 2;
            label9.Text = "This sample demonstrates the AnnotationPositionChanged event.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(ClipToChartArea);
            panel1.Controls.Add(AnnotationY);
            panel1.Controls.Add(AnnotationX);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(AllowMoving);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 1;
            // 
            // ClipToChartArea
            // 
            ClipToChartArea.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            ClipToChartArea.Location = new Point(29, 40);
            ClipToChartArea.Name = "ClipToChartArea";
            ClipToChartArea.Size = new Size(152, 24);
            ClipToChartArea.TabIndex = 1;
            ClipToChartArea.Text = "&Clip To Chart Area:  ";
            ClipToChartArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            ClipToChartArea.CheckedChanged += new EventHandler(ClipToChartArea_CheckedChanged);
            // 
            // AnnotationY
            // 
            AnnotationY.Location = new Point(168, 104);
            AnnotationY.Name = "AnnotationY";
            AnnotationY.ReadOnly = true;
            AnnotationY.Size = new Size(40, 22);
            AnnotationY.TabIndex = 5;
            AnnotationY.Text = "0";
            // 
            // AnnotationX
            // 
            AnnotationX.Location = new Point(168, 72);
            AnnotationX.Name = "AnnotationX";
            AnnotationX.ReadOnly = true;
            AnnotationX.Size = new Size(40, 22);
            AnnotationX.TabIndex = 3;
            AnnotationX.Text = "0";
            // 
            // label2
            // 
            label2.Location = new Point(99, 104);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 4;
            label2.Text = "&Y:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(99, 72);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 2;
            label3.Text = "&X:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label3.Click += new EventHandler(label3_Click);
            // 
            // AllowMoving
            // 
            AllowMoving.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            AllowMoving.Checked = true;
            AllowMoving.CheckState = System.Windows.Forms.CheckState.Checked;
            AllowMoving.Location = new Point(61, 8);
            AllowMoving.Name = "AllowMoving";
            AllowMoving.Size = new Size(120, 24);
            AllowMoving.TabIndex = 0;
            AllowMoving.Text = "Allow &Moving:";
            AllowMoving.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            AllowMoving.CheckedChanged += new EventHandler(AllowMoving_CheckedChanged);
            // 
            // Chart1
            // 
            calloutAnnotation1.AllowMoving = true;
            calloutAnnotation1.AllowSelecting = true;
            calloutAnnotation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            calloutAnnotation1.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.RoundedRectangle;
            calloutAnnotation1.Font = new Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            calloutAnnotation1.Name = "MyAnnotation";
            calloutAnnotation1.Text = "Select and Reposition Me\\nusing the mouse";
            calloutAnnotation1.X = 0;
            calloutAnnotation1.Y = 0;
            Chart1.Annotations.Add(calloutAnnotation1);
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
            chartArea1.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Interval = 1;
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.IsLabelAutoFit = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.Maximum = 100;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.Maximum = 1000;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
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
            series1.ShadowOffset = 1;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.BorderWidth = 4;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Default";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.MarkerColor = System.Drawing.Color.Gold;
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.ShadowOffset = 1;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            series3.ShadowOffset = 1;
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 0;
            Chart1.AnnotationPositionChanged += new EventHandler(Chart1_AnnotationPositionChanged);
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 360);
            label1.Name = "label1";
            label1.Size = new Size(702, 39);
            label1.TabIndex = 3;
            label1.Text = "Click on the annotation, and then move it with the mouse. This sample uses the An" +
                "notationPositionChanged event to update X and Y coordinates to the right of the " +
                "chart.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PositionChangedEvent
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label1);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PositionChangedEvent";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void AnnotationPositioning_Load(object sender, EventArgs e)
		{ 
		
		}

		private void Chart1_AnnotationPositionChanged(object sender, EventArgs e)
		{
			Annotation annotation = (Annotation) sender;
			
			AnnotationX.Text = annotation.X.ToString("#.#");
			AnnotationY.Text = annotation.Y.ToString("#.#");


		}

		private void AllowMoving_CheckedChanged(object sender, EventArgs e)
		{
			Chart1.Annotations[0].AllowMoving = AllowMoving.Checked;
		}

		private void ClipToChartArea_CheckedChanged(object sender, EventArgs e)
		{
			if(ClipToChartArea.Checked)
				Chart1.Annotations[0].ClipToChartArea = "Default";
			else
				Chart1.Annotations[0].ClipToChartArea = "";
		
		}

		private void label3_Click(object sender, EventArgs e)
		{
		
		}






	}
}
