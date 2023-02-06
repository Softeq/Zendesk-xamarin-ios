using System;
using ChatSDK;
using Foundation;
using ObjCRuntime;
using SDKConfigurations.Bindings;
using MessagingAPI.Bindings;

namespace ChatSDK.Bindings
{
    // @interface ZDKChatConfiguration : NSObject
    [BaseType(typeof(ZDKConfiguration))]
    interface ZDKChatConfiguration
    {
        // @property (nonatomic, strong) ZDKChatFormConfiguration * _Nonnull preChatFormConfiguration;
        [Export("preChatFormConfiguration", ArgumentSemantic.Strong)]
        ZDKChatFormConfiguration PreChatFormConfiguration { get; set; }

        // @property (nonatomic) BOOL isChatTranscriptPromptEnabled;
        [Export("isChatTranscriptPromptEnabled")]
        bool IsChatTranscriptPromptEnabled { get; set; }

        // @property (nonatomic) BOOL isPreChatFormEnabled;
        [Export("isPreChatFormEnabled")]
        bool IsPreChatFormEnabled { get; set; }

        // @property (nonatomic) BOOL isOfflineFormEnabled;
        [Export("isOfflineFormEnabled")]
        bool IsOfflineFormEnabled { get; set; }

        // @property (nonatomic) BOOL isAgentAvailabilityEnabled;
        [Export("isAgentAvailabilityEnabled")]
        bool IsAgentAvailabilityEnabled { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // -(void)setChatMenuActions:(NSArray<NSNumber *> * _Nonnull)actions;
        [Export("setChatMenuActions:")]
        void SetChatMenuActions(NSNumber[] actions);

        // @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull menuActions;
        [Export("menuActions", ArgumentSemantic.Copy)]
        NSNumber[] MenuActions { get; }
    }

    // @interface ZDKChatEngine : NSObject
    [BaseType(typeof(ZDKEngine))]
    [DisableDefaultCtor]
    interface ZDKChatEngine
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (readonly, nonatomic, strong) ZDKChatConfiguration * _Nonnull configuration;
        [Export("configuration", ArgumentSemantic.Strong)]
        ZDKChatConfiguration Configuration { get; }

        // -(void)isConversationOngoing:(void (^ _Nonnull)(BOOL))completion;
        [Export("isConversationOngoing:")]
        void IsConversationOngoing(Action<bool> completion);

        // +(ZDKChatEngine * _Nullable)engineAndReturnError:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
        [Static]
        [Export("engineAndReturnError:")]
        [return: NullAllowed]
        ZDKChatEngine EngineAndReturnError([NullAllowed] out NSError error);

        // -(BOOL)isConversationOngoing __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use isConversationOngoing(_ completion: @escaping (Bool) -> Void) instead")));
        [Export("isConversationOngoing")]
        bool IsConversationOngoing();
    }

    // @interface ZDKChatFormConfiguration : NSObject
    [BaseType(typeof(ZDKConfiguration))]
    [DisableDefaultCtor]
    interface ZDKChatFormConfiguration
    {
        // @property (nonatomic) enum ZDKFormFieldStatus name;
        [Export("name", ArgumentSemantic.Assign)]
        ZDKFormFieldStatus Name { get; set; }

        // @property (nonatomic) enum ZDKFormFieldStatus email;
        [Export("email", ArgumentSemantic.Assign)]
        ZDKFormFieldStatus Email { get; set; }

        // @property (nonatomic) enum ZDKFormFieldStatus phoneNumber;
        [Export("phoneNumber", ArgumentSemantic.Assign)]
        ZDKFormFieldStatus PhoneNumber { get; set; }

        // @property (nonatomic) enum ZDKFormFieldStatus department;
        [Export("department", ArgumentSemantic.Assign)]
        ZDKFormFieldStatus Department { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }

        // -(instancetype _Nonnull)initWithName:(enum ZDKFormFieldStatus)name email:(enum ZDKFormFieldStatus)email phoneNumber:(enum ZDKFormFieldStatus)phoneNumber department:(enum ZDKFormFieldStatus)department __attribute__((objc_designated_initializer));
        [Export("initWithName:email:phoneNumber:department:")]
        [DesignatedInitializer]
        IntPtr Constructor(ZDKFormFieldStatus name, ZDKFormFieldStatus email, ZDKFormFieldStatus phoneNumber, ZDKFormFieldStatus department);

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);
    }
}
