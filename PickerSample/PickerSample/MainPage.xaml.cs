using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Picker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            Picker picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            string selectedItem = picker.Items[selectedIndex];
            PropertyInfo info = typeof(Keyboard).GetRuntimeProperty(selectedItem);
            entry.Keyboard = (Keyboard)info.GetValue(null);

            Debug.WriteLine("Picker_SelectedIndexChanged! selectedItem: " + selectedItem);
        }
    }
}
