using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace WPF_Task_10_1.Models
{
    [ValueConversion(typeof(string), typeof(Brush))]
    public class BoolToBackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string message)
            {
                if (message.Contains("успешно", StringComparison.OrdinalIgnoreCase))
                    return Brushes.LightGreen;

                if (message.Contains("ошибка", StringComparison.OrdinalIgnoreCase) ||
                    message.Contains("неверный", StringComparison.OrdinalIgnoreCase))
                    return Brushes.LightPink;
            }
            
            return Brushes.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}