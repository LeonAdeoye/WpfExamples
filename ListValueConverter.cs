using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfExamples
{
    internal class ListValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(targetType != typeof(string))
                throw new InvalidOperationException("Target is not a string");
            if (value == null)
                return 20;

            return value.ToString() switch
            {
                "One" => 1,
                "Two" => 2,
                "Three" => 3,
                _ => 4,
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
