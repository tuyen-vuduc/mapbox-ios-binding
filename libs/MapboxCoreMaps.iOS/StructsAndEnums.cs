using System.Runtime.InteropServices;
using Foundation;
using MapboxCoreMaps;
using ObjCRuntime;

namespace MapboxCoreMaps
{
	[Native]
	public enum MBMGeoJSONSourceDataType : long
	{
		Geometry,
		Feature,
		NSArray,
		NSString
	} 

	[Native]
	public enum MBMGlyphsRasterizationMode : long
	{
		NoGlyphsRasterizedLocally,
		IdeographsRasterizedLocally,
		AllGlyphsRasterizedLocally
	}

	[Native]
	public enum MBMContextMode : long
	{
		Unique,
		Shared
	}

	[Native]
	public enum MBMConstrainMode : long
	{
		None,
		HeightOnly,
		WidthAndHeight
	}

	[Native]
	public enum MBMViewportMode : long
	{
		Default,
		FlippedY
	}

	[Native]
	public enum MBMNorthOrientation : long
	{
		Upwards,
		Rightwards,
		Downwards,
		Leftwards
	}

	[Native]
	public enum MBMMapDebugOptions : long
	{
		TileBorders,
		ParseStatus,
		Timestamps,
		Collision,
		Overdraw,
		StencilClip,
		DepthBuffer,
		RenderCache,
		ModelBounds,
		TerrainWireframe
	}

	[Native]
	public enum MBMViewAnnotationAnchor : long
	{
		Top,
		Left,
		Bottom,
		Right,
		TopLeft,
		BottomRight,
		TopRight,
		BottomLeft,
		Center
	}

	[Native]
	public enum MBMMapMemoryBudgetType : long
	{
		Megabytes,
		Tiles
	}

	[Native]
	public enum MBMRenderedQueryGeometryType : long
	{
		ScreenBox,
		ScreenCoordinate,
		NSArray
	}

	[Native]
	public enum MBMStylePackErrorType : long
	{
		Canceled,
		DoesNotExist,
		DiskFull,
		Other
	}

	[Native]
	public enum MBMResponseErrorReason : long
	{
		NotFound,
		Server,
		Connection,
		RateLimit,
		Other
	}

	[Native]
	public enum MBMOfflineRegionDownloadState : long
	{
		Inactive,
		Active
	}

	[Native]
	public enum MBMTileStoreUsageMode : long
	{
		Disabled,
		ReadOnly,
		ReadAndUpdate
	}

	[Native]
	public enum MBMStylePropertyValueKind : long
	{
		Undefined,
		Constant,
		Expression,
		Transition
	}
}
