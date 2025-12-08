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
	/// Summary description for UsingToolTips.
	/// </summary>
	public class UsingToolTips : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label15;
		private Label label2;
		private Label label7;
		private TextBox SeriesToolTip;
		private TextBox LegendToolTip;
		private Label label1;
		private TextBox PointLabelToolTip;
		private Label label8;
        private TextBox PointToolTip;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public UsingToolTips()
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
			DataPoint dataPoint1 = new DataPoint(0, 5);
			DataPoint dataPoint2 = new DataPoint(0, 8);
			DataPoint dataPoint3 = new DataPoint(0, 9);
			DataPoint dataPoint4 = new DataPoint(0, 12);
			DataPoint dataPoint5 = new DataPoint(0, 14);
			DataPoint dataPoint6 = new DataPoint(0, 12);
			DataPoint dataPoint7 = new DataPoint(0, 17);
			DataPoint dataPoint8 = new DataPoint(0, 14);
			DataPoint dataPoint9 = new DataPoint(0, 18);
            label9 = new Label();
            panel1 = new Panel();
            PointToolTip = new TextBox();
            label8 = new Label();
            PointLabelToolTip = new TextBox();
            label1 = new Label();
            LegendToolTip = new TextBox();
            SeriesToolTip = new TextBox();
            label7 = new Label();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label15 = new Label();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label9.Font = new Font("Verdana", 11F);
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to use tooltips. To see a tooltip, place the cursor " +
                "over a pie slice or legend item.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(PointToolTip);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(PointLabelToolTip);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LegendToolTip);
            panel1.Controls.Add(SeriesToolTip);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(432, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 19;
            // 
            // PointToolTip
            // 
            PointToolTip.Location = new Point(48, 200);
            PointToolTip.Name = "PointToolTip";
            PointToolTip.Size = new Size(216, 22);
            PointToolTip.TabIndex = 12;
            PointToolTip.Text = "Unknown";
            PointToolTip.TextChanged += new EventHandler(textBox1_TextChanged);
            // 
            // label8
            // 
            label8.Location = new Point(48, 176);
            label8.Name = "label8";
            label8.Size = new Size(232, 23);
            label8.TabIndex = 13;
            label8.Text = "Second Data Point Tooltip (&China):";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PointLabelToolTip
            // 
            PointLabelToolTip.Location = new Point(48, 144);
            PointLabelToolTip.Name = "PointLabelToolTip";
            PointLabelToolTip.Size = new Size(216, 22);
            PointLabelToolTip.TabIndex = 2;
            PointLabelToolTip.Text = "#PERCENT";
            PointLabelToolTip.TextChanged += new EventHandler(ToolTip_TextChanged);
            // 
            // label1
            // 
            label1.Location = new Point(48, 120);
            label1.Name = "label1";
            label1.Size = new Size(192, 23);
            label1.TabIndex = 11;
            label1.Text = "&Data Point Labels Tooltip:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LegendToolTip
            // 
            LegendToolTip.Location = new Point(48, 88);
            LegendToolTip.Name = "LegendToolTip";
            LegendToolTip.Size = new Size(216, 22);
            LegendToolTip.TabIndex = 1;
            LegendToolTip.Text = "Income in #LABEL  is #VAL million";
            LegendToolTip.TextChanged += new EventHandler(ToolTip_TextChanged);
            // 
            // SeriesToolTip
            // 
            SeriesToolTip.Location = new Point(48, 32);
            SeriesToolTip.Name = "SeriesToolTip";
            SeriesToolTip.Size = new Size(216, 22);
            SeriesToolTip.TabIndex = 0;
            SeriesToolTip.Text = "Percent: #PERCENT";
            SeriesToolTip.TextChanged += new EventHandler(ToolTip_TextChanged);
            // 
            // label7
            // 
            label7.Location = new Point(48, 64);
            label7.Name = "label7";
            label7.Size = new Size(208, 23);
            label7.TabIndex = 8;
            label7.Text = "&Legend ToolTip Text Or Format:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(48, 8);
            label2.Name = "label2";
            label2.Size = new Size(216, 23);
            label2.TabIndex = 7;
            label2.Text = "&Series ToolTip Text Or Format:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new Point(64, 403);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 5;
            label6.Text = "Border Size:";
            // 
            // label5
            // 
            label5.Location = new Point(64, 380);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 4;
            label5.Text = "Border Color:";
            // 
            // label4
            // 
            label4.Location = new Point(64, 357);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            label3.Location = new Point(64, 334);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
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
            // Chart1
            // 
            Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            Chart1.BorderlineWidth = 2;
            Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 38;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 9;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 60);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "PieStartAngle=120, PieDrawingStyle=Concave";
            series1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Default";
            series1.Name = "Series1";
            dataPoint1.AxisLabel = "Japan";
            dataPoint1.Label = "Japan";
            dataPoint2.Label = "China";
            dataPoint3.Label = "Russia";
            dataPoint4.Label = "USA";
            dataPoint5.Label = "Germany";
            dataPoint6.Label = "Italy";
            dataPoint7.Label = "Sweden";
            dataPoint8.Label = "Spain";
            dataPoint9.Label = "France";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.ToolTip = "#VALX: #VAL{C} million";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 0;
            Chart1.Click += new EventHandler(Chart1_Click);
            // 
            // UsingToolTips
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F);
            Name = "UsingToolTips";
            Size = new Size(728, 480);
            Load += new EventHandler(UsingToolTips_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void Chart1_Click(object sender, EventArgs e)
		{
		
		}

		/// <summary>
		/// This method sets tooltips for chart elements
		/// </summary>
		private void ToolTipChanghed()
		{
			// Set ToolTips for Data Point Series
			Chart1.Series[0].ToolTip = SeriesToolTip.Text;

			// Set ToolTips for legend items
			Chart1.Series[0].LegendToolTip = LegendToolTip.Text;

			// Set ToolTips for the Data Point labels
			Chart1.Series[0].LabelToolTip = PointLabelToolTip.Text;

			// Set ToolTips for second Data Point
			Chart1.Series[0].Points[1].ToolTip = PointToolTip.Text;
		}

		private void UsingToolTips_Load(object sender, EventArgs e)
		{
			// Set ToolTips
			ToolTipChanghed();
		}

		private void ToolTip_TextChanged(object sender, EventArgs e)
		{
			// Set ToolTips
			ToolTipChanghed();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			// Set ToolTips
			ToolTipChanghed();
		}
		
	}
}
