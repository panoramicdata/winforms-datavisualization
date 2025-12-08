// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	AxisName converter of the design-time CustomProperties
//				property object.
//


using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;

using System.Windows.Forms.DataVisualization.Charting.Utilities;


namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Custom properties object type converter.
/// </summary>
internal class CustomPropertiesTypeConverter : TypeConverter
{
	#region String to/from convertion methods

	/// <summary>
	/// Overrides the CanConvertFrom method of TypeConverter.
	/// </summary>
	/// <param name="context">Descriptor context.</param>
	/// <param name="sourceType">Convertion source type.</param>
	/// <returns>Indicates if convertion is possible.</returns>
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		if (sourceType == typeof(string))
		{
			return true;
		}

		return base.CanConvertFrom(context, sourceType);
	}

	/// <summary>
	/// Overrides the CanConvertTo method of TypeConverter.
	/// </summary>
	/// <param name="context">Descriptor context.</param>
	/// <param name="destinationType">Destination type.</param>
	/// <returns>Indicates if convertion is possible.</returns>
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		if (destinationType == typeof(CustomProperties))
		{
			return true;
		}

		return base.CanConvertTo(context, destinationType);
	}

	/// <summary>
	/// Overrides the ConvertTo method of TypeConverter.
	/// </summary>
	/// <param name="context">Descriptor context.</param>
	/// <param name="culture">Culture information.</param>
	/// <param name="value">Value to convert.</param>
	/// <param name="destinationType">Convertion destination type.</param>
	/// <returns>Converted object.</returns>
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == typeof(string))
		{
			return ((CustomProperties)value).DataPointCustomProperties.CustomProperties;
		}

		return base.ConvertTo(context, culture, value, destinationType);
	}

	/// <summary>
	/// Overrides the ConvertFrom method of TypeConverter.
	/// Converts from string with comma separated values.
	/// </summary>
	/// <param name="context">Descriptor context.</param>
	/// <param name="culture">Culture information.</param>
	/// <param name="value">Value to convert from.</param>
	/// <returns>Indicates if convertion is possible.</returns>
	[SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily",
		Justification = "Too large of a code change to justify making this change")]
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string stringValue && context != null && context.Instance != null)
		{
			// Create new custom attribute class with a reference to the DataPointCustomProperties
			if (context.Instance is DataPointCustomProperties)
			{
				((DataPointCustomProperties)context.Instance).CustomProperties = stringValue;
				CustomProperties newAttributes = new(((DataPointCustomProperties)context.Instance));
				return newAttributes;
			}

			else if (context.Instance is CustomProperties)
			{
				CustomProperties newAttributes = new(((CustomProperties)context.Instance).DataPointCustomProperties);
				return newAttributes;
			}
			else if (context.Instance is IDataPointCustomPropertiesProvider)
			{
				CustomProperties newAttributes = new(((IDataPointCustomPropertiesProvider)context.Instance).DataPointCustomProperties);
				return newAttributes;
			}

			else if (context.Instance is Array)
			{
				DataPointCustomProperties attributes = null;
				foreach (object obj in ((Array)context.Instance))
				{
					if (obj is DataPointCustomProperties)
					{
						attributes = (DataPointCustomProperties)obj;
						attributes.CustomProperties = stringValue;
					}
				}

				if (attributes != null)
				{
					CustomProperties newAttributes = new(attributes);
					return newAttributes;
				}
			}
		}

		return base.ConvertFrom(context, culture, value);
	}

	#endregion // String to/from convertion methods

	#region Property Descriptor Collection methods

	/// <summary>
	/// Returns whether this object supports properties.
	/// </summary>
	/// <param name="context">An ITypeDescriptorContext that provides a format context.</param>
	/// <returns>true if GetProperties should be called to find the properties of this object; otherwise, false.</returns>
	public override bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		return true;
	}

	/// <summary>
	/// Returns a collection of properties for the type of array specified by the value parameter,
	/// using the specified context and properties.
	/// </summary>
	/// <param name="context">An ITypeDescriptorContext that provides a format context.</param>
	/// <param name="obj">An Object that specifies the type of array for which to get properties.</param>
	/// <param name="attributes">An array of type Attribute that is used as a filter.</param>
	/// <returns>A PropertyDescriptorCollection with the properties that are exposed for this data type, or a null reference (Nothing in Visual Basic) if there are no properties.</returns>
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object obj, Attribute[] attributes)
	{
		PropertyDescriptorCollection propCollection = new(null);
		if (obj is CustomProperties attr && context != null)
		{
			// Get series associated with custom attribute
			Series series = (attr.DataPointCustomProperties is Series) ? ((Series)attr.DataPointCustomProperties) : attr.DataPointCustomProperties.series;
			if (series != null &&
				series.Common != null)
			{
				// Loop through all registered custom properties
				CustomPropertyRegistry registry = (CustomPropertyRegistry)series.Common.container.GetService(typeof(CustomPropertyRegistry));
				foreach (CustomPropertyInfo attrInfo in registry.registeredCustomProperties)
				{
					// Check if attribute description matches curent selection in property browser
					if (IsApplicableCustomProperty(attrInfo, context.Instance))
					{
						// Get array of property properties
						Attribute[] propAttributes = GetPropertyAttributes(attrInfo);

						// Create property descriptor
						CustomAttributesPropertyDescriptor propertyDescriptor = new(
							typeof(CustomProperties),
							attrInfo.Name,
							attrInfo.ValueType,
							propAttributes,
							attrInfo);

						// Add descriptor into the collection
						propCollection.Add(propertyDescriptor);
					}
				}

				// Always add "UserDefined" property for all user defined custom properties
				Attribute[] propUserDefinedAttributes = [
						new NotifyParentPropertyAttribute(true),
						new RefreshPropertiesAttribute(RefreshProperties.All),
						new DescriptionAttribute(SR.DescriptionAttributeUserDefined)
					];

				// Create property descriptor
				CustomAttributesPropertyDescriptor propertyUserDefinedDescriptor = new(
					typeof(CustomProperties),
					"UserDefined",
					typeof(string),
					propUserDefinedAttributes,
					null);

				// Add descriptor into the collection
				propCollection.Add(propertyUserDefinedDescriptor);
			}
		}

		return propCollection;
	}

	/// <summary>
	/// Checks if provided custom attribute appies to the selected points or series.
	/// </summary>
	/// <param name="attrInfo">Custom attribute information.</param>
	/// <param name="obj">Selected series or points.</param>
	/// <returns>True if custom attribute applies.</returns>
	private bool IsApplicableCustomProperty(CustomPropertyInfo attrInfo, object obj)
	{
		if (obj is CustomProperties customProperties)
		{
			obj = customProperties.DataPointCustomProperties;
		}

		// Check if custom attribute applies to the series or points
		if ((IsDataPoint(obj) && attrInfo.AppliesToDataPoint) ||
			(!IsDataPoint(obj) && attrInfo.AppliesToSeries))
		{
			// Check if attribute do not apply to 3D or 2D chart types
			if ((Is3DChartType(obj) && attrInfo.AppliesTo3D) ||
				(!Is3DChartType(obj) && attrInfo.AppliesTo2D))
			{

				// Check if custom attribute applies to the chart types selected
				SeriesChartType[] chartTypes = GetSelectedChartTypes(obj);
				foreach (SeriesChartType chartType in chartTypes)
				{
					foreach (SeriesChartType attrChartType in attrInfo.AppliesToChartType)
					{
						if (attrChartType == chartType)
						{
							return true;
						}
					}
				}

			}
		}

		return false;
	}

	/// <summary>
	/// Checks if specified object represent a single or array of data points.
	/// </summary>
	/// <param name="obj">Object to test.</param>
	/// <returns>True if specified object contains one or more data points.</returns>
	private bool IsDataPoint(object obj)
	{
		if (obj is Series series)
		{
			return false;
		}

		if (obj is Array array && array.Length > 0)
		{
			if (array.GetValue(0) is Series)
			{
				return false;
			}
		}

		return true;
	}

	/// <summary>
	/// Checks if specified object represent a single or array of data points.
	/// </summary>
	/// <param name="obj">Object to test.</param>
	/// <returns>True if specified object contains one or more data points.</returns>
	private bool Is3DChartType(object obj)
	{
		// Get array of series
		Series[] seriesArray = GetSelectedSeries(obj);

		// Loop through all series and check if its plotted on 3D chart area
		foreach (Series series in seriesArray)
		{
			ChartArea chartArea = series.Chart.ChartAreas[series.ChartArea];
			if (chartArea.Area3DStyle.Enable3D)
			{
				return true;
			}
		}

		return false;
	}

	/// <summary>
	/// Get array of selected series.
	/// </summary>
	/// <param name="obj">Selected objects.</param>
	/// <returns>Selected series array.</returns>
	[SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily",
		Justification = "Too large of a code change to justify making this change")]
	private Series[] GetSelectedSeries(object obj)
	{
		// Get array of series
		Series[] seriesArray = [];
		if (obj is Array && ((Array)obj).Length > 0)
		{
			if (((Array)obj).GetValue(0) is Series)
			{
				seriesArray = new Series[((Array)obj).Length];
				((Array)obj).CopyTo(seriesArray, 0);
			}
			else if (((Array)obj).GetValue(0) is DataPointCustomProperties)
			{
				seriesArray = [((DataPointCustomProperties)((Array)obj).GetValue(0)).series];
			}
		}
		else if (obj is Series)
		{
			seriesArray = [((Series)obj)];
		}
		else if (obj is DataPointCustomProperties)
		{
			seriesArray = [((DataPointCustomProperties)obj).series];
		}

		return seriesArray;
	}

	/// <summary>
	/// Get array of chart types from the selected series.
	/// </summary>
	/// <param name="obj">Selected series or data points.</param>
	/// <returns>Array of selected chart types.</returns>
	private SeriesChartType[] GetSelectedChartTypes(object obj)
	{
		// Get array of series
		Series[] seriesArray = GetSelectedSeries(obj);

		// Create array of chart types
		int index = 0;
		SeriesChartType[] chartTypes = new SeriesChartType[seriesArray.Length];
		foreach (Series series in seriesArray)
		{
			chartTypes[index++] = series.ChartType;
		}

		return chartTypes;
	}

	/// <summary>
	/// Gets array of properties for the dynamic property.
	/// </summary>
	/// <param name="attrInfo">Custom attribute information.</param>
	/// <returns>Array of properties.</returns>
	private Attribute[] GetPropertyAttributes(CustomPropertyInfo attrInfo)
	{
		// Create default value attribute
		DefaultValueAttribute defaultValueAttribute;
		if (attrInfo.DefaultValue.GetType() == attrInfo.ValueType)
		{
			defaultValueAttribute = new DefaultValueAttribute(attrInfo.DefaultValue);
		}
		else if (attrInfo.DefaultValue is string)
		{
			defaultValueAttribute = new DefaultValueAttribute(attrInfo.ValueType, (string)attrInfo.DefaultValue);
		}
		else
		{
			throw (new InvalidOperationException(SR.ExceptionCustomAttributeDefaultValueTypeInvalid));
		}
		// Add all properties into the list
		ArrayList propList =
		[
			new NotifyParentPropertyAttribute(true),
			new RefreshPropertiesAttribute(RefreshProperties.All),
			new DescriptionAttribute(attrInfo.Description),
			defaultValueAttribute,
		];

		if (attrInfo.Name.Equals(CustomPropertyName.ErrorBarType, StringComparison.Ordinal))
		{
			propList.Add(new TypeConverterAttribute(typeof(ErrorBarTypeConverter)));
		}

		// Convert list to array
		int index = 0;
		Attribute[] propAttributes = new Attribute[propList.Count];
		foreach (Attribute attr in propList)
		{
			propAttributes[index++] = attr;
		}

		return propAttributes;
	}

	/// <summary>
	/// Special convertor for ErrorBarType custom attribute
	/// </summary>
	internal class ErrorBarTypeConverter : StringConverter
	{
		/// <summary>
		/// Returns whether this object supports a standard set of values that can be picked from a list, using the specified context.
		/// </summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
		/// <returns>
		/// true if <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues"/> should be called to find a common set of values the object supports; otherwise, false.
		/// </returns>
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>
		/// Returns whether the collection of standard values returned from <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues"/> is an exclusive list of possible values, using the specified context.
		/// </summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
		/// <returns>
		/// true if the <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection"/> returned from <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues"/> is an exhaustive list of possible values; false if other values are possible.
		/// </returns>
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return false;
		}

		/// <summary>
		/// Returns a collection of standard values for the data type this type converter is designed for when provided with a format context.
		/// </summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context that can be used to extract additional information about the environment from which this converter is invoked. This parameter or properties of this parameter can be null.</param>
		/// <returns>
		/// A <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection"/> that holds a standard set of valid values, or null if the data type does not support a standard set of values.
		/// </returns>
		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			ArrayList result = [];
			foreach (ChartTypes.ErrorBarType item in Enum.GetValues(typeof(ChartTypes.ErrorBarType)))
			{
				string itemStr = string.Format(CultureInfo.InvariantCulture, "{0}({1:N0})", item, ChartTypes.ErrorBarChart.DefaultErrorBarTypeValue(item));
				result.Add(itemStr);
			}

			return new StandardValuesCollection(result);
		}
	}

	#endregion // Property Descriptor Collection methods

	#region Custom Attributes Property Descriptor

	/// <summary>
	/// Custom properties inner property descriptor class.
	/// </summary>
	protected class CustomAttributesPropertyDescriptor : SimplePropertyDescriptor
	{
		#region Fields

		// Property name
		private readonly string _name = string.Empty;

		// Custom attribute information
		private readonly CustomPropertyInfo _customAttributeInfo = null;

		#endregion // Fields

		#region Constructor

		/// <summary>
		/// Property descriptor constructor.
		/// </summary>
		/// <param name="componentType">Component type.</param>
		/// <param name="name">Property name.</param>
		/// <param name="propertyType">Property type.</param>
		/// <param name="attributes">Property attributes.</param>
		/// <param name="customAttributeInfo">Custom attribute information.</param>
		internal CustomAttributesPropertyDescriptor(
			Type componentType,
			string name,
			Type propertyType,
			Attribute[] attributes,
			CustomPropertyInfo customAttributeInfo)
			: base(componentType, name, propertyType, attributes)
		{
			_name = name;
			_customAttributeInfo = customAttributeInfo;
		}

		#endregion // Constructor

		#region Methods

		/// <summary>
		/// Gets the current value of the property on a component.
		/// </summary>
		/// <param name="component">The component with the property for which to retrieve the value.</param>
		/// <returns>The value of a property for a given component.</returns>
		public override object GetValue(object component)
		{
			// "UserDefined" property expose comma separated user defined properties
			CustomProperties customAttr = component as CustomProperties;
			if (_name == "UserDefined")
			{
				return customAttr.GetUserDefinedCustomProperties();
			}
			else
			{

				// Check if custom attribute with this name is set
				string stringValue = customAttr.DataPointCustomProperties[_name];
				object val;
				if (_customAttributeInfo != null)
				{
					if (stringValue == null || stringValue.Length == 0)
					{
						val = GetValueFromString(_customAttributeInfo.DefaultValue);
					}
					else
					{
						val = GetValueFromString(stringValue);
					}
				}
				else
				{
					val = stringValue;
				}

				return val;
			}
		}

		/// <summary>
		/// Sets the value of the component to a different value.
		/// </summary>
		/// <param name="component">The component with the property value that is to be set.</param>
		/// <param name="value">The new value.</param>
		public override void SetValue(object component, object value)
		{
			// Validate new value
			ValidateValue(_name, value);

			// Get new value as string
			string stringValue = GetStringFromValue(value);

			// "UserDefined" property expose comma separated user defined properties
			CustomProperties customAttr = component as CustomProperties;
			if (_name == "UserDefined")
			{
				customAttr.SetUserDefinedAttributes(stringValue);
			}
			else
			{
				// Check if the new value is the same as DefaultValue
				bool setAttributeValue = true;
				if (IsDefaultValue(stringValue))
				{
					// Remove custom properties with default values from data point
					// only when series do not have this attribute set.
					if (!(customAttr.DataPointCustomProperties is DataPoint) ||
						!((DataPoint)customAttr.DataPointCustomProperties).series.IsCustomPropertySet(_name))
					{
						// Delete attribute
						if (customAttr.DataPointCustomProperties.IsCustomPropertySet(_name))
						{
							customAttr.DataPointCustomProperties.DeleteCustomProperty(_name);
							setAttributeValue = false;
						}
					}
				}

				// Set custom attribute value
				if (setAttributeValue)
				{
					customAttr.DataPointCustomProperties[_name] = stringValue;
				}
			}

			customAttr.DataPointCustomProperties.CustomProperties = customAttr.DataPointCustomProperties.CustomProperties;

			if (component is IChangeTracking changeTracking)
			{
				changeTracking.AcceptChanges();
			}

		}

		/// <summary>
		/// Checks if specified value is the default value of the attribute.
		/// </summary>
		/// <param name="val">Value to check.</param>
		/// <returns>True if specified value is the default attribute value.</returns>
		public bool IsDefaultValue(string val)
		{
			// Get default value string
			string defaultValue = GetStringFromValue(_customAttributeInfo.DefaultValue);
			return (string.Compare(val, defaultValue, StringComparison.Ordinal) == 0);
		}

		/// <summary>
		/// Gets value from string a native type of attribute.
		/// </summary>
		/// <param name="obj">Object to convert to string.</param>
		/// <returns>String representation of the specified object.</returns>
		public virtual object GetValueFromString(object obj)
		{
			object result = null;
			if (obj != null)
			{
				if (_customAttributeInfo.ValueType == obj.GetType())
				{
					return obj;
				}

				if (obj is string stringValue)
				{
					if (_customAttributeInfo.ValueType == typeof(string))
					{
						result = stringValue;
					}
					else if (_customAttributeInfo.ValueType == typeof(float))
					{
						result = float.Parse(stringValue, CultureInfo.InvariantCulture);
					}
					else if (_customAttributeInfo.ValueType == typeof(double))
					{
						result = double.Parse(stringValue, CultureInfo.InvariantCulture);
					}
					else if (_customAttributeInfo.ValueType == typeof(int))
					{
						result = int.Parse(stringValue, CultureInfo.InvariantCulture);
					}
					else if (_customAttributeInfo.ValueType == typeof(bool))
					{
						result = bool.Parse(stringValue);
					}
					else if (_customAttributeInfo.ValueType == typeof(Color))
					{
						ColorConverter colorConverter = new();
						result = (Color)colorConverter.ConvertFromString(null, CultureInfo.InvariantCulture, stringValue);
					}
					else if (_customAttributeInfo.ValueType.IsEnum)
					{
						result = Enum.Parse(_customAttributeInfo.ValueType, stringValue, true);
					}
					else
					{
						throw (new InvalidOperationException(SR.ExceptionCustomAttributeTypeUnsupported(_customAttributeInfo.ValueType.ToString())));
					}

				}
			}

			return result;
		}


		/// <summary>
		/// Converts attribute value to string.
		/// </summary>
		/// <param name="value">Attribute value to convert.</param>
		/// <returns>Return attribute value converted to string.</returns>
		public string GetStringFromValue(object value)
		{
			if (value is Color)
			{
				ColorConverter colorConverter = new();
				return colorConverter.ConvertToString(null, CultureInfo.InvariantCulture, value);
			}
			else if (value is float)
			{
				return ((float)value).ToString(CultureInfo.InvariantCulture);
			}
			else if (value is double)
			{
				return ((double)value).ToString(CultureInfo.InvariantCulture);
			}
			else if (value is int)
			{
				return ((int)value).ToString(CultureInfo.InvariantCulture);
			}
			else if (value is bool)
			{
				return ((bool)value).ToString();
			}

			return value.ToString();
		}

		/// <summary>
		/// Validates attribute value. Method throws exception in case of any issues.
		/// </summary>
		/// <param name="attrName">Attribute name.</param>
		/// <param name="value">Attribute value to validate.</param>
		[SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily",
			Justification = "Too large of a code change to justify making this change")]
		public virtual void ValidateValue(string attrName, object value)
		{
			// Check for validation rules
			if (_customAttributeInfo == null)
			{
				return;
			}

			// Check if property Min/Max value is provided
			bool outOfRange = false;
			if (_customAttributeInfo.MaxValue != null)
			{
				if (value.GetType() != _customAttributeInfo.MaxValue.GetType())
				{
					throw (new InvalidOperationException(SR.ExceptionCustomAttributeTypeOrMaximumPossibleValueInvalid(attrName)));
				}

				if (value is float)
				{
					if ((float)value > (float)_customAttributeInfo.MaxValue)
					{
						outOfRange = true;
					}
				}
				else if (value is double)
				{
					if ((double)value > (double)_customAttributeInfo.MaxValue)
					{
						outOfRange = true;
					}
				}
				else if (value is int)
				{
					if ((int)value > (int)_customAttributeInfo.MaxValue)
					{
						outOfRange = true;
					}
				}
				else
				{
					throw (new InvalidOperationException(SR.ExceptionCustomAttributeTypeOrMinimumPossibleValueUnsupported(attrName)));
				}

			}

			// Check if property Min value is provided
			if (_customAttributeInfo.MinValue != null)
			{
				if (value.GetType() != _customAttributeInfo.MinValue.GetType())
				{
					throw (new InvalidOperationException(SR.ExceptionCustomAttributeTypeOrMinimumPossibleValueInvalid(attrName)));
				}

				if (value is float)
				{
					if ((float)value < (float)_customAttributeInfo.MinValue)
					{
						outOfRange = true;
					}
				}
				else if (value is double)
				{
					if ((double)value < (double)_customAttributeInfo.MinValue)
					{
						outOfRange = true;
					}
				}
				else if (value is int)
				{
					if ((int)value < (int)_customAttributeInfo.MinValue)
					{
						outOfRange = true;
					}
				}
				else
				{
					throw (new InvalidOperationException(SR.ExceptionCustomAttributeTypeOrMinimumPossibleValueUnsupported(attrName)));
				}
			}

			// Value out of range exception
			if (outOfRange)
			{
				if (_customAttributeInfo.MaxValue != null && _customAttributeInfo.MinValue != null)
				{
					throw (new InvalidOperationException(SR.ExceptionCustomAttributeMustBeInRange(attrName, _customAttributeInfo.MinValue.ToString(), _customAttributeInfo.MaxValue.ToString())));
				}
				else if (_customAttributeInfo.MinValue != null)
				{
					throw (new InvalidOperationException(SR.ExceptionCustomAttributeMustBeBiggerThenValue(attrName, _customAttributeInfo.MinValue.ToString())));
				}
				else if (_customAttributeInfo.MaxValue != null)
				{
					throw (new InvalidOperationException(SR.ExceptionCustomAttributeMustBeMoreThenValue(attrName, _customAttributeInfo.MaxValue.ToString())));
				}
			}
		}

		#endregion // Methods
	}

	#endregion // Custom Attributes Property Descriptor
}


