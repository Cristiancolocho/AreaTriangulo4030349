using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace AreaTriangulo4030349.Converters
{
    public class NullToStringConverter : IValueConverter
    {
        // Convert method is used for converting from the source data type to the target data type
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Check if the value is of type double and is not NaN (Not a Number)
            if (value is double d && !double.IsNaN(d))
                return d.ToString("F2"); // Format the double to 2 decimal places

            return string.Empty; // Return an empty string if the value is null or NaN
        }

        // ConvertBack method is used for converting from the target data type back to the source data type
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException(); 
        }
    }
}
