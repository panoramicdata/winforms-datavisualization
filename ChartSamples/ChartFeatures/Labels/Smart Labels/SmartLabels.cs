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
	/// Summary description for LabelsOverlapping.
	/// </summary>
	public class SmartLabels : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private CheckBox checkBoxPreventOverlap;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private ComboBox AllowOutsidePlotArea;
		private ComboBox CalloutLineAnchorCap;
		private ComboBox CalloutLineAnchorColor;
		private ComboBox CalloutLineAnchorWidth;
		private ComboBox CalloutStyle;
		private Label label5;
		private ComboBox NumOfPoints;
		private Label label6;
		private CheckBox Aligned;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public SmartLabels()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			FillData();

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
            labelSampleComment = new Label();
            panel1 = new Panel();
            Aligned = new CheckBox();
            NumOfPoints = new ComboBox();
            CalloutStyle = new ComboBox();
            CalloutLineAnchorWidth = new ComboBox();
            CalloutLineAnchorColor = new ComboBox();
            CalloutLineAnchorCap = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            AllowOutsidePlotArea = new ComboBox();
            checkBoxPreventOverlap = new CheckBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
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
            chart1.Location = new Point(16, 60);
            chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "P0";
            series1.Legend = "Default";
            series1.MarkerSize = 6;
            series1.Name = "Default";
            series1.ShadowOffset = 1;
            series1.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box;
            chart1.Series.Add(series1);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            chart1.Click += new EventHandler(chart1_Click);
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 14);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 36);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to use smart labels to avoid overlaps by repositioni" +
                "ng or hiding point labels.";
            // 
            // panel1
            // 
            panel1.Controls.Add(Aligned);
            panel1.Controls.Add(NumOfPoints);
            panel1.Controls.Add(CalloutStyle);
            panel1.Controls.Add(CalloutLineAnchorWidth);
            panel1.Controls.Add(CalloutLineAnchorColor);
            panel1.Controls.Add(CalloutLineAnchorCap);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AllowOutsidePlotArea);
            panel1.Controls.Add(checkBoxPreventOverlap);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(424, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 292);
            panel1.TabIndex = 0;
            // 
            // Aligned
            // 
            Aligned.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            Aligned.Location = new Point(22, 36);
            Aligned.Name = "Aligned";
            Aligned.Size = new Size(168, 24);
            Aligned.TabIndex = 1;
            Aligned.Text = "&Similar Point Values:";
            Aligned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Aligned.CheckedChanged += new EventHandler(Aligned_CheckedChanged);
            // 
            // NumOfPoints
            // 
            NumOfPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            NumOfPoints.Items.AddRange([
            "20",
            "30",
            "40",
            "50",
            "60"]);
            NumOfPoints.Location = new Point(176, 64);
            NumOfPoints.Name = "NumOfPoints";
            NumOfPoints.Size = new Size(121, 22);
            NumOfPoints.TabIndex = 3;
            NumOfPoints.SelectedIndexChanged += new EventHandler(NumOfPoints_SelectedIndexChanged);
            // 
            // CalloutStyle
            // 
            CalloutStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CalloutStyle.Items.AddRange([
            "None",
            "Box",
            "Underlined"]);
            CalloutStyle.Location = new Point(176, 200);
            CalloutStyle.Name = "CalloutStyle";
            CalloutStyle.Size = new Size(121, 22);
            CalloutStyle.TabIndex = 13;
            CalloutStyle.SelectedIndexChanged += new EventHandler(CalloutStyle_SelectedIndexChanged);
            // 
            // CalloutLineAnchorWidth
            // 
            CalloutLineAnchorWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CalloutLineAnchorWidth.Items.AddRange([
            "1",
            "2",
            "3",
            "4",
            "5"]);
            CalloutLineAnchorWidth.Location = new Point(176, 176);
            CalloutLineAnchorWidth.Name = "CalloutLineAnchorWidth";
            CalloutLineAnchorWidth.Size = new Size(121, 22);
            CalloutLineAnchorWidth.TabIndex = 11;
            CalloutLineAnchorWidth.SelectedIndexChanged += new EventHandler(CalloutLineAnchorWidth_SelectedIndexChanged);
            // 
            // CalloutLineAnchorColor
            // 
            CalloutLineAnchorColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CalloutLineAnchorColor.Items.AddRange([
            "Red",
            "Blue",
            "Green",
            "Yellow"]);
            CalloutLineAnchorColor.Location = new Point(176, 152);
            CalloutLineAnchorColor.Name = "CalloutLineAnchorColor";
            CalloutLineAnchorColor.Size = new Size(121, 22);
            CalloutLineAnchorColor.TabIndex = 9;
            CalloutLineAnchorColor.SelectedIndexChanged += new EventHandler(CalloutLineAnchorColor_SelectedIndexChanged);
            // 
            // CalloutLineAnchorCap
            // 
            CalloutLineAnchorCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CalloutLineAnchorCap.Items.AddRange([
            "None",
            "Arrow",
            "Diamond",
            "Square",
            "Round"]);
            CalloutLineAnchorCap.Location = new Point(176, 128);
            CalloutLineAnchorCap.Name = "CalloutLineAnchorCap";
            CalloutLineAnchorCap.Size = new Size(121, 22);
            CalloutLineAnchorCap.TabIndex = 7;
            CalloutLineAnchorCap.SelectedIndexChanged += new EventHandler(CalloutLineAnchorCap_SelectedIndexChanged);
            // 
            // label4
            // 
            label4.Location = new Point(3, 176);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 10;
            label4.Text = "Callout Line Anchor &Width:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(8, 154);
            label3.Name = "label3";
            label3.Size = new Size(168, 16);
            label3.TabIndex = 8;
            label3.Text = "Callout Line Anchor C&olor:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(16, 130);
            label2.Name = "label2";
            label2.Size = new Size(160, 16);
            label2.TabIndex = 6;
            label2.Text = "Callout Line Anchor &Cap:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AllowOutsidePlotArea
            // 
            AllowOutsidePlotArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            AllowOutsidePlotArea.Items.AddRange([
            "No",
            "Yes",
            "Partial"]);
            AllowOutsidePlotArea.Location = new Point(176, 96);
            AllowOutsidePlotArea.Name = "AllowOutsidePlotArea";
            AllowOutsidePlotArea.Size = new Size(121, 22);
            AllowOutsidePlotArea.TabIndex = 5;
            AllowOutsidePlotArea.SelectedIndexChanged += new EventHandler(AllowOutsidePlotArea_SelectedIndexChanged);
            // 
            // checkBoxPreventOverlap
            // 
            checkBoxPreventOverlap.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxPreventOverlap.Location = new Point(18, 8);
            checkBoxPreventOverlap.Name = "checkBoxPreventOverlap";
            checkBoxPreventOverlap.Size = new Size(172, 24);
            checkBoxPreventOverlap.TabIndex = 0;
            checkBoxPreventOverlap.Text = "&Smart Labels:";
            checkBoxPreventOverlap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxPreventOverlap.CheckedChanged += new EventHandler(checkBoxPreventOverlap_CheckedChanged);
            // 
            // label1
            // 
            label1.Location = new Point(16, 99);
            label1.Name = "label1";
            label1.Size = new Size(160, 16);
            label1.TabIndex = 4;
            label1.Text = "Allow &Outside Plot Area:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label1.Click += new EventHandler(label1_Click);
            // 
            // label5
            // 
            label5.Location = new Point(16, 202);
            label5.Name = "label5";
            label5.Size = new Size(160, 16);
            label5.TabIndex = 12;
            label5.Text = "Callout St&yle:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(16, 67);
            label6.Name = "label6";
            label6.Size = new Size(160, 16);
            label6.TabIndex = 2;
            label6.Text = "&Number of Points:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SmartLabels
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "Smart Labels";
            Size = new Size(728, 376);
            Load += new EventHandler(SmartLabels_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void checkBoxPreventOverlap_CheckedChanged(object sender, EventArgs e)
		{
			SetSmartLabels();
		}

		private void chart1_Click(object sender, EventArgs e)
		{
		
		}

		private void label1_Click(object sender, EventArgs e)
		{
		
		}

		/// <summary>
		/// Fill Data Points
		/// </summary>
		private void FillData()
		{
			// Remove all data points from collection.
			chart1.Series[0].Points.Clear();

			// Set initial number of data points.
			int numOfPoints = 50;

			// Get out from this method if all combo boxes 
			// are not initialized.
			if( NumOfPoints.Text != "" )
			{
				numOfPoints = int.Parse( NumOfPoints.Text );
			}
			
			// Initialize random nubers.
			Random rand = new Random( 2 );

			// Data points loop
			for( int index = 0; index <= numOfPoints; index++ )
			{
				// Filling algorithm for not aligned data points
				if( !Aligned.Checked )
				{
					chart1.Series[0].Points.Add( new DataPoint( 0, rand.NextDouble() * 50 ) );
				}
				// Filling algorithm for aligned data points
				else
				{
					if( index == 0 )
					{
						chart1.Series[0].Points.Add( new DataPoint( 0, rand.NextDouble() * 50 ) );
					}
					else
					{
						chart1.Series[0].Points.Add( new DataPoint( 0, chart1.Series[0].Points[index-1].YValues[0] + rand.NextDouble() * 4 - 2 ) );
					}
				}
			}
		}

		/// <summary>
		/// Initialize combo boxes
		/// </summary>
		private void SmartLabels_Load(object sender, EventArgs e)
		{
			AllowOutsidePlotArea.SelectedIndex = 0;
			CalloutLineAnchorCap.SelectedIndex = 0;
			CalloutLineAnchorColor.SelectedIndex = 0;
			CalloutLineAnchorWidth.SelectedIndex = 0;
			CalloutStyle.SelectedIndex = 0;
			NumOfPoints.SelectedIndex = 1;
		}

		/// <summary>
		/// Set values from combo boxes to the chart 
		/// smart labels properties.
		/// </summary>
		private void SetSmartLabels()
		{
			// Get out from this method if all combo boxes 
			// are not initialized.
			if( CalloutStyle.Text == "" )
			{
				return;
			}

			// Enable or disable Smart label combo boxes
			if( checkBoxPreventOverlap.Checked )
			{
				AllowOutsidePlotArea.Enabled = true;
                CalloutLineAnchorCap.Enabled = true;
				CalloutLineAnchorColor.Enabled = true;
				CalloutLineAnchorWidth.Enabled = true;
				CalloutStyle.Enabled = true;
			}
			else
			{
				AllowOutsidePlotArea.Enabled = false;
                CalloutLineAnchorCap.Enabled = false;
				CalloutLineAnchorColor.Enabled = false;
				CalloutLineAnchorWidth.Enabled = false;
				CalloutStyle.Enabled = false;
			}

			// Set values from combo boxes to the chart 
			// smart labels properties.
			chart1.Series["Default"].SmartLabelStyle.Enabled = checkBoxPreventOverlap.Checked;
			chart1.Series["Default"].SmartLabelStyle.AllowOutsidePlotArea = (LabelOutsidePlotAreaStyle) Enum.Parse( typeof(LabelOutsidePlotAreaStyle), AllowOutsidePlotArea.Text, true );
            chart1.Series["Default"].SmartLabelStyle.CalloutLineAnchorCapStyle = (LineAnchorCapStyle)Enum.Parse(typeof(LineAnchorCapStyle), CalloutLineAnchorCap.Text, true);
			chart1.Series["Default"].SmartLabelStyle.CalloutLineColor = Color.FromName( CalloutLineAnchorColor.Text );
			chart1.Series["Default"].SmartLabelStyle.CalloutLineWidth = int.Parse( CalloutLineAnchorWidth.Text );
			chart1.Series["Default"].SmartLabelStyle.CalloutStyle = (LabelCalloutStyle) Enum.Parse( typeof(LabelCalloutStyle), CalloutStyle.Text, true );
		
		}

		private void AllowOutsidePlotArea_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetSmartLabels();
		}

		private void CalloutLineAnchorCap_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetSmartLabels();
		}

		private void CalloutLineAnchorColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetSmartLabels();
		}

		private void CalloutLineAnchorWidth_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetSmartLabels();
		}

		private void CalloutStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetSmartLabels();
		}

		private void NumOfPoints_SelectedIndexChanged(object sender, EventArgs e)
		{
			FillData();
			SetSmartLabels();
		}

		private void Aligned_CheckedChanged(object sender, EventArgs e)
		{
			FillData();
			SetSmartLabels();
		}
	}
}
