#pragma once

#import <CoreLocation/CoreLocation.h>

/**
 * Boxed version of CLLocationCoordinate2D
 */
NS_SWIFT_NAME(Coordinate2D)
__attribute__((visibility ("default")))
@interface MBXCoordinate2D : NSObject
@property(nonatomic, readonly, assign) CLLocationCoordinate2D value;

- (nonnull instancetype)initWithValue:(CLLocationCoordinate2D)value;

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;
@end
