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
	/// Summary description for CursorInterval.
	/// </summary>
	public class CursorInterval : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label15;
		private Label label1;
		private Label label2;
		private Label label10;
		private ComboBox YInterval;
		private ComboBox XInterval;
		private ComboBox XIntervalType;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public CursorInterval()
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
			DataPoint dataPoint1 = new DataPoint(37530, 3);
			DataPoint dataPoint2 = new DataPoint(37531, 7);
			DataPoint dataPoint3 = new DataPoint(37532, 8);
			DataPoint dataPoint4 = new DataPoint(37533, 6);
			DataPoint dataPoint5 = new DataPoint(37534, 7);
			DataPoint dataPoint6 = new DataPoint(37535, 7);
			DataPoint dataPoint7 = new DataPoint(37536, 8);
			DataPoint dataPoint8 = new DataPoint(37537, 9);
			DataPoint dataPoint9 = new DataPoint(37539, 4);
			DataPoint dataPoint10 = new DataPoint(37541, 6);
			DataPoint dataPoint11 = new DataPoint(37542, 3);
			DataPoint dataPoint12 = new DataPoint(37543, 6);
			DataPoint dataPoint13 = new DataPoint(37544, 2);
			DataPoint dataPoint14 = new DataPoint(37545, 1);
			DataPoint dataPoint15 = new DataPoint(37546, 5);
			Title title1 = new Title();
            label9 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            XIntervalType = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            YInterval = new ComboBox();
            XInterval = new ComboBox();
            label8 = new Label();
            label7 = new Label();
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
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to set the cursor interval so that the cursor will \"" +
                "step\" as it moves across the data view. To move the cursor, left-click on the ch" +
                "art and drag the mouse.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(XIntervalType);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(YInterval);
            panel1.Controls.Add(XInterval);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
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
            // label10
            // 
            label10.Location = new Point(32, 40);
            label10.Name = "label10";
            label10.Size = new Size(136, 23);
            label10.TabIndex = 2;
            label10.Text = "Interval &Type:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // XIntervalType
            // 
            XIntervalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            XIntervalType.Items.AddRange([
            "Hours",
            "Days",
            "Weeks"]);
            XIntervalType.Location = new Point(168, 40);
            XIntervalType.Name = "XIntervalType";
            XIntervalType.Size = new Size(121, 22);
            XIntervalType.TabIndex = 3;
            XIntervalType.SelectedIndexChanged += new EventHandler(Series_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(32, 72);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 4;
            label2.Text = "&Y Interval:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(32, 8);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 0;
            label1.Text = "&X Interval:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YInterval
            // 
            YInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            YInterval.Items.AddRange([
            "0",
            "1",
            "2"]);
            YInterval.Location = new Point(168, 72);
            YInterval.Name = "YInterval";
            YInterval.Size = new Size(121, 22);
            YInterval.TabIndex = 5;
            YInterval.SelectedIndexChanged += new EventHandler(Series_SelectedIndexChanged);
            // 
            // XInterval
            // 
            XInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            XInterval.Items.AddRange([
            "0",
            "1",
            "2",
            "12"]);
            XInterval.Location = new Point(168, 8);
            XInterval.Name = "XInterval";
            XInterval.Size = new Size(121, 22);
            XInterval.TabIndex = 1;
            XInterval.SelectedIndexChanged += new EventHandler(Series_SelectedIndexChanged);
            // 
            // label8
            // 
            label8.Location = new Point(64, 472);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 7;
            label8.Text = "Shadow Offset:";
            // 
            // label7
            // 
            label7.Location = new Point(64, 449);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 6;
            label7.Text = "Border Style:";
            // 
            // label6
            // 
            label6.Location = new Point(64, 403);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 5;
            label6.Text = "Border Size:";
            // 
            // label5
            // 
            label5.Location = new Point(64, 380);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 4;
            label5.Text = "Border Color:";
            // 
            // label4
            // 
            label4.Location = new Point(64, 357);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            label3.Location = new Point(64, 334);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
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
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "dd/MM";
            chartArea1.AxisX.LabelStyle.Interval = 0;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Interval = 1;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Interval = 1;
            chartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.MinorTickMark.Interval = 12;
            chartArea1.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Format = "N0";
            chartArea1.AxisY.LabelStyle.Interval = 0;
            chartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Interval = 1;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.MinorTickMark.Interval = 1;
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.SelectionColor = System.Drawing.SystemColors.Highlight;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.CursorY.SelectionColor = System.Drawing.SystemColors.Highlight;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 60);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.Points.Add(dataPoint10);
            series1.Points.Add(dataPoint11);
            series1.Points.Add(dataPoint12);
            series1.Points.Add(dataPoint13);
            series1.Points.Add(dataPoint14);
            series1.Points.Add(dataPoint15);
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.ShadowOffset = 2;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Cursor Intervals";
            Chart1.Titles.Add(title1);
            // 
            // CursorInterval
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "CursorInterval";
            Size = new Size(728, 376);
            Load += new EventHandler(CursorInterval_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void Series_SelectedIndexChanged(object sender, EventArgs e)
		{
			if( XInterval.SelectedItem == null ||
				XIntervalType.SelectedItem == null ||
						YInterval.SelectedItem == null )
			{
				return;
			}

			Chart1.ChartAreas["Default"].CursorX.Interval = int.Parse(XInterval.SelectedItem.ToString());
			Chart1.ChartAreas["Default"].CursorX.IntervalType = (DateTimeIntervalType)DateTimeIntervalType.Parse(typeof(DateTimeIntervalType), XIntervalType.SelectedItem.ToString());
			Chart1.ChartAreas["Default"].CursorY.Interval = int.Parse(YInterval.SelectedItem.ToString());

		}
		

		private void CursorInterval_Load(object sender, EventArgs e)
		{
			Chart1.ChartAreas["Default"].CursorY.Position = 4;
			Chart1.ChartAreas["Default"].CursorX.Position = 37535;

			Chart1.ChartAreas["Default"].AxisX.ScaleView.MinSize = 2;
			Chart1.ChartAreas["Default"].AxisY.ScaleView.MinSize = 2;

			// Initialize Combo boxes
			XInterval.SelectedIndex = 1;
			XIntervalType.SelectedIndex = 1;
			YInterval.SelectedIndex = 1;
	
		}

		
		

	}
}
