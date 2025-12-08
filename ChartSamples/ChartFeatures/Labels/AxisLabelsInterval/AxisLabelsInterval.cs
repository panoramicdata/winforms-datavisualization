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
	public class AxisLabelsInterval : UserControl
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
		private ComboBox PointsNumberList;
		private ComboBox XAxisIntervalList;
		private ComboBox YAxisIntervalList;
		private Label label8;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AxisLabelsInterval()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize combo boxes
			PointsNumberList.SelectedIndex = 0;
			XAxisIntervalList.SelectedIndex = 0;
			YAxisIntervalList.SelectedIndex = 0;
			
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
            label9 = new Label();
            panel1 = new Panel();
            YAxisIntervalList = new ComboBox();
            XAxisIntervalList = new ComboBox();
            PointsNumberList = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label15 = new Label();
            Chart1 = new Chart();
            label8 = new Label();
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
            label9.Text = "This sample demonstrates how to set axis interval properties, which are applied t" +
                "o the axis\' labels, major grid lines, and tick marks. ";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(YAxisIntervalList);
            panel1.Controls.Add(XAxisIntervalList);
            panel1.Controls.Add(PointsNumberList);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(432, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // YAxisIntervalList
            // 
            YAxisIntervalList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            YAxisIntervalList.Items.AddRange([
            "Auto",
            "100",
            "200",
            "250",
            "500"]);
            YAxisIntervalList.Location = new Point(168, 40);
            YAxisIntervalList.Name = "YAxisIntervalList";
            YAxisIntervalList.Size = new Size(124, 22);
            YAxisIntervalList.TabIndex = 3;
            YAxisIntervalList.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // XAxisIntervalList
            // 
            XAxisIntervalList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            XAxisIntervalList.Items.AddRange([
            "Auto",
            "Every Week (Starting Sunday)",
            "Every Week (Starting Monday)",
            "Every 2 Weeks",
            "Every Month (Starting at 1st)",
            "Every Month (Starting at 15th)"]);
            XAxisIntervalList.Location = new Point(74, 104);
            XAxisIntervalList.Name = "XAxisIntervalList";
            XAxisIntervalList.Size = new Size(216, 22);
            XAxisIntervalList.TabIndex = 5;
            XAxisIntervalList.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // PointsNumberList
            // 
            PointsNumberList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            PointsNumberList.Items.AddRange([
            "30",
            "50",
            "70"]);
            PointsNumberList.Location = new Point(168, 8);
            PointsNumberList.Name = "PointsNumberList";
            PointsNumberList.Size = new Size(124, 22);
            PointsNumberList.TabIndex = 1;
            PointsNumberList.SelectedIndexChanged += new EventHandler(PointsNumberList_SelectedIndexChanged);
            // 
            // label7
            // 
            label7.Location = new Point(4, 40);
            label7.Name = "label7";
            label7.Size = new Size(160, 23);
            label7.TabIndex = 2;
            label7.Text = "&Y Axis Interval:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 4;
            label2.Text = "&X Axis Interval:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(4, 8);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 0;
            label1.Text = "Number of &Days:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(64, 403);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 10;
            label6.Text = "Border Size:";
            // 
            // label5
            // 
            label5.Location = new Point(64, 380);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 9;
            label5.Text = "Border Color:";
            // 
            // label4
            // 
            label4.Location = new Point(64, 357);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 8;
            label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            label3.Location = new Point(64, 334);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 7;
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
            chartArea1.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "dd MMM";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 82F;
            chartArea1.InnerPlotPosition.Width = 84.7138F;
            chartArea1.InnerPlotPosition.X = 8.2422F;
            chartArea1.InnerPlotPosition.Y = 2.99507F;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 87.64407F;
            chartArea1.Position.Width = 89.43796F;
            chartArea1.Position.X = 4.824818F;
            chartArea1.Position.Y = 5.542373F;
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
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DrawingStyle=Emboss, PointWidth=0.9";
            series1.Legend = "Default";
            series1.Name = "Series1";
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label8.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new Point(16, 377);
            label8.Name = "label8";
            label8.Size = new Size(702, 40);
            label8.TabIndex = 3;
            label8.Text = "Major and minor grid lines, tick marks, and label objects of an axis also have th" +
                "eir own interval related properties, which take precedence over the axis propert" +
                "ies.";
            // 
            // AxisLabelsInterval
            // 
            Controls.Add(label8);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AxisLabelsInterval";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		/// <summary>
		/// Sets interval properties for the axis. 
		/// Note that we use the Axis object's interval properties, and not the properties of its label,
		/// and major tick mark and grid line objects
		/// </summary>
		public void SetAxisInterval(Axis axis, double interval, DateTimeIntervalType intervalType)
		{
			SetAxisInterval(axis, interval, intervalType, 0, DateTimeIntervalType.Auto);
		}

		private void PointsNumberList_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Populate series data
			Random		random = new Random();
			DateTime	dateCurrent = DateTime.Now.Date;
			Chart1.Series["Series1"].Points.Clear();
			for(int pointIndex = 0; pointIndex < int.Parse(PointsNumberList.GetItemText(PointsNumberList.SelectedItem)); pointIndex++)
			{
				Chart1.Series["Series1"].Points.AddXY(dateCurrent.AddDays(pointIndex), random.Next(100, 1000));
			}
			Chart1.Invalidate();
		}

		private void Combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Intervals();
		}
		

		private void Intervals()
		{

			if( 
				PointsNumberList.SelectedItem == null ||
				XAxisIntervalList.SelectedItem == null ||
				YAxisIntervalList.SelectedItem == null
			)
			{
				return;
			}
			
			Chart1.BackColor = Color.White;

			// Set interval and interval type for the Y axis
			if(YAxisIntervalList.GetItemText(YAxisIntervalList.SelectedItem) != "Auto")
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisY, double.Parse(YAxisIntervalList.GetItemText(YAxisIntervalList.SelectedItem)), DateTimeIntervalType.Number);
			}
			else
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisY, Double.NaN, DateTimeIntervalType.Auto, Double.NaN, DateTimeIntervalType.Auto);
			}

			// Set interval and interval type for the X axis
			if(XAxisIntervalList.GetItemText(XAxisIntervalList.SelectedItem) == "Every Week (Starting Sunday)")
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisX, 1, DateTimeIntervalType.Weeks);
			}
			else if(XAxisIntervalList.GetItemText(XAxisIntervalList.SelectedItem) == "Every Week (Starting Monday)")
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisX, 1, DateTimeIntervalType.Weeks, 1, DateTimeIntervalType.Days);
			}
			else if(XAxisIntervalList.GetItemText(XAxisIntervalList.SelectedItem) == "Every 2 Weeks")
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisX, 2, DateTimeIntervalType.Weeks);
			}
			else if(XAxisIntervalList.GetItemText(XAxisIntervalList.SelectedItem) == "Every Month (Starting at 1st)")
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisX, 1, DateTimeIntervalType.Months);
			}
			else if(XAxisIntervalList.GetItemText(XAxisIntervalList.SelectedItem) == "Every Month (Starting at 15th)")
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisX, 1, DateTimeIntervalType.Months, 14, DateTimeIntervalType.Days);
			}
			else if(XAxisIntervalList.GetItemText(XAxisIntervalList.SelectedItem) == "Auto")
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisX, Double.NaN, DateTimeIntervalType.Auto, Double.NaN, DateTimeIntervalType.Auto);
			}

		}

		/// <summary>
		/// Sets interval properties for the axis. 
		/// Note that we use the Axis object's interval properties, and not the properties of its label,
		/// and major tick mark and grid line objects
		/// </summary>
		public void SetAxisInterval(Axis axis, double interval, DateTimeIntervalType intervalType, double intervalOffset, DateTimeIntervalType intervalOffsetType )
		{
			// Set interval-related properties
			axis.Interval = interval;
			axis.IntervalType = intervalType;
			axis.IntervalOffset = intervalOffset;
			axis.IntervalOffsetType = intervalOffsetType;
		}

		
	}
}
