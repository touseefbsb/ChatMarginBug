
using System;
using Windows.UI.Xaml.Data;
namespace ChatMarginBug.Converters
{
    internal class TweetTypeToMsgColumnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (TweetType)value == TweetType.Mine ? 1 : 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) => null;
    }
}
