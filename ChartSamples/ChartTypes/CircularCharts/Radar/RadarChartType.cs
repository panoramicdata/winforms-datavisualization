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
	/// Summary description for RadarChartType.
	/// </summary>
	public class RadarChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private Label label2;
		private Label label3;
		private ComboBox comboBoxLabelStyle;
		private ComboBox comboBoxAreaStyle;
		private ComboBox comboBoxRadarStyle;
		private Label label5;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public RadarChartType()
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
			Series series2 = new Series();
			Title title1 = new Title();
			chart1 = new Chart();
			labelSampleComment = new Label();
			panel1 = new Panel();
			comboBoxLabelStyle = new ComboBox();
			label3 = new Label();
			comboBoxAreaStyle = new ComboBox();
			label2 = new Label();
			comboBoxRadarStyle = new ComboBox();
			label1 = new Label();
			label5 = new Label();
			((ISupportInitialize)(chart1)).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// chart1
			// 
			chart1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(243)), ((System.Byte)(223)), ((System.Byte)(193)));
			chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(181)), ((System.Byte)(64)), ((System.Byte)(1)));
			chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chart1.BorderlineWidth = 2;
			chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorTickMark.Size = 0.6F;
			chartArea1.BackColor = System.Drawing.Color.OldLace;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.Position.Auto = false;
			chartArea1.Position.Height = 78F;
			chartArea1.Position.Width = 88F;
			chartArea1.Position.X = 5F;
			chartArea1.Position.Y = 15F;
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			chart1.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Far;
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			legend1.Position.Auto = false;
			legend1.Position.Height = 14.23021F;
			legend1.Position.Width = 19.34047F;
			legend1.Position.X = 74.73474F;
			legend1.Position.Y = 74.08253F;
			chart1.Legends.Add(legend1);
			chart1.Location = new Point(16, 56);
			chart1.Name = "chart1";
			chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartType = SeriesChartType.Radar;
			series1.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(65)), ((System.Byte)(140)), ((System.Byte)(240)));
			series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			series1.MarkerSize = 9;
			series1.Name = "Series1";
			series1.ShadowOffset = 1;
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
            series2.ChartType = SeriesChartType.Radar;
			series2.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(252)), ((System.Byte)(180)), ((System.Byte)(65)));
			series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			series2.MarkerSize = 9;
			series2.Name = "Series2";
			series2.ShadowOffset = 1;
			chart1.Series.Add(series1);
			chart1.Series.Add(series2);
			chart1.Size = new Size(412, 288);
			chart1.TabIndex = 1;
			title1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
			title1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(32)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			title1.ShadowOffset = 3;
			title1.Text = "Radar Chart";
			chart1.Titles.Add(title1);
			// 
			// labelSampleComment
			// 
			labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			labelSampleComment.Location = new Point(16, 8);
			labelSampleComment.Name = "labelSampleComment";
			labelSampleComment.Size = new Size(702, 42);
			labelSampleComment.TabIndex = 0;
			labelSampleComment.Text = "This sample displays a Radar chart, which is a circular graph used primarily as a" +
				" comparative tool. A 3D effect can also be added to the area background.";
			labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 comboBoxLabelStyle,
																				 label3,
																				 comboBoxAreaStyle,
																				 label2,
																				 comboBoxRadarStyle,
																				 label1]);
			panel1.Location = new Point(432, 72);
			panel1.Name = "panel1";
			panel1.Size = new Size(292, 272);
			panel1.TabIndex = 2;
			// 
			// comboBoxLabelStyle
			// 
			comboBoxLabelStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxLabelStyle.Items.AddRange([
																	"Circular",
																	"Radial",
																	"Horizontal"]);
			comboBoxLabelStyle.Location = new Point(168, 64);
			comboBoxLabelStyle.Name = "comboBoxLabelStyle";
			comboBoxLabelStyle.Size = new Size(96, 22);
			comboBoxLabelStyle.TabIndex = 5;
			comboBoxLabelStyle.SelectedIndexChanged += new EventHandler(comboBoxExploded_SelectedIndexChanged);
			// 
			// label3
			// 
			label3.Location = new Point(19, 64);
			label3.Name = "label3";
			label3.Size = new Size(145, 23);
			label3.TabIndex = 4;
			label3.Text = "&Labels Style:";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxAreaStyle
			// 
			comboBoxAreaStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxAreaStyle.Items.AddRange([
																   "Circle",
																   "Polygon"]);
			comboBoxAreaStyle.Location = new Point(168, 32);
			comboBoxAreaStyle.Name = "comboBoxAreaStyle";
			comboBoxAreaStyle.Size = new Size(96, 22);
			comboBoxAreaStyle.TabIndex = 3;
			comboBoxAreaStyle.SelectedIndexChanged += new EventHandler(comboBoxExploded_SelectedIndexChanged);
			// 
			// label2
			// 
			label2.Location = new Point(6, 32);
			label2.Name = "label2";
			label2.Size = new Size(157, 23);
			label2.TabIndex = 2;
			label2.Text = "&Area Drawing Style:";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxRadarStyle
			// 
			comboBoxRadarStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxRadarStyle.Items.AddRange([
																	"Area",
																	"Line",
																	"Marker"]);
			comboBoxRadarStyle.Location = new Point(168, 0);
			comboBoxRadarStyle.Name = "comboBoxRadarStyle";
			comboBoxRadarStyle.Size = new Size(96, 22);
			comboBoxRadarStyle.TabIndex = 1;
			comboBoxRadarStyle.SelectedIndexChanged += new EventHandler(comboBoxExploded_SelectedIndexChanged);
			// 
			// label1
			// 
			label1.Location = new Point(-14, 0);
			label1.Name = "label1";
			label1.Size = new Size(177, 23);
			label1.TabIndex = 0;
			label1.Text = "Radar &Style:";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			label5.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			label5.Font = new Font("Verdana", 11F);
			label5.Location = new Point(16, 352);
			label5.Name = "label5";
			label5.Size = new Size(696, 24);
			label5.TabIndex = 25;
			label5.Text = "Try different styles for the radar, area drawing and labels.";
			label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RadarChartType
			// 
			BackColor = System.Drawing.Color.White;
			Controls.AddRange([
																		  label5,
																		  panel1,
																		  labelSampleComment,
																		  chart1]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "RadarChartType";
			Size = new Size(728, 480);
			Load += new EventHandler(PieChartType_Load);
			((ISupportInitialize)(chart1)).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Set radar chart style
			chart1.Series["Series1"]["RadarDrawingStyle"] = (string)comboBoxRadarStyle.SelectedItem;
			chart1.Series["Series2"]["RadarDrawingStyle"] = (string)comboBoxRadarStyle.SelectedItem;
			if((string)comboBoxRadarStyle.SelectedItem == "Area")
			{
				chart1.Series["Series1"].BorderColor = Color.FromArgb(100,100,100);
				chart1.Series["Series1"].BorderWidth = 1;
				chart1.Series["Series2"].BorderColor = Color.FromArgb(100,100,100);
				chart1.Series["Series2"].BorderWidth = 1;
			}
			else if((string)comboBoxRadarStyle.SelectedItem == "Line")
			{
				chart1.Series["Series1"].BorderColor = Color.Empty;
				chart1.Series["Series1"].BorderWidth = 2;
				chart1.Series["Series2"].BorderColor = Color.Empty;
				chart1.Series["Series2"].BorderWidth = 2;
			}
			else if((string)comboBoxRadarStyle.SelectedItem == "Marker")
			{
				chart1.Series["Series1"].BorderColor = Color.Empty;
				chart1.Series["Series2"].BorderColor = Color.Empty;
			}

			// Set circular area drawing style
			chart1.Series["Series1"]["AreaDrawingStyle"] = (string)comboBoxAreaStyle.SelectedItem;
			chart1.Series["Series2"]["AreaDrawingStyle"] = (string)comboBoxAreaStyle.SelectedItem;

			// Set labels style
			chart1.Series["Series1"]["CircularLabelsStyle"] = (string)comboBoxLabelStyle.SelectedItem;
			chart1.Series["Series2"]["CircularLabelsStyle"] = (string)comboBoxLabelStyle.SelectedItem;

		}

		private void PieChartType_Load(object sender, EventArgs e)
		{
			// Populate series data
			double[]	yValues = [65.62, 75.54, 60.45, 34.73, 85.42, 55.9, 63.6, 55.1, 77.2];
			double[]	yValues2 = [76.45, 23.78, 86.45, 30.76, 23.79, 35.67, 89.56, 67.45, 38.98];
			string[]	xValues = ["France", "Canada", "Germany", "USA", "Italy", "Spain", "Russia", "Sweden", "Japan"];
			chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
			chart1.Series["Series2"].Points.DataBindXY(xValues, yValues2);

			// Set selection
			comboBoxRadarStyle.SelectedIndex = 0;
			comboBoxAreaStyle.SelectedIndex = 0;
			comboBoxLabelStyle.SelectedIndex = 2;

			UpdateChartSettings();	
		}

		private void comboBoxExploded_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}


	}
}
