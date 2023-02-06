#!/bin/bash

sharpie bind \
    -sdk iphoneos16.0 \
    -namespace CommonUISDK.Bindings \
    -scope ./CommonUISDK.framework/Headers \
    CommonUISDK.framework/Headers/CommonUISDK-Swift.h
