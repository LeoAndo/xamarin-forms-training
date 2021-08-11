using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BitmapSample
{
    public partial class ImageResourcePage : ContentPage
    {
        public ImageResourcePage()
        {
            InitializeComponent();
            imagePokemon.Source = ImageSource.FromResource("BitmapSample.Images.pokemon_500.png");
        }

        void renderSize_SizeChanged(System.Object sender, System.EventArgs e)
        {
            Image image = (Image)sender;
            renderSize.Text = String.Format("Render size = {0:F0} x {1:F0}", image.Width, image.Height);
        }
    }
}
