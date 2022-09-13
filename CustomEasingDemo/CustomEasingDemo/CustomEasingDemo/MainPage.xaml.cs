using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomEasingDemo
{
    public partial class MainPage : ContentPage
    {
        private Random random = new Random();
        public MainPage()
        {
            InitializeComponent();
        }

        async void buttonCustomEasing1_Clicked(System.Object sender, System.EventArgs e)
        {
            double scale = Math.Min(Width / buttonCustomEasing1.Width, Height / buttonCustomEasing1.Height);
            Console.WriteLine("scale: {0}", scale);
            await buttonCustomEasing1.ScaleTo(scale, 1000, new Easing(t => (int)(5 * t) / 5.0));
            await buttonCustomEasing1.ScaleTo(1, 1000, (Easing)RandomEase);
        }
        double RandomEase(double t)
        {
            Console.WriteLine("IN RandomEase t: {0}", t);
            double ret = t == 0 || t == 1 ? t : t + 0.25 * (random.NextDouble() - 0.5);
            Console.WriteLine("IN RandomEase ret: {0}", ret);
            return ret;
        }
    }
}

