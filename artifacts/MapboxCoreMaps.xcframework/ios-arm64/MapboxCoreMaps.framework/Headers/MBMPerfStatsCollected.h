// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/**
 * Performance statistics are collected at the end of the configured window.
 *
 * Note: It will be emitted only if performance statistics collection is enabled on the map.
 */
NS_SWIFT_NAME(PerfStatsCollected)
__attribute__((visibility ("default")))
@interface MBMPerfStatsCollected : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithStats:(nonnull id)stats
                            timestamp:(nonnull NSDate *)timestamp;

/**
 * A value object containing the collected statistics.
 *
 * Note: Currently there's no guarantee on the format.
 * The value can be dumped as a JSON and inspected on the client side.
 */
@property (nonatomic, readonly, nonnull, copy) id stats;

/** The timestamp of the `PerfStatsCollected` event. */
@property (nonatomic, readonly, nonnull) NSDate *timestamp;


@end
