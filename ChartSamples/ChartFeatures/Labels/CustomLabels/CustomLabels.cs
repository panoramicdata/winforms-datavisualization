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
	public class CustomLabels : UserControl
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

		public CustomLabels()
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
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to create custom axis labels.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(432, 46);
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX2.IsLabelAutoFit = false;
            chartArea1.AxisX2.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.Maximum = 100;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY2.Maximum = 100;
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
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series1.MarkerSize = 7;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 0;
            Chart1.MouseUp += new MouseEventHandler(Chart1_MouseUp);
            Chart1.MouseMove += new MouseEventHandler(Chart1_MouseMove);
            Chart1.MouseDown += new MouseEventHandler(Chart1_MouseDown);
            // 
            // label1
            // 
            label1.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label1.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 360);
            label1.Name = "label1";
            label1.Size = new Size(702, 80);
            label1.TabIndex = 20;
            label1.Text = "An axis can display up to three rows of labels. A custom axis label can be associ" +
                "ated with a grid line or a tick mark, or both. Click on the Y-axis labels for ad" +
                "ditional custom label options.";
            // 
            // CustomLabels
            // 
            Controls.Add(label1);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "CustomLabels";
            Size = new Size(728, 480);
            Load += new EventHandler(CustomLabels_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void CustomLabels_Load(object sender, EventArgs e)
		{
			// Populate series data
			Random		random = new Random();
			for(int pointIndex = 0; pointIndex < 5; pointIndex++)
			{
				Chart1.Series["Series1"].Points.AddXY(pointIndex+1, random.Next(10, 90));
			}

            Axis axisX = Chart1.ChartAreas["Default"].AxisX;
            Axis axisY = Chart1.ChartAreas["Default"].AxisY;

			// Set Y axis custom labels
			axisY.CustomLabels.Add(0, 30,"Low");
			axisY.CustomLabels.Add(30, 70, "Medium");
			axisY.CustomLabels.Add(70,100,"High");

			StripLine stripLow = new StripLine();
			stripLow.IntervalOffset = 0;
			stripLow.StripWidth = 30;
			stripLow.BackColor = Color.FromArgb(64, Color.Green);

			StripLine stripMed = new StripLine();
			stripMed.IntervalOffset = 30;
			stripMed.StripWidth = 40;
			stripMed.BackColor = Color.FromArgb(64, Color.Orange);

			StripLine stripHigh = new StripLine();
			stripHigh.IntervalOffset = 70;
			stripHigh.StripWidth = 30;
			stripHigh.BackColor = Color.FromArgb(64, Color.Red);

			axisY.StripLines.Add(stripLow);
			axisY.StripLines.Add(stripMed);
			axisY.StripLines.Add(stripHigh);

			// Set X axis custom labels
            CustomLabel customLabel;            
            customLabel = axisX.CustomLabels.Add(0.5, 1.5, "Jan");
            customLabel.GridTicks = GridTickTypes.All;

			customLabel = axisX.CustomLabels.Add(1.5, 2.5, "Feb");
			customLabel.GridTicks = GridTickTypes.TickMark;

            customLabel = axisX.CustomLabels.Add(2.5, 3.5, "Mar");
            customLabel.GridTicks = GridTickTypes.All;

            customLabel = axisX.CustomLabels.Add(3.5, 4.5, "Apr");
            customLabel.GridTicks = GridTickTypes.TickMark;

            customLabel = axisX.CustomLabels.Add(4.5, 5.5, "May");
            customLabel.GridTicks = GridTickTypes.All;

			// set second row of labels
            axisX.CustomLabels.Add(1.0, 4.0, "Q1", 1, LabelMarkStyle.LineSideMark);
            axisX.CustomLabels.Add(4.0, 5.0, "Q2", 1, LabelMarkStyle.LineSideMark);

			// One more row of labels
            axisX.CustomLabels.Add(1.0, 5.0, "Year 2006", 2, LabelMarkStyle.LineSideMark);
		
		}

		/// <summary>
		/// Mouse Down Event
		/// </summary>
		private void Chart1_MouseDown(object sender, MouseEventArgs e)
		{
			// Call Hit Test Method
			HitTestResult result = Chart1.HitTest( e.X, e.Y );
			
			if( result.ChartElementType == ChartElementType.AxisLabels && result.Axis == Chart1.ChartAreas["Default"].AxisY )
			{
				StripLine stripLine = new StripLine();
				stripLine.IntervalOffset = ((CustomLabel) result.Object).FromPosition;
				stripLine.Interval = 200;
				stripLine.BackColor = Color.FromArgb(128, 255,255, 255);
				stripLine.StripWidth = ((CustomLabel) result.Object).ToPosition - ((CustomLabel) result.Object).FromPosition;
				Chart1.ChartAreas["Default"].AxisY.StripLines.Add( stripLine );
			}
		
		}

		/// <summary>
		/// Mouse Move Event
		/// </summary>
		private void Chart1_MouseMove(object sender, MouseEventArgs e)
		{
			// Call Hit Test Method
			HitTestResult result = Chart1.HitTest( e.X, e.Y );
			
			// If a Data Point or a Legend item is selected.
			if(	result.ChartElementType == ChartElementType.AxisLabels && result.Axis == Chart1.ChartAreas["Default"].AxisY )
			{				
				// Set cursor type 
				Cursor = Cursors.Hand;
			}
			else
			{
				// Set default cursor
				Cursor = Cursors.Default;
			}
		}

		private void Chart1_MouseUp(object sender, MouseEventArgs e)
		{
			if( Chart1.ChartAreas["Default"].AxisY.StripLines.Count > 3 )
			{
				Chart1.ChartAreas["Default"].AxisY.StripLines.RemoveAt(3);
			}
		}


	}
}
