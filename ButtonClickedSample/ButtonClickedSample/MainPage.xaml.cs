using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace ButtonClickedSample
{
    public partial class MainPage : ContentPage
    {
        StackLayout loggerlayout = new StackLayout();
        public MainPage()
        {
            InitializeComponent();
            scrollView.Content = loggerlayout;
            this.Padding = new Thickness(0, (Device.RuntimePlatform == Device.iOS) ? 46 : 12, 0, 0);

            lambdaHandlerButton.Clicked += (sender, args) =>
            {
                Debug.WriteLine("lambdaHandlerButton#Clicked");
            };
        }

        // object senderにはイベント発行元であるオブジェクトが渡ってくる。今回の場合、Button
        // EventArgs e には、イベントに関する追加情報がわたってくる。
        void OnButtonClicked(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            if (button == addButton)
            {
                Label label = new Label();
                label.Text = "Button clicked at " + DateTime.Now.ToString("HH:mm:ss");
                loggerlayout.Children.Add(label);
            }
            else if (button == removeButton)
            {
                loggerlayout.Children.RemoveAt(0);
            }
            else if (button == removeEventButton)
            {
                addButton.Clicked -= OnButtonClicked;
            }

            removeButton.IsEnabled = loggerlayout.Children.Count > 0;
        }
    }
}
