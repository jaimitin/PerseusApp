using Acr.UserDialogs;
using Android.App;
using Android.Runtime;

namespace PerseusMAUI.Platforms.Android
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership) : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp()
        {
            UserDialogs.Init(this);

            return MauiProgram.CreateMauiApp();
        }
    }
}