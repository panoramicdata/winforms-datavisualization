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
	/// Summary description for StripLineTitle.
	/// </summary>
	public class StripLineTitle : UserControl
	{
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private ComboBox FontSize;
		private CheckBox ItalicCheck;
		private TextBox Title;
		private CheckBox BoldCheck;
		private CheckBox UnderlineCheck;
		private CheckBox StrikeoutCheck;
		private ComboBox FontColorCombo;
		private ComboBox TheFont;
		private ComboBox TitlePosition;
		private CheckBox AntiAliasingCheck;
		private ComboBox TitleLinePosition;
        private Label label1;
		private Label label2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public StripLineTitle()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			
			foreach(String AlignmentName in Enum.GetNames(typeof(StringAlignment)))
			{
				TitlePosition.Items.Add(AlignmentName);
				TitleLinePosition.Items.Add(AlignmentName);
			}
			TitlePosition.SelectedIndex = 0;
			TitleLinePosition.SelectedIndex = 0;
			
			// Add Chart Line styles to control.
			foreach(FontFamily fontName in FontFamily.Families)
			{
				TheFont.Items.Add(fontName.Name);
			}
			TheFont.SelectedIndex = 0; // "Arial"

			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				FontColorCombo.Items.Add(colorName);
			}
			FontColorCombo.SelectedIndex = 9;	// "Control Text"

			FontSize.SelectedIndex = 1;	// 10 point
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
			StripLine stripLine1 = new StripLine();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(1, 400);
			DataPoint dataPoint2 = new DataPoint(2, 200);
			DataPoint dataPoint3 = new DataPoint(3, 700);
			DataPoint dataPoint4 = new DataPoint(4, 300);
			DataPoint dataPoint5 = new DataPoint(5, 450);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(1, 200);
			DataPoint dataPoint7 = new DataPoint(2, 300);
			DataPoint dataPoint8 = new DataPoint(3, 350);
			DataPoint dataPoint9 = new DataPoint(4, 80);
			DataPoint dataPoint10 = new DataPoint(5, 400);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(1, 500);
			DataPoint dataPoint12 = new DataPoint(2, 120);
			DataPoint dataPoint13 = new DataPoint(3, 300);
			DataPoint dataPoint14 = new DataPoint(4, 50);
			DataPoint dataPoint15 = new DataPoint(5, 130);
            TheFont = new ComboBox();
            FontColorCombo = new ComboBox();
            TitlePosition = new ComboBox();
            FontSize = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            TitleLinePosition = new ComboBox();
            label1 = new Label();
            StrikeoutCheck = new CheckBox();
            UnderlineCheck = new CheckBox();
            BoldCheck = new CheckBox();
            Title = new TextBox();
            ItalicCheck = new CheckBox();
            AntiAliasingCheck = new CheckBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // TheFont
            // 
            TheFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            TheFont.Location = new Point(168, 104);
            TheFont.Name = "TheFont";
            TheFont.Size = new Size(116, 22);
            TheFont.TabIndex = 7;
            TheFont.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // FontColorCombo
            // 
            FontColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FontColorCombo.Location = new Point(168, 168);
            FontColorCombo.Name = "FontColorCombo";
            FontColorCombo.Size = new Size(116, 22);
            FontColorCombo.TabIndex = 11;
            FontColorCombo.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // TitlePosition
            // 
            TitlePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            TitlePosition.Location = new Point(168, 40);
            TitlePosition.Name = "TitlePosition";
            TitlePosition.Size = new Size(116, 22);
            TitlePosition.TabIndex = 3;
            TitlePosition.SelectedIndexChanged += new EventHandler(ControlChange);
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
            FontSize.Location = new Point(168, 136);
            FontSize.Name = "FontSize";
            FontSize.Size = new Size(116, 22);
            FontSize.TabIndex = 9;
            FontSize.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // label5
            // 
            label5.Location = new Point(20, 107);
            label5.Name = "label5";
            label5.Size = new Size(144, 16);
            label5.TabIndex = 6;
            label5.Text = "&Font:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(20, 43);
            label6.Name = "label6";
            label6.Size = new Size(144, 16);
            label6.TabIndex = 2;
            label6.Text = "Horizontal &Alignment:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(20, 171);
            label7.Name = "label7";
            label7.Size = new Size(144, 16);
            label7.TabIndex = 10;
            label7.Text = "Font &Color:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new Point(20, 139);
            label8.Name = "label8";
            label8.Size = new Size(144, 16);
            label8.TabIndex = 8;
            label8.Text = "Font &Size:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to set a StripLine object\'s title.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TitleLinePosition);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(StrikeoutCheck);
            panel1.Controls.Add(UnderlineCheck);
            panel1.Controls.Add(BoldCheck);
            panel1.Controls.Add(Title);
            panel1.Controls.Add(ItalicCheck);
            panel1.Controls.Add(TitlePosition);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TheFont);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(FontSize);
            panel1.Controls.Add(FontColorCombo);
            panel1.Controls.Add(AntiAliasingCheck);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 360);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(20, 7);
            label2.Name = "label2";
            label2.Size = new Size(144, 16);
            label2.TabIndex = 0;
            label2.Text = "Title &Text:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleLinePosition
            // 
            TitleLinePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            TitleLinePosition.Location = new Point(168, 72);
            TitleLinePosition.Name = "TitleLinePosition";
            TitleLinePosition.Size = new Size(116, 22);
            TitleLinePosition.TabIndex = 5;
            TitleLinePosition.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // label1
            // 
            label1.Location = new Point(20, 75);
            label1.Name = "label1";
            label1.Size = new Size(144, 16);
            label1.TabIndex = 4;
            label1.Text = "&Vertical Alignment:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrikeoutCheck
            // 
            StrikeoutCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            StrikeoutCheck.Location = new Point(19, 296);
            StrikeoutCheck.Name = "StrikeoutCheck";
            StrikeoutCheck.Size = new Size(162, 24);
            StrikeoutCheck.TabIndex = 15;
            StrikeoutCheck.Text = "S&trikeout:";
            StrikeoutCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            StrikeoutCheck.CheckedChanged += new EventHandler(ControlChange);
            // 
            // UnderlineCheck
            // 
            UnderlineCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            UnderlineCheck.Location = new Point(19, 264);
            UnderlineCheck.Name = "UnderlineCheck";
            UnderlineCheck.Size = new Size(162, 24);
            UnderlineCheck.TabIndex = 14;
            UnderlineCheck.Text = "&Underline:";
            UnderlineCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            UnderlineCheck.CheckedChanged += new EventHandler(ControlChange);
            // 
            // BoldCheck
            // 
            BoldCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            BoldCheck.Location = new Point(19, 232);
            BoldCheck.Name = "BoldCheck";
            BoldCheck.Size = new Size(162, 24);
            BoldCheck.TabIndex = 13;
            BoldCheck.Text = "&Bold:";
            BoldCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            BoldCheck.CheckedChanged += new EventHandler(ControlChange);
            // 
            // Title
            // 
            Title.Location = new Point(168, 4);
            Title.Name = "Title";
            Title.Size = new Size(116, 22);
            Title.TabIndex = 1;
            Title.Text = "Strip Line Title";
            Title.TextChanged += new EventHandler(ControlChange);
            // 
            // ItalicCheck
            // 
            ItalicCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            ItalicCheck.Location = new Point(19, 200);
            ItalicCheck.Name = "ItalicCheck";
            ItalicCheck.Size = new Size(162, 24);
            ItalicCheck.TabIndex = 12;
            ItalicCheck.Text = "&Italic:";
            ItalicCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            ItalicCheck.CheckedChanged += new EventHandler(ControlChange);
            // 
            // AntiAliasingCheck
            // 
            AntiAliasingCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            AntiAliasingCheck.Checked = true;
            AntiAliasingCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            AntiAliasingCheck.Location = new Point(16, 328);
            AntiAliasingCheck.Name = "AntiAliasingCheck";
            AntiAliasingCheck.Size = new Size(162, 24);
            AntiAliasingCheck.TabIndex = 16;
            AntiAliasingCheck.Text = "Anti Alia&sing:";
            AntiAliasingCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            AntiAliasingCheck.CheckedChanged += new EventHandler(ControlChange);
            // 
            // Chart1
            // 
            Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            Chart1.BorderlineWidth = 2;
            Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 5;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stripLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            stripLine1.Interval = 3;
            stripLine1.IntervalOffset = 0.5;
            stripLine1.StripWidth = 2;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderWidth = 3;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series3.BorderWidth = 3;
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            // 
            // StripLineTitle
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "StripLineTitle";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void StripLineTitle_Load(object sender, EventArgs e)
		{ 
		
		}

		private void ControlChange(object sender, EventArgs e)
		{
			if(TitlePosition.SelectedIndex >= 0)
			{
				string strAlign = TitlePosition.SelectedItem.ToString();
				StringAlignment align = (StringAlignment) Enum.Parse(typeof(StringAlignment), strAlign, true);
				Chart1.ChartAreas["Default"].AxisX.StripLines[0].TextAlignment = align;
			}
			
			if(TitleLinePosition.SelectedIndex >= 0)
			{
				string strAlign = TitleLinePosition.SelectedItem.ToString();
				StringAlignment align = (StringAlignment) Enum.Parse(typeof(StringAlignment), strAlign, true);
				Chart1.ChartAreas["Default"].AxisX.StripLines[0].TextLineAlignment = align;
			}

			// Set selected axis
			Chart1.ChartAreas["Default"].AxisX.StripLines[0].Text = Title.Text;

			if( AntiAliasingCheck.Checked )
				Chart1.AntiAliasing = AntiAliasingStyles.All;
			else
				Chart1.AntiAliasing = AntiAliasingStyles.Graphics;


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
					Chart1.ChartAreas["Default"].AxisX.StripLines[0].Font = new Font(font, fontpoint, fontStyle);
				}
				catch
				{
					Chart1.ChartAreas["Default"].AxisX.StripLines[0].Font = new Font("Arial", fontpoint, fontStyle);
				}
			}

			// Set Title color
			if(FontColorCombo.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.StripLines[0].ForeColor = Color.FromName(FontColorCombo.SelectedItem.ToString());
			}
		}

	}
}
