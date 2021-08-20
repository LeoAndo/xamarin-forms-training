using System;

using Xamarin.Forms;

namespace ListViewSample
{
    public partial class PullToRefreshSamplePage : ContentPage
    {
        public PullToRefreshSamplePage()
        {
            InitializeComponent();
            int verticalSize = (Device.RuntimePlatform == Device.iOS) ? 60 : 20;
            Padding = new Thickness(0, verticalSize);
        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem != null)
            {
                // セルの選択の解除
                ((ListView)sender).SelectedItem = null;

                // WebView source として RSS itemを設定
                RssItemViewModel rssItem = (RssItemViewModel)args.SelectedItem;

                // ForiOS 9
                // EarthObservatory.nasa.gov サイトにアクセスするための
                // NSAppTransportSecurity key がInfo.plistに追加されている
                webView.Source = rssItem.Link;

                // 表示の切り替え(WebView表示)
                rssLayout.IsVisible = false;
                webLayout.IsVisible = true;
            }
        }

        void OnBackButtonClicked(object sender, EventArgs args)
        {
            // 表示の切り替え(Rssの表示)
            webLayout.IsVisible = false;
            rssLayout.IsVisible = true;
        }
    }
}
