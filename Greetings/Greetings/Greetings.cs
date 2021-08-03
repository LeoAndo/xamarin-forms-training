using System;

using Xamarin.Forms;

namespace Greetings
{
    public class Greetings : ContentPage
    {
        [Obsolete]
        public Greetings()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Greetings, xamarin.Forms!"}
                }
            };
            Device.OnPlatform(iOS: () =>
            {
                Padding = new Thickness(0, 60, 0, 0);
            });
        }
    }
}

