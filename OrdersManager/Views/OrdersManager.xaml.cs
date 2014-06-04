﻿using System;
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
using Elysium;
using MVVM;
using OrdersManager.ModelView;

namespace OrdersManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Elysium.Controls.Window
    {
        private OrdersRootViewModel formView;
        public MainWindow()
        {
            InitializeComponent();

            formView = new OrdersRootViewModel(tabControl.Items);
            this.DataContext = formView;
        }

        private void trw_Products_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }
    }
}
