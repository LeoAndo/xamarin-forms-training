using System;
using Xamarin.Forms;
using Android.OS;

[assembly: Dependency(typeof(DependencyServiceSample.Droid.PlatformInfo))]

namespace DependencyServiceSample.Droid
{
    public class PlatformInfo : IPlatformInfo
    {
        public string GetModel()
        {
            return String.Format("{0} {1}", Build.Manufacturer, Build.Model);
        }

        public string GetVersion()
        {
            return Build.VERSION.Release.ToString();
        }
    }
}
