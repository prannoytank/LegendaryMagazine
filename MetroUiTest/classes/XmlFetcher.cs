using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections;
using MetroUiTest.beansClass;



namespace MetroUiTest.classes
{
        
    class XmlFetcher
    {
        private XmlTextReader rssReader;
        private XmlDocument rssDoc;
        private XmlNode nodeRss;
        private XmlNode nodeChannel;
        private XmlNode nodeItem;
    


        public List<FeedBean> fetchFeeds(string url)
        {

            List<FeedBean> feedList = new List<FeedBean>();

            FeedBean feedBeans;

            rssReader = new XmlTextReader(url);
            rssDoc = new XmlDocument();
            rssDoc.Load(rssReader);

            for (int i = 0; i < rssDoc.ChildNodes.Count; i++)
            {
                if (rssDoc.ChildNodes[i].Name == "rss")
                {
                    nodeRss = rssDoc.ChildNodes[i];
                }
            }

            for (int i = 0; i < nodeRss.ChildNodes.Count; i++)
            {
                if (nodeRss.ChildNodes[i].Name == "channel")
                {
                    nodeChannel = nodeRss.ChildNodes[i];
                }
            }

            for (int i = 0; i < nodeChannel.ChildNodes.Count; i++)
            {

                if (nodeChannel.ChildNodes[i].Name == "item")
                {
                    nodeItem = nodeChannel.ChildNodes[i];
                    feedBeans=  new FeedBean();

                    feedBeans.feedTitle=nodeItem["title"].InnerText;
                    feedBeans.feedDescription = nodeItem["description"].InnerText;
                    feedBeans.feedLink = nodeItem["link"].InnerText;
                    feedBeans.feedImage = nodeItem["enclosure"].Attributes["url"].InnerText;
                    


                    feedList.Add(feedBeans);
                   
                }
            }

            return feedList;

        }

    }
}
