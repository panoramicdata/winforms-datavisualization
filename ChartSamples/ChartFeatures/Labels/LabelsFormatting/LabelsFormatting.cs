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
	public class LabelsFormatting : UserControl
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
		private Label label7;
		private CheckBox IsEndLabelVisible;
		private ComboBox XAxisFormat;
		private ComboBox YAxisFormat;
		private ComboBox SeriesPointFormat;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public LabelsFormatting()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize combo boxes
			XAxisFormat.SelectedIndex = 0;
			YAxisFormat.SelectedIndex = 0;
			SeriesPointFormat.SelectedIndex = 4;
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
            label9 = new Label();
            panel1 = new Panel();
            IsEndLabelVisible = new CheckBox();
            SeriesPointFormat = new ComboBox();
            YAxisFormat = new ComboBox();
            XAxisFormat = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label15 = new Label();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(8, 12);
            label9.Name = "label9";
            label9.Size = new Size(702, 45);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to format axes and data point labels. Data point lab" +
                "els can be set for an entire series or for an individual data point.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(IsEndLabelVisible);
            panel1.Controls.Add(SeriesPointFormat);
            panel1.Controls.Add(YAxisFormat);
            panel1.Controls.Add(XAxisFormat);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(432, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // IsEndLabelVisible
            // 
            IsEndLabelVisible.Location = new Point(48, 148);
            IsEndLabelVisible.Name = "IsEndLabelVisible";
            IsEndLabelVisible.Size = new Size(192, 24);
            IsEndLabelVisible.TabIndex = 6;
            IsEndLabelVisible.Text = "Show X &Axis End Labels";
            IsEndLabelVisible.CheckedChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // SeriesPointFormat
            // 
            SeriesPointFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SeriesPointFormat.Items.AddRange([
            "Currency",
            "Currency Rounded",
            "Scientific",
            "Scientific  Rounded",
            "Percent",
            "Percent Rounded"]);
            SeriesPointFormat.Location = new Point(48, 116);
            SeriesPointFormat.Name = "SeriesPointFormat";
            SeriesPointFormat.Size = new Size(172, 22);
            SeriesPointFormat.TabIndex = 5;
            SeriesPointFormat.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // YAxisFormat
            // 
            YAxisFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            YAxisFormat.Items.AddRange([
            "Currency",
            "Currency Rounded",
            "Scientific",
            "Scientific  Rounded",
            "Percent",
            "Percent Rounded"]);
            YAxisFormat.Location = new Point(48, 72);
            YAxisFormat.Name = "YAxisFormat";
            YAxisFormat.Size = new Size(172, 22);
            YAxisFormat.TabIndex = 3;
            YAxisFormat.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // XAxisFormat
            // 
            XAxisFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            XAxisFormat.Items.AddRange([
            "Short Date",
            "Month Day",
            "Month Year",
            "Week Day",
            "Long Date",
            "General Date/Time"]);
            XAxisFormat.Location = new Point(48, 24);
            XAxisFormat.Name = "XAxisFormat";
            XAxisFormat.Size = new Size(172, 22);
            XAxisFormat.TabIndex = 1;
            XAxisFormat.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // label7
            // 
            label7.Location = new Point(44, 100);
            label7.Name = "label7";
            label7.Size = new Size(160, 23);
            label7.TabIndex = 4;
            label7.Text = "&Series Points Labels Format:";
            // 
            // label2
            // 
            label2.Location = new Point(48, 52);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 2;
            label2.Text = "&Y Axis Labels Format:";
            // 
            // label1
            // 
            label1.Location = new Point(48, 4);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 0;
            label1.Text = "&X Axis Labels Format:";
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
            Chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            Chart1.BackSecondaryColor = System.Drawing.Color.White;
            Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            Chart1.BorderlineWidth = 2;
            Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.LabelAutoFitStyle = ((LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.LabelAutoFitStyle = ((LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisY.LabelStyle.Font = new Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
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
            Chart1.Location = new Point(16, 63);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Default";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series1.MarkerSize = 9;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.ShadowOffset = 1;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            // 
            // LabelsFormatting
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "LabelsFormatting";
            Size = new Size(728, 368);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void Combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Labels();
		}

		private void Labels()
		{
			// Populate series data
			Random		random = new Random(7259);
			DateTime	dateCurrent = DateTime.Now.Date;
			Chart1.Series["Series1"].Points.Clear();
			for(int pointIndex = 0; pointIndex < 7; pointIndex++)
			{
				Chart1.Series["Series1"].Points.AddXY(dateCurrent.AddDays(pointIndex), random.Next(2000, 9000)/100.0);
			}

			Chart1.ChartAreas["Default"].BackColor = Color.White;
			
			// Disable end labels for the X axis
			if(!IsEndLabelVisible.Checked)
			{
				Chart1.ChartAreas["Default"].AxisX.LabelStyle.IsEndLabelVisible = false;
			}
			else
			{
				Chart1.ChartAreas["Default"].AxisX.LabelStyle.IsEndLabelVisible = true;
			}

			// Set X axis labels format
			Chart1.ChartAreas["Default"].AxisX.LabelStyle.Format = GetDateItem(XAxisFormat.SelectedIndex);

			// Set Y axis labels format
			Chart1.ChartAreas["Default"].AxisY.LabelStyle.Format = GetNumItem(YAxisFormat.SelectedIndex);

			// Set series point labels format
			Chart1.Series["Series1"].LabelFormat = GetNumItem(SeriesPointFormat.SelectedIndex);

			// Set series point labels color
			Chart1.Series["Series1"].Color = Color.Navy;
		}

		private string GetDateItem( int item )
		{
			string format;
			switch( item )
			{
				case 0:
					format = "d";
					break;
				case 1:
					format = "M";
					break;
				case 2:
					format = "Y";
					break;
				case 3:
					format = "ddd,d";
					break;
				case 4:
					format = "D";
					break;
				case 5:
					format = "G";
					break;
				default: 
					format = "";
					break;
			}

			return format;
		}

		private string GetNumItem( int item )
		{
			string format;
			switch( item )
			{
				case 0:
					format = "C";
					break;
				case 1:
					format = "C0";
					break;
				case 2:
					format = "E";
					break;
				case 3:
					format = "E0";
					break;
				case 4:
					format = "P";
					break;
				case 5:
					format = "P0";
					break;
				default: 
					format = "";
					break;
			}

			return format;
		}

	}
}
