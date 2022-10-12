#!/bin/bash

sharpie bind -sdk iphoneos16.0 \
    -namespace SupportSDK.Bindings \
    -scope ./SupportSDK.framework/Headers \
    ./SupportSDK.framework/Headers/*.h
