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
	/// Summary description for Title.
	/// </summary>
	public class MultipleTitles : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private Label label2;
		private Label label3;
		private ComboBox Alignment;
		private ComboBox Docking;
		private CheckBox IsDockedInsideChartArea;
		private bool initialized = false;
		private CheckBox checkBoxDockToChartArea;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public MultipleTitles()
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
			CustomLabel customLabel1 = new CustomLabel();
			CustomLabel customLabel2 = new CustomLabel();
			CustomLabel customLabel3 = new CustomLabel();
			CustomLabel customLabel4 = new CustomLabel();
			Legend legend1 = new Legend();
			Legend legend2 = new Legend();
			Legend legend3 = new Legend();
			LegendItem legendItem1 = new LegendItem();
			LegendItem legendItem2 = new LegendItem();
			LegendItem legendItem3 = new LegendItem();
			Series series1 = new Series();
			DataPoint dataPoint1 = new DataPoint(1, 70);
			DataPoint dataPoint2 = new DataPoint(2, 80);
			DataPoint dataPoint3 = new DataPoint(3, 70);
			DataPoint dataPoint4 = new DataPoint(4, 85);
			Series series2 = new Series();
			DataPoint dataPoint5 = new DataPoint(1, 65);
			DataPoint dataPoint6 = new DataPoint(2, 70);
			DataPoint dataPoint7 = new DataPoint(3, 60);
			DataPoint dataPoint8 = new DataPoint(4, 75);
			Series series3 = new Series();
			DataPoint dataPoint9 = new DataPoint(1, 50);
			DataPoint dataPoint10 = new DataPoint(2, 55);
			DataPoint dataPoint11 = new DataPoint(3, 40);
			DataPoint dataPoint12 = new DataPoint(4, 70);
			Title title1 = new Title();
			Title title2 = new Title();
			Title title3 = new Title();
            label9 = new Label();
            panel1 = new Panel();
            checkBoxDockToChartArea = new CheckBox();
            Docking = new ComboBox();
            Alignment = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            IsDockedInsideChartArea = new CheckBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 43);
            label9.TabIndex = 1;
            label9.Text = "This sample shows how to add multiple titles and how to dock titles to the chart " +
                "area. Try changing the alignment and docking of the \"SIDEBAR\" title using contro" +
                "ls below. ";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxDockToChartArea);
            panel1.Controls.Add(Docking);
            panel1.Controls.Add(Alignment);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(IsDockedInsideChartArea);
            panel1.Location = new Point(432, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 296);
            panel1.TabIndex = 1;
            // 
            // checkBoxDockToChartArea
            // 
            checkBoxDockToChartArea.Location = new Point(15, 72);
            checkBoxDockToChartArea.Name = "checkBoxDockToChartArea";
            checkBoxDockToChartArea.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            checkBoxDockToChartArea.Size = new Size(168, 22);
            checkBoxDockToChartArea.TabIndex = 5;
            checkBoxDockToChartArea.Text = "Dock to &Chart Area";
            checkBoxDockToChartArea.CheckedChanged += new EventHandler(checkBoxDockToChartArea_CheckedChanged);
            // 
            // Docking
            // 
            Docking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Docking.Location = new Point(168, 40);
            Docking.Name = "Docking";
            Docking.Size = new Size(121, 22);
            Docking.TabIndex = 4;
            Docking.SelectedIndexChanged += new EventHandler(Docking_SelectedIndexChanged);
            // 
            // Alignment
            // 
            Alignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Alignment.Location = new Point(168, 8);
            Alignment.Name = "Alignment";
            Alignment.Size = new Size(121, 22);
            Alignment.TabIndex = 2;
            Alignment.SelectedIndexChanged += new EventHandler(Docking_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Location = new Point(12, 40);
            label3.Name = "label3";
            label3.Size = new Size(152, 22);
            label3.TabIndex = 3;
            label3.Text = "&Docking:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(152, 22);
            label2.TabIndex = 1;
            label2.Text = "&Alignment:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IsDockedInsideChartArea
            // 
            IsDockedInsideChartArea.Checked = true;
            IsDockedInsideChartArea.CheckState = System.Windows.Forms.CheckState.Checked;
            IsDockedInsideChartArea.Enabled = false;
            IsDockedInsideChartArea.Location = new Point(15, 104);
            IsDockedInsideChartArea.Name = "IsDockedInsideChartArea";
            IsDockedInsideChartArea.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            IsDockedInsideChartArea.Size = new Size(168, 22);
            IsDockedInsideChartArea.TabIndex = 0;
            IsDockedInsideChartArea.Text = "Dock &Inside Chart Area";
            IsDockedInsideChartArea.Click += new EventHandler(IsDockedInsideChartArea_Click);
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
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 5;
            chartArea1.Area3DStyle.WallWidth = 0;
            customLabel1.FromPosition = 0.5;
            customLabel1.Text = "John";
            customLabel1.ToPosition = 1.5;
            customLabel2.FromPosition = 1.5;
            customLabel2.Text = "Mary";
            customLabel2.ToPosition = 2.5;
            customLabel3.FromPosition = 2.5;
            customLabel3.Text = "Jeff";
            customLabel3.ToPosition = 3.5;
            customLabel4.FromPosition = 3.5;
            customLabel4.Text = "Bob";
            customLabel4.ToPosition = 4.5;
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.CustomLabels.Add(customLabel2);
            chartArea1.AxisX.CustomLabels.Add(customLabel3);
            chartArea1.AxisX.CustomLabels.Add(customLabel4);
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F);
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
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Enabled = false;
            legend2.Name = "Legend2";
            legend3.BackColor = System.Drawing.Color.Transparent;
            legendItem1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            legendItem1.Name = "Previous Month Avg";
            legendItem2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            legendItem2.Name = "Last Week";
            legendItem3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            legendItem3.Name = "This Week";
            legend3.CustomItems.Add(legendItem1);
            legend3.CustomItems.Add(legendItem2);
            legend3.CustomItems.Add(legendItem3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Enabled = false;
            legend3.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend3.IsTextAutoFit = false;
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend3.Name = "Legend3";
            Chart1.Legends.Add(legend1);
            Chart1.Legends.Add(legend2);
            Chart1.Legends.Add(legend3);
            Chart1.Location = new Point(16, 60);
            Chart1.Name = "Chart1";
            Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.Legend = "Default";
            series1.LegendText = "Total";
            series1.Name = "Series2";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Default";
            series2.LegendText = "Sales";
            series2.Name = "Series3";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.CustomProperties = "DrawingStyle=Cylinder";
            series3.Legend = "Default";
            series3.LegendText = "Clients";
            series3.Name = "Series4";
            series3.Points.Add(dataPoint9);
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 2;
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Chart Control for .NET Framework";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title2.Name = "Title2";
            title2.ShadowOffset = -1;
            title2.Text = "SIDEBAR";
            title3.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title3";
            title3.Text = "© Microsoft Corporation";
            Chart1.Titles.Add(title1);
            Chart1.Titles.Add(title2);
            Chart1.Titles.Add(title3);
            // 
            // MultipleTitles
            // 
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "MultipleTitles";
            Size = new Size(728, 480);
            Load += new EventHandler(MultipleTitles_Load);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void MultipleTitles_Load(object sender, EventArgs e)
		{
		
			Alignment.Items.Add( "Near" );
			Alignment.Items.Add( "Center" );
			Alignment.Items.Add( "Far" );
				

			Alignment.SelectedIndex = 1;

			foreach( string docking in Enum.GetNames(typeof(Docking)))
			{
				Docking.Items.Add( docking );
			}

			Docking.SelectedIndex = 3;

			initialized = true;
		}
	

		private void DockOffset_Leave(object sender, EventArgs e)
		{
			TitleChanged();
		}

		private void IsDockedInsideChartArea_Click(object sender, EventArgs e)
		{
			TitleChanged();
		}
	
		private void TitleChanged()
		{
			if( !initialized )
			{
				return;
			}

			if( Alignment.SelectedItem.ToString() == "Near" )
			{
				Chart1.Titles[1].Alignment = ContentAlignment.MiddleLeft;
			}
			else if( Alignment.SelectedItem.ToString() == "Far" )
			{
				Chart1.Titles[1].Alignment = ContentAlignment.MiddleRight;
			}
			else
			{
				Chart1.Titles[1].Alignment = ContentAlignment.MiddleCenter;
			}

			// Change Docking
			string docking = (string)(Docking.SelectedItem.ToString());
			Chart1.Titles[1].Docking = (Docking)Enum.Parse( typeof(Docking), docking );

			// Change Dock inside chart area 
			Chart1.Titles[1].IsDockedInsideChartArea = IsDockedInsideChartArea.Checked;

			// Change Dock to chart area
			Chart1.Titles[1].DockedToChartArea = (checkBoxDockToChartArea.Checked) ? "Default" : "";
			
			// Enable or disable Dock Inside chart area.
			IsDockedInsideChartArea.Enabled = checkBoxDockToChartArea.Checked;
		}

		private void Docking_SelectedIndexChanged(object sender, EventArgs e)
		{
			TitleChanged();
		}

		private void checkBoxDockToChartArea_CheckedChanged(object sender, EventArgs e)
		{
			TitleChanged();
		}
	}
}
