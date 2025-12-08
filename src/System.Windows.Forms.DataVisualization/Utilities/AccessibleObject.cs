// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Chart control accessible object.
//


using System.Collections.Generic;

namespace System.Windows.Forms.DataVisualization.Charting.Utilities;

using System.Drawing;

internal class ChartAccessibleObject : Control.ControlAccessibleObject
{
	#region Fields

	// Reference to the chart control
	private readonly Chart _chart = null;

	// List of chart accessible objects
	private List<AccessibleObject> _chartAccessibleObjectList = null;

	// Position of the chart in screen coordinates (optianl can be set to empty)
	private Point _chartScreenPosition = Point.Empty;

	// Chart scaleView transformation matrix
	private PointF _chartScale = new(1f, 1f);

	#endregion // Fields

	#region Constructors

	/// <summary>
	/// Object constructor.
	/// </summary>
	/// <param name="chart">Reference to the chart control.</param>
	public ChartAccessibleObject(Chart chart) : base(chart)
	{
		_chart = chart;
	}

	#endregion // Constructors

	#region Properties

	/// <summary>
	/// Position of the chart in screen coordinates (optianl can be set to empty)
	/// </summary>
	public Point ChartScreenPosition
	{
		get
		{
			return _chartScreenPosition;
		}
	}

	/// <summary>
	/// Gets the role for the Chart. This is used by accessibility programs.
	/// </summary>
	public override AccessibleRole Role
	{
		get
		{
			return AccessibleRole.Chart;
		}
	}

	#endregion // Properties

	#region Methods

	/// <summary>
	/// Indicates if chart child accessibility objects should be reset
	/// </summary>
	public void ResetChildren()
	{
		_chartAccessibleObjectList = null;
	}

	/// <summary>
	/// Chart child count.
	/// </summary>
	/// <returns>Number of chart child eleements.</returns>
	public override int GetChildCount()
	{
		// Fill list of chart accessible child elements
		if (_chartAccessibleObjectList == null)
		{
			FillChartAccessibleObjectList();
		}

		return _chartAccessibleObjectList.Count;
	}

	/// <summary>
	/// Get chart child element by index.
	/// </summary>
	/// <param name="index">Index of the chart child element.</param>
	/// <returns>Chart element accessibility object.</returns>
	public override AccessibleObject GetChild(int index)
	{
		// Fill list of chart accessible child elements
		if (_chartAccessibleObjectList == null)
		{
			FillChartAccessibleObjectList();
		}

		// Return accessible object by index
		if (index >= 0 && index < _chartAccessibleObjectList.Count)
		{
			return _chartAccessibleObjectList[index];
		}

		return null;
	}

	/// <summary>
	/// Creates a list of chart accessible child elements.
	/// </summary>
	/// <returns>List of chart accessible child elements.</returns>
	private void FillChartAccessibleObjectList()
	{
		// Create new list
		_chartAccessibleObjectList = [];

		// Chart reference must set first
		if (_chart != null)
		{
			// Add all Titles into the list
			foreach (Title title in _chart.Titles)
			{
				_chartAccessibleObjectList.Add(new ChartChildAccessibleObject(
					this,
					this,
					title,
					ChartElementType.Title,
					SR.AccessibilityTitleName(title.Name),
					title.Text,
					AccessibleRole.StaticText));
			}

			// Add all Legends into the list
			foreach (Legend legend in _chart.Legends)
			{
				_chartAccessibleObjectList.Add(new ChartChildLegendAccessibleObject(this, legend));
			}

			// Add all Chart Areas into the list
			foreach (ChartArea chartArea in _chart.ChartAreas)
			{
				_chartAccessibleObjectList.Add(new ChartChildChartAreaAccessibleObject(this, chartArea));
			}

			// Add all annotations into the list
			foreach (Annotation annotation in _chart.Annotations)
			{
				if (annotation is TextAnnotation textAnnotation)
				{
					_chartAccessibleObjectList.Add(new ChartChildAccessibleObject(
						this,
						this,
						annotation,
						ChartElementType.Annotation,
						SR.AccessibilityAnnotationName(annotation.Name),
						textAnnotation.Text,
						AccessibleRole.StaticText));
				}
				else
				{
					_chartAccessibleObjectList.Add(new ChartChildAccessibleObject(
						this,
						this,
						annotation,
						ChartElementType.Annotation,
						SR.AccessibilityAnnotationName(annotation.Name),
						string.Empty,
						AccessibleRole.Graphic));
				}
			}
		}
	}

