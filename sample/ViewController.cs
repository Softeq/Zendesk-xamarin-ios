using ChatProvidersSDK.Bindings;
using ChatSDK.Bindings;
using Foundation;
using MessagingAPI.Bindings;
using MessagingSDK.Bindings;
using SDKConfigurations.Bindings;
using SupportProvidersSDK.Bindings;
using SupportSDK.Bindings;
using System;
using UIKit;

namespace SampleApp
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            ZDKChatEngine engine = ZDKChatEngine.EngineAndReturnError(out var engineError);
            if (engineError != null)
            {
                throw new Exception("error during engine creation", new NSErrorException(engineError));
            }

            ZDKEngine[] engines = new ZDKEngine[] { engine };
            ZDKConfiguration[] configs = new ZDKConfiguration[0];

            var controller = ZDKMessaging.Instance.BuildUIWithEngines(engines, configs, out var controllerError);
            if (controllerError != null)
            {
                throw new Exception("error during controller creation", new NSErrorException(controllerError));
            }

            PresentViewController(controller, false, null);
        }
    }
}
