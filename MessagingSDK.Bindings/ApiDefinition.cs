using System;

using ObjCRuntime;
using Foundation;
using UIKit;
using SDKConfigurations.Bindings;
using MessagingAPI.Bindings;

namespace MessagingSDK.Bindings
{
    [Static]
	//[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double MessagingSDKVersionNumber;
		[Field("MessagingSDKVersionNumber", "__Internal")]
		double MessagingSDKVersionNumber { get; }

		//// extern const unsigned char [] MessagingSDKVersionString;
		//[Field("MessagingSDKVersionString", "__Internal")]
		//byte[] MessagingSDKVersionString { get; }
	}

	// @interface ZDKMessaging : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKMessaging
	{
		// @property (readonly, nonatomic, strong, class) ZDKMessaging * _Nonnull instance;
		[Static]
		[Export("instance", ArgumentSemantic.Strong)]
		ZDKMessaging Instance { get; }
	}

	// @interface MessagingSDK_Swift_785 (ZDKMessaging)
	[Category]
	[BaseType(typeof(ZDKMessaging))]
	interface ZDKMessaging_MessagingSDK_Swift_785
	{
		// -(UIViewController * _Nullable)buildUIWithEngines:(NSArray<id<ZDKEngine>> * _Nonnull)engines configs:(NSArray<id<ZDKConfiguration>> * _Nonnull)configs error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
		[Export("buildUIWithEngines:configs:error:")]
		[return: NullAllowed]
		UIViewController BuildUIWithEngines(IZDKEngine[] engines, ZDKConfiguration[] configs, [NullAllowed] out NSError error);
	}

	// @interface ZDKMessagingConfiguration : NSObject <ZDKConfiguration>
	[BaseType(typeof(NSObject))]
	interface ZDKMessagingConfiguration : IZDKConfiguration
	{
		// @property (copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; set; }

		// @property (nonatomic, strong) UIImage * _Nonnull botAvatar;
		[Export("botAvatar", ArgumentSemantic.Strong)]
		UIImage BotAvatar { get; set; }
	}
}

