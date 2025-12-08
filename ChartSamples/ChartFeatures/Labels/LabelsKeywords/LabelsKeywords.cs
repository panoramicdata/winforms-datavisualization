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
	/// Summary description for AxisAppearance.
	/// </summary>
	public class LabelsKeywords : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label15;
		private Label label1;
		private Label label2;
		private ComboBox PointLabelsList;
		private ComboBox AxisLabelsList;
		private Label label7;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public LabelsKeywords()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize component
			AxisLabelsList.SelectedIndex = 0;
			PointLabelsList.SelectedIndex = 0;

			// Populate series data
			DateTime	dateCurrent = DateTime.Now.Date;
			int pointIndex = 0;
			foreach( DataPoint p in Chart1.Series["Series1"].Points)
			{
				p.XValue = dateCurrent.AddDays(pointIndex++).ToOADate();
			}
			
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
			DataPoint dataPoint1 = new DataPoint(0, 1.2999999523162842);
			DataPoint dataPoint2 = new DataPoint(0, 1.7999999523162842);
			DataPoint dataPoint3 = new DataPoint(0, 2.2999999523162842);
			DataPoint dataPoint4 = new DataPoint(0, 1.5);
			DataPoint dataPoint5 = new DataPoint(0, 1.2000000476837158);
			DataPoint dataPoint6 = new DataPoint(0, 1.7999999523162842);
			DataPoint dataPoint7 = new DataPoint(0, 1.2000000476837158);
			ComponentResourceManager resources = new ComponentResourceManager(typeof(LabelsKeywords));
            label9 = new Label();
            panel1 = new Panel();
            AxisLabelsList = new ComboBox();
            label2 = new Label();
            PointLabelsList = new ComboBox();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label15 = new Label();
            Chart1 = new Chart();
            label7 = new Label();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to use keywords within axis and data point labels.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(AxisLabelsList);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PointLabelsList);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // AxisLabelsList
            // 
            AxisLabelsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            AxisLabelsList.Items.AddRange([
            "Month: #VALX{MMM}\\nDay: #VALX{dd}",
            "#VALX{dd}\\n#VALX{MMM}\\n#VALX{yyy}",
            "#INDEX"]);
            AxisLabelsList.Location = new Point(8, 80);
            AxisLabelsList.Name = "AxisLabelsList";
            AxisLabelsList.Size = new Size(280, 22);
            AxisLabelsList.TabIndex = 3;
            AxisLabelsList.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(8, 58);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 2;
            label2.Text = "&X Axis Label with Keywords:";
            // 
            // PointLabelsList
            // 
            PointLabelsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            PointLabelsList.Items.AddRange([
            "#PERCENT",
            "Y = #VALY\\nX = #VALX",
            "#VALX{ddd}"]);
            PointLabelsList.Location = new Point(8, 24);
            PointLabelsList.Name = "PointLabelsList";
            PointLabelsList.Size = new Size(280, 22);
            PointLabelsList.TabIndex = 1;
            PointLabelsList.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(5, 3);
            label1.Name = "label1";
            label1.Size = new Size(212, 20);
            label1.TabIndex = 0;
            label1.Text = "Data Point &Label with Keywords:";
            // 
            // label6
            // 
            label6.Location = new Point(64, 403);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 7;
            label6.Text = "Border Size:";
            // 
            // label5
            // 
            label5.Location = new Point(64, 380);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 6;
            label5.Text = "Border Color:";
            // 
            // label4
            // 
            label4.Location = new Point(64, 357);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 5;
            label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            label3.Location = new Point(64, 334);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "Gradient:";
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
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Format = "N2";
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.Maximum = 2.7999999523162842;
            chartArea1.AxisY.Minimum = 0.800000011920929;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 48);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Default";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series1.MarkerSize = 7;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.ShadowOffset = 1;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            Chart1.Click += new EventHandler(Chart1_Click);
            // 
            // label7
            // 
            label7.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label7.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new Point(16, 356);
            label7.Name = "label7";
            label7.Size = new Size(704, 60);
            label7.TabIndex = 3;
            label7.Text = resources.GetString("label7.Text");
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelsKeywords
            // 
            Controls.Add(label7);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "LabelsKeywords";
            Size = new Size(728, 480);
            Load += new EventHandler(CustomLabels_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void Chart1_Click(object sender, EventArgs e)
		{
		
		}

		private void CustomLabels_Load(object sender, EventArgs e)
		{
			Keywords();
		}

		private void Keywords()
		{
			if( 
				AxisLabelsList.SelectedItem == null ||
				PointLabelsList.SelectedItem == null 
				)
			{
				return;
			}

			
			// Set axis labels
			Chart1.Series["Series1"].AxisLabel = AxisLabelsList.GetItemText(AxisLabelsList.SelectedItem);

			// Set series point's labels
			Chart1.Series["Series1"].Label = PointLabelsList.GetItemText(PointLabelsList.SelectedItem);
		}

		private void Combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Keywords();
		}
		
	}
}
