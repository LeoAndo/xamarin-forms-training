using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            listView.ItemsSource = new List<Color>
            {
                Color.Red,Color.Blue, Color.Aqua, Color.Black, Color.Brown,
                Color.Red,Color.Blue, Color.Aqua, Color.Black, Color.Brown,
                Color.Red,Color.Blue, Color.Aqua, Color.Black, Color.Brown,
                Color.Red,Color.Blue, Color.Aqua, Color.Black, Color.Brown,
            };
        }

        void listView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Debug.WriteLine("IN listView_ItemTapped");
        }

        void listView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Debug.WriteLine("IN listView_ItemSelected");
        }
    }
}