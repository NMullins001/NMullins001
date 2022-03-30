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
    /// Interaction logic for AddNewCustomer.xaml
    /// </summary>
    public partial class AddNewCustomer : Page
    {
       private int EmpId;
       private string EmpName;

        public AddNewCustomer(int empId, string empName)
        {
            EmpId = empId;
            EmpName = empName;
            InitializeComponent();

        }

        //Navigation Dropdown
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
        //Navigation Dropdown End

        //Textbox Clearing
        private int fni;

        private void FirstNameBox_OnGotFocus(object sender, RoutedEventArgs e)
        {

            if (fni == 0)
            {
                FirstNameBox.Text = "";
                fni++;
            }
        }

        private int mni;

        private void MiddleNameBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (mni == 0)
            {
                MiddleNameBox.Text = "";
                mni++;
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

        private int pni;

        private void PhoneNumberBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (pni == 0)
            {
                PhoneNumberBox.Text = "";
                pni++;
            }
        }

        private int eai;

        private void EmailAddressBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (eai == 0)
            {
                EmailAddressBox.Text = "";
                eai++;
            }
        }

        private int adi;

        private void AddressBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (adi == 0)
            {
                AddressBox.Text = "";
                adi++;
            }
        }

        private int cii;

        private void CityBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (cii == 0)
            {
                CityBox.Text = "";
                cii++;
            }
        }

        private int sti;

        private void StateBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (sti == 0)
            {
                StateBox.Text = "";
                sti++;
            }
        }

        private int poi;

        private void PostalCodeBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (poi == 0)
            {
                PostalCodeBox.Text = "";
                poi++;
            }
        }
        //Clearing Textboxes End
        private int errorDetected=0;
        private void SignUpCustomer(object sender, RoutedEventArgs e)
        {
            if (FirstNameBox.Text == "")
            {
                errorDetected++;
            }
            else if (LastNameBox.Text == "")
            {
                errorDetected++;
            }
            else if (DatePicker.Text == "")
            {
                errorDetected++;
            } else if (PhoneNumberBox.Text == "")
            {
                errorDetected++;
            } else if (EmailAddressBox.Text == "")
            {
                errorDetected++;
            }else if (AddressBox.Text == "")
            {
                errorDetected++;
            }else if (CityBox.Text == "")
            {
                errorDetected++;
            } else if (PostalCodeBox.Text == "")
            {
                errorDetected++;
            }
            else if (StateBox.Text == "")
            {
                errorDetected++;
            }
            if (errorDetected > 0)
                MessageBox.Show("There are errors that need fixing\nNote for no middle name leave blank.");
            if (errorDetected == 0)
            {
                Customer customer = new Customer(FirstNameBox.Text, MiddleNameBox.Text, LastNameBox.Text,
                    DatePicker.Text,
                    PhoneNumberBox.Text, EmailAddressBox.Text, AddressBox.Text, CityBox.Text, PostalCodeBox.Text,
                    StateBox.Text);
                var dbCon = DBConnection.Instance();
                dbCon.Server = "209.106.201.103";
                dbCon.DatabaseName = "group1";
                dbCon.UserName = "dbstudent11";
                dbCon.Password = "kindsteel51";

                if (dbCon.IsConnect())
                {
                    try
                    {
                        //suppose col0 and col1 are defined as VARCHAR in the DB
                        string query;
                        query = String.Format(
                            "INSERT INTO Customers (firstName, middleName, lastName, dateOfBirth, phoneNumber, email, address, city, postal, state) " +
                            "VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');",
                            customer.FirstName, customer.MiddleName, customer.LastName, customer.DateOfBirth,
                            customer.PhoneNumber, customer.EmailAddress, customer.Address, customer.City,
                            customer.PostalCode, customer.State);

                        try
                        {
                            var cmd = new MySqlCommand(query, DBConnection.Connection);
                            cmd.ExecuteNonQuery();

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

                        MessageBox.Show($"Success\nEntry Added For " + customer.FirstName + " " + customer.LastName, customer.FirstName);
                        var dbCon2 = DBConnection.Instance();
                        dbCon2.Server = "209.106.201.103";
                        dbCon2.DatabaseName = "group1";
                        dbCon2.UserName = "dbstudent11";
                        dbCon2.Password = "kindsteel51";
                        if (dbCon2.IsConnect())
                        {
                            query = string.Format(
                                "SELECT customerID FROM Customers WHERE firstName='{0}' AND lastName='{1}' AND dateOfBirth='{2}' AND phoneNumber='{3}'",
                                customer.FirstName, customer.LastName, customer.DateOfBirth, customer.PhoneNumber);
                            try
                            {
                                var cmdSearch = new MySqlCommand(query, DBConnection.Connection);
                                var reader = cmdSearch.ExecuteReader();

                                while (reader.Read())
                                {
                                    customer.CustomerId = reader.GetInt32(0);
                                }
                            }
                            catch (Exception exception)
                            {
                                string exceptionMessage;
                                exceptionMessage = Convert.ToString(exception);
                                MessageBox.Show(exceptionMessage);
                                throw;
                            }

                            dbCon2.Close();
                            dbCon2.Cleaner();

                            CustomerPortal customerPortal = new CustomerPortal(EmpId, EmpName, customer);
                            NavigationService.Navigate(customerPortal);
                        }
                    }
                    catch (Exception exception)
                    {
                        string exceptionMessage;
                        exceptionMessage = Convert.ToString(exception);
                        MessageBox.Show(exceptionMessage);
                        throw;

                    }
                }
            }
        }
    }
}
