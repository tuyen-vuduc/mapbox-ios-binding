#!/bin/bash

export SDK=iphoneos17.4

function bind {
    echo "$1 artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/"

    if [ $3 == '1' ]
    then
        sharpie bind --sdk=$SDK \
            --output="libs/$1.iOS" \
            --namespace="$1" \
            --scope="$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/" \
            "$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/$2.h"
    elif [ $3 == '2' ]
    then
        sharpie bind --sdk=$SDK \
            --output="libs/$1.iOS" \
            --namespace="$1" \
            --scope="$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/" \
            "$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/$2.h"
    elif [ $3 == '3' ]
    then
        sharpie bind --sdk=$SDK \
            --output="libs/$1.iOS" \
            --namespace="$1" \
            --scope="$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/" \
            "$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/$2.h" \
            "$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/$2-swift.h"
    else
        sharpie bind --sdk=$SDK \
            --output="libs/$1.iOS" \
            --namespace="$1" \
            --scope="$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/" \
            "$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/$2-Swift.h"
    fi
}

# bind MapboxCoreMaps MapboxCoreMaps 1
bind MapboxCommon MapboxCommon 3
# bind MapboxMaps MapboxMaps 0
# bind Turf Turf 2
# bind MapboxMapsObjC MapboxMapObjC 0