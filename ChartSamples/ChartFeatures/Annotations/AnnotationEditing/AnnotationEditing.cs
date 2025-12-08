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
	/// Summary description for AnnotationEditing.
	/// </summary>
	public class AnnotationEditing : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private CheckBox AllowTextEditingCheck;
		private CheckBox VisibleCheck;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AnnotationEditing()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			((CalloutAnnotation)Chart1.Annotations["ElipseAnnotation"]).IsMultiline = true;

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
			DataPoint dataPoint1 = new DataPoint(0, 700);
			DataPoint dataPoint2 = new DataPoint(0, 400);
			DataPoint dataPoint3 = new DataPoint(0, 200);
			DataPoint dataPoint4 = new DataPoint(0, 450);
			DataPoint dataPoint5 = new DataPoint(0, 300);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 760);
			DataPoint dataPoint7 = new DataPoint(0, 345);
			DataPoint dataPoint8 = new DataPoint(0, 700);
			DataPoint dataPoint9 = new DataPoint(0, 700);
			DataPoint dataPoint10 = new DataPoint(0, 560);
            label9 = new Label();
            panel1 = new Panel();
            VisibleCheck = new CheckBox();
            AllowTextEditingCheck = new CheckBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 1;
            label9.Text = "This sample demonstrates how to enable and disable text editing for an annotation" +
                ".  Double-click on the Annotation object to begin editing the text.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(VisibleCheck);
            panel1.Controls.Add(AllowTextEditingCheck);
            panel1.Location = new Point(432, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 19;
            // 
            // VisibleCheck
            // 
            VisibleCheck.Checked = true;
            VisibleCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            VisibleCheck.Location = new Point(48, 8);
            VisibleCheck.Name = "VisibleCheck";
            VisibleCheck.Size = new Size(144, 24);
            VisibleCheck.TabIndex = 1;
            VisibleCheck.Text = "Annotation &Visible";
            VisibleCheck.CheckedChanged += new EventHandler(VisibleCheck_CheckedChanged);
            // 
            // AllowTextEditingCheck
            // 
            AllowTextEditingCheck.Checked = true;
            AllowTextEditingCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            AllowTextEditingCheck.Location = new Point(48, 40);
            AllowTextEditingCheck.Name = "AllowTextEditingCheck";
            AllowTextEditingCheck.Size = new Size(200, 24);
            AllowTextEditingCheck.TabIndex = 0;
            AllowTextEditingCheck.Text = "Allow &Multiline Text Editing";
            AllowTextEditingCheck.CheckedChanged += new EventHandler(Enabled_CheckedChanged);
            // 
            // Chart1
            // 
            calloutAnnotation1.AllowTextEditing = true;
            calloutAnnotation1.AnchorDataPointName = "Default\\r2";
            calloutAnnotation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            calloutAnnotation1.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Ellipse;
            calloutAnnotation1.Font = new Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            calloutAnnotation1.Name = "ElipseAnnotation";
            calloutAnnotation1.Text = "Double Click to \\nEdit this Annotation";
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
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Interval = 0;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 0;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Interval = 0;
            chartArea1.AxisX.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.LabelStyle.Interval = 0;
            chartArea1.AxisX2.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisX2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorGrid.Interval = 0;
            chartArea1.AxisX2.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisX2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorTickMark.Interval = 0;
            chartArea1.AxisX2.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisX2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Interval = 0;
            chartArea1.AxisY.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Interval = 0;
            chartArea1.AxisY.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.Interval = 0;
            chartArea1.AxisY.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.LabelStyle.Interval = 0;
            chartArea1.AxisY2.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisY2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Interval = 0;
            chartArea1.AxisY2.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisY2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorTickMark.Interval = 0;
            chartArea1.AxisY2.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisY2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 84.1734F;
            chartArea1.InnerPlotPosition.Width = 88.71976F;
            chartArea1.InnerPlotPosition.X = 7.14066F;
            chartArea1.InnerPlotPosition.Y = 4.23579F;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 86.76062F;
            chartArea1.Position.Width = 88.77716F;
            chartArea1.Position.X = 5.089137F;
            chartArea1.Position.Y = 5.895753F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 60);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
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
            Chart1.TabIndex = 0;
            Chart1.KeyDown += new KeyEventHandler(Chart1_KeyDown);
            Chart1.Click += new EventHandler(Chart1_Click);
            // 
            // AnnotationEditing
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AnnotationEditing";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void Enabled_CheckedChanged(object sender, EventArgs e)
		{
			((CalloutAnnotation)Chart1.Annotations["ElipseAnnotation"]).IsMultiline = AllowTextEditingCheck.Checked;

		}

		private void Chart1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				Chart1.Annotations[0].ResizeToContent();
			}
		
		}

		private void Chart1_Click(object sender, EventArgs e)
		{
			Chart1.Focus();
		}

		private void VisibleCheck_CheckedChanged(object sender, EventArgs e)
		{
			Chart1.Annotations[0].Visible = VisibleCheck.Checked;
		}


	}
}
