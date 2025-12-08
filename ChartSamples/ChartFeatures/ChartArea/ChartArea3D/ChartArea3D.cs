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
	/// Summary description for BarColumnChartType.
	/// </summary>
	public class ChartArea3D : UserControl
	{
		private Chart chart1;
		private Panel panel1;
		private CheckBox checkBoxShow3D;
		private CheckBox RightAngleAxis;
		private ComboBox WallWidth;
		private Label label3;
		private NumericUpDown Rotation;
		private NumericUpDown Inclination;
		private Label label4;
		private Label label5;
		private Label label2;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public ChartArea3D()
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
			DataPoint dataPoint1 = new DataPoint(0, 23);
			DataPoint dataPoint2 = new DataPoint(0, 56);
			DataPoint dataPoint3 = new DataPoint(0, 35);
			DataPoint dataPoint4 = new DataPoint(0, 68);
			DataPoint dataPoint5 = new DataPoint(0, 35);
			DataPoint dataPoint6 = new DataPoint(0, -6);
			DataPoint dataPoint7 = new DataPoint(0, 23);
			Title title1 = new Title();
            chart1 = new Chart();
            panel1 = new Panel();
            Rotation = new NumericUpDown();
            Inclination = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            WallWidth = new ComboBox();
            RightAngleAxis = new CheckBox();
            checkBoxShow3D = new CheckBox();
            label2 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Rotation)).BeginInit();
            ((ISupportInitialize)(Inclination)).BeginInit();
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
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
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
            chart1.Location = new Point(16, 65);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            chart1.Series.Add(series1);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "2D Chart";
            chart1.Titles.Add(title1);
            // 
            // panel1
            // 
            panel1.Controls.Add(Rotation);
            panel1.Controls.Add(Inclination);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(WallWidth);
            panel1.Controls.Add(RightAngleAxis);
            panel1.Controls.Add(checkBoxShow3D);
            panel1.Location = new Point(432, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // Rotation
            // 
            Rotation.Enabled = false;
            Rotation.Increment = new decimal([
            10,
            0,
            0,
            0]);
            Rotation.Location = new Point(168, 136);
            Rotation.Maximum = new decimal([
            1000,
            0,
            0,
            0]);
            Rotation.Minimum = new decimal([
            1000,
            0,
            0,
            -2147483648]);
            Rotation.Name = "Rotation";
            Rotation.Size = new Size(56, 22);
            Rotation.TabIndex = 7;
            Rotation.Value = new decimal([
            30,
            0,
            0,
            0]);
            Rotation.ValueChanged += new EventHandler(Rotation_ValueChanged);
            // 
            // Inclination
            // 
            Inclination.Enabled = false;
            Inclination.Increment = new decimal([
            10,
            0,
            0,
            0]);
            Inclination.Location = new Point(168, 104);
            Inclination.Maximum = new decimal([
            1000,
            0,
            0,
            0]);
            Inclination.Minimum = new decimal([
            1000,
            0,
            0,
            -2147483648]);
            Inclination.Name = "Inclination";
            Inclination.Size = new Size(56, 22);
            Inclination.TabIndex = 5;
            Inclination.Value = new decimal([
            30,
            0,
            0,
            0]);
            Inclination.ValueChanged += new EventHandler(Inclination_ValueChanged);
            // 
            // label4
            // 
            label4.Location = new Point(33, 136);
            label4.Name = "label4";
            label4.Size = new Size(132, 23);
            label4.TabIndex = 6;
            label4.Text = "Rotate &Y:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(33, 104);
            label5.Name = "label5";
            label5.Size = new Size(132, 23);
            label5.TabIndex = 4;
            label5.Text = "Rotate &X:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(37, 72);
            label3.Name = "label3";
            label3.Size = new Size(128, 23);
            label3.TabIndex = 2;
            label3.Text = "&Wall Width:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WallWidth
            // 
            WallWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            WallWidth.Enabled = false;
            WallWidth.Items.AddRange([
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "7",
            "10",
            "15",
            "20",
            "25",
            "30"]);
            WallWidth.Location = new Point(168, 72);
            WallWidth.Name = "WallWidth";
            WallWidth.Size = new Size(121, 22);
            WallWidth.TabIndex = 3;
            WallWidth.SelectedIndexChanged += new EventHandler(WallWidth_SelectedIndexChanged);
            // 
            // RightAngleAxis
            // 
            RightAngleAxis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            RightAngleAxis.Enabled = false;
            RightAngleAxis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            RightAngleAxis.Location = new Point(16, 33);
            RightAngleAxis.Name = "RightAngleAxis";
            RightAngleAxis.Size = new Size(164, 24);
            RightAngleAxis.TabIndex = 1;
            RightAngleAxis.Text = "Right Angle &Axis:";
            RightAngleAxis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            RightAngleAxis.CheckedChanged += new EventHandler(RightAngleAxis_CheckedChanged);
            // 
            // checkBoxShow3D
            // 
            checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            checkBoxShow3D.Location = new Point(16, 3);
            checkBoxShow3D.Name = "checkBoxShow3D";
            checkBoxShow3D.Size = new Size(164, 24);
            checkBoxShow3D.TabIndex = 0;
            checkBoxShow3D.Text = "Display chart as 3&D:";
            checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.CheckedChanged += new EventHandler(checkBoxShow3D_CheckedChanged);
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(16, 16);
            label2.Name = "label2";
            label2.Size = new Size(702, 41);
            label2.TabIndex = 4;
            label2.Text = "This sample demonstrates chart rotation, isometric projection, and how to set the" +
                " width of 3D walls. ";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChartArea3D
            // 
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "ChartArea3D";
            Size = new Size(728, 480);
            Load += new EventHandler(BarColumnChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Rotation)).EndInit();
            ((ISupportInitialize)(Inclination)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void BarColumnChartType_Load(object sender, EventArgs e)
		{
			checkBoxShow3D.Checked = false;
			// set the combo selection index
			WallWidth.SelectedIndex = 6;
		}

		private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
		{
			chart1.ChartAreas[0].Area3DStyle.Enable3D = checkBoxShow3D.Checked;

			if(checkBoxShow3D.Checked)
			{
				chart1.Titles[0].Text = "3D Chart";
				Inclination.Enabled = true;
				Rotation.Enabled = true;
			}
			else
			{
				chart1.Titles[0].Text = "2D Chart";
				Inclination.Enabled = false;
				Rotation.Enabled = false;
			}

			RightAngleAxis.Enabled = checkBoxShow3D.Checked;
			WallWidth.Enabled = checkBoxShow3D.Checked;
		}

		private void RightAngleAxis_CheckedChanged(object sender, EventArgs e)
		{
			// Disable/enable right angle axis
			chart1.ChartAreas["Default"].Area3DStyle.IsRightAngleAxes = RightAngleAxis.Checked;
	
		}

		private void WallWidth_SelectedIndexChanged(object sender, EventArgs e)
		{
			if( WallWidth.SelectedItem == null)
				return;

			int val = int.Parse(WallWidth.GetItemText(WallWidth.SelectedItem));
			chart1.ChartAreas[0].Area3DStyle.WallWidth = val;
		}

		private void Inclination_ValueChanged(object sender, EventArgs e)
		{
			if(Inclination.Value > 90)
				Inclination.Value = -90;
			if(Inclination.Value < -90)
				Inclination.Value = 90;

			chart1.ChartAreas["Default"].Area3DStyle.Inclination = (int)Inclination.Value;
		}

		private void Rotation_ValueChanged(object sender, EventArgs e)
		{
			if(Rotation.Value > 180)
				Rotation.Value = -180;
			if(Rotation.Value < -180)
				Rotation.Value = 180;

			chart1.ChartAreas["Default"].Area3DStyle.Rotation = (int)Rotation.Value;
		}


	}
}
