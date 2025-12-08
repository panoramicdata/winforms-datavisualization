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
	/// Summary description for BasicPopulatingData.
	/// </summary>
	public class BasicPopulatingData : UserControl
	{
		private Panel panel1;
		private Chart Chart1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label15;
		private Label label1;
		private Label label2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public BasicPopulatingData()
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
			ChartArea chartArea2 = new ChartArea();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			Series series2 = new Series();
			Title title1 = new Title();
			panel1 = new Panel();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label15 = new Label();
			Chart1 = new Chart();
			label1 = new Label();
			label2 = new Label();
			panel1.SuspendLayout();
			((ISupportInitialize)(Chart1)).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 label6,
																				 label5,
																				 label4,
																				 label3,
																				 label15]);
			panel1.Location = new Point(400, 48);
			panel1.Name = "panel1";
			panel1.Size = new Size(304, 248);
			panel1.TabIndex = 19;
			// 
			// label6
			// 
			label6.Location = new Point(64, 403);
			label6.Name = "label6";
			label6.TabIndex = 5;
			label6.Text = "Border Size:";
			// 
			// label5
			// 
			label5.Location = new Point(64, 380);
			label5.Name = "label5";
			label5.TabIndex = 4;
			label5.Text = "Border Color:";
			// 
			// label4
			// 
			label4.Location = new Point(64, 357);
			label4.Name = "label4";
			label4.TabIndex = 3;
			label4.Text = "Hatch Style:";
			// 
			// label3
			// 
			label3.Location = new Point(64, 334);
			label3.Name = "label3";
			label3.TabIndex = 2;
			label3.Text = "Gradient:";
			// 
			// label15
			// 
			label15.Location = new Point(64, 426);
			label15.Name = "label15";
			label15.TabIndex = 5;
			label15.Text = "Border Size:";
			// 
			// Chart1
			// 
			Chart1.BackColor = System.Drawing.Color.WhiteSmoke;
			Chart1.BackSecondaryColor = System.Drawing.Color.White;
			Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			Chart1.BorderlineWidth = 2;
			Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;;
			chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;;
			chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.Name = "Data Binding";
			chartArea1.Position.Auto = false;
			chartArea1.Position.Height = 68.80695F;
			chartArea1.Position.Width = 45F;
			chartArea1.Position.X = 51F;
			chartArea1.Position.Y = 19.50579F;
			chartArea2.BackColor = System.Drawing.Color.WhiteSmoke;
			chartArea2.BackSecondaryColor = System.Drawing.Color.White;
			chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea2.Name = "Adding Points";
			chartArea2.Position.Auto = false;
			chartArea2.Position.Height = 68.80695F;
			chartArea2.Position.Width = 45F;
			chartArea2.Position.X = 3F;
			chartArea2.Position.Y = 19.50579F;
			Chart1.ChartAreas.Add(chartArea1);
			Chart1.ChartAreas.Add(chartArea2);
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Enabled = false;
			legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			legend1.TitleFont = new Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			Chart1.Legends.Add(legend1);
			Chart1.Location = new Point(16, 40);
			Chart1.Name = "Chart1";
			Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.ChartArea = "Data Binding";
            series1.ChartType = SeriesChartType.Pie;
			series1.CustomProperties = "LabelsRadialLineSize=1, PieDrawingStyle=Concave, LabelStyle=outside";
			series1.Name = "ByArray";
			series2.ChartArea = "Adding Points";
            series2.ChartType = SeriesChartType.Pie;
			series2.CustomProperties = "LabelsRadialLineSize=1, PieDrawingStyle=Concave, LabelStyle=outside";
			series2.Name = "ByPoint";
			Chart1.Series.Add(series1);
			Chart1.Series.Add(series2);
			Chart1.Size = new Size(360, 260);
			Chart1.TabIndex = 0;
			title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			title1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			title1.Name = "Default Title";
			title1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(32)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			title1.ShadowOffset = 3;
			title1.Text = "Chart Control for .NET Framework";
			Chart1.Titles.Add(title1);
            Chart1.PostPaint += new EventHandler<ChartPaintEventArgs>(Chart1_PostPaint);
			// 
			// label1
			// 
			label1.Font = new Font("Verdana", 11.25F);
			label1.Location = new Point(8, 8);
			label1.Name = "label1";
			label1.Size = new Size(624, 24);
			label1.TabIndex = 20;
			label1.Text = "This sample demonstrates how to populate a chart with data.";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			label2.Font = new Font("Verdana", 11.25F);
			label2.Location = new Point(16, 312);
			label2.Name = "label2";
			label2.Size = new Size(688, 72);
			label2.TabIndex = 21;
			label2.Text = "Two arrays are used: one for X values and one for Y values.  The chart on the lef" +
				"t uses the AddXY method to add data points to the chart, while the chart on the " +
				"right uses the DataBindXY method to bind data to an array.";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BasicPopulatingData
			// 
			BackColor = System.Drawing.Color.White;
			Controls.AddRange([
																		  label2,
																		  Chart1,
																		  panel1,
																		  label1]);
			Name = "BasicPopulatingData";
			Size = new Size(728, 400);
			Load += new EventHandler(BasicPopulatingData_Load);
			panel1.ResumeLayout(false);
			((ISupportInitialize)(Chart1)).EndInit();
			ResumeLayout(false);

		}
		#endregion

		private void BasicPopulatingData_Load(object sender, EventArgs e)
		{
			// initialize an array of doubles
			double [] yval = [5,6,4,6,3];

			// initialize an array of string
			string [] xval = ["A", "B", "C", "D", "E"];

			// bind the double array to the Y axis points of the Default data series
			Chart1.Series["ByArray"].Points.DataBindXY(xval,yval);

			// now iterate through the arrays to apply the points individually
			for(int i = 0; i < 5; i++)
			{
				Chart1.Series["ByPoint"].Points.AddXY(xval[i], yval[i]);
			}
		}

		private void Chart1_PostPaint(object sender, ChartPaintEventArgs e)
		{
			// Painting series object
			if(sender is ChartArea)
			{
				ChartArea area = (ChartArea)sender;

				
				StringFormat	format = new StringFormat();
				format.Alignment = StringAlignment.Center;

				
				RectangleF rect = new RectangleF(	area.Position.X, 
													area.Position.Y,
													area.Position.Width,
													6);

				rect = e.ChartGraphics.GetAbsoluteRectangle(rect);
				e.ChartGraphics.Graphics.DrawString(area.Name,
										new Font("Arial", 10), 
										Brushes.Black, 
										rect, 
										format);

			}
		
		}
		
		
	}
}
