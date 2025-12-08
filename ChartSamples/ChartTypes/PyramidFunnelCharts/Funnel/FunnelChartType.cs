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
	/// Summary description for FunnelChartType.
	/// </summary>
	public class FunnelChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private Label label2;
		private CheckBox checkBoxShow3D;
		private ComboBox comboBoxLabelsStyle;
		private ComboBox comboBoxFunnelStyle;
		private ComboBox comboBoxLabelsPlacement;
		private Label labelOutsideLabelsPlacement;
		private Label label3;
		private NumericUpDown numericUpDownGap;
		private NumericUpDown numericUpDownMinHeight;
		private Label label4;
		private NumericUpDown numericUpDownAngle;
		private Label labelAngle;
		private ComboBox comboBox3DDrawingStyle;
		private Label label3DDrawingStyle;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public FunnelChartType()
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
			DataPoint dataPoint1 = new DataPoint(0, 216.19999694824219);
			DataPoint dataPoint2 = new DataPoint(0, 125.80000305175781);
			DataPoint dataPoint3 = new DataPoint(0, 90);
			DataPoint dataPoint4 = new DataPoint(0, 2.5999999046325684);
			DataPoint dataPoint5 = new DataPoint(0, 55.700000762939453);
			DataPoint dataPoint6 = new DataPoint(0, 25.299999237060547);
			Title title1 = new Title();
			chart1 = new Chart();
			labelSampleComment = new Label();
			panel1 = new Panel();
			comboBox3DDrawingStyle = new ComboBox();
			label3DDrawingStyle = new Label();
			numericUpDownAngle = new NumericUpDown();
			labelAngle = new Label();
			numericUpDownMinHeight = new NumericUpDown();
			label4 = new Label();
			numericUpDownGap = new NumericUpDown();
			label3 = new Label();
			comboBoxLabelsPlacement = new ComboBox();
			labelOutsideLabelsPlacement = new Label();
			checkBoxShow3D = new CheckBox();
			comboBoxLabelsStyle = new ComboBox();
			label2 = new Label();
			comboBoxFunnelStyle = new ComboBox();
			label1 = new Label();
			((ISupportInitialize)(chart1)).BeginInit();
			panel1.SuspendLayout();
			((ISupportInitialize)(numericUpDownAngle)).BeginInit();
			((ISupportInitialize)(numericUpDownMinHeight)).BeginInit();
			((ISupportInitialize)(numericUpDownGap)).BeginInit();
			SuspendLayout();
			// 
			// chart1
			// 
			chart1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(223)), ((System.Byte)(240)));
			chart1.BackSecondaryColor = System.Drawing.Color.White;
			chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
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
			chartArea1.BackColor = System.Drawing.Color.Transparent;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BorderWidth = 0;
			chartArea1.Name = "Default";
			chartArea1.Position.Auto = false;
			chartArea1.Position.Height = 81F;
			chartArea1.Position.Width = 89.43796F;
			chartArea1.Position.X = 5F;
			chartArea1.Position.Y = 12F;
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			chart1.ChartAreas.Add(chartArea1);
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Enabled = false;
			legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			chart1.Legends.Add(legend1);
			chart1.Location = new Point(16, 40);
			chart1.Name = "chart1";
			chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartType = SeriesChartType.Funnel;
			series1.CustomProperties = "FunnelMinPointHeight=1";
			series1.LabelFormat = "F1";
			series1.Name = "Default";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.Points.Add(dataPoint6);
			series1.IsValueShownAsLabel = true;
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			chart1.Series.Add(series1);
			chart1.Size = new Size(412, 296);
			chart1.TabIndex = 0;
			title1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
			title1.Position.Auto = false;
			title1.Position.Height = 6.470197F;
			title1.Position.Width = 90F;
			title1.Position.Y = 3F;
			title1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(32)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			title1.ShadowOffset = 3;
			title1.Text = "Funnel chart";
			chart1.Titles.Add(title1);
			// 
			// labelSampleComment
			// 
			labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			labelSampleComment.Location = new Point(16, 8);
			labelSampleComment.Name = "labelSampleComment";
			labelSampleComment.Size = new Size(702, 24);
			labelSampleComment.TabIndex = 2;
			labelSampleComment.Text = "A Funnel chart is used to display data that adds up to 100%.";
			labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 comboBox3DDrawingStyle,
																				 label3DDrawingStyle,
																				 numericUpDownAngle,
																				 labelAngle,
																				 numericUpDownMinHeight,
																				 label4,
																				 numericUpDownGap,
																				 label3,
																				 comboBoxLabelsPlacement,
																				 labelOutsideLabelsPlacement,
																				 checkBoxShow3D,
																				 comboBoxLabelsStyle,
																				 label2,
																				 comboBoxFunnelStyle,
																				 label1]);
			panel1.Location = new Point(432, 48);
			panel1.Name = "panel1";
			panel1.Size = new Size(312, 288);
			panel1.TabIndex = 0;
			// 
			// comboBox3DDrawingStyle
			// 
			comboBox3DDrawingStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBox3DDrawingStyle.Items.AddRange([
																		"CircularBase",
																		"SquareBase"]);
			comboBox3DDrawingStyle.Location = new Point(168, 232);
			comboBox3DDrawingStyle.Name = "comboBox3DDrawingStyle";
			comboBox3DDrawingStyle.Size = new Size(144, 22);
			comboBox3DDrawingStyle.TabIndex = 14;
			comboBox3DDrawingStyle.SelectedIndexChanged += new EventHandler(comboBox3DDrawingStyle_SelectedIndexChanged);
			// 
			// label3DDrawingStyle
			// 
			label3DDrawingStyle.Location = new Point(20, 232);
			label3DDrawingStyle.Name = "label3DDrawingStyle";
			label3DDrawingStyle.Size = new Size(144, 23);
			label3DDrawingStyle.TabIndex = 13;
			label3DDrawingStyle.Text = "&Drawing Style:";
			label3DDrawingStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDownAngle
			// 
			numericUpDownAngle.Location = new Point(168, 200);
			numericUpDownAngle.Maximum = new System.Decimal([
																			   10,
																			   0,
																			   0,
																			   0]);
			numericUpDownAngle.Minimum = new System.Decimal([
																			   10,
																			   0,
																			   0,
																			   -2147483648]);
			numericUpDownAngle.Name = "numericUpDownAngle";
			numericUpDownAngle.Size = new Size(144, 22);
			numericUpDownAngle.TabIndex = 12;
			numericUpDownAngle.Value = new System.Decimal([
																			 5,
																			 0,
																			 0,
																			 0]);
			numericUpDownAngle.ValueChanged += new EventHandler(numericUpDownAngle_ValueChanged);
			// 
			// labelAngle
			// 
			labelAngle.Location = new Point(20, 200);
			labelAngle.Name = "labelAngle";
			labelAngle.Size = new Size(144, 23);
			labelAngle.TabIndex = 11;
			labelAngle.Text = "Rotation &Angle:";
			labelAngle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDownMinHeight
			// 
			numericUpDownMinHeight.Location = new Point(168, 136);
			numericUpDownMinHeight.Maximum = new System.Decimal([
																				   10,
																				   0,
																				   0,
																				   0]);
			numericUpDownMinHeight.Name = "numericUpDownMinHeight";
			numericUpDownMinHeight.Size = new Size(144, 22);
			numericUpDownMinHeight.TabIndex = 9;
			numericUpDownMinHeight.ValueChanged += new EventHandler(numericUpDownMinHeight_ValueChanged);
			// 
			// label4
			// 
			label4.Location = new Point(20, 136);
			label4.Name = "label4";
			label4.Size = new Size(144, 23);
			label4.TabIndex = 8;
			label4.Text = "&Min. Point Height:";
			label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDownGap
			// 
			numericUpDownGap.Location = new Point(168, 104);
			numericUpDownGap.Maximum = new System.Decimal([
																			 5,
																			 0,
																			 0,
																			 0]);
			numericUpDownGap.Name = "numericUpDownGap";
			numericUpDownGap.Size = new Size(144, 22);
			numericUpDownGap.TabIndex = 7;
			numericUpDownGap.ValueChanged += new EventHandler(numericUpDownGap_ValueChanged);
			// 
			// label3
			// 
			label3.Location = new Point(20, 104);
			label3.Name = "label3";
			label3.Size = new Size(144, 23);
			label3.TabIndex = 6;
			label3.Text = "Points &Gap:";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxLabelsPlacement
			// 
			comboBoxLabelsPlacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxLabelsPlacement.Items.AddRange([
																		 "Right",
																		 "Left"]);
			comboBoxLabelsPlacement.Location = new Point(168, 72);
			comboBoxLabelsPlacement.Name = "comboBoxLabelsPlacement";
			comboBoxLabelsPlacement.Size = new Size(144, 22);
			comboBoxLabelsPlacement.TabIndex = 5;
			comboBoxLabelsPlacement.SelectedIndexChanged += new EventHandler(comboBoxLabelsPlacement_SelectedIndexChanged);
			// 
			// labelOutsideLabelsPlacement
			// 
			labelOutsideLabelsPlacement.Location = new Point(20, 72);
			labelOutsideLabelsPlacement.Name = "labelOutsideLabelsPlacement";
			labelOutsideLabelsPlacement.Size = new Size(144, 23);
			labelOutsideLabelsPlacement.TabIndex = 4;
			labelOutsideLabelsPlacement.Text = "Labels &Placement:";
			labelOutsideLabelsPlacement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// checkBoxShow3D
			// 
			checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			checkBoxShow3D.Location = new Point(6, 168);
			checkBoxShow3D.Name = "checkBoxShow3D";
			checkBoxShow3D.Size = new Size(176, 24);
			checkBoxShow3D.TabIndex = 10;
			checkBoxShow3D.Text = "Display chart as &3D:";
			checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			checkBoxShow3D.CheckedChanged += new EventHandler(checkBoxShow3D_CheckedChanged);
			// 
			// comboBoxLabelsStyle
			// 
			comboBoxLabelsStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxLabelsStyle.Items.AddRange([
																	 "OutsideInColumn",
																	 "Outside",
																	 "Inside",
																	 "Disabled"]);
			comboBoxLabelsStyle.Location = new Point(168, 40);
			comboBoxLabelsStyle.Name = "comboBoxLabelsStyle";
			comboBoxLabelsStyle.Size = new Size(144, 22);
			comboBoxLabelsStyle.TabIndex = 3;
			comboBoxLabelsStyle.SelectedIndexChanged += new EventHandler(comboBoxLabelsStyle_SelectedIndexChanged);
			// 
			// label2
			// 
			label2.Location = new Point(20, 40);
			label2.Name = "label2";
			label2.Size = new Size(144, 23);
			label2.TabIndex = 2;
			label2.Text = "&Labels Style:";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxFunnelStyle
			// 
			comboBoxFunnelStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxFunnelStyle.Items.AddRange([
																	 "YIsHeight",
																	 "YIsWidth"]);
			comboBoxFunnelStyle.Location = new Point(168, 8);
			comboBoxFunnelStyle.Name = "comboBoxFunnelStyle";
			comboBoxFunnelStyle.Size = new Size(144, 22);
			comboBoxFunnelStyle.TabIndex = 1;
			comboBoxFunnelStyle.SelectedIndexChanged += new EventHandler(comboBoxFunnelStyle_SelectedIndexChanged);
			// 
			// label1
			// 
			label1.Location = new Point(4, 8);
			label1.Name = "label1";
			label1.Size = new Size(160, 23);
			label1.TabIndex = 0;
			label1.Text = "Funnel &Style:";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FunnelChartType
			// 
			BackColor = System.Drawing.Color.White;
			Controls.AddRange([
																		  panel1,
																		  labelSampleComment,
																		  chart1]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "FunnelChartType";
			Size = new Size(744, 360);
			Load += new EventHandler(PieChartType_Load);
			((ISupportInitialize)(chart1)).EndInit();
			panel1.ResumeLayout(false);
			((ISupportInitialize)(numericUpDownAngle)).EndInit();
			((ISupportInitialize)(numericUpDownMinHeight)).EndInit();
			((ISupportInitialize)(numericUpDownGap)).EndInit();
			ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Bind chart data
			double[]	yValues1 = [216.1, 125.8, 2.6, 97.3, 45.7, 25.3];
			double[]	yValues2 = [232.8, 195.4, 172.9, 100.3, 45.7, 25.3];
			chart1.Series["Default"].Points.DataBindY( (comboBoxFunnelStyle.SelectedIndex == 0) ? yValues1 : yValues2);

			// Set funnel style
			chart1.Series["Default"]["FunnelStyle"] = (string)comboBoxFunnelStyle.SelectedItem;

			// Set funnel data point labels style
			chart1.Series["Default"]["FunnelLabelStyle"] = (string)comboBoxLabelsStyle.SelectedItem;

			// Set labels placement
			if(comboBoxLabelsStyle.SelectedIndex == 0 ||
				comboBoxLabelsStyle.SelectedIndex == 1)
			{
				chart1.Series["Default"]["FunnelOutsideLabelPlacement"] = (string)comboBoxLabelsPlacement.SelectedItem;
			}
			else
			{
				chart1.Series["Default"]["FunnelInsideLabelAlignment"] = (string)comboBoxLabelsPlacement.SelectedItem;
			}

			// Set gap between points
			chart1.Series["Default"]["FunnelPointGap"] = numericUpDownGap.Value.ToString();

			// Set minimum point height
			chart1.Series["Default"]["FunnelMinPointHeight"] = numericUpDownMinHeight.Value.ToString();
			
			// Set 3D mode
			chart1.ChartAreas["Default"].Area3DStyle.Enable3D = checkBoxShow3D.Checked;

			// Set 3D angle
			chart1.Series["Default"]["Funnel3DRotationAngle"] = numericUpDownAngle.Value.ToString();

			// Set 3D drawing style
			chart1.Series["Default"]["Funnel3DDrawingStyle"] = (string)comboBox3DDrawingStyle.SelectedItem;

			// Disable/Enable controls
			numericUpDownAngle.Enabled = checkBoxShow3D.Checked;
			labelAngle.Enabled = checkBoxShow3D.Checked;
			comboBox3DDrawingStyle.Enabled = checkBoxShow3D.Checked;
			label3DDrawingStyle.Enabled = checkBoxShow3D.Checked;
			comboBoxLabelsPlacement.Enabled = comboBoxLabelsStyle.SelectedIndex != 3;
			labelOutsideLabelsPlacement.Enabled = comboBoxLabelsStyle.SelectedIndex != 3;

			chart1.Invalidate();
		}

		private void PieChartType_Load(object sender, EventArgs e)
		{
			// Set selection
			comboBoxFunnelStyle.SelectedIndex = 0;
			comboBoxLabelsStyle.SelectedIndex = 0;
			comboBoxLabelsPlacement.SelectedIndex = 0;
			comboBox3DDrawingStyle.SelectedIndex = 0;

			UpdateChartSettings();	
		}

		private void comboBoxFunnelStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void comboBoxLabelsStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBoxLabelsPlacement.Items.Clear();
			if(comboBoxLabelsStyle.SelectedIndex == 0 ||
				comboBoxLabelsStyle.SelectedIndex == 1)
			{
				comboBoxLabelsPlacement.Items.Add("Right");
				comboBoxLabelsPlacement.Items.Add("Left");
			}
			else
			{
				comboBoxLabelsPlacement.Items.Add("Center");
				comboBoxLabelsPlacement.Items.Add("Top");
				comboBoxLabelsPlacement.Items.Add("Bottom");
			}
			comboBoxLabelsPlacement.SelectedIndex = 0;
			UpdateChartSettings();	
		}

		private void comboBoxLabelsPlacement_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void numericUpDownGap_ValueChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void numericUpDownMinHeight_ValueChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void numericUpDownAngle_ValueChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void comboBox3DDrawingStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();	
		}
	}
}
