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

	// @interface MapboxMapObjC_Swift_347
    [Category]
    [BaseType(typeof(MapInitOptions))]
	interface MapboxMapObjC_Swift_347
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

	// @interface MapInitOptionsFactory : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC21MapInitOptionsFactory")]
	interface MapInitOptionsFactory
	{
		// +(id)createWithResourceOptions:(MBMResourceOptions * _Nullable)resourceOptions mapOptions:(MBMMapOptions * _Nullable)mapOptions cameraOptions:(MBMCameraOptions * _Nullable)cameraOptions styleURI:(NSString * _Nullable)styleURI styleJSON:(NSString * _Nullable)styleJSON __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithResourceOptions:mapOptions:cameraOptions:styleURI:styleJSON:")]
		MapInitOptions CreateWithResourceOptions ([NullAllowed] MBMResourceOptions resourceOptions = null, [NullAllowed] MBMMapOptions mapOptions = null, [NullAllowed] MBMCameraOptions cameraOptions = null, [NullAllowed] string styleURI = null, [NullAllowed] string styleJSON = null);
	}

	// @interface MapboxMapObjC_Swift_385
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_385
	{
		// -(TMBViewport * _Nonnull)viewport __attribute__((warn_unused_result("")));
		[Export ("viewport")]
		TMBViewport Viewport();
	}

	// @interface MapboxMapObjC_Swift_391
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_391
	{
		// -(TMBGestureManager * _Nonnull)gestures __attribute__((warn_unused_result("")));
		[Export ("gestures")]
		TMBGestureManager Gestures();
	}

	// @interface MapboxMapObjC_Swift_397
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_397
	{
		// -(TMBViewAnnotationManager * _Nonnull)viewAnnotations __attribute__((warn_unused_result("")));
		[Export ("viewAnnotations")]
		TMBViewAnnotationManager ViewAnnotations();
	}

	// @interface MapboxMapObjC_Swift_403
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_403
	{
		// -(TMBAnnotationOrchestrator * _Nonnull)annotations __attribute__((warn_unused_result("")));
		[Export ("annotations")]
		TMBAnnotationOrchestrator Annotations();
	}

	// @interface MapboxMapObjC_Swift_409
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_409
	{
		// -(TMBCameraAnimationsManager * _Nonnull)camera __attribute__((warn_unused_result("")));
		[Export ("camera")]
		TMBCameraAnimationsManager Camera();
	}

	// @interface MapboxMapObjC_Swift_415
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_415
	{
		// -(TMBMapboxMap * _Nonnull)mapboxMap __attribute__((warn_unused_result("")));
		[Export ("mapboxMap")]
		TMBMapboxMap MapboxMap();
	}

	// @interface MapboxMapObjC_Swift_421
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_421
	{
		// -(TMBOrnamentsManager * _Nonnull)ornaments __attribute__((warn_unused_result("")));
		[Export ("ornaments")]
		TMBOrnamentsManager Ornaments();
	}

	// @interface MapboxMapObjC_Swift_429
    [Category]
    [BaseType(typeof(MapView))]
	interface MapboxMapObjC_Swift_429
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
        // [iOS (15,0)]
        [Export ("getPreferredFrameRateRange")]
		CAFrameRateRange PreferredFrameRateRange();

		// -(void)setPreferredFrameRateRange:(CAFrameRateRange)value __attribute__((availability(ios, introduced=15.0)));
		// [iOS (15,0)]
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

	// @interface MapboxMapObjC_Swift_458 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_458
	{
		// +(NSNumber * _Nonnull)valueWithSourceType:(enum TMBSourceType)sourceType __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithSourceType:")]
		NSNumber ValueWithSourceType (TMBSourceType sourceType);

		// -(enum TMBSourceType)sourceType __attribute__((warn_unused_result("")));
		[Export ("sourceType")]
		TMBSourceType SourceType();
	}

	// @interface MapboxMapObjC_Swift_465 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_465
	{
		// +(NSNumber * _Nonnull)valueWithScheme:(enum TMBScheme)scheme __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithScheme:")]
		NSNumber ValueWithScheme (TMBScheme scheme);

		// -(enum TMBScheme)scheme __attribute__((warn_unused_result("")));
		[Export ("scheme")]
		TMBScheme Scheme();
	}

	// @interface MapboxMapObjC_Swift_473 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_473
	{
		// +(NSNumber * _Nonnull)valueWithEncoding:(enum TMBEncoding)encoding __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithEncoding:")]
		NSNumber ValueWithEncoding (TMBEncoding encoding);

		// -(enum TMBEncoding)encoding __attribute__((warn_unused_result("")));
		[Export ("encoding")]
		TMBEncoding Encoding();
	}

	// @interface MapboxMapObjC_Swift_481 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_481
	{
		// +(NSNumber * _Nonnull)valueWithTextWritingMode:(enum TMBTextWritingMode)textWritingMode __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithTextWritingMode:")]
		NSNumber ValueWithTextWritingMode (TMBTextWritingMode textWritingMode);

		// -(enum TMBTextWritingMode)textWritingMode __attribute__((warn_unused_result("")));
		[Export ("textWritingMode")]
		TMBTextWritingMode TextWritingMode();
	}

	// @interface MapboxMapObjC_Swift_489 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_489
	{
		// +(NSNumber * _Nonnull)valueWithStyleProjectionName:(enum TMBStyleProjectionName)styleProjectionName __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithStyleProjectionName:")]
		NSNumber ValueWithStyleProjectionName (TMBStyleProjectionName styleProjectionName);

		// -(enum TMBStyleProjectionName)styleProjectionName __attribute__((warn_unused_result("")));
		[Export ("styleProjectionName")]
		TMBStyleProjectionName StyleProjectionName();
	}

	// @interface MapboxMapObjC_Swift_497 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_497
	{
		// +(NSNumber * _Nonnull)valueWithAnchor:(enum TMBAnchor)anchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithAnchor:")]
		NSNumber ValueWithAnchor (TMBAnchor anchor);

		// -(enum TMBAnchor)anchor __attribute__((warn_unused_result("")));
		[Export ("anchor")]
		TMBAnchor Anchor();
	}

	// @interface MapboxMapObjC_Swift_505 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_505
	{
		// +(NSNumber * _Nonnull)valueWithSkyType:(enum TMBSkyType)skyType __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithSkyType:")]
		NSNumber ValueWithSkyType (TMBSkyType skyType);

		// -(enum TMBSkyType)skyType __attribute__((warn_unused_result("")));
		[Export ("skyType")]
		TMBSkyType SkyType();
	}

	// @interface MapboxMapObjC_Swift_513 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_513
	{
		// +(NSNumber * _Nonnull)valueWithHillshadeIlluminationAnchor:(enum TMBHillshadeIlluminationAnchor)hillshadeIlluminationAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithHillshadeIlluminationAnchor:")]
		NSNumber ValueWithHillshadeIlluminationAnchor (TMBHillshadeIlluminationAnchor hillshadeIlluminationAnchor);

		// -(enum TMBHillshadeIlluminationAnchor)hillshadeIlluminationAnchor __attribute__((warn_unused_result("")));
		[Export("hillshadeIlluminationAnchor")]
		TMBHillshadeIlluminationAnchor HillshadeIlluminationAnchor();
	}

	// @interface MapboxMapObjC_Swift_521 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_521
	{
		// +(NSNumber * _Nonnull)valueWithRasterResampling:(enum TMBRasterResampling)rasterResampling __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithRasterResampling:")]
		NSNumber ValueWithRasterResampling (TMBRasterResampling rasterResampling);

		// -(enum TMBRasterResampling)rasterResampling __attribute__((warn_unused_result("")));
		[Export ("rasterResampling")]
		TMBRasterResampling RasterResampling();
	}

	// @interface MapboxMapObjC_Swift_529 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_529
	{
		// +(NSNumber * _Nonnull)valueWithFillExtrusionTranslateAnchor:(enum TMBFillExtrusionTranslateAnchor)fillExtrusionTranslateAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithFillExtrusionTranslateAnchor:")]
		NSNumber ValueWithFillExtrusionTranslateAnchor (TMBFillExtrusionTranslateAnchor fillExtrusionTranslateAnchor);

		// -(enum TMBFillExtrusionTranslateAnchor)fillExtrusionTranslateAnchor __attribute__((warn_unused_result("")));
		[Export ("fillExtrusionTranslateAnchor")]
		TMBFillExtrusionTranslateAnchor FillExtrusionTranslateAnchor();
	}

	// @interface MapboxMapObjC_Swift_537 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_537
	{
		// +(NSNumber * _Nonnull)valueWithCircleTranslateAnchor:(enum TMBCircleTranslateAnchor)circleTranslateAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithCircleTranslateAnchor:")]
		NSNumber ValueWithCircleTranslateAnchor (TMBCircleTranslateAnchor circleTranslateAnchor);

		// -(enum TMBCircleTranslateAnchor)circleTranslateAnchor __attribute__((warn_unused_result("")));
		[Export ("circleTranslateAnchor")]
		TMBCircleTranslateAnchor CircleTranslateAnchor();
	}

	// @interface MapboxMapObjC_Swift_545 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_545
	{
		// +(NSNumber * _Nonnull)valueWithCirclePitchScale:(enum TMBCirclePitchScale)circlePitchScale __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithCirclePitchScale:")]
		NSNumber ValueWithCirclePitchScale (TMBCirclePitchScale circlePitchScale);

		// -(enum TMBCirclePitchScale)circlePitchScale __attribute__((warn_unused_result("")));
		[Export ("circlePitchScale")]
		TMBCirclePitchScale CirclePitchScale();
	}

	// @interface MapboxMapObjC_Swift_552 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_552
	{
		// +(NSNumber * _Nonnull)valueWithLayerType:(enum TMBLayerType)layerType __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithLayerType:")]
		NSNumber ValueWithLayerType (TMBLayerType layerType);

		// -(enum TMBLayerType)layerType __attribute__((warn_unused_result("")));
		[Export ("layerType")]
		TMBLayerType LayerType();
	}

	// @interface MapboxMapObjC_Swift_561 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_561
	{
		// +(NSNumber * _Nonnull)valueWithCirclePitchAlignment:(enum TMBCirclePitchAlignment)circlePitchAlignment __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithCirclePitchAlignment:")]
		NSNumber ValueWithCirclePitchAlignment (TMBCirclePitchAlignment circlePitchAlignment);

		// -(enum TMBCirclePitchAlignment)circlePitchAlignment __attribute__((warn_unused_result("")));
		[Export ("circlePitchAlignment")]
		TMBCirclePitchAlignment CirclePitchAlignment();
	}

	// @interface MapboxMapObjC_Swift_569 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_569
	{
		// +(NSNumber * _Nonnull)valueWithTextTranslateAnchor:(enum TMBTextTranslateAnchor)textTranslateAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithTextTranslateAnchor:")]
		NSNumber ValueWithTextTranslateAnchor (TMBTextTranslateAnchor textTranslateAnchor);

		// -(enum TMBTextTranslateAnchor)textTranslateAnchor __attribute__((warn_unused_result("")));
		[Export ("textTranslateAnchor")]
		TMBTextTranslateAnchor TextTranslateAnchor();
	}

	// @interface MapboxMapObjC_Swift_577 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_577
	{
		// +(NSNumber * _Nonnull)valueWithIconTranslateAnchor:(enum TMBIconTranslateAnchor)iconTranslateAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithIconTranslateAnchor:")]
		NSNumber ValueWithIconTranslateAnchor (TMBIconTranslateAnchor iconTranslateAnchor);

		// -(enum TMBIconTranslateAnchor)iconTranslateAnchor __attribute__((warn_unused_result("")));
		[Export ("iconTranslateAnchor")]
		TMBIconTranslateAnchor IconTranslateAnchor();
	}

	// @interface MapboxMapObjC_Swift_585 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_585
	{
		// +(NSNumber * _Nonnull)valueWithLineTranslateAnchor:(enum TMBLineTranslateAnchor)lineTranslateAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithLineTranslateAnchor:")]
		NSNumber ValueWithLineTranslateAnchor (TMBLineTranslateAnchor lineTranslateAnchor);

		// -(enum TMBLineTranslateAnchor)lineTranslateAnchor __attribute__((warn_unused_result("")));
		[Export ("lineTranslateAnchor")]
		TMBLineTranslateAnchor LineTranslateAnchor();
	}

	// @interface MapboxMapObjC_Swift_593 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_593
	{
		// +(NSNumber * _Nonnull)valueWithFillTranslateAnchor:(enum TMBFillTranslateAnchor)fillTranslateAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithFillTranslateAnchor:")]
		NSNumber ValueWithFillTranslateAnchor (TMBFillTranslateAnchor fillTranslateAnchor);

		// -(enum TMBFillTranslateAnchor)fillTranslateAnchor __attribute__((warn_unused_result("")));
		[Export ("fillTranslateAnchor")]
		TMBFillTranslateAnchor FillTranslateAnchor();
	}

	// @interface MapboxMapObjC_Swift_601 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_601
	{
		// +(NSNumber * _Nonnull)valueWithTextTransform:(enum TMBTextTransform)textTransform __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithTextTransform:")]
		NSNumber ValueWithTextTransform (TMBTextTransform textTransform);

		// -(enum TMBTextTransform)textTransform __attribute__((warn_unused_result("")));
		[Export ("textTransform")]
		TMBTextTransform TextTransform();
	}

	// @interface MapboxMapObjC_Swift_609 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_609
	{
		// +(NSNumber * _Nonnull)valueWithTextRotationAlignment:(enum TMBTextRotationAlignment)textRotationAlignment __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithTextRotationAlignment:")]
		NSNumber ValueWithTextRotationAlignment (TMBTextRotationAlignment textRotationAlignment);

		// -(enum TMBTextRotationAlignment)textRotationAlignment __attribute__((warn_unused_result("")));
		[Export ("textRotationAlignment")]
		TMBTextRotationAlignment TextRotationAlignment();
	}

	// @interface MapboxMapObjC_Swift_617 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_617
	{
		// +(NSNumber * _Nonnull)valueWithTextPitchAlignment:(enum TMBTextPitchAlignment)textPitchAlignment __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithTextPitchAlignment:")]
		NSNumber ValueWithTextPitchAlignment (TMBTextPitchAlignment textPitchAlignment);

		// -(enum TMBTextPitchAlignment)textPitchAlignment __attribute__((warn_unused_result("")));
		[Export ("textPitchAlignment")]
		TMBTextPitchAlignment TextPitchAlignment();
	}

	// @interface MapboxMapObjC_Swift_625 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_625
	{
		// +(NSNumber * _Nonnull)valueWithTextJustify:(enum TMBTextJustify)textJustify __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithTextJustify:")]
		NSNumber ValueWithTextJustify (TMBTextJustify textJustify);

		// -(enum TMBTextJustify)textJustify __attribute__((warn_unused_result("")));
		[Export ("textJustify")]
		TMBTextJustify TextJustify();
	}

	// @interface MapboxMapObjC_Swift_632 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_632
	{
		// +(NSNumber * _Nonnull)valueWithExpressionOperator:(enum TMBExpressionOperator)expressionOperator __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithExpressionOperator:")]
		NSNumber ValueWithExpressionOperator (TMBExpressionOperator expressionOperator);

		// -(enum TMBExpressionOperator)expressionOperator __attribute__((warn_unused_result("")));
		[Export ("expressionOperator")]
		TMBExpressionOperator ExpressionOperator();
	}

	// @interface MapboxMapObjC_Swift_641 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_641
	{
		// +(NSNumber * _Nonnull)valueWithTextAnchor:(enum TMBTextAnchor)textAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithTextAnchor:")]
		NSNumber ValueWithTextAnchor (TMBTextAnchor textAnchor);

		// -(enum TMBTextAnchor)textAnchor __attribute__((warn_unused_result("")));
		[Export ("textAnchor")]
		TMBTextAnchor TextAnchor();
	}

	// @interface MapboxMapObjC_Swift_648 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_648
	{
		// +(NSNumber * _Nonnull)valueWithVisibility:(enum TMBVisibility)visibility __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithVisibility:")]
		NSNumber ValueWithVisibility (TMBVisibility visibility);

		// -(enum TMBVisibility)visibility __attribute__((warn_unused_result("")));
		[Export ("visibility")]
		TMBVisibility Visibility();
	}

	// @interface MapboxMapObjC_Swift_656 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_656
	{
		// +(NSNumber * _Nonnull)valueWithLineCap:(enum TMBLineCap)lineCap __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithLineCap:")]
		NSNumber ValueWithLineCap (TMBLineCap lineCap);

		// -(enum TMBLineCap)lineCap __attribute__((warn_unused_result("")));
		[Export ("lineCap")]
		TMBLineCap LineCap();
	}

	// @interface MapboxMapObjC_Swift_664 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_664
	{
		// +(NSNumber * _Nonnull)valueWithSymbolZOrder:(enum TMBSymbolZOrder)symbolZOrder __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithSymbolZOrder:")]
		NSNumber ValueWithSymbolZOrder (TMBSymbolZOrder symbolZOrder);

		// -(enum TMBSymbolZOrder)symbolZOrder __attribute__((warn_unused_result("")));
		[Export ("symbolZOrder")]
		TMBSymbolZOrder SymbolZOrder();
	}

	// @interface MapboxMapObjC_Swift_672 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_672
	{
		// +(NSNumber * _Nonnull)valueWithLineJoin:(enum TMBLineJoin)lineJoin __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithLineJoin:")]
		NSNumber ValueWithLineJoin (TMBLineJoin lineJoin);

		// -(enum TMBLineJoin)lineJoin __attribute__((warn_unused_result("")));
		[Export ("lineJoin")]
		TMBLineJoin LineJoin();
	}

	// @interface MapboxMapObjC_Swift_681 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_681
	{
		// +(NSNumber * _Nonnull)valueWithSymbolPlacement:(enum TMBSymbolPlacement)symbolPlacement __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithSymbolPlacement:")]
		NSNumber ValueWithSymbolPlacement (TMBSymbolPlacement symbolPlacement);

		// -(enum TMBSymbolPlacement)symbolPlacement __attribute__((warn_unused_result("")));
		[Export ("symbolPlacement")]
		TMBSymbolPlacement SymbolPlacement();
	}

	// @interface MapboxMapObjC_Swift_688 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_688
	{
		// +(NSNumber * _Nonnull)valueWithIconAnchor:(enum TMBIconAnchor)iconAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithIconAnchor:")]
		NSNumber ValueWithIconAnchor (TMBIconAnchor iconAnchor);

		// -(enum TMBIconAnchor)iconAnchor __attribute__((warn_unused_result("")));
		[Export ("iconAnchor")]
		TMBIconAnchor IconAnchor();
	}

	// @interface MapboxMapObjC_Swift_697 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_697
	{
		// +(NSNumber * _Nonnull)valueWithIconTextFit:(enum TMBIconTextFit)iconTextFit __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithIconTextFit:")]
		NSNumber ValueWithIconTextFit (TMBIconTextFit iconTextFit);

		// -(enum TMBIconTextFit)iconTextFit __attribute__((warn_unused_result("")));
		[Export ("iconTextFit")]
		TMBIconTextFit IconTextFit();
	}

	// @interface MapboxMapObjC_Swift_704 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_704
	{
		// +(NSNumber * _Nonnull)valueWithIconPitchAlignment:(enum TMBIconPitchAlignment)iconPitchAlignment __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithIconPitchAlignment:")]
		NSNumber ValueWithIconPitchAlignment (TMBIconPitchAlignment iconPitchAlignment);

		// -(enum TMBIconPitchAlignment)iconPitchAlignment __attribute__((warn_unused_result("")));
		[Export ("iconPitchAlignment")]
		TMBIconPitchAlignment IconPitchAlignment();
	}

	// @interface MapboxMapObjC_Swift_712 (NSNumber)
	[Category]
	[BaseType (typeof(NSNumber))]
	interface NSNumber_MapboxMapObjC_Swift_712
	{
		// +(NSNumber * _Nonnull)valueWithIconRotationAlignment:(enum TMBIconRotationAlignment)iconRotationAlignment __attribute__((warn_unused_result("")));
		[Static]
		[Export ("valueWithIconRotationAlignment:")]
		NSNumber ValueWithIconRotationAlignment (TMBIconRotationAlignment iconRotationAlignment);

		// -(enum TMBIconRotationAlignment)iconRotationAlignment __attribute__((warn_unused_result("")));
		[Export ("iconRotationAlignment")]
		TMBIconRotationAlignment IconRotationAlignment();
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
	partial interface INamedString {}

	[Protocol (Name = "_TtP13MapboxMapObjC11NamedString_"), Model]
    [BaseType(typeof(NSObject))]
	interface NamedString
	{
		// @required -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("stringValue")]
		string StringValue { get; }
	}

	// @interface MapboxMapObjC_Swift_731
    [Category]
    [BaseType(typeof(MBMOfflineManager))]
	interface MapboxMapObjC_Swift_731
	{
		// -(TMBCancelable * _Nonnull)loadStyleWithStyleUriString:(NSString * _Nonnull)styleUriString styleLoadOptions:(MBMStylePackLoadOptions * _Nonnull)styleLoadOptions progress:(id)progress completion:(void (^ _Nonnull)(MBMStylePack * _Nullable, NSError * _Nullable))completion __attribute__((warn_unused_result("")));
		[Export ("loadStyleWithStyleUriString:styleLoadOptions:progress:completion:")]
		TMBCancelable LoadStyleWithStyleUriString (string styleUriString, MBMStylePackLoadOptions styleLoadOptions, Action<MBMStylePackLoadProgress> progress, Action<MBMStylePack, NSError> completion);

		// -(void)allStylePacks:(void (^ _Nonnull)(NSArray<MBMStylePack *> * _Nullable, NSError * _Nullable))completion;
		[Export ("allStylePacks:")]
		void AllStylePacks (Action<NSArray<MBMStylePack>, NSError> completion);
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
	partial interface ITMBAnnotation {}

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
	partial interface ITMBAnnotationManager { }
	
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
		NSDictionary AnnotationManagersById { get; }

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
	partial interface ITMBAttributionURLOpener {}

	[Protocol (Name = "_TtP13MapboxMapObjC23TMBAttributionURLOpener_"), Model]
	[BaseType(typeof(NSObject))]
	interface TMBAttributionURLOpener
	{
		// @required -(void)openAttributionURL:(NSURL * _Nonnull)url;
		[Abstract]
		[Export ("openAttributionURL:")]
		void OpenAttributionURL (NSUrl url);
	}

	// @protocol TMBLayer
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	partial interface ITMBLayer {}
	
	[Protocol (Name = "_TtP13MapboxMapObjC8TMBLayer_"), Model]
	[BaseType(typeof(NSObject))]
	interface TMBLayer
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Abstract]
		[Export ("id")]
		string Id { get; }

		// @required @property (readonly, nonatomic) enum TMBLayerType type;
		[Abstract]
		[Export ("type")]
		TMBLayerType Type { get; }

		// @required @property (nonatomic, strong) TMBExpression * _Nullable filter;
		[Abstract]
		[NullAllowed, Export ("filter", ArgumentSemantic.Strong)]
		TMBExpression Filter { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable source;
		[Abstract]
		[NullAllowed, Export ("source")]
		string Source { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable sourceLayer;
		[Abstract]
		[NullAllowed, Export ("sourceLayer")]
		string SourceLayer { get; set; }

		// @required @property (nonatomic, strong) NSNumber * _Nullable minZoom;
		[Abstract]
		[NullAllowed, Export ("minZoom", ArgumentSemantic.Strong)]
		NSNumber MinZoom { get; set; }

		// @required @property (nonatomic, strong) NSNumber * _Nullable maxZoom;
		[Abstract]
		[NullAllowed, Export ("maxZoom", ArgumentSemantic.Strong)]
		NSNumber MaxZoom { get; set; }
	}

	// @interface TMBBackgroundLayer : NSObject <TMBLayer>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBBackgroundLayer")]
	[DisableDefaultCtor]
	interface TMBBackgroundLayer : TMBLayer
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; set; }

		// @property (readonly, nonatomic) enum TMBLayerType type;
		[Export ("type")]
		TMBLayerType Type { get; }

		// @property (nonatomic, strong) TMBExpression * _Nullable filter;
		[NullAllowed, Export ("filter", ArgumentSemantic.Strong)]
		TMBExpression Filter { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable source;
		[NullAllowed, Export ("source")]
		string Source { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sourceLayer;
		[NullAllowed, Export ("sourceLayer")]
		string SourceLayer { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minZoom;
		[NullAllowed, Export ("minZoom", ArgumentSemantic.Strong)]
		NSNumber MinZoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxZoom;
		[NullAllowed, Export ("maxZoom", ArgumentSemantic.Strong)]
		NSNumber MaxZoom { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable visibility;
		[NullAllowed, Export ("visibility", ArgumentSemantic.Strong)]
		TMBValue Visibility { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable backgroundColor;
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
		TMBValue BackgroundColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable backgroundColorTransition;
		[NullAllowed, Export ("backgroundColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition BackgroundColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable backgroundOpacity;
		[NullAllowed, Export ("backgroundOpacity", ArgumentSemantic.Strong)]
		TMBValue BackgroundOpacity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable backgroundOpacityTransition;
		[NullAllowed, Export ("backgroundOpacityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition BackgroundOpacityTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable backgroundPattern;
		[NullAllowed, Export ("backgroundPattern", ArgumentSemantic.Strong)]
		TMBValue BackgroundPattern { get; set; }

		// @property (nonatomic, strong) SWIFT_DEPRECATED_MSG("This property is deprecated and will be removed in the future. Setting this will have no effect.") TMBStyleTransition * backgroundPatternTransition __attribute__((deprecated("This property is deprecated and will be removed in the future. Setting this will have no effect.")));
		[Export ("backgroundPatternTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition BackgroundPatternTransition { get; set; }
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
		BasicCameraAnimator MakeAnimatorWithDuration (double duration, IUITimingCurveProvider timingParameters, [NullAllowed] TMBAnimationOwner animationOwner, Action<TMBCameraTransition> animations);

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
		ITMBAnnotationInteractionDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TMBAnnotationInteractionDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable circlePitchAlignment;
		[NullAllowed, Export ("circlePitchAlignment", ArgumentSemantic.Strong)]
		NSNumber CirclePitchAlignment { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable circlePitchScale;
		[NullAllowed, Export ("circlePitchScale", ArgumentSemantic.Strong)]
		NSNumber CirclePitchScale { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable circleTranslate;
		[NullAllowed, Export ("circleTranslate", ArgumentSemantic.Copy)]
		NSNumber[] CircleTranslate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable circleTranslateAnchor;
		[NullAllowed, Export ("circleTranslateAnchor", ArgumentSemantic.Strong)]
		NSNumber CircleTranslateAnchor { get; set; }
	}

	// @interface TMBCircleLayer : NSObject <TMBLayer>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC14TMBCircleLayer")]
	[DisableDefaultCtor]
	interface TMBCircleLayer : TMBLayer
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; set; }

		// @property (readonly, nonatomic) enum TMBLayerType type;
		[Export ("type")]
		TMBLayerType Type { get; }

		// @property (nonatomic, strong) TMBExpression * _Nullable filter;
		[NullAllowed, Export ("filter", ArgumentSemantic.Strong)]
		TMBExpression Filter { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable source;
		[NullAllowed, Export ("source")]
		string Source { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sourceLayer;
		[NullAllowed, Export ("sourceLayer")]
		string SourceLayer { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minZoom;
		[NullAllowed, Export ("minZoom", ArgumentSemantic.Strong)]
		NSNumber MinZoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxZoom;
		[NullAllowed, Export ("maxZoom", ArgumentSemantic.Strong)]
		NSNumber MaxZoom { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable visibility;
		[NullAllowed, Export ("visibility", ArgumentSemantic.Strong)]
		TMBValue Visibility { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable circleSortKey;
		[NullAllowed, Export ("circleSortKey", ArgumentSemantic.Strong)]
		TMBValue CircleSortKey { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable circleBlur;
		[NullAllowed, Export ("circleBlur", ArgumentSemantic.Strong)]
		TMBValue CircleBlur { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable circleBlurTransition;
		[NullAllowed, Export ("circleBlurTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition CircleBlurTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable circleColor;
		[NullAllowed, Export ("circleColor", ArgumentSemantic.Strong)]
		TMBValue CircleColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable circleColorTransition;
		[NullAllowed, Export ("circleColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition CircleColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable circleOpacity;
		[NullAllowed, Export ("circleOpacity", ArgumentSemantic.Strong)]
		TMBValue CircleOpacity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable circleOpacityTransition;
		[NullAllowed, Export ("circleOpacityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition CircleOpacityTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable circlePitchAlignment;
		[NullAllowed, Export ("circlePitchAlignment", ArgumentSemantic.Strong)]
		TMBValue CirclePitchAlignment { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable circlePitchScale;
		[NullAllowed, Export ("circlePitchScale", ArgumentSemantic.Strong)]
		TMBValue CirclePitchScale { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable circleRadius;
		[NullAllowed, Export ("circleRadius", ArgumentSemantic.Strong)]
		TMBValue CircleRadius { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable circleRadiusTransition;
		[NullAllowed, Export ("circleRadiusTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition CircleRadiusTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable circleStrokeColor;
		[NullAllowed, Export ("circleStrokeColor", ArgumentSemantic.Strong)]
		TMBValue CircleStrokeColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable circleStrokeColorTransition;
		[NullAllowed, Export ("circleStrokeColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition CircleStrokeColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable circleStrokeOpacity;
		[NullAllowed, Export ("circleStrokeOpacity", ArgumentSemantic.Strong)]
		TMBValue CircleStrokeOpacity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable circleStrokeOpacityTransition;
		[NullAllowed, Export ("circleStrokeOpacityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition CircleStrokeOpacityTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable circleStrokeWidth;
		[NullAllowed, Export ("circleStrokeWidth", ArgumentSemantic.Strong)]
		TMBValue CircleStrokeWidth { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable circleStrokeWidthTransition;
		[NullAllowed, Export ("circleStrokeWidthTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition CircleStrokeWidthTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable circleTranslate;
		[NullAllowed, Export ("circleTranslate", ArgumentSemantic.Strong)]
		TMBValue CircleTranslate { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable circleTranslateTransition;
		[NullAllowed, Export ("circleTranslateTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition CircleTranslateTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable circleTranslateAnchor;
		[NullAllowed, Export ("circleTranslateAnchor", ArgumentSemantic.Strong)]
		TMBValue CircleTranslateAnchor { get; set; }
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
		NSDictionary ClusterProperties { get; set; }

		// -(instancetype _Nonnull)initWithCircleRadius:(TMBValue * _Nullable)circleRadius circleColor:(TMBValue * _Nullable)circleColor textColor:(TMBValue * _Nullable)textColor textSize:(TMBValue * _Nullable)textSize textField:(TMBValue * _Nullable)textField clusterRadius:(double)clusterRadius clusterMaxZoom:(double)clusterMaxZoom clusterProperties:(NSDictionary<NSString *,TMBExpression *> * _Nullable)clusterProperties __attribute__((objc_designated_initializer));
		[Export ("initWithCircleRadius:circleColor:textColor:textSize:textField:clusterRadius:clusterMaxZoom:clusterProperties:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] TMBValue circleRadius, [NullAllowed] TMBValue circleColor, [NullAllowed] TMBValue textColor, [NullAllowed] TMBValue textSize, [NullAllowed] TMBValue textField, double clusterRadius, double clusterMaxZoom, [NullAllowed] NSDictionary clusterProperties);
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
	interface TMBDefaultViewportTransition : TMBViewportTransition
	{
		// @property (nonatomic, strong) TMBDefaultViewportTransitionOptions * _Nonnull options;
		[Export ("options", ArgumentSemantic.Strong)]
		TMBDefaultViewportTransitionOptions Options { get; set; }

		// // -(TMBCancelable * _Nonnull)runTo:(id<TMBViewportState> _Nonnull)toState completion:(void (^ _Nonnull)(BOOL))completion __attribute__((warn_unused_result("")));
		// [Export("runTo:completion:")]
        // TMBCancelable RunTo(ITMBViewportState toState, Action<bool> completion);
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
*/
	partial interface ITMBViewportTransition { }

    [Protocol (Name = "_TtP13MapboxMapObjC21TMBViewportTransition_"), Model]
	[BaseType(typeof(NSObject))]
	interface TMBViewportTransition
    {
		// @required -(TMBCancelable * _Nonnull)runTo:(id<TMBViewportState> _Nonnull)toState completion:(void (^ _Nonnull)(BOOL))completion __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("runTo:completion:")]
		TMBCancelable Completion (ITMBViewportState toState, Action<bool> completion);
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

	// @interface TMBExpression : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13TMBExpression")]
	[DisableDefaultCtor]
	interface TMBExpression
	{
		// @property (nonatomic, readonly) enum TMBExpressionOperator expressionOperator;
		[Export ("expressionOperator")]
		TMBExpressionOperator ExpressionOperator { [Bind ("expressionOperator")] get; }

		// @property (readonly, copy, nonatomic) NSArray * _Nonnull arguments;
		[Export ("arguments", ArgumentSemantic.Copy)]
		NSObject[] Arguments { get; }

		// +(TMBExpression * _Nonnull)createWithOperator:(enum TMBExpressionOperator)operator_ __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithOperator:")]
		TMBExpression CreateWithOperator (TMBExpressionOperator operator_);

		// +(TMBExpression * _Nonnull)createWithOperator:(enum TMBExpressionOperator)operator_ arguments:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithOperator:arguments:")]
		TMBExpression CreateWithOperator (TMBExpressionOperator operator_, NSObject[] arguments);

		// +(TMBExpression * _Nonnull)args:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("args:")]
		TMBExpression Args (NSObject[] arguments);
	}

	// @interface MapboxMapObjC_Swift_1503 (TMBExpression)
	[Category]
	[BaseType (typeof(TMBExpression))]
	interface TMBExpression_MapboxMapObjC_Swift_1503
	{
		// +(TMBExpression * _Nonnull)subtract __attribute__((warn_unused_result("")));
		[Static]
		[Export ("subtract")]
		TMBExpression Subtract();

		// +(TMBExpression * _Nonnull)subtract:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("subtract:")]
		TMBExpression Subtract (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)not __attribute__((warn_unused_result("")));
		[Static]
		[Export ("not")]
		TMBExpression Not();

		// +(TMBExpression * _Nonnull)not:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("not:")]
		TMBExpression Not (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)neq __attribute__((warn_unused_result("")));
		[Static]
		[Export("neq")]
		TMBExpression Neq();

		// +(TMBExpression * _Nonnull)neq:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("neq:")]
		TMBExpression Neq (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)product __attribute__((warn_unused_result("")));
		[Static]
		[Export ("product")]
		TMBExpression Product();

		// +(TMBExpression * _Nonnull)product:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("product:")]
		TMBExpression Product (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)division __attribute__((warn_unused_result("")));
		[Static]
		[Export ("division")]
		TMBExpression Division();

		// +(TMBExpression * _Nonnull)division:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("division:")]
		TMBExpression Division (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)mod __attribute__((warn_unused_result("")));
		[Static]
		[Export ("mod")]
		TMBExpression Mod();

		// +(TMBExpression * _Nonnull)mod:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("mod:")]
		TMBExpression Mod (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)pow __attribute__((warn_unused_result("")));
		[Static]
		[Export ("pow")]
		TMBExpression Pow();

		// +(TMBExpression * _Nonnull)pow:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("pow:")]
		TMBExpression Pow (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)sum __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sum")]
		TMBExpression Sum();

		// +(TMBExpression * _Nonnull)sum:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sum:")]
		TMBExpression Sum (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)lt __attribute__((warn_unused_result("")));
		[Static]
		[Export ("lt")]
		TMBExpression Lt();

		// +(TMBExpression * _Nonnull)lt:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("lt:")]
		TMBExpression Lt (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)lte __attribute__((warn_unused_result("")));
		[Static]
		[Export ("lte")]
		TMBExpression Lte();

		// +(TMBExpression * _Nonnull)lte:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("lte:")]
		TMBExpression Lte (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)eq __attribute__((warn_unused_result("")));
		[Static]
		[Export ("eq")]
		TMBExpression Eq();

		// +(TMBExpression * _Nonnull)eq:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("eq:")]
		TMBExpression Eq (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)gt __attribute__((warn_unused_result("")));
		[Static]
		[Export ("gt")]
		TMBExpression Gt();

		// +(TMBExpression * _Nonnull)gt:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("gt:")]
		TMBExpression Gt (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)gte __attribute__((warn_unused_result("")));
		[Static]
		[Export ("gte")]
		TMBExpression Gte();

		// +(TMBExpression * _Nonnull)gte:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("gte:")]
		TMBExpression Gte (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)abs __attribute__((warn_unused_result("")));
		[Static]
		[Export ("abs")]
		TMBExpression Abs();

		// +(TMBExpression * _Nonnull)abs:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("abs:")]
		TMBExpression Abs (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)accumulated __attribute__((warn_unused_result("")));
		[Static]
		[Export ("accumulated")]
		TMBExpression Accumulated();

		// +(TMBExpression * _Nonnull)accumulated:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("accumulated:")]
		TMBExpression Accumulated (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)acos __attribute__((warn_unused_result("")));
		[Static]
		[Export ("acos")]
		TMBExpression Acos();

		// +(TMBExpression * _Nonnull)acos:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("acos:")]
		TMBExpression Acos (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)all __attribute__((warn_unused_result("")));
		[Static]
		[Export ("all")]
		TMBExpression All();

		// +(TMBExpression * _Nonnull)all:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("all:")]
		TMBExpression All (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)any __attribute__((warn_unused_result("")));
		[Static]
		[Export ("any")]
		TMBExpression Any();

		// +(TMBExpression * _Nonnull)any:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("any:")]
		TMBExpression Any (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)array __attribute__((warn_unused_result("")));
		[Static]
		[Export ("array")]
		TMBExpression Array();

		// +(TMBExpression * _Nonnull)array:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("array:")]
		TMBExpression Array (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)asin __attribute__((warn_unused_result("")));
		[Static]
		[Export ("asin")]
		TMBExpression Asin();

		// +(TMBExpression * _Nonnull)asin:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("asin:")]
		TMBExpression Asin (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)at __attribute__((warn_unused_result("")));
		[Static]
		[Export ("at")]
		TMBExpression At();

		// +(TMBExpression * _Nonnull)at:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("at:")]
		TMBExpression At (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)atan __attribute__((warn_unused_result("")));
		[Static]
		[Export ("atan")]
		TMBExpression Atan();

		// +(TMBExpression * _Nonnull)atan:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("atan:")]
		TMBExpression Atan (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)boolean __attribute__((warn_unused_result("")));
		[Static]
		[Export ("boolean")]
		TMBExpression Boolean();

		// +(TMBExpression * _Nonnull)boolean:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("boolean:")]
		TMBExpression Boolean (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)switchCase __attribute__((warn_unused_result("")));
		[Static]
		[Export ("switchCase")]
		TMBExpression SwitchCase();

		// +(TMBExpression * _Nonnull)switchCase:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("switchCase:")]
		TMBExpression SwitchCase (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)ceil __attribute__((warn_unused_result("")));
		[Static]
		[Export ("ceil")]
		TMBExpression Ceil();

		// +(TMBExpression * _Nonnull)ceil:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("ceil:")]
		TMBExpression Ceil (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)coalesce __attribute__((warn_unused_result("")));
		[Static]
		[Export ("coalesce")]
		TMBExpression Coalesce();

		// +(TMBExpression * _Nonnull)coalesce:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("coalesce:")]
		TMBExpression Coalesce (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)collator __attribute__((warn_unused_result("")));
		[Static]
		[Export ("collator")]
		TMBExpression Collator();

		// +(TMBExpression * _Nonnull)collator:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("collator:")]
		TMBExpression Collator (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)concat __attribute__((warn_unused_result("")));
		[Static]
		[Export ("concat")]
		TMBExpression Concat();

		// +(TMBExpression * _Nonnull)concat:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("concat:")]
		TMBExpression Concat (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)cos __attribute__((warn_unused_result("")));
		[Static]
		[Export ("cos")]
		TMBExpression Cos();

		// +(TMBExpression * _Nonnull)cos:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("cos:")]
		TMBExpression Cos (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)distance __attribute__((warn_unused_result("")));
		[Static]
		[Export ("distance")]
		TMBExpression Distance();

		// +(TMBExpression * _Nonnull)distance:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("distance:")]
		TMBExpression Distance (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)distanceFromCenter __attribute__((warn_unused_result("")));
		[Static]
		[Export ("distanceFromCenter")]
		TMBExpression DistanceFromCenter();

		// +(TMBExpression * _Nonnull)distanceFromCenter:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("distanceFromCenter:")]
		TMBExpression DistanceFromCenter (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)downcase __attribute__((warn_unused_result("")));
		[Static]
		[Export ("downcase")]
		TMBExpression Downcase();

		// +(TMBExpression * _Nonnull)downcase:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("downcase:")]
		TMBExpression Downcase (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)e __attribute__((warn_unused_result("")));
		[Static]
		[Export ("e")]
		TMBExpression E();

		// +(TMBExpression * _Nonnull)e:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("e:")]
		TMBExpression E (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)featureState __attribute__((warn_unused_result("")));
		[Static]
		[Export ("featureState")]
		TMBExpression FeatureState();

		// +(TMBExpression * _Nonnull)featureState:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("featureState:")]
		TMBExpression FeatureState (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)floor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("floor")]
		TMBExpression Floor();

		// +(TMBExpression * _Nonnull)floor:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("floor:")]
		TMBExpression Floor (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)format __attribute__((warn_unused_result("")));
		[Static]
		[Export ("format")]
		TMBExpression Format();

		// +(TMBExpression * _Nonnull)format:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("format:")]
		TMBExpression Format (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)geometryType __attribute__((warn_unused_result("")));
		[Static]
		[Export ("geometryType")]
		TMBExpression GeometryType();

		// +(TMBExpression * _Nonnull)geometryType:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("geometryType:")]
		TMBExpression GeometryType (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)get __attribute__((warn_unused_result("")));
		[Static]
		[Export ("get")]
		TMBExpression Get();

		// +(TMBExpression * _Nonnull)get:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("get:")]
		TMBExpression Get (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)has __attribute__((warn_unused_result("")));
		[Static]
		[Export ("has")]
		TMBExpression Has();

		// +(TMBExpression * _Nonnull)has:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("has:")]
		TMBExpression Has (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)heatmapDensity __attribute__((warn_unused_result("")));
		[Static]
		[Export ("heatmapDensity")]
		TMBExpression HeatmapDensity();

		// +(TMBExpression * _Nonnull)heatmapDensity:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("heatmapDensity:")]
        TMBExpression HeatmapDensity (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)id __attribute__((warn_unused_result("")));
		[Static]
		[Export ("id")]
		TMBExpression Id();

		// +(TMBExpression * _Nonnull)id:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("id:")]
		TMBExpression Id (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)image __attribute__((warn_unused_result("")));
		[Static]
		[Export ("image")]
		TMBExpression Image();

		// +(TMBExpression * _Nonnull)image:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("image:")]
		TMBExpression Image (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)inExpression __attribute__((warn_unused_result("")));
		[Static]
		[Export ("inExpression")]
		TMBExpression InExpression();

		// +(TMBExpression * _Nonnull)inExpression:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("inExpression:")]
		TMBExpression InExpression (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)indexOf __attribute__((warn_unused_result("")));
		[Static]
		[Export ("indexOf")]
		TMBExpression IndexOf();

		// +(TMBExpression * _Nonnull)indexOf:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("indexOf:")]
		TMBExpression IndexOf (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)interpolate __attribute__((warn_unused_result("")));
		[Static]
		[Export ("interpolate")]
		TMBExpression Interpolate();

		// +(TMBExpression * _Nonnull)interpolate:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("interpolate:")]
		TMBExpression Interpolate (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)isSupportedScript __attribute__((warn_unused_result("")));
		[Static]
		[Export ("isSupportedScript")]
		TMBExpression IsSupportedScript();

		// +(TMBExpression * _Nonnull)isSupportedScript:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("isSupportedScript:")]
		TMBExpression IsSupportedScript (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)length __attribute__((warn_unused_result("")));
		[Static]
		[Export ("length")]
		TMBExpression Length();

		// +(TMBExpression * _Nonnull)length:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("length:")]
		TMBExpression Length (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)letExpression __attribute__((warn_unused_result("")));
		[Static]
		[Export ("letExpression")]
		TMBExpression LetExpression();

		// +(TMBExpression * _Nonnull)letExpression:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("letExpression:")]
		TMBExpression LetExpression (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)lineProgress __attribute__((warn_unused_result("")));
		[Static]
		[Export ("lineProgress")]
		TMBExpression LineProgress();

		// +(TMBExpression * _Nonnull)lineProgress:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("lineProgress:")]
		TMBExpression LineProgress (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)literal __attribute__((warn_unused_result("")));
		[Static]
		[Export ("literal")]
		TMBExpression Literal();

		// +(TMBExpression * _Nonnull)literal:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("literal:")]
		TMBExpression Literal (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)ln __attribute__((warn_unused_result("")));
		[Static]
		[Export ("ln")]
		TMBExpression Ln();

		// +(TMBExpression * _Nonnull)ln:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("ln:")]
		TMBExpression Ln (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)ln2 __attribute__((warn_unused_result("")));
		[Static]
		[Export ("ln2")]
		TMBExpression Ln2();

		// +(TMBExpression * _Nonnull)ln2:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("ln2:")]
		TMBExpression Ln2 (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)log10 __attribute__((warn_unused_result("")));
		[Static]
		[Export ("log10")]
		TMBExpression Log10();

		// +(TMBExpression * _Nonnull)log10:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("log10:")]
		TMBExpression Log10 (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)log2 __attribute__((warn_unused_result("")));
		[Static]
		[Export ("log2")]
		TMBExpression Log2();

		// +(TMBExpression * _Nonnull)log2:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("log2:")]
		TMBExpression Log2 (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)match __attribute__((warn_unused_result("")));
		[Static]
		[Export ("match")]
		TMBExpression Match();

		// +(TMBExpression * _Nonnull)match:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("match:")]
		TMBExpression Match (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)max __attribute__((warn_unused_result("")));
		[Static]
		[Export ("max")]
		TMBExpression Max();

		// +(TMBExpression * _Nonnull)max:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("max:")]
		TMBExpression Max (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)min __attribute__((warn_unused_result("")));
		[Static]
		[Export ("min")]
		TMBExpression Min();

		// +(TMBExpression * _Nonnull)min:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("min:")]
		TMBExpression Min (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)number __attribute__((warn_unused_result("")));
		[Static]
		[Export ("number")]
		TMBExpression Number();

		// +(TMBExpression * _Nonnull)number:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("number:")]
		TMBExpression Number (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)numberFormat __attribute__((warn_unused_result("")));
		[Static]
		[Export ("numberFormat")]
		TMBExpression NumberFormat();

		// +(TMBExpression * _Nonnull)numberFormat:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("numberFormat:")]
		TMBExpression NumberFormat (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)objectExpression __attribute__((warn_unused_result("")));
		[Static]
		[Export ("objectExpression")]
		TMBExpression ObjectExpression();

		// +(TMBExpression * _Nonnull)objectExpression:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("objectExpression:")]
		TMBExpression ObjectExpression (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)pi __attribute__((warn_unused_result("")));
		[Static]
		[Export ("pi")]
		TMBExpression Pi();

		// +(TMBExpression * _Nonnull)pi:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("pi:")]
		TMBExpression Pi (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)pitch __attribute__((warn_unused_result("")));
		[Static]
		[Export ("pitch")]
		TMBExpression Pitch();

		// +(TMBExpression * _Nonnull)pitch:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("pitch:")]
		TMBExpression Pitch (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)properties __attribute__((warn_unused_result("")));
		[Static]
		[Export ("properties")]
		TMBExpression Properties();

		// +(TMBExpression * _Nonnull)properties:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("properties:")]
		TMBExpression Properties (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)resolvedLocale __attribute__((warn_unused_result("")));
		[Static]
		[Export ("resolvedLocale")]
		TMBExpression ResolvedLocale();

		// +(TMBExpression * _Nonnull)resolvedLocale:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("resolvedLocale:")]
		TMBExpression ResolvedLocale (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)rgb __attribute__((warn_unused_result("")));
		[Static]
		[Export ("rgb")]
		TMBExpression Rgb();

		// +(TMBExpression * _Nonnull)rgb:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("rgb:")]
		TMBExpression Rgb (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)rgba __attribute__((warn_unused_result("")));
		[Static]
		[Export ("rgba")]
		TMBExpression Rgba();

		// +(TMBExpression * _Nonnull)rgba:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("rgba:")]
		TMBExpression Rgba (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)round __attribute__((warn_unused_result("")));
		[Static]
		[Export ("round")]
		TMBExpression Round();

		// +(TMBExpression * _Nonnull)round:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("round:")]
		TMBExpression Round (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)sin __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sin")]
		TMBExpression Sin();

		// +(TMBExpression * _Nonnull)sin:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sin:")]
		TMBExpression Sin (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)skyRadialProgress __attribute__((warn_unused_result("")));
		[Static]
		[Export ("skyRadialProgress")]
		TMBExpression SkyRadialProgress();

		// +(TMBExpression * _Nonnull)skyRadialProgress:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("skyRadialProgress:")]
		TMBExpression SkyRadialProgress (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)slice __attribute__((warn_unused_result("")));
		[Static]
		[Export ("slice")]
		TMBExpression Slice();

		// +(TMBExpression * _Nonnull)slice:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("slice:")]
		TMBExpression Slice (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)sqrt __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sqrt")]
		TMBExpression Sqrt();

		// +(TMBExpression * _Nonnull)sqrt:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sqrt:")]
		TMBExpression Sqrt (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)step __attribute__((warn_unused_result("")));
		[Static]
		[Export ("step")]
		TMBExpression Step();

		// +(TMBExpression * _Nonnull)step:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("step:")]
		TMBExpression Step (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)string __attribute__((warn_unused_result("")));
		[Static]
		[Export ("string")]
		TMBExpression String();

		// +(TMBExpression * _Nonnull)string:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("string:")]
		TMBExpression String (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)tan __attribute__((warn_unused_result("")));
		[Static]
		[Export ("tan")]
		TMBExpression Tan();

		// +(TMBExpression * _Nonnull)tan:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("tan:")]
		TMBExpression Tan (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)toBoolean __attribute__((warn_unused_result("")));
		[Static]
		[Export ("toBoolean")]
		TMBExpression ToBoolean();

		// +(TMBExpression * _Nonnull)toBoolean:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("toBoolean:")]
		TMBExpression ToBoolean (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)toColor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("toColor")]
		TMBExpression ToColor();

		// +(TMBExpression * _Nonnull)toColor:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("toColor:")]
		TMBExpression ToColor (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)toNumber __attribute__((warn_unused_result("")));
		[Static]
		[Export ("toNumber")]
		TMBExpression ToNumber();

		// +(TMBExpression * _Nonnull)toNumber:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("toNumber:")]
		TMBExpression ToNumber (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)toRgba __attribute__((warn_unused_result("")));
		[Static]
		[Export ("toRgba")]
		TMBExpression ToRgba();

		// +(TMBExpression * _Nonnull)toRgba:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("toRgba:")]
		TMBExpression ToRgba (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)toString __attribute__((warn_unused_result("")));
		[Static]
		[Export ("toString")]
		TMBExpression ToString();

		// +(TMBExpression * _Nonnull)toString:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("toString:")]
		TMBExpression ToString (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)typeofExpression __attribute__((warn_unused_result("")));
		[Static]
		[Export ("typeofExpression")]
		TMBExpression TypeofExpression();

		// +(TMBExpression * _Nonnull)typeofExpression:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("typeofExpression:")]
		TMBExpression TypeofExpression (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)upcase __attribute__((warn_unused_result("")));
		[Static]
		[Export ("upcase")]
		TMBExpression Upcase();

		// +(TMBExpression * _Nonnull)upcase:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("upcase:")]
		TMBExpression Upcase (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)varExpression __attribute__((warn_unused_result("")));
		[Static]
		[Export ("varExpression")]
		TMBExpression VarExpression();

		// +(TMBExpression * _Nonnull)varExpression:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("varExpression:")]
		TMBExpression VarExpression (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)within __attribute__((warn_unused_result("")));
		[Static]
		[Export ("within")]
		TMBExpression Within();

		// +(TMBExpression * _Nonnull)within:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("within:")]
		TMBExpression Within (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)zoom __attribute__((warn_unused_result("")));
		[Static]
		[Export ("zoom")]
		TMBExpression Zoom();

		// +(TMBExpression * _Nonnull)zoom:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("zoom:")]
		TMBExpression Zoom (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)linear __attribute__((warn_unused_result("")));
		[Static]
		[Export ("linear")]
		TMBExpression Linear();

		// +(TMBExpression * _Nonnull)linear:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("linear:")]
		TMBExpression Linear (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)exponential __attribute__((warn_unused_result("")));
		[Static]
		[Export ("exponential")]
		TMBExpression Exponential();

		// +(TMBExpression * _Nonnull)exponential:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("exponential:")]
		TMBExpression Exponential (NSObject[] arguments);

		// +(TMBExpression * _Nonnull)cubicBezier __attribute__((warn_unused_result("")));
		[Static]
		[Export ("cubicBezier")]
		TMBExpression CubicBezier();

		// +(TMBExpression * _Nonnull)cubicBezier:(NSArray * _Nonnull)arguments __attribute__((warn_unused_result("")));
		[Static]
		[Export ("cubicBezier:")]
		TMBExpression CubicBezier (NSObject[] arguments);
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

	// @interface TMBFillExtrusionLayer : NSObject <TMBLayer>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC21TMBFillExtrusionLayer")]
	[DisableDefaultCtor]
	interface TMBFillExtrusionLayer : TMBLayer
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; set; }

		// @property (readonly, nonatomic) enum TMBLayerType type;
		[Export ("type")]
		TMBLayerType Type { get; }

		// @property (nonatomic, strong) TMBExpression * _Nullable filter;
		[NullAllowed, Export ("filter", ArgumentSemantic.Strong)]
		TMBExpression Filter { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable source;
		[NullAllowed, Export ("source")]
		string Source { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sourceLayer;
		[NullAllowed, Export ("sourceLayer")]
		string SourceLayer { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minZoom;
		[NullAllowed, Export ("minZoom", ArgumentSemantic.Strong)]
		NSNumber MinZoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxZoom;
		[NullAllowed, Export ("maxZoom", ArgumentSemantic.Strong)]
		NSNumber MaxZoom { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable visibility;
		[NullAllowed, Export ("visibility", ArgumentSemantic.Strong)]
		TMBValue Visibility { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillExtrusionAmbientOcclusionIntensity;
		[NullAllowed, Export ("fillExtrusionAmbientOcclusionIntensity", ArgumentSemantic.Strong)]
		TMBValue FillExtrusionAmbientOcclusionIntensity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable fillExtrusionAmbientOcclusionIntensityTransition;
		[NullAllowed, Export ("fillExtrusionAmbientOcclusionIntensityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition FillExtrusionAmbientOcclusionIntensityTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillExtrusionAmbientOcclusionRadius;
		[NullAllowed, Export ("fillExtrusionAmbientOcclusionRadius", ArgumentSemantic.Strong)]
		TMBValue FillExtrusionAmbientOcclusionRadius { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable fillExtrusionAmbientOcclusionRadiusTransition;
		[NullAllowed, Export ("fillExtrusionAmbientOcclusionRadiusTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition FillExtrusionAmbientOcclusionRadiusTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillExtrusionBase;
		[NullAllowed, Export ("fillExtrusionBase", ArgumentSemantic.Strong)]
		TMBValue FillExtrusionBase { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable fillExtrusionBaseTransition;
		[NullAllowed, Export ("fillExtrusionBaseTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition FillExtrusionBaseTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillExtrusionColor;
		[NullAllowed, Export ("fillExtrusionColor", ArgumentSemantic.Strong)]
		TMBValue FillExtrusionColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable fillExtrusionColorTransition;
		[NullAllowed, Export ("fillExtrusionColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition FillExtrusionColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillExtrusionHeight;
		[NullAllowed, Export ("fillExtrusionHeight", ArgumentSemantic.Strong)]
		TMBValue FillExtrusionHeight { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable fillExtrusionHeightTransition;
		[NullAllowed, Export ("fillExtrusionHeightTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition FillExtrusionHeightTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillExtrusionOpacity;
		[NullAllowed, Export ("fillExtrusionOpacity", ArgumentSemantic.Strong)]
		TMBValue FillExtrusionOpacity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable fillExtrusionOpacityTransition;
		[NullAllowed, Export ("fillExtrusionOpacityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition FillExtrusionOpacityTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillExtrusionPattern;
		[NullAllowed, Export ("fillExtrusionPattern", ArgumentSemantic.Strong)]
		TMBValue FillExtrusionPattern { get; set; }

		// @property (nonatomic, strong) SWIFT_DEPRECATED_MSG("This property is deprecated and will be removed in the future. Setting this will have no effect.") TMBStyleTransition * fillExtrusionPatternTransition __attribute__((deprecated("This property is deprecated and will be removed in the future. Setting this will have no effect.")));
		[Export ("fillExtrusionPatternTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition FillExtrusionPatternTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillExtrusionTranslate;
		[NullAllowed, Export ("fillExtrusionTranslate", ArgumentSemantic.Strong)]
		TMBValue FillExtrusionTranslate { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable fillExtrusionTranslateTransition;
		[NullAllowed, Export ("fillExtrusionTranslateTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition FillExtrusionTranslateTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillExtrusionTranslateAnchor;
		[NullAllowed, Export ("fillExtrusionTranslateAnchor", ArgumentSemantic.Strong)]
		TMBValue FillExtrusionTranslateAnchor { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillExtrusionVerticalGradient;
		[NullAllowed, Export ("fillExtrusionVerticalGradient", ArgumentSemantic.Strong)]
		TMBValue FillExtrusionVerticalGradient { get; set; }
	}

	// @interface TMBFillLayer : NSObject <TMBLayer>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC12TMBFillLayer")]
	[DisableDefaultCtor]
	interface TMBFillLayer : TMBLayer
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; set; }

		// @property (readonly, nonatomic) enum TMBLayerType type;
		[Export ("type")]
		TMBLayerType Type { get; }

		// @property (nonatomic, strong) TMBExpression * _Nullable filter;
		[NullAllowed, Export ("filter", ArgumentSemantic.Strong)]
		TMBExpression Filter { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable source;
		[NullAllowed, Export ("source")]
		string Source { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sourceLayer;
		[NullAllowed, Export ("sourceLayer")]
		string SourceLayer { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minZoom;
		[NullAllowed, Export ("minZoom", ArgumentSemantic.Strong)]
		NSNumber MinZoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxZoom;
		[NullAllowed, Export ("maxZoom", ArgumentSemantic.Strong)]
		NSNumber MaxZoom { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable visibility;
		[NullAllowed, Export ("visibility", ArgumentSemantic.Strong)]
		TMBValue Visibility { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillSortKey;
		[NullAllowed, Export ("fillSortKey", ArgumentSemantic.Strong)]
		TMBValue FillSortKey { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillAntialias;
		[NullAllowed, Export ("fillAntialias", ArgumentSemantic.Strong)]
		TMBValue FillAntialias { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillColor;
		[NullAllowed, Export ("fillColor", ArgumentSemantic.Strong)]
		TMBValue FillColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable fillColorTransition;
		[NullAllowed, Export ("fillColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition FillColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillOpacity;
		[NullAllowed, Export ("fillOpacity", ArgumentSemantic.Strong)]
		TMBValue FillOpacity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable fillOpacityTransition;
		[NullAllowed, Export ("fillOpacityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition FillOpacityTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillOutlineColor;
		[NullAllowed, Export ("fillOutlineColor", ArgumentSemantic.Strong)]
		TMBValue FillOutlineColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable fillOutlineColorTransition;
		[NullAllowed, Export ("fillOutlineColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition FillOutlineColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillPattern;
		[NullAllowed, Export ("fillPattern", ArgumentSemantic.Strong)]
		TMBValue FillPattern { get; set; }

		// @property (nonatomic, strong) SWIFT_DEPRECATED_MSG("This property is deprecated and will be removed in the future. Setting this will have no effect.") TMBStyleTransition * fillPatternTransition __attribute__((deprecated("This property is deprecated and will be removed in the future. Setting this will have no effect.")));
		[Export ("fillPatternTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition FillPatternTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillTranslate;
		[NullAllowed, Export ("fillTranslate", ArgumentSemantic.Strong)]
		TMBValue FillTranslate { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable fillTranslateTransition;
		[NullAllowed, Export ("fillTranslateTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition FillTranslateTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable fillTranslateAnchor;
		[NullAllowed, Export ("fillTranslateAnchor", ArgumentSemantic.Strong)]
		TMBValue FillTranslateAnchor { get; set; }
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

	// @interface MapboxMapObjC_Swift_1901 (TMBFollowPuckViewportState) <TMBViewportState>
	[Category]
	[BaseType (typeof(TMBFollowPuckViewportState))]
	interface TMBFollowPuckViewportState_MapboxMapObjC_Swift_1901 : ITMBViewportState
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

	// @protocol TMBSource
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	partial interface ITMBSource {}

	[Protocol (Name = "_TtP13MapboxMapObjC9TMBSource_"), Model]
	[BaseType (typeof(NSObject))]
	interface TMBSource
	{
		// @required @property (readonly, nonatomic) enum TMBSourceType type;
		[Abstract]
		[Export ("type")]
		TMBSourceType Type { get; }
	}

	// @interface TMBGeoJSONSource : NSObject <TMBSource>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC16TMBGeoJSONSource")]
	[DisableDefaultCtor]
	interface TMBGeoJSONSource : TMBSource
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (readonly, nonatomic) enum TMBSourceType type;
		[Export ("type")]
		TMBSourceType Type { get; }

		// @property (nonatomic, strong) TMBGeoJSONSourceData * _Nullable data;
		[NullAllowed, Export ("data", ArgumentSemantic.Strong)]
		TMBGeoJSONSourceData Data { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxzoom;
		[NullAllowed, Export ("maxzoom", ArgumentSemantic.Strong)]
		NSNumber Maxzoom { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable attribution;
		[NullAllowed, Export ("attribution")]
		string Attribution { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable buffer;
		[NullAllowed, Export ("buffer", ArgumentSemantic.Strong)]
		NSNumber Buffer { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable tolerance;
		[NullAllowed, Export ("tolerance", ArgumentSemantic.Strong)]
		NSNumber Tolerance { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable cluster;
		[NullAllowed, Export ("cluster", ArgumentSemantic.Strong)]
		NSNumber Cluster { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable clusterRadius;
		[NullAllowed, Export ("clusterRadius", ArgumentSemantic.Strong)]
		NSNumber ClusterRadius { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable clusterMaxZoom;
		[NullAllowed, Export ("clusterMaxZoom", ArgumentSemantic.Strong)]
		NSNumber ClusterMaxZoom { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,TMBExpression *> * _Nullable clusterProperties;
		[NullAllowed, Export ("clusterProperties", ArgumentSemantic.Copy)]
		NSDictionary ClusterProperties { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable lineMetrics;
		[NullAllowed, Export ("lineMetrics", ArgumentSemantic.Strong)]
		NSNumber LineMetrics { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable generateId;
		[NullAllowed, Export ("generateId", ArgumentSemantic.Strong)]
		NSNumber GenerateId { get; set; }

		// @property (nonatomic, strong) TMBPromoteId * _Nullable promoteId;
		[NullAllowed, Export ("promoteId", ArgumentSemantic.Strong)]
		TMBPromoteId PromoteId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable prefetchZoomDelta;
		[NullAllowed, Export ("prefetchZoomDelta", ArgumentSemantic.Strong)]
		NSNumber PrefetchZoomDelta { get; set; }
	}

	// @interface TMBGeoJSONSourceData : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC20TMBGeoJSONSourceData")]
	[DisableDefaultCtor]
	interface TMBGeoJSONSourceData
	{
		// @property (readonly, nonatomic) enum TMBGeoJSONSourceType type;
		[Export ("type")]
		TMBGeoJSONSourceType Type { get; }

		// +(TMBGeoJSONSourceData * _Nonnull)urlWithUrl:(NSURL * _Nonnull)url __attribute__((warn_unused_result("")));
		[Static]
		[Export ("urlWithUrl:")]
		TMBGeoJSONSourceData UrlWithUrl (NSUrl url);

		// +(TMBGeoJSONSourceData * _Nonnull)featureWithFeature:(MBXFeature * _Nonnull)feature __attribute__((warn_unused_result("")));
		[Static]
		[Export ("featureWithFeature:")]
		TMBGeoJSONSourceData FeatureWithFeature (MBXFeature feature);

		// +(TMBGeoJSONSourceData * _Nonnull)featureCollectionWithFeatures:(NSArray<MBXFeature *> * _Nonnull)features __attribute__((warn_unused_result("")));
		[Static]
		[Export ("featureCollectionWithFeatures:")]
		TMBGeoJSONSourceData FeatureCollectionWithFeatures (MBXFeature[] features);

		// +(TMBGeoJSONSourceData * _Nonnull)geometryWithGeometry:(MBXGeometry * _Nonnull)geometry __attribute__((warn_unused_result("")));
		[Static]
		[Export ("geometryWithGeometry:")]
		TMBGeoJSONSourceData GeometryWithGeometry (MBXGeometry geometry);

		// +(TMBGeoJSONSourceData * _Nonnull)empty __attribute__((warn_unused_result("")));
		[Static]
		[Export("empty")]
		TMBGeoJSONSourceData Empty();
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

	// @interface TMBHeatmapLayer : NSObject <TMBLayer>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC15TMBHeatmapLayer")]
	[DisableDefaultCtor]
	interface TMBHeatmapLayer : TMBLayer
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; set; }

		// @property (readonly, nonatomic) enum TMBLayerType type;
		[Export ("type")]
		TMBLayerType Type { get; }

		// @property (nonatomic, strong) TMBExpression * _Nullable filter;
		[NullAllowed, Export ("filter", ArgumentSemantic.Strong)]
		TMBExpression Filter { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable source;
		[NullAllowed, Export ("source")]
		string Source { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sourceLayer;
		[NullAllowed, Export ("sourceLayer")]
		string SourceLayer { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minZoom;
		[NullAllowed, Export ("minZoom", ArgumentSemantic.Strong)]
		NSNumber MinZoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxZoom;
		[NullAllowed, Export ("maxZoom", ArgumentSemantic.Strong)]
		NSNumber MaxZoom { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable visibility;
		[NullAllowed, Export ("visibility", ArgumentSemantic.Strong)]
		TMBValue Visibility { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable heatmapColor;
		[NullAllowed, Export ("heatmapColor", ArgumentSemantic.Strong)]
		TMBValue HeatmapColor { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable heatmapIntensity;
		[NullAllowed, Export ("heatmapIntensity", ArgumentSemantic.Strong)]
		TMBValue HeatmapIntensity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable heatmapIntensityTransition;
		[NullAllowed, Export ("heatmapIntensityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition HeatmapIntensityTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable heatmapOpacity;
		[NullAllowed, Export ("heatmapOpacity", ArgumentSemantic.Strong)]
		TMBValue HeatmapOpacity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable heatmapOpacityTransition;
		[NullAllowed, Export ("heatmapOpacityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition HeatmapOpacityTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable heatmapRadius;
		[NullAllowed, Export ("heatmapRadius", ArgumentSemantic.Strong)]
		TMBValue HeatmapRadius { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable heatmapRadiusTransition;
		[NullAllowed, Export ("heatmapRadiusTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition HeatmapRadiusTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable heatmapWeight;
		[NullAllowed, Export ("heatmapWeight", ArgumentSemantic.Strong)]
		TMBValue HeatmapWeight { get; set; }
	}

	// @interface TMBHillshadeLayer : NSObject <TMBLayer>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC17TMBHillshadeLayer")]
	[DisableDefaultCtor]
	interface TMBHillshadeLayer : TMBLayer
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; set; }

		// @property (readonly, nonatomic) enum TMBLayerType type;
		[Export ("type")]
		TMBLayerType Type { get; }

		// @property (nonatomic, strong) TMBExpression * _Nullable filter;
		[NullAllowed, Export ("filter", ArgumentSemantic.Strong)]
		TMBExpression Filter { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable source;
		[NullAllowed, Export ("source")]
		string Source { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sourceLayer;
		[NullAllowed, Export ("sourceLayer")]
		string SourceLayer { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minZoom;
		[NullAllowed, Export ("minZoom", ArgumentSemantic.Strong)]
		NSNumber MinZoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxZoom;
		[NullAllowed, Export ("maxZoom", ArgumentSemantic.Strong)]
		NSNumber MaxZoom { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable visibility;
		[NullAllowed, Export ("visibility", ArgumentSemantic.Strong)]
		TMBValue Visibility { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable hillshadeAccentColor;
		[NullAllowed, Export ("hillshadeAccentColor", ArgumentSemantic.Strong)]
		TMBValue HillshadeAccentColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable hillshadeAccentColorTransition;
		[NullAllowed, Export ("hillshadeAccentColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition HillshadeAccentColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable hillshadeExaggeration;
		[NullAllowed, Export ("hillshadeExaggeration", ArgumentSemantic.Strong)]
		TMBValue HillshadeExaggeration { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable hillshadeExaggerationTransition;
		[NullAllowed, Export ("hillshadeExaggerationTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition HillshadeExaggerationTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable hillshadeHighlightColor;
		[NullAllowed, Export ("hillshadeHighlightColor", ArgumentSemantic.Strong)]
		TMBValue HillshadeHighlightColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable hillshadeHighlightColorTransition;
		[NullAllowed, Export ("hillshadeHighlightColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition HillshadeHighlightColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable hillshadeIlluminationAnchor;
		[NullAllowed, Export ("hillshadeIlluminationAnchor", ArgumentSemantic.Strong)]
		TMBValue HillshadeIlluminationAnchor { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable hillshadeIlluminationDirection;
		[NullAllowed, Export ("hillshadeIlluminationDirection", ArgumentSemantic.Strong)]
		TMBValue HillshadeIlluminationDirection { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable hillshadeShadowColor;
		[NullAllowed, Export ("hillshadeShadowColor", ArgumentSemantic.Strong)]
		TMBValue HillshadeShadowColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable hillshadeShadowColorTransition;
		[NullAllowed, Export ("hillshadeShadowColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition HillshadeShadowColorTransition { get; set; }
	}

	// @interface TMBImageSource : NSObject <TMBSource>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC14TMBImageSource")]
	[DisableDefaultCtor]
	interface TMBImageSource : TMBSource
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (readonly, nonatomic) enum TMBSourceType type;
		[Export ("type")]
		TMBSourceType Type { get; }

		// @property (copy, nonatomic) NSString * _Nullable url;
		[NullAllowed, Export ("url")]
		string Url { get; set; }

		// @property (copy, nonatomic) NSArray<NSArray<NSNumber *> *> * _Nullable coordinates;
		[NullAllowed, Export ("coordinates", ArgumentSemantic.Copy)]
		NSArray<NSNumber>[] Coordinates { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable prefetchZoomDelta;
		[NullAllowed, Export ("prefetchZoomDelta", ArgumentSemantic.Strong)]
		NSNumber PrefetchZoomDelta { get; set; }
	}

	// @interface TMBImmediateViewportTransition : NSObject <TMBViewportTransition>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC30TMBImmediateViewportTransition")]
	[DisableDefaultCtor]
	interface TMBImmediateViewportTransition : TMBViewportTransition
	{
		// // -(TMBCancelable * _Nonnull)runTo:(id<TMBViewportState> _Nonnull)toState completion:(void (^ _Nonnull)(BOOL))completion __attribute__((warn_unused_result("")));
		// [Export ("runTo:completion:")]
		// TMBCancelable RunTo (ITMBViewportState toState, Action<bool> completion);
	}

	// @interface TMBLayerInfo : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC12TMBLayerInfo")]
	[DisableDefaultCtor]
	interface TMBLayerInfo
	{
		// @property (copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; set; }

		// @property (nonatomic) enum TMBLayerType type;
		[Export ("type", ArgumentSemantic.Assign)]
		TMBLayerType Type { get; set; }
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

		// +(TMBLayerPosition * _Nonnull)atIndex:(NSInteger)index __attribute__((warn_unused_result("")));
		[Static]
		[Export ("atIndex:")]
		TMBLayerPosition AtIndex (nint index);

		// +(TMBLayerPosition * _Nonnull)belowLayerId:(NSString * _Nonnull)layerId __attribute__((warn_unused_result("")));
		[Static]
		[Export ("belowLayerId:")]
		TMBLayerPosition BelowLayerId (string layerId);

		// +(TMBLayerPosition * _Nonnull)aboveLayerId:(NSString * _Nonnull)layerId __attribute__((warn_unused_result("")));
		[Static]
		[Export ("aboveLayerId:")]
		TMBLayerPosition AboveLayerId (string layerId);
	}

	// @interface TMBLight : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC8TMBLight")]
	interface TMBLight
	{
		// @property (nonatomic, strong) NSNumber * _Nullable anchor;
		[NullAllowed, Export ("anchor", ArgumentSemantic.Strong)]
		NSNumber Anchor { get; set; }

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

	// @interface TMBLineLayer : NSObject <TMBLayer>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC12TMBLineLayer")]
	[DisableDefaultCtor]
	interface TMBLineLayer : TMBLayer
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; set; }

		// @property (readonly, nonatomic) enum TMBLayerType type;
		[Export ("type")]
		TMBLayerType Type { get; }

		// @property (nonatomic, strong) TMBExpression * _Nullable filter;
		[NullAllowed, Export ("filter", ArgumentSemantic.Strong)]
		TMBExpression Filter { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable source;
		[NullAllowed, Export ("source")]
		string Source { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sourceLayer;
		[NullAllowed, Export ("sourceLayer")]
		string SourceLayer { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minZoom;
		[NullAllowed, Export ("minZoom", ArgumentSemantic.Strong)]
		NSNumber MinZoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxZoom;
		[NullAllowed, Export ("maxZoom", ArgumentSemantic.Strong)]
		NSNumber MaxZoom { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable visibility;
		[NullAllowed, Export ("visibility", ArgumentSemantic.Strong)]
		TMBValue Visibility { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineCap;
		[NullAllowed, Export ("lineCap", ArgumentSemantic.Strong)]
		TMBValue LineCap { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineJoin;
		[NullAllowed, Export ("lineJoin", ArgumentSemantic.Strong)]
		TMBValue LineJoin { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineMiterLimit;
		[NullAllowed, Export ("lineMiterLimit", ArgumentSemantic.Strong)]
		TMBValue LineMiterLimit { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineRoundLimit;
		[NullAllowed, Export ("lineRoundLimit", ArgumentSemantic.Strong)]
		TMBValue LineRoundLimit { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineSortKey;
		[NullAllowed, Export ("lineSortKey", ArgumentSemantic.Strong)]
		TMBValue LineSortKey { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineBlur;
		[NullAllowed, Export ("lineBlur", ArgumentSemantic.Strong)]
		TMBValue LineBlur { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable lineBlurTransition;
		[NullAllowed, Export ("lineBlurTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition LineBlurTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineColor;
		[NullAllowed, Export ("lineColor", ArgumentSemantic.Strong)]
		TMBValue LineColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable lineColorTransition;
		[NullAllowed, Export ("lineColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition LineColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineDasharray;
		[NullAllowed, Export ("lineDasharray", ArgumentSemantic.Strong)]
		TMBValue LineDasharray { get; set; }

		// @property (nonatomic, strong) SWIFT_DEPRECATED_MSG("This property is deprecated and will be removed in the future. Setting this will have no effect.") TMBStyleTransition * lineDasharrayTransition __attribute__((deprecated("This property is deprecated and will be removed in the future. Setting this will have no effect.")));
		[Export ("lineDasharrayTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition LineDasharrayTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineGapWidth;
		[NullAllowed, Export ("lineGapWidth", ArgumentSemantic.Strong)]
		TMBValue LineGapWidth { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable lineGapWidthTransition;
		[NullAllowed, Export ("lineGapWidthTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition LineGapWidthTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineGradient;
		[NullAllowed, Export ("lineGradient", ArgumentSemantic.Strong)]
		TMBValue LineGradient { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineOffset;
		[NullAllowed, Export ("lineOffset", ArgumentSemantic.Strong)]
		TMBValue LineOffset { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable lineOffsetTransition;
		[NullAllowed, Export ("lineOffsetTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition LineOffsetTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineOpacity;
		[NullAllowed, Export ("lineOpacity", ArgumentSemantic.Strong)]
		TMBValue LineOpacity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable lineOpacityTransition;
		[NullAllowed, Export ("lineOpacityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition LineOpacityTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable linePattern;
		[NullAllowed, Export ("linePattern", ArgumentSemantic.Strong)]
		TMBValue LinePattern { get; set; }

		// @property (nonatomic, strong) SWIFT_DEPRECATED_MSG("This property is deprecated and will be removed in the future. Setting this will have no effect.") TMBStyleTransition * linePatternTransition __attribute__((deprecated("This property is deprecated and will be removed in the future. Setting this will have no effect.")));
		[Export ("linePatternTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition LinePatternTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineTranslate;
		[NullAllowed, Export ("lineTranslate", ArgumentSemantic.Strong)]
		TMBValue LineTranslate { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable lineTranslateTransition;
		[NullAllowed, Export ("lineTranslateTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition LineTranslateTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineTranslateAnchor;
		[NullAllowed, Export ("lineTranslateAnchor", ArgumentSemantic.Strong)]
		TMBValue LineTranslateAnchor { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineTrimOffset;
		[NullAllowed, Export ("lineTrimOffset", ArgumentSemantic.Strong)]
		TMBValue LineTrimOffset { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable lineWidth;
		[NullAllowed, Export ("lineWidth", ArgumentSemantic.Strong)]
		TMBValue LineWidth { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable lineWidthTransition;
		[NullAllowed, Export ("lineWidthTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition LineWidthTransition { get; set; }
	}

	// @interface TMBLocationIndicatorLayer : NSObject <TMBLayer>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC25TMBLocationIndicatorLayer")]
	[DisableDefaultCtor]
	interface TMBLocationIndicatorLayer : TMBLayer
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; set; }

		// @property (readonly, nonatomic) enum TMBLayerType type;
		[Export ("type")]
		TMBLayerType Type { get; }

		// @property (nonatomic, strong) TMBExpression * _Nullable filter;
		[NullAllowed, Export ("filter", ArgumentSemantic.Strong)]
		TMBExpression Filter { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable source;
		[NullAllowed, Export ("source")]
		string Source { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sourceLayer;
		[NullAllowed, Export ("sourceLayer")]
		string SourceLayer { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minZoom;
		[NullAllowed, Export ("minZoom", ArgumentSemantic.Strong)]
		NSNumber MinZoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxZoom;
		[NullAllowed, Export ("maxZoom", ArgumentSemantic.Strong)]
		NSNumber MaxZoom { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable visibility;
		[NullAllowed, Export ("visibility", ArgumentSemantic.Strong)]
		TMBValue Visibility { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable bearingImage;
		[NullAllowed, Export ("bearingImage", ArgumentSemantic.Strong)]
		TMBValue BearingImage { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable shadowImage;
		[NullAllowed, Export ("shadowImage", ArgumentSemantic.Strong)]
		TMBValue ShadowImage { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable topImage;
		[NullAllowed, Export ("topImage", ArgumentSemantic.Strong)]
		TMBValue TopImage { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable accuracyRadius;
		[NullAllowed, Export ("accuracyRadius", ArgumentSemantic.Strong)]
		TMBValue AccuracyRadius { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable accuracyRadiusTransition;
		[NullAllowed, Export ("accuracyRadiusTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition AccuracyRadiusTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable accuracyRadiusBorderColor;
		[NullAllowed, Export ("accuracyRadiusBorderColor", ArgumentSemantic.Strong)]
		TMBValue AccuracyRadiusBorderColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable accuracyRadiusBorderColorTransition;
		[NullAllowed, Export ("accuracyRadiusBorderColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition AccuracyRadiusBorderColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable accuracyRadiusColor;
		[NullAllowed, Export ("accuracyRadiusColor", ArgumentSemantic.Strong)]
		TMBValue AccuracyRadiusColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable accuracyRadiusColorTransition;
		[NullAllowed, Export ("accuracyRadiusColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition AccuracyRadiusColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable bearing;
		[NullAllowed, Export ("bearing", ArgumentSemantic.Strong)]
		TMBValue Bearing { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable bearingTransition;
		[NullAllowed, Export ("bearingTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition BearingTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable bearingImageSize;
		[NullAllowed, Export ("bearingImageSize", ArgumentSemantic.Strong)]
		TMBValue BearingImageSize { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable bearingImageSizeTransition;
		[NullAllowed, Export ("bearingImageSizeTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition BearingImageSizeTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable emphasisCircleColor;
		[NullAllowed, Export ("emphasisCircleColor", ArgumentSemantic.Strong)]
		TMBValue EmphasisCircleColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable emphasisCircleColorTransition;
		[NullAllowed, Export ("emphasisCircleColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition EmphasisCircleColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable emphasisCircleRadius;
		[NullAllowed, Export ("emphasisCircleRadius", ArgumentSemantic.Strong)]
		TMBValue EmphasisCircleRadius { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable emphasisCircleRadiusTransition;
		[NullAllowed, Export ("emphasisCircleRadiusTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition EmphasisCircleRadiusTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable imagePitchDisplacement;
		[NullAllowed, Export ("imagePitchDisplacement", ArgumentSemantic.Strong)]
		TMBValue ImagePitchDisplacement { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable location;
		[NullAllowed, Export ("location", ArgumentSemantic.Strong)]
		TMBValue Location { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable locationTransition;
		[NullAllowed, Export ("locationTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition LocationTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable locationIndicatorOpacity;
		[NullAllowed, Export ("locationIndicatorOpacity", ArgumentSemantic.Strong)]
		TMBValue LocationIndicatorOpacity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable locationIndicatorOpacityTransition;
		[NullAllowed, Export ("locationIndicatorOpacityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition LocationIndicatorOpacityTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable perspectiveCompensation;
		[NullAllowed, Export ("perspectiveCompensation", ArgumentSemantic.Strong)]
		TMBValue PerspectiveCompensation { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable shadowImageSize;
		[NullAllowed, Export ("shadowImageSize", ArgumentSemantic.Strong)]
		TMBValue ShadowImageSize { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable shadowImageSizeTransition;
		[NullAllowed, Export ("shadowImageSizeTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition ShadowImageSizeTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable topImageSize;
		[NullAllowed, Export ("topImageSize", ArgumentSemantic.Strong)]
		TMBValue TopImageSize { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable topImageSizeTransition;
		[NullAllowed, Export ("topImageSizeTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition TopImageSizeTransition { get; set; }
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
		ITMBLocationPermissionsDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TMBLocationPermissionsDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong) id<TMBLocationProvider> _Null_unspecified locationProvider;
		[Export ("locationProvider", ArgumentSemantic.Strong)]
		ITMBLocationProvider LocationProvider { get; }

		// @property (readonly, nonatomic, strong) NSHashTable<id<LocationConsumer>> * _Nonnull consumers;
		[Export ("consumers", ArgumentSemantic.Strong)]
        NSObject Consumers { get; }

		// @property (nonatomic, strong) TMBLocationOptions * _Nonnull options;
		[Export ("options", ArgumentSemantic.Strong)]
		TMBLocationOptions Options { get; set; }

		// -(void)overrideLocationProviderWith:(id<TMBLocationProvider> _Nonnull)customLocationProvider;
		[Export ("overrideLocationProviderWith:")]
		void OverrideLocationProviderWith (ITMBLocationProvider customLocationProvider);

		// -(void)addLocationConsumer:(id<LocationConsumer> _Nonnull)consumer;
		[Export ("addLocationConsumer:")]
		void AddLocationConsumer (ILocationConsumer consumer);

		// -(void)removeLocationConsumer:(id<LocationConsumer> _Nonnull)consumer;
		[Export ("removeLocationConsumer:")]
		void RemoveLocationConsumer (ILocationConsumer consumer);

		// -(void)addPuckLocationConsumer:(id<PuckLocationConsumer> _Nonnull)consumer;
		[Export ("addPuckLocationConsumer:")]
		void AddPuckLocationConsumer (IPuckLocationConsumer consumer);

		// -(void)removePuckLocationConsumer:(id<PuckLocationConsumer> _Nonnull)consumer;
		[Export ("removePuckLocationConsumer:")]
		void RemovePuckLocationConsumer (IPuckLocationConsumer consumer);

		// -(void)requestTemporaryFullAccuracyPermissionsWithPurposeKey:(NSString * _Nonnull)purposeKey __attribute__((availability(ios, introduced=14.0)));
		// [iOS (14,0)]
		[Export ("requestTemporaryFullAccuracyPermissionsWithPurposeKey:")]
		void RequestTemporaryFullAccuracyPermissionsWithPurposeKey (string purposeKey);
	}

	// @interface MapboxMapObjC_Swift_2705 (TMBLocationManager)
	[Category]
	[BaseType (typeof(TMBLocationManager))]
	interface TMBLocationManager_MapboxMapObjC_Swift_2705
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

	partial interface ITMBLocationPermissionsDelegate { }

    // @protocol TMBLocationPermissionsDelegate
    [Protocol (Name = "_TtP13MapboxMapObjC30TMBLocationPermissionsDelegate_"), Model]
	[BaseType(typeof(NSObject))]
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
		// [iOS (14,0)]
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

	// @interface MapboxMapObjC_Swift_3188 (TMBMapboxMap)
	[Category]
	[BaseType (typeof(TMBMapboxMap))]
	interface TMBMapboxMap_MapboxMapObjC_Swift_3188
	{
		// -(void)clearDataWithCompletion:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Export ("clearDataWithCompletion:")]
		void ClearDataWithCompletion (Action<NSError> completion);
	}

	// @interface MapboxMapObjC_Swift_3203 (TMBMapboxMap)
	[Category]
	[BaseType (typeof(TMBMapboxMap))]
	interface TMBMapboxMap_MapboxMapObjC_Swift_3203
	{
		// -(void)subscribe:(id<MBMObserver> _Nonnull)observer events:(NSArray<NSString *> * _Nonnull)events;
		[Export ("subscribe:events:")]
		void Subscribe (IMBMObserver observer, string[] events);

		// -(void)unsubscribe:(id<MBMObserver> _Nonnull)observer events:(NSArray<NSString *> * _Nonnull)events;
		[Export ("unsubscribe:events:")]
		void Unsubscribe (IMBMObserver observer, string[] events);
	}

	// @interface MapboxMapObjC_Swift_3229 (TMBMapboxMap)
	[Category]
	[BaseType (typeof(TMBMapboxMap))]
	interface TMBMapboxMap_MapboxMapObjC_Swift_3229
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

	// @interface MapboxMapObjC_Swift_3270 (TMBMapboxMap)
	[Category]
	[BaseType (typeof(TMBMapboxMap))]
	interface TMBMapboxMap_MapboxMapObjC_Swift_3270
	{
		// -(TMBCancelable * _Nonnull)queryRenderedFeaturesWithShape:(NSArray<NSValue *> * _Nonnull)shape options:(MBMRenderedQueryOptions * _Nullable)options completion:(void (^ _Nullable)(NSArray<MBMQueriedFeature *> * _Nullable, NSError * _Nullable))completion;
		[Export ("queryRenderedFeaturesWithShape:options:completion:")]
		TMBCancelable QueryRenderedFeaturesWithShape (NSValue[] shape, [NullAllowed] MBMRenderedQueryOptions options, [NullAllowed] Action<MBMQueriedFeature[], NSError> completion);

		// -(TMBCancelable * _Nonnull)queryRenderedFeaturesWithRect:(CGRect)rect options:(MBMRenderedQueryOptions * _Nullable)options completion:(void (^ _Nullable)(NSArray<MBMQueriedFeature *> * _Nullable, NSError * _Nullable))completion;
		[Export ("queryRenderedFeaturesWithRect:options:completion:")]
		TMBCancelable QueryRenderedFeaturesWithRect (CGRect rect, [NullAllowed] MBMRenderedQueryOptions options, [NullAllowed] Action<MBMQueriedFeature[], NSError> completion);

		// -(TMBCancelable * _Nonnull)queryRenderedFeaturesWithPoint:(CGPoint)point options:(MBMRenderedQueryOptions * _Nullable)options completion:(void (^ _Nullable)(NSArray<MBMQueriedFeature *> * _Nullable, NSError * _Nullable))completion;
		[Export ("queryRenderedFeaturesWithPoint:options:completion:")]
		TMBCancelable QueryRenderedFeaturesWithPoint (CGPoint point, [NullAllowed] MBMRenderedQueryOptions options, [NullAllowed] Action<MBMQueriedFeature[], NSError> completion);

		// -(void)querySourceFeaturesFor:(NSString * _Nonnull)sourceId options:(MBMSourceQueryOptions * _Nonnull)options completion:(void (^ _Nullable)(NSArray<MBMQueriedFeature *> * _Nullable, NSError * _Nullable))completion;
		[Export ("querySourceFeaturesFor:options:completion:")]
		void QuerySourceFeaturesFor (string sourceId, MBMSourceQueryOptions options, [NullAllowed] Action<MBMQueriedFeature[], NSError> completion);

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

	// @interface MapboxMapObjC_Swift_3363 (TMBMapboxMap)
	[Category]
	[BaseType (typeof(TMBMapboxMap))]
	interface TMBMapboxMap_MapboxMapObjC_Swift_3363
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

	// @interface MapboxMapObjC_Swift_3770 (TMBOverviewViewportState) <TMBViewportState>
	[Category]
	[BaseType (typeof(TMBOverviewViewportState))]
	interface TMBOverviewViewportState_MapboxMapObjC_Swift_3770 : ITMBViewportState
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

		// @property (nonatomic, strong) NSNumber * _Nullable iconAnchor;
		[NullAllowed, Export ("iconAnchor", ArgumentSemantic.Strong)]
		NSNumber IconAnchor { get; set; }

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

		// @property (nonatomic, strong) NSNumber * _Nullable textAnchor;
		[NullAllowed, Export ("textAnchor", ArgumentSemantic.Strong)]
		NSNumber TextAnchor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable textField;
		[NullAllowed, Export ("textField")]
		string TextField { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textJustify;
		[NullAllowed, Export ("textJustify", ArgumentSemantic.Strong)]
		NSNumber TextJustify { get; set; }

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

		// @property (nonatomic, strong) NSNumber * _Nullable textTransform;
		[NullAllowed, Export ("textTransform", ArgumentSemantic.Strong)]
		NSNumber TextTransform { get; set; }

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

		// @property (nonatomic, strong) NSNumber * _Nullable iconPitchAlignment;
		[NullAllowed, Export ("iconPitchAlignment", ArgumentSemantic.Strong)]
		NSNumber IconPitchAlignment { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable iconRotationAlignment;
		[NullAllowed, Export ("iconRotationAlignment", ArgumentSemantic.Strong)]
		NSNumber IconRotationAlignment { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable iconTextFit;
		[NullAllowed, Export ("iconTextFit", ArgumentSemantic.Strong)]
		NSNumber IconTextFit { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable iconTextFitPadding;
		[NullAllowed, Export ("iconTextFitPadding", ArgumentSemantic.Copy)]
		NSNumber[] IconTextFitPadding { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable symbolAvoidEdges;
		[NullAllowed, Export ("symbolAvoidEdges", ArgumentSemantic.Strong)]
		NSNumber SymbolAvoidEdges { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable symbolPlacement;
		[NullAllowed, Export ("symbolPlacement", ArgumentSemantic.Strong)]
		NSNumber SymbolPlacement { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable symbolSpacing;
		[NullAllowed, Export ("symbolSpacing", ArgumentSemantic.Strong)]
		NSNumber SymbolSpacing { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable symbolZOrder;
		[NullAllowed, Export ("symbolZOrder", ArgumentSemantic.Strong)]
		NSNumber SymbolZOrder { get; set; }

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

		// @property (nonatomic, strong) NSNumber * _Nullable textPitchAlignment;
		[NullAllowed, Export ("textPitchAlignment", ArgumentSemantic.Strong)]
		NSNumber TextPitchAlignment { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textRotationAlignment;
		[NullAllowed, Export ("textRotationAlignment", ArgumentSemantic.Strong)]
		NSNumber TextRotationAlignment { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable textVariableAnchor;
		[NullAllowed, Export ("textVariableAnchor", ArgumentSemantic.Copy)]
		NSNumber[] TextVariableAnchor { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable textWritingMode;
		[NullAllowed, Export ("textWritingMode", ArgumentSemantic.Copy)]
		NSNumber[] TextWritingMode { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable iconTranslate;
		[NullAllowed, Export ("iconTranslate", ArgumentSemantic.Copy)]
		NSNumber[] IconTranslate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable iconTranslateAnchor;
		[NullAllowed, Export ("iconTranslateAnchor", ArgumentSemantic.Strong)]
		NSNumber IconTranslateAnchor { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable textTranslate;
		[NullAllowed, Export ("textTranslate", ArgumentSemantic.Copy)]
		NSNumber[] TextTranslate { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable textTranslateAnchor;
		[NullAllowed, Export ("textTranslateAnchor", ArgumentSemantic.Strong)]
		NSNumber TextTranslateAnchor { get; set; }

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

		// @property (nonatomic, strong) NSNumber * _Nullable fillTranslateAnchor;
		[NullAllowed, Export ("fillTranslateAnchor", ArgumentSemantic.Strong)]
		NSNumber FillTranslateAnchor { get; set; }

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

		// @property (nonatomic, strong) NSNumber * _Nullable lineJoin;
		[NullAllowed, Export ("lineJoin", ArgumentSemantic.Strong)]
		NSNumber LineJoin { get; set; }

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

		// @property (nonatomic, strong) NSNumber * _Nullable lineCap;
		[NullAllowed, Export ("lineCap", ArgumentSemantic.Strong)]
		NSNumber LineCap { get; set; }

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

		// @property (nonatomic, strong) NSNumber * _Nullable lineTranslateAnchor;
		[NullAllowed, Export ("lineTranslateAnchor", ArgumentSemantic.Strong)]
		NSNumber LineTranslateAnchor { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable lineTrimOffset;
		[NullAllowed, Export ("lineTrimOffset", ArgumentSemantic.Copy)]
		NSNumber[] LineTrimOffset { get; set; }
	}

	// @interface TMBPromoteId : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC12TMBPromoteId")]
	[DisableDefaultCtor]
	interface TMBPromoteId
	{
		// @property (readonly, nonatomic) enum TMBPromoteIdType type;
		[Export ("type")]
		TMBPromoteIdType Type { get; }

		// +(TMBPromoteId * _Nonnull)stringWithValue:(NSString * _Nonnull)value __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stringWithValue:")]
		TMBPromoteId StringWithValue (string value);

		// +(TMBPromoteId * _Nonnull)objectWithValue:(NSDictionary<NSString *,NSString *> * _Nonnull)value __attribute__((warn_unused_result("")));
		[Static]
		[Export ("objectWithValue:")]
		TMBPromoteId ObjectWithValue (NSDictionary<NSString, NSString> value);
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

	// @interface TMBRasterDemSource : NSObject <TMBSource>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBRasterDemSource")]
	[DisableDefaultCtor]
	interface TMBRasterDemSource : TMBSource
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (readonly, nonatomic) enum TMBSourceType type;
		[Export ("type")]
		TMBSourceType Type { get; }

		// @property (copy, nonatomic) NSString * _Nullable url;
		[NullAllowed, Export ("url")]
		string Url { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable tiles;
		[NullAllowed, Export ("tiles", ArgumentSemantic.Copy)]
		string[] Tiles { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable bounds;
		[NullAllowed, Export ("bounds", ArgumentSemantic.Copy)]
		NSNumber[] Bounds { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minzoom;
		[NullAllowed, Export ("minzoom", ArgumentSemantic.Strong)]
		NSNumber Minzoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxzoom;
		[NullAllowed, Export ("maxzoom", ArgumentSemantic.Strong)]
		NSNumber Maxzoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable tileSize;
		[NullAllowed, Export ("tileSize", ArgumentSemantic.Strong)]
		NSNumber TileSize { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable attribution;
		[NullAllowed, Export ("attribution")]
		string Attribution { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable encoding;
		[NullAllowed, Export ("encoding", ArgumentSemantic.Strong)]
		NSNumber Encoding { get; set; }

		// @property (getter = volatile, nonatomic, setter = setVolatile:, strong) NSNumber * _Nullable volatile_;
		[NullAllowed, Export ("volatile_", ArgumentSemantic.Strong)]
		NSNumber Volatile_ { [Bind ("volatile")] get; [Bind ("setVolatile:")] set; }

		// @property (nonatomic, strong) NSNumber * _Nullable prefetchZoomDelta;
		[NullAllowed, Export ("prefetchZoomDelta", ArgumentSemantic.Strong)]
		NSNumber PrefetchZoomDelta { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minimumTileUpdateInterval;
		[NullAllowed, Export ("minimumTileUpdateInterval", ArgumentSemantic.Strong)]
		NSNumber MinimumTileUpdateInterval { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxOverscaleFactorForParentTiles;
		[NullAllowed, Export ("maxOverscaleFactorForParentTiles", ArgumentSemantic.Strong)]
		NSNumber MaxOverscaleFactorForParentTiles { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable tileRequestsDelay;
		[NullAllowed, Export ("tileRequestsDelay", ArgumentSemantic.Strong)]
		NSNumber TileRequestsDelay { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable tileNetworkRequestsDelay;
		[NullAllowed, Export ("tileNetworkRequestsDelay", ArgumentSemantic.Strong)]
		NSNumber TileNetworkRequestsDelay { get; set; }
	}

	// @interface TMBRasterLayer : NSObject <TMBLayer>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC14TMBRasterLayer")]
	[DisableDefaultCtor]
	interface TMBRasterLayer : TMBLayer
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; set; }

		// @property (readonly, nonatomic) enum TMBLayerType type;
		[Export ("type")]
		TMBLayerType Type { get; }

		// @property (nonatomic, strong) TMBExpression * _Nullable filter;
		[NullAllowed, Export ("filter", ArgumentSemantic.Strong)]
		TMBExpression Filter { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable source;
		[NullAllowed, Export ("source")]
		string Source { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sourceLayer;
		[NullAllowed, Export ("sourceLayer")]
		string SourceLayer { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minZoom;
		[NullAllowed, Export ("minZoom", ArgumentSemantic.Strong)]
		NSNumber MinZoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxZoom;
		[NullAllowed, Export ("maxZoom", ArgumentSemantic.Strong)]
		NSNumber MaxZoom { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable visibility;
		[NullAllowed, Export ("visibility", ArgumentSemantic.Strong)]
		TMBValue Visibility { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable rasterBrightnessMax;
		[NullAllowed, Export ("rasterBrightnessMax", ArgumentSemantic.Strong)]
		TMBValue RasterBrightnessMax { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable rasterBrightnessMaxTransition;
		[NullAllowed, Export ("rasterBrightnessMaxTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition RasterBrightnessMaxTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable rasterBrightnessMin;
		[NullAllowed, Export ("rasterBrightnessMin", ArgumentSemantic.Strong)]
		TMBValue RasterBrightnessMin { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable rasterBrightnessMinTransition;
		[NullAllowed, Export ("rasterBrightnessMinTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition RasterBrightnessMinTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable rasterContrast;
		[NullAllowed, Export ("rasterContrast", ArgumentSemantic.Strong)]
		TMBValue RasterContrast { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable rasterContrastTransition;
		[NullAllowed, Export ("rasterContrastTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition RasterContrastTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable rasterFadeDuration;
		[NullAllowed, Export ("rasterFadeDuration", ArgumentSemantic.Strong)]
		TMBValue RasterFadeDuration { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable rasterHueRotate;
		[NullAllowed, Export ("rasterHueRotate", ArgumentSemantic.Strong)]
		TMBValue RasterHueRotate { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable rasterHueRotateTransition;
		[NullAllowed, Export ("rasterHueRotateTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition RasterHueRotateTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable rasterOpacity;
		[NullAllowed, Export ("rasterOpacity", ArgumentSemantic.Strong)]
		TMBValue RasterOpacity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable rasterOpacityTransition;
		[NullAllowed, Export ("rasterOpacityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition RasterOpacityTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable rasterResampling;
		[NullAllowed, Export ("rasterResampling", ArgumentSemantic.Strong)]
		TMBValue RasterResampling { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable rasterSaturation;
		[NullAllowed, Export ("rasterSaturation", ArgumentSemantic.Strong)]
		TMBValue RasterSaturation { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable rasterSaturationTransition;
		[NullAllowed, Export ("rasterSaturationTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition RasterSaturationTransition { get; set; }
	}

	// @interface TMBRasterSource : NSObject <TMBSource>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC15TMBRasterSource")]
	[DisableDefaultCtor]
	interface TMBRasterSource : TMBSource
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (readonly, nonatomic) enum TMBSourceType type;
		[Export ("type")]
		TMBSourceType Type { get; }

		// @property (copy, nonatomic) NSString * _Nullable url;
		[NullAllowed, Export ("url")]
		string Url { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable tiles;
		[NullAllowed, Export ("tiles", ArgumentSemantic.Copy)]
		string[] Tiles { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable bounds;
		[NullAllowed, Export ("bounds", ArgumentSemantic.Copy)]
		NSNumber[] Bounds { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minzoom;
		[NullAllowed, Export ("minzoom", ArgumentSemantic.Strong)]
		NSNumber Minzoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxzoom;
		[NullAllowed, Export ("maxzoom", ArgumentSemantic.Strong)]
		NSNumber Maxzoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable tileSize;
		[NullAllowed, Export ("tileSize", ArgumentSemantic.Strong)]
		NSNumber TileSize { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable scheme;
		[NullAllowed, Export ("scheme", ArgumentSemantic.Strong)]
		NSNumber Scheme { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable attribution;
		[NullAllowed, Export ("attribution")]
		string Attribution { get; set; }

		// @property (getter = volatile, nonatomic, setter = setVolatile:, strong) NSNumber * _Nullable volatile_;
		[NullAllowed, Export ("volatile_", ArgumentSemantic.Strong)]
		NSNumber Volatile_ { [Bind ("volatile")] get; [Bind ("setVolatile:")] set; }

		// @property (nonatomic, strong) NSNumber * _Nullable prefetchZoomDelta;
		[NullAllowed, Export ("prefetchZoomDelta", ArgumentSemantic.Strong)]
		NSNumber PrefetchZoomDelta { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minimumTileUpdateInterval;
		[NullAllowed, Export ("minimumTileUpdateInterval", ArgumentSemantic.Strong)]
		NSNumber MinimumTileUpdateInterval { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxOverscaleFactorForParentTiles;
		[NullAllowed, Export ("maxOverscaleFactorForParentTiles", ArgumentSemantic.Strong)]
		NSNumber MaxOverscaleFactorForParentTiles { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable tileRequestsDelay;
		[NullAllowed, Export ("tileRequestsDelay", ArgumentSemantic.Strong)]
		NSNumber TileRequestsDelay { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable tileNetworkRequestsDelay;
		[NullAllowed, Export ("tileNetworkRequestsDelay", ArgumentSemantic.Strong)]
		NSNumber TileNetworkRequestsDelay { get; set; }
	}

	// @interface TMBResolvedImage : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC16TMBResolvedImage")]
	[DisableDefaultCtor]
	interface TMBResolvedImage
	{
	}

	// @interface MapboxMapObjC_Swift_4368 (TMBResolvedImage)
	[Category]
	[BaseType (typeof(TMBResolvedImage))]
	interface TMBResolvedImage_MapboxMapObjC_Swift_4368
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

	// @interface TMBSkyLayer : NSObject <TMBLayer>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC11TMBSkyLayer")]
	[DisableDefaultCtor]
	interface TMBSkyLayer : TMBLayer
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; set; }

		// @property (readonly, nonatomic) enum TMBLayerType type;
		[Export ("type")]
		TMBLayerType Type { get; }

		// @property (nonatomic, strong) TMBExpression * _Nullable filter;
		[NullAllowed, Export ("filter", ArgumentSemantic.Strong)]
		TMBExpression Filter { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable source;
		[NullAllowed, Export ("source")]
		string Source { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sourceLayer;
		[NullAllowed, Export ("sourceLayer")]
		string SourceLayer { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minZoom;
		[NullAllowed, Export ("minZoom", ArgumentSemantic.Strong)]
		NSNumber MinZoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxZoom;
		[NullAllowed, Export ("maxZoom", ArgumentSemantic.Strong)]
		NSNumber MaxZoom { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable visibility;
		[NullAllowed, Export ("visibility", ArgumentSemantic.Strong)]
		TMBValue Visibility { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable skyAtmosphereColor;
		[NullAllowed, Export ("skyAtmosphereColor", ArgumentSemantic.Strong)]
		TMBValue SkyAtmosphereColor { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable skyAtmosphereHaloColor;
		[NullAllowed, Export ("skyAtmosphereHaloColor", ArgumentSemantic.Strong)]
		TMBValue SkyAtmosphereHaloColor { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable skyAtmosphereSun;
		[NullAllowed, Export ("skyAtmosphereSun", ArgumentSemantic.Strong)]
		TMBValue SkyAtmosphereSun { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable skyAtmosphereSunIntensity;
		[NullAllowed, Export ("skyAtmosphereSunIntensity", ArgumentSemantic.Strong)]
		TMBValue SkyAtmosphereSunIntensity { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable skyGradient;
		[NullAllowed, Export ("skyGradient", ArgumentSemantic.Strong)]
		TMBValue SkyGradient { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable skyGradientCenter;
		[NullAllowed, Export ("skyGradientCenter", ArgumentSemantic.Strong)]
		TMBValue SkyGradientCenter { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable skyGradientRadius;
		[NullAllowed, Export ("skyGradientRadius", ArgumentSemantic.Strong)]
		TMBValue SkyGradientRadius { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable skyOpacity;
		[NullAllowed, Export ("skyOpacity", ArgumentSemantic.Strong)]
		TMBValue SkyOpacity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable skyOpacityTransition;
		[NullAllowed, Export ("skyOpacityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition SkyOpacityTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable skyType;
		[NullAllowed, Export ("skyType", ArgumentSemantic.Strong)]
		TMBValue SkyType { get; set; }
	}

	// @interface TMBSourceInfo : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC13TMBSourceInfo")]
	[DisableDefaultCtor]
	interface TMBSourceInfo
	{
		// @property (copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; set; }

		// @property (nonatomic) enum TMBSourceType type;
		[Export ("type", ArgumentSemantic.Assign)]
		TMBSourceType Type { get; set; }
	}

	// @interface TMBStyle : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC8TMBStyle")]
	[DisableDefaultCtor]
	interface TMBStyle
	{
		// @property (readonly, nonatomic, weak) MBMStyleManager * _Null_unspecified styleManager;
		[Export ("styleManager", ArgumentSemantic.Weak)]
		MBMStyleManager StyleManager { get; }

		// -(void)addLayer:(id<TMBLayer> _Nonnull)layer layerPosition:(TMBLayerPosition * _Nullable)layerPosition completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addLayer:layerPosition:completion:")]
		void AddLayer (ITMBLayer layer, [NullAllowed] TMBLayerPosition layerPosition, [NullAllowed] Action<NSError> completion);

		// -(void)addPersistentLayer:(id<TMBLayer> _Nonnull)layer layerPosition:(TMBLayerPosition * _Nullable)layerPosition completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addPersistentLayer:layerPosition:completion:")]
		void AddPersistentLayer (ITMBLayer layer, [NullAllowed] TMBLayerPosition layerPosition, [NullAllowed] Action<NSError> completion);

		// -(void)moveLayerWithId:(NSString * _Nonnull)id to:(TMBLayerPosition * _Nonnull)position completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("moveLayerWithId:to:completion:")]
		void MoveLayerWithId (string id, TMBLayerPosition position, [NullAllowed] Action<NSError> completion);

		// -(void)layerWithId:(NSString * _Nonnull)id type:(enum TMBLayerType)type completion:(void (^ _Nullable)(id<TMBLayer> _Nullable, NSError * _Nullable))completion;
		[Export ("layerWithId:type:completion:")]
		void LayerWithId (string id, TMBLayerType type, [NullAllowed] Action<ITMBLayer, NSError> completion);

		// -(void)layerWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(id<TMBLayer> _Nullable, NSError * _Nullable))completion;
		[Export ("layerWithId:completion:")]
		void LayerWithId (string id, [NullAllowed] Action<ITMBLayer, NSError> completion);

		// -(void)updateLayerWithId:(NSString * _Nonnull)id type:(enum TMBLayerType)type update:(id<TMBLayer>  _Nonnull (^ _Nonnull)(id<TMBLayer> _Nonnull))update completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("updateLayerWithId:type:update:completion:")]
		void UpdateLayerWithId (string id, TMBLayerType type, Func<ITMBLayer, ITMBLayer> update, [NullAllowed] Action<NSError> completion);

		// -(void)addSource:(id<TMBSource> _Nonnull)source id:(NSString * _Nonnull)id completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addSource:id:completion:")]
		void AddSource (TMBSource source, string id, [NullAllowed] Action<NSError> completion);

		// -(void)addSourceWithId:(NSString * _Nonnull)id geometry:(MBXGeometry * _Nonnull)geometry completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addSourceWithId:geometry:completion:")]
		void AddSourceWithId (string id, MBXGeometry geometry, [NullAllowed] Action<NSError> completion);

		// -(void)sourceWithId:(NSString * _Nonnull)id type:(enum TMBSourceType)type completion:(void (^ _Nullable)(id<TMBSource> _Nullable, NSError * _Nullable))completion;
		[Export ("sourceWithId:type:completion:")]
		void SourceWithId (string id, TMBSourceType type, [NullAllowed] Action<ITMBSource, NSError> completion);

		// -(void)sourceWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(id<TMBSource> _Nullable, NSError * _Nullable))completion;
		[Export ("sourceWithId:completion:")]
		void SourceWithId (string id, [NullAllowed] Action<ITMBSource, NSError> completion);

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

		// -(void)addLayerWithProperties:(NSDictionary<NSString *,id> * _Nonnull)properties layerPosition:(TMBLayerPosition * _Nullable)layerPosition completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addLayerWithProperties:layerPosition:completion:")]
		void AddLayerWithProperties (NSDictionary<NSString, NSObject> properties, [NullAllowed] TMBLayerPosition layerPosition, [NullAllowed] Action<NSError> completion);

		// -(void)addPersistentLayerWith:(NSDictionary<NSString *,id> * _Nonnull)properties layerPosition:(TMBLayerPosition * _Nullable)layerPosition completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addPersistentLayerWith:layerPosition:completion:")]
		void AddPersistentLayerWith (NSDictionary<NSString, NSObject> properties, [NullAllowed] TMBLayerPosition layerPosition, [NullAllowed] Action<NSError> completion);

		// -(void)isPersistentLayerWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(NSNumber * _Nullable, NSError * _Nullable))completion;
		[Export ("isPersistentLayerWithId:completion:")]
		void IsPersistentLayerWithId (string id, [NullAllowed] Action<NSNumber, NSError> completion);

		// -(void)addPersistentCustomLayerWithId:(NSString * _Nonnull)id layerHost:(id<MBMCustomLayerHost> _Nonnull)layerHost layerPosition:(TMBLayerPosition * _Nullable)layerPosition completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addPersistentCustomLayerWithId:layerHost:layerPosition:completion:")]
		void AddPersistentCustomLayerWithId (string id, IMBMCustomLayerHost layerHost, [NullAllowed] TMBLayerPosition layerPosition, [NullAllowed] Action<NSError> completion);

		// -(void)addCustomLayerWithId:(NSString * _Nonnull)id layerHost:(id<MBMCustomLayerHost> _Nonnull)layerHost layerPosition:(TMBLayerPosition * _Nullable)layerPosition completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("addCustomLayerWithId:layerHost:layerPosition:completion:")]
		void AddCustomLayerWithId (string id, IMBMCustomLayerHost layerHost, [NullAllowed] TMBLayerPosition layerPosition, [NullAllowed] Action<NSError> completion);

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

	// @interface MapboxMapObjC_Swift_5249 (TMBStyle)
	[Category]
	[BaseType (typeof(TMBStyle))]
	interface TMBStyle_MapboxMapObjC_Swift_5249
	{
		// -(void)addGeoJSONSourceWithId:(NSString * _Nonnull)id properties:(NSDictionary<NSString *,id> * _Nonnull)properties geojson:(NSString * _Nonnull)geojson onComplete:(void (^ _Nullable)(NSError * _Nullable))onComplete;
		[Export ("addGeoJSONSourceWithId:properties:geojson:onComplete:")]
		void AddGeoJSONSourceWithId (string id, NSDictionary<NSString, NSObject> properties, string geojson, [NullAllowed] Action<NSError> onComplete);

		// -(void)updateGeoJSONSourceWithId:(NSString * _Nonnull)id geojson:(NSString * _Nonnull)geojson onComplete:(void (^ _Nullable)(NSError * _Nullable))onComplete;
		[Export ("updateGeoJSONSourceWithId:geojson:onComplete:")]
		void UpdateGeoJSONSourceWithId (string id, string geojson, [NullAllowed] Action<NSError> onComplete);
	}

	// @interface MapboxMapObjC_Swift_5256 (TMBStyle)
	[Category]
	[BaseType (typeof(TMBStyle))]
	interface TMBStyle_MapboxMapObjC_Swift_5256
	{
		// -(void)setProjection:(TMBStyleProjection * _Nonnull)projection completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("setProjection:completion:")]
		void SetProjection (TMBStyleProjection projection, [NullAllowed] Action<NSError> completion);

		// @property (readonly, nonatomic, strong) TMBStyleProjection * _Nonnull projection;
		[Export("projection", ArgumentSemantic.Strong)]
		TMBStyleProjection Projection();
	}

	// @interface TMBStyleProjection : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC18TMBStyleProjection")]
	[DisableDefaultCtor]
	interface TMBStyleProjection
	{
		// @property (nonatomic) enum TMBStyleProjectionName name;
		[Export ("name", ArgumentSemantic.Assign)]
		TMBStyleProjectionName Name { get; set; }

		// -(instancetype _Nonnull)initWithName:(enum TMBStyleProjectionName)name __attribute__((objc_designated_initializer));
		[Export ("initWithName:")]
		[DesignatedInitializer]
		IntPtr Constructor (TMBStyleProjectionName name);
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

	// @interface TMBSymbolLayer : NSObject <TMBLayer>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC14TMBSymbolLayer")]
	[DisableDefaultCtor]
	interface TMBSymbolLayer : TMBLayer
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; set; }

		// @property (readonly, nonatomic) enum TMBLayerType type;
		[Export ("type")]
		TMBLayerType Type { get; }

		// @property (nonatomic, strong) TMBExpression * _Nullable filter;
		[NullAllowed, Export ("filter", ArgumentSemantic.Strong)]
		TMBExpression Filter { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable source;
		[NullAllowed, Export ("source")]
		string Source { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sourceLayer;
		[NullAllowed, Export ("sourceLayer")]
		string SourceLayer { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minZoom;
		[NullAllowed, Export ("minZoom", ArgumentSemantic.Strong)]
		NSNumber MinZoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxZoom;
		[NullAllowed, Export ("maxZoom", ArgumentSemantic.Strong)]
		NSNumber MaxZoom { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable visibility;
		[NullAllowed, Export ("visibility", ArgumentSemantic.Strong)]
		TMBValue Visibility { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconAllowOverlap;
		[NullAllowed, Export ("iconAllowOverlap", ArgumentSemantic.Strong)]
		TMBValue IconAllowOverlap { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconAnchor;
		[NullAllowed, Export ("iconAnchor", ArgumentSemantic.Strong)]
		TMBValue IconAnchor { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconIgnorePlacement;
		[NullAllowed, Export ("iconIgnorePlacement", ArgumentSemantic.Strong)]
		TMBValue IconIgnorePlacement { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconImage;
		[NullAllowed, Export ("iconImage", ArgumentSemantic.Strong)]
		TMBValue IconImage { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconKeepUpright;
		[NullAllowed, Export ("iconKeepUpright", ArgumentSemantic.Strong)]
		TMBValue IconKeepUpright { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconOffset;
		[NullAllowed, Export ("iconOffset", ArgumentSemantic.Strong)]
		TMBValue IconOffset { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconOptional;
		[NullAllowed, Export ("iconOptional", ArgumentSemantic.Strong)]
		TMBValue IconOptional { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconPadding;
		[NullAllowed, Export ("iconPadding", ArgumentSemantic.Strong)]
		TMBValue IconPadding { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconPitchAlignment;
		[NullAllowed, Export ("iconPitchAlignment", ArgumentSemantic.Strong)]
		TMBValue IconPitchAlignment { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconRotate;
		[NullAllowed, Export ("iconRotate", ArgumentSemantic.Strong)]
		TMBValue IconRotate { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconRotationAlignment;
		[NullAllowed, Export ("iconRotationAlignment", ArgumentSemantic.Strong)]
		TMBValue IconRotationAlignment { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconSize;
		[NullAllowed, Export ("iconSize", ArgumentSemantic.Strong)]
		TMBValue IconSize { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconTextFit;
		[NullAllowed, Export ("iconTextFit", ArgumentSemantic.Strong)]
		TMBValue IconTextFit { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconTextFitPadding;
		[NullAllowed, Export ("iconTextFitPadding", ArgumentSemantic.Strong)]
		TMBValue IconTextFitPadding { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable symbolAvoidEdges;
		[NullAllowed, Export ("symbolAvoidEdges", ArgumentSemantic.Strong)]
		TMBValue SymbolAvoidEdges { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable symbolPlacement;
		[NullAllowed, Export ("symbolPlacement", ArgumentSemantic.Strong)]
		TMBValue SymbolPlacement { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable symbolSortKey;
		[NullAllowed, Export ("symbolSortKey", ArgumentSemantic.Strong)]
		TMBValue SymbolSortKey { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable symbolSpacing;
		[NullAllowed, Export ("symbolSpacing", ArgumentSemantic.Strong)]
		TMBValue SymbolSpacing { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable symbolZOrder;
		[NullAllowed, Export ("symbolZOrder", ArgumentSemantic.Strong)]
		TMBValue SymbolZOrder { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textAllowOverlap;
		[NullAllowed, Export ("textAllowOverlap", ArgumentSemantic.Strong)]
		TMBValue TextAllowOverlap { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textAnchor;
		[NullAllowed, Export ("textAnchor", ArgumentSemantic.Strong)]
		TMBValue TextAnchor { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textField;
		[NullAllowed, Export ("textField", ArgumentSemantic.Strong)]
		TMBValue TextField { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textFont;
		[NullAllowed, Export ("textFont", ArgumentSemantic.Strong)]
		TMBValue TextFont { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textIgnorePlacement;
		[NullAllowed, Export ("textIgnorePlacement", ArgumentSemantic.Strong)]
		TMBValue TextIgnorePlacement { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textJustify;
		[NullAllowed, Export ("textJustify", ArgumentSemantic.Strong)]
		TMBValue TextJustify { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textKeepUpright;
		[NullAllowed, Export ("textKeepUpright", ArgumentSemantic.Strong)]
		TMBValue TextKeepUpright { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textLetterSpacing;
		[NullAllowed, Export ("textLetterSpacing", ArgumentSemantic.Strong)]
		TMBValue TextLetterSpacing { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textLineHeight;
		[NullAllowed, Export ("textLineHeight", ArgumentSemantic.Strong)]
		TMBValue TextLineHeight { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textMaxAngle;
		[NullAllowed, Export ("textMaxAngle", ArgumentSemantic.Strong)]
		TMBValue TextMaxAngle { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textMaxWidth;
		[NullAllowed, Export ("textMaxWidth", ArgumentSemantic.Strong)]
		TMBValue TextMaxWidth { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textOffset;
		[NullAllowed, Export ("textOffset", ArgumentSemantic.Strong)]
		TMBValue TextOffset { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textOptional;
		[NullAllowed, Export ("textOptional", ArgumentSemantic.Strong)]
		TMBValue TextOptional { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textPadding;
		[NullAllowed, Export ("textPadding", ArgumentSemantic.Strong)]
		TMBValue TextPadding { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textPitchAlignment;
		[NullAllowed, Export ("textPitchAlignment", ArgumentSemantic.Strong)]
		TMBValue TextPitchAlignment { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textRadialOffset;
		[NullAllowed, Export ("textRadialOffset", ArgumentSemantic.Strong)]
		TMBValue TextRadialOffset { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textRotate;
		[NullAllowed, Export ("textRotate", ArgumentSemantic.Strong)]
		TMBValue TextRotate { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textRotationAlignment;
		[NullAllowed, Export ("textRotationAlignment", ArgumentSemantic.Strong)]
		TMBValue TextRotationAlignment { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textSize;
		[NullAllowed, Export ("textSize", ArgumentSemantic.Strong)]
		TMBValue TextSize { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textTransform;
		[NullAllowed, Export ("textTransform", ArgumentSemantic.Strong)]
		TMBValue TextTransform { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textVariableAnchor;
		[NullAllowed, Export ("textVariableAnchor", ArgumentSemantic.Strong)]
		TMBValue TextVariableAnchor { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textWritingMode;
		[NullAllowed, Export ("textWritingMode", ArgumentSemantic.Strong)]
		TMBValue TextWritingMode { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconColor;
		[NullAllowed, Export ("iconColor", ArgumentSemantic.Strong)]
		TMBValue IconColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable iconColorTransition;
		[NullAllowed, Export ("iconColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition IconColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconHaloBlur;
		[NullAllowed, Export ("iconHaloBlur", ArgumentSemantic.Strong)]
		TMBValue IconHaloBlur { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable iconHaloBlurTransition;
		[NullAllowed, Export ("iconHaloBlurTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition IconHaloBlurTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconHaloColor;
		[NullAllowed, Export ("iconHaloColor", ArgumentSemantic.Strong)]
		TMBValue IconHaloColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable iconHaloColorTransition;
		[NullAllowed, Export ("iconHaloColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition IconHaloColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconHaloWidth;
		[NullAllowed, Export ("iconHaloWidth", ArgumentSemantic.Strong)]
		TMBValue IconHaloWidth { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable iconHaloWidthTransition;
		[NullAllowed, Export ("iconHaloWidthTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition IconHaloWidthTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconOpacity;
		[NullAllowed, Export ("iconOpacity", ArgumentSemantic.Strong)]
		TMBValue IconOpacity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable iconOpacityTransition;
		[NullAllowed, Export ("iconOpacityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition IconOpacityTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconTranslate;
		[NullAllowed, Export ("iconTranslate", ArgumentSemantic.Strong)]
		TMBValue IconTranslate { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable iconTranslateTransition;
		[NullAllowed, Export ("iconTranslateTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition IconTranslateTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable iconTranslateAnchor;
		[NullAllowed, Export ("iconTranslateAnchor", ArgumentSemantic.Strong)]
		TMBValue IconTranslateAnchor { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
		TMBValue TextColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable textColorTransition;
		[NullAllowed, Export ("textColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition TextColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textHaloBlur;
		[NullAllowed, Export ("textHaloBlur", ArgumentSemantic.Strong)]
		TMBValue TextHaloBlur { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable textHaloBlurTransition;
		[NullAllowed, Export ("textHaloBlurTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition TextHaloBlurTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textHaloColor;
		[NullAllowed, Export ("textHaloColor", ArgumentSemantic.Strong)]
		TMBValue TextHaloColor { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable textHaloColorTransition;
		[NullAllowed, Export ("textHaloColorTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition TextHaloColorTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textHaloWidth;
		[NullAllowed, Export ("textHaloWidth", ArgumentSemantic.Strong)]
		TMBValue TextHaloWidth { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable textHaloWidthTransition;
		[NullAllowed, Export ("textHaloWidthTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition TextHaloWidthTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textOpacity;
		[NullAllowed, Export ("textOpacity", ArgumentSemantic.Strong)]
		TMBValue TextOpacity { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable textOpacityTransition;
		[NullAllowed, Export ("textOpacityTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition TextOpacityTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textTranslate;
		[NullAllowed, Export ("textTranslate", ArgumentSemantic.Strong)]
		TMBValue TextTranslate { get; set; }

		// @property (nonatomic, strong) TMBStyleTransition * _Nullable textTranslateTransition;
		[NullAllowed, Export ("textTranslateTransition", ArgumentSemantic.Strong)]
		TMBStyleTransition TextTranslateTransition { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable textTranslateAnchor;
		[NullAllowed, Export ("textTranslateAnchor", ArgumentSemantic.Strong)]
		TMBValue TextTranslateAnchor { get; set; }
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

		// @property (copy, nonatomic) NSString * _Nonnull source;
		[Export ("source")]
		string Source { get; set; }

		// @property (nonatomic, strong) TMBValue * _Nullable exaggeration;
		[NullAllowed, Export ("exaggeration", ArgumentSemantic.Strong)]
		TMBValue Exaggeration { get; set; }
	}

	// @interface TMBValue : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC8TMBValue")]
	[DisableDefaultCtor]
	interface TMBValue
	{
		// -(instancetype _Nonnull)initWithConstant:(id _Nullable)constant __attribute__((objc_designated_initializer));
		[Export ("initWithConstant:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] NSObject constant);

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

	// @interface MapboxMapObjC_Swift_5588 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5588
	{
		// +(TMBValue * _Nonnull)lineJoin:(enum TMBLineJoin)lineJoin __attribute__((warn_unused_result("")));
		[Static]
		[Export ("lineJoin:")]
		TMBValue LineJoin (TMBLineJoin lineJoin);
	}

	// @interface MapboxMapObjC_Swift_5593 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5593
	{
		// +(TMBValue * _Nonnull)textAnchor:(enum TMBTextAnchor)textAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("textAnchor:")]
		TMBValue TextAnchor (TMBTextAnchor textAnchor);
	}

	// @interface MapboxMapObjC_Swift_5598 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5598
	{
		// +(TMBValue * _Nonnull)visibility:(enum TMBVisibility)visibility __attribute__((warn_unused_result("")));
		[Static]
		[Export ("visibility:")]
		TMBValue Visibility (TMBVisibility visibility);
	}

	// @interface MapboxMapObjC_Swift_5603 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5603
	{
		// +(TMBValue * _Nonnull)textTranslateAnchor:(enum TMBTextTranslateAnchor)textTranslateAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("textTranslateAnchor:")]
		TMBValue TextTranslateAnchor (TMBTextTranslateAnchor textTranslateAnchor);
	}

	// @interface MapboxMapObjC_Swift_5608 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5608
	{
		// +(TMBValue * _Nonnull)textWritingMode:(enum TMBTextWritingMode)textWritingMode __attribute__((warn_unused_result("")));
		[Static]
		[Export ("textWritingMode:")]
		TMBValue TextWritingMode (TMBTextWritingMode textWritingMode);
	}

	// @interface MapboxMapObjC_Swift_5613 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5613
	{
		// +(TMBValue * _Nonnull)rasterResampling:(enum TMBRasterResampling)rasterResampling __attribute__((warn_unused_result("")));
		[Static]
		[Export ("rasterResampling:")]
		TMBValue RasterResampling (TMBRasterResampling rasterResampling);
	}

	// @interface MapboxMapObjC_Swift_5618 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5618
	{
		// +(TMBValue * _Nonnull)iconTranslateAnchor:(enum TMBIconTranslateAnchor)iconTranslateAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("iconTranslateAnchor:")]
		TMBValue IconTranslateAnchor (TMBIconTranslateAnchor iconTranslateAnchor);
	}

	// @interface MapboxMapObjC_Swift_5623 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5623
	{
		// +(TMBValue * _Nonnull)layerType:(enum TMBLayerType)layerType __attribute__((warn_unused_result("")));
		[Static]
		[Export ("layerType:")]
		TMBValue LayerType (TMBLayerType layerType);
	}

	// @interface MapboxMapObjC_Swift_5628 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5628
	{
		// +(TMBValue * _Nonnull)lineTranslateAnchor:(enum TMBLineTranslateAnchor)lineTranslateAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("lineTranslateAnchor:")]
		TMBValue LineTranslateAnchor (TMBLineTranslateAnchor lineTranslateAnchor);
	}

	// @interface MapboxMapObjC_Swift_5634 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5634
	{
		// +(TMBValue * _Nonnull)lineCap:(enum TMBLineCap)lineCap __attribute__((warn_unused_result("")));
		[Static]
		[Export ("lineCap:")]
		TMBValue LineCap (TMBLineCap lineCap);
	}

	// @interface MapboxMapObjC_Swift_5639 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5639
	{
		// +(TMBValue * _Nonnull)symbolZOrder:(enum TMBSymbolZOrder)symbolZOrder __attribute__((warn_unused_result("")));
		[Static]
		[Export ("symbolZOrder:")]
		TMBValue SymbolZOrder (TMBSymbolZOrder symbolZOrder);
	}

	// @interface MapboxMapObjC_Swift_5644 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5644
	{
		// +(TMBValue * _Nonnull)hillshadeIlluminationAnchor:(enum TMBHillshadeIlluminationAnchor)hillshadeIlluminationAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("hillshadeIlluminationAnchor:")]
		TMBValue HillshadeIlluminationAnchor (TMBHillshadeIlluminationAnchor hillshadeIlluminationAnchor);
	}

	// @interface MapboxMapObjC_Swift_5649 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5649
	{
		// +(TMBValue * _Nonnull)fillTranslateAnchor:(enum TMBFillTranslateAnchor)fillTranslateAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("fillTranslateAnchor:")]
		TMBValue FillTranslateAnchor (TMBFillTranslateAnchor fillTranslateAnchor);
	}

	// @interface MapboxMapObjC_Swift_5654 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5654
	{
		// +(TMBValue * _Nonnull)fillExtrusionTranslateAnchor:(enum TMBFillExtrusionTranslateAnchor)fillExtrusionTranslateAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("fillExtrusionTranslateAnchor:")]
		TMBValue FillExtrusionTranslateAnchor (TMBFillExtrusionTranslateAnchor fillExtrusionTranslateAnchor);
	}

	// @interface MapboxMapObjC_Swift_5659 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5659
	{
		// +(TMBValue * _Nonnull)iconRotationAlignment:(enum TMBIconRotationAlignment)iconRotationAlignment __attribute__((warn_unused_result("")));
		[Static]
		[Export ("iconRotationAlignment:")]
		TMBValue IconRotationAlignment (TMBIconRotationAlignment iconRotationAlignment);
	}

	// @interface MapboxMapObjC_Swift_5664 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5664
	{
		// +(TMBValue * _Nonnull)iconPitchAlignment:(enum TMBIconPitchAlignment)iconPitchAlignment __attribute__((warn_unused_result("")));
		[Static]
		[Export ("iconPitchAlignment:")]
		TMBValue IconPitchAlignment (TMBIconPitchAlignment iconPitchAlignment);
	}

	// @interface MapboxMapObjC_Swift_5669 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5669
	{
		// +(TMBValue * _Nonnull)sourceType:(enum TMBSourceType)sourceType __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sourceType:")]
		TMBValue SourceType (TMBSourceType sourceType);
	}

	// @interface MapboxMapObjC_Swift_5674 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5674
	{
		// +(TMBValue * _Nonnull)iconTextFit:(enum TMBIconTextFit)iconTextFit __attribute__((warn_unused_result("")));
		[Static]
		[Export ("iconTextFit:")]
		TMBValue IconTextFit (TMBIconTextFit iconTextFit);
	}

	// @interface MapboxMapObjC_Swift_5679 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5679
	{
		// +(TMBValue * _Nonnull)textTransform:(enum TMBTextTransform)textTransform __attribute__((warn_unused_result("")));
		[Static]
		[Export ("textTransform:")]
		TMBValue TextTransform (TMBTextTransform textTransform);
	}

	// @interface MapboxMapObjC_Swift_5684 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5684
	{
		// +(TMBValue * _Nonnull)circleTranslateAnchor:(enum TMBCircleTranslateAnchor)circleTranslateAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("circleTranslateAnchor:")]
		TMBValue CircleTranslateAnchor (TMBCircleTranslateAnchor circleTranslateAnchor);
	}

	// @interface MapboxMapObjC_Swift_5689 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5689
	{
		// +(TMBValue * _Nonnull)scheme:(enum TMBScheme)scheme __attribute__((warn_unused_result("")));
		[Static]
		[Export ("scheme:")]
		TMBValue Scheme (TMBScheme scheme);
	}

	// @interface MapboxMapObjC_Swift_5694 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5694
	{
		// +(TMBValue * _Nonnull)textRotationAlignment:(enum TMBTextRotationAlignment)textRotationAlignment __attribute__((warn_unused_result("")));
		[Static]
		[Export ("textRotationAlignment:")]
		TMBValue TextRotationAlignment (TMBTextRotationAlignment textRotationAlignment);
	}

	// @interface MapboxMapObjC_Swift_5699 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5699
	{
		// +(TMBValue * _Nonnull)symbolPlacement:(enum TMBSymbolPlacement)symbolPlacement __attribute__((warn_unused_result("")));
		[Static]
		[Export ("symbolPlacement:")]
		TMBValue SymbolPlacement (TMBSymbolPlacement symbolPlacement);
	}

	// @interface MapboxMapObjC_Swift_5704 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5704
	{
		// +(TMBValue * _Nonnull)skyType:(enum TMBSkyType)skyType __attribute__((warn_unused_result("")));
		[Static]
		[Export ("skyType:")]
		TMBValue SkyType (TMBSkyType skyType);
	}

	// @interface MapboxMapObjC_Swift_5709 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5709
	{
		// +(TMBValue * _Nonnull)circlePitchAlignment:(enum TMBCirclePitchAlignment)circlePitchAlignment __attribute__((warn_unused_result("")));
		[Static]
		[Export ("circlePitchAlignment:")]
		TMBValue CirclePitchAlignment (TMBCirclePitchAlignment circlePitchAlignment);
	}

	// @interface MapboxMapObjC_Swift_5714 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5714
	{
		// +(TMBValue * _Nonnull)textPitchAlignment:(enum TMBTextPitchAlignment)textPitchAlignment __attribute__((warn_unused_result("")));
		[Static]
		[Export ("textPitchAlignment:")]
		TMBValue TextPitchAlignment (TMBTextPitchAlignment textPitchAlignment);
	}

	// @interface MapboxMapObjC_Swift_5719 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5719
	{
		// +(TMBValue * _Nonnull)iconAnchor:(enum TMBIconAnchor)iconAnchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("iconAnchor:")]
		TMBValue IconAnchor (TMBIconAnchor iconAnchor);
	}

	// @interface MapboxMapObjC_Swift_5724 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5724
	{
		// +(TMBValue * _Nonnull)encoding:(enum TMBEncoding)encoding __attribute__((warn_unused_result("")));
		[Static]
		[Export ("encoding:")]
		TMBValue Encoding (TMBEncoding encoding);
	}

	// @interface MapboxMapObjC_Swift_5729 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5729
	{
		// +(TMBValue * _Nonnull)anchor:(enum TMBAnchor)anchor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("anchor:")]
		TMBValue Anchor (TMBAnchor anchor);
	}

	// @interface MapboxMapObjC_Swift_5734 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5734
	{
		// +(TMBValue * _Nonnull)circlePitchScale:(enum TMBCirclePitchScale)circlePitchScale __attribute__((warn_unused_result("")));
		[Static]
		[Export ("circlePitchScale:")]
		TMBValue CirclePitchScale (TMBCirclePitchScale circlePitchScale);
	}

	// @interface MapboxMapObjC_Swift_5739 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5739
	{
		// +(TMBValue * _Nonnull)expressionOperator:(enum TMBExpressionOperator)expressionOperator __attribute__((warn_unused_result("")));
		[Static]
		[Export ("expressionOperator:")]
		TMBValue ExpressionOperator (TMBExpressionOperator expressionOperator);
	}

	// @interface MapboxMapObjC_Swift_5744 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5744
	{
		// +(TMBValue * _Nonnull)textJustify:(enum TMBTextJustify)textJustify __attribute__((warn_unused_result("")));
		[Static]
		[Export ("textJustify:")]
		TMBValue TextJustify (TMBTextJustify textJustify);
	}

	// @interface MapboxMapObjC_Swift_5749 (TMBValue)
	[Category]
	[BaseType (typeof(TMBValue))]
	interface TMBValue_MapboxMapObjC_Swift_5749
	{
		// +(TMBValue * _Nonnull)styleProjectionName:(enum TMBStyleProjectionName)styleProjectionName __attribute__((warn_unused_result("")));
		[Static]
		[Export ("styleProjectionName:")]
		TMBValue StyleProjectionName (TMBStyleProjectionName styleProjectionName);
	}

	// @interface TMBVectorSource : NSObject <TMBSource>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC15TMBVectorSource")]
	[DisableDefaultCtor]
	interface TMBVectorSource : TMBSource
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id;
		[Export ("initWithId:")]
		IntPtr Constructor (string id);

		// @property (readonly, nonatomic) enum TMBSourceType type;
		[Export ("type")]
		TMBSourceType Type { get; }

		// @property (copy, nonatomic) NSString * _Nullable url;
		[NullAllowed, Export ("url")]
		string Url { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable tiles;
		[NullAllowed, Export ("tiles", ArgumentSemantic.Copy)]
		string[] Tiles { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable bounds;
		[NullAllowed, Export ("bounds", ArgumentSemantic.Copy)]
		NSNumber[] Bounds { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable scheme;
		[NullAllowed, Export ("scheme", ArgumentSemantic.Strong)]
		NSNumber Scheme { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minzoom;
		[NullAllowed, Export ("minzoom", ArgumentSemantic.Strong)]
		NSNumber Minzoom { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxzoom;
		[NullAllowed, Export ("maxzoom", ArgumentSemantic.Strong)]
		NSNumber Maxzoom { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable attribution;
		[NullAllowed, Export ("attribution")]
		string Attribution { get; set; }

		// @property (nonatomic, strong) TMBPromoteId * _Nullable promoteId;
		[NullAllowed, Export ("promoteId", ArgumentSemantic.Strong)]
		TMBPromoteId PromoteId { get; set; }

		// @property (getter = volatile, nonatomic, setter = setVolatile:, strong) NSNumber * _Nullable volatile_;
		[NullAllowed, Export ("volatile_", ArgumentSemantic.Strong)]
		NSNumber Volatile_ { [Bind ("volatile")] get; [Bind ("setVolatile:")] set; }

		// @property (nonatomic, strong) NSNumber * _Nullable prefetchZoomDelta;
		[NullAllowed, Export ("prefetchZoomDelta", ArgumentSemantic.Strong)]
		NSNumber PrefetchZoomDelta { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable minimumTileUpdateInterval;
		[NullAllowed, Export ("minimumTileUpdateInterval", ArgumentSemantic.Strong)]
		NSNumber MinimumTileUpdateInterval { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxOverscaleFactorForParentTiles;
		[NullAllowed, Export ("maxOverscaleFactorForParentTiles", ArgumentSemantic.Strong)]
		NSNumber MaxOverscaleFactorForParentTiles { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable tileRequestsDelay;
		[NullAllowed, Export ("tileRequestsDelay", ArgumentSemantic.Strong)]
		NSNumber TileRequestsDelay { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable tileNetworkRequestsDelay;
		[NullAllowed, Export ("tileNetworkRequestsDelay", ArgumentSemantic.Strong)]
		NSNumber TileNetworkRequestsDelay { get; set; }
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
		void AddViewAnnotationUpdateObserver (ITMBViewAnnotationUpdateObserver observer);

		// -(void)removeViewAnnotationUpdateObserver:(id<TMBViewAnnotationUpdateObserver> _Nonnull)observer;
		[Export ("removeViewAnnotationUpdateObserver:")]
		void RemoveViewAnnotationUpdateObserver (ITMBViewAnnotationUpdateObserver observer);

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
	[Protocol (Name = "_TtP13MapboxMapObjC31TMBViewAnnotationUpdateObserver_"), Model]
	[BaseType (typeof (NSObject))]
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
		void AddStatusObserver (ITMBViewportStatusObserver observer);

		// -(void)removeStatusObserver:(id<TMBViewportStatusObserver> _Nonnull)observer;
		[Export ("removeStatusObserver:")]
		void RemoveStatusObserver (ITMBViewportStatusObserver observer);

		// -(void)idle;
		[Export ("idle")]
		void Idle ();

		// -(void)transitionTo:(id<TMBViewportState> _Nonnull)toState transition:(id<TMBViewportTransition> _Nullable)transition completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("transitionTo:transition:completion:")]
		void TransitionTo (ITMBViewportState toState, [NullAllowed] ITMBViewportTransition transition, [NullAllowed] Action<bool> completion);

		// @property (nonatomic, strong) id<TMBViewportTransition> _Nonnull defaultTransition;
		[Export ("defaultTransition", ArgumentSemantic.Strong)]
		ITMBViewportTransition DefaultTransition { get; set; }

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
		[Export("makeImmediateViewportTransition")]
		TMBImmediateViewportTransition MakeImmediateViewportTransition();
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
		TMBViewportStatus State (ITMBViewportState state);

		// +(TMBViewportStatus * _Nonnull)transition:(id<TMBViewportTransition> _Nonnull)transition toState:(id<TMBViewportState> _Nonnull)toState __attribute__((warn_unused_result("")));
		[Static]
		[Export ("transition:toState:")]
		TMBViewportStatus Transition (ITMBViewportTransition transition, TMBViewportState toState);
	}

	// @interface TMBViewportStatusChangeReason : NSObject <NamedString>
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC29TMBViewportStatusChangeReason")]
	[DisableDefaultCtor]
	interface TMBViewportStatusChangeReason : NamedString
	{
		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result("")));
		[Export ("stringValue")]
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
	partial interface ITMBViewportStatusObserver {}

	[Protocol (Name = "_TtP13MapboxMapObjC25TMBViewportStatusObserver_"), Model]
	[BaseType(typeof(NSObject))]
	interface TMBViewportStatusObserver
	{
		// @required -(void)viewportStatusDidChangeFrom:(TMBViewportStatus * _Nonnull)fromStatus to:(TMBViewportStatus * _Nonnull)toStatus reason:(TMBViewportStatusChangeReason * _Nonnull)reason;
		[Abstract]
		[Export ("viewportStatusDidChangeFrom:to:reason:")]
		void To (TMBViewportStatus fromStatus, TMBViewportStatus toStatus, TMBViewportStatusChangeReason reason);
	}

	// @interface MapboxMapObjC_Swift_6088
    [Category]
    [BaseType(typeof(MBXTileStore))]
	interface MapboxMapObjC_Swift_6088
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
