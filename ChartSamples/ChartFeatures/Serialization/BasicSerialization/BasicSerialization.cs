using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for BasicSerialization.
	/// </summary>
	public class BasicSerialization : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Chart chart2;
		private Button buttonLoad;
		private Button buttonResetAppearance;
		private Button buttonResetData;
		private Label label1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public BasicSerialization()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize combo boxes
		
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
			DataPoint dataPoint1 = new DataPoint(0, "3,0");
			DataPoint dataPoint2 = new DataPoint(0, "7,0");
			DataPoint dataPoint3 = new DataPoint(0, "4,0");
			DataPoint dataPoint4 = new DataPoint(0, "1,0");
			DataPoint dataPoint5 = new DataPoint(0, "8,0");
			DataPoint dataPoint6 = new DataPoint(0, "9,0");
			DataPoint dataPoint7 = new DataPoint(0, "1,0");
			DataPoint dataPoint8 = new DataPoint(0, "2,0");
			DataPoint dataPoint9 = new DataPoint(0, "8,0");
			DataPoint dataPoint10 = new DataPoint(0, "6,0");
			DataPoint dataPoint11 = new DataPoint(0, "1,0");
			Series series2 = new Series();
			DataPoint dataPoint12 = new DataPoint(0, 5);
			DataPoint dataPoint13 = new DataPoint(0, 8);
			DataPoint dataPoint14 = new DataPoint(0, 2);
			DataPoint dataPoint15 = new DataPoint(0, 5);
			DataPoint dataPoint16 = new DataPoint(0, 6);
			DataPoint dataPoint17 = new DataPoint(0, 3);
			DataPoint dataPoint18 = new DataPoint(0, 9);
			DataPoint dataPoint19 = new DataPoint(0, 8);
			DataPoint dataPoint20 = new DataPoint(0, 4);
			DataPoint dataPoint21 = new DataPoint(0, 7);
			DataPoint dataPoint22 = new DataPoint(0, 2);
			Title title1 = new Title();
			ChartArea chartArea2 = new ChartArea();
			Legend legend2 = new Legend();
			Series series3 = new Series();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            buttonResetData = new Button();
            buttonResetAppearance = new Button();
            buttonLoad = new Button();
            chart2 = new Chart();
            label1 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)(chart2)).BeginInit();
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
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 40);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Legend = "Default";
            series1.Name = "Series1";
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
            series1.Points.Add(dataPoint11);
            series1.ShadowColor = System.Drawing.Color.Black;
            series1.ShadowOffset = 1;
            series1.YValuesPerPoint = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.BorderWidth = 3;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.Points.Add(dataPoint15);
            series2.Points.Add(dataPoint16);
            series2.Points.Add(dataPoint17);
            series2.Points.Add(dataPoint18);
            series2.Points.Add(dataPoint19);
            series2.Points.Add(dataPoint20);
            series2.Points.Add(dataPoint21);
            series2.Points.Add(dataPoint22);
            series2.ShadowColor = System.Drawing.Color.Black;
            series2.ShadowOffset = 1;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(250, 260);
            chart1.TabIndex = 1;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Serialization Sample";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 24);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to save, load, and reset chart data using serializat" +
                "ion.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonResetData);
            panel1.Controls.Add(buttonResetAppearance);
            panel1.Controls.Add(buttonLoad);
            panel1.Location = new Point(536, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 248);
            panel1.TabIndex = 2;
            // 
            // buttonResetData
            // 
            buttonResetData.BackColor = System.Drawing.SystemColors.Control;
            buttonResetData.Location = new Point(8, 128);
            buttonResetData.Name = "buttonResetData";
            buttonResetData.Size = new Size(200, 40);
            buttonResetData.TabIndex = 2;
            buttonResetData.Text = "Reset &Second Chart";
            buttonResetData.UseVisualStyleBackColor = false;
            buttonResetData.Click += new EventHandler(buttonResetData_Click);
            // 
            // buttonResetAppearance
            // 
            buttonResetAppearance.BackColor = System.Drawing.SystemColors.Control;
            buttonResetAppearance.Location = new Point(8, 72);
            buttonResetAppearance.Name = "buttonResetAppearance";
            buttonResetAppearance.Size = new Size(200, 40);
            buttonResetAppearance.TabIndex = 1;
            buttonResetAppearance.Text = "&Reset Visual Appearance of the Second  Chart";
            buttonResetAppearance.UseVisualStyleBackColor = false;
            buttonResetAppearance.Click += new EventHandler(buttonReset_Click);
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = System.Drawing.SystemColors.Control;
            buttonLoad.Location = new Point(8, 16);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(200, 40);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "&Load Data from the First Chart into the Second Chart";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += new EventHandler(buttonLoad_Click);
            // 
            // chart2
            // 
            chart2.BorderlineColor = System.Drawing.Color.Black;
            chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "Default";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Default";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(280, 40);
            chart2.Name = "chart2";
            series3.ChartArea = "Default";
            series3.Legend = "Default";
            series3.Name = "Default";
            chart2.Series.Add(series3);
            chart2.Size = new Size(250, 260);
            chart2.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 312);
            label1.Name = "label1";
            label1.Size = new Size(702, 64);
            label1.TabIndex = 4;
            label1.Text = "In this sample, data and appearance settings from the first chart is saved into a" +
                " stream and then loaded into the second chart. You can then reset the second cha" +
                "rt in two different ways.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BasicSerialization
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label1);
            Controls.Add(chart2);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "BasicSerialization";
            Size = new Size(752, 400);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(chart2)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void buttonLoad_Click(object sender, EventArgs e)
		{
			// Save first chart into the memory stream
			chart2.Serializer.Content = SerializationContents.Default;
			MemoryStream ms = new MemoryStream();
			chart1.Serializer.Save(ms);

			// Load data from memory stream into the second chart
			ms.Seek(0, SeekOrigin.Begin);
			chart2.Serializer.Load(ms);
			ms.Close();
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			// Reset visual appearance of the second chart
			chart2.Serializer.Content = SerializationContents.Appearance;
			chart2.Serializer.Reset();		

			// Show border around second chart
			chart2.BorderlineColor = Color.Black;
			chart2.BorderlineDashStyle = ChartDashStyle.Solid;
		}

		private void buttonResetData_Click(object sender, EventArgs e)
		{
			// Reset data of the second chart
			chart2.Serializer.Content = SerializationContents.All;
			chart2.Serializer.Reset();		

			chart2.Width = chart1.Width;
			chart2.Height = chart1.Height;

			// Show border around second chart
			chart2.BorderlineColor = Color.Black;
			chart2.BorderlineDashStyle = ChartDashStyle.Solid;
		}
	}
}
