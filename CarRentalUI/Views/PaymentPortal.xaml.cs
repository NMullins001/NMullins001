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
    /// Interaction logic for PaymentPortal.xaml
    /// </summary>
    public partial class PaymentPortal : Page
    {
        private int EmpId;
        private string EmpName;
        private Customer Customer;
        private RentalTransaction RentalTransactionPayment;
        private Payment pay = new Payment();
        private Vehicle Vehicle;
        public PaymentPortal(int empId,string empName, Customer customer, RentalTransaction rentalTransaction)
        {
            EmpId = empId;
            EmpName = empName;
            Customer = customer;
            RentalTransactionPayment = rentalTransaction;
            InitializeComponent();
        }
        public PaymentPortal(int empId, string empName, Customer customer, RentalTransaction rentalTransaction, Vehicle vehicle)
        {
            EmpId = empId;
            EmpName = empName;
            Customer = customer;
            RentalTransactionPayment = rentalTransaction;
            Vehicle = vehicle;
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
            if (AmountToPayBox.Text == "" || AmountToPayBox.Text == "Amount To Pay")
                AmountToPayBox.Text = "0.00";

            double n;
            bool isNumeric = Double.TryParse(AmountToPayBox.Text, out n);
            if (isNumeric)
            {
                if ((pay.AmountPaid + Convert.ToDouble(AmountToPayBox.Text)) < pay.AmountDue)
                {

                    try
                    {
                        var dbCon = DBConnection.Instance();
                        dbCon.Server = "209.106.201.103";
                        dbCon.DatabaseName = "group1";
                        dbCon.UserName = "dbstudent11";
                        dbCon.Password = "kindsteel51";
                        if (dbCon.IsConnect())
                        {
                            double tempPayment = pay.AmountPaid + Convert.ToDouble(AmountToPayBox.Text);
                            string query;
                            query = String.Format("UPDATE Payment SET amountPaid = '{0}' WHERE paymentID = '{1}' ;", +
                                tempPayment, pay.PaymentId);
                            try
                            {
                                var cmd = new MySqlCommand(query, DBConnection.Connection);
                                var reader = cmd.ExecuteNonQuery();
                                MessageBox.Show("Success");
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show(Convert.ToString(exception));
                            }

                            dbCon.Close();
                            dbCon.Cleaner();

                            CustomersRentals customersRentals = new CustomersRentals(EmpId, EmpName, Customer);
                            NavigationService.Navigate(customersRentals);
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(Convert.ToString(exception));
                    }
                }
            }
        }

        private void AmountPaidLabel_OnLoaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void PaymentHeader_OnLoaded(object sender, RoutedEventArgs e)
        {
            
            pay.CustomerId = Customer.CustomerId;
            pay.RentalNumber = RentalTransactionPayment.RentalNumber;

            RentalTransactionPayment.FormatDates();
            
                var dbCon = DBConnection.Instance();
                dbCon.Server = "209.106.201.103";
                dbCon.DatabaseName = "group1";
                dbCon.UserName = "dbstudent11";
                dbCon.Password = "kindsteel51";
                if (dbCon.IsConnect())
                {
                    string query;
                    query = String.Format("SELECT * FROM Payment WHERE rentalNumber = '{0}';",pay.RentalNumber);
                    try
                    {
                        var cmd = new MySqlCommand(query, DBConnection.Connection);
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                         Payment payment = new Payment();
                         payment.PaymentId = reader.GetInt32(0);
                         payment.CustomerId = reader.GetInt32(1);
                         payment.RentalNumber = reader.GetInt32(2);
                         payment.AmountPaid = reader.GetDouble(3);
                         payment.AmountDue = reader.GetDouble(4);
                         pay = payment;
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

            if (pay.AmountDue == 0.00)
            {
                pay.AmountDue = RentalTransactionPayment.Age * Vehicle.PricePerDay;
            }
            AmountPaidLabel.Content = "Amount paid so far: $" + pay.AmountPaid;
            AmountDueLabel.Content = "Total cost of rental: $" + pay.AmountDue;
        }

        private void AmountToPayBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            AmountToPayBox.Text = "0.00";
        }
    }
}
