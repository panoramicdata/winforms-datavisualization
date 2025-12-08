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
	/// Summary description for LegendCustomPosition.
	/// </summary>
	public class LegendCustomPosition : UserControl
	{
		private Label label9;
		private Chart Chart1;
		private Panel panel1;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private NumericUpDown XEdit;
		private NumericUpDown YEdit;
		private NumericUpDown WidthEdit;
		private NumericUpDown HeightEdit;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		private bool suppressChanges = false;

		public LegendCustomPosition()
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
			DataPoint dataPoint1 = new DataPoint(0, 600);
			DataPoint dataPoint2 = new DataPoint(0, 400);
			DataPoint dataPoint3 = new DataPoint(0, 200);
			DataPoint dataPoint4 = new DataPoint(0, 560);
			DataPoint dataPoint5 = new DataPoint(0, 300);
			Series series2 = new Series();
			DataPoint dataPoint6 = new DataPoint(0, 550);
			DataPoint dataPoint7 = new DataPoint(0, 580);
			DataPoint dataPoint8 = new DataPoint(0, 300);
			DataPoint dataPoint9 = new DataPoint(0, 425);
			DataPoint dataPoint10 = new DataPoint(0, 400);
			Series series3 = new Series();
			DataPoint dataPoint11 = new DataPoint(0, 500);
			DataPoint dataPoint12 = new DataPoint(0, 500);
			DataPoint dataPoint13 = new DataPoint(0, 350);
			DataPoint dataPoint14 = new DataPoint(0, 300);
			DataPoint dataPoint15 = new DataPoint(0, 520);
			Title title1 = new Title();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(LegendCustomPosition));
            label9 = new Label();
            Chart1 = new Chart();
            panel1 = new Panel();
            HeightEdit = new NumericUpDown();
            WidthEdit = new NumericUpDown();
            YEdit = new NumericUpDown();
            XEdit = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((ISupportInitialize)(Chart1)).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)(HeightEdit)).BeginInit();
            ((ISupportInitialize)(WidthEdit)).BeginInit();
            ((ISupportInitialize)(YEdit)).BeginInit();
            ((ISupportInitialize)(XEdit)).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new Point(16, 8);
            label9.Name = "label9";
            label9.Size = new Size(702, 40);
            label9.TabIndex = 0;
            label9.Text = "This sample demonstrates how to position the legend by setting the coordinates of" +
                " its width and height, relative to the top left corner. ";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 62.58395F;
            chartArea1.Position.Width = 88.77716F;
            chartArea1.Position.X = 5.089137F;
            chartArea1.Position.Y = 18.3307F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            legend1.Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 9.511945F;
            legend1.Position.Width = 59F;
            legend1.Position.X = 6.966655F;
            legend1.Position.Y = 82.79218F;
            Chart1.Legends.Add(legend1);
            Chart1.Location = new Point(16, 56);
            Chart1.Name = "Chart1";
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "Default";
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series3.ChartArea = "Default";
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            Chart1.Series.Add(series1);
            Chart1.Series.Add(series2);
            Chart1.Series.Add(series3);
            Chart1.Size = new Size(412, 296);
            Chart1.TabIndex = 1;
            title1.Font = new Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Legend Positioning";
            Chart1.Titles.Add(title1);
            Chart1.MouseDown += new MouseEventHandler(Chart1_MouseDown);
            // 
            // panel1
            // 
            panel1.Controls.Add(HeightEdit);
            panel1.Controls.Add(WidthEdit);
            panel1.Controls.Add(YEdit);
            panel1.Controls.Add(XEdit);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(432, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 296);
            panel1.TabIndex = 2;
            // 
            // HeightEdit
            // 
            HeightEdit.Location = new Point(168, 104);
            HeightEdit.Name = "HeightEdit";
            HeightEdit.Size = new Size(80, 22);
            HeightEdit.TabIndex = 7;
            HeightEdit.Value = new decimal([
            9,
            0,
            0,
            0]);
            HeightEdit.ValueChanged += new EventHandler(Controls_ValueChanged);
            // 
            // WidthEdit
            // 
            WidthEdit.Location = new Point(168, 72);
            WidthEdit.Name = "WidthEdit";
            WidthEdit.Size = new Size(80, 22);
            WidthEdit.TabIndex = 5;
            WidthEdit.Value = new decimal([
            21,
            0,
            0,
            0]);
            WidthEdit.ValueChanged += new EventHandler(Controls_ValueChanged);
            // 
            // YEdit
            // 
            YEdit.Location = new Point(168, 40);
            YEdit.Name = "YEdit";
            YEdit.Size = new Size(80, 22);
            YEdit.TabIndex = 3;
            YEdit.Value = new decimal([
            50,
            0,
            0,
            0]);
            YEdit.ValueChanged += new EventHandler(Controls_ValueChanged);
            // 
            // XEdit
            // 
            XEdit.Location = new Point(168, 8);
            XEdit.Name = "XEdit";
            XEdit.Size = new Size(80, 22);
            XEdit.TabIndex = 1;
            XEdit.Value = new decimal([
            15,
            0,
            0,
            0]);
            XEdit.ValueChanged += new EventHandler(Controls_ValueChanged);
            // 
            // label5
            // 
            label5.Location = new Point(16, 107);
            label5.Name = "label5";
            label5.Size = new Size(148, 16);
            label5.TabIndex = 6;
            label5.Text = "&Height:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(16, 75);
            label4.Name = "label4";
            label4.Size = new Size(148, 16);
            label4.TabIndex = 4;
            label4.Text = "&Width:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(16, 43);
            label3.Name = "label3";
            label3.Size = new Size(148, 16);
            label3.TabIndex = 2;
            label3.Text = "&Y:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(16, 11);
            label2.Name = "label2";
            label2.Size = new Size(148, 16);
            label2.TabIndex = 0;
            label2.Text = "&X:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(16, 360);
            label1.Name = "label1";
            label1.Size = new Size(712, 64);
            label1.TabIndex = 3;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LegendCustomPosition
            // 
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Chart1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "LegendCustomPosition";
            Size = new Size(728, 480);
            Load += new EventHandler(LegendCustomPosition_Load);
            ((ISupportInitialize)(Chart1)).EndInit();
            panel1.ResumeLayout(false);
            ((ISupportInitialize)(HeightEdit)).EndInit();
            ((ISupportInitialize)(WidthEdit)).EndInit();
            ((ISupportInitialize)(YEdit)).EndInit();
            ((ISupportInitialize)(XEdit)).EndInit();
            ResumeLayout(false);

		}
		#endregion


		private void LegendCustomPosition_Load(object sender, EventArgs e)
		{
			AdjustLegendControls();
		}

		private void Chart1_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.X != 0 && e.Y != 0)
			{
                ElementPosition position = Chart1.Legends[0].Position;
				// Conver pixels to percentage coordinates and set legend position
                position.X = e.X * 100F / ((float)(Chart1.Size.Width - 1));
                position.Y = e.Y * 100F / ((float)(Chart1.Size.Height - 1)); 
	
				AdjustLegendControls();

				Chart1.Invalidate();
			}
		}

		private void AdjustLegendControls()
		{
			try
			{
				suppressChanges = true;

                ElementPosition position = Chart1.Legends[0].Position;

                if (position.X > 47)
                    position.Width = 60;

                if (position.Y > 91)
                    position.Height = 9;

                XEdit.Value = (decimal)position.X;
                YEdit.Value = (decimal)position.Y;
                WidthEdit.Value = (decimal)position.Width;
                HeightEdit.Value = (decimal)position.Height;
			}
			finally
			{
				suppressChanges = false;
			}
		}

		private void Controls_ValueChanged(object sender, EventArgs e)
		{
			if ( suppressChanges )
			{
				return;
			}

            ElementPosition position = Chart1.Legends[0].Position;
            position.X = (float)XEdit.Value;
            position.Y = (float)YEdit.Value;
            position.Width = (float)WidthEdit.Value;
            position.Height = (float)HeightEdit.Value;

			AdjustLegendControls();

			Chart1.Invalidate();

		}

