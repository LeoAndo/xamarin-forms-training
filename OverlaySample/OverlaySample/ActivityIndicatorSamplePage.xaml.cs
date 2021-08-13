using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OverlaySample
{
    public partial class ActivityIndicatorSamplePage : ContentPage
    {
        public ActivityIndicatorSamplePage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            // Show overlay with ActivityIndicator.
            overlay.IsVisible = true;
            indicator.IsRunning = overlay.IsVisible;

            TimeSpan duration = TimeSpan.FromSeconds(3);
            DateTime startTime = DateTime.Now;

            // Start timer. 0.1秒間隔で定期処理を行う
            Device.StartTimer(TimeSpan.FromSeconds(0.1), () =>
            {
                double progress = (DateTime.Now - startTime).TotalMilliseconds /
                                  duration.TotalMilliseconds;
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
