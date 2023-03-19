using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using MapboxCoreMaps;
using MapboxMaps;

namespace MapboxMapsObjC
{
	// @interface FillExtrusionLayerBuilder : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC25FillExtrusionLayerBuilder")]
	[DisableDefaultCtor]
	interface FillExtrusionLayerBuilder
	{
		// -(void)filter:(MBXExpression * _Nullable)value;
		[Export ("filter:")]
		void Filter ([NullAllowed] MBXExpression value);

		// -(void)source:(NSString * _Nullable)value;
		[Export ("source:")]
		void Source ([NullAllowed] string value);

		// -(void)sourceLayer:(NSString * _Nullable)value;
		[Export ("sourceLayer:")]
		void SourceLayer ([NullAllowed] string value);

		// -(void)minZoom:(NSNumber * _Nullable)value;
		[Export ("minZoom:")]
		void MinZoom ([NullAllowed] NSNumber value);

		// -(void)maxZoom:(NSNumber * _Nullable)value;
		[Export ("maxZoom:")]
		void MaxZoom ([NullAllowed] NSNumber value);

		// -(void)visibility:(MBXValue * _Nullable)value;
		[Export ("visibility:")]
		void Visibility ([NullAllowed] MBXValue value);

		// -(void)fillExtrusionAmbientOcclusionIntensity:(MBXValue * _Nullable)value;
		[Export ("fillExtrusionAmbientOcclusionIntensity:")]
		void FillExtrusionAmbientOcclusionIntensity ([NullAllowed] MBXValue value);

		// -(void)fillExtrusionAmbientOcclusionIntensityTransition:(MBXStyleTransition * _Nullable)value;
		[Export ("fillExtrusionAmbientOcclusionIntensityTransition:")]
		void FillExtrusionAmbientOcclusionIntensityTransition ([NullAllowed] MBXStyleTransition value);

		// -(void)fillExtrusionAmbientOcclusionRadius:(MBXValue * _Nullable)value;
		[Export ("fillExtrusionAmbientOcclusionRadius:")]
		void FillExtrusionAmbientOcclusionRadius ([NullAllowed] MBXValue value);

		// -(void)fillExtrusionAmbientOcclusionRadiusTransition:(MBXStyleTransition * _Nullable)value;
		[Export ("fillExtrusionAmbientOcclusionRadiusTransition:")]
		void FillExtrusionAmbientOcclusionRadiusTransition ([NullAllowed] MBXStyleTransition value);

		// -(void)fillExtrusionBase:(MBXValue * _Nullable)value;
		[Export ("fillExtrusionBase:")]
		void FillExtrusionBase ([NullAllowed] MBXValue value);

		// -(void)fillExtrusionBaseTransition:(MBXStyleTransition * _Nullable)value;
		[Export ("fillExtrusionBaseTransition:")]
		void FillExtrusionBaseTransition ([NullAllowed] MBXStyleTransition value);

		// -(void)fillExtrusionColor:(MBXValue * _Nullable)value;
		[Export ("fillExtrusionColor:")]
		void FillExtrusionColor ([NullAllowed] MBXValue value);

		// -(void)fillExtrusionColorTransition:(MBXStyleTransition * _Nullable)value;
		[Export ("fillExtrusionColorTransition:")]
		void FillExtrusionColorTransition ([NullAllowed] MBXStyleTransition value);

		// -(void)fillExtrusionHeight:(MBXValue * _Nullable)value;
		[Export ("fillExtrusionHeight:")]
		void FillExtrusionHeight ([NullAllowed] MBXValue value);

		// -(void)fillExtrusionHeightTransition:(MBXStyleTransition * _Nullable)value;
		[Export ("fillExtrusionHeightTransition:")]
		void FillExtrusionHeightTransition ([NullAllowed] MBXStyleTransition value);

		// -(void)fillExtrusionOpacity:(MBXValue * _Nullable)value;
		[Export ("fillExtrusionOpacity:")]
		void FillExtrusionOpacity ([NullAllowed] MBXValue value);

