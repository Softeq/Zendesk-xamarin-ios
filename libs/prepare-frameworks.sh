#!/bin/bash

rm -rf *.xcframework
rm -rf *.framework

for zipFile in *.zip; do
    # Extract archive
    unzip ${zipFile} > /dev/null

    frameworkName=$(echo ${zipFile} | cut -d '.' -f 1)
    xcframework="${frameworkName}.xcframework"
    framework="${frameworkName}.framework"

    # Repack universal binary:
    #   from device=(armv7 arm64), simulator=(x86_64 i386 arm64)
    #   to universal=(armv7 x86_64 i386 arm64)
    xcframeworkDeviceFrameworkPath=${xcframework}/ios-arm64_armv7/${framework}
    xcframeworkSimulatorFrameworkPath=${xcframework}/ios-arm64_i386_x86_64-simulator/${framework}
    cp -r ${xcframeworkDeviceFrameworkPath} .
    cd ${framework}
    mv ${frameworkName} device
    lipo -remove arm64 \
        ../${xcframeworkSimulatorFrameworkPath}/${frameworkName} \
        -o simulator
    lipo -create -output ${frameworkName} device simulator
    rm device simulator
    cp -n \
        ../${xcframeworkSimulatorFrameworkPath}/Modules/${frameworkName}.swiftmodule/* \
        Modules/${frameworkName}.swiftmodule
    echo "processed $(pwd)"

    # Cleanup
    cd ..
    rm -rf ${xcframework}
done
