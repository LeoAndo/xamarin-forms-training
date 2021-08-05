using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

            // event hook: page size changed.
            SizeChanged += (object sender, EventArgs e) =>
            {
                Debug.WriteLine("Width: " + this.Width + " Hight: " + this.Height);
            };

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
