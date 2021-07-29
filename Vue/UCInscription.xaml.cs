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
    /// Logique d'interaction pour UCInscription.xaml
    /// </summary>
    public partial class UCInscription : UserControl
    {
        public Manager Manager => (App.Current as App).LeManager;

        internal Navigation Navigation => (App.Current as App).Navigation;
        public UCInscription()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            Manager.CreateNewUser(Name_Box.Text, Login_box.Text, Password_box.Text);
            Manager.IsUserConnected = true;
            Navigation.NavigateToNewUC("UCHome");          
        }
    }
}
