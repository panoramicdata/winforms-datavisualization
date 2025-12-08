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
	/// Summary description for SmallScrollSize.
	/// </summary>
	public class SmallScrollSize : UserControl
	{
		private Chart chart1;
		private Label labelSampleComment;
		private Panel panel1;
		private Label label1;
		private ComboBox comboBoxSmallScrollSize;
		private ComboBox comboBoxSmallScrollMinSize;
		private Label label2;
		private Label label3;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public SmallScrollSize()
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(SmallScrollSize));
            chart1 = new Chart();
            labelSampleComment = new Label();
            panel1 = new Panel();
            comboBoxSmallScrollMinSize = new ComboBox();
            label2 = new Label();
            comboBoxSmallScrollSize = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            ((ISupportInitialize)(chart1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
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
            chartArea1.AxisX.ScaleView.Position = 10;
            chartArea1.AxisX.ScaleView.Size = 50;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScrollBar.Size = 12;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisY.ScrollBar.Size = 12;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.Gray;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 85F;
            chartArea1.InnerPlotPosition.Width = 84F;
            chartArea1.InnerPlotPosition.X = 14F;
            chartArea1.InnerPlotPosition.Y = 5F;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 73F;
            chartArea1.Position.Width = 90F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 11F;
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
            series1.Legend = "Default";
            series1.Name = "Default";
            chart1.Series.Add(series1);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            labelSampleComment.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSampleComment.Location = new Point(16, 14);
            labelSampleComment.Name = "labelSampleComment";
            labelSampleComment.Size = new Size(702, 43);
            labelSampleComment.TabIndex = 0;
            labelSampleComment.Text = "This sample demonstrates how to control the small scrolling size of a view, which" +
                " occurs when you click on the scrollbar arrows.";
            labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxSmallScrollMinSize);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxSmallScrollSize);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(432, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 288);
            panel1.TabIndex = 2;
            // 
            // comboBoxSmallScrollMinSize
            // 
            comboBoxSmallScrollMinSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSmallScrollMinSize.Items.AddRange([
            "1",
            "2",
            "5",
            "10"]);
            comboBoxSmallScrollMinSize.Location = new Point(168, 40);
            comboBoxSmallScrollMinSize.Name = "comboBoxSmallScrollMinSize";
            comboBoxSmallScrollMinSize.Size = new Size(112, 22);
            comboBoxSmallScrollMinSize.TabIndex = 3;
            comboBoxSmallScrollMinSize.SelectedIndexChanged += new EventHandler(comboBoxSmallScrollSize_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.Location = new Point(8, 40);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 2;
            label2.Text = "Small Scroll &Min Size:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxSmallScrollSize
            // 
            comboBoxSmallScrollSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSmallScrollSize.Items.AddRange([
            "Auto",
            "1",
            "2",
            "5",
            "10",
            "20"]);
            comboBoxSmallScrollSize.Location = new Point(168, 8);
            comboBoxSmallScrollSize.Name = "comboBoxSmallScrollSize";
            comboBoxSmallScrollSize.Size = new Size(112, 22);
            comboBoxSmallScrollSize.TabIndex = 1;
            comboBoxSmallScrollSize.SelectedIndexChanged += new EventHandler(comboBoxSmallScrollSize_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.Location = new Point(16, 8);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 0;
            label1.Text = "Small Scroll &Size:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new Point(16, 372);
            label3.Name = "label3";
            label3.Size = new Size(702, 59);
            label3.TabIndex = 3;
            label3.Text = resources.GetString("label3.Text");
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SmallScrollSize
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(labelSampleComment);
            Controls.Add(chart1);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "SmallScrollSize";
            Size = new Size(728, 456);
            Load += new EventHandler(SmallScrollSize_Load);
            ((ISupportInitialize)(chart1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void SmallScrollSize_Load(object sender, EventArgs e)
		{
			comboBoxSmallScrollSize.SelectedIndex = 0;
			comboBoxSmallScrollMinSize.SelectedIndex = 0;

			// Fill chart with random data
			Random		random = new Random();
			for(int pointIndex = 0; pointIndex < 300; pointIndex++)
			{
				chart1.Series["Default"].Points.AddY(random.Next(100, 1000));
			}
		}

		private void comboBoxSmallScrollSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Set small scroll size and Min. size
			if(comboBoxSmallScrollSize.Text == "Auto")
			{
				comboBoxSmallScrollMinSize.Enabled = true;
				chart1.ChartAreas["Default"].AxisX.ScaleView.SmallScrollSize = double.NaN;
			}
			else 
			{
				comboBoxSmallScrollMinSize.Enabled = false;
				if(comboBoxSmallScrollSize.Text != "")
				{
					chart1.ChartAreas["Default"].AxisX.ScaleView.SmallScrollSize = double.Parse(comboBoxSmallScrollSize.Text);
				}
			}

			if(comboBoxSmallScrollMinSize.Text != "")
			{
				chart1.ChartAreas["Default"].AxisX.ScaleView.SmallScrollMinSize = double.Parse(comboBoxSmallScrollMinSize.Text);
			}
		}

	}
}
