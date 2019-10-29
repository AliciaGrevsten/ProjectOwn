using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjectOwn.BLL
{
    class XML_FileAccess
    {
        public static void AddPodcastFile()
        {

        }
        public static void ChangePodcastXMLFile(string title)
        {
            
        }

        public static void ChangeCategoryXMLFile(string title)
        {
            //      INTE KLAR
            //XmlDocument doc = new XmlDocument();
            //doc.Load("../../DLL/XML_Categories/Categories.xml");
            //XmlNode newElem = doc.CreateNode(XmlNodeType.Element, "category", " ");
            //newElem.InnerText = title;
            //doc.AppendChild(newElem); 
            // Funkar inte
        }

        public static List<string> LoadCategoryXMLFile()
        {
            var categoryList = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load("../../DLL/XML_Categories/Categories.xml");
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
