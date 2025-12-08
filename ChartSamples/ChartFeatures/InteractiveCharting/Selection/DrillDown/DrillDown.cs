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
	/// Summary description for DrillDown.
	/// </summary>
	public class DrillDown : UserControl
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
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public DrillDown()
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
            label9 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label15 = new Label();
            Chart1 = new Chart();
            label1 = new Label();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to drill down a chart. ";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 19;
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
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.IsStaggered = true;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 80F;
            chartArea1.Position.Width = 80F;
            chartArea1.Position.X = 10F;
            chartArea1.Position.Y = 10F;
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
            series1.CustomProperties = "LabelStyle=outside";
            series1.Legend = "Default";
            series1.Name = "Series1";
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 0;
            Chart1.MouseMove += new MouseEventHandler(Chart1_MouseMove);
            Chart1.MouseDown += new MouseEventHandler(Chart1_MouseDown);
            Chart1.Click += new EventHandler(Chart1_Click);
            // 
            // label1
            // 
            label1.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label1.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 360);
            label1.Name = "label1";
            label1.Size = new Size(702, 50);
            label1.TabIndex = 20;
            label1.Text = "Click on a column to drill down to a more detailed view that is represented by a " +
                "pie chart. Then, click on a pie slice to go back to the column chart.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DrillDown
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label1);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "DrillDown";
            Size = new Size(728, 440);
            Load += new EventHandler(Form1_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Mouse Down Event
		/// </summary>
		private void Chart1_MouseDown(object sender, MouseEventArgs e)
		{
			// Call Hit Test Method
			HitTestResult result = Chart1.HitTest( e.X, e.Y );

			if( result.ChartElementType != ChartElementType.DataPoint )
				return;

			// Remove data points
			Chart1.Series[0].Points.Clear();

			// If Pie chart is selected
			if( Chart1.Series[0].ChartType == SeriesChartType.Pie )
			{
				// Set Chart Type
				Chart1.Series[0].ChartType = SeriesChartType.Column;

				// Add data points
				Chart1.Series[0].Points.Add( 5 );
				Chart1.Series[0].Points.Add( 6 );
				Chart1.Series[0].Points.Add( 7 );
				Chart1.Series[0].Points.Add( 2 );

				// Set Axis labels
				Chart1.Series[0].Points[0].AxisLabel = "N America";
				Chart1.Series[0].Points[1].AxisLabel = "S America";
				Chart1.Series[0].Points[2].AxisLabel = "Europe";
				Chart1.Series[0].Points[3].AxisLabel = "Asia";

				// Remove custom attributes
				Chart1.Series[0].CustomProperties = "";

				// Recalculate and repaint chart
				Chart1.ChartAreas[0].RecalculateAxesScale();
				Chart1.Invalidate();

				return;
			}

			// Set Label style for pie chart
			Chart1.Series[0].CustomProperties = "LabelStyle=outside";

			// Remove gradient for data points
			Chart1.Series[0].BackGradientStyle = GradientStyle.None;


			switch( result.PointIndex )
			{
				// N America
				case 0:
					// Add data points
					Chart1.Series[0].ChartType = SeriesChartType.Pie;
					Chart1.Series[0].Points.Add( 3 );
					Chart1.Series[0].Points.Add( 2 );
					Chart1.Series[0].Points.Add( 8 );

					// Set Axis labels
					Chart1.Series[0].Points[0].AxisLabel = "Country 1";
                    Chart1.Series[0].Points[1].AxisLabel = "Country 2";
                    Chart1.Series[0].Points[2].AxisLabel = "Country 3";
					
					break;
				// S America
				case 1:
					// Add data points
					Chart1.Series[0].ChartType = SeriesChartType.Pie;
					Chart1.Series[0].Points.Add( 4 );
					Chart1.Series[0].Points.Add( 6 );
					Chart1.Series[0].Points.Add( 2 );

					// Set Axis labels
                    Chart1.Series[0].Points[0].AxisLabel = "Country 4";
                    Chart1.Series[0].Points[1].AxisLabel = "Country 5";
                    Chart1.Series[0].Points[2].AxisLabel = "Country 6";
					
					break;
				// Europe
				case 2:
					// Add data points
					Chart1.Series[0].ChartType = SeriesChartType.Pie;
					Chart1.Series[0].Points.Add( 5 );
					Chart1.Series[0].Points.Add( 7 );
					Chart1.Series[0].Points.Add( 2 );
					Chart1.Series[0].Points.Add( 3 );

					// Set Axis labels
                    Chart1.Series[0].Points[0].AxisLabel = "Country 7";
                    Chart1.Series[0].Points[1].AxisLabel = "Country 8";
                    Chart1.Series[0].Points[2].AxisLabel = "Country 9";
                    Chart1.Series[0].Points[3].AxisLabel = "Country 10";
					
					break;
				// Asia
				case 3:
					// Add data points
					Chart1.Series[0].ChartType = SeriesChartType.Pie;
					Chart1.Series[0].Points.Add( 4 );
					Chart1.Series[0].Points.Add( 3 );
					Chart1.Series[0].Points.Add( 6 );
					Chart1.Series[0].Points.Add( 5 );
					Chart1.Series[0].Points.Add( 4 );

					// Set Axis labels
                    Chart1.Series[0].Points[0].AxisLabel = "Country 11";
                    Chart1.Series[0].Points[1].AxisLabel = "Country 12";
                    Chart1.Series[0].Points[2].AxisLabel = "Country 13";
                    Chart1.Series[0].Points[3].AxisLabel = "Country 14";
                    Chart1.Series[0].Points[4].AxisLabel = "Country 15";
					
					break;
			}
					
			Chart1.ChartAreas[0].RecalculateAxesScale();
			Chart1.Invalidate();
		}

		/// <summary>
		/// Mouse Move Event
		/// </summary>
		private void Chart1_MouseMove(object sender, MouseEventArgs e)
		{
			// Call Hit Test Method
			HitTestResult result = Chart1.HitTest( e.X, e.Y );

			// Reset Data Point Attributes
			foreach( DataPoint point in Chart1.Series[0].Points )
			{
				point.BackHatchStyle = ChartHatchStyle.None;
				point.BorderWidth = 1;
			}
			
			// If a Data Point or a Legend item is selected.
			if
			( 	result.ChartElementType == ChartElementType.DataPoint ||
				result.ChartElementType == ChartElementType.LegendItem )
			{				
				// Set cursor type 
				Cursor = Cursors.Hand;

				// Find selected data point
				DataPoint point = Chart1.Series[0].Points[result.PointIndex];

				// Set End Gradient Color to White
				point.BackSecondaryColor = Color.White;

				// Set selected hatch style
				point.BackHatchStyle = ChartHatchStyle.Percent25;

				// Increase border width
				point.BorderWidth = 2;
			}
			else
			{
				// Set default cursor
				Cursor = Cursors.Default;
			}
		
		}
		
		// Load Form
		private void Form1_Load(object sender, EventArgs e)
		{
			// Set Chart Type
			Chart1.Series[0].ChartType = SeriesChartType.Column;

			// Add Data Points
			Chart1.Series[0].Points.Add( 5 );
			Chart1.Series[0].Points.Add( 6 );
			Chart1.Series[0].Points.Add( 7 );
			Chart1.Series[0].Points.Add( 2 );

			// Add Axis label
			Chart1.Series[0].Points[0].AxisLabel = "N America";
			Chart1.Series[0].Points[1].AxisLabel = "S America";
			Chart1.Series[0].Points[2].AxisLabel = "Europe";
			Chart1.Series[0].Points[3].AxisLabel = "Asia";

			// Remove custom attributes
			Chart1.Series[0].CustomProperties = "";
		
		}

		private void Chart1_Click(object sender, EventArgs e)
		{
		
		}
	}
}
