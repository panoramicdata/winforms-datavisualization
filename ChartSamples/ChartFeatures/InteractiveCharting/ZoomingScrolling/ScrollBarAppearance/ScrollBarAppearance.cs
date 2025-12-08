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
	/// Summary description for ScrollBarAppearance.
	/// </summary>
	public class ScrollBarAppearance : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxSize;
		private ComboBox comboBoxBackColor;
		private Label label2;
		private ComboBox comboBoxButtonsColor;
		private Label label3;
		private ComboBox comboBoxLineColor;
		private Label label4;
		private CheckBox checkBoxResetButton;
		private CheckBox checkBoxSmallScrollButton;
		private CheckBox checkBoxInside;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public ScrollBarAppearance()
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
			Title title1 = new Title();
			chart1 = new Chart();
			labelSampleComment = new Label();
			panel1 = new Panel();
			checkBoxInside = new CheckBox();
			comboBoxLineColor = new ComboBox();
			label4 = new Label();
			comboBoxButtonsColor = new ComboBox();
			label3 = new Label();
			comboBoxBackColor = new ComboBox();
			label2 = new Label();
			checkBoxSmallScrollButton = new CheckBox();
			checkBoxResetButton = new CheckBox();
			comboBoxSize = new ComboBox();
			label1 = new Label();
			((ISupportInitialize)(chart1)).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// chart1
			// 
			chart1.BackColor = System.Drawing.Color.WhiteSmoke;
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
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.IsMarginVisible = false;
			chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
			chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BackColor = System.Drawing.Color.Gainsboro;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea1.CursorX.SelectionColor = System.Drawing.Color.LightBlue;
			chartArea1.CursorX.IsUserEnabled = true;
			chartArea1.CursorX.IsUserSelectionEnabled = true;
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			chart1.ChartAreas.Add(chartArea1);
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Enabled = false;
			legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			chart1.Legends.Add(legend1);
			chart1.Location = new Point(16, 48);
			chart1.Name = "chart1";
			chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartType = SeriesChartType.Area;
			series1.Name = "Default";
			chart1.Series.Add(series1);
			chart1.Size = new Size(412, 296);
			chart1.TabIndex = 1;
			title1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
			title1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(32)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			title1.ShadowOffset = 3;
			title1.Text = "ScrollBar Appearance";
			chart1.Titles.Add(title1);
			chart1.Click += new EventHandler(chart1_Click);
			// 
			// labelSampleComment
			// 
			labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			labelSampleComment.Location = new Point(16, 8);
			labelSampleComment.Name = "labelSampleComment";
			labelSampleComment.Size = new Size(702, 34);
			labelSampleComment.TabIndex = 0;
			labelSampleComment.Text = "This sample demonstrates how to set the appearance of a scrollbar.";
			labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.AddRange([
																				 checkBoxInside,
																				 comboBoxLineColor,
																				 label4,
																				 comboBoxButtonsColor,
																				 label3,
																				 comboBoxBackColor,
																				 label2,
																				 checkBoxSmallScrollButton,
																				 checkBoxResetButton,
																				 comboBoxSize,
																				 label1]);
			panel1.Location = new Point(432, 56);
			panel1.Name = "panel1";
			panel1.Size = new Size(292, 288);
			panel1.TabIndex = 0;
			// 
			// checkBoxInside
			// 
			checkBoxInside.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			checkBoxInside.Checked = true;
			checkBoxInside.CheckState = System.Windows.Forms.CheckState.Checked;
			checkBoxInside.Location = new Point(-10, 104);
			checkBoxInside.Name = "checkBoxInside";
			checkBoxInside.Size = new Size(192, 24);
			checkBoxInside.TabIndex = 4;
			checkBoxInside.Text = "Scrollbars &Inside:";
			checkBoxInside.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			checkBoxInside.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
			// 
			// comboBoxLineColor
			// 
			comboBoxLineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxLineColor.Items.AddRange([
																   "Default"]);
			comboBoxLineColor.Location = new Point(168, 200);
			comboBoxLineColor.Name = "comboBoxLineColor";
			comboBoxLineColor.TabIndex = 10;
			comboBoxLineColor.SelectedIndexChanged += new EventHandler(comboBoxBackColor_SelectedIndexChanged);
			// 
			// label4
			// 
			label4.Location = new Point(52, 200);
			label4.Name = "label4";
			label4.Size = new Size(112, 23);
			label4.TabIndex = 9;
			label4.Text = "&Line Color:";
			label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxButtonsColor
			// 
			comboBoxButtonsColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxButtonsColor.Items.AddRange([
																	  "Default"]);
			comboBoxButtonsColor.Location = new Point(168, 168);
			comboBoxButtonsColor.Name = "comboBoxButtonsColor";
			comboBoxButtonsColor.TabIndex = 8;
			comboBoxButtonsColor.SelectedIndexChanged += new EventHandler(comboBoxBackColor_SelectedIndexChanged);
			// 
			// label3
			// 
			label3.Location = new Point(52, 168);
			label3.Name = "label3";
			label3.Size = new Size(112, 23);
			label3.TabIndex = 7;
			label3.Text = "Buttons &Color:";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxBackColor
			// 
			comboBoxBackColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxBackColor.Items.AddRange([
																   "Default"]);
			comboBoxBackColor.Location = new Point(168, 136);
			comboBoxBackColor.Name = "comboBoxBackColor";
			comboBoxBackColor.TabIndex = 6;
			comboBoxBackColor.SelectedIndexChanged += new EventHandler(comboBoxBackColor_SelectedIndexChanged);
			// 
			// label2
			// 
			label2.Location = new Point(60, 136);
			label2.Name = "label2";
			label2.Size = new Size(104, 23);
			label2.TabIndex = 5;
			label2.Text = "&Back Color:";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// checkBoxSmallScrollButton
			// 
			checkBoxSmallScrollButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			checkBoxSmallScrollButton.Checked = true;
			checkBoxSmallScrollButton.CheckState = System.Windows.Forms.CheckState.Checked;
			checkBoxSmallScrollButton.Location = new Point(-10, 72);
			checkBoxSmallScrollButton.Name = "checkBoxSmallScrollButton";
			checkBoxSmallScrollButton.Size = new Size(192, 24);
			checkBoxSmallScrollButton.TabIndex = 3;
			checkBoxSmallScrollButton.Text = "Show S&mallScroll Button:";
			checkBoxSmallScrollButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			checkBoxSmallScrollButton.CheckedChanged += new EventHandler(checkBoxResetButton_CheckedChanged);
			// 
			// checkBoxResetButton
			// 
			checkBoxResetButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			checkBoxResetButton.Checked = true;
			checkBoxResetButton.CheckState = System.Windows.Forms.CheckState.Checked;
			checkBoxResetButton.Location = new Point(-10, 40);
			checkBoxResetButton.Name = "checkBoxResetButton";
			checkBoxResetButton.Size = new Size(192, 24);
			checkBoxResetButton.TabIndex = 2;
			checkBoxResetButton.Text = "Show &Reset Button:";
			checkBoxResetButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			checkBoxResetButton.CheckedChanged += new EventHandler(checkBoxResetButton_CheckedChanged);
			// 
			// comboBoxSize
			// 
			comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxSize.Items.AddRange([
															  "5",
															  "10",
															  "15",
															  "20"]);
			comboBoxSize.Location = new Point(168, 8);
			comboBoxSize.Name = "comboBoxSize";
			comboBoxSize.TabIndex = 1;
			comboBoxSize.SelectedIndexChanged += new EventHandler(comboBoxSize_SelectedIndexChanged);
			// 
			// label1
			// 
			label1.Location = new Point(85, 8);
			label1.Name = "label1";
			label1.Size = new Size(80, 23);
			label1.TabIndex = 0;
			label1.Text = "&Size:";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ScrollBarAppearance
			// 
			BackColor = System.Drawing.Color.White;
			Controls.AddRange([
																		  panel1,
																		  labelSampleComment,
																		  chart1]);
			Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			Name = "ScrollBarAppearance";
			Size = new Size(728, 360);
			Load += new EventHandler(ZoomingExtents_Load);
			((ISupportInitialize)(chart1)).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);

		}
		#endregion

		private void ZoomingExtents_Load(object sender, EventArgs e)
		{
			// Fill combo boxes with known colors
			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				comboBoxBackColor.Items.Add(colorName);
				comboBoxButtonsColor.Items.Add(colorName);
				comboBoxLineColor.Items.Add(colorName);
			}
			comboBoxSize.SelectedIndex = 1;
			comboBoxBackColor.SelectedIndex = 0;
			comboBoxButtonsColor.SelectedIndex = 0;
			comboBoxLineColor.SelectedIndex = 0;


			// Set original view
			chart1.ChartAreas["Default"].AxisX.ScaleView.Position = 10;
			chart1.ChartAreas["Default"].AxisX.ScaleView.Size = 20;

			// Fill chart with random data
			Random		random = new Random();
			for(int pointIndex = 0; pointIndex < 49; pointIndex++)
			{
				chart1.Series["Default"].Points.AddY(random.Next(0, 100));
			}
		}

		private void comboBoxBackColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxResetButton_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void UpdateChartSettings()
		{
			// Set scrollbar size
			if(comboBoxSize.Text != String.Empty)
			{
				chart1.ChartAreas["Default"].AxisX.ScrollBar.Size = int.Parse(comboBoxSize.Text);
			}

			// Do not show buttons with size 5
			checkBoxResetButton.Enabled = true;
			checkBoxSmallScrollButton.Enabled = true;
			if(chart1.ChartAreas["Default"].AxisX.ScrollBar.Size == 5)
			{
				checkBoxResetButton.Checked = false;
				checkBoxSmallScrollButton.Checked = false;
				checkBoxResetButton.Enabled = false;
				checkBoxSmallScrollButton.Enabled = false;
			}

			// Position of Scrollbars
			chart1.ChartAreas["Default"].AxisX.ScrollBar.IsPositionedInside = checkBoxInside.Checked;

			// Set scrollbar buttons
			chart1.ChartAreas["Default"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.None;
			if(checkBoxResetButton.Checked && checkBoxSmallScrollButton.Checked)
			{
                chart1.ChartAreas["Default"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
			}
			else if(checkBoxResetButton.Checked)
			{
                chart1.ChartAreas["Default"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.ResetZoom;
			}
			else if(checkBoxSmallScrollButton.Checked)
			{
                chart1.ChartAreas["Default"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
			}

			// Set scrollbar colors
			chart1.ChartAreas["Default"].AxisX.ScrollBar.BackColor = Color.White;
			chart1.ChartAreas["Default"].AxisX.ScrollBar.ButtonColor = Color.FromArgb(224, 224, 224);
			chart1.ChartAreas["Default"].AxisX.ScrollBar.LineColor = Color.Black;
			if(comboBoxBackColor.Text != String.Empty && comboBoxBackColor.Text != "Default")
			{
				chart1.ChartAreas["Default"].AxisX.ScrollBar.BackColor = Color.FromName(comboBoxBackColor.Text);
			}
			if(comboBoxLineColor.Text != String.Empty && comboBoxLineColor.Text != "Default")
			{
				chart1.ChartAreas["Default"].AxisX.ScrollBar.LineColor = Color.FromName(comboBoxLineColor.Text);
			}
			if(comboBoxButtonsColor.Text != String.Empty && comboBoxButtonsColor.Text != "Default")
			{
				chart1.ChartAreas["Default"].AxisX.ScrollBar.ButtonColor = Color.FromName(comboBoxButtonsColor.Text);
			}
		}

		private void chart1_Click(object sender, EventArgs e)
		{
		
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

	}
}
