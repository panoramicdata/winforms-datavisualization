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
	/// Summary description for AxisCrossing.
	/// </summary>
	public class AxisCrossing : UserControl
	{
		private Label label5;
		private Label label7;
		private Label label8;
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private ComboBox CrossingX;
		private ComboBox ChartTypes;
		private ComboBox CrossingY;
		private CheckBox ReverseYCheck;
		private CheckBox ReverseXCheck;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AxisCrossing()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			CrossingY.SelectedIndex = 0;
			CrossingX.SelectedIndex = 0;
			ChartTypes.SelectedIndex = 0;

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
			DataPoint dataPoint1 = new DataPoint(0, 550);
			DataPoint dataPoint2 = new DataPoint(0, 900);
			DataPoint dataPoint3 = new DataPoint(0, 1800);
			DataPoint dataPoint4 = new DataPoint(0, 700);
			DataPoint dataPoint5 = new DataPoint(0, 1500);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 900);
			DataPoint dataPoint7 = new DataPoint(0, 1800);
			DataPoint dataPoint8 = new DataPoint(0, 1400);
			DataPoint dataPoint9 = new DataPoint(0, 1600);
			DataPoint dataPoint10 = new DataPoint(0, 2000);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 1800);
			DataPoint dataPoint12 = new DataPoint(0, 2400);
			DataPoint dataPoint13 = new DataPoint(0, 800);
			DataPoint dataPoint14 = new DataPoint(0, 2200);
			DataPoint dataPoint15 = new DataPoint(0, 550);
			CrossingX = new ComboBox();
			ChartTypes = new ComboBox();
			CrossingY = new ComboBox();
			label5 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			panel1 = new Panel();
			ReverseYCheck = new CheckBox();
			ReverseXCheck = new CheckBox();
			Chart1 = new Chart();
			panel1.SuspendLayout();
			((ISupportInitialize)(Chart1)).BeginInit();
			SuspendLayout();
			// 
			// CrossingX
			// 
			CrossingX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			CrossingX.Items.AddRange([
														   "Auto",
														   "1",
														   "3",
														   "5",
														   "Max",
														   "Min"]);
			CrossingX.Location = new Point(168, 8);
			CrossingX.Name = "CrossingX";
			CrossingX.TabIndex = 4;
			CrossingX.SelectedIndexChanged += new EventHandler(ControlChange);
			// 
			// ChartTypes
			// 
			ChartTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			ChartTypes.Items.AddRange([
															"Column",
															"Bar"]);
			ChartTypes.Location = new Point(168, 72);
			ChartTypes.Name = "ChartTypes";
			ChartTypes.TabIndex = 8;
			ChartTypes.SelectedIndexChanged += new EventHandler(ControlChange);
			// 
			// CrossingY
			// 
			CrossingY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			CrossingY.Items.AddRange([
														   "Auto",
														   "1000",
														   "1500",
														   "2000",
														   "Max",
														   "Min"]);
			CrossingY.Location = new Point(168, 40);
			CrossingY.Name = "CrossingY";
			CrossingY.TabIndex = 6;
			CrossingY.SelectedIndexChanged += new EventHandler(ControlChange);
			// 
			// label5
			// 
			label5.Location = new Point(16, 8);
			label5.Name = "label5";
			label5.Size = new Size(148, 16);
			label5.TabIndex = 3;
			label5.Text = "Crossing &X:";
			label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			label7.Location = new Point(16, 72);
			label7.Name = "label7";
			label7.Size = new Size(148, 16);
			label7.TabIndex = 7;
			label7.Text = "Chart &Type:";
			label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			label8.Location = new Point(16, 40);
			label8.Name = "label8";
			label8.Size = new Size(148, 16);
			label8.TabIndex = 5;
			label8.Text = "Crossing &Y:";
			label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			label9.Location = new Point(16, 8);
			label9.Name = "label9";
			label9.Size = new Size(702, 34);
			label9.TabIndex = 1;
			label9.Text = "This sample demonstrates how to use the Crossing and Reverse properties of an axi" +
				"s.";
			label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 ReverseYCheck,
																				 ReverseXCheck,
																				 label5,
																				 CrossingX,
																				 label7,
																				 label8,
																				 CrossingY,
																				 ChartTypes]);
			panel1.Location = new Point(432, 56);
			panel1.Name = "panel1";
			panel1.Size = new Size(292, 288);
			panel1.TabIndex = 0;
			// 
			// ReverseYCheck
			// 
			ReverseYCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			ReverseYCheck.Location = new Point(14, 136);
			ReverseYCheck.Name = "ReverseYCheck";
			ReverseYCheck.Size = new Size(168, 24);
			ReverseYCheck.TabIndex = 0;
			ReverseYCheck.Text = "R&everse Y Axis:";
			ReverseYCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			ReverseYCheck.CheckedChanged += new EventHandler(ControlChange);
			// 
			// ReverseXCheck
			// 
			ReverseXCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			ReverseXCheck.Location = new Point(14, 104);
			ReverseXCheck.Name = "ReverseXCheck";
			ReverseXCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
			ReverseXCheck.Size = new Size(168, 24);
			ReverseXCheck.TabIndex = 9;
			ReverseXCheck.Text = "&Reverse X Axis:";
			ReverseXCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			ReverseXCheck.CheckedChanged += new EventHandler(ControlChange);
			// 
			// Chart1
			// 
			Chart1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(243)), ((System.Byte)(223)), ((System.Byte)(193)));
			Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(181)), ((System.Byte)(64)), ((System.Byte)(1)));
			Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			Chart1.BorderlineWidth = 2;
			Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LabelStyle.Format = "N0";
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.AxisX2.MajorGrid.Enabled = false;
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.AxisY2.MajorGrid.Enabled = false;
			chartArea1.BackColor = System.Drawing.Color.OldLace;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			Chart1.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Far;
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.Enabled = false;
			legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
			legend1.Name = "Default";
			Chart1.Legends.Add(legend1);
			Chart1.Location = new Point(16, 48);
			Chart1.Name = "Chart1";
			Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.Name = "Default";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series2.Name = "Series2";
			series2.Points.Add(dataPoint6);
			series2.Points.Add(dataPoint7);
			series2.Points.Add(dataPoint8);
			series2.Points.Add(dataPoint9);
			series2.Points.Add(dataPoint10);
			series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series3.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series3.Name = "Series3";
			series3.Points.Add(dataPoint11);
			series3.Points.Add(dataPoint12);
			series3.Points.Add(dataPoint13);
			series3.Points.Add(dataPoint14);
			series3.Points.Add(dataPoint15);
			series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			Chart1.Series.Add(series1);
			Chart1.Series.Add(series2);
			Chart1.Series.Add(series3);
			Chart1.Size = new Size(412, 296);
			Chart1.TabIndex = 2;
			// 
			// AxisCrossing
			// 
			Controls.AddRange([
																		  Chart1,
																		  panel1,
																		  label9]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "AxisCrossing";
			Size = new Size(728, 480);
			panel1.ResumeLayout(false);
			((ISupportInitialize)(Chart1)).EndInit();
			ResumeLayout(false);

		}
		#endregion


		private void AxisCrossing_Load(object sender, EventArgs e)
		{ 
		
		}

		private void ControlChange(object sender, EventArgs e)
		{

			Axis AxisX;
			Axis AxisY;

			AxisX = Chart1.ChartAreas["Default"].AxisX;
			AxisY = Chart1.ChartAreas["Default"].AxisY;

			// Set Crossing value for X axis
			if(CrossingX.SelectedIndex >= 0)
			{
				string sel = CrossingX.SelectedItem.ToString();
				switch (sel)
				{
					case "Auto":
						AxisX.Crossing = Double.NaN;
						break;
					case "Max":
						AxisX.Crossing = Double.MaxValue;
						break;
					case "Min":
						AxisX.Crossing = Double.MinValue;
						break;
					default:
						AxisX.Crossing = Double.Parse( CrossingX.SelectedItem.ToString() );
						break;
				}
			}

			// Set Reverse value for X axis
			AxisX.IsReversed = ReverseXCheck.Checked;

			// Set Crossing value for Y axis
			if(CrossingY.SelectedIndex >= 0)
			{
				string sel = CrossingY.SelectedItem.ToString();

				switch(sel)
				{
					case "Auto":
						AxisY.Crossing = Double.NaN;
						break;
					case "Max":
						AxisY.Crossing = Double.MaxValue;
						break;
					case "Min":
						AxisY.Crossing = Double.MinValue;
						break;
					default:
						AxisY.Crossing = Double.Parse( CrossingY.SelectedItem.ToString() );
						break;
				}
			}

			// Set Reverse value for Y axis
			AxisY.IsReversed = ReverseYCheck.Checked;
			
			foreach( Series series in Chart1.Series)
			{
				if(ChartTypes.SelectedIndex >= 0)
				{
					series.ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), ChartTypes.SelectedItem.ToString(), true );
				}
				else
				{
					series.ChartType = SeriesChartType.Column;
				}
			}


		}

	}
}
