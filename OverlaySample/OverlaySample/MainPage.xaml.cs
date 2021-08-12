using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OverlaySample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // ProgressBarのPropertyに0-1の値を設定することができる。0-100ではないので注意！
        void OnButtonClicked(object sender, EventArgs args)
        {
            // Show overlay with ProgressBar.
            overlay.IsVisible = true;

            TimeSpan duration = TimeSpan.FromSeconds(5);
            DateTime startTime = DateTime.Now;

            // Start timer. 0.1秒間隔で定期処理を行う
            Device.StartTimer(TimeSpan.FromSeconds(0.1), () =>
            {
                double progress = (DateTime.Now - startTime).TotalMilliseconds /
                                  duration.TotalMilliseconds;
                progressBar.Progress = progress;
                bool continueTimer = progress < 1;

                if (!continueTimer)
                {
                    // Hide overlay.  progressがMax値に達したら..
                    overlay.IsVisible = false;
                }
                return continueTimer;
            });
        }
    }
}
