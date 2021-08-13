using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBindingSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Set the binding context: target is Label; source is Slider.
            label.BindingContext = slider;
            // Bind the properties: target is Opacity; source is Value.
            label.SetBinding(Label.OpacityProperty, "Value");
        }
    }
}
