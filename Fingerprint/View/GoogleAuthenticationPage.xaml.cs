using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fingerprint.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoogleAuthenticationPage : ContentPage
    {
        public GoogleAuthenticationPage()
        {
            InitializeComponent();
        }
    }
}