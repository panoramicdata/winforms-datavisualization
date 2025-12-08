using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;

namespace System.Windows.Forms.DataVisualization.Charting.Utilities
{
	/// <summary>
	/// Helper class which improves the readability of the small segments in the Pie chart.
	/// Pie segments which are too small are shown in a supplemental pie chart series.
	/// </summary>
	public class PieCollectedDataHelper
	{
		#region Fields

		/// <summary>
		/// Specifies the percentage of the total series values. This value determines 
		/// if the data point value is a "small" value and should be shown as collected.
		/// </summary>
		public	double			CollectedPercentage = 5.0;

		/// <summary>
		/// Position in relative coordinates ( 0,0 - top left corner; 100,100 - bottom right corner)
		/// where original and supplemental pie charts should be placed.
		/// </summary>
		public	RectangleF		ChartAreaPosition = new RectangleF(5f, 5f, 90f, 90f);

		/// <summary>
		/// Indicates if small segments should be shown as one "collected" segment in the original series
		/// </summary>
		public	bool			ShowCollectedDataAsOneSlice = false;

		/// <summary>
		/// Spacing between the original and supplemental chart areas in percentage
		/// </summary>
		public	float			ChartAreaSpacing = 5f;

		/// <summary>
		/// Size ratio between the original and supplemental chart areas.
		/// Value of 1.0f indicates that same area size will be used.
		/// </summary>
		public	float			SupplementedAreaSizeRatio = 0.9f;

		/// <summary>
		/// Color of the connection lines
		/// </summary>
		public	Color			ConnectionLinesColor = Color.FromArgb(64, 64, 64);

		/// <summary>
		/// Collected pie segment label
		/// </summary>
		public	string			CollectedLabel = "Other";
		
		
		// Reference to the parameters
		private Chart			chartControl = null;
		private Series			series = null;

		// Internal use fields
		private	Series			supplementalSeries = null;
		private ChartArea		originalChartArea = null;
		private ChartArea		supplementalChartArea = null;
		private float			collectedPieSliceAngle = 0f;

		#endregion // Fields

		#region Constructor

		/// <summary>
		/// Public constructor.
		/// </summary>
		/// <param name="chartControl">Reference to the chart control.</param>
		public PieCollectedDataHelper(Chart chartControl)
		{
			this.chartControl = chartControl;

			// Handle chart PostPaint event to draw the "connection" between the 
			// collected pie slice and supplemental chart.
			this.chartControl.PostPaint +=new EventHandler<ChartPaintEventArgs>(chart_PostPaint);
		}

		#endregion // Constructor

		#region Methods

		/// <summary>
		/// Shows small pie segments as supplemental pie chart series in the new chart area.
		/// </summary>
		/// <param name="seriesName">Series name </param>
		public void ShowSmallSegmentsAsSupplementalPie(string seriesName)
		{
			// Validate input
			if(chartControl == null)
			{
				throw(new ArgumentNullException("chartControl"));
			}
			if(CollectedPercentage > 100.0 || CollectedPercentage < 0.0)
			{
				throw(new ArgumentException("Value must be in range from 0 to 100 percent.", "CollectedPercentage"));
			}

			// Initialize reference to the series
			series = chartControl.Series[seriesName];

			// Check input series type
			if(series.ChartType != SeriesChartType.Pie &&
				series.ChartType != SeriesChartType.Doughnut)
			{
				throw(new InvalidOperationException("Only series with Pie or Doughnut chart type can be used."));
			}

			// Check if specified series has data points
			if(series.Points.Count == 0)
			{
				throw(new InvalidOperationException("Cannot perform operatiuon on an empty series."));
			}
		
			// Create "collected" pie slice in original series
			supplementalChartArea = null;
			if( CreateCollectedPie() )
			{
				// Calculate width of supplemental chart area
				float supplementalWidth = (ChartAreaPosition.Width - ChartAreaSpacing) / 2f * SupplementedAreaSizeRatio;

				// Adjust position of the original chart area
				originalChartArea = chartControl.ChartAreas[series.ChartArea];
				originalChartArea.Position.X = ChartAreaPosition.X;
				originalChartArea.Position.Y = ChartAreaPosition.Y;
				originalChartArea.Position.Width = ChartAreaPosition.Width - supplementalWidth - ChartAreaSpacing;
				originalChartArea.Position.Height = ChartAreaPosition.Height;

				// Original chart area must be in 2D mode
				originalChartArea.Area3DStyle.Enable3D = false;

				// Create and adjust position of the supplemental chart area
				supplementalChartArea = new ChartArea();
				supplementalChartArea.Name = originalChartArea.Name + "_Supplemental";
				supplementalChartArea.Position.X = originalChartArea.Position.Right + ChartAreaSpacing;
				supplementalChartArea.Position.Y = ChartAreaPosition.Y;
				supplementalChartArea.Position.Width = supplementalWidth;
				supplementalChartArea.Position.Height = ChartAreaPosition.Height;
				chartControl.ChartAreas.Add(supplementalChartArea);

				// Create supplemental pie chart series to show all the collected data
				supplementalSeries.Name = series.Name + "_Supplemental";
				supplementalSeries.ChartArea = supplementalChartArea.Name;
				chartControl.Series.Add(supplementalSeries);

				// Copy some attributes from the original chart area
				supplementalChartArea.BackColor = originalChartArea.BackColor;
				supplementalChartArea.BorderColor = originalChartArea.BorderColor;
				supplementalChartArea.BorderWidth = originalChartArea.BorderWidth;
				supplementalChartArea.ShadowOffset = originalChartArea.ShadowOffset;

				// Copy some attributes from the original series
				supplementalSeries.ChartType = series.ChartType;
				supplementalSeries.Palette = series.Palette;
				supplementalSeries.ShadowOffset = series.ShadowOffset;
				supplementalSeries.BorderColor = series.BorderColor;
				supplementalSeries.BorderWidth = series.BorderWidth;
				supplementalSeries.IsValueShownAsLabel = series.IsValueShownAsLabel;
				supplementalSeries.LabelBackColor = series.LabelBackColor;
				supplementalSeries.LabelBorderColor = series.LabelBorderColor;
				supplementalSeries.LabelBorderWidth = series.LabelBorderWidth;
				supplementalSeries.LabelFormat = series.LabelFormat;
				supplementalSeries.Font = series.Font;
			}
		}

