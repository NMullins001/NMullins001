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
    /// Interaction logic for PaymentPortal.xaml
    /// </summary>
    public partial class PaymentPortal : Page
    {
        private int EmpId;
        private string EmpName;
        private Customer Customer;
        private RentalTransaction RentalTransaction;
        public PaymentPortal(int empId,string empName, Customer customer, RentalTransaction rentalTransaction)
        {
            EmpId = empId;
            EmpName = empName;
            Customer = customer;
            RentalTransaction = rentalTransaction;
            InitializeComponent();
        }

        private void SignOutNavigation(object sender, RoutedEventArgs e)
        {
            LoginPage newLoginPage = new LoginPage();
            NavigationService.Navigate(newLoginPage);
        }

        private void GoBackToRentals(object sender, RoutedEventArgs e)
        {
            CustomersRentals customersRentals = new CustomersRentals(EmpId, EmpName, Customer);
            NavigationService.Navigate(customersRentals);
        }

        private void Pay(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
