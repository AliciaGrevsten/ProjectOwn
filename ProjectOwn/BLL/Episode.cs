using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOwn
{
    public class Episode
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Mp3 { get; set; }
        public string PubDate { get; set; }
        public string Duration { get; set; }
        public string Author { get; set; }


        public Episode(string title, string description, string mp3, string pubDate, string duration, string author)
        {
            Title = title;
            Description = description;
            Mp3 = mp3;
            PubDate = pubDate;
            Duration = duration;
            Author = author;
        }
    }
}
