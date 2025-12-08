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
	/// Summary description for LegendStylePosition.
	/// </summary>
	public class LegendStylePosition : UserControl
	{
		private Label label5;
		private Label label7;
		private Label label8;
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private ComboBox TheStyle;
		private ComboBox TheDocking;
		private ComboBox TheAlignment;
		private CheckBox DisableCheck;
		private CheckBox InsideCheck;
		private Label label1;
		private ComboBox TheTableStyle;
		private CheckBox cb_Reversed;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public LegendStylePosition()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Add Border styles to control.
			foreach(string styleName in Enum.GetNames(typeof(LegendStyle)))
			{
				TheStyle.Items.Add(styleName);
			}
			TheStyle.SelectedIndex = 2;

			foreach(string dockName in Enum.GetNames(typeof(Docking)))
			{
				TheDocking.Items.Add(dockName);
			}
			TheDocking.SelectedIndex = 1;
						
			foreach(string alignName in Enum.GetNames(typeof(StringAlignment)))
			{
				TheAlignment.Items.Add(alignName);
			}
			TheAlignment.SelectedIndex = 0;

			TheTableStyle.SelectedIndex = 0;	
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
			AxisScaleBreakStyle axisScaleBreakStyle1 = new AxisScaleBreakStyle();
			AxisScaleBreakStyle axisScaleBreakStyle2 = new AxisScaleBreakStyle();
			AxisScaleBreakStyle axisScaleBreakStyle3 = new AxisScaleBreakStyle();
			AxisScaleBreakStyle axisScaleBreakStyle4 = new AxisScaleBreakStyle();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(0, 300);
			DataPoint dataPoint2 = new DataPoint(0, 400);
			DataPoint dataPoint3 = new DataPoint(0, 200);
			DataPoint dataPoint4 = new DataPoint(0, 450);
			DataPoint dataPoint5 = new DataPoint(0, 700);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 100);
			DataPoint dataPoint7 = new DataPoint(0, 340);
			DataPoint dataPoint8 = new DataPoint(0, 420);
			DataPoint dataPoint9 = new DataPoint(0, 770);
			DataPoint dataPoint10 = new DataPoint(0, 790);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 75);
			DataPoint dataPoint12 = new DataPoint(0, 300);
			DataPoint dataPoint13 = new DataPoint(0, 400);
			DataPoint dataPoint14 = new DataPoint(0, 550);
			DataPoint dataPoint15 = new DataPoint(0, 630);
			Series series4 = new Series();
			DataPoint dataPoint16 = new DataPoint(0, 120);
			DataPoint dataPoint17 = new DataPoint(0, 360);
			DataPoint dataPoint18 = new DataPoint(0, 410);
			DataPoint dataPoint19 = new DataPoint(0, 520);
			DataPoint dataPoint20 = new DataPoint(0, 560);
			TheStyle = new ComboBox();
			TheAlignment = new ComboBox();
			TheDocking = new ComboBox();
			label5 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			panel1 = new Panel();
			cb_Reversed = new CheckBox();
			label1 = new Label();
			TheTableStyle = new ComboBox();
			DisableCheck = new CheckBox();
			InsideCheck = new CheckBox();
			Chart1 = new Chart();
			panel1.SuspendLayout();
			((ISupportInitialize)(Chart1)).BeginInit();
			SuspendLayout();
			// 
			// TheStyle
			// 
			TheStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			TheStyle.Location = new Point(168, 8);
			TheStyle.Name = "TheStyle";
			TheStyle.TabIndex = 1;
			TheStyle.SelectedIndexChanged += new EventHandler(ControlChange);
			// 
			// TheAlignment
			// 
			TheAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			TheAlignment.Location = new Point(168, 104);
			TheAlignment.Name = "TheAlignment";
			TheAlignment.TabIndex = 5;
			TheAlignment.SelectedIndexChanged += new EventHandler(ControlChange);
			// 
			// TheDocking
			// 
			TheDocking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			TheDocking.Location = new Point(168, 72);
			TheDocking.Name = "TheDocking";
			TheDocking.TabIndex = 3;
			TheDocking.SelectedIndexChanged += new EventHandler(ControlChange);
			// 
			// label5
			// 
			label5.Location = new Point(15, 11);
			label5.Name = "label5";
			label5.Size = new Size(148, 16);
			label5.TabIndex = 0;
			label5.Text = "&Style:";
			label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			label7.Location = new Point(15, 108);
			label7.Name = "label7";
			label7.Size = new Size(148, 16);
			label7.TabIndex = 4;
			label7.Text = "&Alignment:";
			label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			label8.Location = new Point(15, 75);
			label8.Name = "label8";
			label8.Size = new Size(148, 16);
			label8.TabIndex = 2;
			label8.Text = "&Docking:";
			label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			label9.Location = new Point(16, 8);
			label9.Name = "label9";
			label9.Size = new Size(704, 34);
			label9.TabIndex = 0;
			label9.Text = "This sample demonstrates how to set legend style and position within the chart.";
			label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 cb_Reversed,
																				 label1,
																				 TheTableStyle,
																				 DisableCheck,
																				 InsideCheck,
																				 label5,
																				 TheStyle,
																				 label7,
																				 label8,
																				 TheDocking,
																				 TheAlignment]);
			panel1.Location = new Point(432, 56);
			panel1.Name = "panel1";
			panel1.Size = new Size(292, 288);
			panel1.TabIndex = 2;
			// 
			// cb_Reversed
			// 
			cb_Reversed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			cb_Reversed.Location = new Point(13, 197);
			cb_Reversed.Name = "cb_Reversed";
			cb_Reversed.Size = new Size(168, 24);
			cb_Reversed.TabIndex = 11;
			cb_Reversed.Text = "&Reversed:";
			cb_Reversed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			cb_Reversed.CheckedChanged += new EventHandler(cb_Reversed_CheckedChanged);
			// 
			// label1
			// 
			label1.Location = new Point(16, 44);
			label1.Name = "label1";
			label1.Size = new Size(148, 16);
			label1.TabIndex = 9;
			label1.Text = "&Table Style:";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TheTableStyle
			// 
			TheTableStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			TheTableStyle.Enabled = false;
			TheTableStyle.Items.AddRange([
															   "Auto",
															   "Wide",
															   "Tall"]);
			TheTableStyle.Location = new Point(168, 40);
			TheTableStyle.Name = "TheTableStyle";
			TheTableStyle.TabIndex = 2;
			TheTableStyle.SelectedIndexChanged += new EventHandler(ControlChange);
			// 
			// DisableCheck
			// 
			DisableCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			DisableCheck.Location = new Point(13, 167);
			DisableCheck.Name = "DisableCheck";
			DisableCheck.Size = new Size(168, 24);
			DisableCheck.TabIndex = 8;
			DisableCheck.Text = "&Disable Legend:";
			DisableCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			DisableCheck.CheckedChanged += new EventHandler(DisableCheck_CheckedChanged);
			// 
			// InsideCheck
			// 
			InsideCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			InsideCheck.Location = new Point(13, 136);
			InsideCheck.Name = "InsideCheck";
			InsideCheck.Size = new Size(168, 24);
			InsideCheck.TabIndex = 6;
			InsideCheck.Text = "&Inside Chart Area:";
			InsideCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			InsideCheck.CheckedChanged += new EventHandler(ControlChange);
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
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			axisScaleBreakStyle1.Enabled = false;
			chartArea1.AxisX.ScaleBreakStyle = axisScaleBreakStyle1;
			chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			chartArea1.AxisX2.MajorGrid.Enabled = false;
			axisScaleBreakStyle2.Enabled = false;
			chartArea1.AxisX2.ScaleBreakStyle = axisScaleBreakStyle2;
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			axisScaleBreakStyle3.Enabled = false;
			chartArea1.AxisY.ScaleBreakStyle = axisScaleBreakStyle3;
			chartArea1.AxisY2.MajorGrid.Enabled = false;
			axisScaleBreakStyle4.Enabled = false;
			chartArea1.AxisY2.ScaleBreakStyle = axisScaleBreakStyle4;
			chartArea1.BackColor = System.Drawing.Color.OldLace;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			Chart1.ChartAreas.Add(chartArea1);
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			legend1.TitleFont = new Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			Chart1.Legends.Add(legend1);
			Chart1.Location = new Point(16, 48);
			Chart1.Name = "Chart1";
			Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.LegendText = "Projected";
			series1.Name = "Series 1";
			dataPoint1.Label = "";
			dataPoint2.Label = "";
			dataPoint3.Label = "";
			dataPoint4.Label = "";
			dataPoint5.Label = "";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series2.LegendText = "Actual";
			series2.Name = "Series 2";
			series2.Points.Add(dataPoint6);
			series2.Points.Add(dataPoint7);
			series2.Points.Add(dataPoint8);
			series2.Points.Add(dataPoint9);
			series2.Points.Add(dataPoint10);
			series3.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series3.BorderWidth = 2;
			series3.ChartType = SeriesChartType.Line;
			series3.LegendText = "Historical";
			series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
			series3.Name = "Series 3";
			series3.Points.Add(dataPoint11);
			series3.Points.Add(dataPoint12);
			series3.Points.Add(dataPoint13);
			series3.Points.Add(dataPoint14);
			series3.Points.Add(dataPoint15);
			series3.ShadowOffset = 1;
			series4.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series4.BorderWidth = 2;
			series4.ChartType = SeriesChartType.Line;
			series4.LegendText = "Target";
			series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
			series4.Name = "Series 4";
			series4.Points.Add(dataPoint16);
			series4.Points.Add(dataPoint17);
			series4.Points.Add(dataPoint18);
			series4.Points.Add(dataPoint19);
			series4.Points.Add(dataPoint20);
			series4.ShadowOffset = 1;
			Chart1.Series.Add(series1);
			Chart1.Series.Add(series2);
			Chart1.Series.Add(series3);
			Chart1.Series.Add(series4);
			Chart1.Size = new Size(412, 296);
			Chart1.TabIndex = 1;
			// 
			// LegendStylePosition
			// 
			Controls.AddRange([
																		  Chart1,
																		  panel1,
																		  label9]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "LegendStylePosition";
			Size = new Size(728, 480);
			panel1.ResumeLayout(false);
			((ISupportInitialize)(Chart1)).EndInit();
			ResumeLayout(false);

		}
		#endregion


		private void ControlChange(object sender, EventArgs e)
		{			

			if( InsideCheck.Checked )
				Chart1.Legends["Default"].InsideChartArea = "Default";
			else
				Chart1.Legends["Default"].InsideChartArea = "";

			Chart1.Legends["Default"].Enabled = !DisableCheck.Checked;

			if (TheStyle.SelectedItem.ToString() == "Table" && !DisableCheck.Checked)  
			{
				TheTableStyle.Enabled = true;		
			}

			else
				TheTableStyle.Enabled = false;

			if (TheTableStyle.SelectedIndex >=0) 
			{
				Chart1.Legends["Default"].TableStyle = (LegendTableStyle)LegendTableStyle.Parse(typeof(LegendTableStyle),TheTableStyle.SelectedItem.ToString());
			}			
			
			if(TheStyle.SelectedIndex >= 0)
			{
				Chart1.Legends["Default"].LegendStyle = (LegendStyle)LegendStyle.Parse(typeof(LegendStyle), TheStyle.SelectedItem.ToString());
			}

			if(TheDocking.SelectedIndex >= 0)
			{
				Chart1.Legends["Default"].Docking = (Docking)Docking.Parse(typeof(Docking), TheDocking.SelectedItem.ToString());
			}

			if(TheAlignment.SelectedIndex >= 0)
			{
				Chart1.Legends["Default"].Alignment = (StringAlignment)StringAlignment.Parse(typeof(StringAlignment), TheAlignment.SelectedItem.ToString());
			}

            if (cb_Reversed.Checked)
                Chart1.Legends["Default"].LegendItemOrder = LegendItemOrder.ReversedSeriesOrder;

            else
                Chart1.Legends["Default"].LegendItemOrder = LegendItemOrder.SameAsSeriesOrder;
		}

		private void cb_Reversed_CheckedChanged(object sender, EventArgs e)
		{
			ControlChange(sender,e);
		}

		private void DisableCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (!DisableCheck.Checked) 
			{
				TheAlignment.Enabled = true;
				TheDocking.Enabled = true;
				TheTableStyle.Enabled = true;
				TheStyle.Enabled = true;
				InsideCheck.Enabled = true;
				cb_Reversed.Enabled = true;
			}

			else
			{
				TheAlignment.Enabled = false;
				TheDocking.Enabled = false;
				TheTableStyle.Enabled = false;
				TheStyle.Enabled = false;
				InsideCheck.Enabled = false;
				cb_Reversed.Enabled = false;
			}

			ControlChange(sender,e);
		}
	}
}
