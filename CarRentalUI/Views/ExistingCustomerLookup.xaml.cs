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
using MySql.Data.MySqlClient;

namespace CarRentalUI.Views
{
    /// <summary>
    /// Interaction logic for ExistingCustomerLookup.xaml
    /// </summary>
    public partial class ExistingCustomerLookup : Page
    {
        public int EmpId;
        public string EmpName;
        public ExistingCustomerLookup(int empId, string empName)
        {
            EmpId = empId;
            EmpName = empName;
            InitializeComponent();
        }
        private void SignOutNavigation(object sender, RoutedEventArgs e)
        {
            LoginPage newLoginPage = new LoginPage();
            NavigationService.Navigate(newLoginPage);
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

        List<Customer> customerList = new List<Customer>();
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            

            var dbCon = DBConnection.Instance();
            dbCon.Server = "209.106.201.103";
            dbCon.DatabaseName = "group1";
            dbCon.UserName = "dbstudent11";
            dbCon.Password = "kindsteel51";
            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                string query;
                query = String.Format("SELECT * FROM Customers WHERE firstName like '{0}%' AND lastName like '{1}%';", FirstNameBox.Text, LastNameBox.Text );
                customerList.Clear();
                try
                {
                    var cmd = new MySqlCommand(query, DBConnection.Connection);

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {//  string someStringFromColumnZero = reader.GetString(0);
                        Customer customer = new Customer();
                        customer.CustomerId = reader.GetInt32(0);
                        customer.FirstName = reader.GetString(1);
                        customer.MiddleName=reader.GetString(2);
                        customer.LastName = reader.GetString(3);
                        customer.DateOfBirth = reader.GetString(4);
                        customer.PhoneNumber = reader.GetString(5);
                        customer.EmailAddress = reader.GetString(6);
                        customer.Address = reader.GetString(7);
                        customer.City = reader.GetString(8);
                        customer.PostalCode = reader.GetString(9);
                        customer.State = reader.GetString(10);

                        customerList.Add(customer);
                    }

                    PopulateList();
                }
                catch (Exception exception)
                {
                    string exceptionMessage;
                    exceptionMessage = Convert.ToString(exception);
                    MessageBox.Show(exceptionMessage);
                    throw;
                }
                dbCon.Close();
                dbCon.Cleaner();

            }
        }

        private int fni;
        private void FirstNameBox_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (fni == 0)
            {
                FirstNameBox.Text = "";
                fni++;
            }
        }

        private int lni;
        private void LastNameBox_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (lni == 0)
            {
                LastNameBox.Text = "";
                lni++;
            }
        }

        private void PopulateList()
        {
            ListDisplay.Items.Clear();
            foreach (Customer customer in customerList)
            {
                ListDisplay.Items.Add(customer);
            }
            
        }

        private void SelectCustomer_onClick(object sender, RoutedEventArgs e)
        {
            Customer customerToPass = new Customer();
            customerToPass = ListDisplay.SelectedItem as Customer;
            CustomerPortal customerPortal = new CustomerPortal( EmpId, EmpName, customerToPass);
            NavigationService.Navigate(customerPortal);
        }
    }
}
