using ObjCRuntime;

namespace MessagingSDK.Bindings
{
    [Native]
    public enum ZDKMessagingUIEvent : long
    {
        DidLoad = 0,
        WillAppear = 1,
        DidAppear = 2,
        WillDisappear = 3,
        DidDisappear = 4,
        DidLayoutSubviews = 5,
        ControllerDidClose = 6
    }
}
