﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio10
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PickerDemo();
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
