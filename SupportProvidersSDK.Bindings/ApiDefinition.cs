using System;

using ObjCRuntime;
using Foundation;
using UIKit;
using CoreGraphics;
using ZendeskCoreSDK.Bindings;

namespace SupportProvidersSDK.Bindings
{
    // @interface ZDKAttachment : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKAttachment
	{
		// @property (nonatomic, strong) NSNumber * attachmentId;
		[Export("attachmentId", ArgumentSemantic.Strong)]
		NSNumber AttachmentId { get; set; }

		// @property (copy, nonatomic) NSString * filename;
		[Export("filename")]
		string Filename { get; set; }

		// @property (copy, nonatomic) NSString * contentURLString;
		[Export("contentURLString")]
		string ContentURLString { get; set; }

		// @property (copy, nonatomic) NSString * contentType;
		[Export("contentType")]
		string ContentType { get; set; }

		// @property (nonatomic, strong) NSNumber * size;
		[Export("size", ArgumentSemantic.Strong)]
		NSNumber Size { get; set; }

		// @property (copy, nonatomic) NSArray<ZDKAttachment *> * thumbnails;
		[Export("thumbnails", ArgumentSemantic.Copy)]
		ZDKAttachment[] Thumbnails { get; set; }

		// @property (assign, nonatomic) CGSize imageDimension;
		[Export("imageDimension", ArgumentSemantic.Assign)]
		CGSize ImageDimension { get; set; }

		// -(instancetype)initWithDict:(NSDictionary *)dict;
		[Export("initWithDict:")]
		IntPtr Constructor(NSDictionary dict);
	}

	// @interface ZDKAttachmentCache : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKAttachmentCache
	{
		// +(UIImage *)imageWithFilename:(NSString *)filename;
		[Static]
		[Export("imageWithFilename:")]
		UIImage ImageWithFilename(string filename);

		// +(void)cacheImage:(UIImage *)image withFilename:(NSString *)filename;
		[Static]
		[Export("cacheImage:withFilename:")]
		void CacheImage(UIImage image, string filename);

		// +(void)clearCache;
		[Static]
		[Export("clearCache")]
		void ClearCache();
	}

	// @interface ZDKProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKProvider
	{
	}

	// typedef void (^ZDKAvatarCallback)(UIImage *, NSError *);
	delegate void ZDKAvatarCallback(UIImage arg0, NSError arg1);

	// typedef void (^ZDKDownloadCallback)(NSData *, NSError *);
	delegate void ZDKDownloadCallback(NSData arg0, NSError arg1);

	// @interface ZDKAttachmentProvider : ZDKProvider
	[BaseType(typeof(ZDKProvider))]
	interface ZDKAttachmentProvider
	{
		// -(void)getAvatarForUrl:(NSString *)avatarUrl withCallback:(ZDKAvatarCallback)callback;
		[Export("getAvatarForUrl:withCallback:")]
		void GetAvatarForUrl(string avatarUrl, ZDKAvatarCallback callback);

		// -(void)getAttachmentForUrl:(NSString *)attachmentUrl withCallback:(ZDKDownloadCallback)callback;
		[Export("getAttachmentForUrl:withCallback:")]
		void GetAttachmentForUrl(string attachmentUrl, ZDKDownloadCallback callback);
	}

	// @interface ZDKBundleUtils : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKBundleUtils
	{
		// +(NSBundle *)frameworkResourceBundle;
		[Static]
		[Export("frameworkResourceBundle")]
		//[Verify (MethodToProperty)]
		NSBundle FrameworkResourceBundle { get; }

		// +(NSBundle *)frameworkStringsBundle;
		[Static]
		[Export("frameworkStringsBundle")]
		//[Verify (MethodToProperty)]
		NSBundle FrameworkStringsBundle { get; }

		// +(NSString *)pathForFrameworkResource:(NSString *)name ofType:(NSString *)extension;
		[Static]
		[Export("pathForFrameworkResource:ofType:")]
		string PathForFrameworkResource(string name, string extension);

		// +(NSString *)helpCenterCss;
		[Static]
		[Export("helpCenterCss")]
		//[Verify (MethodToProperty)]
		string HelpCenterCss { get; }

		// +(NSString *)userDefinedHelpCenterCss;
		[Static]
		[Export("userDefinedHelpCenterCss")]
		//[Verify (MethodToProperty)]
		string UserDefinedHelpCenterCss { get; }

		// +(NSString *)stringsTableName;
		[Static]
		[Export("stringsTableName")]
		//[Verify (MethodToProperty)]
		string StringsTableName { get; }

		// +(UIImage *)imageNamed:(NSString *)name ofType:(NSString *)extension;
		[Static]
		[Export("imageNamed:ofType:")]
		UIImage ImageNamed(string name, string extension);
	}

	// @interface ZDKCoding : NSObject <NSCoding>
	[BaseType(typeof(NSObject))]
	interface ZDKCoding : INSCoding
	{
	}

