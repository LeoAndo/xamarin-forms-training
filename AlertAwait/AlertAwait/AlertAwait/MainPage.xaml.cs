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

        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("Button_Clicked_1 IN");
            await MyMethodAsync();
            string result = await MyMethodAsync2();
            Console.WriteLine("result: {0}", result);
            string result2 = await MyMethodAsync3();
            Console.WriteLine("result2: {0}", result2);
            Console.WriteLine("Button_Clicked_1 OUT");

        }

        // void: 戻り値なし
        private Task MyMethodAsync()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("MyMethodAsync: ワーカースレッドで実行する処理をここで行う");
            });
        }
        // 戻り値あり
        private Task<string> MyMethodAsync2()
        {
            return Task<string>.Run(() =>
            {
                Console.WriteLine("MyMethodAsync2: ワーカースレッドで実行する処理をここで行う");
                return "Hello, Async task";
            });
        }

        // 戻り値あり & 中でawaitを使うパターン
        private Task<string> MyMethodAsync3()
        {
            return Task<string>.Run(async () =>
            {
                Console.WriteLine("MyMethodAsync3: ワーカースレッドで実行する処理をここで行う");
                await Task.Delay(1000);
                return "Hello, Async task";
            });
        }
    }
}

