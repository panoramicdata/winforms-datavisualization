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
	/// Summary description for RangeColumnChartType.
	/// </summary>
	public class RangeColumnChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private CheckBox checkBoxShow3D;
		private CheckBox checkBoxDrawSideBySide;
		private ComboBox comboBoxDrawingStyle;
		private Label label2;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public RangeColumnChartType()
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
			DataPoint dataPoint1 = new DataPoint(0, "30,80");
			DataPoint dataPoint2 = new DataPoint(0, "40,70");
			DataPoint dataPoint3 = new DataPoint(0, "75,90");
			DataPoint dataPoint4 = new DataPoint(0, "60,80");
			DataPoint dataPoint5 = new DataPoint(0, "50,90");
			DataPoint dataPoint6 = new DataPoint(0, "70,80");
			Series series2 = new Series();
			DataPoint dataPoint7 = new DataPoint(0, "10,20");
			DataPoint dataPoint8 = new DataPoint(0, "15,40");
			DataPoint dataPoint9 = new DataPoint(0, "20,60");
			DataPoint dataPoint10 = new DataPoint(0, "10,30");
			DataPoint dataPoint11 = new DataPoint(0, "30,40");
			DataPoint dataPoint12 = new DataPoint(0, "10,70");
			Title title1 = new Title();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            comboBoxDrawingStyle = new ComboBox();
            label2 = new Label();
            checkBoxDrawSideBySide = new CheckBox();
            checkBoxShow3D = new CheckBox();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.PointDepth = 200;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.LabelStyle.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 53);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DrawSideBySide=True";
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.YValuesPerPoint = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "DrawSideBySide=True";
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.YValuesPerPoint = 2;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Range Column Chart";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(720, 37);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "A Range Column chart is similar to the Column chart, except the Range Column char" +
                "t uses two Y values to define the start and end position of each column.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxDrawingStyle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(checkBoxDrawSideBySide);
            panel1.Controls.Add(checkBoxShow3D);
            panel1.Location = new Point(432, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 288);
            panel1.TabIndex = 2;
            // 
            // comboBoxDrawingStyle
            // 
            comboBoxDrawingStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxDrawingStyle.Items.AddRange([
            "Default",
            "Emboss",
            "Cylinder",
            "Wedge",
            "LightToDark"]);
            comboBoxDrawingStyle.Location = new Point(177, 76);
            comboBoxDrawingStyle.Name = "comboBoxDrawingStyle";
            comboBoxDrawingStyle.Size = new Size(112, 22);
            comboBoxDrawingStyle.TabIndex = 13;
            comboBoxDrawingStyle.SelectedIndexChanged += new EventHandler(comboBoxDrawingStyle_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(64, 76);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 12;
            label2.Text = "Drawing Style:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxDrawSideBySide
            // 
            checkBoxDrawSideBySide.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxDrawSideBySide.Checked = true;
            checkBoxDrawSideBySide.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxDrawSideBySide.Location = new Point(8, 16);
            checkBoxDrawSideBySide.Name = "checkBoxDrawSideBySide";
            checkBoxDrawSideBySide.Size = new Size(184, 24);
            checkBoxDrawSideBySide.TabIndex = 0;
            checkBoxDrawSideBySide.Text = "Show &Side-by-Side:";
            checkBoxDrawSideBySide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxDrawSideBySide.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            // 
            // checkBoxShow3D
            // 
            checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.Location = new Point(8, 45);
            checkBoxShow3D.Name = "checkBoxShow3D";
            checkBoxShow3D.Size = new Size(184, 24);
            checkBoxShow3D.TabIndex = 1;
            checkBoxShow3D.Text = "Show as 3&D:";
            checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.CheckedChanged += new EventHandler(checkBoxShow3D_CheckedChanged);
            // 
            // RangeColumnChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "RangeColumnChartType";
            Size = new Size(752, 376);
            Load += new EventHandler(PieChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Show as 2D or 3D
			chart1.ChartAreas["Default"].Area3DStyle.Enable3D = checkBoxShow3D.Checked;

			// Set drawing style
			chart1.Series["Series1"]["DrawingStyle"] = comboBoxDrawingStyle.SelectedItem.ToString();
			chart1.Series["Series2"]["DrawingStyle"] = comboBoxDrawingStyle.SelectedItem.ToString();

			// Set range column chart type
			chart1.Series["Series1"].ChartType = SeriesChartType.RangeColumn;
			chart1.Series["Series2"].ChartType = SeriesChartType.RangeColumn;

			// Set the side-by-side drawing style
			chart1.Series["Series1"]["DrawSideBySide"] = (checkBoxDrawSideBySide.Checked) ? "true" : "false";
			chart1.Series["Series2"]["DrawSideBySide"] = (checkBoxDrawSideBySide.Checked) ? "true" : "false";
			
		}

		private void PieChartType_Load(object sender, EventArgs e)
		{			
			comboBoxDrawingStyle.SelectedIndex = 0;
			UpdateChartSettings();	
		}

		private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void comboBoxDrawingStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}
	}
}
