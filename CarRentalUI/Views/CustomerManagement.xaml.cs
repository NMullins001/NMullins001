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

namespace CarRentalUI.Views
{
    /// <summary>
    /// Interaction logic for CustomerManagement.xaml
    /// </summary>
    public partial class CustomerManagement : Page
    {
        public int EmpId;
        public string EmpName;
        public CustomerManagement(int empID, string empName)
        {
            EmpId = empID;
            EmpName = empName;
            InitializeComponent();
        }

        private void EmployeePortalNavigation(object sender, RoutedEventArgs e)
        {
            EmployeeSplashPage employeeSplashPage = new EmployeeSplashPage(EmpId, EmpName);
            NavigationService.Navigate(employeeSplashPage);
        }


        private void SignOut(object sender, RoutedEventArgs e)
        {
            LoginPage newLoginPage = new LoginPage();
            NavigationService.Navigate(newLoginPage);
        }


        private void NewCustomer(object sender, RoutedEventArgs e)
        {
            AddNewCustomer addNewCustomer = new AddNewCustomer(EmpId, EmpName);
            NavigationService.Navigate(addNewCustomer);
        }

        private void ViewExistingCustomers(object sender, RoutedEventArgs e)
        {
           ExistingCustomerLookup existingCustomerLookup = new ExistingCustomerLookup(EmpId, EmpName);
           NavigationService.Navigate(existingCustomerLookup);
        }
    }
}
