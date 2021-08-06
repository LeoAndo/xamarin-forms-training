using System;
using Xamarin.Forms;
using UIKit;

[assembly: Dependency(typeof(DependencyServiceSample.iOS.PlatformInfo))]

namespace DependencyServiceSample.iOS
{
    public class PlatformInfo : IPlatformInfo
    {
        UIDevice device = new UIDevice();

        public string GetModel()
        {
            return device.Model.ToString();
        }

        public string GetVersion()
        {
            return String.Format(
                "{0} {1}",
                device.SystemName,
                device.SystemVersion);
        }
    }
}
