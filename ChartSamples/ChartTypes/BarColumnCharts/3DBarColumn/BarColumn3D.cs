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
	/// Summary description for BarColumn3D.
	/// </summary>
	public class BarColumn3D : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private CheckBox checkBoxShowMargin;
		private RadioButton radioButtonColumn;
		private RadioButton radioButtonBar;
		private CheckBox RightAngleAxis;
		private Label label2;
		private Label label1;
		private NumericUpDown Rotation;
		private NumericUpDown Inclination;
		private CheckBox checkClustered;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public BarColumn3D()
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
			ChartArea chartArea1 = new ChartArea();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(0, 6);
			DataPoint dataPoint2 = new DataPoint(0, 9);
			DataPoint dataPoint3 = new DataPoint(0, 5);
			DataPoint dataPoint4 = new DataPoint(0, 7.5);
			DataPoint dataPoint5 = new DataPoint(0, 5.6999998092651367);
			DataPoint dataPoint6 = new DataPoint(0, 3.2000000476837158);
			DataPoint dataPoint7 = new DataPoint(0, 8.5);
			DataPoint dataPoint8 = new DataPoint(0, 7.5);
			DataPoint dataPoint9 = new DataPoint(0, 6.5);
			Series series2 = new Series();
			DataPoint dataPoint10 = new DataPoint(0, 6);
			DataPoint dataPoint11 = new DataPoint(0, 9);
			DataPoint dataPoint12 = new DataPoint(0, 2);
			DataPoint dataPoint13 = new DataPoint(0, 7);
			DataPoint dataPoint14 = new DataPoint(0, 3);
			DataPoint dataPoint15 = new DataPoint(0, 5);
			DataPoint dataPoint16 = new DataPoint(0, 8);
			DataPoint dataPoint17 = new DataPoint(0, 2);
			DataPoint dataPoint18 = new DataPoint(0, 6);
			Series series3 = new Series();
			DataPoint dataPoint19 = new DataPoint(0, 4);
			DataPoint dataPoint20 = new DataPoint(0, 5);
			DataPoint dataPoint21 = new DataPoint(0, 2);
			DataPoint dataPoint22 = new DataPoint(0, 6);
			DataPoint dataPoint23 = new DataPoint(0, 1);
			DataPoint dataPoint24 = new DataPoint(0, 2);
			DataPoint dataPoint25 = new DataPoint(0, 3);
			DataPoint dataPoint26 = new DataPoint(0, 1);
			DataPoint dataPoint27 = new DataPoint(0, 2);
			Title title1 = new Title();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            checkClustered = new CheckBox();
            Rotation = new NumericUpDown();
            Inclination = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            RightAngleAxis = new CheckBox();
            checkBoxShowMargin = new CheckBox();
            radioButtonColumn = new RadioButton();
            radioButtonBar = new RadioButton();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
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
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 58);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
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
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.Points.Add(dataPoint15);
            series2.Points.Add(dataPoint16);
            series2.Points.Add(dataPoint17);
            series2.Points.Add(dataPoint18);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint19);
            series3.Points.Add(dataPoint20);
            series3.Points.Add(dataPoint21);
            series3.Points.Add(dataPoint22);
            series3.Points.Add(dataPoint23);
            series3.Points.Add(dataPoint24);
            series3.Points.Add(dataPoint25);
            series3.Points.Add(dataPoint26);
            series3.Points.Add(dataPoint27);
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "3D Bar and Column charts.";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 42);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates 3D Column and Bar charts. It also shows chart area rotat" +
                "ion and isometric projection, as well as clustering of series. ";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkClustered);
            panel1.Controls.Add(Rotation);
            panel1.Controls.Add(Inclination);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(RightAngleAxis);
            panel1.Controls.Add(checkBoxShowMargin);
            panel1.Controls.Add(radioButtonColumn);
            panel1.Controls.Add(radioButtonBar);
            panel1.Location = new Point(432, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // checkClustered
            // 
            checkClustered.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkClustered.Checked = true;
            checkClustered.CheckState = System.Windows.Forms.CheckState.Checked;
            checkClustered.Location = new Point(37, 136);
            checkClustered.Name = "checkClustered";
            checkClustered.Size = new Size(144, 24);
            checkClustered.TabIndex = 4;
            checkClustered.Text = "&Clustered:";
            checkClustered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkClustered.CheckedChanged += new EventHandler(checkClustered_CheckedChanged);
            // 
            // Rotation
            // 
            Rotation.Increment = new decimal([
            10,
            0,
            0,
            0]);
            Rotation.Location = new Point(168, 200);
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
            Rotation.TabIndex = 8;
            Rotation.Value = new decimal([
            15,
            0,
            0,
            0]);
            Rotation.ValueChanged += new EventHandler(Rotation_ValueChanged);
            // 
            // Inclination
            // 
            Inclination.Increment = new decimal([
            10,
            0,
            0,
            0]);
            Inclination.Location = new Point(168, 168);
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
            Inclination.TabIndex = 6;
            Inclination.Value = new decimal([
            15,
            0,
            0,
            0]);
            Inclination.ValueChanged += new EventHandler(Inclination_ValueChanged);
            // 
            // label2
            // 
            label2.Location = new Point(61, 200);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 7;
            label2.Text = "Rotate &Y:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(69, 168);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 5;
            label1.Text = "Rotate &X:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RightAngleAxis
            // 
            RightAngleAxis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            RightAngleAxis.Location = new Point(37, 104);
            RightAngleAxis.Name = "RightAngleAxis";
            RightAngleAxis.Size = new Size(144, 24);
            RightAngleAxis.TabIndex = 3;
            RightAngleAxis.Text = "&Right Angle Axes:";
            RightAngleAxis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            RightAngleAxis.CheckedChanged += new EventHandler(RightAngleAxis_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.Checked = true;
            checkBoxShowMargin.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxShowMargin.Location = new Point(5, 72);
            checkBoxShowMargin.Name = "checkBoxShowMargin";
            checkBoxShowMargin.Size = new Size(176, 24);
            checkBoxShowMargin.TabIndex = 2;
            checkBoxShowMargin.Text = "Show X Axis &Margin:";
            checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.CheckedChanged += new EventHandler(checkBoxShowMargin_CheckedChanged);
            // 
            // radioButtonColumn
            // 
            radioButtonColumn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonColumn.Checked = true;
            radioButtonColumn.Location = new Point(27, 40);
            radioButtonColumn.Name = "radioButtonColumn";
            radioButtonColumn.Size = new Size(152, 24);
            radioButtonColumn.TabIndex = 1;
            radioButtonColumn.TabStop = true;
            radioButtonColumn.Text = "3D C&olumn Chart:";
            radioButtonColumn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonColumn.CheckedChanged += new EventHandler(radioButtonColumn_CheckedChanged);
            // 
            // radioButtonBar
            // 
            radioButtonBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonBar.Location = new Point(43, 8);
            radioButtonBar.Name = "radioButtonBar";
            radioButtonBar.Size = new Size(136, 24);
            radioButtonBar.TabIndex = 0;
            radioButtonBar.Text = "3D &Bar Chart:";
            radioButtonBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonBar.CheckedChanged += new EventHandler(radioButtonBar_CheckedChanged);
            // 
            // BarColumn3D
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "BarColumn3D";
            Size = new Size(728, 480);
            Load += new EventHandler(BarColumn3D_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Rotation)).EndInit();
            ((ISupportInitialize)(Inclination)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			if(radioButtonBar.Checked)
			{
				// Set chart type to Bar
				chart1.Series["Default"].ChartType = SeriesChartType.Bar;
				chart1.Series["Series2"].ChartType = SeriesChartType.Bar;
				chart1.Series["Series3"].ChartType = SeriesChartType.Bar;
			}
			else
			{
				// Set chart type to Column
				chart1.Series["Default"].ChartType = SeriesChartType.Column;
				chart1.Series["Series2"].ChartType = SeriesChartType.Column;
				chart1.Series["Series3"].ChartType = SeriesChartType.Column;
			}

			// Disable/enable X axis margin
			chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;

			// Disable/enable right angle axis
			chart1.ChartAreas["Default"].Area3DStyle.IsRightAngleAxes = RightAngleAxis.Checked;

			// Disable/enable clustered series
			chart1.ChartAreas["Default"].Area3DStyle.IsClustered = checkClustered.Checked;

		}

		private void radioButtonBar_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void radioButtonColumn_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxShowMargin_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxShowMarkers_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxTension_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void RightAngleAxis_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
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

		private void checkClustered_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void BarColumn3D_Load(object sender, EventArgs e)
		{
		
		}

	}
}