	/// <summary>
	/// Navigates from specified child into specified direction.
	/// </summary>
	/// <param name="chartChildElement">Chart child element.</param>
	/// <param name="chartElementType">Chart child element type.</param>
	/// <param name="direction">Navigation direction.</param>
	/// <returns>Accessibility object we just navigated to.</returns>
	[Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "direction"),
	Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "chartElementType"),
	Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "chartChildElement")]
	public AccessibleObject NavigateFromChild(object chartChildElement, ChartElementType chartElementType, AccessibleNavigation direction)
	{
		// Not Implemented. Requires Selection Manager code changes. Remove CodeAnalysis.SuppressMessageAttributes
		return null;
	}

	/// <summary>
	/// Selects child chart element.
	/// </summary>
	/// <param name="chartChildElement">Chart child element.</param>
	/// <param name="chartElementType">Chart child element type.</param>
	/// <param name="selection">Selection actin.</param>
	[Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "selection"),
	Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "chartElementType"),
	Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "chartChildElement")]
	public void SelectChild(object chartChildElement, ChartElementType chartElementType, AccessibleSelection selection)
	{
		// Not Implemented. Requires Selection Manager code changes. Remove CodeAnalysis.SuppressMessageAttributes
	}

	/// <summary>
	/// Checks if specified chart child element is selected.
	/// </summary>
	/// <param name="chartChildElement">Chart child element.</param>
	/// <param name="chartElementType">Chart child element type.</param>
	/// <returns>True if child is selected.</returns>
	[Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "chartElementType"),
	Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "chartChildElement")]
	public bool IsChildSelected(object chartChildElement, ChartElementType chartElementType)
	{
		// Not Implemented. Requires Selection Manager code changes. Remove CodeAnalysis.SuppressMessageAttributes
		return false;
	}

	/// <summary>
	/// Gets chart child element bounds position in screen coordinates
	/// </summary>
	/// <param name="chartElement">Chart child element.</param>
	/// <param name="chartElementType">Chart child element type.</param>
	/// <param name="seriesName">Series name.</param>
	/// <param name="pointIndex">Series data point index.</param>
	/// <returns>Element boundary in screen coordinates.</returns>
	public Rectangle GetChildBounds(object chartElement, ChartElementType chartElementType, string seriesName, int pointIndex)
	{
		// Make sure we have a valid reference on the chart control
		Rectangle result = Rectangle.Empty;
		if (_chart != null &&
			_chart.chartPicture != null &&
			_chart.chartPicture.Common != null &&
			_chart.chartPicture.Common.HotRegionsList != null)
		{
			// Execute chart hit test to initialize list of chart element positions
			if (_chart.chartPicture.Common.HotRegionsList.List == null ||
				_chart.chartPicture.Common.HotRegionsList.List.Count == 0)
			{
				_chart.HitTest(0, 0);
			}

			// Find specified chart element in the list
			foreach (HotRegion hotRegion in _chart.chartPicture.Common.HotRegionsList.List)
			{
				if (hotRegion.Type == chartElementType)
				{
					// Determine if region should be processed
					bool processRegion = false;
					if (chartElementType == ChartElementType.DataPoint || chartElementType == ChartElementType.DataPointLabel)
					{
						// In case of data point and data point label their series name and label should match
						if (hotRegion.SeriesName == seriesName && hotRegion.PointIndex == pointIndex)
						{
							processRegion = true;
						}

					}
					else if (hotRegion.SelectedObject == chartElement || hotRegion.SelectedSubObject == chartElement)
					{
						processRegion = true;
					}

					if (processRegion)
					{
						RectangleF bounds = hotRegion.BoundingRectangle;



						// Conver chart relative coordinates to chart absolute (pixel) coordinates
						if (hotRegion.RelativeCoordinates)
						{
							RectangleF absolute = RectangleF.Empty;
							absolute.X = bounds.X * (_chart.Width - 1) / 100F;
							absolute.Y = bounds.Y * (_chart.Height - 1) / 100F;
							absolute.Width = bounds.Width * (_chart.Width - 1) / 100F;
							absolute.Height = bounds.Height * (_chart.Height - 1) / 100F;
							bounds = absolute;
						}

						// Check if chart should be scaled
						Rectangle rect = Rectangle.Round(bounds);
						if (_chartScale.X != 1f || _chartScale.Y != 1f)
						{
							SizeF rectSize = rect.Size;
							rect.X = (int)(rect.X * _chartScale.X);
							rect.Y = (int)(rect.Y * _chartScale.Y);

							rectSize.Width *= _chartScale.X;
							rectSize.Height *= _chartScale.Y;
							rect.Size = Size.Round(rectSize);
						}

						// Convert to screen coordinates
						if (!ChartScreenPosition.IsEmpty)
						{
							rect.Offset(ChartScreenPosition);
						}
						else
						{
							rect = _chart.RectangleToScreen(rect);
						}

						// If elementd is not gridlines just return the rectangle
						if (chartElementType != ChartElementType.Gridlines)
						{
							return rect;
						}

						// For gridlines continue accumulation all gridlines positions
						if (result.IsEmpty)
						{
							result = rect;
						}
						else
						{
							result = Rectangle.Union(result, rect);
						}
					}

				}
			}
		}

		return result;
	}

	#endregion // Methods
}

