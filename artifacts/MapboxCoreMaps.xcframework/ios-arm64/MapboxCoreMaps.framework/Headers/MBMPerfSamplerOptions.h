// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Samplers which can be optionally enabled to collect performance statistics */
// NOLINTNEXTLINE(modernize-use-using)
typedef NS_ENUM(NSInteger, MBMPerfSamplerOptions)
{
    /** Collect GPU resource statistics */
    MBMPerfSamplerOptionsCumulativeRenderingStats,
    /** Collect per-frame counters */
    MBMPerfSamplerOptionsPerFrameRenderingStats
} NS_SWIFT_NAME(PerfSamplerOptions);
