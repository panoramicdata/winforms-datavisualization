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
	/// Summary description for PrimarySecondaryAxis.
	/// </summary>
	public class PrimarySecondaryAxis : UserControl
	{
		private Label label6;
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private ComboBox Criterion;
		private CheckBox SecondaryYCheck;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public PrimarySecondaryAxis()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			Criterion.SelectedIndex = 0;	

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
			DataPoint dataPoint1 = new DataPoint(0, 5400);
			DataPoint dataPoint2 = new DataPoint(0, 3200);
			DataPoint dataPoint3 = new DataPoint(0, 2700);
			Title title1 = new Title();
            Criterion = new ComboBox();
            label6 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            SecondaryYCheck = new CheckBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // Criterion
            // 
            Criterion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Criterion.Items.AddRange([
            "Range",
            "Max. Weight",
            "Wing Span",
            "Passengers"]);
            Criterion.Location = new Point(168, 2);
            Criterion.Name = "Criterion";
            Criterion.Size = new Size(121, 22);
            Criterion.TabIndex = 1;
            Criterion.SelectedIndexChanged += new EventHandler(ControlChange);
            // 
            // label6
            // 
            label6.Location = new Point(29, 5);
            label6.Name = "label6";
            label6.Size = new Size(136, 16);
            label6.TabIndex = 0;
            label6.Text = "Aircraft &Data:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to use two different scales for the primary and seco" +
                "ndary Y axes.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(SecondaryYCheck);
            panel1.Controls.Add(Criterion);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(432, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // SecondaryYCheck
            // 
            SecondaryYCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            SecondaryYCheck.Checked = true;
            SecondaryYCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            SecondaryYCheck.Location = new Point(18, 30);
            SecondaryYCheck.Name = "SecondaryYCheck";
            SecondaryYCheck.Size = new Size(164, 24);
            SecondaryYCheck.TabIndex = 2;
            SecondaryYCheck.Text = "Secondary &Y Axis:";
            SecondaryYCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            SecondaryYCheck.CheckedChanged += new EventHandler(ControlChange);
            // 
            // Chart1
            // 
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.TitleFont = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX2.IsLabelAutoFit = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.TitleFont = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.TitleFont = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.TitleFont = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
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
            Chart1.Location = new Point(16, 56);
            Chart1.Name = "Chart1";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Default";
            series1.Name = "Default";
            dataPoint1.AxisLabel = "Plane 1";
            dataPoint1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            dataPoint1.BorderWidth = 2;
            dataPoint2.AxisLabel = "Plane 2";
            dataPoint2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            dataPoint2.BorderWidth = 2;
            dataPoint3.AxisLabel = "Plane 3";
            dataPoint3.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            dataPoint3.BorderWidth = 2;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 360);
            Chart1.TabIndex = 1;
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Aircraft";
            Chart1.Titles.Add(title1);
            // 
            // PrimarySecondaryAxis
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "PrimarySecondaryAxis";
            Size = new Size(728, 432);
            //this.Load += new System.EventHandler(this.PrimarySecondaryAxis_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


/*		private void PrimarySecondaryAxis_Load(object sender, System.EventArgs e)
		{ 
			MainForm mainForm = (MainForm)this.ParentForm;
            Chart1.Series["Default"].Points[0].BackImage = mainForm.CurrentSamplePath + "\\a.png";
			Chart1.Series["Default"].Points[1].BackImage = mainForm.CurrentSamplePath + "\\b2.png";
			Chart1.Series["Default"].Points[2].BackImage = mainForm.CurrentSamplePath + "\\b1.png";
		
		}
*/
		private void ControlChange(object sender, EventArgs e)
		{
			string strSelection = "Range";
			if(Criterion.SelectedIndex >= 0)
			{
				strSelection = Criterion.SelectedItem.ToString();
			}

			// Enable secondary Y axis
			if( SecondaryYCheck.Checked )
				Chart1.ChartAreas["Default"].AxisY2.Enabled = AxisEnabled.True;
			else
				Chart1.ChartAreas["Default"].AxisY2.Enabled = AxisEnabled.False;

			// Set a characteristic of a plane.
			switch( strSelection )
			{
					// Aircraft range
				case "Range":
					// Set Y values
					Chart1.Series["Default"].Points[2].YValues[0] = 5955;
					Chart1.Series["Default"].Points[1].YValues[0] = 7260;
					Chart1.Series["Default"].Points[0].YValues[0] = 8000;

					// Set maximum values for Y axes.
					Chart1.ChartAreas["Default"].AxisY.Maximum = 12000;
					Chart1.ChartAreas["Default"].AxisY2.Maximum = 22224;

					// Set titles for Y axes
					Chart1.ChartAreas["Default"].AxisY.Title = "In Nautical miles";
					Chart1.ChartAreas["Default"].AxisY2.Title = "In Kilometers";

					break;
					// The number of passengers.
				case "Passengers":
					// Set Y values
					Chart1.Series["Default"].Points[2].YValues[0] = 368;
					Chart1.Series["Default"].Points[1].YValues[0] = 416;
					Chart1.Series["Default"].Points[0].YValues[0] = 555;

					// Set maximum values for Y axes.
					Chart1.ChartAreas["Default"].AxisY.Maximum = 800;
					Chart1.ChartAreas["Default"].AxisY2.Maximum = 800;

					// Set titles for Y axes
					Chart1.ChartAreas["Default"].AxisY.Title = "";
					Chart1.ChartAreas["Default"].AxisY2.Title = "";

					break;
					// The maximum take of weight.
				case "Max. Weight":
					// Set Y values
					Chart1.Series["Default"].Points[2].YValues[0] = 660;
					Chart1.Series["Default"].Points[1].YValues[0] = 875;
					Chart1.Series["Default"].Points[0].YValues[0] = 1235;

					// Set maximum values for Y axes.
					Chart1.ChartAreas["Default"].AxisY.Maximum = 1500;
					Chart1.ChartAreas["Default"].AxisY2.Maximum = 680;

					// Set titles for Y axes
					Chart1.ChartAreas["Default"].AxisY.Title = "In lb x 1000";
					Chart1.ChartAreas["Default"].AxisY2.Title = "In Tones";

					break;
					// The wing span
				case "Wing Span":
					// Set Y values
					Chart1.Series["Default"].Points[2].YValues[0] = 199;
					Chart1.Series["Default"].Points[1].YValues[0] = 211;
					Chart1.Series["Default"].Points[0].YValues[0] = 261;

					// Set maximum values for Y axes.
					Chart1.ChartAreas["Default"].AxisY.Maximum = 400;
					Chart1.ChartAreas["Default"].AxisY2.Maximum = 121.8;

					// Set titles for Y axes
					Chart1.ChartAreas["Default"].AxisY.Title = "In ft";
					Chart1.ChartAreas["Default"].AxisY2.Title = "In meters";

					break;
			}

		}


	}
}
