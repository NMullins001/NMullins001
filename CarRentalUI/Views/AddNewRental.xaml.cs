using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for AddNewRental.xaml
    /// </summary>
    public partial class AddNewRental : Page
    {
        private int EmpId;
        private string EmpName;
        private Customer Customer;
        
        public AddNewRental(int empId, string empName, Customer customer)
        {
            EmpId = empId;
            EmpName = empName;
            Customer = customer;
            InitializeComponent();
        }


        private void CustomerPortalNavigation(object sender, RoutedEventArgs e)
        {
            CustomerPortal customerPortal = new CustomerPortal(EmpId, EmpName, Customer);
            NavigationService.Navigate(customerPortal);
        }

        private void NewCustomerRegistrationNavigation(object sender, RoutedEventArgs e)
        {
            AddNewCustomer addNewCustomer = new AddNewCustomer(EmpId, EmpName);
            NavigationService.Navigate(addNewCustomer);
        }

        private void ExistingCustomerLookupNavigation(object sender, RoutedEventArgs e)
        {
            ExistingCustomerLookup existingCustomerLookup = new ExistingCustomerLookup(EmpId, EmpName);
            NavigationService.Navigate(existingCustomerLookup);
        }

        private void CustomerManagementNavigation(object sender, RoutedEventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement(EmpId, EmpName);
            NavigationService.Navigate(customerManagement);
        }

        private void EmployeePortalNavigation(object sender, RoutedEventArgs e)
        {
            EmployeeSplashPage employeeSplashPage = new EmployeeSplashPage(EmpId, EmpName);
            NavigationService.Navigate(employeeSplashPage);
        }

        private void SignOut(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            NavigationService.Navigate(loginPage);
        }

        private void CustomerLabel_OnLoaded(object sender, RoutedEventArgs e)
        {
            CustomerLabel.Content = "Adding A New Rental for " + Customer.FirstName + " " + Customer.LastName;
        }
        
        private int vni;
        private void VinNumberBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (vni == 0)
            {
                VinNumberBox.Text = "";
                vni++;
            }
        }
        private void AddNewRentalForCustomer(object sender, RoutedEventArgs e)
        {
            
            try
            {
                
                RentalTransaction rentalTransaction = new RentalTransaction();

                ///////////////////////////////////////////////////////////////////
                // Date Validation
                string startTime=StartingDateBox.Text, endTime = EndingDateBox.Text, vinNumber=VinNumberBox.Text;


                if (startTime == "" | startTime == "Select a date")
                {
                    Exception invalidStartingDate = new Exception("Please Enter a Starting Date");
                    throw invalidStartingDate;
                }
                if (endTime == "" | endTime == "Select a date")
                {
                    Exception invalidStartingDate = new Exception("Please Enter an Ending Date");
                    throw invalidStartingDate;
                }

                rentalTransaction.StartDate = startTime;
                rentalTransaction.EndDate = endTime;

                rentalTransaction.FormatDates();


                

                if (rentalTransaction.Age == 0)
                {
                    Exception exception = new Exception("Please Enter a valid range of dates");
                    throw exception;
                }

                ///////////////////////////////////////////////////////////////////
                // VinNumber Validation
                if (vinNumber == "" | vinNumber == "VIN Number")
                {
                    Exception invalidVinNumber = new Exception("Please Enter a Vin Number");
                    throw invalidVinNumber;
                }
                rentalTransaction.VinNumber=vinNumber;
                ///////////////////////////////////////////////////////////////////

                    rentalTransaction.CustomerId = Customer.CustomerId;
                    rentalTransaction.EmployeeId = EmpId;

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
                                "INSERT INTO RentalTransactions ( vinNumber, employeeID, startDate, endDate, customerID) " +
                                "VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}');", rentalTransaction.VinNumber,
                                rentalTransaction.EmployeeId, rentalTransaction.StartDate, rentalTransaction.EndDate,
                                rentalTransaction.CustomerId);
                        
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

                            MessageBox.Show($"Success\nEntry Added For " + rentalTransaction.CustomerId +
                                            " VIN NUMBER:" + rentalTransaction.VinNumber);
                            var dbCon2 = DBConnection.Instance();
                            dbCon2.Server = "209.106.201.103";
                            dbCon2.DatabaseName = "group1";
                            dbCon2.UserName = "dbstudent11";
                            dbCon2.Password = "kindsteel51";
                            if (dbCon2.IsConnect())
                            {
                                query = string.Format(
                                    "SELECT rentalNumber FROM RentalTransactions WHERE vinNumber='{0}' AND employeeID='{1}' AND startDate='{2}' AND endDate='{3}' AND customerID='{4}'"
                                    , rentalTransaction.VinNumber, rentalTransaction.EmployeeId,
                                    rentalTransaction.StartDate, rentalTransaction.EndDate,
                                    rentalTransaction.CustomerId);
                                try
                                {
                                    var cmdSearch = new MySqlCommand(query, DBConnection.Connection);
                                    var reader = cmdSearch.ExecuteReader();

                                    while (reader.Read())
                                    {
                                        rentalTransaction.RentalNumber = reader.GetInt32(0);
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
                    var dbCon3 = DBConnection.Instance();
                    dbCon3.Server = "209.106.201.103";
                    dbCon3.DatabaseName = "group1";
                    dbCon3.UserName = "dbstudent11";
                    dbCon3.Password = "kindsteel51";
                    if (dbCon3.IsConnect())
                    {
                        string query;
                        query = String.Format("INSERT INTO Payment ( customerID, rentalNumber) VALUES ( '{0}', '{1}');", Customer.CustomerId, rentalTransaction.RentalNumber);
                        try
                        {
                            var cmd = new MySqlCommand(query, DBConnection.Connection);
                            var reader = cmd.ExecuteNonQuery();

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

                        CustomerPortal customerPortal = new CustomerPortal(EmpId, EmpName, Customer);
                        NavigationService.Navigate(customerPortal);
                    }

            }
            catch (Exception exception)
            {
                string message = Convert.ToString(exception.Message);
                MessageBox.Show(message);
            }
        }





    }
}
