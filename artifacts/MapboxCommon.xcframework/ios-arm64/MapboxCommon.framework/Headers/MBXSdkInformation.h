// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/**
 * Provides information about a given Mapbox SDK. This information is then used to populate the "User-Agent" HTTP header
 * of HTTP requests generated from within Mapbox SDKs. Mapbox SDKs include Maps, Navigation, Search, and others.
 */
NS_SWIFT_NAME(SdkInformation)
__attribute__((visibility ("default")))
@interface MBXSdkInformation : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;



- (BOOL)isEqualToSdkInformation:(nonnull MBXSdkInformation *)other;

@end
