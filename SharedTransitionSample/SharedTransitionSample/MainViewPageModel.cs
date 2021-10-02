using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SharedTransitionSample
{
    internal class MainViewPageModel
    {
        public ObservableCollection<Item> ItemsCollection { get; set; }
        public MainViewPageModel()
        {
            CreateItems();
        }

        private void CreateItems()
        {
            var source = new List<Item>
            {
                new Item{Id = 1, Color = Color.Accent, Name = "Accent"},
                new Item{Id = 2, Color = Color.Beige, Name = "Beige"},
                new Item{Id = 3, Color = Color.Blue, Name = "Blue"},
                new Item{Id = 4, Color = Color.BurlyWood, Name = "BurlyWood"},
                new Item{Id = 5, Color = Color.CadetBlue, Name = "CadetBlue"},
                new Item{Id = 6, Color = Color.Cornsilk, Name = "Cornsilk"},
                new Item{Id = 7, Color = Color.DarkGreen, Name = "DarkGreen"},
                new Item{Id = 8, Color = Color.DarkOrchid, Name = "DarkOrchid"},
                new Item{Id = 9, Color = Color.ForestGreen, Name = "ForestGreen"},
                new Item{Id = 10, Color = Color.Gold, Name = "Gold"},
            };
            ItemsCollection = new ObservableCollection<Item>(source);
        }
    }
}