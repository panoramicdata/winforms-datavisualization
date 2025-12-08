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
	public class Borders : UserControl
	{
		private ComboBox SkinStyle;
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
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		private bool initialising = true;

		public Borders()
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

			// Add Chart Line styles to control.
			foreach(string skinStyle in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle)))
			{
				SkinStyle.Items.Add(skinStyle);
			}
			SkinStyle.SelectedIndex = 1;

			
			// Add Border styles to control.
			foreach(string colorName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)))
			{
				BorderDashStyle.Items.Add(colorName);
			}
			BorderDashStyle.SelectedIndex = BorderDashStyle.Items.IndexOf("Solid");

			// Add Colors to controls.
			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				ChartBackColor.Items.Add(colorName);
				ChartForeColor.Items.Add(colorName);
				BorderColor.Items.Add(colorName);
			}

			BorderColor.SelectedIndex = BorderColor.Items.IndexOf("Maroon");
			ChartBackColor.SelectedIndex = BorderColor.Items.IndexOf("PeachPuff");
			ChartForeColor.SelectedIndex = BorderColor.Items.IndexOf("White");

			BorderSize.SelectedIndex = 0;
			
			initialising = false;
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
            SkinStyle = new ComboBox();
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
            ChartBackColor.Location = new Point(168, 80);
            ChartBackColor.Name = "ChartBackColor";
            ChartBackColor.Size = new Size(121, 22);
            ChartBackColor.TabIndex = 2;
            ChartBackColor.SelectedIndexChanged += new EventHandler(SkinItems_Changed);
            // 
            // SkinStyle
            // 
            SkinStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SkinStyle.Location = new Point(168, 8);
            SkinStyle.Name = "SkinStyle";
            SkinStyle.Size = new Size(121, 22);
            SkinStyle.TabIndex = 0;
            SkinStyle.SelectedIndexChanged += new EventHandler(SkinStyle_SelectedIndexChanged);
            // 
            // ChartForeColor
            // 
            ChartForeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ChartForeColor.Location = new Point(168, 48);
            ChartForeColor.Name = "ChartForeColor";
            ChartForeColor.Size = new Size(121, 22);
            ChartForeColor.TabIndex = 1;
            ChartForeColor.SelectedIndexChanged += new EventHandler(SkinItems_Changed);
            // 
            // HatchStyle
            // 
            HatchStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            HatchStyle.Location = new Point(168, 144);
            HatchStyle.Name = "HatchStyle";
            HatchStyle.Size = new Size(121, 22);
            HatchStyle.TabIndex = 4;
            HatchStyle.SelectedIndexChanged += new EventHandler(SkinItems_Changed);
            // 
            // Gradient
            // 
            Gradient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Gradient.Location = new Point(168, 112);
            Gradient.Name = "Gradient";
            Gradient.Size = new Size(121, 22);
            Gradient.TabIndex = 3;
            Gradient.SelectedIndexChanged += new EventHandler(SkinItems_Changed);
            // 
            // BorderColor
            // 
            BorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BorderColor.Location = new Point(168, 216);
            BorderColor.Name = "BorderColor";
            BorderColor.Size = new Size(121, 22);
            BorderColor.TabIndex = 6;
            BorderColor.SelectedIndexChanged += new EventHandler(Border_Changed);
            // 
            // BorderDashStyle
            // 
            BorderDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BorderDashStyle.Location = new Point(168, 184);
            BorderDashStyle.Name = "BorderDashStyle";
            BorderDashStyle.Size = new Size(121, 22);
            BorderDashStyle.TabIndex = 5;
            BorderDashStyle.SelectedIndexChanged += new EventHandler(Border_Changed);
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
            BorderSize.Location = new Point(168, 248);
            BorderSize.Name = "BorderSize";
            BorderSize.Size = new Size(121, 22);
            BorderSize.TabIndex = 7;
            BorderSize.SelectedIndexChanged += new EventHandler(Border_Changed);
            // 
            // label1
            // 
            label1.Location = new Point(26, 11);
            label1.Name = "label1";
            label1.Size = new Size(136, 16);
            label1.TabIndex = 9;
            label1.Text = "&Skin Style:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(26, 51);
            label2.Name = "label2";
            label2.Size = new Size(136, 16);
            label2.TabIndex = 10;
            label2.Text = "&Fore Color:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(26, 83);
            label3.Name = "label3";
            label3.Size = new Size(136, 16);
            label3.TabIndex = 11;
            label3.Text = "&Back Color:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(26, 115);
            label4.Name = "label4";
            label4.Size = new Size(136, 16);
            label4.TabIndex = 12;
            label4.Text = "&Gradient:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(26, 147);
            label5.Name = "label5";
            label5.Size = new Size(136, 16);
            label5.TabIndex = 13;
            label5.Text = "&Hatch Style:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(26, 187);
            label6.Name = "label6";
            label6.Size = new Size(136, 16);
            label6.TabIndex = 14;
            label6.Text = "B&order Style:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(26, 219);
            label7.Name = "label7";
            label7.Size = new Size(136, 16);
            label7.TabIndex = 15;
            label7.Text = "Bo&rder Color:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new Point(26, 251);
            label8.Name = "label8";
            label8.Size = new Size(136, 16);
            label8.TabIndex = 16;
            label8.Text = "Bor&der Size:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 18;
            label9.Text = "This sample demonstrates how to set the appearance properties of a chart\'s border" +
                " skin.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(BorderDashStyle);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Gradient);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(HatchStyle);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SkinStyle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(BorderSize);
            panel1.Controls.Add(ChartBackColor);
            panel1.Controls.Add(ChartForeColor);
            panel1.Controls.Add(BorderColor);
            panel1.Location = new Point(432, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 0;
            // 
            // Chart1
            // 
            Chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            Chart1.BackSecondaryColor = System.Drawing.Color.White;
            Chart1.BorderlineColor = System.Drawing.Color.Maroon;
            Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 14;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 6;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 17;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5F;
            legend1.Position.Width = 40F;
            legend1.Position.X = 5F;
            legend1.Position.Y = 85F;
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 60);
            Chart1.Name = "Chart1";
            Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.Legend = "Legend2";
            series1.Name = "Series2";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Default";
            series2.Name = "Series3";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.CustomProperties = "DrawingStyle=Cylinder";
            series3.Legend = "Default";
            series3.Name = "Series4";
            series3.Points.Add(dataPoint9);
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
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
            title1.Text = "Chart Control for .NET Framework";
            Chart1.Titles.Add(title1);
            // 
            // Borders
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "Borders";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private bool IsFrameStyle()
		{
			return Chart1.BorderSkin.SkinStyle.ToString().Contains("Frame", StringComparison.CurrentCulture);
		}

		private void SkinStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Set Border Skin
			Chart1.BorderSkin.SkinStyle = (System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle)System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Parse(typeof(System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle), SkinStyle.SelectedItem.ToString());
			
			// disable controls
			ChartForeColor.Enabled = IsFrameStyle();
			ChartBackColor.Enabled = IsFrameStyle();
			Gradient.Enabled		= IsFrameStyle();
			HatchStyle.Enabled 	= IsFrameStyle();
			
			SkinItems_Changed( sender, e );
			Border_Changed( sender, e );
		}


		private void SkinItems_Changed(object sender, EventArgs e)
		{
			
			if ( initialising )
			{
				return;
			}

			// Set Fore Color
			Chart1.BorderSkin.BackSecondaryColor = Color.FromName(ChartForeColor.SelectedItem.ToString());		

			// Set Back Color
			Chart1.BorderSkin.BackColor = Color.FromName(ChartBackColor.SelectedItem.ToString());

			// Set Gradient Type
			Chart1.BorderSkin.BackGradientStyle = (System.Windows.Forms.DataVisualization.Charting.GradientStyle)System.Windows.Forms.DataVisualization.Charting.GradientStyle.Parse(typeof(System.Windows.Forms.DataVisualization.Charting.GradientStyle), Gradient.SelectedItem.ToString());

			// Disable hatch if gradient is active
			if( Chart1.BorderSkin.BackGradientStyle != System.Windows.Forms.DataVisualization.Charting.GradientStyle.None )
				HatchStyle.SelectedIndex = 0;

			// Set Hatch Style
			Chart1.BorderSkin.BackHatchStyle = (System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Parse(typeof(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle), HatchStyle.SelectedItem.ToString());

			// Disable gradient if hatch style is active
			if( Chart1.BorderSkin.BackHatchStyle != System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.None )
				Gradient.SelectedIndex = 0;		

		}

		private void Border_Changed(object sender, EventArgs e)
		{
			if ( initialising )
			{
				return;
			}

			System.Windows.Forms.DataVisualization.Charting.ChartDashStyle style = (System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Parse(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle), BorderDashStyle.SelectedItem.ToString());
			
			// set default appearance
			Chart1.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			Chart1.BorderSkin.BorderColor = Color.Empty;
			Chart1.BorderSkin.BorderWidth = 1;

			Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			Chart1.BorderlineColor = Color.Empty;
			Chart1.BorderlineWidth = 1;

			if ( IsFrameStyle() )
			{
				// Set Border Style
				Chart1.BorderSkin.BorderDashStyle = style;
				// Set Border Color
				Chart1.BorderSkin.BorderColor = Color.FromName(BorderColor.SelectedItem.ToString());
				// Set Border Width
				Chart1.BorderSkin.BorderWidth = int.Parse(BorderSize.SelectedItem.ToString());
			}
			else
			{
				// Set Border Style
				Chart1.BorderlineDashStyle = style;
				// Set Border Color
				Chart1.BorderlineColor = Color.FromName(BorderColor.SelectedItem.ToString());
				// Set Border Width
				Chart1.BorderlineWidth = int.Parse(BorderSize.SelectedItem.ToString());
			}
		}
	}
}
