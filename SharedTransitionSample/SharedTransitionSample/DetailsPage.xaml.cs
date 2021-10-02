using Xamarin.Forms;

namespace SharedTransitionSample
{
    public partial class DetailsPage : ContentPage
    {
        internal DetailsPage(Item item)
        {
            InitializeComponent();
            color.BackgroundColor = item.Color;
            colorName.Text = item.Name;
        }
    }
}
