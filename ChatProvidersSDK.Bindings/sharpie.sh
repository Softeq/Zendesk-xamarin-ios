#!/bin/bash

sharpie bind \
    -sdk iphoneos16.0 \
    -namespace ChatProvidersSDK.Bindings \
    -scope ./ChatProvidersSDK.framework/Headers \
    ChatProvidersSDK.framework/Headers/ChatProvidersSDK-Swift.h
