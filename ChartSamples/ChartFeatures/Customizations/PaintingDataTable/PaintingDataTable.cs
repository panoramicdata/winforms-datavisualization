using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Utilities;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for PaintingDataTable.
	/// </summary>
	public class PaintingDataTable : UserControl
	{
		private Chart chart1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private CheckBox ShowTitle;
		private ComboBox FontSize;
		private ComboBox BorderColor;
		private ComboBox TableColor;
		private ComboBox RotateAxisLabel;
		private Panel panel1;
		private Label label9;
		private CheckBox DataTable1;
		private CheckBox IsPositionedInside;
		private CheckBox EnableScrollBar;

		private ChartDataTableHelper TableHelper = null;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public PaintingDataTable()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			DataTable1.Checked = true;
			ShowTitle.Checked = true;
			FontSize.SelectedIndex = 0;
			BorderColor.SelectedIndex = 1;
			TableColor.SelectedIndex = 2;
			RotateAxisLabel.SelectedIndex = 0;

			chart1.ChartAreas["Default"].AxisX.TitleFont = new Font("Arial", 8);
			
            if(DataTable1.Checked && TableHelper == null)
			{
				TableHelper = new ChartDataTableHelper();
				TableHelper.Initialize(chart1);//, ShowTotals.Checked);
				TableHelper.TableColor = Color.FromName(TableColor.SelectedText);
				TableHelper.BorderColor = Color.FromName(BorderColor.SelectedText);
			}

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ChartArea chartArea1 = new ChartArea();
			Legend legend1 = new Legend();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(1, 2);
			DataPoint dataPoint2 = new DataPoint(2, 3);
			DataPoint dataPoint3 = new DataPoint(3, 5);
			DataPoint dataPoint4 = new DataPoint(4, 3);
			DataPoint dataPoint5 = new DataPoint(5, 6);
			DataPoint dataPoint6 = new DataPoint(6, 5);
			DataPoint dataPoint7 = new DataPoint(7, 7);
			DataPoint dataPoint8 = new DataPoint(8, 9);
			DataPoint dataPoint9 = new DataPoint(9, 9);
			DataPoint dataPoint10 = new DataPoint(10, 6);
			DataPoint dataPoint11 = new DataPoint(11, 9);
			DataPoint dataPoint12 = new DataPoint(12, 3);
			Series series2 = new Series();
			DataPoint dataPoint13 = new DataPoint(1, 2);
			DataPoint dataPoint14 = new DataPoint(2, 8);
			DataPoint dataPoint15 = new DataPoint(3, 3);
			DataPoint dataPoint16 = new DataPoint(4, 4);
			DataPoint dataPoint17 = new DataPoint(5, 7);
			DataPoint dataPoint18 = new DataPoint(6, 0.5);
			DataPoint dataPoint19 = new DataPoint(7, 5);
			DataPoint dataPoint20 = new DataPoint(8, 6);
			DataPoint dataPoint21 = new DataPoint(9, 1);
			DataPoint dataPoint22 = new DataPoint(10, 7);
			DataPoint dataPoint23 = new DataPoint(11, 3);
			DataPoint dataPoint24 = new DataPoint(12, 8);
            chart1 = new Chart();
            ShowTitle = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            RotateAxisLabel = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            FontSize = new ComboBox();
            TableColor = new ComboBox();
            BorderColor = new ComboBox();
            panel1 = new Panel();
            EnableScrollBar = new CheckBox();
            IsPositionedInside = new CheckBox();
            DataTable1 = new CheckBox();
            label9 = new Label();
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Interval = 1;
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Interval = 1;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0.5;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Interval = 1;
            chartArea1.AxisX.MajorTickMark.IntervalOffset = 0.5;
            chartArea1.AxisX.ScaleView.Size = 5;
            chartArea1.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.Title = "This is the X Axis";
            chartArea1.AxisX.TitleFont = new Font("Arial", 8F);
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.CursorX.IntervalOffset = 0.5;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "Default";
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(8, 53);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Series1";
            dataPoint2.AxisLabel = "";
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
            series1.Points.Add(dataPoint12);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Legend = "Default";
            series2.Name = "Series2";
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
            series2.Points.Add(dataPoint23);
            series2.Points.Add(dataPoint24);
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            // 
            // ShowTitle
            // 
            ShowTitle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            ShowTitle.Location = new Point(5, 37);
            ShowTitle.Name = "ShowTitle";
            ShowTitle.Size = new Size(176, 24);
            ShowTitle.TabIndex = 1;
            ShowTitle.Text = "Show Axis T&itle:";
            ShowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            ShowTitle.Click += new EventHandler(ShowTitle_Click);
            // 
            // label1
            // 
            label1.Location = new Point(11, 123);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 4;
            label1.Text = "&Rotate Labels:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(11, 149);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 6;
            label2.Text = "Title Si&ze:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RotateAxisLabel
            // 
            RotateAxisLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            RotateAxisLabel.Items.AddRange([
            "0",
            "30",
            "45",
            "60",
            "90"]);
            RotateAxisLabel.Location = new Point(168, 124);
            RotateAxisLabel.Name = "RotateAxisLabel";
            RotateAxisLabel.Size = new Size(64, 22);
            RotateAxisLabel.TabIndex = 5;
            RotateAxisLabel.SelectionChangeCommitted += new EventHandler(comboBox1_SelectionChangeCommitted);
            // 
            // label3
            // 
            label3.Location = new Point(27, 175);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 8;
            label3.Text = "Table C&olor:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(19, 200);
            label4.Name = "label4";
            label4.Size = new Size(144, 23);
            label4.TabIndex = 10;
            label4.Text = "Table &Border:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FontSize
            // 
            FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FontSize.Items.AddRange([
            "8",
            "10",
            "12",
            "14",
            "18"]);
            FontSize.Location = new Point(168, 150);
            FontSize.Name = "FontSize";
            FontSize.Size = new Size(64, 22);
            FontSize.TabIndex = 7;
            FontSize.SelectionChangeCommitted += new EventHandler(FontSize_SelectionChangeCommitted);
            // 
            // TableColor
            // 
            TableColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            TableColor.Items.AddRange([
            "Control",
            "Yellow",
            "OldLace",
            "White",
            "Transparent"]);
            TableColor.Location = new Point(168, 176);
            TableColor.Name = "TableColor";
            TableColor.Size = new Size(120, 22);
            TableColor.TabIndex = 9;
            TableColor.SelectedIndexChanged += new EventHandler(TableColor_SelectedIndexChanged);
            // 
            // BorderColor
            // 
            BorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BorderColor.Items.AddRange([
            "Control",
            "Black",
            "Red",
            "Yellow",
            "DimGray",
            "White",
            "Transparent"]);
            BorderColor.Location = new Point(168, 202);
            BorderColor.Name = "BorderColor";
            BorderColor.Size = new Size(121, 22);
            BorderColor.TabIndex = 11;
            BorderColor.SelectedIndexChanged += new EventHandler(BorderColor_SelectedIndexChanged);
            // 
            // panel1
            // 
            panel1.Controls.Add(EnableScrollBar);
            panel1.Controls.Add(IsPositionedInside);
            panel1.Controls.Add(DataTable1);
            panel1.Controls.Add(RotateAxisLabel);
            panel1.Controls.Add(ShowTitle);
            panel1.Controls.Add(FontSize);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(BorderColor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TableColor);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(432, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // EnableScrollBar
            // 
            EnableScrollBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            EnableScrollBar.Checked = true;
            EnableScrollBar.CheckState = System.Windows.Forms.CheckState.Checked;
            EnableScrollBar.Location = new Point(5, 66);
            EnableScrollBar.Name = "EnableScrollBar";
            EnableScrollBar.Size = new Size(176, 24);
            EnableScrollBar.TabIndex = 2;
            EnableScrollBar.Text = "Enable &ScrollBar:";
            EnableScrollBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            EnableScrollBar.CheckedChanged += new EventHandler(EnableScrollBar_CheckedChanged);
            // 
            // IsPositionedInside
            // 
            IsPositionedInside.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            IsPositionedInside.Location = new Point(13, 95);
            IsPositionedInside.Name = "IsPositionedInside";
            IsPositionedInside.Size = new Size(168, 24);
            IsPositionedInside.TabIndex = 3;
            IsPositionedInside.Text = "ScrollBar I&nside:";
            IsPositionedInside.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            IsPositionedInside.CheckedChanged += new EventHandler(IsPositionedInside_CheckedChanged);
            // 
            // DataTable1
            // 
            DataTable1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            DataTable1.Location = new Point(5, 8);
            DataTable1.Name = "DataTable1";
            DataTable1.Size = new Size(176, 24);
            DataTable1.TabIndex = 0;
            DataTable1.Text = "Show Data &Table:";
            DataTable1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            DataTable1.CheckedChanged += new EventHandler(DataTable1_CheckedChanged_1);
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 37);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to draw a custom data table using the PrePaint and P" +
                "ostPaint events.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaintingDataTable
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PaintingDataTable";
            Size = new Size(728, 376);
            Load += new EventHandler(PaintingDataTable_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion


		private void PaintingDataTable_Load(object sender, EventArgs e)
		{
		
		}


		private void FontSize_SelectionChangeCommitted(object sender, EventArgs e)
		{
			chart1.ChartAreas["Default"].AxisX.TitleFont = new Font("Arial", float.Parse(FontSize.SelectedItem.ToString()));
		}

		private void TableColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			TableHelper.TableColor = Color.FromName(TableColor.SelectedItem.ToString());
			chart1.Invalidate();		
		}

		private void BorderColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			TableHelper.BorderColor = Color.FromName(BorderColor.SelectedItem.ToString());
			chart1.Invalidate();		
		}

		private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			chart1.ChartAreas["Default"].AxisX.LabelStyle.Angle = int.Parse(RotateAxisLabel.SelectedItem.ToString());
		}

		private void ShowTitle_Click(object sender, EventArgs e)
		{
			if(ShowTitle.Checked)
				chart1.ChartAreas["Default"].AxisX.Title = "This is the X Axis";
			else
				chart1.ChartAreas["Default"].AxisX.Title = "";
		}


		private void DataTable1_CheckedChanged_1(object sender, EventArgs e)
		{
			if(TableHelper == null)
			{
				TableHelper = new ChartDataTableHelper();
				TableHelper.Initialize(chart1);//, ShowTotals.Checked);
				TableHelper.TableColor = Color.FromName(TableColor.SelectedText);
				TableHelper.BorderColor = Color.FromName(BorderColor.SelectedText);
			}

			if(DataTable1.Checked)
				TableHelper.AddDataTable("Default");
			else
				TableHelper.RemoveDataTable("Default");

		}


		private void RemoveDataTable(string ChartAreaName)
		{
			TableHelper.RemoveDataTable(ChartAreaName);
		}


		private void IsPositionedInside_CheckedChanged(object sender, EventArgs e)
		{
			chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = IsPositionedInside.Checked;
		}

		private void EnableScrollBar_CheckedChanged(object sender, EventArgs e)
		{
			chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = EnableScrollBar.Checked;
		}


	}
}


