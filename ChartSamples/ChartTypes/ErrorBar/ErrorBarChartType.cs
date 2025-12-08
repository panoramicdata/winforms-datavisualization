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
	/// Summary description for ErrorBarChartType.
	/// </summary>
	public class ErrorBarChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private Label label2;
		private Label label3;
		private ComboBox comboBoxMarkersStyle;
		private ComboBox comboBoxErrorStyle;
		private ComboBox comboBoxCalculationStyle;
		private ComboBox comboBoxCenterMarkerStyle;
		private Label label4;
		private Label label5;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public ErrorBarChartType()
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
			Series series2 = new Series();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            comboBoxCenterMarkerStyle = new ComboBox();
            label4 = new Label();
            comboBoxMarkersStyle = new ComboBox();
            label3 = new Label();
            comboBoxErrorStyle = new ComboBox();
            label2 = new Label();
            comboBoxCalculationStyle = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
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
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
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
            chart1.Location = new Point(16, 56);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "DataSeries";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.MarkerSize = 6;
            series2.Name = "ErrorBar";
            series2.ShadowOffset = 1;
            series2.YValuesPerPoint = 3;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 40);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample shows how to use the Error Bar chart to display error bars for data s" +
                "eries using different error calculation methods. ";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxCenterMarkerStyle);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxMarkersStyle);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxErrorStyle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxCalculationStyle);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 288);
            panel1.TabIndex = 2;
            // 
            // comboBoxCenterMarkerStyle
            // 
            comboBoxCenterMarkerStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxCenterMarkerStyle.Items.AddRange([
            "None",
            "Line",
            "Square",
            "Circle",
            "Diamond",
            "Triangle",
            "Cross"]);
            comboBoxCenterMarkerStyle.Location = new Point(168, 104);
            comboBoxCenterMarkerStyle.Name = "comboBoxCenterMarkerStyle";
            comboBoxCenterMarkerStyle.Size = new Size(144, 22);
            comboBoxCenterMarkerStyle.TabIndex = 7;
            comboBoxCenterMarkerStyle.SelectedIndexChanged += new EventHandler(comboBoxCenterMarkerStyle_SelectedIndexChanged);
            // 
            // label4
            // 
            label4.Location = new Point(16, 104);
            label4.Name = "label4";
            label4.Size = new Size(144, 23);
            label4.TabIndex = 6;
            label4.Text = "&Center Marker Style:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMarkersStyle
            // 
            comboBoxMarkersStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxMarkersStyle.Items.AddRange([
            "None",
            "Line",
            "Square",
            "Circle",
            "Diamond",
            "Triangle",
            "Cross"]);
            comboBoxMarkersStyle.Location = new Point(168, 72);
            comboBoxMarkersStyle.Name = "comboBoxMarkersStyle";
            comboBoxMarkersStyle.Size = new Size(144, 22);
            comboBoxMarkersStyle.TabIndex = 5;
            comboBoxMarkersStyle.SelectedIndexChanged += new EventHandler(comboBoxMarkersStyle_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(24, 72);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 4;
            label3.Text = "&Markers Style:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxErrorStyle
            // 
            comboBoxErrorStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxErrorStyle.Items.AddRange([
            "Both",
            "UpperError",
            "LowerError"]);
            comboBoxErrorStyle.Location = new Point(168, 40);
            comboBoxErrorStyle.Name = "comboBoxErrorStyle";
            comboBoxErrorStyle.Size = new Size(144, 22);
            comboBoxErrorStyle.TabIndex = 3;
            comboBoxErrorStyle.SelectedIndexChanged += new EventHandler(comboBoxErrorStyle_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(32, 40);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 2;
            label2.Text = "Error &Style:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxCalculationStyle
            // 
            comboBoxCalculationStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxCalculationStyle.Items.AddRange([
            "StandardError",
            "StandardDeviation",
            "Percentage(15)",
            "FixedValue(10)"]);
            comboBoxCalculationStyle.Location = new Point(168, 8);
            comboBoxCalculationStyle.Name = "comboBoxCalculationStyle";
            comboBoxCalculationStyle.Size = new Size(144, 22);
            comboBoxCalculationStyle.TabIndex = 1;
            comboBoxCalculationStyle.SelectedIndexChanged += new EventHandler(comboBoxCalculationStyle_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(16, 8);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 0;
            label1.Text = "&Error Calculation:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label5.Font = new Font("Verdana", 11F);
            label5.Location = new Point(28, 352);
            label5.Name = "label5";
            label5.Size = new Size(696, 32);
            label5.TabIndex = 22;
            label5.Text = "Error bars are used to display statistical information about the chart data.";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ErrorBarChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "ErrorBarChartType";
            Size = new Size(752, 480);
            Load += new EventHandler(PieChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Set error calculation type
			chart1.Series["ErrorBar"]["ErrorBarType"] = (string)comboBoxCalculationStyle.SelectedItem;

			// Set error bar upper & lower error style
			chart1.Series["ErrorBar"]["ErrorBarStyle"] = (string)comboBoxErrorStyle.SelectedItem;

			// Set error bar center marker style
			chart1.Series["ErrorBar"]["ErrorBarCenterMarkerStyle"] = (string)comboBoxCenterMarkerStyle.SelectedItem;

			// Set error bar marker style
			string markerStyle = (string)comboBoxMarkersStyle.SelectedItem;
			chart1.Series["ErrorBar"]["PointWidth"] = "0.4";
			if(markerStyle == "Line")
			{
				chart1.Series["ErrorBar"].MarkerStyle = MarkerStyle.None;
			}
			else if(markerStyle == "None")
			{
				chart1.Series["ErrorBar"]["PointWidth"] = "0";
				chart1.Series["ErrorBar"].MarkerStyle = MarkerStyle.None;
			}
			else if(markerStyle != null)
			{
				chart1.Series["ErrorBar"].MarkerStyle = (MarkerStyle)Enum.Parse(typeof(MarkerStyle), markerStyle);
			}

		}

		private void PieChartType_Load(object sender, EventArgs e)
		{
			// Populate series with data
			double[]	yValues = [32.4, 56.9, 89.7, 80.5, 59.3, 33.8, 78.8, 44.6, 76.4, 68.9];
			chart1.Series["DataSeries"].Points.DataBindY(yValues);

			// Link error bar series with data series
			chart1.Series["ErrorBar"]["ErrorBarSeries"] = "DataSeries";

			// Set selection
			comboBoxCalculationStyle.SelectedIndex = 0;
			comboBoxErrorStyle.SelectedIndex = 0;
			comboBoxMarkersStyle.SelectedIndex = 1;
			comboBoxCenterMarkerStyle.SelectedIndex = 0;

			UpdateChartSettings();	
		}

		private void comboBoxCalculationStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxErrorStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxMarkersStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxCenterMarkerStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

	}
}
