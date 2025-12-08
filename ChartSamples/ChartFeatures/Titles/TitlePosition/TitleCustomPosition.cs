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
	/// Summary description for LegendCustomPosition.
	/// </summary>
	public class TitleCustomPosition : UserControl
	{
		private Label label9;
		private Chart Chart1;
		private Panel panel1;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private NumericUpDown numericUpDownX;
		private NumericUpDown numericUpDownY;
		private NumericUpDown numericUpDownWidth;
		private NumericUpDown numericUpDownHeight;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public TitleCustomPosition()
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
			Title title1 = new Title();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(TitleCustomPosition));
            label9 = new Label();
            Chart1 = new Chart();
            panel1 = new Panel();
            numericUpDownHeight = new NumericUpDown();
            numericUpDownWidth = new NumericUpDown();
            numericUpDownY = new NumericUpDown();
            numericUpDownX = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((ISupportInitialize)(Chart1)).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)(numericUpDownHeight)).BeginInit();
            ((ISupportInitialize)(numericUpDownWidth)).BeginInit();
            ((ISupportInitialize)(numericUpDownY)).BeginInit();
            ((ISupportInitialize)(numericUpDownX)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 12);
            label9.Name = "label9";
            label9.Size = new Size(702, 45);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to position the chart by setting the coordinates of " +
                "its top left corner, width, and height. ";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
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
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.BorderWidth = 0;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 65);
            Chart1.Name = "Chart1";
            Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.Legend = "Default";
            series1.LegendText = "Total";
            series1.Name = "Series2";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Default";
            series2.LegendText = "Sales";
            series2.Name = "Series3";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.CustomProperties = "DrawingStyle=Cylinder";
            series3.Legend = "Default";
            series3.LegendText = "Clients";
            series3.Name = "Series4";
            series3.Points.Add(dataPoint9);
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            title1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.Position.Auto = false;
            title1.Position.Height = 8.738057F;
            title1.Position.Width = 80F;
            title1.Position.X = 4F;
            title1.Position.Y = 4F;
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.Text = "Chart Control for .NET Framework";
            Chart1.Titles.Add(title1);
            Chart1.MouseDown += new MouseEventHandler(Chart1_MouseDown);
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDownHeight);
            panel1.Controls.Add(numericUpDownWidth);
            panel1.Controls.Add(numericUpDownY);
            panel1.Controls.Add(numericUpDownX);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(432, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 296);
            panel1.TabIndex = 2;
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Location = new Point(168, 104);
            numericUpDownHeight.Maximum = new decimal([
            90,
            0,
            0,
            0]);
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(72, 22);
            numericUpDownHeight.TabIndex = 7;
            numericUpDownHeight.Value = new decimal([
            9,
            0,
            0,
            0]);
            numericUpDownHeight.ValueChanged += new EventHandler(numericUpDownHeight_ValueChanged);
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Location = new Point(168, 72);
            numericUpDownWidth.Maximum = new decimal([
            90,
            0,
            0,
            0]);
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(72, 22);
            numericUpDownWidth.TabIndex = 5;
            numericUpDownWidth.Value = new decimal([
            55,
            0,
            0,
            0]);
            numericUpDownWidth.ValueChanged += new EventHandler(numericUpDownWidth_ValueChanged);
            // 
            // numericUpDownY
            // 
            numericUpDownY.Location = new Point(168, 40);
            numericUpDownY.Maximum = new decimal([
            90,
            0,
            0,
            0]);
            numericUpDownY.Name = "numericUpDownY";
            numericUpDownY.Size = new Size(72, 22);
            numericUpDownY.TabIndex = 3;
            numericUpDownY.Value = new decimal([
            4,
            0,
            0,
            0]);
            numericUpDownY.ValueChanged += new EventHandler(numericUpDownY_ValueChanged);
            // 
            // numericUpDownX
            // 
            numericUpDownX.Location = new Point(168, 8);
            numericUpDownX.Maximum = new decimal([
            70,
            0,
            0,
            0]);
            numericUpDownX.Name = "numericUpDownX";
            numericUpDownX.Size = new Size(72, 22);
            numericUpDownX.TabIndex = 1;
            numericUpDownX.Value = new decimal([
            4,
            0,
            0,
            0]);
            numericUpDownX.ValueChanged += new EventHandler(numericUpDownX_ValueChanged);
            // 
            // label5
            // 
            label5.Location = new Point(12, 104);
            label5.Name = "label5";
            label5.Size = new Size(152, 22);
            label5.TabIndex = 6;
            label5.Text = "&Height:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(12, 72);
            label4.Name = "label4";
            label4.Size = new Size(152, 22);
            label4.TabIndex = 4;
            label4.Text = "&Width:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(12, 40);
            label3.Name = "label3";
            label3.Size = new Size(152, 22);
            label3.TabIndex = 2;
            label3.Text = "&Y:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(152, 22);
            label2.TabIndex = 0;
            label2.Text = "&X:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 377);
            label1.Name = "label1";
            label1.Size = new Size(702, 71);
            label1.TabIndex = 3;
            label1.Text = resources.GetString("label1.Text");
            // 
            // TitleCustomPosition
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Chart1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "TitleCustomPosition";
            Size = new Size(728, 448);
            Load += new EventHandler(LegendCustomPosition_Load);
            ((ISupportInitialize)(Chart1)).EndInit();
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(numericUpDownHeight)).EndInit();
            ((ISupportInitialize)(numericUpDownWidth)).EndInit();
            ((ISupportInitialize)(numericUpDownY)).EndInit();
            ((ISupportInitialize)(numericUpDownX)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void LegendCustomPosition_Load(object sender, EventArgs e)
		{
			SetText();
		}

		private void SetText()
		{
			numericUpDownX.Value = (decimal)Chart1.Titles[0].Position.X;
			numericUpDownY.Value = (decimal)Chart1.Titles[0].Position.Y;
			numericUpDownWidth.Value = (decimal)Chart1.Titles[0].Position.Width;
			numericUpDownHeight.Value = (decimal)Chart1.Titles[0].Position.Height;
		}

		private void Chart1_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.X != 0 && e.Y != 0)
			{
				// Conver pixels to percentage coordinates and set legend position
				Chart1.Titles[0].Position.X = e.X * 100F / ((float)(Chart1.Size.Width - 1));
				Chart1.Titles[0].Position.Y = e.Y * 100F / ((float)(Chart1.Size.Height - 1)); 
	
				AdjustLegendControls();

				SetText();
			}
		}

		private void AdjustLegendControls()
		{
			// Restrict title position and size
			if(Chart1.Titles[0].Position.X > 70)
			{
				Chart1.Titles[0].Position.X = 70;
				Chart1.Titles[0].Position.Width = 30;
			}
				
			if(Chart1.Titles[0].Position.Y > 90)
			{
				Chart1.Titles[0].Position.Y = 90;
				Chart1.Titles[0].Position.Height = 10;
			}
		}

		private void numericUpDownX_ValueChanged(object sender, EventArgs e)
		{
			Chart1.Titles[0].Position.X = (float)numericUpDownX.Value;
			AdjustLegendControls();
		}

		private void numericUpDownY_ValueChanged(object sender, EventArgs e)
		{
			Chart1.Titles[0].Position.Y = (float)numericUpDownY.Value;
			AdjustLegendControls();
		}

		private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
		{
			Chart1.Titles[0].Position.Width = (float)numericUpDownWidth.Value;
			AdjustLegendControls();
		}

		private void numericUpDownHeight_ValueChanged(object sender, EventArgs e)
		{
			Chart1.Titles[0].Position.Height = (float)numericUpDownHeight.Value;
			AdjustLegendControls();
		}
	}
}
