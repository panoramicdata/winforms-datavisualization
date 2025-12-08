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
	/// Summary description for CursorPositionChanged.
	/// </summary>
	public class CursorPositionChanged : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private TextBox CursorX;
		private Label label2;
        private TextBox CursorY;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public CursorPositionChanged()
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
			DataPoint dataPoint1 = new DataPoint(0, 4);
			DataPoint dataPoint2 = new DataPoint(0, 7);
			DataPoint dataPoint3 = new DataPoint(0, 6);
			DataPoint dataPoint4 = new DataPoint(0, 9);
			DataPoint dataPoint5 = new DataPoint(0, 6);
			Title title1 = new Title();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            CursorY = new TextBox();
            label2 = new Label();
            CursorX = new TextBox();
            label1 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BackSecondaryColor = System.Drawing.Color.White;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "MMM dd";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Size = 2F;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.Position = 2;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.Gray;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.CursorY.Position = 2;
            chartArea1.CursorY.SelectionColor = System.Drawing.Color.Gray;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 76.3605F;
            chartArea1.Position.Width = 86F;
            chartArea1.Position.X = 4.824818F;
            chartArea1.Position.Y = 16.82594F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 60);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart1.Series.Add(series1);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 0;
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Chart Control for .NET Framework";
            chart1.Titles.Add(title1);
            chart1.CursorPositionChanging += new EventHandler<CursorEventArgs>(chart1_CursorPositionChanging);
            chart1.CursorPositionChanged += new EventHandler<CursorEventArgs>(chart1_CursorPositionChanged);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 14);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 43);
            labelSampleComment.TabIndex = 2;
            labelSampleComment.Text = "This sample demonstrates how to retrieve the cursor\'s coordinates using the Curso" +
                "rPositionChanging event.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(CursorY);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CursorX);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 1;
            // 
            // CursorY
            // 
            CursorY.BackColor = System.Drawing.Color.White;
            CursorY.Location = new Point(168, 40);
            CursorY.Name = "CursorY";
            CursorY.ReadOnly = true;
            CursorY.Size = new Size(120, 22);
            CursorY.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(16, 40);
            label2.Name = "label2";
            label2.Size = new Size(144, 24);
            label2.TabIndex = 2;
            label2.Text = "&Y Cursor Position:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CursorX
            // 
            CursorX.BackColor = System.Drawing.Color.White;
            CursorX.Location = new Point(168, 8);
            CursorX.Name = "CursorX";
            CursorX.ReadOnly = true;
            CursorX.Size = new Size(120, 22);
            CursorX.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(16, 8);
            label1.Name = "label1";
            label1.Size = new Size(144, 24);
            label1.TabIndex = 0;
            label1.Text = "&X Cursor Position:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CursorPositionChanged
            // 
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "CursorPositionChanged";
            Size = new Size(728, 408);
            Load += new EventHandler(CursorPositionChanged_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

		}
		#endregion


		private void CursorPositionChanged_Load(object sender, EventArgs e)
		{
			// Fill chart with random data
			Random	random = new Random();
			for(int pointIndex = 0; pointIndex < 100; pointIndex++)
			{
				chart1.Series["Default"].Points.AddY(random.Next(10, 100));
			}

			// Set Initial Cursor Position
			SetPosition( chart1.ChartAreas[0].AxisX, chart1.ChartAreas[0].CursorX.Position );
			SetPosition( chart1.ChartAreas[0].AxisY, chart1.ChartAreas[0].CursorY.Position );
		}

		// Cursor Position Changed Event
		private void chart1_CursorPositionChanged(object sender, CursorEventArgs e)
		{
			SetPosition( e.Axis, e.NewPosition );
		}

		// Cursor Position Changing Event
		private void chart1_CursorPositionChanging(object sender, CursorEventArgs e)
		{
			SetPosition( e.Axis, e.NewPosition );
		}

		// Set Cursor Position to Edit control.
		private void SetPosition( Axis axis, double position )
		{
			if( double.IsNaN( position ) )
				return;

			if( axis.AxisName == AxisName.X )
			{
				// Convert Double to DateTime.
				DateTime dateTimeX = DateTime.FromOADate( position );
						
				// Set X cursor position to edit Control
				CursorX.Text = dateTimeX.ToString("ddd, dd MMM");
			}
			else
			{
				// Set Y cursor position to edit Control
				CursorY.Text = position.ToString();
			}
		}
	}
}
