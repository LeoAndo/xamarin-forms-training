using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DynamicStyleSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            int verticalPadding = Device.RuntimePlatform == Device.iOS ? 32 : 0;
            this.Padding = new Thickness(0, verticalPadding);
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Resources["buttonStyle"] = Resources["buttonStyle1"];
            Resources["undefinedButtonStyle"] = Resources["buttonStyle1"];
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            Resources["buttonStyle"] = Resources["buttonStyle2"];
            Resources["undefinedButtonStyle"] = Resources["buttonStyle2"];
        }

        void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            Resources["buttonStyle"] = Resources["buttonStyle3"];
            Resources["undefinedButtonStyle"] = Resources["buttonStyle3"];
        }

        void OnResetStyleAction(System.Object sender, System.EventArgs e)
        {
            Resources["buttonStyle"] = null; // nullセットでxamarinのデフォのスタイルに戻す。
            Resources["undefinedButtonStyle"] = null;
        }
    }
}
