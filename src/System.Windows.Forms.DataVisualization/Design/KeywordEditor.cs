// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	A keyword editor form. Allows the end user to insert
//				new and edit exsisting keywords in the string.
//


using System.Collections;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Utilities;

namespace System.Windows.Forms.Design.DataVisualization.Charting;

/// <summary>
/// Summary description for KeywordEditor.
/// </summary>
internal class KeywordEditor : Form
{
	#region Fields

	/// <summary>
	/// List of keywords that are applicable to the edited property
	/// </summary>
	private readonly ArrayList _applicableKeywords = null;

	/// <summary>
	/// Keyword beign edited or empty if inserting a new one.
	/// </summary>
	internal string Keyword = string.Empty;

	/// <summary>
	/// Maximum number of supported Y values.
	/// </summary>
	private readonly int _maxYValueIndex = 9;

	// Form fields
	private GroupBox _groupBoxKeywords;
	private ListBox _listBoxKeywords;
	private GroupBox _groupBoxDescription;
	private Label _labelDescription;
	private Button _buttonCancel;
	private Button _buttonOk;
	private GroupBox _groupBoxFormat;
	private Label _labelFormat;
	private NumericUpDown _numericUpDownYValue;
	private Label _labelYValue;
	private ComboBox _comboBoxFormat;
	private Label _labelPrecision;
	private TextBox _textBoxCustomFormat;
	private Label _labelCustomFormat;
	private Label _labelSample;
	private TextBox _textBoxSample;
	private TextBox _textBoxPrecision;
	private ToolTip _toolTip;
	private System.ComponentModel.IContainer _components;

	// resolved VSTS by extending the dialog by 36x28 pixels.
	// 5767	FRA: ChartAPI: String "Format Sample:" is  truncated on the "Keywords Editor'	
	// 4383	DEU: VC/VB/VCS/VWD: ChartAPI: The string "If a chart type supports..." is truncated on the 'Keyword Editor' dialog.
	// 3524	DEU: VC/VB/VCS/VWD: ChartAPI: The string "If a chart type supports..." is truncated on the 'Keyword Editor' dialog.

	private static readonly int widthDialogExtend = 80;
	private static readonly int heightDialogExtend = 38;

	#endregion // Fields

	#region Constructors

	/// <summary>
	/// Default public constructor.
	/// </summary>
	public KeywordEditor()
	{
		//
		// Required for Windows Form Designer support
		//
		InitializeComponent();
		PrepareControlsLayout();
	}

