// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Design-time editor for the strings that may contain
//				keywords. Form automatically retrives the list of 
//				recongnizable keywords from the chart keywords 
//				registry.
//


using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Utilities;

namespace System.Windows.Forms.Design.DataVisualization.Charting;

/// <summary>
/// Stirng editor form that is used to edit properties that support keywords.
/// </summary>
internal class KeywordsStringEditorForm : Form
{
	#region Fields

	// Form fields
	private RichTextBox _richTextBox;
	private GroupBox _groupBoxString;
	private Button _buttonOk;
	private Button _buttonCancel;
	private Button _buttonInsert;
	private Button _buttonEdit;
	private Label _labelDescription;
	private Panel _panelInsertEditButtons;
	private Panel _panelOkCancelButtons;
	private Panel _panelTopContent;

	/// <summary>
	/// Required designer variable.
	/// </summary>
	private readonly Container _components = null;

	/// <summary>
	/// Property name that is beign edited.
	/// </summary>
	private readonly string _propertyName = string.Empty;

	/// <summary>
	/// Object/class name beign edited.
	/// </summary>
	private readonly string _classTypeName = string.Empty;

	/// <summary>
	/// Initial string to be edited.
	/// </summary>
	[SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	private readonly string _initialString = string.Empty;

	/// <summary>
	/// Result String after editing.
	/// </summary>
	public string ResultString = string.Empty;

	/// <summary>
	/// Maximum Y value index that can be used
	/// </summary>
	private readonly int _maxYValueIndex = 9;

	/// <summary>
	/// List of applicable keywords
	/// </summary>
	internal ArrayList applicableKeywords = null;

	/// <summary>
	/// Reference to the keywords registry
	/// </summary>
	internal KeywordsRegistry KeywordsRegistry = null;

	/// <summary>
	/// Name of the last selected keyword name
	/// </summary>
	private string _selectedKeywordName = string.Empty;

	/// <summary>
	/// Start index of selected keyword.
	/// </summary>
	private int _selectedKeywordStart = -1;

	/// <summary>
	/// Length of selected keyword.
	/// </summary>
	private int _selectedKeywordLength = -1;

	/// <summary>
	/// Indicates that RTF control control is updating its text.
	/// Used to prevent recursive calls.
	/// </summary>
	private bool _updating = false;

	// resolved VSTS by extending the dialog by 36x28 pixels.
	// 5027	 MultiLang: ChartAPI: Strings are truncated on the 'String Keywords Editor' dialog
	// 65162 Garbled characters in the String Keyword Editor on the designer
	// 16588 DEU and JPN: VCS/VB/VWD/VC: ChartAPI: Some string are truncated on the 'String Keywords Editor'
	// 3523  DEU and JPN: VCS/VB/VWD/VC: ChartAPI: Some string are truncated on the 'String Keywords Editor'

	private static readonly int widthDialogExtend = 80;
	private static readonly int heightDialogExtend = 38;

	#endregion // Fields

	#region Constructor

	/// <summary>
	/// Default public constructor
	/// </summary>
	public KeywordsStringEditorForm()
	{
		//
		// Required for Windows Form Designer support
		//
		InitializeComponent();
		PrepareControlsLayout();
	}

	/// <summary>
	/// Object constructor.
	/// </summary>
	/// <param name="initialString">String to edit.</param>
	/// <param name="classTypeName">Class name that beign edited.</param>
	/// <param name="propertyName">Property name that is beign edited.</param>
	/// <param name="maxYValueIndex">Maximum number of supported Y values.</param>
	public KeywordsStringEditorForm(string initialString, string classTypeName, string propertyName, int maxYValueIndex) : this()
	{

		// Save input parameters
		_classTypeName = classTypeName;
		_propertyName = propertyName;
		_maxYValueIndex = maxYValueIndex;
		_initialString = initialString;
		ResultString = initialString;
	}

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">True if disposing.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			_components?.Dispose();
		}

