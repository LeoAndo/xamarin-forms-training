using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimerSample
{
    public partial class MainPage : ContentPage
    {
        // constructor
        public MainPage()
        {
            InitializeComponent();
            // Start the timer going.
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                // Set the Tex property of the Label.
                clock.Text = DateTime.Now.ToString("HH:mm:ss");
                return true; // runs again, or false to stop
            });
        }
    }
}
