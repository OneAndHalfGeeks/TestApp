using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class GreetPage : ContentPage
    {

        public GreetPage()
        {
            InitializeComponent();
        }

        void Handle_Click(object sender, EventArgs e)
        {
            DisplayAlert("Title", "Hello World", "OK");
        }

    }
}
