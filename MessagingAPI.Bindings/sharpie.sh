#!/bin/bash

sharpie bind \
    -sdk iphoneos16.0 \
    -namespace MessagingAPI.Bindings \
    -scope ./MessagingAPI.framework/Headers \
    MessagingAPI.framework/Headers/MessagingAPI-Swift.h
