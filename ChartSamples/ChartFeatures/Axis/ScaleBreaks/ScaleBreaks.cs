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
	/// Summary description for ScaleBreaks.
	/// </summary>
	public class ScaleBreaks : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private CheckBox chk_EnableScaleBreaks;
		private ComboBox cb_BreakLineStyle;
		private Label label1;
		private NumericUpDown numericUpDown1;
		private Label label2;
		private Label label3;
		private ComboBox cb_Color;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public ScaleBreaks()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			foreach (string breakTypes in Enum.GetNames(typeof(BreakLineStyle)))
			{
				cb_BreakLineStyle.Items.Add(breakTypes);
			}

			cb_BreakLineStyle.SelectedIndex = 3;
			cb_Color.SelectedIndex = 0;
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
			DataPoint dataPoint1 = new DataPoint(38801.6328125, 32);
			DataPoint dataPoint2 = new DataPoint(38802.6328125, 30);
			DataPoint dataPoint3 = new DataPoint(38803.6328125, 38);
			DataPoint dataPoint4 = new DataPoint(38804.6328125, 23);
			DataPoint dataPoint5 = new DataPoint(38805.6328125, 28);
			DataPoint dataPoint6 = new DataPoint(38806.6328125, 24);
			DataPoint dataPoint7 = new DataPoint(38807.6328125, 21);
			DataPoint dataPoint8 = new DataPoint(38808.6328125, 30);
			DataPoint dataPoint9 = new DataPoint(38809.6328125, 24);
			DataPoint dataPoint10 = new DataPoint(38810.6328125, 29);
			DataPoint dataPoint11 = new DataPoint(38811.6328125, 2953);
			DataPoint dataPoint12 = new DataPoint(38812.6328125, 3367);
			DataPoint dataPoint13 = new DataPoint(38813.6328125, 3124);
			DataPoint dataPoint14 = new DataPoint(38814.6328125, 3224);
			DataPoint dataPoint15 = new DataPoint(38815.6328125, 25);
			DataPoint dataPoint16 = new DataPoint(38816.6328125, 18);
			DataPoint dataPoint17 = new DataPoint(38817.6328125, 14);
			DataPoint dataPoint18 = new DataPoint(38818.6328125, 28);
			DataPoint dataPoint19 = new DataPoint(38819.6328125, 19);
			DataPoint dataPoint20 = new DataPoint(38820.6328125, 30);
			DataPoint dataPoint21 = new DataPoint(38821.6328125, 21);
			DataPoint dataPoint22 = new DataPoint(38822.6328125, 32);
			DataPoint dataPoint23 = new DataPoint(38823.6328125, 23);
			DataPoint dataPoint24 = new DataPoint(38824.6328125, 10);
			DataPoint dataPoint25 = new DataPoint(38825.6328125, 27);
			label9 = new Label();
			panel1 = new Panel();
			cb_Color = new ComboBox();
			label3 = new Label();
			label2 = new Label();
			numericUpDown1 = new NumericUpDown();
			label1 = new Label();
			cb_BreakLineStyle = new ComboBox();
			chk_EnableScaleBreaks = new CheckBox();
			Chart1 = new Chart();
			panel1.SuspendLayout();
			((ISupportInitialize)(numericUpDown1)).BeginInit();
			((ISupportInitialize)(Chart1)).BeginInit();
			SuspendLayout();
			// 
			// label9
			// 
			label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			label9.Location = new Point(16, 16);
			label9.Name = "label9";
			label9.Size = new Size(702, 24);
			label9.TabIndex = 0;
			label9.Text = "This sample demonstrates how to work with scale breaks.";
			label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 cb_Color,
																				 label3,
																				 label2,
																				 numericUpDown1,
																				 label1,
																				 cb_BreakLineStyle,
																				 chk_EnableScaleBreaks]);
			panel1.Location = new Point(432, 56);
			panel1.Name = "panel1";
			panel1.Size = new Size(312, 288);
			panel1.TabIndex = 2;
			// 
			// cb_Color
			// 
			cb_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cb_Color.Enabled = false;
			cb_Color.Items.AddRange([
														  "Black",
														  "Gray",
														  "Red",
														  "Blue",
														  "Green"]);
			cb_Color.Location = new Point(165, 104);
			cb_Color.Name = "cb_Color";
			cb_Color.Size = new Size(123, 22);
			cb_Color.TabIndex = 6;
			cb_Color.SelectedIndexChanged += new EventHandler(cb_Color_SelectedIndexChanged);
			// 
			// label3
			// 
			label3.Location = new Point(40, 104);
			label3.Name = "label3";
			label3.Size = new Size(120, 23);
			label3.TabIndex = 5;
			label3.Text = "&Color:";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			label2.Location = new Point(96, 72);
			label2.Name = "label2";
			label2.Size = new Size(64, 23);
			label2.TabIndex = 3;
			label2.Text = "&Spacing:";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Enabled = false;
			numericUpDown1.Location = new Point(166, 72);
			numericUpDown1.Maximum = new System.Decimal([
																		   10,
																		   0,
																		   0,
																		   0]);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(66, 22);
			numericUpDown1.TabIndex = 4;
			numericUpDown1.Value = new System.Decimal([
																		 1,
																		 0,
																		 0,
																		 0]);
			numericUpDown1.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
			// 
			// label1
			// 
			label1.Location = new Point(104, 40);
			label1.Name = "label1";
			label1.Size = new Size(56, 23);
			label1.TabIndex = 1;
			label1.Text = "&Type:";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cb_BreakLineStyle
			// 
			cb_BreakLineStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cb_BreakLineStyle.Enabled = false;
			cb_BreakLineStyle.Location = new Point(165, 39);
			cb_BreakLineStyle.Name = "cb_BreakLineStyle";
			cb_BreakLineStyle.Size = new Size(123, 22);
			cb_BreakLineStyle.TabIndex = 2;
			cb_BreakLineStyle.SelectedIndexChanged += new EventHandler(cb_BreakLineStyle_SelectedIndexChanged);
			// 
			// chk_EnableScaleBreaks
			// 
			chk_EnableScaleBreaks.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			chk_EnableScaleBreaks.Location = new Point(12, 8);
			chk_EnableScaleBreaks.Name = "chk_EnableScaleBreaks";
			chk_EnableScaleBreaks.Size = new Size(168, 24);
			chk_EnableScaleBreaks.TabIndex = 0;
			chk_EnableScaleBreaks.Text = "&Enable Scale Breaks:";
			chk_EnableScaleBreaks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			chk_EnableScaleBreaks.CheckedChanged += new EventHandler(chk_EnableScaleBreaks_CheckedChanged);
			// 
			// Chart1
			// 
			Chart1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(223)), ((System.Byte)(240)));
			Chart1.BackSecondaryColor = System.Drawing.Color.White;
			Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			Chart1.BorderlineWidth = 2;
			Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
			chartArea1.AxisX.LabelAutoFitMinFontSize = 8;
			chartArea1.AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.None;
			chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			chartArea1.AxisX.LabelStyle.Format = "MMM dd";
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
			chartArea1.AxisY.LabelAutoFitMinFontSize = 8;
			chartArea1.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
				| System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap);
			chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.LineWidth = 2;
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(165)), ((System.Byte)(191)), ((System.Byte)(228)));
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			Chart1.ChartAreas.Add(chartArea1);
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Enabled = false;
			legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			legend1.TitleFont = new Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			Chart1.Legends.Add(legend1);
			Chart1.Location = new Point(16, 56);
			Chart1.Name = "Chart1";
			Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartArea = "Default";
			series1.CustomProperties = "DrawingStyle=LightToDark";
			series1.Name = "Series1";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.Points.Add(dataPoint6);
			series1.Points.Add(dataPoint7);
			series1.Points.Add(dataPoint8);
			series1.Points.Add(dataPoint9);
			series1.Points.Add(dataPoint10);
			series1.Points.Add(dataPoint11);
			series1.Points.Add(dataPoint12);
			series1.Points.Add(dataPoint13);
			series1.Points.Add(dataPoint14);
			series1.Points.Add(dataPoint15);
			series1.Points.Add(dataPoint16);
			series1.Points.Add(dataPoint17);
			series1.Points.Add(dataPoint18);
			series1.Points.Add(dataPoint19);
			series1.Points.Add(dataPoint20);
			series1.Points.Add(dataPoint21);
			series1.Points.Add(dataPoint22);
			series1.Points.Add(dataPoint23);
			series1.Points.Add(dataPoint24);
			series1.Points.Add(dataPoint25);
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			Chart1.Series.Add(series1);
			Chart1.Size = new Size(412, 296);
			Chart1.TabIndex = 1;
			// 
			// ScaleBreaks
			// 
			Controls.AddRange([
																		  Chart1,
																		  panel1,
																		  label9]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "ScaleBreaks";
			Size = new Size(760, 480);
			panel1.ResumeLayout(false);
			((ISupportInitialize)(numericUpDown1)).EndInit();
			((ISupportInitialize)(Chart1)).EndInit();
			ResumeLayout(false);

		}
		#endregion		

		private void chk_EnableScaleBreaks_CheckedChanged(object sender, EventArgs e)
		{
			if (chk_EnableScaleBreaks.Checked) 
			{
				Chart1.ChartAreas[0].AxisY.ScaleBreakStyle.Enabled = true;
				cb_BreakLineStyle.Enabled = true;
				numericUpDown1.Enabled = true;
				cb_Color.Enabled = true;
			}

			else 
			{
				Chart1.ChartAreas[0].AxisY.ScaleBreakStyle.Enabled = false;
				cb_BreakLineStyle.Enabled = false;
				numericUpDown1.Enabled = false;
				cb_Color.Enabled = false;
			}
		}

		private void cb_BreakLineStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Set the scale break type
			Chart1.ChartAreas[0].AxisY.ScaleBreakStyle.BreakLineStyle = (BreakLineStyle)BreakLineStyle.Parse(typeof(BreakLineStyle), cb_BreakLineStyle.SelectedItem.ToString());
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			Chart1.ChartAreas[0].AxisY.ScaleBreakStyle.Spacing = (int)numericUpDown1.Value;
		}

		private void cb_Color_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.ChartAreas[0].AxisY.ScaleBreakStyle.LineColor = Color.FromName(cb_Color.SelectedItem.ToString());		
		}
	}
}
