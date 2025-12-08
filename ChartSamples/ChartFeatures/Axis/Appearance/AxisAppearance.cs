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
	public class AxisAppearance : UserControl
	{
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private ComboBox LineColor;
		private ComboBox LineDashStyle;
		private ComboBox LineWidth;
		private ComboBox ArrowStyleCombo;
		private CheckBox AxisEnabledCheck;
		private Label label1;
		private Label label2;
		private TextBox textBoxAxisTooltip;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AxisAppearance()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Add Chart Line styles to control.
            foreach (string arrowStyle in Enum.GetNames(typeof(AxisArrowStyle)))
			{
				ArrowStyleCombo.Items.Add(arrowStyle);
			}
            ArrowStyleCombo.SelectedIndex = 0;

			
			// Add Border styles to control.
			foreach(string lineName in Enum.GetNames(typeof(ChartDashStyle)))
			{
				LineDashStyle.Items.Add(lineName);
			}
			LineDashStyle.SelectedIndex = 5;

			// Add Colors to controls.
			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				LineColor.Items.Add(colorName);
			}

			LineColor.SelectedIndex = LineColor.Items.IndexOf("DarkBlue");

			LineWidth.SelectedIndex = 1;

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
            ArrowStyleCombo = new ComboBox();
            LineColor = new ComboBox();
            LineDashStyle = new ComboBox();
            LineWidth = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            textBoxAxisTooltip = new TextBox();
            label2 = new Label();
            AxisEnabledCheck = new CheckBox();
            Chart1 = new Chart();
            label1 = new Label();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // ArrowStyleCombo
            // 
            ArrowStyleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ArrowStyleCombo.Location = new Point(168, 128);
            ArrowStyleCombo.Name = "ArrowStyleCombo";
            ArrowStyleCombo.Size = new Size(121, 22);
            ArrowStyleCombo.TabIndex = 8;
            ArrowStyleCombo.SelectedIndexChanged += new EventHandler(ArrowStyleCombo_SelectedIndexChanged);
            // 
            // LineColor
            // 
            LineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LineColor.Location = new Point(168, 64);
            LineColor.Name = "LineColor";
            LineColor.Size = new Size(121, 22);
            LineColor.TabIndex = 4;
            LineColor.SelectedIndexChanged += new EventHandler(LineColor_SelectedIndexChanged);
            // 
            // LineDashStyle
            // 
            LineDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LineDashStyle.Location = new Point(168, 96);
            LineDashStyle.Name = "LineDashStyle";
            LineDashStyle.Size = new Size(121, 22);
            LineDashStyle.TabIndex = 6;
            LineDashStyle.SelectedIndexChanged += new EventHandler(LineDashStyle_SelectedIndexChanged);
            // 
            // LineWidth
            // 
            LineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LineWidth.Items.AddRange([
            "1",
            "2",
            "3",
            "4"]);
            LineWidth.Location = new Point(168, 32);
            LineWidth.Name = "LineWidth";
            LineWidth.Size = new Size(121, 22);
            LineWidth.TabIndex = 2;
            LineWidth.SelectedIndexChanged += new EventHandler(LineWidth_SelectedIndexChanged);
            // 
            // label5
            // 
            label5.Location = new Point(8, 128);
            label5.Name = "label5";
            label5.Size = new Size(156, 16);
            label5.TabIndex = 7;
            label5.Text = "&Arrow Style:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(0, 96);
            label6.Name = "label6";
            label6.Size = new Size(164, 16);
            label6.TabIndex = 5;
            label6.Text = "Axis &Line Style:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(8, 64);
            label7.Name = "label7";
            label7.Size = new Size(156, 16);
            label7.TabIndex = 3;
            label7.Text = "Line &Color:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new Point(8, 35);
            label8.Name = "label8";
            label8.Size = new Size(156, 16);
            label8.TabIndex = 1;
            label8.Text = "Line &Width:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 1;
            label9.Text = "This sample demonstrates how to set the appearance of axis lines.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxAxisTooltip);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AxisEnabledCheck);
            panel1.Controls.Add(LineDashStyle);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(ArrowStyleCombo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(LineWidth);
            panel1.Controls.Add(LineColor);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 296);
            panel1.TabIndex = 0;
            // 
            // textBoxAxisTooltip
            // 
            textBoxAxisTooltip.Location = new Point(168, 160);
            textBoxAxisTooltip.MaxLength = 15;
            textBoxAxisTooltip.Name = "textBoxAxisTooltip";
            textBoxAxisTooltip.Size = new Size(120, 22);
            textBoxAxisTooltip.TabIndex = 10;
            textBoxAxisTooltip.Text = "Axis tooltip";
            textBoxAxisTooltip.TextChanged += new EventHandler(textBoxAxisTooltip_TextChanged);
            // 
            // label2
            // 
            label2.Location = new Point(45, 162);
            label2.Name = "label2";
            label2.Size = new Size(120, 16);
            label2.TabIndex = 9;
            label2.Text = "Axis &Tooltip:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AxisEnabledCheck
            // 
            AxisEnabledCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            AxisEnabledCheck.Checked = true;
            AxisEnabledCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            AxisEnabledCheck.Location = new Point(77, 4);
            AxisEnabledCheck.Name = "AxisEnabledCheck";
            AxisEnabledCheck.Size = new Size(104, 24);
            AxisEnabledCheck.TabIndex = 0;
            AxisEnabledCheck.Text = "&Visible:";
            AxisEnabledCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            AxisEnabledCheck.CheckedChanged += new EventHandler(Enabled_CheckedChanged);
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
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.IsLabelAutoFit = false;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.ToolTip = "Axis tooltip";
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.Legend = "Legend2";
            series1.Name = "Series2";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Default";
            series2.Name = "Series3";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
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
            Chart1.TabIndex = 2;
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Chart Control for .NET Framework";
            Chart1.Titles.Add(title1);
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 352);
            label1.Name = "label1";
            label1.Size = new Size(702, 64);
            label1.TabIndex = 3;
            label1.Text = "Note that each axis can have different visual attributes, including visibility. I" +
                "n this sample, changes are applied to the secondary Y axis.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AxisAppearance
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label1);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AxisAppearance";
            Size = new Size(728, 424);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void LineWidth_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.ChartAreas["Default"].AxisY2.LineWidth = int.Parse(LineWidth.SelectedItem.ToString());
		}

		private void LineDashStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.ChartAreas["Default"].AxisY2.LineDashStyle = 
				(ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), LineDashStyle.SelectedItem.ToString());
		
			LineWidth.Enabled = (LineDashStyle.SelectedIndex != 0);
			LineColor.Enabled = (LineDashStyle.SelectedIndex != 0);
		}

        private AxisArrowStyle FindStyle(string inputStyle)
        {
            foreach (AxisArrowStyle style in Enum.GetValues(typeof(AxisArrowStyle)))
            {
                if (inputStyle.ToLower() == style.ToString().ToLower())
                    return style;
            }
            return AxisArrowStyle.None;
        }
 
		private void ArrowStyleCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.ChartAreas["Default"].AxisY2.ArrowStyle = 
				FindStyle(ArrowStyleCombo.SelectedItem.ToString());
		}

		private void LineColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.ChartAreas["Default"].AxisY2.LineColor = Color.FromName(LineColor.SelectedItem.ToString());
		}

		private void Enabled_CheckedChanged(object sender, EventArgs e)
		{
			if(AxisEnabledCheck.Checked)
				Chart1.ChartAreas["Default"].AxisY2.Enabled = AxisEnabled.True;
			else
				Chart1.ChartAreas["Default"].AxisY2.Enabled = AxisEnabled.False;

			LineWidth.Enabled = AxisEnabledCheck.Checked;
			LineDashStyle.Enabled = AxisEnabledCheck.Checked;
			ArrowStyleCombo.Enabled = AxisEnabledCheck.Checked;
			LineColor.Enabled = AxisEnabledCheck.Checked;
		}

		private void textBoxAxisTooltip_TextChanged(object sender, EventArgs e)
		{
			Chart1.ChartAreas["Default"].AxisY2.ToolTip = textBoxAxisTooltip.Text;
		}

	}
}
