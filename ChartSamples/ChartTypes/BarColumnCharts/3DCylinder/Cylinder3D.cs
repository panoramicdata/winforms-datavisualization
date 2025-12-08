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
	/// Summary description for Cylinder3D.
	/// </summary>
	public class Cylinder3D : UserControl
	{
		private	Point	mouseDownPoint = Point.Empty;
		private	int		origRotation = 0;
		private	int		origInclination = 0;

		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private RadioButton radioButtonColumn;
		private RadioButton radioButtonBar;
		private CheckBox checkClustered;
		private NumericUpDown numericUpDownPointGapDepth;
		private NumericUpDown numericUpDownPointDepth;
		private Label label3;
		private Label label4;
		private Label label1;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public Cylinder3D()
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
			DataPoint dataPoint6 = new DataPoint(0, 7);
			DataPoint dataPoint7 = new DataPoint(0, 8.5);
			Series series2 = new Series();
			DataPoint dataPoint8 = new DataPoint(0, 6);
			DataPoint dataPoint9 = new DataPoint(0, 9);
			DataPoint dataPoint10 = new DataPoint(0, 2);
			DataPoint dataPoint11 = new DataPoint(0, 7);
			DataPoint dataPoint12 = new DataPoint(0, 3);
			DataPoint dataPoint13 = new DataPoint(0, 5);
			DataPoint dataPoint14 = new DataPoint(0, 8);
			Series series3 = new Series();
			DataPoint dataPoint15 = new DataPoint(0, 4);
			DataPoint dataPoint16 = new DataPoint(0, 2);
			DataPoint dataPoint17 = new DataPoint(0, 1);
			DataPoint dataPoint18 = new DataPoint(0, 3);
			DataPoint dataPoint19 = new DataPoint(0, 2);
			DataPoint dataPoint20 = new DataPoint(0, 3);
			DataPoint dataPoint21 = new DataPoint(0, 5);
			Title title1 = new Title();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            numericUpDownPointGapDepth = new NumericUpDown();
            numericUpDownPointDepth = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            checkClustered = new CheckBox();
            radioButtonColumn = new RadioButton();
            radioButtonBar = new RadioButton();
            label1 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)(numericUpDownPointGapDepth)).BeginInit();
            ((ISupportInitialize)(numericUpDownPointDepth)).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BackSecondaryColor = System.Drawing.Color.White;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            chart1.Cursor = System.Windows.Forms.Cursors.Hand;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 53);
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
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint15);
            series3.Points.Add(dataPoint16);
            series3.Points.Add(dataPoint17);
            series3.Points.Add(dataPoint18);
            series3.Points.Add(dataPoint19);
            series3.Points.Add(dataPoint20);
            series3.Points.Add(dataPoint21);
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
            title1.Text = "3D Cylinder";
            chart1.Titles.Add(title1);
            chart1.MouseUp += new MouseEventHandler(chart1_MouseUp);
            chart1.MouseMove += new MouseEventHandler(chart1_MouseMove);
            chart1.MouseDown += new MouseEventHandler(chart1_MouseDown);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 37);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to display 3D Bar and Column charts as cylinders. Cy" +
                "linders may be applied to an entire data series or to specific points within a s" +
                "eries. ";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDownPointGapDepth);
            panel1.Controls.Add(numericUpDownPointDepth);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(checkClustered);
            panel1.Controls.Add(radioButtonColumn);
            panel1.Controls.Add(radioButtonBar);
            panel1.Location = new Point(432, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 280);
            panel1.TabIndex = 2;
            // 
            // numericUpDownPointGapDepth
            // 
            numericUpDownPointGapDepth.Increment = new decimal([
            50,
            0,
            0,
            0]);
            numericUpDownPointGapDepth.Location = new Point(168, 136);
            numericUpDownPointGapDepth.Maximum = new decimal([
            1000,
            0,
            0,
            0]);
            numericUpDownPointGapDepth.Name = "numericUpDownPointGapDepth";
            numericUpDownPointGapDepth.Size = new Size(56, 22);
            numericUpDownPointGapDepth.TabIndex = 6;
            numericUpDownPointGapDepth.Value = new decimal([
            100,
            0,
            0,
            0]);
            numericUpDownPointGapDepth.ValueChanged += new EventHandler(numericUpDownPointGapDepth_ValueChanged);
            // 
            // numericUpDownPointDepth
            // 
            numericUpDownPointDepth.Increment = new decimal([
            25,
            0,
            0,
            0]);
            numericUpDownPointDepth.Location = new Point(168, 104);
            numericUpDownPointDepth.Maximum = new decimal([
            1000,
            0,
            0,
            0]);
            numericUpDownPointDepth.Name = "numericUpDownPointDepth";
            numericUpDownPointDepth.Size = new Size(56, 22);
            numericUpDownPointDepth.TabIndex = 4;
            numericUpDownPointDepth.Value = new decimal([
            100,
            0,
            0,
            0]);
            numericUpDownPointDepth.ValueChanged += new EventHandler(numericUpDownPointDepth_ValueChanged);
            // 
            // label3
            // 
            label3.Location = new Point(18, 136);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 5;
            label3.Text = "&Gap Depth:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(10, 104);
            label4.Name = "label4";
            label4.Size = new Size(152, 23);
            label4.TabIndex = 3;
            label4.Text = "Point &Depth:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkClustered
            // 
            checkClustered.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkClustered.Checked = true;
            checkClustered.CheckState = System.Windows.Forms.CheckState.Checked;
            checkClustered.Location = new Point(45, 72);
            checkClustered.Name = "checkClustered";
            checkClustered.Size = new Size(136, 24);
            checkClustered.TabIndex = 2;
            checkClustered.Text = "C&lustered:";
            checkClustered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkClustered.CheckedChanged += new EventHandler(checkClustered_CheckedChanged);
            // 
            // radioButtonColumn
            // 
            radioButtonColumn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonColumn.Checked = true;
            radioButtonColumn.Location = new Point(13, 40);
            radioButtonColumn.Name = "radioButtonColumn";
            radioButtonColumn.Size = new Size(168, 24);
            radioButtonColumn.TabIndex = 1;
            radioButtonColumn.TabStop = true;
            radioButtonColumn.Text = "3D &Column Cylinder:";
            radioButtonColumn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonColumn.CheckedChanged += new EventHandler(radioButtonColumn_CheckedChanged);
            // 
            // radioButtonBar
            // 
            radioButtonBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonBar.Location = new Point(29, 8);
            radioButtonBar.Name = "radioButtonBar";
            radioButtonBar.Size = new Size(152, 24);
            radioButtonBar.TabIndex = 0;
            radioButtonBar.Text = "3D &Bar Cylinder:";
            radioButtonBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonBar.CheckedChanged += new EventHandler(radioButtonBar_CheckedChanged);
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 349);
            label1.Name = "label1";
            label1.Size = new Size(702, 32);
            label1.TabIndex = 3;
            label1.Text = "Click on the chart and drag the mouse to rotate the chart.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cylinder3D
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "Cylinder3D";
            Size = new Size(728, 480);
            Load += new EventHandler(Cylinder3D_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(numericUpDownPointGapDepth)).EndInit();
            ((ISupportInitialize)(numericUpDownPointDepth)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Set Cylinder drawing style attribute
			chart1.Series["Default"]["DrawingStyle"] = "Cylinder";
			chart1.Series["Series2"]["DrawingStyle"] = "Cylinder";
			chart1.Series["Series3"]["DrawingStyle"] = "Cylinder";

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

			// Disable/enable clustered series
			chart1.ChartAreas["Default"].Area3DStyle.IsClustered = checkClustered.Checked;

			// Set point depth
			chart1.ChartAreas["Default"].Area3DStyle.PointDepth = (int)numericUpDownPointDepth.Value;
			chart1.ChartAreas["Default"].Area3DStyle.PointGapDepth = (int)numericUpDownPointGapDepth.Value;
		}

		private void radioButtonBar_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void radioButtonColumn_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkClustered_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void numericUpDownPointDepth_ValueChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void numericUpDownPointGapDepth_ValueChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void chart1_MouseDown(object sender, MouseEventArgs e)
		{
			chart1.Cursor = Cursors.NoMove2D;	
			mouseDownPoint = new Point(e.X, e.Y);
			origRotation = chart1.ChartAreas[0].Area3DStyle.Rotation;
			origInclination = chart1.ChartAreas[0].Area3DStyle.Inclination;
		}

		private void chart1_MouseUp(object sender, MouseEventArgs e)
		{
			chart1.Cursor = Cursors.Hand;	
			mouseDownPoint = Point.Empty;
		}

		private void chart1_MouseMove(object sender, MouseEventArgs e)
		{
			if(!mouseDownPoint.IsEmpty)
			{
				int		RotationDelta = (mouseDownPoint.X - e.X);
				int		Rotation = origRotation;
				for(int i = 0; i != RotationDelta; )
				{
					if(RotationDelta > 0)
					{
						if(Rotation >= 180)
						{
							Rotation = -180;
						}
						++Rotation;
					}
					else
					{
						if(Rotation <= -180)
						{
							Rotation = 180;
						}
						--Rotation;
					}

					i += (RotationDelta > 0) ? 1 : -1;
				}
				chart1.ChartAreas[0].Area3DStyle.Rotation = Rotation;

				int		InclinationDelta = (e.Y - mouseDownPoint.Y);
				int		Inclination = origInclination;
				for(int i = 0; i != InclinationDelta; )
				{
					if(InclinationDelta > 0)
					{
						if(Inclination >= 90)
						{
							Inclination = -90;
						}
						++Inclination;
					}
					else
					{
						if(Inclination <= -90)
						{
							Inclination = 90;
						}
						--Inclination;
					}

					i += (InclinationDelta > 0) ? 1 : -1;
				}
				chart1.ChartAreas[0].Area3DStyle.Inclination = Inclination;

				chart1.Invalidate();
				chart1.Update();
			}
		}

		private void Cylinder3D_Load(object sender, EventArgs e)
		{
			// Set Cylinder drawing style attribute
			chart1.Series["Default"]["DrawingStyle"] = "Cylinder";
			chart1.Series["Series2"]["DrawingStyle"] = "Cylinder";
			chart1.Series["Series3"]["DrawingStyle"] = "Cylinder";
		}

	}
}
