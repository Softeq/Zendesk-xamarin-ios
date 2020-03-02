using Foundation;
using UIKit;
using ZendeskCoreSDK.Bindings;
using SupportSDK.Bindings;
using System;
using System.Diagnostics;

namespace Zendesk
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIResponder, IUIApplicationDelegate
    {

        [Export("window")]
        public UIWindow Window { get; set; }

        [Export("application:didFinishLaunchingWithOptions:")]
        public bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            ZDKZendesk.InitializeWithAppId("8d7a4c798735d6efd9c1e31c012a2739b8f1fd58b07f39aa", "mobile_sdk_client_d552e2213ad411467f27", "https://halocollar.zendesk.com");
            ZDKZendesk.Instance.SetIdentity(new ZDKObjCAnonymous("PavelNewBinding", "pavel.leonenko@softeq.com"));
            ZDKSupportUI.InitializeWithZendesk(ZDKZendesk.Instance);


            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method
            return true;
        }

        // UISceneSession Lifecycle

        [Export("application:configurationForConnectingSceneSession:options:")]
        public UISceneConfiguration GetConfiguration(UIApplication application, UISceneSession connectingSceneSession, UISceneConnectionOptions options)
        {
            // Called when a new scene session is being created.
            // Use this method to select a configuration to create the new scene with.
            return UISceneConfiguration.Create("Default Configuration", connectingSceneSession.Role);
        }

        [Export("application:didDiscardSceneSessions:")]
        public void DidDiscardSceneSessions(UIApplication application, NSSet<UISceneSession> sceneSessions)
        {
            // Called when the user discards a scene session.
            // If any sessions were discarded while the application was not running, this will be called shortly after `FinishedLaunching`.
            // Use this method to release any resources that were specific to the discarded scenes, as they will not return.
        }
    }
}

