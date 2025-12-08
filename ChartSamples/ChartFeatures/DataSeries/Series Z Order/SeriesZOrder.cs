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
	public class SeriesZOrder : UserControl
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
		private Label ZOrder;
		private CheckBox Transparent;
		private ComboBox SeriesOrder;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public SeriesZOrder()
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
			ChartArea chartArea3 = new ChartArea();
			Legend legend3 = new Legend();
			Series series7 = new Series();
			DataPoint dataPoint31 = new DataPoint(0, 3);
			DataPoint dataPoint32 = new DataPoint(0, 7);
			DataPoint dataPoint33 = new DataPoint(0, 8);
			DataPoint dataPoint34 = new DataPoint(0, 6);
			DataPoint dataPoint35 = new DataPoint(0, 7);
			Series series8 = new Series();
			DataPoint dataPoint36 = new DataPoint(0, 4);
			DataPoint dataPoint37 = new DataPoint(0, 2);
			DataPoint dataPoint38 = new DataPoint(0, 3);
			DataPoint dataPoint39 = new DataPoint(0, 1);
			DataPoint dataPoint40 = new DataPoint(0, 6);
			Series series9 = new Series();
			DataPoint dataPoint41 = new DataPoint(0, 1);
			DataPoint dataPoint42 = new DataPoint(0, 2);
			DataPoint dataPoint43 = new DataPoint(0, 4);
			DataPoint dataPoint44 = new DataPoint(0, 5);
			DataPoint dataPoint45 = new DataPoint(0, 1);
            label9 = new Label();
            panel1 = new Panel();
            Transparent = new CheckBox();
            ZOrder = new Label();
            SeriesOrder = new ComboBox();
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
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample shows how to change the Z-order of each series.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(Transparent);
            panel1.Controls.Add(ZOrder);
            panel1.Controls.Add(SeriesOrder);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // Transparent
            // 
            Transparent.Location = new Point(7, 40);
            Transparent.Name = "Transparent";
            Transparent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Transparent.Size = new Size(144, 24);
            Transparent.TabIndex = 2;
            Transparent.Text = "Use Solid Colors:";
            Transparent.CheckedChanged += new EventHandler(SeriesOrder_SelectedIndexChanged);
            // 
            // ZOrder
            // 
            ZOrder.Location = new Point(7, 9);
            ZOrder.Name = "ZOrder";
            ZOrder.Size = new Size(125, 20);
            ZOrder.TabIndex = 0;
            ZOrder.Text = "Series &Z Order:";
            ZOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SeriesOrder
            // 
            SeriesOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SeriesOrder.Items.AddRange([
            "Column-Spline-Area",
            "Column-Area-Spline",
            "Area-Column-Spline",
            "Area-Spline-Column",
            "Spline-Area-Column",
            "Spline-Column-Area"]);
            SeriesOrder.Location = new Point(136, 8);
            SeriesOrder.Name = "SeriesOrder";
            SeriesOrder.Size = new Size(152, 22);
            SeriesOrder.TabIndex = 1;
            SeriesOrder.SelectedIndexChanged += new EventHandler(SeriesOrder_SelectedIndexChanged);
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
            label6.TabIndex = 6;
            label6.Text = "Border Size:";
            // 
            // label5
            // 
            label5.Location = new Point(64, 380);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 5;
            label5.Text = "Border Color:";
            // 
            // label4
            // 
            label4.Location = new Point(64, 357);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 4;
            label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            label3.Location = new Point(64, 334);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 3;
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
            Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            Chart1.BorderlineWidth = 2;
            Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.Inclination = 15;
            chartArea3.Area3DStyle.IsClustered = true;
            chartArea3.Area3DStyle.IsRightAngleAxes = false;
            chartArea3.Area3DStyle.Perspective = 10;
            chartArea3.Area3DStyle.Rotation = 10;
            chartArea3.Area3DStyle.WallWidth = 0;
            chartArea3.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisX.LabelStyle.Format = "dd MMM";
            chartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.Name = "Default";
            chartArea3.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Default";
            Chart1.Legends.Add(legend3);
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            series7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series7.ChartArea = "Default";
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series7.Legend = "Default";
            series7.Name = "Series1";
            series7.Points.Add(dataPoint31);
            series7.Points.Add(dataPoint32);
            series7.Points.Add(dataPoint33);
            series7.Points.Add(dataPoint34);
            series7.Points.Add(dataPoint35);
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series8.ChartArea = "Default";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series8.Legend = "Default";
            series8.Name = "Series2";
            series8.Points.Add(dataPoint36);
            series8.Points.Add(dataPoint37);
            series8.Points.Add(dataPoint38);
            series8.Points.Add(dataPoint39);
            series8.Points.Add(dataPoint40);
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series9.ChartArea = "Default";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series9.Legend = "Default";
            series9.Name = "Series3";
            series9.Points.Add(dataPoint41);
            series9.Points.Add(dataPoint42);
            series9.Points.Add(dataPoint43);
            series9.Points.Add(dataPoint44);
            series9.Points.Add(dataPoint45);
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            Chart1.Series.Add(series7);
            Chart1.Series.Add(series8);
            Chart1.Series.Add(series9);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            Chart1.Click += new EventHandler(Chart1_Click);
            // 
            // SeriesZOrder
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "SeriesZOrder";
            Size = new Size(728, 480);
            Load += new EventHandler(SeriesZOrder_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void SeriesZOrder_Load(object sender, EventArgs e)
		{
			SeriesOrder.SelectedIndex = 1;
		
		}

		private void Order()
		{
			if( SeriesOrder.SelectedItem == null )
				return;

			// Set solid colors
			foreach(Series ser in Chart1.Series)
			{
				ser.Color = Color.FromArgb(255,ser.Color.R,ser.Color.G,ser.Color.B);
			}

			// Create references to series
			Series [] series = [Chart1.Series["Series1"], Chart1.Series["Series2"], Chart1.Series["Series3"]];

			// Remove all series from the collection
			Chart1.Series.Clear();

			// Add chart series into the collection in selected order
			switch( SeriesOrder.GetItemText(SeriesOrder.SelectedItem) )
			{
				case "Column-Spline-Area":
					Chart1.Series.Add(series[0]);
					Chart1.Series.Add(series[1]);
					Chart1.Series.Add(series[2]);
					break;
				case "Column-Area-Spline":
					Chart1.Series.Add(series[0]);
					Chart1.Series.Add(series[2]);
					Chart1.Series.Add(series[1]);
					break;
				case "Spline-Column-Area":
					Chart1.Series.Add(series[1]);
					Chart1.Series.Add(series[0]);
					Chart1.Series.Add(series[2]);
					break;
				case "Spline-Area-Column":
					Chart1.Series.Add(series[1]);
					Chart1.Series.Add(series[2]);
					Chart1.Series.Add(series[0]);
					break;
				case "Area-Column-Spline":
					Chart1.Series.Add(series[2]);
					Chart1.Series.Add(series[0]);
					Chart1.Series.Add(series[1]);
					break;
				case "Area-Spline-Column":
					Chart1.Series.Add(series[2]);
					Chart1.Series.Add(series[1]);
					Chart1.Series.Add(series[0]);
					break;
			}

			// Set transparent colors
			if(!Transparent.Checked)
			{
				foreach(Series ser in Chart1.Series)
				{
					ser.Color = Color.FromArgb(220,ser.Color.R,ser.Color.G,ser.Color.B);
				}
			}
		}

		private void SeriesOrder_SelectedIndexChanged(object sender, EventArgs e)
		{
			Order();
		}

		private void Chart1_Click(object sender, EventArgs e)
		{
		
		}

		
	

	}
}
