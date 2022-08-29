using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TaskDelayClock
{
    public partial class MainPage : ContentPage
    {
        Random random = new Random();

        public MainPage()
        {
            InitializeComponent();

            InfiniteLoop();
        }

        async void InfiniteLoop()
        {
            while (true)
            {
                label.Text = DateTime.Now.ToString("T");
                label.FontSize = random.Next(12, 49);
                AbsoluteLayout.SetLayoutBounds(label, new Rectangle(random.NextDouble(),
                                                                    random.NextDouble(),
                                                                    AbsoluteLayout.AutoSize,
                                                                    AbsoluteLayout.AutoSize));
                await Task.Delay(250);
            }
        }
    }
}