/// <summary>
/// Property descriptor with ability to dynamically change properties 
/// of the base property descriptor object.
/// </summary>
internal class DynamicPropertyDescriptor : PropertyDescriptor
{
	#region Fields

	// Reference to the base property descriptor
	private readonly PropertyDescriptor _basePropertyDescriptor = null;

	// Dynamic display name of the property
	private readonly string _displayName = string.Empty;

	#endregion // Fields 

	#region Constructor

	/// <summary>
	/// Constructor of the dynamic property descriptor.
	/// </summary>
	/// <param name="basePropertyDescriptor">Base property descriptor.</param>
	/// <param name="displayName">New display name of the property.</param>
	public DynamicPropertyDescriptor(
		PropertyDescriptor basePropertyDescriptor,
		string displayName)
		: base(basePropertyDescriptor)
	{
		_displayName = displayName;
		_basePropertyDescriptor = basePropertyDescriptor;
	}

	#endregion // Constructor

	#region Properties

	/// <summary>
	/// Gets the type of the component this property is bound to.
	/// </summary>
	public override Type ComponentType
	{
		get
		{
			return _basePropertyDescriptor.ComponentType;
		}
	}

	/// <summary>
	/// Gets the name that can be displayed in a window, such as a Properties window.
	/// </summary>
	public override string DisplayName
	{
		get
		{
			if (_displayName.Length > 0)
			{
				return _displayName;
			}

			return _basePropertyDescriptor.DisplayName;
		}
	}

