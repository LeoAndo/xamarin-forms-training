﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBindingSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            MainPage = new Sample2Page();
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
