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
	/// Summary description for PolarChartType.
	/// </summary>
	public class PolarChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private Label label2;
		private Label label3;
		private ComboBox comboBoxLabelStyle;
		private ComboBox comboBoxAreaStyle;
		private ComboBox comboBoxRadarStyle;
		private Label label5;
        private Label label4;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public PolarChartType()
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
			Title title1 = new Title();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(PolarChartType));
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            comboBoxLabelStyle = new ComboBox();
            label3 = new Label();
            comboBoxAreaStyle = new ComboBox();
            label2 = new Label();
            comboBoxRadarStyle = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
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
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.Size = 0.6F;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 78F;
            chartArea1.Position.Width = 88F;
            chartArea1.Position.X = 5F;
            chartArea1.Position.Y = 15F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 14.23021F;
            legend1.Position.Width = 19.34047F;
            legend1.Position.X = 74.73474F;
            legend1.Position.Y = 74.08253F;
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 64);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series1.Legend = "Default";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.MarkerColor = System.Drawing.Color.LightSkyBlue;
            series1.MarkerSize = 7;
            series1.Name = "Series1";
            series1.ShadowOffset = 1;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.BorderWidth = 3;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series2.Legend = "Default";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.MarkerColor = System.Drawing.Color.Gold;
            series2.MarkerSize = 7;
            series2.Name = "Series2";
            series2.ShadowOffset = 1;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 0;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Polar Chart";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 48);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample displays a polar chart, which is a circular graph on which data point" +
                "s are displayed using the angle and distance from the center point.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxLabelStyle);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxAreaStyle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxRadarStyle);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // comboBoxLabelStyle
            // 
            comboBoxLabelStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxLabelStyle.Items.AddRange([
            "Circular",
            "Radial",
            "Horizontal"]);
            comboBoxLabelStyle.Location = new Point(168, 72);
            comboBoxLabelStyle.Name = "comboBoxLabelStyle";
            comboBoxLabelStyle.Size = new Size(96, 22);
            comboBoxLabelStyle.TabIndex = 5;
            comboBoxLabelStyle.SelectedIndexChanged += new EventHandler(comboBoxExploded_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(11, 72);
            label3.Name = "label3";
            label3.Size = new Size(152, 23);
            label3.TabIndex = 4;
            label3.Text = "&Labels Style:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxAreaStyle
            // 
            comboBoxAreaStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxAreaStyle.Items.AddRange([
            "Circle",
            "Polygon"]);
            comboBoxAreaStyle.Location = new Point(168, 40);
            comboBoxAreaStyle.Name = "comboBoxAreaStyle";
            comboBoxAreaStyle.Size = new Size(96, 22);
            comboBoxAreaStyle.TabIndex = 3;
            comboBoxAreaStyle.SelectedIndexChanged += new EventHandler(comboBoxExploded_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(-2, 40);
            label2.Name = "label2";
            label2.Size = new Size(165, 23);
            label2.TabIndex = 2;
            label2.Text = "&Area Drawing Style:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxRadarStyle
            // 
            comboBoxRadarStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxRadarStyle.Items.AddRange([
            "Marker",
            "Line"]);
            comboBoxRadarStyle.Location = new Point(168, 8);
            comboBoxRadarStyle.Name = "comboBoxRadarStyle";
            comboBoxRadarStyle.Size = new Size(96, 22);
            comboBoxRadarStyle.TabIndex = 1;
            comboBoxRadarStyle.SelectedIndexChanged += new EventHandler(comboBoxExploded_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(35, 8);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 0;
            label1.Text = "&Polar Style:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label5.Font = new Font("Verdana", 11F);
            label5.Location = new Point(16, 368);
            label5.Name = "label5";
            label5.Size = new Size(696, 24);
            label5.TabIndex = 24;
            label5.Text = "Try different settings for the chart\'s polar, label, and area drawing styles.";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label4.Font = new Font("Verdana", 11F);
            label4.Location = new Point(16, 392);
            label4.Name = "label4";
            label4.Size = new Size(696, 88);
            label4.TabIndex = 25;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PolarChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PolarChartType";
            Size = new Size(728, 480);
            Load += new EventHandler(PieChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Set radar chart style
			chart1.Series["Series1"]["PolarDrawingStyle"] = (string)comboBoxRadarStyle.SelectedItem;
			chart1.Series["Series2"]["PolarDrawingStyle"] = (string)comboBoxRadarStyle.SelectedItem;
			if((string)comboBoxRadarStyle.SelectedItem == "Line")
			{
				chart1.Series["Series1"].BorderColor = Color.Empty;
				chart1.Series["Series1"].BorderWidth = 2;
				chart1.Series["Series2"].BorderColor = Color.Empty;
				chart1.Series["Series2"].BorderWidth = 2;
			}
			else if((string)comboBoxRadarStyle.SelectedItem == "Marker")
			{
				chart1.Series["Series1"].BorderColor = Color.Empty;
				chart1.Series["Series2"].BorderColor = Color.Empty;
			}

			// Set circular area drawing style
			chart1.Series["Series1"]["AreaDrawingStyle"] = (string)comboBoxAreaStyle.SelectedItem;
			chart1.Series["Series2"]["AreaDrawingStyle"] = (string)comboBoxAreaStyle.SelectedItem;

			// Set labels style
			chart1.Series["Series1"]["CircularLabelsStyle"] = (string)comboBoxLabelStyle.SelectedItem;
			chart1.Series["Series2"]["CircularLabelsStyle"] = (string)comboBoxLabelStyle.SelectedItem;

		}

		private void PieChartType_Load(object sender, EventArgs e)
		{
			// Fill series data
			for(double angle = 0.0; angle <= 360.0; angle += 10.0)
			{
				double yValue = (1.0 + Math.Sin(angle/180.0*Math.PI)) * 10.0;
				chart1.Series["Series1"].Points.AddXY(angle + 90.0, yValue);
				chart1.Series["Series2"].Points.AddXY(angle + 270.0, yValue);
			}

			// Set selection
			comboBoxRadarStyle.SelectedIndex = 0;
			comboBoxAreaStyle.SelectedIndex = 0;
			comboBoxLabelStyle.SelectedIndex = 2;

			UpdateChartSettings();	
		}

		private void comboBoxExploded_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

	}
}
