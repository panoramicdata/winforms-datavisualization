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
	/// Summary description for StackedChartType.
	/// </summary>
	public class StackedChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxChartType;
		private CheckBox checkBoxHundredPercent;
		private CheckBox checkBoxShowLabels;
		private CheckBox checkBoxShowMargin;
		private CheckBox checkBoxShow3D;
		private CheckBox checkBoxGrouped;
		private Label label2;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public StackedChartType()
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
			Series series4 = new Series();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            checkBoxGrouped = new CheckBox();
            checkBoxShow3D = new CheckBox();
            checkBoxShowMargin = new CheckBox();
            checkBoxShowLabels = new CheckBox();
            checkBoxHundredPercent = new CheckBox();
            comboBoxChartType = new ComboBox();
            label1 = new Label();
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
            chartArea1.Area3DStyle.Inclination = 15;
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
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 92F;
            chartArea1.Position.Width = 92F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 3F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 53);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Series1";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.Legend = "Default";
            series3.Name = "Series3";
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series4.ChartArea = "Default";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            series4.Legend = "Default";
            series4.Name = "Series4";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Series.Add(series4);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 37);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates Stacked Area, Stacked Bar, Stacked Column, 100% Stacked " +
                "Area, 100% Stacked Bar, and 100% Stacked Column chart types.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxGrouped);
            panel1.Controls.Add(checkBoxShow3D);
            panel1.Controls.Add(checkBoxShowMargin);
            panel1.Controls.Add(checkBoxShowLabels);
            panel1.Controls.Add(checkBoxHundredPercent);
            panel1.Controls.Add(comboBoxChartType);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // checkBoxGrouped
            // 
            checkBoxGrouped.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxGrouped.Location = new Point(88, 176);
            checkBoxGrouped.Name = "checkBoxGrouped";
            checkBoxGrouped.Size = new Size(96, 24);
            checkBoxGrouped.TabIndex = 6;
            checkBoxGrouped.Text = "&Grouped:";
            checkBoxGrouped.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxGrouped.CheckedChanged += new EventHandler(checkBoxGrouped_CheckedChanged);
            // 
            // checkBoxShow3D
            // 
            checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.Location = new Point(15, 144);
            checkBoxShow3D.Name = "checkBoxShow3D";
            checkBoxShow3D.Size = new Size(168, 24);
            checkBoxShow3D.TabIndex = 5;
            checkBoxShow3D.Text = "Display chart as 3&D:";
            checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.CheckedChanged += new EventHandler(checkBoxShow3D_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.Checked = true;
            checkBoxShowMargin.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxShowMargin.Location = new Point(15, 112);
            checkBoxShowMargin.Name = "checkBoxShowMargin";
            checkBoxShowMargin.Size = new Size(168, 24);
            checkBoxShowMargin.TabIndex = 4;
            checkBoxShowMargin.Text = "Show X Axis &Margin:";
            checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.CheckedChanged += new EventHandler(checkBoxShowLabels_CheckedChanged_1);
            // 
            // checkBoxShowLabels
            // 
            checkBoxShowLabels.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowLabels.Location = new Point(15, 80);
            checkBoxShowLabels.Name = "checkBoxShowLabels";
            checkBoxShowLabels.Size = new Size(168, 24);
            checkBoxShowLabels.TabIndex = 3;
            checkBoxShowLabels.Text = "Show Point &Labels:";
            checkBoxShowLabels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowLabels.CheckedChanged += new EventHandler(checkBoxShowLabels_CheckedChanged_1);
            // 
            // checkBoxHundredPercent
            // 
            checkBoxHundredPercent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxHundredPercent.Location = new Point(15, 48);
            checkBoxHundredPercent.Name = "checkBoxHundredPercent";
            checkBoxHundredPercent.Size = new Size(168, 24);
            checkBoxHundredPercent.TabIndex = 2;
            checkBoxHundredPercent.Text = "100% &Stacked:";
            checkBoxHundredPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxHundredPercent.CheckedChanged += new EventHandler(checkBoxShowLabels_CheckedChanged_1);
            // 
            // comboBoxChartType
            // 
            comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxChartType.Items.AddRange([
            "StackedArea",
            "StackedBar",
            "StackedColumn"]);
            comboBoxChartType.Location = new Point(168, 16);
            comboBoxChartType.Name = "comboBoxChartType";
            comboBoxChartType.Size = new Size(121, 22);
            comboBoxChartType.TabIndex = 1;
            comboBoxChartType.SelectedIndexChanged += new EventHandler(comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(44, 16);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 0;
            label1.Text = "Chart Type:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(16, 357);
            label2.Name = "label2";
            label2.Size = new Size(702, 48);
            label2.TabIndex = 3;
            label2.Text = "When using the Stacked bar or Stacked column types, you can group different serie" +
                "s into separate groups by setting the StackedGroupName custom attribute.";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StackedChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "StackedChartType";
            Size = new Size(728, 480);
            Load += new EventHandler(StackedChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Set chart type
			string	chartTypeName = comboBoxChartType.Text;
			if(checkBoxHundredPercent.Checked)
			{
				chartTypeName = chartTypeName + "100";
			}

			// Grouping cannot be done using stacked area charts
			if (chartTypeName == "StackedArea" || chartTypeName == "StackedArea100") 
				checkBoxGrouped.Enabled = false;

			else
				checkBoxGrouped.Enabled = true;

			chart1.Series["Series1"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), chartTypeName, true );
			chart1.Series["Series2"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), chartTypeName, true );
			chart1.Series["Series3"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), chartTypeName, true );
			chart1.Series["Series4"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), chartTypeName, true );

			// Show point labels
			chart1.Series["Series1"].IsValueShownAsLabel = checkBoxShowLabels.Checked;
			chart1.Series["Series2"].IsValueShownAsLabel = checkBoxShowLabels.Checked;
			chart1.Series["Series3"].IsValueShownAsLabel = checkBoxShowLabels.Checked;
			chart1.Series["Series4"].IsValueShownAsLabel = checkBoxShowLabels.Checked;

			// Enable/Disable margin
			chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;
		}

		private void StackedChartType_Load(object sender, EventArgs e)
		{
			// Populate series data
			Random	random = new Random();
			for(int pointIndex = 0; pointIndex < 10; pointIndex++)
			{
				chart1.Series["Series1"].Points.AddY(random.Next(75, 170));
				chart1.Series["Series2"].Points.AddY(random.Next(35, 125));
				chart1.Series["Series3"].Points.AddY(random.Next(45, 140));
				chart1.Series["Series4"].Points.AddY(random.Next(25, 110));
			}

			// Set selection
			comboBoxChartType.SelectedIndex = 2;
		}

		private void checkBoxShowLabels_CheckedChanged_1(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxShow3D.Checked){
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
				chart1.ChartAreas["Default"].Area3DStyle.LightStyle = LightStyle.Simplistic;		
			}

			else
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;				
			}
		}

		private void checkBoxGrouped_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxGrouped.Checked) 
			{
				chart1.Series["Series1"]["StackedGroupName"] = "Group1";
				chart1.Series["Series2"]["StackedGroupName"] = "Group1";
				chart1.Series["Series3"]["StackedGroupName"] = "Group2";
				chart1.Series["Series4"]["StackedGroupName"] = "Group2";

				chart1.ResetAutoValues();
				chart1.Invalidate();
			}

			else 
			{
				foreach (Series series in chart1.Series) 
				{
					series["StackedGroupName"] = "";
				}

				chart1.ResetAutoValues();
				chart1.Invalidate();

			}
		
		}
	}
}
