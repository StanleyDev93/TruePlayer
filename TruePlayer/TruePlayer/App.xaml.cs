using System;
using Xamarin.Forms;
using TruePlayer.Views;
using Xamarin.Forms.Xaml;

namespace TruePlayer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MusicList());
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
