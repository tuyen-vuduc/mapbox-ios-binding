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

	// @interface FillExtrusionLayerBuilder : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC25FillExtrusionLayerBuilder")]
	[DisableDefaultCtor]
	interface FillExtrusionLayerBuilder
	{
		// +(FillExtrusionLayerBuilder * _Nonnull)withId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Static]
		[Export ("withId:")]
		FillExtrusionLayerBuilder WithId (string id);

		// -(void)filter:(TMBExpression * _Nullable)value;
		[Export ("filter:")]
		void Filter ([NullAllowed] TMBExpression value);

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

		// -(void)visibility:(TMBValue * _Nullable)value;
		[Export ("visibility:")]
		void Visibility ([NullAllowed] TMBValue value);

		// -(void)fillExtrusionAmbientOcclusionIntensity:(TMBValue * _Nullable)value;
		[Export ("fillExtrusionAmbientOcclusionIntensity:")]
		void FillExtrusionAmbientOcclusionIntensity ([NullAllowed] TMBValue value);

		// -(void)fillExtrusionAmbientOcclusionIntensityTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("fillExtrusionAmbientOcclusionIntensityTransition:")]
		void FillExtrusionAmbientOcclusionIntensityTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)fillExtrusionAmbientOcclusionRadius:(TMBValue * _Nullable)value;
		[Export ("fillExtrusionAmbientOcclusionRadius:")]
		void FillExtrusionAmbientOcclusionRadius ([NullAllowed] TMBValue value);

		// -(void)fillExtrusionAmbientOcclusionRadiusTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("fillExtrusionAmbientOcclusionRadiusTransition:")]
		void FillExtrusionAmbientOcclusionRadiusTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)fillExtrusionBase:(TMBValue * _Nullable)value;
		[Export ("fillExtrusionBase:")]
		void FillExtrusionBase ([NullAllowed] TMBValue value);

		// -(void)fillExtrusionBaseTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("fillExtrusionBaseTransition:")]
		void FillExtrusionBaseTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)fillExtrusionColor:(TMBValue * _Nullable)value;
		[Export ("fillExtrusionColor:")]
		void FillExtrusionColor ([NullAllowed] TMBValue value);

		// -(void)fillExtrusionColorTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("fillExtrusionColorTransition:")]
		void FillExtrusionColorTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)fillExtrusionHeight:(TMBValue * _Nullable)value;
		[Export ("fillExtrusionHeight:")]
		void FillExtrusionHeight ([NullAllowed] TMBValue value);

		// -(void)fillExtrusionHeightTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("fillExtrusionHeightTransition:")]
		void FillExtrusionHeightTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)fillExtrusionOpacity:(TMBValue * _Nullable)value;
		[Export ("fillExtrusionOpacity:")]
		void FillExtrusionOpacity ([NullAllowed] TMBValue value);

		// -(void)fillExtrusionOpacityTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("fillExtrusionOpacityTransition:")]
		void FillExtrusionOpacityTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)fillExtrusionPattern:(TMBValue * _Nullable)value;
		[Export ("fillExtrusionPattern:")]
		void FillExtrusionPattern ([NullAllowed] TMBValue value);

		// -(void)fillExtrusionPatternTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("fillExtrusionPatternTransition:")]
		void FillExtrusionPatternTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)fillExtrusionTranslate:(TMBValue * _Nullable)value;
		[Export ("fillExtrusionTranslate:")]
		void FillExtrusionTranslate ([NullAllowed] TMBValue value);

		// -(void)fillExtrusionTranslateTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("fillExtrusionTranslateTransition:")]
		void FillExtrusionTranslateTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)fillExtrusionTranslateAnchor:(TMBValue * _Nonnull)value;
		[Export ("fillExtrusionTranslateAnchor:")]
		void FillExtrusionTranslateAnchor (TMBValue value);

		// -(void)fillExtrusionVerticalGradient:(TMBValue * _Nullable)value;
		[Export ("fillExtrusionVerticalGradient:")]
		void FillExtrusionVerticalGradient ([NullAllowed] TMBValue value);
	}

	// @interface MapboxMapObjC_Swift_327
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_327
	{
		// -(MBMResourceOptions * _Nonnull)resourceOptions __attribute__((warn_unused_result("")));
		[Export ("resourceOptions")]
		MBMResourceOptions ResourceOptions();
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

	// @interface MapboxMapObjC_Swift_352
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_352
	{
		// -(void)setTerrain:(TMBTerrain * _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("setTerrain:onError:")]
		void SetTerrain (TMBTerrain value, [NullAllowed] Action<NSError> onError);
	}

	// @interface MapboxMapObjC_Swift_357
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_357
	{
		// -(void)setCameraTo:(MBMCameraOptions * _Nonnull)cameraOptions;
		[Export ("setCameraTo:")]
		void SetCameraTo (MBMCameraOptions cameraOptions);
	}

	// @interface MapboxMapObjC_Swift_363
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_363
	{
		// -(void)ornamentsOptionsScaleBarVisibility:(enum TMBOrnamentVisibility)value;
		[Export ("ornamentsOptionsScaleBarVisibility:")]
		void OrnamentsOptionsScaleBarVisibility (TMBOrnamentVisibility value);
	}

	// @interface MapboxMapObjC_Swift_369
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_369
	{
		// -(void)updateSymbolLayer:(NSString * _Nonnull)id configure:(void (^ _Nonnull)(SymbolLayerBuilder * _Nonnull))configure onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("updateSymbolLayer:configure:onError:")]
		void UpdateSymbolLayer (string id, Action<SymbolLayerBuilder> configure, [NullAllowed] Action<NSError> onError);
	}

	// @interface MapboxMapObjC_Swift_375
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_375
	{
		// -(void)addRasterDemSource:(NSString * _Nonnull)id configure:(void (^ _Nonnull)(RasterDemSourceBuilder * _Nonnull))configure onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addRasterDemSource:configure:onError:")]
		void AddRasterDemSource (string id, Action<RasterDemSourceBuilder> configure, [NullAllowed] Action<NSError> onError);
	}

	// @interface MapboxMapObjC_Swift_381
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_381
	{
		// -(void)updateSkyLayer:(NSString * _Nonnull)id configure:(void (^ _Nonnull)(SkyLayerBuilder * _Nonnull))configure onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("updateSkyLayer:configure:onError:")]
		void UpdateSkyLayer (string id, Action<SkyLayerBuilder> configure, [NullAllowed] Action<NSError> onError);
	}

	// @interface MapboxMapObjC_Swift_387
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_387
	{
		// -(void)setStyle:(NSString * _Nonnull)styleUri;
		[Export ("setStyle:")]
		void SetStyle (string styleUri);

		// -(void)setStyleInJson:(NSString * _Nonnull)styleJson;
		[Export ("setStyleInJson:")]
		void SetStyleInJson (string styleJson);

		// -(void)loadStyle:(NSString * _Nonnull)styleUri completion:(void (^ _Nullable)(TMBStyle * _Nullable, NSError * _Nullable))completion;
		[Export ("loadStyle:completion:")]
		void LoadStyle (string styleUri, [NullAllowed] Action<TMBStyle, NSError> completion);
	}

	// @interface MapboxMapObjC_Swift_394
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_394
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
	}

	// @interface MapboxMapObjC_Swift_404
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_404
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

		// -(void)puckBearingSource:(enum TMBPuckBearingSource)source;
		[Export ("puckBearingSource:")]
		void PuckBearingSource (TMBPuckBearingSource source);
	}

	// @interface MapboxMapObjC_Swift_413
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_413
	{
		// -(void)addSource:(NSString * _Nonnull)id properties:(NSDictionary<NSString *,id> * _Nonnull)properties onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addSource:properties:onError:")]
		void AddSource (string id, NSDictionary<NSString, NSObject> properties, [NullAllowed] Action<NSError> onError);

		// -(void)removeSource:(NSString * _Nonnull)id onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("removeSource:onError:")]
		void RemoveSource (string id, [NullAllowed] Action<NSError> onError);

		// -(BOOL)sourceExists:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("sourceExists:")]
		bool SourceExists (string id);

		// -(void)setSourcePropertiesFor:(NSString * _Nonnull)id properties:(NSDictionary<NSString *,id> * _Nonnull)properties onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("setSourcePropertiesFor:properties:onError:")]
		void SetSourcePropertiesFor (string id, NSDictionary<NSString, NSObject> properties, [NullAllowed] Action<NSError> onError);

		// -(NSDictionary<NSString *,id> * _Nonnull)getSourcePropertiesFor:(NSString * _Nonnull)id onError:(void (^ _Nullable)(NSError * _Nonnull))onError __attribute__((warn_unused_result("")));
		[Export ("getSourcePropertiesFor:onError:")]
		NSDictionary<NSString, NSObject> GetSourcePropertiesFor (string id, [NullAllowed] Action<NSError> onError);

		// -(void)addSourceWithId:(NSString * _Nonnull)id geometry:(TMBGeometry * _Nonnull)geometry onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addSourceWithId:geometry:onError:")]
		void AddSourceWithId (string id, TMBGeometry geometry, [NullAllowed] Action<NSError> onError);
	}

	// @interface MapboxMapObjC_Swift_427
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_427
	{
		// -(TMBPolygonAnnotationManager * _Nonnull)polygonAnnotationManager __attribute__((warn_unused_result("")));
		[Export ("polygonAnnotationManager")]
		TMBPolygonAnnotationManager PolygonAnnotationManager ();

		// -(TMBPolygonAnnotationManager * _Nonnull)polygonAnnotationManagerWithId:(NSString * _Nullable)id layerPosition:(enum TMBLayerPosition)layerPosition layerPositionParam:(id _Nullable)layerPositionParam __attribute__((warn_unused_result("")));
		[Export ("polygonAnnotationManagerWithId:layerPosition:layerPositionParam:")]
		TMBPolygonAnnotationManager PolygonAnnotationManagerWithId ([NullAllowed] string id, TMBLayerPosition layerPosition, [NullAllowed] NSObject layerPositionParam);

		// -(TMBCircleAnnotationManager * _Nonnull)circleAnnotationManager __attribute__((warn_unused_result("")));
		[Export ("circleAnnotationManager")]
		TMBCircleAnnotationManager CircleAnnotationManager();

		// -(TMBCircleAnnotationManager * _Nonnull)circleAnnotationManagerWithId:(NSString * _Nullable)id layerPosition:(enum TMBLayerPosition)layerPosition layerPositionParam:(id _Nullable)layerPositionParam __attribute__((warn_unused_result("")));
		[Export ("circleAnnotationManagerWithId:layerPosition:layerPositionParam:")]
		TMBCircleAnnotationManager CircleAnnotationManagerWithId ([NullAllowed] string id, TMBLayerPosition layerPosition, [NullAllowed] NSObject layerPositionParam);

		// -(TMBPointAnnotationManager * _Nonnull)pointAnnotationManager __attribute__((warn_unused_result("")));
		[Export ("pointAnnotationManager")]
		TMBPointAnnotationManager PointAnnotationManager();

		// -(TMBPointAnnotationManager * _Nonnull)pointAnnotationManagerWithId:(NSString * _Nullable)id layerPosition:(enum TMBLayerPosition)layerPosition layerPositionParam:(id _Nullable)layerPositionParam __attribute__((warn_unused_result("")));
		[Export ("pointAnnotationManagerWithId:layerPosition:layerPositionParam:")]
		TMBPointAnnotationManager PointAnnotationManagerWithId ([NullAllowed] string id, TMBLayerPosition layerPosition, [NullAllowed] NSObject layerPositionParam);
	}

	// @interface MapboxMapObjC_Swift_439
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_439
	{
		// -(void)setLightProperty:(NSString * _Nonnull)name value:(id _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("setLightProperty:value:onError:")]
		void SetLightProperty (string name, NSObject value, [NullAllowed] Action<NSError> onError);

		// -(void)setLightWithProperties:(NSDictionary<NSString *,id> * _Nonnull)properties onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("setLightWithProperties:onError:")]
		void SetLightWithProperties (NSDictionary<NSString, NSObject> properties, [NullAllowed] Action<NSError> onError);

		// -(void)lightAnchor:(enum TMBAnchor)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("lightAnchor:onError:")]
		void LightAnchor (TMBAnchor value, [NullAllowed] Action<NSError> onError);

		// -(void)lightColor:(UIColor * _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("lightColor:onError:")]
		void LightColor (UIColor value, [NullAllowed] Action<NSError> onError);

		// -(void)lightColorTransition:(TMBStyleTransition * _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("lightColorTransition:onError:")]
		void LightColorTransition (TMBStyleTransition value, [NullAllowed] Action<NSError> onError);

		// -(void)lightIntensity:(double)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("lightIntensity:onError:")]
		void LightIntensity (double value, [NullAllowed] Action<NSError> onError);

		// -(void)lightIntensityTransition:(TMBStyleTransition * _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("lightIntensityTransition:onError:")]
		void LightIntensityTransition (TMBStyleTransition value, [NullAllowed] Action<NSError> onError);

		// -(void)lightPosition:(NSArray<NSNumber *> * _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("lightPosition:onError:")]
		void LightPosition (NSNumber[] value, [NullAllowed] Action<NSError> onError);

		// -(void)lightPositionTransition:(TMBStyleTransition * _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("lightPositionTransition:onError:")]
		void LightPositionTransition (TMBStyleTransition value, [NullAllowed] Action<NSError> onError);
	}

	// @interface MapboxMapObjC_Swift_462
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_462
	{
		// -(void)addLayerWithProperties:(NSDictionary<NSString *,id> * _Nonnull)properties layerPosition:(enum TMBLayerPosition)layerPosition layerPositionParam:(NSObject * _Nullable)layerPositionParam onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addLayerWithProperties:layerPosition:layerPositionParam:onError:")]
		void AddLayerWithProperties (NSDictionary<NSString, NSObject> properties, TMBLayerPosition layerPosition, [NullAllowed] NSObject layerPositionParam, [NullAllowed] Action<NSError> onError);

		// -(void)removeLayerWithId:(NSString * _Nonnull)id onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("removeLayerWithId:onError:")]
		void RemoveLayerWithId (string id, [NullAllowed] Action<NSError> onError);

		// -(BOOL)isPersistentLayerWithId:(NSString * _Nonnull)id onError:(void (^ _Nullable)(NSError * _Nonnull))onError __attribute__((warn_unused_result("")));
		[Export ("isPersistentLayerWithId:onError:")]
		bool IsPersistentLayerWithId (string id, [NullAllowed] Action<NSError> onError);

		// -(BOOL)layerExistsWithId:(NSString * _Nonnull)id onError:(void (^ _Nullable)(NSError * _Nonnull))onError __attribute__((warn_unused_result("")));
		[Export ("layerExistsWithId:onError:")]
		bool LayerExistsWithId (string id, [NullAllowed] Action<NSError> onError);

		// -(void)setLayerPropertiesFor:(NSString * _Nonnull)id properties:(NSDictionary<NSString *,id> * _Nonnull)properties onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("setLayerPropertiesFor:properties:onError:")]
		void SetLayerPropertiesFor (string id, NSDictionary<NSString, NSObject> properties, [NullAllowed] Action<NSError> onError);

		// -(void)updateLayerPropertiesFor:(NSString * _Nonnull)id properties:(NSDictionary<NSString *,id> * _Nonnull)properties onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("updateLayerPropertiesFor:properties:onError:")]
		void UpdateLayerPropertiesFor (string id, NSDictionary<NSString, NSObject> properties, [NullAllowed] Action<NSError> onError);

		// -(NSDictionary<NSString *,id> * _Nonnull)getLayerPropertiesFor:(NSString * _Nonnull)id onError:(void (^ _Nullable)(NSError * _Nonnull))onError __attribute__((warn_unused_result("")));
		[Export ("getLayerPropertiesFor:onError:")]
		NSDictionary<NSString, NSObject> GetLayerPropertiesFor (string id, [NullAllowed] Action<NSError> onError);

		// -(void)addPersistentLayerWithProperties:(NSDictionary<NSString *,id> * _Nonnull)properties layerPosition:(enum TMBLayerPosition)layerPosition layerPositionParam:(NSObject * _Nullable)layerPositionParam onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addPersistentLayerWithProperties:layerPosition:layerPositionParam:onError:")]
		void AddPersistentLayerWithProperties (NSDictionary<NSString, NSObject> properties, TMBLayerPosition layerPosition, [NullAllowed] NSObject layerPositionParam, [NullAllowed] Action<NSError> onError);

		// -(void)addLayerWithTarget:(NSObject * _Nonnull)target selector:(SEL _Nonnull)selector layerPosition:(enum TMBLayerPosition)layerPosition layerPositionParam:(NSObject * _Nullable)layerPositionParam onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addLayerWithTarget:selector:layerPosition:layerPositionParam:onError:")]
		void AddLayerWithTarget (NSObject target, Selector selector, TMBLayerPosition layerPosition, [NullAllowed] NSObject layerPositionParam, [NullAllowed] Action<NSError> onError);

		// -(void)addLayerWithBuilder:(id  _Nonnull (^ _Nonnull)(void))builder layerPosition:(enum TMBLayerPosition)layerPosition layerPositionParam:(NSObject * _Nullable)layerPositionParam onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addLayerWithBuilder:layerPosition:layerPositionParam:onError:")]
		void AddLayerWithBuilder (Func<NSObject> builder, TMBLayerPosition layerPosition, [NullAllowed] NSObject layerPositionParam, [NullAllowed] Action<NSError> onError);

		// -(void)addCustomLayer:(NSString * _Nonnull)id layerHost:(id<MBMCustomLayerHost> _Nonnull)layerHost layerPosition:(enum TMBLayerPosition)layerPosition layerPositionParam:(NSObject * _Nullable)layerPositionParam onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addCustomLayer:layerHost:layerPosition:layerPositionParam:onError:")]
		void AddCustomLayer (string id, MBMCustomLayerHost layerHost, TMBLayerPosition layerPosition, [NullAllowed] NSObject layerPositionParam, [NullAllowed] Action<NSError> onError);
	}

	// @interface MapboxMapObjC_Swift_478
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_478
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

	// @interface MapViewFactory : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC14MapViewFactory")]
	[DisableDefaultCtor]
	interface MapViewFactory
	{
		// +(id)createWithFrame:(CGRect)frame options:(id)options __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithFrame:options:")]
		MapView CreateWithFrame (CGRect frame, [NullAllowed] MapInitOptions options);
	}

	// @interface MapboxMapObjC_Swift_567
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_567
	{
		// -(TMBCancelable * _Nonnull)loadStyleWithStyleUriString:(NSString * _Nonnull)styleUriString styleLoadOptions:(MBMStylePackLoadOptions * _Nonnull)styleLoadOptions progress:(id)progress completion:(void (^ _Nonnull)(MBMStylePack * _Nullable, NSError * _Nullable))completion __attribute__((warn_unused_result("")));
		[Export ("loadStyleWithStyleUriString:styleLoadOptions:progress:completion:")]
		TMBCancelable LoadStyleWithStyleUriString (string styleUriString, MBMStylePackLoadOptions styleLoadOptions, NSObject progress, Action<MBMStylePack, NSError> completion);

		// -(void)allStylePacks:(void (^ _Nonnull)(NSArray<MBMStylePack *> * _Nullable, NSError * _Nullable))completion;
		[Export ("allStylePacks:")]
		void AllStylePacks (Action<NSArray<MBMStylePack>, NSError> completion);
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

		// -(RasterDemSourceBuilder * _Nonnull)encoding:(enum TMBEncoding)value;
		[Export ("encoding:")]
		RasterDemSourceBuilder Encoding (TMBEncoding value);

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
		// +(SkyLayerBuilder * _Nonnull)withId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Static]
		[Export ("withId:")]
		SkyLayerBuilder WithId (string id);

		// -(void)filter:(TMBExpression * _Nullable)value;
		[Export ("filter:")]
		void Filter ([NullAllowed] TMBExpression value);

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

		// -(void)visibility:(TMBValue * _Nullable)value;
		[Export ("visibility:")]
		void Visibility ([NullAllowed] TMBValue value);

		// -(void)skyAtmosphereColor:(TMBValue * _Nullable)value;
		[Export ("skyAtmosphereColor:")]
		void SkyAtmosphereColor ([NullAllowed] TMBValue value);

		// -(void)skyAtmosphereHaloColor:(TMBValue * _Nullable)value;
		[Export ("skyAtmosphereHaloColor:")]
		void SkyAtmosphereHaloColor ([NullAllowed] TMBValue value);

		// -(void)skyAtmosphereSun:(TMBValue * _Nullable)value;
		[Export ("skyAtmosphereSun:")]
		void SkyAtmosphereSun ([NullAllowed] TMBValue value);

		// -(void)skyAtmosphereSunIntensity:(TMBValue * _Nullable)value;
		[Export ("skyAtmosphereSunIntensity:")]
		void SkyAtmosphereSunIntensity ([NullAllowed] TMBValue value);

		// -(void)skyGradient:(TMBValue * _Nullable)value;
		[Export ("skyGradient:")]
		void SkyGradient ([NullAllowed] TMBValue value);

		// -(void)skyGradientCenter:(TMBValue * _Nullable)value;
		[Export ("skyGradientCenter:")]
		void SkyGradientCenter ([NullAllowed] TMBValue value);

		// -(void)skyGradientRadius:(TMBValue * _Nullable)value;
		[Export ("skyGradientRadius:")]
		void SkyGradientRadius ([NullAllowed] TMBValue value);

		// -(void)skyOpacity:(TMBValue * _Nullable)value;
		[Export ("skyOpacity:")]
		void SkyOpacity ([NullAllowed] TMBValue value);

		// -(void)skyOpacityTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("skyOpacityTransition:")]
		void SkyOpacityTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)skyType:(TMBValue * _Nullable)value;
		[Export ("skyType:")]
		void SkyType ([NullAllowed] TMBValue value);
	}

	// @interface SymbolLayerBuilder : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18SymbolLayerBuilder")]
	[DisableDefaultCtor]
	interface SymbolLayerBuilder
	{
		// +(SymbolLayerBuilder * _Nonnull)withId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Static]
		[Export ("withId:")]
		SymbolLayerBuilder WithId (string id);

		// -(void)filter:(TMBExpression * _Nullable)value;
		[Export ("filter:")]
		void Filter ([NullAllowed] TMBExpression value);

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

		// -(void)visibility:(TMBValue * _Nullable)value;
		[Export ("visibility:")]
		void Visibility ([NullAllowed] TMBValue value);

		// -(void)iconAllowOverlap:(TMBValue * _Nullable)value;
		[Export ("iconAllowOverlap:")]
		void IconAllowOverlap ([NullAllowed] TMBValue value);

		// -(void)iconAnchor:(TMBValue * _Nullable)value;
		[Export ("iconAnchor:")]
		void IconAnchor ([NullAllowed] TMBValue value);

		// -(void)iconIgnorePlacement:(TMBValue * _Nullable)value;
		[Export ("iconIgnorePlacement:")]
		void IconIgnorePlacement ([NullAllowed] TMBValue value);

		// -(void)iconImage:(TMBValue * _Nullable)value;
		[Export ("iconImage:")]
		void IconImage ([NullAllowed] TMBValue value);

		// -(void)iconKeepUpright:(TMBValue * _Nullable)value;
		[Export ("iconKeepUpright:")]
		void IconKeepUpright ([NullAllowed] TMBValue value);

		// -(void)iconOffset:(TMBValue * _Nullable)value;
		[Export ("iconOffset:")]
		void IconOffset ([NullAllowed] TMBValue value);

		// -(void)iconOptional:(TMBValue * _Nullable)value;
		[Export ("iconOptional:")]
		void IconOptional ([NullAllowed] TMBValue value);

		// -(void)iconPadding:(TMBValue * _Nullable)value;
		[Export ("iconPadding:")]
		void IconPadding ([NullAllowed] TMBValue value);

		// -(void)iconPitchAlignment:(TMBValue * _Nullable)value;
		[Export ("iconPitchAlignment:")]
		void IconPitchAlignment ([NullAllowed] TMBValue value);

		// -(void)iconRotate:(TMBValue * _Nullable)value;
		[Export ("iconRotate:")]
		void IconRotate ([NullAllowed] TMBValue value);

		// -(void)iconRotationAlignment:(TMBValue * _Nullable)value;
		[Export ("iconRotationAlignment:")]
		void IconRotationAlignment ([NullAllowed] TMBValue value);

		// -(void)iconSize:(TMBValue * _Nullable)value;
		[Export ("iconSize:")]
		void IconSize ([NullAllowed] TMBValue value);

		// -(void)iconTextFit:(TMBValue * _Nullable)value;
		[Export ("iconTextFit:")]
		void IconTextFit ([NullAllowed] TMBValue value);

		// -(void)iconTextFitPadding:(TMBValue * _Nullable)value;
		[Export ("iconTextFitPadding:")]
		void IconTextFitPadding ([NullAllowed] TMBValue value);

		// -(void)symbolAvoidEdges:(TMBValue * _Nullable)value;
		[Export ("symbolAvoidEdges:")]
		void SymbolAvoidEdges ([NullAllowed] TMBValue value);

		// -(void)symbolPlacement:(TMBValue * _Nullable)value;
		[Export ("symbolPlacement:")]
		void SymbolPlacement ([NullAllowed] TMBValue value);

		// -(void)symbolSortKey:(TMBValue * _Nullable)value;
		[Export ("symbolSortKey:")]
		void SymbolSortKey ([NullAllowed] TMBValue value);

		// -(void)symbolSpacing:(TMBValue * _Nullable)value;
		[Export ("symbolSpacing:")]
		void SymbolSpacing ([NullAllowed] TMBValue value);

		// -(void)symbolZOrder:(TMBValue * _Nullable)value;
		[Export ("symbolZOrder:")]
		void SymbolZOrder ([NullAllowed] TMBValue value);

		// -(void)textAllowOverlap:(TMBValue * _Nullable)value;
		[Export ("textAllowOverlap:")]
		void TextAllowOverlap ([NullAllowed] TMBValue value);

		// -(void)textAnchor:(TMBValue * _Nullable)value;
		[Export ("textAnchor:")]
		void TextAnchor ([NullAllowed] TMBValue value);

		// -(void)textField:(TMBValue * _Nullable)value;
		[Export ("textField:")]
		void TextField ([NullAllowed] TMBValue value);

		// -(void)textFont:(TMBValue * _Nullable)value;
		[Export ("textFont:")]
		void TextFont ([NullAllowed] TMBValue value);

		// -(void)textIgnorePlacement:(TMBValue * _Nullable)value;
		[Export ("textIgnorePlacement:")]
		void TextIgnorePlacement ([NullAllowed] TMBValue value);

		// -(void)textJustify:(TMBValue * _Nullable)value;
		[Export ("textJustify:")]
		void TextJustify ([NullAllowed] TMBValue value);

		// -(void)textKeepUpright:(TMBValue * _Nullable)value;
		[Export ("textKeepUpright:")]
		void TextKeepUpright ([NullAllowed] TMBValue value);

		// -(void)textLetterSpacing:(TMBValue * _Nullable)value;
		[Export ("textLetterSpacing:")]
		void TextLetterSpacing ([NullAllowed] TMBValue value);

		// -(void)textLineHeight:(TMBValue * _Nullable)value;
		[Export ("textLineHeight:")]
		void TextLineHeight ([NullAllowed] TMBValue value);

		// -(void)textMaxAngle:(TMBValue * _Nullable)value;
		[Export ("textMaxAngle:")]
		void TextMaxAngle ([NullAllowed] TMBValue value);

		// -(void)textMaxWidth:(TMBValue * _Nullable)value;
		[Export ("textMaxWidth:")]
		void TextMaxWidth ([NullAllowed] TMBValue value);

		// -(void)textOffset:(TMBValue * _Nullable)value;
		[Export ("textOffset:")]
		void TextOffset ([NullAllowed] TMBValue value);

		// -(void)textOptional:(TMBValue * _Nullable)value;
		[Export ("textOptional:")]
		void TextOptional ([NullAllowed] TMBValue value);

		// -(void)textPadding:(TMBValue * _Nullable)value;
		[Export ("textPadding:")]
		void TextPadding ([NullAllowed] TMBValue value);

		// -(void)textPitchAlignment:(TMBValue * _Nullable)value;
		[Export ("textPitchAlignment:")]
		void TextPitchAlignment ([NullAllowed] TMBValue value);

		// -(void)textRadialOffset:(TMBValue * _Nullable)value;
		[Export ("textRadialOffset:")]
		void TextRadialOffset ([NullAllowed] TMBValue value);

		// -(void)textRotate:(TMBValue * _Nullable)value;
		[Export ("textRotate:")]
		void TextRotate ([NullAllowed] TMBValue value);

		// -(void)textRotationAlignment:(TMBValue * _Nullable)value;
		[Export ("textRotationAlignment:")]
		void TextRotationAlignment ([NullAllowed] TMBValue value);

		// -(void)textSize:(TMBValue * _Nullable)value;
		[Export ("textSize:")]
		void TextSize ([NullAllowed] TMBValue value);

		// -(void)textTransform:(TMBValue * _Nullable)value;
		[Export ("textTransform:")]
		void TextTransform ([NullAllowed] TMBValue value);

		// -(void)textVariableAnchor:(TMBValue * _Nullable)value;
		[Export ("textVariableAnchor:")]
		void TextVariableAnchor ([NullAllowed] TMBValue value);

		// -(void)textWritingMode:(TMBValue * _Nullable)value;
		[Export ("textWritingMode:")]
		void TextWritingMode ([NullAllowed] TMBValue value);

		// -(void)iconColor:(TMBValue * _Nullable)value;
		[Export ("iconColor:")]
		void IconColor ([NullAllowed] TMBValue value);

		// -(void)iconColorTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("iconColorTransition:")]
		void IconColorTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)iconHaloBlur:(TMBValue * _Nullable)value;
		[Export ("iconHaloBlur:")]
		void IconHaloBlur ([NullAllowed] TMBValue value);

		// -(void)iconHaloBlurTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("iconHaloBlurTransition:")]
		void IconHaloBlurTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)iconHaloColor:(TMBValue * _Nullable)value;
		[Export ("iconHaloColor:")]
		void IconHaloColor ([NullAllowed] TMBValue value);

		// -(void)iconHaloColorTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("iconHaloColorTransition:")]
		void IconHaloColorTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)iconHaloWidth:(TMBValue * _Nullable)value;
		[Export ("iconHaloWidth:")]
		void IconHaloWidth ([NullAllowed] TMBValue value);

		// -(void)iconHaloWidthTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("iconHaloWidthTransition:")]
		void IconHaloWidthTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)iconOpacity:(TMBValue * _Nullable)value;
		[Export ("iconOpacity:")]
		void IconOpacity ([NullAllowed] TMBValue value);

		// -(void)iconOpacityTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("iconOpacityTransition:")]
		void IconOpacityTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)iconTranslate:(TMBValue * _Nullable)value;
		[Export ("iconTranslate:")]
		void IconTranslate ([NullAllowed] TMBValue value);

		// -(void)iconTranslateTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("iconTranslateTransition:")]
		void IconTranslateTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)iconTranslateAnchor:(TMBValue * _Nullable)value;
		[Export ("iconTranslateAnchor:")]
		void IconTranslateAnchor ([NullAllowed] TMBValue value);

		// -(void)textColor:(TMBValue * _Nullable)value;
		[Export ("textColor:")]
		void TextColor ([NullAllowed] TMBValue value);

		// -(void)textColorTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("textColorTransition:")]
		void TextColorTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)textHaloBlur:(TMBValue * _Nullable)value;
		[Export ("textHaloBlur:")]
		void TextHaloBlur ([NullAllowed] TMBValue value);

		// -(void)textHaloBlurTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("textHaloBlurTransition:")]
		void TextHaloBlurTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)textHaloColor:(TMBValue * _Nullable)value;
		[Export ("textHaloColor:")]
		void TextHaloColor ([NullAllowed] TMBValue value);

		// -(void)textHaloColorTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("textHaloColorTransition:")]
		void TextHaloColorTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)textHaloWidth:(TMBValue * _Nullable)value;
		[Export ("textHaloWidth:")]
		void TextHaloWidth ([NullAllowed] TMBValue value);

		// -(void)textHaloWidthTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("textHaloWidthTransition:")]
		void TextHaloWidthTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)textOpacity:(TMBValue * _Nullable)value;
		[Export ("textOpacity:")]
		void TextOpacity ([NullAllowed] TMBValue value);

		// -(void)textOpacityTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("textOpacityTransition:")]
		void TextOpacityTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)textTranslate:(TMBValue * _Nullable)value;
		[Export ("textTranslate:")]
		void TextTranslate ([NullAllowed] TMBValue value);

		// -(void)textTranslateTransition:(TMBStyleTransition * _Nullable)value;
		[Export ("textTranslateTransition:")]
		void TextTranslateTransition ([NullAllowed] TMBStyleTransition value);

		// -(void)textTranslateAnchor:(TMBValue * _Nullable)value;
		[Export ("textTranslateAnchor:")]
		void TextTranslateAnchor ([NullAllowed] TMBValue value);
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
*/[Protocol (Name = "_TtP13MapboxMapObjC13TMBAnnotation_")]
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
	[Protocol (Name = "_TtP13MapboxMapObjC20TMBAnnotationManager_")]
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

		// @property (nonatomic, strong) UIColor * _Nullable circleColor;
		[NullAllowed, Export ("circleColor", ArgumentSemantic.Strong)]
		UIColor CircleColor { get; set; }

		// @property (nonatomic) double circleRadius;
		[Export ("circleRadius")]
		double CircleRadius { get; set; }

		// @property (nonatomic) BOOL isDraggable;
		[Export ("isDraggable")]
		bool IsDraggable { get; set; }

		// +(TMBCircleAnnotation * _Nonnull)fromCenter:(CLLocationCoordinate2D)coordinate __attribute__((warn_unused_result("")));
		[Static]
		[Export ("fromCenter:")]
		TMBCircleAnnotation FromCenter (CLLocationCoordinate2D coordinate);
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
		ITMBAnnotationInteractionDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TMBAnnotationInteractionDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	// @interface TMBExpression : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13TMBExpression")]
	[DisableDefaultCtor]
	interface TMBExpression
	{
		// +(TMBExpression * _Nonnull)createWithOperator:(enum TMBOperator)operator_ __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithOperator:")]
		TMBExpression CreateWithOperator (TMBOperator operator_);

		// +(TMBExpression * _Nonnull)createWithOperator:(enum TMBOperator)operator_ arguments:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithOperator:arguments:")]
		TMBExpression CreateWithOperator (TMBOperator operator_, NSObject[] arguments);
	}

	// @protocol TMBGeoData
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol (Name = "_TtP13MapboxMapObjC10TMBGeoData_")]
	[BaseType(typeof(NSObject))]
	interface TMBGeoData
	{
	}

	partial interface ITMBGeoData { }

	// @interface TMBGeometry : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC11TMBGeometry")]
	[DisableDefaultCtor]
	interface TMBGeometry
	{
		// +(TMBGeometry * _Nonnull)fromData:(id<TMBGeoData> _Nonnull)data __attribute__((warn_unused_result("")));
		[Static]
		[Export ("fromData:")]
		TMBGeometry FromData (TMBGeoData data);
	}

	// @interface TMBPoint : NSObject <TMBGeoData>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC8TMBPoint")]
	[DisableDefaultCtor]
	interface TMBPoint : TMBGeoData
	{
		// +(TMBPoint * _Nonnull)withCoordinates:(CLLocationCoordinate2D)coordinates __attribute__((warn_unused_result("")));
		[Static]
		[Export ("withCoordinates:")]
		TMBPoint WithCoordinates (CLLocationCoordinate2D coordinates);
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
	}

	// @interface TMBPolygon : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC10TMBPolygon")]
	[DisableDefaultCtor]
	interface TMBPolygon
	{
		// -(instancetype _Nonnull)initWithOuterRingCoordinates:(NSArray<NSValue *> * _Nonnull)outerRingCoordinates innerRingCoordinates:(NSArray<NSArray<NSValue *> *> * _Nonnull)innerRingCoordinates __attribute__((objc_designated_initializer));
		[Export ("initWithOuterRingCoordinates:innerRingCoordinates:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSValue[] outerRingCoordinates, NSArray<NSValue>[] innerRingCoordinates);
		// - (nonnull instancetype)init:(NSArray<NSArray<NSValue *> *> * _Nonnull)coordinates OBJC_DESIGNATED_INITIALIZER;
		[Export ("init:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSArray coordinates);

		// +(TMBPolygon * _Nonnull)createWithOuterRingCoordinates:(NSArray<NSValue *> * _Nonnull)outerRingCoordinates innerRingCoordinates:(NSArray<NSArray<NSValue *> *> * _Nonnull)innerRingCoordinates __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithOuterRingCoordinates:innerRingCoordinates:")]
		TMBPolygon CreateWithOuterRingCoordinates (NSValue[] outerRingCoordinates, NSArray<NSValue>[] innerRingCoordinates);

		// + (TMBPolygon * _Nonnull)fromCoordinates:(NSArray<NSArray<NSValue *> *> * _Nonnull)coordinates SWIFT_WARN_UNUSED_RESULT;
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

		// @property (nonatomic, strong) UIColor * _Nullable fillColor;
		[NullAllowed, Export ("fillColor", ArgumentSemantic.Strong)]
		UIColor FillColor { get; set; }

		// @property (nonatomic) double fillOpacity;
		[Export ("fillOpacity")]
		double FillOpacity { get; set; }

		// +(TMBPolygonAnnotation * _Nonnull)polygon:(TMBPolygon * _Nonnull)polygon __attribute__((warn_unused_result("")));
		[Static]
		[Export ("polygon:")]
		TMBPolygonAnnotation Polygon (TMBPolygon polygon);
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

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		TMBAnnotationInteractionDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TMBAnnotationInteractionDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	// @interface TMBResolvedImage : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC16TMBResolvedImage")]
	[DisableDefaultCtor]
	interface TMBResolvedImage
	{
	}

	// @interface MapboxMapObjC_Swift_1283 (TMBResolvedImage)
	[Category]
	[BaseType (typeof(TMBResolvedImage))]
	interface TMBResolvedImage_MapboxMapObjC_Swift_1283
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

	// @interface TMBStyle : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC8TMBStyle")]
	[DisableDefaultCtor]
	interface TMBStyle
	{
		// -(void)addImage:(UIImage * _Nonnull)image id:(NSString * _Nonnull)id completion:(void (^ _Nullable)(NSError * _Nonnull))completion;
		[Export ("addImage:id:completion:")]
		void AddImage (UIImage image, string id, [NullAllowed] Action<NSError> completion);
	}

	// @interface TMBStyleTransition : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBStyleTransition")]
	[DisableDefaultCtor]
	interface TMBStyleTransition
	{
		// -(instancetype _Nonnull)initWithDuration:(double)duration delay:(double)delay __attribute__((objc_designated_initializer));
		[Export ("initWithDuration:delay:")]
		[DesignatedInitializer]
		IntPtr Constructor (double duration, double delay);
	}

	// @interface TMBTerrain : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC10TMBTerrain")]
	[DisableDefaultCtor]
	interface TMBTerrain
	{
		// -(instancetype _Nonnull)initWithSourceId:(NSString * _Nonnull)sourceId __attribute__((objc_designated_initializer));
		[Export ("initWithSourceId:")]
		[DesignatedInitializer]
		IntPtr Constructor (string sourceId);

		// @property (nonatomic, strong) TMBValue * _Nullable exaggeration;
		[NullAllowed, Export ("exaggeration", ArgumentSemantic.Strong)]
		TMBValue Exaggeration { get; set; }
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
	}

	// @interface MapboxMapObjC_Swift_1503
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_1503
	{
		// +(id)getDefault __attribute__((warn_unused_result("")));
		[Static]
		[Export ("getDefault")]
		MBXTileStore GetDefault();

		// -(TMBCancelable * _Nonnull)loadTileRegionForId:(NSString * _Nonnull)id loadOptions:(MBXTileRegionLoadOptions * _Nonnull)loadOptions progress:(id)progress completion:(void (^ _Nonnull)(MBXTileRegion * _Nullable, NSError * _Nullable))completion;
		[Export ("loadTileRegionForId:loadOptions:progress:completion:")]
		TMBCancelable LoadTileRegionForId (string id, MBXTileRegionLoadOptions loadOptions, NSObject progress, Action<MBXTileRegion, NSError> completion);

		// -(void)allTileRegions:(void (^ _Nonnull)(NSArray<MBXTileRegion *> * _Nullable, NSError * _Nullable))completion;
		[Export ("allTileRegions:")]
		void AllTileRegions (Action<NSArray<MBXTileRegion>, NSError> completion);
	}
}