	// @interface ZDKComment : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKComment
	{
		// @property (readonly, nonatomic, strong) NSNumber * commentId;
		[Export("commentId", ArgumentSemantic.Strong)]
		NSNumber CommentId { get; }

		// @property (copy, nonatomic) NSString * body;
		[Export("body")]
		string Body { get; set; }

		// @property (copy, nonatomic) NSString * htmlBody;
		[Export("htmlBody")]
		string HtmlBody { get; set; }

		// @property (nonatomic, strong) NSNumber * authorId;
		[Export("authorId", ArgumentSemantic.Strong)]
		NSNumber AuthorId { get; set; }

		// @property (nonatomic, strong) NSDate * createdAt;
		[Export("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (copy, nonatomic) NSArray<ZDKAttachment *> * attachments;
		[Export("attachments", ArgumentSemantic.Copy)]
		ZDKAttachment[] Attachments { get; set; }

		// @property (copy, nonatomic) NSString * requestId;
		[Export("requestId")]
		string RequestId { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary dictionary);

		// -(NSDictionary *)toJson;
		[Export("toJson")]
		//[Verify (MethodToProperty)]
		NSDictionary ToJson { get; }
	}

	// @interface ZDKCommentWithUser : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKCommentWithUser
	{
		// @property (readonly, nonatomic, strong) ZDKComment * comment;
		[Export("comment", ArgumentSemantic.Strong)]
		ZDKComment Comment { get; }

		// @property (readonly, nonatomic, strong) ZDKSupportUser * user;
		[Export("user", ArgumentSemantic.Strong)]
		ZDKSupportUser User { get; }

		// +(instancetype)buildCommentWithUser:(ZDKComment *)comment withUsers:(NSArray *)users;
		[Static]
		[Export("buildCommentWithUser:withUsers:")]
		//[Verify (StronglyTypedNSArray)]
		ZDKCommentWithUser BuildCommentWithUser(ZDKComment comment, NSObject[] users);
	}

	// @interface ZDKCommentsResponse : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKCommentsResponse
	{
		// @property (readonly, copy, nonatomic) NSArray * commmentsWithUsers;
		[Export("commmentsWithUsers", ArgumentSemantic.Copy)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] CommmentsWithUsers { get; }

		// +(NSArray *)parseData:(NSDictionary *)dictionary;
		[Static]
		[Export("parseData:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ParseData(NSDictionary dictionary);
	}

	// @interface ZDKCreateRequest : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKCreateRequest
	{
		// @property (copy, nonatomic) NSArray * tags;
		[Export("tags", ArgumentSemantic.Copy)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] Tags { get; set; }

		// @property (copy, nonatomic) NSString * subject;
		[Export("subject")]
		string Subject { get; set; }

		// @property (copy, nonatomic) NSString * requestDescription;
		[Export("requestDescription")]
		string RequestDescription { get; set; }

		// @property (copy, nonatomic) NSArray * attachments;
		[Export("attachments", ArgumentSemantic.Copy)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] Attachments { get; set; }

		// @property (copy, nonatomic) NSArray<ZDKCustomField *> * customFields;
		[Export("customFields", ArgumentSemantic.Copy)]
		ZDKCustomField[] CustomFields { get; set; }

		// @property (nonatomic, strong) NSNumber * ticketFormId;
		[Export("ticketFormId", ArgumentSemantic.Strong)]
		NSNumber TicketFormId { get; set; }

		// -(instancetype)initWithDict:(NSDictionary *)dict;
		[Export("initWithDict:")]
		IntPtr Constructor(NSDictionary dict);
	}

	// @interface ZDKDateUtil : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKDateUtil
	{
		// +(NSDate *)dateForJsonString:(NSString *)string;
		[Static]
		[Export("dateForJsonString:")]
		NSDate DateForJsonString(string @string);

		// +(NSNumber *)dateAsNumber:(NSDate *)date;
		[Static]
		[Export("dateAsNumber:")]
		NSNumber DateAsNumber(NSDate date);

		// +(NSDate *)dateFromNumber:(NSNumber *)date;
		[Static]
		[Export("dateFromNumber:")]
		NSDate DateFromNumber(NSNumber date);

		// +(NSDate *)dateFromString:(NSString *)string usingFormat:(NSString *)format;
		[Static]
		[Export("dateFromString:usingFormat:")]
		NSDate DateFromString(string @string, string format);

		// +(NSString *)stringFromDate:(NSDate *)date usingFormat:(NSString *)format;
		[Static]
		[Export("stringFromDate:usingFormat:")]
		string StringFromDate(NSDate date, string format);

		// +(NSString *)stringFromDate:(NSDate *)date;
		[Static]
		[Export("stringFromDate:")]
		string StringFromDate(NSDate date);

		// +(NSDateFormatter *)formatterForFormat:(NSString *)format;
		[Static]
		[Export("formatterForFormat:")]
		NSDateFormatter FormatterForFormat(string format);
	}

	// @interface ZDKDeviceInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKDeviceInfo
	{
		// +(NSString *)deviceType;
		[Static]
		[Export("deviceType")]
		//[Verify (MethodToProperty)]
		string DeviceType { get; }

		// +(double)totalDeviceMemory;
		[Static]
		[Export("totalDeviceMemory")]
		//[Verify (MethodToProperty)]
		double TotalDeviceMemory { get; }

		// +(double)freeDiskspace;
		[Static]
		[Export("freeDiskspace")]
		//[Verify (MethodToProperty)]
		double FreeDiskspace { get; }

		// +(double)totalDiskspace;
		[Static]
		[Export("totalDiskspace")]
		//[Verify (MethodToProperty)]
		double TotalDiskspace { get; }

		// +(CGFloat)batteryLevel;
		[Static]
		[Export("batteryLevel")]
		//[Verify (MethodToProperty)]
		nfloat BatteryLevel { get; }

		// +(NSString *)region;
		[Static]
		[Export("region")]
		//[Verify (MethodToProperty)]
		string Region { get; }

		// +(NSString *)language;
		[Static]
		[Export("language")]
		//[Verify (MethodToProperty)]
		string Language { get; }

		// +(NSDictionary *)deviceInfoDictionary;
		[Static]
		[Export("deviceInfoDictionary")]
		//[Verify (MethodToProperty)]
		NSDictionary DeviceInfoDictionary { get; }
	}

	// @protocol ZDKDictionaryCreatable <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	//[Protocol]
	//[BaseType(typeof(NSObject))]
	//interface ZDKDictionaryCreatable
	//{
	//	// @required +(id<ZDKDictionaryCreatable>)alloc;
	//	[Static, Abstract]
	//	[Export("alloc")]
	//	//[Verify (MethodToProperty)]
	//	ZDKDictionaryCreatable Alloc { get; }

	//	// @required -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
	//	[Abstract]
	//	[Export("initWithDictionary:")]
	//	IntPtr Constructor(NSDictionary dictionary);
	//}

	// @interface ZDKDispatcherResponse : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKDispatcherResponse
	{
		// @property (nonatomic, strong) NSHTTPURLResponse * response;
		[Export("response", ArgumentSemantic.Strong)]
		NSHttpUrlResponse Response { get; set; }

		// @property (nonatomic, strong) NSData * data;
		[Export("data", ArgumentSemantic.Strong)]
		NSData Data { get; set; }

		// -(instancetype)initWithResponse:(NSHTTPURLResponse *)response andData:(NSData *)data;
		[Export("initWithResponse:andData:")]
		IntPtr Constructor(NSHttpUrlResponse response, NSData data);
	}

	// typedef void (^ZDKAPISuccess)(id);
	delegate void ZDKAPISuccess(NSObject arg0);

	// typedef void (^ZDKAPIError)(NSError *);
	delegate void ZDKAPIError(NSError arg0);

	// @interface ZDKETag : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKETag
	{
		// +(void)addEtagToRequest:(NSMutableURLRequest *)request;
		[Static]
		[Export("addEtagToRequest:")]
		void AddEtagToRequest(NSMutableUrlRequest request);

		// +(BOOL)unmodified:(ZDKDispatcherResponse *)response;
		[Static]
		[Export("unmodified:")]
		bool Unmodified(ZDKDispatcherResponse response);

		// +(NSString *)eTagForURL:(NSURL *)url;
		[Static]
		[Export("eTagForURL:")]
		string ETagForURL(NSUrl url);
	}

	// @interface ZDKHelpCenterArticle : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterArticle
	{
		// @property (copy, nonatomic) NSNumber * identifier;
		[Export("identifier", ArgumentSemantic.Copy)]
		NSNumber Identifier { get; set; }

		// @property (copy, nonatomic) NSNumber * section_id;
		[Export("section_id", ArgumentSemantic.Copy)]
		NSNumber Section_id { get; set; }

		// @property (copy, nonatomic) NSString * title;
		[Export("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * body;
		[Export("body")]
		string Body { get; set; }

		// @property (copy, nonatomic) NSString * author_name;
		[Export("author_name")]
		string Author_name { get; set; }

		// @property (copy, nonatomic) NSNumber * author_id;
		[Export("author_id", ArgumentSemantic.Copy)]
		NSNumber Author_id { get; set; }

		// @property (copy, nonatomic) NSString * articleParents;
		[Export("articleParents")]
		string ArticleParents { get; set; }

		// @property (nonatomic, strong) NSDate * created_at;
		[Export("created_at", ArgumentSemantic.Strong)]
		NSDate Created_at { get; set; }

		// @property (assign, nonatomic) NSInteger position;
		[Export("position")]
		nint Position { get; set; }

		// @property (assign, nonatomic) BOOL outdated;
		[Export("outdated")]
		bool Outdated { get; set; }

		// @property (nonatomic, strong) NSNumber * voteSum;
		[Export("voteSum", ArgumentSemantic.Strong)]
		NSNumber VoteSum { get; set; }

		// @property (nonatomic, strong) NSNumber * voteCount;
		[Export("voteCount", ArgumentSemantic.Strong)]
		NSNumber VoteCount { get; set; }

		// @property (copy, nonatomic) NSString * locale;
		[Export("locale")]
		string Locale { get; set; }

		// @property (copy, nonatomic) NSArray * labelNames;
		[Export("labelNames", ArgumentSemantic.Copy)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] LabelNames { get; set; }

		// @property (copy, nonatomic) NSString * htmlUrl;
		[Export("htmlUrl")]
		string HtmlUrl { get; set; }

		// -(NSInteger)getUpvoteCount;
		[Export("getUpvoteCount")]
		//[Verify (MethodToProperty)]
		nint UpvoteCount { get; }

		// -(NSInteger)getDownvoteCount;
		[Export("getDownvoteCount")]
		//[Verify (MethodToProperty)]
		nint DownvoteCount { get; }

		// +(ZDKHelpCenterArticle *)parseArticle:(NSDictionary *)articleJson;
		[Static]
		[Export("parseArticle:")]
		ZDKHelpCenterArticle ParseArticle(NSDictionary articleJson);
	}

	// @interface ZDKHelpCenterArticleVote : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterArticleVote
	{
		// @property (copy, nonatomic) NSNumber * identifier;
		[Export("identifier", ArgumentSemantic.Copy)]
		NSNumber Identifier { get; set; }

		// @property (copy, nonatomic) NSString * url;
		[Export("url")]
		string Url { get; set; }

		// @property (copy, nonatomic) NSNumber * userId;
		[Export("userId", ArgumentSemantic.Copy)]
		NSNumber UserId { get; set; }

		// @property (copy, nonatomic) NSString * value;
		[Export("value")]
		string Value { get; set; }

		// @property (copy, nonatomic) NSNumber * itemId;
		[Export("itemId", ArgumentSemantic.Copy)]
		NSNumber ItemId { get; set; }

		// @property (copy, nonatomic) NSString * itemType;
		[Export("itemType")]
		string ItemType { get; set; }

		// @property (nonatomic, strong) NSDate * createdAt;
		[Export("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSDate * updatedAt;
		[Export("updatedAt", ArgumentSemantic.Strong)]
		NSDate UpdatedAt { get; set; }

		// +(ZDKHelpCenterArticleVote *)parseArticleVote:(NSDictionary *)articleVoteJson;
		[Static]
		[Export("parseArticleVote:")]
		ZDKHelpCenterArticleVote ParseArticleVote(NSDictionary articleVoteJson);

		// +(NSArray *)parseArticleVotes:(NSDictionary *)json;
		[Static]
		[Export("parseArticleVotes:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ParseArticleVotes(NSDictionary json);
	}

	// @interface ZDKHelpCenterAttachment : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterAttachment
	{
		// @property (copy, nonatomic) NSNumber * identifier;
		[Export("identifier", ArgumentSemantic.Copy)]
		NSNumber Identifier { get; set; }

		// @property (copy, nonatomic) NSString * url;
		[Export("url")]
		string Url { get; set; }

		// @property (copy, nonatomic) NSNumber * article_id;
		[Export("article_id", ArgumentSemantic.Copy)]
		NSNumber Article_id { get; set; }

		// @property (copy, nonatomic) NSString * file_name;
		[Export("file_name")]
		string File_name { get; set; }

		// @property (copy, nonatomic) NSString * content_url;
		[Export("content_url")]
		string Content_url { get; set; }

		// @property (copy, nonatomic) NSString * content_type;
		[Export("content_type")]
		string Content_type { get; set; }

		// @property (assign, nonatomic) NSUInteger size;
		[Export("size")]
		nuint Size { get; set; }

		// @property (assign, nonatomic) BOOL isInline;
		[Export("isInline")]
		bool IsInline { get; set; }

		// +(ZDKHelpCenterAttachment *)parseAttachment:(NSDictionary *)attachmentJson;
		[Static]
		[Export("parseAttachment:")]
		ZDKHelpCenterAttachment ParseAttachment(NSDictionary attachmentJson);

		// +(NSArray *)parseAttachments:(NSDictionary *)json;
		[Static]
		[Export("parseAttachments:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ParseAttachments(NSDictionary json);

		// -(NSString *)humanReadableFileSize;
		[Export("humanReadableFileSize")]
		//[Verify (MethodToProperty)]
		string HumanReadableFileSize { get; }
	}

	// @interface ZDKHelpCenterCategory : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterCategory
	{
		// @property (copy, nonatomic) NSNumber * identifier;
		[Export("identifier", ArgumentSemantic.Copy)]
		NSNumber Identifier { get; set; }

		// @property (copy, nonatomic) NSString * name;
		[Export("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * categoryDescription;
		[Export("categoryDescription")]
		string CategoryDescription { get; set; }

		// @property (assign, nonatomic) NSInteger position;
		[Export("position")]
		nint Position { get; set; }

		// @property (assign, nonatomic) BOOL outdated;
		[Export("outdated")]
		bool Outdated { get; set; }

		// @property (copy, nonatomic) NSString * locale;
		[Export("locale")]
		string Locale { get; set; }

		// @property (copy, nonatomic) NSString * sourceLocale;
		[Export("sourceLocale")]
		string SourceLocale { get; set; }

		// @property (copy, nonatomic) NSString * url;
		[Export("url")]
		string Url { get; set; }

		// @property (copy, nonatomic) NSString * html_url;
		[Export("html_url")]
		string Html_url { get; set; }

		// @property (copy, nonatomic) NSString * updatedAt;
		[Export("updatedAt")]
		string UpdatedAt { get; set; }

		// @property (copy, nonatomic) NSString * createdAt;
		[Export("createdAt")]
		string CreatedAt { get; set; }

		// +(ZDKHelpCenterCategory *)parseCategory:(NSDictionary *)categoryJson;
		[Static]
		[Export("parseCategory:")]
		ZDKHelpCenterCategory ParseCategory(NSDictionary categoryJson);

		// +(NSArray *)parseCategories:(NSDictionary *)json;
		[Static]
		[Export("parseCategories:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ParseCategories(NSDictionary json);
	}

	// @interface ZDKHelpCenterDeflection : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterDeflection
	{
		// @property (copy, nonatomic) NSString * query;
		[Export("query")]
		string Query { get; set; }

		// @property (copy, nonatomic) NSMutableArray * labelNames;
		[Export("labelNames", ArgumentSemantic.Copy)]
		NSMutableArray LabelNames { get; set; }

		// @property (copy, nonatomic) NSString * locale;
		[Export("locale")]
		string Locale { get; set; }

		// @property (copy, nonatomic) NSMutableArray * sideLoads;
		[Export("sideLoads", ArgumentSemantic.Copy)]
		NSMutableArray SideLoads { get; set; }

		// @property (nonatomic, strong) NSNumber * categoryId;
		[Export("categoryId", ArgumentSemantic.Strong)]
		NSNumber CategoryId { get; set; }

		// @property (nonatomic, strong) NSNumber * sectionId;
		[Export("sectionId", ArgumentSemantic.Strong)]
		NSNumber SectionId { get; set; }

		// @property (nonatomic, strong) NSNumber * page;
		[Export("page", ArgumentSemantic.Strong)]
		NSNumber Page { get; set; }

		// @property (nonatomic, strong) NSNumber * resultsPerPage;
		[Export("resultsPerPage", ArgumentSemantic.Strong)]
		NSNumber ResultsPerPage { get; set; }
	}

	// @interface ZDKHelpCenterSection : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterSection
	{
		// @property (copy, nonatomic) NSNumber * identifier;
		[Export("identifier", ArgumentSemantic.Copy)]
		NSNumber Identifier { get; set; }

		// @property (copy, nonatomic) NSNumber * category_id;
		[Export("category_id", ArgumentSemantic.Copy)]
		NSNumber Category_id { get; set; }

		// @property (copy, nonatomic) NSString * name;
		[Export("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * sectionDescription;
		[Export("sectionDescription")]
		string SectionDescription { get; set; }

		// @property (assign, nonatomic) NSInteger position;
		[Export("position")]
		nint Position { get; set; }

		// @property (copy, nonatomic) NSString * locale;
		[Export("locale")]
		string Locale { get; set; }

		// @property (copy, nonatomic) NSString * sourceLocale;
		[Export("sourceLocale")]
		string SourceLocale { get; set; }

		// @property (copy, nonatomic) NSString * url;
		[Export("url")]
		string Url { get; set; }

		// @property (copy, nonatomic) NSString * html_url;
		[Export("html_url")]
		string Html_url { get; set; }

		// @property (copy, nonatomic) NSString * sorting;
		[Export("sorting")]
		string Sorting { get; set; }

		// @property (copy, nonatomic) NSString * createdAt;
		[Export("createdAt")]
		string CreatedAt { get; set; }

		// @property (copy, nonatomic) NSString * updatedAt;
		[Export("updatedAt")]
		string UpdatedAt { get; set; }

		// @property (assign, nonatomic) BOOL outdated;
		[Export("outdated")]
		bool Outdated { get; set; }

		// +(ZDKHelpCenterSection *)parseSection:(NSDictionary *)sectionJson;
		[Static]
		[Export("parseSection:")]
		ZDKHelpCenterSection ParseSection(NSDictionary sectionJson);

		// +(NSArray *)parseSections:(NSDictionary *)json;
		[Static]
		[Export("parseSections:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ParseSections(NSDictionary json);
	}

	// @interface ZDKHelpCenterFlatArticle : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterFlatArticle
	{
		// @property (nonatomic, strong) ZDKHelpCenterArticle * article;
		[Export("article", ArgumentSemantic.Strong)]
		ZDKHelpCenterArticle Article { get; set; }

		// @property (nonatomic, strong) ZDKHelpCenterSection * section;
		[Export("section", ArgumentSemantic.Strong)]
		ZDKHelpCenterSection Section { get; set; }

		// @property (nonatomic, strong) ZDKHelpCenterCategory * category;
		[Export("category", ArgumentSemantic.Strong)]
		ZDKHelpCenterCategory Category { get; set; }

		// -(NSString *)getArticleBreadcrumb;
		[Export("getArticleBreadcrumb")]
		//[Verify (MethodToProperty)]
		string ArticleBreadcrumb { get; }
	}

	// @interface ZDKHelpCenterLastSearch : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterLastSearch
	{
		// @property (readonly, copy, nonatomic) NSString * query;
		[Export("query")]
		string Query { get; }

		// @property (readonly, nonatomic, strong) NSNumber * results_count;
		[Export("results_count", ArgumentSemantic.Strong)]
		NSNumber Results_count { get; }

		// -(instancetype)initWithQuery:(NSString *)query resultsCount:(NSNumber *)count;
		[Export("initWithQuery:resultsCount:")]
		IntPtr Constructor(string query, NSNumber count);

		// -(NSDictionary *)toJson;
		[Export("toJson")]
		//[Verify (MethodToProperty)]
		NSDictionary ToJson { get; }
	}

	// @interface ZDKHelpCenterOverviewContentModel : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKHelpCenterOverviewContentModel
	{
		// @property (copy, nonatomic) NSArray * labels;
		[Export("labels", ArgumentSemantic.Copy)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] Labels { get; set; }

		// @property (assign, nonatomic) ZDKHelpCenterOverviewGroupType groupType;
		//[Export("groupType", ArgumentSemantic.Assign)]
		//ZDKHelpCenterOverviewGroupType GroupType { get; set; }

		//// @property (assign, nonatomic) ZDKNavBarConversationsUIType navBarConversationsUIType __attribute__((deprecated("Deprecated as of 1.10.0.1, use ZDKHelpCenterConversationsUIDelegate instead.")));
		//[Export("navBarConversationsUIType", ArgumentSemantic.Assign)]
		//ZDKNavBarConversationsUIType NavBarConversationsUIType { get; set; }

		// @property (assign, nonatomic) BOOL hideContactSupport __attribute__((deprecated("Deprecated as of 2.3.0, use ZDKHelpCenterUiConfigration instead")));
		[Export("hideContactSupport")]
		bool HideContactSupport { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * groupIds;
		[Export("groupIds", ArgumentSemantic.Copy)]
		NSNumber[] GroupIds { get; set; }

		// +(instancetype)defaultContent;
		[Static]
		[Export("defaultContent")]
		ZDKHelpCenterOverviewContentModel DefaultContent();
	}

	// @interface ZDKHelpCenterParser : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterParser
	{
		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary dict);

		// +(NSDictionary *)createSectionLookup:(NSArray *)sections;
		[Static]
		[Export("createSectionLookup:")]
		//[Verify (StronglyTypedNSArray)]
		NSDictionary CreateSectionLookup(NSObject[] sections);

		// +(NSDictionary *)createCategoryLookup:(NSArray *)categories;
		[Static]
		[Export("createCategoryLookup:")]
		//[Verify (StronglyTypedNSArray)]
		NSDictionary CreateCategoryLookup(NSObject[] categories);

		// +(NSDictionary *)createAuthorLookup:(NSArray *)users;
		[Static]
		[Export("createAuthorLookup:")]
		//[Verify (StronglyTypedNSArray)]
		NSDictionary CreateAuthorLookup(NSObject[] users);

		// -(NSArray *)parseArticles:(NSDictionary *)json;
		[Export("parseArticles:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ParseArticles(NSDictionary json);

		// -(NSArray *)parseArticlesWithRootKey:(NSDictionary *)json withRootKey:(NSString *)root;
		[Export("parseArticlesWithRootKey:withRootKey:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ParseArticlesWithRootKey(NSDictionary json, string root);

		// -(NSArray *)parseFlatArticles:(NSDictionary *)json;
		[Export("parseFlatArticles:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ParseFlatArticles(NSDictionary json);

		// -(NSArray *)parseArticleSearchResults:(NSDictionary *)json;
		[Export("parseArticleSearchResults:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ParseArticleSearchResults(NSDictionary json);
	}

	// @interface ZDKHelpCenterSearch : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterSearch
	{
		// @property (copy, nonatomic) NSString * query;
		[Export("query")]
		string Query { get; set; }

		// @property (copy, nonatomic) NSMutableArray * labelNames;
		[Export("labelNames", ArgumentSemantic.Copy)]
		NSMutableArray LabelNames { get; set; }

		// @property (copy, nonatomic) NSString * locale;
		[Export("locale")]
		string Locale { get; set; }

		// @property (copy, nonatomic) NSMutableArray * sideLoads;
		[Export("sideLoads", ArgumentSemantic.Copy)]
		NSMutableArray SideLoads { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * categoryIds;
		[Export("categoryIds", ArgumentSemantic.Copy)]
		NSNumber[] CategoryIds { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * sectionIds;
		[Export("sectionIds", ArgumentSemantic.Copy)]
		NSNumber[] SectionIds { get; set; }

		// @property (nonatomic, strong) NSNumber * page;
		[Export("page", ArgumentSemantic.Strong)]
		NSNumber Page { get; set; }

		// @property (nonatomic, strong) NSNumber * resultsPerPage;
		[Export("resultsPerPage", ArgumentSemantic.Strong)]
		NSNumber ResultsPerPage { get; set; }
	}

	// typedef void (^ZDKHelpCenterCallback)(NSArray *, NSError *);
	delegate void ZDKHelpCenterCallback(NSObject[] arg0, NSError arg1);

	// typedef void (^ZDKHelpCenterCategoriesCallback)(NSArray<ZDKHelpCenterCategoryViewModel *> *, NSError *);
	delegate void ZDKHelpCenterCategoriesCallback(ZDKHelpCenterCategoryViewModel[] arg0, NSError arg1);

	// typedef void (^ZDKHelpCenterGenericCallback)(id, NSError *);
	delegate void ZDKHelpCenterGenericCallback(NSObject arg0, NSError arg1);

	// @interface ZDKHelpCenterProvider : ZDKProvider
	[BaseType(typeof(ZDKProvider))]
	interface ZDKHelpCenterProvider
	{
		// -(void)getHelpCenterOverviewWithHelpCenterOverviewModel:(ZDKHelpCenterOverviewContentModel *)helpCenterModel callback:(ZDKHelpCenterCategoriesCallback)callback;
		[Export("getHelpCenterOverviewWithHelpCenterOverviewModel:callback:")]
		void GetHelpCenterOverviewWithHelpCenterOverviewModel(ZDKHelpCenterOverviewContentModel helpCenterModel, ZDKHelpCenterCategoriesCallback callback);

		// -(void)getCategoriesWithCallback:(ZDKHelpCenterCallback)callback;
		[Export("getCategoriesWithCallback:")]
		void GetCategoriesWithCallback(ZDKHelpCenterCallback callback);

		// -(void)getSectionsWithCategoryId:(NSString *)categoryId withCallback:(ZDKHelpCenterCallback)callback;
		[Export("getSectionsWithCategoryId:withCallback:")]
		void GetSectionsWithCategoryId(string categoryId, ZDKHelpCenterCallback callback);

		// -(void)getArticlesWithSectionId:(NSString *)sectionId withCallback:(ZDKHelpCenterCallback)callback;
		[Export("getArticlesWithSectionId:withCallback:")]
		void GetArticlesWithSectionId(string sectionId, ZDKHelpCenterCallback callback);

		// -(void)getArticlesWithSectionId:(NSString *)sectionId labels:(NSArray *)labels withCallback:(ZDKHelpCenterCallback)callback;
		[Export("getArticlesWithSectionId:labels:withCallback:")]
		//[Verify (StronglyTypedNSArray)]
		void GetArticlesWithSectionId(string sectionId, NSObject[] labels, ZDKHelpCenterCallback callback);

		// -(void)searchForArticlesUsingQuery:(NSString *)query withCallback:(ZDKHelpCenterCallback)callback;
		[Export("searchForArticlesUsingQuery:withCallback:")]
		void SearchForArticlesUsingQuery(string query, ZDKHelpCenterCallback callback);

		// -(void)searchForArticlesUsingQuery:(NSString *)query andLabels:(NSArray<NSString *> *)labels withCallback:(ZDKHelpCenterCallback)callback;
		[Export("searchForArticlesUsingQuery:andLabels:withCallback:")]
		void SearchForArticlesUsingQuery(string query, string[] labels, ZDKHelpCenterCallback callback);

		// -(void)searchArticles:(ZDKHelpCenterSearch *)search withCallback:(ZDKHelpCenterCallback)callback;
		[Export("searchArticles:withCallback:")]
		void SearchArticles(ZDKHelpCenterSearch search, ZDKHelpCenterCallback callback);

		// -(void)getAttachmentWithArticleId:(NSString *)articleId withCallback:(ZDKHelpCenterCallback)callback;
		[Export("getAttachmentWithArticleId:withCallback:")]
		void GetAttachmentWithArticleId(string articleId, ZDKHelpCenterCallback callback);

		// -(void)getArticlesByLabels:(NSArray<NSString *> *)labels withCallback:(ZDKHelpCenterCallback)callback;
		[Export("getArticlesByLabels:withCallback:")]
		void GetArticlesByLabels(string[] labels, ZDKHelpCenterCallback callback);

		// -(void)getArticleWithId:(NSString *)articleId withCallback:(ZDKHelpCenterCallback)callback;
		[Export("getArticleWithId:withCallback:")]
		void GetArticleWithId(string articleId, ZDKHelpCenterCallback callback);

		// -(void)getArticleSuggestions:(ZDKHelpCenterDeflection *)search withCallback:(ZDKHelpCenterCallback)callback;
		[Export("getArticleSuggestions:withCallback:")]
		void GetArticleSuggestions(ZDKHelpCenterDeflection search, ZDKHelpCenterCallback callback);

		// -(void)getFlatArticlesWithCallback:(ZDKHelpCenterCallback)callback;
		[Export("getFlatArticlesWithCallback:")]
		void GetFlatArticlesWithCallback(ZDKHelpCenterCallback callback);

		// -(void)getSectionWithId:(NSString *)sectionId withCallback:(ZDKHelpCenterCallback)callback;
		[Export("getSectionWithId:withCallback:")]
		void GetSectionWithId(string sectionId, ZDKHelpCenterCallback callback);

		// -(void)getCategoryWithId:(NSString *)categoryId withCallback:(ZDKHelpCenterCallback)callback;
		[Export("getCategoryWithId:withCallback:")]
		void GetCategoryWithId(string categoryId, ZDKHelpCenterCallback callback);

		// -(void)submitRecordArticleView:(ZDKHelpCenterArticle *)article withCallback:(ZDKHelpCenterGenericCallback)callback;
		[Export("submitRecordArticleView:withCallback:")]
		void SubmitRecordArticleView(ZDKHelpCenterArticle article, ZDKHelpCenterGenericCallback callback);

		// -(void)upVoteArticleWithId:(NSString *)articleId withCallback:(ZDKHelpCenterCallback)callback;
		[Export("upVoteArticleWithId:withCallback:")]
		void UpVoteArticleWithId(string articleId, ZDKHelpCenterCallback callback);

		// -(void)downVoteArticleWithId:(NSString *)articleId withCallback:(ZDKHelpCenterCallback)callback;
		[Export("downVoteArticleWithId:withCallback:")]
		void DownVoteArticleWithId(string articleId, ZDKHelpCenterCallback callback);

		// -(void)removeVoteWithId:(NSString *)voteId withCallback:(ZDKHelpCenterGenericCallback)callback;
		[Export("removeVoteWithId:withCallback:")]
		void RemoveVoteWithId(string voteId, ZDKHelpCenterGenericCallback callback);
	}

	// @interface ZDKHelpCenterSessionCache : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterSessionCache
	{
		// +(void)cacheLastSearch:(ZDKHelpCenterLastSearch *)lastSearch;
		[Static]
		[Export("cacheLastSearch:")]
		void CacheLastSearch(ZDKHelpCenterLastSearch lastSearch);

		// +(void)unsetUniqueSearchResultClick;
		[Static]
		[Export("unsetUniqueSearchResultClick")]
		void UnsetUniqueSearchResultClick();

		// +(ZDKHelpCenterLastSearch *)getLastSearch;
		[Static]
		[Export("getLastSearch")]
		//[Verify (MethodToProperty)]
		ZDKHelpCenterLastSearch LastSearch { get; }

		// +(NSDictionary *)recordArticleViewRequestJson;
		[Static]
		[Export("recordArticleViewRequestJson")]
		//[Verify (MethodToProperty)]
		NSDictionary RecordArticleViewRequestJson { get; }
	}

	// @interface ZDKHelpCenterSimpleArticle : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterSimpleArticle
	{
		// @property (copy, nonatomic) NSString * id;
		[Export("id")]
		string Id { get; set; }

		// @property (copy, nonatomic) NSString * title;
		[Export("title")]
		string Title { get; set; }

		// +(NSArray *)parseDeflectionSearchResults:(NSDictionary *)json;
		[Static]
		[Export("parseDeflectionSearchResults:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ParseDeflectionSearchResults(NSDictionary json);

		// +(ZDKHelpCenterSimpleArticle *)parseSimpleArticle:(NSDictionary *)simpleArticleJSON;
		[Static]
		[Export("parseSimpleArticle:")]
		ZDKHelpCenterSimpleArticle ParseSimpleArticle(NSDictionary simpleArticleJSON);
	}

	// @protocol ZDKHelpCenterViewModel <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterViewModel
	{
		// @required @property (readonly, copy) NSString * name;
		[Abstract]
		[Export("name")]
		string Name { get; }

		// @optional @property (readonly, copy) NSString * detailTitle;
		[Export("detailTitle")]
		string DetailTitle { get; }
	}

	// @interface ZDKJsonUtil : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKJsonUtil
	{
		// +(id)cleanJSONVal:(NSDictionary *)json key:(NSString *)key;
		[Static]
		[Export("cleanJSONVal:key:")]
		NSObject CleanJSONVal(NSDictionary json, string key);

		// +(id)cleanJSONVal:(id)val;
		[Static]
		[Export("cleanJSONVal:")]
		NSObject CleanJSONVal(NSObject val);

		// +(id)cleanJSONArrayVal:(NSDictionary *)json key:(NSString *)key;
		[Static]
		[Export("cleanJSONArrayVal:key:")]
		NSObject CleanJSONArrayVal(NSDictionary json, string key);

		// +(id)convertJsonObject:(NSDictionary *)json toObjectOfType:(Class)classToMap;
		[Static]
		[Export("convertJsonObject:toObjectOfType:")]
		NSObject ConvertJsonObject(NSDictionary json, Class classToMap);

		// +(NSMutableArray *)convertArrayOfJsonObjects:(NSArray *)jsonArray toArrayOfType:(Class)classToMap;
		[Static]
		[Export("convertArrayOfJsonObjects:toArrayOfType:")]
		//[Verify (StronglyTypedNSArray)]
		NSMutableArray ConvertArrayOfJsonObjects(NSObject[] jsonArray, Class classToMap);

		// +(NSDictionary *)convertObjectToDictionary:(id)objectToConvert forClass:(Class)aClass;
		[Static]
		[Export("convertObjectToDictionary:forClass:")]
		NSDictionary ConvertObjectToDictionary(NSObject objectToConvert, Class aClass);

		// +(NSMutableArray *)arrayWithPropertiesOfObject:(Class)aClass;
		[Static]
		[Export("arrayWithPropertiesOfObject:")]
		NSMutableArray ArrayWithPropertiesOfObject(Class aClass);
	}

	// @interface ZDKLocalization : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKLocalization
	{
		// +(void)printAllKeys;
		[Static]
		[Export("printAllKeys")]
		void PrintAllKeys();

		// +(void)registerTableName:(NSString * _Nonnull)tableName;
		[Static]
		[Export("registerTableName:")]
		void RegisterTableName(string tableName);

		// +(NSString * _Nonnull)localizedStringWithKey:(NSString * _Nonnull)key;
		[Static]
		[Export("localizedStringWithKey:")]
		string LocalizedStringWithKey(string key);
	}

	// @interface ZDKMobileProvisionAnalyzer : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKMobileProvisionAnalyzer
	{
		// +(NSString *)getEnvironment;
		[Static]
		[Export("getEnvironment")]
		//[Verify (MethodToProperty)]
		string Environment { get; }
	}

	// @interface ZDKNSCodingUtil : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKNSCodingUtil
	{
		// +(void)encodeWithCoder:(NSCoder *)aCoder forInstance:(NSObject *)instance;
		[Static]
		[Export("encodeWithCoder:forInstance:")]
		void EncodeWithCoder(NSCoder aCoder, NSObject instance);

		// +(void)decodeWithCoder:(NSCoder *)aDecoder forInstance:(NSObject *)instance;
		[Static]
		[Export("decodeWithCoder:forInstance:")]
		void DecodeWithCoder(NSCoder aDecoder, NSObject instance);
	}

	// @interface ZDKReachability : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKReachability
	{
		// +(instancetype)reachabilityWithHostName:(NSString *)hostName;
		[Static]
		[Export("reachabilityWithHostName:")]
		ZDKReachability ReachabilityWithHostName(string hostName);

		// +(instancetype)reachabilityWithAddress:(const struct sockaddr_in *)hostAddress;
		//[Static]
		//[Export("reachabilityWithAddress:")]
		//unsafe ZDKReachability ReachabilityWithAddress(sockaddr_in* hostAddress);

		// +(instancetype)reachabilityForInternetConnection;
		[Static]
		[Export("reachabilityForInternetConnection")]
		ZDKReachability ReachabilityForInternetConnection();

		// +(instancetype)reachabilityForLocalWiFi;
		[Static]
		[Export("reachabilityForLocalWiFi")]
		ZDKReachability ReachabilityForLocalWiFi();

		// -(BOOL)startNotifier;
		[Export("startNotifier")]
		//[Verify (MethodToProperty)]
		bool StartNotifier { get; }

		// -(void)stopNotifier;
		[Export("stopNotifier")]
		void StopNotifier();

		// -(ZDKNetworkStatus)currentReachabilityStatus;
		//[Export("currentReachabilityStatus")]
		////[Verify (MethodToProperty)]
		//ZDKNetworkStatus CurrentReachabilityStatus { get; }

		// -(BOOL)connectionRequired;
		[Export("connectionRequired")]
		//[Verify (MethodToProperty)]
		bool ConnectionRequired { get; }
	}

	// @interface ZDKRequest : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKRequest
	{
		// @property (copy, nonatomic) NSString * _Nonnull requestId;
		[Export("requestId")]
		string RequestId { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nonnull requesterId;
		[Export("requesterId", ArgumentSemantic.Strong)]
		NSNumber RequesterId { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull status;
		[Export("status")]
		string Status { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable subject;
		[NullAllowed, Export("subject")]
		string Subject { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull requestDescription;
		[Export("requestDescription")]
		string RequestDescription { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable type;
		[NullAllowed, Export("type")]
		string Type { get; set; }

		// @property (nonatomic, strong) NSDate * _Nonnull createdAt;
		[Export("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSDate * _Nonnull updateAt;
		[Export("updateAt", ArgumentSemantic.Strong)]
		NSDate UpdateAt { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable publicUpdatedAt;
		[NullAllowed, Export("publicUpdatedAt", ArgumentSemantic.Strong)]
		NSDate PublicUpdatedAt { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nonnull commentCount;
		[Export("commentCount", ArgumentSemantic.Strong)]
		NSNumber CommentCount { get; set; }

		// @property (nonatomic, strong) ZDKComment * _Nullable lastComment;
		[NullAllowed, Export("lastComment", ArgumentSemantic.Strong)]
		ZDKComment LastComment { get; set; }

		// @property (nonatomic, strong) ZDKComment * _Nullable firstComment;
		[NullAllowed, Export("firstComment", ArgumentSemantic.Strong)]
		ZDKComment FirstComment { get; set; }

		// @property (nonatomic, strong) NSArray<NSNumber *> * _Nonnull collaboratingIds;
		[Export("collaboratingIds", ArgumentSemantic.Strong)]
		NSNumber[] CollaboratingIds { get; set; }

		// @property (nonatomic, strong) NSArray<NSNumber *> * _Nonnull commentingAgentsIds;
		[Export("commentingAgentsIds", ArgumentSemantic.Strong)]
		NSNumber[] CommentingAgentsIds { get; set; }

		// @property (nonatomic, strong) NSArray<ZDKCustomField *> * _Nullable customFields;
		[NullAllowed, Export("customFields", ArgumentSemantic.Strong)]
		ZDKCustomField[] CustomFields { get; set; }

		// -(instancetype _Nullable)initWithDict:(NSDictionary * _Nullable)dict;
		[Export("initWithDict:")]
		IntPtr Constructor([NullAllowed] NSDictionary dict);

		// -(NSDictionary * _Nonnull)toJson;
		[Export("toJson")]
		//[Verify (MethodToProperty)]
		NSDictionary ToJson { get; }
	}

	// typedef void (^ZDKRequestCallback)(ZDKRequest *, NSError *);
	delegate void ZDKRequestCallback(ZDKRequest arg0, NSError arg1);

	// typedef void (^ZDKRequestListCallback)(ZDKRequestsWithCommentingAgents *, NSError *);
	delegate void ZDKRequestListCallback(ZDKRequestsWithCommentingAgents arg0, NSError arg1);

	// typedef void (^ZDKRequestCommentListCallback)(NSArray<ZDKCommentWithUser *> *, NSError *);
	delegate void ZDKRequestCommentListCallback(ZDKCommentWithUser[] arg0, NSError arg1);

	// typedef void (^ZDKRequestAddCommentCallback)(ZDKComment *, NSError *);
	delegate void ZDKRequestAddCommentCallback(ZDKComment arg0, NSError arg1);

	// typedef void (^ZDKCreateRequestCallback)(id, NSError *);
	delegate void ZDKCreateRequestCallback(NSObject arg0, NSError arg1);

	// typedef void (^ZDKTicketFormCallback)(NSArray<ZDKTicketForm *> *, NSError *);
	//delegate void ZDKTicketFormCallback(ZDKTicketForm[] arg0, NSError arg1);

	// @interface ZDKRequestProvider : ZDKProvider
	[BaseType(typeof(ZDKProvider))]
	interface ZDKRequestProvider
	{
		// -(void)createRequest:(ZDKCreateRequest *)request withCallback:(ZDKCreateRequestCallback)callback;
		[Export("createRequest:withCallback:")]
		void CreateRequest(ZDKCreateRequest request, ZDKCreateRequestCallback callback);

		// -(void)getRequestById:(NSString *)requestId withCallback:(ZDKRequestCallback)callback;
		[Export("getRequestById:withCallback:")]
		void GetRequestById(string requestId, ZDKRequestCallback callback);

		// -(void)getAllRequestsWithCallback:(ZDKRequestListCallback)callback;
		[Export("getAllRequestsWithCallback:")]
		void GetAllRequestsWithCallback(ZDKRequestListCallback callback);

		// -(void)getRequestsByStatus:(NSString *)status withCallback:(ZDKRequestListCallback)callback;
		[Export("getRequestsByStatus:withCallback:")]
		void GetRequestsByStatus(string status, ZDKRequestListCallback callback);

		// -(void)getCommentsWithRequestId:(NSString *)requestId withCallback:(ZDKRequestCommentListCallback)callback;
		[Export("getCommentsWithRequestId:withCallback:")]
		void GetCommentsWithRequestId(string requestId, ZDKRequestCommentListCallback callback);

		// -(void)getCommentsWithRequestId:(NSString *)requestId sinceDate:(NSDate *)sinceDate onlyAgent:(BOOL)onlyAgent withCallback:(ZDKRequestCommentListCallback)callback;
		[Export("getCommentsWithRequestId:sinceDate:onlyAgent:withCallback:")]
		void GetCommentsWithRequestId(string requestId, NSDate sinceDate, bool onlyAgent, ZDKRequestCommentListCallback callback);

		// -(void)addComment:(NSString *)comment forRequestId:(NSString *)requestId withCallback:(ZDKRequestAddCommentCallback)callback;
		[Export("addComment:forRequestId:withCallback:")]
		void AddComment(string comment, string requestId, ZDKRequestAddCommentCallback callback);

		// -(void)getTicketFormWithIds:(NSArray<NSNumber *> *)ticketFormIds callback:(ZDKTicketFormCallback)callback;
		//[Export("getTicketFormWithIds:callback:")]
		//void GetTicketFormWithIds(NSNumber[] ticketFormIds, ZDKTicketFormCallback callback);

		// -(void)addComment:(NSString *)comment forRequestId:(NSString *)requestId attachments:(NSArray *)attachments withCallback:(ZDKRequestAddCommentCallback)callback;
		[Export("addComment:forRequestId:attachments:withCallback:")]
		//[Verify (StronglyTypedNSArray)]
		void AddComment(string comment, string requestId, NSObject[] attachments, ZDKRequestAddCommentCallback callback);
	}

	// @interface ZDKUploadResponse : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface ZDKUploadResponse : INSCopying
	{
		// @property (copy, nonatomic) NSString * uploadToken;
		[Export("uploadToken")]
		string UploadToken { get; set; }

		// @property (nonatomic, strong) ZDKAttachment * attachment;
		[Export("attachment", ArgumentSemantic.Strong)]
		ZDKAttachment Attachment { get; set; }

		// -(instancetype)initWithDict:(NSDictionary *)dict;
		[Export("initWithDict:")]
		IntPtr Constructor(NSDictionary dict);
	}

	// typedef void (^ZDKUploadCallback)(ZDKUploadResponse *, NSError *);
	delegate void ZDKUploadCallback(ZDKUploadResponse arg0, NSError arg1);

	// typedef void (^ZDKDeleteUploadCallback)(NSString *, NSError *);
	delegate void ZDKDeleteUploadCallback(string arg0, NSError arg1);

	// @interface ZDKUploadProvider : ZDKProvider
	[BaseType(typeof(ZDKProvider))]
	interface ZDKUploadProvider
	{
		// -(void)uploadAttachment:(NSData *)attachment withFilename:(NSString *)filename andContentType:(NSString *)contentType callback:(ZDKUploadCallback)callback;
		[Export("uploadAttachment:withFilename:andContentType:callback:")]
		void UploadAttachment(NSData attachment, string filename, string contentType, ZDKUploadCallback callback);

		// -(void)deleteUpload:(NSString *)uploadToken andCallback:(ZDKDeleteUploadCallback)callback;
		[Export("deleteUpload:andCallback:")]
		void DeleteUpload(string uploadToken, ZDKDeleteUploadCallback callback);
	}

	// @interface ZDKRequestWithAttachmentsUtil : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKRequestWithAttachmentsUtil
	{
		// -(void)uploadAttachment:(NSData *)data withFilename:(NSString *)filename callback:(ZDKUploadCallback)callback;
		[Export("uploadAttachment:withFilename:callback:")]
		void UploadAttachment(NSData data, string filename, ZDKUploadCallback callback);

		// -(void)uploadAttachment:(NSData *)data withFilename:(NSString *)filename andContentType:(NSString *)contentType callback:(ZDKUploadCallback)callback;
		[Export("uploadAttachment:withFilename:andContentType:callback:")]
		void UploadAttachment(NSData data, string filename, string contentType, ZDKUploadCallback callback);

		// -(void)createRequest:(ZDKRequest *)request withTags:(NSArray *)tags andCallback:(ZDKCreateRequestCallback)callback;
		[Export("createRequest:withTags:andCallback:")]
		//[Verify (StronglyTypedNSArray)]
		void CreateRequest(ZDKRequest request, NSObject[] tags, ZDKCreateRequestCallback callback);

		// -(void)addComment:(ZDKComment *)comment forRequestId:(NSString *)requestId withCallback:(ZDKRequestAddCommentCallback)callback;
		[Export("addComment:forRequestId:withCallback:")]
		void AddComment(ZDKComment comment, string requestId, ZDKRequestAddCommentCallback callback);

		// -(void)deleteFilename:(NSString *)filename;
		[Export("deleteFilename:")]
		void DeleteFilename(string filename);

		// +(NSString *)MIMETypeForData:(NSData *)data;
		[Static]
		[Export("MIMETypeForData:")]
		string MIMETypeForData(NSData data);
	}

	// @interface ZDKRequestsResponse : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKRequestsResponse
	{
		// +(NSArray<ZDKRequest *> *)parseRequestListWithDictionary:(NSDictionary *)dictionary;
		[Static]
		[Export("parseRequestListWithDictionary:")]
		ZDKRequest[] ParseRequestListWithDictionary(NSDictionary dictionary);

		// +(NSArray<ZDKSupportUser *> *)parseRequestListAgentsWithDictionary:(NSDictionary *)dictionary;
		[Static]
		[Export("parseRequestListAgentsWithDictionary:")]
		ZDKSupportUser[] ParseRequestListAgentsWithDictionary(NSDictionary dictionary);
	}

	// @interface ZDKRequestsWithCommentingAgents : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKRequestsWithCommentingAgents
	{
		// @property (nonatomic, strong) NSArray<ZDKRequest *> * requests;
		[Export("requests", ArgumentSemantic.Strong)]
		ZDKRequest[] Requests { get; set; }

		// @property (nonatomic, strong) NSArray<ZDKSupportUser *> * commentingAgents;
		[Export("commentingAgents", ArgumentSemantic.Strong)]
		ZDKSupportUser[] CommentingAgents { get; set; }

		// -(instancetype)initWithRequests:(NSArray<ZDKRequest *> *)requests andCommentingAgents:(NSArray<ZDKSupportUser *> *)commentingAgents;
		[Export("initWithRequests:andCommentingAgents:")]
		IntPtr Constructor(ZDKRequest[] requests, ZDKSupportUser[] commentingAgents);
	}

	// @interface ZDKStringUtil : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKStringUtil
	{
		// +(NSString *)csvStringFromArray:(NSArray *)array;
		[Static]
		[Export("csvStringFromArray:")]
		//[Verify (StronglyTypedNSArray)]
		string CsvStringFromArray(NSObject[] array);
	}

	// @interface ZDKTicketField : NSObject <ZDKDictionaryCreatable>
	//[BaseType(typeof(NSObject))]
	//interface ZDKTicketField : IZDKDictionaryCreatable
	//{
	//	// @property (copy, nonatomic) NSNumber * fieldId;
	//	[Export("fieldId", ArgumentSemantic.Copy)]
	//	NSNumber FieldId { get; set; }

	//	// @property (copy, nonatomic) NSString * title;
	//	[Export("title")]
	//	string Title { get; set; }

	//	// @property (copy, nonatomic) NSString * titleInPortal;
	//	[Export("titleInPortal")]
	//	string TitleInPortal { get; set; }

	//	// @property (copy, nonatomic) NSString * fieldDescription;
	//	[Export("fieldDescription")]
	//	string FieldDescription { get; set; }

	//	// @property (copy, nonatomic) NSString * validationRegex;
	//	[Export("validationRegex")]
	//	string ValidationRegex { get; set; }

	//	// @property (assign, nonatomic) ZDKTicketFieldType type;
	//	[Export("type", ArgumentSemantic.Assign)]
	//	ZDKTicketFieldType Type { get; set; }

	//	// @property (assign, nonatomic) BOOL required;
	//	[Export("required")]
	//	bool Required { get; set; }

	//	// @property (copy, nonatomic) NSArray<ZDKTicketFieldOption *> * options;
	//	[Export("options", ArgumentSemantic.Copy)]
	//	ZDKTicketFieldOption[] Options { get; set; }

	//	// @property (copy, nonatomic) NSArray<ZDKTicketFieldSystemOption *> * systemOptions;
	//	[Export("systemOptions", ArgumentSemantic.Copy)]
	//	ZDKTicketFieldSystemOption[] SystemOptions { get; set; }

	//	// -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
	//	[Export("initWithDictionary:")]
	//	IntPtr Constructor(NSDictionary dictionary);
	//}

	// @interface ZDKTicketFieldOption : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKTicketFieldOption
	{
		// @property (copy, nonatomic) NSNumber * fieldOptionId;
		[Export("fieldOptionId", ArgumentSemantic.Copy)]
		NSNumber FieldOptionId { get; set; }

		// @property (copy, nonatomic) NSString * name;
		[Export("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * value;
		[Export("value")]
		string Value { get; set; }

		// @property (assign, nonatomic) BOOL isDefaultValue;
		[Export("isDefaultValue")]
		bool IsDefaultValue { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary dictionary);
	}

	// @interface ZDKTicketFieldSystemOption : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKTicketFieldSystemOption
	{
		// @property (copy, nonatomic) NSString * name;
		[Export("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * value;
		[Export("value")]
		string Value { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary dictionary);
	}

	// @interface ZDKTicketForm : NSObject <ZDKDictionaryCreatable>
	//[BaseType(typeof(NSObject))]
	//interface ZDKTicketForm : IZDKDictionaryCreatable
	//{
	//	// @property (copy, nonatomic) NSNumber * formId;
	//	[Export("formId", ArgumentSemantic.Copy)]
	//	NSNumber FormId { get; set; }

	//	// @property (copy, nonatomic) NSString * name;
	//	[Export("name")]
	//	string Name { get; set; }

	//	// @property (copy, nonatomic) NSString * displayName;
	//	[Export("displayName")]
	//	string DisplayName { get; set; }

	//	// @property (copy, nonatomic) NSArray<NSNumber *> * ticketFieldsIds;
	//	[Export("ticketFieldsIds", ArgumentSemantic.Copy)]
	//	NSNumber[] TicketFieldsIds { get; set; }

	//	// @property (copy, nonatomic) NSArray<ZDKTicketField *> * ticketFields;
	//	[Export("ticketFields", ArgumentSemantic.Copy)]
	//	ZDKTicketField[] TicketFields { get; set; }

	//	// -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
	//	[Export("initWithDictionary:")]
	//	IntPtr Constructor(NSDictionary dictionary);
	//}

	// @interface ZDKSupportUser : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKSupportUser
	{
		// @property (nonatomic, strong) NSNumber * userId;
		[Export("userId", ArgumentSemantic.Strong)]
		NSNumber UserId { get; set; }

		// @property (copy, nonatomic) NSString * name;
		[Export("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * avatarURL;
		[Export("avatarURL")]
		string AvatarURL { get; set; }

		// @property (assign, nonatomic) BOOL isAgent;
		[Export("isAgent")]
		bool IsAgent { get; set; }

		// @property (copy, nonatomic) NSArray * tags;
		[Export("tags", ArgumentSemantic.Copy)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] Tags { get; set; }

		// @property (copy, nonatomic) NSDictionary * userFields;
		[Export("userFields", ArgumentSemantic.Copy)]
		NSDictionary UserFields { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary dictionary);

		// -(NSDictionary *)toJson;
		[Export("toJson")]
		//[Verify (MethodToProperty)]
		NSDictionary ToJson { get; }
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const ZDKParameterValidationErrorDomain;
		[Field("ZDKParameterValidationErrorDomain", "__Internal")]
		NSString ZDKParameterValidationErrorDomain { get; }
	}

	// @interface ZDKValidator : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKValidator
	{
		// +(NSError *)validateValues:(NSDictionary *)parameterDictionarys;
		[Static]
		[Export("validateValues:")]
		NSError ValidateValues(NSDictionary parameterDictionarys);
	}

	//[Static]
	////[Verify (ConstantsInterfaceAssociation)]
	//partial interface Constants
	//{
	//	// extern const NSTimeInterval ZD_DefaultAnimationTime;
	//	[Field("ZD_DefaultAnimationTime", "__Internal")]
	//	double ZD_DefaultAnimationTime { get; }

	//	// extern NSString *const ZDKAPI_ConfigUpdated;
	//	[Field("ZDKAPI_ConfigUpdated", "__Internal")]
	//	NSString ZDKAPI_ConfigUpdated { get; }

	//	// extern NSString *const ZDKAPI_ConfigUpdateFailed;
	//	[Field("ZDKAPI_ConfigUpdateFailed", "__Internal")]
	//	NSString ZDKAPI_ConfigUpdateFailed { get; }

	//	// extern NSString *const ZDKAPI_RequestsUpdated;
	//	[Field("ZDKAPI_RequestsUpdated", "__Internal")]
	//	NSString ZDKAPI_RequestsUpdated { get; }

	//	// extern NSString *const ZDKAPI_UsersUpdated;
	//	[Field("ZDKAPI_UsersUpdated", "__Internal")]
	//	NSString ZDKAPI_UsersUpdated { get; }

	//	// extern NSString *const ZDKAPI_CommentListStarting;
	//	[Field("ZDKAPI_CommentListStarting", "__Internal")]
	//	NSString ZDKAPI_CommentListStarting { get; }

	//	// extern NSString *const ZDKAPI_CommentListSuccess;
	//	[Field("ZDKAPI_CommentListSuccess", "__Internal")]
	//	NSString ZDKAPI_CommentListSuccess { get; }

	//	// extern NSString *const ZDKAPI_CommentListError;
	//	[Field("ZDKAPI_CommentListError", "__Internal")]
	//	NSString ZDKAPI_CommentListError { get; }

	//	// extern NSString *const ZDKAPI_CommentSubmissionStarting;
	//	[Field("ZDKAPI_CommentSubmissionStarting", "__Internal")]
	//	NSString ZDKAPI_CommentSubmissionStarting { get; }

	//	// extern NSString *const ZDKAPI_CommentSubmissionSuccess;
	//	[Field("ZDKAPI_CommentSubmissionSuccess", "__Internal")]
	//	NSString ZDKAPI_CommentSubmissionSuccess { get; }

	//	// extern NSString *const ZDKAPI_CommentSubmissionError;
	//	[Field("ZDKAPI_CommentSubmissionError", "__Internal")]
	//	NSString ZDKAPI_CommentSubmissionError { get; }

	//	// extern NSString *const ZDKAPI_RequestSubmissionStarting;
	//	[Field("ZDKAPI_RequestSubmissionStarting", "__Internal")]
	//	NSString ZDKAPI_RequestSubmissionStarting { get; }

	//	// extern NSString *const ZDKAPI_RequestSubmissionSuccess;
	//	[Field("ZDKAPI_RequestSubmissionSuccess", "__Internal")]
	//	NSString ZDKAPI_RequestSubmissionSuccess { get; }

	//	// extern NSString *const ZDKAPI_RequestSubmissionError;
	//	[Field("ZDKAPI_RequestSubmissionError", "__Internal")]
	//	NSString ZDKAPI_RequestSubmissionError { get; }

	//	// extern NSString *const ZDKAPI_RequestsStarting;
	//	[Field("ZDKAPI_RequestsStarting", "__Internal")]
	//	NSString ZDKAPI_RequestsStarting { get; }

	//	// extern NSString *const ZDKAPI_RequestsSuccess;
	//	[Field("ZDKAPI_RequestsSuccess", "__Internal")]
	//	NSString ZDKAPI_RequestsSuccess { get; }

	//	// extern NSString *const ZDKAPI_RequestsError;
	//	[Field("ZDKAPI_RequestsError", "__Internal")]
	//	NSString ZDKAPI_RequestsError { get; }

	//	// extern NSString *const ZDKAPI_ReachabilityChangedNotification;
	//	[Field("ZDKAPI_ReachabilityChangedNotification", "__Internal")]
	//	NSString ZDKAPI_ReachabilityChangedNotification { get; }

	//	// extern NSString *const ZDKAPI_UploadAttachmentStarting;
	//	[Field("ZDKAPI_UploadAttachmentStarting", "__Internal")]
	//	NSString ZDKAPI_UploadAttachmentStarting { get; }

	//	// extern NSString *const ZDKAPI_UploadAttachmentSuccess;
	//	[Field("ZDKAPI_UploadAttachmentSuccess", "__Internal")]
	//	NSString ZDKAPI_UploadAttachmentSuccess { get; }

	//	// extern NSString *const ZDKAPI_UploadAttachmentError;
	//	[Field("ZDKAPI_UploadAttachmentError", "__Internal")]
	//	NSString ZDKAPI_UploadAttachmentError { get; }

	//	// extern NSString *const ZDKAPI_DeleteUploadStarting;
	//	[Field("ZDKAPI_DeleteUploadStarting", "__Internal")]
	//	NSString ZDKAPI_DeleteUploadStarting { get; }

	//	// extern NSString *const ZDKAPI_DeleteUploadSuccess;
	//	[Field("ZDKAPI_DeleteUploadSuccess", "__Internal")]
	//	NSString ZDKAPI_DeleteUploadSuccess { get; }

	//	// extern NSString *const ZDKAPI_DeleteUploadError;
	//	[Field("ZDKAPI_DeleteUploadError", "__Internal")]
	//	NSString ZDKAPI_DeleteUploadError { get; }

	//	// extern NSString *const ZDKAPI_RequestByIdStarting;
	//	[Field("ZDKAPI_RequestByIdStarting", "__Internal")]
	//	NSString ZDKAPI_RequestByIdStarting { get; }

	//	// extern NSString *const ZDKAPI_RequestByIdSuccess;
	//	[Field("ZDKAPI_RequestByIdSuccess", "__Internal")]
	//	NSString ZDKAPI_RequestByIdSuccess { get; }

	//	// extern NSString *const ZDKAPI_RequestByIdError;
	//	[Field("ZDKAPI_RequestByIdError", "__Internal")]
	//	NSString ZDKAPI_RequestByIdError { get; }

	//	// extern NSString *const ZDKAPI_AddUserTagsStarting;
	//	[Field("ZDKAPI_AddUserTagsStarting", "__Internal")]
	//	NSString ZDKAPI_AddUserTagsStarting { get; }

	//	// extern NSString *const ZDKAPI_AddUserTagsSuccess;
	//	[Field("ZDKAPI_AddUserTagsSuccess", "__Internal")]
	//	NSString ZDKAPI_AddUserTagsSuccess { get; }

	//	// extern NSString *const ZDKAPI_AddUserTagsFailure;
	//	[Field("ZDKAPI_AddUserTagsFailure", "__Internal")]
	//	NSString ZDKAPI_AddUserTagsFailure { get; }

	//	// extern NSString *const ZDKAPI_DeleteUserTagsStarting;
	//	[Field("ZDKAPI_DeleteUserTagsStarting", "__Internal")]
	//	NSString ZDKAPI_DeleteUserTagsStarting { get; }

	//	// extern NSString *const ZDKAPI_DeleteUserTagsSuccess;
	//	[Field("ZDKAPI_DeleteUserTagsSuccess", "__Internal")]
	//	NSString ZDKAPI_DeleteUserTagsSuccess { get; }

	//	// extern NSString *const ZDKAPI_DeleteUserTagsFailure;
	//	[Field("ZDKAPI_DeleteUserTagsFailure", "__Internal")]
	//	NSString ZDKAPI_DeleteUserTagsFailure { get; }

	//	// extern NSString *const ZDKAPI_GetUserFieldsStarting;
	//	[Field("ZDKAPI_GetUserFieldsStarting", "__Internal")]
	//	NSString ZDKAPI_GetUserFieldsStarting { get; }

	//	// extern NSString *const ZDKAPI_GetUserFieldsSuccess;
	//	[Field("ZDKAPI_GetUserFieldsSuccess", "__Internal")]
	//	NSString ZDKAPI_GetUserFieldsSuccess { get; }

	//	// extern NSString *const ZDKAPI_GetUserFieldsFailure;
	//	[Field("ZDKAPI_GetUserFieldsFailure", "__Internal")]
	//	NSString ZDKAPI_GetUserFieldsFailure { get; }

	//	// extern NSString *const ZDKAPI_SetUserFieldsStarting;
	//	[Field("ZDKAPI_SetUserFieldsStarting", "__Internal")]
	//	NSString ZDKAPI_SetUserFieldsStarting { get; }

	//	// extern NSString *const ZDKAPI_SetUserFieldsSuccess;
	//	[Field("ZDKAPI_SetUserFieldsSuccess", "__Internal")]
	//	NSString ZDKAPI_SetUserFieldsSuccess { get; }

	//	// extern NSString *const ZDKAPI_SetUserFieldsFailure;
	//	[Field("ZDKAPI_SetUserFieldsFailure", "__Internal")]
	//	NSString ZDKAPI_SetUserFieldsFailure { get; }

	//	// extern NSString *const ZDKAPI_GetUserStarting;
	//	[Field("ZDKAPI_GetUserStarting", "__Internal")]
	//	NSString ZDKAPI_GetUserStarting { get; }

	//	// extern NSString *const ZDKAPI_GetUserSuccess;
	//	[Field("ZDKAPI_GetUserSuccess", "__Internal")]
	//	NSString ZDKAPI_GetUserSuccess { get; }

	//	// extern NSString *const ZDKAPI_GetUserFailure;
	//	[Field("ZDKAPI_GetUserFailure", "__Internal")]
	//	NSString ZDKAPI_GetUserFailure { get; }

	//	// extern NSString *const ZD_HC_CategoriesStarting;
	//	[Field("ZD_HC_CategoriesStarting", "__Internal")]
	//	NSString ZD_HC_CategoriesStarting { get; }

	//	// extern NSString *const ZD_HC_CategoriesUpdated;
	//	[Field("ZD_HC_CategoriesUpdated", "__Internal")]
	//	NSString ZD_HC_CategoriesUpdated { get; }

	//	// extern NSString *const ZD_HC_SectionsStarting;
	//	[Field("ZD_HC_SectionsStarting", "__Internal")]
	//	NSString ZD_HC_SectionsStarting { get; }

	//	// extern NSString *const ZD_HC_SectionsUpdated;
	//	[Field("ZD_HC_SectionsUpdated", "__Internal")]
	//	NSString ZD_HC_SectionsUpdated { get; }

	//	// extern NSString *const ZD_HC_ArticlesStarting;
	//	[Field("ZD_HC_ArticlesStarting", "__Internal")]
	//	NSString ZD_HC_ArticlesStarting { get; }

	//	// extern NSString *const ZD_HC_ArticlesUpdated;
	//	[Field("ZD_HC_ArticlesUpdated", "__Internal")]
	//	NSString ZD_HC_ArticlesUpdated { get; }

	//	// extern NSString *const ZD_HC_ArticleByIdStarting;
	//	[Field("ZD_HC_ArticleByIdStarting", "__Internal")]
	//	NSString ZD_HC_ArticleByIdStarting { get; }

	//	// extern NSString *const ZD_HC_ArticleByIdSuccess;
	//	[Field("ZD_HC_ArticleByIdSuccess", "__Internal")]
	//	NSString ZD_HC_ArticleByIdSuccess { get; }

	//	// extern NSString *const ZD_HC_AttachmentsStarting;
	//	[Field("ZD_HC_AttachmentsStarting", "__Internal")]
	//	NSString ZD_HC_AttachmentsStarting { get; }

	//	// extern NSString *const ZD_HC_AttachmentsUpdated;
	//	[Field("ZD_HC_AttachmentsUpdated", "__Internal")]
	//	NSString ZD_HC_AttachmentsUpdated { get; }

	//	// extern NSString *const ZD_HC_AttachmentsErrored;
	//	[Field("ZD_HC_AttachmentsErrored", "__Internal")]
	//	NSString ZD_HC_AttachmentsErrored { get; }

	//	// extern NSString *const ZD_HC_SearchStarting;
	//	[Field("ZD_HC_SearchStarting", "__Internal")]
	//	NSString ZD_HC_SearchStarting { get; }

	//	// extern NSString *const ZD_HC_SearchSuccess;
	//	[Field("ZD_HC_SearchSuccess", "__Internal")]
	//	NSString ZD_HC_SearchSuccess { get; }

	//	// extern NSString *const ZD_HC_CategorySelected;
	//	[Field("ZD_HC_CategorySelected", "__Internal")]
	//	NSString ZD_HC_CategorySelected { get; }

	//	// extern NSString *const ZD_HC_CategoryByIdStarting;
	//	[Field("ZD_HC_CategoryByIdStarting", "__Internal")]
	//	NSString ZD_HC_CategoryByIdStarting { get; }

	//	// extern NSString *const ZD_HC_CategoryByIdSuccess;
	//	[Field("ZD_HC_CategoryByIdSuccess", "__Internal")]
	//	NSString ZD_HC_CategoryByIdSuccess { get; }

	//	// extern NSString *const ZD_HC_SectionSelected;
	//	[Field("ZD_HC_SectionSelected", "__Internal")]
	//	NSString ZD_HC_SectionSelected { get; }

	//	// extern NSString *const ZD_HC_SectionArticle;
	//	[Field("ZD_HC_SectionArticle", "__Internal")]
	//	NSString ZD_HC_SectionArticle { get; }

	//	// extern NSString *const ZD_HC_SectionByIdStarting;
	//	[Field("ZD_HC_SectionByIdStarting", "__Internal")]
	//	NSString ZD_HC_SectionByIdStarting { get; }

	//	// extern NSString *const ZD_HC_SectionByIdSuccess;
	//	[Field("ZD_HC_SectionByIdSuccess", "__Internal")]
	//	NSString ZD_HC_SectionByIdSuccess { get; }

	//	// extern NSString *const ZD_HC_DeflectionSearchStarting;
	//	[Field("ZD_HC_DeflectionSearchStarting", "__Internal")]
	//	NSString ZD_HC_DeflectionSearchStarting { get; }

	//	// extern NSString *const ZD_HC_DeflectionSearchSuccess;
	//	[Field("ZD_HC_DeflectionSearchSuccess", "__Internal")]
	//	NSString ZD_HC_DeflectionSearchSuccess { get; }

	//	// extern NSString *const ZD_HC_DeflectionSearchError;
	//	[Field("ZD_HC_DeflectionSearchError", "__Internal")]
	//	NSString ZD_HC_DeflectionSearchError { get; }

	//	// extern NSString *const ZD_HC_UpvoteStarting;
	//	[Field("ZD_HC_UpvoteStarting", "__Internal")]
	//	NSString ZD_HC_UpvoteStarting { get; }

	//	// extern NSString *const ZD_HC_UpvoteSuccess;
	//	[Field("ZD_HC_UpvoteSuccess", "__Internal")]
	//	NSString ZD_HC_UpvoteSuccess { get; }

	//	// extern NSString *const ZD_HC_UpvoteError;
	//	[Field("ZD_HC_UpvoteError", "__Internal")]
	//	NSString ZD_HC_UpvoteError { get; }

	//	// extern NSString *const ZD_HC_DownvoteStarting;
	//	[Field("ZD_HC_DownvoteStarting", "__Internal")]
	//	NSString ZD_HC_DownvoteStarting { get; }

	//	// extern NSString *const ZD_HC_DownvoteSuccess;
	//	[Field("ZD_HC_DownvoteSuccess", "__Internal")]
	//	NSString ZD_HC_DownvoteSuccess { get; }

	//	// extern NSString *const ZD_HC_DownvoteError;
	//	[Field("ZD_HC_DownvoteError", "__Internal")]
	//	NSString ZD_HC_DownvoteError { get; }

	//	// extern NSString *const ZD_HC_VoteDeleteStarting;
	//	[Field("ZD_HC_VoteDeleteStarting", "__Internal")]
	//	NSString ZD_HC_VoteDeleteStarting { get; }

	//	// extern NSString *const ZD_HC_VoteDeleteSuccess;
	//	[Field("ZD_HC_VoteDeleteSuccess", "__Internal")]
	//	NSString ZD_HC_VoteDeleteSuccess { get; }

	//	// extern NSString *const ZD_HC_VoteDeleteError;
	//	[Field("ZD_HC_VoteDeleteError", "__Internal")]
	//	NSString ZD_HC_VoteDeleteError { get; }

	//	// extern NSString *const ZD_HC_RequestError;
	//	[Field("ZD_HC_RequestError", "__Internal")]
	//	NSString ZD_HC_RequestError { get; }

	//	// extern NSString *const ZD_ResignFirstResponder;
	//	[Field("ZD_ResignFirstResponder", "__Internal")]
	//	NSString ZD_ResignFirstResponder { get; }

	//	// extern NSString *const ZDK_Header_Suffix_Format;
	//	[Field("ZDK_Header_Suffix_Format", "__Internal")]
	//	NSString ZDK_Header_Suffix_Format { get; }

	//	// extern const NSInteger ZDCharacterLimitForUserAgentHeader;
	//	[Field("ZDCharacterLimitForUserAgentHeader", "__Internal")]
	//	nint ZDCharacterLimitForUserAgentHeader { get; }

	//	// extern NSString *const ZDD_HTTPPost;
	//	[Field("ZDD_HTTPPost", "__Internal")]
	//	NSString ZDD_HTTPPost { get; }

	//	// extern NSString *const ZDD_HTTPGet;
	//	[Field("ZDD_HTTPGet", "__Internal")]
	//	NSString ZDD_HTTPGet { get; }

	//	// extern NSString *const ZDD_HTTPPut;
	//	[Field("ZDD_HTTPPut", "__Internal")]
	//	NSString ZDD_HTTPPut { get; }

	//	// extern NSString *const ZDD_HTTPDelete;
	//	[Field("ZDD_HTTPDelete", "__Internal")]
	//	NSString ZDD_HTTPDelete { get; }

	//	// extern NSString *const ZDD_ContentType;
	//	[Field("ZDD_ContentType", "__Internal")]
	//	NSString ZDD_ContentType { get; }

	//	// extern NSString *const ZDD_ContentLength;
	//	[Field("ZDD_ContentLength", "__Internal")]
	//	NSString ZDD_ContentLength { get; }

	//	// extern NSString *const ZDD_Accept;
	//	[Field("ZDD_Accept", "__Internal")]
	//	NSString ZDD_Accept { get; }

	//	// extern NSString *const ZDD_TypeJSON;
	//	[Field("ZDD_TypeJSON", "__Internal")]
	//	NSString ZDD_TypeJSON { get; }

	//	// extern NSString *const ZDD_UserAgent;
	//	[Field("ZDD_UserAgent", "__Internal")]
	//	NSString ZDD_UserAgent { get; }

	//	// extern NSString *const ZDD_AcceptLanguage;
	//	[Field("ZDD_AcceptLanguage", "__Internal")]
	//	NSString ZDD_AcceptLanguage { get; }

	//	// extern NSString *const ZDD_ClientIdentifier;
	//	[Field("ZDD_ClientIdentifier", "__Internal")]
	//	NSString ZDD_ClientIdentifier { get; }

	//	// extern NSString *const ZDD_MIMETypeJPEG;
	//	[Field("ZDD_MIMETypeJPEG", "__Internal")]
	//	NSString ZDD_MIMETypeJPEG { get; }

	//	// extern NSString *const ZDD_MIMETypePNG;
	//	[Field("ZDD_MIMETypePNG", "__Internal")]
	//	NSString ZDD_MIMETypePNG { get; }

	//	// extern NSString *const ZDD_MIMETypeGIF;
	//	[Field("ZDD_MIMETypeGIF", "__Internal")]
	//	NSString ZDD_MIMETypeGIF { get; }

	//	// extern NSString *const ZDD_MIMETypeTIFF;
	//	[Field("ZDD_MIMETypeTIFF", "__Internal")]
	//	NSString ZDD_MIMETypeTIFF { get; }

	//	// extern NSString *const ZDD_ERROR_Domain;
	//	[Field("ZDD_ERROR_Domain", "__Internal")]
	//	NSString ZDD_ERROR_Domain { get; }

	//	// extern NSString *const ZDD_ERROR_Key;
	//	[Field("ZDD_ERROR_Key", "__Internal")]
	//	NSString ZDD_ERROR_Key { get; }

	//	// extern NSString *const ZDD_Validator_Error_Key;
	//	[Field("ZDD_Validator_Error_Key", "__Internal")]
	//	NSString ZDD_Validator_Error_Key { get; }

	//	// extern NSString *const iOS7AppStoreURLFormat;
	//	[Field("iOS7AppStoreURLFormat", "__Internal")]
	//	NSString iOS7AppStoreURLFormat { get; }

	//	// extern NSString *const iOSAppStoreURLFormat;
	//	[Field("iOSAppStoreURLFormat", "__Internal")]
	//	NSString iOSAppStoreURLFormat { get; }

	//	// extern NSString *const ZDSDKUserDefaultsKey;
	//	[Field("ZDSDKUserDefaultsKey", "__Internal")]
	//	NSString ZDSDKUserDefaultsKey { get; }

	//	// extern NSString *const ZDK_AUTHENTICATION_JWT;
	//	[Field("ZDK_AUTHENTICATION_JWT", "__Internal")]
	//	NSString ZDK_AUTHENTICATION_JWT { get; }

	//	// extern NSString *const ZDK_AUTHENTICATION_ANONYMOUS;
	//	[Field("ZDK_AUTHENTICATION_ANONYMOUS", "__Internal")]
	//	NSString ZDK_AUTHENTICATION_ANONYMOUS { get; }

	//	// extern const NSInteger ZDK_Article_Down_Vote_Number;
	//	[Field("ZDK_Article_Down_Vote_Number", "__Internal")]
	//	nint ZDK_Article_Down_Vote_Number { get; }

	//	// extern const NSInteger ZDK_Article_Up_Vote_Number;
	//	[Field("ZDK_Article_Up_Vote_Number", "__Internal")]
	//	nint ZDK_Article_Up_Vote_Number { get; }

	//	// extern const NSInteger ZDK_Article_Even_Vote_Number;
	//	[Field("ZDK_Article_Even_Vote_Number", "__Internal")]
	//	nint ZDK_Article_Even_Vote_Number { get; }

	//	// extern const NSUInteger ZDK_Article_Down_Vote_Button_Index;
	//	[Field("ZDK_Article_Down_Vote_Button_Index", "__Internal")]
	//	nuint ZDK_Article_Down_Vote_Button_Index { get; }

	//	// extern const NSUInteger ZDK_Article_Up_Vote_Button_Index;
	//	[Field("ZDK_Article_Up_Vote_Button_Index", "__Internal")]
	//	nuint ZDK_Article_Up_Vote_Button_Index { get; }
	//}

	// @interface ZDKAttachmentSettings : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKAttachmentSettings
	{
		// @property (readonly, nonatomic) BOOL enabled;
		[Export("enabled")]
		bool Enabled { get; }

		// @property (readonly, nonatomic) NSInteger maxAttachmentSize;
		[Export("maxAttachmentSize")]
		nint MaxAttachmentSize { get; }
	}

	// @interface ZDKContactUsSettings : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKContactUsSettings
	{
		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull tags;
		[Export("tags", ArgumentSemantic.Copy)]
		string[] Tags { get; }

		// -(instancetype _Nonnull)initWith:(NSArray<NSString *> * _Nonnull)tags __attribute__((objc_designated_initializer));
		[Export("initWith:")]
		[DesignatedInitializer]
		IntPtr Constructor(string[] tags);
	}

	// @interface ZDKConversationsSettings : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKConversationsSettings
	{
		// @property (readonly, nonatomic) BOOL enabled;
		[Export("enabled")]
		bool Enabled { get; }
	}

	// @interface ZDKCustomField : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKCustomField
	{
		// @property (readonly, nonatomic) int64_t fieldId;
		[Export("fieldId")]
		long FieldId { get; }

		// @property (readonly, nonatomic) id _Nullable value;
		[NullAllowed, Export("value")]
		NSObject Value { get; }

		// -(instancetype _Nonnull)initWithFieldId:(NSNumber * _Nonnull)fieldId value:(id _Nullable)value;
		[Export("initWithFieldId:value:")]
		IntPtr Constructor(NSNumber fieldId, [NullAllowed] NSObject value);

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary<NSString, NSObject> dictionary);

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull customFieldDictionary;
		[Export("customFieldDictionary", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> CustomFieldDictionary { get; }
	}

	// @interface DispatcherAdapter : NSObject
	//[BaseType(typeof(NSObject), Name = "_TtC19SupportProvidersSDK17DispatcherAdapter")]
	//interface DispatcherAdapter
	//{
	//	// +(void)performRequestWithZendesk:(ZDKZendesk * _Nonnull)zendesk urlRequest:(NSURLRequest * _Nonnull)urlRequest requiresAuth:(BOOL)requiresAuth completionHandler:(void (^ _Nonnull)(NSURLResponse * _Nullable, NSData * _Nullable, NSError * _Nullable))completionHandler;
	//	[Static]
	//	[Export("performRequestWithZendesk:urlRequest:requiresAuth:completionHandler:")]
	//	void PerformRequestWithZendesk(ZDKZendesk zendesk, NSUrlRequest urlRequest, bool requiresAuth, Action<NSURLResponse, NSData, NSError> completionHandler);

	//	// +(NSError * _Nullable)convertErrorWithResponse:(NSURLResponse * _Nullable)response originalError:(NSError * _Nullable)error __attribute__((warn_unused_result));
	//	[Static]
	//	[Export("convertErrorWithResponse:originalError:")]
	//	[return: NullAllowed]
	//	NSError ConvertErrorWithResponse([NullAllowed] NSUrlResponse response, [NullAllowed] NSError error);

	//	// +(void)clearSettingsAndSession;
	//	[Static]
	//	[Export("clearSettingsAndSession")]
	//	void ClearSettingsAndSession();
	//}

	// @interface HTMLSanitizer : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC19SupportProvidersSDK13HTMLSanitizer")]
	interface HTMLSanitizer
	{
		// +(NSString * _Nonnull)cleanWithHtml:(NSString * _Nonnull)html __attribute__((warn_unused_result));
		[Static]
		[Export("cleanWithHtml:")]
		string CleanWithHtml(string html);
	}

	// @interface ZDKHelpCenterArticleViewModel : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKHelpCenterArticleViewModel
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull section_id;
		[Export("section_id")]
		string Section_id { get; }

		// +(NSArray<ZDKHelpCenterArticleViewModel *> * _Nonnull)convertWithArticles:(NSArray<ZDKHelpCenterArticle *> * _Nonnull)articles __attribute__((warn_unused_result));
		[Static]
		[Export("convertWithArticles:")]
		ZDKHelpCenterArticleViewModel[] ConvertWithArticles(ZDKHelpCenterArticle[] articles);
	}

	// @interface ZDKHelpCenterBlips : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKHelpCenterBlips
	{
	}

	// @interface SupportProvidersSDK_Swift_1423 (ZDKHelpCenterBlips)
	[Category]
	[BaseType(typeof(ZDKHelpCenterBlips))]
	interface ZDKHelpCenterBlips_SupportProvidersSDK_Swift_1423
	{
		// +(void)blipArticleViewed:(NSString * _Nonnull)pageTitle url:(NSString * _Nonnull)url navigatorLanguage:(NSString * _Nonnull)navigatorLanguage;
		[Static]
		[Export("blipArticleViewed:url:navigatorLanguage:")]
		void BlipArticleViewed(string pageTitle, string url, string navigatorLanguage);

		// +(void)blipSearchQuery:(NSString * _Nonnull)query;
		[Static]
		[Export("blipSearchQuery:")]
		void BlipSearchQuery(string query);

		// +(void)blipArticleVote:(NSString * _Nonnull)articleId vote:(NSInteger)vote;
		[Static]
		[Export("blipArticleVote:vote:")]
		void BlipArticleVote(string articleId, nint vote);
	}

	// @interface ZDKHelpCenterCategoryViewModel : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKHelpCenterCategoryViewModel
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; }

		// @property (copy, nonatomic) NSArray<ZDKHelpCenterSectionViewModel *> * _Nonnull sections;
		[Export("sections", ArgumentSemantic.Copy)]
		ZDKHelpCenterSectionViewModel[] Sections { get; set; }

		// -(ZDKHelpCenterCategoryViewModel * _Nonnull)updateWithSection:(ZDKHelpCenterSectionViewModel * _Nonnull)newSection __attribute__((warn_unused_result));
		[Export("updateWithSection:")]
		ZDKHelpCenterCategoryViewModel UpdateWithSection(ZDKHelpCenterSectionViewModel newSection);
	}

	// @interface ZDKHelpCenterCategoryViewModelContainer : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKHelpCenterCategoryViewModelContainer
	{
		// +(NSArray<ZDKHelpCenterCategoryViewModel *> * _Nullable)parseWithData:(NSData * _Nonnull)data error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result));
		[Static]
		[Export("parseWithData:error:")]
		[return: NullAllowed]
		ZDKHelpCenterCategoryViewModel[] ParseWithData(NSData data, [NullAllowed] out NSError error);
	}

	// @interface ZDKHelpCenterSectionViewModel : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKHelpCenterSectionViewModel
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSArray<ZDKHelpCenterArticleViewModel *> * _Nonnull articles;
		[Export("articles", ArgumentSemantic.Copy)]
		ZDKHelpCenterArticleViewModel[] Articles { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull category_id;
		[Export("category_id")]
		string Category_id { get; }

		// @property (readonly, nonatomic) NSInteger article_count;
		[Export("article_count")]
		nint Article_count { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull detailTitle;
		[Export("detailTitle")]
		string DetailTitle { get; }

		// -(ZDKHelpCenterSectionViewModel * _Nonnull)sectionByReplacingWithArticles:(NSArray<ZDKHelpCenterArticleViewModel *> * _Nonnull)articles __attribute__((warn_unused_result));
		[Export("sectionByReplacingWithArticles:")]
		ZDKHelpCenterSectionViewModel SectionByReplacingWithArticles(ZDKHelpCenterArticleViewModel[] articles);

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);
	}

	// @interface ZDKHelpCenterSettings : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterSettings
	{
		// @property (readonly, nonatomic) BOOL helpCenterArticleVotingEnabled;
		[Export("helpCenterArticleVotingEnabled")]
		bool HelpCenterArticleVotingEnabled { get; }

		// @property (readonly, nonatomic) BOOL enabled;
		[Export("enabled")]
		bool Enabled { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull locale;
		[Export("locale")]
		string Locale { get; }
	}

	// @interface ZDKLegacyRequestStorageMigrator : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKLegacyRequestStorageMigrator
	{
		// -(instancetype _Nonnull)initWithRequestStorage:(ZDKRequestStorage * _Nonnull)requestStorage __attribute__((objc_designated_initializer));
		[Export("initWithRequestStorage:")]
		[DesignatedInitializer]
		IntPtr Constructor(ZDKRequestStorage requestStorage);
	}

	// @interface SupportProvidersSDK_Swift_1482 (ZDKLegacyRequestStorageMigrator)
	[Category]
	[BaseType(typeof(ZDKLegacyRequestStorageMigrator))]
	interface ZDKLegacyRequestStorageMigrator_SupportProvidersSDK_Swift_1482
	{
		// -(void)checkAndMigrateOldTicketIds;
		[Export("checkAndMigrateOldTicketIds")]
		void CheckAndMigrateOldTicketIds();
	}

	// @interface ZDKRequestBlips : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKRequestBlips
	{
	}

	// @interface SupportProvidersSDK_Swift_1494 (ZDKRequestBlips)
	[Category]
	[BaseType(typeof(ZDKRequestBlips))]
	interface ZDKRequestBlips_SupportProvidersSDK_Swift_1494
	{
		// +(void)requestCreatedBlip:(NSString * _Nonnull)requestId;
		[Static]
		[Export("requestCreatedBlip:")]
		void RequestCreatedBlip(string requestId);

		// +(void)requestUpdateBlip:(NSString * _Nonnull)requestId;
		[Static]
		[Export("requestUpdateBlip:")]
		void RequestUpdateBlip(string requestId);
	}

	// @interface ZDKRequestForStorage : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKRequestForStorage
	{
	}

	// @interface SupportProvidersSDK_Swift_1508 (ZDKRequestForStorage)
	[Category]
	[BaseType(typeof(ZDKRequestForStorage))]
	interface ZDKRequestForStorage_SupportProvidersSDK_Swift_1508
	{
		// +(ZDKRequestForStorage * _Nonnull)createFromRequest:(ZDKRequest * _Nonnull)request readCommentCount:(NSInteger)readCommentCount __attribute__((warn_unused_result));
		[Static]
		[Export("createFromRequest:readCommentCount:")]
		ZDKRequestForStorage CreateFromRequest(ZDKRequest request, nint readCommentCount);

		// -(void)incrementCommentCounts;
		[Export("incrementCommentCounts")]
		void IncrementCommentCounts();
	}

	// @interface ZDKRequestStorage : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKRequestStorage
	{
		// -(instancetype _Nonnull)initWithZendesk:(ZDKZendesk * _Nonnull)zendesk;
		[Export("initWithZendesk:")]
		IntPtr Constructor(ZDKZendesk zendesk);

		// -(ZDKRequestForStorage * _Nullable)getRequestForId:(NSString * _Nonnull)requestId __attribute__((warn_unused_result));
		[Export("getRequestForId:")]
		[return: NullAllowed]
		ZDKRequestForStorage GetRequestForId(string requestId);
	}

	// @interface SupportProvidersSDK_Swift_1523 (ZDKRequestStorage)
	//[Category]
	//[BaseType(typeof(ZDKRequestStorage))]
	//interface ZDKRequestStorage_SupportProvidersSDK_Swift_1523
	//{
	//	// -(NSArray<NSString *> * _Nonnull)getRequestIds __attribute__((warn_unused_result));
	//	[Export("getRequestIds")]
	//	//[Verify (MethodToProperty)]
	//	string[] RequestIds { get; }

	//	// -(BOOL)storeRequest:(ZDKRequestForStorage * _Nullable)request;
	//	[Export("storeRequest:")]
	//	bool StoreRequest([NullAllowed] ZDKRequestForStorage request);

	//	// -(BOOL)storeRequestsAndResetCacheTime:(NSArray<ZDKRequestForStorage *> * _Nonnull)requests;
	//	[Export("storeRequestsAndResetCacheTime:")]
	//	bool StoreRequestsAndResetCacheTime(ZDKRequestForStorage[] requests);
	//}

	// @interface ZDKRequestUpdates : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKRequestUpdates
	{
		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSNumber *> * _Nonnull requestUpdates;
		[Export("requestUpdates", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSNumber> RequestUpdates { get; }

		// @property (readonly, nonatomic) NSInteger totalUpdates;
		[Export("totalUpdates")]
		nint TotalUpdates { get; }

		// -(BOOL)isRequestUnread:(NSString * _Nonnull)requestId __attribute__((warn_unused_result));
		[Export("isRequestUnread:")]
		bool IsRequestUnread(string requestId);

		// -(BOOL)hasUpdatedRequests __attribute__((warn_unused_result));
		[Export("hasUpdatedRequests")]
		//[Verify (MethodToProperty)]
		bool HasUpdatedRequests { get; }
	}

	// @interface ZDKSupport : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKSupport
	{
		// @property (copy, nonatomic) NSString * _Nullable helpCenterLocaleOverride;
		[NullAllowed, Export("helpCenterLocaleOverride")]
		string HelpCenterLocaleOverride { get; set; }

		// +(void)initializeWithZendesk:(ZDKZendesk * _Nullable)zendesk;
		[Static]
		[Export("initializeWithZendesk:")]
		void InitializeWithZendesk([NullAllowed] ZDKZendesk zendesk);

		// @property (readonly, nonatomic, strong, class) ZDKSupport * _Nullable instance;
		[Static]
		[NullAllowed, Export("instance", ArgumentSemantic.Strong)]
		ZDKSupport Instance { get; }

		// -(BOOL)refreshRequestWithRequestId:(NSString * _Nonnull)requestId __attribute__((warn_unused_result));
		[Export("refreshRequestWithRequestId:")]
		bool RefreshRequestWithRequestId(string requestId);
	}

	// @interface ZDKSupportSettings : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKSupportSettings
	{
		// @property (readonly, nonatomic) BOOL neverRequestEmail;
		[Export("neverRequestEmail")]
		bool NeverRequestEmail { get; }

		// @property (readonly, nonatomic) BOOL showClosedRequests;
		[Export("showClosedRequests")]
		bool ShowClosedRequests { get; }

		// @property (readonly, nonatomic) BOOL showReferrerLogo;
		[Export("showReferrerLogo")]
		bool ShowReferrerLogo { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull referrerUrl;
		[Export("referrerUrl")]
		string ReferrerUrl { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull systemMessage;
		[Export("systemMessage")]
		string SystemMessage { get; }

		// @property (readonly, nonatomic, strong) ZDKConversationsSettings * _Nonnull conversationSettings;
		[Export("conversationSettings", ArgumentSemantic.Strong)]
		ZDKConversationsSettings ConversationSettings { get; }

		// @property (readonly, nonatomic, strong) ZDKAttachmentSettings * _Nonnull attachmentSettings;
		[Export("attachmentSettings", ArgumentSemantic.Strong)]
		ZDKAttachmentSettings AttachmentSettings { get; }

		// @property (readonly, nonatomic, strong) ZDKTicketFormsSettings * _Nonnull ticketFormsSettings;
		[Export("ticketFormsSettings", ArgumentSemantic.Strong)]
		ZDKTicketFormsSettings TicketFormsSettings { get; }

		// @property (readonly, nonatomic, strong) ZDKContactUsSettings * _Nonnull contactUsSettings;
		[Export("contactUsSettings", ArgumentSemantic.Strong)]
		ZDKContactUsSettings ContactUsSettings { get; }
	}

	// @interface ZDKTicketFormsSettings : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKTicketFormsSettings
	{
		// @property (readonly, nonatomic) BOOL available;
		[Export("available")]
		bool Available { get; }
	}

	// @interface ZDKAttachmentSettingsProvider : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC19SupportProvidersSDK29ZDKAttachmentSettingsProvider")]
	interface ZDKAttachmentSettingsProvider
	{
		// +(void)getAttachmentSettingsWithCallback:(void (^ _Nonnull)(ZDKAttachmentSettings * _Nullable))callback;
		[Static]
		[Export("getAttachmentSettingsWithCallback:")]
		void GetAttachmentSettingsWithCallback(Action<ZDKAttachmentSettings> callback);
	}

	// @interface ZDKContactUsSettingsProvider : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC19SupportProvidersSDK28ZDKContactUsSettingsProvider")]
	interface ZDKContactUsSettingsProvider
	{
		// +(void)getContactUsSettingsWithCallback:(void (^ _Nonnull)(ZDKContactUsSettings * _Nullable))callback;
		[Static]
		[Export("getContactUsSettingsWithCallback:")]
		void GetContactUsSettingsWithCallback(Action<ZDKContactUsSettings> callback);
	}

	// @interface ZDKConversationsSettingsProvider : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC19SupportProvidersSDK32ZDKConversationsSettingsProvider")]
	interface ZDKConversationsSettingsProvider
	{
		// +(void)getConversationsSettingsWithCallback:(void (^ _Nonnull)(ZDKConversationsSettings * _Nullable))callback;
		[Static]
		[Export("getConversationsSettingsWithCallback:")]
		void GetConversationsSettingsWithCallback(Action<ZDKConversationsSettings> callback);
	}

	// @interface ZDKHelpCenterSettingsProvider : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC19SupportProvidersSDK29ZDKHelpCenterSettingsProvider")]
	interface ZDKHelpCenterSettingsProvider
	{
		// +(void)getHelpCenterSettingsWithCallback:(void (^ _Nonnull)(ZDKHelpCenterSettings * _Nullable))callback;
		[Static]
		[Export("getHelpCenterSettingsWithCallback:")]
		void GetHelpCenterSettingsWithCallback(Action<ZDKHelpCenterSettings> callback);
	}

	// @interface SupportProvidersSDK_Swift_1639 (ZDKRequestProvider)
	[Category]
	[BaseType(typeof(ZDKRequestProvider))]
	interface ZDKRequestProvider_SupportProvidersSDK_Swift_1639
	{
		// -(void)getUpdatesForDeviceWithCallback:(void (^ _Nonnull)(ZDKRequestUpdates * _Nullable))callback;
		[Export("getUpdatesForDeviceWithCallback:")]
		void GetUpdatesForDeviceWithCallback(Action<ZDKRequestUpdates> callback);

		// -(void)markRequestAsRead:(NSString * _Nonnull)requestId withCommentCount:(NSInteger)commentCount;
		[Export("markRequestAsRead:withCommentCount:")]
		void MarkRequestAsRead(string requestId, nint commentCount);

		// -(void)markRequestAsUnread:(NSString * _Nonnull)requestId;
		[Export("markRequestAsUnread:")]
		void MarkRequestAsUnread(string requestId);

		// -(void)updateRequestStorageWithRequests:(NSArray<ZDKRequest *> * _Nonnull)requests;
		[Export("updateRequestStorageWithRequests:")]
		void UpdateRequestStorageWithRequests(ZDKRequest[] requests);
	}

	// @interface ZDKSupportSettingsProvider : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC19SupportProvidersSDK26ZDKSupportSettingsProvider")]
	interface ZDKSupportSettingsProvider
	{
		// +(void)getSupportSettingsWithCallback:(void (^ _Nonnull)(ZDKSupportSettings * _Nullable))callback;
		[Static]
		[Export("getSupportSettingsWithCallback:")]
		void GetSupportSettingsWithCallback(Action<ZDKSupportSettings> callback);
	}

	// @interface ZDKTicketFormsSettingsProvider : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC19SupportProvidersSDK30ZDKTicketFormsSettingsProvider")]
	interface ZDKTicketFormsSettingsProvider
	{
		// +(void)getTicketFormsSettingsWithCallback:(void (^ _Nonnull)(ZDKTicketFormsSettings * _Nullable))callback;
		[Static]
		[Export("getTicketFormsSettingsWithCallback:")]
		void GetTicketFormsSettingsWithCallback(Action<ZDKTicketFormsSettings> callback);
	}
}

