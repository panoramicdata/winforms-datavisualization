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
	/// Summary description for AxisVarLabelsInterval.
	/// </summary>
	public class AxisVarLabelsInterval : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label15;
		private CheckBox checkBox1;
		private Chart chart2;
		private ComboBox XAxisFormat;
		private Label label1;
		private Label label2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AxisVarLabelsInterval()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();	
	
			XAxisFormat.SelectedIndex = 0;
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
			DataPoint dataPoint1 = new DataPoint(38859, 1627.000244140625);
			DataPoint dataPoint2 = new DataPoint(38872, 1597.524658203125);
			DataPoint dataPoint3 = new DataPoint(38885, 1573.083740234375);
			DataPoint dataPoint4 = new DataPoint(38900, 1565.8377685546875);
			DataPoint dataPoint5 = new DataPoint(38914, 1602.314453125);
			DataPoint dataPoint6 = new DataPoint(38937, 1642.5465087890625);
			DataPoint dataPoint7 = new DataPoint(38952, 1672.42822265625);
			DataPoint dataPoint8 = new DataPoint(38955, 1648.5418701171875);
			DataPoint dataPoint9 = new DataPoint(38972, 1621.2138671875);
			DataPoint dataPoint10 = new DataPoint(38999, 1572.0396728515625);
			DataPoint dataPoint11 = new DataPoint(39013, 1578.5050048828125);
			DataPoint dataPoint12 = new DataPoint(39023, 1558.218017578125);
			DataPoint dataPoint13 = new DataPoint(39028, 1573.986083984375);
			DataPoint dataPoint14 = new DataPoint(39040, 1576.890869140625);
			DataPoint dataPoint15 = new DataPoint(39066, 1529.220458984375);
			DataPoint dataPoint16 = new DataPoint(39086, 1564.6845703125);
			DataPoint dataPoint17 = new DataPoint(39107, 1578.4237060546875);
			DataPoint dataPoint18 = new DataPoint(39126, 1576.835205078125);
			DataPoint dataPoint19 = new DataPoint(39148, 1596.8394775390625);
			DataPoint dataPoint20 = new DataPoint(39164, 1597.822509765625);
			DataPoint dataPoint21 = new DataPoint(39189, 1609.9180908203125);
			DataPoint dataPoint22 = new DataPoint(39210, 1621.64306640625);
			DataPoint dataPoint23 = new DataPoint(39225, 1652.377197265625);
			DataPoint dataPoint24 = new DataPoint(39239, 1642.6414794921875);
			DataPoint dataPoint25 = new DataPoint(39265, 1657.52587890625);
			DataPoint dataPoint26 = new DataPoint(39280, 1696.0537109375);
			DataPoint dataPoint27 = new DataPoint(39295, 1738.0972900390625);
			DataPoint dataPoint28 = new DataPoint(39301, 1702.7032470703125);
			DataPoint dataPoint29 = new DataPoint(39302, 1667.0447998046875);
			DataPoint dataPoint30 = new DataPoint(39304, 1694.8780517578125);
			DataPoint dataPoint31 = new DataPoint(39330, 1740.7620849609375);
			DataPoint dataPoint32 = new DataPoint(39346, 1734.49072265625);
			DataPoint dataPoint33 = new DataPoint(39352, 1778.2821044921875);
			DataPoint dataPoint34 = new DataPoint(39359, 1815.655029296875);
			DataPoint dataPoint35 = new DataPoint(39364, 1824.577392578125);
			DataPoint dataPoint36 = new DataPoint(39380, 1860.8177490234375);
			DataPoint dataPoint37 = new DataPoint(39400, 1852.8516845703125);
			DataPoint dataPoint38 = new DataPoint(39406, 1888.8582763671875);
			DataPoint dataPoint39 = new DataPoint(39432, 1908.6798095703125);
			DataPoint dataPoint40 = new DataPoint(39456, 1891.787841796875);
			DataPoint dataPoint41 = new DataPoint(39463, 1940.2855224609375);
			DataPoint dataPoint42 = new DataPoint(39483, 1913.6676025390625);
			DataPoint dataPoint43 = new DataPoint(39498, 1943.043701171875);
			DataPoint dataPoint44 = new DataPoint(39509, 1970.134033203125);
			DataPoint dataPoint45 = new DataPoint(39522, 1970.98876953125);
			DataPoint dataPoint46 = new DataPoint(39536, 1979.9300537109375);
			DataPoint dataPoint47 = new DataPoint(39555, 2006.0057373046875);
			DataPoint dataPoint48 = new DataPoint(39574, 2043.123779296875);
			ComponentResourceManager resources = new ComponentResourceManager(typeof(AxisVarLabelsInterval));
            label9 = new Label();
            panel1 = new Panel();
            XAxisFormat = new ComboBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label15 = new Label();
            chart2 = new Chart();
            label2 = new Label();
            panel1.SuspendLayout();
            ((ISupportInitialize)(chart2)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to set variable label intervals.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(XAxisFormat);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(440, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 296);
            panel1.TabIndex = 2;
            // 
            // XAxisFormat
            // 
            XAxisFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            XAxisFormat.Items.AddRange([
            "Short Date",
            "Full Date",
            "Week Day"]);
            XAxisFormat.Location = new Point(168, 48);
            XAxisFormat.Name = "XAxisFormat";
            XAxisFormat.Size = new Size(102, 22);
            XAxisFormat.TabIndex = 15;
            XAxisFormat.SelectedIndexChanged += new EventHandler(XAxisFormat_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(24, 52);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 14;
            label1.Text = "&X Axis Labels Format:";
            // 
            // checkBox1
            // 
            checkBox1.Checked = true;
            checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox1.Location = new Point(8, 16);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            checkBox1.Size = new Size(176, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Variable Label Intervals";
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            // 
            // label6
            // 
            label6.Location = new Point(64, 403);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 10;
            label6.Text = "Border Size:";
            // 
            // label5
            // 
            label5.Location = new Point(64, 380);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 9;
            label5.Text = "Border Color:";
            // 
            // label4
            // 
            label4.Location = new Point(64, 357);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 8;
            label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            label3.Location = new Point(64, 334);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 7;
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
            // chart2
            // 
            chart2.BackColor = System.Drawing.Color.WhiteSmoke;
            chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart2.BackSecondaryColor = System.Drawing.Color.White;
            chart2.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart2.BorderlineWidth = 2;
            chart2.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F);
            chartArea1.AxisX.LabelStyle.Format = "ddd,d";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart2.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(16, 60);
            chart2.Name = "chart2";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DrawingStyle=Emboss, PointWidth=0.9";
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.Points.Add(dataPoint10);
            series1.Points.Add(dataPoint11);
            series1.Points.Add(dataPoint12);
            series1.Points.Add(dataPoint13);
            series1.Points.Add(dataPoint14);
            series1.Points.Add(dataPoint15);
            series1.Points.Add(dataPoint16);
            series1.Points.Add(dataPoint17);
            series1.Points.Add(dataPoint18);
            series1.Points.Add(dataPoint19);
            series1.Points.Add(dataPoint20);
            series1.Points.Add(dataPoint21);
            series1.Points.Add(dataPoint22);
            series1.Points.Add(dataPoint23);
            series1.Points.Add(dataPoint24);
            series1.Points.Add(dataPoint25);
            series1.Points.Add(dataPoint26);
            series1.Points.Add(dataPoint27);
            series1.Points.Add(dataPoint28);
            series1.Points.Add(dataPoint29);
            series1.Points.Add(dataPoint30);
            series1.Points.Add(dataPoint31);
            series1.Points.Add(dataPoint32);
            series1.Points.Add(dataPoint33);
            series1.Points.Add(dataPoint34);
            series1.Points.Add(dataPoint35);
            series1.Points.Add(dataPoint36);
            series1.Points.Add(dataPoint37);
            series1.Points.Add(dataPoint38);
            series1.Points.Add(dataPoint39);
            series1.Points.Add(dataPoint40);
            series1.Points.Add(dataPoint41);
            series1.Points.Add(dataPoint42);
            series1.Points.Add(dataPoint43);
            series1.Points.Add(dataPoint44);
            series1.Points.Add(dataPoint45);
            series1.Points.Add(dataPoint46);
            series1.Points.Add(dataPoint47);
            series1.Points.Add(dataPoint48);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart2.Series.Add(series1);
            chart2.Size = new Size(412, 296);
            chart2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label2.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(16, 368);
            label2.Name = "label2";
            label2.Size = new Size(702, 64);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AxisVarLabelsInterval
            // 
            Controls.Add(label2);
            Controls.Add(chart2);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AxisVarLabelsInterval";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(chart2)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			// variable intervals
			if (checkBox1.Checked) 
                chart2.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
			
			else 
				chart2.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;

		}

		private void XAxisFormat_SelectedIndexChanged(object sender, EventArgs e)
		{
			chart2.ChartAreas["Default"].AxisX.LabelStyle.Format = GetDateItem(XAxisFormat.SelectedIndex);		
		}

		private string GetDateItem( int item )
		{
			string format;
			switch( item )
			{
				case 0:
					format = "d";
					break;
				case 1:
					format = "D";
					break;									
				case 2:
					format = "ddd,d";
					break;
				default: 
					format = "";
					break;
			}

			return format;
		}
		
	}
}
