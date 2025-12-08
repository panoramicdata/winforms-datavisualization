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
	/// Summary description for InteractivePie.
	/// </summary>
	public class InteractivePie : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label15;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public InteractivePie()
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
			StripLine stripLine1 = new StripLine();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(0, 3);
			DataPoint dataPoint2 = new DataPoint(0, 5);
			DataPoint dataPoint3 = new DataPoint(0, 4);
			DataPoint dataPoint4 = new DataPoint(0, 2);
			DataPoint dataPoint5 = new DataPoint(0, 8);
			Title title1 = new Title();
            label9 = new Label();
            panel1 = new Panel();
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
            label9.Size = new Size(702, 43);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to use selection to explode a pie slice. To explode " +
                "a slice, click on the slice or a legend item. ";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(432, 73);
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
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.ScaleView.Position = 3;
            chartArea1.AxisX.ScaleView.Size = 30;
            stripLine1.Interval = 20;
            stripLine1.StripWidth = 5;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.ScaleView.Position = 5;
            chartArea1.AxisY.ScaleView.Size = 10;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderWidth = 0;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 80F;
            chartArea1.InnerPlotPosition.Width = 80F;
            chartArea1.InnerPlotPosition.X = 10F;
            chartArea1.InnerPlotPosition.Y = 10F;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 84F;
            chartArea1.Position.Width = 74F;
            chartArea1.Position.X = 4.824818F;
            chartArea1.Position.Y = 12F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 65);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieLabelStyle=Disabled";
            series1.Legend = "Default";
            series1.Name = "Series1";
            dataPoint1.AxisLabel = "Product A";
            dataPoint2.AxisLabel = "Product B";
            dataPoint3.AxisLabel = "Product C";
            dataPoint4.AxisLabel = "Product D";
            dataPoint5.AxisLabel = "Product E";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.ShadowOffset = 4;
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 0;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Select a Slice of the Pie";
            Chart1.Titles.Add(title1);
            Chart1.MouseMove += new MouseEventHandler(Chart1_MouseMove);
            Chart1.MouseDown += new MouseEventHandler(Chart1_MouseDown);
            Chart1.Click += new EventHandler(Chart1_Click);
            // 
            // InteractivePie
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "InteractivePie";
            Size = new Size(728, 368);
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

			// Exit event if no item was clicked on (PointResult will be negative one)
			if(result.PointIndex < 0)
				return;

			// Check if data point is already exploded.
			bool exploded = ( Chart1.Series[0].Points[result.PointIndex].CustomProperties == "Exploded=true" );

			// Remove all exploded attributes
			foreach( DataPoint point in Chart1.Series[0].Points )
			{
				point.CustomProperties = "";
			}

			// If data point is already exploded get out.
			if( exploded )
				return;

			// If data point is selected
			if( result.ChartElementType == ChartElementType.DataPoint )
			{
				// Set Attribute
				DataPoint point = Chart1.Series[0].Points[result.PointIndex];
				point.CustomProperties = "Exploded = true";
			}

			// If legend item is selected
			if( result.ChartElementType == ChartElementType.LegendItem )
			{
				// Set Attribute
				DataPoint point = Chart1.Series[0].Points[result.PointIndex];
				point.CustomProperties = "Exploded = true";
			}
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
				point.BackSecondaryColor = Color.Black;
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

		private void Chart1_Click(object sender, EventArgs e)
		{
		
		}
	}
}
