using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
        }
    }
}

