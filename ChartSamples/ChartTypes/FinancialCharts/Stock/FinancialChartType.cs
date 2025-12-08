using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using ChartSamples;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for FinancialChartType.
	/// </summary>
	public class FinancialChartType : UserControl
	{
		private MemoryStream defaultViewStyleStream = new MemoryStream();

		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private Label label2;
		private ComboBox comboBoxMarks;
		private CheckBox checkBoxCloseOnly;
		private ComboBox comboBoxChartType;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public FinancialChartType()
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
			defaultViewStyleStream.Close();

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
			ChartArea chartArea2 = new ChartArea();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			Series series2 = new Series();
			chart1 = new Chart();
			labelSampleComment = new Label();
			panel1 = new Panel();
			checkBoxCloseOnly = new CheckBox();
			comboBoxMarks = new ComboBox();
			label2 = new Label();
			comboBoxChartType = new ComboBox();
			label1 = new Label();
			((ISupportInitialize)(chart1)).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// chart1
			// 
			chart1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(223)), ((System.Byte)(240)));
			chart1.BackSecondaryColor = System.Drawing.Color.White;
			chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chart1.BorderlineWidth = 2;
			chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.IsStartedFromZero = false;
			chartArea1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(165)), ((System.Byte)(191)), ((System.Byte)(228)));
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea1.Name = "Price";
			chartArea1.Position.Auto = false;
			chartArea1.Position.Height = 42F;
			chartArea1.Position.Width = 88F;
			chartArea1.Position.X = 3F;
			chartArea1.Position.Y = 10F;
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			chartArea2.AlignWithChartArea = "Price";
			chartArea2.Area3DStyle.IsClustered = true;
			chartArea2.Area3DStyle.Perspective = 10;
			chartArea2.Area3DStyle.IsRightAngleAxes = false;
			chartArea2.Area3DStyle.WallWidth = 0;
			chartArea2.Area3DStyle.Inclination = 15;
			chartArea2.Area3DStyle.Rotation = 10;
			chartArea2.AxisX.IsLabelAutoFit = false;
			chartArea2.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea2.AxisX.LabelStyle.IsEndLabelVisible = false;
			chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.AxisY.IsLabelAutoFit = false;
			chartArea2.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.AxisY.IsStartedFromZero = false;
			chartArea2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(165)), ((System.Byte)(191)), ((System.Byte)(228)));
			chartArea2.BackSecondaryColor = System.Drawing.Color.White;
			chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea2.Name = "Volume";
			chartArea2.Position.Auto = false;
			chartArea2.Position.Height = 42F;
			chartArea2.Position.Width = 88F;
			chartArea2.Position.X = 3F;
			chartArea2.Position.Y = 51.84195F;
			chartArea2.ShadowColor = System.Drawing.Color.Transparent;
			chart1.ChartAreas.Add(chartArea1);
			chart1.ChartAreas.Add(chartArea2);
			legend1.Alignment = System.Drawing.StringAlignment.Far;
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
			legend1.IsDockedInsideChartArea = false;
			legend1.DockedToChartArea = "Price";
			legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
			legend1.Name = "Default";
			legend1.Position.Auto = false;
			legend1.Position.Height = 7.127659F;
			legend1.Position.Width = 38.19123F;
			legend1.Position.X = 55F;
			legend1.Position.Y = 5F;
			chart1.Legends.Add(legend1);
			chart1.Location = new Point(16, 48);
			chart1.Name = "chart1";
			chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartArea = "Price";
			series1.ChartType = SeriesChartType.Stock;
			series1.Name = "Price";
			series1.IsVisibleInLegend = false;
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series1.YValuesPerPoint = 4;
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series2.ChartArea = "Volume";
			series2.Color = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(64)), ((System.Byte)(10)));
			series2.Name = "Volume";
			series2.IsVisibleInLegend = false;
			series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			chart1.Series.Add(series1);
			chart1.Series.Add(series2);
			chart1.Size = new Size(446, 296);
			chart1.TabIndex = 1;
			// 
			// labelSampleComment
			// 
			labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			labelSampleComment.Location = new Point(16, 8);
			labelSampleComment.Name = "labelSampleComment";
			labelSampleComment.Size = new Size(702, 34);
			labelSampleComment.TabIndex = 0;
			labelSampleComment.Text = "This sample demonstrates the Stock and CandleStick chart types.";
			labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 checkBoxCloseOnly,
																				 comboBoxMarks,
																				 label2,
																				 comboBoxChartType,
																				 label1]);
			panel1.Location = new Point(464, 56);
			panel1.Name = "panel1";
			panel1.Size = new Size(256, 288);
			panel1.TabIndex = 2;
			// 
			// checkBoxCloseOnly
			// 
			checkBoxCloseOnly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			checkBoxCloseOnly.Location = new Point(13, 72);
			checkBoxCloseOnly.Name = "checkBoxCloseOnly";
			checkBoxCloseOnly.Size = new Size(144, 24);
			checkBoxCloseOnly.TabIndex = 4;
			checkBoxCloseOnly.Text = "&Close Price Only:";
			checkBoxCloseOnly.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			checkBoxCloseOnly.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
			// 
			// comboBoxMarks
			// 
			comboBoxMarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxMarks.Items.AddRange([
															   "Line",
															   "Triangle"]);
			comboBoxMarks.Location = new Point(144, 40);
			comboBoxMarks.Name = "comboBoxMarks";
			comboBoxMarks.Size = new Size(112, 22);
			comboBoxMarks.TabIndex = 3;
			comboBoxMarks.SelectedIndexChanged += new EventHandler(comboBoxMarks_SelectedIndexChanged);
			// 
			// label2
			// 
			label2.Location = new Point(10, 40);
			label2.Name = "label2";
			label2.Size = new Size(128, 23);
			label2.TabIndex = 2;
			label2.Text = "&Open Close Marks:";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxChartType
			// 
			comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxChartType.Items.AddRange([
																   "Stock",
																   "CandleStick"]);
			comboBoxChartType.Location = new Point(144, 8);
			comboBoxChartType.Name = "comboBoxChartType";
			comboBoxChartType.Size = new Size(112, 22);
			comboBoxChartType.TabIndex = 1;
			comboBoxChartType.SelectedIndexChanged += new EventHandler(comboBoxMarks_SelectedIndexChanged);
			// 
			// label1
			// 
			label1.Location = new Point(10, 8);
			label1.Name = "label1";
			label1.Size = new Size(128, 23);
			label1.TabIndex = 0;
			label1.Text = "Chart &Type:";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FinancialChartType
			// 
			BackColor = System.Drawing.Color.White;
			Controls.AddRange([
																		  panel1,
																		  labelSampleComment,
																		  chart1]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "FinancialChartType";
			Size = new Size(728, 360);
			Load += new EventHandler(FinancialChartType_Load);
			((ISupportInitialize)(chart1)).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			chart1.BeginInit();

			comboBoxChartType.Enabled = true;
			comboBoxMarks.Enabled = true;
			checkBoxCloseOnly.Enabled = true;

			// Load default settings except of the chart's size
			defaultViewStyleStream.Seek(0, SeekOrigin.Begin);
			chart1.Serializer.SerializableContent = "*.*";
			chart1.Serializer.NonSerializableContent = "*.Size";
			chart1.Serializer.Load(defaultViewStyleStream);

			// Set series chart type
			chart1.Series["Price"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), comboBoxChartType.Text, true );

			// Set stock chart attributes
			if(comboBoxChartType.Text == "Stock")
			{
				comboBoxMarks.Enabled = true;
				checkBoxCloseOnly.Enabled = true;
				chart1.Series["Price"]["OpenCloseStyle"] = comboBoxMarks.Text;
				if(checkBoxCloseOnly.Checked)
				{
					chart1.Series["Price"]["ShowOpenClose"] = "Close";
				}

				chart1.Series["Price"]["PointWidth"] = "1.0";
			}
			else
			{
				chart1.Series["Price"]["PointWidth"] = "0.8";
				comboBoxMarks.Enabled = false;
				checkBoxCloseOnly.Enabled = false;
			}

			chart1.Series["Volume"]["PointWidth"] = "0.5";

			chart1.EndInit();
		}


		private void SetMarkers()
		{
			// Get image path
			MainForm mainForm = (MainForm)ParentForm;
            string imagePath = mainForm.CurrentSamplePath;
			imagePath += "\\";

			// Randomly set dividend and split markers
			Random	random = new Random();
			
			for(int index = 0; index < 2; index ++)
			{
				
				int pointIndex = random.Next(0, chart1.Series["Price"].Points.Count);
				
				chart1.Series["Price"].Points[pointIndex].MarkerImage = imagePath + "DividentLegend.bmp";
				chart1.Series["Price"].Points[pointIndex].MarkerImageTransparentColor = Color.White;
				chart1.Series["Price"].Points[pointIndex].ToolTip = "#VALX{D}\n0.15 - dividend per share";

				pointIndex = random.Next(0, chart1.Series["Price"].Points.Count);
				
				chart1.Series["Price"].Points[pointIndex].MarkerImage = imagePath + "SplitLegend.bmp";

				chart1.Series["Price"].Points[pointIndex].MarkerImageTransparentColor = Color.White;
				chart1.Series["Price"].Points[pointIndex].ToolTip = "#VALX{D}\n2 for 1 split";
			}
		}

		private void FinancialChartType_Load(object sender, EventArgs e)
		{
			// Get image path
			MainForm mainForm = (MainForm) ParentForm;
            string imagePath = mainForm.CurrentSamplePath; 
			imagePath += "\\";

			// Add custom legend items
			LegendItem legendItem = new LegendItem(); 
			legendItem.Name = "Dividend";
			legendItem.ImageStyle = LegendImageStyle.Marker;
			legendItem.MarkerImageTransparentColor = Color.White;
			legendItem.MarkerImage = imagePath + "DividentLegend.bmp";
			chart1.Legends[0].CustomItems.Add(legendItem);

			legendItem = new LegendItem(); 
			legendItem.Name = "Split";
			legendItem.ImageStyle = LegendImageStyle.Marker;
			legendItem.MarkerImageTransparentColor = Color.White;
			legendItem.MarkerImage = imagePath + "SplitLegend.bmp";
            chart1.Legends[0].CustomItems.Add(legendItem);

			// Populate series data
			FillData();
			
			SetMarkers();

			// Save default appearance
			chart1.Serializer.Save(defaultViewStyleStream);

			comboBoxChartType.SelectedIndex = 0;
			comboBoxMarks.SelectedIndex = 0;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void radioButtonCGI_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxMarks_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		/// <summary>
		/// Random Stock Data Generator
		/// </summary>
		private void FillData()
		{
			Random rand;
			// Use a number to calculate a starting value for 
			// the pseudo-random number sequence
			rand = new Random();
			
			// The number of days for stock data
			int period = 60;

			// The first High value
			double high = rand.NextDouble() * 40;

			// The first Close value
			double close = high - rand.NextDouble();

			// The first Low value
			double low = close - rand.NextDouble();

			// The first Open value
			double open = ( high - low ) * rand.NextDouble() + low;

			// The first Volume value
			double volume = 100 + 15 * rand.NextDouble();
						
			// The first day X and Y values
			chart1.Series["Price"].Points.AddXY(DateTime.Parse("1/2/2002"), high);
			chart1.Series["Volume"].Points.AddXY(DateTime.Parse("1/2/2002"), volume);
			chart1.Series["Price"].Points[0].YValues[1] = low;

			// The Open value is not used.
			chart1.Series["Price"].Points[0].YValues[2] = open;
			chart1.Series["Price"].Points[0].YValues[3] = close;
			
			// Days loop
			for( int day = 1; day <= period; day++ )
			{
			
				// Calculate High, Low and Close values
				high = chart1.Series["Price"].Points[day-1].YValues[2]+rand.NextDouble();
				close = high - rand.NextDouble();
				low = close - rand.NextDouble();
				open = ( high - low ) * rand.NextDouble() + low;
				
				// Calculate volume
				volume = chart1.Series["Volume"].Points[day-1].YValues[0] + 10 * rand.NextDouble() - 5;

				// The low cannot be less than yesterday close value.
				if( low > chart1.Series["Price"].Points[day-1].YValues[2])
					low = chart1.Series["Price"].Points[day-1].YValues[2];
							
				// Set data points values
				chart1.Series["Price"].Points.AddXY(day, high);
				chart1.Series["Price"].Points[day].XValue = chart1.Series["Price"].Points[day-1].XValue+1;
				chart1.Series["Price"].Points[day].YValues[1] = low;
				chart1.Series["Price"].Points[day].YValues[2] = open;
				chart1.Series["Price"].Points[day].YValues[3] = close;

				// Set volume values
				chart1.Series["Volume"].Points.AddXY(day, volume);
				chart1.Series["Volume"].Points[day].XValue = chart1.Series["Volume"].Points[day-1].XValue+1;
			}
		}

	}
}
