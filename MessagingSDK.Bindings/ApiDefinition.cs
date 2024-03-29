using Foundation;
using MessagingSDK;
using ObjCRuntime;
using UIKit;
using SDKConfigurations.Bindings;
using MessagingAPI.Bindings;

namespace MessagingSDK.Bindings
{
    // @interface ZDKMessaging : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKMessaging
    {
        // @property (readonly, nonatomic, strong, class) ZDKMessaging * _Nonnull instance;
        [Static]
        [Export("instance", ArgumentSemantic.Strong)]
        ZDKMessaging Instance { get; }

        // @property (readonly, nonatomic) BOOL isMessagingPresented;
        [Export("isMessagingPresented")]
        bool IsMessagingPresented { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        ZDKMessagingDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<ZDKMessagingDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(UIViewController * _Nullable)buildUIWithEngines:(NSArray<id<ZDKEngine>> * _Nonnull)engines configs:(NSArray<id<ZDKConfiguration>> * _Nonnull)configs error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
        [Export("buildUIWithEngines:configs:error:")]
        [return: NullAllowed]
        UIViewController BuildUIWithEngines(IZDKEngine[] engines, IZDKConfiguration[] configs, [NullAllowed] out NSError error);
    }

    // @interface ZDKMessagingConfiguration : NSObject <ZDKConfiguration>
    [BaseType(typeof(ZDKConfiguration))]
    interface ZDKMessagingConfiguration
    {
        // @property (copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; set; }

        // @property (nonatomic, strong) UIImage * _Nonnull botAvatar;
        [Export("botAvatar", ArgumentSemantic.Strong)]
        UIImage BotAvatar { get; set; }

        // @property (nonatomic) BOOL isMultilineResponseOptionsEnabled;
        [Export("isMultilineResponseOptionsEnabled")]
        bool IsMultilineResponseOptionsEnabled { get; set; }
    }

    // @protocol ZDKMessagingDelegate
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface ZDKMessagingDelegate
    {
        // @required -(void)messaging:(ZDKMessaging * _Nonnull)messaging didPerformEvent:(enum ZDKMessagingUIEvent)event context:(id _Nullable)context;
        [Abstract]
        [Export("messaging:didPerformEvent:context:")]
        void Messaging(ZDKMessaging messaging, ZDKMessagingUIEvent @event, [NullAllowed] NSObject context);

        // @required -(BOOL)messaging:(ZDKMessaging * _Nonnull)messaging shouldOpenURL:(NSURL * _Nonnull)url __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("messaging:shouldOpenURL:")]
        bool Messaging(ZDKMessaging messaging, NSUrl url);
    }
}
