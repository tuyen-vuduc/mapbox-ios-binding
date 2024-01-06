// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@protocol MBXHttpServiceInterceptorInterface;
@protocol MBXHttpServiceInterface;

/**
 * HTTP service factory.
 *
 * This class is used to get a pointer/reference to HTTP service platform implementation.
 */
NS_SWIFT_NAME(HttpServiceFactory)
__attribute__((visibility ("default")))
@interface MBXHttpServiceFactory : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

/**
 * Sets an interceptor for the current HTTP service instance.
 *
 * @param interceptor The interceptor to be set.
 */
+ (void)setHttpServiceInterceptorForInterceptor:(nullable id<MBXHttpServiceInterceptorInterface>)interceptor;

@end
