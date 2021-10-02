using System.Linq;
using Xamarin.Forms;
using Plugin.SharedTransitions;

namespace SharedTransitionSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void MyItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any())
            {
                list.SelectedItem = null;
                var selectedItem = e.CurrentSelection.FirstOrDefault() as Item;
                SharedTransitionNavigationPage.SetTransitionSelectedGroup(
                    this, selectedItem.Id.ToString());
                await Navigation.PushAsync(new DetailsPage(selectedItem));
            }
        }
    }
}
