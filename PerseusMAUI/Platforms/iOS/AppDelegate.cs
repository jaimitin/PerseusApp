using Foundation;
using UIKit;

namespace PerseusMAUI.Platforms.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp()
        {
            return MauiProgram.CreateMauiApp();
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            return base.FinishedLaunching(application, launchOptions);
        }
    }
}