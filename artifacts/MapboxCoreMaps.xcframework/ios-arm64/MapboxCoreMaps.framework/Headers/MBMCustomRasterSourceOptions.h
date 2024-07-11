// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import "MBMCustomRasterSourceTileStatusChangedCallback.h"

/** Options for custom raster source. */
NS_SWIFT_NAME(CustomRasterSourceOptions)
__attribute__((visibility ("default")))
@interface MBMCustomRasterSourceOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithTileStatusChangedFunction:(nonnull MBMCustomRasterSourceTileStatusChangedCallback)tileStatusChangedFunction;

- (nonnull instancetype)initWithTileStatusChangedFunction:(nonnull MBMCustomRasterSourceTileStatusChangedCallback)tileStatusChangedFunction
                                                  minZoom:(uint8_t)minZoom
                                                  maxZoom:(uint8_t)maxZoom
                                                 tileSize:(uint16_t)tileSize;

/** The callback with notification about tile status change. */
@property (nonatomic, readonly, nonnull) MBMCustomRasterSourceTileStatusChangedCallback tileStatusChangedFunction;

/**
 * A minimum zoom level, at which to create vector tiles.
 *
 * The default value is `0`.
 */
@property (nonatomic, readonly) uint8_t minZoom;

/**
 * A maximum zoom level, at which to create vector tiles.
 *
 * A higher maximum zoom level provides greater details at high map zoom levels.
 *
 * The default value is `18`.
 */
@property (nonatomic, readonly) uint8_t maxZoom;

/** Size of the tiles. Tile size must be a power of 2. Default is `512`. */
@property (nonatomic, readonly) uint16_t tileSize;


@end
