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
    /// Interaction logic for QuickRentCustomerSelect.xaml
    /// </summary>
    
    public partial class QuickRentCustomerSelect : Page
    {
        private int EmpID;
        private string EmpName;
        private Vehicle ImportedVehicle;
        public QuickRentCustomerSelect(int empID,string empName, Vehicle importedVehicle)
        {
            EmpID = empID;
            EmpName = empName;
            ImportedVehicle = importedVehicle;
            InitializeComponent();
        }

        private void StopQuickRent(object sender, RoutedEventArgs e)
        {
            VehicleInvLookup vehicleInvLookup = new VehicleInvLookup(EmpID, EmpName);
            NavigationService.Navigate(vehicleInvLookup);
        }

        private void SignOutNavigation(object sender, RoutedEventArgs e)
        {
            LoginPage newLoginPage = new LoginPage();
            NavigationService.Navigate(newLoginPage);
        }

        /// <summary>
        /// Copied Code From Views/existingcustomerlookup.cs
        /// </summary>
        List<Customer> customerList = new List<Customer>();
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            string firstName, lastName;
            if (FirstNameBox.Text == "First Name" | FirstNameBox.Text == "")
                firstName = "";
            else
                firstName = FirstNameBox.Text;
            if (LastNameBox.Text == "Last Name" | LastNameBox.Text == "")
                lastName = "";
            else
                lastName = LastNameBox.Text;

            var dbCon = DBConnection.Instance();
            dbCon.Server = "209.106.201.103";
            dbCon.DatabaseName = "group1";
            dbCon.UserName = "dbstudent11";
            dbCon.Password = "kindsteel51";
            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                string query;
                query = String.Format("SELECT * FROM Customers WHERE firstName like '{0}%' AND lastName like '{1}%';", firstName, lastName);
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
                        customer.MiddleName = reader.GetString(2);
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
        private void FirstNameBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (fni == 0)
            {
                FirstNameBox.Text = "";
                fni++;
            }
        }

        private int lni;
        private void LastNameBox_OnGotFocus(object sender, RoutedEventArgs e)
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
            QuickRentCreation quickRentCreation = new QuickRentCreation(EmpID, EmpName, ImportedVehicle, customerToPass);
            NavigationService.Navigate(quickRentCreation);
        }
    }
}

