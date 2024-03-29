﻿using System;
using CoreLocation;
using Foundation;
using MapboxMaps;
using ObjCRuntime;
using UIKit;

namespace MapboxMaps
{
	// @interface AppleLocationProvider : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10MapboxMaps21AppleLocationProvider")]
	interface AppleLocationProvider : ICLLocationManagerDelegate
	{
		// -(void)locationManager:(CLLocationManager * _Nonnull)manager didUpdateLocations:(NSArray<CLLocation *> * _Nonnull)locations;
		[Export ("locationManager:didUpdateLocations:")]
		void LocationManager (CLLocationManager manager, CLLocation[] locations);

		// -(void)locationManager:(CLLocationManager * _Nonnull)manager didUpdateHeading:(CLHeading * _Nonnull)heading;
		[Export ("locationManager:didUpdateHeading:")]
		void LocationManager (CLLocationManager manager, CLHeading heading);

		// -(void)locationManager:(CLLocationManager * _Nonnull)manager didFailWithError:(NSError * _Nonnull)error;
		[Export ("locationManager:didFailWithError:")]
		void LocationManager (CLLocationManager manager, NSError error);

		// -(void)locationManagerDidChangeAuthorization:(CLLocationManager * _Nonnull)manager __attribute__((availability(ios, introduced=14.0)));
		// [iOS (14,0)]
		[Export ("locationManagerDidChangeAuthorization:")]
		void LocationManagerDidChangeAuthorization (CLLocationManager manager);

		// - (BOOL)locationManagerShouldDisplayHeadingCalibration:(CLLocationManager * _Nonnull)manager SWIFT_WARN_UNUSED_RESULT;
		[Export ("locationManagerShouldDisplayHeadingCalibration:")]
		bool LocationManagerShouldDisplayHeadingCalibration (CLLocationManager manager);
	}

	// @interface BasicCameraAnimator : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10MapboxMaps19BasicCameraAnimator")]
	[DisableDefaultCtor]
	interface BasicCameraAnimator
	{
	}

	// @interface FlyToCameraAnimator : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10MapboxMaps19FlyToCameraAnimator")]
	[DisableDefaultCtor]
	interface FlyToCameraAnimator
	{
	}

	// @interface Location : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10MapboxMaps8Location")]
	[DisableDefaultCtor]
	interface Location
	{
	}

	// @protocol LocationConsumer
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol (Name = "_TtP10MapboxMaps16LocationConsumer_"), Model]
	[BaseType (typeof(NSObject))]
	interface LocationConsumer
	{
		// @required -(void)locationUpdateWithNewLocation:(Location * _Nonnull)newLocation;
		[Abstract]
		[Export ("locationUpdateWithNewLocation:")]
		void LocationUpdateWithNewLocation (Location newLocation);
	}

	// @interface LocationManager : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10MapboxMaps15LocationManager")]
	[DisableDefaultCtor]
	interface LocationManager
	{
	}

	// @protocol LocationPermissionsDelegate
	[Protocol (Name = "_TtP10MapboxMaps27LocationPermissionsDelegate_"), Model]
	interface LocationPermissionsDelegate
	{
		// @optional -(void)locationManager:(LocationManager * _Nonnull)locationManager didFailToLocateUserWithError:(NSError * _Nonnull)error;
		[Export ("locationManager:didFailToLocateUserWithError:")]
		void DidFailToLocateUserWithError (LocationManager locationManager, NSError error);

		// @optional -(void)locationManager:(LocationManager * _Nonnull)locationManager didChangeAccuracyAuthorization:(CLAccuracyAuthorization)accuracyAuthorization;
		[Export ("locationManager:didChangeAccuracyAuthorization:")]
		void DidChangeAccuracyAuthorization (LocationManager locationManager, CLAccuracyAuthorization accuracyAuthorization);

		// - (BOOL)locationManagerShouldDisplayHeadingCalibration:(LocationManager * _Nonnull)locationManager SWIFT_WARN_UNUSED_RESULT;
		[Export ("locationManagerShouldDisplayHeadingCalibration:didChangeAccuracyAuthorization:")]
		bool LocationManagerShouldDisplayHeadingCalibration (LocationManager locationManager);
	}

	// @interface MapInitOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10MapboxMaps14MapInitOptions")]
	[DisableDefaultCtor]
	interface MapInitOptions
	{
		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
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
	partial interface IMapInitOptionsProvider { }

	[Protocol (Name = "_TtP10MapboxMaps22MapInitOptionsProvider_"), Model]
	[BaseType(typeof(NSObject))]
	interface MapInitOptionsProvider
	{
		// @required -(MapInitOptions * _Nonnull)mapInitOptions __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("mapInitOptions")]
		MapInitOptions MapInitOptions { get; }
	}

	// @interface MapView : UIView
	[BaseType (typeof(UIView), Name = "_TtC10MapboxMaps7MapView")]
	interface MapView
	{
		// -(void)awakeFromNib __attribute__((objc_requires_super));
		[Export ("awakeFromNib")]
		[RequiresSuper]
		void AwakeFromNib ();

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();
	}

	// @interface OrnamentsManager : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10MapboxMaps16OrnamentsManager")]
	[DisableDefaultCtor]
	interface OrnamentsManager
	{
	}

	// SWIFT_PROTOCOL("_TtP10MapboxMaps20PuckLocationConsumer_")
	// @protocol PuckLocationConsumer
	[Protocol (Name = "_TtP10MapboxMaps20PuckLocationConsumer_"), Model]
	[BaseType(typeof(NSObject))]
	interface PuckLocationConsumer
	{
		// /// To be invoked when a new puck’s location is received.
		// - (void)puckLocationUpdateWithNewLocation:(Location * _Nonnull)newLocation;
		[Export ("puckLocationUpdateWithNewLocation:")]
		void PuckLocationUpdateWithNewLocation (Location newLocation);
	}
}
