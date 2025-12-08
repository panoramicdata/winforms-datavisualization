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
	/// Summary description for PieChart3D.
	/// </summary>
	public class PieChart3D : UserControl
	{
		# region Fields

		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxChartType;
		private Label label2;
		private ComboBox comboBoxLabelStyle;
		private Label label3;
		private ComboBox comboBoxExploded;
		private Timer timer1;
		private CheckBox ShowLegend;
		private ComboBox comboBoxRadius;
		private Label label4;
		private CheckBox checkBoxShow3D;
		private CheckBox checkBoxRotate;
        private IContainer components;
		private Label label6;
		private ComboBox comboBoxPieDrawingStyle;
		private int angle = 0;

		#endregion

		# region Constructor

		public PieChart3D()
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

		#endregion

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
			DataPoint dataPoint1 = new DataPoint(0, 65.62);
			DataPoint dataPoint2 = new DataPoint(0, 75.54);
			DataPoint dataPoint3 = new DataPoint(0, 60.45);
			DataPoint dataPoint4 = new DataPoint(0, 55.73);
			DataPoint dataPoint5 = new DataPoint(0, 70.42);
			Title title1 = new Title();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            label6 = new Label();
            comboBoxPieDrawingStyle = new ComboBox();
            checkBoxRotate = new CheckBox();
            checkBoxShow3D = new CheckBox();
            comboBoxRadius = new ComboBox();
            label4 = new Label();
            ShowLegend = new CheckBox();
            comboBoxExploded = new ComboBox();
            label3 = new Label();
            comboBoxLabelStyle = new ComboBox();
            label2 = new Label();
            comboBoxChartType = new ComboBox();
            label1 = new Label();
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
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 0;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 40);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DoughnutRadius=60, PieLabelStyle=Disabled, PieDrawingStyle=SoftEdge";
            series1.Legend = "Default";
            series1.Name = "Default";
            dataPoint1.CustomProperties = "Exploded=false";
            dataPoint1.Label = "France";
            dataPoint2.CustomProperties = "Exploded=false";
            dataPoint2.Label = "Canada";
            dataPoint3.CustomProperties = "Exploded=false";
            dataPoint3.Label = "UK";
            dataPoint4.CustomProperties = "Exploded=false";
            dataPoint4.Label = "USA";
            dataPoint5.CustomProperties = "Exploded=false";
            dataPoint5.Label = "Italy";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 0;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Doughnut Chart";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 26);
            labelSampleComment.TabIndex = 2;
            labelSampleComment.Text = "This sample demonstrates the Pie and Doughnut chart types in both 2D and 3D.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBoxPieDrawingStyle);
            panel1.Controls.Add(checkBoxRotate);
            panel1.Controls.Add(checkBoxShow3D);
            panel1.Controls.Add(comboBoxRadius);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ShowLegend);
            panel1.Controls.Add(comboBoxExploded);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxLabelStyle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxChartType);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.Location = new Point(49, 229);
            label6.Name = "label6";
            label6.Size = new Size(112, 23);
            label6.TabIndex = 14;
            label6.Text = "&Drawing Style:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxPieDrawingStyle
            // 
            comboBoxPieDrawingStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxPieDrawingStyle.Items.AddRange([
            "Default",
            "SoftEdge",
            "Concave"]);
            comboBoxPieDrawingStyle.Location = new Point(167, 229);
            comboBoxPieDrawingStyle.Name = "comboBoxPieDrawingStyle";
            comboBoxPieDrawingStyle.Size = new Size(112, 22);
            comboBoxPieDrawingStyle.TabIndex = 13;
            comboBoxPieDrawingStyle.SelectedIndexChanged += new EventHandler(comboBoxDrawingStyle_SelectedIndexChanged);
            // 
            // checkBoxRotate
            // 
            checkBoxRotate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxRotate.Location = new Point(13, 166);
            checkBoxRotate.Name = "checkBoxRotate";
            checkBoxRotate.Size = new Size(168, 24);
            checkBoxRotate.TabIndex = 12;
            checkBoxRotate.Text = "Rotate C&hart:";
            checkBoxRotate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxShow3D
            // 
            checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.Location = new Point(14, 197);
            checkBoxShow3D.Name = "checkBoxShow3D";
            checkBoxShow3D.Size = new Size(168, 24);
            checkBoxShow3D.TabIndex = 11;
            checkBoxShow3D.Text = "Display &chart as 3D:";
            checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.CheckedChanged += new EventHandler(checkBoxShow3D_CheckedChanged);
            // 
            // comboBoxRadius
            // 
            comboBoxRadius.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxRadius.Items.AddRange([
            "20",
            "30",
            "40",
            "50",
            "60",
            "70"]);
            comboBoxRadius.Location = new Point(168, 104);
            comboBoxRadius.Name = "comboBoxRadius";
            comboBoxRadius.Size = new Size(112, 22);
            comboBoxRadius.TabIndex = 3;
            comboBoxRadius.SelectedIndexChanged += new EventHandler(comboBoxRadius_SelectedIndexChanged);
            // 
            // label4
            // 
            label4.Location = new Point(11, 104);
            label4.Name = "label4";
            label4.Size = new Size(152, 23);
            label4.TabIndex = 8;
            label4.Text = "Doughnut &Radius (%):";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShowLegend
            // 
            ShowLegend.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            ShowLegend.Checked = true;
            ShowLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            ShowLegend.Location = new Point(21, 136);
            ShowLegend.Name = "ShowLegend";
            ShowLegend.Size = new Size(160, 24);
            ShowLegend.TabIndex = 4;
            ShowLegend.Text = "Show &Legend:";
            ShowLegend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            ShowLegend.CheckedChanged += new EventHandler(ShowLegend_CheckedChanged);
            // 
            // comboBoxExploded
            // 
            comboBoxExploded.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxExploded.Items.AddRange([
            "None",
            "France",
            "Canada",
            "UK",
            "USA",
            "Italy"]);
            comboBoxExploded.Location = new Point(168, 72);
            comboBoxExploded.Name = "comboBoxExploded";
            comboBoxExploded.Size = new Size(112, 22);
            comboBoxExploded.TabIndex = 2;
            comboBoxExploded.SelectedIndexChanged += new EventHandler(comboBoxExploded_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(11, 72);
            label3.Name = "label3";
            label3.Size = new Size(152, 23);
            label3.TabIndex = 7;
            label3.Text = "&Exploded Point:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxLabelStyle
            // 
            comboBoxLabelStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxLabelStyle.Items.AddRange([
            "Inside",
            "Outside",
            "Disabled"]);
            comboBoxLabelStyle.Location = new Point(168, 40);
            comboBoxLabelStyle.Name = "comboBoxLabelStyle";
            comboBoxLabelStyle.Size = new Size(112, 22);
            comboBoxLabelStyle.TabIndex = 1;
            comboBoxLabelStyle.SelectedIndexChanged += new EventHandler(comboBoxExploded_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(11, 40);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 6;
            label2.Text = "Label &Style:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxChartType
            // 
            comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxChartType.Items.AddRange([
            "Pie",
            "Doughnut"]);
            comboBoxChartType.Location = new Point(168, 8);
            comboBoxChartType.Name = "comboBoxChartType";
            comboBoxChartType.Size = new Size(112, 22);
            comboBoxChartType.TabIndex = 0;
            comboBoxChartType.SelectedIndexChanged += new EventHandler(comboBoxExploded_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 5;
            label1.Text = "Chart &Type:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += new EventHandler(timer1_Tick);
            // 
            // PieChart3D
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PieChart3D";
            Size = new Size(728, 440);
            Load += new EventHandler(PieChart3D_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			chart1.Legends[0].Enabled = ShowLegend.Checked;	

			// Set chart type and title
			chart1.Series["Default"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), comboBoxChartType.Text, true );
			chart1.Titles[0].Text = comboBoxChartType.Text + " Chart";

			// Set labels style
			chart1.Series["Default"]["PieLabelStyle"] = comboBoxLabelStyle.Text;

			// Set Doughnut hole size
			chart1.Series["Default"]["DoughnutRadius"] = comboBoxRadius.Text;

			// Disable Doughnut hole size control for Pie chart
			comboBoxRadius.Enabled = (comboBoxChartType.Text != "Pie");

			// Explode selected country
			foreach(DataPoint point in chart1.Series["Default"].Points)
			{
				point["Exploded"] = "false";
				if(point.AxisLabel == comboBoxExploded.Text)
				{
					point["Exploded"] = "true";
				}
			}

			// Enable 3D
			chart1.ChartAreas[0].Area3DStyle.Enable3D = checkBoxShow3D.Checked;

			// Pie drawing style
			if (checkBoxShow3D.Checked)
				comboBoxPieDrawingStyle.Enabled = false;
			
			else
				comboBoxPieDrawingStyle.Enabled = true;
		}

		private void PieChart3D_Load(object sender, EventArgs e)
		{
			// Populate series data
			double[]	yValues = [65.62, 75.54, 60.45, 55.73, 70.42];
			string[]	xValues = ["France", "Canada", "UK", "USA", "Italy"];
			chart1.Series["Default"].Points.DataBindXY(xValues, yValues);		

			// Set selection
			comboBoxChartType.SelectedIndex = 1;
			comboBoxPieDrawingStyle.SelectedIndex = 1;
			comboBoxLabelStyle.SelectedIndex = 0;
			comboBoxExploded.SelectedIndex = 0;
			comboBoxRadius.SelectedIndex = 4;
			chart1.Legends[0].Enabled = ShowLegend.Checked;
		}

		private void comboBoxExploded_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if(checkBoxRotate.Checked)
			{
				angle += 1;
				if(angle >= 360)
				{
					angle = 0;
				}
				chart1.Series["Default"]["PieStartAngle"] = angle.ToString();		
			}
		}

		private void ShowLegend_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void comboBoxRadius_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void LabelLineSizeBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();			
		}

		private void comboBoxDrawingStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			chart1.Series[0]["PieDrawingStyle"] = comboBoxPieDrawingStyle.SelectedItem.ToString();
		}
	}
}
