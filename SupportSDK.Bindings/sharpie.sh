#!/bin/bash
sharpie bind -sdk iphoneos15.5 \
	-namespace SupportSDK.Bindings \
	-scope ./SupportSDK.framework/Headers \
	./SupportSDK.framework/Headers/*.h
