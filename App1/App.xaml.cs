using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Views;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new SliderEx02();
            //MainPage = new Carouselex();
            MainPage = new NavigationPage(new PopupEx());
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
