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
	/// Summary description for Templates.
	/// </summary>
	public class Templates : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxTemplate;
		private Label label2;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public Templates()
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
			DataPoint dataPoint1 = new DataPoint(0, 3);
			DataPoint dataPoint2 = new DataPoint(0, 4);
			DataPoint dataPoint3 = new DataPoint(0, 7);
			DataPoint dataPoint4 = new DataPoint(0, 3);
			DataPoint dataPoint5 = new DataPoint(0, 9);
			DataPoint dataPoint6 = new DataPoint(0, 7);
			DataPoint dataPoint7 = new DataPoint(0, 2);
			Series series2 = new Series();
			DataPoint dataPoint8 = new DataPoint(0, 9);
			DataPoint dataPoint9 = new DataPoint(0, 7);
			DataPoint dataPoint10 = new DataPoint(0, 5);
			DataPoint dataPoint11 = new DataPoint(0, 8);
			DataPoint dataPoint12 = new DataPoint(0, 2);
			DataPoint dataPoint13 = new DataPoint(0, 1);
			DataPoint dataPoint14 = new DataPoint(0, 5);
			Series series3 = new Series();
			DataPoint dataPoint15 = new DataPoint(0, 8);
			DataPoint dataPoint16 = new DataPoint(0, 3);
			DataPoint dataPoint17 = new DataPoint(0, 6);
			DataPoint dataPoint18 = new DataPoint(0, 1);
			DataPoint dataPoint19 = new DataPoint(0, 3);
			DataPoint dataPoint20 = new DataPoint(0, 9);
			DataPoint dataPoint21 = new DataPoint(0, 2);
			chart1 = new Chart();
			labelSampleComment = new Label();
			panel1 = new Panel();
			comboBoxTemplate = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			((ISupportInitialize)(chart1)).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// chart1
			// 
			chart1.BackColor = System.Drawing.Color.Goldenrod;
			chart1.BackSecondaryColor = System.Drawing.Color.PaleGoldenrod;
			chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
			chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
			chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
			chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea1.BackColor = System.Drawing.Color.Transparent;
			chartArea1.BorderColor = System.Drawing.Color.Empty;
			chartArea1.Name = "Default";
			chart1.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Center;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.BorderColor = System.Drawing.Color.Transparent;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
			legend1.Name = "Default";
			chart1.Legends.Add(legend1);
			chart1.Location = new Point(16, 40);
			chart1.Name = "chart1";
			chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
			series1.BackSecondaryColor = System.Drawing.Color.Khaki;
			series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			series1.Name = "Series1";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.Points.Add(dataPoint6);
			series1.Points.Add(dataPoint7);
			series1.ShadowOffset = 2;
			series2.BackSecondaryColor = System.Drawing.Color.Khaki;
			series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			series2.Name = "Series2";
			series2.Points.Add(dataPoint8);
			series2.Points.Add(dataPoint9);
			series2.Points.Add(dataPoint10);
			series2.Points.Add(dataPoint11);
			series2.Points.Add(dataPoint12);
			series2.Points.Add(dataPoint13);
			series2.Points.Add(dataPoint14);
			series2.ShadowOffset = 2;
			series3.BorderColor = System.Drawing.Color.LightGray;
			series3.BorderWidth = 3;
			series3.ChartType = SeriesChartType.Spline;
			series3.Name = "Series3";
			series3.Points.Add(dataPoint15);
			series3.Points.Add(dataPoint16);
			series3.Points.Add(dataPoint17);
			series3.Points.Add(dataPoint18);
			series3.Points.Add(dataPoint19);
			series3.Points.Add(dataPoint20);
			series3.Points.Add(dataPoint21);
			series3.ShadowOffset = 2;
			chart1.Series.Add(series1);
			chart1.Series.Add(series2);
			chart1.Series.Add(series3);
			chart1.Size = new Size(412, 296);
			chart1.TabIndex = 0;
			// 
			// labelSampleComment
			// 
			labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			labelSampleComment.Location = new Point(16, 8);
			labelSampleComment.Name = "labelSampleComment";
			labelSampleComment.Size = new Size(702, 24);
			labelSampleComment.TabIndex = 2;
			labelSampleComment.Text = "This sample demonstrates how to load appearance templates using serialization.";
			labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 comboBoxTemplate,
																				 label1]);
			panel1.Location = new Point(432, 48);
			panel1.Name = "panel1";
			panel1.Size = new Size(292, 288);
			panel1.TabIndex = 1;
			// 
			// comboBoxTemplate
			// 
			comboBoxTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxTemplate.Items.AddRange([
																  "None",
																  "WhiteSmoke",
																  "SkyBlue",
																  "WarmTones"]);
			comboBoxTemplate.Location = new Point(168, 8);
			comboBoxTemplate.Name = "comboBoxTemplate";
			comboBoxTemplate.TabIndex = 1;
			comboBoxTemplate.SelectedIndexChanged += new EventHandler(comboBoxTemplate_SelectedIndexChanged);
			// 
			// label1
			// 
			label1.Location = new Point(56, 8);
			label1.Name = "label1";
			label1.Size = new Size(104, 23);
			label1.TabIndex = 0;
			label1.Text = "&Template:";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			label2.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			label2.Location = new Point(16, 344);
			label2.Name = "label2";
			label2.Size = new Size(702, 48);
			label2.TabIndex = 3;
			label2.Text = "Template files are in an XML format, and can be created using any text editor or " +
				"by using the Save method of the ChartSerializer class.";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Templates
			// 
			BackColor = System.Drawing.Color.White;
			Controls.AddRange([
																		  label2,
																		  panel1,
																		  labelSampleComment,
																		  chart1]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "Templates";
			Size = new Size(728, 440);
			Load += new EventHandler(Templates_Load);
			((ISupportInitialize)(chart1)).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);

		}
		#endregion

		private void Templates_Load(object sender, EventArgs e)
		{
			// Set current template
			comboBoxTemplate.SelectedIndex = 1;
		}

		private void comboBoxTemplate_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(comboBoxTemplate.Text == "None")
			{
				// Reset chart appearance
				chart1.Serializer.Content = SerializationContents.Appearance;
				chart1.Serializer.Reset();
			}
			else
			{
				// Get template path
				MainForm mainForm = (MainForm)ParentForm;
                string imageFileName = mainForm.CurrentSamplePath;
				imageFileName += "\\" + comboBoxTemplate.Text + ".xml";

				// Load template		
                chart1.Serializer.IsResetWhenLoading = false;
				chart1.LoadTemplate(imageFileName);
			}
		}
	}
}
