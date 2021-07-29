using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Manager Manager => (App.Current as App).LeManager;

        internal Navigation Navigation => (App.Current as App).Navigation;

        public MainWindow()
        {
            InitializeComponent();
            if(Manager.IsUserConnected == false)
            {
                logout_button.Visibility = Visibility.Collapsed;
            }
            if(Manager.IsUserConnected == true)
            {
                logout_button.Visibility = Visibility.Visible;
            }
            
        }

        private void click_favourite(object sender, RoutedEventArgs e)
        {
            contentControlHome.Content = new UCFavourites();
            Manager.DisplayedGames = Manager.FavouriteGames;
        }

        private void click_home(object sender, RoutedEventArgs e)
        {
            contentControlHome.Content = new UCHome();
            Manager.DisplayedGames = Manager.Games;
        }

        private void click_setting(object sender, RoutedEventArgs e)
        {
            contentControlHome.Content = new UCSetting();
        }

        private void click_log_in(object sender, RoutedEventArgs e)
        {
            contentControlHome.Content = new UCConnection();
        }

        private void click_sign_up(object sender, RoutedEventArgs e)
        {
            contentControlHome.Content = new UCInscription();
        }

        private void click_log_out(object sender, RoutedEventArgs e)
        {
            Navigation.NavigateToNewUC("UCHome");
        }

        private void click_close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
        private void click_minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Name_Selected(object sender, RoutedEventArgs e)
        {
            Manager.DisplayedGames = Manager.DisplayedGames.OrderBy(g => g.Name);
            Navigation.NavigateToNewUC("UCHome");
        }

        private void Date_Selected(object sender, RoutedEventArgs e)
        {
            Manager.DisplayedGames = Manager.DisplayedGames.OrderBy(g => g.DateOfRelease);
            Navigation.NavigateToNewUC("UCHome");
        }

        private void Publisher_Selected(object sender, RoutedEventArgs e)
        {
            Manager.DisplayedGames = Manager.DisplayedGames.OrderBy(g => g.Publisher);
            Navigation.NavigateToNewUC("UCHome");
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                
                

                string[] uc = Navigation.MainPart.Content.ToString().Split(".");

                if (uc[1].Equals("UCHome")){
                    Manager.SearchGame(searchBox.Text.ToLower(), uc[1]);
                    Navigation.NavigateToNewUC("UCHome");
                }
                else if (uc[1].Equals("UCFavourites"))
                {
                    Manager.SearchGame(searchBox.Text.ToLower(), uc[1]);
                    Navigation.NavigateToNewUC("UCFavourites");
                }
                
                Debug.WriteLine(uc.ToString());

            }
        }

        /// <summary>
        /// Click to create a new user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accept_button(object sender, RoutedEventArgs e)
        {
            if(Manager.Games.Contains(new Game(GameTextBox.Text, DateTextBox.Text, TypeTextBox.Text, PublisherTextBox.Text, DescriptionTextBox.Text)) == false){
                Manager.games.Add(new Game(GameTextBox.Text, DateTextBox.Text, TypeTextBox.Text, PublisherTextBox.Text, DescriptionTextBox.Text));
                Manager.DisplayedGames = Manager.games;
                Navigation.NavigateToNewUC("UCHome");
            }
            
        }

    }
}
