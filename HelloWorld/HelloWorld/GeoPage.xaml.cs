
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class GeoPage : ContentPage
    {
        public GeoPage()
        {
            InitializeComponent();
        }

        private async void Handle_Click(object sender, EventArgs e)
        {
            try
            {
                var location = await Geolocation.GetLocationAsync();

                if (location != null)
                {
                    //await location.OpenMapsAsync();
                    await Navigation.PushAsync(new MapPage(location));
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }
    }
}
