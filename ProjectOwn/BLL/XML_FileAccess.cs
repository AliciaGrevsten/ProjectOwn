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
            //https://stackoverflow.com/questions/8382834/how-to-remove-an-xml-element-from-file
            //XmlDocument doc = new XmlDocument();
            //doc.Load("../../DAL/XML_Categories/Categories.xml");

            //XmlNode node = doc.SelectSingleNode($"/categories/category[@name='{title}']");

            //if (node != null)
            //{
            //    XmlNode parent = node.ParentNode;
            //    parent.RemoveChild(node);
            //    doc.Save("../../DAL/XML_Categories/Categories.xml");
            //}
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