		// -(void)fillExtrusionOpacityTransition:(MBXStyleTransition * _Nullable)value;
		[Export ("fillExtrusionOpacityTransition:")]
		void FillExtrusionOpacityTransition ([NullAllowed] MBXStyleTransition value);

		// -(void)fillExtrusionPattern:(MBXValue * _Nullable)value;
		[Export ("fillExtrusionPattern:")]
		void FillExtrusionPattern ([NullAllowed] MBXValue value);

		// -(void)fillExtrusionPatternTransition:(MBXStyleTransition * _Nullable)value;
		[Export ("fillExtrusionPatternTransition:")]
		void FillExtrusionPatternTransition ([NullAllowed] MBXStyleTransition value);

		// -(void)fillExtrusionTranslate:(MBXValue * _Nullable)value;
		[Export ("fillExtrusionTranslate:")]
		void FillExtrusionTranslate ([NullAllowed] MBXValue value);

		// -(void)fillExtrusionTranslateTransition:(MBXStyleTransition * _Nullable)value;
		[Export ("fillExtrusionTranslateTransition:")]
		void FillExtrusionTranslateTransition ([NullAllowed] MBXStyleTransition value);

		// -(void)fillExtrusionTranslateAnchor:(MBXValue * _Nonnull)value;
		[Export ("fillExtrusionTranslateAnchor:")]
		void FillExtrusionTranslateAnchor (MBXValue value);

		// -(void)fillExtrusionVerticalGradient:(MBXValue * _Nullable)value;
		[Export ("fillExtrusionVerticalGradient:")]
		void FillExtrusionVerticalGradient ([NullAllowed] MBXValue value);
	}

	// @interface MBXCancelable : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13MBXCancelable")]
	[DisableDefaultCtor]
	interface MBXCancelable
	{
	}

	// @interface MBXExpression : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13MBXExpression")]
	[DisableDefaultCtor]
	interface MBXExpression
	{
		// +(MBXExpression * _Nonnull)createWithOperator:(enum MBXOperator)operator_ __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithOperator:")]
		MBXExpression CreateWithOperator (MBXOperator operator_);

		// +(MBXExpression * _Nonnull)createWithOperator:(enum MBXOperator)operator_ arguments:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithOperator:arguments:")]
		MBXExpression CreateWithOperator (MBXOperator operator_, NSObject[] arguments);
	}

	// @interface MBXResolvedImage : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC16MBXResolvedImage")]
	[DisableDefaultCtor]
	interface MBXResolvedImage
	{
	}

	// @interface MBXResolvedImageData : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC20MBXResolvedImageData")]
	[DisableDefaultCtor]
	interface MBXResolvedImageData
	{
	}

	// @interface MBXStyleTransition : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18MBXStyleTransition")]
	[DisableDefaultCtor]
	interface MBXStyleTransition
	{
		// -(instancetype _Nonnull)initWithDuration:(double)duration delay:(double)delay __attribute__((objc_designated_initializer));
		[Export ("initWithDuration:delay:")]
		[DesignatedInitializer]
		IntPtr Constructor (double duration, double delay);
	}

	// @interface MBXTerrain : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC10MBXTerrain")]
	[DisableDefaultCtor]
	interface MBXTerrain
	{
		// -(instancetype _Nonnull)initWithSourceId:(NSString * _Nonnull)sourceId __attribute__((objc_designated_initializer));
		[Export ("initWithSourceId:")]
		[DesignatedInitializer]
		IntPtr Constructor (string sourceId);

		// @property (nonatomic, strong) MBXValue * _Nullable exaggeration;
		[NullAllowed, Export ("exaggeration", ArgumentSemantic.Strong)]
		MBXValue Exaggeration { get; set; }
	}

