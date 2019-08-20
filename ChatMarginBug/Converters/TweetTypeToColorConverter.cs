
using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
namespace ChatMarginBug.Converters
{
    internal class TweetTypeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (TweetType)value == TweetType.Mine ?
                new SolidColorBrush((Color)Application.Current.Resources["SystemAccentColor"]) :
                Application.Current.Resources["SystemControlBackgroundBaseLowBrush"] as SolidColorBrush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) => null;
    }
}
