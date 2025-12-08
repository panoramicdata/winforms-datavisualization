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
	/// Summary description for RenkoChartType.
	/// </summary>
	public class RenkoChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxSize;
		private Label label3;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public RenkoChartType()
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
            comboBoxSize = new ComboBox();
            label1 = new Label();
            label3 = new Label();
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
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 37);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;
            series1.CustomProperties = "PriceUpColor=White";
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
            title1.Text = "Renko chart, Box Size 1";
            chart1.Titles.Add(title1);
            chart1.PrePaint += new EventHandler<ChartPaintEventArgs>(chart1_PrePaint);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 21);
            labelSampleComment.TabIndex = 2;
            labelSampleComment.Text = "This sample demonstrates the Renko chart type.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxSize);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 280);
            panel1.TabIndex = 1;
            // 
            // comboBoxSize
            // 
            comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSize.Items.AddRange([
            "0.2",
            "0.5",
            "0.8",
            "1",
            "1.2",
            "1.5",
            "2",
            "Default"]);
            comboBoxSize.Location = new Point(168, 8);
            comboBoxSize.Name = "comboBoxSize";
            comboBoxSize.Size = new Size(104, 22);
            comboBoxSize.TabIndex = 0;
            comboBoxSize.SelectedIndexChanged += new EventHandler(comboBoxSize_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(32, 8);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 0;
            label1.Text = "Box &Size:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label3.Font = new Font("Verdana", 11F);
            label3.Location = new Point(13, 338);
            label3.Name = "label3";
            label3.Size = new Size(702, 24);
            label3.TabIndex = 24;
            label3.Text = "Note that you can retrieve the automatically calculated default box size only in " +
                "the PrePaint event.";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RenkoChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "RenkoChartType";
            Size = new Size(728, 480);
            Load += new EventHandler(RenkoChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion


		private void UpdateChartSettings()
		{
			
			string boxSize = comboBoxSize.Text;

			// set series type
			chart1.Series["Default"].ChartType = SeriesChartType.Renko;

			// set the PriceUpColor attribute			
			chart1.Series["Default"]["PriceUpColor"] = "White";

			// set the default color
			chart1.Series["Default"].Color = Color.Black;

			if ( boxSize == "Default")
			{
				// clear attribute, let the default BoxSize to be calculated
				chart1.Series["Default"].DeleteCustomProperty("BoxSize");
			}
			else
			{
				// set the BoxSize attribute
				chart1.Series["Default"]["BoxSize"] = boxSize;
			}
			
		}

		private void RenkoChartType_Load(object sender, EventArgs e)
		{

			comboBoxSize.Text = "1";
			

			// load series data
			FillData();	
			
			// set up appearance
			UpdateChartSettings();
		}

		private void FillData() 
		{
			double[] points = [	  47.625,47.750,47.500,46.125,45.125,45.250,44.500,45.000,45.250,44.875,44.250,43.375,42.500,42.750,
								  42.000,41.375,40.000,39.875,40.125,41.250,42.250,42.625,43.375,45.250,47.500,47.625,46.500,46.125,
								  46.250,45.750,45.125,45.250,43.500,43.625,44.125,43.750,44.000,44.875,44.625,45.250,45.250,45.250,
								  45.125,45.500,45.625,45.500,45.625,45.000,44.750,44.875,45.250,45.250,45.125,45.125,45.625,45.500,
								  45.375,46.500,47.000,46.125,45.125,45.375,45.875,45.250,45.250,44.625,45.125,45.250,46.125,46.750];

			DateTime date   = DateTime.Today.AddDays( -points.Length);
			
			chart1.Series["Default"].Points.Clear();
			
			for( int day = 0; day < points.Length; day++) 
			{
				chart1.Series["Default"].Points.AddXY( date.AddDays( day), points[day]);
			}
		}

		private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboPriceUpColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void chart1_PrePaint(object sender, ChartPaintEventArgs e)
		{
			// read the calculated Box Size - CurrentBoxSize attribute
			string calculatedBoxSize = chart1.Series["Default"]["CurrentBoxSize"].ToString();
			// update chart title
			chart1.Titles[0].Text = "Renko chart, Box Size = " + calculatedBoxSize;
		}
	}
}
