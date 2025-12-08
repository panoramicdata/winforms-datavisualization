# region Used Namespaces
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
#endregion

namespace ChartSamples
{
	/// <summary>
	/// Summary description for AligningChartingAreas.
	/// </summary>
	public class AligningChartingAreas : UserControl
	{
        # region Fields
        private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label12;
		private Label label15;
		private ComboBox AlignmentCombo;
		private CheckBox checkBoxShowChartArea1;
		private CheckBox checkBoxShowChartArea2;
		private Label label1;
        
        /// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;
        #endregion

        # region Constructor

        public AligningChartingAreas()
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

        #endregion

        #region Component Designer generated code
        /// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ChartArea chartArea3 = new ChartArea();
			ChartArea chartArea4 = new ChartArea();
			Legend legend2 = new Legend();
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 3);
			DataPoint dataPoint12 = new DataPoint(0, 7);
			DataPoint dataPoint13 = new DataPoint(0, 8);
			DataPoint dataPoint14 = new DataPoint(0, 6);
			DataPoint dataPoint15 = new DataPoint(0, 7);
			Series series4 = new Series();
			DataPoint dataPoint16 = new DataPoint(0, 4);
			DataPoint dataPoint17 = new DataPoint(0, 7);
			DataPoint dataPoint18 = new DataPoint(0, 5);
			DataPoint dataPoint19 = new DataPoint(0, 8);
			DataPoint dataPoint20 = new DataPoint(0, 6);
            label9 = new Label();
            panel1 = new Panel();
            checkBoxShowChartArea2 = new CheckBox();
            checkBoxShowChartArea1 = new CheckBox();
            AlignmentCombo = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label12 = new Label();
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
            label9.Location = new Point(16, 0);
            label9.Name = "label9";
            label9.Size = new Size(702, 43);
            label9.TabIndex = 0;
            label9.Text = "This sample shows how to align multiple chart areas when more than one chart area" +
                " is visible.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxShowChartArea2);
            panel1.Controls.Add(checkBoxShowChartArea1);
            panel1.Controls.Add(AlignmentCombo);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(432, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // checkBoxShowChartArea2
            // 
            checkBoxShowChartArea2.Checked = true;
            checkBoxShowChartArea2.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxShowChartArea2.Location = new Point(6, 47);
            checkBoxShowChartArea2.Name = "checkBoxShowChartArea2";
            checkBoxShowChartArea2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            checkBoxShowChartArea2.Size = new Size(160, 24);
            checkBoxShowChartArea2.TabIndex = 9;
            checkBoxShowChartArea2.Text = "Show Chart Area 2";
            checkBoxShowChartArea2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);
            // 
            // checkBoxShowChartArea1
            // 
            checkBoxShowChartArea1.Checked = true;
            checkBoxShowChartArea1.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxShowChartArea1.Location = new Point(6, 15);
            checkBoxShowChartArea1.Name = "checkBoxShowChartArea1";
            checkBoxShowChartArea1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            checkBoxShowChartArea1.Size = new Size(160, 24);
            checkBoxShowChartArea1.TabIndex = 8;
            checkBoxShowChartArea1.Text = "Show Chart Area 1";
            checkBoxShowChartArea1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            // 
            // AlignmentCombo
            // 
            AlignmentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            AlignmentCombo.Items.AddRange([
            "Horizontally",
            "Vertically"]);
            AlignmentCombo.Location = new Point(150, 80);
            AlignmentCombo.Name = "AlignmentCombo";
            AlignmentCombo.Size = new Size(136, 22);
            AlignmentCombo.TabIndex = 1;
            AlignmentCombo.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // label8
            // 
            label8.Location = new Point(64, 472);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 7;
            label8.Text = "Shadow Offset:";
            // 
            // label7
            // 
            label7.Location = new Point(64, 449);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 6;
            label7.Text = "Border Style:";
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
            // label12
            // 
            label12.Location = new Point(95, 80);
            label12.Name = "label12";
            label12.Size = new Size(51, 23);
            label12.TabIndex = 0;
            label12.Text = "&Align:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            Chart1.BackSecondaryColor = System.Drawing.Color.White;
            Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            Chart1.BorderlineWidth = 2;
            Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea3.Area3DStyle.IsClustered = true;
            chartArea3.Area3DStyle.Perspective = 10;
            chartArea3.Area3DStyle.IsRightAngleAxes = false;
            chartArea3.Area3DStyle.WallWidth = 0;
            chartArea3.Area3DStyle.Inclination = 15;
            chartArea3.Area3DStyle.Rotation = 10;
            chartArea3.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea3.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisX.LabelStyle.Format = "dd MMM";
            chartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisY.LabelAutoFitStyle = ((LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea3.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisY.LineWidth = 2;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea3.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.Name = "Default";
            chartArea3.ShadowColor = System.Drawing.Color.Transparent;
            chartArea4.AlignWithChartArea = "Default";
            chartArea4.Area3DStyle.IsClustered = true;
            chartArea4.Area3DStyle.Perspective = 10;
            chartArea4.Area3DStyle.IsRightAngleAxes = false;
            chartArea4.Area3DStyle.WallWidth = 0;
            chartArea4.Area3DStyle.Inclination = 15;
            chartArea4.Area3DStyle.Rotation = 10;
            chartArea4.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea4.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea4.AxisX.LabelStyle.Format = "dd MMM";
            chartArea4.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.AxisY.LabelAutoFitStyle = ((LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea4.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea4.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.AxisY.LineWidth = 2;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.AxisY2.LabelAutoFitStyle = ((LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea4.AxisY2.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea4.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.AxisY2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea4.BackSecondaryColor = System.Drawing.Color.White;
            chartArea4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.Name = "Chart Area 2";
            chartArea4.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea3);
            Chart1.ChartAreas.Add(chartArea4);
            legend2.IsTextAutoFit = false;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Enabled = false;
            legend2.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend2.Name = "Default";
            Chart1.Legends.Add(legend2);
            Chart1.Location = new Point(14, 46);
            Chart1.Name = "Chart1";
            Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Name = "Series1";
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series4.BorderWidth = 2;
            series4.ChartArea = "Chart Area 2";
            series4.ChartType = SeriesChartType.Spline;
            series4.Name = "Series2";
            series4.Points.Add(dataPoint16);
            series4.Points.Add(dataPoint17);
            series4.Points.Add(dataPoint18);
            series4.Points.Add(dataPoint19);
            series4.Points.Add(dataPoint20);
            series4.ShadowOffset = 1;
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            Chart1.Series.Add(series3);
            Chart1.Series.Add(series4);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label1.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 353);
            label1.Name = "label1";
            label1.Size = new Size(702, 57);
            label1.TabIndex = 3;
            label1.Text = "In order to horizontally align the chart areas, the position of both chart areas " +
                "must be set. In addition, by setting the AlignmentOrientation property, we are able " +
                "to align the inner plotting areas.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AligningChartingAreas
            // 
            Controls.Add(label1);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AligningChartingAreas";
            Size = new Size(728, 480);
            Load += new EventHandler(Alignment_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

        # region Event Handler

        private void Alignment_Load(object sender, EventArgs e)
        {
            AlignmentCombo.SelectedIndex = 0;

            Alignment();
        }

        private void Combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Alignment();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
        }

        #endregion

        # region Methods

        private void Alignment()
        {
            if (AlignmentCombo.SelectedItem == null)
                return;

            // Vertical Alignment
            if (AlignmentCombo.GetItemText(AlignmentCombo.SelectedItem) == "Vertically")
            {
                // Set the chart area alignmnet.  This will cause the axes to align vertically.
                Chart1.ChartAreas["Chart Area 2"].AlignmentOrientation = AreaAlignmentOrientations.Vertical;

                // Disable X Axis Labels for the first chart area.
                Chart1.ChartAreas["Default"].AxisX.LabelStyle.Enabled = false;
                Chart1.ChartAreas["Default"].AxisX.MajorTickMark.Enabled = false;

                // Enable Y axis for the second chart area
                Chart1.ChartAreas["Chart Area 2"].AxisY.LabelStyle.Enabled = true;
                Chart1.ChartAreas["Chart Area 2"].AxisY.MajorTickMark.Enabled = true;

                // Disable Y axis for the second chart area
                Chart1.ChartAreas["Chart Area 2"].AxisY.Enabled = AxisEnabled.True;

                // Enable Y2 axis for the second chart area
                Chart1.ChartAreas["Chart Area 2"].AxisY2.Enabled = AxisEnabled.False;

                // Disable End labels for Y axes.
                Chart1.ChartAreas["Default"].AxisY.LabelStyle.IsEndLabelVisible = false;
                Chart1.ChartAreas["Chart Area 2"].AxisY.LabelStyle.IsEndLabelVisible = false;

                // Set the chart area position for the first chart area.
                Chart1.ChartAreas["Default"].Position.X = 5;
                Chart1.ChartAreas["Default"].Position.Y = 10;
                Chart1.ChartAreas["Default"].Position.Width = 85;
                Chart1.ChartAreas["Default"].Position.Height = 40;

                // Set the chart area position for the second chart area.
                Chart1.ChartAreas["Chart Area 2"].Position.X = 5;
                Chart1.ChartAreas["Chart Area 2"].Position.Y = 50;
                Chart1.ChartAreas["Chart Area 2"].Position.Width = 85;
                Chart1.ChartAreas["Chart Area 2"].Position.Height = 40;
            }
            // Horizontal Alignment
            else
            {
                // Set the chart area alignmnet.  This will cause the axes to align horizontally.
                Chart1.ChartAreas["Chart Area 2"].AlignmentOrientation = AreaAlignmentOrientations.Horizontal;

                // Disable Y axis for the second chart area
                Chart1.ChartAreas["Chart Area 2"].AxisY.LabelStyle.Enabled = false;
                Chart1.ChartAreas["Chart Area 2"].AxisY.MajorTickMark.Enabled = false;


                // Disable X Axis Labels for the first chart area.
                Chart1.ChartAreas["Default"].AxisX.LabelStyle.Enabled = true;

                // Enable Y2 axis for the second chart area
                Chart1.ChartAreas["Chart Area 2"].AxisY2.Enabled = AxisEnabled.True;

                // Set axis maximum for Y axes 
                Chart1.ChartAreas["Default"].AxisY.Maximum = 10;
                Chart1.ChartAreas["Chart Area 2"].AxisY.Maximum = 10;

                // Disable end labels for X axes
                Chart1.ChartAreas["Default"].AxisX.LabelStyle.IsEndLabelVisible = false;
                Chart1.ChartAreas["Default"].AxisY.LabelStyle.IsEndLabelVisible = true;
                Chart1.ChartAreas["Chart Area 2"].AxisX.LabelStyle.IsEndLabelVisible = false;

                // Set the chart area position for the first chart area.
                Chart1.ChartAreas["Default"].Position.X = 5;
                Chart1.ChartAreas["Default"].Position.Y = 10;
                Chart1.ChartAreas["Default"].Position.Width = 45;
                Chart1.ChartAreas["Default"].Position.Height = 80;

                // Set the chart area position for the second chart area.
                Chart1.ChartAreas["Chart Area 2"].Position.X = 50;
                Chart1.ChartAreas["Chart Area 2"].Position.Y = 10;
                Chart1.ChartAreas["Chart Area 2"].Position.Width = 45;
                Chart1.ChartAreas["Chart Area 2"].Position.Height = 80;
            }
        }

        private void UpdateChartSettings() 
		{
			// If both chart areas are specified, align the chart areas
			if ((checkBoxShowChartArea2.Checked) && (checkBoxShowChartArea1.Checked))
			{
				AlignmentCombo.Enabled = true;
				Chart1.ChartAreas["Default"].Visible = true;
				Chart1.ChartAreas["Chart Area 2"].Visible = true;
				Alignment();
			}

			// If Chart Area 1 checked, Chart Area 2 unchecked
			else if ((!checkBoxShowChartArea2.Checked) &&(checkBoxShowChartArea1.Checked))
			{
				AlignmentCombo.Enabled = false;

				Chart1.ChartAreas["Chart Area 2"].Visible = false;
				
				Chart1.ChartAreas["Default"].Visible = true;
				Chart1.ChartAreas["Default"].Position.Auto = true;
				Chart1.ChartAreas["Default"].InnerPlotPosition.Auto = true;

				// Enable X Axis Labels for the first chart area.
				Chart1.ChartAreas["Default"].AxisX.LabelStyle.Enabled = true;
				Chart1.ChartAreas["Default"].AxisX.MajorTickMark.Enabled = true;
			}

			// If Chart Area 1 unchecked, Chart Area 2 checked
			else if ((checkBoxShowChartArea2.Checked) &&(!checkBoxShowChartArea1.Checked))
			{
				AlignmentCombo.Enabled = false;

				Chart1.ChartAreas["Default"].Visible = false;

				Chart1.ChartAreas["Chart Area 2"].Visible = true;
				Chart1.ChartAreas["Chart Area 2"].Position.Auto = true;
				Chart1.ChartAreas["Chart Area 2"].InnerPlotPosition.Auto = true;
			}

			// If both chart areas unchecked
			else if ((!checkBoxShowChartArea2.Checked) &&(!checkBoxShowChartArea1.Checked))
			{
				AlignmentCombo.Enabled = false;

				Chart1.ChartAreas["Default"].Visible = false;
				Chart1.ChartAreas["Chart Area 2"].Visible = false;
			}
        }

        #endregion
    }
}
