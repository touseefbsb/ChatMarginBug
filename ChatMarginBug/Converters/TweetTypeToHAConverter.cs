
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
namespace ChatMarginBug.Converters
{
    internal class TweetTypeToHAConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (TweetType)value == TweetType.Mine ?
                HorizontalAlignment.Right : HorizontalAlignment.Left;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) => null;
    }
}
