// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

NS_SWIFT_NAME(HttpRequestFlags)
__attribute__((visibility ("default")))
@interface MBXHttpRequestFlags : NSObject

    @property (nonatomic, class, readonly) uint32_t None;
    /** Keep compression flag. If set, responses will not be automatically decompressed. */
    @property (nonatomic, class, readonly) uint32_t KeepCompression;
    /**
     * Supported for Android only.
     * If set and application also has "com.mapbox.common.http.pause_requests_on_demand" setting in manifest
     * the request will be performed in the foreground only. In case application is in the background request will
     * be queued.
     */
    @property (nonatomic, class, readonly) uint32_t PauseInBackground;
    /**
     * Flag to prevent the HTTP request from being coalesced with other equivalent request(s) that are currently on
     * the fly. Setting this flag will ensure that the request made through the HTTP service interface results in
     * its own network request.
     */
    @property (nonatomic, class, readonly) uint32_t PreventCoalescing;

@end
