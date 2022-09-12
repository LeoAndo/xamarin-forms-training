using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnimationTryout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void buttonAnimate_Clicked(System.Object sender, System.EventArgs e)
        {
            buttonAnimate.RotateTo(360);
        }
    }
}

