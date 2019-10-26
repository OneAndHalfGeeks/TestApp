using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace HelloWorld
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
        }

        public MapPage(Location location)
        {
            InitializeComponent();
            map.IsShowingUser = true;
            map.MoveToRegion(new MapSpan(new Position(location.Latitude, location.Longitude), 0, 0));
        }
    }
}
