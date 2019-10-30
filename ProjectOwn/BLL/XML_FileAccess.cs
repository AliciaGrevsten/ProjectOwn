using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ProjectOwn.BLL
{
    class XML_FileAccess
    {
        public static void AddPodcastFile()
        {

        }
        public static void AddToPodcastXMLFile(string title)
        {
            
        }

        public static void AddToCategoryXMLFile(string title)
        {
            // https://stackoverflow.com/questions/9761363/adding-to-xml-file
            XDocument doc = XDocument.Load("../../DAL/XML_Categories/Categories.xml");
            XElement newElement = new XElement("category", new XAttribute("title", title));

            doc.Root.Add(newElement);
            doc.Save("../../DAL/XML_Categories/Categories.xml");

        }

        public static void RemoveFromCategoryXMLFile(string title)
        {
            // https://stackoverflow.com/questions/58620539/remove-an-item-from-xml-file-using-c-sharp

            var xml = XDocument.Load("../../DAL/XML_Categories/Categories.xml");

            xml.Root.Elements("category").Where(e => e.Attribute("title").Value == title).Remove();

            xml.Save("../../DAL/XML_Categories/Categories.xml");
        }

        public static void RemoveFromPodcastXMLFile(string title)
        {

        }

        public static List<string> LoadCategoryXMLFile()
        {
            var categoryList = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load("../../DAL/XML_Categories/Categories.xml");
            foreach(XmlNode node in doc.DocumentElement)
            {
                string title = node.Attributes["title"].InnerText;
                categoryList.Add(title);
            }
            return categoryList;
        }

        public static void LoadPodcastXMLFile()
        {
            // https://www.youtube.com/watch?v=ulzFqXb13dI&list=PLY1UVBlGVILWSg2OvxRiqeCMqBK5k8aU-&index=5&t=207s
        }
    }

   
}
