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
	/// Summary description for PointAndFigureChartType.
	/// </summary>
	public class PointAndFigureChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxSize;
		private Label label2;
		private ComboBox comboReversalAmount;
		private CheckBox checkPropSymbols;
		private Label label3;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public PointAndFigureChartType()
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
            checkPropSymbols = new CheckBox();
            comboBoxSize = new ComboBox();
            label2 = new Label();
            comboReversalAmount = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
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
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.PointAndFigure;
            series1.CustomProperties = "PriceUpColor=Black";
            series1.IsXValueIndexed = true;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Point and Figure Chart";
            chart1.Titles.Add(title1);
            chart1.Click += new EventHandler(chart1_Click);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 24);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates the Point and Figure chart type.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkPropSymbols);
            panel1.Controls.Add(comboBoxSize);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboReversalAmount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            // 
            // checkPropSymbols
            // 
            checkPropSymbols.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkPropSymbols.Location = new Point(5, 72);
            checkPropSymbols.Name = "checkPropSymbols";
            checkPropSymbols.RightToLeft = System.Windows.Forms.RightToLeft.No;
            checkPropSymbols.Size = new Size(176, 24);
            checkPropSymbols.TabIndex = 4;
            checkPropSymbols.Text = "&Proportional Symbols:";
            checkPropSymbols.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkPropSymbols.CheckedChanged += new EventHandler(checkPropSymbols_CheckedChanged);
            // 
            // comboBoxSize
            // 
            comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSize.Items.AddRange([
            "1",
            "1.2",
            "7%",
            "8%",
            "9%",
            "Default"]);
            comboBoxSize.Location = new Point(168, 8);
            comboBoxSize.Name = "comboBoxSize";
            comboBoxSize.Size = new Size(88, 22);
            comboBoxSize.TabIndex = 1;
            comboBoxSize.SelectedIndexChanged += new EventHandler(comboBoxSize_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(59, 8);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 0;
            label2.Text = "Box &Size:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboReversalAmount
            // 
            comboReversalAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboReversalAmount.Items.AddRange([
            "1",
            "2",
            "3",
            "4",
            "5"]);
            comboReversalAmount.Location = new Point(168, 40);
            comboReversalAmount.Name = "comboReversalAmount";
            comboReversalAmount.Size = new Size(88, 22);
            comboReversalAmount.TabIndex = 3;
            comboReversalAmount.SelectedIndexChanged += new EventHandler(comboReversalAmount_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(27, 40);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 2;
            label1.Text = "Reversal &Amount:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label3.Font = new Font("Verdana", 11F);
            label3.Location = new Point(13, 344);
            label3.Name = "label3";
            label3.Size = new Size(702, 40);
            label3.TabIndex = 23;
            label3.Text = "The ProportionalSymbols custom attribute indicates that the chart should try to d" +
                "raw ‘X’ and ‘O’ symbols proportionally.";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PointAndFigureChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PointAndFigureChartType";
            Size = new Size(728, 480);
            Load += new EventHandler(PointAndFigureChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion


		private void UpdateChartSettings()
		{
			
			string reversalAmount = comboReversalAmount.Text;
			string boxSize		  = comboBoxSize.Text;
			string propSymbols    = checkPropSymbols.Checked.ToString();

			// set series type
			chart1.Series["Default"].ChartType = SeriesChartType.PointAndFigure;

			// set the PriceUpColor attribute			
			chart1.Series["Default"]["PriceUpColor"] = "Blue";
			
			// set the Color attribute			
			chart1.Series["Default"].Color = Color.Red;

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
			// set the ProportionalSymbols attribute
			chart1.Series["Default"]["ProportionalSymbols"] = propSymbols;
		}

		private void PointAndFigureChartType_Load(object sender, EventArgs e)
		{

			comboBoxSize.Text = "1";
			comboReversalAmount.Text = "1";
			checkPropSymbols.Checked = false;
			
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
			
			Random rnd = new Random();

			chart1.Series["Default"].Points.Clear();
			
			for( int days = 0; days < points.Length; days++) 
			{
				chart1.Series["Default"].Points.AddXY( date.AddDays( days), points[days] + 0.500, points[days]);

			}
		}

		private void comboReversalAmount_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkPropSymbols_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		
		}

		private void chart1_Click(object sender, EventArgs e)
		{
		
		}
	}
}


