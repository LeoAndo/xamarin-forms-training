using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ApplicatinScopeStyleSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            int verticalSize = (Device.RuntimePlatform == Device.iOS) ? 32 : 0;
            this.Padding = new Thickness(0, verticalSize);
        }
    }
}
