#!/bin/bash
sharpie bind -sdk iphoneos15.5 \
	-namespace SupportProvidersSDK.Bindings \
	-scope ./SupportProvidersSDK.framework/Headers \
	./SupportProvidersSDK.framework/Headers/*.h
