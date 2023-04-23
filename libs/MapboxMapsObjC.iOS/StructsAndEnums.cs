using ObjCRuntime;

namespace MapboxMapsObjC
{
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
	public enum TMBPuckBearingSource : long
	{
		Heading = 0,
		Course = 1
	}
}
