// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMPerfSamplerOptions.h>

/** Options used to configure performance sampling */
NS_SWIFT_NAME(PerfStatsCollectionOptions)
__attribute__((visibility ("default")))
@interface MBMPerfStatsCollectionOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithSamplerOptions:(nonnull NSArray<NSNumber *> *)samplerOptions;

- (nonnull instancetype)initWithSamplerOptions:(nonnull NSArray<NSNumber *> *)samplerOptions
                               framesPerSample:(uint32_t)framesPerSample;

/**
 * List of samplers to be used to collect performance statistics.
 * Leaving the array empty means that the sampling is disbled.
 */
@property (nonatomic, readonly, nonnull, copy) NSArray<NSNumber *> *samplerOptions;

/**
 * Number of frames to sample before the statistics event is emitted.
 *
 * Note: Lower values have higher effect on the performance. Errored frames are ignored and they are not counted in the number of samples.
 */
@property (nonatomic, readonly) uint32_t framesPerSample;


@end
