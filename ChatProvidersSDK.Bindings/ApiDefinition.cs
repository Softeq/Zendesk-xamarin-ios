using System;
using ChatProvidersSDK;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using UIKit;
using SDKConfigurations.Bindings;
using MessagingAPI.Bindings;

namespace ChatProvidersSDK.Bindings
{
    // @interface ZDKChatAccount : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKChatAccount
    {
        // @property (readonly, nonatomic) enum ZDKChatAccountStatus accountStatus;
        [Export("accountStatus")]
        ZDKChatAccountStatus AccountStatus { get; }

        // @property (readonly, copy, nonatomic) NSArray<ZDKDepartment *> * _Nullable departments;
        [NullAllowed, Export("departments", ArgumentSemantic.Copy)]
        ZDKDepartment[] Departments { get; }

        // -(instancetype _Nonnull)initWithAccountStatus:(enum ZDKChatAccountStatus)accountStatus departments:(NSArray<ZDKDepartment *> * _Nullable)departments __attribute__((objc_designated_initializer));
        [Export("initWithAccountStatus:departments:")]
        [DesignatedInitializer]
        IntPtr Constructor(ZDKChatAccountStatus accountStatus, [NullAllowed] ZDKDepartment[] departments);

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // -(BOOL)containsDepartmentWith:(NSString * _Nonnull)name __attribute__((warn_unused_result("")));
        [Export("containsDepartmentWith:")]
        bool ContainsDepartmentWith(string name);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }
    }

    // @interface ZDKChatAccountProvider : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKChatAccountProvider
    {
        // -(void)getAccount:(void (^ _Nonnull)(ZDKChatAccount * _Nullable, NSError * _Nullable))completion;
        [Export("getAccount:")]
        void GetAccount(Action<ZDKChatAccount, NSError> completion);

        // -(ZDKObservationToken * _Nonnull)observeAccountWithIdentifier:(NSString * _Nonnull)identifier :(void (^ _Nonnull)(ZDKChatAccount * _Nonnull))completion __attribute__((warn_unused_result("")));
        [Export("observeAccountWithIdentifier::")]
        ZDKObservationToken ObserveAccountWithIdentifier(string identifier, Action<ZDKChatAccount> completion);

        // -(ZDKObservationToken * _Nonnull)observeAccount:(void (^ _Nonnull)(ZDKChatAccount * _Nonnull))completion __attribute__((warn_unused_result("")));
        [Export("observeAccount:")]
        ZDKObservationToken ObserveAccount(Action<ZDKChatAccount> completion);
    }

    // @interface ZDKAgent : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKAgent
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull nick;
        [Export("nick")]
        string Nick { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull displayName;
        [Export("displayName")]
        string DisplayName { get; }

        // @property (readonly, copy, nonatomic) NSURL * _Nullable avatar;
        [NullAllowed, Export("avatar", ArgumentSemantic.Copy)]
        NSUrl Avatar { get; }

        // @property (readonly, nonatomic) BOOL isTyping;
        [Export("isTyping")]
        bool IsTyping { get; }

        // -(instancetype _Nonnull)initWithAvatar:(NSURL * _Nullable)avatar nick:(NSString * _Nonnull)nick displayName:(NSString * _Nonnull)displayName isTyping:(BOOL)isTyping __attribute__((objc_designated_initializer));
        [Export("initWithAvatar:nick:displayName:isTyping:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] NSUrl avatar, string nick, string displayName, bool isTyping);

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }
    }

    // @interface ZDKChat : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKChat
    {
        // @property (readonly, nonatomic, class) NSNotificationName _Nonnull NotificationMessageReceived;
        [Static]
        [Export("NotificationMessageReceived")]
        string NotificationMessageReceived { get; }

        // @property (readonly, nonatomic, class) NSNotificationName _Nonnull NotificationChatEnded;
        [Static]
        [Export("NotificationChatEnded")]
        string NotificationChatEnded { get; }

        // @property (readonly, nonatomic, class) NSNotificationName _Nonnull NotificationAuthenticationFailed;
        [Static]
        [Export("NotificationAuthenticationFailed")]
        string NotificationAuthenticationFailed { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull accountKey;
        [Export("accountKey")]
        string AccountKey { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable appId;
        [NullAllowed, Export("appId")]
        string AppId { get; }

        // @property (readonly, nonatomic, strong) ZDKChatProviders * _Nonnull providers;
        [Export("providers", ArgumentSemantic.Strong)]
        ZDKChatProviders Providers { get; }

        // @property (readonly, nonatomic, strong, class) ZDKChat * _Nullable instance;
        [Static]
        [NullAllowed, Export("instance", ArgumentSemantic.Strong)]
        ZDKChat Instance { get; }

        // @property (nonatomic, strong) ZDKChatAPIConfiguration * _Nonnull configuration;
        [Export("configuration", ArgumentSemantic.Strong)]
        ZDKChatAPIConfiguration Configuration { get; set; }

        // @property (readonly, nonatomic, strong, class) ZDKChatAPIConfiguration * _Nonnull configuration;
        [Static]
        [Export("configuration", ArgumentSemantic.Strong)]
        ZDKChatAPIConfiguration DefaultConfiguration { get; }

        // @property (readonly, nonatomic, class) BOOL hasIdentity;
        [Static]
        [Export("hasIdentity")]
        bool DefaultHasIdentity { get; }

        // @property (readonly, nonatomic, strong, class) ZDKChatAccountProvider * _Nullable accountProvider;
        [Static]
        [NullAllowed, Export("accountProvider", ArgumentSemantic.Strong)]
        ZDKChatAccountProvider DefaultAccountProvider { get; }

        // @property (readonly, nonatomic, strong, class) ZDKConnectionProvider * _Nullable connectionProvider;
        [Static]
        [NullAllowed, Export("connectionProvider", ArgumentSemantic.Strong)]
        ZDKConnectionProvider DefaultConnectionProvider { get; }

        // @property (readonly, nonatomic, strong, class) ZDKProfileProvider * _Nullable profileProvider;
        [Static]
        [NullAllowed, Export("profileProvider", ArgumentSemantic.Strong)]
        ZDKProfileProvider DefaultProfileProvider { get; }

        // @property (readonly, nonatomic, strong, class) ZDKPushNotificationsProvider * _Nullable pushNotificationsProvider;
        [Static]
        [NullAllowed, Export("pushNotificationsProvider", ArgumentSemantic.Strong)]
        ZDKPushNotificationsProvider DefaultPushNotificationsProvider { get; }

        // @property (readonly, nonatomic, strong, class) ZDKChatProvider * _Nullable chatProvider;
        [Static]
        [NullAllowed, Export("chatProvider", ArgumentSemantic.Strong)]
        ZDKChatProvider DefaultChatProvider { get; }

        // @property (readonly, nonatomic, strong, class) ZDKSettingsProvider * _Nullable settingsProvider;
        [Static]
        [NullAllowed, Export("settingsProvider", ArgumentSemantic.Strong)]
        ZDKSettingsProvider DefaultSettingsProvider { get; }

        // @property (readonly, nonatomic) BOOL hasIdentity;
        [Export("hasIdentity")]
        bool HasIdentity { get; }

        // @property (readonly, nonatomic, strong) ZDKChatAccountProvider * _Nonnull accountProvider;
        [Export("accountProvider", ArgumentSemantic.Strong)]
        ZDKChatAccountProvider AccountProvider { get; }

        // @property (readonly, nonatomic, strong) ZDKConnectionProvider * _Nonnull connectionProvider;
        [Export("connectionProvider", ArgumentSemantic.Strong)]
        ZDKConnectionProvider ConnectionProvider { get; }

        // @property (readonly, nonatomic, strong) ZDKPushNotificationsProvider * _Nonnull pushNotificationsProvider;
        [Export("pushNotificationsProvider", ArgumentSemantic.Strong)]
        ZDKPushNotificationsProvider PushNotificationsProvider { get; }

        // @property (readonly, nonatomic, strong) ZDKProfileProvider * _Nonnull profileProvider;
        [Export("profileProvider", ArgumentSemantic.Strong)]
        ZDKProfileProvider ProfileProvider { get; }

        // @property (readonly, nonatomic, strong) ZDKChatProvider * _Nonnull chatProvider;
        [Export("chatProvider", ArgumentSemantic.Strong)]
        ZDKChatProvider ChatProvider { get; }

        // @property (readonly, nonatomic, strong) ZDKSettingsProvider * _Nonnull settingsProvider;
        [Export("settingsProvider", ArgumentSemantic.Strong)]
        ZDKSettingsProvider SettingsProvider { get; }

        // +(void)initializeWithAccountKey:(NSString * _Nonnull)accountKey appId:(NSString * _Nullable)appId queue:(dispatch_queue_t _Nonnull)queue;
        [Static]
        [Export("initializeWithAccountKey:appId:queue:")]
        void InitializeWithAccountKey(string accountKey, [NullAllowed] string appId, DispatchQueue queue);

        // +(void)initializeWithAccountKey:(NSString * _Nonnull)accountKey queue:(dispatch_queue_t _Nonnull)queue;
        [Static]
        [Export("initializeWithAccountKey:queue:")]
        void InitializeWithAccountKey(string accountKey, DispatchQueue queue);

        // -(void)clearCache;
        [Export("clearCache")]
        void ClearCache();

        // -(void)setIdentityWithAuthenticator:(id<ZDKJWTAuthenticator> _Nonnull)authenticator;
        [Export("setIdentityWithAuthenticator:")]
        void SetIdentityWithAuthenticator(ZDKJWTAuthenticator authenticator);

        // -(void)resetIdentity:(void (^ _Nullable)(void))completion;
        [Export("resetIdentity:")]
        void ResetIdentity([NullAllowed] Action completion);

        // -(void)resetIdentity __attribute__((deprecated("Please use `resetIdentity(_ completion: (() -> Void)?)` instead")));
        [Export("resetIdentity")]
        void ResetIdentity();

        // +(void)registerPushToken:(NSData * _Nonnull)pushTokenData;
        [Static]
        [Export("registerPushToken:")]
        void RegisterPushToken(NSData pushTokenData);

        // +(void)registerPushTokenString:(NSString * _Nonnull)pushTokenString;
        [Static]
        [Export("registerPushTokenString:")]
        void RegisterPushTokenString(string pushTokenString);

        // +(void)didReceiveRemoteNotification:(NSDictionary * _Nonnull)userInfo in:(UIApplication * _Nonnull)application;
        [Static]
        [Export("didReceiveRemoteNotification:in:")]
        void DidReceiveRemoteNotification(NSDictionary userInfo, UIApplication application);
    }

    // @interface ZDKChatAPIConfiguration : NSObject
    [BaseType(typeof(ZDKConfiguration))]
    interface ZDKChatAPIConfiguration
    {
        // @property (copy, nonatomic) NSString * _Nullable visitorPathOne;
        [NullAllowed, Export("visitorPathOne")]
        string VisitorPathOne { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull visitorPathTwo;
        [Export("visitorPathTwo")]
        string VisitorPathTwo { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable visitorPathTwoValue;
        [NullAllowed, Export("visitorPathTwoValue")]
        string VisitorPathTwoValue { get; set; }

        // @property (copy, nonatomic) NSArray<NSString *> * _Nonnull tags;
        [Export("tags", ArgumentSemantic.Copy)]
        string[] Tags { get; set; }

        // @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("", "departmentName") NSString * department __attribute__((deprecated("", "departmentName")));
        [Export("department")]
        string Department { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable departmentName;
        [NullAllowed, Export("departmentName")]
        string DepartmentName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable departmentId;
        [NullAllowed, Export("departmentId")]
        string DepartmentId { get; set; }

        // @property (nonatomic, strong) ZDKVisitorInfo * _Nullable visitorInfo;
        [NullAllowed, Export("visitorInfo", ArgumentSemantic.Strong)]
        ZDKVisitorInfo VisitorInfo { get; set; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);
    }

    // @interface ZDKChatAttachment : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKChatAttachment
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull mimeType;
        [Export("mimeType")]
        string MimeType { get; }

        // @property (readonly, nonatomic) NSInteger size;
        [Export("size")]
        nint Size { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull url;
        [Export("url")]
        string Url { get; }

        // @property (readonly, copy, nonatomic) NSURL * _Nullable localURL;
        [NullAllowed, Export("localURL", ArgumentSemantic.Copy)]
        NSUrl LocalURL { get; }

        // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name mimeType:(NSString * _Nonnull)mimeType size:(NSInteger)size url:(NSString * _Nonnull)url localURL:(NSURL * _Nullable)localURL;
        [Export("initWithName:mimeType:size:url:localURL:")]
        IntPtr Constructor(string name, string mimeType, nint size, string url, [NullAllowed] NSUrl localURL);

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }
    }

    // @interface ZDKChatLog : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKChatLog
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull nick;
        [Export("nick")]
        string Nick { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull displayName;
        [Export("displayName")]
        string DisplayName { get; }

        // @property (readonly, nonatomic) NSTimeInterval createdTimestamp;
        [Export("createdTimestamp")]
        double CreatedTimestamp { get; }

        // @property (readonly, nonatomic) NSTimeInterval lastModifiedTimestamp;
        [Export("lastModifiedTimestamp")]
        double LastModifiedTimestamp { get; }

        // @property (readonly, nonatomic) enum ZDKChatLogType type;
        [Export("type")]
        ZDKChatLogType Type { get; }

        // @property (readonly, nonatomic) enum ZDKChatParticipant participant;
        [Export("participant")]
        ZDKChatParticipant Participant { get; }

        // @property (readonly, nonatomic) BOOL createdByVisitor;
        [Export("createdByVisitor")]
        bool CreatedByVisitor { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);
    }

    // @interface ZDKChatAttachmentMessage : ZDKChatLog
    [BaseType(typeof(ZDKChatLog))]
    interface ZDKChatAttachmentMessage
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull message;
        [Export("message")]
        string Message { get; }

        // @property (readonly, nonatomic, strong) ZDKChatAttachment * _Nonnull attachment;
        [Export("attachment", ArgumentSemantic.Strong)]
        ZDKChatAttachment Attachment { get; }

        // @property (readonly, copy, nonatomic) NSURL * _Nullable url;
        [NullAllowed, Export("url", ArgumentSemantic.Copy)]
        NSUrl Url { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);
    }

    // @interface ZDKChatComment : ZDKChatLog
    [BaseType(typeof(ZDKChatLog))]
    interface ZDKChatComment
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable comment;
        [NullAllowed, Export("comment")]
        string Comment { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull newComment;
        [Export("newComment")]
        string NewComment { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }
    }

    // @interface ZDKChatInfo : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKChatInfo
    {
        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) BOOL isChatting;
        [Export("isChatting")]
        bool IsChatting { get; }

        // -(instancetype _Nonnull)initWithIsChatting:(BOOL)isChatting __attribute__((objc_designated_initializer));
        [Export("initWithIsChatting:")]
        [DesignatedInitializer]
        IntPtr Constructor(bool isChatting);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }

        // @property (readonly, nonatomic) enum ZDKDeliveryStatus deliveryStatus;
        [Export("deliveryStatus")]
        ZDKDeliveryStatus DeliveryStatus { get; }
    }

    // @interface ZDKChatMemberJoin : ZDKChatLog
    [BaseType(typeof(ZDKChatLog))]
    interface ZDKChatMemberJoin
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }
    }

    // @interface ZDKChatMemberLeave : ZDKChatLog
    [BaseType(typeof(ZDKChatLog))]
    interface ZDKChatMemberLeave
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }
    }

    // @interface ZDKChatMessage : ZDKChatLog
    [BaseType(typeof(ZDKChatLog))]
    interface ZDKChatMessage
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull message;
        [Export("message")]
        string Message { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }
    }

    // @interface ZDKChatOptionsMessage : ZDKChatLog
    [BaseType(typeof(ZDKChatLog))]
    interface ZDKChatOptionsMessage
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull message;
        [Export("message")]
        string Message { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull options;
        [Export("options", ArgumentSemantic.Copy)]
        string[] Options { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }
    }

    // @interface ZDKChatProvider : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKChatProvider
    {
        // @property (readonly, nonatomic, strong) ZDKChatState * _Nonnull chatState;
        [Export("chatState", ArgumentSemantic.Strong)]
        ZDKChatState ChatState { get; }

        // -(void)requestChat __attribute__((deprecated("This API is no longer supported")));
        [Export("requestChat")]
        void RequestChat();

        // -(void)sendTypingWithIsTyping:(BOOL)isTyping;
        [Export("sendTypingWithIsTyping:")]
        void SendTypingWithIsTyping(bool isTyping);

        // -(void)getChatInfo:(void (^ _Nonnull)(ZDKChatInfo * _Nullable, NSError * _Nullable))completion;
        [Export("getChatInfo:")]
        void GetChatInfo(Action<ZDKChatInfo, NSError> completion);

        // -(void)setDepartment:(NSString * _Nullable)name completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("setDepartment:completion:")]
        void SetDepartmentByName([NullAllowed] string name, [NullAllowed] Action<NSString, NSError> completion);

        // -(void)setDepartment:(NSString * _Nonnull)id _:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("setDepartment:_:")]
        void SetDepartmentById(string id, [NullAllowed] Action<NSString, NSError> completion);

        // -(void)sendMessage:(NSString * _Nonnull)message completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("sendMessage:completion:")]
        void SendMessage(string message, [NullAllowed] Action<NSString, NSError> completion);

        // -(void)sendOfflineForm:(ZDKOfflineForm * _Nonnull)offlineForm completion:(void (^ _Nullable)(ZDKOfflineForm * _Nullable, NSError * _Nullable))completion;
        [Export("sendOfflineForm:completion:")]
        void SendOfflineForm(ZDKOfflineForm offlineForm, [NullAllowed] Action<ZDKOfflineForm, NSError> completion);

        // -(void)resendFailedMessageWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("resendFailedMessageWithId:completion:")]
        void ResendFailedMessageWithId(string id, [NullAllowed] Action<NSString, NSError> completion);

        // -(void)deleteFailedMessageWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("deleteFailedMessageWithId:completion:")]
        void DeleteFailedMessageWithId(string id, [NullAllowed] Action<NSString, NSError> completion);

        // -(void)sendFileWithUrl:(NSURL * _Nonnull)url onProgress:(void (^ _Nullable)(double))onProgress completion:(void (^ _Nullable)(NSString * _Nullable, ZDKChatAttachmentMessage * _Nullable, NSError * _Nullable))completion;
        [Export("sendFileWithUrl:onProgress:completion:")]
        void SendFileWithUrl(NSUrl url, [NullAllowed] Action<double> onProgress, [NullAllowed] Action<NSString, ZDKChatAttachmentMessage, NSError> completion);

        // -(void)resendFailedFileWithId:(NSString * _Nonnull)id onProgress:(void (^ _Nullable)(double))onProgress completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("resendFailedFileWithId:onProgress:completion:")]
        void ResendFailedFileWithId(string id, [NullAllowed] Action<double> onProgress, [NullAllowed] Action<NSString, NSError> completion);

        // -(void)sendChatRating:(enum ZDKRating)rating completion:(void (^ _Nullable)(enum ZDKRating, NSError * _Nullable))completion;
        [Export("sendChatRating:completion:")]
        void SendChatRating(ZDKRating rating, [NullAllowed] Action<ZDKRating, NSError> completion);

        // -(void)sendChatComment:(NSString * _Nonnull)comment completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("sendChatComment:completion:")]
        void SendChatComment(string comment, [NullAllowed] Action<NSString, NSError> completion);

        // -(void)sendEmailTranscript:(NSString * _Nonnull)email completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("sendEmailTranscript:completion:")]
        void SendEmailTranscript(string email, [NullAllowed] Action<NSString, NSError> completion);

        // -(void)endChat:(void (^ _Nullable)(BOOL, NSError * _Nullable))completion;
        [Export("endChat:")]
        void EndChat([NullAllowed] Action<bool, NSError> completion);

        // -(ZDKObservationToken * _Nonnull)observeChatStateWithIdentifier:(NSString * _Nonnull)identifier :(void (^ _Nonnull)(ZDKChatState * _Nonnull))completion __attribute__((warn_unused_result("")));
        [Export("observeChatStateWithIdentifier::")]
        ZDKObservationToken ObserveChatStateWithIdentifier(string identifier, Action<ZDKChatState> completion);

        // -(ZDKObservationToken * _Nonnull)observeChatState:(void (^ _Nonnull)(ZDKChatState * _Nonnull))completion __attribute__((warn_unused_result("")));
        [Export("observeChatState:")]
        ZDKObservationToken ObserveChatState(Action<ZDKChatState> completion);
    }

    // @interface ZDKChatRating : ZDKChatLog
    [BaseType(typeof(ZDKChatLog))]
    interface ZDKChatRating
    {
        // @property (readonly, nonatomic) enum ZDKRating ratingValue;
        [Export("ratingValue")]
        ZDKRating RatingValue { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }
    }

    // @interface ZDKRatingRequest : ZDKChatLog
    [BaseType(typeof(ZDKChatLog))]
    interface ZDKRatingRequest
    {
        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }
    }

    // @interface ZDKChatSettings : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKChatSettings
    {
        // @property (readonly, nonatomic, strong, class) ZDKChatSettings * _Nonnull initial;
        [Static]
        [Export("initial", ArgumentSemantic.Strong)]
        ZDKChatSettings Initial { get; }

        // @property (readonly, nonatomic) int64_t fileSizeLimit;
        [Export("fileSizeLimit")]
        long FileSizeLimit { get; }

        // @property (readonly, nonatomic) BOOL isFileSendingEnabled;
        [Export("isFileSendingEnabled")]
        bool IsFileSendingEnabled { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull supportedFileTypes;
        [Export("supportedFileTypes", ArgumentSemantic.Copy)]
        string[] SupportedFileTypes { get; }

        // -(instancetype _Nonnull)initWithFileSizeLimit:(int64_t)fileSizeLimit isFileSendingEnabled:(BOOL)isFileSendingEnabled supportedFileTypes:(NSArray<NSString *> * _Nonnull)supportedFileTypes __attribute__((objc_designated_initializer));
        [Export("initWithFileSizeLimit:isFileSendingEnabled:supportedFileTypes:")]
        [DesignatedInitializer]
        IntPtr Constructor(long fileSizeLimit, bool isFileSendingEnabled, string[] supportedFileTypes);

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }
    }

    // @interface ZDKChatState : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKChatState
    {
        // @property (readonly, nonatomic, strong, class) ZDKChatState * _Nonnull initial;
        [Static]
        [Export("initial", ArgumentSemantic.Strong)]
        ZDKChatState Initial { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull comment;
        [Export("comment")]
        string Comment { get; }

        // @property (readonly, nonatomic) enum ZDKRating ratingValue;
        [Export("ratingValue")]
        ZDKRating RatingValue { get; }

        // @property (readonly, copy, nonatomic) NSArray<ZDKAgent *> * _Nonnull agents;
        [Export("agents", ArgumentSemantic.Copy)]
        ZDKAgent[] Agents { get; }

        // @property (readonly, nonatomic) BOOL isChatting;
        [Export("isChatting")]
        bool IsChatting { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable chatId;
        [NullAllowed, Export("chatId")]
        string ChatId { get; }

        // @property (readonly, nonatomic, strong) ZDKDepartment * _Nullable department;
        [NullAllowed, Export("department", ArgumentSemantic.Strong)]
        ZDKDepartment Department { get; }

        // @property (readonly, copy, nonatomic) NSArray<ZDKChatLog *> * _Nonnull logs;
        [Export("logs", ArgumentSemantic.Copy)]
        ZDKChatLog[] Logs { get; }

        // @property (nonatomic, strong) ZDKQueuePosition * _Nonnull queuePosition;
        [Export("queuePosition", ArgumentSemantic.Strong)]
        ZDKQueuePosition QueuePosition { get; set; }

        // @property (readonly, nonatomic) enum ChatSessionStatus chatSessionStatus;
        [Export("chatSessionStatus")]
        ChatSessionStatus ChatSessionStatus { get; }

        // -(ZDKChatLog * _Nullable)logWithId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
        [Export("logWithId:")]
        [return: NullAllowed]
        ZDKChatLog LogWithId(string id);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }

        // -(instancetype _Nonnull)initWithAgents:(NSArray<ZDKAgent *> * _Nonnull)agents isChatting:(BOOL)isChatting chatId:(NSString * _Nullable)chatId department:(ZDKDepartment * _Nullable)department logs:(NSArray<ZDKChatLog *> * _Nonnull)logs queue:(NSInteger)queue comment:(NSString * _Nonnull)comment rating:(enum ZDKRating)rating;
        [Export("initWithAgents:isChatting:chatId:department:logs:queue:comment:rating:")]
        IntPtr Constructor(ZDKAgent[] agents, bool isChatting, [NullAllowed] string chatId, [NullAllowed] ZDKDepartment department, ZDKChatLog[] logs, nint queue, string comment, ZDKRating rating);

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);
    }

    // @interface ZDKConnectionProvider : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKConnectionProvider
    {
        // @property (readonly, nonatomic) enum ZDKConnectionStatus status;
        [Export("status")]
        ZDKConnectionStatus Status { get; }

        // -(void)connect;
        [Export("connect")]
        void Connect();

        // -(void)disconnect;
        [Export("disconnect")]
        void Disconnect();

        // -(ZDKObservationToken * _Nonnull)observeConnectionStatusWithIdentifier:(NSString * _Nonnull)identifier :(void (^ _Nonnull)(enum ZDKConnectionStatus))completion __attribute__((warn_unused_result("")));
        [Export("observeConnectionStatusWithIdentifier::")]
        ZDKObservationToken ObserveConnectionStatusWithIdentifier(string identifier, Action<ZDKConnectionStatus> completion);

        // -(ZDKObservationToken * _Nonnull)observeConnectionStatus:(void (^ _Nonnull)(enum ZDKConnectionStatus))completion __attribute__((warn_unused_result("")));
        [Export("observeConnectionStatus:")]
        ZDKObservationToken ObserveConnectionStatus(Action<ZDKConnectionStatus> completion);
    }

    // @interface ZDKDepartment : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKDepartment
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, nonatomic) enum ZDKDepartmentStatus departmentStatus;
        [Export("departmentStatus")]
        ZDKDepartmentStatus DepartmentStatus { get; }

        // -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id name:(NSString * _Nonnull)name departmentStatus:(enum ZDKDepartmentStatus)departmentStatus;
        [Export("initWithId:name:departmentStatus:")]
        IntPtr Constructor(string id, string name, ZDKDepartmentStatus departmentStatus);

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ZDKJWTAuthenticator
    {
        // @required -(void)getToken:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
        [Abstract]
        [Export("getToken:")]
        void GetToken(Action<NSString, NSError> completion);
    }

    // @interface ZDKChatLogger : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDKChatLogger
    {
        // @property (nonatomic, class) enum ZDKChatLogLevel defaultLevel;
        [Static]
        [Export("defaultLevel", ArgumentSemantic.Assign)]
        ZDKChatLogLevel DefaultLevel { get; set; }

        // @property (nonatomic, class) BOOL isEnabled;
        [Static]
        [Export("isEnabled")]
        bool IsEnabled { get; set; }
    }

    // @interface ZDKOfflineForm : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKOfflineForm
    {
        // @property (readonly, nonatomic, strong) ZDKVisitorInfo * _Nullable visitorInfo;
        [NullAllowed, Export("visitorInfo", ArgumentSemantic.Strong)]
        ZDKVisitorInfo VisitorInfo { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable departmentId;
        [NullAllowed, Export("departmentId")]
        string DepartmentId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull message;
        [Export("message")]
        string Message { get; }

        // -(instancetype _Nonnull)initWithVisitorInfo:(ZDKVisitorInfo * _Nullable)visitorInfo departmentId:(NSString * _Nullable)departmentId message:(NSString * _Nonnull)message __attribute__((objc_designated_initializer));
        [Export("initWithVisitorInfo:departmentId:message:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] ZDKVisitorInfo visitorInfo, [NullAllowed] string departmentId, string message);

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);
    }

    // @interface ZDKProfileProvider : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKProfileProvider
    {
        // @property (readonly, nonatomic, strong) ZDKVisitorInfo * _Nonnull visitorInfo;
        [Export("visitorInfo", ArgumentSemantic.Strong)]
        ZDKVisitorInfo VisitorInfo { get; }

        // -(void)setVisitorInfo:(ZDKVisitorInfo * _Nonnull)visitorInfo completion:(void (^ _Nullable)(ZDKVisitorInfo * _Nullable, NSError * _Nullable))completion;
        [Export("setVisitorInfo:completion:")]
        void SetVisitorInfo(ZDKVisitorInfo visitorInfo, [NullAllowed] Action<ZDKVisitorInfo, NSError> completion);

        // -(void)trackVisitorPath:(ZDKVisitorPath * _Nonnull)visitorPath completion:(void (^ _Nullable)(ZDKVisitorPath * _Nullable, NSError * _Nullable))completion;
        [Export("trackVisitorPath:completion:")]
        void TrackVisitorPath(ZDKVisitorPath visitorPath, [NullAllowed] Action<ZDKVisitorPath, NSError> completion);

        // -(void)addTags:(NSArray<NSString *> * _Nonnull)tags completion:(void (^ _Nullable)(NSArray<NSString *> * _Nullable, NSError * _Nullable))completion;
        [Export("addTags:completion:")]
        void AddTags(string[] tags, [NullAllowed] Action<NSArray<NSString>, NSError> completion);

        // -(void)removeTags:(NSArray<NSString *> * _Nonnull)tags completion:(void (^ _Nullable)(NSArray<NSString *> * _Nullable, NSError * _Nullable))completion;
        [Export("removeTags:completion:")]
        void RemoveTags(string[] tags, [NullAllowed] Action<NSArray<NSString>, NSError> completion);

        // -(void)appendNote:(NSString * _Nonnull)note completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("appendNote:completion:")]
        void AppendNote(string note, [NullAllowed] Action<NSString, NSError> completion);

        // -(void)setNote:(NSString * _Nonnull)note completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("setNote:completion:")]
        void SetNote(string note, [NullAllowed] Action<NSString, NSError> completion);

        // -(ZDKObservationToken * _Nonnull)observeVisitorInfo:(void (^ _Nonnull)(ZDKVisitorInfo * _Nonnull))completion __attribute__((warn_unused_result("")));
        [Export("observeVisitorInfo:")]
        ZDKObservationToken ObserveVisitorInfo(Action<ZDKVisitorInfo> completion);

        // -(ZDKObservationToken * _Nonnull)observeVisitorInfoWithIdentifier:(NSString * _Nonnull)identifier :(void (^ _Nonnull)(ZDKVisitorInfo * _Nonnull))completion __attribute__((warn_unused_result("")));
        [Export("observeVisitorInfoWithIdentifier::")]
        ZDKObservationToken ObserveVisitorInfoWithIdentifier(string identifier, Action<ZDKVisitorInfo> completion);
    }

    // @interface ZDKChatProviders : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKChatProviders
    {
        // @property (readonly, nonatomic, strong) ZDKChatAccountProvider * _Nonnull accountProvider;
        [Export("accountProvider", ArgumentSemantic.Strong)]
        ZDKChatAccountProvider AccountProvider { get; }

        // @property (readonly, nonatomic, strong) ZDKConnectionProvider * _Nonnull connectionProvider;
        [Export("connectionProvider", ArgumentSemantic.Strong)]
        ZDKConnectionProvider ConnectionProvider { get; }

        // @property (readonly, nonatomic, strong) ZDKProfileProvider * _Nonnull profileProvider;
        [Export("profileProvider", ArgumentSemantic.Strong)]
        ZDKProfileProvider ProfileProvider { get; }

        // @property (readonly, nonatomic, strong) ZDKPushNotificationsProvider * _Nonnull pushNotificationsProvider;
        [Export("pushNotificationsProvider", ArgumentSemantic.Strong)]
        ZDKPushNotificationsProvider PushNotificationsProvider { get; }

        // @property (readonly, nonatomic, strong) ZDKChatProvider * _Nonnull chatProvider;
        [Export("chatProvider", ArgumentSemantic.Strong)]
        ZDKChatProvider ChatProvider { get; }

        // @property (readonly, nonatomic, strong) ZDKSettingsProvider * _Nonnull settingsProvider;
        [Export("settingsProvider", ArgumentSemantic.Strong)]
        ZDKSettingsProvider SettingsProvider { get; }
    }

    // @interface ZDKPushNotificationData : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKPushNotificationData
    {
        // @property (readonly, nonatomic) enum ZDKPushNotificationType type;
        [Export("type")]
        ZDKPushNotificationType Type { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull userInfo;
        [Export("userInfo", ArgumentSemantic.Copy)]
        NSDictionary UserInfo { get; }

        // +(ZDKPushNotificationData * _Nullable)dataFor:(NSDictionary * _Nonnull)userInfo __attribute__((warn_unused_result("")));
        [Static]
        [Export("dataFor:")]
        [return: NullAllowed]
        ZDKPushNotificationData DataFor(NSDictionary userInfo);

        // +(BOOL)isChatPushNotificationWithUserInfo:(NSDictionary * _Nonnull)userInfo __attribute__((warn_unused_result("")));
        [Static]
        [Export("isChatPushNotificationWithUserInfo:")]
        bool IsChatPushNotificationWithUserInfo(NSDictionary userInfo);

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);
    }

    // @interface ZDKPushNotificationsProvider : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKPushNotificationsProvider
    {
        // @property (readonly, nonatomic, class) NSNotificationName _Nonnull ChatMessageReceivedNotification;
        [Static]
        [Export("ChatMessageReceivedNotification")]
        string ChatMessageReceivedNotification { get; }

        // -(void)unregisterPushToken;
        [Export("unregisterPushToken")]
        void UnregisterPushToken();

        // -(void)didReceiveRemoteNotification:(NSDictionary * _Nonnull)userInfo in:(UIApplication * _Nonnull)application;
        [Export("didReceiveRemoteNotification:in:")]
        void DidReceiveRemoteNotification(NSDictionary userInfo, UIApplication application);

        // -(BOOL)isChatPushNotification:(NSDictionary * _Nonnull)userInfo __attribute__((warn_unused_result("")));
        [Export("isChatPushNotification:")]
        bool IsChatPushNotification(NSDictionary userInfo);

        // -(void)registerPushToken:(NSData * _Nonnull)pushTokenData;
        [Export("registerPushToken:")]
        void RegisterPushToken(NSData pushTokenData);

        // -(void)registerPushTokenString:(NSString * _Nonnull)pushTokenString;
        [Export("registerPushTokenString:")]
        void RegisterPushTokenString(string pushTokenString);
    }

    // @interface ZDKQueuePosition : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKQueuePosition
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (nonatomic) NSInteger queue;
        [Export("queue")]
        nint Queue { get; set; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);
    }

    // @interface ZDKSettingsProvider : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKSettingsProvider
    {
        // @property (readonly, nonatomic, strong) ZDKChatSettings * _Nonnull settings;
        [Export("settings", ArgumentSemantic.Strong)]
        ZDKChatSettings Settings { get; }

        // -(ZDKObservationToken * _Nonnull)observeChatSettingsWithIdentifier:(NSString * _Nonnull)identifier :(void (^ _Nonnull)(ZDKChatSettings * _Nonnull))completion __attribute__((warn_unused_result("")));
        [Export("observeChatSettingsWithIdentifier::")]
        ZDKObservationToken ObserveChatSettingsWithIdentifier(string identifier, Action<ZDKChatSettings> completion);

        // -(ZDKObservationToken * _Nonnull)observeChatSettings:(void (^ _Nonnull)(ZDKChatSettings * _Nonnull))completion __attribute__((warn_unused_result("")));
        [Export("observeChatSettings:")]
        ZDKObservationToken ObserveChatSettings(Action<ZDKChatSettings> completion);
    }

    // @interface ZDKVisitorInfo : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKVisitorInfo
    {
        // @property (readonly, nonatomic, strong, class) ZDKVisitorInfo * _Nonnull initial;
        [Static]
        [Export("initial", ArgumentSemantic.Strong)]
        ZDKVisitorInfo Initial { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull email;
        [Export("email")]
        string Email { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull phoneNumber;
        [Export("phoneNumber")]
        string PhoneNumber { get; }

        // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name email:(NSString * _Nonnull)email phoneNumber:(NSString * _Nonnull)phoneNumber;
        [Export("initWithName:email:phoneNumber:")]
        IntPtr Constructor(string name, string email, string phoneNumber);

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        [Override]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        [Override]
        string DebugDescription { get; }
    }

    // @interface ZDKVisitorPath : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKVisitorPath
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull url;
        [Export("url")]
        string Url { get; }

        // -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title url:(NSString * _Nonnull)url __attribute__((objc_designated_initializer));
        [Export("initWithTitle:url:")]
        [DesignatedInitializer]
        IntPtr Constructor(string title, string url);

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
    }
}
