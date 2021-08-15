using System;
using System.Diagnostics;
using System.Globalization;
using Xamarin.Forms;

namespace ValueConverterSample
{
    public class IntToBoolConverter : IValueConverter
    {
        public IntToBoolConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.WriteLine("Convert value: " + value + " targetType: " + targetType + " parameter: " + parameter + " culture: " + culture);
            return (int)value != 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.WriteLine("ConvertBack value: " + value + " targetType: " + targetType + " parameter: " + parameter + " culture: " + culture);
            return (bool)value ? 1 : 0;
        }
    }
}
