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
	/// Summary description for Title.
	/// </summary>
	public class ChartTitle : UserControl
	{
		private Label label5;
		private Label label7;
		private Label label8;
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private ComboBox FontSize;
		private TextBox Title;
		private ComboBox FontColorCombo;
		private ComboBox TheFont;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private ComboBox Alignment;
		private ComboBox BorderColor;
		private TextBox ToolTip;
		private ComboBox BackColorCom;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public ChartTitle()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			
			// Add Chart Line styles to control.
			foreach(FontFamily fontName in FontFamily.Families)
			{
				TheFont.Items.Add(fontName.Name);
			}
			TheFont.SelectedIndex = TheFont.Items.IndexOf( Chart1.Titles[0].Font.Name); 

			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				FontColorCombo.Items.Add(colorName);
			}
			
			Alignment.SelectedIndex = 1;
			FontColorCombo.SelectedIndex = 9;	// "Control Text"

			FontSize.SelectedIndex = 3;	// 14 point

			BackColorCom.SelectedIndex = 0;
			BorderColor.SelectedIndex = 0;

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
			Title title1 = new Title();
            TheFont = new ComboBox();
            FontColorCombo = new ComboBox();
            FontSize = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            ToolTip = new TextBox();
            label4 = new Label();
            label3 = new Label();
            Alignment = new ComboBox();
            label2 = new Label();
            BorderColor = new ComboBox();
            label1 = new Label();
            BackColorCom = new ComboBox();
            Title = new TextBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // TheFont
            // 
            TheFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            TheFont.Location = new Point(168, 32);
            TheFont.Name = "TheFont";
            TheFont.Size = new Size(121, 22);
            TheFont.TabIndex = 2;
            TheFont.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // FontColorCombo
            // 
            FontColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FontColorCombo.Location = new Point(168, 88);
            FontColorCombo.Name = "FontColorCombo";
            FontColorCombo.Size = new Size(121, 22);
            FontColorCombo.TabIndex = 6;
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
            FontSize.Location = new Point(168, 60);
            FontSize.Name = "FontSize";
            FontSize.Size = new Size(121, 22);
            FontSize.TabIndex = 4;
            FontSize.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // label5
            // 
            label5.Location = new Point(8, 35);
            label5.Name = "label5";
            label5.Size = new Size(156, 16);
            label5.TabIndex = 1;
            label5.Text = "&Font:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(8, 91);
            label7.Name = "label7";
            label7.Size = new Size(156, 16);
            label7.TabIndex = 5;
            label7.Text = "Font &Color:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new Point(8, 63);
            label8.Name = "label8";
            label8.Size = new Size(156, 16);
            label8.TabIndex = 3;
            label8.Text = "Font &Size:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample shows how to set the chart title\'s text, font and color. Note that th" +
                "e PrePaint and PostPaint events allow for custom drawing of the chart\'s title. ";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(ToolTip);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Alignment);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(BorderColor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BackColorCom);
            panel1.Controls.Add(Title);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TheFont);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(FontSize);
            panel1.Controls.Add(FontColorCombo);
            panel1.Location = new Point(432, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 296);
            panel1.TabIndex = 2;
            // 
            // ToolTip
            // 
            ToolTip.Location = new Point(169, 200);
            ToolTip.Name = "ToolTip";
            ToolTip.Size = new Size(120, 22);
            ToolTip.TabIndex = 14;
            ToolTip.Text = "Title Tooltip";
            ToolTip.TextChanged += new EventHandler(ControlChange);
            // 
            // label4
            // 
            label4.Location = new Point(8, 204);
            label4.Name = "label4";
            label4.Size = new Size(156, 16);
            label4.TabIndex = 13;
            label4.Text = "&ToolTip:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(8, 175);
            label3.Name = "label3";
            label3.Size = new Size(156, 16);
            label3.TabIndex = 11;
            label3.Text = "&Alignment:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Alignment
            // 
            Alignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Alignment.Items.AddRange([
            "Left",
            "Center",
            "Right"]);
            Alignment.Location = new Point(168, 172);
            Alignment.Name = "Alignment";
            Alignment.Size = new Size(121, 22);
            Alignment.TabIndex = 12;
            Alignment.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // label2
            // 
            label2.Location = new Point(8, 147);
            label2.Name = "label2";
            label2.Size = new Size(156, 16);
            label2.TabIndex = 9;
            label2.Text = "B&order Color:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BorderColor
            // 
            BorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BorderColor.Items.AddRange([
            "None",
            "Red",
            "Green",
            "Blue",
            "Yellow"]);
            BorderColor.Location = new Point(168, 144);
            BorderColor.Name = "BorderColor";
            BorderColor.Size = new Size(121, 22);
            BorderColor.TabIndex = 10;
            BorderColor.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // label1
            // 
            label1.Location = new Point(8, 119);
            label1.Name = "label1";
            label1.Size = new Size(156, 16);
            label1.TabIndex = 7;
            label1.Text = "&Back Color:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BackColorCom
            // 
            BackColorCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BackColorCom.Items.AddRange([
            "None",
            "Red",
            "Green",
            "Blue",
            "Yellow"]);
            BackColorCom.Location = new Point(168, 116);
            BackColorCom.Name = "BackColorCom";
            BackColorCom.Size = new Size(121, 22);
            BackColorCom.TabIndex = 8;
            BackColorCom.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // Title
            // 
            Title.Location = new Point(8, 4);
            Title.Name = "Title";
            Title.Size = new Size(280, 22);
            Title.TabIndex = 0;
            Title.Text = "Sales Report\\nYear 2001";
            Title.TextChanged += new EventHandler(ControlChange);
            // 
            // Chart1
            // 
            Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            Chart1.BorderlineWidth = 2;
            Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 5;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 60);
            Chart1.Name = "Chart1";
            Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
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
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
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
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Sales Report\\nYear 2001";
            Chart1.Titles.Add(title1);
            // 
            // ChartTitle
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "ChartTitle";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void AxisTitle_Load(object sender, EventArgs e)
		{ 
		
		}

		private void ControlChange(object sender, EventArgs e)
		{
			
			// Set selected axis
			Chart1.Titles[0].Text = Title.Text;

			// Set Font style.
			FontStyle fontStyle = FontStyle.Regular;
			
			// Set Title font
			if(TheFont.SelectedIndex >= 0 && FontSize.SelectedIndex >= 0)
			{
				string font = TheFont.SelectedItem.ToString();
				float fontpoint = float.Parse(FontSize.SelectedItem.ToString());
				try
				{
					Chart1.Titles[0].Font = new Font(font, fontpoint, fontStyle);
				}
				catch
				{
					Chart1.Titles[0].Font = new Font("Arial", fontpoint, fontStyle);
				}
			}

			// Set Title alignment
			if( Alignment.SelectedIndex == 0 )
			{
				Chart1.Titles[0].Alignment = ContentAlignment.MiddleLeft;
			}
			else if( Alignment.SelectedIndex == 1 )
			{
				Chart1.Titles[0].Alignment = ContentAlignment.MiddleCenter;
			}
			else
			{
				Chart1.Titles[0].Alignment = ContentAlignment.MiddleRight;
			}

			// Set Title color
			if(FontColorCombo.SelectedIndex >= 0)
			{
				Chart1.Titles[0].ForeColor = Color.FromName(FontColorCombo.SelectedItem.ToString());
			}

			// Set Border Title color
			if(BorderColor.SelectedIndex > 0)
			{
				Chart1.Titles[0].BorderColor = Color.FromName(BorderColor.SelectedItem.ToString());
			}
			else
			{
				Chart1.Titles[0].BorderColor =  Color.Empty;
			}

			// Set Background Title color
			if(BackColorCom.SelectedIndex > 0)
			{
				Chart1.Titles[0].BackColor = Color.FromName(BackColorCom.SelectedItem.ToString());
			}
			else
			{
				Chart1.Titles[0].BackColor =  Color.Empty;
			}

			// Set Tooltip
			Chart1.Titles[0].ToolTip = ToolTip.Text;

		}

	}
}
