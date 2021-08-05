using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ButtonClickedSample
{
    public partial class MainPage : ContentPage
    {
        StackLayout loggerlayout = new StackLayout();
        public MainPage()
        {
            InitializeComponent();
            scrollView.Content = loggerlayout;
            this.Padding = new Thickness(0, (Device.RuntimePlatform == Device.iOS) ? 46 : 12, 0, 0);

            lambdaHandlerButton.Clicked += (sender, args) =>
            {
                Debug.WriteLine("lambdaHandlerButton#Clicked");
            };
        }

        void OnButtonClicked(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            if (button == addButton)
            {
                Label label = new Label();
                label.Text = "Button clicked at " + DateTime.Now.ToString("HH:mm:ss");
                loggerlayout.Children.Add(label);
            }
            else
            {
                loggerlayout.Children.RemoveAt(0);
            }

            removeButton.IsEnabled = loggerlayout.Children.Count > 0;
        }
    }
}
