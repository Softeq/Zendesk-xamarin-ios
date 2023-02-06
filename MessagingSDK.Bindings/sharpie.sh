#!/bin/bash

sharpie bind \
    -sdk iphoneos16.0 \
    -namespace MessagingSDK.Bindings \
    -scope ./MessagingSDK.framework/Headers \
    MessagingSDK.framework/Headers/MessagingSDK-Swift.h
