#!/bin/bash

rm *.zip

wget "https://github.com/zendesk/core_sdk_ios/releases/download/2.7.0/ZendeskCoreSDK.xcframework.zip" &
wget "https://github.com/zendesk/support_sdk_ios/releases/download/5.5.0/SupportSDK.xcframework.zip" &
wget "https://github.com/zendesk/support_providers_sdk_ios/releases/download/5.5.0/SupportProvidersSDK.xcframework.zip" &
wget "https://github.com/zendesk/messaging_sdk_ios/releases/download/3.8.5/MessagingSDK.xcframework.zip" &
wget "https://github.com/zendesk/messagingapi_sdk_ios/releases/download/3.8.5/MessagingAPI.xcframework.zip" &
wget "https://github.com/zendesk/commonui_sdk_ios/releases/download/6.1.4/CommonUISDK.xcframework.zip" &
wget "https://github.com/zendesk/sdkconfigurations_sdk_ios/releases/download/1.1.11/SDKConfigurations.xcframework.zip" &
wget "https://github.com/zendesk/chat_providers_sdk_ios/releases/download/2.12.0/ChatProvidersSDK.xcframework.zip" &
wget "https://github.com/zendesk/chat_sdk_ios/releases/download/2.12.0/ChatSDK.xcframework.zip" &

wait
