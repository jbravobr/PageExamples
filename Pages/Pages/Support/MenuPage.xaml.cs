using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Pages
{
    public partial class MenuPage : ContentPage
    {
        ObservableCollection<MenuItem> menuItens = new ObservableCollection<MenuItem>();

        public MenuPage()
        {
            InitializeComponent();

            menuItens.Add(new MenuItem { DisplayName = "Menu 01" });
            menuItens.Add(new MenuItem { DisplayName = "Menu 02" });
            menuItens.Add(new MenuItem { DisplayName = "Menu 03" });
            menuItens.Add(new MenuItem { DisplayName = "Menu 04" });
            menuItens.Add(new MenuItem { DisplayName = "Menu 05" });

            MenuView.ItemsSource = menuItens;
        }
    }

    public class MenuItem
    {
        public string DisplayName { get; set; }
    }
}

