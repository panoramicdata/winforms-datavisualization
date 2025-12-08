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
	/// Summary description for AreaChartType.
	/// </summary>
	public class AreaChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private RadioButton radioButtonArea;
		private RadioButton radioButtonSplineArea;
		private CheckBox checkBoxShowMargin;
		private CheckBox checkBoxShowMarkers;
		private ComboBox comboBoxTension;
		private CheckBox checkBoxShow3D;
		private CheckBox checkBoxTransparent;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AreaChartType()
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
            checkBoxTransparent = new CheckBox();
            checkBoxShow3D = new CheckBox();
            comboBoxTension = new ComboBox();
            label1 = new Label();
            checkBoxShowMarkers = new CheckBox();
            checkBoxShowMargin = new CheckBox();
            radioButtonSplineArea = new RadioButton();
            radioButtonArea = new RadioButton();
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
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
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
            chart1.Location = new Point(16, 48);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.LabelFormat = "C";
            series1.Legend = "Default";
            series1.Name = "Default";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.LabelFormat = "C";
            series2.Legend = "Default";
            series2.Name = "Series2";
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
            labelSampleComment.Size = new Size(702, 34);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates Area and Spline Area charts.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelSampleComment.Click += new EventHandler(labelSampleComment_Click);
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxTransparent);
            panel1.Controls.Add(checkBoxShow3D);
            panel1.Controls.Add(comboBoxTension);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkBoxShowMarkers);
            panel1.Controls.Add(checkBoxShowMargin);
            panel1.Controls.Add(radioButtonSplineArea);
            panel1.Controls.Add(radioButtonArea);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // checkBoxTransparent
            // 
            checkBoxTransparent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxTransparent.Location = new Point(19, 168);
            checkBoxTransparent.Name = "checkBoxTransparent";
            checkBoxTransparent.Size = new Size(216, 24);
            checkBoxTransparent.TabIndex = 6;
            checkBoxTransparent.Text = "Semi-&Transparent Colors:";
            checkBoxTransparent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxTransparent.CheckedChanged += new EventHandler(checkBoxTransparent_CheckedChanged);
            // 
            // checkBoxShow3D
            // 
            checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.Location = new Point(51, 200);
            checkBoxShow3D.Name = "checkBoxShow3D";
            checkBoxShow3D.Size = new Size(184, 24);
            checkBoxShow3D.TabIndex = 7;
            checkBoxShow3D.Text = "Display chart as 3&D:";
            checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.CheckedChanged += new EventHandler(checkBoxShow3D_CheckedChanged);
            // 
            // comboBoxTension
            // 
            comboBoxTension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxTension.Items.AddRange([
            "1.2",
            "0.8",
            "0.4",
            "0.2"]);
            comboBoxTension.Location = new Point(222, 70);
            comboBoxTension.Name = "comboBoxTension";
            comboBoxTension.Size = new Size(64, 22);
            comboBoxTension.TabIndex = 3;
            comboBoxTension.SelectedIndexChanged += new EventHandler(comboBoxTension_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(105, 70);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 2;
            label1.Text = "Spline &Tension:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxShowMarkers
            // 
            checkBoxShowMarkers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMarkers.Location = new Point(3, 104);
            checkBoxShowMarkers.Name = "checkBoxShowMarkers";
            checkBoxShowMarkers.Size = new Size(232, 24);
            checkBoxShowMarkers.TabIndex = 4;
            checkBoxShowMarkers.Text = "Show Point &Markers and Labels:";
            checkBoxShowMarkers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMarkers.CheckedChanged += new EventHandler(checkBoxShowMarkers_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.Location = new Point(3, 136);
            checkBoxShowMargin.Name = "checkBoxShowMargin";
            checkBoxShowMargin.Size = new Size(232, 24);
            checkBoxShowMargin.TabIndex = 5;
            checkBoxShowMargin.Text = "Show X Axis M&argin:";
            checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.CheckedChanged += new EventHandler(checkBoxShowMargin_CheckedChanged);
            // 
            // radioButtonSplineArea
            // 
            radioButtonSplineArea.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonSplineArea.Location = new Point(48, 37);
            radioButtonSplineArea.Name = "radioButtonSplineArea";
            radioButtonSplineArea.Size = new Size(184, 24);
            radioButtonSplineArea.TabIndex = 1;
            radioButtonSplineArea.Text = "&Spline Area Chart:";
            radioButtonSplineArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonSplineArea.CheckedChanged += new EventHandler(radioButtonSplineArea_CheckedChanged);
            // 
            // radioButtonArea
            // 
            radioButtonArea.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonArea.Checked = true;
            radioButtonArea.Location = new Point(88, 8);
            radioButtonArea.Name = "radioButtonArea";
            radioButtonArea.Size = new Size(144, 24);
            radioButtonArea.TabIndex = 0;
            radioButtonArea.TabStop = true;
            radioButtonArea.Text = "&Area Chart:";
            radioButtonArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            radioButtonArea.CheckedChanged += new EventHandler(radioButtonArea_CheckedChanged);
            // 
            // AreaChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AreaChartType";
            Size = new Size(728, 480);
            Load += new EventHandler(AreaChartType_Load);
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
				chart1.Series["Default"].ChartType = SeriesChartType.Area;
				chart1.Series["Series2"].ChartType = SeriesChartType.Area;
				chart1.Series["Default"].DeleteCustomProperty("LineTension");
				chart1.Series["Series2"].DeleteCustomProperty("LineTension");
				comboBoxTension.Enabled = false;
			}
			else
			{
				// Set chart type to SplineArea and set line tension
				comboBoxTension.Enabled = true;
				chart1.Series["Default"].ChartType = SeriesChartType.SplineArea;
				chart1.Series["Default"]["LineTension"] = comboBoxTension.Text;
				chart1.Series["Series2"].ChartType = SeriesChartType.SplineArea;
				chart1.Series["Series2"]["LineTension"] = comboBoxTension.Text;
			}

			
			
			// Show solid or transparent color
			if(checkBoxTransparent.Checked==true)
			{
				chart1.Series["Default"].Color = Color.FromArgb(220, 65, 140, 240);
				chart1.Series["Series2"].Color = Color.FromArgb(220, 252, 180, 65);
			}
			else
			{
				if(checkBoxShow3D.Checked)
				{
					chart1.Series["Default"].Color = Color.FromArgb(255, 65, 140, 240);
					chart1.Series["Series2"].Color = Color.FromArgb(255, 252, 180, 65);
				}
				else
				{
					chart1.Series["Default"].Color = Color.FromArgb(255, 65, 140, 240);
					chart1.Series["Series2"].Color = Color.FromArgb(255, 252, 180, 65);
				}
			}
			
			// Enable points labels and markers
			if(checkBoxShowMarkers.Checked)
			{
				chart1.Series["Default"].IsValueShownAsLabel = true;
				chart1.Series["Default"].MarkerStyle = MarkerStyle.Circle;
				chart1.Series["Default"].MarkerColor = Color.Gold;
				chart1.Series["Series2"].IsValueShownAsLabel = true;
				chart1.Series["Series2"].MarkerStyle = MarkerStyle.Circle;
				chart1.Series["Series2"].MarkerColor = Color.Gold;
			}
			else
			{
				chart1.Series["Default"].IsValueShownAsLabel = false;
				chart1.Series["Default"].MarkerStyle = MarkerStyle.None;
				chart1.Series["Default"].MarkerColor = Color.Gold;
				chart1.Series["Series2"].IsValueShownAsLabel = false;
				chart1.Series["Series2"].MarkerStyle = MarkerStyle.None;
				chart1.Series["Series2"].MarkerColor = Color.Gold;
			}

			// Disable/enable X axis margin
			chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;

			// Show 3D or 2D charts
			if(checkBoxShow3D.Checked==true)
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
				chart1.Series["Default"].IsValueShownAsLabel = false;
				chart1.Series["Series2"].IsValueShownAsLabel = false;
				chart1.Series["Default"].MarkerStyle = MarkerStyle.None;
				chart1.Series["Series2"].MarkerStyle = MarkerStyle.None;
			}
			else
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;
			}

			if(checkBoxShowMarkers.Checked)
			{
				chart1.Series["Default"].IsValueShownAsLabel = true;
				chart1.Series["Series2"].IsValueShownAsLabel = true;
				chart1.Series["Default"].MarkerStyle = MarkerStyle.Circle;
				chart1.Series["Series2"].MarkerStyle = MarkerStyle.Circle;
			}

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

		private void AreaChartType_Load(object sender, EventArgs e)
		{
			comboBoxTension.SelectedIndex = 1;
			checkBoxTransparent.Checked = true;
			// Add data
			chart1.Series["Default"].Points.AddY(8.1);
			chart1.Series["Default"].Points.AddY(7.6);
			chart1.Series["Default"].Points.AddY(9.5);
			chart1.Series["Default"].Points.AddY(8.5);
			chart1.Series["Default"].Points.AddY(9.0);
			chart1.Series["Default"].Points.AddY(8.0);

			chart1.Series["Series2"].Points.AddY(2.3);
			chart1.Series["Series2"].Points.AddY(4.2);
			chart1.Series["Series2"].Points.AddY(3.6);
			chart1.Series["Series2"].Points.AddY(2.3);
			chart1.Series["Series2"].Points.AddY(1.6);
			chart1.Series["Series2"].Points.AddY(2.9);
		}

		private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxTransparent_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void labelSampleComment_Click(object sender, EventArgs e)
		{
		
		}


	}
}
