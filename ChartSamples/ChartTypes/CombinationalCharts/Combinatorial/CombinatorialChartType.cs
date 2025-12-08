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
	/// Summary description for CombinatorialChartType.
	/// </summary>
	public class CombinatorialChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private ComboBox comboBoxSeries3;
		private Label label3;
		private ComboBox comboBoxSeries2;
		private Label label2;
		private ComboBox comboBoxSeries1;
		private Label label1;
		private CheckBox checkBoxShowMargin;
		private CheckBox checkBoxShow3D;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public CombinatorialChartType()
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
			Title title1 = new Title();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            checkBoxShow3D = new CheckBox();
            checkBoxShowMargin = new CheckBox();
            comboBoxSeries3 = new ComboBox();
            label3 = new Label();
            comboBoxSeries2 = new ComboBox();
            label2 = new Label();
            comboBoxSeries1 = new ComboBox();
            label1 = new Label();
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
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 58);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.MarkerSize = 10;
            series2.Name = "Series2";
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.Legend = "Default";
            series3.MarkerSize = 10;
            series3.Name = "Series3";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Combination Charts";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 37);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to combine different chart types in one plot area an" +
                "d how to display a chart area in 3D. ";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxShow3D);
            panel1.Controls.Add(checkBoxShowMargin);
            panel1.Controls.Add(comboBoxSeries3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxSeries2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxSeries1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // checkBoxShow3D
            // 
            checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.Location = new Point(-3, 136);
            checkBoxShow3D.Name = "checkBoxShow3D";
            checkBoxShow3D.Size = new Size(184, 24);
            checkBoxShow3D.TabIndex = 7;
            checkBoxShow3D.Text = "Display chart as 3&D:";
            checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.CheckedChanged += new EventHandler(checkBoxShow3D_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.Checked = true;
            checkBoxShowMargin.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxShowMargin.Location = new Point(13, 104);
            checkBoxShowMargin.Name = "checkBoxShowMargin";
            checkBoxShowMargin.Size = new Size(168, 24);
            checkBoxShowMargin.TabIndex = 6;
            checkBoxShowMargin.Text = "Show X Axis &Margin:";
            checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.CheckedChanged += new EventHandler(checkBoxShowMargin_CheckedChanged);
            // 
            // comboBoxSeries3
            // 
            comboBoxSeries3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSeries3.Items.AddRange([
            "Column",
            "Line",
            "Spline",
            "StepLine",
            "Area",
            "SplineArea",
            "Point"]);
            comboBoxSeries3.Location = new Point(168, 72);
            comboBoxSeries3.Name = "comboBoxSeries3";
            comboBoxSeries3.Size = new Size(104, 22);
            comboBoxSeries3.TabIndex = 5;
            comboBoxSeries3.SelectedIndexChanged += new EventHandler(comboBoxSeries1_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(11, 72);
            label3.Name = "label3";
            label3.Size = new Size(152, 23);
            label3.TabIndex = 4;
            label3.Text = "Series &3 Type:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxSeries2
            // 
            comboBoxSeries2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSeries2.Items.AddRange([
            "Column",
            "Line",
            "Spline",
            "StepLine",
            "Area",
            "SplineArea",
            "Point"]);
            comboBoxSeries2.Location = new Point(168, 40);
            comboBoxSeries2.Name = "comboBoxSeries2";
            comboBoxSeries2.Size = new Size(104, 22);
            comboBoxSeries2.TabIndex = 3;
            comboBoxSeries2.SelectedIndexChanged += new EventHandler(comboBoxSeries1_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 2;
            label2.Text = "Series &2 Type:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxSeries1
            // 
            comboBoxSeries1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSeries1.Items.AddRange([
            "Column",
            "Line",
            "Spline",
            "StepLine",
            "Area",
            "SplineArea",
            "Point"]);
            comboBoxSeries1.Location = new Point(168, 8);
            comboBoxSeries1.Name = "comboBoxSeries1";
            comboBoxSeries1.Size = new Size(104, 22);
            comboBoxSeries1.TabIndex = 1;
            comboBoxSeries1.SelectedIndexChanged += new EventHandler(comboBoxSeries1_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 0;
            label1.Text = "Series &1 Type:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CombinatorialChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "CombinatorialChartType";
            Size = new Size(728, 480);
            Load += new EventHandler(CombinatorialChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			if( comboBoxSeries3.Text == "" )
			{
				return;
			}

			// Set series chart types
			chart1.Series["Series1"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), comboBoxSeries1.Text, true );
			chart1.Series["Series2"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), comboBoxSeries2.Text, true );
			chart1.Series["Series3"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), comboBoxSeries3.Text, true );

			// Disable/enable X axis margin
			chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;

			// Adjust all series appearance depending on the chart type
			foreach(Series series in chart1.Series)
			{
				// Adjust border width 
				series.BorderWidth = 1;
				if(series.ChartType == SeriesChartType.Line || series.ChartType == SeriesChartType.Spline || series.ChartType == SeriesChartType.StepLine)
				{
					series.BorderWidth = 3;
				}

				// Disable shadow in area charts
				series.ShadowOffset = 2;
				if(series.ChartType == SeriesChartType.Area || series.ChartType == SeriesChartType.StackedArea || series.ChartType == SeriesChartType.SplineArea )
				{
					series.ShadowOffset = 0;
				}
			}

			// Check for 3D
			if(checkBoxShow3D.Checked){
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D=true;
			}
			else{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D=false;
			}
		}

		private void CombinatorialChartType_Load(object sender, EventArgs e)
		{
			// Set selection
			comboBoxSeries1.SelectedIndex = 0;		
			comboBoxSeries2.SelectedIndex = 2;
			comboBoxSeries3.SelectedIndex = 0;

			// Populate series data with random data
			Random	random = new Random();
			for(int pointIndex = 0; pointIndex < 10; pointIndex++)
			{
				chart1.Series["Series1"].Points.AddY(random.Next(5, 95));
				chart1.Series["Series2"].Points.AddY(random.Next(5, 95));
				chart1.Series["Series3"].Points.AddY(random.Next(5, 95));
			}

			UpdateChartSettings();
		}

		private void comboBoxSeries1_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxShowMargin_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}
	}
}
