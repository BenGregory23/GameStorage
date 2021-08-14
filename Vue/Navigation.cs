using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Modele;

namespace Vue
{
    public class Navigation
    {
        public Manager Manager => (App.Current as App).LeManager;

        
        public ContentControl MainPart { get; private set; }

        public Navigation(ContentControl contentControl)
        {
            MainPart = contentControl;
        }

        public void NavigateToNewUC(string uc)
        {
            

            switch (uc)
            {
                case "UCDetails":
                    MainPart.Content = new UCDetails();
                    break;
                case "UCHome":
                    MainPart.Content = new UCHome();
                    break;
                case "UCFavourites":
                    MainPart.Content = new UCFavourites();
                    break;
                case "UCConnection":
                    MainPart.Content = new UCConnection();
                    break;
                case "UCInscription":
                    MainPart.Content = new UCInscription();
                    break;
                case "UCSettings":
                    MainPart.Content = new UCSetting();
                    break;
                case "UCCreateGame":
                    MainPart.Content = new UCCreateGame();
                    break;
                case "UCLog-in-out":
                    MainPart.Content = new UCLog_in_out();
                    break;
            }
        }

    }
}
