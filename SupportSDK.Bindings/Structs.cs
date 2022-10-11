using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using ObjCRuntime;
using UIKit;

namespace SupportSDK.Bindings
{
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
}
