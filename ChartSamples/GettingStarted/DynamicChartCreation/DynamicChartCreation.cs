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
	/// Summary description for UsingToolTips.
	/// </summary>
	public class DynamicChartCreation : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label15;
		private Chart Chart1;
		private Label label1;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public DynamicChartCreation()
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
            label9 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label15 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label9.Font = new Font("Verdana", 11.25F);
            label9.Location = new Point(8, 16);
            label9.Name = "label9";
            label9.Size = new Size(696, 24);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to create a chart dynamically at run time.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(405, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 248);
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
            // label1
            // 
            label1.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label1.Font = new Font("Verdana", 11.25F);
            label1.Location = new Point(16, 328);
            label1.Name = "label1";
            label1.Size = new Size(696, 32);
            label1.TabIndex = 20;
            label1.Text = "For ease of use, add the chart at design time.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DynamicChartCreation
            // 
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Name = "DynamicChartCreation";
            Size = new Size(728, 400);
            Load += new EventHandler(DynamicChartCreation_Load);
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void DynamicChartCreation_Load(object sender, EventArgs e)
		{
			// Create a Chart
			Chart1 = new Chart();

			// Create Chart Area
			ChartArea chartArea1 = new ChartArea();

			// Add Chart Area to the Chart
			Chart1.ChartAreas.Add(chartArea1);

			// Create a data series
			Series series1 = new Series();
			Series series2 = new Series();

			// Add data points to the first series
			series1.Points.Add(34);
			series1.Points.Add(24);
			series1.Points.Add(32);
			series1.Points.Add(28);
			series1.Points.Add(44);

			// Add data points to the second series
			series2.Points.Add(14);
			series2.Points.Add(44);
			series2.Points.Add(24);
			series2.Points.Add(32);
			series2.Points.Add(28);

			// Add series to the chart
			Chart1.Series.Add(series1);
			Chart1.Series.Add(series2);

			// Set chart control location
			Chart1.Location = new Point(16, 48);

			// Set Chart control size
			Chart1.Size = new Size(360, 260);

			// Add chart control to the form
			Controls.AddRange([Chart1]);
					
		}
		
	}
}
