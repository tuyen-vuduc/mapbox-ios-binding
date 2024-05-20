using ObjCRuntime;

namespace MapboxMapsObjC
{
	[Native]
	public enum TMBCompassDirectionFormatterStyle : long
	{
		SShort = 0,
		LLong = 1
	}

	[Native]
	public enum TMBExpressionOptionsType : long
	{
		Format = 0,
		NumberFormat = 1,
		Collator = 2
	}

	[Native]
	public enum TMBGeoJSONSourceType : long
	{
		SString = 0,
		Feature = 1,
		FeatureCollection = 2,
		Geometry = 3,
		Empty = 4
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
		SingleTap = 6,
		Rotation = 7
	}

	[Native]
	public enum TMBLayerPositionType : long
	{
		At = 0,
		Above = 1,
		Below = 2,
		Default = 3
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
	public enum TMBPromoteIdType : long
	{
		SString = 0,
		OObject = 1
	}

	[Native]
	public enum TMBPuckBearing : long
	{
		Heading = 0,
		Course = 1
	}

	[Native]
	public enum TMBPuckType : long
	{
		Puck2D = 0,
		Puck3D = 1
	}

	[Native]
	public enum TMBVisibility : long
	{
		Visible = 0,
		None = 1
	}
}
