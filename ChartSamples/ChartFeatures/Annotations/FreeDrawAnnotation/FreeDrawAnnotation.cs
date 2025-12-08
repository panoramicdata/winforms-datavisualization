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
	/// Summary description for AnnotationAppearance.
	/// </summary>
	public class FreeDrawAnnotation : UserControl
	{
		private Label label9;
		private Panel panel1;
		private Chart Chart1;
		private CheckBox DrawingMode;
		private Label label1;
		private Button UndoButton;
        private Button ClearAll;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public FreeDrawAnnotation()
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(FreeDrawAnnotation));
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
            label9 = new Label();
            panel1 = new Panel();
            ClearAll = new Button();
            UndoButton = new Button();
            label1 = new Label();
            DrawingMode = new CheckBox();
            Chart1 = new Chart();
            panel1.SuspendLayout();
            ((ISupportInitialize)(Chart1)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 14);
            label9.Name = "label9";
            label9.Size = new Size(702, 56);
            label9.TabIndex = 1;
            label9.Text = resources.GetString("label9.Text");
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(ClearAll);
            panel1.Controls.Add(UndoButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DrawingMode);
            panel1.Location = new Point(432, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 284);
            panel1.TabIndex = 19;
            // 
            // ClearAll
            // 
            ClearAll.BackColor = System.Drawing.SystemColors.Control;
            ClearAll.Enabled = false;
            ClearAll.Location = new Point(48, 133);
            ClearAll.Name = "ClearAll";
            ClearAll.Size = new Size(128, 23);
            ClearAll.TabIndex = 4;
            ClearAll.Text = "&Clear All";
            ClearAll.UseVisualStyleBackColor = false;
            ClearAll.Click += new EventHandler(ClearAll_Click);
            // 
            // UndoButton
            // 
            UndoButton.BackColor = System.Drawing.SystemColors.Control;
            UndoButton.Enabled = false;
            UndoButton.Location = new Point(48, 88);
            UndoButton.Name = "UndoButton";
            UndoButton.Size = new Size(128, 23);
            UndoButton.TabIndex = 3;
            UndoButton.Text = "&Undo";
            UndoButton.UseVisualStyleBackColor = false;
            UndoButton.Click += new EventHandler(UndoButton_Click);
            // 
            // label1
            // 
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(224, 23);
            label1.TabIndex = 2;
            label1.Text = "Select to enable Drawing Mode:";
            // 
            // DrawingMode
            // 
            DrawingMode.Appearance = System.Windows.Forms.Appearance.Button;
            DrawingMode.BackColor = System.Drawing.SystemColors.Control;
            DrawingMode.Location = new Point(48, 48);
            DrawingMode.Name = "DrawingMode";
            DrawingMode.Size = new Size(128, 24);
            DrawingMode.TabIndex = 1;
            DrawingMode.Text = "&Drawing Mode";
            DrawingMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            DrawingMode.UseVisualStyleBackColor = false;
            DrawingMode.CheckedChanged += new EventHandler(DrawingMode_CheckedChanged);
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
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 75F;
            chartArea1.Position.Width = 90F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 13F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5F;
            legend1.Position.Width = 40F;
            legend1.Position.X = 5F;
            legend1.Position.Y = 85F;
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
            legend3.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend3.IsTextAutoFit = false;
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend3.Name = "Legend3";
            legend3.Position.Auto = false;
            legend3.Position.Height = 12F;
            legend3.Position.Width = 90F;
            legend3.Position.X = 5F;
            legend3.Position.Y = 85F;
            Chart1.Legends.Add(legend1);
            Chart1.Legends.Add(legend2);
            Chart1.Legends.Add(legend3);
            Chart1.Location = new Point(16, 79);
            Chart1.Name = "Chart1";
            Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.Legend = "Legend2";
            series1.Name = "Series2";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Default";
            series2.Name = "Series3";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.CustomProperties = "DrawingStyle=Cylinder";
            series3.Legend = "Default";
            series3.Name = "Series4";
            series3.Points.Add(dataPoint9);
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 0;
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.Position.Auto = false;
            title1.Position.Height = 8.738057F;
            title1.Position.Width = 80F;
            title1.Position.X = 4F;
            title1.Position.Y = 4F;
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Chart Control for .NET Framework";
            Chart1.Titles.Add(title1);
            Chart1.AnnotationPlaced += new EventHandler(Chart1_AnnotationPlaced);
            // 
            // FreeDrawAnnotation
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "FreeDrawAnnotation";
            Size = new Size(728, 480);
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(Chart1)).EndInit();
            ResumeLayout(false);

		}
		#endregion

		private void DrawingMode_CheckedChanged(object sender, EventArgs e)
		{
			if(DrawingMode.Checked)
			{
				// enter the drawing mode
				DrawAnnotation();
			}
			else
			{
				// end the placement of the annotation object...
				Chart1.Annotations[Chart1.Annotations.Count-1].EndPlacement();
			}
		}


		private void Chart1_AnnotationPlaced(object sender, EventArgs e)
		{
			if(DrawingMode.Checked)
			{
				DrawAnnotation();
			}
			EnableDisableButtons();
		}

		private void DrawAnnotation()
		{
			PolylineAnnotation polyline = new PolylineAnnotation();
			polyline.LineColor = Color.FromArgb(255, 227, 130);
            polyline.LineWidth = 2;
			polyline.ShadowOffset = 2;
            polyline.AllowPathEditing = true;
            polyline.AllowSelecting = true;
            polyline.AllowMoving = true;
            polyline.IsFreeDrawPlacement = true;
            Chart1.Annotations.Add(polyline);
			polyline.BeginPlacement();
		}

		private void UndoButton_Click(object sender, EventArgs e)
		{
			if(Chart1.Annotations.Count > 0)
			{
				// if in drawing mode, end the drawing mode...
				if(DrawingMode.Checked)
				{
					// uncheck the drawing mode button, which will cause
					// the end placement method to be called for the check changed event
					DrawingMode.Checked = false;

					// Call self to remove the annotation... as simply removing the 
					// annotation does not work 
					UndoButton_Click(sender, e);
				}

				// remove the last annotation object that was added
				Chart1.Annotations.Remove(Chart1.Annotations[Chart1.Annotations.Count-1]);
			}
			EnableDisableButtons();
		}

		private void ClearAll_Click(object sender, EventArgs e)
		{
			// uncheck the drawing mode button, which will cause
			// the end placement method to be called for the check changed event
			DrawingMode.Checked = false;

			// remove all annotation objects
			Chart1.Annotations.Clear();
			EnableDisableButtons();
		}

		private void EnableDisableButtons()
		{
			UndoButton.Enabled = (Chart1.Annotations.Count > 0);
			ClearAll.Enabled = (Chart1.Annotations.Count > 0);
		}

	}
}
