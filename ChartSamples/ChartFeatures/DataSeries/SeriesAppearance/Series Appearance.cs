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
	public class SeriesAppearance : UserControl
	{

		private System.IO.MemoryStream defaultChartView = new System.IO.MemoryStream();
		private bool initializing = true;

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
		private Label label12;
		private Label label13;
		private Label label14;
		private Label label16;
		private ComboBox ColorCom;
		private ComboBox EndColorCom;
		private ComboBox GradientCom;
		private ComboBox HatchingCom;
		private ComboBox BorderColorCom;
		private ComboBox BorderSizeCom;
		private ComboBox BorderDashStyleCom;
		private ComboBox ShadowOffset;
		private CheckBox ThirdPoint;
		private Label label17;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public SeriesAppearance()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			Chart1.Serializer.SerializableContent = "*.*";
			Chart1.Serializer.NonSerializableContent = "*.Size";

			// Add Hatch styles to control.
			foreach(string colorName in Enum.GetNames(typeof(ChartHatchStyle)))
			{
				HatchingCom.Items.Add(colorName);
			}
		
			// Add Chart Gradient types to control.
			foreach(string colorName in Enum.GetNames(typeof(GradientStyle)))
			{
				GradientCom.Items.Add(colorName);
			}

			// Add Chart Line styles to control.
			foreach(string colorName in Enum.GetNames(typeof(ChartDashStyle)))
			{
				BorderDashStyleCom.Items.Add(colorName);
			}

			HatchingCom.SelectedIndex = 0;
			GradientCom.SelectedIndex = 7;
			ColorCom.SelectedIndex = 0;
			EndColorCom.SelectedIndex = 2;
			BorderColorCom.SelectedIndex = 6;
			BorderSizeCom.SelectedIndex = 1;
			BorderDashStyleCom.SelectedIndex = 5;
			ShadowOffset.SelectedIndex = 0;
			ThirdPoint.Checked = false;

			initializing = false;
			AppearanceChange();
			
			// save current settings as default
			Chart1.Serializer.Save( defaultChartView );

		}

		private void AppearanceChange()
		{
			
			// suppress appearance settings during loading
			if ( initializing )
			{
				return;
			}

			// load default chart settings
			if ( defaultChartView.Length > 0) 
			{
				defaultChartView.Position = 0;
				Chart1.Serializer.Load( defaultChartView );
			}

			// Set Back Color
			Chart1.Series[0].Points[2].Color = Color.FromName(ColorCom.GetItemText(ColorCom.SelectedItem));

			// Set Back Gradient End Color
			Chart1.Series[0].Points[2].BackSecondaryColor = Color.FromName(EndColorCom.GetItemText(EndColorCom.SelectedItem));

			// Set Border Color
			Chart1.Series[0].Points[2].BorderColor = Color.FromName(BorderColorCom.GetItemText(BorderColorCom.SelectedItem));

			// Set Gradient Type
			if( GradientCom.SelectedItem != null )
				Chart1.Series[0].Points[2].BackGradientStyle = (GradientStyle)GradientStyle.Parse(typeof(GradientStyle), GradientCom.GetItemText(GradientCom.SelectedItem));

			// Set Gradient Type
			if( HatchingCom.SelectedItem != null )
				Chart1.Series[0].Points[2].BackHatchStyle = (ChartHatchStyle)ChartHatchStyle.Parse(typeof(ChartHatchStyle), HatchingCom.GetItemText(HatchingCom.SelectedItem));

			// Set Border Width
			if( BorderSizeCom.SelectedItem != null )
				Chart1.Series[0].Points[2].BorderWidth = int.Parse(BorderSizeCom.GetItemText(BorderSizeCom.SelectedItem));

			// Set Border Style
			if( BorderDashStyleCom.SelectedItem != null )
				Chart1.Series[0].Points[2].BorderDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), BorderDashStyleCom.GetItemText(BorderDashStyleCom.SelectedItem));

			if( !ThirdPoint.Checked )
			{
				
				// Set Back Color
				Chart1.Series[0].Color = Color.FromName(ColorCom.GetItemText(ColorCom.SelectedItem));

				// Set Back Gradient End Color
				Chart1.Series[0].BackSecondaryColor = Color.FromName(EndColorCom.GetItemText(EndColorCom.SelectedItem));

				// Set Border Color
				Chart1.Series[0].BorderColor = Color.FromName(BorderColorCom.GetItemText(BorderColorCom.SelectedItem));

				// Set Gradient Type
				if( GradientCom.SelectedItem != null )
					Chart1.Series[0].BackGradientStyle = (GradientStyle)GradientStyle.Parse(typeof(GradientStyle), GradientCom.GetItemText(GradientCom.SelectedItem));

				// Set Gradient Type
				if( HatchingCom.SelectedItem != null )
					Chart1.Series[0].BackHatchStyle = (ChartHatchStyle)ChartHatchStyle.Parse(typeof(ChartHatchStyle), HatchingCom.GetItemText(HatchingCom.SelectedItem));

				// Set Border Width
				if( BorderSizeCom.SelectedItem != null )
					Chart1.Series[0].BorderWidth = int.Parse(BorderSizeCom.GetItemText(BorderSizeCom.SelectedItem));

				// Set Border Style
				if( BorderDashStyleCom.SelectedItem != null )
					Chart1.Series[0].BorderDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), BorderDashStyleCom.GetItemText(BorderDashStyleCom.SelectedItem));

				// Set Shadow Offset
				if( ShadowOffset.SelectedItem != null )
					Chart1.Series[0].ShadowOffset = int.Parse(ShadowOffset.GetItemText(ShadowOffset.SelectedItem));
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
			DataPoint dataPoint1 = new DataPoint(0, 3);
			DataPoint dataPoint2 = new DataPoint(0, 7);
			DataPoint dataPoint3 = new DataPoint(0, 8);
			DataPoint dataPoint4 = new DataPoint(0, 6);
			DataPoint dataPoint5 = new DataPoint(0, 7);
			Title title1 = new Title();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(SeriesAppearance));
            label9 = new Label();
            panel1 = new Panel();
            ThirdPoint = new CheckBox();
            ShadowOffset = new ComboBox();
            BorderDashStyleCom = new ComboBox();
            BorderSizeCom = new ComboBox();
            BorderColorCom = new ComboBox();
            HatchingCom = new ComboBox();
            GradientCom = new ComboBox();
            EndColorCom = new ComboBox();
            ColorCom = new ComboBox();
            label16 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
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
            label17 = new Label();
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
            label9.Text = "This sample demonstrates how to set the visual appearance of a series.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(ThirdPoint);
            panel1.Controls.Add(ShadowOffset);
            panel1.Controls.Add(BorderDashStyleCom);
            panel1.Controls.Add(BorderSizeCom);
            panel1.Controls.Add(BorderColorCom);
            panel1.Controls.Add(HatchingCom);
            panel1.Controls.Add(GradientCom);
            panel1.Controls.Add(EndColorCom);
            panel1.Controls.Add(ColorCom);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
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
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 300);
            panel1.TabIndex = 2;
            // 
            // ThirdPoint
            // 
            ThirdPoint.Location = new Point(68, 232);
            ThirdPoint.Name = "ThirdPoint";
            ThirdPoint.Size = new Size(220, 32);
            ThirdPoint.TabIndex = 16;
            ThirdPoint.Text = "&Apply to the Third  Point Only";
            ThirdPoint.CheckedChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // ShadowOffset
            // 
            ShadowOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ShadowOffset.Items.AddRange([
            "0",
            "1",
            "2",
            "3",
            "4"]);
            ShadowOffset.Location = new Point(168, 192);
            ShadowOffset.Name = "ShadowOffset";
            ShadowOffset.Size = new Size(121, 22);
            ShadowOffset.TabIndex = 15;
            ShadowOffset.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // BorderDashStyleCom
            // 
            BorderDashStyleCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BorderDashStyleCom.Location = new Point(168, 168);
            BorderDashStyleCom.Name = "BorderDashStyleCom";
            BorderDashStyleCom.Size = new Size(121, 22);
            BorderDashStyleCom.TabIndex = 13;
            BorderDashStyleCom.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // BorderSizeCom
            // 
            BorderSizeCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BorderSizeCom.Items.AddRange([
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"]);
            BorderSizeCom.Location = new Point(168, 144);
            BorderSizeCom.Name = "BorderSizeCom";
            BorderSizeCom.Size = new Size(121, 22);
            BorderSizeCom.TabIndex = 11;
            BorderSizeCom.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // BorderColorCom
            // 
            BorderColorCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BorderColorCom.Items.AddRange([
            "MediumSeaGreen",
            "Blue",
            "White",
            "Red",
            "Yellow",
            "Green",
            "Gray"]);
            BorderColorCom.Location = new Point(168, 120);
            BorderColorCom.Name = "BorderColorCom";
            BorderColorCom.Size = new Size(121, 22);
            BorderColorCom.TabIndex = 9;
            BorderColorCom.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // HatchingCom
            // 
            HatchingCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            HatchingCom.Location = new Point(168, 80);
            HatchingCom.Name = "HatchingCom";
            HatchingCom.Size = new Size(121, 22);
            HatchingCom.TabIndex = 7;
            HatchingCom.SelectedIndexChanged += new EventHandler(HatchingCom_SelectedIndexChanged);
            // 
            // GradientCom
            // 
            GradientCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            GradientCom.Location = new Point(168, 55);
            GradientCom.Name = "GradientCom";
            GradientCom.Size = new Size(121, 22);
            GradientCom.TabIndex = 5;
            GradientCom.SelectedIndexChanged += new EventHandler(GradientCom_SelectedIndexChanged);
            // 
            // EndColorCom
            // 
            EndColorCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            EndColorCom.Items.AddRange([
            "Tomato",
            "Navy",
            "SkyBlue"]);
            EndColorCom.Location = new Point(168, 29);
            EndColorCom.Name = "EndColorCom";
            EndColorCom.Size = new Size(121, 22);
            EndColorCom.TabIndex = 3;
            EndColorCom.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // ColorCom
            // 
            ColorCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ColorCom.Items.AddRange([
            "RoyalBlue",
            "Red",
            "Brown"]);
            ColorCom.Location = new Point(168, 4);
            ColorCom.Name = "ColorCom";
            ColorCom.Size = new Size(121, 22);
            ColorCom.TabIndex = 1;
            ColorCom.SelectedIndexChanged += new EventHandler(Combo_SelectedIndexChanged);
            // 
            // label16
            // 
            label16.Location = new Point(26, 80);
            label16.Name = "label16";
            label16.Size = new Size(140, 23);
            label16.TabIndex = 6;
            label16.Text = "&Hatching:";
            label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.Location = new Point(28, 192);
            label14.Name = "label14";
            label14.Size = new Size(136, 21);
            label14.TabIndex = 14;
            label14.Text = "Shadow &Offset:";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.Location = new Point(26, 168);
            label13.Name = "label13";
            label13.Size = new Size(138, 23);
            label13.TabIndex = 12;
            label13.Text = "Border St&yle:";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.Location = new Point(26, 144);
            label12.Name = "label12";
            label12.Size = new Size(138, 23);
            label12.TabIndex = 10;
            label12.Text = "Border &Size:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label12.Click += new EventHandler(label12_Click);
            // 
            // label11
            // 
            label11.Location = new Point(26, 120);
            label11.Name = "label11";
            label11.Size = new Size(138, 23);
            label11.TabIndex = 8;
            label11.Text = "&Border Color:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Location = new Point(26, 55);
            label10.Name = "label10";
            label10.Size = new Size(138, 23);
            label10.TabIndex = 4;
            label10.Text = "&Gradient:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(26, 29);
            label2.Name = "label2";
            label2.Size = new Size(138, 23);
            label2.TabIndex = 2;
            label2.Text = "&End Color:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(26, 4);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 0;
            label1.Text = "&Color:";
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
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 306);
            Chart1.TabIndex = 1;
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Chart Control for .NET Framework";
            Chart1.Titles.Add(title1);
            // 
            // label17
            // 
            label17.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label17.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.Location = new Point(16, 372);
            label17.Name = "label17";
            label17.Size = new Size(702, 60);
            label17.TabIndex = 20;
            label17.Text = resources.GetString("label17.Text");
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SeriesAppearance
            // 
            Controls.Add(label17);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "SeriesAppearance";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void Combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			AppearanceChange();		
		}

		private void HatchingCom_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Disable fore color control if gradient or hatching are not used
			if( HatchingCom.SelectedIndex != 0 )
			{
				GradientCom.Enabled = false;
				EndColorCom.Enabled = true;
			}
			else
			{
				GradientCom.Enabled = true;
				if( GradientCom.SelectedIndex != 0 )
					EndColorCom.Enabled = true;
				else
					EndColorCom.Enabled = false;
			}

			AppearanceChange();	
		}

		private void GradientCom_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Disable fore color control if gradient or hatching are not used
			if( GradientCom.SelectedIndex != 0 )
			{
				EndColorCom.Enabled = true;
			}
			else
			{
				EndColorCom.Enabled = false;
			}

			AppearanceChange();	
		
		}

		private void label12_Click(object sender, EventArgs e)
		{
		
		}

	}
}
