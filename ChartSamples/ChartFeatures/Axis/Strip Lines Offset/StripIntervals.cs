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
	/// Summary description for StripIntervals.
	/// </summary>
	public class StripIntervals : UserControl
	{
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label1;
		private Label label2;
		private ComboBox StripWidth;
		private ComboBox IntervalOffset;
		private ComboBox IntervalType;
		private ComboBox IntervalOffsetType;
		private ComboBox StripWidthType;
        private ComboBox StripInterval;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public StripIntervals()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			
			FillData();

			StripWidth.SelectedIndex = 1;
			IntervalOffset.SelectedIndex = 0;
			IntervalType.SelectedIndex = 0;
			IntervalOffsetType.SelectedIndex = 0;
			StripWidthType.SelectedIndex = 0;
			StripInterval.SelectedIndex = 0;
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
            StripWidth = new ComboBox();
            IntervalOffset = new ComboBox();
            IntervalType = new ComboBox();
            IntervalOffsetType = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            StripWidthType = new ComboBox();
            label1 = new Label();
            StripInterval = new ComboBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // StripWidth
            // 
            StripWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StripWidth.Items.AddRange([
            "0",
            "1",
            "2"]);
            StripWidth.Location = new Point(168, 136);
            StripWidth.Name = "StripWidth";
            StripWidth.Size = new Size(121, 22);
            StripWidth.TabIndex = 4;
            StripWidth.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // IntervalOffset
            // 
            IntervalOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            IntervalOffset.Items.AddRange([
            "1",
            "2"]);
            IntervalOffset.Location = new Point(168, 72);
            IntervalOffset.Name = "IntervalOffset";
            IntervalOffset.Size = new Size(121, 22);
            IntervalOffset.TabIndex = 2;
            IntervalOffset.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // IntervalType
            // 
            IntervalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            IntervalType.Items.AddRange([
            "Weeks",
            "Months"]);
            IntervalType.Location = new Point(168, 40);
            IntervalType.Name = "IntervalType";
            IntervalType.Size = new Size(121, 22);
            IntervalType.TabIndex = 1;
            IntervalType.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // IntervalOffsetType
            // 
            IntervalOffsetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            IntervalOffsetType.Items.AddRange([
            "Days",
            "Weeks"]);
            IntervalOffsetType.Location = new Point(168, 104);
            IntervalOffsetType.Name = "IntervalOffsetType";
            IntervalOffsetType.Size = new Size(121, 22);
            IntervalOffsetType.TabIndex = 3;
            IntervalOffsetType.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // label5
            // 
            label5.Location = new Point(14, 139);
            label5.Name = "label5";
            label5.Size = new Size(152, 16);
            label5.TabIndex = 13;
            label5.Text = "Strip &Width:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(14, 43);
            label6.Name = "label6";
            label6.Size = new Size(152, 16);
            label6.TabIndex = 14;
            label6.Text = "Interval &Type:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(14, 75);
            label7.Name = "label7";
            label7.Size = new Size(152, 16);
            label7.TabIndex = 15;
            label7.Text = "&Offset:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new Point(14, 107);
            label8.Name = "label8";
            label8.Size = new Size(152, 16);
            label8.TabIndex = 16;
            label8.Text = "Offset T&ype:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 43);
            label9.TabIndex = 2;
            label9.Text = "This sample demonstrates how to set the offset, interval, strip width, and width " +
                "type of a StripLine object.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(StripWidthType);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(StripInterval);
            panel1.Controls.Add(IntervalType);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(StripWidth);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(IntervalOffsetType);
            panel1.Controls.Add(IntervalOffset);
            panel1.Location = new Point(432, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(14, 171);
            label2.Name = "label2";
            label2.Size = new Size(152, 16);
            label2.TabIndex = 28;
            label2.Text = "Width Ty&pe:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StripWidthType
            // 
            StripWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StripWidthType.Items.AddRange([
            "Days",
            "Weeks"]);
            StripWidthType.Location = new Point(168, 168);
            StripWidthType.Name = "StripWidthType";
            StripWidthType.Size = new Size(121, 22);
            StripWidthType.TabIndex = 5;
            StripWidthType.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(152, 16);
            label1.TabIndex = 18;
            label1.Text = "&Interval:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StripInterval
            // 
            StripInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StripInterval.Items.AddRange([
            "1",
            "2",
            "3"]);
            StripInterval.Location = new Point(168, 8);
            StripInterval.Name = "StripInterval";
            StripInterval.Size = new Size(121, 22);
            StripInterval.TabIndex = 0;
            StripInterval.SelectedIndexChanged += new EventHandler(ControlSelectedIndexChanged);
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "d MMM";
            chartArea1.AxisX.LabelStyle.IsStaggered = true;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stripLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(241)))), ((int)(((byte)(185)))), ((int)(((byte)(168)))));
            stripLine1.Interval = 2;
            stripLine1.StripWidth = 1;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsStartedFromZero = false;
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
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 65);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.ShadowOffset = 1;
            series1.YValuesPerPoint = 4;
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            // 
            // StripIntervals
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "StripIntervals";
            Size = new Size(728, 480);
            Load += new EventHandler(StripIntervals_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void StripIntervals_Load(object sender, EventArgs e)
		{
		}

		private void ControlSelectedIndexChanged(object sender, EventArgs e)
		{

			if(StripWidth.SelectedIndex >= 0)
			{
				Chart1.ChartAreas[0].AxisX.StripLines[0].StripWidth = 
					int.Parse(StripWidth.SelectedItem.ToString());
			}

			if(StripWidthType.SelectedIndex >= 0)
			{
				switch( StripWidthType.SelectedItem.ToString())
				{
					case "Days":
						Chart1.ChartAreas[0].AxisX.StripLines[0].StripWidthType = DateTimeIntervalType.Days;
						break;
					case "Weeks":
						Chart1.ChartAreas[0].AxisX.StripLines[0].StripWidthType = DateTimeIntervalType.Weeks;
						break;
				}
			}


			if(IntervalOffset.SelectedIndex >= 0)
			{
				Chart1.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = 
					int.Parse(IntervalOffset.SelectedItem.ToString());
			}

			if(IntervalOffsetType.SelectedIndex >= 0)
			{
				switch( IntervalOffsetType.SelectedItem.ToString())
				{
					case "Days":
						Chart1.ChartAreas[0].AxisX.StripLines[0].IntervalOffsetType = DateTimeIntervalType.Days;
						break;
					case "Weeks":
						Chart1.ChartAreas[0].AxisX.StripLines[0].IntervalOffsetType = DateTimeIntervalType.Weeks;
						break;
				}
			}

			if(StripInterval.SelectedIndex >= 0)
			{
				Chart1.ChartAreas[0].AxisX.StripLines[0].Interval = 
					int.Parse(StripInterval.SelectedItem.ToString());
			}

			if(IntervalType.SelectedIndex >= 0)
			{
				switch( IntervalType.SelectedItem.ToString())
				{
					case "Weeks":
						Chart1.ChartAreas[0].AxisX.StripLines[0].IntervalType = DateTimeIntervalType.Weeks;
						break;
					case "Months":
						Chart1.ChartAreas[0].AxisX.StripLines[0].IntervalType = DateTimeIntervalType.Months;
						break;
				}
			}
		}

		private void FillData()
		{
			Random rand;
			// Use a number to calculate a starting value for 
			// the pseudo-random number sequence
			rand = new Random();
			
			// The number of days for stock data
			int period = 120;

			// The first High value
			double high = rand.NextDouble() * 40;

			// The first Close value
			double close = high - rand.NextDouble();

			// The first Low value
			double low = close - rand.NextDouble();

			// The first Open value
			double open = ( high - low ) * rand.NextDouble() + low;

			// The first day X and Y values
			Chart1.Series[0].Points.AddXY(DateTime.Parse("1/2/2002"), high);
			Chart1.Series[0].Points[0].YValues[1] = low;

			// The Open value is not used.
			Chart1.Series[0].Points[0].YValues[2] = open;
			Chart1.Series[0].Points[0].YValues[3] = close;
			
			// Days loop
			for( int day = 1; day <= period; day++ )
			{
			
				// Calculate High, Low and Close values
				high = Chart1.Series[0].Points[day-1].YValues[2]+rand.NextDouble();
				close = high - rand.NextDouble();
				low = close - rand.NextDouble();
				open = ( high - low ) * rand.NextDouble() + low;
				
				// The low cannot be less than yesterday close value.
				if( low > Chart1.Series[0].Points[day-1].YValues[2])
					low = Chart1.Series[0].Points[day-1].YValues[2];
							
				// Set data points values
				Chart1.Series[0].Points.AddXY(day, high);
				Chart1.Series[0].Points[day].XValue = Chart1.Series[0].Points[day-1].XValue+1;
				Chart1.Series[0].Points[day].YValues[1] = low;
				Chart1.Series[0].Points[day].YValues[2] = open;
				Chart1.Series[0].Points[day].YValues[3] = close;

			}
		}


	}
}
