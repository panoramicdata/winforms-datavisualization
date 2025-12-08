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
	/// Summary description for LineCurves3D.
	/// </summary>
	public class LineCurves3D : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxChartType;
		private Label label2;
		private ComboBox comboBoxPointLabels;
		private CheckBox checkBoxShowMargin;
		private CheckBox ShowMarkerLines;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public LineCurves3D()
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
			Series series3 = new Series();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            ShowMarkerLines = new CheckBox();
            checkBoxShowMargin = new CheckBox();
            comboBoxPointLabels = new ComboBox();
            label2 = new Label();
            comboBoxChartType = new ComboBox();
            label1 = new Label();
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
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 38;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.PointDepth = 200;
            chartArea1.Area3DStyle.Rotation = 9;
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
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 2F;
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F);
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 37);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates Line, Spline and StepLine chart types with 3D enabled. T" +
                "he label style and the display of data point marker lines can be set using custo" +
                "m attributes.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(ShowMarkerLines);
            panel1.Controls.Add(checkBoxShowMargin);
            panel1.Controls.Add(comboBoxPointLabels);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxChartType);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // ShowMarkerLines
            // 
            ShowMarkerLines.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            ShowMarkerLines.Location = new Point(14, 104);
            ShowMarkerLines.Name = "ShowMarkerLines";
            ShowMarkerLines.Size = new Size(168, 24);
            ShowMarkerLines.TabIndex = 5;
            ShowMarkerLines.Text = "Show Marker &Lines:";
            ShowMarkerLines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            ShowMarkerLines.CheckedChanged += new EventHandler(ShowMarkerLines_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.Location = new Point(14, 72);
            checkBoxShowMargin.Name = "checkBoxShowMargin";
            checkBoxShowMargin.Size = new Size(168, 24);
            checkBoxShowMargin.TabIndex = 4;
            checkBoxShowMargin.Text = "Show X Axis &Margin:";
            checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.CheckedChanged += new EventHandler(checkBoxShowMargin_CheckedChanged);
            // 
            // comboBoxPointLabels
            // 
            comboBoxPointLabels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxPointLabels.Items.AddRange([
            "None",
            "Auto",
            "TopLeft",
            "Top",
            "TopRight",
            "Right",
            "BottomRight",
            "Bottom",
            "BottomLeft",
            "Left",
            "Center"]);
            comboBoxPointLabels.Location = new Point(168, 40);
            comboBoxPointLabels.Name = "comboBoxPointLabels";
            comboBoxPointLabels.Size = new Size(104, 22);
            comboBoxPointLabels.TabIndex = 3;
            comboBoxPointLabels.SelectedIndexChanged += new EventHandler(comboBoxChartType_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(51, 40);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 2;
            label2.Text = "Point &Labels:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxChartType
            // 
            comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxChartType.Items.AddRange([
            "Line",
            "Spline",
            "StepLine"]);
            comboBoxChartType.Location = new Point(168, 8);
            comboBoxChartType.Name = "comboBoxChartType";
            comboBoxChartType.Size = new Size(104, 22);
            comboBoxChartType.TabIndex = 1;
            comboBoxChartType.SelectedIndexChanged += new EventHandler(comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(51, 8);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 0;
            label1.Text = "Chart &Type:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LineCurves3D
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "LineCurves3D";
            Size = new Size(728, 384);
            Load += new EventHandler(LineCurves3D_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Loop through all series
			foreach(Series series in chart1.Series)
			{
				// Set series chart type
				series.ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), comboBoxChartType.Text, true );

				// Set point labels
				if(comboBoxPointLabels.Text != "None")
				{
					series.IsValueShownAsLabel = true;
					if(comboBoxPointLabels.Text != "Auto")
					{
						series["LabelStyle"] = comboBoxPointLabels.Text;
					}
				}
				else
				{
					series.IsValueShownAsLabel = false;
				}

				// Enable / disable Marker Lines
				series["ShowMarkerLines"] = ShowMarkerLines.Checked.ToString();
			}

			// Set X axis margin
			chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;

		}

		private void LineCurves3D_Load(object sender, EventArgs e)
		{
			comboBoxChartType.SelectedIndex = 1;
			comboBoxPointLabels.SelectedIndex = 0;

			// Populate series data
			Random	random = new Random();
			for(int pointIndex = 0; pointIndex < 10; pointIndex++)
			{
				chart1.Series["Series1"].Points.AddY(random.Next(45, 95));
				chart1.Series["Series2"].Points.AddY(random.Next(5, 75));
				chart1.Series["Series3"].Points.AddY(random.Next(2, 50));
			}

			UpdateChartSettings();
		}

		private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
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
	}
}
