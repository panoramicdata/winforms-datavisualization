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
	/// Summary description for ChartAppearance.
	/// </summary>
	public class ChartAppearance : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label2;
		private Label label10;
		private Label label12;
		private Label label13;
		private Label label14;
		private Label label16;
		private Label label1;
		private ComboBox HatchStyle;
		private ComboBox Gradient;
		private ComboBox BorderDashStyle;
		private ComboBox BorderColor;
		private ComboBox BorderSizeCom;
		private ComboBox ForeColorCom;
		private ComboBox BackColorCom;
		private CheckBox ShowImageCheck;
		private ComboBox ImageMode;
		private ComboBox ImageAlign;
		private Label label11;
		private Label label17;
		private	bool		loadingData = false;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public ChartAppearance()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Add Hatch styles to control.
			foreach(string colorName in Enum.GetNames(typeof(ChartHatchStyle)))
			{
				HatchStyle.Items.Add(colorName);
			}
		
			// Add Chart Gradient types to control.
			foreach(string colorName in Enum.GetNames(typeof(GradientStyle)))
			{
				Gradient.Items.Add(colorName);
			}

			// Add Chart Line styles to control.
			foreach(string colorName in Enum.GetNames(typeof(ChartDashStyle)))
			{
				BorderDashStyle.Items.Add(colorName);
			}

			
			// Add Chart Image Mode styles to control.
			foreach(string imageMode in Enum.GetNames(typeof(ChartImageWrapMode)))
			{
				ImageMode.Items.Add(imageMode);
			}
			ImageMode.SelectedIndex = 5;

			// Add Chart Image Align styles to control.
			foreach(string imageAlign in Enum.GetNames(typeof(ChartImageAlignmentStyle)))
			{
				ImageAlign.Items.Add(imageAlign);
			}
			ImageAlign.SelectedIndex = 2;
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
			DataPoint dataPoint1 = new DataPoint(1, 70);
			DataPoint dataPoint2 = new DataPoint(2, 80);
			DataPoint dataPoint3 = new DataPoint(3, 70);
			DataPoint dataPoint4 = new DataPoint(4, 85);
			Series series2 = new Series();
			DataPoint dataPoint5 = new DataPoint(1, 65);
			DataPoint dataPoint6 = new DataPoint(2, 70);
			DataPoint dataPoint7 = new DataPoint(3, 60);
			DataPoint dataPoint8 = new DataPoint(4, 75);
			Series series3 = new Series();
			DataPoint dataPoint9 = new DataPoint(1, 50);
			DataPoint dataPoint10 = new DataPoint(2, 55);
			DataPoint dataPoint11 = new DataPoint(3, 40);
			DataPoint dataPoint12 = new DataPoint(4, 70);
			Title title1 = new Title();
            label9 = new Label();
            panel1 = new Panel();
            ImageMode = new ComboBox();
            ImageAlign = new ComboBox();
            label11 = new Label();
            label17 = new Label();
            ShowImageCheck = new CheckBox();
            BorderDashStyle = new ComboBox();
            BorderSizeCom = new ComboBox();
            BorderColor = new ComboBox();
            HatchStyle = new ComboBox();
            Gradient = new ComboBox();
            ForeColorCom = new ComboBox();
            BackColorCom = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label16 = new Label();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(696, 32);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to set a chart\'s background appearance.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(ImageMode);
            panel1.Controls.Add(ImageAlign);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(ShowImageCheck);
            panel1.Controls.Add(BorderDashStyle);
            panel1.Controls.Add(BorderSizeCom);
            panel1.Controls.Add(BorderColor);
            panel1.Controls.Add(HatchStyle);
            panel1.Controls.Add(Gradient);
            panel1.Controls.Add(ForeColorCom);
            panel1.Controls.Add(BackColorCom);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label16);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // ImageMode
            // 
            ImageMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ImageMode.Location = new Point(168, 232);
            ImageMode.Name = "ImageMode";
            ImageMode.Size = new Size(120, 22);
            ImageMode.TabIndex = 16;
            ImageMode.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // ImageAlign
            // 
            ImageAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ImageAlign.Location = new Point(168, 256);
            ImageAlign.Name = "ImageAlign";
            ImageAlign.Size = new Size(120, 22);
            ImageAlign.TabIndex = 18;
            ImageAlign.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // label11
            // 
            label11.Location = new Point(66, 232);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 15;
            label11.Text = "Image &Mode:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            label17.Location = new Point(66, 256);
            label17.Name = "label17";
            label17.Size = new Size(100, 23);
            label17.TabIndex = 17;
            label17.Text = "Image &Align:";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShowImageCheck
            // 
            ShowImageCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            ShowImageCheck.Location = new Point(64, 208);
            ShowImageCheck.Name = "ShowImageCheck";
            ShowImageCheck.Size = new Size(120, 24);
            ShowImageCheck.TabIndex = 14;
            ShowImageCheck.Text = "Show &Image: ";
            ShowImageCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            ShowImageCheck.Click += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // BorderDashStyle
            // 
            BorderDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BorderDashStyle.Location = new Point(168, 168);
            BorderDashStyle.Name = "BorderDashStyle";
            BorderDashStyle.Size = new Size(120, 22);
            BorderDashStyle.TabIndex = 13;
            BorderDashStyle.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // BorderSizeCom
            // 
            BorderSizeCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BorderSizeCom.Items.AddRange([
            "1",
            "2",
            "3",
            "4",
            "5"]);
            BorderSizeCom.Location = new Point(168, 144);
            BorderSizeCom.Name = "BorderSizeCom";
            BorderSizeCom.Size = new Size(120, 22);
            BorderSizeCom.TabIndex = 11;
            BorderSizeCom.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // BorderColor
            // 
            BorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BorderColor.Items.AddRange([
            "MidnightBlue",
            "Red",
            "Green",
            "Blue",
            "Gray"]);
            BorderColor.Location = new Point(168, 120);
            BorderColor.Name = "BorderColor";
            BorderColor.Size = new Size(120, 22);
            BorderColor.TabIndex = 9;
            BorderColor.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // HatchStyle
            // 
            HatchStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            HatchStyle.Location = new Point(168, 56);
            HatchStyle.Name = "HatchStyle";
            HatchStyle.Size = new Size(120, 22);
            HatchStyle.TabIndex = 5;
            HatchStyle.SelectedIndexChanged += new EventHandler(HatchStyle_SelectedIndexChanged);
            // 
            // Gradient
            // 
            Gradient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Gradient.Location = new Point(168, 32);
            Gradient.Name = "Gradient";
            Gradient.Size = new Size(120, 22);
            Gradient.TabIndex = 3;
            Gradient.SelectedIndexChanged += new EventHandler(Gradient_SelectedIndexChanged);
            // 
            // ForeColorCom
            // 
            ForeColorCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ForeColorCom.Items.AddRange([
            "SkyBlue",
            "Yellow",
            "Coral",
            "Teal",
            "Gainsboro"]);
            ForeColorCom.Location = new Point(168, 80);
            ForeColorCom.Name = "ForeColorCom";
            ForeColorCom.Size = new Size(120, 22);
            ForeColorCom.TabIndex = 7;
            ForeColorCom.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // BackColorCom
            // 
            BackColorCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BackColorCom.Items.AddRange([
            "White",
            "AliceBlue",
            "Linen",
            "Pink",
            "Lime",
            "WhiteSmoke"]);
            BackColorCom.Location = new Point(168, 8);
            BackColorCom.Name = "BackColorCom";
            BackColorCom.Size = new Size(120, 22);
            BackColorCom.TabIndex = 1;
            BackColorCom.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(66, 168);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 12;
            label1.Text = "Border S&tyle:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 6;
            label2.Text = "Secondary Back C&olor:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Location = new Point(66, 144);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 10;
            label10.Text = "Border &Size:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.Location = new Point(66, 8);
            label12.Name = "label12";
            label12.Size = new Size(100, 23);
            label12.TabIndex = 0;
            label12.Text = "&Back Color:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.Location = new Point(66, 32);
            label13.Name = "label13";
            label13.Size = new Size(100, 23);
            label13.TabIndex = 2;
            label13.Text = "&Gradient:";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.Location = new Point(66, 120);
            label14.Name = "label14";
            label14.Size = new Size(100, 23);
            label14.TabIndex = 8;
            label14.Text = "Border &Color:";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            label16.Location = new Point(66, 56);
            label16.Name = "label16";
            label16.Size = new Size(100, 23);
            label16.TabIndex = 4;
            label16.Text = "&Hatch Style:";
            label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Chart1
            // 
            Chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            Chart1.BackSecondaryColor = System.Drawing.Color.White;
            Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
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
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 75F;
            chartArea1.Position.Width = 90F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 13F;
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
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
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
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Default";
            series2.Name = "Series3";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.CustomProperties = "DrawingStyle=Cylinder";
            series3.Legend = "Default";
            series3.Name = "Series4";
            series3.Points.Add(dataPoint9);
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.Position.Auto = false;
            title1.Position.Height = 8.738057F;
            title1.Position.Width = 80F;
            title1.Position.X = 4F;
            title1.Position.Y = 4F;
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Chart Control for .NET Framework";
            Chart1.Titles.Add(title1);
            // 
            // ChartAppearance
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "ChartAppearance";
            Size = new Size(728, 352);
            Load += new EventHandler(ChartAppearance_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void ChartAppearance_Load(object sender, EventArgs e)
		{
			BackColorCom.SelectedIndex = 0;
			Gradient.SelectedIndex = 0;
			ForeColorCom.SelectedIndex = 2;
			BorderColor.SelectedIndex = 0;
			HatchStyle.SelectedIndex = 0;
			BorderSizeCom.SelectedIndex = 1;
			BorderDashStyle.SelectedIndex = 5;
			
			ChartAppearanceChange();
		}

		private void ChartAppearanceChange()
		{
			// Enable/disable appearance controls
			ForeColorCom.Enabled = (HatchStyle.SelectedIndex != 0 || Gradient.SelectedIndex != 0);
			BorderColor.Enabled = (BorderDashStyle.SelectedIndex != 0);
			BorderSizeCom.Enabled = (BorderDashStyle.SelectedIndex != 0);

			// Set Back Color
			Chart1.BackColor = Color.FromName(BackColorCom.GetItemText(BackColorCom.SelectedItem));

			// Set Back Gradient End Color
			Chart1.BackSecondaryColor = Color.FromName(ForeColorCom.GetItemText(ForeColorCom.SelectedItem));

			// Set Gradient Type
			if( Gradient.SelectedItem != null )
				Chart1.BackGradientStyle = (GradientStyle)GradientStyle.Parse(typeof(GradientStyle), Gradient.GetItemText(Gradient.SelectedItem));

			// Set Gradient Type
			if( HatchStyle.SelectedItem != null )
				Chart1.BackHatchStyle = (ChartHatchStyle)ChartHatchStyle.Parse(typeof(ChartHatchStyle), HatchStyle.GetItemText(HatchStyle.SelectedItem));

			// Set background image
			if(!ShowImageCheck.Checked)
			{
				Chart1.BackImage = "";
				ImageAlign.Enabled = false;
				ImageMode.Enabled = false;
			}
			else
			{
				ImageMode.Enabled = true;
				ImageAlign.Enabled = (ImageMode.SelectedIndex == 5);

				// Set chart image
				MainForm mainForm = (MainForm)ParentForm;
                string imageFileName = mainForm.CurrentSamplePath;
				imageFileName += "\\Flag.gif";
				Chart1.BackImage = imageFileName;
				Chart1.BackImageTransparentColor = Color.Red;

				// Set Image Mode
				if( ImageMode.SelectedItem != null )
					Chart1.BackImageWrapMode = (ChartImageWrapMode)ChartImageWrapMode.Parse(typeof(ChartImageWrapMode), ImageMode.SelectedItem.ToString());

				// Set Image Alignment
				if( ImageAlign.SelectedItem != null )
					Chart1.BackImageAlignment = (ChartImageAlignmentStyle)ChartImageAlignmentStyle.Parse(typeof(ChartImageAlignmentStyle), ImageAlign.SelectedItem.ToString());
			}

			// Set Border Width
			if( BorderSizeCom.SelectedItem != null )
				Chart1.BorderWidth = int.Parse(BorderSizeCom.GetItemText(BorderSizeCom.SelectedItem));

			// Set Border Style
			if( BorderDashStyle.SelectedItem != null )
				Chart1.BorderDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), BorderDashStyle.GetItemText(BorderDashStyle.SelectedItem));

			// Set Border Color
			Chart1.BorderColor = Color.FromName(BorderColor.GetItemText(BorderColor.SelectedItem));
		}

		private void Combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			ChartAppearanceChange();
		}

		private void Gradient_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(!loadingData)
			{
				// Reset Hatching style
				loadingData = true;
				HatchStyle.SelectedIndex = 0;
				loadingData = false;

				ChartAppearanceChange();
			}
		}

		private void HatchStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(!loadingData)
			{
				// Reset Gradient style
				loadingData = true;
				Gradient.SelectedIndex = 0;
				loadingData = false;

				ChartAppearanceChange();
			}
		}
	}
}
