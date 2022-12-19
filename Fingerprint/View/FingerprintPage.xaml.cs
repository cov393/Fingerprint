using Fingerprint.View;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fingerprint
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FingerprintPage : ContentPage
    {
        public FingerprintPage()
        {
            InitializeComponent();

        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var availability = await CrossFingerprint.Current.IsAvailableAsync();

            if (!availability)
            {
                await DisplayAlert("Warning!", "No biometrics available", "OK");

                return;
            }

            var authResult = await CrossFingerprint.Current.AuthenticateAsync(new AuthenticationRequestConfiguration("Heads up!", "I would like to use your biometrics, please!"));

            if (authResult.Authenticated)
            {
                //await DisplayAlert("Yaay!", "Here is the secrets", "Thanks!");
                await Navigation.PushAsync(new GoogleAuthenticationPage());
            }
        }
    }
}