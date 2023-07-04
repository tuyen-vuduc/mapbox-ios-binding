using ObjCRuntime;

namespace MapboxMapsObjC
{
	[Native]
	public enum TMBExpressionOptionsType : long
	{
		Format = 0,
		NumberFormat = 1,
		Collator = 2
	}

	[Native]
	public enum TMBGestureType : long
	{
		Pan = 0,
		Pinch = 1,
		Pitch = 2,
		DoubleTapToZoomIn = 3,
		DoubleTouchToZoomOut = 4,
		QuickZoom = 5,
		SingleTap = 6
	}

	[Native]
	public enum TMBLayerPositionType : long
	{
		At = 0,
		Above = 1,
		Below = 2
	}

	[Native]
	public enum TMBLayerType : long
	{
		Fill = 0,
		Line = 1,
		Symbol = 2,
		Circle = 3,
		Heatmap = 4,
		FillExtrusion = 5,
		Raster = 6,
		Hillshade = 7,
		Background = 8,
		LocationIndicator = 9,
		Sky = 10
	}

	[Native]
	public enum TMBOrnamentPosition : long
	{
		TopLeft = 0,
		TopRight = 1,
		BottomRight = 2,
		BottomLeft = 3,
		TopLeading = 4,
		TopTrailing = 5,
		BottomLeading = 6,
		BottomTrailing = 7
	}

	[Native]
	public enum TMBOrnamentVisibility : long
	{
		Adaptive = 0,
		Hidden = 1,
		Visible = 2
	}

	[Native]
	public enum TMBPanMode : long
	{
		Horizontal = 0,
		Vertical = 1,
		HorizontalAndVertical = 2
	}

	[Native]
	public enum TMBPuck2DConfigurationPulsingRadius : long
	{
		Constant = 0,
		Accuracy = 1
	}

	[Native]
	public enum TMBPuckBearingSource : long
	{
		Heading = 0,
		Course = 1
	}

	[Native]
	public enum TMBPuckType : long
	{
		TMBPuckTypePuck2D = 0,
		TMBPuckTypePuck3D = 1
	}

	[Native]
	public enum TMBViewAnnotationManagerError : long
	{
		ViewIsAlreadyAdded = 0,
		AssociatedFeatureIdIsAlreadyInUse = 1,
		AnnotationNotFound = 2,
		GeometryFieldMissing = 3
	}
}
