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
	/// Summary description for ZoomingExtents.
	/// </summary>
	public class ZoomingExtents : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxMinSize;
		private Button buttonResetZoom;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public ZoomingExtents()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

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
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            buttonResetZoom = new Button();
            comboBoxMinSize = new ComboBox();
            label1 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScrollBar.Size = 12;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisY.ScrollBar.Size = 12;
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.LightBlue;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 65);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.ShadowOffset = 1;
            chart1.Series.Add(series1);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            chart1.AxisViewChanged += new EventHandler<ViewEventArgs>(chart1_AxisViewChanged);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 14);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 43);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to limit the minimum view size.  To zoom in, left-cl" +
                "ick on the chart, and then drag the mouse.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonResetZoom);
            panel1.Controls.Add(comboBoxMinSize);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // buttonResetZoom
            // 
            buttonResetZoom.BackColor = System.Drawing.SystemColors.Control;
            buttonResetZoom.Location = new Point(112, 56);
            buttonResetZoom.Name = "buttonResetZoom";
            buttonResetZoom.Size = new Size(128, 23);
            buttonResetZoom.TabIndex = 2;
            buttonResetZoom.Text = "&Reset Zoom";
            buttonResetZoom.UseVisualStyleBackColor = false;
            buttonResetZoom.Click += new EventHandler(buttonResetZoom_Click);
            // 
            // comboBoxMinSize
            // 
            comboBoxMinSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxMinSize.Items.AddRange([
            "None",
            "3 days",
            "1 week",
            "2 weeks",
            "1 month"]);
            comboBoxMinSize.Location = new Point(168, 8);
            comboBoxMinSize.Name = "comboBoxMinSize";
            comboBoxMinSize.Size = new Size(120, 22);
            comboBoxMinSize.TabIndex = 1;
            comboBoxMinSize.SelectedIndexChanged += new EventHandler(comboBoxMinSize_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(24, 8);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 0;
            label1.Text = "View Min. &Size:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ZoomingExtents
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "ZoomingExtents";
            Size = new Size(728, 368);
            Load += new EventHandler(ZoomingExtents_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void ZoomingExtents_Load(object sender, EventArgs e)
		{
			comboBoxMinSize.SelectedIndex = 0;

			// Fill chart with random data
			Random		random = new Random();
			DateTime	date = DateTime.Now.Date;
			for(int pointIndex = 0; pointIndex < 49; pointIndex++)
			{
				chart1.Series["Default"].Points.AddXY(date, random.Next(100, 1000));
				date = date.AddDays(1);
			}
		
		}

		private void comboBoxMinSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(comboBoxMinSize.SelectedIndex == 1)
			{
				chart1.ChartAreas["Default"].AxisX.ScaleView.MinSize = 3;
				chart1.ChartAreas["Default"].AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Days;
			}
			else if(comboBoxMinSize.SelectedIndex == 2)
			{
				chart1.ChartAreas["Default"].AxisX.ScaleView.MinSize = 1;
				chart1.ChartAreas["Default"].AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Weeks;
			}
			else if(comboBoxMinSize.SelectedIndex == 3)
			{
				chart1.ChartAreas["Default"].AxisX.ScaleView.MinSize = 2;
				chart1.ChartAreas["Default"].AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Weeks;
			}
			else if(comboBoxMinSize.SelectedIndex == 4)
			{
				chart1.ChartAreas["Default"].AxisX.ScaleView.MinSize = 1;
				chart1.ChartAreas["Default"].AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Months;
			}
			else
			{
				chart1.ChartAreas["Default"].AxisX.ScaleView.MinSize = 0;
			}

			// Reset current axis view
			chart1.ChartAreas["Default"].AxisX.ScaleView.ZoomReset(0);
		}

		private void chart1_AxisViewChanged(object sender, ViewEventArgs e)
		{
			// Change label format when showing hours
			chart1.ChartAreas["Default"].RecalculateAxesScale();
			chart1.ChartAreas["Default"].AxisX.LabelStyle.Format = "";
			if(chart1.ChartAreas["Default"].AxisX.LabelStyle.IntervalType == DateTimeIntervalType.Hours)
			{
				chart1.ChartAreas["Default"].AxisX.LabelStyle.Format = "MMM d, hh tt";
                chart1.ChartAreas["Default"].RecalculateAxesScale();
			}
		}

		private void buttonResetZoom_Click(object sender, EventArgs e)
		{
			chart1.ChartAreas["Default"].AxisX.ScaleView.ZoomReset(0);
		}

	}
}
