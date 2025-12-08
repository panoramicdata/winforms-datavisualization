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
	/// Summary description for LabelsOverlapping.
	/// </summary>
	public class AnnotationSmartLabels : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private CheckBox checkBoxEnable;
		private Label label1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AnnotationSmartLabels()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Anchor annotation to the data point
			chart1.Annotations[0].AnchorDataPoint = chart1.Series[0].Points[2];

			// Enable annotations SmartLabels
			foreach(Annotation annotation in chart1.Annotations)
			{
				annotation.SmartLabelStyle.Enabled = true;
			}

			// Enable series SmartLabels
			foreach(Series series in chart1.Series)
			{
				series.SmartLabelStyle.Enabled = true;
			}
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
			DataPoint dataPoint1 = new DataPoint(0, 21);
			DataPoint dataPoint2 = new DataPoint(0, 14);
			DataPoint dataPoint3 = new DataPoint(0, 33);
			DataPoint dataPoint4 = new DataPoint(0, 57);
			DataPoint dataPoint5 = new DataPoint(0, 35);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 74);
			DataPoint dataPoint7 = new DataPoint(0, 25);
			DataPoint dataPoint8 = new DataPoint(0, 82);
			DataPoint dataPoint9 = new DataPoint(0, 21);
			DataPoint dataPoint10 = new DataPoint(0, 56);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 29);
			DataPoint dataPoint12 = new DataPoint(0, 77);
			DataPoint dataPoint13 = new DataPoint(0, 89);
			DataPoint dataPoint14 = new DataPoint(0, 44);
			DataPoint dataPoint15 = new DataPoint(0, 12);
			ComponentResourceManager resources = new ComponentResourceManager(typeof(AnnotationSmartLabels));
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            checkBoxEnable = new CheckBox();
            label1 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            calloutAnnotation1.AllowAnchorMoving = true;
            calloutAnnotation1.AllowSelecting = true;
            calloutAnnotation1.AnchorDataPointName = "Default\\r2";
            calloutAnnotation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            calloutAnnotation1.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
            calloutAnnotation1.Font = new Font("Trebuchet MS", 9F);
            calloutAnnotation1.Name = "Callout2";
            calloutAnnotation1.SmartLabelStyle.IsOverlappedHidden = false;
            calloutAnnotation1.Text = "Cloud Annotation";
            chart1.Annotations.Add(calloutAnnotation1);
            chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BackSecondaryColor = System.Drawing.Color.White;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
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
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 68);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "P0";
            series1.Legend = "Default";
            series1.MarkerSize = 9;
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.ShadowColor = System.Drawing.Color.Black;
            series1.ShadowOffset = 1;
            series1.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "P0";
            series2.Legend = "Default";
            series2.MarkerSize = 11;
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.ShadowColor = System.Drawing.Color.Black;
            series2.ShadowOffset = 1;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "P0";
            series3.Legend = "Default";
            series3.MarkerSize = 12;
            series3.Name = "Series3";
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            series3.ShadowColor = System.Drawing.Color.Black;
            series3.ShadowOffset = 1;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 0;
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 14);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 36);
            labelSampleComment.TabIndex = 2;
            labelSampleComment.Text = "This sample demonstrates how to use smart labels in the Annotation object to avoi" +
                "d overlapping other chart elements that use smart labels. ";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxEnable);
            panel1.Location = new Point(432, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 1;
            // 
            // checkBoxEnable
            // 
            checkBoxEnable.Checked = true;
            checkBoxEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxEnable.Location = new Point(48, 16);
            checkBoxEnable.Name = "checkBoxEnable";
            checkBoxEnable.Size = new Size(184, 24);
            checkBoxEnable.TabIndex = 0;
            checkBoxEnable.Text = "&Enable Smart Labels";
            checkBoxEnable.CheckedChanged += new EventHandler(Enable_CheckedChanged);
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 374);
            label1.Name = "label1";
            label1.Size = new Size(702, 56);
            label1.TabIndex = 3;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnnotationSmartLabels
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AnnotationSmartLabels";
            Size = new Size(728, 480);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void Enable_CheckedChanged(object sender, EventArgs e)
		{
			// Disable/Enable annotations SmartLabels
			foreach(Annotation annotation in chart1.Annotations)
			{
				annotation.SmartLabelStyle.Enabled = checkBoxEnable.Checked;
			}

			// Disable/Enable series SmartLabels
			foreach(Series series in chart1.Series)
			{
				series.SmartLabelStyle.Enabled = checkBoxEnable.Checked;
			}
		}

	}
}
