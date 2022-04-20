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
    /// Interaction logic for CustomersRentals.xaml
    /// </summary>
    public partial class CustomersRentals : Page
    {
        private int EmpId;
        private string EmpName;
        private Customer Customer;
        List<RentalTransaction> RentalTransactionList = new List<RentalTransaction>();
        
        List<Vehicle> VehicleList = new List<Vehicle>();
        public CustomersRentals(int empId,string empName, Customer customer)
        {
            EmpId = empId;
            EmpName = empName;
            Customer = customer;
            InitializeComponent();
        }
        
        private void CustomerLabel_OnLoaded(object sender, RoutedEventArgs e)
        {
            CustomerLabel.Content = Customer.FirstName + " " + Customer.LastName + "'s Rentals" ;
        }

        private void GoBackToSelectedCustomerPortal(object sender, RoutedEventArgs e)
        {
            CustomerPortal customerPortal = new CustomerPortal(EmpId, EmpName, Customer);
            NavigationService.Navigate(customerPortal);
        }

        private void SignOutNavigation(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            NavigationService.Navigate(loginPage);
        }
        private void PopulateList()
        {

          
            RentedVehicleListBox.Items.Clear();
            
            foreach (Vehicle vehicle in VehicleList)
            {
                RentedVehicleListBox.Items.Add(vehicle);
            }

        }

        private void ListBoxLoaded(object sender, RoutedEventArgs e)
        {
            var dbCon = DBConnection.Instance();
            dbCon.Server = "209.106.201.103";
            dbCon.DatabaseName = "group1";
            dbCon.UserName = "dbstudent11";
            dbCon.Password = "kindsteel51";
            if (dbCon.IsConnect())
            {
                string query;
                query = String.Format("SELECT * FROM RentalTransactions JOIN " +
                                      "VehicleStock ON VehicleStock.vinNumber = RentalTransactions.vinNumber " +
                                      "WHERE RentalTransactions.customerID = {0};", Customer.CustomerId);
                RentalTransactionList.Clear();
                VehicleList.Clear();
                try
                {
                    var cmd = new MySqlCommand(query, DBConnection.Connection);

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {//  string someStringFromColumnZero = reader.GetString(0);
                        RentalTransaction rentalTransaction = new RentalTransaction();
                        rentalTransaction.RentalNumber = reader.GetInt32(0);
                        rentalTransaction.VinNumber = reader.GetString(1);
                        rentalTransaction.EmployeeId = reader.GetInt32(2);
                        rentalTransaction.StartDate = reader.GetString(3);
                        rentalTransaction.EndDate = reader.GetString(4);
                        rentalTransaction.CustomerId = reader.GetInt32(5);
                        RentalTransactionList.Add(rentalTransaction);

                        Vehicle vehicle = new Vehicle();
                        vehicle.VinNumber = reader.GetString(6);
                        vehicle.Manufacturer = reader.GetString(7);
                        vehicle.Model = reader.GetString(8);
                        vehicle.Color = reader.GetString(9);
                        vehicle.Type = reader.GetString(10);
                        vehicle.Miles = reader.GetInt32(11);
                        vehicle.CarYear = reader.GetString(12);
                        vehicle.Condition = reader.GetString(13);
                        vehicle.PricePerDay = reader.GetDouble(14);
                        VehicleList.Add(vehicle);



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

        private void DeleteRental(object sender, RoutedEventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle = RentedVehicleListBox.SelectedItem as Vehicle;

            var dbCon = DBConnection.Instance();
            dbCon.Server = "209.106.201.103";
            dbCon.DatabaseName = "group1";
            dbCon.UserName = "dbstudent11";
            dbCon.Password = "kindsteel51";
            if (dbCon.IsConnect())
            {
                string query;
                query = String.Format("DELETE RentalTransactions FROM RentalTransactions JOIN " +
                                      "VehicleStock ON VehicleStock.vinNumber = RentalTransactions.vinNumber " +
                                      "WHERE RentalTransactions.customerID = {0} AND RentalTransactions.rentalNumber = {1};", Customer.CustomerId, RentalTransactionList[0].RentalNumber);
                try
                {
                    var cmd = new MySqlCommand(query, DBConnection.Connection);

                    var reader = cmd.ExecuteNonQuery();
                    MessageBox.Show("Success");
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

        private void EditRental(object sender, RoutedEventArgs e)
        {
            try
            {
                Exception exception = new Exception("Not Yet Implemented");
                throw exception;
            }
            catch (Exception exception)
            {
                MessageBox.Show(Convert.ToString(exception));
            }
        }

        private void PayForRental(object sender, RoutedEventArgs e)
        {
            Vehicle vehicleTemp = new Vehicle();
            vehicleTemp = RentedVehicleListBox.SelectedItem as Vehicle;

            if (vehicleTemp != null)
            {
                var dbCon = DBConnection.Instance();
                dbCon.Server = "209.106.201.103";
                dbCon.DatabaseName = "group1";
                dbCon.UserName = "dbstudent11";
                dbCon.Password = "kindsteel51";
                if (dbCon.IsConnect())
                {
                    string query;
                    query = String.Format("SELECT * FROM RentalTransactions JOIN " +
                                          "VehicleStock ON VehicleStock.vinNumber = RentalTransactions.vinNumber " +
                                          "WHERE RentalTransactions.customerID = {0} AND RentalTransactions.vinNumber = '{1}';",
                        Customer.CustomerId, vehicleTemp.VinNumber);
                    try
                    {
                        var cmd = new MySqlCommand(query, DBConnection.Connection);
                        var reader = cmd.ExecuteReader();
                        RentalTransactionList.Clear();
                        VehicleList.Clear();
                        while (reader.Read())
                        {
                            //  string someStringFromColumnZero = reader.GetString(0);
                            RentalTransaction rentalTransaction = new RentalTransaction();
                            rentalTransaction.RentalNumber = reader.GetInt32(0);
                            rentalTransaction.VinNumber = reader.GetString(1);
                            rentalTransaction.EmployeeId = reader.GetInt32(2);
                            rentalTransaction.StartDate = reader.GetString(3);
                            rentalTransaction.EndDate = reader.GetString(4);
                            rentalTransaction.CustomerId = reader.GetInt32(5);
                            RentalTransactionList.Add(rentalTransaction);

                            Vehicle vehicle = new Vehicle();
                            vehicle.VinNumber = reader.GetString(6);
                            vehicle.Manufacturer = reader.GetString(7);
                            vehicle.Model = reader.GetString(8);
                            vehicle.Color = reader.GetString(9);
                            vehicle.Type = reader.GetString(10);
                            vehicle.Miles = reader.GetInt32(11);
                            vehicle.CarYear = reader.GetString(12);
                            vehicle.Condition = reader.GetString(13);
                            vehicle.PricePerDay = reader.GetDouble(14);
                            VehicleList.Add(vehicle);
                        }
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




                PaymentPortal paymentPortal = new PaymentPortal(EmpId, EmpName, Customer, RentalTransactionList[0],VehicleList[0]);
                NavigationService.Navigate(paymentPortal);
            }
        }
    }

}
