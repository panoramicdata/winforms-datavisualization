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
	public class AxisTitle : UserControl
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
		private ComboBox AxisPosition;
		private Label label1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AxisTitle()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			AxisPosition.Items.Add("Axis X");
			AxisPosition.Items.Add("Axis Y");
			AxisPosition.Items.Add("Axis X2");
			AxisPosition.Items.Add("Axis Y2");
			AxisPosition.SelectedIndex = 0;	// X Axis
			
			// Add Chart Line styles to control.
			foreach(FontFamily fontName in FontFamily.Families)
			{
				TheFont.Items.Add(fontName.Name);
			}
			
			TheFont.SelectedIndex = TheFont.Items.IndexOf("Trebuchet MS"); // "Verdana"
			if ( TheFont.SelectedIndex == -1)
			{
				TheFont.SelectedIndex = 0; // "Arial"
			}
			
			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				FontColorCombo.Items.Add(colorName);
			}
			FontColorCombo.SelectedIndex = 9;	// "Control Text"

			FontSize.SelectedIndex = FontSize.Items.IndexOf("12");
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
			CustomLabel customLabel1 = new CustomLabel();
			CustomLabel customLabel2 = new CustomLabel();
			CustomLabel customLabel3 = new CustomLabel();
			CustomLabel customLabel4 = new CustomLabel();
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
            TheFont = new ComboBox();
            FontColorCombo = new ComboBox();
            AxisPosition = new ComboBox();
            FontSize = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            StrikeoutCheck = new CheckBox();
            UnderlineCheck = new CheckBox();
            BoldCheck = new CheckBox();
            Title = new TextBox();
            ItalicCheck = new CheckBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // TheFont
            // 
            TheFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            TheFont.Location = new Point(167, 72);
            TheFont.Name = "TheFont";
            TheFont.Size = new Size(121, 22);
            TheFont.TabIndex = 5;
            TheFont.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // FontColorCombo
            // 
            FontColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FontColorCombo.Location = new Point(167, 136);
            FontColorCombo.Name = "FontColorCombo";
            FontColorCombo.Size = new Size(121, 22);
            FontColorCombo.TabIndex = 9;
            FontColorCombo.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // AxisPosition
            // 
            AxisPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            AxisPosition.Location = new Point(167, 40);
            AxisPosition.Name = "AxisPosition";
            AxisPosition.Size = new Size(121, 22);
            AxisPosition.TabIndex = 3;
            AxisPosition.SelectedIndexChanged += new EventHandler(ControlChange);
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
            FontSize.Location = new Point(167, 104);
            FontSize.Name = "FontSize";
            FontSize.Size = new Size(121, 22);
            FontSize.TabIndex = 7;
            FontSize.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // label5
            // 
            label5.Location = new Point(8, 80);
            label5.Name = "label5";
            label5.Size = new Size(156, 16);
            label5.TabIndex = 4;
            label5.Text = "&Font:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(8, 40);
            label6.Name = "label6";
            label6.Size = new Size(156, 16);
            label6.TabIndex = 2;
            label6.Text = "&Axis:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(8, 144);
            label7.Name = "label7";
            label7.Size = new Size(156, 16);
            label7.TabIndex = 8;
            label7.Text = "Font &Color:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new Point(8, 104);
            label8.Name = "label8";
            label8.Size = new Size(156, 16);
            label8.TabIndex = 6;
            label8.Text = "&Font Size:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to set the appearance of the axis title.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(StrikeoutCheck);
            panel1.Controls.Add(UnderlineCheck);
            panel1.Controls.Add(BoldCheck);
            panel1.Controls.Add(Title);
            panel1.Controls.Add(ItalicCheck);
            panel1.Controls.Add(AxisPosition);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TheFont);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(FontSize);
            panel1.Controls.Add(FontColorCombo);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 296);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(156, 16);
            label1.TabIndex = 0;
            label1.Text = "Title &Text:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrikeoutCheck
            // 
            StrikeoutCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            StrikeoutCheck.Location = new Point(11, 264);
            StrikeoutCheck.Name = "StrikeoutCheck";
            StrikeoutCheck.Size = new Size(169, 24);
            StrikeoutCheck.TabIndex = 13;
            StrikeoutCheck.Text = "&Strikeout:";
            StrikeoutCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            StrikeoutCheck.CheckedChanged += new EventHandler(ControlChange);
            // 
            // UnderlineCheck
            // 
            UnderlineCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            UnderlineCheck.Location = new Point(11, 232);
            UnderlineCheck.Name = "UnderlineCheck";
            UnderlineCheck.Size = new Size(169, 24);
            UnderlineCheck.TabIndex = 12;
            UnderlineCheck.Text = "&Underline:";
            UnderlineCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            UnderlineCheck.CheckedChanged += new EventHandler(ControlChange);
            // 
            // BoldCheck
            // 
            BoldCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            BoldCheck.Location = new Point(11, 200);
            BoldCheck.Name = "BoldCheck";
            BoldCheck.Size = new Size(169, 24);
            BoldCheck.TabIndex = 11;
            BoldCheck.Text = "&Bold:";
            BoldCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            BoldCheck.CheckedChanged += new EventHandler(ControlChange);
            // 
            // Title
            // 
            Title.Location = new Point(168, 4);
            Title.Name = "Title";
            Title.Size = new Size(120, 22);
            Title.TabIndex = 1;
            Title.Text = "Axis Title";
            Title.TextChanged += new EventHandler(ControlChange);
            // 
            // ItalicCheck
            // 
            ItalicCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            ItalicCheck.Location = new Point(11, 168);
            ItalicCheck.Name = "ItalicCheck";
            ItalicCheck.Size = new Size(169, 24);
            ItalicCheck.TabIndex = 10;
            ItalicCheck.Text = "&Italic:";
            ItalicCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            ItalicCheck.CheckedChanged += new EventHandler(ControlChange);
            // 
            // Chart1
            // 
            Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
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
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX2.IsLabelAutoFit = false;
            chartArea1.AxisX2.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.TitleFont = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
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
            title1.Position.Width = 55F;
            title1.Position.X = 4F;
            title1.Position.Y = 4F;
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Chart Control for .NET Framework";
            title1.Visible = false;
            Chart1.Titles.Add(title1);
            // 
            // AxisTitle
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AxisTitle";
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
			int axis = 0;
			
			foreach( Axis item in Chart1.ChartAreas["Default"].Axes)
			{
				item.Title = String.Empty;
			}

			if(AxisPosition.SelectedIndex >= 0)
			{
				string strAxis = AxisPosition.SelectedItem.ToString();
				if(strAxis == "Axis X")
					axis = 0;
				if(strAxis == "Axis Y")
					axis = 1;
				if(strAxis == "Axis X2")
					axis = 2;
				if(strAxis == "Axis Y2")
					axis = 3;
			}
			// Set selected axis
			Chart1.ChartAreas["Default"].Axes[axis].Title = Title.Text;

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
					Chart1.ChartAreas["Default"].Axes[axis].TitleFont = new Font(font, fontpoint, fontStyle);
				}
				catch
				{
					Chart1.ChartAreas["Default"].Axes[axis].TitleFont = new Font("Arial", fontpoint, fontStyle);
				}
			}

			// Set Title color
			if(FontColorCombo.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].Axes[axis].TitleForeColor = Color.FromName(FontColorCombo.SelectedItem.ToString());
			}
		}

	}
}
