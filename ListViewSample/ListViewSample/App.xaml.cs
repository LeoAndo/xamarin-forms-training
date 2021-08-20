﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            // MainPage = new TextCellListSamplePage();
            MainPage = new ViewCellSamplePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
