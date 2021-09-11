using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HyperLinkDemo
{
    // Spanコントローラの派生クラスを作成し、新規でUrlプロパティを作成し、タップすると、
    // Launcher.OpenAsyncが呼ばれURLを処理できる外部アプリを起動する.
    public class HyperlinkSpan : Span
    {
        public static readonly BindableProperty UrlProperty = BindableProperty.Create(nameof(Url), typeof(string), typeof(HyperlinkSpan), null);

        public string Url
        {
            get { return (string)GetValue(UrlProperty); }
            set { SetValue(UrlProperty, value); }
        }

        public HyperlinkSpan()
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
