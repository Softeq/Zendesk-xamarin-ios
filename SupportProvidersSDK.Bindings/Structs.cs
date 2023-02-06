using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace SupportProvidersSDK.Bindings
{
    [Native]
    public enum ZDKAuthenticationType : ulong
    {
        Unknown,
        Jwt,
        Anonymous
    }

    [Native]
    public enum ZDKAPILoginState : long
    {
        NotLoggedIn,
        LoggingIn,
        LoggedIn
    }

    [Native]
    public enum ZDKHelpCenterOverviewGroupType : ulong
    {
        Default,
        Section,
        Category
    }

    [Native]
    public enum ZDKNavBarConversationsUIType : ulong
    {
        LocalizedLabel,
        Image,
        None
    }

    [Native]
    public enum ZDKNetworkStatus : ulong
    {
        NotReachable,
        ReachableViaWiFi,
        ReachableViaWWAN
    }

    [Native]
    public enum ZDKTicketFieldType : ulong
    {
        Subject,
        Description,
        Regex,
        TextArea,
        Text,
        Checkbox,
        ComboBox,
        Integer,
        Decimal,
        Date,
        CreditCard,
        Priority,
        Status,
        TicketType,
        MultiSelect,
        Unknown = ulong.MaxValue
    }

    [Native]
    public enum ZDKValidation : ulong
    {
        NilError,
        EmptyStringError
    }
}