		/// <summary>
		/// Creates the "collected" pie slice data point by re moving and accumulating all
		/// the values of the data points which values are less then specified percentage.
		/// </summary>
		/// <returns>True if collected pie slice was created.</returns>
		private bool CreateCollectedPie()
		{
			// Create supplemental series
			supplementalSeries = new Series();

			// Calculate total vale of all point in series
			double total = 0.0;
			foreach(DataPoint dataPoint in series.Points)
			{
				total += Math.Abs(dataPoint.YValues[0]);
			}

			// Count how many data points will be presented as collected
			double	minValue = total / 100.0 * CollectedPercentage;
			int		collectedPointsCount = 0;
			for(int index = 0; index < series.Points.Count; index++)
			{
				double pointValue = Math.Abs(series.Points[index].YValues[0]);
				if(pointValue <= minValue)
				{
					++collectedPointsCount;
				}
			}

			// Do not collect data points if one or less points left in the original series
			if( (series.Points.Count - collectedPointsCount) <= 1 ||
				collectedPointsCount <= 1)
			{
				return false;
			}

			// Add Collected data point into series before applying palette colors
			DataPoint colectedDataPoint = null;
			if(ShowCollectedDataAsOneSlice)
			{
				colectedDataPoint = new DataPoint(series);
				series.Points.Add(colectedDataPoint);
			}


			// Apply pallete colors to series to save same data point colors
			// in supplemental series.
			chartControl.ApplyPaletteColors();
			foreach(DataPoint dataPoint in series.Points)
			{
				// Setting data point color to itself will clear the internal flag which
				// indicates that point color should be taken from the palette again when
				// control is rendered next time.
				dataPoint.Color = dataPoint.Color;
			}

			// Remove points which value is less than specified percentage from total
			double	collectedValue = 0.0;
			for(int index = 0; index < series.Points.Count; index++)
			{
				double pointValue = Math.Abs(series.Points[index].YValues[0]);
				if(pointValue <= minValue && 
					series.Points[index] != colectedDataPoint)
				{
					// Add point value to the collected value
					collectedValue += pointValue;

					// Add point to supplemental series
					supplementalSeries.Points.Add(series.Points[index].Clone());

					// Remove point from the series
					series.Points.RemoveAt(index);
					--index;
				}
			}

			// Add all collected data points at the end of the series
			if(!ShowCollectedDataAsOneSlice)
			{
				foreach(DataPoint dataPoint in supplementalSeries.Points)
				{
					DataPoint dataPointCollected = dataPoint.Clone();
					dataPoint.IsVisibleInLegend = false;
					series.Points.Add(dataPointCollected);

					// Disable labels in collected slices
					dataPointCollected.Label = String.Empty;
					dataPointCollected.LegendText = dataPointCollected.AxisLabel;
					dataPointCollected.AxisLabel = String.Empty;
					dataPointCollected.IsValueShownAsLabel = false;
				}
			}

			// Check if we need to add the "collected" data point
			if(collectedValue > 0.0)
			{
				// Set collected data point value and other attributes
				if(ShowCollectedDataAsOneSlice)
				{
					colectedDataPoint.YValues[0] = collectedValue;
					colectedDataPoint.Label = CollectedLabel;
					colectedDataPoint.IsVisibleInLegend = false;

					// Note: Collected data point may be exploded
					//colectedDataPoint["Exploded"] = "true";
				}

				// Calculate collected pie slice angle
				collectedPieSliceAngle = (float) ( (360f / 100f) * (collectedValue / (total / 100) ) );

				// Adjust the Pie chart start angle, so that the middle of the 
				// collected slice looks directly at 3 o'clock.
				int startAngle = (int)Math.Round(collectedPieSliceAngle / 2.0);
				series["PieStartAngle"] = startAngle.ToString();

				return true;
			}
			else if(colectedDataPoint != null)
			{
				// Remove collected data point
				series.Points.Remove(colectedDataPoint);
			}

			return false;
		}

