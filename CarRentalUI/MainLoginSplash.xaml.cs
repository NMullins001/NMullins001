﻿using System;
using System.Collections.Generic;
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
using CarRentalUI.Models;
using CarRentalUI.Views;
namespace CarRentalUI
{
    /// <summary>
    /// Interaction logic for MainLoginSplash.xaml
    /// </summary>
    public partial class MainLoginSplash : Page
    {
       
        public MainLoginSplash()
        {
            
            InitializeComponent();
        }

        private void GoToLogin(object sender, RoutedEventArgs e)
        {
         LoginPage loginPage = new LoginPage();
         NavigationService.Navigate(loginPage);
        }
    }
}