	/// <summary>
	/// Form constructor.
	/// </summary>
	/// <param name="applicableKeywords">List of keywords that can be inserted.</param>
	/// <param name="keyword">Keyword that should be edited.</param>
	/// <param name="maxYValueIndex">Maximum number of Y Values supported.</param>
	public KeywordEditor(ArrayList applicableKeywords, string keyword, int maxYValueIndex) : this()
	{
		// Save input data
		_applicableKeywords = applicableKeywords;
		Keyword = keyword;
		_maxYValueIndex = maxYValueIndex;
	}

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			_components?.Dispose();
		}

		base.Dispose(disposing);
	}

	#endregion // Constructors

	#region Windows Form Designer generated code
	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		_components = new System.ComponentModel.Container();
		_groupBoxKeywords = new GroupBox();
		_listBoxKeywords = new ListBox();
		_groupBoxDescription = new GroupBox();
		_labelDescription = new Label();
		_buttonCancel = new Button();
		_buttonOk = new Button();
		_groupBoxFormat = new GroupBox();
		_textBoxPrecision = new TextBox();
		_labelSample = new Label();
		_textBoxSample = new TextBox();
		_numericUpDownYValue = new NumericUpDown();
		_labelYValue = new Label();
		_comboBoxFormat = new ComboBox();
		_labelPrecision = new Label();
		_labelFormat = new Label();
		_labelCustomFormat = new Label();
		_textBoxCustomFormat = new TextBox();
		_toolTip = new ToolTip(_components);
		_groupBoxKeywords.SuspendLayout();
		_groupBoxDescription.SuspendLayout();
		_groupBoxFormat.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(_numericUpDownYValue)).BeginInit();
		SuspendLayout();
		// 
		// groupBoxKeywords
		// 
		_groupBoxKeywords.Controls.AddRange([
																					   _listBoxKeywords]);
		_groupBoxKeywords.Location = new Drawing.Point(8, 16);
		_groupBoxKeywords.Name = "groupBoxKeywords";
		_groupBoxKeywords.Size = new Drawing.Size(216, 232);
		_groupBoxKeywords.TabIndex = 0;
		_groupBoxKeywords.TabStop = false;
		_groupBoxKeywords.Text = SR.LabelKeyKeywords;
		// 
		// listBoxKeywords
		// 
		_listBoxKeywords.Location = new Drawing.Point(8, 24);
		_listBoxKeywords.Name = "listBoxKeywords";
		_listBoxKeywords.Size = new Drawing.Size(200, 199);
		_listBoxKeywords.TabIndex = 0;
		_listBoxKeywords.DoubleClick += new EventHandler(listBoxKeywords_DoubleClick);
		_listBoxKeywords.SelectedIndexChanged += new EventHandler(listBoxKeywords_SelectedIndexChanged);
		// 
		// groupBoxDescription
		// 
		_groupBoxDescription.Controls.AddRange([
																						  _labelDescription]);
		_groupBoxDescription.Location = new Drawing.Point(240, 16);
		_groupBoxDescription.Name = "groupBoxDescription";
		_groupBoxDescription.Size = new Drawing.Size(328, 88);
		_groupBoxDescription.TabIndex = 1;
		_groupBoxDescription.TabStop = false;
		_groupBoxDescription.Text = SR.LabelDescription;
		// 
		// labelDescription
		// 
		_labelDescription.Location = new Drawing.Point(16, 24);
		_labelDescription.Name = "labelDescription";
		_labelDescription.Size = new Drawing.Size(304, 56);
		_labelDescription.TabIndex = 0;
		_labelDescription.Text = "<replaced at runtime>";
		// 
		// buttonCancel
		// 
		_buttonCancel.DialogResult = DialogResult.Cancel;
		_buttonCancel.Location = new Drawing.Point(479, 256);
		_buttonCancel.Name = "buttonCancel";
		_buttonCancel.Size = new Drawing.Size(90, 27);
		_buttonCancel.TabIndex = 4;
		_buttonCancel.Text = SR.LabelButtonCancel;
		// 
		// buttonOk
		// 
		_buttonOk.DialogResult = DialogResult.OK;
		_buttonOk.Location = new Drawing.Point(367, 256);
		_buttonOk.Name = "buttonOk";
		_buttonOk.Size = new Drawing.Size(90, 27);
		_buttonOk.TabIndex = 3;
		_buttonOk.Text = SR.LabelButtonOk;
		_buttonOk.Click += new EventHandler(buttonOk_Click);
		// 
		// groupBoxFormat
		// 
		_groupBoxFormat.Controls.AddRange([
																					 _textBoxPrecision,
																					 _labelSample,
																					 _textBoxSample,
																					 _numericUpDownYValue,
																					 _labelYValue,
																					 _comboBoxFormat,
																					 _labelPrecision,
																					 _labelFormat,
																					 _labelCustomFormat,
																					 _textBoxCustomFormat]);
		_groupBoxFormat.Location = new Drawing.Point(240, 112);
		_groupBoxFormat.Name = "groupBoxFormat";
		_groupBoxFormat.Size = new Drawing.Size(328, 136);
		_groupBoxFormat.TabIndex = 2;
		_groupBoxFormat.TabStop = false;
		_groupBoxFormat.Text = SR.LabelValueFormatting;
		// 
		// textBoxPrecision
		// 
		_textBoxPrecision.Location = new Drawing.Point(112, 48);
		_textBoxPrecision.Name = "textBoxPrecision";
		_textBoxPrecision.Size = new Drawing.Size(64, 20);
		_textBoxPrecision.TabIndex = 3;
		_textBoxPrecision.Text = "";
		_textBoxPrecision.TextChanged += new EventHandler(textBoxPrecision_TextChanged);
		// 
		// labelSample
		// 
		_labelSample.Location = new Drawing.Point(8, 72);
		_labelSample.Name = "labelSample";
		_labelSample.Size = new Drawing.Size(96, 23);
		_labelSample.TabIndex = 7;
		_labelSample.Text = SR.LabelFormatKeySample;
		_labelSample.TextAlign = Drawing.ContentAlignment.MiddleRight;
		// 
		// textBoxSample
		// 
		_textBoxSample.Location = new Drawing.Point(112, 72);
		_textBoxSample.Name = "textBoxSample";
		_textBoxSample.ReadOnly = true;
		_textBoxSample.Size = new Drawing.Size(192, 20);
		_textBoxSample.TabIndex = 8;
		_textBoxSample.Text = "";
		// 
		// numericUpDownYValue
		// 
		_numericUpDownYValue.CausesValidation = false;
		_numericUpDownYValue.Location = new Drawing.Point(112, 104);
		_numericUpDownYValue.Maximum = new decimal([
																			9,
																			0,
																			0,
																			0]);
		_numericUpDownYValue.Name = "numericUpDownYValue";
		_numericUpDownYValue.Size = new Drawing.Size(64, 20);
		_numericUpDownYValue.TabIndex = 10;
		_numericUpDownYValue.ValueChanged += new EventHandler(numericUpDownYValue_ValueChanged);
		// 
		// labelYValue
		// 
		_labelYValue.Location = new Drawing.Point(8, 104);
		_labelYValue.Name = "labelYValue";
		_labelYValue.Size = new Drawing.Size(96, 23);
		_labelYValue.TabIndex = 9;
		_labelYValue.Text = SR.LabelKeyYValueIndex;
		_labelYValue.TextAlign = Drawing.ContentAlignment.MiddleRight;
		// 
		// comboBoxFormat
		// 
		_comboBoxFormat.DropDownStyle = ComboBoxStyle.DropDownList;
		_comboBoxFormat.Items.AddRange([
															SR.DescriptionTypeNone,
															SR.DescriptionNumberFormatTypeCurrency,
															SR.DescriptionNumberFormatTypeDecimal,
															SR.DescriptionNumberFormatTypeScientific,
															SR.DescriptionNumberFormatTypeFixedPoint,
															SR.DescriptionNumberFormatTypeGeneral,
															SR.DescriptionNumberFormatTypeNumber,
															SR.DescriptionNumberFormatTypePercent,
															SR.DescriptionTypeCustom]);

		_comboBoxFormat.Location = new Drawing.Point(112, 24);
		_comboBoxFormat.MaxDropDownItems = 10;
		_comboBoxFormat.Name = "comboBoxFormat";
		_comboBoxFormat.Size = new Drawing.Size(192, 21);
		_comboBoxFormat.TabIndex = 1;
		_comboBoxFormat.SelectedIndexChanged += new EventHandler(comboBoxFormat_SelectedIndexChanged);
		// 
		// labelPrecision
		// 
		_labelPrecision.Location = new Drawing.Point(8, 48);
		_labelPrecision.Name = "labelPrecision";
		_labelPrecision.Size = new Drawing.Size(96, 23);
		_labelPrecision.TabIndex = 2;
		_labelPrecision.Text = SR.LabelKeyPrecision;
		_labelPrecision.TextAlign = Drawing.ContentAlignment.MiddleRight;
		// 
		// labelFormat
		// 
		_labelFormat.Location = new Drawing.Point(8, 24);
		_labelFormat.Name = "labelFormat";
		_labelFormat.Size = new Drawing.Size(96, 23);
		_labelFormat.TabIndex = 0;
		_labelFormat.Text = SR.LabelKeyFormat;
		_labelFormat.TextAlign = Drawing.ContentAlignment.MiddleRight;
		// 
		// labelCustomFormat
		// 
		_labelCustomFormat.Location = new Drawing.Point(8, 48);
		_labelCustomFormat.Name = "labelCustomFormat";
		_labelCustomFormat.Size = new Drawing.Size(96, 23);
		_labelCustomFormat.TabIndex = 4;
		_labelCustomFormat.Text = SR.LabelKeyCustomFormat;
		_labelCustomFormat.TextAlign = Drawing.ContentAlignment.MiddleRight;
		_labelCustomFormat.Visible = false;
		// 
		// textBoxCustomFormat
		// 
		_textBoxCustomFormat.Location = new Drawing.Point(112, 48);
		_textBoxCustomFormat.Name = "textBoxCustomFormat";
		_textBoxCustomFormat.Size = new Drawing.Size(192, 20);
		_textBoxCustomFormat.TabIndex = 5;
		_textBoxCustomFormat.Text = "";
		_textBoxCustomFormat.Visible = false;
		_textBoxCustomFormat.TextChanged += new EventHandler(textBoxCustomFormat_TextChanged);
		// 
		// KeywordEditor
		// 
		AcceptButton = _buttonOk;
		AutoScaleBaseSize = new Drawing.Size(5, 13);
		CancelButton = _buttonCancel;
		ClientSize = new Drawing.Size(578, 295);
		Controls.AddRange([
																	  _groupBoxFormat,
																	  _buttonCancel,
																	  _buttonOk,
																	  _groupBoxDescription,
																	  _groupBoxKeywords]);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "KeywordEditor";
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = SR.LabelKeywordEditor;
		Load += new EventHandler(KeywordEditor_Load);
		_groupBoxKeywords.ResumeLayout(false);
		_groupBoxDescription.ResumeLayout(false);
		_groupBoxFormat.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)(_numericUpDownYValue)).EndInit();
		ResumeLayout(false);

	}
	#endregion

	#region Event Handlers

	/// <summary>
	/// Form loaded event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void KeywordEditor_Load(object sender, EventArgs e)
	{
		// Set restriction on the Y Value index editor
		if (_maxYValueIndex >= 0 && _maxYValueIndex < 10)
		{
			_numericUpDownYValue.Maximum = _maxYValueIndex;
		}

		_numericUpDownYValue.Enabled = _maxYValueIndex > 0;
		_labelYValue.Enabled = _maxYValueIndex > 0;

		// Set tooltip for custom format
		_toolTip.SetToolTip(_textBoxCustomFormat, SR.DescriptionToolTipCustomFormatCharacters);

		// Select format None
		_comboBoxFormat.SelectedIndex = 0;

		// Fill list of applicable keywords
		if (_applicableKeywords != null)
		{
			foreach (KeywordInfo keywordInfo in _applicableKeywords)
			{
				_listBoxKeywords.Items.Add(keywordInfo);
			}
		}

		// Check if keyword for editing was specified
		if (Keyword.Length == 0)
		{
			_listBoxKeywords.SelectedIndex = 0;
			_comboBoxFormat.SelectedIndex = 0;
		}
		else
		{
			// Iterate through all keywords and find a match
			bool itemFound = false;
			foreach (KeywordInfo keywordInfo in _applicableKeywords)
			{
				// Iterate through all possible keyword names
				string[] keywordNames = keywordInfo.GetKeywords();
				foreach (string keywordName in keywordNames)
				{
					if (Keyword.StartsWith(keywordName, StringComparison.Ordinal))
					{
						// Select keyword in the list
						_listBoxKeywords.SelectedItem = keywordInfo;
						int keywordLength = keywordName.Length;

						// Check if keyword support multiple Y values
						if (keywordInfo.SupportsValueIndex)
						{
							if (Keyword.Length > keywordLength &&
								Keyword[keywordLength] == 'Y')
							{
								++keywordLength;
								if (Keyword.Length > (keywordLength) &&
									char.IsDigit(Keyword[keywordLength]))
								{
									int yValueIndex = int.Parse(Keyword.Substring(keywordLength, 1), CultureInfo.InvariantCulture);
									if (yValueIndex < 0 || yValueIndex > _maxYValueIndex)
									{
										yValueIndex = 0;
									}

									_numericUpDownYValue.Value = yValueIndex;
									++keywordLength;
								}
							}
						}

						// Check if keyword support format string
						if (keywordInfo.SupportsFormatting)
						{
							if (Keyword.Length > keywordLength &&
								Keyword[keywordLength] == '{' &&
								Keyword.EndsWith("}", StringComparison.Ordinal))
							{
								// Get format string
								string format = Keyword.Substring(keywordLength + 1, Keyword.Length - keywordLength - 2);

								if (format.Length == 0)
								{
									// Select format None
									_comboBoxFormat.SelectedIndex = 0;
								}
								else
								{
									// Check if format string is custom
									if (format.Length == 1 ||
										(format.Length == 2 && char.IsDigit(format[1])) ||
										(format.Length == 3 && char.IsDigit(format[2])))
									{
										if (format[0] == 'C')
										{
											_comboBoxFormat.SelectedIndex = 1;
										}
										else if (format[0] == 'D')
										{
											_comboBoxFormat.SelectedIndex = 2;
										}
										else if (format[0] == 'E')
										{
											_comboBoxFormat.SelectedIndex = 3;
										}
										else if (format[0] == 'F')
										{
											_comboBoxFormat.SelectedIndex = 4;
										}
										else if (format[0] == 'G')
										{
											_comboBoxFormat.SelectedIndex = 5;
										}
										else if (format[0] == 'N')
										{
											_comboBoxFormat.SelectedIndex = 6;
										}
										else if (format[0] == 'P')
										{
											_comboBoxFormat.SelectedIndex = 7;
										}
										else
										{
											// Custom format
											_comboBoxFormat.SelectedIndex = 8;
											_textBoxCustomFormat.Text = format;
										}

										// Get precision
										if (_comboBoxFormat.SelectedIndex != 8 && format.Length > 0)
										{
											_textBoxPrecision.Text = format[1..];
										}
									}
									else
									{
										// Custom format
										_comboBoxFormat.SelectedIndex = 8;
										_textBoxCustomFormat.Text = format;
									}
								}
							}
						}

						// Stop iteration
						itemFound = true;
						break;
					}
				}

				// Break from the keywords loop
				if (itemFound)
				{
					break;
				}
			}
		}
	}

	/// <summary>
	/// Selected format changed event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void comboBoxFormat_SelectedIndexChanged(object sender, EventArgs e)
	{
		// Format disabled
		_labelCustomFormat.Enabled = (_comboBoxFormat.SelectedIndex > 0);
		_textBoxCustomFormat.Enabled = (_comboBoxFormat.SelectedIndex > 0);
		_labelPrecision.Enabled = (_comboBoxFormat.SelectedIndex > 0);
		_textBoxPrecision.Enabled = (_comboBoxFormat.SelectedIndex > 0);
		_labelSample.Enabled = (_comboBoxFormat.SelectedIndex > 0);
		_textBoxSample.Enabled = (_comboBoxFormat.SelectedIndex > 0);

		// Hide show form control depending on the format selection
		bool customFormat = ((string)_comboBoxFormat.SelectedItem == "Custom");
		_labelCustomFormat.Visible = customFormat;
		_textBoxCustomFormat.Visible = customFormat;
		_labelPrecision.Visible = !customFormat;
		_textBoxPrecision.Visible = !customFormat;

		// Update format sample
		UpdateNumericSample();
	}


	/// <summary>
	/// Selected keyword changed event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void listBoxKeywords_SelectedIndexChanged(object sender, EventArgs e)
	{
		// Get selected keyword
		if (_listBoxKeywords.SelectedItem is KeywordInfo keywordInfo)
		{
			// Show description of the selected keyword
			_labelDescription.Text = keywordInfo.Description.Replace("\\n", "\n");

			// Check if keyword support value formatting
			_groupBoxFormat.Enabled = keywordInfo.SupportsFormatting;

			// Check if keyword support Y value index
			_labelYValue.Enabled = keywordInfo.SupportsValueIndex;
			_numericUpDownYValue.Enabled = keywordInfo.SupportsValueIndex && _maxYValueIndex > 0;
			_labelYValue.Enabled = keywordInfo.SupportsValueIndex && _maxYValueIndex > 0;
		}

	}

	/// <summary>
	/// Keyword double click event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void listBoxKeywords_DoubleClick(object sender, EventArgs e)
	{
		// Simulate accept button click when user double clicks in the list
		AcceptButton.PerformClick();
	}

	/// <summary>
	/// Precision text changed event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void textBoxPrecision_TextChanged(object sender, EventArgs e)
	{
		MessageBoxOptions messageBoxOptions = 0;
		if (RightToLeft == RightToLeft.Yes)
		{
			messageBoxOptions = MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading;
		}

		if (_textBoxPrecision.Text.Length >= 1 && !char.IsDigit(_textBoxPrecision.Text[0]))
		{
			MessageBox.Show(this, SR.MessagePrecisionInvalid, SR.MessageChartTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, messageBoxOptions);
			_textBoxPrecision.Text = "";
		}
		else if (_textBoxPrecision.Text.Length >= 2 && (!char.IsDigit(_textBoxPrecision.Text[0]) || !char.IsDigit(_textBoxPrecision.Text[1])))
		{
			MessageBox.Show(this, SR.MessagePrecisionInvalid, SR.MessageChartTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, messageBoxOptions);
			_textBoxPrecision.Text = "";
		}

		UpdateNumericSample();
	}

	/// <summary>
	/// Custom format text changed event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void textBoxCustomFormat_TextChanged(object sender, EventArgs e)
	{
		UpdateNumericSample();
	}

	/// <summary>
	/// Ok button click event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void buttonOk_Click(object sender, EventArgs e)
	{
		// Generate new keyword
		Keyword = string.Empty;

		// Get selected keyword
		if (_listBoxKeywords.SelectedItem is KeywordInfo keywordInfo)
		{
			Keyword = keywordInfo.Keyword;

			if (keywordInfo.SupportsValueIndex &&
				(int)_numericUpDownYValue.Value > 0)
			{
				Keyword += "Y" + ((int)_numericUpDownYValue.Value).ToString(CultureInfo.InvariantCulture);
			}

			if (keywordInfo.SupportsFormatting &&
				_comboBoxFormat.SelectedIndex > 0 &&
				GetFormatString().Length > 0)
			{
				Keyword += "{" + GetFormatString() + "}";
			}
		}
	}

	/// <summary>
	/// Y Value index changed event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void numericUpDownYValue_ValueChanged(object sender, EventArgs e)
	{
		if (_numericUpDownYValue.Value > _maxYValueIndex && _numericUpDownYValue.Value < 0)
		{
			MessageBoxOptions messageBoxOptions = 0;
			if (RightToLeft == RightToLeft.Yes)
			{
				messageBoxOptions = MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading;
			}

			MessageBox.Show(this, SR.MessageYValueIndexInvalid(_maxYValueIndex.ToString(CultureInfo.CurrentCulture)), SR.MessageChartTitle,
				MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, messageBoxOptions);

			_numericUpDownYValue.Value = 0;
		}
	}

	#endregion // Event Handlers

	#region Helper Methods

	/// <summary>
	/// Gets current format string
	/// </summary>
	/// <returns></returns>
	private string GetFormatString()
	{
		string formatString = string.Empty;
		if (_comboBoxFormat.Enabled &&
			_comboBoxFormat.SelectedIndex == 1)
		{
			formatString = "C" + _textBoxPrecision.Text;
		}
		else if (_comboBoxFormat.SelectedIndex == 2)
		{
			formatString = "D" + _textBoxPrecision.Text;
		}
		else if (_comboBoxFormat.SelectedIndex == 3)
		{
			formatString = "E" + _textBoxPrecision.Text;
		}
		else if (_comboBoxFormat.SelectedIndex == 4)
		{
			formatString = "G" + _textBoxPrecision.Text;
		}
		else if (_comboBoxFormat.SelectedIndex == 5)
		{
			formatString = "G" + _textBoxPrecision.Text;
		}
		else if (_comboBoxFormat.SelectedIndex == 6)
		{
			formatString = "N" + _textBoxPrecision.Text;
		}
		else if (_comboBoxFormat.SelectedIndex == 7)
		{
			formatString = "P" + _textBoxPrecision.Text;
		}
		else if (_comboBoxFormat.SelectedIndex == 8)
		{
			formatString = _textBoxCustomFormat.Text;
		}

		return formatString;
	}

	/// <summary>
	/// Updates numeric sample on the form.
	/// </summary>
	private void UpdateNumericSample()
	{
		string formatString = GetFormatString();
		if (_comboBoxFormat.SelectedIndex == 0)
		{
			// No format
			_textBoxSample.Text = string.Empty;
		}
		else if (_comboBoxFormat.SelectedIndex == 1)
		{
			_textBoxSample.Text = string.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345.6789);
		}
		else if (_comboBoxFormat.SelectedIndex == 2)
		{
			_textBoxSample.Text = string.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345);
		}
		else if (_comboBoxFormat.SelectedIndex == 3)
		{
			_textBoxSample.Text = string.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345.6789);
		}
		else if (_comboBoxFormat.SelectedIndex == 4)
		{
			_textBoxSample.Text = string.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345.6789);
		}
		else if (_comboBoxFormat.SelectedIndex == 5)
		{
			_textBoxSample.Text = string.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345.6789);
		}
		else if (_comboBoxFormat.SelectedIndex == 6)
		{
			_textBoxSample.Text = string.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345.6789);
		}
		else if (_comboBoxFormat.SelectedIndex == 7)
		{
			_textBoxSample.Text = string.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 0.126);
		}
		else if (_comboBoxFormat.SelectedIndex == 8)
		{
			// Custom format
			bool success = false;
			try
			{
				_textBoxSample.Text = string.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345.67890);
				success = true;
			}
			catch (FormatException)
			{
			}

			if (!success)
			{
				try
				{
					_textBoxSample.Text = string.Format(CultureInfo.CurrentCulture, "{0:" + formatString + "}", 12345);
					success = true;
				}
				catch (FormatException)
				{
				}
			}

			if (!success)
			{
				_textBoxSample.Text = SR.DesciptionCustomLabelFormatInvalid;
			}
		}
	}
	/// <summary>
	/// VSTS: 787936, 787937 - Expand the dialog with widthDialogExtend, heightDialogExtend  to make room for localization.
	/// </summary>
	private void PrepareControlsLayout()
	{

		Width += widthDialogExtend;
		_buttonOk.Left += widthDialogExtend;
		_buttonCancel.Left += widthDialogExtend;
		_groupBoxDescription.Width += widthDialogExtend;
		_groupBoxFormat.Width += widthDialogExtend;
		_labelDescription.Width += widthDialogExtend;
		foreach (Control ctrl in _groupBoxFormat.Controls)
		{
			if (ctrl is Label)
			{
				ctrl.Width += widthDialogExtend;
			}
			else
			{
				ctrl.Left += widthDialogExtend;
			}
		}

		Height += heightDialogExtend;
		_buttonOk.Top += heightDialogExtend;
		_buttonCancel.Top += heightDialogExtend;
		_groupBoxKeywords.Height += heightDialogExtend;
		_listBoxKeywords.IntegralHeight = false;
		_listBoxKeywords.Height += heightDialogExtend;
		_groupBoxDescription.Height += heightDialogExtend;
		_labelDescription.Height += heightDialogExtend;
		_groupBoxFormat.Top += heightDialogExtend;
	}

	#endregion // Helper Methods
}


