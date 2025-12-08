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
	/// Summary description for AxisAppearance.
	/// </summary>
	public class LabelsTextStyle : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label15;
		private Label label1;
		private Label label2;
		private Label label7;
		private ComboBox FontNameList;
		private ComboBox FontSizeList;
		private ComboBox AngleList;
		private CheckBox OffsetLabels;
		private CheckBox EnableLabels;
		private CheckBox TextAntiAlias;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public LabelsTextStyle()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize combo boxes
			FontNameList.SelectedIndex = 2;
			FontSizeList.SelectedIndex = 1;
			AngleList.SelectedIndex = 0;
			OffsetLabels.Checked = false;
			EnableLabels.Checked = true;
			TextAntiAlias.Checked = true;
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
			Legend legend2 = new Legend();
			Legend legend3 = new Legend();
			LegendItem legendItem1 = new LegendItem();
			LegendItem legendItem2 = new LegendItem();
			LegendItem legendItem3 = new LegendItem();
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
            TextAntiAlias = new CheckBox();
            EnableLabels = new CheckBox();
            OffsetLabels = new CheckBox();
            AngleList = new ComboBox();
            label7 = new Label();
            FontSizeList = new ComboBox();
            label2 = new Label();
            FontNameList = new ComboBox();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label15 = new Label();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 43);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to set an axis labels\' font, angle, and offset style" +
                ". It also shows how to enable and disable axis labels.  ";
            // 
            // panel1
            // 
            panel1.Controls.Add(TextAntiAlias);
            panel1.Controls.Add(EnableLabels);
            panel1.Controls.Add(OffsetLabels);
            panel1.Controls.Add(AngleList);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(FontSizeList);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(FontNameList);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(432, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // TextAntiAlias
            // 
            TextAntiAlias.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            TextAntiAlias.Location = new Point(17, 168);
            TextAntiAlias.Name = "TextAntiAlias";
            TextAntiAlias.Size = new Size(164, 24);
            TextAntiAlias.TabIndex = 8;
            TextAntiAlias.Text = "AntiAlias For &Text:";
            TextAntiAlias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            TextAntiAlias.CheckedChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // EnableLabels
            // 
            EnableLabels.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            EnableLabels.Location = new Point(8, 136);
            EnableLabels.Name = "EnableLabels";
            EnableLabels.Size = new Size(168, 24);
            EnableLabels.TabIndex = 7;
            EnableLabels.Text = "&Enable X Axis Labels:";
            EnableLabels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            EnableLabels.CheckedChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // OffsetLabels
            // 
            OffsetLabels.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            OffsetLabels.Location = new Point(17, 104);
            OffsetLabels.Name = "OffsetLabels";
            OffsetLabels.Size = new Size(164, 24);
            OffsetLabels.TabIndex = 6;
            OffsetLabels.Text = "&Offset X Axis Labels:";
            OffsetLabels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            OffsetLabels.CheckedChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // AngleList
            // 
            AngleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            AngleList.Items.AddRange([
            "0",
            "30",
            "45",
            "60",
            "90",
            "-30",
            "-45",
            "-60",
            "-90"]);
            AngleList.Location = new Point(168, 72);
            AngleList.Name = "AngleList";
            AngleList.Size = new Size(120, 22);
            AngleList.TabIndex = 5;
            AngleList.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // label7
            // 
            label7.Location = new Point(4, 72);
            label7.Name = "label7";
            label7.Size = new Size(160, 24);
            label7.TabIndex = 4;
            label7.Text = "X Axis Labels &Angle:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FontSizeList
            // 
            FontSizeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FontSizeList.Items.AddRange([
            "6",
            "8",
            "10",
            "12",
            "14",
            "16"]);
            FontSizeList.Location = new Point(168, 40);
            FontSizeList.Name = "FontSizeList";
            FontSizeList.Size = new Size(120, 22);
            FontSizeList.TabIndex = 3;
            FontSizeList.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(4, 40);
            label2.Name = "label2";
            label2.Size = new Size(160, 24);
            label2.TabIndex = 2;
            label2.Text = "X Axis Labels Font &Size:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FontNameList
            // 
            FontNameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FontNameList.Items.AddRange([
            "Arial",
            "Courier New",
            "Tahoma",
            "Trebuchet MS",
            "Verdana"]);
            FontNameList.Location = new Point(168, 8);
            FontNameList.Name = "FontNameList";
            FontNameList.Size = new Size(120, 22);
            FontNameList.TabIndex = 1;
            FontNameList.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(0, 8);
            label1.Name = "label1";
            label1.Size = new Size(164, 24);
            label1.TabIndex = 0;
            label1.Text = "X Axis Labels Font &Name:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(64, 403);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 12;
            label6.Text = "Border Size:";
            // 
            // label5
            // 
            label5.Location = new Point(64, 380);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 11;
            label5.Text = "Border Color:";
            // 
            // label4
            // 
            label4.Location = new Point(64, 357);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 10;
            label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            label3.Location = new Point(64, 334);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 9;
            label3.Text = "Gradient:";
            // 
            // label15
            // 
            label15.Location = new Point(64, 426);
            label15.Name = "label15";
            label15.Size = new Size(100, 23);
            label15.TabIndex = 5;
            label15.Text = "Border Size:";
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
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            legend2.Enabled = false;
            legend2.Name = "Legend2";
            legend3.BackColor = System.Drawing.Color.Transparent;
            legendItem1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            legendItem1.Name = "Previous Month Avg";
            legendItem2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            legendItem2.Name = "Last Week";
            legendItem3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            legendItem3.Name = "This Week";
            legend3.CustomItems.Add(legendItem1);
            legend3.CustomItems.Add(legendItem2);
            legend3.CustomItems.Add(legendItem3);
            legend3.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend3.IsTextAutoFit = false;
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend3.Name = "Legend3";
            legend3.Position.Auto = false;
            legend3.Position.Height = 12F;
            legend3.Position.Width = 90F;
            legend3.Position.X = 5F;
            legend3.Position.Y = 85F;
            Chart1.Legends.Add(legend1);
            Chart1.Legends.Add(legend2);
            Chart1.Legends.Add(legend3);
            Chart1.Location = new Point(16, 60);
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
            Chart1.Click += new EventHandler(Chart1_Click);
            // 
            // LabelsTextStyle
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "LabelsTextStyle";
            Size = new Size(728, 480);
            Load += new EventHandler(LabelsTextStyle_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion
		
		private void Combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Labels();
		}

		private void Labels()
		{
			if(
				FontNameList.SelectedItem == null ||
				FontSizeList.SelectedItem == null ||
				AngleList.SelectedItem == null
				)
			{
				return;
			}

			// Disable axis labels text auto fitting
			Chart1.ChartAreas["Default"].AxisX.IsLabelAutoFit = false;

			// Set axis labels font
			Chart1.ChartAreas["Default"].AxisX.LabelStyle.Font = new Font(FontNameList.GetItemText(FontNameList.SelectedItem), int.Parse(FontSizeList.GetItemText(FontSizeList.SelectedItem)));

			// Set axis labels angle
			AngleList.Enabled = !OffsetLabels.Checked;
			Chart1.ChartAreas["Default"].AxisX.LabelStyle.Angle = int.Parse(AngleList.GetItemText(AngleList.SelectedItem));

			// Set offset labels style
			Chart1.ChartAreas["Default"].AxisX.LabelStyle.IsStaggered = OffsetLabels.Checked;

			// Disable X axis labels
			Chart1.ChartAreas["Default"].AxisX.LabelStyle.Enabled = EnableLabels.Checked;

			// Enable AntiAliasing for either Text and Graphics or just Graphics
			if(TextAntiAlias.Checked)
                Chart1.AntiAliasing = AntiAliasingStyles.All;
			else
				Chart1.AntiAliasing = AntiAliasingStyles.Graphics;
			
		}

		private void Chart1_Click(object sender, EventArgs e)
		{
		
		}

		private void LabelsTextStyle_Load(object sender, EventArgs e)
		{
			Labels();
		}


		
	}
}
