using System;

using ObjCRuntime;
using Foundation;
using UIKit;
using ZendeskCoreSDK.Bindings;

namespace SupportSDK.Bindings
{
    [Native]
	public enum ZDKNavBarCreateRequestUIType : ulong
	{
		LocalizedLabel,
		Image
	}

	[Native]
	public enum ZDKContactUsVisibility : ulong
	{
		ArticleListAndArticle,
		ArticleListOnly,
		Off
	}

	[Native]
	public enum ZDKHelpCenterError : ulong
	{
		InvalidCategoryIds = 100,
		InvalidSectionIds,
		NoArticlesForLabels,
		EmptyHelpCenter
	}

	[Native]
	public enum ZDKLayoutGuideApplicatorPosition : ulong
	{
		Top,
		Bottom
	}

	//static class CFunctions
	//{
	//	// CGRect CGRectMakeCenteredInScreen (CGFloat width, CGFloat height);
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern CGRect CGRectMakeCenteredInScreen(nfloat width, nfloat height);

	//	// CGRect CGMakeCenteredRectInRect (CGFloat width, CGFloat height, CGRect rect);
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern CGRect CGMakeCenteredRectInRect(nfloat width, nfloat height, CGRect rect);

	//	// CGRect CGMakeCenteredRectOnXInRect (CGFloat width, CGFloat height, CGFloat y, CGRect frame);
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern CGRect CGMakeCenteredRectOnXInRect(nfloat width, nfloat height, nfloat y, CGRect frame);

	//	// CGRect CGCenterRectInRect (CGRect rect, CGRect inRect);
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern CGRect CGCenterRectInRect(CGRect rect, CGRect inRect);

	//	// BOOL ZDKUIIsLandscape ();
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern bool ZDKUIIsLandscape();

	//	// CGRect ZDKUIScreenFrame ();
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern CGRect ZDKUIScreenFrame();

	//	// CGPoint ZDKUIOriginInWindow (UIView *view);
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern CGPoint ZDKUIOriginInWindow(UIView view);
	//}

	[Native]
	public enum ZDKFileType : long
	{
		Png = 0,
		Jpg = 1,
		Pdf = 2,
		Plain = 3,
		Word = 4,
		Excel = 5,
		Powerpoint = 6,
		PowerpointX = 7,
		Keynote = 8,
		Pages = 9,
		Numbers = 10,
		Binary = 11,
		Heic = 12
	}
}

