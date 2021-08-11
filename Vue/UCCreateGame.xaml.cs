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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Modele;

namespace Vue
{
    /// <summary>
    /// Logique d'interaction pour UCCreateGame.xaml
    /// </summary>
    public partial class UCCreateGame : UserControl
    {
        public Manager Manager => (App.Current as App).LeManager;

        internal Navigation Navigation => (App.Current as App).Navigation;

        public UCCreateGame()
        {
            InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = FindResource("moveRectangle") as Storyboard;
            
                Debug.WriteLine(sb.ToString());
            
            sb.Begin();

        }

        private void Confirm_click(object sender, RoutedEventArgs e)
        {
            DateTime? selectedDate = DatePicker.SelectedDate;
            string formattedDate = "";
            if (selectedDate.HasValue)
            {
                 formattedDate = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }

            List<EnumType> GamesGenres = new List<EnumType>();

            if (action.IsChecked == true) GamesGenres.Add(EnumType.Action);
            if (arcade.IsChecked == true) GamesGenres.Add(EnumType.Arcade);
            if (adventure.IsChecked == true) GamesGenres.Add(EnumType.Adventure);
            if (cooperation.IsChecked == true) GamesGenres.Add(EnumType.Cooperation);
            if (fps.IsChecked == true) GamesGenres.Add(EnumType.FPS);
            if (fighting.IsChecked == true) GamesGenres.Add(EnumType.Fighting);
            if (mmo.IsChecked == true) GamesGenres.Add(EnumType.MMO);
            if (platformer.IsChecked == true) GamesGenres.Add(EnumType.Platformer);
            if (rpg.IsChecked == true) GamesGenres.Add(EnumType.RPG);
            if (racing.IsChecked == true) GamesGenres.Add(EnumType.Racing);
            if (simulation.IsChecked == true) GamesGenres.Add(EnumType.Simulation);
            if (sports.IsChecked == true) GamesGenres.Add(EnumType.Sports);
            if (strategy.IsChecked == true) GamesGenres.Add(EnumType.Strategy);
           

            if (Manager.Games.Contains(new Game(GameTextBox.Text, formattedDate, GamesGenres, PublisherTextBox.Text, CoverBox.Text,DescriptionTextBox.Text, TrailerBox.Text)) == false){
                Manager.AddGame(new Game(GameTextBox.Text, formattedDate, GamesGenres, PublisherTextBox.Text, CoverBox.Text,DescriptionTextBox.Text, TrailerBox.Text));
                Manager.LoadData();
                Manager.DisplayedGames = Manager.games;
                Navigation.NavigateToNewUC("UCHome");
            }
        }
    }
}
