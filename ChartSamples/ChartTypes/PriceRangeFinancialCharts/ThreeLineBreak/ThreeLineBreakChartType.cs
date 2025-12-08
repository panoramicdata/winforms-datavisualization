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
	/// Summary description for ThreeLineBreakChartType.
	/// </summary>
	public class ThreeLineBreakChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboNumberOfLines;
		private Label label3;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public ThreeLineBreakChartType()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

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
			Title title1 = new Title();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            comboNumberOfLines = new ComboBox();
            label1 = new Label();
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
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "MMM dd";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 40);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak;
            series1.CustomProperties = "PriceUpColor=Black";
            series1.IsXValueIndexed = true;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 0;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Three Line Break Chart";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 26);
            labelSampleComment.TabIndex = 2;
            labelSampleComment.Text = "This sample demonstrates the Three Line Break chart type.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboNumberOfLines);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 280);
            panel1.TabIndex = 1;
            // 
            // comboNumberOfLines
            // 
            comboNumberOfLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboNumberOfLines.Items.AddRange([
            "1",
            "2",
            "3",
            "4",
            "Default"]);
            comboNumberOfLines.Location = new Point(168, 16);
            comboNumberOfLines.Name = "comboNumberOfLines";
            comboNumberOfLines.Size = new Size(104, 22);
            comboNumberOfLines.TabIndex = 0;
            comboNumberOfLines.SelectedIndexChanged += new EventHandler(comboNumberOfLines_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 0;
            label1.Text = "Number of &Lines in Break:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label3.Font = new Font("Verdana", 11F);
            label3.Location = new Point(13, 342);
            label3.Name = "label3";
            label3.Size = new Size(702, 43);
            label3.TabIndex = 25;
            label3.Text = "The sensitivity of the reversal criteria can be adjusted by changing the number o" +
                "f lines in break.";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ThreeLineBreakChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "ThreeLineBreakChartType";
            Size = new Size(728, 403);
            Load += new EventHandler(ThreeLineBreakChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion


		private void UpdateChartSettings()
		{
			
			string numberOfLines = comboNumberOfLines.Text;

			// set series type
			chart1.Series["Default"].ChartType = SeriesChartType.ThreeLineBreak;

			// set the PriceUpColor attribute			
			chart1.Series["Default"]["PriceUpColor"] = "White";

			// set the default color
			chart1.Series["Default"].Color = Color.Black;

			if ( numberOfLines == "Default")
			{
				// clear attribute, let the default NumberOfLinesInBreak to be calculated
				chart1.Series["Default"].DeleteCustomProperty("NumberOfLinesInBreak");
			}
			else
			{
				// set the NumberOfLinesInBreak attribute
				chart1.Series["Default"]["NumberOfLinesInBreak"] = numberOfLines;
			}
			
		}

		private void ThreeLineBreakChartType_Load(object sender, EventArgs e)
		{

			comboNumberOfLines.Text = "1";
			
			// load series data
			FillData();	
			
			// set up appearance
			UpdateChartSettings();
		}

		private void FillData() 
		{
			double[] points = [   27.375,26.375,26.062,25.750,26.125,25.875,25.750,25.250,24.375,24.000, 
								  23.625,23.875,26.500,26.750,27.375,27.375,26.825,27.000,26.875,26.625,
								  27.627,28.000,27.125,25.875,27.250,25.500,24.875,24.875,24.125,25.000,
								  26.250,27.375,27.500,28.000,27.625,27.125,26.250,26.250,26.250,26.375,
								  26.625,27.375,28.500,27.250,26.250,26.500,26.125,25.750,26.000,26.625,
								  26.125,26.250,25.750,25.375,25.375,24.750,23.500,24.062,23.250,23.500,24.125,24.625,24.625];

			DateTime date   = DateTime.Today.AddDays( -points.Length);
			
			chart1.Series["Default"].Points.Clear();
			
			for( int day = 0; day < points.Length; day++) 
			{
				chart1.Series["Default"].Points.AddXY( date.AddDays( day), points[day]);
			}
		}

		private void comboNumberOfLines_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}
	}
}