	// @interface MBXValue : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC8MBXValue")]
	[DisableDefaultCtor]
	interface MBXValue
	{
		// -(instancetype _Nonnull)initWithConstant:(NSObject * _Nonnull)constant __attribute__((objc_designated_initializer));
		[Export ("initWithConstant:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject constant);

		// -(instancetype _Nonnull)initWithExpression:(MBXExpression * _Nonnull)expression __attribute__((objc_designated_initializer));
		[Export ("initWithExpression:")]
		[DesignatedInitializer]
		IntPtr Constructor (MBXExpression expression);

		// +(MBXValue * _Nonnull)constant:(NSObject * _Nonnull)constant __attribute__((warn_unused_result("")));
		[Static]
		[Export ("constant:")]
		MBXValue Constant (NSObject constant);

		// +(MBXValue * _Nonnull)expression:(MBXExpression * _Nonnull)expression __attribute__((warn_unused_result("")));
		[Static]
		[Export ("expression:")]
		MBXValue Expression (MBXExpression expression);
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
		[Export("create")]
		MapInitOptionsBuilder Create();

		// -(MapInitOptions * _Nonnull)build __attribute__((warn_unused_result("")));
		[Export("build")]
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

		// -(MapInitOptionsBuilder * _Nonnull)styleStreets __attribute__((warn_unused_result("")));
		[Export ("styleStreets")]
		MapInitOptionsBuilder StyleStreets();

        // -(MapInitOptionsBuilder * _Nonnull)styleOutdoors __attribute__((warn_unused_result("")));
        [Export ("styleOutdoors")]
		MapInitOptionsBuilder StyleOutdoors();

        // -(MapInitOptionsBuilder * _Nonnull)styleLight __attribute__((warn_unused_result("")));
        [Export ("styleLight")]
		MapInitOptionsBuilder StyleLight();

        // -(MapInitOptionsBuilder * _Nonnull)styleDark __attribute__((warn_unused_result("")));
        [Export ("styleDark")]
		MapInitOptionsBuilder StyleDark();

        // -(MapInitOptionsBuilder * _Nonnull)styleSatellite __attribute__((warn_unused_result("")));
        [Export ("styleSatellite")]
		MapInitOptionsBuilder StyleSatellite();

        // -(MapInitOptionsBuilder * _Nonnull)styleSatelliteStreets __attribute__((warn_unused_result("")));
        [Export("styleSatelliteStreets")]
		MapInitOptionsBuilder StyleSatelliteStreets();
	}

	// @interface MapboxMapObjC_Swift_930
	[Category]
	[BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_930
	{
		// -(void)setTerrain:(MBXTerrain * _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("setTerrain:onError:")]
		void SetTerrain (MBXTerrain value, [NullAllowed] Action<NSError> onError);
	}

    // @interface MapboxMapObjC_Swift_935
    [Category]
    [BaseType(typeof(MapView))]
    interface MapboxMapObjC_Swift_935
	{
		// -(void)addFillExtrusionLayer:(NSString * _Nonnull)id configure:(void (^ _Nonnull)(FillExtrusionLayerBuilder * _Nonnull))configure onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addFillExtrusionLayer:configure:onError:")]
		void AddFillExtrusionLayer (string id, Action<FillExtrusionLayerBuilder> configure, [NullAllowed] Action<NSError> onError);
	}

    // @interface MapboxMapObjC_Swift_940
    [Category]
    [BaseType(typeof(MapView))]
    interface MapboxMapObjC_Swift_940
	{
		// -(void)setCameraTo:(MBMCameraOptions * _Nonnull)cameraOptions;
		[Export ("setCameraTo:")]
		void SetCameraTo (MBMCameraOptions cameraOptions);
	}

    // @interface MapboxMapObjC_Swift_946
    [Category]
    [BaseType(typeof(MapView))]
    interface MapboxMapObjC_Swift_946
	{
		// -(void)addRasterDemSource:(NSString * _Nonnull)id configure:(void (^ _Nonnull)(RasterDemSourceBuilder * _Nonnull))configure onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addRasterDemSource:configure:onError:")]
		void AddRasterDemSource (string id, Action<RasterDemSourceBuilder> configure, [NullAllowed] Action<NSError> onError);
	}

	// @interface MapboxMapObjC_Swift_951
	[Category]
	[BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_951
	{
		// -(void)ornamentsOptionsScaleBarVisibility:(enum MBXOrnamentVisibility)value;
		[Export ("ornamentsOptionsScaleBarVisibility:")]
		void OrnamentsOptionsScaleBarVisibility (MBXOrnamentVisibility value);
	}

    // @interface MapboxMapObjC_Swift_957
    [Category]
    [BaseType(typeof(MapView))]
    interface MapboxMapObjC_Swift_957
	{
		// -(void)addSkyLayer:(NSString * _Nonnull)id configure:(void (^ _Nonnull)(SkyLayerBuilder * _Nonnull))configure onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addSkyLayer:configure:onError:")]
		void AddSkyLayer (string id, Action<SkyLayerBuilder> configure, [NullAllowed] Action<NSError> onError);
	}

    // @interface MapboxMapObjC_Swift_962
    [Category]
    [BaseType(typeof(MapView))]
    interface MapboxMapObjC_Swift_962
	{
		// -(void)preferredFrameRateRange:(CAFrameRateRange)value;
		[Export ("preferredFrameRateRange:")]
		void PreferredFrameRateRange (CAFrameRateRange value);

		// -(NSArray<NSNumber *> * _Nonnull)mapboxMapDebugOptions __attribute__((warn_unused_result("")));
		[Export("mapboxMapDebugOptions")]
		NSNumber[] MapboxMapDebugOptions();

		// -(void)mapboxMapDebugOptions:(NSArray<NSNumber *> * _Nonnull)value;
		[Export ("mapboxMapDebugOptions:")]
		void MapboxMapDebugOptions (NSNumber[] value);
	}

    // @interface MapboxMapObjC_Swift_971
    [Category]
    [BaseType(typeof(MapView))]
    interface MapboxMapObjC_Swift_971
	{
		// -(void)locationDelegate:(id<LocationPermissionsDelegate> _Nonnull)delegate;
		[Export ("locationDelegate:")]
		void LocationDelegate (ILocationPermissionsDelegate @delegate);

		// -(void)locationRequestTemporaryFullAccuracyPermissions:(NSString * _Nonnull)customKey;
		[Export ("locationRequestTemporaryFullAccuracyPermissions:")]
		void LocationRequestTemporaryFullAccuracyPermissions (string customKey);

		// -(void)puck2D:(void (^ _Nullable)(Puck2DConfigurationBuilder * _Nonnull))build;
		[Export ("puck2D:")]
		void Puck2D ([NullAllowed] Action<Puck2DConfigurationBuilder> build);

		// -(void)puckBearingSource:(enum MBXPuckBearingSource)source;
		[Export ("puckBearingSource:")]
		void PuckBearingSource (MBXPuckBearingSource source);
	}

    // @interface MapboxMapObjC_Swift_981
    [Category]
    [BaseType(typeof(MapView))]
    interface MapboxMapObjC_Swift_981
	{
		// -(void)addCustomLayer:(NSString * _Nonnull)id layerHost:(id<MBMCustomLayerHost> _Nonnull)layerHost below:(NSString * _Nonnull)belowLayerId onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addCustomLayer:layerHost:below:onError:")]
		void AddCustomLayerBelow (string id, MBMCustomLayerHost layerHost, string belowLayerId, [NullAllowed] Action<NSError> onError);

		// -(void)addCustomLayer:(NSString * _Nonnull)id layerHost:(id<MBMCustomLayerHost> _Nonnull)layerHost above:(NSString * _Nonnull)aboveLayerId onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addCustomLayer:layerHost:above:onError:")]
		void AddCustomLayerAbove (string id, MBMCustomLayerHost layerHost, string aboveLayerId, [NullAllowed] Action<NSError> onError);

		// -(void)addCustomLayer:(NSString * _Nonnull)id layerHost:(id<MBMCustomLayerHost> _Nonnull)layerHost at:(NSInteger)index onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addCustomLayer:layerHost:at:onError:")]
		void AddCustomLayerAt (string id, MBMCustomLayerHost layerHost, nint index, [NullAllowed] Action<NSError> onError);

		// -(void)addLayerBelowWithProperties:(NSDictionary * _Nonnull)properties layerId:(NSString * _Nonnull)layerId onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addLayerBelowWithProperties:layerId:onError:")]
		void AddLayerBelowWithProperties (NSDictionary properties, string layerId, [NullAllowed] Action<NSError> onError);

		// -(void)addLayerAboveWithProperties:(NSDictionary * _Nonnull)properties layerId:(NSString * _Nonnull)layerId onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addLayerAboveWithProperties:layerId:onError:")]
		void AddLayerAboveWithProperties (NSDictionary properties, string layerId, [NullAllowed] Action<NSError> onError);

		// -(void)addLayerAtWithProperties:(NSDictionary * _Nonnull)properties index:(NSInteger)index onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addLayerAtWithProperties:index:onError:")]
		void AddLayerAtWithProperties (NSDictionary properties, nint index, [NullAllowed] Action<NSError> onError);
	}

    // @interface MapboxMapObjC_Swift_992
    [Category]
    [BaseType(typeof(MapView))]
    interface MapboxMapObjC_Swift_992
	{
		// -(void)lightAnchor:(enum MBXAnchor)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("lightAnchor:onError:")]
		void LightAnchor (MBXAnchor value, [NullAllowed] Action<NSError> onError);

		// -(void)lightColor:(UIColor * _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("lightColor:onError:")]
		void LightColor (UIColor value, [NullAllowed] Action<NSError> onError);

		// -(void)lightColorTransition:(MBXStyleTransition * _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("lightColorTransition:onError:")]
		void LightColorTransition (MBXStyleTransition value, [NullAllowed] Action<NSError> onError);

		// -(void)lightIntensity:(double)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("lightIntensity:onError:")]
		void LightIntensity (double value, [NullAllowed] Action<NSError> onError);

		// -(void)lightIntensityTransition:(MBXStyleTransition * _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("lightIntensityTransition:onError:")]
		void LightIntensityTransition (MBXStyleTransition value, [NullAllowed] Action<NSError> onError);

		// -(void)lightPosition:(NSArray<NSNumber *> * _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("lightPosition:onError:")]
		void LightPosition (NSNumber[] value, [NullAllowed] Action<NSError> onError);

		// -(void)lightPositionTransition:(MBXStyleTransition * _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("lightPositionTransition:onError:")]
		void LightPositionTransition (MBXStyleTransition value, [NullAllowed] Action<NSError> onError);
	}

    // @interface MapboxMapObjC_Swift_1010
    [Category]
    [BaseType(typeof(MapView))]
    interface MapboxMapObjC_Swift_1010
	{
		// -(MBXCancelable * _Nonnull)onMapLoaded:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onMapLoaded:")]
		MBXCancelable OnMapLoaded (Action<NSObject> handler);

		// -(MBXCancelable * _Nonnull)onMapLoadingError:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onMapLoadingError:")]
		MBXCancelable OnMapLoadingError (Action<NSObject> handler);

		// -(MBXCancelable * _Nonnull)onMapIdle:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onMapIdle:")]
		MBXCancelable OnMapIdle (Action<NSObject> handler);

		// -(MBXCancelable * _Nonnull)onStyleDataLoaded:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onStyleDataLoaded:")]
		MBXCancelable OnStyleDataLoaded (Action<NSObject> handler);

		// -(MBXCancelable * _Nonnull)onStyleLoaded:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onStyleLoaded:")]
		MBXCancelable OnStyleLoaded (Action<NSObject> handler);

		// -(MBXCancelable * _Nonnull)onStyleImageMissing:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onStyleImageMissing:")]
		MBXCancelable OnStyleImageMissing (Action<NSObject> handler);

		// -(MBXCancelable * _Nonnull)onStyleImageRemoveUnused:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onStyleImageRemoveUnused:")]
		MBXCancelable OnStyleImageRemoveUnused (Action<NSObject> handler);

		// -(MBXCancelable * _Nonnull)onSourceDataLoaded:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onSourceDataLoaded:")]
		MBXCancelable OnSourceDataLoaded (Action<NSObject> handler);

		// -(MBXCancelable * _Nonnull)onSourceAdded:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onSourceAdded:")]
		MBXCancelable OnSourceAdded (Action<NSObject> handler);

		// -(MBXCancelable * _Nonnull)onSourceRemoved:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onSourceRemoved:")]
		MBXCancelable OnSourceRemoved (Action<NSObject> handler);

		// -(MBXCancelable * _Nonnull)onRenderFrameStarted:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onRenderFrameStarted:")]
		MBXCancelable OnRenderFrameStarted (Action<NSObject> handler);

		// -(MBXCancelable * _Nonnull)onRenderFrameFinished:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onRenderFrameFinished:")]
		MBXCancelable OnRenderFrameFinished (Action<NSObject> handler);

		// -(MBXCancelable * _Nonnull)onEvenCameraChanged:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onEvenCameraChanged:")]
		MBXCancelable OnEvenCameraChanged (Action<NSObject> handler);

		// -(MBXCancelable * _Nonnull)onResourceRequest:(void (^ _Nonnull)(id _Nonnull))handler;
		[Export ("onResourceRequest:")]
		MBXCancelable OnResourceRequest (Action<NSObject> handler);
	}

	// @interface MapViewFactory : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC14MapViewFactory")]
	[DisableDefaultCtor]
	interface MapViewFactory
	{
		// +(id)createWithFrame:(CGRect)frame options:(MapInitOptions * _Nullable)options __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithFrame:options:")]
		MapView CreateWithFrame (CGRect frame, [NullAllowed] MapInitOptions options);
	}

	// @interface Puck2DConfigurationBuilder : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC26Puck2DConfigurationBuilder")]
	interface Puck2DConfigurationBuilder
	{
		// -(Puck2DConfigurationBuilder * _Nonnull)setPulsingBuilder:(Puck2DConfigurationPulsingBuilder * _Nullable)builder __attribute__((warn_unused_result("")));
		[Export ("setPulsingBuilder:")]
		Puck2DConfigurationBuilder SetPulsingBuilder ([NullAllowed] Puck2DConfigurationPulsingBuilder builder);

		// -(Puck2DConfigurationBuilder * _Nonnull)setPulsing:(void (^ _Nonnull)(Puck2DConfigurationPulsingBuilder * _Nonnull))build __attribute__((warn_unused_result("")));
		[Export ("setPulsing:")]
		Puck2DConfigurationBuilder SetPulsing (Action<Puck2DConfigurationPulsingBuilder> build);

		// -(Puck2DConfigurationBuilder * _Nonnull)setOpacity:(NSNumber * _Nonnull)value __attribute__((warn_unused_result("")));
		[Export ("setOpacity:")]
		Puck2DConfigurationBuilder SetOpacity (NSNumber value);

		// -(Puck2DConfigurationBuilder * _Nonnull)setTopImage:(UIImage * _Nullable)value __attribute__((warn_unused_result("")));
		[Export ("setTopImage:")]
		Puck2DConfigurationBuilder SetTopImage ([NullAllowed] UIImage value);

		// -(Puck2DConfigurationBuilder * _Nonnull)setBearingImage:(UIImage * _Nullable)value __attribute__((warn_unused_result("")));
		[Export ("setBearingImage:")]
		Puck2DConfigurationBuilder SetBearingImage ([NullAllowed] UIImage value);

		// -(Puck2DConfigurationBuilder * _Nonnull)setShadowImage:(UIImage * _Nullable)value __attribute__((warn_unused_result("")));
		[Export ("setShadowImage:")]
		Puck2DConfigurationBuilder SetShadowImage ([NullAllowed] UIImage value);

		// -(Puck2DConfigurationBuilder * _Nonnull)setScale:(NSNumber * _Nullable)value __attribute__((warn_unused_result("")));
		[Export ("setScale:")]
		Puck2DConfigurationBuilder SetScale ([NullAllowed] NSNumber value);

		// -(Puck2DConfigurationBuilder * _Nonnull)setShowsAccuracyRing:(BOOL)value __attribute__((warn_unused_result("")));
		[Export ("setShowsAccuracyRing:")]
		Puck2DConfigurationBuilder SetShowsAccuracyRing (bool value);

		// -(Puck2DConfigurationBuilder * _Nonnull)setAccuracyRingColor:(UIColor * _Nullable)value __attribute__((warn_unused_result("")));
		[Export ("setAccuracyRingColor:")]
		Puck2DConfigurationBuilder SetAccuracyRingColor ([NullAllowed] UIColor value);

		// -(Puck2DConfigurationBuilder * _Nonnull)setAccuracyRingBorderColor:(UIColor * _Nullable)value __attribute__((warn_unused_result("")));
		[Export ("setAccuracyRingBorderColor:")]
		Puck2DConfigurationBuilder SetAccuracyRingBorderColor ([NullAllowed] UIColor value);
	}

	// @interface Puck2DConfigurationPulsingBuilder : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC33Puck2DConfigurationPulsingBuilder")]
	interface Puck2DConfigurationPulsingBuilder
	{
		// -(Puck2DConfigurationPulsingBuilder * _Nonnull)setColor:(UIColor * _Nullable)color __attribute__((warn_unused_result("")));
		[Export ("setColor:")]
		Puck2DConfigurationPulsingBuilder SetColor ([NullAllowed] UIColor color);

		// -(Puck2DConfigurationPulsingBuilder * _Nonnull)setRadiusWithValue:(NSNumber * _Nullable)value __attribute__((warn_unused_result("")));
		[Export ("setRadiusWithValue:")]
		Puck2DConfigurationPulsingBuilder SetRadiusWithValue ([NullAllowed] NSNumber value);
	}

	// @interface RasterDemSourceBuilder : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC22RasterDemSourceBuilder")]
	interface RasterDemSourceBuilder
	{
		// -(RasterDemSourceBuilder * _Nonnull)url:(NSString * _Nullable)value;
		[Export ("url:")]
		RasterDemSourceBuilder Url ([NullAllowed] string value);

		// -(RasterDemSourceBuilder * _Nonnull)tiles:(NSArray<NSString *> * _Nullable)value;
		[Export ("tiles:")]
		RasterDemSourceBuilder Tiles ([NullAllowed] string[] value);

		// -(RasterDemSourceBuilder * _Nonnull)bounds:(NSArray<NSNumber *> * _Nullable)value;
		[Export ("bounds:")]
		RasterDemSourceBuilder Bounds ([NullAllowed] NSNumber[] value);

		// -(RasterDemSourceBuilder * _Nonnull)minzoom:(double)value;
		[Export ("minzoom:")]
		RasterDemSourceBuilder Minzoom (double value);

		// -(RasterDemSourceBuilder * _Nonnull)maxzoom:(double)value;
		[Export ("maxzoom:")]
		RasterDemSourceBuilder Maxzoom (double value);

		// -(RasterDemSourceBuilder * _Nonnull)tileSize:(double)value;
		[Export ("tileSize:")]
		RasterDemSourceBuilder TileSize (double value);

		// -(RasterDemSourceBuilder * _Nonnull)attribution:(NSString * _Nullable)value;
		[Export ("attribution:")]
		RasterDemSourceBuilder Attribution ([NullAllowed] string value);

		// -(RasterDemSourceBuilder * _Nonnull)encoding:(enum MBXEncoding)value;
		[Export ("encoding:")]
		RasterDemSourceBuilder Encoding (MBXEncoding value);

		// -(RasterDemSourceBuilder * _Nonnull)volatile:(BOOL)value;
		[Export ("volatile:")]
		RasterDemSourceBuilder Volatile (bool value);

		// -(RasterDemSourceBuilder * _Nonnull)prefetchZoomDelta:(double)value;
		[Export ("prefetchZoomDelta:")]
		RasterDemSourceBuilder PrefetchZoomDelta (double value);

		// -(RasterDemSourceBuilder * _Nonnull)minimumTileUpdateInterval:(double)value;
		[Export ("minimumTileUpdateInterval:")]
		RasterDemSourceBuilder MinimumTileUpdateInterval (double value);

		// -(RasterDemSourceBuilder * _Nonnull)maxOverscaleFactorForParentTiles:(double)value;
		[Export ("maxOverscaleFactorForParentTiles:")]
		RasterDemSourceBuilder MaxOverscaleFactorForParentTiles (double value);

		// -(RasterDemSourceBuilder * _Nonnull)tileRequestsDelay:(double)value;
		[Export ("tileRequestsDelay:")]
		RasterDemSourceBuilder TileRequestsDelay (double value);

		// -(RasterDemSourceBuilder * _Nonnull)tileNetworkRequestsDelay:(double)value;
		[Export ("tileNetworkRequestsDelay:")]
		RasterDemSourceBuilder TileNetworkRequestsDelay (double value);
	}

	// @interface SkyLayerBuilder : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC15SkyLayerBuilder")]
	[DisableDefaultCtor]
	interface SkyLayerBuilder
	{
		// -(void)filter:(MBXExpression * _Nullable)value;
		[Export ("filter:")]
		void Filter ([NullAllowed] MBXExpression value);

		// -(void)source:(NSString * _Nullable)value;
		[Export ("source:")]
		void Source ([NullAllowed] string value);

		// -(void)sourceLayer:(NSString * _Nullable)value;
		[Export ("sourceLayer:")]
		void SourceLayer ([NullAllowed] string value);

		// -(void)minZoom:(NSNumber * _Nullable)value;
		[Export ("minZoom:")]
		void MinZoom ([NullAllowed] NSNumber value);

		// -(void)maxZoom:(NSNumber * _Nullable)value;
		[Export ("maxZoom:")]
		void MaxZoom ([NullAllowed] NSNumber value);

		// -(void)visibility:(MBXValue * _Nullable)value;
		[Export ("visibility:")]
		void Visibility ([NullAllowed] MBXValue value);

		// -(void)skyAtmosphereColor:(MBXValue * _Nullable)value;
		[Export ("skyAtmosphereColor:")]
		void SkyAtmosphereColor ([NullAllowed] MBXValue value);

		// -(void)skyAtmosphereHaloColor:(MBXValue * _Nullable)value;
		[Export ("skyAtmosphereHaloColor:")]
		void SkyAtmosphereHaloColor ([NullAllowed] MBXValue value);

		// -(void)skyAtmosphereSun:(MBXValue * _Nullable)value;
		[Export ("skyAtmosphereSun:")]
		void SkyAtmosphereSun ([NullAllowed] MBXValue value);

		// -(void)skyAtmosphereSunIntensity:(MBXValue * _Nullable)value;
		[Export ("skyAtmosphereSunIntensity:")]
		void SkyAtmosphereSunIntensity ([NullAllowed] MBXValue value);

		// -(void)skyGradient:(MBXValue * _Nullable)value;
		[Export ("skyGradient:")]
		void SkyGradient ([NullAllowed] MBXValue value);

		// -(void)skyGradientCenter:(MBXValue * _Nullable)value;
		[Export ("skyGradientCenter:")]
		void SkyGradientCenter ([NullAllowed] MBXValue value);

		// -(void)skyGradientRadius:(MBXValue * _Nullable)value;
		[Export ("skyGradientRadius:")]
		void SkyGradientRadius ([NullAllowed] MBXValue value);

		// -(void)skyOpacity:(MBXValue * _Nullable)value;
		[Export ("skyOpacity:")]
		void SkyOpacity ([NullAllowed] MBXValue value);

		// -(void)skyOpacityTransition:(MBXStyleTransition * _Nullable)value;
		[Export ("skyOpacityTransition:")]
		void SkyOpacityTransition ([NullAllowed] MBXStyleTransition value);

		// -(void)skyType:(MBXValue * _Nullable)value;
		[Export ("skyType:")]
		void SkyType ([NullAllowed] MBXValue value);
	}
}
