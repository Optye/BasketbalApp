using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using basketbalApp.Services;
using basketbalApp.Views;

namespace basketbalApp
{
    public partial class App : Application
    {
        public static string FilePath;
        public static ApiData apiData;
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }
        public App(string filePath)
        {
            InitializeComponent();
            apiData = new ApiData();
            MainPage = new MainPage();

            FilePath = filePath;
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