/// <summary>
/// Chart child element accessible object
/// </summary>
internal class ChartChildAccessibleObject : AccessibleObject
{
	#region Fields

	// Chart element presented by this accessibility object
	internal object chartChildObject = null;

	// Chart child object type
	internal ChartElementType chartChildObjectType = ChartElementType.Nothing;

	// Chart accessibility object
	internal ChartAccessibleObject chartAccessibleObject = null;

	// Chart accessibility object
	internal AccessibleObject chartAccessibleParentObject = null;

	// Accessible object role
	internal AccessibleRole role = AccessibleRole.StaticText;

	// Accessible object value
	internal string name = string.Empty;

	// Accessible object name
	internal string objectValue = string.Empty;

	// Series name
	protected string seriesName = string.Empty;

	// Data point index
	internal int dataPointIndex = -1;

	#endregion // Fields

	#region Constructors

	/// <summary>
	/// Initializes chart element accessibility object with specified title.
	/// </summary>
	/// <param name="chartAccessibleObject">Chart accessibility object.</param>
	/// <param name="chartAccessibleParentObject">The chart accessible parent object.</param>
	/// <param name="chartChildObject">Chart child object.</param>
	/// <param name="chartChildObjectType">Chart child object type.</param>
	/// <param name="name">Chart child object name.</param>
	/// <param name="objectValue">Chart child object value.</param>
	/// <param name="role">Chart child object role.</param>
	public ChartChildAccessibleObject(
		ChartAccessibleObject chartAccessibleObject,
		AccessibleObject chartAccessibleParentObject,
		object chartChildObject,
		ChartElementType chartChildObjectType,
		string name,
		string objectValue,
		AccessibleRole role)
	{
		this.chartAccessibleObject = chartAccessibleObject;
		this.chartAccessibleParentObject = chartAccessibleParentObject;
		this.chartChildObject = chartChildObject;
		this.chartChildObjectType = chartChildObjectType;
		this.name = name;
		this.role = role;
		this.objectValue = objectValue;
	}

