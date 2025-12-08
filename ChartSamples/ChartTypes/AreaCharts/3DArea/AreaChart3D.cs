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
	/// Summary description for AreaChart3D.
	/// </summary>
	public class AreaChart3D : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private RadioButton radioButtonArea;
		private RadioButton radioButtonSplineArea;
		private CheckBox checkBoxShowMargin;
		private ComboBox comboBoxTension;
		private CheckBox ShowMarkerLines;
		private ComboBox LightingType;
		private Label label3;
		private Timer timer1;
		private IContainer components;

		public AreaChart3D()
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
            components = new Container();
			ChartArea chartArea1 = new ChartArea();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(0, "5,0");
			DataPoint dataPoint2 = new DataPoint(0, "8.10000038146973,0");
			DataPoint dataPoint3 = new DataPoint(0, "9,0");
			DataPoint dataPoint4 = new DataPoint(0, "7,0");
			DataPoint dataPoint5 = new DataPoint(0, "5,0");
			DataPoint dataPoint6 = new DataPoint(0, "5.5,0");
			DataPoint dataPoint7 = new DataPoint(0, "7.80000019073486,0");
			DataPoint dataPoint8 = new DataPoint(0, "7,0");
			DataPoint dataPoint9 = new DataPoint(0, "8.5,0");
			Series series2 = new Series();
			DataPoint dataPoint10 = new DataPoint(0, 5);
			DataPoint dataPoint11 = new DataPoint(0, 4);
			DataPoint dataPoint12 = new DataPoint(0, 5);
			DataPoint dataPoint13 = new DataPoint(0, 3.5);
			DataPoint dataPoint14 = new DataPoint(0, 4);
			DataPoint dataPoint15 = new DataPoint(0, 5.5);
			DataPoint dataPoint16 = new DataPoint(0, 6);
			DataPoint dataPoint17 = new DataPoint(0, 3);
			DataPoint dataPoint18 = new DataPoint(0, 2);
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            LightingType = new ComboBox();
            label3 = new Label();
            ShowMarkerLines = new CheckBox();
            comboBoxTension = new ComboBox();
            label1 = new Label();
            checkBoxShowMargin = new CheckBox();
            radioButtonSplineArea = new RadioButton();
            radioButtonArea = new RadioButton();
            timer1 = new Timer(components);
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
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
            chartArea1.Area3DStyle.Perspective = 10;
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
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 57);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "ShowMarkerLines=true";
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
            series1.YValuesPerPoint = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "ShowMarkerLines=true";
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
            labelSampleComment.Size = new Size(702, 45);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates 3D Area and Spline Area charts. The X axis margin and da" +
                "ta point marker lines can be toggled on and off, and the lighting can also be mo" +
                "dified.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelSampleComment.Click += new EventHandler(labelSampleComment_Click);
            // 
            // panel1
            // 
            panel1.Controls.Add(LightingType);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ShowMarkerLines);
            panel1.Controls.Add(comboBoxTension);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkBoxShowMargin);
            panel1.Controls.Add(radioButtonSplineArea);
            panel1.Controls.Add(radioButtonArea);
            panel1.Location = new Point(432, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // LightingType
            // 
            LightingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LightingType.Items.AddRange([
            "None",
            "Simplistic",
            "Realistic"]);
            LightingType.Location = new Point(168, 112);
            LightingType.Name = "LightingType";
            LightingType.Size = new Size(80, 22);
            LightingType.TabIndex = 5;
            LightingType.SelectedIndexChanged += new EventHandler(LightingType_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(61, 112);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 4;
            label3.Text = "&Lighting:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShowMarkerLines
            // 
            ShowMarkerLines.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            ShowMarkerLines.Location = new Point(14, 176);
            ShowMarkerLines.Name = "ShowMarkerLines";
            ShowMarkerLines.Size = new Size(168, 24);
            ShowMarkerLines.TabIndex = 7;
            ShowMarkerLines.Text = "Show Marker &Lines:";
            ShowMarkerLines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            ShowMarkerLines.CheckedChanged += new EventHandler(ShowMarkerLines_CheckedChanged);
            // 
            // comboBoxTension
            // 
            comboBoxTension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxTension.Items.AddRange([
            "1.2",
            "0.8",
            "0.4",
            "0.2"]);
            comboBoxTension.Location = new Point(168, 80);
            comboBoxTension.Name = "comboBoxTension";
            comboBoxTension.Size = new Size(80, 22);
            comboBoxTension.TabIndex = 3;
            comboBoxTension.SelectedIndexChanged += new EventHandler(comboBoxTension_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(29, 80);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 2;
            label1.Text = "Spline &Tension:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label1.Click += new EventHandler(label1_Click);
            // 
            // checkBoxShowMargin
            // 
            checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.Location = new Point(-2, 144);
            checkBoxShowMargin.Name = "checkBoxShowMargin";
            checkBoxShowMargin.Size = new Size(184, 24);
            checkBoxShowMargin.TabIndex = 6;
            checkBoxShowMargin.Text = "Show X Axis &Margin:";
            checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.CheckedChanged += new EventHandler(checkBoxShowMargin_CheckedChanged);
            // 
            // radioButtonSplineArea
            // 
            radioButtonSplineArea.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonSplineArea.Location = new Point(36, 45);
            radioButtonSplineArea.Name = "radioButtonSplineArea";
            radioButtonSplineArea.Size = new Size(144, 24);
            radioButtonSplineArea.TabIndex = 1;
            radioButtonSplineArea.Text = "&Spline Area:";
            radioButtonSplineArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonSplineArea.CheckedChanged += new EventHandler(radioButtonSplineArea_CheckedChanged);
            // 
            // radioButtonArea
            // 
            radioButtonArea.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonArea.Checked = true;
            radioButtonArea.Location = new Point(36, 16);
            radioButtonArea.Name = "radioButtonArea";
            radioButtonArea.Size = new Size(144, 24);
            radioButtonArea.TabIndex = 0;
            radioButtonArea.TabStop = true;
            radioButtonArea.Text = "&Area:";
            radioButtonArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonArea.CheckedChanged += new EventHandler(radioButtonArea_CheckedChanged);
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
            // 
            // AreaChart3D
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AreaChart3D";
            Size = new Size(728, 480);
            Load += new EventHandler(AreaChart3D_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			if(radioButtonArea.Checked)
			{
				// Set chart type to Area
				chart1.Series["Series1"].ChartType = SeriesChartType.Area;
				chart1.Series["Series2"].ChartType = SeriesChartType.Area;
				chart1.Series["Series1"].DeleteCustomProperty("LineTension");
				chart1.Series["Series2"].DeleteCustomProperty("LineTension");
				comboBoxTension.Enabled = false;
			}
			else
			{
				// Set chart type to SplineArea and set line tension
				comboBoxTension.Enabled = true;
				chart1.Series["Series1"].ChartType = SeriesChartType.SplineArea;
				chart1.Series["Series1"]["LineTension"] = comboBoxTension.Text;
				chart1.Series["Series2"].ChartType = SeriesChartType.SplineArea;
				chart1.Series["Series2"]["LineTension"] = comboBoxTension.Text;
			}

			// Disable/enable X axis margin
			chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;
			chart1.Series["Series1"]["ShowMarkerLines"] = ShowMarkerLines.Checked.ToString();
			chart1.Series["Series2"]["ShowMarkerLines"] = ShowMarkerLines.Checked.ToString();

			// Set area lighting
			if(LightingType.Text != "")
				chart1.ChartAreas["Default"].Area3DStyle.LightStyle = (LightStyle)LightStyle.Parse(typeof(LightStyle), LightingType.Text);
		}

		private void radioButtonArea_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void radioButtonSplineArea_CheckedChanged(object sender, EventArgs e)
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

		private void AreaChart3D_Load(object sender, EventArgs e)
		{
			comboBoxTension.SelectedIndex = 1;
			LightingType.SelectedIndex = 2;
		}

		private void ShowMarkerLines_CheckedChanged(object sender, EventArgs e)
		{
			chart1.Series["Series1"]["ShowMarkerLines"] = ShowMarkerLines.Checked.ToString();
			chart1.Series["Series2"]["ShowMarkerLines"] = ShowMarkerLines.Checked.ToString();
		}

		private void LightingType_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if(chart1.ChartAreas[0].Area3DStyle.Rotation <= 177)
				chart1.ChartAreas[0].Area3DStyle.Rotation += 3;
			else
				chart1.ChartAreas[0].Area3DStyle.Rotation = -180;
		}

		private void label1_Click(object sender, EventArgs e)
		{
		
		}

        private void labelSampleComment_Click(object sender, EventArgs e)
        {

        }


	}
}
