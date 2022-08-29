using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlertCallbacks
{
    public partial class MainPage : ContentPage
    {
        bool result;
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Task<bool> task = DisplayAlert("Simple Alert", "Decide on an option", "yes or ok", "no or cancel");
            task.ContinueWith(AlertDismissedCallback);
            label.Text = "Alert is currently displayed";
        }

        private void AlertDismissedCallback(Task<bool> task)
        {
            result = task.Result;
            Device.BeginInvokeOnMainThread(DisplayResultCallback);
        }

        private void DisplayResultCallback()
        {
            label.Text = String.Format("Alert {0} button was pressed", result ? "OK" : "Cancel");
        }
    }
}

