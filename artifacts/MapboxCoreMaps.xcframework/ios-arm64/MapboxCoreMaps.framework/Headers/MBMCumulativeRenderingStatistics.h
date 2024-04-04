// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

NS_SWIFT_NAME(CumulativeRenderingStatistics)
__attribute__((visibility ("default")))
@interface MBMCumulativeRenderingStatistics : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithDrawCalls:(nullable NSNumber *)drawCalls
                             textureBytes:(nullable NSNumber *)textureBytes
                              vertexBytes:(nullable NSNumber *)vertexBytes;

/** The number of draw calls at the end of the collection window. */
@property (nonatomic, readonly, nullable) NSNumber *drawCalls NS_REFINED_FOR_SWIFT;

/** The amount of texture memory in use at the end of the collection window. */
@property (nonatomic, readonly, nullable) NSNumber *textureBytes NS_REFINED_FOR_SWIFT;

/** The amount of vertex memory (array and index buffer memory) in use at the end of the collection window. */
@property (nonatomic, readonly, nullable) NSNumber *vertexBytes NS_REFINED_FOR_SWIFT;


@end
