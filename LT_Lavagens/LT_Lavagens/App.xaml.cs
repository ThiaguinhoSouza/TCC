using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LT_Lavagens
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LT_Lavagens.Master.Menu());
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
