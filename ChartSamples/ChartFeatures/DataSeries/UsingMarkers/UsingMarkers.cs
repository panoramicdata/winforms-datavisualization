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
	public class UsingMarkers : UserControl
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
		private Label label15;
		private Label label1;
		private Label label2;
		private Label label10;
		private Label label11;
		private CheckBox ApplyToPoint;
		private ComboBox Shape;
		private ComboBox MarkerSize;
		private ComboBox MarkerColor;
		private ComboBox MarkerBorderColor;
		private Label label12;
		#endregion
		private NumericUpDown MarkerBorderWidth;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public UsingMarkers()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize Combo Boxes
			Shape.SelectedIndex = 0;
			MarkerSize.SelectedIndex = 0;
			MarkerColor.SelectedIndex = 0;
			MarkerBorderColor.SelectedIndex = 1;
			MarkerBorderWidth.Value = 1;
			ApplyToPoint.Checked = true;			
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
			DataPoint dataPoint1 = new DataPoint(0, 3);
			DataPoint dataPoint2 = new DataPoint(0, 7);
			DataPoint dataPoint3 = new DataPoint(0, 8);
			DataPoint dataPoint4 = new DataPoint(0, 6);
			DataPoint dataPoint5 = new DataPoint(0, 7);
			Title title1 = new Title();
            label9 = new Label();
            panel1 = new Panel();
            MarkerBorderWidth = new NumericUpDown();
            label12 = new Label();
            MarkerBorderColor = new ComboBox();
            MarkerColor = new ComboBox();
            MarkerSize = new ComboBox();
            Shape = new ComboBox();
            ApplyToPoint = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label15 = new Label();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(MarkerBorderWidth)).BeginInit();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 43);
            label9.TabIndex = 0;
            label9.Text = "This sample shows how to set marker appearance properties. Note that these proper" +
                "ties can be applied to all data points in a series or to a single data point.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(MarkerBorderWidth);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(MarkerBorderColor);
            panel1.Controls.Add(MarkerColor);
            panel1.Controls.Add(MarkerSize);
            panel1.Controls.Add(Shape);
            panel1.Controls.Add(ApplyToPoint);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(432, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 296);
            panel1.TabIndex = 2;
            // 
            // MarkerBorderWidth
            // 
            MarkerBorderWidth.Location = new Point(168, 136);
            MarkerBorderWidth.Maximum = new decimal([
            5,
            0,
            0,
            0]);
            MarkerBorderWidth.Minimum = new decimal([
            1,
            0,
            0,
            0]);
            MarkerBorderWidth.Name = "MarkerBorderWidth";
            MarkerBorderWidth.Size = new Size(72, 22);
            MarkerBorderWidth.TabIndex = 14;
            MarkerBorderWidth.Value = new decimal([
            1,
            0,
            0,
            0]);
            MarkerBorderWidth.ValueChanged += new EventHandler(MarkerBorderWidth_ValueChanged);
            // 
            // label12
            // 
            label12.Location = new Point(9, 136);
            label12.Name = "label12";
            label12.Size = new Size(156, 24);
            label12.TabIndex = 13;
            label12.Text = "Marker Border &Width:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MarkerBorderColor
            // 
            MarkerBorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MarkerBorderColor.Items.AddRange([
            "White",
            "Blue",
            "Green",
            "Yellow",
            "Magenta",
            "Brown"]);
            MarkerBorderColor.Location = new Point(168, 104);
            MarkerBorderColor.Name = "MarkerBorderColor";
            MarkerBorderColor.Size = new Size(121, 22);
            MarkerBorderColor.TabIndex = 7;
            MarkerBorderColor.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // MarkerColor
            // 
            MarkerColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MarkerColor.Items.AddRange([
            "White",
            "Blue",
            "Green",
            "Yellow",
            "Magenta",
            "Brown"]);
            MarkerColor.Location = new Point(168, 72);
            MarkerColor.Name = "MarkerColor";
            MarkerColor.Size = new Size(121, 22);
            MarkerColor.TabIndex = 5;
            MarkerColor.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // MarkerSize
            // 
            MarkerSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MarkerSize.Items.AddRange([
            "5",
            "10",
            "15",
            "20"]);
            MarkerSize.Location = new Point(168, 40);
            MarkerSize.Name = "MarkerSize";
            MarkerSize.Size = new Size(121, 22);
            MarkerSize.TabIndex = 3;
            MarkerSize.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // Shape
            // 
            Shape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Shape.Items.AddRange([
            "Circle",
            "Square",
            "Diamond",
            "Triangle",
            "Cross",
            "Image",
            "Star10",
            "Star4",
            "Star5",
            "Star6"]);
            Shape.Location = new Point(168, 8);
            Shape.Name = "Shape";
            Shape.Size = new Size(121, 22);
            Shape.TabIndex = 1;
            Shape.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // ApplyToPoint
            // 
            ApplyToPoint.Location = new Point(32, 168);
            ApplyToPoint.Name = "ApplyToPoint";
            ApplyToPoint.Size = new Size(232, 24);
            ApplyToPoint.TabIndex = 8;
            ApplyToPoint.Text = "&Apply to the Third Point Only";
            ApplyToPoint.CheckedChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // label11
            // 
            label11.Location = new Point(20, 104);
            label11.Name = "label11";
            label11.Size = new Size(144, 23);
            label11.TabIndex = 6;
            label11.Text = "Marker &Border Color:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Location = new Point(20, 72);
            label10.Name = "label10";
            label10.Size = new Size(144, 23);
            label10.TabIndex = 4;
            label10.Text = "Marker &Color:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(20, 40);
            label2.Name = "label2";
            label2.Size = new Size(144, 23);
            label2.TabIndex = 2;
            label2.Text = "Marker &Size:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(20, 8);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 0;
            label1.Text = "Marker &Shape:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            label6.TabIndex = 12;
            label6.Text = "Border Size:";
            // 
            // label5
            // 
            label5.Location = new Point(64, 380);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 11;
            label5.Text = "Border Color:";
            // 
            // label4
            // 
            label4.Location = new Point(64, 357);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 10;
            label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            label3.Location = new Point(64, 334);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 9;
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
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            Chart1.Location = new Point(16, 65);
            Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Default";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.ShadowOffset = 1;
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 306);
            Chart1.TabIndex = 1;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Using Markers";
            Chart1.Titles.Add(title1);
            Chart1.Click += new EventHandler(Chart1_Click);
            // 
            // UsingMarkers
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "UsingMarkers";
            Size = new Size(728, 384);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(MarkerBorderWidth)).EndInit();
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void Chart1_Click(object sender, EventArgs e)
		{
		
		}

		private void Marker()
		{
			if( 
				Shape.SelectedItem == null ||
				MarkerSize.SelectedItem == null ||
				MarkerColor.SelectedItem == null ||
				MarkerBorderColor.SelectedItem == null
			)
				return;

			// Using markers
			MainForm mainForm = (MainForm)ParentForm;

			if( mainForm == null )
				return;

			string fileNameString = mainForm.applicationPath + "\\Images\\Face.bmp";

			// Set Marker shape to image
			if(Shape.GetItemText(Shape.SelectedItem) == "Image")
			{
				if(!ApplyToPoint.Checked)
				{
					Chart1.Series["Default"].MarkerImage = fileNameString;
					Chart1.Series["Default"].MarkerImageTransparentColor = Color.White;

					Chart1.Series["Default"].Points[2].DeleteCustomProperty("MarkerImage");
				}
				else
				{
					// Series
					Chart1.Series["Default"].MarkerImage = "";
					
					// Point
					Chart1.Series["Default"].Points[2].MarkerImage = fileNameString;
					Chart1.Series["Default"].Points[2].MarkerImageTransparentColor = Color.White;
				}

				// Disable color and size controls
				MarkerSize.Enabled = false;
				MarkerColor.Enabled = false;
				MarkerBorderColor.Enabled = false;
				MarkerBorderWidth.Enabled = false;
			}

			// Set "bubble" series shape
			else
			{
				if(!ApplyToPoint.Checked)
				{
					// Disable images
					Chart1.Series["Default"].MarkerImage = "";

					Chart1.Series["Default"].MarkerStyle = (MarkerStyle)MarkerStyle.Parse(typeof(MarkerStyle), Shape.GetItemText(Shape.SelectedItem));

					// Disable images
					Chart1.Series["Default"].Points[2].DeleteCustomProperty("MarkerImage");

					Chart1.Series["Default"].Points[2].DeleteCustomProperty("MarkerStyle");
				}
				else
				{
					// Disable images
					Chart1.Series["Default"].MarkerImage = "";

					Chart1.Series["Default"].MarkerStyle = (MarkerStyle)MarkerStyle.Parse(typeof(MarkerStyle), "Circle");

					// Disable images
					Chart1.Series["Default"].Points[2].MarkerImage = "";

					Chart1.Series["Default"].Points[2].MarkerStyle = (MarkerStyle)MarkerStyle.Parse(typeof(MarkerStyle), Shape.GetItemText(Shape.SelectedItem));
				}
            
				// Enable color and size controls
				MarkerSize.Enabled = true;
				MarkerColor.Enabled = true;
				MarkerBorderColor.Enabled = true;
				MarkerBorderWidth.Enabled = true;
			}

            
			if(!ApplyToPoint.Checked)
			{
				Chart1.Series["Default"].MarkerSize = Int32.Parse(MarkerSize.GetItemText(MarkerSize.SelectedItem));
				Chart1.Series["Default"].MarkerColor = Color.FromName(MarkerColor.GetItemText(MarkerColor.SelectedItem));
				Chart1.Series["Default"].MarkerBorderColor = Color.FromName(MarkerBorderColor.GetItemText(MarkerBorderColor.SelectedItem));
				Chart1.Series["Default"].MarkerBorderWidth = Int32.Parse(MarkerBorderWidth.Value.ToString());

				// Point
				Chart1.Series["Default"].Points[2].DeleteCustomProperty("MarkerSize");
				Chart1.Series["Default"].Points[2].DeleteCustomProperty("MarkerColor");
				Chart1.Series["Default"].Points[2].DeleteCustomProperty("MarkerBorderColor");
								Chart1.Series["Default"].Points[2].DeleteCustomProperty("MarkerBorderWidth");
			}
			else
			{
				// Series
				Chart1.Series["Default"].MarkerSize = 5;
				Chart1.Series["Default"].MarkerColor = Color.White;
				Chart1.Series["Default"].MarkerBorderColor = Color.Blue;
				Chart1.Series["Default"].MarkerBorderWidth = 1;

				// Point
				Chart1.Series["Default"].Points[2].MarkerSize = Int32.Parse(MarkerSize.GetItemText(MarkerSize.SelectedItem));
				Chart1.Series["Default"].Points[2].MarkerColor = Color.FromName(MarkerColor.GetItemText(MarkerColor.SelectedItem));
				Chart1.Series["Default"].Points[2].MarkerBorderColor = Color.FromName(MarkerBorderColor.GetItemText(MarkerBorderColor.SelectedItem));
				Chart1.Series["Default"].Points[2].MarkerBorderWidth = Int32.Parse(MarkerBorderWidth.Value.ToString());
			}
		}

		private void Combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Marker();
		}

		private void MarkerBorderWidth_ValueChanged(object sender, EventArgs e)
		{
			Marker();		
		}

	}
}
