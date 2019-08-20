
using System;
using Windows.UI.Xaml.Data;
namespace ChatMarginBug.Converters
{
    internal class TweetTypeToMetaDataColumnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (TweetType)value == TweetType.Mine ? 0 : 1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) => null;
    }
}
