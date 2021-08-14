﻿using System;
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
using Modele;

namespace Vue
{
    /// <summary>
    /// Logique d'interaction pour UCSetting.xaml
    /// </summary>
    public partial class UCSetting : UserControl
    {
        public Manager Manager => (App.Current as App).LeManager;

        internal Navigation Navigation => (App.Current as App).Navigation;
        public UCSetting()
        {
            InitializeComponent();
            DataContext = Manager;
        }
    }
}
