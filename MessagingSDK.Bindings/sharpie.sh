#!/bin/bash
sharpie bind \
	-sdk iphoneos15.5 \
	-namespace MessagingSDK.Bindings \
	-scope ./MessagingSDK.framework/Headers \
	MessagingSDK.framework/Headers/MessagingSDK-Swift.h