	/// <summary>
	/// Initializes chart element accessibility object with specified title.
	/// </summary>
	/// <param name="chartAccessibleObject">Chart accessibility object.</param>
	/// <param name="chartAccessibleParentObject">The chart accessible parent object.</param>
	/// <param name="chartChildObject">Chart child object.</param>
	/// <param name="chartChildObjectType">Chart child object type.</param>
	/// <param name="name">Chart child object name.</param>
	/// <param name="objectValue">Chart child object value.</param>
	/// <param name="role">Chart child object role.</param>
	/// <param name="seriesName">Chart series name.</param>
	/// <param name="pointIndex">Chart data point index.</param>
	public ChartChildAccessibleObject(
		ChartAccessibleObject chartAccessibleObject,
		AccessibleObject chartAccessibleParentObject,
		object chartChildObject,
		ChartElementType chartChildObjectType,
		string name,
		string objectValue,
		AccessibleRole role,
		string seriesName,
		int pointIndex)
	{
		this.chartAccessibleObject = chartAccessibleObject;
		this.chartAccessibleParentObject = chartAccessibleParentObject;
		this.chartChildObject = chartChildObject;
		this.chartChildObjectType = chartChildObjectType;
		this.name = name;
		this.role = role;
		this.objectValue = objectValue;
		this.seriesName = seriesName;
		dataPointIndex = pointIndex;
	}

	#endregion // Constructors

	#region Properties

	/// <summary>
	/// Gets the Bounds for the accessible object.
	/// </summary>
	public override Rectangle Bounds
	{
		get
		{
			return chartAccessibleObject.GetChildBounds(chartChildObject, chartChildObjectType, seriesName, dataPointIndex);
		}
	}

	/// <summary>
	/// Gets parent accessible object
	/// </summary>
	public override AccessibleObject Parent
	{
		get
		{
			if (chartAccessibleParentObject != null)
			{
				return chartAccessibleParentObject;
			}

			return chartAccessibleObject;
		}
	}

	/// <summary>
	/// Object value
	/// </summary>
	public override string Value
	{
		get
		{
			return objectValue;
		}
		set
		{
			objectValue = value;
		}
	}

	/// <summary>
	/// Gets accessible object role
	/// </summary>
	public override AccessibleRole Role
	{
		get
		{
			return role;
		}
	}

	/// <summary>
	/// Gets accessible object state.
	/// </summary>
	public override AccessibleStates State
	{
		get
		{
			AccessibleStates state = AccessibleStates.Selectable;
			if (chartAccessibleObject.IsChildSelected(chartChildObject, chartChildObjectType))
			{
				state |= AccessibleStates.Selected;
			}

			return state;
		}
	}

	/// <summary>
	/// Gets the name of the accessibility object.
	/// </summary>
	public override string Name
	{
		get
		{
			return name;
		}
		set
		{
			name = value;
		}
	}

	#endregion // Properties

	#region Methods

	/// <summary>
	/// Navigate through chart child objects.
	/// </summary>
	/// <param name="direction">Navigation direction.</param>
	/// <returns>Accessibility object to navigate to.</returns>
	public override AccessibleObject Navigate(AccessibleNavigation direction)
	{
		return chartAccessibleObject.NavigateFromChild(chartChildObject, chartChildObjectType, direction);
	}

	/// <summary>
	/// Selects chart child element.
	/// </summary>
	/// <param name="selection">Element to select.</param>
	public override void Select(AccessibleSelection selection)
	{
		chartAccessibleObject.SelectChild(chartChildObject, chartChildObjectType, selection);
	}

	#endregion // Methods
}

/// <summary>
/// Chart legend element accessible object
/// </summary>
internal class ChartChildLegendAccessibleObject : ChartChildAccessibleObject
{
	#region Fields

	// List of child accessible objects
	private readonly List<ChartChildAccessibleObject> _childList = [];

	#endregion // Fields

	#region Constructor

