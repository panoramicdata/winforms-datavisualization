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
	/// Summary description for CursorAppearance.
	/// </summary>
	public class CursorAppearance : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label10;
		private Label label12;
		private Label label1;
		private ComboBox SelectionColor;
		private Label label2;
		private Label label11;
		private ComboBox XLineDashStyle;
		private ComboBox XLineSize;
		private ComboBox XLineColor;
		private ComboBox YLineDashStyle;
		private ComboBox YLineSize;
		private ComboBox YLineColor;
		private Label label3;
		private Label label4;
		private Label label5;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public CursorAppearance()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
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
            YLineDashStyle = new ComboBox();
            YLineSize = new ComboBox();
            YLineColor = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SelectionColor = new ComboBox();
            label2 = new Label();
            XLineDashStyle = new ComboBox();
            XLineSize = new ComboBox();
            XLineColor = new ComboBox();
            label1 = new Label();
            label10 = new Label();
            label12 = new Label();
            Chart1 = new Chart();
            label11 = new Label();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 34);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to set the appearance properties of axis cursors.";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(YLineDashStyle);
            panel1.Controls.Add(YLineSize);
            panel1.Controls.Add(YLineColor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(SelectionColor);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(XLineDashStyle);
            panel1.Controls.Add(XLineSize);
            panel1.Controls.Add(XLineColor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 0;
            // 
            // YLineDashStyle
            // 
            YLineDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            YLineDashStyle.Location = new Point(168, 184);
            YLineDashStyle.Name = "YLineDashStyle";
            YLineDashStyle.Size = new Size(120, 22);
            YLineDashStyle.TabIndex = 16;
            YLineDashStyle.SelectedIndexChanged += new EventHandler(YControl_SelectedIndexChanged);
            // 
            // YLineSize
            // 
            YLineSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            YLineSize.Items.AddRange([
            "1",
            "2",
            "3",
            "4",
            "5"]);
            YLineSize.Location = new Point(168, 152);
            YLineSize.Name = "YLineSize";
            YLineSize.Size = new Size(120, 22);
            YLineSize.TabIndex = 14;
            YLineSize.SelectedIndexChanged += new EventHandler(YControl_SelectedIndexChanged);
            // 
            // YLineColor
            // 
            YLineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            YLineColor.Items.AddRange([
            ""]);
            YLineColor.Location = new Point(168, 120);
            YLineColor.Name = "YLineColor";
            YLineColor.Size = new Size(120, 22);
            YLineColor.TabIndex = 12;
            YLineColor.SelectedIndexChanged += new EventHandler(YControl_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(24, 184);
            label3.Name = "label3";
            label3.Size = new Size(144, 24);
            label3.TabIndex = 15;
            label3.Text = "Y Cursor Line Sty&le:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(24, 152);
            label4.Name = "label4";
            label4.Size = new Size(144, 24);
            label4.TabIndex = 13;
            label4.Text = "Y Cursor Line S&ize:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(24, 120);
            label5.Name = "label5";
            label5.Size = new Size(144, 24);
            label5.TabIndex = 11;
            label5.Text = "Y Cursor Line C&olor:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SelectionColor
            // 
            SelectionColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SelectionColor.Items.AddRange([
            ""]);
            SelectionColor.Location = new Point(168, 232);
            SelectionColor.Name = "SelectionColor";
            SelectionColor.Size = new Size(120, 22);
            SelectionColor.TabIndex = 10;
            SelectionColor.SelectedIndexChanged += new EventHandler(SelectionColor_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(24, 232);
            label2.Name = "label2";
            label2.Size = new Size(144, 24);
            label2.TabIndex = 9;
            label2.Text = "Selection C&olor:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // XLineDashStyle
            // 
            XLineDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            XLineDashStyle.Location = new Point(168, 72);
            XLineDashStyle.Name = "XLineDashStyle";
            XLineDashStyle.Size = new Size(120, 22);
            XLineDashStyle.TabIndex = 7;
            XLineDashStyle.SelectedIndexChanged += new EventHandler(XControl_SelectedIndexChanged);
            // 
            // XLineSize
            // 
            XLineSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            XLineSize.Items.AddRange([
            "1",
            "2",
            "3",
            "4",
            "5"]);
            XLineSize.Location = new Point(168, 40);
            XLineSize.Name = "XLineSize";
            XLineSize.Size = new Size(120, 22);
            XLineSize.TabIndex = 5;
            XLineSize.SelectedIndexChanged += new EventHandler(XControl_SelectedIndexChanged);
            // 
            // XLineColor
            // 
            XLineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            XLineColor.Items.AddRange([
            ""]);
            XLineColor.Location = new Point(168, 8);
            XLineColor.Name = "XLineColor";
            XLineColor.Size = new Size(120, 22);
            XLineColor.TabIndex = 3;
            XLineColor.SelectedIndexChanged += new EventHandler(XControl_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(24, 72);
            label1.Name = "label1";
            label1.Size = new Size(144, 24);
            label1.TabIndex = 6;
            label1.Text = "X Cursor Line St&yle:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Location = new Point(24, 40);
            label10.Name = "label10";
            label10.Size = new Size(144, 24);
            label10.TabIndex = 4;
            label10.Text = "X Cursor Line &Size:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.Location = new Point(24, 8);
            label12.Name = "label12";
            label12.Size = new Size(144, 24);
            label12.TabIndex = 2;
            label12.Text = "X Cursor Line &Color:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Chart1
            // 
            Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
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
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.AliceBlue;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.ScrollBar.BackColor = System.Drawing.Color.AliceBlue;
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.SelectionColor = System.Drawing.SystemColors.Highlight;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.CursorY.SelectionColor = System.Drawing.SystemColors.Highlight;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 75F;
            chartArea1.InnerPlotPosition.Width = 86.32634F;
            chartArea1.InnerPlotPosition.X = 11.21863F;
            chartArea1.InnerPlotPosition.Y = 3.96004F;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 85F;
            chartArea1.Position.Width = 81.46518F;
            chartArea1.Position.X = 9.267409F;
            chartArea1.Position.Y = 10F;
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
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.ShadowOffset = 1;
            Chart1.Series.Add(series1);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            // 
            // label11
            // 
            label11.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            label11.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new Point(24, 352);
            label11.Name = "label11";
            label11.Size = new Size(702, 48);
            label11.TabIndex = 3;
            label11.Text = "Each axis has its own associated cursor. If selection is enabled, the user can se" +
                "lect and zoom in on the data view by left-clicking and dragging the mouse.";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CursorAppearance
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label11);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "CursorAppearance";
            Size = new Size(728, 427);
            Load += new EventHandler(CursorAppearance_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void CursorAppearance_Load(object sender, EventArgs e)
		{
			
			foreach(string lineName in Enum.GetNames(typeof(ChartDashStyle)))
			{
				XLineDashStyle.Items.Add(lineName);
				YLineDashStyle.Items.Add(lineName);
			}
			XLineDashStyle.SelectedIndex = 5;
			YLineDashStyle.SelectedIndex = 5;

			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				XLineColor.Items.Add(colorName);
				YLineColor.Items.Add(colorName);
				SelectionColor.Items.Add(colorName);
			}
			
			XLineSize.SelectedIndex = 0;
			XLineColor.SelectedIndex = XLineColor.Items.IndexOf("Black");

			YLineSize.SelectedIndex = 0;
			YLineColor.SelectedIndex = XLineColor.Items.IndexOf("Black");
			

			SelectionColor.SelectedIndex = XLineColor.Items.IndexOf("Highlight");

            Axis axisX = Chart1.ChartAreas["Default"].AxisX;

            CustomLabel label = null;

            label = axisX.CustomLabels.Add(Math.PI - Math.PI / 5, Math.PI + Math.PI / 5, "pi");
			label.GridTicks = GridTickTypes.All;

            label = axisX.CustomLabels.Add(2 * Math.PI - Math.PI / 5, 2 * Math.PI + Math.PI / 5, "2pi");
            label.GridTicks = GridTickTypes.All;

            label = axisX.CustomLabels.Add(3 * Math.PI - Math.PI / 5, 3 * Math.PI + Math.PI / 5, "3pi");
            label.GridTicks = GridTickTypes.All;


			double t;
			for(t = 0; t <= (7 * Math.PI / 2); t += Math.PI/6)
			{
				double ch1 = Math.Sin(t);
				Chart1.Series["Default"].Points.AddXY(t, ch1);
			}

			Chart1.ChartAreas["Default"].CursorX.Position = Math.PI / 2;
			Chart1.ChartAreas["Default"].CursorY.Position = -1.0;


		}
		


		private void XControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			System.Windows.Forms.DataVisualization.Charting.Cursor cursor = Chart1.ChartAreas["Default"].CursorX;
		
			if(XLineSize.SelectedIndex >= 0)
			{
				cursor.LineWidth = int.Parse(XLineSize.SelectedItem.ToString());
			}
			if(XLineDashStyle.SelectedIndex >= 0)
			{
				cursor.LineDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), XLineDashStyle.SelectedItem.ToString());
			}
			if(XLineColor.SelectedIndex >= 0)
			{
				cursor.LineColor = Color.FromName(XLineColor.SelectedItem.ToString());
			}
		}

		private void YControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			System.Windows.Forms.DataVisualization.Charting.Cursor cursor = Chart1.ChartAreas["Default"].CursorY;
		
			if(YLineSize.SelectedIndex >= 0)
			{
				cursor.LineWidth = int.Parse(YLineSize.SelectedItem.ToString());
			}
			if(YLineDashStyle.SelectedIndex >= 0)
			{
				cursor.LineDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), YLineDashStyle.SelectedItem.ToString());
			}
			if(YLineColor.SelectedIndex >= 0)
			{
				cursor.LineColor = Color.FromName(YLineColor.SelectedItem.ToString());
			}
		}

		private void SelectionColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(SelectionColor.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].CursorX.SelectionColor = Color.FromName(SelectionColor.SelectedItem.ToString());	
				Chart1.ChartAreas["Default"].CursorY.SelectionColor = Color.FromName(SelectionColor.SelectedItem.ToString());	
			}
		
		}

	
	}
}
