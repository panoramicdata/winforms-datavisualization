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
	/// Summary description for EquallySizedAutoFont.
	/// </summary>
	public class EquallySizedAutoFont : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private CheckBox checkBoxSameSize;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public EquallySizedAutoFont()
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
			DataPoint dataPoint1 = new DataPoint(0, 12);
			DataPoint dataPoint2 = new DataPoint(0, 45);
			DataPoint dataPoint3 = new DataPoint(0, 44);
			DataPoint dataPoint4 = new DataPoint(0, 76);
			DataPoint dataPoint5 = new DataPoint(0, 38);
			DataPoint dataPoint6 = new DataPoint(0, 81);
			DataPoint dataPoint7 = new DataPoint(0, 43);
			DataPoint dataPoint8 = new DataPoint(0, 27);
			DataPoint dataPoint9 = new DataPoint(0, 28);
			DataPoint dataPoint10 = new DataPoint(0, 67);
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            checkBoxSameSize = new CheckBox();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
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
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.Points.Add(dataPoint10);
            chart1.Series.Add(series1);
            chart1.Size = new Size(576, 148);
            chart1.TabIndex = 0;
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 14);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 36);
            labelSampleComment.TabIndex = 2;
            labelSampleComment.Text = "This sample demonstrates how to use the same font size for all axes labels in a c" +
                "hart area. By default, the font size for axis labels is calculated on an axis-by" +
                "-axis basis.";
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxSameSize);
            panel1.Location = new Point(160, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 40);
            panel1.TabIndex = 1;
            // 
            // checkBoxSameSize
            // 
            checkBoxSameSize.Location = new Point(8, 8);
            checkBoxSameSize.Name = "checkBoxSameSize";
            checkBoxSameSize.Size = new Size(276, 24);
            checkBoxSameSize.TabIndex = 0;
            checkBoxSameSize.Text = "Same Font &Size for All Axes Labels";
            checkBoxSameSize.CheckedChanged += new EventHandler(checkBoxSameSize_CheckedChanged);
            // 
            // EquallySizedAutoFont
            // 
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "EquallySizedAutoFont";
            Size = new Size(728, 480);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void checkBoxSameSize_CheckedChanged(object sender, EventArgs e)
		{
			chart1.ChartAreas["Default"].IsSameFontSizeForAllAxes = checkBoxSameSize.Checked;
		}
	}
}
