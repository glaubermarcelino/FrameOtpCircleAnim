using System;
using Xamarin.Forms;

namespace FrameOtpCircleAnim
{
    public class ValueProgressBarConverter :IValueConverter
    {
        public object Convert(object value, Type targetType,object parameter,System.Globalization.CultureInfo culture)
        {
            return (double)value / 30;
        }

        public object ConvertBack(object value,Type targetType, object parameter,System.Globalization.CultureInfo culture) 
        { 
            return new NotImplementedException(); 
        }
    }
}
