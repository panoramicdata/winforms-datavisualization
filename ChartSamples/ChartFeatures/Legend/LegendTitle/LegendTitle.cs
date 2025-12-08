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
	/// Summary description for LegendCellColumns.
	/// </summary>
	public class LegendTitle : UserControl
	{
		#region Fields

		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Container components = null;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox tb_Text;
		private ComboBox cb_Color;
		private ComboBox cb_Separator;
		private Label label5;
		private ComboBox cb_SeparatorColor;
		private ComboBox cb_Alignment;
		private ComboBox cb_Docking;
		private Label label6;
		private Label label1;

		#endregion

		# region Constructor

		public LegendTitle()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
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

		#endregion

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
			DataPoint dataPoint1 = new DataPoint(0, 700);
			DataPoint dataPoint2 = new DataPoint(0, 400);
			DataPoint dataPoint3 = new DataPoint(0, 200);
			DataPoint dataPoint4 = new DataPoint(0, 450);
			DataPoint dataPoint5 = new DataPoint(0, 300);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 154);
			DataPoint dataPoint7 = new DataPoint(0, 760);
			DataPoint dataPoint8 = new DataPoint(0, 345);
			DataPoint dataPoint9 = new DataPoint(0, 700);
			DataPoint dataPoint10 = new DataPoint(0, 700);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 357);
			DataPoint dataPoint12 = new DataPoint(0, 200);
			DataPoint dataPoint13 = new DataPoint(0, 300);
			DataPoint dataPoint14 = new DataPoint(0, 400);
			DataPoint dataPoint15 = new DataPoint(0, 342);
            label9 = new Label();
            panel1 = new Panel();
            cb_Docking = new ComboBox();
            label6 = new Label();
            cb_Alignment = new ComboBox();
            label1 = new Label();
            cb_SeparatorColor = new ComboBox();
            label5 = new Label();
            cb_Separator = new ComboBox();
            cb_Color = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tb_Text = new TextBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 16);
            label9.Name = "label9";
            label9.Size = new Size(702, 24);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to set the font and color of the legend\'s title text" +
                ".";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(cb_Docking);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cb_Alignment);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cb_SeparatorColor);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cb_Separator);
            panel1.Controls.Add(cb_Color);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tb_Text);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 296);
            panel1.TabIndex = 0;
            // 
            // cb_Docking
            // 
            cb_Docking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_Docking.Items.AddRange([
            "Right",
            "Top",
            "Bottom",
            "Left"]);
            cb_Docking.Location = new Point(168, 174);
            cb_Docking.Name = "cb_Docking";
            cb_Docking.Size = new Size(142, 22);
            cb_Docking.TabIndex = 5;
            cb_Docking.SelectedIndexChanged += new EventHandler(cb_Docking_SelectedIndexChanged);
            // 
            // label6
            // 
            label6.Location = new Point(20, 177);
            label6.Name = "label6";
            label6.Size = new Size(136, 16);
            label6.TabIndex = 10;
            label6.Text = "Legend Docking:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_Alignment
            // 
            cb_Alignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_Alignment.Location = new Point(168, 76);
            cb_Alignment.Name = "cb_Alignment";
            cb_Alignment.Size = new Size(142, 22);
            cb_Alignment.TabIndex = 2;
            cb_Alignment.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(54, 77);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 8;
            label1.Text = "Title Alignment:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_SeparatorColor
            // 
            cb_SeparatorColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_SeparatorColor.Items.AddRange([
            "Black",
            "Blue",
            "Orange",
            "Gray"]);
            cb_SeparatorColor.Location = new Point(168, 141);
            cb_SeparatorColor.Name = "cb_SeparatorColor";
            cb_SeparatorColor.Size = new Size(142, 22);
            cb_SeparatorColor.TabIndex = 4;
            cb_SeparatorColor.SelectedIndexChanged += new EventHandler(cb_SeparatorColor_SelectedIndexChanged);
            // 
            // label5
            // 
            label5.Location = new Point(45, 141);
            label5.Name = "label5";
            label5.Size = new Size(112, 24);
            label5.TabIndex = 6;
            label5.Text = "Separator Color:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_Separator
            // 
            cb_Separator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_Separator.Location = new Point(168, 108);
            cb_Separator.Name = "cb_Separator";
            cb_Separator.Size = new Size(142, 22);
            cb_Separator.TabIndex = 3;
            cb_Separator.SelectedIndexChanged += new EventHandler(cb_Separator_SelectedIndexChanged);
            // 
            // cb_Color
            // 
            cb_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_Color.Items.AddRange([
            "Black",
            "Blue",
            "Orange",
            "Gray"]);
            cb_Color.Location = new Point(168, 43);
            cb_Color.Name = "cb_Color";
            cb_Color.Size = new Size(142, 22);
            cb_Color.TabIndex = 1;
            cb_Color.SelectedIndexChanged += new EventHandler(cb_Color_SelectedIndexChanged);
            // 
            // label4
            // 
            label4.Location = new Point(77, 43);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 3;
            label4.Text = "Title Color:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(53, 109);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 2;
            label3.Text = "Title Separator:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(77, 9);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 1;
            label2.Text = "Title Text:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Text
            // 
            tb_Text.Location = new Point(168, 8);
            tb_Text.MaxLength = 25;
            tb_Text.Name = "tb_Text";
            tb_Text.Size = new Size(142, 22);
            tb_Text.TabIndex = 0;
            tb_Text.Text = "Chart\\n Control";
            tb_Text.TextChanged += new EventHandler(tb_Text_TextChanged);
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
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Interval = 0;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 0;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Interval = 0;
            chartArea1.AxisX.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.LabelStyle.Interval = 0;
            chartArea1.AxisX2.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisX2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorGrid.Interval = 0;
            chartArea1.AxisX2.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisX2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorTickMark.Interval = 0;
            chartArea1.AxisX2.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisX2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.Interval = 0;
            chartArea1.AxisY.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Interval = 0;
            chartArea1.AxisY.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.Interval = 0;
            chartArea1.AxisY.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.LabelStyle.Interval = 0;
            chartArea1.AxisY2.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisY2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Interval = 0;
            chartArea1.AxisY2.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisY2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorTickMark.Interval = 0;
            chartArea1.AxisY2.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisY2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            legend1.Title = "Chart \\nControl";
            legend1.TitleFont = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend1.TitleSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 56);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
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
            // LegendTitle
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "LegendTitle";
            Size = new Size(776, 480);
            Load += new EventHandler(LegendTitle_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void LegendTitle_Load(object sender, EventArgs e)
		{
			tb_Text.Text = @"Chart Control";
			cb_Color.SelectedIndex = 0;

			foreach(string sepTypes in Enum.GetNames(typeof(LegendSeparatorStyle)))
			{
				cb_Separator.Items.Add(sepTypes);
			}

			foreach(string alignmentTypes in Enum.GetNames(typeof(StringAlignment)))
			{
				cb_Alignment.Items.Add(alignmentTypes);
			}

			cb_Separator.SelectedIndex = 3;
			cb_SeparatorColor.SelectedIndex = 0;
			cb_Alignment.SelectedIndex = 1;
			cb_Docking.SelectedIndex = 2;
		}

		private void cb_Color_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Legends["Default"].TitleForeColor = Color.FromName(cb_Color.SelectedItem.ToString());
		}

		private void tb_Text_TextChanged(object sender, EventArgs e)
		{
			string legendTitleText = tb_Text.Text;
			Chart1.Legends["Default"].Title = legendTitleText;

			if (legendTitleText == String.Empty) 
			{
				cb_Alignment.Enabled = false;
				cb_Separator.Enabled = false;
				cb_SeparatorColor.Enabled = false;
				cb_Color.Enabled = false;
			}

			else
			{
				cb_Alignment.Enabled = true;
				cb_Separator.Enabled = true;
				cb_SeparatorColor.Enabled = true;				
				cb_Color.Enabled = true;
			}
		
			
		}

		private void cb_Separator_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Legends["Default"].TitleSeparator = (LegendSeparatorStyle)LegendSeparatorStyle.Parse(typeof(LegendSeparatorStyle), cb_Separator.SelectedItem.ToString());
			if (cb_Separator.SelectedItem.ToString() == "None") 
			{
				cb_SeparatorColor.Enabled = false;
			}

			else 
				cb_SeparatorColor.Enabled = true;
		}

		private void cb_SeparatorColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Legends["Default"].TitleSeparatorColor = Color.FromName(cb_SeparatorColor.SelectedItem.ToString());		
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Legends["Default"].TitleAlignment = (StringAlignment)StringAlignment.Parse(typeof(StringAlignment), cb_Alignment.SelectedItem.ToString());
		}

		private void cb_Docking_SelectedIndexChanged(object sender, EventArgs e)
		{
			Chart1.Legends["Default"].Docking = (Docking)Docking.Parse(typeof(Docking), cb_Docking.SelectedItem.ToString());
		}
	}
}