		base.Dispose(disposing);
	}

	#endregion // Constructor

	#region Windows Form Designer generated code
	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		_richTextBox = new RichTextBox();
		_groupBoxString = new GroupBox();
		_buttonEdit = new Button();
		_buttonInsert = new Button();
		_buttonOk = new Button();
		_buttonCancel = new Button();
		_labelDescription = new Label();
		_panelOkCancelButtons = new Panel();
		_panelTopContent = new Panel();
		_panelInsertEditButtons = new Panel();
		_groupBoxString.SuspendLayout();
		_panelOkCancelButtons.SuspendLayout();
		_panelTopContent.SuspendLayout();
		_panelInsertEditButtons.SuspendLayout();
		SuspendLayout();
		// 
		// richTextBox
		// 
		_richTextBox.Dock = DockStyle.Fill;
		_richTextBox.Location = new Point(6, 19);
		_richTextBox.Margin = new Padding(7);
		_richTextBox.Name = "_richTextBox";
		_richTextBox.Size = new Size(488, 106);
		_richTextBox.TabIndex = 0;
		_richTextBox.WordWrap = false;
		_richTextBox.SelectionChanged += new EventHandler(richTextBox_SelectionChanged);
		_richTextBox.KeyDown += new KeyEventHandler(richTextBox_KeyDown);
		_richTextBox.KeyPress += new KeyPressEventHandler(richTextBox_KeyPress);
		_richTextBox.TextChanged += new EventHandler(richTextBox_TextChanged);
		// 
		// groupBoxString
		// 
		_groupBoxString.Controls.Add(_panelInsertEditButtons);
		_groupBoxString.Controls.Add(_richTextBox);
		_groupBoxString.Dock = DockStyle.Fill;
		_groupBoxString.Location = new Point(0, 56);
		_groupBoxString.Name = "_groupBoxString";
		_groupBoxString.Padding = new Padding(6);
		_groupBoxString.Size = new Size(500, 131);
		_groupBoxString.TabIndex = 1;
		_groupBoxString.TabStop = false;
		_groupBoxString.Text = SR.LabelStringWithKeywords;
		// 
		// buttonEdit
		// 
		_buttonEdit.Enabled = false;
		_buttonEdit.Location = new Point(30, 34);
		_buttonEdit.Name = "_buttonEdit";
		_buttonEdit.Size = new Size(156, 27);
		_buttonEdit.TabIndex = 2;
		_buttonEdit.Text = SR.LabelEditKeyword;
		_buttonEdit.Click += new EventHandler(buttonEdit_Click);
		// 
		// buttonInsert
		// 
		_buttonInsert.Location = new Point(30, 2);
		_buttonInsert.Name = "_buttonInsert";
		_buttonInsert.Size = new Size(156, 27);
		_buttonInsert.TabIndex = 1;
		_buttonInsert.Text = SR.LabelInsertNewKeyword;
		_buttonInsert.Click += new EventHandler(buttonInsert_Click);
		// 
		// buttonOk
		// 
		_buttonOk.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
		_buttonOk.DialogResult = DialogResult.OK;
		_buttonOk.Location = new Point(305, 9);
		_buttonOk.Name = "_buttonOk";
		_buttonOk.Size = new Size(90, 27);
		_buttonOk.TabIndex = 2;
		_buttonOk.Text = SR.LabelButtonOk;
		_buttonOk.Click += new EventHandler(buttonOk_Click);
		// 
		// buttonCancel
		// 
		_buttonCancel.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
		_buttonCancel.DialogResult = DialogResult.Cancel;
		_buttonCancel.Location = new Point(401, 9);
		_buttonCancel.Name = "_buttonCancel";
		_buttonCancel.Size = new Size(90, 27);
		_buttonCancel.TabIndex = 3;
		_buttonCancel.Text = SR.LabelButtonCancel;
		// 
		// labelDescription
		// 
		_labelDescription.Dock = DockStyle.Top;
		_labelDescription.Location = new Point(0, 0);
		_labelDescription.Name = "_labelDescription";
		_labelDescription.Size = new Size(500, 56);
		_labelDescription.TabIndex = 0;
		_labelDescription.Text = SR.DesciptionCustomLabelEditorTitle;
		// 
		// _panelOkCancelButtons
		// 
		_panelOkCancelButtons.Controls.Add(_buttonOk);
		_panelOkCancelButtons.Controls.Add(_buttonCancel);
		_panelOkCancelButtons.Dock = DockStyle.Bottom;
		_panelOkCancelButtons.Location = new Point(4, 191);
		_panelOkCancelButtons.Name = "_panelOkCancelButtons";
		_panelOkCancelButtons.Padding = new Padding(6);
		_panelOkCancelButtons.Size = new Size(500, 44);
		_panelOkCancelButtons.TabIndex = 4;
		// 
		// _panelTopContent
		// 
		_panelTopContent.Controls.Add(_groupBoxString);
		_panelTopContent.Controls.Add(_labelDescription);
		_panelTopContent.Dock = DockStyle.Fill;
		_panelTopContent.Location = new Point(4, 4);
		_panelTopContent.Name = "_panelTopContent";
		_panelTopContent.Size = new Size(500, 187);
		_panelTopContent.TabIndex = 5;
		// 
		// _panelInsertEditButtons
		// 
		_panelInsertEditButtons.Controls.Add(_buttonInsert);
		_panelInsertEditButtons.Controls.Add(_buttonEdit);
		_panelInsertEditButtons.Dock = DockStyle.Right;
		_panelInsertEditButtons.Location = new Point(305, 19);
		_panelInsertEditButtons.Name = "_panelInsertEditButtons";
		_panelInsertEditButtons.Size = new Size(189, 106);
		_panelInsertEditButtons.TabIndex = 3;
		// 
		// KeywordsStringEditorForm
		// 
		CancelButton = _buttonCancel;
		ClientSize = new Size(524, 275);
		Controls.Add(_panelTopContent);
		Controls.Add(_panelOkCancelButtons);
		MaximizeBox = false;
		MinimizeBox = false;
		MinimumSize = new Size(524, 275);
		Padding = new Padding(4);
		ShowIcon = false;
		ShowInTaskbar = false;
		SizeGripStyle = SizeGripStyle.Show;
		StartPosition = FormStartPosition.CenterScreen;
		Name = "KeywordsStringEditorForm";
		Text = SR.LabelStringKeywordsEditor;
		Load += new EventHandler(KeywordsStringEditorForm_Load);
		_groupBoxString.ResumeLayout(false);
		_panelOkCancelButtons.ResumeLayout(false);
		_panelTopContent.ResumeLayout(false);
		_panelInsertEditButtons.ResumeLayout(false);
		ResumeLayout(false);

	}
	#endregion

	#region Event Handlers

	/// <summary>
	/// Form loaded event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void KeywordsStringEditorForm_Load(object sender, EventArgs e)
	{
		// Insert new line characters in the text
		_labelDescription.Text = _labelDescription.Text.Replace("\\n", "\n");

		// Load list of keywords applicable for the specified object and property.
		applicableKeywords = GetApplicableKeywords();
		if (applicableKeywords.Count == 0)
		{
			_buttonInsert.Enabled = false;
			_buttonEdit.Enabled = false;
		}

		if (!string.IsNullOrEmpty(_initialString))
		{
			// Set text to edit
			_richTextBox.Rtf = GetRtfText(_initialString);
		}
	}

	/// <summary>
	/// Insert keyword button clicked event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void buttonInsert_Click(object sender, EventArgs e)
	{
		// Show keyword editor form
		KeywordEditor keywordEditor = new(
			applicableKeywords,
			string.Empty,
			_maxYValueIndex);
		if (keywordEditor.ShowDialog() == DialogResult.OK)
		{
			if (_selectedKeywordLength > 0)
			{
				// Insert keyword at the end of curently selected keyword 
				// and separate them with space
				_richTextBox.SelectionStart += _richTextBox.SelectionLength;
				_richTextBox.SelectionLength = 0;
				_richTextBox.SelectedText = " " + keywordEditor.Keyword;
			}
			else
			{
				// Insert new keyword at current location
				_richTextBox.SelectionLength = Math.Max(0, _selectedKeywordLength);
				_richTextBox.SelectedText = keywordEditor.Keyword;
			}
		}

		// Set focus back to the editor
		_richTextBox.Focus();
	}

	/// <summary>
	/// Edit keyword button clicked event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void buttonEdit_Click(object sender, EventArgs e)
	{
		// Get seloected keyword
		string keyword = _richTextBox.Text.Substring(_selectedKeywordStart, _selectedKeywordLength);

		// Show keyword editor form
		KeywordEditor keywordEditor = new(
			applicableKeywords,
			keyword,
			_maxYValueIndex);
		if (keywordEditor.ShowDialog() == DialogResult.OK)
		{
			int start = _selectedKeywordStart;
			int length = _selectedKeywordLength;

			// Update currently selected kyword
			_richTextBox.Text = _richTextBox.Text[..start] +
				keywordEditor.Keyword +
				_richTextBox.Text[(start + length)..];
			_richTextBox.SelectionStart = start + keywordEditor.Keyword.Length;
		}

		// Set focus back to the editor
		_richTextBox.Focus();
	}

	/// <summary>
	/// Rich text box text changed event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void richTextBox_TextChanged(object sender, EventArgs e)
	{
		if (!_updating)
		{
			_updating = true;

			// Save current selection
			int selectionStart = _richTextBox.SelectionStart;
			int selectionLength = _richTextBox.SelectionLength;

			// Update RTF tex
			_richTextBox.Rtf = GetRtfText(_richTextBox.Text);

			// Restore selection
			_richTextBox.SelectionStart = selectionStart;
			_richTextBox.SelectionLength = selectionLength;

			_updating = false;
		}
	}

	/// <summary>
	/// Rich text box selection changed event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void richTextBox_SelectionChanged(object sender, EventArgs e)
	{
		// No any processing in selection mode with the Shift key down
		if ((ModifierKeys & Keys.Shift) != Keys.Shift)
		{
			if (!_updating)
			{
				_updating = true;

				// Update RTF text only when selected (bolded) keyword is changed
				string selectedKeywordTemp = _selectedKeywordName;
				string newRtf = GetRtfText(_richTextBox.Text);
				if (selectedKeywordTemp != _selectedKeywordName)
				{
					// Save current selection
					int selectionStart = _richTextBox.SelectionStart;

					// Update RTF text
					_richTextBox.Rtf = newRtf;

					// Restore selection
					_richTextBox.SelectionStart = selectionStart;
					_richTextBox.SelectionLength = 0;
				}

				_updating = false;
			}
		}
	}

	/// <summary>
	/// Rich text box key pressed event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void richTextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		// Make sure we enter a closing bracket when user starts 
		// entering the format string
		if (e.KeyChar == '{')
		{
			if (_richTextBox.SelectionColor == Color.Blue)
			{
				e.Handled = true;
				_richTextBox.SelectedText = "{}";
				_richTextBox.SelectionStart--;
			}
		}
	}

	/// <summary>
	/// Rich text box key down event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void richTextBox_KeyDown(object sender, KeyEventArgs e)
	{
		// Delete keyword when user press 'Delete' key
		if (e.KeyCode == Keys.Delete &&
			_selectedKeywordStart >= 0 &&
			_selectedKeywordLength > 0)
		{
			// Remember selection start because it will be changed as soon
			// as we update editor text
			int newSelectionPosition = _selectedKeywordStart;

			// Remove keyword
			string newText = _richTextBox.Text[.._selectedKeywordStart];
			newText += _richTextBox.Text[(_selectedKeywordStart + _selectedKeywordLength)..];
			_richTextBox.Text = newText;

			// Restore cursor (selection) position
			_richTextBox.SelectionStart = newSelectionPosition;
			e.Handled = true;
		}
	}


	/// <summary>
	/// Ok button pressed event handler.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void buttonOk_Click(object sender, EventArgs e)
	{
		// Get text from the editor
		ResultString = _richTextBox.Text;

		// New line character should be presented as 2 characters "\n"
		ResultString = ResultString.Replace("\r\n", "\\n");
		ResultString = ResultString.Replace("\n", "\\n");
	}

	#endregion // Event Handlers

	#region Helper Methods

	/// <summary>
	/// Helper method that generates the RTF text based on the string.
	/// </summary>
	/// <param name="originalText">Input text.</param>
	/// <returns>Input text formatted as RTF.</returns>
	private string GetRtfText(string originalText)
	{

		// Initialize empty string
		// Start with RTF header and font table
		string resultRtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}\r\n";

		// Add color table
		resultRtf += @"{\colortbl ;\red0\green0\blue255;}\r\n";

		// Add text starting tags
		resultRtf += @"\viewkind4\uc1\pard\f0\fs17 ";

		// Add text
		resultRtf += GetUnicodeRtf(GetColorHilightedRtfText(originalText));

		// Finish RTF format
		resultRtf += @"\par\r\n}";

		return resultRtf;
	}

	// VSTS: 65162: The non ansi 1252 characters will be lost, we need conversion in \uXXXX? format.
	private static string GetUnicodeRtf(string orginalText)
	{
		Text.StringBuilder result = new();
		foreach (char c in orginalText.ToCharArray())
		{
			int charInt = Convert.ToInt32(c);
			if (charInt < 0x00 || charInt > 0x7f)
			{
				result.Append(@"\u" + charInt.ToString() + "?");
			}
			else
			{
				result.Append(Convert.ToString(c));
			}
		}

		return result.ToString();
	}

	/// <summary>
	/// Gets specified text in RTF format where keyword are color highlighted.
	/// </summary>
	/// <param name="originalText">Original text.</param>
	/// <returns>Color higlighted RTF text.</returns>
	private string GetColorHilightedRtfText(string originalText)
	{
		string resultText = originalText;
		string selectedKeyword = string.Empty;

		// Reset selected keyword position
		_selectedKeywordStart = -1;
		_selectedKeywordLength = 0;

		// Current selection position that will be adjusted when formatting 
		// characters are added infron of it.
		int selectionStart = _richTextBox.SelectionStart;

		// Replace special new line character sequence "\n"
		resultText = resultText.Replace("\\n", "\r\n");

		// Replace special RTF Character '\'
		int slashCountre = 0;
		for (int index = 0; index < resultText.Length && index < selectionStart; index++)
		{
			if (resultText[index] == '\\')
			{
				++slashCountre;
			}
		}

		selectionStart += slashCountre;
		resultText = resultText.Replace(@"\", @"\\");

		// Iterate through all keywords 
		foreach (KeywordInfo keywordInfo in applicableKeywords)
		{
			// Fill array of possible names for that keyword
			string[] keywordNames = keywordInfo.GetKeywords();

			// Iterate through all possible names
			foreach (string keywordNameWithSpaces in keywordNames)
			{
				int startIndex = 0;

				// Trim spaces
				string keywordName = keywordNameWithSpaces.Trim();

				// Skip empty strings
				if (keywordName.Length > 0)
				{
					// Try finding the keyword in the string
					while ((startIndex = resultText.IndexOf(keywordName, startIndex, StringComparison.Ordinal)) >= 0)
					{
						int keywordLength = keywordName.Length;

						// Check if Y value index can be part of the keyword
						if (keywordInfo.SupportsValueIndex)
						{
							if (resultText.Length > (startIndex + keywordLength) &&
								resultText[startIndex + keywordLength] == 'Y')
							{
								++keywordLength;
								if (resultText.Length > (startIndex + keywordLength) &&
									char.IsDigit(resultText[startIndex + keywordLength]))
								{
									++keywordLength;
								}
							}
						}

						// Check if format string can be part of the keyword
						if (keywordInfo.SupportsFormatting)
						{
							if (resultText.Length > (startIndex + keywordLength) &&
								resultText[startIndex + keywordLength] == '{')
							{
								++keywordLength;
								int formatEndBracket = resultText.IndexOf("}", startIndex + keywordLength, StringComparison.Ordinal);
								if (formatEndBracket >= 0)
								{
									keywordLength += formatEndBracket - startIndex - keywordLength + 1;
								}
							}
						}

						// Check if cursor currently located inside the keyword
						bool isKeywordSelected = (selectionStart > (startIndex) &&
							selectionStart <= (startIndex + keywordLength));

						// Show Keyword with different color
						string tempText = resultText[..startIndex];
						string formattedKeyword = string.Empty;
						formattedKeyword += @"\cf1";
						if (isKeywordSelected)
						{
							// Remember selected keyword by name and position
							selectedKeyword = keywordInfo.Name;
							selectedKeyword += "__" + startIndex.ToString(CultureInfo.InvariantCulture);
							_selectedKeywordStart = startIndex;
							_selectedKeywordStart -= selectionStart - _richTextBox.SelectionStart;
							_selectedKeywordLength = keywordLength;

							formattedKeyword += @"\b";
						}

						formattedKeyword += @"\ul";
						// Replace keyword start symbol '#' with "#_" to avoid duplicate processing
						formattedKeyword += "#_";
						formattedKeyword += resultText.Substring(startIndex + 1, keywordLength - 1);
						formattedKeyword += @"\cf0";
						if (isKeywordSelected)
						{
							formattedKeyword += @"\b0";
						}

						formattedKeyword += @"\ul0 ";
						tempText += formattedKeyword;
						tempText += resultText[(startIndex + keywordLength)..];
						resultText = tempText;

						// Adjust selection position
						if (startIndex < selectionStart)
						{
							selectionStart += formattedKeyword.Length - keywordLength;
						}

						// Increase search start index by the length of the keyword
						startIndex += formattedKeyword.Length;
					}
				}
			}
		}

		// Set currenly selected keyword name
		_selectedKeywordName = selectedKeyword;

		// Update Edit button
		if (_selectedKeywordName.Length > 0)
		{
			// Enable Edit button and set it text
			_buttonEdit.Enabled = true;
		}
		else
		{
			_buttonEdit.Enabled = false;
		}

		// Replace all the "\n" strings with new line objectTag "\par"
		resultText = resultText.Replace("\r\n", @"\par ");
		resultText = resultText.Replace("\n", @"\par ");
		resultText = resultText.Replace("\\n", @"\par ");

		// Replace special RTF Characters '{' and '}'
		// Has to be done after all processing because this character is 
		// used in keywords formatting.
		resultText = resultText.Replace(@"{", @"\{");
		resultText = resultText.Replace(@"}", @"\}");

		// Replace the "#_" string with keyword start symbol.
		// This  was previously chnaged to avoid duplicate processing.
		return resultText.Replace("#_", "#");
	}

	/// <summary>
	/// Get list of keywords applicable to current object and property.
	/// </summary>
	/// <returns></returns>
	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	private ArrayList GetApplicableKeywords()
	{
		// Create new array
		ArrayList keywordList = [];

		// Get acess to the chart keywords registry
		if (KeywordsRegistry != null &&
			_propertyName.Length > 0 &&
			_classTypeName.Length > 0)
		{
			// Iterate through all keywords in the registry
			foreach (KeywordInfo keywordInfo in KeywordsRegistry._registeredKeywords)
			{
				// Check if keyword is supported by specified type
				bool typeSupported = false;
				string[] typeNames = keywordInfo.AppliesToTypes.Split(',');
				foreach (string typeName in typeNames)
				{
					if (_classTypeName == typeName.Trim())
					{
						typeSupported = true;
						break;
					}
				}

				// If type supported check property name
				if (typeSupported)
				{
					string[] propertyNames = keywordInfo.AppliesToProperties.Split(',');
					foreach (string propertyName in propertyNames)
					{
						if (_propertyName == propertyName.Trim())
						{
							// Add KeywordInfo into the list
							keywordList.Add(keywordInfo);
							break;
						}
					}
				}
			}
		}

		return keywordList;
	}

	/// <summary>
	/// VSTS: 787930 - Expand the dialog with widthDialogExtend, heightDialogExtend  to make room for localization.
	/// </summary>
	private void PrepareControlsLayout()
	{
		int buttonWidthAdd = 18;
		Width += widthDialogExtend;
		_panelOkCancelButtons.Width += widthDialogExtend;
		_panelInsertEditButtons.Width += widthDialogExtend;
		_buttonInsert.Width += widthDialogExtend + buttonWidthAdd;
		_buttonInsert.Left -= buttonWidthAdd;
		_buttonEdit.Width += widthDialogExtend + buttonWidthAdd;
		_buttonEdit.Left -= buttonWidthAdd;
		_labelDescription.Width += widthDialogExtend;

		Height += heightDialogExtend;
		_panelOkCancelButtons.Top += heightDialogExtend;
		_labelDescription.Height += heightDialogExtend;
	}

	#endregion // Helper Methods
}

