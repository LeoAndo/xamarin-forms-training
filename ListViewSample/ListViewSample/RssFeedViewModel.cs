using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Input;
using System.Xml.Linq;
using Xamarin.Forms;

namespace ListViewSample
{
    public class RssFeedViewModel : ViewModelBase
    {
        string url, title;
        IList<RssItemViewModel> items;
        bool isRefreshing;

        public RssFeedViewModel()
        {
            // 通信処理
            RefreshCommand = new Command(
                execute: () =>
                {
                    LoadRssFeed(url);
                },
                canExecute: () =>
                {
                    // executeメソッドの実行フラグを返す
                    return !IsRefreshing;
                });
        }

        public string Url
        {
            set
            {
                if (SetProperty(ref url, value) && !String.IsNullOrEmpty(url))
                {
                    LoadRssFeed(url);
                }
            }
            get => url;
        }
        public string Title
        {
            set => SetProperty(ref title, value);
            get => title;
        }

        public IList<RssItemViewModel> Items
        {
            set => SetProperty(ref items, value);
            get => items;
        }

        public ICommand RefreshCommand { private set; get; }

        public bool IsRefreshing
        {
            set => SetProperty(ref isRefreshing, value);
            get => isRefreshing;
        }

        public void LoadRssFeed(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.BeginGetResponse((args) =>
            {
                // XMLをダウンロード
                Stream stream = request.EndGetResponse(args).GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string xml = reader.ReadToEnd();

                // XMLを解析し、RSSフィードからデータを抽出
                XDocument doc = XDocument.Parse(xml);
                XElement rss = doc.Element(XName.Get("rss"));
                XElement channel = rss.Element(XName.Get("channel"));

                // Title propertyを設定
                Title = channel.Element(XName.Get("title")).Value;

                // Items propertyを設定
                List<RssItemViewModel> list =
                    channel.Elements(XName.Get("item")).Select((XElement element) =>
                    {
                        return new RssItemViewModel(element);
                    }).ToList();
                Items = list;

                // Pull TO Refreshの処理が終わったらフラグをfalseにする.
                IsRefreshing = false;
            }, null);
        }
    }
}
