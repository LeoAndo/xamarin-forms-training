using System.Diagnostics;
using System.Xml.Linq;

namespace ListViewSample
{
    // リストのセルに表示するデータを扱うクラス
    public class RssItemViewModel
    {
        public RssItemViewModel(XElement element)
        {
            Title = element.Element(XName.Get("title")).Value;
            Description = element.Element(XName.Get("description")).Value;
            Link = element.Element(XName.Get("link")).Value;
            PubDate = element.Element(XName.Get("pubDate")).Value;

            // thumbnailが存在しないこともあるので、nullチェックをすること！
            XElement thumbnailElement = element.Element(
                XName.Get("thumbnail", "http://search.yahoo.com/mrss/"));

            Debug.WriteLine("thumbnailElement: " + thumbnailElement);
            if (thumbnailElement != null)
            {
                Thumbnail = thumbnailElement.Attribute(XName.Get("url")).Value;
            }
        }

        public string Title { protected set; get; }

        public string Description { protected set; get; }

        public string Link { protected set; get; }

        public string PubDate { protected set; get; }

        public string Thumbnail { protected set; get; }
    }
}
