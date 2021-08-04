using System;

using Xamarin.Forms;

namespace Greetings
{
    public class Greetings : ContentPage
    {
        // [Obsolete]
        public Greetings()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Greetings, xamarin.Forms!",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        FontAttributes = FontAttributes.Bold | FontAttributes.Italic

                    }
                }
            };
            // iOSだけ固有の設定を行う.
            //Device.OnPlatform(iOS: () =>
            //{
            //    Padding = new Thickness(0, 60, 0, 0);
            //});
        }
    }
}

