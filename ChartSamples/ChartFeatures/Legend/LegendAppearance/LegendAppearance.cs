using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for Borders.
	/// </summary>
	public class LegendAppearance : UserControl
	{
		private ComboBox ChartForeColor;
		private ComboBox HatchStyle;
		private ComboBox Gradient;
		private ComboBox BorderColor;
		private ComboBox BorderDashStyle;
		private ComboBox BorderSize;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private ComboBox ChartBackColor;
		private Label label9;
		private Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private ComboBox ShadowOffset;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public LegendAppearance()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Add Hatch styles to control.
			foreach(string colorName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)))
			{
				HatchStyle.Items.Add(colorName);
			}
			HatchStyle.SelectedIndex = 0;

			// Add Chart Gradient types to control.
			foreach(string colorName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.GradientStyle)))
			{
				Gradient.Items.Add(colorName);
			}
			Gradient.SelectedIndex = 0;

			// Add Border styles to control.
			foreach(string colorName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)))
			{
				BorderDashStyle.Items.Add(colorName);
			}
			BorderDashStyle.SelectedIndex = BorderDashStyle.Items.IndexOf("Solid");


			ChartBackColor.SelectedIndex = 0;
			ChartForeColor.SelectedIndex = BorderColor.Items.IndexOf("Green");;
			BorderColor.SelectedIndex = BorderColor.Items.IndexOf("Gray");

			BorderSize.SelectedIndex = 0;
			ShadowOffset.SelectedIndex = 0;

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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel4 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 70);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 80);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 70);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 85);
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 65);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 70);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 60);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 75);
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 50);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 55);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 40);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 70);
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			ChartBackColor = new ComboBox();
			ShadowOffset = new ComboBox();
			ChartForeColor = new ComboBox();
			HatchStyle = new ComboBox();
			Gradient = new ComboBox();
			BorderColor = new ComboBox();
			BorderDashStyle = new ComboBox();
			BorderSize = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			panel1 = new Panel();
			Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			panel1.SuspendLayout();
			((ISupportInitialize)(Chart1)).BeginInit();
			SuspendLayout();
			// 
			// ChartBackColor
			// 
			ChartBackColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			ChartBackColor.Items.AddRange([
																"Transparent",
																"White",
																"Blue",
																"Red",
																"Green",
																"Yellow",
																"Maroon",
																"Gray",
																"Gainsboro"]);
			ChartBackColor.Location = new Point(168, 8);
			ChartBackColor.Name = "ChartBackColor";
			ChartBackColor.TabIndex = 3;
			ChartBackColor.SelectedIndexChanged += new EventHandler(BackColor_SelectedIndexChanged);
			// 
			// ShadowOffset
			// 
			ShadowOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			ShadowOffset.Items.AddRange([
															  "0",
															  "1",
															  "2",
															  "3",
															  "4",
															  "5"]);
			ShadowOffset.Location = new Point(168, 248);
			ShadowOffset.Name = "ShadowOffset";
			ShadowOffset.TabIndex = 15;
			ShadowOffset.SelectedIndexChanged += new EventHandler(ShadowOffset_SelectedIndexChanged);
			// 
			// ChartForeColor
			// 
			ChartForeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			ChartForeColor.Items.AddRange([
																"Transparent",
																"White",
																"Blue",
																"Red",
																"Green",
																"Yellow",
																"Maroon",
																"Gray",
																"Gainsboro"]);
			ChartForeColor.Location = new Point(168, 104);
			ChartForeColor.Name = "ChartForeColor";
			ChartForeColor.TabIndex = 1;
			ChartForeColor.SelectedIndexChanged += new EventHandler(ChartForeColor_SelectedIndexChanged);
			// 
			// HatchStyle
			// 
			HatchStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			HatchStyle.Location = new Point(168, 72);
			HatchStyle.Name = "HatchStyle";
			HatchStyle.TabIndex = 7;
			HatchStyle.SelectedIndexChanged += new EventHandler(HatchStyle_SelectedIndexChanged);
			// 
			// Gradient
			// 
			Gradient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			Gradient.Location = new Point(168, 40);
			Gradient.Name = "Gradient";
			Gradient.TabIndex = 5;
			Gradient.SelectedIndexChanged += new EventHandler(Gradient_SelectedIndexChanged);
			// 
			// BorderColor
			// 
			BorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			BorderColor.Items.AddRange([
															 "Transparent",
															 "Black",
															 "White",
															 "Blue",
															 "Red",
															 "Green",
															 "Yellow",
															 "Maroon",
															 "Gray",
															 "Gainsboro"]);
			BorderColor.Location = new Point(168, 144);
			BorderColor.Name = "BorderColor";
			BorderColor.TabIndex = 11;
			BorderColor.SelectedIndexChanged += new EventHandler(BorderColor_SelectedIndexChanged);
			// 
			// BorderDashStyle
			// 
			BorderDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			BorderDashStyle.Location = new Point(168, 176);
			BorderDashStyle.Name = "BorderDashStyle";
			BorderDashStyle.TabIndex = 9;
			BorderDashStyle.SelectedIndexChanged += new EventHandler(BorderDashStyle_SelectedIndexChanged);
			// 
			// BorderSize
			// 
			BorderSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			BorderSize.Items.AddRange([
															"1",
															"2",
															"3",
															"4",
															"5"]);
			BorderSize.Location = new Point(168, 208);
			BorderSize.Name = "BorderSize";
			BorderSize.TabIndex = 13;
			BorderSize.SelectedIndexChanged += new EventHandler(BorderSize_SelectedIndexChanged);
			// 
			// label1
			// 
			label1.Location = new Point(12, 253);
			label1.Name = "label1";
			label1.Size = new Size(156, 13);
			label1.TabIndex = 14;
			label1.Text = "Shadow &Offset:";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			label2.Location = new Point(12, 104);
			label2.Name = "label2";
			label2.Size = new Size(156, 19);
			label2.TabIndex = 0;
			label2.Text = "&Secondary Back Color:";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			label3.Location = new Point(11, 10);
			label3.Name = "label3";
			label3.Size = new Size(156, 19);
			label3.TabIndex = 2;
			label3.Text = "&Back Color:";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			label4.Location = new Point(12, 48);
			label4.Name = "label4";
			label4.Size = new Size(156, 13);
			label4.TabIndex = 4;
			label4.Text = "&Gradient:";
			label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			label5.Location = new Point(12, 80);
			label5.Name = "label5";
			label5.Size = new Size(156, 13);
			label5.TabIndex = 6;
			label5.Text = "&Hatch Style:";
			label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			label6.Location = new Point(12, 184);
			label6.Name = "label6";
			label6.Size = new Size(156, 13);
			label6.TabIndex = 8;
			label6.Text = "&Border Style:";
			label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			label7.Location = new Point(12, 152);
			label7.Name = "label7";
			label7.Size = new Size(156, 13);
			label7.TabIndex = 10;
			label7.Text = "B&order Color:";
			label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			label8.Location = new Point(12, 216);
			label8.Name = "label8";
			label8.Size = new Size(156, 13);
			label8.TabIndex = 12;
			label8.Text = "Bo&rder Size:";
			label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			label9.Location = new Point(16, 8);
			label9.Name = "label9";
			label9.Size = new Size(702, 34);
			label9.TabIndex = 0;
			label9.Text = "This sample demonstrates how to set the appearance of the legend.";
			label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 BorderDashStyle,
																				 label5,
																				 Gradient,
																				 label6,
																				 label4,
																				 HatchStyle,
																				 label7,
																				 label3,
																				 ShadowOffset,
																				 label1,
																				 label2,
																				 label8,
																				 BorderSize,
																				 ChartBackColor,
																				 ChartForeColor,
																				 BorderColor]);
			panel1.Location = new Point(432, 56);
			panel1.Name = "panel1";
			panel1.Size = new Size(292, 296);
			panel1.TabIndex = 2;
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
			chartArea1.Area3DStyle.Rotation = 5;
			customLabel1.FromPosition = 0.5;
			customLabel1.Text = "John";
			customLabel1.ToPosition = 1.5;
			customLabel2.FromPosition = 1.5;
			customLabel2.Text = "Mary";
			customLabel2.ToPosition = 2.5;
			customLabel3.FromPosition = 2.5;
			customLabel3.Text = "Jeff";
			customLabel3.ToPosition = 3.5;
			customLabel4.FromPosition = 3.5;
			customLabel4.Text = "Bob";
			customLabel4.ToPosition = 4.5;
			chartArea1.AxisX.CustomLabels.Add(customLabel1);
			chartArea1.AxisX.CustomLabels.Add(customLabel2);
			chartArea1.AxisX.CustomLabels.Add(customLabel3);
			chartArea1.AxisX.CustomLabels.Add(customLabel4);
			chartArea1.AxisX.Interval = 1;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F);
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.Position.Auto = false;
			chartArea1.Position.Height = 75F;
			chartArea1.Position.Width = 100F;
			chartArea1.Position.Y = 8F;
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			Chart1.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Center;
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.IsDockedInsideChartArea = false;
			legend1.DockedToChartArea = "Default";
			legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
			legend1.Name = "Default";
			Chart1.Legends.Add(legend1);
			Chart1.Location = new Point(16, 48);
			Chart1.Name = "Chart1";
			Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartArea = "Default";
			series1.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(65)), ((System.Byte)(140)), ((System.Byte)(240)));
			series1.CustomProperties = "DrawingStyle=Cylinder";
			series1.Name = "Total";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.ShadowColor = System.Drawing.Color.Transparent;
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			series2.ChartArea = "Default";
			series2.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(252)), ((System.Byte)(180)), ((System.Byte)(65)));
			series2.CustomProperties = "DrawingStyle=Cylinder";
			series2.Name = "Last Week";
			series2.Points.Add(dataPoint5);
			series2.Points.Add(dataPoint6);
			series2.Points.Add(dataPoint7);
			series2.Points.Add(dataPoint8);
			series3.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			series3.ChartArea = "Default";
			series3.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(224)), ((System.Byte)(64)), ((System.Byte)(10)));
			series3.CustomProperties = "DrawingStyle=Cylinder";
			series3.Name = "This Week";
			series3.Points.Add(dataPoint9);
			series3.Points.Add(dataPoint10);
			series3.Points.Add(dataPoint11);
			series3.Points.Add(dataPoint12);
			Chart1.Series.Add(series1);
			Chart1.Series.Add(series2);
			Chart1.Series.Add(series3);
			Chart1.Size = new Size(412, 296);
			Chart1.TabIndex = 1;
			title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
			title1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
			title1.Position.Auto = false;
			title1.Position.Height = 8.738057F;
			title1.Position.Width = 80F;
			title1.Position.X = 5F;
			title1.Position.Y = 4F;
			title1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(32)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			title1.ShadowOffset = 3;
			title1.Text = "Chart Control for .NET Framework";
			Chart1.Titles.Add(title1);
			// 
			// LegendAppearance
			// 
			Controls.AddRange([
																		  Chart1,
																		  panel1,
																		  label9]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "LegendAppearance";
			Size = new Size(728, 480);
			panel1.ResumeLayout(false);
			((ISupportInitialize)(Chart1)).EndInit();
			ResumeLayout(false);

		}
		#endregion

		private void ShadowOffset_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Set Border Skin
			Chart1.Legends["Default"].ShadowOffset = int.Parse(ShadowOffset.SelectedItem.ToString());
		}

		private void ChartForeColor_SelectedIndexChanged(object sender, EventArgs e)
		{
				// Set Fore Color
			Chart1.Legends["Default"].BackSecondaryColor = Color.FromName(ChartForeColor.SelectedItem.ToString());
		}

		private void BackColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Set Back Color
			Chart1.Legends["Default"].BackColor = Color.FromName(ChartBackColor.SelectedItem.ToString());
		}

		private void Gradient_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Set Gradient Type
			Chart1.Legends["Default"].BackGradientStyle = (System.Windows.Forms.DataVisualization.Charting.GradientStyle)System.Windows.Forms.DataVisualization.Charting.GradientStyle.Parse(typeof(System.Windows.Forms.DataVisualization.Charting.GradientStyle), Gradient.SelectedItem.ToString());

			// Disable hatch if gradient is active
			if( Chart1.Legends["Default"].BackGradientStyle != System.Windows.Forms.DataVisualization.Charting.GradientStyle.None )
				HatchStyle.SelectedIndex = 0;
		
		}

		private void HatchStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			// Set Hatch Style
			Chart1.Legends["Default"].BackHatchStyle = (System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Parse(typeof(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle), HatchStyle.SelectedItem.ToString());

			// Disable gradient if hatch style is active
			if( Chart1.Legends["Default"].BackHatchStyle != System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.None )
				Gradient.SelectedIndex = 0;		
		}

		private void BorderDashStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Set Border Style
			Chart1.Legends["Default"].BorderDashStyle = (System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Parse(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle), BorderDashStyle.SelectedItem.ToString());
		}

		private void BorderColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Set Border Color
			Chart1.Legends["Default"].BorderColor = Color.FromName(BorderColor.SelectedItem.ToString());
		}

		private void BorderSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Set Border Width
			Chart1.Legends["Default"].BorderWidth = int.Parse(BorderSize.SelectedItem.ToString());
		}
	}
}
