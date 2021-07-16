using Microsoft.Maui.Controls;
using System;
using Application = Microsoft.Maui.Controls.Application;

namespace PassingData
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage(DateTime.Now.ToString("u")));
        }
    }
}