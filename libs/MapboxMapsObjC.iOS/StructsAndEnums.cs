using ObjCRuntime;

namespace MapboxMapsObjC
{
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
	public enum TMBLayerPosition : long
	{
		At = 0,
		Below = 1,
		Above = 2,
		Unowned = 3
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
	public enum TMBPuckBearingSource : long
	{
		Heading = 0,
		Course = 1
	}
}
