using ObjCRuntime;

namespace MapboxMapsObjC
{
	[Native]
	public enum TMBAnchor : long
	{
		Map = 0,
		Viewport = 1
	}

	[Native]
	public enum TMBCirclePitchAlignment : long
	{
		Map = 0,
		Viewport = 1
	}

	[Native]
	public enum TMBCirclePitchScale : long
	{
		Map = 0,
		Viewport = 1
	}

	[Native]
	public enum TMBCircleTranslateAnchor : long
	{
		Map = 0,
		Viewport = 1
	}

	[Native]
	public enum TMBEncoding : long
	{
		Terrarium = 0,
		Mapbox = 1
	}

	[Native]
	public enum TMBExpressionOptionsType : long
	{
		Format = 0,
		NumberFormat = 1,
		Collator = 2
	}

	[Native]
	public enum TMBFillExtrusionTranslateAnchor : long
	{
		Map = 0,
		Viewport = 1
	}

	[Native]
	public enum TMBFillTranslateAnchor : long
	{
		Map = 0,
		Viewport = 1
	}

	[Native]
	public enum TMBGeoJSONSourceType : long
	{
		Url = 0,
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
		SingleTap = 6
	}

	[Native]
	public enum TMBHillshadeIlluminationAnchor : long
	{
		Map = 0,
		Viewport = 1
	}

	[Native]
	public enum TMBIconAnchor : long
	{
		Center = 0,
		Left = 1,
		Right = 2,
		Top = 3,
		Bottom = 4,
		TopLeft = 5,
		TopRight = 6,
		BottomLeft = 7,
		BottomRight = 8
	}

	[Native]
	public enum TMBIconPitchAlignment : long
	{
		Map = 0,
		Viewport = 1,
		Auto = 2
	}

	[Native]
	public enum TMBIconRotationAlignment : long
	{
		Map = 0,
		Viewport = 1,
		Auto = 2
	}

	[Native]
	public enum TMBIconTextFit : long
	{
		None = 0,
		Width = 1,
		Height = 2,
		Both = 3
	}

	[Native]
	public enum TMBIconTranslateAnchor : long
	{
		Map = 0,
		Viewport = 1
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
		Sky = 10,
		Model = 11
	}

	[Native]
	public enum TMBLineCap : long
	{
		Butt = 0,
		Round = 1,
		Square = 2
	}

	[Native]
	public enum TMBLineJoin : long
	{
		Bevel = 0,
		Round = 1,
		Miter = 2
	}

	[Native]
	public enum TMBLineTranslateAnchor : long
	{
		Map = 0,
		Viewport = 1
	}

	[Native]
	public enum TMBExpressionOperator : long
	{
		Subtract = 0,
		Not = 1,
		Neq = 2,
		Product = 3,
		Division = 4,
		Mod = 5,
		Pow = 6,
		Sum = 7,
		Lt = 8,
		Lte = 9,
		Eq = 10,
		Gt = 11,
		Gte = 12,
		Abs = 13,
		Accumulated = 14,
		Acos = 15,
		All = 16,
		Any = 17,
		Array = 18,
		Asin = 19,
		At = 20,
		Atan = 21,
		Boolean = 22,
		SwitchCase = 23,
		Ceil = 24,
		Coalesce = 25,
		Collator = 26,
		Concat = 27,
		Cos = 28,
		Distance = 29,
		DistanceFromCenter = 30,
		Downcase = 31,
		E = 32,
		FeatureState = 33,
		Floor = 34,
		Format = 35,
		GeometryType = 36,
		Get = 37,
		Has = 38,
		HeatmapDensity = 39,
		Id = 40,
		Image = 41,
		InExpression = 42,
		IndexOf = 43,
		Interpolate = 44,
		IsSupportedScript = 45,
		Length = 46,
		LetExpression = 47,
		LineProgress = 48,
		Literal = 49,
		Ln = 50,
		Ln2 = 51,
		Log10 = 52,
		Log2 = 53,
		Match = 54,
		Max = 55,
		Min = 56,
		Number = 57,
		NumberFormat = 58,
		ObjectExpression = 59,
		Pi = 60,
		Pitch = 61,
		Properties = 62,
		ResolvedLocale = 63,
		Rgb = 64,
		Rgba = 65,
		Round = 66,
		Sin = 67,
		SkyRadialProgress = 68,
		Slice = 69,
		Sqrt = 70,
		Step = 71,
		String = 72,
		Tan = 73,
		ToBoolean = 74,
		ToColor = 75,
		ToNumber = 76,
		ToRgba = 77,
		ToString = 78,
		TypeofExpression = 79,
		Upcase = 80,
		VarExpression = 81,
		Within = 82,
		Zoom = 83,
		Linear = 84,
		Exponential = 85,
		CubicBezier = 86
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
		String = 0,
		Object = 1
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
	public enum TMBRasterResampling : long
	{
		Linear = 0,
		Nearest = 1
	}

	[Native]
	public enum TMBScheme : long
	{
		Xyz = 0,
		Tms = 1
	}

	[Native]
	public enum TMBSkyType : long
	{
		Gradient = 0,
		Atmosphere = 1
	}

	[Native]
	public enum TMBSourceType : long
	{
		Vector = 0,
		Raster = 1,
		RasterDem = 2,
		GeoJson = 3,
		Image = 4,
		Model = 5
	}

	[Native]
	public enum TMBStyleProjectionName : long
	{
		Mercator = 0,
		Globe = 1
	}

	[Native]
	public enum TMBSymbolPlacement : long
	{
		Point = 0,
		Line = 1,
		LineCenter = 2
	}

	[Native]
	public enum TMBSymbolZOrder : long
	{
		Auto = 0,
		ViewportY = 1,
		Source = 2
	}

	[Native]
	public enum TMBTextAnchor : long
	{
		Center = 0,
		Left = 1,
		Right = 2,
		Top = 3,
		Bottom = 4,
		TopLeft = 5,
		TopRight = 6,
		BottomLeft = 7,
		BottomRight = 8
	}

	[Native]
	public enum TMBTextJustify : long
	{
		Auto = 0,
		Left = 1,
		Center = 2,
		Right = 3
	}

	[Native]
	public enum TMBTextPitchAlignment : long
	{
		Map = 0,
		Viewport = 1,
		Auto = 2
	}

	[Native]
	public enum TMBTextRotationAlignment : long
	{
		Map = 0,
		Viewport = 1,
		Auto = 2
	}

	[Native]
	public enum TMBTextTransform : long
	{
		None = 0,
		Uppercase = 1,
		Lowercase = 2
	}

	[Native]
	public enum TMBTextTranslateAnchor : long
	{
		Map = 0,
		Viewport = 1
	}

	[Native]
	public enum TMBTextWritingMode : long
	{
		Horizontal = 0,
		Vertical = 1
	}

	[Native]
	public enum TMBViewAnnotationManagerError : long
	{
		ViewIsAlreadyAdded = 0,
		AssociatedFeatureIdIsAlreadyInUse = 1,
		AnnotationNotFound = 2,
		GeometryFieldMissing = 3
	}

	[Native]
	public enum TMBVisibility : long
	{
		Visible = 0,
		None = 1
	}
}
