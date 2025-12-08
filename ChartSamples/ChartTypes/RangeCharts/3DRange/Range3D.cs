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
	/// Summary description for Range3D.
	/// </summary>
	public class Range3D : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label2;
		private Label label1;
		private ComboBox comboBoxLineTension;
		private ComboBox comboBoxChartType;
		private CheckBox checkBoxShowMargin;
		private CheckBox ShowMarkerLines;
		private Label label3;
		private ComboBox LightingType;
        private CheckBox UsePerspective;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public Range3D()
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
            UsePerspective = new CheckBox();
            LightingType = new ComboBox();
            label3 = new Label();
            ShowMarkerLines = new CheckBox();
            checkBoxShowMargin = new CheckBox();
            comboBoxLineTension = new ComboBox();
            label2 = new Label();
            comboBoxChartType = new ComboBox();
            label1 = new Label();
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
            chartArea1.Area3DStyle.Inclination = 32;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = 29;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 96F;
            chartArea1.Position.Width = 99F;
            chartArea1.Position.Y = 2F;
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValuesPerPoint = 2;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 0);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 42);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates Range and Spline Range chart types. The Spline Range cha" +
                "rt supports line tension adjustment. ";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(UsePerspective);
            panel1.Controls.Add(LightingType);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ShowMarkerLines);
            panel1.Controls.Add(checkBoxShowMargin);
            panel1.Controls.Add(comboBoxLineTension);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxChartType);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 280);
            panel1.TabIndex = 2;
            // 
            // UsePerspective
            // 
            UsePerspective.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            UsePerspective.Location = new Point(-2, 168);
            UsePerspective.Name = "UsePerspective";
            UsePerspective.Size = new Size(184, 24);
            UsePerspective.TabIndex = 8;
            UsePerspective.Text = "Use 10% &Perspective:";
            UsePerspective.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            UsePerspective.CheckedChanged += new EventHandler(UsePerspective_CheckedChanged);
            // 
            // LightingType
            // 
            LightingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LightingType.Items.AddRange([
            "None",
            "Simplistic",
            "Realistic"]);
            LightingType.Location = new Point(168, 72);
            LightingType.Name = "LightingType";
            LightingType.Size = new Size(112, 22);
            LightingType.TabIndex = 5;
            LightingType.SelectedIndexChanged += new EventHandler(LightingType_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(28, 72);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 4;
            label3.Text = "L&ighting:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShowMarkerLines
            // 
            ShowMarkerLines.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            ShowMarkerLines.Location = new Point(-2, 136);
            ShowMarkerLines.Name = "ShowMarkerLines";
            ShowMarkerLines.Size = new Size(184, 24);
            ShowMarkerLines.TabIndex = 7;
            ShowMarkerLines.Text = "Show Marker &Lines:";
            ShowMarkerLines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            ShowMarkerLines.CheckedChanged += new EventHandler(ShowMarkerLines_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.Location = new Point(-2, 104);
            checkBoxShowMargin.Name = "checkBoxShowMargin";
            checkBoxShowMargin.Size = new Size(184, 24);
            checkBoxShowMargin.TabIndex = 6;
            checkBoxShowMargin.Text = "Show X Axis &Margin:";
            checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.CheckedChanged += new EventHandler(checkBoxShowMargin_CheckedChanged);
            // 
            // comboBoxLineTension
            // 
            comboBoxLineTension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxLineTension.Items.AddRange([
            "1.2",
            "0.8",
            "0.4",
            "0.2"]);
            comboBoxLineTension.Location = new Point(168, 40);
            comboBoxLineTension.Name = "comboBoxLineTension";
            comboBoxLineTension.Size = new Size(112, 22);
            comboBoxLineTension.TabIndex = 3;
            comboBoxLineTension.SelectedIndexChanged += new EventHandler(comboBoxLineTension_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(4, 40);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 2;
            label2.Text = "Spline &Tension:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxChartType
            // 
            comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxChartType.Items.AddRange([
            "Spline Range",
            "Range"]);
            comboBoxChartType.Location = new Point(168, 8);
            comboBoxChartType.Name = "comboBoxChartType";
            comboBoxChartType.Size = new Size(112, 22);
            comboBoxChartType.TabIndex = 1;
            comboBoxChartType.SelectedIndexChanged += new EventHandler(comboBoxLineTension_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(4, 8);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 0;
            label1.Text = "Chart &Type:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Range3D
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "Range3D";
            Size = new Size(728, 384);
            Load += new EventHandler(Range3D_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			if( comboBoxChartType.Text == "" )
			{
				return;
			}

			// Loop through all series
			foreach(Series series in chart1.Series)
			{
                // Set marker lines
				series["ShowMarkerLines"] = ShowMarkerLines.Checked.ToString();

                // Set chart type and line tension
				if(comboBoxChartType.Text == "Spline Range")
				{
                    series.ChartType = SeriesChartType.SplineRange;
                    comboBoxLineTension.Enabled = true;
					series["LineTension"] = comboBoxLineTension.Text;
				}
				else
				{
                    series.ChartType = SeriesChartType.Range;
                    comboBoxLineTension.Enabled = false;
					series.DeleteCustomProperty("LineTension");
				}
			}

			// Disable/enable X axis margin
			chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;

			// Set area lighting
			if(LightingType.Text != "")
				chart1.ChartAreas["Default"].Area3DStyle.LightStyle = (LightStyle)LightStyle.Parse(typeof(LightStyle), LightingType.Text);

			if(UsePerspective.Checked)
			{
				chart1.ChartAreas["Default"].Area3DStyle.Perspective = 10;
				chart1.ChartAreas["Default"].Area3DStyle.PointDepth = 200;
			}
			else
			{
				chart1.ChartAreas["Default"].Area3DStyle.Perspective = 0;
				chart1.ChartAreas["Default"].Area3DStyle.PointDepth = 100;
			}
		}

		private void Range3D_Load(object sender, EventArgs e)
		{
			// Populate series data with data
			double[]	yValue11 = [56, 74, 45, 59, 34, 87, 50, 87, 64, 34];
			double[]	yValue12 = [42, 65, 30, 42, 25, 47, 40, 70, 34, 20];
			chart1.Series["Default"].Points.DataBindY(yValue11, yValue12);

			double[]	yValue21 = [46, 64, 55, 69, 34, 57, 20, 67, 64, 34];
			double[]	yValue22 = [12, 45, 50, 12, 15, 27, 10, 40, 24, 30];
			chart1.Series["Series2"].Points.DataBindY(yValue21, yValue22);

			// Set selection
			comboBoxLineTension.SelectedIndex = 1;
			comboBoxChartType.SelectedIndex = 0;
			LightingType.SelectedIndex = 2;
		}

		private void comboBoxLineTension_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxShowMargin_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void ShowMarkerLines_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void LightingType_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void UsePerspective_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

	}
}
