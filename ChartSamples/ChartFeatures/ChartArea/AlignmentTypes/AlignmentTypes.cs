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
	/// Summary description for AxisTitle.
	/// </summary>
	public class AlignmentTypes : UserControl
	{
		private Label label9;
        private Panel panel1;
        private CheckBox checkAlign;
        private GroupBox groupBox1;
        private RadioButton positionButton;
        private GroupBox groupBox2;
        private RadioButton noneButton;
        private RadioButton plotButton;
        private CheckBox AxisViewsBox;
        private CheckBox CursorBox;
        private GroupBox groupBox3;
        private Label AlignStyleLabel;
        private Chart Chart1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public AlignmentTypes()
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
			ChartArea chartArea2 = new ChartArea();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(0, "12000,84000");
			DataPoint dataPoint2 = new DataPoint(0, "27000,86000");
			DataPoint dataPoint3 = new DataPoint(0, "8000,76000");
			DataPoint dataPoint4 = new DataPoint(0, "15000,97000");
			DataPoint dataPoint5 = new DataPoint(0, "24000,76000");
			DataPoint dataPoint6 = new DataPoint(0, "15000,73000");
			DataPoint dataPoint7 = new DataPoint(0, "34000,87000");
			DataPoint dataPoint8 = new DataPoint(0, "21000,67000");
			DataPoint dataPoint9 = new DataPoint(0, "12000,90000");
			DataPoint dataPoint10 = new DataPoint(0, "10000,96000");
			DataPoint dataPoint11 = new DataPoint(0, "34000,78000");
			Series series2 = new Series();
			DataPoint dataPoint12 = new DataPoint(0, 55000);
			DataPoint dataPoint13 = new DataPoint(0, 60000);
			DataPoint dataPoint14 = new DataPoint(0, 53000);
			DataPoint dataPoint15 = new DataPoint(0, 27000);
			DataPoint dataPoint16 = new DataPoint(0, 29000);
			DataPoint dataPoint17 = new DataPoint(0, 25000);
			DataPoint dataPoint18 = new DataPoint(0, 38000);
			DataPoint dataPoint19 = new DataPoint(0, 43000);
			DataPoint dataPoint20 = new DataPoint(0, 68000);
			DataPoint dataPoint21 = new DataPoint(0, 55000);
			DataPoint dataPoint22 = new DataPoint(0, 45000);
			Series series3 = new Series();
			DataPoint dataPoint23 = new DataPoint(0, "20,78");
			DataPoint dataPoint24 = new DataPoint(0, "33,73");
			DataPoint dataPoint25 = new DataPoint(0, "35,63");
			DataPoint dataPoint26 = new DataPoint(0, "25,90");
			DataPoint dataPoint27 = new DataPoint(0, "44,70");
			DataPoint dataPoint28 = new DataPoint(0, "30,70");
			DataPoint dataPoint29 = new DataPoint(0, "33,80");
			DataPoint dataPoint30 = new DataPoint(0, "23,72");
			DataPoint dataPoint31 = new DataPoint(0, "9,65");
			DataPoint dataPoint32 = new DataPoint(0, "23,85");
			DataPoint dataPoint33 = new DataPoint(0, "13,84");
			Series series4 = new Series();
			DataPoint dataPoint34 = new DataPoint(0, 47);
			DataPoint dataPoint35 = new DataPoint(0, 44);
			DataPoint dataPoint36 = new DataPoint(0, 37);
			DataPoint dataPoint37 = new DataPoint(0, 47);
			DataPoint dataPoint38 = new DataPoint(0, 53);
			DataPoint dataPoint39 = new DataPoint(0, 42);
			DataPoint dataPoint40 = new DataPoint(0, 50);
			DataPoint dataPoint41 = new DataPoint(0, 60);
			DataPoint dataPoint42 = new DataPoint(0, 43);
			DataPoint dataPoint43 = new DataPoint(0, 39);
			DataPoint dataPoint44 = new DataPoint(0, 72);
            label9 = new Label();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            AlignStyleLabel = new Label();
            groupBox2 = new GroupBox();
            AxisViewsBox = new CheckBox();
            CursorBox = new CheckBox();
            groupBox1 = new GroupBox();
            noneButton = new RadioButton();
            plotButton = new RadioButton();
            positionButton = new RadioButton();
            checkAlign = new CheckBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to align two chart areas using various alignment typ" +
                "es.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(checkAlign);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(AlignStyleLabel);
            groupBox3.Location = new Point(20, 212);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(232, 76);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Align Type";
            // 
            // AlignStyleLabel
            // 
            AlignStyleLabel.AutoSize = true;
            AlignStyleLabel.Location = new Point(7, 22);
            AlignStyleLabel.Name = "AlignStyleLabel";
            AlignStyleLabel.Size = new Size(79, 14);
            AlignStyleLabel.TabIndex = 0;
            AlignStyleLabel.Text = "Not aligned";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AxisViewsBox);
            groupBox2.Controls.Add(CursorBox);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(20, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(235, 72);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Align using mouse interaction";
            // 
            // AxisViewsBox
            // 
            AxisViewsBox.Checked = true;
            AxisViewsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            AxisViewsBox.Location = new Point(7, 47);
            AxisViewsBox.Name = "AxisViewsBox";
            AxisViewsBox.Size = new Size(88, 18);
            AxisViewsBox.TabIndex = 1;
            AxisViewsBox.Text = "AxisViews";
            AxisViewsBox.CheckedChanged += new EventHandler(AnythingChecked);
            // 
            // CursorBox
            // 
            CursorBox.Checked = true;
            CursorBox.CheckState = System.Windows.Forms.CheckState.Checked;
            CursorBox.Location = new Point(7, 22);
            CursorBox.Name = "CursorBox";
            CursorBox.Size = new Size(68, 18);
            CursorBox.TabIndex = 0;
            CursorBox.Text = "Cursor";
            CursorBox.CheckedChanged += new EventHandler(AnythingChecked);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(noneButton);
            groupBox1.Controls.Add(plotButton);
            groupBox1.Controls.Add(positionButton);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(20, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 98);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Align using position";
            // 
            // noneButton
            // 
            noneButton.Location = new Point(6, 69);
            noneButton.Name = "noneButton";
            noneButton.Size = new Size(58, 18);
            noneButton.TabIndex = 2;
            noneButton.TabStop = true;
            noneButton.Text = "None";
            noneButton.CheckedChanged += new EventHandler(AnythingChecked);
            // 
            // plotButton
            // 
            plotButton.Checked = true;
            plotButton.Location = new Point(6, 45);
            plotButton.Name = "plotButton";
            plotButton.Size = new Size(145, 18);
            plotButton.TabIndex = 1;
            plotButton.TabStop = true;
            plotButton.Text = "Inner Plot Position ";
            plotButton.CheckedChanged += new EventHandler(AnythingChecked);
            // 
            // positionButton
            // 
            positionButton.Location = new Point(6, 21);
            positionButton.Name = "positionButton";
            positionButton.Size = new Size(75, 18);
            positionButton.TabIndex = 0;
            positionButton.TabStop = true;
            positionButton.Text = "Position";
            positionButton.CheckedChanged += new EventHandler(AnythingChecked);
            // 
            // checkAlign
            // 
            checkAlign.Location = new Point(20, 0);
            checkAlign.Name = "checkAlign";
            checkAlign.Size = new Size(192, 24);
            checkAlign.TabIndex = 0;
            checkAlign.Text = "&Align the two chart areas";
            checkAlign.CheckedChanged += new EventHandler(AnythingChecked);
            // 
            // Chart1
            // 
            Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            Chart1.BorderlineWidth = 2;
            Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.IndianRed;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Inclination = 15;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Perspective = 10;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.AxisY.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BackColor = System.Drawing.Color.OldLace;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorX.SelectionColor = System.Drawing.Color.IndianRed;
            chartArea2.Name = "Chart Area 2";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            Chart1.ChartAreas.Add(chartArea2);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "Default";
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(19, 56);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Series 1";
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
            series1.YValuesPerPoint = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Default";
            series2.Name = "Series 2";
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
            series2.ShadowOffset = 1;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Chart Area 2";
            series3.Legend = "Default";
            series3.Name = "Series 3";
            series3.Points.Add(dataPoint23);
            series3.Points.Add(dataPoint24);
            series3.Points.Add(dataPoint25);
            series3.Points.Add(dataPoint26);
            series3.Points.Add(dataPoint27);
            series3.Points.Add(dataPoint28);
            series3.Points.Add(dataPoint29);
            series3.Points.Add(dataPoint30);
            series3.Points.Add(dataPoint31);
            series3.Points.Add(dataPoint32);
            series3.Points.Add(dataPoint33);
            series3.YValuesPerPoint = 2;
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series4.ChartArea = "Chart Area 2";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Default";
            series4.Name = "Series 4";
            series4.Points.Add(dataPoint34);
            series4.Points.Add(dataPoint35);
            series4.Points.Add(dataPoint36);
            series4.Points.Add(dataPoint37);
            series4.Points.Add(dataPoint38);
            series4.Points.Add(dataPoint39);
            series4.Points.Add(dataPoint40);
            series4.Points.Add(dataPoint41);
            series4.Points.Add(dataPoint42);
            series4.Points.Add(dataPoint43);
            series4.Points.Add(dataPoint44);
            series4.ShadowOffset = 1;
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Series.Add(series4);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            // 
            // AlignmentTypes
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "AlignmentTypes";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion






        private void AnythingChecked(object sender, EventArgs e)
        {
            if (checkAlign.Checked)
            {
                // Make Chart Area 2 align to Chart Area 1
                Chart1.ChartAreas["Chart Area 2"].AlignWithChartArea = "Default";
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;



            }


            if (noneButton.Checked)
            {
                if (CursorBox.Checked && AxisViewsBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.None | AreaAlignmentStyles.Cursor | AreaAlignmentStyles.AxesView;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.None |\n AreaAlignmentStyles.Cursor |\n AreaAlignmentStyles.AxesView;";
                }
                else if (AxisViewsBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.None | AreaAlignmentStyles.AxesView;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.None |\n AreaAlignmentStyles.AxesView;";
                }
                else if (CursorBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.None | AreaAlignmentStyles.Cursor;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.None |\n AreaAlignmentStyles.Cursor;";
                }
                else if(noneButton.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.None;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.None;";

                }
            }
            if (positionButton.Checked)
            {
                if (CursorBox.Checked && AxisViewsBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.Position | AreaAlignmentStyles.Cursor | AreaAlignmentStyles.AxesView;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.Position |\n AreaAlignmentStyles.Cursor |\n AreaAlignmentStyles.AxesView;";
                }
                else if (AxisViewsBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.Position | AreaAlignmentStyles.AxesView;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.Position |\n AreaAlignmentStyles.AxesView;";
                }
                else if (CursorBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.Position | AreaAlignmentStyles.Cursor;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.Position |\n AreaAlignmentStyles.Cursor;";

                }
                else if (positionButton.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.Position;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.Position;";
                }
            }
            if (plotButton.Checked)
            {
                if (CursorBox.Checked && AxisViewsBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.PlotPosition | AreaAlignmentStyles.Cursor | AreaAlignmentStyles.AxesView;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.PlotPosition |\n AreaAlignmentStyles.Cursor |\n AreaAlignmentStyles.AxesView;";
                }
                else if (AxisViewsBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.PlotPosition | AreaAlignmentStyles.AxesView;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.PlotPosition |\n AreaAlignmentStyles.AxesView";
                }
                else if (CursorBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.PlotPosition | AreaAlignmentStyles.Cursor;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.PlotPosition |\n AreaAlignmentStyles.Cursor;";
                }
                else if(plotButton.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.PlotPosition;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.PlotPosition;";
                }
            }
            if (!checkAlign.Checked)
            {
                // No alignment
                Chart1.ChartAreas["Chart Area 2"].AlignWithChartArea = "";
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                AlignStyleLabel.Text = "Not aligned";
            }




        }




	}
}

