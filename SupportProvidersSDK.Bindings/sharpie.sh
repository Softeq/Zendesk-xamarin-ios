#!/bin/bash

sharpie bind -sdk iphoneos16.0 \
    -namespace SupportProvidersSDK.Bindings \
    -scope ./SupportProvidersSDK.framework/Headers \
    ./SupportProvidersSDK.framework/Headers/*.h
