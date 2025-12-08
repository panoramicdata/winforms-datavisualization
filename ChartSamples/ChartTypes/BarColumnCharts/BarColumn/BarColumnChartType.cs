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
	/// Summary description for BarColumnChartType.
	/// </summary>
	public class BarColumnChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxPointWidth;
		private Label label3;
		private CheckBox checkBoxShow3D;
		private ComboBox comboBoxChartType;
		private Label label2;
		private ComboBox comboBoxDrawingStyle;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public BarColumnChartType()
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
			DataPoint dataPoint1 = new DataPoint(36890, 32);
			DataPoint dataPoint2 = new DataPoint(36891, 56);
			DataPoint dataPoint3 = new DataPoint(36892, 35);
			DataPoint dataPoint4 = new DataPoint(36893, 12);
			DataPoint dataPoint5 = new DataPoint(36894, 35);
			DataPoint dataPoint6 = new DataPoint(36895, 6);
			DataPoint dataPoint7 = new DataPoint(36896, 23);
			Series series2 = new Series();
			DataPoint dataPoint8 = new DataPoint(36890, 67);
			DataPoint dataPoint9 = new DataPoint(36891, 24);
			DataPoint dataPoint10 = new DataPoint(36892, 12);
			DataPoint dataPoint11 = new DataPoint(36893, 8);
			DataPoint dataPoint12 = new DataPoint(36894, 46);
			DataPoint dataPoint13 = new DataPoint(36895, 14);
			DataPoint dataPoint14 = new DataPoint(36896, 76);
			Title title1 = new Title();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            comboBoxDrawingStyle = new ComboBox();
            label2 = new Label();
            comboBoxChartType = new ComboBox();
            checkBoxShow3D = new CheckBox();
            label3 = new Label();
            comboBoxPointWidth = new ComboBox();
            label1 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
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
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "MM-dd";
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Format = "C0";
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
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
            chart1.Location = new Point(16, 64);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 0;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Column Chart";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 39);
            labelSampleComment.TabIndex = 2;
            labelSampleComment.Text = "This sample demonstrates the Column and Bar chart types.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxDrawingStyle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxChartType);
            panel1.Controls.Add(checkBoxShow3D);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxPointWidth);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 0;
            // 
            // comboBoxDrawingStyle
            // 
            comboBoxDrawingStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxDrawingStyle.Items.AddRange([
            "Default",
            "Emboss",
            "Cylinder",
            "Wedge",
            "LightToDark"]);
            comboBoxDrawingStyle.Location = new Point(168, 72);
            comboBoxDrawingStyle.Name = "comboBoxDrawingStyle";
            comboBoxDrawingStyle.Size = new Size(112, 22);
            comboBoxDrawingStyle.TabIndex = 11;
            comboBoxDrawingStyle.SelectedIndexChanged += new EventHandler(comboBoxDrawingEffect_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(51, 72);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 10;
            label2.Text = "Drawing Style:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxChartType
            // 
            comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxChartType.Items.AddRange([
            "Column",
            "Bar"]);
            comboBoxChartType.Location = new Point(168, 8);
            comboBoxChartType.Name = "comboBoxChartType";
            comboBoxChartType.Size = new Size(112, 22);
            comboBoxChartType.TabIndex = 9;
            comboBoxChartType.SelectedIndexChanged += new EventHandler(comboBoxChartType_SelectedIndexChanged);
            // 
            // checkBoxShow3D
            // 
            checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.Location = new Point(22, 103);
            checkBoxShow3D.Name = "checkBoxShow3D";
            checkBoxShow3D.Size = new Size(160, 24);
            checkBoxShow3D.TabIndex = 5;
            checkBoxShow3D.Text = "Display chart as 3&D:";
            checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.CheckedChanged += new EventHandler(checkBoxShow3D_CheckedChanged);
            // 
            // label3
            // 
            label3.Location = new Point(43, 8);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 7;
            label3.Text = "Chart &Type:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxPointWidth
            // 
            comboBoxPointWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxPointWidth.Items.AddRange([
            "1.0",
            "0.8",
            "0.6",
            "0.4"]);
            comboBoxPointWidth.Location = new Point(168, 40);
            comboBoxPointWidth.Name = "comboBoxPointWidth";
            comboBoxPointWidth.Size = new Size(112, 22);
            comboBoxPointWidth.TabIndex = 2;
            comboBoxPointWidth.SelectedIndexChanged += new EventHandler(comboBoxPointWidth_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(64, 40);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 3;
            label1.Text = "Point &Width:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BarColumnChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "BarColumnChartType";
            Size = new Size(728, 384);
            Load += new EventHandler(BarColumnChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			foreach (Series series in chart1.Series) 
			{
				// Set series type
				if (comboBoxChartType.SelectedItem.ToString() == "Bar")
				{
					series.ChartType = SeriesChartType.Bar;
					chart1.Titles[0].Text = "Bar Chart";
				}
				else
				{
					series.ChartType = SeriesChartType.Column;
					chart1.Titles[0].Text = "Column Chart";
				}

				// Set point width of the series
				series["PointWidth"] = comboBoxPointWidth.Text;

				// Set drawing style
				series["DrawingStyle"] = comboBoxDrawingStyle.Text;
			}
		}

		private void BarColumnChartType_Load(object sender, EventArgs e)
		{
			comboBoxChartType.SelectedIndex = 0;
			comboBoxDrawingStyle.SelectedIndex = 0;
			comboBoxPointWidth.SelectedIndex = 1;
			checkBoxShow3D.Checked = false;
			chart1.ChartAreas[0].AxisX.LabelStyle.IntervalOffset = 1;
			chart1.ChartAreas[0].AxisX.LabelStyle.IntervalOffsetType = DateTimeIntervalType.Days;
			chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 2;
			chart1.ChartAreas[0].AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Days;

			UpdateChartSettings();
		}

		private void radioButtonColumn_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void radioButtonBar_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxPointWidth_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxPointLabels_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxEndLabels_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
		{
			chart1.ChartAreas[0].Area3DStyle.Enable3D = checkBoxShow3D.Checked;
		}

		private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void comboBoxDrawingEffect_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

//		private void checkBoxCylinder_CheckedChanged(object sender, System.EventArgs e)
//		{
//			// Set "DrawingStyle" custom attribute
//			foreach(Series series in chart1.Series)
//			{
//				series.DeleteCustomProperty("DrawingStyle");
//				if(checkBoxCylinder.Checked)
//				{
//					series["DrawingStyle"] = "Cylinder";
//				}
//			}
//
//			// Invalidate and update the chart
//			chart1.Invalidate();
//			chart1.Update();
//		}

	}
}
