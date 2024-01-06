using System;
using CoreGraphics;
using CoreLocation;
using Foundation;
using MapboxMaps;
using MapboxCommon;
using MapboxCoreMaps;
using Metal;
using ObjCRuntime;
using UIKit;

namespace MapboxMaps
{
    // @interface AnnotationOrchestratorImpl : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10MapboxMaps26AnnotationOrchestratorImpl")]
    [DisableDefaultCtor]
    interface AnnotationOrchestratorImpl
    {
    }

    // @interface GestureHandler : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10MapboxMaps14GestureHandler")]
    [DisableDefaultCtor]
    interface GestureHandler
    {
    }

    // @interface AnyTouchGestureHandler : GestureHandler
    [BaseType(typeof(GestureHandler), Name = "_TtC10MapboxMaps22AnyTouchGestureHandler")]
    interface AnyTouchGestureHandler
    {
    }

    // @interface MapboxMaps_Swift_280 (AnyTouchGestureHandler) <UIGestureRecognizerDelegate>
    [Category]
    [BaseType(typeof(AnyTouchGestureHandler))]
    interface AnyTouchGestureHandler_MapboxMaps_Swift_280
    {
        // -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer __attribute__((warn_unused_result("")));
        [Export("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
        bool GestureRecognizer(UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);
    }

    // @interface AttributionView : UIView
    [BaseType(typeof(UIView), Name = "_TtC10MapboxMaps15AttributionView")]
    interface AttributionView
    {
        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);
    }

    // @interface CLLocationManagerDelegateProxy : NSObject <CLLocationManagerDelegate>
    [BaseType(typeof(NSObject), Name = "_TtC10MapboxMaps30CLLocationManagerDelegateProxy")]
    interface CLLocationManagerDelegateProxy : ICLLocationManagerDelegate
    {
        // -(void)locationManager:(CLLocationManager * _Nonnull)manager didUpdateLocations:(NSArray<CLLocation *> * _Nonnull)locations;
        [Export("locationManager:didUpdateLocations:")]
        void LocationManager(CLLocationManager manager, CLLocation[] locations);

        // -(void)locationManager:(CLLocationManager * _Nonnull)manager didUpdateHeading:(CLHeading * _Nonnull)newHeading;
        [Export("locationManager:didUpdateHeading:")]
        void LocationManager(CLLocationManager manager, CLHeading newHeading);

        // -(void)locationManager:(CLLocationManager * _Nonnull)manager didFailWithError:(NSError * _Nonnull)error;
        [Export("locationManager:didFailWithError:")]
        void LocationManager(CLLocationManager manager, NSError error);

        // -(void)locationManagerDidChangeAuthorization:(CLLocationManager * _Nonnull)manager;
        [Export("locationManagerDidChangeAuthorization:")]
        void LocationManagerDidChangeAuthorization(CLLocationManager manager);

        // -(BOOL)locationManagerShouldDisplayHeadingCalibration:(CLLocationManager * _Nonnull)manager __attribute__((warn_unused_result("")));
        [Export("locationManagerShouldDisplayHeadingCalibration:")]
        bool LocationManagerShouldDisplayHeadingCalibration(CLLocationManager manager);
    }

    // @interface CameraDebugView : UIView
    [BaseType(typeof(UIView), Name = "_TtC10MapboxMaps15CameraDebugView")]
    interface CameraDebugView
    {
        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);
    }

