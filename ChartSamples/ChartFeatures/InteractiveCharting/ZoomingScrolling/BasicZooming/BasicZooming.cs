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
	/// Summary description for BasicZooming.
	/// </summary>
	public class BasicZooming : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private Label label2;
		private Button buttonResetZoom;
		private CheckBox checkBoxZoomUI;
		private ComboBox comboBoxFrom;
		private ComboBox comboBoxTo;
		private CheckBox checkBoxShowMargin;
		private ComboBox comboBoxAxis;
		private Label label3;
		private CheckBox checkBoxInside;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public BasicZooming()
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
            buttonResetZoom = new Button();
            labelSampleComment = new Label();
            panel1 = new Panel();
            checkBoxInside = new CheckBox();
            comboBoxAxis = new ComboBox();
            label3 = new Label();
            checkBoxShowMargin = new CheckBox();
            comboBoxTo = new ComboBox();
            comboBoxFrom = new ComboBox();
            checkBoxZoomUI = new CheckBox();
            label2 = new Label();
            label1 = new Label();
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
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 51);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Default";
            chart1.Series.Add(series1);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            chart1.Click += new EventHandler(chart1_Click);
            // 
            // buttonResetZoom
            // 
            buttonResetZoom.BackColor = System.Drawing.SystemColors.Control;
            buttonResetZoom.Location = new Point(128, 208);
            buttonResetZoom.Name = "buttonResetZoom";
            buttonResetZoom.Size = new Size(112, 23);
            buttonResetZoom.TabIndex = 8;
            buttonResetZoom.Text = "&Reset Zoom";
            buttonResetZoom.UseVisualStyleBackColor = false;
            buttonResetZoom.Click += new EventHandler(buttonResetZoom_Click);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 37);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to zoom along the X and Y axis.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxInside);
            panel1.Controls.Add(comboBoxAxis);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(checkBoxShowMargin);
            panel1.Controls.Add(comboBoxTo);
            panel1.Controls.Add(comboBoxFrom);
            panel1.Controls.Add(checkBoxZoomUI);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonResetZoom);
            panel1.Location = new Point(432, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // checkBoxInside
            // 
            checkBoxInside.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxInside.Checked = true;
            checkBoxInside.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxInside.Location = new Point(14, 104);
            checkBoxInside.Name = "checkBoxInside";
            checkBoxInside.RightToLeft = System.Windows.Forms.RightToLeft.No;
            checkBoxInside.Size = new Size(168, 16);
            checkBoxInside.TabIndex = 9;
            checkBoxInside.Text = "Scrollbars &Inside:";
            checkBoxInside.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxInside.CheckedChanged += new EventHandler(checkBoxInside_CheckedChanged);
            // 
            // comboBoxAxis
            // 
            comboBoxAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxAxis.Items.AddRange([
            "X",
            "Y",
            "X and Y"]);
            comboBoxAxis.Location = new Point(168, 8);
            comboBoxAxis.Name = "comboBoxAxis";
            comboBoxAxis.Size = new Size(112, 22);
            comboBoxAxis.TabIndex = 1;
            comboBoxAxis.SelectedIndexChanged += new EventHandler(comboBoxAxis_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(28, 8);
            label3.Name = "label3";
            label3.Size = new Size(136, 24);
            label3.TabIndex = 0;
            label3.Text = "&Axis Used:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxShowMargin
            // 
            checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.Checked = true;
            checkBoxShowMargin.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxShowMargin.Location = new Point(14, 136);
            checkBoxShowMargin.Name = "checkBoxShowMargin";
            checkBoxShowMargin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            checkBoxShowMargin.Size = new Size(168, 16);
            checkBoxShowMargin.TabIndex = 6;
            checkBoxShowMargin.Text = "Show Axis &Margin:";
            checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowMargin.CheckedChanged += new EventHandler(checkBoxShowMargin_CheckedChanged);
            // 
            // comboBoxTo
            // 
            comboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxTo.Items.AddRange([
            "35",
            "40",
            "50"]);
            comboBoxTo.Location = new Point(168, 72);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(112, 22);
            comboBoxTo.TabIndex = 5;
            comboBoxTo.SelectedIndexChanged += new EventHandler(comboBoxFrom_SelectedIndexChanged);
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxFrom.Items.AddRange([
            "10",
            "20",
            "30"]);
            comboBoxFrom.Location = new Point(168, 40);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(112, 22);
            comboBoxFrom.TabIndex = 3;
            comboBoxFrom.SelectedIndexChanged += new EventHandler(comboBoxFrom_SelectedIndexChanged);
            // 
            // checkBoxZoomUI
            // 
            checkBoxZoomUI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxZoomUI.Checked = true;
            checkBoxZoomUI.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxZoomUI.Location = new Point(14, 168);
            checkBoxZoomUI.Name = "checkBoxZoomUI";
            checkBoxZoomUI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            checkBoxZoomUI.Size = new Size(168, 16);
            checkBoxZoomUI.TabIndex = 7;
            checkBoxZoomUI.Text = "&Enable Zooming UI:";
            checkBoxZoomUI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxZoomUI.CheckedChanged += new EventHandler(checkBoxZoomUI_CheckedChanged);
            // 
            // label2
            // 
            label2.Location = new Point(76, 72);
            label2.Name = "label2";
            label2.Size = new Size(88, 24);
            label2.TabIndex = 4;
            label2.Text = "Zoom &To:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(52, 40);
            label1.Name = "label1";
            label1.Size = new Size(112, 24);
            label1.TabIndex = 2;
            label1.Text = "Zoom &From:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BasicZooming
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "BasicZooming";
            Size = new Size(728, 384);
            Load += new EventHandler(BasicZooming_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void BasicZooming_Load(object sender, EventArgs e)
		{
			comboBoxAxis.SelectedIndex = 0;

			// Enable range selection and zooming UI by default
			chart1.ChartAreas["Default"].CursorX.IsUserEnabled = true;
			chart1.ChartAreas["Default"].CursorX.IsUserSelectionEnabled = true;
			chart1.ChartAreas["Default"].AxisX.ScaleView.Zoomable = true;

			// Fill chart with random data
			Random	random = new Random();
			for(int pointIndex = 0; pointIndex < 49; pointIndex++)
			{
				chart1.Series["Default"].Points.AddY(random.Next(0, 100));
			}
		}

		private void checkBoxZoomUI_CheckedChanged(object sender, EventArgs e)
		{
			// Reset to default
			chart1.ChartAreas["Default"].CursorX.IsUserEnabled = false;
			chart1.ChartAreas["Default"].CursorX.IsUserSelectionEnabled = false;
			chart1.ChartAreas["Default"].AxisX.ScaleView.Zoomable = false;
			chart1.ChartAreas["Default"].CursorY.IsUserEnabled = false;
			chart1.ChartAreas["Default"].CursorY.IsUserSelectionEnabled = false;
			chart1.ChartAreas["Default"].AxisY.ScaleView.Zoomable = false;
		
			// Enable range selection and zooming UI
			if(comboBoxAxis.Text == "X" || comboBoxAxis.Text == "X and Y")
			{
				chart1.ChartAreas["Default"].CursorX.IsUserEnabled = checkBoxZoomUI.Checked;
				chart1.ChartAreas["Default"].CursorX.IsUserSelectionEnabled = checkBoxZoomUI.Checked;
				chart1.ChartAreas["Default"].AxisX.ScaleView.Zoomable = checkBoxZoomUI.Checked;
			}

			if(comboBoxAxis.Text == "Y" || comboBoxAxis.Text == "X and Y")
			{
				chart1.ChartAreas["Default"].CursorY.IsUserEnabled = checkBoxZoomUI.Checked;
				chart1.ChartAreas["Default"].CursorY.IsUserSelectionEnabled = checkBoxZoomUI.Checked;
				chart1.ChartAreas["Default"].AxisY.ScaleView.Zoomable = checkBoxZoomUI.Checked;
			}
		}

		private void buttonResetZoom_Click(object sender, EventArgs e)
		{
			if(comboBoxAxis.Text == "X" || comboBoxAxis.Text == "X and Y")
			{
				// Rese X axis zooming
				chart1.ChartAreas["Default"].AxisX.ScaleView.ZoomReset(0);
			}
			if(comboBoxAxis.Text == "Y" || comboBoxAxis.Text == "X and Y")
			{
				// Rese Y axis zooming
				chart1.ChartAreas["Default"].AxisY.ScaleView.ZoomReset(0);
			}
		}

		private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(comboBoxFrom.Text != String.Empty)
			{
				if(comboBoxTo.Text == String.Empty)
				{
					comboBoxTo.SelectedIndex = 0;
				}

				// Zoom into the axis
				if(comboBoxAxis.Text == "X" || comboBoxAxis.Text == "X and Y")
				{
					chart1.ChartAreas["Default"].AxisX.ScaleView.Zoom(double.Parse(comboBoxFrom.Text), double.Parse(comboBoxTo.Text));
				}
				if(comboBoxAxis.Text == "Y" || comboBoxAxis.Text == "X and Y")
				{
					chart1.ChartAreas["Default"].AxisY.ScaleView.Zoom(double.Parse(comboBoxFrom.Text), double.Parse(comboBoxTo.Text));
				}
			}
		}

		private void checkBoxShowMargin_CheckedChanged(object sender, EventArgs e)
		{
			chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;
			chart1.ChartAreas["Default"].AxisY.IsMarginVisible = checkBoxShowMargin.Checked;
		}

		private void comboBoxAxis_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBoxFrom_SelectedIndexChanged(chart1, null);
			checkBoxShowMargin_CheckedChanged(chart1, null);
			checkBoxZoomUI_CheckedChanged(chart1, null);
			checkBoxInside_CheckedChanged(chart1, null);
		}

		private void checkBoxInside_CheckedChanged(object sender, EventArgs e)
		{
			chart1.ChartAreas["Default"].AxisX.ScrollBar.IsPositionedInside = checkBoxInside.Checked;
			chart1.ChartAreas["Default"].AxisY.ScrollBar.IsPositionedInside = checkBoxInside.Checked;
		}

		private void chart1_Click(object sender, EventArgs e)
		{
		
		}

	}
}
