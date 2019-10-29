using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace ProjectOwn
{
    /*  Att göra:
     *  Fixa så att antalet episoder räknas ut genom en metod och läggs in i det lokala fältet.
     *  I CreateEpisodeList så kommer inget att läggas till i fältet för mp3 eftersom sökvägen är fel. Försök hitta något sätt att söka efter attribut i en node.
     *  Gör så att all data sparas i en lokal xml-fil.
     *  */

    public class Podcast
    {
        public string Url { get; set; }
        public string Category { get; set; }
        public int UpdateFrequency { get; set; }
        public int NrOfEpisodes { get; set; }

        public string Title { get; set; }

        public List<Episode> episodes = new List<Episode>();

        public Podcast(string title, string url, string category, int updateFrequency)
        {

            Url = url;
            Category = category;
            UpdateFrequency = updateFrequency;
            Title = title;


            XmlDocument rssXmlDoc = new XmlDocument();
            rssXmlDoc.Load("Url");
            XmlNodeList rssNodes = rssXmlDoc.SelectNodes("rss/channel/item");


            episodes = CreateEpisodesList(rssNodes);

            CreatePodcastXMLFile();

        }
        private void CreatePodcastXMLFile()
        {
            // creates a folder for the file
            string podcastFolderPath = @"C:\Users\alici\Documents\HT19 - c-sharp\Projektarbete\PodcastXML";
            System.IO.Directory.CreateDirectory(podcastFolderPath);

            // creates the filename, adds it to the path. Regular Expression is used to remove spaces in file name.
            Title = Regex.Replace(Title, @"s", "");
            string fileName = Title + ".txt";
            string podcastFilePath = System.IO.Path.Combine(podcastFolderPath, fileName);

            // Creates the file if it does not already exist.
            if (!System.IO.File.Exists(podcastFilePath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(podcastFilePath))
                {
                    /* Might need to change to a StringBuilder that saves all the content and then returns a string which is inputed into the StreamWriter. Check if it's possible to add the rssXmlDoc to the StreamWriter.
                     * 
                     * */

                    StreamWriter sw = File.CreateText(podcastFilePath);
                    sw.Write(episodes);
                }
            }
            else
            {
                // MESSAGE THAT IT ALREADY EXIST
            }
        }

        private List<Episode> CreateEpisodesList (XmlNodeList rssNodes)
        {
            List<Episode> ep = new List<Episode>();

            // Iterate through the items in the RSS file
            foreach (XmlNode rssNode in rssNodes)
            {
                XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                string title = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("pubDate");
                string pubDate = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("description");
                string description = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("itunes:duration");
                string duration = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("itunes:author");
                string author = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("enclosure");
                string mp3 = rssSubNode != null ? rssSubNode.InnerText : "";

                ep.Add(new Episode(title, description, mp3, pubDate, duration, author));
            }

            return ep;
        }
    }
}
