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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTE1NTc2QDMxMzkyZTMzMmUzMGx3TC91VENVdlR4Z0Z4VmZpWkFKMzlXbzNkaWIxVG1sTGZRS1YrQm5nSkk9");
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
