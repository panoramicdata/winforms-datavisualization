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
	/// Summary description for AnnotationAppearance.
	/// </summary>
	public class AnnotationAppearance : UserControl
	{
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private ComboBox LineColor;
		private ComboBox LineDashStyle;
		private ComboBox FontName;
		private ComboBox FontSize;
		private Label FontLabel;
		private Label label4;
		private ComboBox FontColorCombo;
		private Label label3;
		private ComboBox FontStyle;
		private Label label1;
		private ComboBox AnnotationBackColor;
		private ComboBox Shadow;
		private Label label2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AnnotationAppearance()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			
			
			// Add Border styles to control.
			foreach(string lineName in Enum.GetNames(typeof(ChartDashStyle)))
			{
				LineDashStyle.Items.Add(lineName);
			}

			LineDashStyle.SelectedIndex = 5;
			Shadow.SelectedIndex = 2;
			FontSize.SelectedIndex = 0;
			FontName.SelectedIndex = 3;
			AnnotationBackColor.SelectedIndex = 0;
			FontStyle.SelectedIndex = 0;
			FontColorCombo.SelectedIndex = 0;
			LineColor.SelectedIndex = 1;

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
			CalloutAnnotation calloutAnnotation2 = new CalloutAnnotation();
			ChartArea chartArea2 = new ChartArea();
			Legend legend2 = new Legend();
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 700);
			DataPoint dataPoint12 = new DataPoint(0, 600);
			DataPoint dataPoint13 = new DataPoint(0, 800);
			DataPoint dataPoint14 = new DataPoint(0, 450);
			DataPoint dataPoint15 = new DataPoint(0, 700);
			Series series4 = new Series();
			DataPoint dataPoint16 = new DataPoint(0, 450);
			DataPoint dataPoint17 = new DataPoint(0, 300);
			DataPoint dataPoint18 = new DataPoint(0, 500);
			DataPoint dataPoint19 = new DataPoint(0, 400);
			DataPoint dataPoint20 = new DataPoint(0, 600);
            LineColor = new ComboBox();
            LineDashStyle = new ComboBox();
            Shadow = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            AnnotationBackColor = new ComboBox();
            label3 = new Label();
            FontStyle = new ComboBox();
            label4 = new Label();
            FontColorCombo = new ComboBox();
            FontLabel = new Label();
            FontSize = new ComboBox();
            FontName = new ComboBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // LineColor
            // 
            LineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LineColor.Items.AddRange([
            "Black",
            "DimGray",
            "Gainsboro",
            "Blue",
            "Red",
            "Magenta",
            "Purple",
            "Orange"]);
            LineColor.Location = new Point(168, 40);
            LineColor.Name = "LineColor";
            LineColor.Size = new Size(121, 22);
            LineColor.TabIndex = 3;
            LineColor.SelectedIndexChanged += new EventHandler(LineColor_SelectedIndexChanged);
            // 
            // LineDashStyle
            // 
            LineDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LineDashStyle.Location = new Point(168, 8);
            LineDashStyle.Name = "LineDashStyle";
            LineDashStyle.Size = new Size(121, 22);
            LineDashStyle.TabIndex = 1;
            LineDashStyle.SelectedIndexChanged += new EventHandler(LineDashStyle_SelectedIndexChanged);
            // 
            // Shadow
            // 
            Shadow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Shadow.Items.AddRange([
            "0",
            "1",
            "2",
            "3",
            "4"]);
            Shadow.Location = new Point(168, 72);
            Shadow.Name = "Shadow";
            Shadow.Size = new Size(121, 22);
            Shadow.TabIndex = 5;
            Shadow.SelectedIndexChanged += new EventHandler(Shadow_SelectedIndexChanged);
            // 
            // label6
            // 
            label6.Location = new Point(-16, 8);
            label6.Name = "label6";
            label6.Size = new Size(176, 23);
            label6.TabIndex = 0;
            label6.Text = "Line &Style:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(-16, 40);
            label7.Name = "label7";
            label7.Size = new Size(176, 23);
            label7.TabIndex = 2;
            label7.Text = "Line &Color:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label7.Click += new EventHandler(label7_Click);
            // 
            // label8
            // 
            label8.Location = new Point(-16, 72);
            label8.Name = "label8";
            label8.Size = new Size(176, 23);
            label8.TabIndex = 4;
            label8.Text = "&Shadow:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to set the appearance properties of an Annotation ob" +
                "ject. ";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(AnnotationBackColor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(FontStyle);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(FontColorCombo);
            panel1.Controls.Add(FontLabel);
            panel1.Controls.Add(FontSize);
            panel1.Controls.Add(FontName);
            panel1.Controls.Add(LineDashStyle);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(Shadow);
            panel1.Controls.Add(LineColor);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(24, 136);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 8;
            label2.Text = "F&ont Size:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(-16, 232);
            label1.Name = "label1";
            label1.Size = new Size(176, 23);
            label1.TabIndex = 14;
            label1.Text = "&Back Color:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AnnotationBackColor
            // 
            AnnotationBackColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            AnnotationBackColor.Items.AddRange([
            "LightYellow",
            "White",
            "Yellow",
            "Gainsboro",
            "Silver",
            "BurlyWood"]);
            AnnotationBackColor.Location = new Point(168, 232);
            AnnotationBackColor.Name = "AnnotationBackColor";
            AnnotationBackColor.Size = new Size(121, 22);
            AnnotationBackColor.TabIndex = 15;
            AnnotationBackColor.SelectedIndexChanged += new EventHandler(BackColor_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(-16, 200);
            label3.Name = "label3";
            label3.Size = new Size(176, 23);
            label3.TabIndex = 12;
            label3.Text = "Font St&yle:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FontStyle
            // 
            FontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FontStyle.Items.AddRange([
            "Default",
            "Shadow",
            "Emboss",
            "Embed",
            "Frame"]);
            FontStyle.Location = new Point(168, 200);
            FontStyle.Name = "FontStyle";
            FontStyle.Size = new Size(121, 22);
            FontStyle.TabIndex = 13;
            FontStyle.SelectedIndexChanged += new EventHandler(FontStyle_SelectedIndexChanged);
            // 
            // label4
            // 
            label4.Location = new Point(-16, 168);
            label4.Name = "label4";
            label4.Size = new Size(176, 23);
            label4.TabIndex = 10;
            label4.Text = "Fo&nt Color:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FontColorCombo
            // 
            FontColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FontColorCombo.Items.AddRange([
            "Black",
            "DimGray",
            "Gainsboro",
            "Blue",
            "Red",
            "Magenta",
            "Purple",
            "Orange"]);
            FontColorCombo.Location = new Point(168, 168);
            FontColorCombo.Name = "FontColorCombo";
            FontColorCombo.Size = new Size(121, 22);
            FontColorCombo.TabIndex = 11;
            FontColorCombo.SelectedIndexChanged += new EventHandler(FontColorCombo_SelectedIndexChanged);
            // 
            // FontLabel
            // 
            FontLabel.Location = new Point(-16, 104);
            FontLabel.Name = "FontLabel";
            FontLabel.Size = new Size(176, 23);
            FontLabel.TabIndex = 6;
            FontLabel.Text = "&Font:";
            FontLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FontSize
            // 
            FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FontSize.Items.AddRange([
            "8",
            "10",
            "12",
            "14"]);
            FontSize.Location = new Point(168, 136);
            FontSize.Name = "FontSize";
            FontSize.Size = new Size(56, 22);
            FontSize.TabIndex = 9;
            FontSize.SelectedIndexChanged += new EventHandler(FontSize_SelectedIndexChanged);
            // 
            // FontName
            // 
            FontName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FontName.Items.AddRange([
            "Microsoft Sans Serif",
            "Arial",
            "Times New Roman",
            "Tahoma"]);
            FontName.Location = new Point(168, 104);
            FontName.Name = "FontName";
            FontName.Size = new Size(121, 22);
            FontName.TabIndex = 7;
            FontName.SelectedIndexChanged += new EventHandler(FontName_SelectedIndexChanged);
            // 
            // Chart1
            // 
            calloutAnnotation2.AnchorDataPointName = "Default\\r0";
            calloutAnnotation2.AnchorOffsetX = 5;
            calloutAnnotation2.AnchorOffsetY = 7;
            calloutAnnotation2.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
            calloutAnnotation2.Name = "CloudAnnotation";
            calloutAnnotation2.Text = "Set my Appearance";
            Chart1.Annotations.Add(calloutAnnotation2);
            Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            Chart1.BorderlineWidth = 2;
            Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.Inclination = 15;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Perspective = 10;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.Name = "Default";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Enabled = false;
            legend2.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Default";
            Chart1.Legends.Add(legend2);
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series3.Legend = "Default";
            series3.Name = "Default";
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series4.ChartArea = "Default";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series4.Legend = "Default";
            series4.Name = "Series2";
            series4.Points.Add(dataPoint16);
            series4.Points.Add(dataPoint17);
            series4.Points.Add(dataPoint18);
            series4.Points.Add(dataPoint19);
            series4.Points.Add(dataPoint20);
            Chart1.Series.Add(series3);
            Chart1.Series.Add(series4);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            // 
            // AnnotationAppearance
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AnnotationAppearance";
            Size = new Size(728, 480);
            Load += new EventHandler(AnnotationAppearance_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void LineDashStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Annotations[0].LineDashStyle = 
				(ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), LineDashStyle.SelectedItem.ToString());
		
		}


		private void LineColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Annotations[0].LineColor = Color.FromName(LineColor.SelectedItem.ToString());
		}


		private void AnnotationAppearance_Load(object sender, EventArgs e)
		{
		
		}

		private void label7_Click(object sender, EventArgs e)
		{
		
		}

		private void label5_Click(object sender, EventArgs e)
		{
		
		}

		private void FontName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(FontSize.SelectedItem != null)
				Chart1.Annotations[0].Font = new Font(FontName.SelectedItem.ToString(), float.Parse(FontSize.SelectedItem.ToString()));
		}

		private void FontSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(FontName.SelectedItem != null)
				Chart1.Annotations[0].Font = new Font(FontName.SelectedItem.ToString(), float.Parse(FontSize.SelectedItem.ToString()));
		}

		private void FontColorCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Annotations[0].ForeColor = Color.FromName(FontColorCombo.SelectedItem.ToString());
		}

		private void FontStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Annotations[0].TextStyle = 
				(TextStyle)TextStyle.Parse(	typeof(TextStyle), FontStyle.SelectedItem.ToString());
		}

		private void BackColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Annotations[0].BackColor = Color.FromName(AnnotationBackColor.SelectedItem.ToString());
		
		}

		private void Shadow_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Annotations[0].ShadowOffset = int.Parse(Shadow.SelectedItem.ToString());
		
		}


	}
}
