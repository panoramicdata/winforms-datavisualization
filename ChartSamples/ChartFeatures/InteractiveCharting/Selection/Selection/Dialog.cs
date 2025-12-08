using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Dialog : Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;
		internal System.Windows.Forms.DataVisualization.Charting.Chart ChartRef;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
        private Label label6;
		private Panel panel1;
		private Button button1;
		private TextBox YValue;
		private ComboBox MarkerBorderColor;
		private ComboBox BorderColor;
		private ComboBox MarkerColor;
		private TextBox Label;
        private ComboBox PointColor;
		internal int pointIndex;

		public Dialog()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Add Colors to controls.
			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				PointColor.Items.Add(colorName);
				MarkerColor.Items.Add(colorName);
				MarkerBorderColor.Items.Add(colorName);
				BorderColor.Items.Add(colorName);
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            YValue = new TextBox();
            label1 = new Label();
            MarkerBorderColor = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            Label = new TextBox();
            MarkerColor = new ComboBox();
            BorderColor = new ComboBox();
            PointColor = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // YValue
            // 
            YValue.Location = new Point(208, 8);
            YValue.Name = "YValue";
            YValue.Size = new Size(152, 20);
            YValue.TabIndex = 0;
            YValue.KeyPress += new KeyPressEventHandler(YValue_KeyPress);
            // 
            // label1
            // 
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label1.Location = new Point(8, 6);
            label1.Name = "label1";
            label1.Size = new Size(184, 23);
            label1.TabIndex = 1;
            label1.Text = "Y Value:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MarkerBorderColor
            // 
            MarkerBorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MarkerBorderColor.Location = new Point(208, 158);
            MarkerBorderColor.Name = "MarkerBorderColor";
            MarkerBorderColor.Size = new Size(152, 21);
            MarkerBorderColor.TabIndex = 5;
            // 
            // label2
            // 
            label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label2.Location = new Point(8, 36);
            label2.Name = "label2";
            label2.Size = new Size(184, 23);
            label2.TabIndex = 3;
            label2.Text = "Data Point Color:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label3.Location = new Point(8, 66);
            label3.Name = "label3";
            label3.Size = new Size(184, 23);
            label3.TabIndex = 4;
            label3.Text = "Data Point Border Color:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label4.Location = new Point(8, 96);
            label4.Name = "label4";
            label4.Size = new Size(184, 23);
            label4.TabIndex = 5;
            label4.Text = "Data Point Label:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label5.Location = new Point(8, 126);
            label5.Name = "label5";
            label5.Size = new Size(184, 23);
            label5.TabIndex = 6;
            label5.Text = "Data Point Marker Color:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label6.Location = new Point(8, 156);
            label6.Name = "label6";
            label6.Size = new Size(184, 23);
            label6.TabIndex = 7;
            label6.Text = "Data Point Marker Border Color:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Label);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(MarkerColor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BorderColor);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PointColor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(YValue);
            panel1.Controls.Add(MarkerBorderColor);
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 224);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(280, 192);
            button1.Name = "button1";
            button1.Size = new Size(80, 23);
            button1.TabIndex = 6;
            button1.Text = "&OK";
            button1.Click += new EventHandler(button1_Click);
            // 
            // Label
            // 
            Label.Location = new Point(208, 99);
            Label.Name = "Label";
            Label.Size = new Size(152, 20);
            Label.TabIndex = 3;
            Label.Text = "textBox2";
            // 
            // MarkerColor
            // 
            MarkerColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MarkerColor.Location = new Point(208, 128);
            MarkerColor.Name = "MarkerColor";
            MarkerColor.Size = new Size(152, 21);
            MarkerColor.TabIndex = 4;
            // 
            // BorderColor
            // 
            BorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BorderColor.Location = new Point(208, 68);
            BorderColor.Name = "BorderColor";
            BorderColor.Size = new Size(152, 21);
            BorderColor.TabIndex = 2;
            // 
            // PointColor
            // 
            PointColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            PointColor.Location = new Point(208, 38);
            PointColor.Name = "PointColor";
            PointColor.Size = new Size(152, 21);
            PointColor.TabIndex = 1;
            // 
            // Dialog
            // 
            AutoScaleBaseSize = new Size(5, 13);
            ClientSize = new Size(392, 237);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dialog";
            Text = "Data Point";
            TopMost = true;
            Load += new EventHandler(Dialog_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

		}
		#endregion


		private void Dialog_Load(object sender, EventArgs e)
		{
			YValue.Text = ChartRef.Series[0].Points[pointIndex].YValues[0].ToString();
			Label.Text = ChartRef.Series[0].Points[pointIndex].Label;
			PointColor.SelectedIndex = PointColor.FindString( ChartRef.Series[0].Points[pointIndex].Color.Name );
			MarkerColor.SelectedIndex = MarkerColor.FindString( ChartRef.Series[0].Points[pointIndex].MarkerColor.Name );
			BorderColor.SelectedIndex = BorderColor.FindString( ChartRef.Series[0].Points[pointIndex].BorderColor.Name );
			MarkerBorderColor.SelectedIndex = MarkerBorderColor.FindString( ChartRef.Series[0].Points[pointIndex].MarkerBorderColor.Name );
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				double newValue = double.Parse( YValue.Text );
				if(newValue > 0)
					ChartRef.Series[0].Points[pointIndex].YValues[0] = newValue;
				else
					ChartRef.Series[0].Points[pointIndex].YValues[0] = 0.5;
			}
			catch
			{
				
			}

			ChartRef.Series[0].Points[pointIndex].Label = Label.Text;

			ChartRef.Series[0].Points[pointIndex].Color = Color.FromName(PointColor.SelectedItem.ToString());
			ChartRef.Series[0].Points[pointIndex].BorderColor = Color.FromName(BorderColor.SelectedItem.ToString());
			ChartRef.Series[0].Points[pointIndex].MarkerColor = Color.FromName(MarkerColor.SelectedItem.ToString());
			ChartRef.Series[0].Points[pointIndex].MarkerBorderColor = Color.FromName(MarkerBorderColor.SelectedItem.ToString());

			ChartRef.Invalidate();

			Close();
		}

		private void YValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == 46  || e.KeyChar == '.')
			{
				string editText = ((TextBox)(sender)).Text;
				if(e.KeyChar != 8)
				{
					TextBox textBox = (TextBox)sender;
					int selStart = textBox.SelectionStart;
					int selLength = textBox.SelectionLength;
	
					if(selLength > 0)
					{
						editText = editText.Remove(selStart, selLength);
						textBox.Text = editText;
						textBox.SelectionLength = 0;
						textBox.SelectionStart = selStart;
					}


					editText = editText.Insert(selStart,e.KeyChar.ToString());

					try
					{
						double newValue = double.Parse(editText);
						if(newValue <= 10 && newValue >= 0)
						{
							e.Handled = false;
						}
						else
							e.Handled = true;
					}
					catch(Exception )
					{
						e.Handled = true;
					}
				}
				else
					e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		
		}
	}
}
