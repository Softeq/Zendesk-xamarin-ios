using Foundation;
using UIKit;
using ZendeskCoreSDK.Bindings;
using SupportSDK.Bindings;

namespace SampleApp
{
    [Register("AppDelegate")]
    public class AppDelegate : UIResponder, IUIApplicationDelegate
    {
        [Export("window")]
        public UIWindow Window { get; set; }

        [Export("application:didFinishLaunchingWithOptions:")]
        public bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            InitZendesk();

            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method
            return true;
        }

        private void InitZendesk()
        {
            // TODO: Add valid credentials:
            ZDKZendesk.InitializeWithAppId(
                appId: "",
                clientId: "",
                zendeskUrl: "");
            ZDKZendesk.Instance.SetIdentity(new ZDKObjCAnonymous(
                name: "",
                email: ""));
            ZDKSupportUI.InitializeWithZendesk(ZDKZendesk.Instance);
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

