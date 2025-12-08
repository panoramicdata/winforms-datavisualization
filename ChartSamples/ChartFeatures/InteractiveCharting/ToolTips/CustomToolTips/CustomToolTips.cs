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
	/// Summary description for CustomToolTips.
	/// </summary>
	public class CustomToolTips : UserControl
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

		public CustomToolTips()
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
			Title title1 = new Title();
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
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to use the GetToolTipText event to retrieve or modif" +
                "y tooltip text.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(432, 68);
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
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.ScaleView.Position = 3;
            chartArea1.AxisX.ScaleView.Size = 30;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stripLine1.Interval = 20;
            stripLine1.StripWidth = 5;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.ScaleView.Position = 5;
            chartArea1.AxisY.ScaleView.Size = 10;
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series1.Legend = "Default";
            series1.MarkerSize = 8;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.ShadowOffset = 2;
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 0;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Custom ToolTips";
            Chart1.Titles.Add(title1);
            Chart1.GetToolTipText += new EventHandler<ToolTipEventArgs>(Chart1_GetToolTipText);
            // 
            // label1
            // 
            label1.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label1.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 352);
            label1.Name = "label1";
            label1.Size = new Size(708, 36);
            label1.TabIndex = 20;
            label1.Text = "Move the mouse cursor over the chart elements to see different tooltip text.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomToolTips
            // 
            Controls.Add(label1);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "CustomToolTips";
            Size = new Size(728, 480);
            Load += new EventHandler(CustomToolTips_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		/// <summary>
		/// Tooltip Event
		/// </summary>
		private void Chart1_GetToolTipText(object sender, ToolTipEventArgs e)
		{
		
			// Check selevted chart element and set tooltip text
			switch(	e.HitTestResult.ChartElementType )
			{
				case ChartElementType.Axis:
					e.Text = e.HitTestResult.Axis.Name;
					break;
				case ChartElementType.ScrollBarLargeDecrement:
					e.Text = "A scrollbar large decrement button";
					break;
                case ChartElementType.ScrollBarLargeIncrement:
					e.Text = "A scrollbar large increment button";
					break;
                case ChartElementType.ScrollBarSmallDecrement:
					e.Text = "A scrollbar small decrement button";
					break;
                case ChartElementType.ScrollBarSmallIncrement:
					e.Text = "A scrollbar small increment button";
					break;
                case ChartElementType.ScrollBarThumbTracker:
					e.Text = "A scrollbar tracking thumb";
					break;
                case ChartElementType.ScrollBarZoomReset:
					e.Text = "The ZoomReset button of a scrollbar";
					break;
				case ChartElementType.DataPoint:
					e.Text = "Data Point " + e.HitTestResult.PointIndex.ToString();
					break;
				case ChartElementType.Gridlines:
					e.Text = "Grid Lines";
					break;
				case ChartElementType.LegendArea:
					e.Text = "Legend Area";
					break;
				case ChartElementType.LegendItem:
					e.Text = "Legend Item";
					break;
				case ChartElementType.PlottingArea:
					e.Text = "Plotting Area";
					break;
				case ChartElementType.StripLines:
					e.Text = "Strip Lines";
					break;
				case ChartElementType.TickMarks:
					e.Text = "Tick Marks";
					break;
				case ChartElementType.Title:
					e.Text = "Title";
					break;
			}
		}

		private void CustomToolTips_Load(object sender, EventArgs e)
		{
			Random rand = new Random();
			for( int i = 1; i<= 100; i++ )
			{
				Chart1.Series[0].Points.Add( rand.Next(20) );
			}
		}

		
	}
}
