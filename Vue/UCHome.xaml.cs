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
using StubPers;

namespace Vue
{
    /// <summary>
    /// Logique d'interaction pour UCHome.xaml
    /// </summary>
    public partial class UCHome : UserControl
    {
        public Manager Manager => (App.Current as App).LeManager;
        internal Navigation Navigation => (App.Current as App).Navigation;

        public UCHome()
        {
            InitializeComponent();
            DataContext = Manager;
           

        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        { 
            Manager.SelectedGame = ListBoxGames.SelectedItem as Game;
            Debug.WriteLine(ListBoxGames.SelectedItem);
            Debug.WriteLine(Manager.SelectedGame);
            Navigation.NavigateToNewUC("UCDetails");
            
        }

        

        
    }
}
