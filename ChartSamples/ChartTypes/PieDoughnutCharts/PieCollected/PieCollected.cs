using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Utilities;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for PieCollected.
	/// </summary>
	public class PieCollected : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private ComboBox comboBoxCollectedThreshold;
		private TextBox textBoxCollectedLabel;
		private Label label6;
		private Label label5;
		private ComboBox comboBoxCollectedColor;
		private Label label4;
		private CheckBox checkBoxCollectPieSlices;
		private CheckBox checkBoxShowExploded;
		private ComboBox comboBoxChartType;
		private Label label1;
		private Panel panel1;
		private Label label2;
		private TextBox textBoxCollectedLegend;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public PieCollected()
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
			DataPoint dataPoint1 = new DataPoint(0, 39);
			DataPoint dataPoint2 = new DataPoint(0, 18);
			DataPoint dataPoint3 = new DataPoint(0, 15);
			DataPoint dataPoint4 = new DataPoint(0, 12);
			DataPoint dataPoint5 = new DataPoint(0, 8);
			DataPoint dataPoint6 = new DataPoint(0, 4.5);
			DataPoint dataPoint7 = new DataPoint(0, 3.2000000476837158);
			DataPoint dataPoint8 = new DataPoint(0, 2);
			DataPoint dataPoint9 = new DataPoint(0, 1);
            chart1 = new Chart();
            labelSampleComment = new Label();
            comboBoxCollectedThreshold = new ComboBox();
            textBoxCollectedLabel = new TextBox();
            label6 = new Label();
            label5 = new Label();
            comboBoxCollectedColor = new ComboBox();
            label4 = new Label();
            checkBoxCollectPieSlices = new CheckBox();
            checkBoxShowExploded = new CheckBox();
            comboBoxChartType = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            textBoxCollectedLegend = new TextBox();
            label2 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.PointGapDepth = 900;
            chartArea1.Area3DStyle.Rotation = 162;
            chartArea1.Area3DStyle.WallWidth = 25;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorTickMark.Enabled = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Area1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            chart1.IsSoftShadows = false;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            legend1.IsEquallySpacedItems = true;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 61);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.ChartArea = "Area1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DoughnutRadius=25, PieDrawingStyle=Concave, CollectedLabel=Other, MinimumRelative" +
                "PieSize=20";
            series1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            series1.Label = "#PERCENT{P1}";
            series1.Legend = "Default";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            dataPoint1.CustomProperties = "OriginalPointIndex=0";
            dataPoint1.IsValueShownAsLabel = false;
            dataPoint1.LegendText = "RUS";
            dataPoint2.CustomProperties = "OriginalPointIndex=1";
            dataPoint2.IsValueShownAsLabel = false;
            dataPoint2.LegendText = "CAN";
            dataPoint3.CustomProperties = "OriginalPointIndex=2";
            dataPoint3.IsValueShownAsLabel = false;
            dataPoint3.LegendText = "USA";
            dataPoint4.CustomProperties = "OriginalPointIndex=3";
            dataPoint4.LegendText = "PRC";
            dataPoint5.CustomProperties = "OriginalPointIndex=5";
            dataPoint5.LegendText = "DEN";
            dataPoint6.LegendText = "AUS";
            dataPoint7.CustomProperties = "OriginalPointIndex=4";
            dataPoint7.LegendText = "IND";
            dataPoint8.LegendText = "ARG";
            dataPoint9.LegendText = "FRA";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
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
            labelSampleComment.Text = "This sample demonstrates how to group many small segments of a pie or doughnut ch" +
                "art into one collected slice to improve chart readability.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCollectedThreshold
            // 
            comboBoxCollectedThreshold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxCollectedThreshold.Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBoxCollectedThreshold.ItemHeight = 14;
            comboBoxCollectedThreshold.Items.AddRange([
            "5",
            "8",
            "12",
            "15"]);
            comboBoxCollectedThreshold.Location = new Point(184, 40);
            comboBoxCollectedThreshold.Name = "comboBoxCollectedThreshold";
            comboBoxCollectedThreshold.Size = new Size(104, 22);
            comboBoxCollectedThreshold.TabIndex = 2;
            comboBoxCollectedThreshold.SelectedIndexChanged += new EventHandler(comboBoxCollectedThreshold_SelectedIndexChanged);
            // 
            // textBoxCollectedLabel
            // 
            textBoxCollectedLabel.Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxCollectedLabel.Location = new Point(184, 104);
            textBoxCollectedLabel.MaxLength = 12;
            textBoxCollectedLabel.Name = "textBoxCollectedLabel";
            textBoxCollectedLabel.Size = new Size(104, 22);
            textBoxCollectedLabel.TabIndex = 4;
            textBoxCollectedLabel.TextChanged += new EventHandler(textBoxCollectedLabel_TextChanged);
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.White;
            label6.Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new Point(35, 104);
            label6.Name = "label6";
            label6.Size = new Size(144, 23);
            label6.TabIndex = 4;
            label6.Text = "Collected &Label:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.White;
            label5.Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new Point(35, 72);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 3;
            label5.Text = "Collected &Color:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxCollectedColor
            // 
            comboBoxCollectedColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxCollectedColor.Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBoxCollectedColor.ItemHeight = 14;
            comboBoxCollectedColor.Items.AddRange([
            "Green",
            "Gold",
            "Gray",
            "Magenta"]);
            comboBoxCollectedColor.Location = new Point(184, 72);
            comboBoxCollectedColor.Name = "comboBoxCollectedColor";
            comboBoxCollectedColor.Size = new Size(104, 22);
            comboBoxCollectedColor.TabIndex = 3;
            comboBoxCollectedColor.SelectedIndexChanged += new EventHandler(comboBoxCollectedColor_SelectedIndexChanged);
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.White;
            label4.Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new Point(4, 40);
            label4.Name = "label4";
            label4.Size = new Size(176, 23);
            label4.TabIndex = 2;
            label4.Text = "Collected &Threshold (in %):";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxCollectPieSlices
            // 
            checkBoxCollectPieSlices.BackColor = System.Drawing.Color.White;
            checkBoxCollectPieSlices.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxCollectPieSlices.Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBoxCollectPieSlices.Location = new Point(38, 8);
            checkBoxCollectPieSlices.Name = "checkBoxCollectPieSlices";
            checkBoxCollectPieSlices.Size = new Size(160, 24);
            checkBoxCollectPieSlices.TabIndex = 1;
            checkBoxCollectPieSlices.Text = "Collect &Pie Slices:     ";
            checkBoxCollectPieSlices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxCollectPieSlices.UseVisualStyleBackColor = false;
            checkBoxCollectPieSlices.CheckedChanged += new EventHandler(checkBoxCollectPieSlices_CheckedChanged);
            // 
            // checkBoxShowExploded
            // 
            checkBoxShowExploded.BackColor = System.Drawing.Color.White;
            checkBoxShowExploded.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowExploded.Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBoxShowExploded.Location = new Point(62, 165);
            checkBoxShowExploded.Name = "checkBoxShowExploded";
            checkBoxShowExploded.Size = new Size(136, 24);
            checkBoxShowExploded.TabIndex = 6;
            checkBoxShowExploded.Text = "&Show Exploded: ";
            checkBoxShowExploded.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowExploded.UseVisualStyleBackColor = false;
            checkBoxShowExploded.CheckedChanged += new EventHandler(checkBoxcollectSmallSegments_CheckedChanged);
            // 
            // comboBoxChartType
            // 
            comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxChartType.Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBoxChartType.ItemHeight = 14;
            comboBoxChartType.Items.AddRange([
            "Pie",
            "Doughnut"]);
            comboBoxChartType.Location = new Point(184, 195);
            comboBoxChartType.Name = "comboBoxChartType";
            comboBoxChartType.Size = new Size(104, 22);
            comboBoxChartType.TabIndex = 7;
            comboBoxChartType.SelectedIndexChanged += new EventHandler(comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(99, 194);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 7;
            label1.Text = "Chart &Type:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(textBoxCollectedLegend);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxCollectedThreshold);
            panel1.Controls.Add(textBoxCollectedLabel);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBoxCollectedColor);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(checkBoxCollectPieSlices);
            panel1.Controls.Add(checkBoxShowExploded);
            panel1.Controls.Add(comboBoxChartType);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panel1.Location = new Point(432, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 0;
            // 
            // textBoxCollectedLegend
            // 
            textBoxCollectedLegend.Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxCollectedLegend.Location = new Point(184, 136);
            textBoxCollectedLegend.MaxLength = 12;
            textBoxCollectedLegend.Name = "textBoxCollectedLegend";
            textBoxCollectedLegend.Size = new Size(104, 22);
            textBoxCollectedLegend.TabIndex = 5;
            textBoxCollectedLegend.TextChanged += new EventHandler(textBoxCollectedLegend_TextChanged);
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.White;
            label2.Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(27, 136);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 5;
            label2.Text = "Collected &Legend Text:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PieCollected
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PieCollected";
            Size = new Size(728, 368);
            Load += new EventHandler(PieChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			Series series1 = chart1.Series[0];

			if (checkBoxCollectPieSlices.Checked) 
			{
				comboBoxChartType.Enabled = true;
				comboBoxCollectedColor.Enabled = true;
				comboBoxCollectedThreshold.Enabled = true;
				textBoxCollectedLabel.Enabled = true;
				textBoxCollectedLegend.Enabled = true;
				checkBoxCollectPieSlices.Enabled = true;
				checkBoxCollectPieSlices.Enabled = true;
				checkBoxShowExploded.Enabled = true;

				// Set the threshold under which all points will be collected
				series1["CollectedThreshold"] = comboBoxCollectedThreshold.GetItemText(comboBoxCollectedThreshold.SelectedItem);
				
				// Set the label of the collected pie slice
				series1["CollectedLabel"] = textBoxCollectedLabel.Text;
				
				// Set the legend text of the collected pie slice
				series1["CollectedLegendText"] = textBoxCollectedLegend.Text;

				// Set the collected pie slice to be exploded
				series1["CollectedSliceExploded"]= checkBoxShowExploded.Checked.ToString();

				// Set collected color
				series1["CollectedColor"] = comboBoxCollectedColor.GetItemText(comboBoxCollectedColor.SelectedItem);

				// Set chart type
				series1.ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), comboBoxChartType.Text, true );

			}

			else 
			{
				series1["CollectedThreshold"] = "0";
				comboBoxChartType.Enabled = false;
				comboBoxCollectedColor.Enabled = false;
				comboBoxCollectedThreshold.Enabled = false;
				textBoxCollectedLabel.Enabled = false;
				textBoxCollectedLegend.Enabled = false;
				checkBoxShowExploded.Enabled = false;
			}
		}

		private void PieChartType_Load(object sender, EventArgs e)
		{
			// Set series font
			chart1.Series[0].Font = new Font("Trebuchet MS", 8, FontStyle.Bold);
            
			// Set current selection
			checkBoxCollectPieSlices.Checked = false;
			comboBoxChartType.SelectedIndex = 0;
			comboBoxCollectedColor.SelectedIndex = 0;
			comboBoxCollectedThreshold.SelectedIndex = 0;
			textBoxCollectedLabel.Text = "Other";
			textBoxCollectedLegend.Text = "Other";

			chart1.Series[0]["CollectedToolTip"] = "Other";

			// Update chart
			UpdateChartSettings();
		}

		private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxcollectSmallSegments_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxCollectedColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void textBoxCollectedLabel_TextChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void comboBoxCollectedThreshold_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void textBoxCollectedLegend_TextChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxCollectPieSlices_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}
	}
}
