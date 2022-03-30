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
    /// Interaction logic for AddNewVehicle.xaml
    /// </summary>
    public partial class AddNewVehicle : Page
    {
        private int EmpId;
        private string EmpName;
        public AddNewVehicle(int empId, string empName)
        {
            InitializeComponent();
        }

        private void GoToVehicleManagement(object sender, RoutedEventArgs e)
        {
            VehicleManagement vehicleManagement = new VehicleManagement(EmpId, EmpName);
            NavigationService.Navigate(vehicleManagement);
        }

        private void GoToEmployeeSplashPage(object sender, RoutedEventArgs e)
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
        private void VinNumberBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (vni == 0)
            {
                VinNumberBox.Text = "";
                vni++;
            }
        }
        
        private int moi;

        private void ModelBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (moi == 0)
            {
                ModelBox.Text = "";
                moi++;
            }
        }
        private int cbi;

        private void ColorBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (cbi == 0)
            {
                ColorBox.Text = "";
                cbi++;
            }
        }
        private int vtb;

        private void VehicleTypeBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (vtb == 0)
            {
                VehicleTypeBox.Text = "";
                vtb++;
            }
        }
        private int yni;

        private void YearBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (yni == 0)
            {
                YearBox.Text = "";
                yni++;
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
        private int cdi;

        private void ConditionBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (cdi == 0)
            {
                ConditionBox.Text = "";
                cdi++;
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

        private decimal pdi;
        private void PricePerDay_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (pdi == 0)
            {
                PricePerDay.Text = "";
                pdi++;
            }
        }

        private void AddVehicle(object sender, RoutedEventArgs e)
        {
            int errorDetected=0;
            if (VinNumberBox.Text == "")
            {
                errorDetected++;
            }
            else if (ManufacturerBox.Text == "")
            {
                errorDetected++;
            }
            else if (ModelBox.Text == "")
            {
                errorDetected++;
            }
            else if (YearBox.Text == "")
            {
                errorDetected++;
            }
            else if (ColorBox.Text == "")
            {
                errorDetected++;
            }
            else if (VehicleTypeBox.Text == "")
            {
                errorDetected++;
            }
            else if (MilesBox.Text == "")
            {
                errorDetected++;
            }
            else if (ConditionBox.Text == "")
            {
                errorDetected++;
            }
            else if (Convert.ToDecimal(PricePerDay.Text) == 0)
            {
                errorDetected++;
            }

            if (errorDetected > 0)
                MessageBox.Show("There are errors that need fixing\nNote for no middle name leave blank.");
            if (errorDetected == 0)
            {
                Vehicle vehicle = new Vehicle(VinNumberBox.Text, ManufacturerBox.Text, ModelBox.Text, ColorBox.Text,
                    VehicleTypeBox.Text, Convert.ToInt32(MilesBox.Text), YearBox.Text, ConditionBox.Text, Convert.ToDouble(PricePerDay.Text),"0");
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
                            "INSERT INTO VehicleStock () " +
                            "VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');",
                            vehicle.VinNumber, vehicle.Manufacturer, vehicle.Model, vehicle.Color,
                            vehicle.Type, vehicle.Miles, vehicle.CarYear, vehicle.Condition,
                            vehicle.PricePerDay, vehicle.IsRented );
                        
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

                        MessageBox.Show($"Success\nEntry Added For " + vehicle.VinNumber);
                        ResetTextBoxes();
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

        private void ResetTextBoxes()
        {
            VinNumberBox.Text = "VIN Number";
            ManufacturerBox.Text = "Manufacturer";
            ModelBox.Text = "Model";
            ColorBox.Text = "Color";
            VehicleTypeBox.Text = "Vehicle Type";
            YearBox.Text = "Year";
            ConditionBox.Text = "Condition";
            PricePerDay.Text = "Price Per Day";
            MilesBox.Text = "Miles";
        }
    }
}
