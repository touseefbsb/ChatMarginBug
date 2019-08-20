
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
namespace ChatMarginBug.Converters
{
    public class TweetTypeToC1DefConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (TweetType)value == TweetType.Mine ? new GridLength(80) : new GridLength(1,GridUnitType.Star);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) => null;
    }
}
