using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Modele;
using StubPers;

namespace Vue
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Manager LeManager { get; private set; } = new Manager(new Stub());

        internal Navigation Navigation { get; set; }
        public App()
        {
            LeManager.LoadData();
            
        }


        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            Navigation = new Navigation((MainWindow as MainWindow).contentControlHome);
        }
    }
}
