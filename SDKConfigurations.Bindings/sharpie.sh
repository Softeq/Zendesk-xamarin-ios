#!/bin/bash

sharpie bind \
    -sdk iphoneos16.0 \
    -namespace SDKConfigurations.Bindings \
    -scope ./SDKConfigurations.framework/Headers \
    SDKConfigurations.framework/Headers/SDKConfigurations-Swift.h
