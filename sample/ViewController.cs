﻿using ChatProvidersSDK.Bindings;
using ChatSDK.Bindings;
using Foundation;
using MessagingAPI.Bindings;
using MessagingSDK.Bindings;
using SDKConfigurations.Bindings;
using SupportProvidersSDK.Bindings;
using SupportSDK.Bindings;
using System;
using UIKit;

namespace SampleApp
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var openSupportBtn = new UIButton(UIButtonType.System);
            openSupportBtn.TranslatesAutoresizingMaskIntoConstraints = false;
            openSupportBtn.SetTitle("Open Support", UIControlState.Normal);
            openSupportBtn.TouchUpInside += OnOpenSupport;

            var openChatBtn = new UIButton(UIButtonType.System);
            openChatBtn.TranslatesAutoresizingMaskIntoConstraints = false;
            openChatBtn.SetTitle("Open Chat", UIControlState.Normal);
            openChatBtn.TouchUpInside += OnOpenChat;

            View!.AddSubview(openSupportBtn);
            View!.AddSubview(openChatBtn);

            NSLayoutConstraint.ActivateConstraints(new[] {
                openSupportBtn.TopAnchor.ConstraintEqualTo(View.TopAnchor, 50),
                openSupportBtn.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor),
                openChatBtn.TopAnchor.ConstraintEqualTo(openSupportBtn.BottomAnchor, 20),
                openChatBtn.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor),
            });
        }

        private void OnOpenSupport(object? sender, EventArgs e)
        {
            // SUPPORT
            // https://developer.zendesk.com/documentation/classic-web-widget-sdks/support-sdk/ios/help_center/

            var config = new ZDKRequestUiConfiguration
            {
                Tags = new[] { "Create Request" },
                Subject = "Test from create request",
            };
            UIViewController requestScreen = ZDKRequestUi.BuildRequestUiWith(new NSObject[] { config });

            // UIViewController requestList = ZDKRequestUi.BuildRequestUiWith(new NSObject[]{});
            UIViewController helpCenter = ZDKHelpCenterUi.BuildHelpCenterOverviewUiWithConfigs(new ZDKConfiguration[] { });
            // UIViewController helpCenter = ZDKHelpCenterUi.BuildHelpCenterOverviewUi();

            PresentModalViewController(helpCenter, true);
        }

        private void OnOpenChat(object? sender, EventArgs e)
        {
            // CHAT
            // https://developer.zendesk.com/documentation/classic-web-widget-sdks/chat-sdk-v2/ios/getting-started/

            ZDKChatEngine engine = ZDKChatEngine.EngineAndReturnError(out var engineError);
            if (engineError != null)
            {
                throw new Exception("error during engine creation", new NSErrorException(engineError));
            }
            ZDKEngine[] engines = { engine };
            ZDKMessagingConfiguration messagingConfiguration = new ZDKMessagingConfiguration
            {
                Name = "Test Chat Bot",
            };
            ZDKChatConfiguration chatConfiguration = new ZDKChatConfiguration
            {
                IsAgentAvailabilityEnabled = false,
            };
            ZDKConfiguration[] configs = { messagingConfiguration, chatConfiguration };

            UIViewController chat = ZDKMessaging.Instance.BuildUIWithEngines(engines, configs, out var controllerError);
            if (controllerError != null)
            {
                throw new Exception("error during controller creation", new NSErrorException(controllerError));
            }

            PresentModalViewController(chat, false);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }
    }
}
