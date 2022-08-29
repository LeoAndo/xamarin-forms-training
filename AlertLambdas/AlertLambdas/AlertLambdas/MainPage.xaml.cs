using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlertLambdas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            // 非同期処理 - ラムダで書くパターン
            Task<bool> task = DisplayAlert("Simple Alert", "Decide on an option", "yes or ok", "no or cancel");
            task.ContinueWith((Task<bool> taskResult) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    label.Text = String.Format("Alert {0} button was pressed", taskResult.Result ? "OK" : "Cancel");
                });
            });

            label.Text = "Alert is currently displayed";

        }
    }
}

