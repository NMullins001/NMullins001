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
    /// Interaction logic for VehicleInvLookup.xaml
    /// </summary>
    public partial class VehicleInvLookup : Page
    {
        private int EmpId;
        private string EmpName;
        public VehicleInvLookup(int empId, string empName)
        {
            EmpId = empId;
            EmpName = empName;
            InitializeComponent();
        }

        private void VehicleMangementNavigation(object sender, RoutedEventArgs e)
        {
            VehicleManagement vehicleManagement = new VehicleManagement(EmpId, EmpName);
            NavigationService.Navigate(vehicleManagement);
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

        private int vni;
        private void VinNumberBox_OnFocus(object sender, RoutedEventArgs e)
        {
            if (vni == 0)
            {
                VinNumberBox.Text = "";
                vni++;
            }
        }
        private int mfi;

        private void ManufacturerBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (mfi == 0)
            {
                ManufacturerBox.Text = "";
                mfi++;
            }
        }
        private int mdi;

        private void ModelBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (mdi == 0)
            {
                ModelBox.Text = "";
                mdi++;
            }
        }
        private int coi;

        private void ColorBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (coi == 0)
            {
                ColorBox.Text = "";
                coi++;
            }
        }

        private int mii;

        private void MilesBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (mii == 0)
            {
                MilesBox.Text = "";
                mii++;
            }
        }

        private int cyi;

        private void CarYearBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (cyi == 0)
            {
                CarYearBox.Text = "";
                cyi++;
            }
        }
        private int pmi;

        private void PriceBoxMin_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (pmi == 0)
            {
                PriceBoxMin.Text = "";
                pmi++;
            }
        }

        private int pni;

        private void PriceBoxMax_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (pni == 0)
            {
                PriceBoxMax.Text = "";
                pni++;
            }
        }
        private void ViewVehicleDetails(object sender, RoutedEventArgs e)
        {
            try
            {
                throw new NotImplementedException("Not Implemented Yet");
            }
            catch (NotImplementedException exception)
            {
                string exceptionMessage;
                exceptionMessage = Convert.ToString(exception);
                MessageBox.Show(exceptionMessage);
            }
        }

        private void QuickRent(object sender, RoutedEventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle = ListDisplay.SelectedItem as Vehicle;
            QuickRentCustomerSelect quickRentCustomerSelect = new QuickRentCustomerSelect(EmpId, EmpName, vehicle);
            NavigationService.Navigate(quickRentCustomerSelect);
        }

        List<Vehicle> vehicleList = new List<Vehicle>();
        private void SearchVehicle(object sender, RoutedEventArgs e)
        {
            double MinPrice = -1, MaxPrice = -1;
            int VehicleStatus=-1,miles=-1;
            string vehicleType = "", VinNumber = "", model="",color="",manufacturer="",year="";
            
            try
            {
                //Price Min and Max Formatting
                if (PriceBoxMin.Text == "")
                    MinPrice = 0.00;
                if (PriceBoxMax.Text == "")
                    MaxPrice = 0.00;
                if (PriceBoxMin.Text == "Min Price")
                    MinPrice = 0.00;
                if (PriceBoxMax.Text == "Max Price")
                    MaxPrice = 0.00;
                

                if (MinPrice == 0)
                { }
                else
                {
                    MinPrice = double.Parse(PriceBoxMin.Text);
                }
                if (MaxPrice == 0)
                { MaxPrice = 99999999.00; }
                else
                {
                    MaxPrice = double.Parse(PriceBoxMax.Text);
                }

                
                if (MinPrice > MaxPrice)
                {
                    Exception exception = new Exception("Max Price cannot be lower than min price");
                    throw exception;
                }
                ///////////////////////////////////////////////////////////////////////////////////////////
                // Vehicle Availability Formatting
                ComboBoxItem availability = (ComboBoxItem)VehicleRentalStatusBox.SelectedItem;
                string vehicleAvailability = availability.Name;

                if (vehicleAvailability=="Available")
                {
                    VehicleStatus = 0;
                }
                else
                {
                    VehicleStatus = 1;
                }
                ///////////////////////////////////////////////////////////////////////////////////////////
                // Vehicle Type Formatting
                ComboBoxItem vehicleTyping = (ComboBoxItem) VehicleTypeBox.SelectedItem;
                vehicleType = vehicleTyping.Name;
                ///////////////////////////////////////////////////////////////////////////////////////////
                // MilesBox Formatting
                if (MilesBox.Text == ""|MilesBox.Text == "Maximum Miles")
                    miles = 999999999;
                else
                {
                    miles = Convert.ToInt32(MilesBox.Text);
                }
                ///////////////////////////////////////////////////////////////////////////////////////////
                // VinNumberBox Formatting
                if (VinNumberBox.Text == "" | VinNumberBox.Text == "VIN Number")
                    VinNumber = "";
                else
                {
                    VinNumber = VinNumberBox.Text;
                }
                ///////////////////////////////////////////////////////////////////////////////////////////
                // ModelBox Formatting
                if (ModelBox.Text == "" | ModelBox.Text == "Model")
                    model = "";
                else
                {
                    model = ModelBox.Text;
                }
                ///////////////////////////////////////////////////////////////////////////////////////////
                // Manufacturer Formatting
                if (ManufacturerBox.Text == "" | ManufacturerBox.Text == "Manufacturer")
                    manufacturer = "";
                else
                {
                    manufacturer = ManufacturerBox.Text;
                }
                ///////////////////////////////////////////////////////////////////////////////////////////
                // Year Formatting
                if (CarYearBox.Text == "" | CarYearBox.Text == "Year")
                    year = "";
                else
                {
                    year = CarYearBox.Text;
                }
                ///////////////////////////////////////////////////////////////////////////////////////////
                // Color Formatting
                if (ColorBox.Text == "" | ColorBox.Text == "Color")
                    color = "";
                else
                {
                    color = ColorBox.Text;
                }
                ///////////////////////////////////////////////////////////////////////////////////////////


            }
            catch (Exception exception)
            {
                string exceptionMessage;
                exceptionMessage = Convert.ToString(exception);
                MessageBox.Show(exceptionMessage);
                VehicleInvLookup vehicleInvLookup = new VehicleInvLookup(EmpId, EmpName);
                NavigationService.Navigate(vehicleInvLookup);
            }

            var dbCon = DBConnection.Instance();
                dbCon.Server = "209.106.201.103";
                dbCon.DatabaseName = "group1";
                dbCon.UserName = "dbstudent11";
                dbCon.Password = "kindsteel51";
                if (dbCon.IsConnect())
                {
                    //suppose col0 and col1 are defined as VARCHAR in the DB
                    string query;
                    query = String.Format("SELECT * FROM VehicleStock WHERE vinNumber like '{0}%' AND manufacturer like '{1}%' AND model like '{2}%' AND color like '{3}%' " +
                                          "AND type like '{4}%' AND miles BETWEEN 0 AND {5} AND carYear like '{6}%' AND pricePerDay BETWEEN {7} AND {8} AND isRented = {9};"
                        , VinNumber, manufacturer, model, color, vehicleType, miles, year, Convert.ToString(MinPrice), Convert.ToString(MaxPrice), Convert.ToString(VehicleStatus));
                    vehicleList.Clear();
                    try
                    {
                        var cmd = new MySqlCommand(query, DBConnection.Connection);

                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {//  string someStringFromColumnZero = reader.GetString(0);
                            Vehicle vehicle = new Vehicle();
                            vehicle.VinNumber=reader.GetString(0);
                            vehicle.Manufacturer=reader.GetString(1);
                            vehicle.Model=reader.GetString(2);
                            vehicle.Color=reader.GetString(3);
                            vehicle.Type=reader.GetString(4);
                            vehicle.Miles = Convert.ToInt32(reader.GetString(5));
                            vehicle.CarYear = reader.GetString(6);
                            vehicle.Condition = reader.GetString(7);
                            vehicle.PricePerDay = Convert.ToDouble(reader.GetString(8));
                            vehicle.IsRented = reader.GetString(9);


                            vehicleList.Add(vehicle);
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
        private void PopulateList()
        {
            ListDisplay.Items.Clear();
            foreach (Vehicle vehicle in vehicleList)
            {
                ListDisplay.Items.Add(vehicle);
            }

        }

        private void CopyVin(object sender, RoutedEventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle = ListDisplay.SelectedItem as Vehicle;
            Clipboard.SetText(vehicle.VinNumber);
            string message = string.Format("Copied VIN Number to Clipboard for {0} {1} {2}", vehicle.CarYear,vehicle.Model,vehicle.Manufacturer);
            MessageBox.Show(message);
        }
    }
}
