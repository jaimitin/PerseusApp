using OPerseiMAUI.Pages;

namespace OPerseiMAUI
{
    public partial class App : Application
    {
        public App(IServiceProvider provider)
        {
            InitializeComponent();

            ServiceProvider = provider;

            MainPage = new AppShell();
        }

        public static IServiceProvider ServiceProvider { get; private set; }
    }
}