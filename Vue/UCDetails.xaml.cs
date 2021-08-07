using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Logique d'interaction pour UCDetails.xaml
    /// </summary>
    public partial class UCDetails : UserControl
    {
        public Manager Manager => (App.Current as App).LeManager;
        internal Navigation Navigation => (App.Current as App).Navigation;
        public UCDetails()
        {
            InitializeComponent();
            DataContext = Manager.SelectedGame;
            if(Manager.IsUserConnected == false)
            {
                Heart_button.IsEnabled = false;
                Delete_favourite.IsEnabled = false;

            }
            else
            {
                Heart_button.IsEnabled = true;
                Delete_favourite.IsEnabled = true;
            }


        }

        private void Heart_Click(object sender, RoutedEventArgs e)
        {
            if (Manager.FavouriteGames.Contains(Manager.SelectedGame))
            {
                return;
            }
            //Manager.FavouriteGames.Add(Manager.SelectedGame);
            Manager.AddGameToFavourite();
            
           


        }

        private void Delete_Favourite_Click(object sender, RoutedEventArgs e)
        {
            if (Manager.FavouriteGames.Contains(Manager.SelectedGame))
            {
                //Manager.FavouriteGames.Remove(Manager.SelectedGame); this worked but didn't impact the user's hashSet
                Manager.RemoveGameToFavourite(); //this method does impact the users hashSet
                
               
            }   
        }
    }
}
