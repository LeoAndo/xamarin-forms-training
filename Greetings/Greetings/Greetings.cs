using System;

using Xamarin.Forms;

namespace Greetings
{
    public class Greetings : ContentPage
    {
        public Greetings()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Greetings, xamarin.Forms!"}
                }
            };
        }
    }
}

