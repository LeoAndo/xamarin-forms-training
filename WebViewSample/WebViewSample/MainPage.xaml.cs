using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebViewSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnEntryCompleted(System.Object sender, System.EventArgs e)
        {
            Entry entry = (Entry)sender;
            webView.Source = entry.Text;
        }

        void OnGoBackClicked(System.Object sender, System.EventArgs e)
        {
            webView.GoBack();
        }

        void OnGoForwardClicked(System.Object sender, System.EventArgs e)
        {
            webView.GoForward();
        }
    }
}
