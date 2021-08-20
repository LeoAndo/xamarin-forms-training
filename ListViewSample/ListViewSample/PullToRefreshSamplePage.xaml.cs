using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewSample
{
    public partial class PullToRefreshSamplePage : ContentPage
    {
        public PullToRefreshSamplePage()
        {
            InitializeComponent();
        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem != null)
            {
                // Deselect item.
                ((ListView)sender).SelectedItem = null;

                // Set WebView source to RSS item
                RssItemViewModel rssItem = (RssItemViewModel)args.SelectedItem;

                // For iOS 9, a NSAppTransportSecurity key was added to 
                //  Info.plist to allow accesses to EarthObservatory.nasa.gov sites.
                webView.Source = rssItem.Link;

                // Hide and make visible.
                rssLayout.IsVisible = false;
                webLayout.IsVisible = true;
            }
        }

        void OnBackButtonClicked(object sender, EventArgs args)
        {
            // Hide and make visible.
            webLayout.IsVisible = false;
            rssLayout.IsVisible = true;
        }
    }
}