//		private void Edit_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
//		{
//			if((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == 46 )
//			{
//				string editText = ((TextBox)(sender)).Text;
//				if(e.KeyChar != 8)
//				{
//					TextBox textBox = (TextBox)sender;
//					int selStart = textBox.SelectionStart;
//					int selLength = textBox.SelectionLength;
//	
//					if(selLength > 0)
//					{
//						editText = editText.Remove(selStart, selLength);
//						textBox.Text = editText;
//						textBox.SelectionLength = 0;
//						textBox.SelectionStart = selStart;
//					}
//
//
//					editText = editText.Insert(selStart,e.KeyChar.ToString());
//
//					try
//					{
//						double newValue = double.Parse(editText);
//						if(newValue <= 100 && newValue >= 0)
//						{
//							e.Handled = false;
//						}
//						else
//							e.Handled = true;
//					}
//					catch(Exception )
//					{
//						e.Handled = true;
//					}
//				}
//				else
//					e.Handled = false;
//			}
//			else
//			{
//				e.Handled = true;
//			}
//		
//		}
//
//		private void XEdit_TextChanged(object sender, System.EventArgs e)
//		{
//			if(XEdit.Text != "")
//				Chart1.Legends[0].Position.X = float.Parse(XEdit.Text);
//			else
//				Chart1.Legends[0].Position.X = 0;
//
//			AdjustLegendControls();
//		}
//
//		private void YEdit_TextChanged(object sender, System.EventArgs e)
//		{
//			if(YEdit.Text != "")
//				Chart1.Legends[0].Position.Y = float.Parse(YEdit.Text);
//			else
//				Chart1.Legends[0].Position.Y = 0;
//
//			AdjustLegendControls();
//		}
//
//		private void WidthEdit_TextChanged(object sender, System.EventArgs e)
//		{
//			if(WidthEdit.Text != "")
//				Chart1.Legends[0].Position.Width = float.Parse(WidthEdit.Text);
//			else
//				Chart1.Legends[0].Position.Width = 21;
//
//			AdjustLegendControls();
//		}
//
//		private void HeightEdit_TextChanged(object sender, System.EventArgs e)
//		{
//			if(HeightEdit.Text != "")
//				Chart1.Legends[0].Position.Height = float.Parse(HeightEdit.Text);
//			else
//				Chart1.Legends[0].Position.Height = 9;
//
//			AdjustLegendControls();
//		}

	}
}
