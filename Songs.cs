// Static Attributes

namespace Tutorial
{
    class Songs 
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Songs (string _title, string _artist, int _duration)
        {
            title = _title;
            artist = _artist;
            duration = _duration;
            songCount++;
        }
    }
}