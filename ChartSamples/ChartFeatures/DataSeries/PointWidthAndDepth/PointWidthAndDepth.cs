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
	/// Summary description for PointWidthAndDepth.
	/// </summary>
	public class PointWidthAndDepth: UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label15;
		private Label ZOrder;
		private Label label1;
		private Label label2;
		private NumericUpDown numericUpDownGap;
		private NumericUpDown numericUpDownDepth;
		private NumericUpDown numericUpDownWidth;
		private CheckBox checkBox3D;
		private CheckBox checkBoxClustered;
		private Label label10;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public PointWidthAndDepth()
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
			DataPoint dataPoint1 = new DataPoint(0, 14);
			DataPoint dataPoint2 = new DataPoint(0, 18);
			DataPoint dataPoint3 = new DataPoint(0, 14);
			DataPoint dataPoint4 = new DataPoint(0, 18);
			DataPoint dataPoint5 = new DataPoint(0, 16);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 10);
			DataPoint dataPoint7 = new DataPoint(0, 19);
			DataPoint dataPoint8 = new DataPoint(0, 8);
			DataPoint dataPoint9 = new DataPoint(0, 12);
			DataPoint dataPoint10 = new DataPoint(0, 18);
            label9 = new Label();
            panel1 = new Panel();
            checkBoxClustered = new CheckBox();
            numericUpDownGap = new NumericUpDown();
            numericUpDownDepth = new NumericUpDown();
            numericUpDownWidth = new NumericUpDown();
            checkBox3D = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label15 = new Label();
            ZOrder = new Label();
            Chart1 = new Chart();
            label10 = new Label();
            panel1.SuspendLayout();
            ((ISupportInitialize)(numericUpDownGap)).BeginInit();
            ((ISupportInitialize)(numericUpDownDepth)).BeginInit();
            ((ISupportInitialize)(numericUpDownWidth)).BeginInit();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(696, 40);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to set data point width to a specified number of pix" +
                "els. It also shows how to set series point depth in pixels.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxClustered);
            panel1.Controls.Add(numericUpDownGap);
            panel1.Controls.Add(numericUpDownDepth);
            panel1.Controls.Add(numericUpDownWidth);
            panel1.Controls.Add(checkBox3D);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(ZOrder);
            panel1.Location = new Point(432, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 296);
            panel1.TabIndex = 2;
            // 
            // checkBoxClustered
            // 
            checkBoxClustered.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxClustered.Enabled = false;
            checkBoxClustered.Location = new Point(11, 72);
            checkBoxClustered.Name = "checkBoxClustered";
            checkBoxClustered.Size = new Size(172, 24);
            checkBoxClustered.TabIndex = 3;
            checkBoxClustered.Text = "&Clustered:";
            checkBoxClustered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxClustered.CheckedChanged += new EventHandler(checkBoxClustered_CheckedChanged);
            // 
            // numericUpDownGap
            // 
            numericUpDownGap.Enabled = false;
            numericUpDownGap.Increment = new decimal([
            10,
            0,
            0,
            0]);
            numericUpDownGap.Location = new Point(168, 136);
            numericUpDownGap.Maximum = new decimal([
            500,
            0,
            0,
            0]);
            numericUpDownGap.Minimum = new decimal([
            5,
            0,
            0,
            0]);
            numericUpDownGap.Name = "numericUpDownGap";
            numericUpDownGap.Size = new Size(72, 22);
            numericUpDownGap.TabIndex = 7;
            numericUpDownGap.Value = new decimal([
            10,
            0,
            0,
            0]);
            numericUpDownGap.ValueChanged += new EventHandler(numericUpDownGap_ValueChanged);
            // 
            // numericUpDownDepth
            // 
            numericUpDownDepth.Enabled = false;
            numericUpDownDepth.Increment = new decimal([
            10,
            0,
            0,
            0]);
            numericUpDownDepth.Location = new Point(168, 104);
            numericUpDownDepth.Maximum = new decimal([
            500,
            0,
            0,
            0]);
            numericUpDownDepth.Minimum = new decimal([
            5,
            0,
            0,
            0]);
            numericUpDownDepth.Name = "numericUpDownDepth";
            numericUpDownDepth.Size = new Size(72, 22);
            numericUpDownDepth.TabIndex = 5;
            numericUpDownDepth.Value = new decimal([
            70,
            0,
            0,
            0]);
            numericUpDownDepth.ValueChanged += new EventHandler(numericUpDownDepth_ValueChanged);
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Increment = new decimal([
            5,
            0,
            0,
            0]);
            numericUpDownWidth.Location = new Point(168, 6);
            numericUpDownWidth.Maximum = new decimal([
            50,
            0,
            0,
            0]);
            numericUpDownWidth.Minimum = new decimal([
            5,
            0,
            0,
            0]);
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(72, 22);
            numericUpDownWidth.TabIndex = 1;
            numericUpDownWidth.Value = new decimal([
            45,
            0,
            0,
            0]);
            numericUpDownWidth.ValueChanged += new EventHandler(numericUpDownWidth_ValueChanged);
            // 
            // checkBox3D
            // 
            checkBox3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBox3D.Location = new Point(11, 40);
            checkBox3D.Name = "checkBox3D";
            checkBox3D.Size = new Size(172, 24);
            checkBox3D.TabIndex = 2;
            checkBox3D.Text = "3&D Chart: ";
            checkBox3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBox3D.CheckedChanged += new EventHandler(checkBox3D_CheckedChanged);
            // 
            // label2
            // 
            label2.Location = new Point(0, 139);
            label2.Name = "label2";
            label2.Size = new Size(164, 16);
            label2.TabIndex = 6;
            label2.Text = "Point &Gap Depth in Pixels:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(11, 107);
            label1.Name = "label1";
            label1.Size = new Size(156, 16);
            label1.TabIndex = 4;
            label1.Text = "Point &Depth in Pixels:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new Point(64, 472);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 7;
            label8.Text = "Shadow Offset:";
            // 
            // label7
            // 
            label7.Location = new Point(64, 449);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 6;
            label7.Text = "Border Style:";
            // 
            // label6
            // 
            label6.Location = new Point(64, 403);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 11;
            label6.Text = "Border Size:";
            // 
            // label5
            // 
            label5.Location = new Point(64, 380);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 10;
            label5.Text = "Border Color:";
            // 
            // label4
            // 
            label4.Location = new Point(64, 357);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 9;
            label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            label3.Location = new Point(64, 334);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 8;
            label3.Text = "Gradient:";
            // 
            // label15
            // 
            label15.Location = new Point(64, 426);
            label15.Name = "label15";
            label15.Size = new Size(100, 23);
            label15.TabIndex = 5;
            label15.Text = "Border Size:";
            // 
            // ZOrder
            // 
            ZOrder.Location = new Point(11, 9);
            ZOrder.Name = "ZOrder";
            ZOrder.Size = new Size(156, 16);
            ZOrder.TabIndex = 0;
            ZOrder.Text = "Point &Width in Pixels:";
            ZOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Chart1
            // 
            Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            Chart1.BorderlineWidth = 2;
            Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
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
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "Default";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 68);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series1.CustomProperties = "PixelPointWidth=45, PixelPointDepth=70, PixelPointGapDepth=10";
            series1.Legend = "Default";
            series1.Name = "Series 2";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series2.CustomProperties = "PixelPointWidth=45, PixelPointDepth=70, PixelPointGapDepth=10";
            series2.Legend = "Default";
            series2.Name = "Series 1";
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
            // 
            // label10
            // 
            label10.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label10.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new Point(20, 376);
            label10.Name = "label10";
            label10.Size = new Size(696, 40);
            label10.TabIndex = 3;
            label10.Text = "The point width and depth are set to absolute values and do not depend on the num" +
                "ber of points in the series.";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PointWidthAndDepth
            // 
            Controls.Add(label10);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PointWidthAndDepth";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(numericUpDownGap)).EndInit();
            ((ISupportInitialize)(numericUpDownDepth)).EndInit();
            ((ISupportInitialize)(numericUpDownWidth)).EndInit();
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
		{
			foreach(Series ser in Chart1.Series)
			{
				ser["PixelPointWidth"] = numericUpDownWidth.Value.ToString();
			}
			Chart1.Invalidate();
		}

		private void checkBox3D_CheckedChanged(object sender, EventArgs e)
		{
			Chart1.ChartAreas["Default"].Area3DStyle.Enable3D = checkBox3D.Checked;
			numericUpDownDepth.Enabled = checkBox3D.Checked;
			numericUpDownGap.Enabled = checkBox3D.Checked;
			checkBoxClustered.Enabled = checkBox3D.Checked;
		}

		private void numericUpDownDepth_ValueChanged(object sender, EventArgs e)
		{
			foreach(Series ser in Chart1.Series)
			{
				ser["PixelPointDepth"] = numericUpDownDepth.Value.ToString();
			}
			Chart1.Invalidate();
		}

		private void numericUpDownGap_ValueChanged(object sender, EventArgs e)
		{
			foreach(Series ser in Chart1.Series)
			{
				ser["PixelPointGapDepth"] = numericUpDownGap.Value.ToString();
			}
			Chart1.Invalidate();
		}

		private void checkBoxClustered_CheckedChanged(object sender, EventArgs e)
		{
			Chart1.ChartAreas["Default"].Area3DStyle.IsClustered = checkBoxClustered.Checked;
		}

	}
}
