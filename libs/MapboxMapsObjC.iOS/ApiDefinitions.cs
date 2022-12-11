using CoreGraphics;
using Foundation;
using MapboxMapsObjC;
using MapboxCoreMaps;
using MapboxMaps;

namespace MapboxMapsObjC
{
	// @interface MapInitOptionsFactory : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC21MapInitOptionsFactory")]
	[DisableDefaultCtor]
	interface MapInitOptionsFactory
	{
		// +(MapInitOptions * _Nonnull)createWithResourceOptions:(MBMResourceOptions * _Nullable)resourceOptions mapOptions:(MBMMapOptions * _Nullable)mapOptions cameraOptions:(MBMCameraOptions * _Nullable)cameraOptions stylePath:(NSString * _Nullable)stylePath __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithResourceOptions:mapOptions:cameraOptions:stylePath:")]
		MapInitOptions CreateWithResourceOptions ([NullAllowed] MBMResourceOptions resourceOptions, [NullAllowed] MBMMapOptions mapOptions, [NullAllowed] MBMCameraOptions cameraOptions, [NullAllowed] string stylePath);

		// +(MapInitOptions * _Nonnull)createWithResourceOptions:(MBMResourceOptions * _Nullable)resourceOptions mapOptions:(MBMMapOptions * _Nullable)mapOptions cameraOptions:(MBMCameraOptions * _Nullable)cameraOptions styleURI:(NSUrl * _Nullable)styleURI __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithResourceOptions:mapOptions:cameraOptions:styleURI:")]
		MapInitOptions CreateWithResourceOptions ([NullAllowed] MBMResourceOptions resourceOptions, [NullAllowed] MBMMapOptions mapOptions, [NullAllowed] MBMCameraOptions cameraOptions, [NullAllowed] NSUrl styleURI);
	}

	// @interface MapViewFactory : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC14MapViewFactory")]
	[DisableDefaultCtor]
	interface MapViewFactory
	{
		// +(MapView * _Nonnull)createWithFrame:(CGRect)frame options:(MapInitOptions * _Nonnull)options __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithFrame:options:")]
		MapView CreateWithFrame (CGRect frame, [NullAllowed] MapInitOptions options);
	}

	// @interface MapInitOptions (SWIFT_EXTENSION(MapboxMapObjC))
	[Category, BaseType(typeof(MapInitOptions))]
	interface MapInitOptions_Options
	{
		// - (NSArray * _Nonnull)options SWIFT_WARN_UNUSED_RESULT;
		[Static]
		[Export ("options")]
		NSArray GetOptions ();
	}

	// @interface MapView (SWIFT_EXTENSION(MapboxMapObjC))
	[Category, BaseType(typeof(MapView))]
	interface MapView_Extensions
	{
		// - (void)setLocationDelegate:(id <LocationPermissionsDelegate> _Nonnull)delegate;
		[Export ("setLocationDelegate:")]
		void SetLocationDelegate (ILocationPermissionsDelegate locationPermissionsDelegate);

		// - (void)requestTemporaryFullAccuracyPermissions:(NSString * _Nonnull)customKey;
		[Export ("requestTemporaryFullAccuracyPermissions:")]
		void RequestTemporaryFullAccuracyPermissions (string customKey);
		
		// - (void)puck2D;
		[Export ("puck2D")]
		void Puck2D ();
	}

}
