using Modele;
using System;
using System.Collections.Generic;
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
using System.Linq;

namespace Vue
{
    /// <summary>
    /// Logique d'interaction pour UCConnection.xaml
    /// </summary>
    public partial class UCConnection : UserControl
    {
        public Manager Manager => (App.Current as App).LeManager;
        internal Navigation Navigation => (App.Current as App).Navigation;
        public UCConnection()
        {
            InitializeComponent();
        }



        private void Confirm_Click(object sender, RoutedEventArgs e)
        {

            User u = Manager.users.Find(u => u.Login.Equals(Login_box.Text));
            if (u == null)
            {
                Error_box.Text = "Unknown Login";
            }
            else if(u.checkPassword(PasswordBox.Text))
            {
                Manager.ConnectedUser = u;
                Manager.IsUserConnected = true;
                Navigation.NavigateToNewUC("UCHome");
            }
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Confirm_Click(sender, e);

            }
        }
    }
}
