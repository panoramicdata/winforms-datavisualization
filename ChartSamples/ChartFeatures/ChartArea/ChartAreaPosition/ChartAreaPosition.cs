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
	/// Summary description for ChartAreaPosition.
	/// </summary>
	public class ChartAreaPosition : UserControl
	{
		# region Fields

		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label10;
		private Label label11;
		private Label label12;
		private NumericUpDown ChartArea_X;
		private NumericUpDown ChartArea_Y;
		private NumericUpDown ChartArea_Width;
		private NumericUpDown ChartArea_Height;
		private NumericUpDown PlottingArea_X;
		private NumericUpDown PlottingArea_Y;
		private NumericUpDown PlottingArea_Width;
		private NumericUpDown PlottingArea_Height;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		#endregion

		# region Constructor

		public ChartAreaPosition()
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
			CustomLabel customLabel1 = new CustomLabel();
			CustomLabel customLabel2 = new CustomLabel();
			CustomLabel customLabel3 = new CustomLabel();
			CustomLabel customLabel4 = new CustomLabel();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(1, 70);
			DataPoint dataPoint2 = new DataPoint(2, 80);
			DataPoint dataPoint3 = new DataPoint(3, 70);
			DataPoint dataPoint4 = new DataPoint(4, 85);
			Series series2 = new Series();
			DataPoint dataPoint5 = new DataPoint(1, 65);
			DataPoint dataPoint6 = new DataPoint(2, 70);
			DataPoint dataPoint7 = new DataPoint(3, 60);
			DataPoint dataPoint8 = new DataPoint(4, 75);
			Series series3 = new Series();
			DataPoint dataPoint9 = new DataPoint(1, 50);
			DataPoint dataPoint10 = new DataPoint(2, 55);
			DataPoint dataPoint11 = new DataPoint(3, 40);
			DataPoint dataPoint12 = new DataPoint(4, 70);
            label9 = new Label();
            panel1 = new Panel();
            PlottingArea_Height = new NumericUpDown();
            PlottingArea_Width = new NumericUpDown();
            PlottingArea_Y = new NumericUpDown();
            PlottingArea_X = new NumericUpDown();
            ChartArea_Height = new NumericUpDown();
            ChartArea_Width = new NumericUpDown();
            ChartArea_Y = new NumericUpDown();
            ChartArea_X = new NumericUpDown();
            label11 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Chart1 = new Chart();
            label12 = new Label();
            panel1.SuspendLayout();
            ((ISupportInitialize)(PlottingArea_Height)).BeginInit();
            ((ISupportInitialize)(PlottingArea_Width)).BeginInit();
            ((ISupportInitialize)(PlottingArea_Y)).BeginInit();
            ((ISupportInitialize)(PlottingArea_X)).BeginInit();
            ((ISupportInitialize)(ChartArea_Height)).BeginInit();
            ((ISupportInitialize)(ChartArea_Width)).BeginInit();
            ((ISupportInitialize)(ChartArea_Y)).BeginInit();
            ((ISupportInitialize)(ChartArea_X)).BeginInit();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 18;
            label9.Text = "This sample shows how to manually set the positions of the chart area and plot ar" +
                "ea. ";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(PlottingArea_Height);
            panel1.Controls.Add(PlottingArea_Width);
            panel1.Controls.Add(PlottingArea_Y);
            panel1.Controls.Add(PlottingArea_X);
            panel1.Controls.Add(ChartArea_Height);
            panel1.Controls.Add(ChartArea_Width);
            panel1.Controls.Add(ChartArea_Y);
            panel1.Controls.Add(ChartArea_X);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 312);
            panel1.TabIndex = 19;
            // 
            // PlottingArea_Height
            // 
            PlottingArea_Height.Location = new Point(176, 280);
            PlottingArea_Height.Name = "PlottingArea_Height";
            PlottingArea_Height.Size = new Size(112, 22);
            PlottingArea_Height.TabIndex = 21;
            PlottingArea_Height.Value = new decimal([
            80,
            0,
            0,
            0]);
            PlottingArea_Height.ValueChanged += new EventHandler(PlottingArea_Height_ValueChanged);
            // 
            // PlottingArea_Width
            // 
            PlottingArea_Width.Location = new Point(176, 248);
            PlottingArea_Width.Name = "PlottingArea_Width";
            PlottingArea_Width.Size = new Size(112, 22);
            PlottingArea_Width.TabIndex = 20;
            PlottingArea_Width.Value = new decimal([
            80,
            0,
            0,
            0]);
            PlottingArea_Width.ValueChanged += new EventHandler(PlottingArea_Width_ValueChanged);
            // 
            // PlottingArea_Y
            // 
            PlottingArea_Y.Location = new Point(176, 216);
            PlottingArea_Y.Maximum = new decimal([
            20,
            0,
            0,
            0]);
            PlottingArea_Y.Name = "PlottingArea_Y";
            PlottingArea_Y.Size = new Size(112, 22);
            PlottingArea_Y.TabIndex = 19;
            PlottingArea_Y.Value = new decimal([
            10,
            0,
            0,
            0]);
            PlottingArea_Y.ValueChanged += new EventHandler(PlottingArea_Y_ValueChanged);
            // 
            // PlottingArea_X
            // 
            PlottingArea_X.Location = new Point(176, 184);
            PlottingArea_X.Maximum = new decimal([
            20,
            0,
            0,
            0]);
            PlottingArea_X.Name = "PlottingArea_X";
            PlottingArea_X.Size = new Size(112, 22);
            PlottingArea_X.TabIndex = 18;
            PlottingArea_X.Value = new decimal([
            10,
            0,
            0,
            0]);
            PlottingArea_X.ValueChanged += new EventHandler(PlottingArea_X_ValueChanged);
            // 
            // ChartArea_Height
            // 
            ChartArea_Height.Location = new Point(168, 128);
            ChartArea_Height.Name = "ChartArea_Height";
            ChartArea_Height.Size = new Size(112, 22);
            ChartArea_Height.TabIndex = 17;
            ChartArea_Height.Value = new decimal([
            80,
            0,
            0,
            0]);
            ChartArea_Height.ValueChanged += new EventHandler(ChartArea_Height_ValueChanged);
            // 
            // ChartArea_Width
            // 
            ChartArea_Width.Location = new Point(168, 96);
            ChartArea_Width.Name = "ChartArea_Width";
            ChartArea_Width.Size = new Size(112, 22);
            ChartArea_Width.TabIndex = 16;
            ChartArea_Width.Value = new decimal([
            80,
            0,
            0,
            0]);
            ChartArea_Width.ValueChanged += new EventHandler(ChartArea_Width_ValueChanged);
            // 
            // ChartArea_Y
            // 
            ChartArea_Y.Location = new Point(168, 64);
            ChartArea_Y.Maximum = new decimal([
            15,
            0,
            0,
            0]);
            ChartArea_Y.Minimum = new decimal([
            1,
            0,
            0,
            0]);
            ChartArea_Y.Name = "ChartArea_Y";
            ChartArea_Y.Size = new Size(112, 22);
            ChartArea_Y.TabIndex = 15;
            ChartArea_Y.Value = new decimal([
            10,
            0,
            0,
            0]);
            ChartArea_Y.ValueChanged += new EventHandler(ChartArea_Y_ValueChanged);
            // 
            // ChartArea_X
            // 
            ChartArea_X.Location = new Point(168, 32);
            ChartArea_X.Maximum = new decimal([
            15,
            0,
            0,
            0]);
            ChartArea_X.Minimum = new decimal([
            1,
            0,
            0,
            0]);
            ChartArea_X.Name = "ChartArea_X";
            ChartArea_X.Size = new Size(112, 22);
            ChartArea_X.TabIndex = 14;
            ChartArea_X.Value = new decimal([
            10,
            0,
            0,
            0]);
            ChartArea_X.ValueChanged += new EventHandler(ChartArea_X_ValueChanged);
            // 
            // label11
            // 
            label11.Location = new Point(16, 160);
            label11.Name = "label11";
            label11.Size = new Size(144, 16);
            label11.TabIndex = 13;
            label11.Text = "Plotting Area Position:";
            // 
            // label6
            // 
            label6.Location = new Point(80, 280);
            label6.Name = "label6";
            label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label6.Size = new Size(88, 23);
            label6.TabIndex = 12;
            label6.Text = "Height:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(80, 248);
            label7.Name = "label7";
            label7.Size = new Size(88, 23);
            label7.TabIndex = 11;
            label7.Text = "Width:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new Point(80, 216);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 10;
            label8.Text = "Y:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Location = new Point(80, 184);
            label10.Name = "label10";
            label10.Size = new Size(88, 23);
            label10.TabIndex = 9;
            label10.Text = "X:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(80, 131);
            label5.Name = "label5";
            label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label5.Size = new Size(80, 16);
            label5.TabIndex = 4;
            label5.Text = "Height:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(80, 99);
            label4.Name = "label4";
            label4.Size = new Size(80, 16);
            label4.TabIndex = 3;
            label4.Text = "Width:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(80, 67);
            label3.Name = "label3";
            label3.Size = new Size(80, 16);
            label3.TabIndex = 2;
            label3.Text = "Y:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(72, 35);
            label2.Name = "label2";
            label2.Size = new Size(88, 16);
            label2.TabIndex = 1;
            label2.Text = "X:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 0;
            label1.Text = "Chart Area Position:";
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
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 5;
            chartArea1.Area3DStyle.WallWidth = 0;
            customLabel1.FromPosition = 0.5;
            customLabel1.Text = "John";
            customLabel1.ToPosition = 1.5;
            customLabel2.FromPosition = 1.5;
            customLabel2.Text = "Mary";
            customLabel2.ToPosition = 2.5;
            customLabel3.FromPosition = 2.5;
            customLabel3.Text = "Jeff";
            customLabel3.ToPosition = 3.5;
            customLabel4.FromPosition = 3.5;
            customLabel4.Text = "Bob";
            customLabel4.ToPosition = 4.5;
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.CustomLabels.Add(customLabel2);
            chartArea1.AxisX.CustomLabels.Add(customLabel3);
            chartArea1.AxisX.CustomLabels.Add(customLabel4);
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelAutoFitStyle = ((LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 75F;
            chartArea1.Position.Width = 90F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 13F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5F;
            legend1.Position.Width = 40F;
            legend1.Position.X = 5F;
            legend1.Position.Y = 85F;
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.Legend = "Legend2";
            series1.Name = "Series2";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Default";
            series2.Name = "Series3";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.CustomProperties = "DrawingStyle=Cylinder";
            series3.Legend = "Default";
            series3.Name = "Series4";
            series3.Points.Add(dataPoint9);
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 20;
            Chart1.PrePaint += new EventHandler<ChartPaintEventArgs>(Chart1_PrePaint);
            // 
            // label12
            // 
            label12.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label12.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new Point(16, 368);
            label12.Name = "label12";
            label12.Size = new Size(696, 40);
            label12.TabIndex = 21;
            label12.Text = "The plot area is the portion within a chart area that is used for plotting data, " +
                "and does not include tick marks and axis labels.";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChartAreaPosition
            // 
            Controls.Add(label12);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "ChartAreaPosition";
            Size = new Size(728, 480);
            Load += new EventHandler(ZOrder_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(PlottingArea_Height)).EndInit();
            ((ISupportInitialize)(PlottingArea_Width)).EndInit();
            ((ISupportInitialize)(PlottingArea_Y)).EndInit();
            ((ISupportInitialize)(PlottingArea_X)).EndInit();
            ((ISupportInitialize)(ChartArea_Height)).EndInit();
            ((ISupportInitialize)(ChartArea_Width)).EndInit();
            ((ISupportInitialize)(ChartArea_Y)).EndInit();
            ((ISupportInitialize)(ChartArea_X)).EndInit();
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		# endregion

		# region Methods

		private void Positions()
		{	
			Chart1.ChartAreas["Default"].Position.Auto = false;
			Chart1.ChartAreas["Default"].Position.X = (float)ChartArea_X.Value;
			Chart1.ChartAreas["Default"].Position.Y = (float)ChartArea_Y.Value;
			Chart1.ChartAreas["Default"].Position.Width = (float)ChartArea_Width.Value;
			Chart1.ChartAreas["Default"].Position.Height= (float)ChartArea_Height.Value;

			Chart1.ChartAreas["Default"].InnerPlotPosition.Auto = false;
			Chart1.ChartAreas["Default"].InnerPlotPosition.X = (float)PlottingArea_X.Value;
			Chart1.ChartAreas["Default"].InnerPlotPosition.Y = (float)PlottingArea_Y.Value;
			Chart1.ChartAreas["Default"].InnerPlotPosition.Width = (float)PlottingArea_Width.Value;
			Chart1.ChartAreas["Default"].InnerPlotPosition.Height = (float)PlottingArea_Height.Value;
		}	

		private void Chart1_PrePaint(object sender, ChartPaintEventArgs e)
		{
			if( sender is ChartArea )
			{
				RectangleF rect = e.ChartGraphics.GetAbsoluteRectangle( e.Chart.ChartAreas[0].Position.ToRectangleF() );
				e.ChartGraphics.Graphics.DrawRectangle( new Pen(Color.Red), rect.X, rect.Y, rect.Width, rect.Height);
			}
		}
		
		# endregion	

		# region Event Handlers

		private void ZOrder_Load(object sender, EventArgs e)
		{
			Positions();
		}

		private void ChartArea_X_ValueChanged(object sender, EventArgs e)
		{
			Positions();		
		}

		private void ChartArea_Y_ValueChanged(object sender, EventArgs e)
		{
			Positions();	
		}

		private void ChartArea_Width_ValueChanged(object sender, EventArgs e)
		{
			Positions();	
		}

		private void ChartArea_Height_ValueChanged(object sender, EventArgs e)
		{
			Positions();	
		}

		private void PlottingArea_X_ValueChanged(object sender, EventArgs e)
		{
			Positions();	
		}

		private void PlottingArea_Y_ValueChanged(object sender, EventArgs e)
		{
			Positions();	
		}

		private void PlottingArea_Width_ValueChanged(object sender, EventArgs e)
		{
			Positions();	
		}

		private void PlottingArea_Height_ValueChanged(object sender, EventArgs e)
		{
			Positions();	
		}

		# endregion
	}
}