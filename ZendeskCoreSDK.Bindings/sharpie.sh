#!/bin/bash

sharpie bind \
    -sdk iphoneos16.0 \
    -namespace ZendeskCoreSDK.Bindings \
    -scope ./ZendeskCoreSDK.framework/Headers \
    ZendeskCoreSDK.framework/Headers/ZendeskCoreSDK-Swift.h
