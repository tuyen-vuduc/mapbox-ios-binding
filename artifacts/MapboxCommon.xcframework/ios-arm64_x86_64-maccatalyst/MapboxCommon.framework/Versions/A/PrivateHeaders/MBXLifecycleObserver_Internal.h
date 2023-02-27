// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import "MBXLifecycleMonitoringState_Internal.h"
#import "MBXLifecycleState_Internal.h"

NS_SWIFT_NAME(LifecycleObserver)
@protocol MBXLifecycleObserver
- (void)onMonitoringStateChangedForState:(MBXLifecycleMonitoringState)state
                                   error:(nullable NSString *)error;
- (void)onLifecycleStateChangedForState:(MBXLifecycleState)state;
@end
