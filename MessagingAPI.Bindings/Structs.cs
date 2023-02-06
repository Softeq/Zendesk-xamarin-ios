using ObjCRuntime;

namespace MessagingAPI.Bindings
{
    [Native]
    public enum ZDKApplicationEvent : long
    {
        WillEnterForeground = 0,
        DidEnterBackground = 1
    }
}
