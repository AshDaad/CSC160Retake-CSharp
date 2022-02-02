using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ConwaysGameOfLife.Converters
{
	public class CellConverter : IValueConverter
	{
		private readonly SolidColorBrush Color_Life = new SolidColorBrush(Color.FromRgb(0,0,0));
		private readonly SolidColorBrush Color_Death = new SolidColorBrush(Color.FromRgb(200, 200, 200));
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if ((bool)value)
			{
				return Color_Life;
			}
			else
			{
				return Color_Death;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
