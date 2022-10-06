#!/bin/bash

sharpie bind \
    -sdk iphoneos16.0 \
    -namespace ChatSDK.Bindings \
    -scope ./ChatSDK.framework/Headers \
    ChatSDK.framework/Headers/ChatSDK-Swift.h
