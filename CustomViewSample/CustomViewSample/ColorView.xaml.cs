using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CustomViewSample
{
    public partial class ColorView : ContentView
    {
        string colorName;
        ColorTypeConverter converter = new ColorTypeConverter();

        public ColorView()
        {
            InitializeComponent();
        }

        // 独自のプロパティを作成
        public string ColorName
        {
            set
            {
                // 名前を設定
                colorName = value;
                colorNameLabel.Text = value;

                // 実際のColorを取得し、他のviewを設定
                Color color = (Color)converter.ConvertFromInvariantString(colorName);
                boxView.Color = color;

                colorValueLabel.Text =
                    String.Format(
                        "{0:X2}-{1:X2}-{2:X2}",
                        (int)(255 * color.R),
                        (int)(255 * color.G),
                        (int)(255 * color.B)
                    );
            }
            get
            {
                return colorName;
            }
        }
    }
}