	/// <summary>
	/// Gets a value indicating whether this property is browsable.
	/// </summary>
	public override bool IsBrowsable
	{
		get
		{
			return _basePropertyDescriptor.IsBrowsable;
		}
	}

	/// <summary>
	/// Gets a value indicating whether this property is read-only.
	/// </summary>
	public override bool IsReadOnly
	{
		get
		{
			return _basePropertyDescriptor.IsReadOnly;
		}
	}

	/// <summary>
	/// Gets the type of the property.
	/// </summary>
	public override Type PropertyType
	{
		get
		{
			return _basePropertyDescriptor.PropertyType;
		}
	}

	#endregion // Properties

	#region Methods

	/// <summary>
	/// Returns whether resetting an object changes its value.
	/// </summary>
	/// <param name="component">The component to test for reset capability.</param>
	/// <returns>true if resetting the component changes its value; otherwise, false.</returns>
	public override bool CanResetValue(object component)
	{
		return _basePropertyDescriptor.CanResetValue(component);
	}

	/// <summary>
	/// Gets the current value of the property on a component.
	/// </summary>
	/// <param name="component">The component with the property for which to retrieve the value.</param>
	/// <returns>The value of a property for a given component.</returns>
	public override object GetValue(object component)
	{
		return _basePropertyDescriptor.GetValue(component);
	}

	/// <summary>
	/// Resets the value for this property of the component to the default value.
	/// </summary>
	/// <param name="component">The component with the property value that is to be reset to the default value.</param>
	public override void ResetValue(object component)
	{
		_basePropertyDescriptor.ResetValue(component);
	}

	/// <summary>
	/// Determines a value indicating whether the value of this property needs to be persisted.
	/// </summary>
	/// <param name="component">The component with the property to be examined for persistence.</param>
	/// <returns>True if the property should be persisted; otherwise, false.</returns>
	public override bool ShouldSerializeValue(object component)
	{
		return _basePropertyDescriptor.ShouldSerializeValue(component);
	}

	/// <summary>
	/// Sets the value of the component to a different value.
	/// </summary>
	/// <param name="component">The component with the property value that is to be set.</param>
	/// <param name="value">The new value.</param>
	public override void SetValue(object component, object value)
	{
		_basePropertyDescriptor.SetValue(component, value);
	}

	#endregion // Methods
}

internal interface IDataPointCustomPropertiesProvider
{
	DataPointCustomProperties DataPointCustomProperties { get; }
}
