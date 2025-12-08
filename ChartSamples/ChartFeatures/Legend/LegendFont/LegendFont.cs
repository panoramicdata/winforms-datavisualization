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
	/// Summary description for AxisTitle.
	/// </summary>
	public class LegendFont : UserControl
	{
		private Label label5;
		private Label label7;
		private Label label8;
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private ComboBox FontSize;
		private CheckBox ItalicCheck;
		private CheckBox BoldCheck;
		private CheckBox UnderlineCheck;
		private CheckBox StrikeoutCheck;
		private ComboBox FontColorCombo;
		private ComboBox TheFont;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public LegendFont()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Add Chart Line styles to control.
			foreach(FontFamily fontName in FontFamily.Families)
			{
				TheFont.Items.Add(fontName.Name);
			}
			TheFont.SelectedIndex = TheFont.Items.IndexOf(Chart1.Legends[0].Font.Name);

			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				FontColorCombo.Items.Add(colorName);
			}
			FontColorCombo.SelectedIndex = 9;	// "Control Text"

			FontSize.SelectedIndex = 0;	// 8 point
			BoldCheck.Checked = true;

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
			DataPoint dataPoint1 = new DataPoint(0, 400);
			DataPoint dataPoint2 = new DataPoint(0, 200);
			DataPoint dataPoint3 = new DataPoint(0, 700);
			DataPoint dataPoint4 = new DataPoint(0, 300);
			DataPoint dataPoint5 = new DataPoint(0, 450);
			TheFont = new ComboBox();
			FontColorCombo = new ComboBox();
			FontSize = new ComboBox();
			label5 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			panel1 = new Panel();
			StrikeoutCheck = new CheckBox();
			UnderlineCheck = new CheckBox();
			BoldCheck = new CheckBox();
			ItalicCheck = new CheckBox();
			Chart1 = new Chart();
			panel1.SuspendLayout();
			((ISupportInitialize)(Chart1)).BeginInit();
			SuspendLayout();
			// 
			// TheFont
			// 
			TheFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			TheFont.Location = new Point(168, 4);
			TheFont.Name = "TheFont";
			TheFont.TabIndex = 1;
			TheFont.SelectedIndexChanged += new EventHandler(ControlChange);
			// 
			// FontColorCombo
			// 
			FontColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			FontColorCombo.Location = new Point(168, 72);
			FontColorCombo.Name = "FontColorCombo";
			FontColorCombo.TabIndex = 5;
			FontColorCombo.SelectedIndexChanged += new EventHandler(ControlChange);
			// 
			// FontSize
			// 
			FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			FontSize.Items.AddRange([
														  "8",
														  "10",
														  "12",
														  "14",
														  "16"]);
			FontSize.Location = new Point(168, 40);
			FontSize.Name = "FontSize";
			FontSize.TabIndex = 3;
			FontSize.SelectedIndexChanged += new EventHandler(ControlChange);
			// 
			// label5
			// 
			label5.Location = new Point(12, 7);
			label5.Name = "label5";
			label5.Size = new Size(152, 16);
			label5.TabIndex = 0;
			label5.Text = "&Font:";
			label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			label7.Location = new Point(12, 72);
			label7.Name = "label7";
			label7.Size = new Size(152, 16);
			label7.TabIndex = 4;
			label7.Text = "Font &Color:";
			label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			label8.Location = new Point(12, 40);
			label8.Name = "label8";
			label8.Size = new Size(152, 16);
			label8.TabIndex = 2;
			label8.Text = "Font &Size:";
			label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			label9.Location = new Point(16, 8);
			label9.Name = "label9";
			label9.Size = new Size(702, 34);
			label9.TabIndex = 0;
			label9.Text = "This sample demonstrates how to set the font and color of the legend\'s text.";
			label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 StrikeoutCheck,
																				 UnderlineCheck,
																				 BoldCheck,
																				 ItalicCheck,
																				 label5,
																				 TheFont,
																				 label7,
																				 label8,
																				 FontSize,
																				 FontColorCombo]);
			panel1.Location = new Point(432, 56);
			panel1.Name = "panel1";
			panel1.Size = new Size(292, 296);
			panel1.TabIndex = 0;
			// 
			// StrikeoutCheck
			// 
			StrikeoutCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			StrikeoutCheck.Location = new Point(13, 200);
			StrikeoutCheck.Name = "StrikeoutCheck";
			StrikeoutCheck.Size = new Size(168, 24);
			StrikeoutCheck.TabIndex = 9;
			StrikeoutCheck.Text = "&Strikeout:";
			StrikeoutCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			StrikeoutCheck.CheckedChanged += new EventHandler(ControlChange);
			// 
			// UnderlineCheck
			// 
			UnderlineCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			UnderlineCheck.Location = new Point(13, 168);
			UnderlineCheck.Name = "UnderlineCheck";
			UnderlineCheck.Size = new Size(168, 24);
			UnderlineCheck.TabIndex = 8;
			UnderlineCheck.Text = "&Underline:";
			UnderlineCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			UnderlineCheck.CheckedChanged += new EventHandler(ControlChange);
			// 
			// BoldCheck
			// 
			BoldCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			BoldCheck.Location = new Point(13, 136);
			BoldCheck.Name = "BoldCheck";
			BoldCheck.Size = new Size(168, 24);
			BoldCheck.TabIndex = 7;
			BoldCheck.Text = "&Bold:";
			BoldCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			BoldCheck.CheckedChanged += new EventHandler(ControlChange);
			// 
			// ItalicCheck
			// 
			ItalicCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			ItalicCheck.Location = new Point(13, 104);
			ItalicCheck.Name = "ItalicCheck";
			ItalicCheck.Size = new Size(168, 24);
			ItalicCheck.TabIndex = 6;
			ItalicCheck.Text = "&Italic:";
			ItalicCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			ItalicCheck.CheckedChanged += new EventHandler(ControlChange);
			// 
			// Chart1
			// 
			Chart1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(223)), ((System.Byte)(240)));
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
			chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			chartArea1.AxisX2.MajorGrid.Enabled = false;
			chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY2.MajorGrid.Enabled = false;
			chartArea1.BackColor = System.Drawing.Color.Transparent;
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
			series1.ChartType = SeriesChartType.Pie;
			series1.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(65)), ((System.Byte)(140)), ((System.Byte)(240)));
			series1.CustomProperties = "PieDrawingStyle=SoftEdge";
			series1.Name = "Default";
			dataPoint1.CustomProperties = "Exploded=true";
			dataPoint1.Label = "Canada";
			dataPoint2.Label = "Other";
			dataPoint3.Label = "Ireland";
			dataPoint4.Label = "England";
			dataPoint5.Label = "Australia";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.IsValueShownAsLabel = true;
			Chart1.Series.Add(series1);
			Chart1.Size = new Size(412, 296);
			Chart1.TabIndex = 1;
			// 
			// LegendFont
			// 
			Controls.AddRange([
																		  Chart1,
																		  panel1,
																		  label9]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "LegendFont";
			Size = new Size(728, 480);
			panel1.ResumeLayout(false);
			((ISupportInitialize)(Chart1)).EndInit();
			ResumeLayout(false);

		}
		#endregion


		private void LegendFont_Load(object sender, EventArgs e)
		{ 
		
		}

		private void ControlChange(object sender, EventArgs e)
		{
			// Set Font style.
			FontStyle fontStyle = FontStyle.Regular;
			if( ItalicCheck.Checked )
				fontStyle = (FontStyle)FontStyle.Italic;
			if( BoldCheck.Checked )
				fontStyle |= (FontStyle)FontStyle.Bold;
			if( UnderlineCheck.Checked )
				fontStyle |= (FontStyle)FontStyle.Underline;
			if( StrikeoutCheck.Checked )
				fontStyle |= (FontStyle)FontStyle.Strikeout;

			// Set Title font
			if(TheFont.SelectedIndex >= 0 && FontSize.SelectedIndex >= 0)
			{
				string font = TheFont.SelectedItem.ToString();
				float fontpoint = float.Parse(FontSize.SelectedItem.ToString());
				try
				{
					Chart1.Legends["Default"].Font = new Font(font, fontpoint, fontStyle);
				}
				catch
				{
					Chart1.Legends["Default"].Font = new Font("Arial", fontpoint, fontStyle);
				}
			}

			// Set Title color
			if(FontColorCombo.SelectedIndex >= 0)
			{
				Chart1.Legends["Default"].ForeColor = Color.FromName(FontColorCombo.SelectedItem.ToString());
			}
		}

	}
}
