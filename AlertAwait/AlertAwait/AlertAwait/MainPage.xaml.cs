using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlertAwait
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("Button_Clicked IN");
            Task<bool> task = DisplayAlert("Simple Alert", "Decide on an option", "yes or ok", "no or cancel");
            label.Text = "Alert is currently displayed";

            bool result = await task; // 処理結果をまつ。 ワーカースレッドで実行される
            Console.WriteLine("await result {0}", result);
            label.Text = String.Format("Alert {0} button was pressed", result ? "OK" : "Cancel"); // UIスレッドで実行される

            Console.WriteLine("Button_Clicked OUT");
        }
    }
}

