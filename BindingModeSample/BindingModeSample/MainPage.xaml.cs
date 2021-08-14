using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindingModeSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            int randomValue = new Random().Next(1, 51);
            Debug.WriteLine("randomValue: " + randomValue);
            slider1.Value = randomValue;
            slider2.Value = randomValue;
            label3.FontSize = randomValue;
            label4.FontSize = randomValue;
        }
    }
}
