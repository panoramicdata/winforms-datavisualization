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
	/// Summary description for BubbleChartType.
	/// </summary>
	public class BubbleChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxShape;
		private Label label2;
		private ComboBox comboBoxMaxSize;
		private Label label3;
		private ComboBox comboBoxMaxScale;
		private Label label4;
		private ComboBox comboBoxMinScale;
		private CheckBox checkBoxShowSizeInLabel;
        private CheckBox checkBoxShow3D;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public BubbleChartType()
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
			DataPoint dataPoint1 = new DataPoint(0, "15,8");
			DataPoint dataPoint2 = new DataPoint(0, "18,14");
			DataPoint dataPoint3 = new DataPoint(0, "15,8");
			DataPoint dataPoint4 = new DataPoint(0, "16,13");
			DataPoint dataPoint5 = new DataPoint(0, "14,11");
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, "9,15");
			DataPoint dataPoint7 = new DataPoint(0, "8,14");
			DataPoint dataPoint8 = new DataPoint(0, "12,10");
			DataPoint dataPoint9 = new DataPoint(0, "9,14");
			DataPoint dataPoint10 = new DataPoint(0, "7,12");
			Title title1 = new Title();
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            checkBoxShow3D = new CheckBox();
            checkBoxShowSizeInLabel = new CheckBox();
            comboBoxMinScale = new ComboBox();
            label4 = new Label();
            comboBoxMaxScale = new ComboBox();
            label3 = new Label();
            comboBoxMaxSize = new ComboBox();
            label2 = new Label();
            comboBoxShape = new ComboBox();
            label1 = new Label();
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
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
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
            chart1.Location = new Point(16, 63);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Font = new Font("Trebuchet MS", 9F);
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.YValuesPerPoint = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series2.Font = new Font("Trebuchet MS", 9F);
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.YValuesPerPoint = 2;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 0;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Bubble Chart";
            chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 0);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 56);
            labelSampleComment.TabIndex = 2;
            labelSampleComment.Text = "This sample displays a Bubble chart that uses different shapes, including an imag" +
                "e, for the bubble. It demonstrates how to control the maximum bubble size and sc" +
                "ale as well as how to enable 3D.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxShow3D);
            panel1.Controls.Add(checkBoxShowSizeInLabel);
            panel1.Controls.Add(comboBoxMinScale);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxMaxScale);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxMaxSize);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxShape);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 280);
            panel1.TabIndex = 1;
            // 
            // checkBoxShow3D
            // 
            checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.Location = new Point(13, 170);
            checkBoxShow3D.Name = "checkBoxShow3D";
            checkBoxShow3D.Size = new Size(168, 24);
            checkBoxShow3D.TabIndex = 9;
            checkBoxShow3D.Text = "Display chart as 3&D:";
            checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.CheckedChanged += new EventHandler(checkBoxShow3D_CheckedChanged);
            // 
            // checkBoxShowSizeInLabel
            // 
            checkBoxShowSizeInLabel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowSizeInLabel.Location = new Point(-27, 138);
            checkBoxShowSizeInLabel.Name = "checkBoxShowSizeInLabel";
            checkBoxShowSizeInLabel.Size = new Size(208, 24);
            checkBoxShowSizeInLabel.TabIndex = 8;
            checkBoxShowSizeInLabel.Text = "Show Size in &Labels:";
            checkBoxShowSizeInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowSizeInLabel.CheckedChanged += new EventHandler(checkBoxShowSizeInLabel_CheckedChanged);
            // 
            // comboBoxMinScale
            // 
            comboBoxMinScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxMinScale.Items.AddRange([
            "Auto",
            "-4",
            "0",
            "4"]);
            comboBoxMinScale.Location = new Point(168, 104);
            comboBoxMinScale.Name = "comboBoxMinScale";
            comboBoxMinScale.Size = new Size(120, 22);
            comboBoxMinScale.TabIndex = 7;
            comboBoxMinScale.SelectedIndexChanged += new EventHandler(comboBoxMaxScale_SelectedIndexChanged);
            // 
            // label4
            // 
            label4.Location = new Point(4, 104);
            label4.Name = "label4";
            label4.Size = new Size(160, 23);
            label4.TabIndex = 6;
            label4.Text = "Bubble Size M&in. Scale:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMaxScale
            // 
            comboBoxMaxScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxMaxScale.Items.AddRange([
            "Auto",
            "20",
            "25",
            "30",
            "40"]);
            comboBoxMaxScale.Location = new Point(168, 72);
            comboBoxMaxScale.Name = "comboBoxMaxScale";
            comboBoxMaxScale.Size = new Size(120, 22);
            comboBoxMaxScale.TabIndex = 5;
            comboBoxMaxScale.SelectedIndexChanged += new EventHandler(comboBoxMaxScale_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(4, 72);
            label3.Name = "label3";
            label3.Size = new Size(160, 23);
            label3.TabIndex = 4;
            label3.Text = "Bubble Size Ma&x. Scale:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMaxSize
            // 
            comboBoxMaxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxMaxSize.Items.AddRange([
            "5",
            "10",
            "15",
            "20",
            "25"]);
            comboBoxMaxSize.Location = new Point(168, 40);
            comboBoxMaxSize.Name = "comboBoxMaxSize";
            comboBoxMaxSize.Size = new Size(120, 22);
            comboBoxMaxSize.TabIndex = 3;
            comboBoxMaxSize.SelectedIndexChanged += new EventHandler(comboBoxMaxScale_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(4, 40);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 2;
            label2.Text = "&Max. Bubble Size:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxShape
            // 
            comboBoxShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxShape.Items.AddRange([
            "Circle",
            "Square",
            "Diamond",
            "Triangle",
            "Cross",
            "Image"]);
            comboBoxShape.Location = new Point(168, 8);
            comboBoxShape.Name = "comboBoxShape";
            comboBoxShape.Size = new Size(120, 22);
            comboBoxShape.TabIndex = 1;
            comboBoxShape.SelectedIndexChanged += new EventHandler(comboBoxMaxScale_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(4, 8);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 0;
            label1.Text = "Bubble &Shape:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BubbleChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "BubbleChartType";
            Size = new Size(728, 392);
            Load += new EventHandler(BubbleChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Set bubble series shape to image
			if(comboBoxShape.Text == "Image")
			{
				// Get image path
				MainForm mainForm = (MainForm)ParentForm;
                string imageFileName = mainForm.CurrentSamplePath;
				imageFileName += "\\Face.bmp";
				
				chart1.Series["Default"].MarkerImage = imageFileName;
				chart1.Series["Default"].MarkerImageTransparentColor = Color.White;
				chart1.Series["Default"].MarkerStyle = MarkerStyle.None;
			}

			// Set "bubble" series shape
			else
			{
				chart1.Series["Default"].MarkerImage = "";
				chart1.Series["Default"].MarkerStyle = (MarkerStyle)MarkerStyle.Parse(typeof(MarkerStyle), comboBoxShape.Text);
			}

			// Set max bubble size
			chart1.Series["Default"]["BubbleMaxSize"] = comboBoxMaxSize.Text;

			// Show Y value or bubble sise as point labels
			chart1.Series["Default"].IsValueShownAsLabel = true;
			if(checkBoxShowSizeInLabel.Checked)
			{
				chart1.Series["Default"]["BubbleUseSizeForLabel"] = "true";
			}
			else
			{
				chart1.Series["Default"]["BubbleUseSizeForLabel"] = "false";
			}

			// Set scale for the bubble size
			if(comboBoxMinScale.Text != "Auto")
			{
				chart1.Series["Default"]["BubbleScaleMin"] = comboBoxMinScale.Text;
			}
			else
			{
				chart1.Series["Default"].DeleteCustomProperty("BubbleScaleMin");
			}

			if(comboBoxMaxScale.Text != "Auto")
			{
				chart1.Series["Default"]["BubbleScaleMax"] = comboBoxMaxScale.Text;
			}
			else
			{
				chart1.Series["Default"].DeleteCustomProperty("BubbleScaleMax");
			}

			if(checkBoxShow3D.Checked)
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
			}
			else
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;
			}

		}

		private void BubbleChartType_Load(object sender, EventArgs e)
		{
			comboBoxShape.SelectedIndex = 0;
			comboBoxMaxSize.SelectedIndex = 2;
			comboBoxMaxScale.SelectedIndex = 0;
			comboBoxMinScale.SelectedIndex = 0;
		}

		private void comboBoxMaxScale_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxShowSizeInLabel_CheckedChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
		{
			comboBoxShape.Items.Clear();
			if(checkBoxShow3D.Checked)
			{
				comboBoxShape.Items.Add("Circle");
				comboBoxShape.Items.Add("Square");
			}
			else
			{
				comboBoxShape.Items.Add("Circle");
				comboBoxShape.Items.Add("Square");
				comboBoxShape.Items.Add("Diamond");
				comboBoxShape.Items.Add("Triangle");
				comboBoxShape.Items.Add("Cross");
				comboBoxShape.Items.Add("Image");
			}
			comboBoxShape.SelectedIndex = 0;

			UpdateChartSettings();
		}
	}
}
