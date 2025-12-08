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
	public class SeriesAndChartAreas : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Label label1;
		private Label label2;
		private Label label3;
		private ComboBox Series1;
		private ComboBox Series2;
		private ComboBox Series3;
		private Chart Chart1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public SeriesAndChartAreas()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			Series1.SelectedIndex = 1;
			Series2.SelectedIndex = 1;
			Series3.SelectedIndex = 2;

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
			ChartArea chartArea2 = new ChartArea();
			Legend legend1 = new Legend();
			Series series4 = new Series();
			DataPoint dataPoint1 = new DataPoint(0, 6);
			DataPoint dataPoint2 = new DataPoint(0, 5);
			DataPoint dataPoint3 = new DataPoint(0, 7);
			Series series5 = new Series();
			DataPoint dataPoint4 = new DataPoint(0, 7);
			DataPoint dataPoint5 = new DataPoint(0, 4);
			DataPoint dataPoint6 = new DataPoint(0, 5);
			Series series6 = new Series();
			DataPoint dataPoint7 = new DataPoint(0, 4);
			DataPoint dataPoint8 = new DataPoint(0, 6);
			DataPoint dataPoint9 = new DataPoint(0, 5);
            label9 = new Label();
            panel1 = new Panel();
            Series3 = new ComboBox();
            Series2 = new ComboBox();
            Series1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            label9.Text = "This sample demonstrates how to attach a series to a chart area.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(Series3);
            panel1.Controls.Add(Series2);
            panel1.Controls.Add(Series1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // Series3
            // 
            Series3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Series3.Items.AddRange([
            "None",
            "Default",
            "Chart Area 2"]);
            Series3.Location = new Point(168, 72);
            Series3.Name = "Series3";
            Series3.Size = new Size(121, 22);
            Series3.TabIndex = 5;
            Series3.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // Series2
            // 
            Series2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Series2.Items.AddRange([
            "None",
            "Default",
            "Chart Area 2"]);
            Series2.Location = new Point(168, 40);
            Series2.Name = "Series2";
            Series2.Size = new Size(121, 22);
            Series2.TabIndex = 3;
            Series2.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // Series1
            // 
            Series1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Series1.Items.AddRange([
            "None",
            "Default",
            "Chart Area 2"]);
            Series1.Location = new Point(168, 8);
            Series1.Name = "Series1";
            Series1.Size = new Size(121, 22);
            Series1.TabIndex = 1;
            Series1.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(16, 72);
            label3.Name = "label3";
            label3.Size = new Size(148, 16);
            label3.TabIndex = 4;
            label3.Text = "Red Series &3:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(16, 43);
            label2.Name = "label2";
            label2.Size = new Size(148, 16);
            label2.TabIndex = 2;
            label2.Text = "Gold Series &2:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(148, 16);
            label1.TabIndex = 0;
            label1.Text = "Blue Series &1:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 42F;
            chartArea1.Position.Width = 89.43796F;
            chartArea1.Position.X = 4.824818F;
            chartArea1.Position.Y = 5.542373F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chartArea2.AlignWithChartArea = "Default";
            chartArea2.Area3DStyle.Inclination = 15;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Perspective = 10;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BackColor = System.Drawing.Color.Gainsboro;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.Name = "Chart Area 2";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 42F;
            chartArea2.Position.Width = 89.43796F;
            chartArea2.Position.X = 4.824818F;
            chartArea2.Position.Y = 47F;
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            Chart1.ChartAreas.Add(chartArea2);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 8.351166F;
            legend1.Position.Width = 45F;
            legend1.Position.X = 50F;
            legend1.Position.Y = 87F;
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series4.ChartArea = "Default";
            series4.Legend = "Default";
            series4.LegendText = "Blue";
            series4.Name = "Series1";
            series4.Points.Add(dataPoint1);
            series4.Points.Add(dataPoint2);
            series4.Points.Add(dataPoint3);
            series5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series5.ChartArea = "Default";
            series5.Legend = "Default";
            series5.LegendText = "Gold";
            series5.Name = "Series2";
            series5.Points.Add(dataPoint4);
            series5.Points.Add(dataPoint5);
            series5.Points.Add(dataPoint6);
            series6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series6.ChartArea = "Default";
            series6.Legend = "Default";
            series6.LegendText = "Red";
            series6.Name = "Series3";
            series6.Points.Add(dataPoint7);
            series6.Points.Add(dataPoint8);
            series6.Points.Add(dataPoint9);
            Chart1.Series.Add(series4);
            Chart1.Series.Add(series5);
            Chart1.Series.Add(series6);
            Chart1.Size = new Size(412, 306);
            Chart1.TabIndex = 1;
            Chart1.Click += new EventHandler(Chart1_Click);
            // 
            // SeriesAndChartAreas
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "SeriesAndChartAreas";
            Size = new Size(728, 480);
            Load += new EventHandler(SeriesAndChartAreas_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		
		private void Combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			AreaSeries();
		}

		private void AreaSeries()
		{
			// Attach the first series to a chart area.
			if( Series1.SelectedIndex == 0 )
				Chart1.Series["Series1"].ChartArea = "";
			else
				Chart1.Series["Series1"].ChartArea = Series1.GetItemText(Series1.SelectedItem);

			// Attach the second series to a chart area.
			if( Series2.SelectedIndex == 0 )
				Chart1.Series["Series2"].ChartArea = "";
			else
				Chart1.Series["Series2"].ChartArea = Series2.GetItemText(Series2.SelectedItem);

			// Attach the Third series to a chart area.
			if( Series3.SelectedIndex == 0 )
				Chart1.Series["Series3"].ChartArea = "";
			else
				Chart1.Series["Series3"].ChartArea = Series3.GetItemText(Series3.SelectedItem);

		}

		private void SeriesAndChartAreas_Load(object sender, EventArgs e)
		{
			AreaSeries();
		}

		private void Chart1_Click(object sender, EventArgs e)
		{
		
		}

		

	}
}