    // @interface CameraView : UIView
    [BaseType(typeof(UIView), Name = "_TtC10MapboxMaps10CameraView")]
    interface CameraView
    {
        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);
    }

    // @interface DistanceFormatter : NSMeasurementFormatter
    [BaseType(typeof(NSMeasurementFormatter), Name = "_TtC10MapboxMaps17DistanceFormatter")]
    interface DistanceFormatter
    {
        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);
    }

    // @interface DoubleTapToZoomInGestureHandler : GestureHandler
    [BaseType(typeof(GestureHandler), Name = "_TtC10MapboxMaps31DoubleTapToZoomInGestureHandler")]
    interface DoubleTapToZoomInGestureHandler
    {
    }

    // @interface DoubleTouchToZoomOutGestureHandler : GestureHandler
    [BaseType(typeof(GestureHandler), Name = "_TtC10MapboxMaps34DoubleTouchToZoomOutGestureHandler")]
    interface DoubleTouchToZoomOutGestureHandler
    {
    }

    // @interface EmptyCustomRenderer : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10MapboxMaps19EmptyCustomRenderer")]
    [DisableDefaultCtor]
    interface EmptyCustomRenderer
    {
        // -(void)renderingWillStart:(id<MTLDevice> _Nonnull)metalDevice colorPixelFormat:(NSUInteger)colorPixelFormat depthStencilPixelFormat:(NSUInteger)depthStencilPixelFormat;
        [Export("renderingWillStart:colorPixelFormat:depthStencilPixelFormat:")]
        void RenderingWillStart(IMTLDevice metalDevice, nuint colorPixelFormat, nuint depthStencilPixelFormat);

        // -(void)render:(MBMCustomLayerRenderParameters * _Nonnull)parameters mtlCommandBuffer:(id<MTLCommandBuffer> _Nonnull)mtlCommandBuffer mtlRenderPassDescriptor:(MTLRenderPassDescriptor * _Nonnull)mtlRenderPassDescriptor;
        [Export("render:mtlCommandBuffer:mtlRenderPassDescriptor:")]
        void Render(MBMCustomLayerRenderParameters parameters, IMTLCommandBuffer mtlCommandBuffer, MTLRenderPassDescriptor mtlRenderPassDescriptor);

        // -(void)renderingWillEnd;
        [Export("renderingWillEnd")]
        void RenderingWillEnd();
    }

    //// @interface MapboxMaps_Swift_379
    //interface MapboxMaps_Swift_379
    //{
    //	// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
    //	[Export ("isEqual:")]
    //	bool IsEqual ([NullAllowed] NSObject @object);

    //	// @property (readonly, nonatomic) NSUInteger hash;
    //	[Export ("hash")]
    //	nuint Hash { }
    //}

    // @interface InfoButtonOrnament : UIView
    [BaseType(typeof(UIView), Name = "_TtC10MapboxMaps18InfoButtonOrnament")]
    interface InfoButtonOrnament
    {
        // @property (getter = isHidden, nonatomic) BOOL hidden;
        [Export("hidden")]
        bool Hidden { [Bind("isHidden")] get; set; }

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);

        // -(void)infoTapped;
        [Export("infoTapped")]
        void InfoTapped();
    }

    // @interface InterruptDecelerationGestureHandler : GestureHandler
    [BaseType(typeof(GestureHandler), Name = "_TtC10MapboxMaps35InterruptDecelerationGestureHandler")]
    interface InterruptDecelerationGestureHandler
    {
    }

    // @interface MapboxMaps_Swift_401 (InterruptDecelerationGestureHandler) <UIGestureRecognizerDelegate>
    [Category]
    [BaseType(typeof(InterruptDecelerationGestureHandler))]
    interface InterruptDecelerationGestureHandler_MapboxMaps_Swift_401// : IUIGestureRecognizerDelegate
    {
        // -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer __attribute__((warn_unused_result("")));
        [Export("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
        bool GestureRecognizer(UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);
    }

    // @interface LogoView : UIView
    [BaseType(typeof(UIView), Name = "_TtC10MapboxMaps8LogoView")]
    interface LogoView
    {
        // @property (getter = isHidden, nonatomic) BOOL hidden;
        [Export("hidden")]
        bool Hidden { [Bind("isHidden")] get; set; }

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(void)drawRect:(CGRect)rect;
        [Export("drawRect:")]
        void DrawRect(CGRect rect);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);
    }

    // @interface LongPressGestureHandler : NSObject <UIGestureRecognizerDelegate>
    [BaseType(typeof(NSObject), Name = "_TtC10MapboxMaps23LongPressGestureHandler")]
    interface LongPressGestureHandler : IUIGestureRecognizerDelegate
    {
        // -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer __attribute__((warn_unused_result("")));
        [Export("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
        bool GestureRecognizer(UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);
    }

    // @interface MapInitOptions : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10MapboxMaps14MapInitOptions")]
    [DisableDefaultCtor]
    interface MapInitOptions
    {
        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }
    }

    // @protocol MapInitOptionsProvider
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Model, Protocol(Name = "_TtP10MapboxMaps22MapInitOptionsProvider_")]
    [BaseType(typeof(NSObject))]
    interface MapInitOptionsProvider
    {
        // @required -(MapInitOptions * _Nonnull)mapInitOptions __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("mapInitOptions")]
        MapInitOptions MapInitOptions { get; }
    }

    //// @interface MapboxMaps_Swift_452
    //interface MapboxMaps_Swift_452
    //{
    //	// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
    //	[Export ("isEqual:")]
    //	bool IsEqual ([NullAllowed] NSObject @object);

    //	// @property (readonly, nonatomic) NSUInteger hash;
    //	[Export ("hash")]
    //	nuint Hash { }
    //}

    // @interface MapView : UIView
    [BaseType(typeof(UIView), Name = "_TtC10MapboxMaps7MapView")]
    interface MapView
    {
        // @property (getter = isOpaque, nonatomic) BOOL opaque;
        [Export("opaque")]
        bool Opaque { [Bind("isOpaque")] get; set; }

        // @property (readonly, nonatomic, weak) id<MapInitOptionsProvider> _Nullable mapInitOptionsProvider __attribute__((iboutlet));
        [NullAllowed, Export("mapInitOptionsProvider", ArgumentSemantic.Weak)]
        MapInitOptionsProvider MapInitOptionsProvider { get; }

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer)) __attribute__((availability(ios_app_extension, unavailable)));
        ////[Unavailable (PlatformName.iOSAppExtension)]
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);

        // -(void)awakeFromNib __attribute__((objc_requires_super));
        [Export("awakeFromNib")]
        [RequiresSuper]
        void AwakeFromNib();

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(void)didMoveToWindow;
        [Export("didMoveToWindow")]
        void DidMoveToWindow();
    }

    // @interface MapboxCompassOrnamentView : UIButton
    [BaseType(typeof(UIButton), Name = "_TtC10MapboxMaps25MapboxCompassOrnamentView")]
    interface MapboxCompassOrnamentView
    {
        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);
    }

    // @interface MapboxScaleBarLabel : UILabel
    [BaseType(typeof(UILabel), Name = "_TtC10MapboxMaps19MapboxScaleBarLabel")]
    interface MapboxScaleBarLabel
    {
        // -(void)drawTextInRect:(CGRect)rect;
        [Export("drawTextInRect:")]
        void DrawTextInRect(CGRect rect);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);
    }

    // @interface MapboxScaleBarOrnamentView : UIView
    [BaseType(typeof(UIView), Name = "_TtC10MapboxMaps26MapboxScaleBarOrnamentView")]
    interface MapboxScaleBarOrnamentView
    {
        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);

        // -(void)didMoveToSuperview;
        [Export("didMoveToSuperview")]
        void DidMoveToSuperview();

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();
    }

    // @interface PaddingDebugView : UIView
    [BaseType(typeof(UIView), Name = "_TtC10MapboxMaps16PaddingDebugView")]
    interface PaddingDebugView
    {
        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();
    }

    // @interface PanGestureHandler : GestureHandler
    [BaseType(typeof(GestureHandler), Name = "_TtC10MapboxMaps17PanGestureHandler")]
    interface PanGestureHandler
    {
    }

    // @interface MapboxMaps_Swift_531 (PanGestureHandler) <UIGestureRecognizerDelegate>
    [Category]
    [BaseType(typeof(PanGestureHandler))]
    interface PanGestureHandler_MapboxMaps_Swift_531
    {
        // -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer __attribute__((warn_unused_result("")));
        [Export("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
        bool GestureRecognizer(UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);
    }

    // @interface PinchGestureHandler : GestureHandler
    [BaseType(typeof(GestureHandler), Name = "_TtC10MapboxMaps19PinchGestureHandler")]
    interface PinchGestureHandler
    {
    }

    // @interface MapboxMaps_Swift_543 (PinchGestureHandler) <UIGestureRecognizerDelegate>
    [Category]
    [BaseType(typeof(PinchGestureHandler))]
    interface PinchGestureHandler_MapboxMaps_Swift_543 //: IUIGestureRecognizerDelegate
    {
        // -(BOOL)gestureRecognizerShouldBegin:(UIGestureRecognizer * _Nonnull)gestureRecognizer __attribute__((warn_unused_result("")));
        [Export("gestureRecognizerShouldBegin:")]
        bool GestureRecognizerShouldBegin(UIGestureRecognizer gestureRecognizer);

        // -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer __attribute__((warn_unused_result("")));
        [Export("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
        bool GestureRecognizer(UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);
    }

    // @interface PitchGestureHandler : GestureHandler <UIGestureRecognizerDelegate>
    [BaseType(typeof(GestureHandler), Name = "_TtC10MapboxMaps19PitchGestureHandler")]
    interface PitchGestureHandler : IUIGestureRecognizerDelegate
    {
        // -(BOOL)gestureRecognizerShouldBegin:(UIGestureRecognizer * _Nonnull)gestureRecognizer __attribute__((warn_unused_result("")));
        [Export("gestureRecognizerShouldBegin:")]
        bool GestureRecognizerShouldBegin(UIGestureRecognizer gestureRecognizer);
    }

    // @interface QuickZoomGestureHandler : GestureHandler
    [BaseType(typeof(GestureHandler), Name = "_TtC10MapboxMaps23QuickZoomGestureHandler")]
    interface QuickZoomGestureHandler
    {
    }

    // @interface RotateGestureHandler : GestureHandler
    [BaseType(typeof(GestureHandler), Name = "_TtC10MapboxMaps20RotateGestureHandler")]
    interface RotateGestureHandler
    {
    }

    // @interface MapboxMaps_Swift_574 (RotateGestureHandler) <UIGestureRecognizerDelegate>
    [Category]
    [BaseType(typeof(RotateGestureHandler))]
    interface RotateGestureHandler_MapboxMaps_Swift_574 //: IUIGestureRecognizerDelegate
    {
        // -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer __attribute__((warn_unused_result("")));
        [Export("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
        bool GestureRecognizer(UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);
    }

    // @interface SingleTapGestureHandler : GestureHandler
    [BaseType(typeof(GestureHandler), Name = "_TtC10MapboxMaps23SingleTapGestureHandler")]
    interface SingleTapGestureHandler
    {
    }

    // @interface MapboxMaps_Swift_587 (SingleTapGestureHandler) <UIGestureRecognizerDelegate>
    [Category]
    [BaseType(typeof(SingleTapGestureHandler))]
    interface SingleTapGestureHandler_MapboxMaps_Swift_587 //: IUIGestureRecognizerDelegate
    {
        // -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer __attribute__((warn_unused_result("")));
        [Export("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
        bool GestureRecognizer(UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);
    }

    // @interface TouchBeganGestureRecognizer : UIGestureRecognizer
    [BaseType(typeof(UIGestureRecognizer), Name = "_TtC10MapboxMaps27TouchBeganGestureRecognizer")]
    interface TouchBeganGestureRecognizer
    {
        // -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
        [Export("touchesBegan:withEvent:")]
        void TouchesBegan(NSSet<UITouch> touches, UIEvent @event);

        // -(instancetype _Nonnull)initWithTarget:(id _Nullable)target action:(SEL _Nullable)action __attribute__((objc_designated_initializer));
        [Export("initWithTarget:action:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] NSObject target, [NullAllowed] Selector action);
    }

    // @interface MapboxMaps_Swift_630 (NSUserDefaults)
    [Category]
    [BaseType(typeof(NSUserDefaults))]
    interface NSUserDefaults_MapboxMaps_Swift_630
    {
        // @property (nonatomic) BOOL MGLMapboxMetricsEnabled;
        [Export("get_MGLMapboxMetricsEnabled")]
        bool MGLMapboxMetricsEnabled();

        [Export("set_MGLMapboxMetricsEnabled:")]
        void SetMGLMapboxMetricsEnabled(bool value);
    }

    // @interface ViewAnnotationsContainer : UIView
    [BaseType(typeof(UIView), Name = "_TtC10MapboxMaps24ViewAnnotationsContainer")]
    interface ViewAnnotationsContainer
    {
        // -(UIView * _Nullable)hitTest:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result("")));
        [Export("hitTest:withEvent:")]
        [return: NullAllowed]
        UIView HitTest(CGPoint point, [NullAllowed] UIEvent @event);

        // -(void)didAddSubview:(UIView * _Nonnull)subview;
        [Export("didAddSubview:")]
        void DidAddSubview(UIView subview);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);
    }
}
