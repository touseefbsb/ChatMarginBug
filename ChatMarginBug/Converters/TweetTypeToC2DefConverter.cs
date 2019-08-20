
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
namespace ChatMarginBug.Converters
{
    internal class TweetTypeToC2DefConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (TweetType)value == TweetType.Mine ? new GridLength(1, GridUnitType.Star) : new GridLength(80);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) => null;
    }
}