	/// <summary>
	/// Object constructor.
	/// </summary>
	/// <param name="chartAccessibleObject">Chart accessible object.</param>
	/// <param name="legend">Chart legend object.</param>
	public ChartChildLegendAccessibleObject(ChartAccessibleObject chartAccessibleObject, Legend legend)
		: base(
			chartAccessibleObject,
			chartAccessibleObject,
			legend, ChartElementType.LegendArea,
			SR.AccessibilityLegendName(legend.Name),
			string.Empty,
			AccessibleRole.StaticText)
	{
		// Add legend title as a child element
		if (legend.Title.Length > 0)
		{
			_childList.Add(new ChartChildAccessibleObject(
						chartAccessibleObject,
						this,
						legend, ChartElementType.LegendTitle,
						SR.AccessibilityLegendTitleName(legend.Name),
						legend.Title,
						AccessibleRole.StaticText));
		}

		// NOTE: Legend items are dynamically generated and curently are not part of the list
	}

	#endregion // Constructor

	#region Methods

	/// <summary>
	/// Gets child accessible object.
	/// </summary>
	/// <param name="index">Index of the child object to get.</param>
	/// <returns>Chart child accessible object.</returns>
	public override AccessibleObject GetChild(int index)
	{
		if (index >= 0 && index < _childList.Count)
		{
			return _childList[index];
		}

		return null;
	}

	/// <summary>
	/// Get number of chart accessible objects.
	/// </summary>
	/// <returns>Number of chart accessible objects.</returns>
	public override int GetChildCount()
	{
		return _childList.Count;
	}

	#endregion // Methods
}

/// <summary>
/// Chart area element accessible object
/// </summary>
internal class ChartChildChartAreaAccessibleObject : ChartChildAccessibleObject
{
	#region Fields

	// List of child accessible objects
	private readonly List<ChartChildAccessibleObject> _childList = [];

	#endregion // Fields

	#region Constructor

	/// <summary>
	/// Object constructor.
	/// </summary>
	/// <param name="chartAccessibleObject">Chart accessible object.</param>
	/// <param name="chartArea">Chart area object.</param>
	public ChartChildChartAreaAccessibleObject(ChartAccessibleObject chartAccessibleObject, ChartArea chartArea)
		: base(
			chartAccessibleObject,
			chartAccessibleObject,
			chartArea, ChartElementType.PlottingArea,
			SR.AccessibilityChartAreaName(chartArea.Name),
			string.Empty,
			AccessibleRole.Graphic)
	{
		// Add all series shown in the chart area
		List<Series> areaSeries = chartArea.GetSeries();
		foreach (Series series in areaSeries)
		{
			_childList.Add(new ChartChildSeriesAccessibleObject(chartAccessibleObject, this, series));
		}

		// Add all axes
		AddAxisAccessibilityObjects(chartAccessibleObject, chartArea.AxisX);
		AddAxisAccessibilityObjects(chartAccessibleObject, chartArea.AxisY);
		AddAxisAccessibilityObjects(chartAccessibleObject, chartArea.AxisX2);
		AddAxisAccessibilityObjects(chartAccessibleObject, chartArea.AxisY2);
	}

	#endregion // Constructor

	#region Methods

