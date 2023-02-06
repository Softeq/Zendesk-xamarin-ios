using ObjCRuntime;

namespace ChatProvidersSDK.Bindings
{
    [Native]
    public enum ZDKChatAccountStatus : long
    {
        nline = 0,
        ffline = 1
    }

    [Native]
    public enum ZDKAuthenticationErrorCode : long
    {
        InvalidAccountKey = 500,
        InvalidAccessToken = 501,
        InvalidEmail = 502,
        InvalidName = 503,
        InvalidSharedSecret = 504,
        TokenHasExpired = 505,
        ExternalUserIdHasChanged = 506,
        InternalServerError = 507,
        InternalError = 508,
        NetworkError = 509
    }

    [Native]
    public enum ChatError : long
    {
        ChatIsNotInitialized = 0,
        Disconnected = 1
    }

    [Native]
    public enum ZDKChatLogType : long
    {
        Message = 0,
        AttachmentMessage = 1,
        MemberJoin = 2,
        MemberLeave = 3,
        OptionsMessage = 4,
        ChatComment = 5,
        ChatRating = 6,
        ChatRatingRequest = 7
    }

    [Native]
    public enum ZDKChatParticipant : long
    {
        Agent = 0,
        Visitor = 1,
        Trigger = 2,
        System = 3
    }

    [Native]
    public enum ChatSessionStatus : long
    {
        Initializing = 0,
        Configuring = 1,
        Started = 2,
        Ending = 3,
        Ended = 4
    }

    [Native]
    public enum ZDKConnectionStatus : long
    {
        Connecting = 0,
        Connected = 1,
        Disconnected = 2,
        Reconnecting = 3,
        Failed = 4,
        Unreachable = 5
    }

    [Native]
    public enum ZDKChatLogLevel : long
    {
        Verbose = 2,
        Debug = 3,
        Info = 4,
        Warning = 5,
        Error = 6
    }

    [Native]
    public enum ZDKPushNotificationType : long
    {
        ChatEnded = 0,
        Message = 1
    }

    [Native]
    public enum ZDKDeliveryStatus : long
    {
        Pending = 0,
        Delivered = 1,
        Failed = 2
    }

    [Native]
    public enum ZDKDepartmentStatus : long
    {
        Offline = 0,
        Online = 1,
        Away = 2
    }

    [Native]
    public enum ZDKRating : long
    {
        None = 0,
        Good = 1,
        Bad = 2
    }
}
