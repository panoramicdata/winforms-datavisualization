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
	public class ZOrder : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label1;
		private Label label2;
		private ComboBox SelectedSeries;
		private ComboBox SelectedArea;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public ZOrder()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			SelectedSeries.SelectedIndex = 0;
			SelectedArea.SelectedIndex = 0;

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
			ChartArea chartArea3 = new ChartArea();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(0, 3);
			DataPoint dataPoint2 = new DataPoint(0, 7);
			DataPoint dataPoint3 = new DataPoint(0, 8);
			DataPoint dataPoint4 = new DataPoint(0, 6);
			DataPoint dataPoint5 = new DataPoint(0, 7);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 4);
			DataPoint dataPoint7 = new DataPoint(0, 7);
			DataPoint dataPoint8 = new DataPoint(0, 6);
			DataPoint dataPoint9 = new DataPoint(0, 5);
			DataPoint dataPoint10 = new DataPoint(0, 5);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 6);
			DataPoint dataPoint12 = new DataPoint(0, 7);
			DataPoint dataPoint13 = new DataPoint(0, 5);
			DataPoint dataPoint14 = new DataPoint(0, 7);
			DataPoint dataPoint15 = new DataPoint(0, 6);
			Series series4 = new Series();
			DataPoint dataPoint16 = new DataPoint(0, 6);
			DataPoint dataPoint17 = new DataPoint(0, 4);
			DataPoint dataPoint18 = new DataPoint(0, 6);
			DataPoint dataPoint19 = new DataPoint(0, 5);
			DataPoint dataPoint20 = new DataPoint(0, 7);
			Series series5 = new Series();
			DataPoint dataPoint21 = new DataPoint(0, 4);
			DataPoint dataPoint22 = new DataPoint(0, 3);
			DataPoint dataPoint23 = new DataPoint(0, 7);
			DataPoint dataPoint24 = new DataPoint(0, 5);
			DataPoint dataPoint25 = new DataPoint(0, 6);
			Series series6 = new Series();
			DataPoint dataPoint26 = new DataPoint(0, 8);
			DataPoint dataPoint27 = new DataPoint(0, 4);
			DataPoint dataPoint28 = new DataPoint(0, 6);
			DataPoint dataPoint29 = new DataPoint(0, 5);
			DataPoint dataPoint30 = new DataPoint(0, 6);
			Title title1 = new Title();
            label9 = new Label();
            panel1 = new Panel();
            SelectedSeries = new ComboBox();
            label2 = new Label();
            SelectedArea = new ComboBox();
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
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 43);
            label9.TabIndex = 0;
            label9.Text = "This sample shows how to change the Z order for chart areas and series. Click on " +
                "the chart to set the top chart area.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(SelectedSeries);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SelectedArea);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // SelectedSeries
            // 
            SelectedSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SelectedSeries.Items.AddRange([
            "1-2",
            "2-1"]);
            SelectedSeries.Location = new Point(168, 40);
            SelectedSeries.Name = "SelectedSeries";
            SelectedSeries.Size = new Size(120, 22);
            SelectedSeries.TabIndex = 3;
            SelectedSeries.SelectedIndexChanged += new EventHandler(SelectedArea_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(32, 43);
            label2.Name = "label2";
            label2.Size = new Size(136, 16);
            label2.TabIndex = 2;
            label2.Text = "&Series Z Order:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SelectedArea
            // 
            SelectedArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SelectedArea.Items.AddRange([
            "1-2-3",
            "1-3-2",
            "2-1-3",
            "2-3-1",
            "3-1-2",
            "3-2-1"]);
            SelectedArea.Location = new Point(168, 8);
            SelectedArea.Name = "SelectedArea";
            SelectedArea.Size = new Size(120, 22);
            SelectedArea.TabIndex = 1;
            SelectedArea.SelectedIndexChanged += new EventHandler(SelectedArea_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(157, 16);
            label1.TabIndex = 0;
            label1.Text = "Chart &Areas Z Order:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label1.Click += new EventHandler(label1_Click);
            // 
            // Chart1
            // 
            Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            Chart1.BorderlineWidth = 2;
            Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 50F;
            chartArea1.Position.Width = 50F;
            chartArea1.Position.X = 5F;
            chartArea1.Position.Y = 5F;
            chartArea1.ShadowOffset = 2;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BackColor = System.Drawing.Color.OldLace;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.Name = "Chart Area 2";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 50F;
            chartArea2.Position.Width = 50F;
            chartArea2.Position.X = 25F;
            chartArea2.Position.Y = 25F;
            chartArea2.ShadowOffset = 2;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.BackColor = System.Drawing.Color.OldLace;
            chartArea3.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.Name = "Chart Area 3";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 50F;
            chartArea3.Position.Width = 50F;
            chartArea3.Position.X = 45F;
            chartArea3.Position.Y = 45F;
            chartArea3.ShadowOffset = 2;
            Chart1.ChartAreas.Add(chartArea1);
            Chart1.ChartAreas.Add(chartArea2);
            Chart1.ChartAreas.Add(chartArea3);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 65);
            Chart1.Name = "Chart1";
            Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.ShadowColor = System.Drawing.Color.Transparent;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series3.ChartArea = "Chart Area 2";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series4.ChartArea = "Chart Area 2";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series4.Legend = "Default";
            series4.Name = "Series4";
            series4.Points.Add(dataPoint16);
            series4.Points.Add(dataPoint17);
            series4.Points.Add(dataPoint18);
            series4.Points.Add(dataPoint19);
            series4.Points.Add(dataPoint20);
            series5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series5.ChartArea = "Chart Area 3";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(185)))), ((int)(((byte)(168)))));
            series5.Legend = "Default";
            series5.Name = "Series5";
            series5.Points.Add(dataPoint21);
            series5.Points.Add(dataPoint22);
            series5.Points.Add(dataPoint23);
            series5.Points.Add(dataPoint24);
            series5.Points.Add(dataPoint25);
            series6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series6.ChartArea = "Chart Area 3";
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(120)))), ((int)(((byte)(147)))), ((int)(((byte)(190)))));
            series6.Legend = "Default";
            series6.Name = "Series6";
            series6.Points.Add(dataPoint26);
            series6.Points.Add(dataPoint27);
            series6.Points.Add(dataPoint28);
            series6.Points.Add(dataPoint29);
            series6.Points.Add(dataPoint30);
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Series.Add(series4);
            Chart1.Series.Add(series5);
            Chart1.Series.Add(series6);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            Chart1.Titles.Add(title1);
            Chart1.MouseDown += new MouseEventHandler(Chart1_MouseDown);
            Chart1.Click += new EventHandler(Chart1_Click);
            // 
            // ZOrder
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "ZOrder";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		

		private void SelectedArea_SelectedIndexChanged(object sender, EventArgs e)
		{
			if( 
				SelectedSeries.SelectedItem == null ||
				SelectedArea.SelectedItem == null
			)
			{
				return;
			}

			// Create references to chart areas.
			ChartArea [] areas =
			[
				Chart1.ChartAreas["Default"],
				Chart1.ChartAreas["Chart Area 2"],
				Chart1.ChartAreas["Chart Area 3"],
			];

			// Remove all chart areas from the collection
			Chart1.ChartAreas.Clear();

			// Create references to series
			Series [] series =
			[
				Chart1.Series["Series1"],
				Chart1.Series["Series2"],
				Chart1.Series["Series3"],
				Chart1.Series["Series4"],
				Chart1.Series["Series5"],
				Chart1.Series["Series6"],
			];

			// Remove all series from the collection
			Chart1.Series.Clear();

			// Selected item from check box
			switch( SelectedArea.SelectedIndex )
			{
				case 0:
					// Add chart areas to the collection in selected order
					Chart1.ChartAreas.Add(areas[0]);
					Chart1.ChartAreas.Add(areas[1]);
					Chart1.ChartAreas.Add(areas[2]);
					break;
				case 1:
					Chart1.ChartAreas.Add(areas[0]);
					Chart1.ChartAreas.Add(areas[2]);
					Chart1.ChartAreas.Add(areas[1]);
					break;
				case 2:
					Chart1.ChartAreas.Add(areas[1]);
					Chart1.ChartAreas.Add(areas[0]);
					Chart1.ChartAreas.Add(areas[2]);
					break;
				case 3:
					Chart1.ChartAreas.Add(areas[1]);
					Chart1.ChartAreas.Add(areas[2]);
					Chart1.ChartAreas.Add(areas[0]);
					break;
				case 4:
					Chart1.ChartAreas.Add(areas[2]);
					Chart1.ChartAreas.Add(areas[0]);
					Chart1.ChartAreas.Add(areas[1]);
					break;
				case 5:
					Chart1.ChartAreas.Add(areas[2]);
					Chart1.ChartAreas.Add(areas[1]);
					Chart1.ChartAreas.Add(areas[0]);
					break;
			}

			// Add series to the collection in selected order
			if( SelectedSeries.SelectedIndex == 0 )
			{
				Chart1.Series.Add(series[0]);
				Chart1.Series.Add(series[1]);
				Chart1.Series.Add(series[2]);
				Chart1.Series.Add(series[3]);
				Chart1.Series.Add(series[4]);
				Chart1.Series.Add(series[5]);
			}
			else
			{
				Chart1.Series.Add(series[1]);
				Chart1.Series.Add(series[0]);
				Chart1.Series.Add(series[3]);
				Chart1.Series.Add(series[2]);
				Chart1.Series.Add(series[5]);
				Chart1.Series.Add(series[4]);
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
		
		}

		private void Chart1_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.X != 0 && e.Y != 0)
			{
				int selected = 0;

				// Create references to chart areas.
				ChartArea [] areas = [Chart1.ChartAreas[0], Chart1.ChartAreas[1], Chart1.ChartAreas[2]];

				// Conver pixels to percentage coordinates
				double X = e.X * 100F / ((float)(Chart1.Width - 1));
				double Y = e.Y * 100F / ((float)(Chart1.Height - 1)); 

				// Find which chart area is selected.
				if( areas[0].Position.ToRectangleF().Contains((float)X,(float)Y) )
				{
					selected = 0;
				}
				else if( areas[1].Position.ToRectangleF().Contains((float)X,(float)Y) )
				{
					selected = 1;
				}
				else if( areas[2].Position.ToRectangleF().Contains((float)X,(float)Y) )
				{
					selected = 2;
				}

				// Change selected item from combo box.
				if( areas[selected].Name == "Default" )
					SelectedArea.SelectedIndex = 5;
				else if( areas[selected].Name == "Chart Area 2" )
					SelectedArea.SelectedIndex = 1;
				else if( areas[selected].Name == "Chart Area 3" )
					SelectedArea.SelectedIndex = 0;


			}
		}

		private void Chart1_Click(object sender, EventArgs e)
		{
		
		}

		
	}
}
