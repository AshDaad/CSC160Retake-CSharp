using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ValueConverterDemo.Converters
{
    public class BoolToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SolidColorBrush scb = null;

            if(targetType == typeof(Brush))
            {
                bool boolVal = (bool)value;

                //Pro Tip: You can use a ternary here to set the brush
                scb = boolVal ? Brushes.Yellow : Brushes.Purple;
            }

            return scb;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
