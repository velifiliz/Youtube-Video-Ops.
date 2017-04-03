    public static class Youtube
    {
        public static string GetVideoId(string url)
        {
            var youtubeMatch = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)").Match(url);
            return youtubeMatch.Groups[1].Value;
        }
        public static string GetVideoImage(string url)
        {
            var youtubeMatch = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)").Match(url);
            return "http://i1.ytimg.com/vi/" + youtubeMatch.Groups[1].Value + "/hqdefault.jpg";

            // maxresdefault.jpg
            // hqdefault.jpg
            // mqdefault.jpg
            // default.jpg
        }
    }