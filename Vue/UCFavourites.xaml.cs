using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Modele;

namespace Vue
{
    /// <summary>
    /// Logique d'interaction pour UCFavourites.xaml
    /// </summary>
    public partial class UCFavourites : UserControl
    {
        public Manager Manager => (App.Current as App).LeManager;

        internal Navigation Navigation => (App.Current as App).Navigation;
        public UCFavourites()
        {
            InitializeComponent();
            DataContext = Manager;
            if(Manager.IsUserConnected == false)
            {
                Error_box.Text = "You have to log in to see your favourites games!";
            }
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Manager.SelectedGame = ListBoxGames.SelectedItem as Game;
            Navigation.NavigateToNewUC("UCDetails");

        }

        
    }
}
