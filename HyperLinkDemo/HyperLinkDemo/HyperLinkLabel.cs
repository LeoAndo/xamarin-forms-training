using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HyperLinkDemo
{
    // Labelコントローラの派生クラスを作成し、新規でUrlプロパティを作成し、タップすると、
    // Launcher.OpenAsyncが呼ばれURLを処理できる外部アプリを起動する.
    public class HyperlinkLabel : Label
    {
        public static readonly BindableProperty UrlProperty = BindableProperty.Create(nameof(Url), typeof(string), typeof(HyperlinkLabel), null);

        public string Url
        {
            get { return (string)GetValue(UrlProperty); }
            set { SetValue(UrlProperty, value); }
        }

        public HyperlinkLabel()
        {
            TextDecorations = TextDecorations.Underline;
            TextColor = Color.Blue;
            GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () => await Launcher.OpenAsync(Url))
            });

        }
    }
}
