using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    /// Interaction logic for CustomerPortal.xaml
    /// </summary>
    public partial class CustomerPortal : Page
    {
        private int EmpId;
        private string EmpName;
        private Customer Customer;
        public CustomerPortal(int empId, string empName, Customer customer)
        {
            EmpId = empId;
            EmpName = empName;
            Customer = customer;
            InitializeComponent();
        }
        private void CustomerLabel_OnLoaded(object sender, RoutedEventArgs e)
        {
            CustomerLabel.Content = Customer.FirstName + " " + Customer.LastName;
        }

        private void GoToCustomerManagement(object sender, RoutedEventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement(EmpId, EmpName);
            NavigationService.Navigate(customerManagement);
        }

        private void GoToEmployeeSplashPage(object sender, RoutedEventArgs e)
        {
            EmployeeSplashPage employeeSplashPage = new EmployeeSplashPage(EmpId, EmpName);
            NavigationService.Navigate(employeeSplashPage);
        }


        private void SignOutNavigation(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            NavigationService.Navigate(loginPage);
        }

        private void AddANewRental(object sender, RoutedEventArgs e)
        {
            AddNewRental addNewRental = new AddNewRental(EmpId, EmpName, Customer);
            NavigationService.Navigate(addNewRental);
        }

        private void ViewExistingRentals(object sender, RoutedEventArgs e)
        {

            CustomersRentals customersRentals = new CustomersRentals(EmpId, EmpName, Customer);
            NavigationService.Navigate(customersRentals);
        }
    }
}
