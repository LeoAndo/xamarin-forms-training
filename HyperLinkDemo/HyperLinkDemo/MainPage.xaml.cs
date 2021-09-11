using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HyperLinkDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            float topPadding = (Device.RuntimePlatform == Device.iOS) ? 60 : 0;
            Padding = new Thickness(0, topPadding, 0, 0);
        }
    }
}
