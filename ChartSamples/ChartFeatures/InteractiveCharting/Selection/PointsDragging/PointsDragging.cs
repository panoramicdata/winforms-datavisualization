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
	/// Summary description for PointsDragging.
	/// </summary>
	public class PointsDragging : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label15;
		private ComboBox comboBoxChartType;
		private Label label1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public PointsDragging()
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
			DataPoint dataPoint1 = new DataPoint(1, 578);
			DataPoint dataPoint2 = new DataPoint(2, 220);
			DataPoint dataPoint3 = new DataPoint(3, 890);
			DataPoint dataPoint4 = new DataPoint(4, 725);
			DataPoint dataPoint5 = new DataPoint(5, 350);
			DataPoint dataPoint6 = new DataPoint(6, 100);
            label9 = new Label();
            panel1 = new Panel();
            comboBoxChartType = new ComboBox();
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
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 40);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to interactively change series data values. Click an" +
                "d drag the data points within the plot area.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxChartType);
            panel1.Controls.Add(label1);
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
            // comboBoxChartType
            // 
            comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxChartType.Items.AddRange([
            "Point",
            "Line",
            "Spline",
            "Column",
            "Cylinder",
            "Area",
            "SplineArea"]);
            comboBoxChartType.Location = new Point(168, 8);
            comboBoxChartType.Name = "comboBoxChartType";
            comboBoxChartType.Size = new Size(120, 22);
            comboBoxChartType.TabIndex = 9;
            comboBoxChartType.SelectedIndexChanged += new EventHandler(comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(24, 8);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 8;
            label1.Text = "Chart &Type:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.IsStaggered = true;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.LabelStyle.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorTickMark.Size = 2F;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
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
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.LabelFormat = "N2";
            series1.Legend = "Default";
            series1.MarkerSize = 20;
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 0;
            Chart1.MouseUp += new MouseEventHandler(Chart1_MouseUp);
            Chart1.MouseMove += new MouseEventHandler(Chart1_MouseMove);
            Chart1.MouseDown += new MouseEventHandler(Chart1_MouseDown);
            // 
            // PointsDragging
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PointsDragging";
            Size = new Size(728, 376);
            Load += new EventHandler(Form1_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		// Load Form
		private void Form1_Load(object sender, EventArgs e)
		{
			comboBoxChartType.SelectedIndex = 0;
		}

		/// <summary>
		/// Currently selected data point
		/// </summary>
		private DataPoint	selectedDataPoint = null;

		/// <summary>
		/// Mouse Down Event
		/// </summary>
		private void Chart1_MouseDown(object sender, MouseEventArgs e)
		{
			// Call Hit Test Method
			HitTestResult hitResult = Chart1.HitTest( e.X, e.Y );

			// Initialize currently selected data point
			selectedDataPoint = null;
			if( hitResult.ChartElementType == ChartElementType.DataPoint )
			{
				selectedDataPoint = (DataPoint)hitResult.Object;

				// Show point value as label
				selectedDataPoint.IsValueShownAsLabel = true;

				// Set cursor shape
				Chart1.Cursor = Cursors.SizeNS;
			}
		}

		/// <summary>
		/// Mouse Move Event
		/// </summary>
		private void Chart1_MouseMove(object sender, MouseEventArgs e)
		{
			// Check if data point selected
			if(selectedDataPoint != null)
			{
				// Mouse coordinates should not be outside of the chart 
				int coordinate = e.Y;
				if(coordinate < 0)
					coordinate = 0;
				if(coordinate > Chart1.Size.Height - 1)
					coordinate = Chart1.Size.Height - 1;

				// Calculate new Y value from current cursor position
				double yValue = Chart1.ChartAreas["Default"].AxisY.PixelPositionToValue(coordinate);
				yValue = Math.Min(yValue, Chart1.ChartAreas["Default"].AxisY.Maximum);
				yValue = Math.Max(yValue, Chart1.ChartAreas["Default"].AxisY.Minimum);


				if(( yValue <= 0) &&
					(Chart1.Series["Default"].ChartType == SeriesChartType.Column))
				{
					yValue = 0.01;
				}

				// Update selected point Y value
				selectedDataPoint.YValues[0] = yValue;

				
				// Invalidate chart
				Chart1.Invalidate();

				// Force the chart to redraw
				Chart1.Update();
			}
			else
			{
				// Set different shape of cursor over the data points
				HitTestResult hitResult = Chart1.HitTest( e.X, e.Y );
				if( hitResult.ChartElementType == ChartElementType.DataPoint )
				{
					Chart1.Cursor = Cursors.Hand;
				}
				else
				{
					Chart1.Cursor = Cursors.Default;
				}
			}
		}
		
		private void Chart1_MouseUp(object sender, MouseEventArgs e)
		{
			// Initialize currently selected data point
			if(selectedDataPoint != null)
			{
				// Hide point label
				selectedDataPoint.IsValueShownAsLabel = false;

				// reset selected object
				selectedDataPoint = null;

				// Invalidate chart
				Chart1.Invalidate();

				// Reset cursor style
				Chart1.Cursor = Cursors.Default;
			}
		}

		private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(comboBoxChartType.SelectedIndex >= 0)
			{
				Chart1.Series["Default"].DeleteCustomProperty("DrawingStyle");
				if((string)comboBoxChartType.SelectedItem == "Cylinder")
				{
					Chart1.Series["Default"].ChartType = SeriesChartType.Column;
					Chart1.Series["Default"]["DrawingStyle"] = "Cylinder";
				}
				else
				{
					Chart1.Series["Default"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), (string)comboBoxChartType.SelectedItem, true );
				}
			}
		}
	}
}