		/// <summary>
		/// Chart post paint event handler. 
		/// Used to draw the "connection" lines between the original and supplemental pies.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event arguments.</param>
		private void chart_PostPaint(object sender, ChartPaintEventArgs e)
		{
			if(sender is ChartArea)
			{
				ChartArea area = (ChartArea)sender;
				if(supplementalChartArea != null &&
					area.Name == supplementalChartArea.Name)
				{
					// Get position of the plotting areas in pixels
					RectangleF originalPosition = GetChartAreaPlottingPosition(originalChartArea, e.ChartGraphics);
					RectangleF supplementalPosition = GetChartAreaPlottingPosition(supplementalChartArea, e.ChartGraphics);

					// Get coordinates of the "connection" lines
					PointF p1 = GetRotatedPlotAreaPoint(supplementalPosition, 325f);
					PointF p2 = GetRotatedPlotAreaPoint(supplementalPosition, 215f);
					PointF p3 = GetRotatedPlotAreaPoint(originalPosition, 90f - collectedPieSliceAngle / 2f);
					PointF p4 = GetRotatedPlotAreaPoint(originalPosition, 90f + collectedPieSliceAngle / 2f);

					// Draw "connection lines"
					using( Pen pen = new Pen(ConnectionLinesColor, 1) )
					{
						e.ChartGraphics.Graphics.DrawLine(pen, p1, p3);
                        e.ChartGraphics.Graphics.DrawLine(pen, p2, p4);
					}
				}
			}
		}

		/// <summary>
		/// Helper method which calculates a point on the edje of the pie chart using 
		/// specified angle.
		/// </summary>
		/// <param name="areaPosition">Chart are position in pixels.</param>
		/// <param name="angle">Point angle in degrees.</param>
		/// <returns>Point location in pixels.</returns>
		private PointF GetRotatedPlotAreaPoint(RectangleF areaPosition, float angle)
		{
			PointF[] points = [new PointF(areaPosition.X + areaPosition.Width / 2f, areaPosition.Y)];
			using ( Matrix transformMatrix = new Matrix() )
			{
				transformMatrix.RotateAt(angle, new PointF(
					areaPosition.X + areaPosition.Width / 2f, 
					areaPosition.Y + areaPosition.Height / 2f) );

				transformMatrix.TransformPoints(points);
			}
			return points[0];
		}

		/// <summary>
		/// Helper method which calculates chart area plotting position in pixels.
		/// </summary>
		/// <param name="area">Chart area to get the plotting area position.</param>
		/// <param name="chartGraphics">Chart graphics object.</param>
		/// <returns>Chart area ploting area position in pixels.</returns>
		private RectangleF GetChartAreaPlottingPosition(ChartArea area, ChartGraphics chartGraphics)
		{
			RectangleF plottingRect = area.Position.ToRectangleF();
			plottingRect.X += (area.Position.Width / 100F) * area.InnerPlotPosition.X;
			plottingRect.Y += (area.Position.Height / 100F) * area.InnerPlotPosition.Y;
			plottingRect.Width = (area.Position.Width / 100F) * area.InnerPlotPosition.Width;
			plottingRect.Height = (area.Position.Height / 100F) * area.InnerPlotPosition.Height;
			plottingRect = chartGraphics.GetAbsoluteRectangle(plottingRect);
			return plottingRect;
		}

		#endregion // Methods
	}
}