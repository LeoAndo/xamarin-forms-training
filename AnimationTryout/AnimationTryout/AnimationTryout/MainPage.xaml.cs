using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnimationTryout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void buttonAnimate_Clicked(System.Object sender, System.EventArgs e)
        {
            buttonAnimate.RotateTo(360);
        }

        async void buttonAsyncAnimate_Clicked(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("IN buttonAsyncAnimate_Clicked!");
            await buttonAsyncAnimate.RotateTo(90, 250); // 時計回り
            await buttonAsyncAnimate.RotateTo(-90, 500); // 反時計回り
            await buttonAsyncAnimate.RotateTo(0, 250); // 元の位置に戻る
            Console.WriteLine("OUT buttonAsyncAnimate_Clicked!");
        }

        void buttonCancelAnimate_Clicked(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("IN buttonCancelAnimate_Clicked!");
            ViewExtensions.CancelAnimations(buttonAsyncAnimate);
            Console.WriteLine("OUT buttonCancelAnimate_Clicked!");
        }

        async void buttonCombineAnimate_Clicked(System.Object sender, System.EventArgs e)
        {
            buttonCombineAnimate.Rotation = 0;
            await Task.WhenAny<bool>
                ( // 引数内のTaskが同時に実行される！
                buttonCombineAnimate.RotateTo(360, 1000, easing: Easing.BounceOut),
                buttonCombineAnimate.ScaleTo(5, 3000)
                );
            await buttonCombineAnimate.ScaleTo(1, 1000);
        }
    }
}

