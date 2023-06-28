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

	// @interface MapboxMapObjC_Swift_375
    [Category]
    [BaseType(typeof(MapInitOptions))]
	interface MapboxMapObjC_Swift_375
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

	// @interface MapboxMapObjC_Swift_400
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_400
	{
		// -(TMBGestureManager * _Nonnull)gestureManager __attribute__((warn_unused_result("")));
		[Export ("gestureManager")]
		TMBGestureManager GestureManager();
	}

	// @interface MapboxMapObjC_Swift_406
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_406
	{
		// -(void)updateSkyLayer:(NSString * _Nonnull)id configure:(void (^ _Nonnull)(SkyLayerBuilder * _Nonnull))configure onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("updateSkyLayer:configure:onError:")]
		void UpdateSkyLayer (string id, Action<SkyLayerBuilder> configure, [NullAllowed] Action<NSError> onError);
	}

	// @interface MapboxMapObjC_Swift_412
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_412
	{
		// -(void)setTerrain:(TMBTerrain * _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("setTerrain:onError:")]
		void SetTerrain (TMBTerrain value, [NullAllowed] Action<NSError> onError);
	}

	// @interface MapboxMapObjC_Swift_418
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_418
	{
		// -(void)ornamentsOptionsScaleBarVisibility:(enum TMBOrnamentVisibility)value;
		[Export ("ornamentsOptionsScaleBarVisibility:")]
		void OrnamentsOptionsScaleBarVisibility (TMBOrnamentVisibility value);
	}

	// @interface MapboxMapObjC_Swift_424
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_424
	{
		// -(void)addRasterDemSource:(NSString * _Nonnull)id configure:(void (^ _Nonnull)(RasterDemSourceBuilder * _Nonnull))configure onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("addRasterDemSource:configure:onError:")]
		void AddRasterDemSource (string id, Action<RasterDemSourceBuilder> configure, [NullAllowed] Action<NSError> onError);
	}

	// @interface MapboxMapObjC_Swift_430
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_430
	{
		// -(void)updateSymbolLayer:(NSString * _Nonnull)id configure:(void (^ _Nonnull)(SymbolLayerBuilder * _Nonnull))configure onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("updateSymbolLayer:configure:onError:")]
		void UpdateSymbolLayer (string id, Action<SymbolLayerBuilder> configure, [NullAllowed] Action<NSError> onError);
	}

	// @interface MapboxMapObjC_Swift_435
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_435
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

	// @interface MapboxMapObjC_Swift_442
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_442
	{
		// -(void)setCameraTo:(MBMCameraOptions * _Nonnull)cameraOptions;
		[Export ("setCameraTo:")]
		void SetCameraTo (MBMCameraOptions cameraOptions);

		// -(CLLocationCoordinate2D)coordinateFromScreenPosition:(CGPoint)point __attribute__((warn_unused_result("")));
		[Export ("coordinateFromScreenPosition:")]
		CLLocationCoordinate2D CoordinateFromScreenPosition (CGPoint point);

		// -(NSArray<NSValue *> * _Nonnull)coordinateFromScreenPositions:(NSArray<NSValue *> * _Nonnull)point __attribute__((warn_unused_result("")));
		[Export ("coordinateFromScreenPositions:")]
        NSArray CoordinateFromScreenPositions (NSArray point);
	}

	// @interface MapboxMapObjC_Swift_452
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_452
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

	// @interface MapboxMapObjC_Swift_466
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_466
	{
		// -(TMBPolygonAnnotationManager * _Nonnull)polygonAnnotationManagerWithId:(NSString * _Nullable)id layerPosition:(enum TMBLayerPosition)layerPosition layerPositionParam:(id _Nullable)layerPositionParam __attribute__((warn_unused_result("")));
		[Export ("polygonAnnotationManagerWithId:layerPosition:layerPositionParam:")]
		TMBPolygonAnnotationManager PolygonAnnotationManagerWithId ([NullAllowed] string id, TMBLayerPosition layerPosition, [NullAllowed] NSObject layerPositionParam);

		// -(TMBCircleAnnotationManager * _Nonnull)circleAnnotationManagerWithId:(NSString * _Nullable)id layerPosition:(enum TMBLayerPosition)layerPosition layerPositionParam:(id _Nullable)layerPositionParam __attribute__((warn_unused_result("")));
		[Export ("circleAnnotationManagerWithId:layerPosition:layerPositionParam:")]
		TMBCircleAnnotationManager CircleAnnotationManagerWithId ([NullAllowed] string id, TMBLayerPosition layerPosition, [NullAllowed] NSObject layerPositionParam);

		// -(TMBPointAnnotationManager * _Nonnull)pointAnnotationManagerWithId:(NSString * _Nullable)id layerPosition:(enum TMBLayerPosition)layerPosition layerPositionParam:(id _Nullable)layerPositionParam clusterOptions:(TMBClusterOptions * _Nullable)clusterOptions __attribute__((warn_unused_result("")));
		[Export ("pointAnnotationManagerWithId:layerPosition:layerPositionParam:clusterOptions:")]
		TMBPointAnnotationManager PointAnnotationManagerWithId ([NullAllowed] string id, TMBLayerPosition layerPosition, [NullAllowed] NSObject layerPositionParam, [NullAllowed] TMBClusterOptions clusterOptions);

		// -(TMBPolylineAnnotationManager * _Nonnull)polylineAnnotationManagerWithId:(NSString * _Nullable)id layerPosition:(enum TMBLayerPosition)layerPosition layerPositionParam:(id _Nullable)layerPositionParam __attribute__((warn_unused_result("")));
		[Export ("polylineAnnotationManagerWithId:layerPosition:layerPositionParam:")]
		TMBPolylineAnnotationManager PolylineAnnotationManagerWithId ([NullAllowed] string id, TMBLayerPosition layerPosition, [NullAllowed] NSObject layerPositionParam);
	}

	// @interface MapboxMapObjC_Swift_480
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_480
	{
		// -(TMBCancelable * _Nonnull)queryRenderedFeaturesWithin:(NSArray<NSValue *> * _Nonnull)shape options:(MBMRenderedQueryOptions * _Nullable)options completion:(void (^ _Nullable)(NSArray<MBMQueriedFeature *> * _Nullable, NSError * _Nullable))completion __attribute__((warn_unused_result("")));
		[Export ("queryRenderedFeaturesWithin:options:completion:")]
		TMBCancelable QueryRenderedFeaturesWithin (NSArray shape, [NullAllowed] MBMRenderedQueryOptions options, [NullAllowed] Action<MBMQueriedFeature[], NSError> completion);

		// -(TMBCancelable * _Nonnull)queryRenderedFeaturesIn:(CGRect)rect options:(MBMRenderedQueryOptions * _Nullable)options completion:(void (^ _Nullable)(NSArray<MBMQueriedFeature *> * _Nullable, NSError * _Nullable))completion __attribute__((warn_unused_result("")));
		[Export ("queryRenderedFeaturesIn:options:completion:")]
		TMBCancelable QueryRenderedFeaturesIn (CGRect rect, [NullAllowed] MBMRenderedQueryOptions options, [NullAllowed] Action<MBMQueriedFeature[], NSError> completion);

		// -(TMBCancelable * _Nonnull)queryRenderedFeaturesWith:(CGPoint)point options:(MBMRenderedQueryOptions * _Nullable)options completion:(void (^ _Nullable)(NSArray<MBMQueriedFeature *> * _Nullable, NSError * _Nullable))completion __attribute__((warn_unused_result("")));
		[Export ("queryRenderedFeaturesWith:options:completion:")]
		TMBCancelable QueryRenderedFeaturesWith (CGPoint point, [NullAllowed] MBMRenderedQueryOptions options, [NullAllowed] Action<MBMQueriedFeature[], NSError> completion);

		// -(void)querySourceFeaturesFor:(NSString * _Nonnull)sourceId options:(MBMSourceQueryOptions * _Nonnull)options completion:(void (^ _Nullable)(NSArray<MBMQueriedFeature *> * _Nullable, NSError * _Nullable))completion;
		[Export ("querySourceFeaturesFor:options:completion:")]
		void QuerySourceFeaturesFor (string sourceId, MBMSourceQueryOptions options, [NullAllowed] Action<MBMQueriedFeature[], NSError> completion);

		// -(void)queryFeatureExtensionFor:(NSString * _Nonnull)sourceId feature:(MBXFeature * _Nonnull)feature extension:(NSString * _Nonnull)extension extensionField:(NSString * _Nonnull)extensionField args:(NSDictionary<NSString *,id> * _Nullable)args completion:(void (^ _Nullable)(MBMFeatureExtensionValue * _Nullable, NSError * _Nullable))completion;
		[Export ("queryFeatureExtensionFor:feature:extension:extensionField:args:completion:")]
		void QueryFeatureExtensionFor (string sourceId, MBXFeature feature, string extension, string extensionField, [NullAllowed] NSDictionary<NSString, NSObject> args, [NullAllowed] Action<MBMFeatureExtensionValue, NSError> completion);
	}

	// @interface MapboxMapObjC_Swift_491
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_491
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

		// -(void)addImageWithId:(NSString * _Nonnull)id image:(UIImage * _Nonnull)image sdf:(BOOL)sdf contentInsets:(UIEdgeInsets)contentInsets completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addImageWithId:image:sdf:contentInsets:completion:")]
		void AddImageWithId (string id, UIImage image, bool sdf, UIEdgeInsets contentInsets, [NullAllowed] Action<NSError> completion);

		// -(void)removeImageWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("removeImageWithId:completion:")]
		void RemoveImageWithId (string id, [NullAllowed] Action<NSError> completion);

		// -(BOOL)imageExistsWithId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("imageExistsWithId:")]
		bool ImageExistsWithId (string id);
	}

	// @interface MapboxMapObjC_Swift_502
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_502
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

		// -(void)addGeoJSONSourceWithId:(NSString * _Nonnull)id properties:(NSDictionary<NSString *,id> * _Nonnull)properties geojson:(NSString * _Nonnull)geojson onComplete:(void (^ _Nullable)(NSError * _Nullable))onComplete;
		[Export ("addGeoJSONSourceWithId:properties:geojson:onComplete:")]
		void AddGeoJSONSourceWithId (string id, NSDictionary<NSString, NSObject> properties, string geojson, [NullAllowed] Action<NSError> onComplete);

		// -(void)updateGeoJSONSourceWithId:(NSString * _Nonnull)id geojson:(NSString * _Nonnull)geojson onComplete:(void (^ _Nullable)(NSError * _Nullable))onComplete;
		[Export ("updateGeoJSONSourceWithId:geojson:onComplete:")]
		void UpdateGeoJSONSourceWithId (string id, string geojson, [NullAllowed] Action<NSError> onComplete);
	}

	// @interface MapboxMapObjC_Swift_516
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_516
	{
		// -(void)setLightProperty:(NSString * _Nonnull)name value:(id _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("setLightProperty:value:onError:")]
		void SetLightProperty (string name, NSObject value, [NullAllowed] Action<NSError> onError);

		// -(void)setLightWithProperties:(NSDictionary<NSString *,id> * _Nonnull)properties onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
		[Export ("setLightWithProperties:onError:")]
		void SetLightWithProperties (NSDictionary<NSString, NSObject> properties, [NullAllowed] Action<NSError> onError);

		// -(void)lightAnchor:(TMBAnchor * _Nonnull)value onError:(void (^ _Nullable)(NSError * _Nonnull))onError;
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

	// @interface MapboxMapObjC_Swift_540
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_540
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
	}

	// @interface MapboxMapObjC_Swift_554
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_554
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

	// @interface MapboxMapObjC_Swift_569
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_569
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

	partial interface INamedString {}

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

	// @interface MapboxMapObjC_Swift_664
    [Category]
    [BaseType(typeof(MBMOfflineManager))]
	interface MapboxMapObjC_Swift_664
	{
		// -(TMBCancelable * _Nonnull)loadStyleWithStyleUriString:(NSString * _Nonnull)styleUriString styleLoadOptions:(MBMStylePackLoadOptions * _Nonnull)styleLoadOptions progress:(id)progress completion:(void (^ _Nonnull)(MBMStylePack * _Nullable, NSError * _Nullable))completion __attribute__((warn_unused_result("")));
		[Export ("loadStyleWithStyleUriString:styleLoadOptions:progress:completion:")]
		TMBCancelable LoadStyleWithStyleUriString (string styleUriString, MBMStylePackLoadOptions styleLoadOptions, Action<MBMStylePackLoadProgress> progress, Action<MBMStylePack, NSError> completion);

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

		// -(RasterDemSourceBuilder * _Nonnull)encoding:(TMBEncoding * _Nullable)value;
		[Export ("encoding:")]
		RasterDemSourceBuilder Encoding ([NullAllowed] TMBEncoding value);

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
*/[Protocol (Name = "_TtP13MapboxMapObjC20TMBAnnotationManager_")]
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
		ITMBAnnotationInteractionDelegate Delegate { get; set; }

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
	interface TMBExpression : INativeObject
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export ("debugDescription")]
		string DebugDescription { get; }

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
	[Protocol (Name = "_TtP13MapboxMapObjC10TMBGeoData_"), Model]
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
		TMBGeometry FromData (ITMBGeoData data);
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
		TMBIconPitchAlignment Auto_ { [Bind ("auto")] get; }
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
		TMBIconRotationAlignment Auto_ { [Bind ("auto")] get; }
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
		IntPtr Constructor (NSValue[] outerRingCoordinates, NSArray<NSValue>[] innerRingCoordinates);

		// -(instancetype _Nonnull)init:(NSArray<NSArray<NSValue *> *> * _Nonnull)coordinates __attribute__((objc_designated_initializer));
		[Export ("init:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSArray coordinates);

		// +(TMBPolygon * _Nonnull)createWithOuterRingCoordinates:(NSArray<NSValue *> * _Nonnull)outerRingCoordinates innerRingCoordinates:(NSArray<NSArray<NSValue *> *> * _Nonnull)innerRingCoordinates __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithOuterRingCoordinates:innerRingCoordinates:")]
		TMBPolygon CreateWithOuterRingCoordinates (NSValue[] outerRingCoordinates, NSArray<NSValue>[] innerRingCoordinates);

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
		TMBPolylineAnnotation FromId (string id, NSArray coordinates, bool isSelected, bool isDraggable);

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

	// @interface MapboxMapObjC_Swift_2037 (TMBResolvedImage)
	[Category]
	[BaseType (typeof(TMBResolvedImage))]
	interface TMBResolvedImage_MapboxMapObjC_Swift_2037
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

	// @interface TMBSourceType : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13TMBSourceType")]
	[DisableDefaultCtor]
	interface TMBSourceType : NamedString
	{
		// -(instancetype _Nonnull)initWithValue:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string value);

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
		// -(void)addImageWithId:(NSString * _Nonnull)id image:(UIImage * _Nonnull)image sdf:(BOOL)sdf contentInsets:(UIEdgeInsets)contentInsets completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addImageWithId:image:sdf:contentInsets:completion:")]
		void AddImageWithId (string id, UIImage image, bool sdf, UIEdgeInsets contentInsets, [NullAllowed] Action<NSError> completion);

		// -(void)removeImageWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("removeImageWithId:completion:")]
		void RemoveImageWithId (string id, [NullAllowed] Action<NSError> completion);

		// -(BOOL)imageExistsWithId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("imageExistsWithId:")]
		bool ImageExistsWithId (string id);
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
		// -(instancetype _Nonnull)initWithDuration:(double)duration delay:(double)delay __attribute__((objc_designated_initializer));
		[Export ("initWithDuration:delay:")]
		[DesignatedInitializer]
		IntPtr Constructor (double duration, double delay);
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
		TMBSymbolZOrder Auto_ { [Bind ("auto")] get; }

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
		// -(instancetype _Nonnull)initWithSourceId:(NSString * _Nonnull)sourceId __attribute__((objc_designated_initializer));
		[Export ("initWithSourceId:")]
		[DesignatedInitializer]
		IntPtr Constructor (string sourceId);

		// @property (nonatomic, strong) TMBValue * _Nullable exaggeration;
		[NullAllowed, Export ("exaggeration", ArgumentSemantic.Strong)]
		TMBValue Exaggeration { get; set; }
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

	// @interface MapboxMapObjC_Swift_2362
    [Category]
    [BaseType(typeof(MBXTileStore))]
	interface MapboxMapObjC_Swift_2362
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
