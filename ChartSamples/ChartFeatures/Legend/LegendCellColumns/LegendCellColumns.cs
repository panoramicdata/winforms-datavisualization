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
	/// Summary description for LegendCellColumns.
	/// </summary>
	public class LegendCellColumns : UserControl
	{
		#region Fields

		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private CheckBox chk_showTotal;
		private CheckBox chk_showAvg;
		
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		LegendCellColumn avgColumn = new LegendCellColumn();
		LegendCellColumn totalColumn = new LegendCellColumn();
		private CheckBox checkBox1;
		private Button button1;
		LegendCellColumn minColumn = new LegendCellColumn();
		Random random = new Random();

		#endregion

		# region Constructor

		public LegendCellColumns()
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

		#endregion

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ChartArea chartArea1 = new ChartArea();
			AxisScaleBreakStyle axisScaleBreakStyle1 = new AxisScaleBreakStyle();
			AxisScaleBreakStyle axisScaleBreakStyle2 = new AxisScaleBreakStyle();
			AxisScaleBreakStyle axisScaleBreakStyle3 = new AxisScaleBreakStyle();
			AxisScaleBreakStyle axisScaleBreakStyle4 = new AxisScaleBreakStyle();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(1, 3);
			DataPoint dataPoint2 = new DataPoint(2, 5);
			DataPoint dataPoint3 = new DataPoint(3, 6);
			DataPoint dataPoint4 = new DataPoint(4, 7);
			DataPoint dataPoint5 = new DataPoint(5, 8);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(1, 8);
			DataPoint dataPoint7 = new DataPoint(2, 7);
			DataPoint dataPoint8 = new DataPoint(3, 2);
			DataPoint dataPoint9 = new DataPoint(4, 6);
			DataPoint dataPoint10 = new DataPoint(5, 3);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(1, 4);
			DataPoint dataPoint12 = new DataPoint(2, 7);
			DataPoint dataPoint13 = new DataPoint(3, 9);
			DataPoint dataPoint14 = new DataPoint(4, 12);
			DataPoint dataPoint15 = new DataPoint(5, 3);
			Series series4 = new Series();
			DataPoint dataPoint16 = new DataPoint(1, 7.1999998092651367);
			DataPoint dataPoint17 = new DataPoint(2, 8);
			DataPoint dataPoint18 = new DataPoint(3, 8);
			DataPoint dataPoint19 = new DataPoint(4, 9);
			DataPoint dataPoint20 = new DataPoint(5, 9);
			label9 = new Label();
			panel1 = new Panel();
			button1 = new Button();
			checkBox1 = new CheckBox();
			chk_showAvg = new CheckBox();
			chk_showTotal = new CheckBox();
			Chart1 = new Chart();
			panel1.SuspendLayout();
			((ISupportInitialize)(Chart1)).BeginInit();
			SuspendLayout();
			// 
			// label9
			// 
			label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			label9.Location = new Point(16, 16);
			label9.Name = "label9";
			label9.Size = new Size(702, 34);
			label9.TabIndex = 0;
			label9.Text = "This sample demonstrates how to work with cell columns to create multi-column leg" +
				"ends.";
			label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 button1,
																				 checkBox1,
																				 chk_showAvg,
																				 chk_showTotal]);
			panel1.Location = new Point(432, 64);
			panel1.Name = "panel1";
			panel1.Size = new Size(292, 296);
			panel1.TabIndex = 0;
			// 
			// button1
			// 
			button1.BackColor = System.Drawing.SystemColors.Control;
			button1.Location = new Point(88, 120);
			button1.Name = "button1";
			button1.Size = new Size(168, 23);
			button1.TabIndex = 10;
			button1.Text = "Generate Random Data";
			button1.Click += new EventHandler(button1_Click);
			// 
			// checkBox1
			// 
			checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			checkBox1.Checked = true;
			checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			checkBox1.Location = new Point(14, 80);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(168, 24);
			checkBox1.TabIndex = 9;
			checkBox1.Text = "Show &Minimum:";
			checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
			// 
			// chk_showAvg
			// 
			chk_showAvg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			chk_showAvg.Checked = true;
			chk_showAvg.CheckState = System.Windows.Forms.CheckState.Checked;
			chk_showAvg.Location = new Point(13, 12);
			chk_showAvg.Name = "chk_showAvg";
			chk_showAvg.Size = new Size(168, 24);
			chk_showAvg.TabIndex = 8;
			chk_showAvg.Text = "Show &Average:";
			chk_showAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			chk_showAvg.CheckedChanged += new EventHandler(chk_showAvg_CheckedChanged);
			// 
			// chk_showTotal
			// 
			chk_showTotal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			chk_showTotal.Checked = true;
			chk_showTotal.CheckState = System.Windows.Forms.CheckState.Checked;
			chk_showTotal.Location = new Point(14, 47);
			chk_showTotal.Name = "chk_showTotal";
			chk_showTotal.Size = new Size(168, 24);
			chk_showTotal.TabIndex = 7;
			chk_showTotal.Text = "Show &Total:";
			chk_showTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			chk_showTotal.CheckedChanged += new EventHandler(chk_showTotal_CheckedChanged);
			// 
			// Chart1
			// 
			Chart1.BackColor = System.Drawing.Color.WhiteSmoke;
			Chart1.BackSecondaryColor = System.Drawing.Color.White;
			Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			Chart1.BorderlineWidth = 2;
			Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Enable3D = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.PointGapDepth = 0;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LabelStyle.Interval = 1;
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.Interval = 1;
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorTickMark.Enabled = false;
			chartArea1.AxisX.MajorTickMark.Interval = 1;
			axisScaleBreakStyle1.Enabled = false;
			chartArea1.AxisX.ScaleBreakStyle = axisScaleBreakStyle1;
			axisScaleBreakStyle2.Enabled = false;
			chartArea1.AxisX2.ScaleBreakStyle = axisScaleBreakStyle2;
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorTickMark.Enabled = false;
			axisScaleBreakStyle3.Enabled = false;
			chartArea1.AxisY.ScaleBreakStyle = axisScaleBreakStyle3;
			axisScaleBreakStyle4.Enabled = false;
			chartArea1.AxisY2.ScaleBreakStyle = axisScaleBreakStyle4;
			chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			Chart1.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Center;
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.Font = new Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
			legend1.TitleFont = new Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			Chart1.Legends.Add(legend1);
			Chart1.Location = new Point(16, 64);
			Chart1.Name = "Chart1";
			Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
            series1.ChartType = SeriesChartType.StackedArea;
			series1.Color = System.Drawing.Color.FromArgb(((System.Byte)(5)), ((System.Byte)(100)), ((System.Byte)(146)));
			series1.CustomProperties = "DrawingStyle=Cylinder, StackGroupName=Group1";
			series1.Name = "Bob";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
            series2.ChartType = SeriesChartType.StackedArea;
			series2.Color = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(180)), ((System.Byte)(65)));
			series2.CustomProperties = "DrawingStyle=Cylinder, StackGroupName=Group2";
			series2.Name = "John";
			series2.Points.Add(dataPoint6);
			series2.Points.Add(dataPoint7);
			series2.Points.Add(dataPoint8);
			series2.Points.Add(dataPoint9);
			series2.Points.Add(dataPoint10);
			series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series3.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
            series3.ChartType = SeriesChartType.StackedArea;
			series3.Color = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(64)), ((System.Byte)(10)));
			series3.CustomProperties = "DrawingStyle=Cylinder, StackGroupName=Group2";
			series3.Name = "Nehra";
			series3.Points.Add(dataPoint11);
			series3.Points.Add(dataPoint12);
			series3.Points.Add(dataPoint13);
			series3.Points.Add(dataPoint14);
			series3.Points.Add(dataPoint15);
			series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series4.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
            series4.ChartType = SeriesChartType.StackedArea;
			series4.Color = System.Drawing.Color.FromArgb(((System.Byte)(65)), ((System.Byte)(140)), ((System.Byte)(240)));
			series4.CustomProperties = "DrawingStyle=Cylinder, StackGroupName=Group1";
			series4.Name = "Mike";
			series4.Points.Add(dataPoint16);
			series4.Points.Add(dataPoint17);
			series4.Points.Add(dataPoint18);
			series4.Points.Add(dataPoint19);
			series4.Points.Add(dataPoint20);
			series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			Chart1.Series.Add(series1);
			Chart1.Series.Add(series2);
			Chart1.Series.Add(series3);
			Chart1.Series.Add(series4);
			Chart1.Size = new Size(412, 296);
			Chart1.TabIndex = 1;
			Chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
			// 
			// LegendCellColumns
			// 
			Controls.AddRange([
																		  Chart1,
																		  panel1,
																		  label9]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "LegendCellColumns";
			Size = new Size(728, 480);
			Load += new EventHandler(LegendCellColumns_Load);
			panel1.ResumeLayout(false);
			((ISupportInitialize)(Chart1)).EndInit();
			ResumeLayout(false);

		}
		#endregion

		#region Methods

		private void InitializeCellColumns() 
		{
			// Add first cell column
			LegendCellColumn firstColumn = new LegendCellColumn();
			firstColumn.ColumnType = LegendCellColumnType.SeriesSymbol;
			firstColumn.HeaderText = "Color";
			firstColumn.HeaderBackColor = Color.WhiteSmoke;
			Chart1.Legends["Default"].CellColumns.Add(firstColumn);

			// Add second cell column
			LegendCellColumn secondColumn = new LegendCellColumn();
			secondColumn.ColumnType = LegendCellColumnType.Text;
			secondColumn.HeaderText = "Name";
			secondColumn.Text = "#LEGENDTEXT";
			secondColumn.HeaderBackColor = Color.WhiteSmoke;
			Chart1.Legends["Default"].CellColumns.Add(secondColumn);

			// Add header separator of type line
			Chart1.Legends["Default"].HeaderSeparator = LegendSeparatorStyle.Line;
			Chart1.Legends["Default"].HeaderSeparatorColor = Color.FromArgb(64,64,64,64);
			
			// Add item column separator of type line
			Chart1.Legends["Default"].ItemColumnSeparator = LegendSeparatorStyle.Line;
			Chart1.Legends["Default"].ItemColumnSeparatorColor = Color.FromArgb(64,64,64,64);

			// Set AVG cell column attributes
			avgColumn.Text = "#AVG{N2}";
			avgColumn.HeaderText = "Avg";
			avgColumn.Name = "AvgColumn";
			avgColumn.HeaderBackColor = Color.WhiteSmoke;

			Chart1.Legends["Default"].CellColumns.Add(avgColumn);
			
			// Set Total cell column attributes
			totalColumn.Text = "#TOTAL{N1}";
			totalColumn.HeaderText = "Total";
			totalColumn.Name = "TotalColumn";
			totalColumn.HeaderBackColor = Color.WhiteSmoke;

			Chart1.Legends["Default"].CellColumns.Add(totalColumn);

			// Set Min cell column attributes
			minColumn.Text = "#MIN{N1}";
			minColumn.HeaderText = "Min";
			minColumn.Name = "MinColumn";
			minColumn.HeaderBackColor = Color.WhiteSmoke;

			Chart1.Legends["Default"].CellColumns.Add(minColumn);
		}

		// Fill chart data
		public void FillData(Chart chart, string seriesName) 
		{		
			double yValue = 10;
			for(int pointIndex = 0; pointIndex < 5; pointIndex++)
			{
				yValue = Math.Abs(yValue + ( random.NextDouble() * 10.0 - 5.0 )); 
				chart.Series[seriesName].Points.AddY(yValue);
			}
		}

		#endregion

		#region UI Handlers

		private void LegendCellColumns_Load(object sender, EventArgs e)
		{			
			// Set up the default appearance of the legend
			InitializeCellColumns();
		}

		private void chk_showAvg_CheckedChanged(object sender, EventArgs e)
		{
			if (chk_showAvg.Checked) 
			{
				Chart1.Legends["Default"].CellColumns.Add(avgColumn);		
			}

			else 
			{
				LegendCellColumn cellColumn = Chart1.Legends["Default"].CellColumns.FindByName("AvgColumn");
				Chart1.Legends["Default"].CellColumns.Remove(cellColumn);
			}		
		}

		private void chk_showTotal_CheckedChanged(object sender, EventArgs e)
		{
			if (chk_showTotal.Checked) 
			{
				Chart1.Legends["Default"].CellColumns.Add(totalColumn);		
			}

			else 
			{
				LegendCellColumn cellColumn = Chart1.Legends["Default"].CellColumns.FindByName("TotalColumn");
				Chart1.Legends["Default"].CellColumns.Remove(cellColumn);
			}			
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked) 
			{
				Chart1.Legends["Default"].CellColumns.Add(minColumn);		
			}

			else 
			{
				LegendCellColumn minColumn = Chart1.Legends["Default"].CellColumns.FindByName("MinColumn");
				Chart1.Legends["Default"].CellColumns.Remove(minColumn);
			}	
		}

		private void button1_Click(object sender, EventArgs e)
		{
			foreach(Series series in Chart1.Series) 
			{
				series.Points.Clear();	
				string seriesName = series.Name;
				FillData(Chart1,seriesName);
			}

			Chart1.ResetAutoValues();
			Chart1.Invalidate();
		}

		
		#endregion

	}
}