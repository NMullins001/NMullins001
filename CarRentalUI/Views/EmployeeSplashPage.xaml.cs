using System;
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

namespace CarRentalUI.Views
{
    /// <summary>
    /// Interaction logic for EmployeeSplashPage.xaml
    /// </summary>
    public partial class EmployeeSplashPage : Page
    {
        public string EmpName;
        private int EmpId;
        public EmployeeSplashPage(int userId, string userName)
        {
            EmpName = userName;
            EmpId = userId;

            InitializeComponent();
        }

        private void EmployeeName_OnLoaded(object sender, RoutedEventArgs e)
        {
            EmployeeName.Content = "Welcome " + EmpName;
        }

        private void SignOutNavigation(object sender, RoutedEventArgs e)
        {
            LoginPage newLoginPage = new LoginPage();
            NavigationService.Navigate(newLoginPage);
        }
        private void GoToRentalManagement(object sender, RoutedEventArgs e)
        {
            CustomerManagement rentalManagement = new CustomerManagement(EmpId,EmpName);
            NavigationService.Navigate(rentalManagement);
        }

        private void GoToVehicleManagement(object sender, RoutedEventArgs e)
        {
            VehicleManagement vehicleManagement = new VehicleManagement(EmpId, EmpName);
            NavigationService.Navigate(vehicleManagement);
        }
    }
}