	/// <summary>
	/// Helper method which adds all accessibility objects for specified axis
	/// </summary>
	/// <param name="chartAccessibleObject">Chart accessibility object.</param>
	/// <param name="axis">Axis to add accessibility for.</param>
	private void AddAxisAccessibilityObjects(ChartAccessibleObject chartAccessibleObject, Axis axis)
	{
		// Y axis plus title
		if (axis.enabled)
		{
			_childList.Add(new ChartChildAccessibleObject(
				chartAccessibleObject,
				this,
				axis,
				ChartElementType.Axis,
				axis.Name,
				string.Empty,
				AccessibleRole.Graphic));

			if (axis.Title.Length > 0)
			{
				_childList.Add(new ChartChildAccessibleObject(
					chartAccessibleObject,
					this,
					axis,
					ChartElementType.AxisTitle,
					SR.AccessibilityChartAxisTitleName(axis.Name),
					axis.Title,
					AccessibleRole.StaticText));
			}


			if (axis.MajorGrid.Enabled)
			{
				_childList.Add(new ChartChildAccessibleObject(
					chartAccessibleObject,
					this,
					axis.MajorGrid,
					ChartElementType.Gridlines,
					SR.AccessibilityChartAxisMajorGridlinesName(axis.Name),
					string.Empty,
					AccessibleRole.Graphic));
			}

			if (axis.MinorGrid.Enabled)
			{
				_childList.Add(new ChartChildAccessibleObject(
					chartAccessibleObject,
					this,
					axis.MinorGrid,
					ChartElementType.Gridlines,
					SR.AccessibilityChartAxisMinorGridlinesName(axis.Name),
					string.Empty,
					AccessibleRole.Graphic));
			}
		}
	}

	/// <summary>
	/// Gets child accessible object.
	/// </summary>
	/// <param name="index">Index of the child object to get.</param>
	/// <returns>Chart child accessible object.</returns>
	public override AccessibleObject GetChild(int index)
	{
		if (index >= 0 && index < _childList.Count)
		{
			return _childList[index];
		}

		return null;
	}

	/// <summary>
	/// Get number of chart accessible objects.
	/// </summary>
	/// <returns>Number of chart accessible objects.</returns>
	public override int GetChildCount()
	{
		return _childList.Count;
	}

	#endregion // Methods
}

/// <summary>
/// Chart series element accessible object
/// </summary>
internal class ChartChildSeriesAccessibleObject : ChartChildAccessibleObject
{
	#region Fields

	// List of child accessible objects
	private readonly List<ChartChildAccessibleObject> _childList = [];

	#endregion // Fields

	#region Constructor

	/// <summary>
	/// Object constructor.
	/// </summary>
	/// <param name="chartAccessibleObject">Chart accessible object.</param>
	/// <param name="series">Chart series object.</param>
	public ChartChildSeriesAccessibleObject(ChartAccessibleObject chartAccessibleObject, AccessibleObject parent, Series series)
		: base(
			chartAccessibleObject,
			parent,
			series, ChartElementType.DataPoint,
			SR.AccessibilitySeriesName(series.Name),
			string.Empty,
			AccessibleRole.Graphic)
	{
		// Add all series data points
		int index = 1;
		foreach (DataPoint point in series.Points)
		{
			_childList.Add(new ChartChildAccessibleObject(
				chartAccessibleObject,
				this,
				point,
				ChartElementType.DataPoint,
				SR.AccessibilityDataPointName(index),
				string.Empty,
				AccessibleRole.Graphic,
				series.Name,
				index - 1));

			if (point.Label.Length > 0 || point.IsValueShownAsLabel)
			{
				_childList.Add(new ChartChildAccessibleObject(
					chartAccessibleObject,
					this,
					point,
					ChartElementType.DataPointLabel,
					SR.AccessibilityDataPointLabelName(index),
					!string.IsNullOrEmpty(point._lastLabelText) ? point._lastLabelText : point.Label,
					AccessibleRole.Text,
					series.Name,
					index - 1));
			}

			++index;
		}
	}

	#endregion // Constructor

	#region Methods

	/// <summary>
	/// Gets child accessible object.
	/// </summary>
	/// <param name="index">Index of the child object to get.</param>
	/// <returns>Chart child accessible object.</returns>
	public override AccessibleObject GetChild(int index)
	{
		if (index >= 0 && index < _childList.Count)
		{
			return _childList[index];
		}

		return null;
	}

	/// <summary>
	/// Get number of chart accessible objects.
	/// </summary>
	/// <returns>Number of chart accessible objects.</returns>
	public override int GetChildCount()
	{
		return _childList.Count;
	}

	#endregion // Methods
}

