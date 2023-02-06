using System;
using ChatProvidersSDK.Bindings;
using Foundation;

namespace SampleApp
{
    public class CustomAuthenticator : ZDKJWTAuthenticator
    {
        public override void GetToken(Action<NSString, NSError> completion)
        {
            NSData data = NSData.FromUrl(new NSUrl("https://enter.url.to/jwt/provider"));
            var token = NSString.FromData(data, NSStringEncoding.UTF8);

            completion(token, null);
        }
    }
}
