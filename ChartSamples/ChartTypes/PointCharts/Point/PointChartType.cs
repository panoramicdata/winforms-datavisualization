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
	/// Summary description for PointChartType.
	/// </summary>
	public class PointChartType : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label3;
		private Label label2;
		private Label label1;
		private ComboBox comboMarkerSize;
		private ComboBox comboBoxMarkerShape;
		private ComboBox comboBoxLabelPosition;
		private CheckBox checkBoxShow3D;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public PointChartType()
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
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            checkBoxShow3D = new CheckBox();
            comboMarkerSize = new ComboBox();
            label3 = new Label();
            comboBoxMarkerShape = new ComboBox();
            label2 = new Label();
            comboBoxLabelPosition = new ComboBox();
            label1 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.WhiteSmoke;
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
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
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
            chart1.Location = new Point(16, 56);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Font = new Font("Trebuchet MS", 9F);
            series1.Legend = "Default";
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            series1.ShadowOffset = 1;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Font = new Font("Trebuchet MS", 9F);
            series2.Legend = "Default";
            series2.MarkerSize = 10;
            series2.Name = "Series2";
            series2.ShadowOffset = 1;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 8);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 45);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample displays a Point chart. Try setting different marker sizes, shapes an" +
                "d point label positions.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxShow3D);
            panel1.Controls.Add(comboMarkerSize);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxMarkerShape);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxLabelPosition);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // checkBoxShow3D
            // 
            checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.Location = new Point(13, 104);
            checkBoxShow3D.Name = "checkBoxShow3D";
            checkBoxShow3D.Size = new Size(168, 24);
            checkBoxShow3D.TabIndex = 6;
            checkBoxShow3D.Text = "Display chart as 3&D:";
            checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShow3D.CheckedChanged += new EventHandler(checkBoxShow3D_CheckedChanged);
            // 
            // comboMarkerSize
            // 
            comboMarkerSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboMarkerSize.Items.AddRange([
            "5",
            "7",
            "10",
            "12",
            "18"]);
            comboMarkerSize.Location = new Point(168, 72);
            comboMarkerSize.Name = "comboMarkerSize";
            comboMarkerSize.Size = new Size(120, 22);
            comboMarkerSize.TabIndex = 5;
            comboMarkerSize.SelectedIndexChanged += new EventHandler(comboMarkerSize_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(20, 72);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 4;
            label3.Text = "Marker Si&ze:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMarkerShape
            // 
            comboBoxMarkerShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxMarkerShape.Items.AddRange([
            "Circle & Square",
            "Diamond & Triangle",
            "Cross & Star"]);
            comboBoxMarkerShape.Location = new Point(168, 40);
            comboBoxMarkerShape.Name = "comboBoxMarkerShape";
            comboBoxMarkerShape.Size = new Size(120, 22);
            comboBoxMarkerShape.TabIndex = 3;
            comboBoxMarkerShape.SelectedIndexChanged += new EventHandler(comboMarkerSize_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(20, 40);
            label2.Name = "label2";
            label2.Size = new Size(144, 23);
            label2.TabIndex = 2;
            label2.Text = "Marker &Shape:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxLabelPosition
            // 
            comboBoxLabelPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxLabelPosition.Items.AddRange([
            "None",
            "TopLeft",
            "Top",
            "TopRight",
            "Right",
            "BottomRight",
            "Bottom",
            "BottomLeft",
            "Left",
            "Center"]);
            comboBoxLabelPosition.Location = new Point(168, 8);
            comboBoxLabelPosition.Name = "comboBoxLabelPosition";
            comboBoxLabelPosition.Size = new Size(120, 22);
            comboBoxLabelPosition.TabIndex = 1;
            comboBoxLabelPosition.SelectedIndexChanged += new EventHandler(comboMarkerSize_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(20, 8);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 0;
            label1.Text = "Label &Position:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PointChartType
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PointChartType";
            Size = new Size(728, 368);
            Load += new EventHandler(PointChartType_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Set point chart type
			chart1.Series["Series1"].ChartType = SeriesChartType.Point;
			chart1.Series["Series2"].ChartType = SeriesChartType.Point;

			// Enable data points labels
			if(comboBoxLabelPosition.Text != "None")
			{
				chart1.Series["Series1"].IsValueShownAsLabel = true;
				chart1.Series["Series2"].IsValueShownAsLabel = true;
				chart1.Series["Series1"]["LabelStyle"] = comboBoxLabelPosition.Text;
				chart1.Series["Series2"]["LabelStyle"] = comboBoxLabelPosition.Text;
			}
			else
			{
				chart1.Series["Series1"].IsValueShownAsLabel = false;
				chart1.Series["Series2"].IsValueShownAsLabel = false;
			}


			// Set marker size
			chart1.Series["Series1"].MarkerSize = int.Parse(comboMarkerSize.Text);
			chart1.Series["Series2"].MarkerSize = int.Parse(comboMarkerSize.Text);

			// Set marker shape
			if(comboBoxMarkerShape.SelectedIndex == 1)	
			{
				chart1.Series["Series1"].MarkerStyle = MarkerStyle.Diamond;
				chart1.Series["Series2"].MarkerStyle = MarkerStyle.Triangle;
				chart1.Series["Series2"].MarkerImage = "";
			}
			else if(comboBoxMarkerShape.SelectedIndex == 2)	
			{


				chart1.Series["Series1"].MarkerStyle = MarkerStyle.Cross;
                chart1.Series["Series2"].MarkerStyle = MarkerStyle.Star5;
			}
			else
			{
				chart1.Series["Series1"].MarkerStyle = MarkerStyle.Circle;
				chart1.Series["Series2"].MarkerStyle = MarkerStyle.Square;
			}


			// Set X and Y axis scale
			chart1.ChartAreas["Default"].AxisY.Maximum = 100.0;
			chart1.ChartAreas["Default"].AxisY.Minimum = 0.0;
		}	
			
		private void PointChartType_Load(object sender, EventArgs e)
		{
			// Populate series data with random data
			Random	random = new Random();
			for(int pointIndex = 0; pointIndex < 10; pointIndex++)
			{
				chart1.Series["Series1"].Points.AddY(random.Next(5, 60));
				chart1.Series["Series2"].Points.AddY(random.Next(50, 95));
			}

			// Set selected items
			comboMarkerSize.SelectedIndex = 1;
			comboBoxMarkerShape.SelectedIndex = 0;
			comboBoxLabelPosition.SelectedIndex = 0;
		}

		private void comboMarkerSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxShow3D.Checked)
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
				chart1.ChartAreas["Default"].Area3DStyle.LightStyle = LightStyle.Realistic;				
			}
			else
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;				
			}
		}

	}
}
