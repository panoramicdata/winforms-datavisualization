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
	/// Summary description for AutoFitAxesLabels.
	/// </summary>
	public class AutoFitAxesLabels : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private CheckBox checkBoxAutoFit;
		private CheckBox checkBoxFontSize;
		private CheckBox checkBoxOffsetLabels;
		private CheckBox checkBoxWordWrap;
		private ComboBox comboBoInclination;
		private Label labelAngle;
		private Chart chart2;
		private Label label2;
		private GroupBox groupBox1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AutoFitAxesLabels()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize component
			comboBoInclination.SelectedIndex = 1;

			UpdateAutoFitChecked();
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
			DataPoint dataPoint1 = new DataPoint(37622, 345);
			DataPoint dataPoint2 = new DataPoint(37623, 634);
			DataPoint dataPoint3 = new DataPoint(37624, 154);
			DataPoint dataPoint4 = new DataPoint(37625, 765);
			DataPoint dataPoint5 = new DataPoint(37626, 376);
			DataPoint dataPoint6 = new DataPoint(37627, 600);
			ChartArea chartArea2 = new ChartArea();
			Legend legend2 = new Legend();
			Series series2 = new Series();
			DataPoint dataPoint7 = new DataPoint(37622, 345);
			DataPoint dataPoint8 = new DataPoint(37623, 634);
			DataPoint dataPoint9 = new DataPoint(37624, 154);
			DataPoint dataPoint10 = new DataPoint(37625, 765);
			DataPoint dataPoint11 = new DataPoint(37626, 376);
			DataPoint dataPoint12 = new DataPoint(37627, 457);
            label9 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            checkBoxFontSize = new CheckBox();
            labelAngle = new Label();
            checkBoxWordWrap = new CheckBox();
            checkBoxOffsetLabels = new CheckBox();
            comboBoInclination = new ComboBox();
            checkBoxAutoFit = new CheckBox();
            Chart1 = new Chart();
            chart2 = new Chart();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            ((ISupportInitialize)(chart2)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to automatically fit labels along an axis. ";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(checkBoxAutoFit);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxFontSize);
            groupBox1.Controls.Add(labelAngle);
            groupBox1.Controls.Add(checkBoxWordWrap);
            groupBox1.Controls.Add(checkBoxOffsetLabels);
            groupBox1.Controls.Add(comboBoInclination);
            groupBox1.Location = new Point(16, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 160);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Automatic Fitting Style:";
            // 
            // checkBoxFontSize
            // 
            checkBoxFontSize.Checked = true;
            checkBoxFontSize.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxFontSize.Enabled = false;
            checkBoxFontSize.Location = new Point(32, 24);
            checkBoxFontSize.Name = "checkBoxFontSize";
            checkBoxFontSize.Size = new Size(216, 24);
            checkBoxFontSize.TabIndex = 2;
            checkBoxFontSize.Text = "Modify Font &Size";
            checkBoxFontSize.CheckedChanged += new EventHandler(checkBoxFontSize_CheckedChanged);
            // 
            // labelAngle
            // 
            labelAngle.Enabled = false;
            labelAngle.Location = new Point(24, 120);
            labelAngle.Name = "labelAngle";
            labelAngle.Size = new Size(96, 23);
            labelAngle.TabIndex = 5;
            labelAngle.Text = "Labels &Angle:";
            labelAngle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxWordWrap
            // 
            checkBoxWordWrap.Checked = true;
            checkBoxWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxWordWrap.Enabled = false;
            checkBoxWordWrap.Location = new Point(32, 88);
            checkBoxWordWrap.Name = "checkBoxWordWrap";
            checkBoxWordWrap.Size = new Size(216, 24);
            checkBoxWordWrap.TabIndex = 4;
            checkBoxWordWrap.Text = "Use Word &Wrap";
            checkBoxWordWrap.CheckedChanged += new EventHandler(checkBoxWordWrap_CheckedChanged);
            // 
            // checkBoxOffsetLabels
            // 
            checkBoxOffsetLabels.Checked = true;
            checkBoxOffsetLabels.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxOffsetLabels.Enabled = false;
            checkBoxOffsetLabels.Location = new Point(32, 56);
            checkBoxOffsetLabels.Name = "checkBoxOffsetLabels";
            checkBoxOffsetLabels.Size = new Size(216, 24);
            checkBoxOffsetLabels.TabIndex = 3;
            checkBoxOffsetLabels.Text = "Use &Offset Labels";
            checkBoxOffsetLabels.CheckedChanged += new EventHandler(checkBoxOffsetLabels_CheckedChanged);
            // 
            // comboBoInclination
            // 
            comboBoInclination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoInclination.Enabled = false;
            comboBoInclination.Items.AddRange([
            "Not Changed",
            "0-30-60-90",
            "0-45-90",
            "0-90"]);
            comboBoInclination.Location = new Point(128, 120);
            comboBoInclination.Name = "comboBoInclination";
            comboBoInclination.Size = new Size(120, 22);
            comboBoInclination.TabIndex = 6;
            comboBoInclination.SelectedIndexChanged += new EventHandler(comboBoInclination_SelectedIndexChanged);
            // 
            // checkBoxAutoFit
            // 
            checkBoxAutoFit.Checked = true;
            checkBoxAutoFit.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxAutoFit.Location = new Point(48, 8);
            checkBoxAutoFit.Name = "checkBoxAutoFit";
            checkBoxAutoFit.Size = new Size(228, 24);
            checkBoxAutoFit.TabIndex = 0;
            checkBoxAutoFit.Text = "Automatically Fit &X Axis Labels";
            checkBoxAutoFit.CheckedChanged += new EventHandler(checkBoxAutoFit_CheckedChanged);
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
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "ddd, MMM dd";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Format = "C";
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Series1";
            dataPoint1.AxisLabel = "";
            dataPoint2.AxisLabel = "";
            dataPoint3.AxisLabel = "";
            dataPoint4.AxisLabel = "";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            Chart1.Click += new EventHandler(Chart1_Click);
            // 
            // chart2
            // 
            chart2.BorderlineColor = System.Drawing.Color.DimGray;
            chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart2.BorderSkin.BackSecondaryColor = System.Drawing.Color.White;
            chart2.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Format = "ddd, MMM dd";
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.LabelStyle.Format = "C";
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.BackColor = System.Drawing.Color.LightGray;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "Default";
            chartArea2.ShadowOffset = 1;
            chart2.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.White;
            legend2.BorderColor = System.Drawing.Color.Black;
            legend2.Enabled = false;
            legend2.Name = "Default";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(16, 48);
            chart2.Name = "chart2";
            chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.ChartArea = "Default";
            series2.Legend = "Default";
            series2.Name = "Series1";
            dataPoint7.AxisLabel = "";
            dataPoint8.AxisLabel = "";
            dataPoint9.AxisLabel = "";
            dataPoint10.AxisLabel = "";
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.ShadowOffset = 1;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart2.Series.Add(series2);
            chart2.Size = new Size(360, 260);
            chart2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label2.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(20, 360);
            label2.Name = "label2";
            label2.Size = new Size(692, 34);
            label2.TabIndex = 3;
            label2.Text = "For more information on this sample, Click the Overview tab at the top of this fr" +
                "ame.";
            // 
            // AutoFitAxesLabels
            // 
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(Chart1);
            Controls.Add(label9);
            Controls.Add(chart2);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AutoFitAxesLabels";
            Size = new Size(728, 480);
            Load += new EventHandler(CustomLabels_Load);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ((ISupportInitialize)(chart2)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void Chart1_Click(object sender, EventArgs e)
		{
		
		}

		private void CustomLabels_Load(object sender, EventArgs e)
		{
		}

		private void Combo_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void checkBoxAutoFit_CheckedChanged(object sender, EventArgs e)
		{
			UpdateAutoFitChecked();
		}

		private void UpdateAutoFitChecked() 
		{
			checkBoxFontSize.Enabled = checkBoxAutoFit.Checked;
			checkBoxOffsetLabels.Enabled = checkBoxAutoFit.Checked;
			checkBoxWordWrap.Enabled = checkBoxAutoFit.Checked;
			labelAngle.Enabled = checkBoxAutoFit.Checked;
			comboBoInclination.Enabled = checkBoxAutoFit.Checked;

			// Enable/disable X axis labels automatic fitting
			Chart1.ChartAreas["Default"].AxisX.IsLabelAutoFit = checkBoxAutoFit.Checked;
		}

		private void checkBoxFontSize_CheckedChanged(object sender, EventArgs e)
		{
			UpdateAutoFitStyle();
		}

		private void checkBoxOffsetLabels_CheckedChanged(object sender, EventArgs e)
		{
			UpdateAutoFitStyle();
		}

		private void checkBoxWordWrap_CheckedChanged(object sender, EventArgs e)
		{
			UpdateAutoFitStyle();
		}

		private void comboBoInclination_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateAutoFitStyle();
		}

		private void UpdateAutoFitStyle()
		{
			// Set X axis auto fit style
			Chart1.ChartAreas["Default"].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
			if(checkBoxFontSize.Checked)
			{
				Chart1.ChartAreas["Default"].AxisX.LabelAutoFitStyle |= 
					LabelAutoFitStyles.DecreaseFont | LabelAutoFitStyles.IncreaseFont;
			}
			if(checkBoxOffsetLabels.Checked)
			{
				Chart1.ChartAreas["Default"].AxisX.LabelAutoFitStyle |= 
					LabelAutoFitStyles.StaggeredLabels;
			}
			if(checkBoxWordWrap.Checked)
			{
				Chart1.ChartAreas["Default"].AxisX.LabelAutoFitStyle |= 
					LabelAutoFitStyles.WordWrap;
			}
			if(comboBoInclination.SelectedIndex == 1)
			{
				Chart1.ChartAreas["Default"].AxisX.LabelAutoFitStyle |= 
					LabelAutoFitStyles.LabelsAngleStep30;
			}
			if(comboBoInclination.SelectedIndex == 2)
			{
				Chart1.ChartAreas["Default"].AxisX.LabelAutoFitStyle |= 
					LabelAutoFitStyles.LabelsAngleStep45;
			}
			if(comboBoInclination.SelectedIndex == 3)
			{
				Chart1.ChartAreas["Default"].AxisX.LabelAutoFitStyle |= 
					LabelAutoFitStyles.LabelsAngleStep90;
			}

		}
		
	}
}
