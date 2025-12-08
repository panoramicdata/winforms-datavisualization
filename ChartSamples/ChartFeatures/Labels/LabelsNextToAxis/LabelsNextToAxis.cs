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
	public class LabelsNextToAxis : UserControl
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
		private ComboBox XLabelsList;
		private Label label2;
		private ComboBox YLabelsList;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public LabelsNextToAxis()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize combo boxes
			XLabelsList.SelectedIndex = 0;
			YLabelsList.SelectedIndex = 0;
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
			Series series2 = new Series();
			Series series3 = new Series();
            label9 = new Label();
            panel1 = new Panel();
            YLabelsList = new ComboBox();
            label2 = new Label();
            XLabelsList = new ComboBox();
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
            label9.Size = new Size(696, 40);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to set an axis crossing point. It also demonstrates " +
                "how to display labels and tick marks next to an axis or at the plotting area bor" +
                "der.";
            // 
            // panel1
            // 
            panel1.Controls.Add(YLabelsList);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(XLabelsList);
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
            // YLabelsList
            // 
            YLabelsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            YLabelsList.Items.AddRange([
            "Show Next to the Axis",
            "Show at Plot Area Border"]);
            YLabelsList.Location = new Point(44, 72);
            YLabelsList.Name = "YLabelsList";
            YLabelsList.Size = new Size(176, 22);
            YLabelsList.TabIndex = 3;
            YLabelsList.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(24, 56);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 2;
            label2.Text = "&Y Axis Labels and Tick Marks:";
            // 
            // XLabelsList
            // 
            XLabelsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            XLabelsList.Items.AddRange([
            "Show Next to the Axis",
            "Show at Plot Area Border"]);
            XLabelsList.Location = new Point(44, 24);
            XLabelsList.Name = "XLabelsList";
            XLabelsList.Size = new Size(176, 22);
            XLabelsList.TabIndex = 1;
            XLabelsList.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(20, 4);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 0;
            label1.Text = "&X Axis Labels and Tick Marks:";
            // 
            // label6
            // 
            label6.Location = new Point(64, 403);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 7;
            label6.Text = "Border Size:";
            // 
            // label5
            // 
            label5.Location = new Point(64, 380);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 6;
            label5.Text = "Border Color:";
            // 
            // label4
            // 
            label4.Location = new Point(64, 357);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 5;
            label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            label3.Location = new Point(64, 334);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
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
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.Crossing = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.Maximum = 100;
            chartArea1.AxisX.Minimum = -100;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.Crossing = 0;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.Maximum = 100;
            chartArea1.AxisY.Minimum = -100;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
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
            Chart1.Location = new Point(16, 60);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Default";
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series1.Name = "Series1";
            series1.ShadowOffset = 1;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Default";
            series2.MarkerSize = 7;
            series2.Name = "Series2";
            series2.ShadowOffset = 1;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Default";
            series3.MarkerSize = 8;
            series3.Name = "Series3";
            series3.ShadowOffset = 1;
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            // 
            // LabelsNextToAxis
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "LabelsNextToAxis";
            Size = new Size(728, 480);
            Load += new EventHandler(AxisLabelsInterval_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void AxisLabelsInterval_Load(object sender, EventArgs e)
		{
			
		}

		
		private void Combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Labels();
		}

		private void Labels()
		{
			// Populate series data with random data
			Random random = new Random();
			Chart1.Series["Series1"].Points.Clear();
			Chart1.Series["Series2"].Points.Clear();
			Chart1.Series["Series3"].Points.Clear();
			for(int pointIndex = 0; pointIndex < 10; pointIndex++)
			{
				Chart1.Series["Series1"].Points.AddXY(random.Next(-100, 100), random.Next(-100, 100));
				Chart1.Series["Series2"].Points.AddXY(random.Next(-100, 100), random.Next(-100, 100));
				Chart1.Series["Series3"].Points.AddXY(random.Next(-100, 100), random.Next(-100, 100));
			}

			Chart1.ChartAreas["Default"].BackColor = Color.White;

			// Set X and Y axis crossing
			Chart1.ChartAreas["Default"].AxisX.Crossing = 0;
			Chart1.ChartAreas["Default"].AxisY.Crossing = 0;

			// Position the X axis labels and tick marks to the area border
			if(XLabelsList.SelectedIndex == 1)
			{
				Chart1.ChartAreas["Default"].AxisX.IsMarksNextToAxis = false;
			}
			else
			{
				Chart1.ChartAreas["Default"].AxisX.IsMarksNextToAxis = true;
			}

			// Position the Y axis labels and tick marks to the area border
			if(YLabelsList.SelectedIndex == 1)
			{
				Chart1.ChartAreas["Default"].AxisY.IsMarksNextToAxis = false;
			}
			else
			{
				Chart1.ChartAreas["Default"].AxisY.IsMarksNextToAxis = true;
			}
		}

		
	}
}
