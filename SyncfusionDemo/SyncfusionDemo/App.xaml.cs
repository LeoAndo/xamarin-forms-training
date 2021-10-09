using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SyncfusionDemo
{
    public partial class App : Application
    {
        public App()
        {
            // TODO Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
