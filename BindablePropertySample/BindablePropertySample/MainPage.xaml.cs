using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindablePropertySample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            int wordcount = countedLabel.WordCount;
            wordCountLabel.Text = wordcount + " words";
        }
    }
}
