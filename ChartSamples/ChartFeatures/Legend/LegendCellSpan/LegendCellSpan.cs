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
	/// Summary description for LegendCellSpan.
	/// </summary>
	public class LegendCellSpan : UserControl
	{
		private Label label9;
		private Panel panel1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;
		private Chart chart2;

		public LegendCellSpan()
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
			LegendItem legendItem1 = new LegendItem();
			LegendCell legendCell1 = new LegendCell();
			Margins margins1 = new Margins();
			LegendCell legendCell2 = new LegendCell();
			LegendItem legendItem2 = new LegendItem();
			LegendCell legendCell3 = new LegendCell();
			LegendCell legendCell4 = new LegendCell();
			LegendItem legendItem3 = new LegendItem();
			LegendCell legendCell5 = new LegendCell();
			LegendCell legendCell6 = new LegendCell();
			LegendItem legendItem4 = new LegendItem();
			LegendCell legendCell7 = new LegendCell();
			Margins margins2 = new Margins();
			LegendCell legendCell8 = new LegendCell();
			LegendItem legendItem5 = new LegendItem();
			LegendCell legendCell9 = new LegendCell();
			LegendCell legendCell10 = new LegendCell();
			LegendItem legendItem6 = new LegendItem();
			LegendCell legendCell11 = new LegendCell();
			LegendCell legendCell12 = new LegendCell();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(0, 8);
			DataPoint dataPoint2 = new DataPoint(0, 14);
			DataPoint dataPoint3 = new DataPoint(0, 10);
			DataPoint dataPoint4 = new DataPoint(0, 16);
			DataPoint dataPoint5 = new DataPoint(0, 13);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 11);
			DataPoint dataPoint7 = new DataPoint(0, 7);
			DataPoint dataPoint8 = new DataPoint(0, 8);
			DataPoint dataPoint9 = new DataPoint(0, 6);
			DataPoint dataPoint10 = new DataPoint(0, 7);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 4);
			DataPoint dataPoint12 = new DataPoint(0, 3);
			DataPoint dataPoint13 = new DataPoint(0, 6);
			DataPoint dataPoint14 = new DataPoint(0, 5);
			DataPoint dataPoint15 = new DataPoint(0, 3);
			Series series4 = new Series();
			DataPoint dataPoint16 = new DataPoint(0, 5);
			DataPoint dataPoint17 = new DataPoint(0, 6);
			DataPoint dataPoint18 = new DataPoint(0, 14);
			DataPoint dataPoint19 = new DataPoint(0, 8);
			DataPoint dataPoint20 = new DataPoint(0, 9);
			label9 = new Label();
			chart2 = new Chart();
			panel1 = new Panel();
			((ISupportInitialize)(chart2)).BeginInit();
			SuspendLayout();
			// 
			// label9
			// 
			label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			label9.Location = new Point(16, 16);
			label9.Name = "label9";
			label9.Size = new Size(702, 32);
			label9.TabIndex = 0;
			label9.Text = "This sample demonstrates the cell span feature of the legend.";
			label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chart2
			// 
			chart2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(223)), ((System.Byte)(240)));
			chart2.BackSecondaryColor = System.Drawing.Color.White;
			chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chart2.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chart2.BorderlineWidth = 2;
			chart2.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Enable3D = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
			chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LabelStyle.Format = "MMM dd";
			chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.LabelAutoFitMaxFontSize = 7;
			chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(165)), ((System.Byte)(191)), ((System.Byte)(228)));
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			chart2.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Center;
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legendCell1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell1.CellSpan = 2;
			margins1.Bottom = 15;
			margins1.Left = 15;
			margins1.Right = 15;
			legendCell1.Margins = margins1;
			legendCell1.Name = "Cell1";
			legendCell1.Text = "North America";
			legendCell2.Name = "Cell2";
			legendItem1.Cells.Add(legendCell1);
			legendItem1.Cells.Add(legendCell2);
			legendItem1.Name = "North America";
			legendItem2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			legendCell3.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell3.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
			legendCell3.Name = "Cell1";
			legendCell3.SeriesSymbolSize = new Size(200, 50);
			legendCell4.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell4.Name = "Cell2";
			legendCell4.SeriesSymbolSize = new Size(200, 100);
			legendCell4.Text = "Country 1";
			legendItem2.Cells.Add(legendCell3);
			legendItem2.Cells.Add(legendCell4);
			legendItem2.Color = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(65)), ((System.Byte)(140)), ((System.Byte)(240)));
			legendItem2.Name = "LightBlue";
			legendItem3.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			legendCell5.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell5.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
			legendCell5.Name = "Cell1";
			legendCell5.SeriesSymbolSize = new Size(200, 50);
			legendCell6.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell6.Name = "Cell2";
			legendCell6.Text = "Country 2";
			legendItem3.Cells.Add(legendCell5);
			legendItem3.Cells.Add(legendCell6);
			legendItem3.Color = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(252)), ((System.Byte)(180)), ((System.Byte)(65)));
			legendItem3.Name = "Gold";
			legendCell7.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell7.CellSpan = 2;
			legendCell7.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			margins2.Bottom = 15;
			margins2.Left = 15;
			margins2.Right = 15;
			margins2.Top = 200;
			legendCell7.Margins = margins2;
			legendCell7.Name = "Cell1";
			legendCell7.Text = "South America";
			legendCell8.Name = "Cell2";
			legendItem4.Cells.Add(legendCell7);
			legendItem4.Cells.Add(legendCell8);
			legendItem4.Name = "South America";
			legendItem5.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			legendCell9.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell9.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
			legendCell9.Name = "Cell1";
			legendCell9.SeriesSymbolSize = new Size(200, 50);
			legendCell10.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell10.Name = "Cell2";
			legendCell10.Text = "Country 3";
			legendItem5.Cells.Add(legendCell9);
			legendItem5.Cells.Add(legendCell10);
			legendItem5.Color = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(64)), ((System.Byte)(10)));
			legendItem5.Name = "Red";
			legendItem6.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			legendCell11.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell11.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
			legendCell11.Name = "Cell1";
			legendCell11.SeriesSymbolSize = new Size(200, 50);
			legendCell12.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell12.Name = "Cell2";
			legendCell12.Text = "Country 4";
			legendItem6.Cells.Add(legendCell11);
			legendItem6.Cells.Add(legendCell12);
			legendItem6.Color = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			legendItem6.Name = "DarkBlue";
			legend1.CustomItems.Add(legendItem1);
			legend1.CustomItems.Add(legendItem2);
			legend1.CustomItems.Add(legendItem3);
			legend1.CustomItems.Add(legendItem4);
			legend1.CustomItems.Add(legendItem5);
			legend1.CustomItems.Add(legendItem6);
			legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			legend1.TitleFont = new Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			chart2.Legends.Add(legend1);
			chart2.Location = new Point(16, 56);
			chart2.Name = "chart2";
			chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartArea = "Default";
			series1.ChartType = SeriesChartType.StackedBar;
			series1.CustomProperties = "DrawingStyle=Cylinder";
			series1.Name = "B-1";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			series1.IsVisibleInLegend = false;
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series2.ChartArea = "Default";
            series2.ChartType = SeriesChartType.StackedBar;
			series2.CustomProperties = "DrawingStyle=Cylinder";
			series2.Name = "A-1";
			series2.Points.Add(dataPoint6);
			series2.Points.Add(dataPoint7);
			series2.Points.Add(dataPoint8);
			series2.Points.Add(dataPoint9);
			series2.Points.Add(dataPoint10);
			series2.IsVisibleInLegend = false;
			series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series3.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series3.ChartArea = "Default";
			series3.ChartType = SeriesChartType.StackedBar;
			series3.CustomProperties = "DrawingStyle=Cylinder";
			series3.Name = "A-2";
			series3.Points.Add(dataPoint11);
			series3.Points.Add(dataPoint12);
			series3.Points.Add(dataPoint13);
			series3.Points.Add(dataPoint14);
			series3.Points.Add(dataPoint15);
			series3.IsVisibleInLegend = false;
			series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series4.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series4.ChartArea = "Default";
            series4.ChartType = SeriesChartType.StackedBar;
			series4.Color = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series4.CustomProperties = "DrawingStyle=Cylinder";
			series4.Name = "B-2";
			series4.Points.Add(dataPoint16);
			series4.Points.Add(dataPoint17);
			series4.Points.Add(dataPoint18);
			series4.Points.Add(dataPoint19);
			series4.Points.Add(dataPoint20);
			series4.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			series4.IsVisibleInLegend = false;
			series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			chart2.Series.Add(series1);
			chart2.Series.Add(series2);
			chart2.Series.Add(series3);
			chart2.Series.Add(series4);
			chart2.Size = new Size(412, 296);
			chart2.TabIndex = 1;
			// 
			// panel1
			// 
			panel1.Location = new Point(432, 56);
			panel1.Name = "panel1";
			panel1.Size = new Size(292, 296);
			panel1.TabIndex = 2;
			// 
			// LegendCellSpan
			// 
			Controls.AddRange([
																		  panel1,
																		  chart2,
																		  label9]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "LegendCellSpan";
			Size = new Size(728, 392);
			((ISupportInitialize)(chart2)).EndInit();
			ResumeLayout(false);

		}
		#endregion

	}
}
