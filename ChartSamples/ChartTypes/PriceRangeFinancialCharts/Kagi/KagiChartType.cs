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
	/// Summary description for KagiChartType.
	/// </summary>
	public class KagiChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboReversalAmount;
		private Label label2;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public KagiChartType()
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
            comboReversalAmount = new ComboBox();
            label1 = new Label();
            label2 = new Label();
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
            chart1.Location = new Point(16, 35);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Kagi;
            series1.Color = System.Drawing.Color.Tomato;
            series1.CustomProperties = "PriceUpColor=SkyBlue";
            series1.IsXValueIndexed = true;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.ShadowColor = System.Drawing.Color.Black;
            series1.ShadowOffset = 2;
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
            title1.Text = "Kagi Chart";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 21);
            labelSampleComment.TabIndex = 2;
            labelSampleComment.Text = "This sample demonstrates the Kagi chart type.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboReversalAmount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 1;
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            // 
            // comboReversalAmount
            // 
            comboReversalAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboReversalAmount.Items.AddRange([
            "0.6",
            "0.8",
            "1",
            "1.2",
            "1%",
            "2%",
            "4%",
            "Default"]);
            comboReversalAmount.Location = new Point(168, 8);
            comboReversalAmount.Name = "comboReversalAmount";
            comboReversalAmount.Size = new Size(112, 22);
            comboReversalAmount.TabIndex = 0;
            comboReversalAmount.SelectedIndexChanged += new EventHandler(comboReversalAmount_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(16, 8);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 0;
            label1.Text = "Reversal &Amount:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label2.Font = new Font("Verdana", 11F);
            label2.Location = new Point(13, 339);
            label2.Name = "label2";
            label2.Size = new Size(702, 24);
            label2.TabIndex = 22;
            label2.Text = "The reversal amount can be a percentage or a fixed amount.";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KagiChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "KagiChartType";
            Size = new Size(728, 416);
            Load += new EventHandler(KagiChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion


		private void UpdateChartSettings()
		{
			string reversalAmount = comboReversalAmount.Text;

			// set series chart type
			chart1.Series["Default"].ChartType = SeriesChartType.Kagi;

			// set the PriceUpColor attribute			
			chart1.Series["Default"]["PriceUpColor"] = "0, 128, 255";
			chart1.Series["Default"].Color = Color.FromArgb(255,64,64);

			if ( reversalAmount == "Default")
			{
				// clear attribute, let the default ReversalAmount to be calculated
				chart1.Series["Default"].DeleteCustomProperty("ReversalAmount");
			}
			else
			{
				// set the ReversalAmount attribute
				chart1.Series["Default"]["ReversalAmount"] = reversalAmount;
			}

		}

		private void KagiChartType_Load(object sender, EventArgs e)
		{

			comboReversalAmount.Text = "1";

			// load series data
			FillData();	
			
			// set up appearance
			UpdateChartSettings();
		}

		private void FillData() 
		{
			double[] points = [   35.250,37.750,39.000,38.375,37.750,37.750,37.375,36.250,35.750,35.250,36.250,35.250,34.500,
								  35.625,35.500,36.625,36.375,36.250,36.875,37.250,36.875,36.500,37.125,36.375,35.875,36.625,
								  37.125,36.250,37.000,37.250,37.500,38.500,39.500,38.875,38.500,39.000,38.500,38.500,39.000,
								  39.000,40.000,39.875,39.875,38.875,38.500,38.250,38.875,39.375,39.375,39.750,39.500,39.375,
								  38.500,37.750,37.625,37.500,36.500,35.000,36.625,36.000,35.875,35.000,35.250,35.125,35.050];

			DateTime date   = DateTime.Today.AddDays( -points.Length);
			
			chart1.Series["Default"].Points.Clear();
			
			for( int day = 0; day < points.Length; day++) 
			{
				chart1.Series["Default"].Points.AddXY( date.AddDays( day), points[day]);
			}
		}



		private void comboReversalAmount_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		
		}
	}
}