/// <summary>
/// Editor for the string properties that may contain keyords.
/// </summary>
internal class KeywordsStringEditor : UITypeEditor
{
	#region Editor methods and properties

	// Editor services
	private IWindowsFormsEditorService _edSvc = null;

	/// <summary>
	/// Edit label format by showing the form
	/// </summary>
	/// <param name="context">Editing context.</param>
	/// <param name="provider">Provider.</param>
	/// <param name="value">Value to edit.</param>
	/// <returns>Result</returns>
	[SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily",
		Justification = "Too large of a code change to justify making this change")]
	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		if (context != null &&
			context.Instance != null &&
			provider != null &&
			context.PropertyDescriptor != null)
		{
			_edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
			if (_edSvc != null)
			{
				// Try getting access to the associated series
				Series series = null;
				Chart chart = null;
				object instance = context.Instance;

#if CHART_ACTLIST
                    // Special processing if editor is called from the smart tag
                    if (instance is ChartActionList)
                    {
                        chart = ((ChartActionList)instance).Chart;
                        ChartActionList.SelectedItemInfo selectedItemInfo = ((ChartActionList)instance).GetSelectedItemInfo();
                        if(selectedItemInfo != null)
                        {
                            instance = selectedItemInfo.SelectedObject;
                        }
                    }

#endif //CHART_ACTLIST
				// Check object instance edited
				if (instance is Series)
				{
					series = (Series)instance;
				}
				else if (instance is DataPoint)
				{
					series = ((DataPoint)instance).series;
				}
				else if (instance is LegendItem)
				{
					if (((LegendItem)instance).Common != null)
					{
						chart = ((LegendItem)instance).Common.Chart;
						if (((LegendItem)instance).Common.DataManager.Series.IndexOf(((LegendItem)instance).SeriesName) >= 0)
						{
							series = ((LegendItem)instance).Common.DataManager.Series[((LegendItem)instance).SeriesName];
						}
					}
				}
				else if (instance is LegendCellColumn)
				{
					if (((LegendCellColumn)instance).Legend != null)
					{
						chart = ((LegendCellColumn)instance).Legend.Common.Chart;
					}
				}

				else if (instance is Annotation)
				{
					chart = ((Annotation)instance).Chart;
					if (((Annotation)instance).AnchorDataPoint != null)
					{
						series = ((Annotation)instance).AnchorDataPoint.series;
					}
					else if (chart != null && chart.Series.Count > 0)
					{
						series = chart.Series[0];
					}
				}



				// Make sure chart reference was found
				if (chart == null && series != null)
				{
					chart = series.Chart;
				}

				// Get maximum number of Y values
				int maxYValueNumber = 9;
				if (series != null)
				{
					maxYValueNumber = series.YValuesPerPoint - 1;
				}
				else if (chart != null)
				{
					// Find MAX number of Y values use in all series
					maxYValueNumber = 0;
					foreach (Series ser in chart.Series)
					{
						maxYValueNumber = Math.Max(maxYValueNumber, ser.YValuesPerPoint - 1);
					}
				}

				// Show editor form
				KeywordsStringEditorForm form = new(
					(string)value,
						instance.GetType().Name,
					context.PropertyDescriptor.Name,
					maxYValueNumber);
				if (chart != null)
				{
					form.KeywordsRegistry = (KeywordsRegistry)chart.GetService(typeof(KeywordsRegistry));
				}

				_edSvc.ShowDialog(form);
				value = form.ResultString;
			}
		}

		return value;
	}

	/// <summary>
	/// Show modal form.
	/// </summary>
	/// <param name="context">Editing context.</param>
	/// <returns>Editor style.</returns>
	public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
	{
		if (context != null && context.Instance != null)
		{
			return UITypeEditorEditStyle.Modal;
		}

		return base.GetEditStyle(context);
	}

	#endregion
}


