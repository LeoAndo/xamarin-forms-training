using System;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace ClockSample
{
    public class DateTimeViewModel : INotifyPropertyChanged
    {
        private int counter;
        DateTime dateTime = DateTime.Now;
        public event PropertyChangedEventHandler PropertyChanged;

        public DateTimeViewModel()
        {
            Debug.WriteLine("call constractor!");
            Device.StartTimer(TimeSpan.FromMilliseconds(800), OnTimerTick);
            counter = 0;
        }

        private bool OnTimerTick()
        {
            Debug.WriteLine("call OnTimerTick");
            DateTime = DateTime.Now;
            counter++;
            if (counter < 100)
            {
                return true; // true: Timerの定期処理を続ける
            }
            else
            {
                return false;
            }
        }

        public DateTime DateTime
        {
            private set
            {
                Debug.WriteLine("call set dateTime: " + dateTime + " value: " + value);
                if (dateTime != value)
                {
                    dateTime = value;
                }

                // イベントを発行
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateTime"));
            }

            get => dateTime;
        }
    }
}
