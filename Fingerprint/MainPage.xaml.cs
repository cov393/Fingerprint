using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Fingerprint
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
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
                await DisplayAlert("Yaay!", "Here is the secrets", "Thanks!");
            }
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync (new FingerprintPage());
        }
        //async void Button_Clicked(object sender, EventArgs e)
        //    {
        //        if (await CrossFingerprint.Current.IsAvailableAsync(true))
        //        {
        //            var result = await CrossFingerprint.Current.AuthenticateAsync(
        //               new AuthenticationRequestConfiguration("Login", "Access your account"));
        //            if (result.Authenticated)
        //            {
        //                await DisplayAlert("Success", "Authenticated", "OK");
        //            }
        //            else
        //            {
        //                await DisplayAlert("Failure", "Not Authenticated", "OK");
        //            }
        //        }
        //        else
        //        {
        //            await DisplayAlert("Failure", "Biometrics not available", "OK");
        //        }
        //    }
    }
}
