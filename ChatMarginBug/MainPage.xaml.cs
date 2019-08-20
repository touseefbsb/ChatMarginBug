using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ChatMarginBug
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            MyTweets = new List<TweetData>
            {
                new TweetData{ Text="abqrwfsddggc", MyTweetType = TweetType.Mine},
                new TweetData{ Text="abqrwfsddggasasasc", MyTweetType = TweetType.Mine},
                new TweetData{ Text="abqrwfsddassqsasacbvretgergggc", MyTweetType = TweetType.Mine},
                new TweetData{ Text="abcalkdjdjjd qdjqwpodwqpodqwjdqwkj qdkjqwkdjqwlkdjqlkdjaslkj   qieoqieowqdjwkjwkj kdwqjqwlk;lqwkd;lkd;laskd;laks;dlkaskld;lakdpoiwdpowqkd;l qwioeqwijdkqwjdlkndlksanlcsmcsa qwkkjeqwjdlkqwjdlksadmasldjl;qkd;asljdlqwkhdlwqk", MyTweetType = TweetType.Mine},
                new TweetData{ Text="abcalkdjkjwkj kdwqjqwlk;lqwkd;lkd;laskd;laks;dlkaskld;lakdpoiwdpowqkd;l qwioeqwijdkqwjdlkndlksanlcsmcsa qwkkjeqwjdlkqwjdlksadmasldjl;qkd;asljdlqwkhdlwqk", MyTweetType = TweetType.Mine},
                new TweetData{ Text="abewqeqweqweqwe", MyTweetType = TweetType.Mine},
                new TweetData{ Text="abcalkdjdjjd qdjqwpodwqpodqwjdqwkj qdkjqwkdjqwlkdjqlkdjaslkj   qieoqieowqdjwkjwkj kdwqjqwlk;lqwkd;lkd;laskd;laks;dlkaskld;lakdpoiwdpowqkd;l qwioeqwijdkqwjdlkndlksanlcsmcsa qwkkjeqwjdlkqwjdlksadmasldjl;qkd;asljdlqwkhdlwqk", MyTweetType = TweetType.Mine},
                new TweetData{ Text="abcalkdjdjjd qdjqwpodwqpodqwjdqwkj qdkjqwkdjqwlkdjqlkdjaslkj   qieoqieowqdjwkjwkj kdwqjqwlk;lqwkd;lkd;laskd;laks;dlkaskld;lakdpoiwdpowqkd;l qwioeqwijdkqwjdlkndlksanlcsmcsa qwkkjeqwjdlkqwjdlksadmasldjl;qkd;asljdlqwkhdlwqk", MyTweetType = TweetType.NotMine},
                new TweetData{ Text="abc", MyTweetType = TweetType.NotMine},
                new TweetData{ Text="abcqdwqdqdqsdqwdwqdsdsaddz", MyTweetType = TweetType.Mine},
                new TweetData{ Text="abc", MyTweetType = TweetType.NotMine},
                new TweetData{ Text="abcscascqwdwwrewr", MyTweetType = TweetType.NotMine},
                new TweetData{ Text="abc", MyTweetType = TweetType.NotMine},
                new TweetData{ Text="abc", MyTweetType = TweetType.NotMine},
                new TweetData{ Text="abcqweqwewqeqweqdsdadqwqw", MyTweetType = TweetType.NotMine},
                new TweetData{ Text="xkwjdwqjdpo", MyTweetType = TweetType.NotMine}
            };
        }

        public List<TweetData> MyTweets { get; }
    }
}
