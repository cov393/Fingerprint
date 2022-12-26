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
            //backgroundImage.Source = new UriImageSource
            //{
            //    Uri = new Uri("https://blobmixer.14islands.com/view?ambient=0&angle1=0.42&angle2=0.52&angle3=0.39&ccRougness=0.14&clearColor=rgba%28118%2C0%2C240%2C1%29&clearcoat=1&color1=rgba%280%2C255%2C248%2C1%29&color2=rgba%28120%2C0%2C255%2C1%29&color3=rgba%28255%2C255%2C255%2C1%29&decay1=1&dist1=8.27&dist2=9.53&dist3=8.2&distort=0&dynEnv=false&envMap=0.05&floor=false&floorColor=rgba%2811%2C39%2C43%2C1%29&floorEnvMap=0.37&floorMetalness=0&floorOpacity=0.27&floorRoughness=0.15&floorSize=0&floorY=-0.4&frequency=0.06&gradient=rainbow&int1=1.27&int2=3&int3=2&int4=0&int5=0.63&ior=2.33&lights[0]=1&lights[1]=2&lights[2]=3&metalness=0&numWaves=1&opacity=1&penum1=0.66&penum3=1&reflectivity=1&roughness=1&rshad=false&scale=1.04&segments=512&shadow1=false&shadow2=false&shadowBias1=false&shadowFocus1=1&shadowMap=false&sky=false&speed=2&surfaceDistort=3.1&surfaceFrequency=0.28&surfaceSpeed=1&transmission=0&useGradient=true&uv=true&x1=-5&x2=-2.73&x3=1.2&x4=3.07&y1=0.07&y2=-6.67&y3=2.67&z1=1.93&z2=5.73&z3=4.6&z4=3.53&z5=6.2"),
            //    CachingEnabled = true,
            //    CacheValidity = new TimeSpan(5, 0, 0, 0)
            //};
        }
    }
}