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
	/// Summary description for MovingAverages.
	/// </summary>
	public class LegendInteractive : UserControl
	{
		private	int		randomSeed = 0;
		private Chart chart1;
		private Label labelSampleComment;
        private Panel panel1;
        private Button buttonRandomData;
        Random rand;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

        public LegendInteractive()
		{
            rand = new Random(randomSeed);


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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(LegendInteractive));
			ChartArea chartArea2 = new ChartArea();
			Legend legend2 = new Legend();
			LegendItem legendItem5 = new LegendItem();
			LegendCell legendCell13 = new LegendCell();
			LegendCell legendCell14 = new LegendCell();
			LegendCell legendCell15 = new LegendCell();
			LegendItem legendItem6 = new LegendItem();
			LegendCell legendCell16 = new LegendCell();
			LegendCell legendCell17 = new LegendCell();
			LegendCell legendCell18 = new LegendCell();
			LegendItem legendItem7 = new LegendItem();
			LegendCell legendCell19 = new LegendCell();
			LegendCell legendCell20 = new LegendCell();
			LegendCell legendCell21 = new LegendCell();
			LegendItem legendItem8 = new LegendItem();
			LegendCell legendCell22 = new LegendCell();
			LegendCell legendCell23 = new LegendCell();
			LegendCell legendCell24 = new LegendCell();
			Series series5 = new Series();
			DataPoint dataPoint121 = new DataPoint(0, 27);
			DataPoint dataPoint122 = new DataPoint(0, -33);
			DataPoint dataPoint123 = new DataPoint(0, -22);
			DataPoint dataPoint124 = new DataPoint(0, 45);
			DataPoint dataPoint125 = new DataPoint(0, 38);
			DataPoint dataPoint126 = new DataPoint(0, -6);
			DataPoint dataPoint127 = new DataPoint(0, -33);
			DataPoint dataPoint128 = new DataPoint(0, -3);
			DataPoint dataPoint129 = new DataPoint(0, 44);
			DataPoint dataPoint130 = new DataPoint(0, -50);
			DataPoint dataPoint131 = new DataPoint(0, -6);
			DataPoint dataPoint132 = new DataPoint(0, 38);
			DataPoint dataPoint133 = new DataPoint(0, 17);
			DataPoint dataPoint134 = new DataPoint(0, -44);
			DataPoint dataPoint135 = new DataPoint(0, -3);
			DataPoint dataPoint136 = new DataPoint(0, 45);
			DataPoint dataPoint137 = new DataPoint(0, -23);
			DataPoint dataPoint138 = new DataPoint(0, -29);
			DataPoint dataPoint139 = new DataPoint(0, 17);
			DataPoint dataPoint140 = new DataPoint(0, -10);
			DataPoint dataPoint141 = new DataPoint(0, -26);
			DataPoint dataPoint142 = new DataPoint(0, 7);
			DataPoint dataPoint143 = new DataPoint(0, -35);
			DataPoint dataPoint144 = new DataPoint(0, 47);
			DataPoint dataPoint145 = new DataPoint(0, 39);
			DataPoint dataPoint146 = new DataPoint(0, -38);
			DataPoint dataPoint147 = new DataPoint(0, 14);
			DataPoint dataPoint148 = new DataPoint(0, -8);
			DataPoint dataPoint149 = new DataPoint(0, -32);
			DataPoint dataPoint150 = new DataPoint(0, 16);
			Series series6 = new Series();
			DataPoint dataPoint151 = new DataPoint(0, 44);
			DataPoint dataPoint152 = new DataPoint(0, -36);
			DataPoint dataPoint153 = new DataPoint(0, -23);
			DataPoint dataPoint154 = new DataPoint(0, 14);
			DataPoint dataPoint155 = new DataPoint(0, -37);
			DataPoint dataPoint156 = new DataPoint(0, 19);
			DataPoint dataPoint157 = new DataPoint(0, -41);
			DataPoint dataPoint158 = new DataPoint(0, 4);
			DataPoint dataPoint159 = new DataPoint(0, -13);
			DataPoint dataPoint160 = new DataPoint(0, -26);
			DataPoint dataPoint161 = new DataPoint(0, -16);
			DataPoint dataPoint162 = new DataPoint(0, -20);
			DataPoint dataPoint163 = new DataPoint(0, -40);
			DataPoint dataPoint164 = new DataPoint(0, -3);
			DataPoint dataPoint165 = new DataPoint(0, -46);
			DataPoint dataPoint166 = new DataPoint(0, 41);
			DataPoint dataPoint167 = new DataPoint(0, 8);
			DataPoint dataPoint168 = new DataPoint(0, -36);
			DataPoint dataPoint169 = new DataPoint(0, -3);
			DataPoint dataPoint170 = new DataPoint(0, 43);
			DataPoint dataPoint171 = new DataPoint(0, 45);
			DataPoint dataPoint172 = new DataPoint(0, 19);
			DataPoint dataPoint173 = new DataPoint(0, -21);
			DataPoint dataPoint174 = new DataPoint(0, 20);
			DataPoint dataPoint175 = new DataPoint(0, 15);
			DataPoint dataPoint176 = new DataPoint(0, -30);
			DataPoint dataPoint177 = new DataPoint(0, -49);
			DataPoint dataPoint178 = new DataPoint(0, -20);
			DataPoint dataPoint179 = new DataPoint(0, -45);
			DataPoint dataPoint180 = new DataPoint(0, 26);
			Series series7 = new Series();
			DataPoint dataPoint181 = new DataPoint(0, 29);
			DataPoint dataPoint182 = new DataPoint(0, 24);
			DataPoint dataPoint183 = new DataPoint(0, -21);
			DataPoint dataPoint184 = new DataPoint(0, -23);
			DataPoint dataPoint185 = new DataPoint(0, -45);
			DataPoint dataPoint186 = new DataPoint(0, -21);
			DataPoint dataPoint187 = new DataPoint(0, 10);
			DataPoint dataPoint188 = new DataPoint(0, -47);
			DataPoint dataPoint189 = new DataPoint(0, 43);
			DataPoint dataPoint190 = new DataPoint(0, 28);
			DataPoint dataPoint191 = new DataPoint(0, 35);
			DataPoint dataPoint192 = new DataPoint(0, 23);
			DataPoint dataPoint193 = new DataPoint(0, 33);
			DataPoint dataPoint194 = new DataPoint(0, -7);
			DataPoint dataPoint195 = new DataPoint(0, -44);
			DataPoint dataPoint196 = new DataPoint(0, 43);
			DataPoint dataPoint197 = new DataPoint(0, -4);
			DataPoint dataPoint198 = new DataPoint(0, 18);
			DataPoint dataPoint199 = new DataPoint(0, 43);
			DataPoint dataPoint200 = new DataPoint(0, 48);
			DataPoint dataPoint201 = new DataPoint(0, 3);
			DataPoint dataPoint202 = new DataPoint(0, 0);
			DataPoint dataPoint203 = new DataPoint(0, 44);
			DataPoint dataPoint204 = new DataPoint(0, -26);
			DataPoint dataPoint205 = new DataPoint(0, 21);
			DataPoint dataPoint206 = new DataPoint(0, -26);
			DataPoint dataPoint207 = new DataPoint(0, 35);
			DataPoint dataPoint208 = new DataPoint(0, 6);
			DataPoint dataPoint209 = new DataPoint(0, 48);
			DataPoint dataPoint210 = new DataPoint(0, 42);
			Series series8 = new Series();
			DataPoint dataPoint211 = new DataPoint(0, 17);
			DataPoint dataPoint212 = new DataPoint(0, 29);
			DataPoint dataPoint213 = new DataPoint(0, -2);
			DataPoint dataPoint214 = new DataPoint(0, 10);
			DataPoint dataPoint215 = new DataPoint(0, -6);
			DataPoint dataPoint216 = new DataPoint(0, 9);
			DataPoint dataPoint217 = new DataPoint(0, -49);
			DataPoint dataPoint218 = new DataPoint(0, 32);
			DataPoint dataPoint219 = new DataPoint(0, -9);
			DataPoint dataPoint220 = new DataPoint(0, 25);
			DataPoint dataPoint221 = new DataPoint(0, -20);
			DataPoint dataPoint222 = new DataPoint(0, 5);
			DataPoint dataPoint223 = new DataPoint(0, -30);
			DataPoint dataPoint224 = new DataPoint(0, 19);
			DataPoint dataPoint225 = new DataPoint(0, -43);
			DataPoint dataPoint226 = new DataPoint(0, -29);
			DataPoint dataPoint227 = new DataPoint(0, 36);
			DataPoint dataPoint228 = new DataPoint(0, 35);
			DataPoint dataPoint229 = new DataPoint(0, 14);
			DataPoint dataPoint230 = new DataPoint(0, 22);
			DataPoint dataPoint231 = new DataPoint(0, 23);
			DataPoint dataPoint232 = new DataPoint(0, -17);
			DataPoint dataPoint233 = new DataPoint(0, -13);
			DataPoint dataPoint234 = new DataPoint(0, -43);
			DataPoint dataPoint235 = new DataPoint(0, -27);
			DataPoint dataPoint236 = new DataPoint(0, -21);
			DataPoint dataPoint237 = new DataPoint(0, 29);
			DataPoint dataPoint238 = new DataPoint(0, -45);
			DataPoint dataPoint239 = new DataPoint(0, 6);
			DataPoint dataPoint240 = new DataPoint(0, 31);
			Title title2 = new Title();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            buttonRandomData = new Button();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.AccessibleDescription = null;
            chart1.AccessibleName = null;
            resources.ApplyResources(chart1, "chart1");
            chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BackSecondaryColor = System.Drawing.Color.White;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.Inclination = 15;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.IsInterlaced = true;
            chartArea2.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LabelStyle.IntervalOffset = 0;
            chartArea2.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.Interval = 0;
            chartArea2.AxisX.MajorGrid.IntervalOffset = 0;
            chartArea2.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorTickMark.Interval = 0;
            chartArea2.AxisX.MajorTickMark.IntervalOffset = 0;
            chartArea2.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX2.LabelStyle.Interval = 0;
            chartArea2.AxisX2.LabelStyle.IntervalOffset = 0;
            chartArea2.AxisX2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX2.MajorGrid.Interval = 0;
            chartArea2.AxisX2.MajorGrid.IntervalOffset = 0;
            chartArea2.AxisX2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX2.MajorTickMark.Interval = 0;
            chartArea2.AxisX2.MajorTickMark.IntervalOffset = 0;
            chartArea2.AxisX2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LabelStyle.Format = "0";
            chartArea2.AxisY.LabelStyle.Interval = 0;
            chartArea2.AxisY.LabelStyle.IntervalOffset = 0;
            chartArea2.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.Interval = 0;
            chartArea2.AxisY.MajorGrid.IntervalOffset = 0;
            chartArea2.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorTickMark.Interval = 0;
            chartArea2.AxisY.MajorTickMark.IntervalOffset = 0;
            chartArea2.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY2.LabelStyle.Interval = 0;
            chartArea2.AxisY2.LabelStyle.IntervalOffset = 0;
            chartArea2.AxisY2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY2.MajorGrid.Interval = 0;
            chartArea2.AxisY2.MajorGrid.IntervalOffset = 0;
            chartArea2.AxisY2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY2.MajorTickMark.Interval = 0;
            chartArea2.AxisY2.MajorTickMark.IntervalOffset = 0;
            chartArea2.AxisY2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "Default";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            legendItem5.BorderColor = System.Drawing.Color.White;
            legendItem5.BorderWidth = 2;
            legendCell13.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.Image;
            legendCell13.ImageTransparentColor = System.Drawing.Color.Red;
            legendCell13.Name = "Cell1";
            legendCell14.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
            legendCell14.Name = "Cell2";
            legendCell15.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            legendCell15.Name = "Cell3";
            legendCell15.Text = "Series 1";
            legendItem5.Cells.Add(legendCell13);
            legendItem5.Cells.Add(legendCell14);
            legendItem5.Cells.Add(legendCell15);
            legendItem5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            legendItem5.Name = "Series 1";
            legendItem6.BorderColor = System.Drawing.Color.White;
            legendItem6.BorderWidth = 2;
            legendCell16.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.Image;
            legendCell16.ImageTransparentColor = System.Drawing.Color.Red;
            legendCell16.Name = "Cell1";
            legendCell17.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
            legendCell17.Name = "Cell2";
            legendCell18.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            legendCell18.Name = "Cell3";
            legendCell18.Text = "Series 2";
            legendItem6.Cells.Add(legendCell16);
            legendItem6.Cells.Add(legendCell17);
            legendItem6.Cells.Add(legendCell18);
            legendItem6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            legendItem6.Name = "Series 2";
            legendItem7.BorderColor = System.Drawing.Color.White;
            legendItem7.BorderWidth = 2;
            legendCell19.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.Image;
            legendCell19.ImageTransparentColor = System.Drawing.Color.Red;
            legendCell19.Name = "Cell1";
            legendCell20.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
            legendCell20.Name = "Cell2";
            legendCell21.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            legendCell21.Name = "Cell3";
            legendCell21.Text = "Series 3";
            legendItem7.Cells.Add(legendCell19);
            legendItem7.Cells.Add(legendCell20);
            legendItem7.Cells.Add(legendCell21);
            legendItem7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            legendItem7.Name = "Series 3";
            legendItem8.BorderColor = System.Drawing.Color.White;
            legendItem8.BorderWidth = 2;
            legendCell22.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.Image;
            legendCell22.ImageTransparentColor = System.Drawing.Color.Red;
            legendCell22.Name = "Cell1";
            legendCell23.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
            legendCell23.Name = "Cell2";
            legendCell24.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            legendCell24.Name = "Cell3";
            legendCell24.Text = "Series 4";
            legendItem8.Cells.Add(legendCell22);
            legendItem8.Cells.Add(legendCell23);
            legendItem8.Cells.Add(legendCell24);
            legendItem8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            legendItem8.Name = "Series 4";
            legend2.CustomItems.Add(legendItem5);
            legend2.CustomItems.Add(legendItem6);
            legend2.CustomItems.Add(legendItem7);
            legend2.CustomItems.Add(legendItem8);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend2.HeaderSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend2.IsTextAutoFit = false;
            legend2.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend2.Name = "Default";
            legend2.TitleSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chart1.Legends.Add(legend2);
            chart1.Name = "chart1";
            series5.ChartArea = "Default";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.CustomProperties = "DrawingStyle=LightToDark";
            series5.IsVisibleInLegend = false;
            series5.Legend = "Default";
            series5.Name = "Series1";
            series5.Points.Add(dataPoint121);
            series5.Points.Add(dataPoint122);
            series5.Points.Add(dataPoint123);
            series5.Points.Add(dataPoint124);
            series5.Points.Add(dataPoint125);
            series5.Points.Add(dataPoint126);
            series5.Points.Add(dataPoint127);
            series5.Points.Add(dataPoint128);
            series5.Points.Add(dataPoint129);
            series5.Points.Add(dataPoint130);
            series5.Points.Add(dataPoint131);
            series5.Points.Add(dataPoint132);
            series5.Points.Add(dataPoint133);
            series5.Points.Add(dataPoint134);
            series5.Points.Add(dataPoint135);
            series5.Points.Add(dataPoint136);
            series5.Points.Add(dataPoint137);
            series5.Points.Add(dataPoint138);
            series5.Points.Add(dataPoint139);
            series5.Points.Add(dataPoint140);
            series5.Points.Add(dataPoint141);
            series5.Points.Add(dataPoint142);
            series5.Points.Add(dataPoint143);
            series5.Points.Add(dataPoint144);
            series5.Points.Add(dataPoint145);
            series5.Points.Add(dataPoint146);
            series5.Points.Add(dataPoint147);
            series5.Points.Add(dataPoint148);
            series5.Points.Add(dataPoint149);
            series5.Points.Add(dataPoint150);
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.ChartArea = "Default";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series6.CustomProperties = "DrawingStyle=LightToDark";
            series6.IsVisibleInLegend = false;
            series6.Legend = "Default";
            series6.MarkerBorderWidth = 2;
            series6.Name = "Series2";
            series6.Points.Add(dataPoint151);
            series6.Points.Add(dataPoint152);
            series6.Points.Add(dataPoint153);
            series6.Points.Add(dataPoint154);
            series6.Points.Add(dataPoint155);
            series6.Points.Add(dataPoint156);
            series6.Points.Add(dataPoint157);
            series6.Points.Add(dataPoint158);
            series6.Points.Add(dataPoint159);
            series6.Points.Add(dataPoint160);
            series6.Points.Add(dataPoint161);
            series6.Points.Add(dataPoint162);
            series6.Points.Add(dataPoint163);
            series6.Points.Add(dataPoint164);
            series6.Points.Add(dataPoint165);
            series6.Points.Add(dataPoint166);
            series6.Points.Add(dataPoint167);
            series6.Points.Add(dataPoint168);
            series6.Points.Add(dataPoint169);
            series6.Points.Add(dataPoint170);
            series6.Points.Add(dataPoint171);
            series6.Points.Add(dataPoint172);
            series6.Points.Add(dataPoint173);
            series6.Points.Add(dataPoint174);
            series6.Points.Add(dataPoint175);
            series6.Points.Add(dataPoint176);
            series6.Points.Add(dataPoint177);
            series6.Points.Add(dataPoint178);
            series6.Points.Add(dataPoint179);
            series6.Points.Add(dataPoint180);
            series7.ChartArea = "Default";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series7.CustomProperties = "DrawingStyle=LightToDark";
            series7.IsVisibleInLegend = false;
            series7.Legend = "Default";
            series7.Name = "Series3";
            series7.Points.Add(dataPoint181);
            series7.Points.Add(dataPoint182);
            series7.Points.Add(dataPoint183);
            series7.Points.Add(dataPoint184);
            series7.Points.Add(dataPoint185);
            series7.Points.Add(dataPoint186);
            series7.Points.Add(dataPoint187);
            series7.Points.Add(dataPoint188);
            series7.Points.Add(dataPoint189);
            series7.Points.Add(dataPoint190);
            series7.Points.Add(dataPoint191);
            series7.Points.Add(dataPoint192);
            series7.Points.Add(dataPoint193);
            series7.Points.Add(dataPoint194);
            series7.Points.Add(dataPoint195);
            series7.Points.Add(dataPoint196);
            series7.Points.Add(dataPoint197);
            series7.Points.Add(dataPoint198);
            series7.Points.Add(dataPoint199);
            series7.Points.Add(dataPoint200);
            series7.Points.Add(dataPoint201);
            series7.Points.Add(dataPoint202);
            series7.Points.Add(dataPoint203);
            series7.Points.Add(dataPoint204);
            series7.Points.Add(dataPoint205);
            series7.Points.Add(dataPoint206);
            series7.Points.Add(dataPoint207);
            series7.Points.Add(dataPoint208);
            series7.Points.Add(dataPoint209);
            series7.Points.Add(dataPoint210);
            series8.ChartArea = "Default";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series8.CustomProperties = "DrawingStyle=LightToDark";
            series8.IsVisibleInLegend = false;
            series8.Legend = "Default";
            series8.Name = "Series4";
            series8.Points.Add(dataPoint211);
            series8.Points.Add(dataPoint212);
            series8.Points.Add(dataPoint213);
            series8.Points.Add(dataPoint214);
            series8.Points.Add(dataPoint215);
            series8.Points.Add(dataPoint216);
            series8.Points.Add(dataPoint217);
            series8.Points.Add(dataPoint218);
            series8.Points.Add(dataPoint219);
            series8.Points.Add(dataPoint220);
            series8.Points.Add(dataPoint221);
            series8.Points.Add(dataPoint222);
            series8.Points.Add(dataPoint223);
            series8.Points.Add(dataPoint224);
            series8.Points.Add(dataPoint225);
            series8.Points.Add(dataPoint226);
            series8.Points.Add(dataPoint227);
            series8.Points.Add(dataPoint228);
            series8.Points.Add(dataPoint229);
            series8.Points.Add(dataPoint230);
            series8.Points.Add(dataPoint231);
            series8.Points.Add(dataPoint232);
            series8.Points.Add(dataPoint233);
            series8.Points.Add(dataPoint234);
            series8.Points.Add(dataPoint235);
            series8.Points.Add(dataPoint236);
            series8.Points.Add(dataPoint237);
            series8.Points.Add(dataPoint238);
            series8.Points.Add(dataPoint239);
            series8.Points.Add(dataPoint240);
            chart1.Series.Add(series5);
            chart1.Series.Add(series6);
            chart1.Series.Add(series7);
            chart1.Series.Add(series8);
            title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title2.Font = new Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.ShadowColor = System.Drawing.Color.Silver;
            title2.ShadowOffset = 2;
            title2.Text = "Interactive Legend";
            chart1.Titles.Add(title2);
            chart1.MouseDown += new MouseEventHandler(chart1_MouseDown);
            // 
            // labelSampleComment
            // 
            labelSampleComment.AccessibleDescription = null;
            labelSampleComment.AccessibleName = null;
            resources.ApplyResources(labelSampleComment, "labelSampleComment");
            labelSampleComment.Name = "labelSampleComment";
            // 
            // panel1
            // 
            panel1.AccessibleDescription = null;
            panel1.AccessibleName = null;
            resources.ApplyResources(panel1, "panel1");
            panel1.BackgroundImage = null;
            panel1.Controls.Add(buttonRandomData);
            panel1.Font = null;
            panel1.Name = "panel1";
            // 
            // buttonRandomData
            // 
            buttonRandomData.AccessibleDescription = null;
            buttonRandomData.AccessibleName = null;
            resources.ApplyResources(buttonRandomData, "buttonRandomData");
            buttonRandomData.BackColor = System.Drawing.SystemColors.Control;
            buttonRandomData.BackgroundImage = null;
            buttonRandomData.Font = null;
            buttonRandomData.Name = "buttonRandomData";
            buttonRandomData.UseVisualStyleBackColor = false;
            buttonRandomData.Click += new EventHandler(buttonRandomData_Click);
            // 
            // LegendInteractive
            // 
            AccessibleDescription = null;
            AccessibleName = null;
            resources.ApplyResources(this, "$this");
            BackColor = System.Drawing.Color.White;
            BackgroundImage = null;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Name = "LegendInteractive";
            Load += new EventHandler(TemplateSampleControl_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void TemplateSampleControl_Load(object sender, EventArgs e)
		{
			// Generate rundom data
            // Generate rundom data
            GenerateRandomData(chart1.Series["Series1"]);
            GenerateRandomData(chart1.Series["Series2"]);
            GenerateRandomData(chart1.Series["Series3"]);
            GenerateRandomData(chart1.Series["Series4"]);

			// Set all cells image transp color to red
			for (int i = 1; i < 4; i++) 
			{
				chart1.Legends["Default"].CustomItems[i].Cells[0].ImageTransparentColor = Color.Red;
			}

			MainForm mainForm = (MainForm)ParentForm;
			
			// Set image for all custom items
			chart1.Legends["Default"].CustomItems[0].Cells[0].Image = mainForm.CurrentSamplePath + @"\chk_checked.png";
			chart1.Legends["Default"].CustomItems[1].Cells[0].Image = mainForm.CurrentSamplePath + @"\chk_checked.png";
			chart1.Legends["Default"].CustomItems[2].Cells[0].Image = mainForm.CurrentSamplePath + @"\chk_checked.png";
			chart1.Legends["Default"].CustomItems[3].Cells[0].Image = mainForm.CurrentSamplePath + @"\chk_checked.png";

			// Set tag property for all custom items to appropriate series
			chart1.Legends["Default"].CustomItems[0].Tag = chart1.Series["Series1"];
            chart1.Legends["Default"].CustomItems[1].Tag = chart1.Series["Series2"];
            chart1.Legends["Default"].CustomItems[2].Tag = chart1.Series["Series3"];
            chart1.Legends["Default"].CustomItems[3].Tag = chart1.Series["Series4"];			
		}

		# region Methods

		// Helper method for setting series appearance
		private void SetSeriesAppearance(string seriesName) 
		{
			chart1.Series[seriesName].ChartArea = "Default";
			chart1.Series[seriesName].ChartType = SeriesChartType.Line;
			chart1.Series[seriesName].BorderWidth = 2;
			chart1.Series[seriesName].ShadowOffset = 1;				
			chart1.Series[seriesName].IsVisibleInLegend = false;
		}

		/// <summary>
		/// This method calculates different Moving Averages.
		/// </summary>
		private void UpdateChart()
		{

			chart1.Invalidate();
		}

		/// <summary>
		/// This method generates random data.
		/// </summary>
		/// <param name="series"></param>
		private void GenerateRandomData( Series series )
		{
			

			// Generate 30 random y values.
			series.Points.Clear();
			for( int index = 0; index < 30; index++ )
			{
				// Generate the first point
				series.Points.AddXY(index+1,0);
				series.Points[index].YValues[0] = 10;

				// Use previous point to calculate a next one.
				if( index > 0 )
				{
					series.Points[index].YValues[0] = series.Points[index-1].YValues[0] + 4*rand.NextDouble() - 2;
				}
			}

			chart1.Invalidate();
		}
		#endregion

		# region UI Event Handlers




		private void buttonRandomData_Click(object sender, EventArgs e)
		{
			Random rand = new Random();
			randomSeed = rand.Next();

			// Generate rundom data
			GenerateRandomData(chart1.Series["Series1"] );
            GenerateRandomData(chart1.Series["Series2"]);
            GenerateRandomData(chart1.Series["Series3"]);
            GenerateRandomData(chart1.Series["Series4"]);

			// Calculate Moving Averages
			UpdateChart();
		}



		private void chart1_MouseDown(object sender, MouseEventArgs e)
		{
			HitTestResult result = chart1.HitTest(e.X, e.Y);
			if(result != null && result.Object != null)
			{					
				// When user hits the LegendItem
				if (result.Object is LegendItem) 
				{
					// Legend item result
					LegendItem legendItem = (LegendItem)result.Object;
					
					// series item selected
					Series selectedSeries = (Series)legendItem.Tag;

					if (selectedSeries !=null) 
					{

						MainForm mainForm = (MainForm)ParentForm;
			
						if (selectedSeries.Enabled) 
						{
							selectedSeries.Enabled = false;
							legendItem.Cells[0].Image = string.Format(mainForm.CurrentSamplePath + @"\chk_unchecked.png");
							legendItem.Cells[0].ImageTransparentColor = Color.Red;
						}

						else 
						{
							selectedSeries.Enabled = true;
							legendItem.Cells[0].Image = string.Format(mainForm.CurrentSamplePath + @"\chk_checked.png");
							legendItem.Cells[0].ImageTransparentColor = Color.Red;
						}
					}
				}
			}

			#endregion
		}
	}
}
