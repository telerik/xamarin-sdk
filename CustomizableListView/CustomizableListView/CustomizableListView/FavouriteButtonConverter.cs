using System;
using System.Globalization;
using Xamarin.Forms;

namespace CustomizableListView
{
    public class FavouriteButtonConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return "unfav_btn.png";
            }

            return "fav_btn.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}