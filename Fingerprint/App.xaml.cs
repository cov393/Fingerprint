using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Fingerprint.View;


namespace Fingerprint
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new FingerprintPage());
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
