using System;
using CoreAnimation;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;
using MapboxCoreMaps;
using MapboxMaps;
using MapboxCommon;
using MapboxMapsObjC;

namespace MapboxMapsObjC
{
	// @interface BuiltInStyles : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13BuiltInStyles")]
	interface BuiltInStyles
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull streets;
		[Static]
		[Export ("streets")]
		string Streets { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull outdoors;
		[Static]
		[Export ("outdoors")]
		string Outdoors { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull light;
		[Static]
		[Export ("light")]
		string Light { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull dark;
		[Static]
		[Export ("dark")]
		string Dark { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull satellite;
		[Static]
		[Export ("satellite")]
		string Satellite { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull satelliteStreets;
		[Static]
		[Export ("satelliteStreets")]
		string SatelliteStreets { get; }
	}

	// @interface GeometryHelper : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC14GeometryHelper")]
	[DisableDefaultCtor]
	interface GeometryHelper
	{
		// +(MBXGeometry * _Nonnull)createPoint:(NSValue * _Nonnull)location __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createPoint:")]
		MBXGeometry CreatePoint (NSValue location);

		// +(MBXGeometry * _Nonnull)createLine:(NSArray<NSValue *> * _Nonnull)locations __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createLine:")]
		MBXGeometry CreateLine (NSValue[] locations);

		// +(MBXGeometry * _Nonnull)createMultiLine:(NSArray<NSArray<NSValue *> *> * _Nonnull)locations __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createMultiLine:")]
		MBXGeometry CreateMultiLine (NSArray locations);

		// +(MBXGeometry * _Nonnull)createMultiPoint:(NSArray<NSValue *> * _Nonnull)locations __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createMultiPoint:")]
		MBXGeometry CreateMultiPoint (NSValue[] locations);

		// +(MBXGeometry * _Nonnull)createMultiPolygon:(NSArray<NSArray<NSArray<NSValue *> *> *> * _Nonnull)locations __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createMultiPolygon:")]
		MBXGeometry CreateMultiPolygon (NSArray locations);

		// +(MBXGeometry * _Nonnull)createPolygon:(NSArray<NSArray<NSValue *> *> * _Nonnull)locations __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createPolygon:")]
		MBXGeometry CreatePolygon (NSArray locations);

		// +(MBXGeometry * _Nonnull)create:(NSArray<MBXGeometry *> * _Nonnull)items __attribute__((warn_unused_result("")));
		[Static]
		[Export ("create:")]
		MBXGeometry Create (MBXGeometry[] items);
	}

	// @interface MapboxMapObjC_Swift_346
    [Category]
    [BaseType(typeof(MapInitOptions))]
	interface MapboxMapObjC_Swift_346
	{
		// -(MBMResourceOptions * _Nonnull)getResourceOptions __attribute__((warn_unused_result("")));
		[Export ("getResourceOptions")]
		MBMResourceOptions ResourceOptions();

		// -(MBMMapOptions * _Nonnull)getMapOptions __attribute__((warn_unused_result("")));
		[Export ("getMapOptions")]
		MBMMapOptions MapOptions();

		// -(NSString * _Nullable)getStyleURI __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("getStyleURI")]
		string StyleURI();

		// -(NSString * _Nullable)getStyleJSON __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("getStyleJSON")]
		string StyleJSON();

		// -(MBMCameraOptions * _Nullable)getCameraOptions __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("getCameraOptions")]
		MBMCameraOptions CameraOptions();
	}

	// @interface MapInitOptionsBuilder : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC21MapInitOptionsBuilder")]
	interface MapInitOptionsBuilder
	{
		// @property (readonly, nonatomic, strong, class) MBMResourceOptions * _Nonnull defaultResourceOptions;
		[Static]
		[Export ("defaultResourceOptions", ArgumentSemantic.Strong)]
		MBMResourceOptions DefaultResourceOptions { get; }

		// +(MapInitOptionsBuilder * _Nonnull)create __attribute__((warn_unused_result("")));
		[Static]
		[Export ("create")]
		MapInitOptionsBuilder Create();

		// -(id)build __attribute__((warn_unused_result("")));
		[Export ("build")]
		MapInitOptions Build();

		// -(MapInitOptionsBuilder * _Nonnull)resourceOptions:(MBMResourceOptions * _Nullable)value __attribute__((warn_unused_result("")));
		[Export ("resourceOptions:")]
		MapInitOptionsBuilder ResourceOptions ([NullAllowed] MBMResourceOptions value);

		// -(MapInitOptionsBuilder * _Nonnull)accessToken:(NSString * _Nonnull)value __attribute__((warn_unused_result("")));
		[Export ("accessToken:")]
		MapInitOptionsBuilder AccessToken (string value);

		// -(MapInitOptionsBuilder * _Nonnull)mapOptions:(MBMMapOptions * _Nullable)value __attribute__((warn_unused_result("")));
		[Export ("mapOptions:")]
		MapInitOptionsBuilder MapOptions ([NullAllowed] MBMMapOptions value);

		// -(MapInitOptionsBuilder * _Nonnull)cameraOptions:(MBMCameraOptions * _Nullable)value __attribute__((warn_unused_result("")));
		[Export ("cameraOptions:")]
		MapInitOptionsBuilder CameraOptions ([NullAllowed] MBMCameraOptions value);

		// -(MapInitOptionsBuilder * _Nonnull)styleUriString:(NSString * _Nonnull)value __attribute__((warn_unused_result("")));
		[Export ("styleUriString:")]
		MapInitOptionsBuilder StyleUriString (string value);

		// -(MapInitOptionsBuilder * _Nonnull)styleUri:(NSURL * _Nonnull)value __attribute__((warn_unused_result("")));
		[Export ("styleUri:")]
		MapInitOptionsBuilder StyleUri (NSUrl value);
	}

	// @interface MapInitOptionsFactory : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC21MapInitOptionsFactory")]
	interface MapInitOptionsFactory
	{
		// +(id)createWithResourceOptions:(MBMResourceOptions * _Nullable)resourceOptions mapOptions:(MBMMapOptions * _Nullable)mapOptions cameraOptions:(MBMCameraOptions * _Nullable)cameraOptions styleURI:(NSString * _Nullable)styleURI styleJSON:(NSString * _Nullable)styleJSON __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithResourceOptions:mapOptions:cameraOptions:styleURI:styleJSON:")]
		NSObject CreateWithResourceOptions ([NullAllowed] MBMResourceOptions resourceOptions, [NullAllowed] MBMMapOptions mapOptions, [NullAllowed] MBMCameraOptions cameraOptions, [NullAllowed] string styleURI, [NullAllowed] string styleJSON);
	}

	// @interface MapboxMapObjC_Swift_401
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_401
	{
		// -(TMBCameraAnimationsManager * _Nonnull)camera __attribute__((warn_unused_result("")));
		[Export ("camera")]
		TMBCameraAnimationsManager Camera();
	}

	// @interface MapboxMapObjC_Swift_408
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_408
	{
		// -(TMBGestureManager * _Nonnull)gestures __attribute__((warn_unused_result("")));
		[Export ("gestures")]
		TMBGestureManager Gestures();
	}

	// @interface MapboxMapObjC_Swift_414
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_414
	{
		// -(TMBViewport * _Nonnull)viewport __attribute__((warn_unused_result("")));
		[Export ("viewport")]
		TMBViewport Viewport();
	}

	// @interface MapboxMapObjC_Swift_420
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_420
	{
		// -(TMBViewAnnotationManager * _Nonnull)viewAnnotations __attribute__((warn_unused_result("")));
		[Export ("viewAnnotations")]
		TMBViewAnnotationManager ViewAnnotations();
	}

	// @interface MapboxMapObjC_Swift_426
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_426
	{
		// -(TMBOrnamentsManager * _Nonnull)ornaments __attribute__((warn_unused_result("")));
		[Export ("ornaments")]
		TMBOrnamentsManager Ornaments();
	}

	// @interface MapboxMapObjC_Swift_432
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_432
	{
		// -(TMBMapboxMap * _Nonnull)mapboxMap __attribute__((warn_unused_result("")));
		[Export ("mapboxMap")]
		TMBMapboxMap MapboxMap();
	}

	// @interface MapboxMapObjC_Swift_438
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_438
	{
		// -(TMBAnnotationOrchestrator * _Nonnull)annotations __attribute__((warn_unused_result("")));
		[Export ("annotations")]
		TMBAnnotationOrchestrator Annotations();
	}

	// @interface MapboxMapObjC_Swift_445
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_445
	{
		// -(void)preferredFrameRateRange:(CAFrameRateRange)value;
		[Export ("preferredFrameRateRange:")]
		void PreferredFrameRateRange (CAFrameRateRange value);

		// -(NSArray<NSNumber *> * _Nonnull)mapboxMapDebugOptions __attribute__((warn_unused_result("")));
		[Export ("mapboxMapDebugOptions")]
		NSNumber[] MapboxMapDebugOptions();

		// -(void)mapboxMapDebugOptions:(NSArray<NSNumber *> * _Nonnull)value;
		[Export ("mapboxMapDebugOptions:")]
		void MapboxMapDebugOptions (NSNumber[] value);

		// -(BOOL)getPresentsWithTransaction __attribute__((warn_unused_result("")));
		[Export ("getPresentsWithTransaction")]
		bool PresentsWithTransaction();

		// -(void)setPresentsWithTransaction:(BOOL)value;
		[Export ("setPresentsWithTransaction:")]
		void SetPresentsWithTransaction (bool value);

		// -(NSInteger)getPreferredFramesPerSecond __attribute__((warn_unused_result("")));
		[Export ("getPreferredFramesPerSecond")]
		nint PreferredFramesPerSecond();

		// -(void)setPreferredFramesPerSecond:(NSInteger)value;
		[Export ("setPreferredFramesPerSecond:")]
		void SetPreferredFramesPerSecond (nint value);

		// -(CAFrameRateRange)getPreferredFrameRateRange __attribute__((warn_unused_result(""))) __attribute__((availability(ios, introduced=15.0)));
		[iOS (15, 0)]
		[Export ("getPreferredFrameRateRange")]
		CAFrameRateRange PreferredFrameRateRange();

		// -(void)setPreferredFrameRateRange:(CAFrameRateRange)value __attribute__((availability(ios, introduced=15.0)));
		[iOS (15,0)]
		[Export ("setPreferredFrameRateRange:")]
		void SetPreferredFrameRateRange (CAFrameRateRange value);

		// -(MBMCameraState * _Nonnull)getCameraState __attribute__((warn_unused_result("")));
		[Export ("getCameraState")]
		MBMCameraState CameraState();

		// -(CGPoint)getAnchor __attribute__((warn_unused_result("")));
		[Export ("getAnchor")]
		CGPoint Anchor();
	}

	// @interface MapViewFactory : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC14MapViewFactory")]
	[DisableDefaultCtor]
	interface MapViewFactory
	{
		// +(id)createWithFrame:(CGRect)frame options:(id)options __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithFrame:options:")]
		MapView CreateWithFrame (CGRect frame, MapInitOptions options);

		// +(id)createWithFrame:(CGRect)frame mapInitOptions:(id)mapInitOptions urlOpener:(id<TMBAttributionURLOpener> _Nonnull)urlOpener __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithFrame:mapInitOptions:urlOpener:")]
		MapView CreateWithFrame (CGRect frame, MapInitOptions mapInitOptions, TMBAttributionURLOpener urlOpener);
	}

	// @protocol NamedString
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol (Name = "_TtP13MapboxMapObjC11NamedString_"), Model]
    [BaseType(typeof(NSObject))]
	interface NamedString
	{
		// @required -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("stringValue")]
		string StringValue { get; }
	}

	// @interface MapboxMapObjC_Swift_482
    [Category]
    [BaseType(typeof(MBMOfflineManager))]
	interface MapboxMapObjC_Swift_482
	{
		// -(TMBCancelable * _Nonnull)loadStyleWithStyleUriString:(NSString * _Nonnull)styleUriString styleLoadOptions:(MBMStylePackLoadOptions * _Nonnull)styleLoadOptions progress:(id)progress completion:(void (^ _Nonnull)(MBMStylePack * _Nullable, NSError * _Nullable))completion __attribute__((warn_unused_result("")));
		[Export ("loadStyleWithStyleUriString:styleLoadOptions:progress:completion:")]
		TMBCancelable LoadStyleWithStyleUriString (string styleUriString, MBMStylePackLoadOptions styleLoadOptions, NSObject progress, Action<MBMStylePack, NSError> completion);

		// -(void)allStylePacks:(void (^ _Nonnull)(NSArray<MBMStylePack *> * _Nullable, NSError * _Nullable))completion;
		[Export ("allStylePacks:")]
		void AllStylePacks (Action<NSArray<MBMStylePack>, NSError> completion);
	}

	// @interface TMBAnchor : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC9TMBAnchor")]
	[DisableDefaultCtor]
	interface TMBAnchor : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBAnchor * _Nonnull map;
		[Static]
		[Export ("map", ArgumentSemantic.Strong)]
		TMBAnchor Map { get; }

		// @property (readonly, nonatomic, strong, class) TMBAnchor * _Nonnull viewport;
		[Static]
		[Export ("viewport", ArgumentSemantic.Strong)]
		TMBAnchor Viewport { get; }
	}

	// @interface TMBAnimationOwner : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC17TMBAnimationOwner")]
	[DisableDefaultCtor]
	interface TMBAnimationOwner : NamedString
	{
		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// -(instancetype _Nonnull)initWithRawValue:(NSString * _Nonnull)rawValue __attribute__((objc_designated_initializer));
		[Export ("initWithRawValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string rawValue);

		// @property (readonly, nonatomic, strong, class) TMBAnimationOwner * _Nonnull gestures;
		[Static]
		[Export ("gestures", ArgumentSemantic.Strong)]
		TMBAnimationOwner Gestures { get; }

		// @property (readonly, nonatomic, strong, class) TMBAnimationOwner * _Nonnull unspecified;
		[Static]
		[Export ("unspecified", ArgumentSemantic.Strong)]
		TMBAnimationOwner Unspecified { get; }
	}

	// @protocol TMBAnnotation
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol (Name = "_TtP13MapboxMapObjC13TMBAnnotation_"), Model]
    [BaseType(typeof(NSObject))]
	interface TMBAnnotation
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Abstract]
		[Export ("id")]
		string Id { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull geometryInJSON;
		[Abstract]
		[Export ("geometryInJSON")]
		string GeometryInJSON { get; }

		// @required @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable userInfo;
		[Abstract]
		[NullAllowed, Export ("userInfo", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> UserInfo { get; }
	}

	partial interface ITMBAnnotation { }

	partial interface ITMBAnnotationManager { }

	partial interface ITMBAnnotationInteractionDelegate { }

	// @protocol TMBAnnotationInteractionDelegate
	[Protocol (Name = "_TtP13MapboxMapObjC32TMBAnnotationInteractionDelegate_"), Model]
	[BaseType(typeof(NSObject))]
	interface TMBAnnotationInteractionDelegate
	{
		// @required -(void)annotationManager:(id<TMBAnnotationManager> _Nonnull)manager didDetectTappedAnnotations:(NSArray<id<TMBAnnotation>> * _Nonnull)annotations;
		[Abstract]
		[Export ("annotationManager:didDetectTappedAnnotations:")]
		void DidDetectTappedAnnotations (ITMBAnnotationManager manager, NSArray annotations);
	}

	// @protocol TMBAnnotationManager
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol (Name = "_TtP13MapboxMapObjC20TMBAnnotationManager_"), Model]
	[BaseType(typeof(NSObject))]
	interface TMBAnnotationManager
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Abstract]
		[Export ("id")]
		string Id { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull sourceId;
		[Abstract]
		[Export ("sourceId")]
		string SourceId { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull layerId;
		[Abstract]
		[Export ("layerId")]
		string LayerId { get; }
	}

	// @interface TMBAnnotationOrchestrator : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC25TMBAnnotationOrchestrator")]
	[DisableDefaultCtor]
	interface TMBAnnotationOrchestrator
	{
		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id<TMBAnnotationManager>> * _Nonnull annotationManagersById;
		[Export ("annotationManagersById", ArgumentSemantic.Copy)]
		NSDictionary<NSString, TMBAnnotationManager> AnnotationManagersById { get; }

		// -(TMBPointAnnotationManager * _Nonnull)makePointAnnotationManagerWithId:(NSString * _Nullable)id layerPosition:(TMBLayerPosition * _Nullable)layerPosition clusterOptions:(TMBClusterOptions * _Nullable)clusterOptions __attribute__((warn_unused_result("")));
		[Export ("makePointAnnotationManagerWithId:layerPosition:clusterOptions:")]
		TMBPointAnnotationManager MakePointAnnotationManagerWithId ([NullAllowed] string id, [NullAllowed] TMBLayerPosition layerPosition, [NullAllowed] TMBClusterOptions clusterOptions);

		// -(TMBPolygonAnnotationManager * _Nonnull)makePolygonAnnotationManagerWithId:(NSString * _Nullable)id layerPosition:(TMBLayerPosition * _Nullable)layerPosition __attribute__((warn_unused_result("")));
		[Export ("makePolygonAnnotationManagerWithId:layerPosition:")]
		TMBPolygonAnnotationManager MakePolygonAnnotationManagerWithId ([NullAllowed] string id, [NullAllowed] TMBLayerPosition layerPosition);

		// -(TMBPolylineAnnotationManager * _Nonnull)makePolylineAnnotationManagerWithId:(NSString * _Nullable)id layerPosition:(TMBLayerPosition * _Nullable)layerPosition __attribute__((warn_unused_result("")));
		[Export ("makePolylineAnnotationManagerWithId:layerPosition:")]
		TMBPolylineAnnotationManager MakePolylineAnnotationManagerWithId ([NullAllowed] string id, [NullAllowed] TMBLayerPosition layerPosition);

		// -(TMBCircleAnnotationManager * _Nonnull)makeCircleAnnotationManagerWithId:(NSString * _Nullable)id layerPosition:(TMBLayerPosition * _Nullable)layerPosition __attribute__((warn_unused_result("")));
		[Export ("makeCircleAnnotationManagerWithId:layerPosition:")]
		TMBCircleAnnotationManager MakeCircleAnnotationManagerWithId ([NullAllowed] string id, [NullAllowed] TMBLayerPosition layerPosition);

		// -(void)removeAnnotationManagerWithId:(NSString * _Nonnull)id;
		[Export ("removeAnnotationManagerWithId:")]
		void RemoveAnnotationManagerWithId (string id);
	}

	// @interface TMBAtmosphere : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13TMBAtmosphere")]
	interface TMBAtmosphere
	{
		// @property (nonatomic, strong) TMBValue * _Nullable color;
		[NullAllowed, Export ("color", ArgumentSemantic.Strong)]
		TMBValue Color { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable colorTransition;
		[NullAllowed, Export ("colorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition ColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable highColor;
		[NullAllowed, Export ("highColor", ArgumentSemantic.Strong)]
		TMBValue HighColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable highColorTransition;
		[NullAllowed, Export ("highColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition HighColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable horizonBlend;
		[NullAllowed, Export ("horizonBlend", ArgumentSemantic.Strong)]
		TMBValue HorizonBlend { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable horizonBlendTransition;
		[NullAllowed, Export ("horizonBlendTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition HorizonBlendTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable range;
		[NullAllowed, Export ("range", ArgumentSemantic.Strong)]
		TMBValue Range { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable rangeTransition;
		[NullAllowed, Export ("rangeTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition RangeTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable spaceColor;
		[NullAllowed, Export ("spaceColor", ArgumentSemantic.Strong)]
		TMBValue SpaceColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable spaceColorTransition;
		[NullAllowed, Export ("spaceColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition SpaceColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable starIntensity;
		[NullAllowed, Export ("starIntensity", ArgumentSemantic.Strong)]
		TMBValue StarIntensity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable starIntensityTransition;
		[NullAllowed, Export ("starIntensityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition StarIntensityTransition { get; set; }
	}

	// @interface TMBAttributionButtonOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC27TMBAttributionButtonOptions")]
	[DisableDefaultCtor]
	interface TMBAttributionButtonOptions
	{
		// @property (nonatomic) enum TMBOrnamentPosition position;
		[Export ("position", ArgumentSemantic.Assign)]
		TMBOrnamentPosition Position { get; set; }

		// @property (nonatomic) CGPoint margins;
		[Export ("margins", ArgumentSemantic.Assign)]
		CGPoint Margins { get; set; }
	}

	// @protocol TMBAttributionURLOpener
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol (Name = "_TtP13MapboxMapObjC23TMBAttributionURLOpener_"), Model]
	[BaseType(typeof(NSObject))]
	interface TMBAttributionURLOpener
	{
		// @required -(void)openAttributionURL:(NSURL * _Nonnull)url;
		[Abstract]
		[Export ("openAttributionURL:")]
		void OpenAttributionURL (NSUrl url);
	}

	// @interface TMBCameraAnimationsManager : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC26TMBCameraAnimationsManager")]
	[DisableDefaultCtor]
	interface TMBCameraAnimationsManager
	{
		// @property (readonly, copy, nonatomic) NSArray<TMBCameraAnimator *> * _Nonnull cameraAnimators;
		[Export ("cameraAnimators", ArgumentSemantic.Copy)]
		TMBCameraAnimator[] CameraAnimators { get; }

		// -(void)cancelAnimations;
		[Export ("cancelAnimations")]
		void CancelAnimations ();

		// -(TMBCancelable * _Nullable)flyTo:(MBMCameraOptions * _Nonnull)to duration:(NSNumber * _Nullable)duration completion:(void (^ _Nullable)(UIViewAnimatingPosition))completion;
		[Export ("flyTo:duration:completion:")]
		[return: NullAllowed]
		TMBCancelable FlyTo (MBMCameraOptions to, [NullAllowed] NSNumber duration, [NullAllowed] Action<UIViewAnimatingPosition> completion);

		// -(TMBCancelable * _Nullable)easeTo:(MBMCameraOptions * _Nonnull)to duration:(NSTimeInterval)duration curve:(enum UIViewAnimationCurve)curve completion:(void (^ _Nullable)(UIViewAnimatingPosition))completion;
		[Export ("easeTo:duration:curve:completion:")]
		[return: NullAllowed]
		TMBCancelable EaseTo (MBMCameraOptions to, double duration, UIViewAnimationCurve curve, [NullAllowed] Action<UIViewAnimatingPosition> completion);

		// -(BasicCameraAnimator * _Nonnull)makeAnimatorWithDuration:(NSTimeInterval)duration timingParameters:(id<UITimingCurveProvider> _Nonnull)timingParameters animationOwner:(TMBAnimationOwner * _Nullable)animationOwner animations:(void (^ _Nonnull)(TMBCameraTransition * _Nonnull))animations __attribute__((warn_unused_result("")));
		[Export ("makeAnimatorWithDuration:timingParameters:animationOwner:animations:")]
		BasicCameraAnimator MakeAnimatorWithDuration (double duration, UITimingCurveProvider timingParameters, [NullAllowed] TMBAnimationOwner animationOwner, Action<TMBCameraTransition> animations);

		// -(BasicCameraAnimator * _Nonnull)makeAnimatorWithDuration:(NSTimeInterval)duration curve:(enum UIViewAnimationCurve)curve animationOwner:(TMBAnimationOwner * _Nullable)animationOwner animations:(void (^ _Nonnull)(TMBCameraTransition * _Nonnull))animations __attribute__((warn_unused_result("")));
		[Export ("makeAnimatorWithDuration:curve:animationOwner:animations:")]
		BasicCameraAnimator MakeAnimatorWithDuration (double duration, UIViewAnimationCurve curve, [NullAllowed] TMBAnimationOwner animationOwner, Action<TMBCameraTransition> animations);

		// -(BasicCameraAnimator * _Nonnull)makeAnimatorWithDuration:(NSTimeInterval)duration controlPoint1:(CGPoint)controlPoint1 controlPoint2:(CGPoint)controlPoint2 animationOwner:(TMBAnimationOwner * _Nullable)animationOwner animations:(void (^ _Nonnull)(TMBCameraTransition * _Nonnull))animations __attribute__((warn_unused_result("")));
		[Export ("makeAnimatorWithDuration:controlPoint1:controlPoint2:animationOwner:animations:")]
		BasicCameraAnimator MakeAnimatorWithDuration (double duration, CGPoint controlPoint1, CGPoint controlPoint2, [NullAllowed] TMBAnimationOwner animationOwner, Action<TMBCameraTransition> animations);

		// -(BasicCameraAnimator * _Nonnull)makeAnimatorWithDuration:(NSTimeInterval)duration dampingRatio:(CGFloat)dampingRatio animationOwner:(TMBAnimationOwner * _Nullable)animationOwner animations:(void (^ _Nonnull)(TMBCameraTransition * _Nonnull))animations __attribute__((warn_unused_result("")));
		[Export ("makeAnimatorWithDuration:dampingRatio:animationOwner:animations:")]
		BasicCameraAnimator MakeAnimatorWithDuration (double duration, nfloat dampingRatio, [NullAllowed] TMBAnimationOwner animationOwner, Action<TMBCameraTransition> animations);
	}

	// @interface TMBCameraAnimator : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC17TMBCameraAnimator")]
	[DisableDefaultCtor]
	interface TMBCameraAnimator
	{
		// @property (readonly, nonatomic) UIViewAnimatingState state;
		[Export ("state")]
		UIViewAnimatingState State { get; }

		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();
	}

	// @interface TMBCameraTransition : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC19TMBCameraTransition")]
	[DisableDefaultCtor]
	interface TMBCameraTransition
	{
		// @property (readonly, nonatomic, strong) TMBCameraTransitionChange * _Nonnull center;
		[Export ("center", ArgumentSemantic.Strong)]
		TMBCameraTransitionChange Center { get; }

		// @property (readonly, nonatomic, strong) TMBCameraTransitionChange * _Nonnull zoom;
		[Export ("zoom", ArgumentSemantic.Strong)]
		TMBCameraTransitionChange Zoom { get; }

		// @property (readonly, nonatomic, strong) TMBCameraTransitionChange * _Nonnull padding;
		[Export ("padding", ArgumentSemantic.Strong)]
		TMBCameraTransitionChange Padding { get; }

		// @property (readonly, nonatomic, strong) TMBCameraTransitionChange * _Nonnull anchor;
		[Export ("anchor", ArgumentSemantic.Strong)]
		TMBCameraTransitionChange Anchor { get; }

		// @property (readonly, nonatomic, strong) TMBCameraTransitionChange * _Nonnull bearing;
		[Export ("bearing", ArgumentSemantic.Strong)]
		TMBCameraTransitionChange Bearing { get; }

		// @property (nonatomic) BOOL shouldOptimizeBearingPath;
		[Export ("shouldOptimizeBearingPath")]
		bool ShouldOptimizeBearingPath { get; set; }

		// @property (readonly, nonatomic, strong) TMBCameraTransitionChange * _Nonnull pitch;
		[Export ("pitch", ArgumentSemantic.Strong)]
		TMBCameraTransitionChange Pitch { get; }
	}

	// @interface TMBCameraTransitionChange : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC25TMBCameraTransitionChange")]
	[DisableDefaultCtor]
	interface TMBCameraTransitionChange
	{
		// @property (nonatomic, strong) NSValue * _Nonnull fromValue;
		[Export ("fromValue", ArgumentSemantic.Strong)]
		NSValue FromValue { get; set; }

		// @property (nonatomic, strong) NSValue * _Nullable toValue;
		[NullAllowed, Export ("toValue", ArgumentSemantic.Strong)]
		NSValue ToValue { get; set; }
	}

	// @interface TMBCancelable : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13TMBCancelable")]
	[DisableDefaultCtor]
	interface TMBCancelable
	{
		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();
	}

	// @interface TMBCircleAnnotation : NSObject <TMBAnnotation>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC19TMBCircleAnnotation")]
	[DisableDefaultCtor]
	interface TMBCircleAnnotation : TMBAnnotation
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull geometryInJSON;
		[Export ("geometryInJSON")]
		string GeometryInJSON { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable userInfo;
		[NullAllowed, Export ("userInfo", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> UserInfo { get; }

		// @property (nonatomic) BOOL isSelected;
		[Export ("isSelected")]
		bool IsSelected { get; set; }

		// @property (nonatomic) BOOL isDraggable;
		[Export ("isDraggable")]
		bool IsDraggable { get; set; }

		// +(TMBCircleAnnotation * _Nonnull)fromCenter:(CLLocationCoordinate2D)coordinate __attribute__((warn_unused_result("")));
		[Static]
		[Export ("fromCenter:")]
		TMBCircleAnnotation FromCenter (CLLocationCoordinate2D coordinate);

		// @property (nonatomic, strong) NSNumber * _Nullable circleSortKey;
		[NullAllowed, Export ("circleSortKey", ArgumentSemantic.Strong)]
		NSNumber CircleSortKey { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable circleBlur;
		[NullAllowed, Export ("circleBlur", ArgumentSemantic.Strong)]
		NSNumber CircleBlur { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable circleColor;
		[NullAllowed, Export ("circleColor", ArgumentSemantic.Strong)]
		UIColor CircleColor { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable circleOpacity;
		[NullAllowed, Export ("circleOpacity", ArgumentSemantic.Strong)]
		NSNumber CircleOpacity { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable circleRadius;
		[NullAllowed, Export ("circleRadius", ArgumentSemantic.Strong)]
		NSNumber CircleRadius { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable circleStrokeColor;
		[NullAllowed, Export ("circleStrokeColor", ArgumentSemantic.Strong)]
		UIColor CircleStrokeColor { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable circleStrokeOpacity;
		[NullAllowed, Export ("circleStrokeOpacity", ArgumentSemantic.Strong)]
		NSNumber CircleStrokeOpacity { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable circleStrokeWidth;
		[NullAllowed, Export ("circleStrokeWidth", ArgumentSemantic.Strong)]
		NSNumber CircleStrokeWidth { get; set; }
	}

	// @interface TMBCircleAnnotationManager : NSObject <TMBAnnotationManager>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC26TMBCircleAnnotationManager")]
	[DisableDefaultCtor]
	interface TMBCircleAnnotationManager : TMBAnnotationManager
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sourceId;
		[Export ("sourceId")]
		string SourceId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull layerId;
		[Export ("layerId")]
		string LayerId { get; }

		// @property (copy, nonatomic) NSArray<TMBCircleAnnotation *> * _Nonnull annotations;
		[Export ("annotations", ArgumentSemantic.Copy)]
		TMBCircleAnnotation[] Annotations { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		TMBAnnotationInteractionDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TMBAnnotationInteractionDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) TMBCirclePitchAlignment * _Nullable circlePitchAlignment;
		[NullAllowed, Export ("circlePitchAlignment", ArgumentSemantic.Strong)]
		TMBCirclePitchAlignment CirclePitchAlignment { get; set; }

		// @property (nonatomic, strong) TMBCirclePitchScale * _Nullable circlePitchScale;
		[NullAllowed, Export ("circlePitchScale", ArgumentSemantic.Strong)]
		TMBCirclePitchScale CirclePitchScale { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable circleTranslate;
		[NullAllowed, Export ("circleTranslate", ArgumentSemantic.Copy)]
		NSNumber[] CircleTranslate { get; set; }

		// @property (nonatomic, strong) TMBCircleTranslateAnchor * _Nullable circleTranslateAnchor;
		[NullAllowed, Export ("circleTranslateAnchor", ArgumentSemantic.Strong)]
		TMBCircleTranslateAnchor CircleTranslateAnchor { get; set; }
	}

	// @interface TMBCirclePitchAlignment : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC23TMBCirclePitchAlignment")]
	[DisableDefaultCtor]
	interface TMBCirclePitchAlignment : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBCirclePitchAlignment * _Nonnull map;
		[Static]
		[Export ("map", ArgumentSemantic.Strong)]
		TMBCirclePitchAlignment Map { get; }

		// @property (readonly, nonatomic, strong, class) TMBCirclePitchAlignment * _Nonnull viewport;
		[Static]
		[Export ("viewport", ArgumentSemantic.Strong)]
		TMBCirclePitchAlignment Viewport { get; }
	}

	// @interface TMBCirclePitchScale : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC19TMBCirclePitchScale")]
	[DisableDefaultCtor]
	interface TMBCirclePitchScale : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBCirclePitchScale * _Nonnull map;
		[Static]
		[Export ("map", ArgumentSemantic.Strong)]
		TMBCirclePitchScale Map { get; }

		// @property (readonly, nonatomic, strong, class) TMBCirclePitchScale * _Nonnull viewport;
		[Static]
		[Export ("viewport", ArgumentSemantic.Strong)]
		TMBCirclePitchScale Viewport { get; }
	}

	// @interface TMBCircleTranslateAnchor : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC24TMBCircleTranslateAnchor")]
	[DisableDefaultCtor]
	interface TMBCircleTranslateAnchor : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBCircleTranslateAnchor * _Nonnull map;
		[Static]
		[Export ("map", ArgumentSemantic.Strong)]
		TMBCircleTranslateAnchor Map { get; }

		// @property (readonly, nonatomic, strong, class) TMBCircleTranslateAnchor * _Nonnull viewport;
		[Static]
		[Export ("viewport", ArgumentSemantic.Strong)]
		TMBCircleTranslateAnchor Viewport { get; }
	}

	// @interface TMBClusterOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC17TMBClusterOptions")]
	[DisableDefaultCtor]
	interface TMBClusterOptions
	{
		// @property (nonatomic, strong) TMBValue * _Nullable circleRadius;
		[NullAllowed, Export ("circleRadius", ArgumentSemantic.Strong)]
		TMBValue CircleRadius { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable circleColor;
		[NullAllowed, Export ("circleColor", ArgumentSemantic.Strong)]
		TMBValue CircleColor { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
		TMBValue TextColor { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textSize;
		[NullAllowed, Export ("textSize", ArgumentSemantic.Strong)]
		TMBValue TextSize { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textField;
		[NullAllowed, Export ("textField", ArgumentSemantic.Strong)]
		TMBValue TextField { get; set; }

		// @property (nonatomic) double clusterRadius;
		[Export ("clusterRadius")]
		double ClusterRadius { get; set; }

		// @property (nonatomic) double clusterMaxZoom;
		[Export ("clusterMaxZoom")]
		double ClusterMaxZoom { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,TMBExpression *> * _Nullable clusterProperties;
		[NullAllowed, Export ("clusterProperties", ArgumentSemantic.Copy)]
		NSDictionary<NSString, TMBExpression> ClusterProperties { get; set; }

		// -(instancetype _Nonnull)initWithCircleRadius:(TMBValue * _Nullable)circleRadius circleColor:(TMBValue * _Nullable)circleColor textColor:(TMBValue * _Nullable)textColor textSize:(TMBValue * _Nullable)textSize textField:(TMBValue * _Nullable)textField clusterRadius:(double)clusterRadius clusterMaxZoom:(double)clusterMaxZoom clusterProperties:(NSDictionary<NSString *,TMBExpression *> * _Nullable)clusterProperties __attribute__((objc_designated_initializer));
		[Export ("initWithCircleRadius:circleColor:textColor:textSize:textField:clusterRadius:clusterMaxZoom:clusterProperties:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] TMBValue circleRadius, [NullAllowed] TMBValue circleColor, [NullAllowed] TMBValue textColor, [NullAllowed] TMBValue textSize, [NullAllowed] TMBValue textField, double clusterRadius, double clusterMaxZoom, [NullAllowed] NSDictionary<NSString, TMBExpression> clusterProperties);
	}

	// @interface TMBCollatorOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBCollatorOptions")]
	[DisableDefaultCtor]
	interface TMBCollatorOptions
	{
		// @property (nonatomic, strong) NSNumber * _Nullable caseSensitive;
		[NullAllowed, Export ("caseSensitive", ArgumentSemantic.Strong)]
		NSNumber CaseSensitive { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable diacriticSensitive;
		[NullAllowed, Export ("diacriticSensitive", ArgumentSemantic.Strong)]
		NSNumber DiacriticSensitive { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable locale;
		[NullAllowed, Export ("locale")]
		string Locale { get; set; }

		// -(instancetype _Nonnull)initWithCaseSensitive:(NSNumber * _Nullable)caseSensitive diacriticSensitive:(NSNumber * _Nullable)diacriticSensitive locale:(NSString * _Nullable)locale __attribute__((objc_designated_initializer));
		[Export ("initWithCaseSensitive:diacriticSensitive:locale:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] NSNumber caseSensitive, [NullAllowed] NSNumber diacriticSensitive, [NullAllowed] string locale);
	}

	// @interface TMBCompassViewOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC21TMBCompassViewOptions")]
	[DisableDefaultCtor]
	interface TMBCompassViewOptions
	{
		// @property (nonatomic) enum TMBOrnamentPosition position;
		[Export ("position", ArgumentSemantic.Assign)]
		TMBOrnamentPosition Position { get; set; }

		// @property (nonatomic) CGPoint margins;
		[Export ("margins", ArgumentSemantic.Assign)]
		CGPoint Margins { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (nonatomic) enum TMBOrnamentVisibility visibility;
		[Export ("visibility", ArgumentSemantic.Assign)]
		TMBOrnamentVisibility Visibility { get; set; }
	}

	// @interface TMBDefaultViewportTransition : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC28TMBDefaultViewportTransition")]
	[DisableDefaultCtor]
	interface TMBDefaultViewportTransition
	{
		// @property (nonatomic, strong) TMBDefaultViewportTransitionOptions * _Nonnull options;
		[Export ("options", ArgumentSemantic.Strong)]
		TMBDefaultViewportTransitionOptions Options { get; set; }
	}

	// @protocol TMBViewportTransition
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol (Name = "_TtP13MapboxMapObjC21TMBViewportTransition_")]
	interface TMBViewportTransition
	{
		// @required -(TMBCancelable * _Nonnull)runTo:(id<TMBViewportState> _Nonnull)toState completion:(void (^ _Nonnull)(BOOL))completion __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("runTo:completion:")]
		TMBCancelable Completion (TMBViewportState toState, Action<bool> completion);
	}

	// @interface MapboxMapObjC_Swift_1121 (TMBDefaultViewportTransition) <TMBViewportTransition>
	[Category]
	[BaseType (typeof(TMBDefaultViewportTransition))]
	interface TMBDefaultViewportTransition_MapboxMapObjC_Swift_1121 : TMBViewportTransition
	{
		// -(TMBCancelable * _Nonnull)runTo:(id<TMBViewportState> _Nonnull)toState completion:(void (^ _Nonnull)(BOOL))completion __attribute__((warn_unused_result("")));
		[Export ("runTo:completion:")]
		TMBCancelable RunTo (TMBViewportState toState, Action<bool> completion);
	}

	// @interface TMBDefaultViewportTransitionOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC35TMBDefaultViewportTransitionOptions")]
	[DisableDefaultCtor]
	interface TMBDefaultViewportTransitionOptions
	{
		// @property (nonatomic) NSTimeInterval maxDuration;
		[Export ("maxDuration")]
		double MaxDuration { get; set; }

		// -(instancetype _Nonnull)initWithMaxDuration:(NSTimeInterval)maxDuration __attribute__((objc_designated_initializer));
		[Export ("initWithMaxDuration:")]
		[DesignatedInitializer]
		IntPtr Constructor (double maxDuration);
	}

	// @interface TMBEncoding : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC11TMBEncoding")]
	[DisableDefaultCtor]
	interface TMBEncoding : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBEncoding * _Nonnull terrarium;
		[Static]
		[Export ("terrarium", ArgumentSemantic.Strong)]
		TMBEncoding Terrarium { get; }

		// @property (readonly, nonatomic, strong, class) TMBEncoding * _Nonnull mapbox;
		[Static]
		[Export ("mapbox", ArgumentSemantic.Strong)]
		TMBEncoding Mapbox { get; }
	}

	// @interface TMBExpression : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13TMBExpression")]
	[DisableDefaultCtor]
	interface TMBExpression
	{
		// +(TMBExpression * _Nonnull)createWithOperator:(TMBOperator * _Nonnull)operator_ __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithOperator:")]
		TMBExpression CreateWithOperator (TMBOperator operator_);

		// +(TMBExpression * _Nonnull)createWithOperator:(TMBOperator * _Nonnull)operator_ arguments:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithOperator:arguments:")]
		TMBExpression CreateWithOperator (TMBOperator operator_, NSObject[] arguments);

		// +(TMBExpression * _Nonnull)createWithArguments:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithArguments:")]
		TMBExpression CreateWithArguments (NSObject[] arguments);
	}

	// @interface TMBExpressionOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC20TMBExpressionOptions")]
	[DisableDefaultCtor]
	interface TMBExpressionOptions
	{
		// @property (readonly, nonatomic) enum TMBExpressionOptionsType type;
		[Export ("type")]
		TMBExpressionOptionsType Type { get; }

		// @property (readonly, nonatomic) id _Nonnull options;
		[Export ("options")]
		NSObject Options { get; }

		// +(TMBExpressionOptions * _Nonnull)formatWithOptions:(TMBFormatOptions * _Nonnull)options __attribute__((warn_unused_result("")));
		[Static]
		[Export ("formatWithOptions:")]
		TMBExpressionOptions FormatWithOptions (TMBFormatOptions options);

		// +(TMBExpressionOptions * _Nonnull)numberFormatWithOptions:(TMBNumberFormatOptions * _Nonnull)options __attribute__((warn_unused_result("")));
		[Static]
		[Export ("numberFormatWithOptions:")]
		TMBExpressionOptions NumberFormatWithOptions (TMBNumberFormatOptions options);

		// +(TMBExpressionOptions * _Nonnull)collatorWithOptions:(TMBCollatorOptions * _Nonnull)options __attribute__((warn_unused_result("")));
		[Static]
		[Export ("collatorWithOptions:")]
		TMBExpressionOptions CollatorWithOptions (TMBCollatorOptions options);
	}

	// @interface TMBFillExtrusionTranslateAnchor : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC31TMBFillExtrusionTranslateAnchor")]
	[DisableDefaultCtor]
	interface TMBFillExtrusionTranslateAnchor : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBFillExtrusionTranslateAnchor * _Nonnull map;
		[Static]
		[Export ("map", ArgumentSemantic.Strong)]
		TMBFillExtrusionTranslateAnchor Map { get; }

		// @property (readonly, nonatomic, strong, class) TMBFillExtrusionTranslateAnchor * _Nonnull viewport;
		[Static]
		[Export ("viewport", ArgumentSemantic.Strong)]
		TMBFillExtrusionTranslateAnchor Viewport { get; }
	}

	// @interface TMBFillTranslateAnchor : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC22TMBFillTranslateAnchor")]
	[DisableDefaultCtor]
	interface TMBFillTranslateAnchor : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBFillTranslateAnchor * _Nonnull map;
		[Static]
		[Export ("map", ArgumentSemantic.Strong)]
		TMBFillTranslateAnchor Map { get; }

		// @property (readonly, nonatomic, strong, class) TMBFillTranslateAnchor * _Nonnull viewport;
		[Static]
		[Export ("viewport", ArgumentSemantic.Strong)]
		TMBFillTranslateAnchor Viewport { get; }
	}

	// @interface TMBFollowPuckViewportState : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC26TMBFollowPuckViewportState")]
	[DisableDefaultCtor]
	interface TMBFollowPuckViewportState
	{
		// @property (nonatomic, strong) TMBFollowPuckViewportStateOptions * _Nonnull options;
		[Export ("options", ArgumentSemantic.Strong)]
		TMBFollowPuckViewportStateOptions Options { get; set; }
	}

	// @protocol TMBViewportState
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/

	partial interface ITMBViewportState { }

	[Protocol (Name = "_TtP13MapboxMapObjC16TMBViewportState_"), Model]
	[BaseType(typeof(NSObject))]
	interface TMBViewportState
	{
		// @required -(TMBCancelable * _Nonnull)observeDataSourceWith:(BOOL (^ _Nonnull)(MBMCameraOptions * _Nonnull))handler __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("observeDataSourceWith:")]
		TMBCancelable ObserveDataSourceWith (Func<MBMCameraOptions, bool> handler);

		// @required -(void)startUpdatingCamera;
		[Abstract]
		[Export ("startUpdatingCamera")]
		void StartUpdatingCamera ();

		// @required -(void)stopUpdatingCamera;
		[Abstract]
		[Export ("stopUpdatingCamera")]
		void StopUpdatingCamera ();
	}

	// @interface MapboxMapObjC_Swift_1294 (TMBFollowPuckViewportState) <TMBViewportState>
	[Category]
	[BaseType (typeof(TMBFollowPuckViewportState))]
	interface TMBFollowPuckViewportState_MapboxMapObjC_Swift_1294 : TMBViewportState
	{
		// -(TMBCancelable * _Nonnull)observeDataSourceWith:(BOOL (^ _Nonnull)(MBMCameraOptions * _Nonnull))handler __attribute__((warn_unused_result("")));
		[Export ("observeDataSourceWith:")]
		TMBCancelable ObserveDataSourceWith (Func<MBMCameraOptions, bool> handler);

		// -(void)startUpdatingCamera;
		[Export ("startUpdatingCamera")]
		void StartUpdatingCamera ();

		// -(void)stopUpdatingCamera;
		[Export ("stopUpdatingCamera")]
		void StopUpdatingCamera ();
	}

	// @interface TMBFollowPuckViewportStateBearing : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC33TMBFollowPuckViewportStateBearing")]
	[DisableDefaultCtor]
	interface TMBFollowPuckViewportStateBearing
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nullable bearing;
		[NullAllowed, Export ("bearing", ArgumentSemantic.Strong)]
		NSNumber Bearing { get; }

		// +(TMBFollowPuckViewportStateBearing * _Nonnull)constant:(CLLocationDirection)bearing __attribute__((warn_unused_result("")));
		[Static]
		[Export ("constant:")]
		TMBFollowPuckViewportStateBearing Constant (double bearing);

		// @property (readonly, nonatomic, strong, class) TMBFollowPuckViewportStateBearing * _Nonnull heading;
		[Static]
		[Export ("heading", ArgumentSemantic.Strong)]
		TMBFollowPuckViewportStateBearing Heading { get; }

		// @property (readonly, nonatomic, strong, class) TMBFollowPuckViewportStateBearing * _Nonnull course;
		[Static]
		[Export ("course", ArgumentSemantic.Strong)]
		TMBFollowPuckViewportStateBearing Course { get; }
	}

	// @interface TMBFollowPuckViewportStateOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC33TMBFollowPuckViewportStateOptions")]
	[DisableDefaultCtor]
	interface TMBFollowPuckViewportStateOptions
	{
		// @property (nonatomic, strong) NSValue * _Nullable padding;
		[NullAllowed, Export ("padding", ArgumentSemantic.Strong)]
		NSValue Padding { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable zoom;
		[NullAllowed, Export ("zoom", ArgumentSemantic.Strong)]
		NSNumber Zoom { get; set; }

		// @property (nonatomic, strong) TMBFollowPuckViewportStateBearing * _Nullable bearing;
		[NullAllowed, Export ("bearing", ArgumentSemantic.Strong)]
		TMBFollowPuckViewportStateBearing Bearing { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pitch;
		[NullAllowed, Export ("pitch", ArgumentSemantic.Strong)]
		NSNumber Pitch { get; set; }

		// -(instancetype _Nonnull)initWithPadding:(NSValue * _Nullable)padding zoom:(NSNumber * _Nullable)zoom bearing:(TMBFollowPuckViewportStateBearing * _Nullable)bearing pitch:(NSNumber * _Nullable)pitch __attribute__((objc_designated_initializer));
		[Export ("initWithPadding:zoom:bearing:pitch:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] NSValue padding, [NullAllowed] NSNumber zoom, [NullAllowed] TMBFollowPuckViewportStateBearing bearing, [NullAllowed] NSNumber pitch);
	}

	// @interface TMBFormatOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC16TMBFormatOptions")]
	[DisableDefaultCtor]
	interface TMBFormatOptions
	{
		// @property (nonatomic, strong) TMBValue * _Nullable fontScaleValue;
		[NullAllowed, Export ("fontScaleValue", ArgumentSemantic.Strong)]
		TMBValue FontScaleValue { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable fontScale;
		[NullAllowed, Export ("fontScale", ArgumentSemantic.Strong)]
		NSNumber FontScale { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textFontValue;
		[NullAllowed, Export ("textFontValue", ArgumentSemantic.Strong)]
		TMBValue TextFontValue { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable textFont;
		[NullAllowed, Export ("textFont", ArgumentSemantic.Copy)]
		string[] TextFont { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textColorValue;
		[NullAllowed, Export ("textColorValue", ArgumentSemantic.Strong)]
		TMBValue TextColorValue { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }
	}

	// @interface TMBGestureManager : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC17TMBGestureManager")]
	[DisableDefaultCtor]
	interface TMBGestureManager
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		ITMBGestureManagerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TMBGestureManagerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(TMBGestureOptions * _Nonnull)gestureOptions __attribute__((warn_unused_result("")));
		[Export ("gestureOptions")]
		TMBGestureOptions GestureOptions();

		// @property (readonly, nonatomic, strong) UIGestureRecognizer * _Nonnull panGestureRecognizer;
		[Export ("panGestureRecognizer", ArgumentSemantic.Strong)]
		UIGestureRecognizer PanGestureRecognizer { get; }

		// @property (readonly, nonatomic, strong) UIGestureRecognizer * _Nonnull pinchGestureRecognizer;
		[Export ("pinchGestureRecognizer", ArgumentSemantic.Strong)]
		UIGestureRecognizer PinchGestureRecognizer { get; }

		// @property (readonly, nonatomic, strong) UIGestureRecognizer * _Nonnull rotateGestureRecognizer;
		[Export ("rotateGestureRecognizer", ArgumentSemantic.Strong)]
		UIGestureRecognizer RotateGestureRecognizer { get; }

		// @property (readonly, nonatomic, strong) UIGestureRecognizer * _Nonnull pitchGestureRecognizer;
		[Export ("pitchGestureRecognizer", ArgumentSemantic.Strong)]
		UIGestureRecognizer PitchGestureRecognizer { get; }

		// @property (readonly, nonatomic, strong) UIGestureRecognizer * _Nonnull doubleTapToZoomInGestureRecognizer;
		[Export ("doubleTapToZoomInGestureRecognizer", ArgumentSemantic.Strong)]
		UIGestureRecognizer DoubleTapToZoomInGestureRecognizer { get; }

		// @property (readonly, nonatomic, strong) UIGestureRecognizer * _Nonnull doubleTouchToZoomOutGestureRecognizer;
		[Export ("doubleTouchToZoomOutGestureRecognizer", ArgumentSemantic.Strong)]
		UIGestureRecognizer DoubleTouchToZoomOutGestureRecognizer { get; }

		// @property (readonly, nonatomic, strong) UIGestureRecognizer * _Nonnull quickZoomGestureRecognizer;
		[Export ("quickZoomGestureRecognizer", ArgumentSemantic.Strong)]
		UIGestureRecognizer QuickZoomGestureRecognizer { get; }

		// @property (readonly, nonatomic, strong) UIGestureRecognizer * _Nonnull singleTapGestureRecognizer;
		[Export ("singleTapGestureRecognizer", ArgumentSemantic.Strong)]
		UIGestureRecognizer SingleTapGestureRecognizer { get; }
	}

	partial interface ITMBGestureManagerDelegate { }

	// @protocol TMBGestureManagerDelegate
	[Protocol (Name = "_TtP13MapboxMapObjC25TMBGestureManagerDelegate_"), Model]
	[BaseType (typeof (NSObject))]
	interface TMBGestureManagerDelegate
	{
		// @required -(void)gestureManagerWithDidBegin:(enum TMBGestureType)gestureType;
		[Abstract]
		[Export ("gestureManagerWithDidBegin:")]
		void GestureManagerWithDidBegin (TMBGestureType gestureType);

		// @required -(void)gestureManagerWithDidEnd:(enum TMBGestureType)gestureType willAnimate:(BOOL)willAnimate;
		[Abstract]
		[Export ("gestureManagerWithDidEnd:willAnimate:")]
		void GestureManagerWithDidEnd (TMBGestureType gestureType, bool willAnimate);

		// @required -(void)gestureManagerWithDidEndAnimatingFor:(enum TMBGestureType)gestureType;
		[Abstract]
		[Export ("gestureManagerWithDidEndAnimatingFor:")]
		void GestureManagerWithDidEndAnimatingFor (TMBGestureType gestureType);
	}

	// @interface TMBGestureOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC17TMBGestureOptions")]
	[DisableDefaultCtor]
	interface TMBGestureOptions
	{
		// @property (nonatomic) BOOL panEnabled;
		[Export ("panEnabled")]
		bool PanEnabled { get; set; }

		// @property (nonatomic) BOOL pinchEnabled;
		[Export ("pinchEnabled")]
		bool PinchEnabled { get; set; }

		// @property (nonatomic) BOOL rotateEnabled;
		[Export ("rotateEnabled")]
		bool RotateEnabled { get; set; }

		// @property (nonatomic) BOOL simultaneousRotateAndPinchZoomEnabled;
		[Export ("simultaneousRotateAndPinchZoomEnabled")]
		bool SimultaneousRotateAndPinchZoomEnabled { get; set; }

		// @property (nonatomic) BOOL pinchZoomEnabled;
		[Export ("pinchZoomEnabled")]
		bool PinchZoomEnabled { get; set; }

		// @property (nonatomic) BOOL pinchPanEnabled;
		[Export ("pinchPanEnabled")]
		bool PinchPanEnabled { get; set; }

		// @property (nonatomic) BOOL pitchEnabled;
		[Export ("pitchEnabled")]
		bool PitchEnabled { get; set; }

		// @property (nonatomic) BOOL doubleTapToZoomInEnabled;
		[Export ("doubleTapToZoomInEnabled")]
		bool DoubleTapToZoomInEnabled { get; set; }

		// @property (nonatomic) BOOL doubleTouchToZoomOutEnabled;
		[Export ("doubleTouchToZoomOutEnabled")]
		bool DoubleTouchToZoomOutEnabled { get; set; }

		// @property (nonatomic) BOOL quickZoomEnabled;
		[Export ("quickZoomEnabled")]
		bool QuickZoomEnabled { get; set; }

		// @property (nonatomic) enum TMBPanMode panMode;
		[Export ("panMode", ArgumentSemantic.Assign)]
		TMBPanMode PanMode { get; set; }

		// @property (nonatomic) CGFloat panDecelerationFactor;
		[Export ("panDecelerationFactor")]
		nfloat PanDecelerationFactor { get; set; }

		// @property (nonatomic, strong) NSValue * _Nullable focalPoint;
		[NullAllowed, Export ("focalPoint", ArgumentSemantic.Strong)]
		NSValue FocalPoint { get; set; }
	}

	// @interface TMBHillshadeIlluminationAnchor : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC30TMBHillshadeIlluminationAnchor")]
	[DisableDefaultCtor]
	interface TMBHillshadeIlluminationAnchor : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBHillshadeIlluminationAnchor * _Nonnull map;
		[Static]
		[Export ("map", ArgumentSemantic.Strong)]
		TMBHillshadeIlluminationAnchor Map { get; }

		// @property (readonly, nonatomic, strong, class) TMBHillshadeIlluminationAnchor * _Nonnull viewport;
		[Static]
		[Export ("viewport", ArgumentSemantic.Strong)]
		TMBHillshadeIlluminationAnchor Viewport { get; }
	}

	// @interface TMBIconAnchor : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13TMBIconAnchor")]
	[DisableDefaultCtor]
	interface TMBIconAnchor : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconAnchor * _Nonnull center;
		[Static]
		[Export ("center", ArgumentSemantic.Strong)]
		TMBIconAnchor Center { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconAnchor * _Nonnull left;
		[Static]
		[Export ("left", ArgumentSemantic.Strong)]
		TMBIconAnchor Left { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconAnchor * _Nonnull right;
		[Static]
		[Export ("right", ArgumentSemantic.Strong)]
		TMBIconAnchor Right { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconAnchor * _Nonnull top;
		[Static]
		[Export ("top", ArgumentSemantic.Strong)]
		TMBIconAnchor Top { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconAnchor * _Nonnull bottom;
		[Static]
		[Export ("bottom", ArgumentSemantic.Strong)]
		TMBIconAnchor Bottom { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconAnchor * _Nonnull topLeft;
		[Static]
		[Export ("topLeft", ArgumentSemantic.Strong)]
		TMBIconAnchor TopLeft { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconAnchor * _Nonnull topRight;
		[Static]
		[Export ("topRight", ArgumentSemantic.Strong)]
		TMBIconAnchor TopRight { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconAnchor * _Nonnull bottomLeft;
		[Static]
		[Export ("bottomLeft", ArgumentSemantic.Strong)]
		TMBIconAnchor BottomLeft { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconAnchor * _Nonnull bottomRight;
		[Static]
		[Export ("bottomRight", ArgumentSemantic.Strong)]
		TMBIconAnchor BottomRight { get; }
	}

	// @interface TMBIconPitchAlignment : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC21TMBIconPitchAlignment")]
	[DisableDefaultCtor]
	interface TMBIconPitchAlignment : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconPitchAlignment * _Nonnull map;
		[Static]
		[Export ("map", ArgumentSemantic.Strong)]
		TMBIconPitchAlignment Map { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconPitchAlignment * _Nonnull viewport;
		[Static]
		[Export ("viewport", ArgumentSemantic.Strong)]
		TMBIconPitchAlignment Viewport { get; }

		// @property (readonly, getter = auto, nonatomic, strong, class) TMBIconPitchAlignment * _Nonnull auto_;
		[Static]
		[Export ("auto_", ArgumentSemantic.Strong)]
		TMBIconPitchAlignment Auto { [Bind ("auto")] get; }
	}

	// @interface TMBIconRotationAlignment : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC24TMBIconRotationAlignment")]
	[DisableDefaultCtor]
	interface TMBIconRotationAlignment : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconRotationAlignment * _Nonnull map;
		[Static]
		[Export ("map", ArgumentSemantic.Strong)]
		TMBIconRotationAlignment Map { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconRotationAlignment * _Nonnull viewport;
		[Static]
		[Export ("viewport", ArgumentSemantic.Strong)]
		TMBIconRotationAlignment Viewport { get; }

		// @property (readonly, getter = auto, nonatomic, strong, class) TMBIconRotationAlignment * _Nonnull auto_;
		[Static]
		[Export ("auto_", ArgumentSemantic.Strong)]
		TMBIconRotationAlignment Auto { [Bind ("auto")] get; }
	}

	// @interface TMBIconTextFit : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC14TMBIconTextFit")]
	[DisableDefaultCtor]
	interface TMBIconTextFit : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconTextFit * _Nonnull none;
		[Static]
		[Export ("none", ArgumentSemantic.Strong)]
		TMBIconTextFit None { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconTextFit * _Nonnull width;
		[Static]
		[Export ("width", ArgumentSemantic.Strong)]
		TMBIconTextFit Width { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconTextFit * _Nonnull height;
		[Static]
		[Export ("height", ArgumentSemantic.Strong)]
		TMBIconTextFit Height { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconTextFit * _Nonnull both;
		[Static]
		[Export ("both", ArgumentSemantic.Strong)]
		TMBIconTextFit Both { get; }
	}

	// @interface TMBIconTranslateAnchor : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC22TMBIconTranslateAnchor")]
	[DisableDefaultCtor]
	interface TMBIconTranslateAnchor : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconTranslateAnchor * _Nonnull map;
		[Static]
		[Export ("map", ArgumentSemantic.Strong)]
		TMBIconTranslateAnchor Map { get; }

		// @property (readonly, nonatomic, strong, class) TMBIconTranslateAnchor * _Nonnull viewport;
		[Static]
		[Export ("viewport", ArgumentSemantic.Strong)]
		TMBIconTranslateAnchor Viewport { get; }
	}

	// @interface TMBImmediateViewportTransition : NSObject <TMBViewportTransition>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC30TMBImmediateViewportTransition")]
	[DisableDefaultCtor]
	interface TMBImmediateViewportTransition : ITMBViewportTransition
	{
		// -(TMBCancelable * _Nonnull)runTo:(id<TMBViewportState> _Nonnull)toState completion:(void (^ _Nonnull)(BOOL))completion __attribute__((warn_unused_result("")));
		[Export ("runTo:completion:")]
		TMBCancelable RunTo (TMBViewportState toState, Action<bool> completion);
	}

	// @interface TMBLayer : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC8TMBLayer")]
	[DisableDefaultCtor]
	interface TMBLayer
	{
	}

	// @interface TMBLayerInfo : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC12TMBLayerInfo")]
	[DisableDefaultCtor]
	interface TMBLayerInfo
	{
	}

	// @interface TMBLayerPosition : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC16TMBLayerPosition")]
	[DisableDefaultCtor]
	interface TMBLayerPosition
	{
		// @property (readonly, nonatomic, strong) id _Nonnull arg;
		[Export ("arg", ArgumentSemantic.Strong)]
		NSObject Arg { get; }

		// @property (readonly, nonatomic) enum TMBLayerPositionType type;
		[Export ("type")]
		TMBLayerPositionType Type { get; }

		// -(instancetype _Nonnull)init:(enum TMBLayerPositionType)type arg:(id _Nonnull)arg __attribute__((objc_designated_initializer));
		[Export ("init:arg:")]
		[DesignatedInitializer]
		IntPtr Constructor (TMBLayerPositionType type, NSObject arg);
	}

	// @interface TMBLight : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC8TMBLight")]
	interface TMBLight
	{
		// @property (nonatomic, strong) TMBAnchor * _Nullable anchor;
		[NullAllowed, Export ("anchor", ArgumentSemantic.Strong)]
		TMBAnchor Anchor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable color;
		[NullAllowed, Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable colorTransition;
		[NullAllowed, Export ("colorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition ColorTransition { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable intensity;
		[NullAllowed, Export ("intensity", ArgumentSemantic.Strong)]
		NSNumber Intensity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable intensityTransition;
		[NullAllowed, Export ("intensityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition IntensityTransition { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable position;
		[NullAllowed, Export ("position", ArgumentSemantic.Copy)]
		NSNumber[] Position { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable positionTransition;
		[NullAllowed, Export ("positionTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition PositionTransition { get; set; }
	}

	// @interface TMBLineCap : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC10TMBLineCap")]
	[DisableDefaultCtor]
	interface TMBLineCap : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBLineCap * _Nonnull butt;
		[Static]
		[Export ("butt", ArgumentSemantic.Strong)]
		TMBLineCap Butt { get; }

		// @property (readonly, nonatomic, strong, class) TMBLineCap * _Nonnull round;
		[Static]
		[Export ("round", ArgumentSemantic.Strong)]
		TMBLineCap Round { get; }

		// @property (readonly, nonatomic, strong, class) TMBLineCap * _Nonnull square;
		[Static]
		[Export ("square", ArgumentSemantic.Strong)]
		TMBLineCap Square { get; }
	}

	// @interface TMBLineJoin : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC11TMBLineJoin")]
	[DisableDefaultCtor]
	interface TMBLineJoin : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBLineJoin * _Nonnull bevel;
		[Static]
		[Export ("bevel", ArgumentSemantic.Strong)]
		TMBLineJoin Bevel { get; }

		// @property (readonly, nonatomic, strong, class) TMBLineJoin * _Nonnull round;
		[Static]
		[Export ("round", ArgumentSemantic.Strong)]
		TMBLineJoin Round { get; }

		// @property (readonly, nonatomic, strong, class) TMBLineJoin * _Nonnull miter;
		[Static]
		[Export ("miter", ArgumentSemantic.Strong)]
		TMBLineJoin Miter { get; }
	}

	// @interface TMBLineTranslateAnchor : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC22TMBLineTranslateAnchor")]
	[DisableDefaultCtor]
	interface TMBLineTranslateAnchor : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBFillTranslateAnchor * _Nonnull map;
		[Static]
		[Export ("map", ArgumentSemantic.Strong)]
		TMBFillTranslateAnchor Map { get; }

		// @property (readonly, nonatomic, strong, class) TMBFillTranslateAnchor * _Nonnull viewport;
		[Static]
		[Export ("viewport", ArgumentSemantic.Strong)]
		TMBFillTranslateAnchor Viewport { get; }
	}

	// @interface TMBLocationManager : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBLocationManager")]
	[DisableDefaultCtor]
	interface TMBLocationManager
	{
		// @property (readonly, nonatomic, strong) Location * _Nullable latestLocation;
		[NullAllowed, Export ("latestLocation", ArgumentSemantic.Strong)]
		Location LatestLocation { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		TMBLocationPermissionsDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TMBLocationPermissionsDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong) id<TMBLocationProvider> _Null_unspecified locationProvider;
		[Export ("locationProvider", ArgumentSemantic.Strong)]
		TMBLocationProvider LocationProvider { get; }

		// @property (readonly, nonatomic, strong) NSHashTable<id<LocationConsumer>> * _Nonnull consumers;
		[Export ("consumers", ArgumentSemantic.Strong)]
		NSHashTable<LocationConsumer> Consumers { get; }

		// @property (nonatomic, strong) TMBLocationOptions * _Nonnull options;
		[Export ("options", ArgumentSemantic.Strong)]
		TMBLocationOptions Options { get; set; }

		// -(void)overrideLocationProviderWith:(id<TMBLocationProvider> _Nonnull)customLocationProvider;
		[Export ("overrideLocationProviderWith:")]
		void OverrideLocationProviderWith (TMBLocationProvider customLocationProvider);

		// -(void)addLocationConsumer:(id<LocationConsumer> _Nonnull)consumer;
		[Export ("addLocationConsumer:")]
		void AddLocationConsumer (LocationConsumer consumer);

		// -(void)removeLocationConsumer:(id<LocationConsumer> _Nonnull)consumer;
		[Export ("removeLocationConsumer:")]
		void RemoveLocationConsumer (LocationConsumer consumer);

		// -(void)addPuckLocationConsumer:(id<PuckLocationConsumer> _Nonnull)consumer;
		[Export ("addPuckLocationConsumer:")]
		void AddPuckLocationConsumer (PuckLocationConsumer consumer);

		// -(void)removePuckLocationConsumer:(id<PuckLocationConsumer> _Nonnull)consumer;
		[Export ("removePuckLocationConsumer:")]
		void RemovePuckLocationConsumer (PuckLocationConsumer consumer);

		// -(void)requestTemporaryFullAccuracyPermissionsWithPurposeKey:(NSString * _Nonnull)purposeKey __attribute__((availability(ios, introduced=14.0)));
		[iOS (14,0)]
		[Export ("requestTemporaryFullAccuracyPermissionsWithPurposeKey:")]
		void RequestTemporaryFullAccuracyPermissionsWithPurposeKey (string purposeKey);
	}

	// @interface MapboxMapObjC_Swift_1824 (TMBLocationManager)
	[Category]
	[BaseType (typeof(TMBLocationManager))]
	interface TMBLocationManager_MapboxMapObjC_Swift_1824
	{
		// -(BOOL)locationManagerShouldDisplayHeadingCalibration:(LocationManager * _Nonnull)locationManager __attribute__((warn_unused_result("")));
		[Export ("locationManagerShouldDisplayHeadingCalibration:")]
		bool LocationManagerShouldDisplayHeadingCalibration (LocationManager locationManager);

		// -(void)locationManager:(LocationManager * _Nonnull)locationManager didChangeAccuracyAuthorization:(CLAccuracyAuthorization)accuracyAuthorization;
		[Export ("locationManager:didChangeAccuracyAuthorization:")]
		void LocationManager (LocationManager locationManager, CLAccuracyAuthorization accuracyAuthorization);

		// -(void)locationManager:(LocationManager * _Nonnull)locationManager didFailToLocateUserWithError:(NSError * _Nonnull)error;
		[Export ("locationManager:didFailToLocateUserWithError:")]
		void LocationManager (LocationManager locationManager, NSError error);
	}

	// @interface TMBLocationOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBLocationOptions")]
	[DisableDefaultCtor]
	interface TMBLocationOptions
	{
		// @property (nonatomic) CLLocationDistance distanceFilter;
		[Export ("distanceFilter")]
		double DistanceFilter { get; set; }

		// @property (nonatomic) CLLocationAccuracy desiredAccuracy;
		[Export ("desiredAccuracy")]
		double DesiredAccuracy { get; set; }

		// @property (nonatomic) CLActivityType activityType;
		[Export ("activityType", ArgumentSemantic.Assign)]
		CLActivityType ActivityType { get; set; }

		// @property (readonly, nonatomic) enum TMBPuckType puckType;
		[Export ("puckType")]
		TMBPuckType PuckType { get; }

		// @property (nonatomic, strong) TMBPuck2DConfiguration * _Nullable puck2DConfiguration;
		[NullAllowed, Export ("puck2DConfiguration", ArgumentSemantic.Strong)]
		TMBPuck2DConfiguration Puck2DConfiguration { get; set; }

		// @property (nonatomic, strong) TMBPuck3DConfiguration * _Nullable puck3DConfiguration;
		[NullAllowed, Export ("puck3DConfiguration", ArgumentSemantic.Strong)]
		TMBPuck3DConfiguration Puck3DConfiguration { get; set; }

		// @property (nonatomic) enum TMBPuckBearingSource puckBearingSource;
		[Export ("puckBearingSource", ArgumentSemantic.Assign)]
		TMBPuckBearingSource PuckBearingSource { get; set; }

		// @property (nonatomic) BOOL puckBearingEnabled;
		[Export ("puckBearingEnabled")]
		bool PuckBearingEnabled { get; set; }

		// -(instancetype _Nonnull)initWithDistanceFilter:(CLLocationDistance)distanceFilter desiredAccuracy:(CLLocationAccuracy)desiredAccuracy activityType:(CLActivityType)activityType puck2DConfiguration:(TMBPuck2DConfiguration * _Nullable)puck2DConfiguration puck3DConfiguration:(TMBPuck3DConfiguration * _Nullable)puck3DConfiguration puckBearingSource:(enum TMBPuckBearingSource)puckBearingSource puckBearingEnabled:(BOOL)puckBearingEnabled __attribute__((objc_designated_initializer));
		[Export ("initWithDistanceFilter:desiredAccuracy:activityType:puck2DConfiguration:puck3DConfiguration:puckBearingSource:puckBearingEnabled:")]
		[DesignatedInitializer]
		IntPtr Constructor (double distanceFilter, double desiredAccuracy, CLActivityType activityType, [NullAllowed] TMBPuck2DConfiguration puck2DConfiguration, [NullAllowed] TMBPuck3DConfiguration puck3DConfiguration, TMBPuckBearingSource puckBearingSource, bool puckBearingEnabled);
	}

	// @protocol TMBLocationPermissionsDelegate
	[Protocol (Name = "_TtP13MapboxMapObjC30TMBLocationPermissionsDelegate_"), Model (AutoGeneratedName = true)]
	interface TMBLocationPermissionsDelegate
	{
		// @optional -(void)locationManager:(TMBLocationManager * _Nonnull)locationManager didFailToLocateUserWithError:(NSError * _Nonnull)error;
		[Export ("locationManager:didFailToLocateUserWithError:")]
		void LocationManager (TMBLocationManager locationManager, NSError error);

		// @optional -(void)locationManager:(TMBLocationManager * _Nonnull)locationManager didChangeAccuracyAuthorization:(CLAccuracyAuthorization)accuracyAuthorization;
		[Export ("locationManager:didChangeAccuracyAuthorization:")]
		void LocationManager (TMBLocationManager locationManager, CLAccuracyAuthorization accuracyAuthorization);

		// @optional -(BOOL)locationManagerShouldDisplayHeadingCalibration:(TMBLocationManager * _Nonnull)locationManager __attribute__((warn_unused_result("")));
		[Export ("locationManagerShouldDisplayHeadingCalibration:")]
		bool LocationManagerShouldDisplayHeadingCalibration (TMBLocationManager locationManager);
	}

	// @protocol TMBLocationProvider
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	partial interface ITMBLocationProvider {}

	[Protocol (Name = "_TtP13MapboxMapObjC19TMBLocationProvider_"), Model]
	[BaseType(typeof(NSObject))]
	interface TMBLocationProvider
	{
		// @required @property (nonatomic, strong) TMBLocationOptions * _Nonnull locationProviderOptions;
		[Abstract]
		[Export ("locationProviderOptions", ArgumentSemantic.Strong)]
		TMBLocationOptions LocationProviderOptions { get; set; }

		// @required @property (readonly, nonatomic) CLAuthorizationStatus authorizationStatus;
		[Abstract]
		[Export ("authorizationStatus")]
		CLAuthorizationStatus AuthorizationStatus { get; }

		// @required @property (readonly, nonatomic) CLAccuracyAuthorization accuracyAuthorization;
		[Abstract]
		[Export ("accuracyAuthorization")]
		CLAccuracyAuthorization AccuracyAuthorization { get; }

		// @required @property (readonly, nonatomic, strong) CLHeading * _Nullable heading;
		[Abstract]
		[NullAllowed, Export ("heading", ArgumentSemantic.Strong)]
		CLHeading Heading { get; }

		// @required -(void)setDelegate:(id<TMBLocationProviderDelegate> _Nonnull)delegate;
		[Abstract]
		[Export ("setDelegate:")]
		void SetDelegate (ITMBLocationProviderDelegate @delegate);

		// @required -(void)requestAlwaysAuthorization;
		[Abstract]
		[Export ("requestAlwaysAuthorization")]
		void RequestAlwaysAuthorization ();

		// @required -(void)requestWhenInUseAuthorization;
		[Abstract]
		[Export ("requestWhenInUseAuthorization")]
		void RequestWhenInUseAuthorization ();

		// @required -(void)requestTemporaryFullAccuracyAuthorizationWithPurposeKey:(NSString * _Nonnull)purposeKey __attribute__((availability(ios, introduced=14.0)));
		[iOS (14,0)]
		[Abstract]
		[Export ("requestTemporaryFullAccuracyAuthorizationWithPurposeKey:")]
		void RequestTemporaryFullAccuracyAuthorizationWithPurposeKey (string purposeKey);

		// @required -(void)startUpdatingLocation;
		[Abstract]
		[Export ("startUpdatingLocation")]
		void StartUpdatingLocation ();

		// @required -(void)stopUpdatingLocation;
		[Abstract]
		[Export ("stopUpdatingLocation")]
		void StopUpdatingLocation ();

		// @required @property (nonatomic) CLDeviceOrientation headingOrientation;
		[Abstract]
		[Export ("headingOrientation", ArgumentSemantic.Assign)]
		CLDeviceOrientation HeadingOrientation { get; set; }

		// @required -(void)startUpdatingHeading;
		[Abstract]
		[Export ("startUpdatingHeading")]
		void StartUpdatingHeading ();

		// @required -(void)stopUpdatingHeading;
		[Abstract]
		[Export ("stopUpdatingHeading")]
		void StopUpdatingHeading ();

		// @required -(void)dismissHeadingCalibrationDisplay;
		[Abstract]
		[Export ("dismissHeadingCalibrationDisplay")]
		void DismissHeadingCalibrationDisplay ();
	}

	partial interface ITMBLocationProviderDelegate {}

	// @protocol TMBLocationProviderDelegate
	[Protocol (Name = "_TtP13MapboxMapObjC27TMBLocationProviderDelegate_"), Model]
	[BaseType(typeof(NSObject))]
	interface TMBLocationProviderDelegate
	{
		// @required -(void)locationProvider:(id<TMBLocationProvider> _Nonnull)provider didUpdateLocations:(NSArray<CLLocation *> * _Nonnull)locations;
		[Abstract]
		[Export ("locationProvider:didUpdateLocations:")]
		void LocationProvider (ITMBLocationProvider provider, CLLocation[] locations);

		// @required -(void)locationProvider:(id<TMBLocationProvider> _Nonnull)provider didUpdateHeading:(CLHeading * _Nonnull)newHeading;
		[Abstract]
		[Export ("locationProvider:didUpdateHeading:")]
		void LocationProvider (ITMBLocationProvider provider, CLHeading newHeading);

		// @required -(void)locationProvider:(id<TMBLocationProvider> _Nonnull)provider didFailWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("locationProvider:didFailWithError:")]
		void LocationProvider (ITMBLocationProvider provider, NSError error);

		// @required -(void)locationProviderDidChangeAuthorization:(id<TMBLocationProvider> _Nonnull)provider;
		[Abstract]
		[Export ("locationProviderDidChangeAuthorization:")]
		void LocationProviderDidChangeAuthorization (ITMBLocationProvider provider);
	}

	// @interface TMBLogoViewOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBLogoViewOptions")]
	[DisableDefaultCtor]
	interface TMBLogoViewOptions
	{
		// @property (nonatomic) enum TMBOrnamentPosition position;
		[Export ("position", ArgumentSemantic.Assign)]
		TMBOrnamentPosition Position { get; set; }

		// @property (nonatomic) CGPoint margins;
		[Export ("margins", ArgumentSemantic.Assign)]
		CGPoint Margins { get; set; }
	}

	// @interface TMBMapboxMap : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC12TMBMapboxMap")]
	[DisableDefaultCtor]
	interface TMBMapboxMap
	{
		// @property (readonly, nonatomic, strong) TMBStyle * _Nonnull style;
		[Export ("style", ArgumentSemantic.Strong)]
		TMBStyle Style { get; }

		// -(void)triggerRepaint;
		[Export ("triggerRepaint")]
		void TriggerRepaint ();

		// -(void)loadStyleURI:(NSString * _Nonnull)styleUri completion:(void (^ _Nullable)(TMBStyle * _Nullable, NSError * _Nullable))completion;
		[Export ("loadStyleURI:completion:")]
		void LoadStyleURI (string styleUri, [NullAllowed] Action<TMBStyle, NSError> completion);

		// -(void)loadStyleJSON:(NSString * _Nonnull)JSON completion:(void (^ _Nullable)(TMBStyle * _Nullable, NSError * _Nullable))completion;
		[Export ("loadStyleJSON:completion:")]
		void LoadStyleJSON (string JSON, [NullAllowed] Action<TMBStyle, NSError> completion);

		// @property (nonatomic) uint8_t prefetchZoomDelta;
		[Export ("prefetchZoomDelta")]
		byte PrefetchZoomDelta { get; set; }

		// @property (nonatomic) BOOL shouldRenderWorldCopies;
		[Export ("shouldRenderWorldCopies")]
		bool ShouldRenderWorldCopies { get; set; }

		// @property (readonly, nonatomic, strong) MBMResourceOptions * _Nonnull resourceOptions;
		[Export ("resourceOptions", ArgumentSemantic.Strong)]
		MBMResourceOptions ResourceOptions { get; }

		// +(void)clearDataFor:(MBMResourceOptions * _Nonnull)resourceOptions completion:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Static]
		[Export ("clearDataFor:completion:")]
		void ClearDataFor (MBMResourceOptions resourceOptions, Action<NSError> completion);

		// -(NSNumber * _Nullable)elevationAt:(CLLocationCoordinate2D)coordinate __attribute__((warn_unused_result("")));
		[Export ("elevationAt:")]
		[return: NullAllowed]
		NSNumber ElevationAt (CLLocationCoordinate2D coordinate);

		// -(MBMCoordinateBounds * _Nonnull)coordinateBoundsFor:(CGRect)rect __attribute__((warn_unused_result("")));
		[Export ("coordinateBoundsFor:")]
		MBMCoordinateBounds CoordinateBoundsFor (CGRect rect);

		// -(CGRect)rectFor:(MBMCoordinateBounds * _Nonnull)coordinateBounds __attribute__((warn_unused_result("")));
		[Export ("rectFor:")]
		CGRect RectFor (MBMCoordinateBounds coordinateBounds);

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull debugOptions;
		[Export ("debugOptions", ArgumentSemantic.Copy)]
		NSNumber[] DebugOptions { get; set; }

		// @property (readonly, nonatomic, strong) MBMMapOptions * _Nonnull options;
		[Export ("options", ArgumentSemantic.Strong)]
		MBMMapOptions Options { get; }

		// -(MBMCameraOptions * _Nonnull)cameraForCoordinateBounds:(MBMCoordinateBounds * _Nonnull)coordinateBounds padding:(UIEdgeInsets)padding bearing:(NSNumber * _Nullable)bearing pitch:(NSNumber * _Nullable)pitch __attribute__((warn_unused_result("")));
		[Export ("cameraForCoordinateBounds:padding:bearing:pitch:")]
		MBMCameraOptions CameraForCoordinateBounds (MBMCoordinateBounds coordinateBounds, UIEdgeInsets padding, [NullAllowed] NSNumber bearing, [NullAllowed] NSNumber pitch);

		// -(MBMCameraOptions * _Nonnull)cameraForCoordinates:(NSArray<NSValue *> * _Nonnull)coordinates padding:(UIEdgeInsets)padding bearing:(NSNumber * _Nullable)bearing pitch:(NSNumber * _Nullable)pitch __attribute__((warn_unused_result("")));
		[Export ("cameraForCoordinates:padding:bearing:pitch:")]
		MBMCameraOptions CameraForCoordinates (NSValue[] coordinates, UIEdgeInsets padding, [NullAllowed] NSNumber bearing, [NullAllowed] NSNumber pitch);

		// -(MBMCameraOptions * _Nonnull)cameraFor:(NSArray<NSValue *> * _Nonnull)coordinates camera:(MBMCameraOptions * _Nonnull)camera rect:(CGRect)rect __attribute__((warn_unused_result("")));
		[Export ("cameraFor:camera:rect:")]
		MBMCameraOptions CameraFor (NSValue[] coordinates, MBMCameraOptions camera, CGRect rect);

		// -(MBMCameraOptions * _Nonnull)cameraFor:(MBXGeometry * _Nonnull)geometry padding:(UIEdgeInsets)padding bearing:(NSNumber * _Nullable)bearing pitch:(NSNumber * _Nullable)pitch __attribute__((warn_unused_result("")));
		[Export ("cameraFor:padding:bearing:pitch:")]
		MBMCameraOptions CameraFor (MBXGeometry geometry, UIEdgeInsets padding, [NullAllowed] NSNumber bearing, [NullAllowed] NSNumber pitch);

		// -(MBMCoordinateBounds * _Nonnull)coordinateBoundsForCameraBounds:(MBMCameraOptions * _Nonnull)camera __attribute__((warn_unused_result("")));
		[Export ("coordinateBoundsForCameraBounds:")]
		MBMCoordinateBounds CoordinateBoundsForCameraBounds (MBMCameraOptions camera);

		// -(MBMCoordinateBounds * _Nonnull)coordinateBoundsUnwrappedFor:(MBMCameraOptions * _Nonnull)camera __attribute__((warn_unused_result("")));
		[Export ("coordinateBoundsUnwrappedFor:")]
		MBMCoordinateBounds CoordinateBoundsUnwrappedFor (MBMCameraOptions camera);

		// -(MBMCoordinateBoundsZoom * _Nonnull)coordinateBoundsZoomFor:(MBMCameraOptions * _Nonnull)camera __attribute__((warn_unused_result("")));
		[Export ("coordinateBoundsZoomFor:")]
		MBMCoordinateBoundsZoom CoordinateBoundsZoomFor (MBMCameraOptions camera);

		// -(MBMCoordinateBoundsZoom * _Nonnull)coordinateBoundsZoomUnwrappedFor:(MBMCameraOptions * _Nonnull)camera __attribute__((warn_unused_result("")));
		[Export ("coordinateBoundsZoomUnwrappedFor:")]
		MBMCoordinateBoundsZoom CoordinateBoundsZoomUnwrappedFor (MBMCameraOptions camera);

		// -(CLLocationCoordinate2D)coordinateFor:(CGPoint)point __attribute__((warn_unused_result("")));
		[Export ("coordinateFor:")]
		CLLocationCoordinate2D CoordinateFor (CGPoint point);

		// -(CGPoint)pointFor:(CLLocationCoordinate2D)coordinate __attribute__((warn_unused_result("")));
		[Export ("pointFor:")]
		CGPoint PointFor (CLLocationCoordinate2D coordinate);

		// -(NSArray<NSValue *> * _Nonnull)pointsFor:(NSArray<NSValue *> * _Nonnull)coordinates __attribute__((warn_unused_result("")));
		[Export ("pointsFor:")]
		NSValue[] PointsFor (NSValue[] coordinates);

		// -(NSArray<NSValue *> * _Nonnull)coordinatesFor:(NSArray<NSValue *> * _Nonnull)points __attribute__((warn_unused_result("")));
		[Export ("coordinatesFor:")]
		NSValue[] CoordinatesFor (NSValue[] points);

		// -(void)setCameraTo:(MBMCameraOptions * _Nonnull)cameraOptions;
		[Export ("setCameraTo:")]
		void SetCameraTo (MBMCameraOptions cameraOptions);

		// @property (readonly, nonatomic, strong) MBMCameraState * _Nonnull cameraState;
		[Export ("cameraState", ArgumentSemantic.Strong)]
		MBMCameraState CameraState { get; }

		// @property (nonatomic, strong) MBMFreeCameraOptions * _Nonnull freeCameraOptions;
		[Export ("freeCameraOptions", ArgumentSemantic.Strong)]
		MBMFreeCameraOptions FreeCameraOptions { get; set; }

		// @property (readonly, nonatomic, strong) MBMCameraBounds * _Nonnull cameraBounds;
		[Export ("cameraBounds", ArgumentSemantic.Strong)]
		MBMCameraBounds CameraBounds { get; }

		// -(void)setCameraBoundsWith:(MBMCameraBoundsOptions * _Nonnull)options completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setCameraBoundsWith:completion:")]
		void SetCameraBoundsWith (MBMCameraBoundsOptions options, [NullAllowed] Action<NSError> completion);

		// -(void)dragStartFor:(CGPoint)point;
		[Export ("dragStartFor:")]
		void DragStartFor (CGPoint point);

		// -(MBMCameraOptions * _Nonnull)dragCameraOptionsFrom:(CGPoint)from to:(CGPoint)to __attribute__((warn_unused_result("")));
		[Export ("dragCameraOptionsFrom:to:")]
		MBMCameraOptions DragCameraOptionsFrom (CGPoint from, CGPoint to);

		// -(void)dragEnd;
		[Export ("dragEnd")]
		void DragEnd ();

		// -(void)beginAnimation;
		[Export ("beginAnimation")]
		void BeginAnimation ();

		// -(void)endAnimation;
		[Export ("endAnimation")]
		void EndAnimation ();

		// -(void)beginGesture;
		[Export ("beginGesture")]
		void BeginGesture ();

		// -(void)endGesture;
		[Export ("endGesture")]
		void EndGesture ();
	}

	// @interface MapboxMapObjC_Swift_2307 (TMBMapboxMap)
	[Category]
	[BaseType (typeof(TMBMapboxMap))]
	interface TMBMapboxMap_MapboxMapObjC_Swift_2307
	{
		// -(void)clearDataWithCompletion:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Export ("clearDataWithCompletion:")]
		void ClearDataWithCompletion (Action<NSError> completion);
	}

	// @interface MapboxMapObjC_Swift_2322 (TMBMapboxMap)
	[Category]
	[BaseType (typeof(TMBMapboxMap))]
	interface TMBMapboxMap_MapboxMapObjC_Swift_2322
	{
		// -(void)subscribe:(id<MBMObserver> _Nonnull)observer events:(NSArray<NSString *> * _Nonnull)events;
		[Export ("subscribe:events:")]
		void Subscribe (MBMObserver observer, string[] events);

		// -(void)unsubscribe:(id<MBMObserver> _Nonnull)observer events:(NSArray<NSString *> * _Nonnull)events;
		[Export ("unsubscribe:events:")]
		void Unsubscribe (MBMObserver observer, string[] events);
	}

	// @interface MapboxMapObjC_Swift_2348 (TMBMapboxMap)
	[Category]
	[BaseType (typeof(TMBMapboxMap))]
	interface TMBMapboxMap_MapboxMapObjC_Swift_2348
	{
		// -(void)setFeatureStateWithSourceId:(NSString * _Nonnull)sourceId sourceLayerId:(NSString * _Nullable)sourceLayerId featureId:(NSString * _Nonnull)featureId state:(NSDictionary<NSString *,id> * _Nonnull)state;
		[Export ("setFeatureStateWithSourceId:sourceLayerId:featureId:state:")]
		void SetFeatureStateWithSourceId (string sourceId, [NullAllowed] string sourceLayerId, string featureId, NSDictionary<NSString, NSObject> state);

		// -(void)getFeatureStateWithSourceId:(NSString * _Nonnull)sourceId sourceLayerId:(NSString * _Nullable)sourceLayerId featureId:(NSString * _Nonnull)featureId callback:(void (^ _Nonnull)(NSDictionary<NSString *,id> * _Nullable, NSError * _Nullable))callback;
		[Export ("getFeatureStateWithSourceId:sourceLayerId:featureId:callback:")]
		void GetFeatureStateWithSourceId (string sourceId, [NullAllowed] string sourceLayerId, string featureId, Action<NSDictionary<NSString, NSObject>, NSError> callback);

		// -(void)removeFeatureStateWithSourceId:(NSString * _Nonnull)sourceId sourceLayerId:(NSString * _Nullable)sourceLayerId featureId:(NSString * _Nonnull)featureId stateKey:(NSString * _Nullable)stateKey;
		[Export ("removeFeatureStateWithSourceId:sourceLayerId:featureId:stateKey:")]
		void RemoveFeatureStateWithSourceId (string sourceId, [NullAllowed] string sourceLayerId, string featureId, [NullAllowed] string stateKey);
	}

	// @interface MapboxMapObjC_Swift_2390 (TMBMapboxMap)
	[Category]
	[BaseType (typeof(TMBMapboxMap))]
	interface TMBMapboxMap_MapboxMapObjC_Swift_2390
	{
		// -(TMBCancelable * _Nonnull)queryRenderedFeaturesWithShape:(NSArray<NSValue *> * _Nonnull)shape options:(MBMRenderedQueryOptions * _Nullable)options completion:(void (^ _Nullable)(NSArray<MBMQueriedFeature *> * _Nullable, NSError * _Nullable))completion;
		[Export ("queryRenderedFeaturesWithShape:options:completion:")]
		TMBCancelable QueryRenderedFeaturesWithShape (NSValue[] shape, [NullAllowed] MBMRenderedQueryOptions options, [NullAllowed] Action<NSArray<MBMQueriedFeature>, NSError> completion);

		// -(TMBCancelable * _Nonnull)queryRenderedFeaturesWithRect:(CGRect)rect options:(MBMRenderedQueryOptions * _Nullable)options completion:(void (^ _Nullable)(NSArray<MBMQueriedFeature *> * _Nullable, NSError * _Nullable))completion;
		[Export ("queryRenderedFeaturesWithRect:options:completion:")]
		TMBCancelable QueryRenderedFeaturesWithRect (CGRect rect, [NullAllowed] MBMRenderedQueryOptions options, [NullAllowed] Action<NSArray<MBMQueriedFeature>, NSError> completion);

		// -(TMBCancelable * _Nonnull)queryRenderedFeaturesWithPoint:(CGPoint)point options:(MBMRenderedQueryOptions * _Nullable)options completion:(void (^ _Nullable)(NSArray<MBMQueriedFeature *> * _Nullable, NSError * _Nullable))completion;
		[Export ("queryRenderedFeaturesWithPoint:options:completion:")]
		TMBCancelable QueryRenderedFeaturesWithPoint (CGPoint point, [NullAllowed] MBMRenderedQueryOptions options, [NullAllowed] Action<NSArray<MBMQueriedFeature>, NSError> completion);

		// -(void)querySourceFeaturesFor:(NSString * _Nonnull)sourceId options:(MBMSourceQueryOptions * _Nonnull)options completion:(void (^ _Nullable)(NSArray<MBMQueriedFeature *> * _Nullable, NSError * _Nullable))completion;
		[Export ("querySourceFeaturesFor:options:completion:")]
		void QuerySourceFeaturesFor (string sourceId, MBMSourceQueryOptions options, [NullAllowed] Action<NSArray<MBMQueriedFeature>, NSError> completion);

		// -(void)queryFeatureExtensionFor:(NSString * _Nonnull)sourceId feature:(MBXFeature * _Nonnull)feature extension:(NSString * _Nonnull)extension extensionField:(NSString * _Nonnull)extensionField args:(NSDictionary<NSString *,id> * _Nullable)args completion:(void (^ _Nullable)(MBMFeatureExtensionValue * _Nullable, NSError * _Nullable))completion;
		[Export ("queryFeatureExtensionFor:feature:extension:extensionField:args:completion:")]
		void QueryFeatureExtensionFor (string sourceId, MBXFeature feature, string extension, string extensionField, [NullAllowed] NSDictionary<NSString, NSObject> args, [NullAllowed] Action<MBMFeatureExtensionValue, NSError> completion);

		// -(void)getGeoJsonClusterLeavesForSourceId:(NSString * _Nonnull)sourceId feature:(MBXFeature * _Nonnull)feature limit:(uint64_t)limit offset:(uint64_t)offset completion:(void (^ _Nonnull)(MBMFeatureExtensionValue * _Nullable, NSError * _Nullable))completion;
		[Export ("getGeoJsonClusterLeavesForSourceId:feature:limit:offset:completion:")]
		void GetGeoJsonClusterLeavesForSourceId (string sourceId, MBXFeature feature, ulong limit, ulong offset, Action<MBMFeatureExtensionValue, NSError> completion);

		// -(void)getGeoJsonClusterChildrenForSourceId:(NSString * _Nonnull)sourceId feature:(MBXFeature * _Nonnull)feature completion:(void (^ _Nonnull)(MBMFeatureExtensionValue * _Nullable, NSError * _Nullable))completion;
		[Export ("getGeoJsonClusterChildrenForSourceId:feature:completion:")]
		void GetGeoJsonClusterChildrenForSourceId (string sourceId, MBXFeature feature, Action<MBMFeatureExtensionValue, NSError> completion);

		// -(void)getGeoJsonClusterExpansionZoomForSourceId:(NSString * _Nonnull)sourceId feature:(MBXFeature * _Nonnull)feature completion:(void (^ _Nonnull)(MBMFeatureExtensionValue * _Nullable, NSError * _Nullable))completion;
		[Export ("getGeoJsonClusterExpansionZoomForSourceId:feature:completion:")]
		void GetGeoJsonClusterExpansionZoomForSourceId (string sourceId, MBXFeature feature, Action<MBMFeatureExtensionValue, NSError> completion);
	}

	// @interface MapboxMapObjC_Swift_2483 (TMBMapboxMap)
	[Category]
	[BaseType (typeof(TMBMapboxMap))]
	interface TMBMapboxMap_MapboxMapObjC_Swift_2483
	{
		// -(TMBCancelable * _Nonnull)onMapLoaded:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onMapLoaded:")]
		TMBCancelable OnMapLoaded (Action<NSObject> handler);

		// -(TMBCancelable * _Nonnull)onMapLoadingError:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onMapLoadingError:")]
		TMBCancelable OnMapLoadingError (Action<NSObject> handler);

		// -(TMBCancelable * _Nonnull)onMapIdle:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onMapIdle:")]
		TMBCancelable OnMapIdle (Action<NSObject> handler);

		// -(TMBCancelable * _Nonnull)onStyleDataLoaded:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onStyleDataLoaded:")]
		TMBCancelable OnStyleDataLoaded (Action<NSObject> handler);

		// -(TMBCancelable * _Nonnull)onStyleLoaded:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onStyleLoaded:")]
		TMBCancelable OnStyleLoaded (Action<NSObject> handler);

		// -(TMBCancelable * _Nonnull)onStyleImageMissing:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onStyleImageMissing:")]
		TMBCancelable OnStyleImageMissing (Action<NSObject> handler);

		// -(TMBCancelable * _Nonnull)onStyleImageRemoveUnused:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onStyleImageRemoveUnused:")]
		TMBCancelable OnStyleImageRemoveUnused (Action<NSObject> handler);

		// -(TMBCancelable * _Nonnull)onSourceDataLoaded:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onSourceDataLoaded:")]
		TMBCancelable OnSourceDataLoaded (Action<NSObject> handler);

		// -(TMBCancelable * _Nonnull)onSourceAdded:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onSourceAdded:")]
		TMBCancelable OnSourceAdded (Action<NSObject> handler);

		// -(TMBCancelable * _Nonnull)onSourceRemoved:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onSourceRemoved:")]
		TMBCancelable OnSourceRemoved (Action<NSObject> handler);

		// -(TMBCancelable * _Nonnull)onRenderFrameStarted:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onRenderFrameStarted:")]
		TMBCancelable OnRenderFrameStarted (Action<NSObject> handler);

		// -(TMBCancelable * _Nonnull)onRenderFrameFinished:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onRenderFrameFinished:")]
		TMBCancelable OnRenderFrameFinished (Action<NSObject> handler);

		// -(TMBCancelable * _Nonnull)onEvenCameraChanged:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onEvenCameraChanged:")]
		TMBCancelable OnEvenCameraChanged (Action<NSObject> handler);

		// -(TMBCancelable * _Nonnull)onResourceRequest:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onResourceRequest:")]
		TMBCancelable OnResourceRequest (Action<NSObject> handler);
	}

	// @interface TMBModel : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC8TMBModel")]
	[DisableDefaultCtor]
	interface TMBModel
	{
		// @property (copy, nonatomic) NSURL * _Nullable uri;
		[NullAllowed, Export ("uri", ArgumentSemantic.Copy)]
		NSUrl Uri { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable position;
		[NullAllowed, Export ("position", ArgumentSemantic.Copy)]
		NSNumber[] Position { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable orientation;
		[NullAllowed, Export ("orientation", ArgumentSemantic.Copy)]
		NSNumber[] Orientation { get; set; }

		// -(instancetype _Nonnull)initWithUri:(NSURL * _Nullable)uri position:(NSArray<NSNumber *> * _Nullable)position orientation:(NSArray<NSNumber *> * _Nullable)orientation __attribute__((objc_designated_initializer));
		[Export ("initWithUri:position:orientation:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] NSUrl uri, [NullAllowed] NSNumber[] position, [NullAllowed] NSNumber[] orientation);
	}

	// @interface TMBNumberFormatOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC22TMBNumberFormatOptions")]
	[DisableDefaultCtor]
	interface TMBNumberFormatOptions
	{
	}

	// @interface TMBOperator : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC11TMBOperator")]
	[DisableDefaultCtor]
	interface TMBOperator : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull subtract;
		[Static]
		[Export ("subtract", ArgumentSemantic.Strong)]
		TMBOperator Subtract { get; }

		// @property (readonly, getter = not, nonatomic, strong, class) TMBOperator * _Nonnull not_;
		[Static]
		[Export ("not_", ArgumentSemantic.Strong)]
		TMBOperator Not_ { [Bind ("not")] get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull neq;
		[Static]
		[Export ("neq", ArgumentSemantic.Strong)]
		TMBOperator Neq { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull product;
		[Static]
		[Export ("product", ArgumentSemantic.Strong)]
		TMBOperator Product { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull division;
		[Static]
		[Export ("division", ArgumentSemantic.Strong)]
		TMBOperator Division { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull mod;
		[Static]
		[Export ("mod", ArgumentSemantic.Strong)]
		TMBOperator Mod { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull pow;
		[Static]
		[Export ("pow", ArgumentSemantic.Strong)]
		TMBOperator Pow { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull sum;
		[Static]
		[Export ("sum", ArgumentSemantic.Strong)]
		TMBOperator Sum { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull lt;
		[Static]
		[Export ("lt", ArgumentSemantic.Strong)]
		TMBOperator Lt { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull lte;
		[Static]
		[Export ("lte", ArgumentSemantic.Strong)]
		TMBOperator Lte { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull eq;
		[Static]
		[Export ("eq", ArgumentSemantic.Strong)]
		TMBOperator Eq { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull gt;
		[Static]
		[Export ("gt", ArgumentSemantic.Strong)]
		TMBOperator Gt { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull gte;
		[Static]
		[Export ("gte", ArgumentSemantic.Strong)]
		TMBOperator Gte { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull abs;
		[Static]
		[Export ("abs", ArgumentSemantic.Strong)]
		TMBOperator Abs { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull accumulated;
		[Static]
		[Export ("accumulated", ArgumentSemantic.Strong)]
		TMBOperator Accumulated { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull acos;
		[Static]
		[Export ("acos", ArgumentSemantic.Strong)]
		TMBOperator Acos { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull all;
		[Static]
		[Export ("all", ArgumentSemantic.Strong)]
		TMBOperator All { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull any;
		[Static]
		[Export ("any", ArgumentSemantic.Strong)]
		TMBOperator Any { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull array;
		[Static]
		[Export ("array", ArgumentSemantic.Strong)]
		TMBOperator Array { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull asin;
		[Static]
		[Export ("asin", ArgumentSemantic.Strong)]
		TMBOperator Asin { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull at;
		[Static]
		[Export ("at", ArgumentSemantic.Strong)]
		TMBOperator At { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull atan;
		[Static]
		[Export ("atan", ArgumentSemantic.Strong)]
		TMBOperator Atan { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull boolean;
		[Static]
		[Export ("boolean", ArgumentSemantic.Strong)]
		TMBOperator Boolean { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull switchCase;
		[Static]
		[Export ("switchCase", ArgumentSemantic.Strong)]
		TMBOperator SwitchCase { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull ceil;
		[Static]
		[Export ("ceil", ArgumentSemantic.Strong)]
		TMBOperator Ceil { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull coalesce;
		[Static]
		[Export ("coalesce", ArgumentSemantic.Strong)]
		TMBOperator Coalesce { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull collator;
		[Static]
		[Export ("collator", ArgumentSemantic.Strong)]
		TMBOperator Collator { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull concat;
		[Static]
		[Export ("concat", ArgumentSemantic.Strong)]
		TMBOperator Concat { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull cos;
		[Static]
		[Export ("cos", ArgumentSemantic.Strong)]
		TMBOperator Cos { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull distance;
		[Static]
		[Export ("distance", ArgumentSemantic.Strong)]
		TMBOperator Distance { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull distanceFromCenter;
		[Static]
		[Export ("distanceFromCenter", ArgumentSemantic.Strong)]
		TMBOperator DistanceFromCenter { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull downcase;
		[Static]
		[Export ("downcase", ArgumentSemantic.Strong)]
		TMBOperator Downcase { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull e;
		[Static]
		[Export ("e", ArgumentSemantic.Strong)]
		TMBOperator E { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull featureState;
		[Static]
		[Export ("featureState", ArgumentSemantic.Strong)]
		TMBOperator FeatureState { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull floor;
		[Static]
		[Export ("floor", ArgumentSemantic.Strong)]
		TMBOperator Floor { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull format;
		[Static]
		[Export ("format", ArgumentSemantic.Strong)]
		TMBOperator Format { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull geometryType;
		[Static]
		[Export ("geometryType", ArgumentSemantic.Strong)]
		TMBOperator GeometryType { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull get;
		[Static]
		[Export ("get", ArgumentSemantic.Strong)]
		TMBOperator Get { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull has;
		[Static]
		[Export ("has", ArgumentSemantic.Strong)]
		TMBOperator Has { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull heatmapDensity;
		[Static]
		[Export ("heatmapDensity", ArgumentSemantic.Strong)]
		TMBOperator HeatmapDensity { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull id;
		[Static]
		[Export ("id", ArgumentSemantic.Strong)]
		TMBOperator Id { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull image;
		[Static]
		[Export ("image", ArgumentSemantic.Strong)]
		TMBOperator Image { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull inExpression;
		[Static]
		[Export ("inExpression", ArgumentSemantic.Strong)]
		TMBOperator InExpression { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull indexOf;
		[Static]
		[Export ("indexOf", ArgumentSemantic.Strong)]
		TMBOperator IndexOf { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull interpolate;
		[Static]
		[Export ("interpolate", ArgumentSemantic.Strong)]
		TMBOperator Interpolate { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull isSupportedScript;
		[Static]
		[Export ("isSupportedScript", ArgumentSemantic.Strong)]
		TMBOperator IsSupportedScript { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull length;
		[Static]
		[Export ("length", ArgumentSemantic.Strong)]
		TMBOperator Length { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull letExpression;
		[Static]
		[Export ("letExpression", ArgumentSemantic.Strong)]
		TMBOperator LetExpression { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull lineProgress;
		[Static]
		[Export ("lineProgress", ArgumentSemantic.Strong)]
		TMBOperator LineProgress { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull literal;
		[Static]
		[Export ("literal", ArgumentSemantic.Strong)]
		TMBOperator Literal { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull ln;
		[Static]
		[Export ("ln", ArgumentSemantic.Strong)]
		TMBOperator Ln { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull ln2;
		[Static]
		[Export ("ln2", ArgumentSemantic.Strong)]
		TMBOperator Ln2 { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull log10;
		[Static]
		[Export ("log10", ArgumentSemantic.Strong)]
		TMBOperator Log10 { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull log2;
		[Static]
		[Export ("log2", ArgumentSemantic.Strong)]
		TMBOperator Log2 { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull match;
		[Static]
		[Export ("match", ArgumentSemantic.Strong)]
		TMBOperator Match { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull max;
		[Static]
		[Export ("max", ArgumentSemantic.Strong)]
		TMBOperator Max { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull min;
		[Static]
		[Export ("min", ArgumentSemantic.Strong)]
		TMBOperator Min { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull number;
		[Static]
		[Export ("number", ArgumentSemantic.Strong)]
		TMBOperator Number { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull numberFormat;
		[Static]
		[Export ("numberFormat", ArgumentSemantic.Strong)]
		TMBOperator NumberFormat { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull objectExpression;
		[Static]
		[Export ("objectExpression", ArgumentSemantic.Strong)]
		TMBOperator ObjectExpression { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull pi;
		[Static]
		[Export ("pi", ArgumentSemantic.Strong)]
		TMBOperator Pi { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull pitch;
		[Static]
		[Export ("pitch", ArgumentSemantic.Strong)]
		TMBOperator Pitch { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull properties;
		[Static]
		[Export ("properties", ArgumentSemantic.Strong)]
		TMBOperator Properties { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull resolvedLocale;
		[Static]
		[Export ("resolvedLocale", ArgumentSemantic.Strong)]
		TMBOperator ResolvedLocale { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull rgb;
		[Static]
		[Export ("rgb", ArgumentSemantic.Strong)]
		TMBOperator Rgb { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull rgba;
		[Static]
		[Export ("rgba", ArgumentSemantic.Strong)]
		TMBOperator Rgba { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull round;
		[Static]
		[Export ("round", ArgumentSemantic.Strong)]
		TMBOperator Round { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull sin;
		[Static]
		[Export ("sin", ArgumentSemantic.Strong)]
		TMBOperator Sin { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull skyRadialProgress;
		[Static]
		[Export ("skyRadialProgress", ArgumentSemantic.Strong)]
		TMBOperator SkyRadialProgress { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull slice;
		[Static]
		[Export ("slice", ArgumentSemantic.Strong)]
		TMBOperator Slice { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull sqrt;
		[Static]
		[Export ("sqrt", ArgumentSemantic.Strong)]
		TMBOperator Sqrt { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull step;
		[Static]
		[Export ("step", ArgumentSemantic.Strong)]
		TMBOperator Step { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull string;
		[Static]
		[Export ("string", ArgumentSemantic.Strong)]
		TMBOperator String { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull tan;
		[Static]
		[Export ("tan", ArgumentSemantic.Strong)]
		TMBOperator Tan { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull toBoolean;
		[Static]
		[Export ("toBoolean", ArgumentSemantic.Strong)]
		TMBOperator ToBoolean { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull toColor;
		[Static]
		[Export ("toColor", ArgumentSemantic.Strong)]
		TMBOperator ToColor { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull toNumber;
		[Static]
		[Export ("toNumber", ArgumentSemantic.Strong)]
		TMBOperator ToNumber { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull toRgba;
		[Static]
		[Export ("toRgba", ArgumentSemantic.Strong)]
		TMBOperator ToRgba { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull toString;
		[Static]
		[Export ("toString", ArgumentSemantic.Strong)]
		TMBOperator ToString { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull typeofExpression;
		[Static]
		[Export ("typeofExpression", ArgumentSemantic.Strong)]
		TMBOperator TypeofExpression { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull upcase;
		[Static]
		[Export ("upcase", ArgumentSemantic.Strong)]
		TMBOperator Upcase { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull varExpression;
		[Static]
		[Export ("varExpression", ArgumentSemantic.Strong)]
		TMBOperator VarExpression { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull within;
		[Static]
		[Export ("within", ArgumentSemantic.Strong)]
		TMBOperator Within { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull zoom;
		[Static]
		[Export ("zoom", ArgumentSemantic.Strong)]
		TMBOperator Zoom { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull linear;
		[Static]
		[Export ("linear", ArgumentSemantic.Strong)]
		TMBOperator Linear { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull exponential;
		[Static]
		[Export ("exponential", ArgumentSemantic.Strong)]
		TMBOperator Exponential { get; }

		// @property (readonly, nonatomic, strong, class) TMBOperator * _Nonnull cubicBezier;
		[Static]
		[Export ("cubicBezier", ArgumentSemantic.Strong)]
		TMBOperator CubicBezier { get; }
	}

	// @interface TMBOrnamentOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBOrnamentOptions")]
	[DisableDefaultCtor]
	interface TMBOrnamentOptions
	{
		// @property (nonatomic, strong) TMBScaleBarViewOptions * _Nonnull scaleBar;
		[Export ("scaleBar", ArgumentSemantic.Strong)]
		TMBScaleBarViewOptions ScaleBar { get; set; }

		// @property (nonatomic, strong) TMBCompassViewOptions * _Nonnull compass;
		[Export ("compass", ArgumentSemantic.Strong)]
		TMBCompassViewOptions Compass { get; set; }

		// @property (nonatomic, strong) TMBLogoViewOptions * _Nonnull logo;
		[Export ("logo", ArgumentSemantic.Strong)]
		TMBLogoViewOptions Logo { get; set; }

		// @property (nonatomic, strong) TMBAttributionButtonOptions * _Nonnull attributionButton;
		[Export ("attributionButton", ArgumentSemantic.Strong)]
		TMBAttributionButtonOptions AttributionButton { get; set; }
	}

	// @interface TMBOrnamentsManager : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC19TMBOrnamentsManager")]
	[DisableDefaultCtor]
	interface TMBOrnamentsManager
	{
		// @property (nonatomic, strong) TMBOrnamentOptions * _Nonnull options;
		[Export ("options", ArgumentSemantic.Strong)]
		TMBOrnamentOptions Options { get; set; }

		// @property (readonly, nonatomic, strong) UIView * _Nonnull logoView;
		[Export ("logoView", ArgumentSemantic.Strong)]
		UIView LogoView { get; }

		// @property (readonly, nonatomic, strong) UIView * _Nonnull scaleBarView;
		[Export ("scaleBarView", ArgumentSemantic.Strong)]
		UIView ScaleBarView { get; }

		// @property (readonly, nonatomic, strong) UIView * _Nonnull compassView;
		[Export ("compassView", ArgumentSemantic.Strong)]
		UIView CompassView { get; }

		// @property (readonly, nonatomic, strong) UIView * _Nonnull attributionButton;
		[Export ("attributionButton", ArgumentSemantic.Strong)]
		UIView AttributionButton { get; }
	}

	// @interface TMBOverviewViewportState : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC24TMBOverviewViewportState")]
	[DisableDefaultCtor]
	interface TMBOverviewViewportState
	{
		// @property (nonatomic, strong) TMBOverviewViewportStateOptions * _Nonnull options;
		[Export ("options", ArgumentSemantic.Strong)]
		TMBOverviewViewportStateOptions Options { get; set; }
	}

	// @interface MapboxMapObjC_Swift_2983 (TMBOverviewViewportState) <TMBViewportState>
	[Category]
	[BaseType (typeof(TMBOverviewViewportState))]
	interface TMBOverviewViewportState_MapboxMapObjC_Swift_2983 : ITMBViewportState
	{
		// -(TMBCancelable * _Nonnull)observeDataSourceWith:(BOOL (^ _Nonnull)(MBMCameraOptions * _Nonnull))handler __attribute__((warn_unused_result("")));
		[Export ("observeDataSourceWith:")]
		TMBCancelable ObserveDataSourceWith (Func<MBMCameraOptions, bool> handler);

		// -(void)startUpdatingCamera;
		[Export ("startUpdatingCamera")]
		void StartUpdatingCamera ();

		// -(void)stopUpdatingCamera;
		[Export ("stopUpdatingCamera")]
		void StopUpdatingCamera ();
	}

	// @interface TMBOverviewViewportStateOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC31TMBOverviewViewportStateOptions")]
	[DisableDefaultCtor]
	interface TMBOverviewViewportStateOptions
	{
		// @property (nonatomic, strong) MBXGeometry * _Nonnull geometry;
		[Export ("geometry", ArgumentSemantic.Strong)]
		MBXGeometry Geometry { get; set; }

		// @property (nonatomic) UIEdgeInsets padding;
		[Export ("padding", ArgumentSemantic.Assign)]
		UIEdgeInsets Padding { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable bearing;
		[NullAllowed, Export ("bearing", ArgumentSemantic.Strong)]
		NSNumber Bearing { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable pitch;
		[NullAllowed, Export ("pitch", ArgumentSemantic.Strong)]
		NSNumber Pitch { get; set; }

		// @property (nonatomic) NSTimeInterval animationDuration;
		[Export ("animationDuration")]
		double AnimationDuration { get; set; }

		// -(instancetype _Nonnull)initWithGeometry:(MBXGeometry * _Nonnull)geometry padding:(UIEdgeInsets)padding bearing:(NSNumber * _Nullable)bearing pitch:(NSNumber * _Nullable)pitch animationDuration:(NSTimeInterval)animationDuration __attribute__((objc_designated_initializer));
		[Export ("initWithGeometry:padding:bearing:pitch:animationDuration:")]
		[DesignatedInitializer]
		IntPtr Constructor (MBXGeometry geometry, UIEdgeInsets padding, [NullAllowed] NSNumber bearing, [NullAllowed] NSNumber pitch, double animationDuration);
	}

	// @interface TMBPointAnnotation : NSObject <TMBAnnotation>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBPointAnnotation")]
	[DisableDefaultCtor]
	interface TMBPointAnnotation : TMBAnnotation
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull geometryInJSON;
		[Export ("geometryInJSON")]
		string GeometryInJSON { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable userInfo;
		[NullAllowed, Export ("userInfo", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> UserInfo { get; }

		// @property (nonatomic) BOOL isSelected;
		[Export ("isSelected")]
		bool IsSelected { get; set; }

		// @property (nonatomic) BOOL isDraggable;
		[Export ("isDraggable")]
		bool IsDraggable { get; set; }

		// -(void)image:(UIImage * _Nonnull)image name:(NSString * _Nonnull)name;
		[Export ("image:name:")]
		void Image (UIImage image, string name);

		// +(TMBPointAnnotation * _Nonnull)fromCoordinate:(CLLocationCoordinate2D)coordinate __attribute__((warn_unused_result("")));
		[Static]
		[Export ("fromCoordinate:")]
		TMBPointAnnotation FromCoordinate (CLLocationCoordinate2D coordinate);

		// @property (nonatomic, strong) TMBIconAnchor * _Nullable iconAnchor;
		[NullAllowed, Export ("iconAnchor", ArgumentSemantic.Strong)]
		TMBIconAnchor IconAnchor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable iconImage;
		[NullAllowed, Export ("iconImage")]
		string IconImage { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable iconOffset;
		[NullAllowed, Export ("iconOffset", ArgumentSemantic.Copy)]
		NSNumber[] IconOffset { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable iconRotate;
		[NullAllowed, Export ("iconRotate", ArgumentSemantic.Strong)]
		NSNumber IconRotate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable iconSize;
		[NullAllowed, Export ("iconSize", ArgumentSemantic.Strong)]
		NSNumber IconSize { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable symbolSortKey;
		[NullAllowed, Export ("symbolSortKey", ArgumentSemantic.Strong)]
		NSNumber SymbolSortKey { get; set; }

		// @property (nonatomic, strong) TMBTextAnchor * _Nullable textAnchor;
		[NullAllowed, Export ("textAnchor", ArgumentSemantic.Strong)]
		TMBTextAnchor TextAnchor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable textField;
		[NullAllowed, Export ("textField")]
		string TextField { get; set; }

		// @property (nonatomic, strong) TMBTextJustify * _Nullable textJustify;
		[NullAllowed, Export ("textJustify", ArgumentSemantic.Strong)]
		TMBTextJustify TextJustify { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textLetterSpacing;
		[NullAllowed, Export ("textLetterSpacing", ArgumentSemantic.Strong)]
		NSNumber TextLetterSpacing { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textLineHeight;
		[NullAllowed, Export ("textLineHeight", ArgumentSemantic.Strong)]
		NSNumber TextLineHeight { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textMaxWidth;
		[NullAllowed, Export ("textMaxWidth", ArgumentSemantic.Strong)]
		NSNumber TextMaxWidth { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable textOffset;
		[NullAllowed, Export ("textOffset", ArgumentSemantic.Copy)]
		NSNumber[] TextOffset { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textRadialOffset;
		[NullAllowed, Export ("textRadialOffset", ArgumentSemantic.Strong)]
		NSNumber TextRadialOffset { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textRotate;
		[NullAllowed, Export ("textRotate", ArgumentSemantic.Strong)]
		NSNumber TextRotate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textSize;
		[NullAllowed, Export ("textSize", ArgumentSemantic.Strong)]
		NSNumber TextSize { get; set; }

		// @property (nonatomic, strong) TMBTextTransform * _Nullable textTransform;
		[NullAllowed, Export ("textTransform", ArgumentSemantic.Strong)]
		TMBTextTransform TextTransform { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable iconColor;
		[NullAllowed, Export ("iconColor", ArgumentSemantic.Strong)]
		UIColor IconColor { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable iconHaloBlur;
		[NullAllowed, Export ("iconHaloBlur", ArgumentSemantic.Strong)]
		NSNumber IconHaloBlur { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable iconHaloColor;
		[NullAllowed, Export ("iconHaloColor", ArgumentSemantic.Strong)]
		UIColor IconHaloColor { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable iconHaloWidth;
		[NullAllowed, Export ("iconHaloWidth", ArgumentSemantic.Strong)]
		NSNumber IconHaloWidth { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable iconOpacity;
		[NullAllowed, Export ("iconOpacity", ArgumentSemantic.Strong)]
		NSNumber IconOpacity { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textHaloBlur;
		[NullAllowed, Export ("textHaloBlur", ArgumentSemantic.Strong)]
		NSNumber TextHaloBlur { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable textHaloColor;
		[NullAllowed, Export ("textHaloColor", ArgumentSemantic.Strong)]
		UIColor TextHaloColor { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textHaloWidth;
		[NullAllowed, Export ("textHaloWidth", ArgumentSemantic.Strong)]
		NSNumber TextHaloWidth { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textOpacity;
		[NullAllowed, Export ("textOpacity", ArgumentSemantic.Strong)]
		NSNumber TextOpacity { get; set; }
	}

	// @interface TMBPointAnnotationManager : NSObject <TMBAnnotationManager>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC25TMBPointAnnotationManager")]
	[DisableDefaultCtor]
	interface TMBPointAnnotationManager : TMBAnnotationManager
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sourceId;
		[Export ("sourceId")]
		string SourceId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull layerId;
		[Export ("layerId")]
		string LayerId { get; }

		// @property (copy, nonatomic) NSArray<TMBPointAnnotation *> * _Nonnull annotations;
		[Export ("annotations", ArgumentSemantic.Copy)]
		TMBPointAnnotation[] Annotations { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		ITMBAnnotationInteractionDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TMBAnnotationInteractionDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable iconAllowOverlap;
		[NullAllowed, Export ("iconAllowOverlap", ArgumentSemantic.Strong)]
		NSNumber IconAllowOverlap { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable iconIgnorePlacement;
		[NullAllowed, Export ("iconIgnorePlacement", ArgumentSemantic.Strong)]
		NSNumber IconIgnorePlacement { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable iconKeepUpright;
		[NullAllowed, Export ("iconKeepUpright", ArgumentSemantic.Strong)]
		NSNumber IconKeepUpright { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable iconOptional;
		[NullAllowed, Export ("iconOptional", ArgumentSemantic.Strong)]
		NSNumber IconOptional { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable iconPadding;
		[NullAllowed, Export ("iconPadding", ArgumentSemantic.Strong)]
		NSNumber IconPadding { get; set; }

		// @property (nonatomic, strong) TMBIconPitchAlignment * _Nullable iconPitchAlignment;
		[NullAllowed, Export ("iconPitchAlignment", ArgumentSemantic.Strong)]
		TMBIconPitchAlignment IconPitchAlignment { get; set; }

		// @property (nonatomic, strong) TMBIconRotationAlignment * _Nullable iconRotationAlignment;
		[NullAllowed, Export ("iconRotationAlignment", ArgumentSemantic.Strong)]
		TMBIconRotationAlignment IconRotationAlignment { get; set; }

		// @property (nonatomic, strong) TMBIconTextFit * _Nullable iconTextFit;
		[NullAllowed, Export ("iconTextFit", ArgumentSemantic.Strong)]
		TMBIconTextFit IconTextFit { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable iconTextFitPadding;
		[NullAllowed, Export ("iconTextFitPadding", ArgumentSemantic.Copy)]
		NSNumber[] IconTextFitPadding { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable symbolAvoidEdges;
		[NullAllowed, Export ("symbolAvoidEdges", ArgumentSemantic.Strong)]
		NSNumber SymbolAvoidEdges { get; set; }

		// @property (nonatomic, strong) TMBSymbolPlacement * _Nullable symbolPlacement;
		[NullAllowed, Export ("symbolPlacement", ArgumentSemantic.Strong)]
		TMBSymbolPlacement SymbolPlacement { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable symbolSpacing;
		[NullAllowed, Export ("symbolSpacing", ArgumentSemantic.Strong)]
		NSNumber SymbolSpacing { get; set; }

		// @property (nonatomic, strong) TMBSymbolZOrder * _Nullable symbolZOrder;
		[NullAllowed, Export ("symbolZOrder", ArgumentSemantic.Strong)]
		TMBSymbolZOrder SymbolZOrder { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textAllowOverlap;
		[NullAllowed, Export ("textAllowOverlap", ArgumentSemantic.Strong)]
		NSNumber TextAllowOverlap { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable textFont;
		[NullAllowed, Export ("textFont", ArgumentSemantic.Copy)]
		string[] TextFont { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textIgnorePlacement;
		[NullAllowed, Export ("textIgnorePlacement", ArgumentSemantic.Strong)]
		NSNumber TextIgnorePlacement { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textKeepUpright;
		[NullAllowed, Export ("textKeepUpright", ArgumentSemantic.Strong)]
		NSNumber TextKeepUpright { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textMaxAngle;
		[NullAllowed, Export ("textMaxAngle", ArgumentSemantic.Strong)]
		NSNumber TextMaxAngle { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textOptional;
		[NullAllowed, Export ("textOptional", ArgumentSemantic.Strong)]
		NSNumber TextOptional { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textPadding;
		[NullAllowed, Export ("textPadding", ArgumentSemantic.Strong)]
		NSNumber TextPadding { get; set; }

		// @property (nonatomic, strong) TMBTextPitchAlignment * _Nullable textPitchAlignment;
		[NullAllowed, Export ("textPitchAlignment", ArgumentSemantic.Strong)]
		TMBTextPitchAlignment TextPitchAlignment { get; set; }

		// @property (nonatomic, strong) TMBTextRotationAlignment * _Nullable textRotationAlignment;
		[NullAllowed, Export ("textRotationAlignment", ArgumentSemantic.Strong)]
		TMBTextRotationAlignment TextRotationAlignment { get; set; }

		// @property (copy, nonatomic) NSArray<TMBTextAnchor *> * _Nullable textVariableAnchor;
		[NullAllowed, Export ("textVariableAnchor", ArgumentSemantic.Copy)]
		TMBTextAnchor[] TextVariableAnchor { get; set; }

		// @property (copy, nonatomic) NSArray<TMBTextWritingMode *> * _Nullable textWritingMode;
		[NullAllowed, Export ("textWritingMode", ArgumentSemantic.Copy)]
		TMBTextWritingMode[] TextWritingMode { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable iconTranslate;
		[NullAllowed, Export ("iconTranslate", ArgumentSemantic.Copy)]
		NSNumber[] IconTranslate { get; set; }

		// @property (nonatomic, strong) TMBIconTranslateAnchor * _Nullable iconTranslateAnchor;
		[NullAllowed, Export ("iconTranslateAnchor", ArgumentSemantic.Strong)]
		TMBIconTranslateAnchor IconTranslateAnchor { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable textTranslate;
		[NullAllowed, Export ("textTranslate", ArgumentSemantic.Copy)]
		NSNumber[] TextTranslate { get; set; }

		// @property (nonatomic, strong) TMBTextTranslateAnchor * _Nullable textTranslateAnchor;
		[NullAllowed, Export ("textTranslateAnchor", ArgumentSemantic.Strong)]
		TMBTextTranslateAnchor TextTranslateAnchor { get; set; }

		// @property (nonatomic, strong) SWIFT_DEPRECATED_MSG("text-line-height property is now data driven, use `PointAnnotation.textLineHeight` instead.") NSNumber * textLineHeight __attribute__((deprecated("text-line-height property is now data driven, use `PointAnnotation.textLineHeight` instead.")));
		[Export ("textLineHeight", ArgumentSemantic.Strong)]
		NSNumber TextLineHeight { get; set; }
	}

	// @interface TMBPolygon : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC10TMBPolygon")]
	[DisableDefaultCtor]
	interface TMBPolygon
	{
		// -(instancetype _Nonnull)initWithOuterRingCoordinates:(NSArray<NSValue *> * _Nonnull)outerRingCoordinates innerRingCoordinates:(NSArray<NSArray<NSValue *> *> * _Nonnull)innerRingCoordinates __attribute__((objc_designated_initializer));
		[Export ("initWithOuterRingCoordinates:innerRingCoordinates:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSValue[] outerRingCoordinates, NSArray innerRingCoordinates);

		// -(instancetype _Nonnull)init:(NSArray<NSArray<NSValue *> *> * _Nonnull)coordinates __attribute__((objc_designated_initializer));
		[Export ("init:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSArray coordinates);

		// +(TMBPolygon * _Nonnull)createWithOuterRingCoordinates:(NSArray<NSValue *> * _Nonnull)outerRingCoordinates innerRingCoordinates:(NSArray<NSArray<NSValue *> *> * _Nonnull)innerRingCoordinates __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithOuterRingCoordinates:innerRingCoordinates:")]
		TMBPolygon CreateWithOuterRingCoordinates (NSValue[] outerRingCoordinates, NSArray innerRingCoordinates);

		// +(TMBPolygon * _Nonnull)fromCoordinates:(NSArray<NSArray<NSValue *> *> * _Nonnull)coordinates __attribute__((warn_unused_result("")));
		[Static]
		[Export ("fromCoordinates:")]
		TMBPolygon FromCoordinates (NSArray coordinates);
	}

	// @interface TMBPolygonAnnotation : NSObject <TMBAnnotation>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC20TMBPolygonAnnotation")]
	[DisableDefaultCtor]
	interface TMBPolygonAnnotation : TMBAnnotation
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull geometryInJSON;
		[Export ("geometryInJSON")]
		string GeometryInJSON { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable userInfo;
		[NullAllowed, Export ("userInfo", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> UserInfo { get; }

		// +(TMBPolygonAnnotation * _Nonnull)polygon:(TMBPolygon * _Nonnull)polygon __attribute__((warn_unused_result("")));
		[Static]
		[Export ("polygon:")]
		TMBPolygonAnnotation Polygon (TMBPolygon polygon);

		// @property (nonatomic, strong) NSNumber * _Nullable fillSortKey;
		[NullAllowed, Export ("fillSortKey", ArgumentSemantic.Strong)]
		NSNumber FillSortKey { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable fillColor;
		[NullAllowed, Export ("fillColor", ArgumentSemantic.Strong)]
		UIColor FillColor { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable fillOpacity;
		[NullAllowed, Export ("fillOpacity", ArgumentSemantic.Strong)]
		NSNumber FillOpacity { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable fillOutlineColor;
		[NullAllowed, Export ("fillOutlineColor", ArgumentSemantic.Strong)]
		UIColor FillOutlineColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable fillPattern;
		[NullAllowed, Export ("fillPattern")]
		string FillPattern { get; set; }
	}

	// @interface TMBPolygonAnnotationManager : NSObject <TMBAnnotationManager>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC27TMBPolygonAnnotationManager")]
	[DisableDefaultCtor]
	interface TMBPolygonAnnotationManager : TMBAnnotationManager
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sourceId;
		[Export ("sourceId")]
		string SourceId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull layerId;
		[Export ("layerId")]
		string LayerId { get; }

		// @property (copy, nonatomic) NSArray<TMBPolygonAnnotation *> * _Nonnull annotations;
		[Export ("annotations", ArgumentSemantic.Copy)]
		TMBPolygonAnnotation[] Annotations { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable fillAntialias;
		[NullAllowed, Export ("fillAntialias", ArgumentSemantic.Strong)]
		NSNumber FillAntialias { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable fillTranslate;
		[NullAllowed, Export ("fillTranslate", ArgumentSemantic.Copy)]
		NSNumber[] FillTranslate { get; set; }

		// @property (nonatomic, strong) TMBFillTranslateAnchor * _Nullable fillTranslateAnchor;
		[NullAllowed, Export ("fillTranslateAnchor", ArgumentSemantic.Strong)]
		TMBFillTranslateAnchor FillTranslateAnchor { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		ITMBAnnotationInteractionDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TMBAnnotationInteractionDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	// @interface TMBPolylineAnnotation : NSObject <TMBAnnotation>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC21TMBPolylineAnnotation")]
	[DisableDefaultCtor]
	interface TMBPolylineAnnotation : TMBAnnotation
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull geometryInJSON;
		[Export ("geometryInJSON")]
		string GeometryInJSON { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable userInfo;
		[NullAllowed, Export ("userInfo", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> UserInfo { get; }

		// @property (nonatomic) BOOL isSelected;
		[Export ("isSelected")]
		bool IsSelected { get; set; }

		// @property (nonatomic) BOOL isDraggable;
		[Export ("isDraggable")]
		bool IsDraggable { get; set; }

		// +(TMBPolylineAnnotation * _Nonnull)fromId:(NSString * _Nonnull)id coordinates:(NSArray<NSValue *> * _Nonnull)coordinates isSelected:(BOOL)isSelected isDraggable:(BOOL)isDraggable __attribute__((warn_unused_result("")));
		[Static]
		[Export ("fromId:coordinates:isSelected:isDraggable:")]
		TMBPolylineAnnotation FromId (string id, NSValue[] coordinates, bool isSelected, bool isDraggable);

		// @property (nonatomic, strong) TMBLineJoin * _Nullable lineJoin;
		[NullAllowed, Export ("lineJoin", ArgumentSemantic.Strong)]
		TMBLineJoin LineJoin { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable lineSortKey;
		[NullAllowed, Export ("lineSortKey", ArgumentSemantic.Strong)]
		NSNumber LineSortKey { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable lineBlur;
		[NullAllowed, Export ("lineBlur", ArgumentSemantic.Strong)]
		NSNumber LineBlur { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable lineColor;
		[NullAllowed, Export ("lineColor", ArgumentSemantic.Strong)]
		UIColor LineColor { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable lineGapWidth;
		[NullAllowed, Export ("lineGapWidth", ArgumentSemantic.Strong)]
		NSNumber LineGapWidth { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable lineOffset;
		[NullAllowed, Export ("lineOffset", ArgumentSemantic.Strong)]
		NSNumber LineOffset { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable lineOpacity;
		[NullAllowed, Export ("lineOpacity", ArgumentSemantic.Strong)]
		NSNumber LineOpacity { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable linePattern;
		[NullAllowed, Export ("linePattern")]
		string LinePattern { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable lineWidth;
		[NullAllowed, Export ("lineWidth", ArgumentSemantic.Strong)]
		NSNumber LineWidth { get; set; }
	}

	// @interface TMBPolylineAnnotationManager : NSObject <TMBAnnotationManager>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC28TMBPolylineAnnotationManager")]
	[DisableDefaultCtor]
	interface TMBPolylineAnnotationManager : TMBAnnotationManager
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sourceId;
		[Export ("sourceId")]
		string SourceId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull layerId;
		[Export ("layerId")]
		string LayerId { get; }

		// @property (copy, nonatomic) NSArray<TMBPolylineAnnotation *> * _Nonnull annotations;
		[Export ("annotations", ArgumentSemantic.Copy)]
		TMBPolylineAnnotation[] Annotations { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		ITMBAnnotationInteractionDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TMBAnnotationInteractionDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) TMBLineCap * _Nullable lineCap;
		[NullAllowed, Export ("lineCap", ArgumentSemantic.Strong)]
		TMBLineCap LineCap { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable lineMiterLimit;
		[NullAllowed, Export ("lineMiterLimit", ArgumentSemantic.Strong)]
		NSNumber LineMiterLimit { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable lineRoundLimit;
		[NullAllowed, Export ("lineRoundLimit", ArgumentSemantic.Strong)]
		NSNumber LineRoundLimit { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable lineDasharray;
		[NullAllowed, Export ("lineDasharray", ArgumentSemantic.Copy)]
		NSNumber[] LineDasharray { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable lineTranslate;
		[NullAllowed, Export ("lineTranslate", ArgumentSemantic.Copy)]
		NSNumber[] LineTranslate { get; set; }

		// @property (nonatomic, strong) TMBLineTranslateAnchor * _Nullable lineTranslateAnchor;
		[NullAllowed, Export ("lineTranslateAnchor", ArgumentSemantic.Strong)]
		TMBLineTranslateAnchor LineTranslateAnchor { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable lineTrimOffset;
		[NullAllowed, Export ("lineTrimOffset", ArgumentSemantic.Copy)]
		NSNumber[] LineTrimOffset { get; set; }
	}

	// @interface TMBPuck2DConfiguration : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC22TMBPuck2DConfiguration")]
	[DisableDefaultCtor]
	interface TMBPuck2DConfiguration
	{
		// @property (nonatomic) double opacity;
		[Export ("opacity")]
		double Opacity { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable topImage;
		[NullAllowed, Export ("topImage", ArgumentSemantic.Strong)]
		UIImage TopImage { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable bearingImage;
		[NullAllowed, Export ("bearingImage", ArgumentSemantic.Strong)]
		UIImage BearingImage { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable shadowImage;
		[NullAllowed, Export ("shadowImage", ArgumentSemantic.Strong)]
		UIImage ShadowImage { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable scale;
		[NullAllowed, Export ("scale", ArgumentSemantic.Strong)]
		TMBValue Scale { get; set; }

		// @property (nonatomic, strong) TMBPuck2DConfigurationPulsing * _Nullable pulsing;
		[NullAllowed, Export ("pulsing", ArgumentSemantic.Strong)]
		TMBPuck2DConfigurationPulsing Pulsing { get; set; }

		// @property (nonatomic) BOOL showsAccuracyRing;
		[Export ("showsAccuracyRing")]
		bool ShowsAccuracyRing { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull accuracyRingColor;
		[Export ("accuracyRingColor", ArgumentSemantic.Strong)]
		UIColor AccuracyRingColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull accuracyRingBorderColor;
		[Export ("accuracyRingBorderColor", ArgumentSemantic.Strong)]
		UIColor AccuracyRingBorderColor { get; set; }

		// -(instancetype _Nonnull)initWithTopImage:(UIImage * _Nullable)topImage bearingImage:(UIImage * _Nullable)bearingImage shadowImage:(UIImage * _Nullable)shadowImage scale:(TMBValue * _Nullable)scale showsAccuracyRing:(BOOL)showsAccuracyRing accuracyRingColor:(UIColor * _Nonnull)accuracyRingColor accuracyRingBorderColor:(UIColor * _Nonnull)accuracyRingBorderColor opacity:(double)opacity __attribute__((objc_designated_initializer));
		[Export ("initWithTopImage:bearingImage:shadowImage:scale:showsAccuracyRing:accuracyRingColor:accuracyRingBorderColor:opacity:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] UIImage topImage, [NullAllowed] UIImage bearingImage, [NullAllowed] UIImage shadowImage, [NullAllowed] TMBValue scale, bool showsAccuracyRing, UIColor accuracyRingColor, UIColor accuracyRingBorderColor, double opacity);

		// -(instancetype _Nonnull)initWithTopImage:(UIImage * _Nullable)topImage bearingImage:(UIImage * _Nullable)bearingImage shadowImage:(UIImage * _Nullable)shadowImage scale:(TMBValue * _Nullable)scale pulsing:(TMBPuck2DConfigurationPulsing * _Nullable)pulsing showsAccuracyRing:(BOOL)showsAccuracyRing opacity:(double)opacity __attribute__((objc_designated_initializer));
		[Export ("initWithTopImage:bearingImage:shadowImage:scale:pulsing:showsAccuracyRing:opacity:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] UIImage topImage, [NullAllowed] UIImage bearingImage, [NullAllowed] UIImage shadowImage, [NullAllowed] TMBValue scale, [NullAllowed] TMBPuck2DConfigurationPulsing pulsing, bool showsAccuracyRing, double opacity);

		// +(TMBPuck2DConfiguration * _Nonnull)makeDefaultWithShowBearing:(BOOL)showBearing __attribute__((warn_unused_result("")));
		[Static]
		[Export ("makeDefaultWithShowBearing:")]
		TMBPuck2DConfiguration MakeDefaultWithShowBearing (bool showBearing);
	}

	// @interface TMBPuck2DConfigurationPulsing : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC29TMBPuck2DConfigurationPulsing")]
	[DisableDefaultCtor]
	interface TMBPuck2DConfigurationPulsing
	{
		// @property (nonatomic) BOOL isEnabled;
		[Export ("isEnabled")]
		bool IsEnabled { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull color;
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// @property (nonatomic) enum TMBPuck2DConfigurationPulsingRadius radius;
		[Export ("radius", ArgumentSemantic.Assign)]
		TMBPuck2DConfigurationPulsingRadius Radius { get; set; }

		// @property (nonatomic) double radiusValue;
		[Export ("radiusValue")]
		double RadiusValue { get; set; }
	}

	// @interface TMBPuck3DConfiguration : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC22TMBPuck3DConfiguration")]
	[DisableDefaultCtor]
	interface TMBPuck3DConfiguration
	{
		// @property (nonatomic, strong) TMBModel * _Nonnull model;
		[Export ("model", ArgumentSemantic.Strong)]
		TMBModel Model { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable modelScale;
		[NullAllowed, Export ("modelScale", ArgumentSemantic.Strong)]
		TMBValue ModelScale { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable modelRotation;
		[NullAllowed, Export ("modelRotation", ArgumentSemantic.Strong)]
		TMBValue ModelRotation { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable modelOpacity;
		[NullAllowed, Export ("modelOpacity", ArgumentSemantic.Strong)]
		TMBValue ModelOpacity { get; set; }

		// -(instancetype _Nonnull)initWithModel:(TMBModel * _Nonnull)model modelScale:(TMBValue * _Nullable)modelScale modelRotation:(TMBValue * _Nullable)modelRotation modelOpacity:(TMBValue * _Nullable)modelOpacity __attribute__((objc_designated_initializer));
		[Export ("initWithModel:modelScale:modelRotation:modelOpacity:")]
		[DesignatedInitializer]
		IntPtr Constructor (TMBModel model, [NullAllowed] TMBValue modelScale, [NullAllowed] TMBValue modelRotation, [NullAllowed] TMBValue modelOpacity);
	}

	// @interface TMBRasterResampling : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC19TMBRasterResampling")]
	[DisableDefaultCtor]
	interface TMBRasterResampling : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBRasterResampling * _Nonnull linear;
		[Static]
		[Export ("linear", ArgumentSemantic.Strong)]
		TMBRasterResampling Linear { get; }

		// @property (readonly, nonatomic, strong, class) TMBRasterResampling * _Nonnull nearest;
		[Static]
		[Export ("nearest", ArgumentSemantic.Strong)]
		TMBRasterResampling Nearest { get; }
	}

	// @interface TMBResolvedImage : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC16TMBResolvedImage")]
	[DisableDefaultCtor]
	interface TMBResolvedImage
	{
	}

	// @interface MapboxMapObjC_Swift_3446 (TMBResolvedImage)
	[Category]
	[BaseType (typeof(TMBResolvedImage))]
	interface TMBResolvedImage_MapboxMapObjC_Swift_3446
	{
		// +(TMBResolvedImage * _Nonnull)fromName:(NSString * _Nonnull)name __attribute__((warn_unused_result("")));
		[Static]
		[Export ("fromName:")]
		TMBResolvedImage FromName (string name);

		// +(TMBResolvedImage * _Nonnull)fromName:(NSString * _Nonnull)name available:(BOOL)available __attribute__((warn_unused_result("")));
		[Static]
		[Export ("fromName:available:")]
		TMBResolvedImage FromName (string name, bool available);
	}

	// @interface TMBResolvedImageData : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC20TMBResolvedImageData")]
	[DisableDefaultCtor]
	interface TMBResolvedImageData
	{
	}

	// @interface TMBResourceOptionsManager : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC25TMBResourceOptionsManager")]
	[DisableDefaultCtor]
	interface TMBResourceOptionsManager
	{
		// @property (readonly, getter = default, nonatomic, strong, class) TMBResourceOptionsManager * _Nonnull default_;
		[Static]
		[Export ("default_", ArgumentSemantic.Strong)]
		TMBResourceOptionsManager Default { [Bind ("default")] get; }

		// +(void)destroyDefault;
		[Static]
		[Export ("destroyDefault")]
		void DestroyDefault ();

		// @property (nonatomic, strong) MBMResourceOptions * _Nonnull resourceOptions;
		[Export ("resourceOptions", ArgumentSemantic.Strong)]
		MBMResourceOptions ResourceOptions { get; set; }

		// -(instancetype _Nonnull)initWithAccessToken:(NSString * _Nullable)accessToken;
		[Export ("initWithAccessToken:")]
		IntPtr Constructor ([NullAllowed] string accessToken);

		// -(instancetype _Nonnull)initWithResourceOptions:(MBMResourceOptions * _Nonnull)resourceOptions;
		[Export ("initWithResourceOptions:")]
		IntPtr Constructor (MBMResourceOptions resourceOptions);
	}

	// @interface TMBScaleBarViewOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC22TMBScaleBarViewOptions")]
	[DisableDefaultCtor]
	interface TMBScaleBarViewOptions
	{
		// @property (nonatomic) enum TMBOrnamentPosition position;
		[Export ("position", ArgumentSemantic.Assign)]
		TMBOrnamentPosition Position { get; set; }

		// @property (nonatomic) CGPoint margins;
		[Export ("margins", ArgumentSemantic.Assign)]
		CGPoint Margins { get; set; }

		// @property (nonatomic) enum TMBOrnamentVisibility visibility;
		[Export ("visibility", ArgumentSemantic.Assign)]
		TMBOrnamentVisibility Visibility { get; set; }
	}

	// @interface TMBScheme : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC9TMBScheme")]
	[DisableDefaultCtor]
	interface TMBScheme : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBScheme * _Nonnull xyz;
		[Static]
		[Export ("xyz", ArgumentSemantic.Strong)]
		TMBScheme Xyz { get; }

		// @property (readonly, nonatomic, strong, class) TMBScheme * _Nonnull tms;
		[Static]
		[Export ("tms", ArgumentSemantic.Strong)]
		TMBScheme Tms { get; }
	}

	// @interface TMBSkyType : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC10TMBSkyType")]
	[DisableDefaultCtor]
	interface TMBSkyType : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBSkyType * _Nonnull gradient;
		[Static]
		[Export ("gradient", ArgumentSemantic.Strong)]
		TMBSkyType Gradient { get; }

		// @property (readonly, nonatomic, strong, class) TMBSkyType * _Nonnull atmosphere;
		[Static]
		[Export ("atmosphere", ArgumentSemantic.Strong)]
		TMBSkyType Atmosphere { get; }
	}

	// @interface TMBSource : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC9TMBSource")]
	[DisableDefaultCtor]
	interface TMBSource
	{
		// @property (readonly, nonatomic, strong) TMBSourceType * _Nonnull type;
		[Export ("type", ArgumentSemantic.Strong)]
		TMBSourceType Type { get; }
	}

	// @interface TMBSourceInfo : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13TMBSourceInfo")]
	[DisableDefaultCtor]
	interface TMBSourceInfo
	{
		// @property (copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; set; }

		// @property (nonatomic, strong) TMBSourceType * _Nonnull type;
		[Export ("type", ArgumentSemantic.Strong)]
		TMBSourceType Type { get; set; }
	}

	// @interface TMBSourceType : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13TMBSourceType")]
	[DisableDefaultCtor]
	interface TMBSourceType : NamedString
	{
		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBSourceType * _Nonnull vector;
		[Static]
		[Export ("vector", ArgumentSemantic.Strong)]
		TMBSourceType Vector { get; }

		// @property (readonly, nonatomic, strong, class) TMBSourceType * _Nonnull raster;
		[Static]
		[Export ("raster", ArgumentSemantic.Strong)]
		TMBSourceType Raster { get; }

		// @property (readonly, nonatomic, strong, class) TMBSourceType * _Nonnull rasterDem;
		[Static]
		[Export ("rasterDem", ArgumentSemantic.Strong)]
		TMBSourceType RasterDem { get; }

		// @property (readonly, nonatomic, strong, class) TMBSourceType * _Nonnull geoJson;
		[Static]
		[Export ("geoJson", ArgumentSemantic.Strong)]
		TMBSourceType GeoJson { get; }

		// @property (readonly, nonatomic, strong, class) TMBSourceType * _Nonnull image;
		[Static]
		[Export ("image", ArgumentSemantic.Strong)]
		TMBSourceType Image { get; }

		// @property (readonly, nonatomic, strong, class) TMBSourceType * _Nonnull model;
		[Static]
		[Export ("model", ArgumentSemantic.Strong)]
		TMBSourceType Model { get; }
	}

	// @interface TMBStyle : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC8TMBStyle")]
	[DisableDefaultCtor]
	interface TMBStyle
	{
		// @property (readonly, nonatomic, weak) MBMStyleManager * _Null_unspecified styleManager;
		[Export ("styleManager", ArgumentSemantic.Weak)]
		MBMStyleManager StyleManager { get; }

		// -(void)addLayer:(TMBLayer * _Nonnull)layer layerPosition:(TMBLayerPosition * _Nullable)layerPosition completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addLayer:layerPosition:completion:")]
		void AddLayer (TMBLayer layer, [NullAllowed] TMBLayerPosition layerPosition, [NullAllowed] Action<NSError> completion);

		// -(void)addPersistentLayer:(TMBLayer * _Nonnull)layer layerPosition:(TMBLayerPosition * _Nullable)layerPosition completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addPersistentLayer:layerPosition:completion:")]
		void AddPersistentLayer (TMBLayer layer, [NullAllowed] TMBLayerPosition layerPosition, [NullAllowed] Action<NSError> completion);

		// -(void)moveLayerWithId:(NSString * _Nonnull)id to:(TMBLayerPosition * _Nonnull)position completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("moveLayerWithId:to:completion:")]
		void MoveLayerWithId (string id, TMBLayerPosition position, [NullAllowed] Action<NSError> completion);

		// -(void)layerWithId:(NSString * _Nonnull)id type:(enum TMBLayerType)type completion:(void (^ _Nullable)(TMBLayer * _Nullable, NSError * _Nullable))completion;
		[Export ("layerWithId:type:completion:")]
		void LayerWithId (string id, TMBLayerType type, [NullAllowed] Action<TMBLayer, NSError> completion);

		// -(void)layerWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(TMBLayer * _Nullable, NSError * _Nullable))completion;
		[Export ("layerWithId:completion:")]
		void LayerWithId (string id, [NullAllowed] Action<TMBLayer, NSError> completion);

		// -(void)updateLayerWithId:(NSString * _Nonnull)id type:(enum TMBLayerType)type update:(void (^ _Nonnull)(TMBLayer * _Nonnull))update completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("updateLayerWithId:type:update:completion:")]
		void UpdateLayerWithId (string id, TMBLayerType type, Action<TMBLayer> update, [NullAllowed] Action<NSError> completion);

		// -(void)addSource:(TMBSource * _Nonnull)source id:(NSString * _Nonnull)id completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addSource:id:completion:")]
		void AddSource (TMBSource source, string id, [NullAllowed] Action<NSError> completion);

		// -(void)sourceWithId:(NSString * _Nonnull)id type:(TMBSourceType * _Nonnull)type completion:(void (^ _Nullable)(TMBSource * _Nullable, NSError * _Nullable))completion;
		[Export ("sourceWithId:type:completion:")]
		void SourceWithId (string id, TMBSourceType type, [NullAllowed] Action<TMBSource, NSError> completion);

		// -(void)sourceWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(TMBSource * _Nullable, NSError * _Nullable))completion;
		[Export ("sourceWithId:completion:")]
		void SourceWithId (string id, [NullAllowed] Action<TMBSource, NSError> completion);

		// -(void)updateGeoJSONSourceWithId:(NSString * _Nonnull)id geometry:(MBXGeometry * _Nonnull)geometry completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("updateGeoJSONSourceWithId:geometry:completion:")]
		void UpdateGeoJSONSourceWithId (string id, MBXGeometry geometry, [NullAllowed] Action<NSError> completion);

		// -(void)updateGeoJSONSourceWithId:(NSString * _Nonnull)id feature:(MBXFeature * _Nonnull)feature completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("updateGeoJSONSourceWithId:feature:completion:")]
		void UpdateGeoJSONSourceWithId (string id, MBXFeature feature, [NullAllowed] Action<NSError> completion);

		// @property (readonly, nonatomic) BOOL isLoaded;
		[Export ("isLoaded")]
		bool IsLoaded { get; }

		// @property (copy, nonatomic) NSString * _Nullable uri;
		[NullAllowed, Export ("uri")]
		string Uri { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull JSON;
		[Export ("JSON")]
		string JSON { get; set; }

		// @property (readonly, nonatomic, strong) MBMCameraOptions * _Nonnull defaultCamera;
		[Export ("defaultCamera", ArgumentSemantic.Strong)]
		MBMCameraOptions DefaultCamera { get; }

		// @property (nonatomic, strong) MBMTransitionOptions * _Nonnull transition;
		[Export ("transition", ArgumentSemantic.Strong)]
		MBMTransitionOptions Transition { get; set; }

		// -(void)addLayerWith:(NSDictionary<NSString *,id> * _Nonnull)properties layerPosition:(TMBLayerPosition * _Nullable)layerPosition completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addLayerWith:layerPosition:completion:")]
		void AddLayerWith (NSDictionary<NSString, NSObject> properties, [NullAllowed] TMBLayerPosition layerPosition, [NullAllowed] Action<NSError> completion);

		// -(void)addPersistentLayerWith:(NSDictionary<NSString *,id> * _Nonnull)properties layerPosition:(TMBLayerPosition * _Nullable)layerPosition completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addPersistentLayerWith:layerPosition:completion:")]
		void AddPersistentLayerWith (NSDictionary<NSString, NSObject> properties, [NullAllowed] TMBLayerPosition layerPosition, [NullAllowed] Action<NSError> completion);

		// -(void)isPersistentLayerWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(NSNumber * _Nullable, NSError * _Nullable))completion;
		[Export ("isPersistentLayerWithId:completion:")]
		void IsPersistentLayerWithId (string id, [NullAllowed] Action<NSNumber, NSError> completion);

		// -(void)addPersistentCustomLayerWithId:(NSString * _Nonnull)id layerHost:(id<MBMCustomLayerHost> _Nonnull)layerHost layerPosition:(TMBLayerPosition * _Nullable)layerPosition completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addPersistentCustomLayerWithId:layerHost:layerPosition:completion:")]
		void AddPersistentCustomLayerWithId (string id, MBMCustomLayerHost layerHost, [NullAllowed] TMBLayerPosition layerPosition, [NullAllowed] Action<NSError> completion);

		// -(void)addCustomLayerWithId:(NSString * _Nonnull)id layerHost:(id<MBMCustomLayerHost> _Nonnull)layerHost layerPosition:(TMBLayerPosition * _Nullable)layerPosition completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addCustomLayerWithId:layerHost:layerPosition:completion:")]
		void AddCustomLayerWithId (string id, MBMCustomLayerHost layerHost, [NullAllowed] TMBLayerPosition layerPosition, [NullAllowed] Action<NSError> completion);

		// -(void)removeLayerWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("removeLayerWithId:completion:")]
		void RemoveLayerWithId (string id, [NullAllowed] Action<NSError> completion);

		// -(BOOL)layerExistsWithId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("layerExistsWithId:")]
		bool LayerExistsWithId (string id);

		// @property (readonly, copy, nonatomic) NSArray<TMBLayerInfo *> * _Nonnull allLayerIdentifiers;
		[Export ("allLayerIdentifiers", ArgumentSemantic.Copy)]
		TMBLayerInfo[] AllLayerIdentifiers { get; }

		// -(id _Nonnull)layerPropertyValueFor:(NSString * _Nonnull)layerId property:(NSString * _Nonnull)property __attribute__((warn_unused_result("")));
		[Export ("layerPropertyValueFor:property:")]
		NSObject LayerPropertyValueFor (string layerId, string property);

		// -(MBMStylePropertyValue * _Nonnull)layerPropertyFor:(NSString * _Nonnull)layerId property:(NSString * _Nonnull)property __attribute__((warn_unused_result("")));
		[Export ("layerPropertyFor:property:")]
		MBMStylePropertyValue LayerPropertyFor (string layerId, string property);

		// -(void)setLayerPropertyFor:(NSString * _Nonnull)layerId property:(NSString * _Nonnull)property value:(id _Nonnull)value completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setLayerPropertyFor:property:value:completion:")]
		void SetLayerPropertyFor (string layerId, string property, NSObject value, [NullAllowed] Action<NSError> completion);

		// +(MBMStylePropertyValue * _Nonnull)layerPropertyDefaultValueFor:(enum TMBLayerType)layerType property:(NSString * _Nonnull)property __attribute__((warn_unused_result("")));
		[Static]
		[Export ("layerPropertyDefaultValueFor:property:")]
		MBMStylePropertyValue LayerPropertyDefaultValueFor (TMBLayerType layerType, string property);

		// -(void)layerPropertiesFor:(NSString * _Nonnull)layerId completion:(void (^ _Nullable)(NSDictionary<NSString *,id> * _Nullable, NSError * _Nullable))completion;
		[Export ("layerPropertiesFor:completion:")]
		void LayerPropertiesFor (string layerId, [NullAllowed] Action<NSDictionary<NSString, NSObject>, NSError> completion);

		// -(void)setLayerPropertiesFor:(NSString * _Nonnull)layerId properties:(NSDictionary<NSString *,id> * _Nonnull)properties completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setLayerPropertiesFor:properties:completion:")]
		void SetLayerPropertiesFor (string layerId, NSDictionary<NSString, NSObject> properties, [NullAllowed] Action<NSError> completion);

		// -(void)addSourceWithId:(NSString * _Nonnull)id properties:(NSDictionary<NSString *,id> * _Nonnull)properties completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addSourceWithId:properties:completion:")]
		void AddSourceWithId (string id, NSDictionary<NSString, NSObject> properties, [NullAllowed] Action<NSError> completion);

		// -(void)removeSourceWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("removeSourceWithId:completion:")]
		void RemoveSourceWithId (string id, [NullAllowed] Action<NSError> completion);

		// -(BOOL)sourceExistsWithId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("sourceExistsWithId:")]
		bool SourceExistsWithId (string id);

		// @property (readonly, copy, nonatomic) NSArray<TMBSourceInfo *> * _Nonnull allSourceIdentifiers;
		[Export ("allSourceIdentifiers", ArgumentSemantic.Copy)]
		TMBSourceInfo[] AllSourceIdentifiers { get; }

		// -(MBMStylePropertyValue * _Nonnull)sourcePropertyFor:(NSString * _Nonnull)sourceId property:(NSString * _Nonnull)property __attribute__((warn_unused_result("")));
		[Export ("sourcePropertyFor:property:")]
		MBMStylePropertyValue SourcePropertyFor (string sourceId, string property);

		// -(void)setSourcePropertyFor:(NSString * _Nonnull)sourceId property:(NSString * _Nonnull)property value:(id _Nonnull)value completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setSourcePropertyFor:property:value:completion:")]
		void SetSourcePropertyFor (string sourceId, string property, NSObject value, [NullAllowed] Action<NSError> completion);

		// -(void)sourcePropertiesFor:(NSString * _Nonnull)sourceId completion:(void (^ _Nullable)(NSDictionary<NSString *,id> * _Nullable, NSError * _Nullable))completion;
		[Export ("sourcePropertiesFor:completion:")]
		void SourcePropertiesFor (string sourceId, [NullAllowed] Action<NSDictionary<NSString, NSObject>, NSError> completion);

		// -(void)setSourcePropertiesFor:(NSString * _Nonnull)sourceId properties:(NSDictionary<NSString *,id> * _Nonnull)properties completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setSourcePropertiesFor:properties:completion:")]
		void SetSourcePropertiesFor (string sourceId, NSDictionary<NSString, NSObject> properties, [NullAllowed] Action<NSError> completion);

		// +(MBMStylePropertyValue * _Nonnull)sourcePropertyDefaultValueFor:(NSString * _Nonnull)sourceType property:(NSString * _Nonnull)property __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sourcePropertyDefaultValueFor:property:")]
		MBMStylePropertyValue SourcePropertyDefaultValueFor (string sourceType, string property);

		// -(void)updateImageSourceWithId:(NSString * _Nonnull)id image:(UIImage * _Nonnull)image completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("updateImageSourceWithId:image:completion:")]
		void UpdateImageSourceWithId (string id, UIImage image, [NullAllowed] Action<NSError> completion);

		// -(void)addImage:(UIImage * _Nonnull)image id:(NSString * _Nonnull)id sdf:(BOOL)sdf stretchX:(NSArray<MBMImageStretches *> * _Nonnull)stretchX stretchY:(NSArray<MBMImageStretches *> * _Nonnull)stretchY content:(MBMImageContent * _Nullable)content completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addImage:id:sdf:stretchX:stretchY:content:completion:")]
		void AddImage (UIImage image, string id, bool sdf, MBMImageStretches[] stretchX, MBMImageStretches[] stretchY, [NullAllowed] MBMImageContent content, [NullAllowed] Action<NSError> completion);

		// -(void)addImage:(UIImage * _Nonnull)image id:(NSString * _Nonnull)id sdf:(BOOL)sdf contentInsets:(UIEdgeInsets)contentInsets completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addImage:id:sdf:contentInsets:completion:")]
		void AddImage (UIImage image, string id, bool sdf, UIEdgeInsets contentInsets, [NullAllowed] Action<NSError> completion);

		// -(void)removeImageWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("removeImageWithId:completion:")]
		void RemoveImageWithId (string id, [NullAllowed] Action<NSError> completion);

		// -(BOOL)imageExistsWithId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("imageExistsWithId:")]
		bool ImageExistsWithId (string id);

		// -(UIImage * _Nullable)imageWithId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("imageWithId:")]
		[return: NullAllowed]
		UIImage ImageWithId (string id);

		// -(void)setLight:(TMBLight * _Nonnull)light completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setLight:completion:")]
		void SetLight (TMBLight light, [NullAllowed] Action<NSError> completion);

		// -(void)setLightWithProperties:(NSDictionary<NSString *,id> * _Nonnull)properties completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setLightWithProperties:completion:")]
		void SetLightWithProperties (NSDictionary<NSString, NSObject> properties, [NullAllowed] Action<NSError> completion);

		// -(void)setLightProperty:(NSString * _Nonnull)property value:(id _Nonnull)value completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setLightProperty:value:completion:")]
		void SetLightProperty (string property, NSObject value, [NullAllowed] Action<NSError> completion);

		// -(id _Nonnull)lightProperty:(NSString * _Nonnull)property __attribute__((warn_unused_result("")));
		[Export ("lightProperty:")]
		NSObject LightProperty (string property);

		// -(MBMStylePropertyValue * _Nonnull)lightStylePropertyValue:(NSString * _Nonnull)property __attribute__((warn_unused_result("")));
		[Export ("lightStylePropertyValue:")]
		MBMStylePropertyValue LightStylePropertyValue (string property);

		// -(void)setTerrain:(TMBTerrain * _Nonnull)terrain completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setTerrain:completion:")]
		void SetTerrain (TMBTerrain terrain, [NullAllowed] Action<NSError> completion);

		// -(void)removeTerrain;
		[Export ("removeTerrain")]
		void RemoveTerrain ();

		// -(void)setTerrainWithProperties:(NSDictionary<NSString *,id> * _Nonnull)properties completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setTerrainWithProperties:completion:")]
		void SetTerrainWithProperties (NSDictionary<NSString, NSObject> properties, [NullAllowed] Action<NSError> completion);

		// -(void)setTerrainProperty:(NSString * _Nonnull)property value:(id _Nonnull)value completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setTerrainProperty:value:completion:")]
		void SetTerrainProperty (string property, NSObject value, [NullAllowed] Action<NSError> completion);

		// -(id _Nonnull)terrainProperty:(NSString * _Nonnull)property __attribute__((warn_unused_result("")));
		[Export ("terrainProperty:")]
		NSObject TerrainProperty (string property);

		// -(MBMStylePropertyValue * _Nonnull)terrainStylePropertyValue:(NSString * _Nonnull)property __attribute__((warn_unused_result("")));
		[Export ("terrainStylePropertyValue:")]
		MBMStylePropertyValue TerrainStylePropertyValue (string property);

		// -(void)setAtmosphere:(TMBAtmosphere * _Nonnull)atmosphere completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setAtmosphere:completion:")]
		void SetAtmosphere (TMBAtmosphere atmosphere, [NullAllowed] Action<NSError> completion);

		// -(void)removeAtmosphereWithCompletion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("removeAtmosphereWithCompletion:")]
		void RemoveAtmosphereWithCompletion ([NullAllowed] Action<NSError> completion);

		// -(void)setAtmosphereWithProperties:(NSDictionary<NSString *,id> * _Nonnull)properties completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setAtmosphereWithProperties:completion:")]
		void SetAtmosphereWithProperties (NSDictionary<NSString, NSObject> properties, [NullAllowed] Action<NSError> completion);

		// -(void)setAtmosphereProperty:(NSString * _Nonnull)property value:(id _Nonnull)value completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setAtmosphereProperty:value:completion:")]
		void SetAtmosphereProperty (string property, NSObject value, [NullAllowed] Action<NSError> completion);

		// -(MBMStylePropertyValue * _Nonnull)atmosphereProperty:(NSString * _Nonnull)property __attribute__((warn_unused_result("")));
		[Export ("atmosphereProperty:")]
		MBMStylePropertyValue AtmosphereProperty (string property);

		// -(void)addCustomGeometrySourceWithId:(NSString * _Nonnull)id options:(MBMCustomGeometrySourceOptions * _Nonnull)options completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addCustomGeometrySourceWithId:options:completion:")]
		void AddCustomGeometrySourceWithId (string id, MBMCustomGeometrySourceOptions options, [NullAllowed] Action<NSError> completion);

		// -(void)setCustomGeometrySourceTileDataForSourceId:(NSString * _Nonnull)sourceId tileId:(MBMCanonicalTileID * _Nonnull)tileId features:(NSArray<MBXFeature *> * _Nonnull)features completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setCustomGeometrySourceTileDataForSourceId:tileId:features:completion:")]
		void SetCustomGeometrySourceTileDataForSourceId (string sourceId, MBMCanonicalTileID tileId, MBXFeature[] features, [NullAllowed] Action<NSError> completion);

		// -(void)invalidateCustomGeometrySourceTileForSourceId:(NSString * _Nonnull)sourceId tileId:(MBMCanonicalTileID * _Nonnull)tileId completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("invalidateCustomGeometrySourceTileForSourceId:tileId:completion:")]
		void InvalidateCustomGeometrySourceTileForSourceId (string sourceId, MBMCanonicalTileID tileId, [NullAllowed] Action<NSError> completion);

		// -(void)invalidateCustomGeometrySourceRegionForSourceId:(NSString * _Nonnull)sourceId bounds:(MBMCoordinateBounds * _Nonnull)bounds completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("invalidateCustomGeometrySourceRegionForSourceId:bounds:completion:")]
		void InvalidateCustomGeometrySourceRegionForSourceId (string sourceId, MBMCoordinateBounds bounds, [NullAllowed] Action<NSError> completion);
	}

	// @interface MapboxMapObjC_Swift_4315 (TMBStyle)
	[Category]
	[BaseType (typeof(TMBStyle))]
	interface TMBStyle_MapboxMapObjC_Swift_4315
	{
		// -(void)addGeoJSONSourceWithId:(NSString * _Nonnull)id properties:(NSDictionary<NSString *,id> * _Nonnull)properties geojson:(NSString * _Nonnull)geojson onComplete:(void (^ _Nullable)(NSError * _Nullable))onComplete;
		[Export ("addGeoJSONSourceWithId:properties:geojson:onComplete:")]
		void AddGeoJSONSourceWithId (string id, NSDictionary<NSString, NSObject> properties, string geojson, [NullAllowed] Action<NSError> onComplete);

		// -(void)updateGeoJSONSourceWithId:(NSString * _Nonnull)id geojson:(NSString * _Nonnull)geojson onComplete:(void (^ _Nullable)(NSError * _Nullable))onComplete;
		[Export ("updateGeoJSONSourceWithId:geojson:onComplete:")]
		void UpdateGeoJSONSourceWithId (string id, string geojson, [NullAllowed] Action<NSError> onComplete);
	}

	// @interface MapboxMapObjC_Swift_4322 (TMBStyle)
	[Category]
	[BaseType (typeof(TMBStyle))]
	interface TMBStyle_MapboxMapObjC_Swift_4322
	{
		// -(void)setProjection:(TMBStyleProjection * _Nonnull)projection completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setProjection:completion:")]
		void SetProjection (TMBStyleProjection projection, [NullAllowed] Action<NSError> completion);

		// @property (readonly, nonatomic, strong) TMBStyleProjection * _Nonnull projection;
		[Export ("projection", ArgumentSemantic.Strong)]
		TMBStyleProjection Projection { get; }
	}

	// @interface TMBStyleProjection : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBStyleProjection")]
	[DisableDefaultCtor]
	interface TMBStyleProjection
	{
		// @property (nonatomic, strong) TMBStyleProjectionName * _Nonnull name;
		[Export ("name", ArgumentSemantic.Strong)]
		TMBStyleProjectionName Name { get; set; }

		// -(instancetype _Nonnull)initWithName:(TMBStyleProjectionName * _Nonnull)name __attribute__((objc_designated_initializer));
		[Export ("initWithName:")]
		[DesignatedInitializer]
		IntPtr Constructor (TMBStyleProjectionName name);
	}

	// @interface TMBStyleProjectionName : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC22TMBStyleProjectionName")]
	[DisableDefaultCtor]
	interface TMBStyleProjectionName : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBStyleProjectionName * _Nonnull mercator;
		[Static]
		[Export ("mercator", ArgumentSemantic.Strong)]
		TMBStyleProjectionName Mercator { get; }

		// @property (readonly, nonatomic, strong, class) TMBStyleProjectionName * _Nonnull globe;
		[Static]
		[Export ("globe", ArgumentSemantic.Strong)]
		TMBStyleProjectionName Globe { get; }
	}

	// @interface TMBStyleTransition : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBStyleTransition")]
	[DisableDefaultCtor]
	interface TMBStyleTransition
	{
		// @property (nonatomic) double duration;
		[Export ("duration")]
		double Duration { get; set; }

		// @property (nonatomic) double delay;
		[Export ("delay")]
		double Delay { get; set; }

		// -(instancetype _Nonnull)initWithDuration:(double)duration delay:(double)delay __attribute__((objc_designated_initializer));
		[Export ("initWithDuration:delay:")]
		[DesignatedInitializer]
		IntPtr Constructor (double duration, double delay);

		// @property (readonly, nonatomic, strong, class) TMBStyleTransition * _Nonnull zero;
		[Static]
		[Export ("zero", ArgumentSemantic.Strong)]
		TMBStyleTransition Zero { get; }
	}

	// @interface TMBSymbolPlacement : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBSymbolPlacement")]
	[DisableDefaultCtor]
	interface TMBSymbolPlacement : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBSymbolPlacement * _Nonnull point;
		[Static]
		[Export ("point", ArgumentSemantic.Strong)]
		TMBSymbolPlacement Point { get; }

		// @property (readonly, nonatomic, strong, class) TMBSymbolPlacement * _Nonnull line;
		[Static]
		[Export ("line", ArgumentSemantic.Strong)]
		TMBSymbolPlacement Line { get; }

		// @property (readonly, nonatomic, strong, class) TMBSymbolPlacement * _Nonnull lineCenter;
		[Static]
		[Export ("lineCenter", ArgumentSemantic.Strong)]
		TMBSymbolPlacement LineCenter { get; }
	}

	// @interface TMBSymbolZOrder : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC15TMBSymbolZOrder")]
	[DisableDefaultCtor]
	interface TMBSymbolZOrder : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, getter = auto, nonatomic, strong, class) TMBSymbolZOrder * _Nonnull auto_;
		[Static]
		[Export ("auto_", ArgumentSemantic.Strong)]
		TMBSymbolZOrder Auto { [Bind ("auto")] get; }

		// @property (readonly, nonatomic, strong, class) TMBSymbolZOrder * _Nonnull viewportY;
		[Static]
		[Export ("viewportY", ArgumentSemantic.Strong)]
		TMBSymbolZOrder ViewportY { get; }

		// @property (readonly, nonatomic, strong, class) TMBSymbolZOrder * _Nonnull source;
		[Static]
		[Export ("source", ArgumentSemantic.Strong)]
		TMBSymbolZOrder Source { get; }
	}

	// @interface TMBTerrain : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC10TMBTerrain")]
	[DisableDefaultCtor]
	interface TMBTerrain
	{
		// @property (copy, nonatomic) NSString * _Nonnull sourceId;
		[Export ("sourceId")]
		string SourceId { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable exaggeration;
		[NullAllowed, Export ("exaggeration", ArgumentSemantic.Strong)]
		TMBValue Exaggeration { get; set; }

		// -(instancetype _Nonnull)initWithSourceId:(NSString * _Nonnull)sourceId __attribute__((objc_designated_initializer));
		[Export ("initWithSourceId:")]
		[DesignatedInitializer]
		IntPtr Constructor (string sourceId);
	}

	// @interface TMBTextAnchor : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13TMBTextAnchor")]
	[DisableDefaultCtor]
	interface TMBTextAnchor : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextAnchor * _Nonnull center;
		[Static]
		[Export ("center", ArgumentSemantic.Strong)]
		TMBTextAnchor Center { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextAnchor * _Nonnull left;
		[Static]
		[Export ("left", ArgumentSemantic.Strong)]
		TMBTextAnchor Left { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextAnchor * _Nonnull right;
		[Static]
		[Export ("right", ArgumentSemantic.Strong)]
		TMBTextAnchor Right { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextAnchor * _Nonnull top;
		[Static]
		[Export ("top", ArgumentSemantic.Strong)]
		TMBTextAnchor Top { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextAnchor * _Nonnull bottom;
		[Static]
		[Export ("bottom", ArgumentSemantic.Strong)]
		TMBTextAnchor Bottom { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextAnchor * _Nonnull topLeft;
		[Static]
		[Export ("topLeft", ArgumentSemantic.Strong)]
		TMBTextAnchor TopLeft { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextAnchor * _Nonnull topRight;
		[Static]
		[Export ("topRight", ArgumentSemantic.Strong)]
		TMBTextAnchor TopRight { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextAnchor * _Nonnull bottomLeft;
		[Static]
		[Export ("bottomLeft", ArgumentSemantic.Strong)]
		TMBTextAnchor BottomLeft { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextAnchor * _Nonnull bottomRight;
		[Static]
		[Export ("bottomRight", ArgumentSemantic.Strong)]
		TMBTextAnchor BottomRight { get; }
	}

	// @interface TMBTextJustify : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC14TMBTextJustify")]
	[DisableDefaultCtor]
	interface TMBTextJustify : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, getter = auto, nonatomic, strong, class) TMBTextJustify * _Nonnull auto_;
		[Static]
		[Export ("auto_", ArgumentSemantic.Strong)]
		TMBTextJustify Auto { [Bind ("auto")] get; }

		// @property (readonly, nonatomic, strong, class) TMBTextJustify * _Nonnull left;
		[Static]
		[Export ("left", ArgumentSemantic.Strong)]
		TMBTextJustify Left { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextJustify * _Nonnull center;
		[Static]
		[Export ("center", ArgumentSemantic.Strong)]
		TMBTextJustify Center { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextJustify * _Nonnull right;
		[Static]
		[Export ("right", ArgumentSemantic.Strong)]
		TMBTextJustify Right { get; }
	}

	// @interface TMBTextPitchAlignment : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC21TMBTextPitchAlignment")]
	[DisableDefaultCtor]
	interface TMBTextPitchAlignment : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextPitchAlignment * _Nonnull map;
		[Static]
		[Export ("map", ArgumentSemantic.Strong)]
		TMBTextPitchAlignment Map { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextPitchAlignment * _Nonnull viewport;
		[Static]
		[Export ("viewport", ArgumentSemantic.Strong)]
		TMBTextPitchAlignment Viewport { get; }

		// @property (readonly, getter = auto, nonatomic, strong, class) TMBTextPitchAlignment * _Nonnull auto_;
		[Static]
		[Export ("auto_", ArgumentSemantic.Strong)]
		TMBTextPitchAlignment Auto { [Bind ("auto")] get; }
	}

	// @interface TMBTextRotationAlignment : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC24TMBTextRotationAlignment")]
	[DisableDefaultCtor]
	interface TMBTextRotationAlignment : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextRotationAlignment * _Nonnull map;
		[Static]
		[Export ("map", ArgumentSemantic.Strong)]
		TMBTextRotationAlignment Map { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextRotationAlignment * _Nonnull viewport;
		[Static]
		[Export ("viewport", ArgumentSemantic.Strong)]
		TMBTextRotationAlignment Viewport { get; }

		// @property (readonly, getter = auto, nonatomic, strong, class) TMBTextRotationAlignment * _Nonnull auto_;
		[Static]
		[Export ("auto_", ArgumentSemantic.Strong)]
		TMBTextRotationAlignment Auto { [Bind ("auto")] get; }
	}

	// @interface TMBTextTransform : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC16TMBTextTransform")]
	[DisableDefaultCtor]
	interface TMBTextTransform : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		[Verify (MethodToProperty)]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextTransform * _Nonnull none;
		[Static]
		[Export ("none", ArgumentSemantic.Strong)]
		TMBTextTransform None { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextTransform * _Nonnull uppercase;
		[Static]
		[Export ("uppercase", ArgumentSemantic.Strong)]
		TMBTextTransform Uppercase { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextTransform * _Nonnull lowercase;
		[Static]
		[Export ("lowercase", ArgumentSemantic.Strong)]
		TMBTextTransform Lowercase { get; }
	}

	// @interface TMBTextTranslateAnchor : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC22TMBTextTranslateAnchor")]
	[DisableDefaultCtor]
	interface TMBTextTranslateAnchor : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextTranslateAnchor * _Nonnull map;
		[Static]
		[Export ("map", ArgumentSemantic.Strong)]
		TMBTextTranslateAnchor Map { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextTranslateAnchor * _Nonnull viewport;
		[Static]
		[Export ("viewport", ArgumentSemantic.Strong)]
		TMBTextTranslateAnchor Viewport { get; }
	}

	// @interface TMBTextWritingMode : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBTextWritingMode")]
	[DisableDefaultCtor]
	interface TMBTextWritingMode : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextWritingMode * _Nonnull horizontal;
		[Static]
		[Export ("horizontal", ArgumentSemantic.Strong)]
		TMBTextWritingMode Horizontal { get; }

		// @property (readonly, nonatomic, strong, class) TMBTextWritingMode * _Nonnull vertical;
		[Static]
		[Export ("vertical", ArgumentSemantic.Strong)]
		TMBTextWritingMode Vertical { get; }
	}

	// @interface TMBValue : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC8TMBValue")]
	[DisableDefaultCtor]
	interface TMBValue
	{
		// -(instancetype _Nonnull)initWithConstant:(NSObject * _Nonnull)constant __attribute__((objc_designated_initializer));
		[Export ("initWithConstant:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject constant);

		// -(instancetype _Nonnull)initWithExpression:(TMBExpression * _Nonnull)expression __attribute__((objc_designated_initializer));
		[Export ("initWithExpression:")]
		[DesignatedInitializer]
		IntPtr Constructor (TMBExpression expression);

		// +(TMBValue * _Nonnull)constant:(NSObject * _Nonnull)constant __attribute__((warn_unused_result("")));
		[Static]
		[Export ("constant:")]
		TMBValue Constant (NSObject constant);

		// +(TMBValue * _Nonnull)intValue:(NSInteger)value __attribute__((warn_unused_result("")));
		[Static]
		[Export ("intValue:")]
		TMBValue IntValue (nint value);

		// +(TMBValue * _Nonnull)doubleValue:(double)value __attribute__((warn_unused_result("")));
		[Static]
		[Export ("doubleValue:")]
		TMBValue DoubleValue (double value);

		// +(TMBValue * _Nonnull)expression:(TMBExpression * _Nonnull)expression __attribute__((warn_unused_result("")));
		[Static]
		[Export ("expression:")]
		TMBValue Expression (TMBExpression expression);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export ("debugDescription")]
		string DebugDescription { get; }
	}

	// @interface TMBViewAnnotationManager : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC24TMBViewAnnotationManager")]
	[DisableDefaultCtor]
	interface TMBViewAnnotationManager
	{
		// -(MBMViewAnnotationOptions * _Nullable)optionsForAnnotationId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("optionsForAnnotationId:")]
		[return: NullAllowed]
		MBMViewAnnotationOptions OptionsForAnnotationId (string id);

		// -(MBMViewAnnotationOptions * _Nullable)optionsForAnnotationView:(UIView * _Nonnull)view __attribute__((warn_unused_result("")));
		[Export ("optionsForAnnotationView:")]
		[return: NullAllowed]
		MBMViewAnnotationOptions OptionsForAnnotationView (UIView view);

		// -(UIView * _Nullable)viewForAnnotationId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("viewForAnnotationId:")]
		[return: NullAllowed]
		UIView ViewForAnnotationId (string id);

		// -(UIView * _Nullable)viewForAnnotationFeatureId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("viewForAnnotationFeatureId:")]
		[return: NullAllowed]
		UIView ViewForAnnotationFeatureId (string id);

		// -(MBMViewAnnotationOptions * _Nullable)optionsForAnnotationFeatureId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("optionsForAnnotationFeatureId:")]
		[return: NullAllowed]
		MBMViewAnnotationOptions OptionsForAnnotationFeatureId (string id);

		// -(void)addWithViewAnnotation:(UIView * _Nonnull)viewAnnotation id:(NSString * _Nullable)id options:(MBMViewAnnotationOptions * _Nonnull)options completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addWithViewAnnotation:id:options:completion:")]
		void AddWithViewAnnotation (UIView viewAnnotation, [NullAllowed] string id, MBMViewAnnotationOptions options, [NullAllowed] Action<NSError> completion);

		// -(void)updateWithViewAnnotation:(UIView * _Nonnull)viewAnnotation options:(MBMViewAnnotationOptions * _Nonnull)options completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("updateWithViewAnnotation:options:completion:")]
		void UpdateWithViewAnnotation (UIView viewAnnotation, MBMViewAnnotationOptions options, [NullAllowed] Action<NSError> completion);

		// -(void)removeWithViewAnnotation:(UIView * _Nonnull)viewAnnotation;
		[Export ("removeWithViewAnnotation:")]
		void RemoveWithViewAnnotation (UIView viewAnnotation);

		// -(void)removeAllViewAnnotations;
		[Export ("removeAllViewAnnotations")]
		void RemoveAllViewAnnotations ();

		// -(void)addViewAnnotationUpdateObserver:(id<TMBViewAnnotationUpdateObserver> _Nonnull)observer;
		[Export ("addViewAnnotationUpdateObserver:")]
		void AddViewAnnotationUpdateObserver (TMBViewAnnotationUpdateObserver observer);

		// -(void)removeViewAnnotationUpdateObserver:(id<TMBViewAnnotationUpdateObserver> _Nonnull)observer;
		[Export ("removeViewAnnotationUpdateObserver:")]
		void RemoveViewAnnotationUpdateObserver (TMBViewAnnotationUpdateObserver observer);

		// -(MBMCameraOptions * _Nullable)cameraForAnnotations:(NSArray<NSString *> * _Nonnull)identifiers padding:(UIEdgeInsets)padding bearing:(NSNumber * _Nullable)bearing pitch:(NSNumber * _Nullable)pitch __attribute__((warn_unused_result("")));
		[Export ("cameraForAnnotations:padding:bearing:pitch:")]
		[return: NullAllowed]
		MBMCameraOptions CameraForAnnotations (string[] identifiers, UIEdgeInsets padding, [NullAllowed] NSNumber bearing, [NullAllowed] NSNumber pitch);
	}

	// @protocol TMBViewAnnotationUpdateObserver
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	partial interface ITMBViewAnnotationUpdateObserver {}

	[Protocol (Name = "_TtP13MapboxMapObjC31TMBViewAnnotationUpdateObserver_")]
	interface TMBViewAnnotationUpdateObserver
	{
		// @required -(void)framesDidChangeFor:(NSArray<UIView *> * _Nonnull)annotationViews;
		[Abstract]
		[Export ("framesDidChangeFor:")]
		void FramesDidChangeFor (UIView[] annotationViews);

		// @required -(void)visibilityDidChangeFor:(NSArray<UIView *> * _Nonnull)annotationViews;
		[Abstract]
		[Export ("visibilityDidChangeFor:")]
		void VisibilityDidChangeFor (UIView[] annotationViews);
	}

	// @interface TMBViewport : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC11TMBViewport")]
	[DisableDefaultCtor]
	interface TMBViewport
	{
		// @property (nonatomic, strong) TMBViewportOptions * _Nonnull options;
		[Export ("options", ArgumentSemantic.Strong)]
		TMBViewportOptions Options { get; set; }

		// @property (readonly, nonatomic, strong) TMBViewportStatus * _Nonnull status;
		[Export ("status", ArgumentSemantic.Strong)]
		TMBViewportStatus Status { get; }

		// -(void)addStatusObserver:(id<TMBViewportStatusObserver> _Nonnull)observer;
		[Export ("addStatusObserver:")]
		void AddStatusObserver (TMBViewportStatusObserver observer);

		// -(void)removeStatusObserver:(id<TMBViewportStatusObserver> _Nonnull)observer;
		[Export ("removeStatusObserver:")]
		void RemoveStatusObserver (TMBViewportStatusObserver observer);

		// -(void)idle;
		[Export ("idle")]
		void Idle ();

		// -(void)transitionTo:(id<TMBViewportState> _Nonnull)toState transition:(id<TMBViewportTransition> _Nullable)transition completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("transitionTo:transition:completion:")]
		void TransitionTo (TMBViewportState toState, [NullAllowed] TMBViewportTransition transition, [NullAllowed] Action<bool> completion);

		// @property (nonatomic, strong) id<TMBViewportTransition> _Nonnull defaultTransition;
		[Export ("defaultTransition", ArgumentSemantic.Strong)]
		TMBViewportTransition DefaultTransition { get; set; }

		// -(TMBFollowPuckViewportState * _Nonnull)makeFollowPuckViewportStateWithOptions:(TMBFollowPuckViewportStateOptions * _Nullable)options __attribute__((warn_unused_result("")));
		[Export ("makeFollowPuckViewportStateWithOptions:")]
		TMBFollowPuckViewportState MakeFollowPuckViewportStateWithOptions ([NullAllowed] TMBFollowPuckViewportStateOptions options);

		// -(TMBOverviewViewportState * _Nonnull)makeOverviewViewportStateWithOptions:(TMBOverviewViewportStateOptions * _Nonnull)options __attribute__((warn_unused_result("")));
		[Export ("makeOverviewViewportStateWithOptions:")]
		TMBOverviewViewportState MakeOverviewViewportStateWithOptions (TMBOverviewViewportStateOptions options);

		// -(TMBDefaultViewportTransition * _Nonnull)makeDefaultViewportTransitionWithOptions:(TMBDefaultViewportTransitionOptions * _Nullable)options __attribute__((warn_unused_result("")));
		[Export ("makeDefaultViewportTransitionWithOptions:")]
		TMBDefaultViewportTransition MakeDefaultViewportTransitionWithOptions ([NullAllowed] TMBDefaultViewportTransitionOptions options);

		// -(TMBImmediateViewportTransition * _Nonnull)makeImmediateViewportTransition __attribute__((warn_unused_result("")));
		[Export ("makeImmediateViewportTransition")]
		[Verify (MethodToProperty)]
		TMBImmediateViewportTransition MakeImmediateViewportTransition { get; }
	}

	// @interface TMBViewportOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBViewportOptions")]
	[DisableDefaultCtor]
	interface TMBViewportOptions
	{
		// @property (nonatomic) BOOL transitionsToIdleUponUserInteraction;
		[Export ("transitionsToIdleUponUserInteraction")]
		bool TransitionsToIdleUponUserInteraction { get; set; }

		// -(instancetype _Nonnull)initWithTransitionsToIdleUponUserInteraction:(BOOL)transitionsToIdleUponUserInteraction __attribute__((objc_designated_initializer));
		[Export ("initWithTransitionsToIdleUponUserInteraction:")]
		[DesignatedInitializer]
		IntPtr Constructor (bool transitionsToIdleUponUserInteraction);
	}

	// @interface TMBViewportStatus : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC17TMBViewportStatus")]
	[DisableDefaultCtor]
	interface TMBViewportStatus
	{
		// @property (readonly, nonatomic, strong, class) TMBViewportStatus * _Nonnull idle;
		[Static]
		[Export ("idle", ArgumentSemantic.Strong)]
		TMBViewportStatus Idle { get; }

		// +(TMBViewportStatus * _Nonnull)state:(id<TMBViewportState> _Nonnull)state __attribute__((warn_unused_result("")));
		[Static]
		[Export ("state:")]
		TMBViewportStatus State (TMBViewportState state);

		// +(TMBViewportStatus * _Nonnull)transition:(id<TMBViewportTransition> _Nonnull)transition toState:(id<TMBViewportState> _Nonnull)toState __attribute__((warn_unused_result("")));
		[Static]
		[Export ("transition:toState:")]
		TMBViewportStatus Transition (TMBViewportTransition transition, TMBViewportState toState);
	}

	// @interface TMBViewportStatusChangeReason : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC29TMBViewportStatusChangeReason")]
	[DisableDefaultCtor]
	interface TMBViewportStatusChangeReason : NamedString
	{
		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		[Verify (MethodToProperty)]
		string StringValue { get; }
	}

	// @protocol TMBViewportStatusObserver
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	partial nterface ITMBViewportStatusObserver {}

	[Protocol (Name = "_TtP13MapboxMapObjC25TMBViewportStatusObserver_"), Model]
	[BaseType(typeof(NSObject))]
	interface TMBViewportStatusObserver
	{
		// @required -(void)viewportStatusDidChangeFrom:(TMBViewportStatus * _Nonnull)fromStatus to:(TMBViewportStatus * _Nonnull)toStatus reason:(TMBViewportStatusChangeReason * _Nonnull)reason;
		[Abstract]
		[Export ("viewportStatusDidChangeFrom:to:reason:")]
		void ViewportStatusDidChangeFrom (TMBViewportStatus fromStatus, TMBViewportStatus toStatus, TMBViewportStatusChangeReason reason);
	}

	// @interface TMBVisibility : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13TMBVisibility")]
	[DisableDefaultCtor]
	interface TMBVisibility : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic, strong, class) TMBVisibility * _Nonnull visible;
		[Static]
		[Export ("visible", ArgumentSemantic.Strong)]
		TMBVisibility Visible { get; }

		// @property (readonly, nonatomic, strong, class) TMBVisibility * _Nonnull none;
		[Static]
		[Export ("none", ArgumentSemantic.Strong)]
		TMBVisibility None { get; }
	}

	// @interface MapboxMapObjC_Swift_4847
    [Category]
    [BaseType(typeof(MBXTileStore))]
	interface MapboxMapObjC_Swift_4847
	{
		// +(id)getDefault __attribute__((warn_unused_result("")));
		[Static]
		[Export ("getDefault")]
		MBXTileStore GetDefault();

		// -(TMBCancelable * _Nonnull)loadTileRegionForId:(NSString * _Nonnull)id loadOptions:(MBXTileRegionLoadOptions * _Nonnull)loadOptions progress:(id)progress completion:(void (^ _Nonnull)(MBXTileRegion * _Nullable, NSError * _Nullable))completion;
		[Export ("loadTileRegionForId:loadOptions:progress:completion:")]
		TMBCancelable LoadTileRegionForId (string id, MBXTileRegionLoadOptions loadOptions, Action<MBXTileRegionLoadProgress> progress, Action<MBXTileRegion, NSError> completion);

		// -(void)allTileRegions:(void (^ _Nonnull)(NSArray<MBXTileRegion *> * _Nullable, NSError * _Nullable))completion;
		[Export ("allTileRegions:")]
		void AllTileRegions (Action<NSArray<MBXTileRegion>, NSError> completion);
	}
}
