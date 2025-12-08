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
	/// Summary description for FastLineChartType.
	/// </summary>
	public class FastLineChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Button buttonAddPoints;
		private Label label2;
		private ComboBox comboBoxChartType;
		private Label label1;
        private Label label3;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public FastLineChartType()
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
			Title title1 = new Title();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(FastLineChartType));
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            comboBoxChartType = new ComboBox();
            label1 = new Label();
            buttonAddPoints = new Button();
            label2 = new Label();
            label3 = new Label();
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
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScrollBar.Size = 10;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisY.ScrollBar.Size = 10;
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 58);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.Black;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.ShadowColor = System.Drawing.Color.Black;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 0;
            title1.Font = new Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Two series with 20000 points each";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 45);
            labelSampleComment.TabIndex = 2;
            labelSampleComment.Text = "The Fast Line and Fast Point chart types significantly reduce the drawing time of" +
                " a series that has many data points. ";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxChartType);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonAddPoints);
            panel1.Location = new Point(432, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 1;
            // 
            // comboBoxChartType
            // 
            comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxChartType.Items.AddRange([
            "Fast Line",
            "Fast Point"]);
            comboBoxChartType.Location = new Point(184, 8);
            comboBoxChartType.Name = "comboBoxChartType";
            comboBoxChartType.Size = new Size(104, 22);
            comboBoxChartType.TabIndex = 3;
            comboBoxChartType.SelectedIndexChanged += new EventHandler(comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(51, 8);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 2;
            label1.Text = "Chart &Type:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAddPoints
            // 
            buttonAddPoints.BackColor = System.Drawing.SystemColors.Control;
            buttonAddPoints.Location = new Point(104, 48);
            buttonAddPoints.Name = "buttonAddPoints";
            buttonAddPoints.Size = new Size(184, 23);
            buttonAddPoints.TabIndex = 1;
            buttonAddPoints.Text = "&Add 1000 Data Points";
            buttonAddPoints.UseVisualStyleBackColor = false;
            buttonAddPoints.Click += new EventHandler(buttonAddPoints_Click);
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(16, 362);
            label2.Name = "label2";
            label2.Size = new Size(702, 72);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new Point(16, 435);
            label3.Name = "label3";
            label3.Size = new Size(702, 27);
            label3.TabIndex = 4;
            label3.Text = "To further enhance performance, disable tooltips, anti-aliasing, and border skins" +
                ".";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FastLineChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "FastLineChartType";
            Size = new Size(728, 511);
            Load += new EventHandler(PieChartType_Load);
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
				series.ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), comboBoxChartType.Text.Replace(" ", "") );
			}

		}

		private void PieChartType_Load(object sender, EventArgs e)
		{
			comboBoxChartType.SelectedIndex = 0;
			AddPoints(20000);
			UpdateChartSettings();	
		}

		private void buttonAddPoints_Click(object sender, EventArgs e)
		{
			AddPoints(1000);
			chart1.Titles[0].Text = "Two series with " + chart1.Series["Series1"].Points.Count + " points each";
			chart1.Invalidate();
		}

		private void AddPoints(int pointCount)
		{
			// Fill series data
			double yValue = 50.0;
			double yValue2 = 200.0;
			if(chart1.Series["Series1"].Points.Count > 0)
			{
				yValue = chart1.Series["Series1"].Points[chart1.Series["Series1"].Points.Count - 1].YValues[0];
				yValue2 = chart1.Series["Series2"].Points[chart1.Series["Series1"].Points.Count - 1].YValues[0];
			}
			Random random = new Random();
			for(int pointIndex = 0; pointIndex < pointCount; pointIndex ++)
			{
				yValue = yValue + (float)( random.NextDouble( ) * 10.0 - 5.0  );
				chart1.Series["Series1"].Points.AddY(yValue);

				yValue2 = yValue2 + (float)( random.NextDouble( ) * 10.0 - 5.0  );
				chart1.Series["Series2"].Points.AddY(yValue2);
			}
		}

		private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}
	}
}
