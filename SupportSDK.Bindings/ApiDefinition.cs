using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using SupportSDK;
using UIKit;
using ZendeskCoreSDK.Bindings;
using MessagingAPI.Bindings;
using SupportProvidersSDK.Bindings;
using SDKConfigurations.Bindings;

namespace SupportSDK.Bindings
{
    // @interface ZDKArticleUiConfiguration : NSObject
    [BaseType(typeof(ZDKConfiguration))]
    interface ZDKArticleUiConfiguration
    {
        // @property (nonatomic) BOOL showContactOptions;
        [Export("showContactOptions")]
        bool ShowContactOptions { get; set; }

        // @property (copy, nonatomic) NSArray<id<ZDKEngine>> * _Nonnull objcEngines;
        [Export("objcEngines", ArgumentSemantic.Copy)]
        IZDKEngine[] ObjcEngines { get; set; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ZDKContainerChild
    {
        [Wrap("WeakChildDelegate")]
        [NullAllowed]
        ZDKContainerChildControllerDelegate ChildDelegate { get; set; }

        // @required @property (nonatomic, strong) id<ZDKContainerChildControllerDelegate> _Nullable childDelegate;
        [NullAllowed, Export("childDelegate", ArgumentSemantic.Strong)]
        NSObject WeakChildDelegate { get; set; }
    }

    // @protocol ZDKContainerChildControllerDelegate <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface ZDKContainerChildControllerDelegate
    {
        // @required -(void)willDismiss;
        [Abstract]
        [Export("willDismiss")]
        void WillDismiss();

        // @required @property (readonly, nonatomic, strong) UINavigationItem * _Nullable navItem;
        [Abstract]
        [NullAllowed, Export("navItem", ArgumentSemantic.Strong)]
        UINavigationItem NavItem { get; }
    }

    // @interface ContainerViewController : UIViewController
    [BaseType(typeof(UIViewController), Name = "_TtC10SupportSDK23ContainerViewController")]
    interface ContainerViewController : ZDKContainerChildControllerDelegate
    {
        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        [Override]
        void ViewDidLoad();

        // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
        [Export("initWithNibName:bundle:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

        // @property (readonly, nonatomic, strong) UINavigationItem * _Nullable navItem;
        [NullAllowed, Export("navItem", ArgumentSemantic.Strong)]
        UINavigationItem NavItem { get; }

        // -(void)willDismiss;
        [Export("willDismiss")]
        void WillDismiss();
    }

    // @interface ZDKCoordinatingViewController : ContainerViewController
    [BaseType(typeof(ContainerViewController))]
    interface ZDKCoordinatingViewController
    {
        // -(instancetype _Nonnull)initWithCoordinator:(id<ZDKCoordinator> _Nonnull)coordinator __attribute__((objc_designated_initializer));
        [Export("initWithCoordinator:")]
        [DesignatedInitializer]
        IntPtr Constructor(ZDKCoordinator coordinator);

        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        [Override]
        void ViewDidLoad();

        // -(void)viewWillAppear:(BOOL)animated;
        [Export("viewWillAppear:")]
        [Override]
        void ViewWillAppear(bool animated);

        // -(void)viewDidAppear:(BOOL)animated;
        [Export("viewDidAppear:")]
        [Override]
        void ViewDidAppear(bool animated);

        // -(void)viewDidDisappear:(BOOL)animated;
        [Export("viewDidDisappear:")]
        [Override]
        void ViewDidDisappear(bool animated);
    }

    [BaseType(typeof(NSObject))]
    [Protocol, Model]
    interface ZDKCoordinator
    {
        // @required -(void)startWithPresent:(void (^ _Nonnull)(UIViewController<ZDKContainerChild> * _Nonnull))present with:(id<ZDKContainerChildControllerDelegate> _Nonnull)containerDelegate;
        [Abstract]
        [Export("startWithPresent:with:")]
        void StartWithPresent(Action<ZDKContainerChild> present, ZDKContainerChildControllerDelegate containerDelegate);
    }

    interface IZDKCoordinator { }

    // @interface ZDKDismissUtil : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDKDismissUtil
    {
        // +(void)remove:(UIViewController * _Nullable)viewController from:(UINavigationController * _Nullable)navigationController;
        [Static]
        [Export("remove:from:")]
        void Remove([NullAllowed] UIViewController viewController, [NullAllowed] UINavigationController navigationController);

        // +(BOOL)navigationController:(UINavigationController * _Nullable)navigationController didPush:(UIViewController * _Nullable)viewController __attribute__((warn_unused_result("")));
        [Static]
        [Export("navigationController:didPush:")]
        bool NavigationController([NullAllowed] UINavigationController navigationController, [NullAllowed] UIViewController viewController);

        // +(UIBarButtonItem * _Nonnull)barButtonFor:(UIViewController * _Nonnull)viewController embededIn:(UINavigationController * _Nullable)navigationController action:(SEL _Nonnull)action __attribute__((warn_unused_result("")));
        [Static]
        [Export("barButtonFor:embededIn:action:")]
        UIBarButtonItem BarButtonFor(UIViewController viewController, [NullAllowed] UINavigationController navigationController, Selector action);
    }

    // @interface HelpCenterArticleVotingHandler : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10SupportSDK30HelpCenterArticleVotingHandler")]
    [DisableDefaultCtor]
    interface HelpCenterArticleVotingHandler
    {
        // -(instancetype _Nonnull)initWithArticleId:(NSString * _Nonnull)articleId andLocale:(NSString * _Nonnull)locale;
        [Export("initWithArticleId:andLocale:")]
        IntPtr Constructor(string articleId, string locale);

        // -(void)articleRatingVoteSelected:(id<ZDKHelpCenterArticleRatingStateProtocol> _Nonnull)ratingState atIndex:(NSInteger)index;
        [Export("articleRatingVoteSelected:atIndex:")]
        void ArticleRatingVoteSelected(ZDKHelpCenterArticleRatingStateProtocol ratingState, nint index);

        // -(NSInteger)currentArticleVote __attribute__((warn_unused_result("")));
        [Export("currentArticleVote")]
        nint CurrentArticleVote { get; }
    }

    // @interface ZDKHelpCenterContactUsRouter : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKHelpCenterContactUsRouter
    {
        // -(instancetype _Nonnull)initWithPresentingViewController:(UIViewController * _Nonnull)presentingViewController configurations:(NSArray<id> * _Nonnull)configurations engines:(NSArray<id<ZDKEngine>> * _Nonnull)engines __attribute__((objc_designated_initializer));
        [Export("initWithPresentingViewController:configurations:engines:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIViewController presentingViewController, NSObject[] configurations, IZDKEngine[] engines);

        // -(void)decideButtonActionForNavBar;
        [Export("decideButtonActionForNavBar")]
        void DecideButtonActionForNavBar();

        // -(void)decideButtonActionForEmptySearch;
        [Export("decideButtonActionForEmptySearch")]
        void DecideButtonActionForEmptySearch();
    }

    // @interface ZDKHelpCenterCoordinator : NSObject <ZDKCoordinator>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKHelpCenterCoordinator : ZDKCoordinator
    {
        // -(instancetype _Nonnull)initWithHelpCenterController:(UIViewController<ZDKContainerChild> * _Nonnull)helpCenterController uiConfigurations:(NSArray<id> * _Nonnull)uiConfigurations __attribute__((objc_designated_initializer));
        [Export("initWithHelpCenterController:uiConfigurations:")]
        [DesignatedInitializer]
        IntPtr Constructor(ZDKContainerChild helpCenterController, NSObject[] uiConfigurations);

        // -(void)startWithPresent:(void (^ _Nonnull)(UIViewController<ZDKContainerChild> * _Nonnull))present with:(id<ZDKContainerChildControllerDelegate> _Nonnull)containerDelegate;
        [Export("startWithPresent:with:")]
        void StartWithPresent(Action<ZDKContainerChild> present, ZDKContainerChildControllerDelegate containerDelegate);
    }

    // @interface ZDKHelpCenterUiConfiguration : NSObject
    [BaseType(typeof(ZDKConfiguration))]
    interface ZDKHelpCenterUiConfiguration
    {
        // @property (copy, nonatomic) NSArray<NSString *> * _Nonnull labels;
        [Export("labels", ArgumentSemantic.Copy)]
        string[] Labels { get; set; }

        // @property (nonatomic) int groupType;
        [Export("groupType")]
        int GroupType { get; set; }

        // @property (nonatomic) BOOL showContactOptions;
        [Export("showContactOptions")]
        bool ShowContactOptions { get; set; }

        // @property (nonatomic) BOOL showContactOptionsOnEmptySearch;
        [Export("showContactOptionsOnEmptySearch")]
        bool ShowContactOptionsOnEmptySearch { get; set; }

        // @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull groupIds;
        [Export("groupIds", ArgumentSemantic.Copy)]
        NSNumber[] GroupIds { get; set; }

        // @property (copy, nonatomic) NSArray<id<ZDKEngine>> * _Nonnull objcEngines;
        [Export("objcEngines", ArgumentSemantic.Copy)]
        IZDKEngine[] ObjcEngines { get; set; }

        // @property (readonly, nonatomic, strong) ZDKHelpCenterOverviewContentModel * _Nonnull overviewContentModel;
        [Export("overviewContentModel", ArgumentSemantic.Strong)]
        ZDKHelpCenterOverviewContentModel OverviewContentModel { get; }
    }

    // @interface ZDKRequestAttachment : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKRequestAttachment
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull filename;
        [Export("filename")]
        string Filename { get; }

        // @property (readonly, copy, nonatomic) NSData * _Nonnull data;
        [Export("data", ArgumentSemantic.Copy)]
        NSData Data { get; }

        // @property (readonly, nonatomic) enum ZDKFileType fileType;
        [Export("fileType")]
        ZDKFileType FileType { get; }

        // -(instancetype _Nonnull)initWithFilename:(NSString * _Nonnull)filename data:(NSData * _Nonnull)data fileType:(enum ZDKFileType)fileType __attribute__((objc_designated_initializer));
        [Export("initWithFilename:data:fileType:")]
        [DesignatedInitializer]
        IntPtr Constructor(string filename, NSData data, ZDKFileType fileType);
    }

    // @interface RequestCoordinator : NSObject <ZDKCoordinator>
    [BaseType(typeof(NSObject), Name = "_TtC10SupportSDK18RequestCoordinator")]
    [DisableDefaultCtor]
    interface RequestCoordinator : ZDKCoordinator
    {
        // -(void)startWithPresent:(void (^ _Nonnull)(UIViewController<ZDKContainerChild> * _Nonnull))present with:(id<ZDKContainerChildControllerDelegate> _Nonnull)containerDelegate;
        [Export("startWithPresent:with:")]
        void StartWithPresent(Action<ZDKContainerChild> present, ZDKContainerChildControllerDelegate containerDelegate);
    }

    // @interface ZDKRequestListUiConfiguration : NSObject
    [BaseType(typeof(ZDKConfiguration))]
    interface ZDKRequestListUiConfiguration
    {
        // @property (nonatomic) BOOL allowRequestCreation;
        [Export("allowRequestCreation")]
        bool AllowRequestCreation { get; set; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);
    }

    // @interface ZDKRequestUi : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDKRequestUi
    {
        // +(UIViewController * _Nonnull)buildRequestList __attribute__((warn_unused_result("")));
        [Static]
        [Export("buildRequestList")]
        UIViewController BuildRequestList();

        // +(UIViewController * _Nonnull)buildRequestListWith:(NSArray<id> * _Nonnull)configurations __attribute__((warn_unused_result("")));
        [Static]
        [Export("buildRequestListWith:")]
        UIViewController BuildRequestListWith(NSObject[] configurations);

        // +(UIViewController * _Nonnull)buildRequestUi __attribute__((warn_unused_result("")));
        [Static]
        [Export("buildRequestUi")]
        UIViewController BuildRequestUi();

        // +(UIViewController * _Nonnull)buildRequestUiWith:(NSArray<id> * _Nonnull)configurations __attribute__((warn_unused_result("")));
        [Static]
        [Export("buildRequestUiWith:")]
        UIViewController BuildRequestUiWith(NSObject[] configurations);

        // +(UIViewController * _Nonnull)buildRequestUiWithRequestId:(NSString * _Nonnull)requestId __attribute__((warn_unused_result("")));
        [Static]
        [Export("buildRequestUiWithRequestId:")]
        UIViewController BuildRequestUiWithRequestId(string requestId);

        // +(UIViewController * _Nonnull)buildRequestUiWithRequestId:(NSString * _Nonnull)requestId configurations:(NSArray<id> * _Nonnull)configurations __attribute__((warn_unused_result("")));
        [Static]
        [Export("buildRequestUiWithRequestId:configurations:")]
        UIViewController BuildRequestUiWithRequestId(string requestId, NSObject[] configurations);
    }

    // @interface ZDKRequestUiConfiguration : NSObject
    [BaseType(typeof(ZDKConfiguration))]
    interface ZDKRequestUiConfiguration
    {
        // @property (copy, nonatomic) NSString * _Nonnull subject;
        [Export("subject")]
        string Subject { get; set; }

        // @property (copy, nonatomic) NSArray<NSString *> * _Nonnull tags;
        [Export("tags", ArgumentSemantic.Copy)]
        string[] Tags { get; set; }

        // @property (copy, nonatomic) NSArray<ZDKCustomField *> * _Nonnull customFields;
        [Export("customFields", ArgumentSemantic.Copy)]
        ZDKCustomField[] CustomFields { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable ticketFormID;
        [NullAllowed, Export("ticketFormID", ArgumentSemantic.Strong)]
        NSNumber TicketFormID { get; set; }

        // @property (copy, nonatomic) NSArray<ZDKRequestAttachment *> * _Nonnull fileAttachments;
        [Export("fileAttachments", ArgumentSemantic.Copy)]
        ZDKRequestAttachment[] FileAttachments { get; set; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);
    }

    // @interface ZDKSuasDebugLogger : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDKSuasDebugLogger
    {
        // @property (nonatomic, class) BOOL enabled;
        [Static]
        [Export("enabled")]
        bool Enabled { get; set; }
    }

    // @interface ZDKSupportEngine : NSObject <ZDKEngine>
    [BaseType(typeof(ZDKEngine))]
    [DisableDefaultCtor]
    interface ZDKSupportEngine
    {
        // -(void)isConversationOngoing:(void (^ _Nonnull)(BOOL))completion;
        [Export("isConversationOngoing:")]
        void IsConversationOngoing(Action<bool> completion);

        // +(ZDKSupportEngine * _Nullable)engineAndReturnError:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
        [Static]
        [Export("engineAndReturnError:")]
        [return: NullAllowed]
        ZDKSupportEngine EngineAndReturnError([NullAllowed] out NSError error);
    }

    // @interface ZDKSupportUI : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKSupportUI
    {
        // @property (copy, nonatomic) NSString * _Nullable helpCenterLocaleOverride;
        [NullAllowed, Export("helpCenterLocaleOverride")]
        string HelpCenterLocaleOverride { get; set; }

        // +(void)initializeWithZendesk:(ZDKZendesk * _Nullable)zendesk;
        [Static]
        [Export("initializeWithZendesk:")]
        void InitializeWithZendesk([NullAllowed] ZDKZendesk zendesk);

        // @property (readonly, nonatomic, strong, class) ZDKSupportUI * _Nullable instance;
        [Static]
        [NullAllowed, Export("instance", ArgumentSemantic.Strong)]
        ZDKSupportUI Instance { get; }

        // -(BOOL)refreshRequestWithRequestId:(NSString * _Nonnull)requestId __attribute__((warn_unused_result("")));
        [Export("refreshRequestWithRequestId:")]
        bool RefreshRequestWithRequestId(string requestId);
    }

    // @interface ZDKTheme : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDKTheme
    {
        // @property (readonly, nonatomic, strong, class) ZDKTheme * _Nonnull currentTheme;
        [Static]
        [Export("currentTheme", ArgumentSemantic.Strong)]
        ZDKTheme CurrentTheme { get; }

        // @property (nonatomic, strong) UIColor * _Nonnull primaryColor;
        [Export("primaryColor", ArgumentSemantic.Strong)]
        UIColor PrimaryColor { get; set; }
    }

    // @interface ZDKConstants : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10SupportSDK12ZDKConstants")]
    interface ZDKConstants
    {
        // +(UIColor * _Nonnull)colorForToast __attribute__((warn_unused_result("")));
        [Static]
        [Export("colorForToast")]
        UIColor ColorForToast { get; }
    }

    // @protocol ZDKCreateRequestUIDelegate <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface ZDKCreateRequestUIDelegate
    {
        // @required -(ZDKNavBarCreateRequestUIType)navBarCreateRequestUIType;
        [Abstract]
        [Export("navBarCreateRequestUIType")]
        ZDKNavBarCreateRequestUIType NavBarCreateRequestUIType();

        // @required -(UIImage *)createRequestBarButtonImage;
        [Abstract]
        [Export("createRequestBarButtonImage")]
        UIImage CreateRequestBarButtonImage();

        // @required -(NSString *)createRequestBarButtonLocalizedLabel;
        [Abstract]
        [Export("createRequestBarButtonLocalizedLabel")]
        string CreateRequestBarButtonLocalizedLabel();
    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    interface ZDKHelpCenterArticleRatingStateProtocol
    {
        // @required -(void)updateButtonStatesForButtonAtIndexSelected:(NSUInteger)index;
        [Abstract]
        [Export("updateButtonStatesForButtonAtIndexSelected:")]
        void UpdateButtonStatesForButtonAtIndexSelected(nuint index);
    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    interface ZDKHelpCenterArticleRatingHandlerProtocol
    {
        // @required -(NSInteger)currentArticleVote;
        [Abstract]
        [Export("currentArticleVote")]
        nint CurrentArticleVote { get; }

        // @required -(void)articleRatingVoteSelected:(id<ZDKHelpCenterArticleRatingStateProtocol>)ratingState atIndex:(NSInteger)index;
        [Abstract]
        [Export("articleRatingVoteSelected:atIndex:")]
        void AtIndex(ZDKHelpCenterArticleRatingStateProtocol ratingState, nint index);
    }

    // @interface ZDKHelpCenterAttachmentsDataSource
    interface ZDKHelpCenterAttachmentsDataSource
    {
        // -(instancetype)initWithArticleId:(NSNumber *)articleId;
        [Export("initWithArticleId:")]
        IntPtr Constructor(NSNumber articleId);
    }

    // @protocol ZDKHelpCenterConversationsUIDelegate <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface ZDKHelpCenterConversationsUIDelegate
    {
        // @required -(id)navBarConversationsUIType;
        [Abstract]
        [Export("navBarConversationsUIType")]
        NSObject NavBarConversationsUIType { get; }

        // @required -(ZDKContactUsVisibility)active;
        [Abstract]
        [Export("active")]
        ZDKContactUsVisibility Active { get; }

        // @optional -(NSString *)conversationsBarButtonLocalizedLabel;
        [Export("conversationsBarButtonLocalizedLabel")]
        string ConversationsBarButtonLocalizedLabel { get; }

        // @optional -(UIImage *)conversationsBarButtonImage;
        [Export("conversationsBarButtonImage")]
        UIImage ConversationsBarButtonImage { get; }
    }

    // @protocol ZDKHelpCenterDelegate <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface ZDKHelpCenterDelegate
    {
        [Wrap("WeakUiDelegate")]
        ZDKHelpCenterConversationsUIDelegate UiDelegate { get; set; }

        // @required @property (nonatomic, weak) id<ZDKHelpCenterConversationsUIDelegate> uiDelegate;
        [NullAllowed, Export("uiDelegate", ArgumentSemantic.Weak)]
        NSObject WeakUiDelegate { get; set; }
    }

    // typedef void (^ZDKHelpCenterCellConfigureBlock)(id, id);
    delegate void ZDKHelpCenterCellConfigureBlock(NSObject arg0, NSObject arg1);

    // @interface ZDKHelpCenterDataSource : NSObject <UITableViewDataSource>
    [BaseType(typeof(NSObject))]
    interface ZDKHelpCenterDataSource : IUITableViewDataSource
    {
        // @property (readonly, assign, nonatomic) BOOL hasItems;
        [Export("hasItems")]
        bool HasItems { get; }

        // @property (readonly, copy, nonatomic) NSArray * items;
        [Export("items", ArgumentSemantic.Copy)]
        NSObject[] Items { get; }

        // @property (readonly, nonatomic, strong) ZDKHelpCenterProvider * provider;
        [Export("provider", ArgumentSemantic.Strong)]
        ZDKHelpCenterProvider Provider { get; }

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();

        // -(id)itemAtIndexPath:(NSIndexPath *)indexPath;
        [Export("itemAtIndexPath:")]
        NSObject ItemAtIndexPath(NSIndexPath indexPath);

        // +(NSString *)cellIdentifierForDataSource;
        [Static]
        [Export("cellIdentifierForDataSource")]
        string CellIdentifierForDataSource { get; }
    }

    [Static]
    partial interface ZDKHelpCenterErrorCodes
    {
        // extern NSString *const ZDKHelpCenterErrorDomain;
        [Field("ZDKHelpCenterErrorDomain", "__Internal")]
        NSString ZDKHelpCenterErrorDomain { get; }

        // extern NSString *const ZDKHelpCenterNoCategoriesLocalisedDescription;
        [Field("ZDKHelpCenterNoCategoriesLocalisedDescription", "__Internal")]
        NSString ZDKHelpCenterNoCategoriesLocalisedDescription { get; }

        // extern NSString *const ZDKHelpCenterNoSectionsLocalisedDescription;
        [Field("ZDKHelpCenterNoSectionsLocalisedDescription", "__Internal")]
        NSString ZDKHelpCenterNoSectionsLocalisedDescription { get; }

        // extern NSString *const ZDKHelpCenterNoArticlesForLabelsDescription;
        [Field("ZDKHelpCenterNoArticlesForLabelsDescription", "__Internal")]
        NSString ZDKHelpCenterNoArticlesForLabelsDescription { get; }

        // extern NSString *const ZDKHelpCenterEmptyHelpCenterDescription;
        [Field("ZDKHelpCenterEmptyHelpCenterDescription", "__Internal")]
        NSString ZDKHelpCenterEmptyHelpCenterDescription { get; }
    }

    // @interface ZDKHelpCenterUi : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDKHelpCenterUi
    {
        // +(UIViewController * _Nonnull)buildHelpCenterOverviewUi;
        [Static]
        [Export("buildHelpCenterOverviewUi")]
        UIViewController BuildHelpCenterOverviewUi();

        // +(UIViewController<ZDKHelpCenterDelegate> * _Nonnull)buildHelpCenterOverview __attribute__((deprecated("use buildHelpCenterOverviewUi instead")));
        [Static]
        [Export("buildHelpCenterOverview")]
        ZDKHelpCenterDelegate BuildHelpCenterOverview();

        // +(UIViewController * _Nonnull)buildHelpCenterOverviewUiWithConfigs:(NSArray<id<ZDKConfiguration>> * _Nonnull)configs;
        [Static]
        [Export("buildHelpCenterOverviewUiWithConfigs:")]
        UIViewController BuildHelpCenterOverviewUiWithConfigs(ZDKConfiguration[] configs);

        // +(UIViewController<ZDKHelpCenterDelegate> * _Nonnull)buildHelpCenterOverviewWithConfigs:(NSArray<id<ZDKConfiguration>> * _Nonnull)configs __attribute__((deprecated("use buildHelpCenterOverviewUiWithConfigs instead")));
        [Static]
        [Export("buildHelpCenterOverviewWithConfigs:")]
        ZDKHelpCenterDelegate BuildHelpCenterOverviewWithConfigs(ZDKConfiguration[] configs);

        // +(UIViewController * _Nonnull)buildHelpCenterArticleUi:(ZDKHelpCenterArticle * _Nonnull)article;
        [Static]
        [Export("buildHelpCenterArticleUi:")]
        UIViewController BuildHelpCenterArticleUi(ZDKHelpCenterArticle article);

        // +(UIViewController<ZDKHelpCenterDelegate> * _Nonnull)buildHelpCenterArticle:(ZDKHelpCenterArticle * _Nonnull)article __attribute__((deprecated("use buildHelpCenterArticleUi instead")));
        [Static]
        [Export("buildHelpCenterArticle:")]
        ZDKHelpCenterDelegate BuildHelpCenterArticle(ZDKHelpCenterArticle article);

        // +(UIViewController * _Nonnull)buildHelpCenterArticleUi:(ZDKHelpCenterArticle * _Nonnull)article andConfigs:(NSArray<id<ZDKConfiguration>> * _Nonnull)configs;
        [Static]
        [Export("buildHelpCenterArticleUi:andConfigs:")]
        UIViewController BuildHelpCenterArticleUi(ZDKHelpCenterArticle article, ZDKConfiguration[] configs);

        // +(UIViewController<ZDKHelpCenterDelegate> * _Nonnull)buildHelpCenterArticle:(ZDKHelpCenterArticle * _Nonnull)article andConfigs:(NSArray<id<ZDKConfiguration>> * _Nonnull)configs __attribute__((deprecated("use buildHelpCenterArticleUi:andConfigs instead")));
        [Static]
        [Export("buildHelpCenterArticle:andConfigs:")]
        ZDKHelpCenterDelegate BuildHelpCenterArticle(ZDKHelpCenterArticle article, ZDKConfiguration[] configs);

        // +(UIViewController * _Nonnull)buildHelpCenterArticleUiWithArticleId:(NSString * _Nonnull)articleId;
        [Static]
        [Export("buildHelpCenterArticleUiWithArticleId:")]
        UIViewController BuildHelpCenterArticleUiWithArticleId(string articleId);

        // +(UIViewController<ZDKHelpCenterDelegate> * _Nonnull)buildHelpCenterArticleWithArticleId:(NSString * _Nonnull)articleId __attribute__((deprecated("use buildHelpCenterArticleUiWithArticleId instead")));
        [Static]
        [Export("buildHelpCenterArticleWithArticleId:")]
        ZDKHelpCenterDelegate BuildHelpCenterArticleWithArticleId(string articleId);

        // +(UIViewController * _Nonnull)buildHelpCenterArticleUiWithArticleId:(NSString * _Nonnull)articleId andConfigs:(NSArray<id<ZDKConfiguration>> * _Nonnull)configs;
        [Static]
        [Export("buildHelpCenterArticleUiWithArticleId:andConfigs:")]
        UIViewController BuildHelpCenterArticleUiWithArticleId(string articleId, ZDKConfiguration[] configs);

        // +(UIViewController<ZDKHelpCenterDelegate> * _Nonnull)buildHelpCenterArticleWithArticleId:(NSString * _Nonnull)articleId andConfigs:(NSArray<id<ZDKConfiguration>> * _Nonnull)configs __attribute__((deprecated("use buildHelpCenterArticleUiWithArticleId:andConfigs instead")));
        [Static]
        [Export("buildHelpCenterArticleWithArticleId:andConfigs:")]
        ZDKHelpCenterDelegate BuildHelpCenterArticleWithArticleId(string articleId, ZDKConfiguration[] configs);
    }

    // @interface ZDKLayoutGuideApplicator : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKLayoutGuideApplicator
    {
        // -(instancetype _Nonnull)initWithViewController:(UIViewController * _Nonnull)viewController topLevelView:(UIView * _Nonnull)topLevelView layoutPosition:(ZDKLayoutGuideApplicatorPosition)position __attribute__((objc_designated_initializer));
        [Export("initWithViewController:topLevelView:layoutPosition:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIViewController viewController, UIView topLevelView, ZDKLayoutGuideApplicatorPosition position);
    }

    // @protocol ZDKSpinnerDelegate <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface ZDKSpinnerDelegate
    {
        // @required @property (assign, nonatomic) CGRect frame;
        [Abstract]
        [Export("frame", ArgumentSemantic.Assign)]
        CGRect Frame { get; set; }

        // @required @property (getter = isHidden, assign, nonatomic) BOOL hidden;
        [Abstract]
        [Export("hidden")]
        bool Hidden { [Bind("isHidden")] get; set; }

        // @required @property (assign, nonatomic) CGPoint center;
        [Abstract]
        [Export("center", ArgumentSemantic.Assign)]
        CGPoint Center { get; set; }

        // @required -(void)startAnimating;
        [Abstract]
        [Export("startAnimating")]
        void StartAnimating();

        // @required -(void)stopAnimating;
        [Abstract]
        [Export("stopAnimating")]
        void StopAnimating();
    }

    // typedef id<ZDKSpinnerDelegate> (^ZDUISpinner)(CGRect);
    delegate ZDKSpinnerDelegate ZDUISpinner(CGRect arg0);

    // @interface ZDKSupportAttachmentCell : UITableViewCell <UIAppearanceContainer>
    [BaseType(typeof(UITableViewCell))]
    interface ZDKSupportAttachmentCell : IUIAppearanceContainer
    {
        // @property (readonly, nonatomic, strong) UILabel * fileSize;
        [Export("fileSize", ArgumentSemantic.Strong)]
        UILabel FileSize { get; }

        // @property (readonly, nonatomic, strong) UILabel * title;
        [Export("title", ArgumentSemantic.Strong)]
        UILabel Title { get; }

        // +(NSString *)cellIdentifier;
        [Static]
        [Export("cellIdentifier")]
        string CellIdentifier { get; }
    }

    // @interface ZDKToastViewWrapper : UIView
    [BaseType(typeof(UIView))]
    interface ZDKToastViewWrapper
    {
        // @property (readonly, nonatomic) BOOL isVisible;
        [Export("isVisible")]
        bool IsVisible { get; }

        // -(void)showErrorInViewController:(UIViewController *)viewController withMessage:(NSString *)message;
        [Export("showErrorInViewController:withMessage:")]
        void ShowErrorInViewController(UIViewController viewController, string message);

        // -(void)showErrorInViewController:(UIViewController *)viewController withMessage:(NSString *)message duration:(CGFloat)duration;
        [Export("showErrorInViewController:withMessage:duration:")]
        void ShowErrorInViewController(UIViewController viewController, string message, nfloat duration);

        // -(void)showErrorInViewController:(UIViewController *)viewController withMessage:(NSString *)message buttonTitle:(NSString *)buttonTitle action:(void (^)(void))action;
        [Export("showErrorInViewController:withMessage:buttonTitle:action:")]
        void ShowErrorInViewController(UIViewController viewController, string message, string buttonTitle, Action action);

        // -(void)dismiss;
        [Export("dismiss")]
        void Dismiss();

        // -(void)hideToastView:(BOOL)hide;
        [Export("hideToastView:")]
        void HideToastView(bool hide);
    }

    // @interface ZDKUIUtil : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDKUIUtil
    {
        // +(id)appearanceValueForClass:(Class)viewClass selector:(SEL)selector;
        [Static]
        [Export("appearanceValueForClass:selector:")]
        NSObject AppearanceValueForClass(Class viewClass, Selector selector);

        // +(id)appearanceValueForClass:(Class)viewClass whenContainedIn:(Class<UIAppearanceContainer>)containerClass selector:(SEL)selector;
        [Static]
        [Export("appearanceValueForClass:whenContainedIn:selector:")]
        NSObject AppearanceValueForClass(Class viewClass, UIAppearanceContainer containerClass, Selector selector);

        // +(id)appearanceValueForView:(UIView *)view selector:(SEL)selector;
        [Static]
        [Export("appearanceValueForView:selector:")]
        NSObject AppearanceValueForView(UIView view, Selector selector);

        // +(BOOL)isOlderVersion:(NSString *)majorVersionNumber;
        [Static]
        [Export("isOlderVersion:")]
        bool IsOlderVersion(string majorVersionNumber);

        // +(BOOL)isNewerVersion:(NSString *)majorVersionNumber;
        [Static]
        [Export("isNewerVersion:")]
        bool IsNewerVersion(string majorVersionNumber);

        // +(BOOL)isSameVersion:(NSNumber *)majorVersionNumber;
        [Static]
        [Export("isSameVersion:")]
        bool IsSameVersion(NSNumber majorVersionNumber);

        // +(CGFloat)separatorHeightForScreenScale;
        [Static]
        [Export("separatorHeightForScreenScale")]
        nfloat SeparatorHeightForScreenScale { get; }

        // +(UIButton *)buildButtonWithFrame:(CGRect)frame andTitle:(NSString *)title;
        [Static]
        [Export("buildButtonWithFrame:andTitle:")]
        UIButton BuildButtonWithFrame(CGRect frame, string title);

        // +(UIInterfaceOrientation)currentInterfaceOrientation;
        [Static]
        [Export("currentInterfaceOrientation")]
        UIInterfaceOrientation CurrentInterfaceOrientation { get; }

        // +(CGFloat)scaledHeightForSize:(CGSize)size constrainedByWidth:(CGFloat)width;
        [Static]
        [Export("scaledHeightForSize:constrainedByWidth:")]
        nfloat ScaledHeightForSize(CGSize size, nfloat width);

        // +(BOOL)isPad;
        [Static]
        [Export("isPad")]
        bool IsPad { get; }

        // +(BOOL)isLandscape;
        [Static]
        [Export("isLandscape")]
        bool IsLandscape { get; }

        // +(UIImage *)fixOrientationOfImage:(UIImage *)image;
        [Static]
        [Export("fixOrientationOfImage:")]
        UIImage FixOrientationOfImage(UIImage image);

        // +(BOOL)shouldEnableAttachments:(UIViewController *)viewController;
        [Static]
        [Export("shouldEnableAttachments:")]
        bool ShouldEnableAttachments(UIViewController viewController);
    }
}
