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
    /// Interaction logic for VehicleManagement.xaml
    /// </summary>
    public partial class VehicleManagement : Page
    {
        private int EmpId;
        private string EmpName;
        public VehicleManagement(int empId, string empName)
        {
            EmpId = empId;
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

        private void AddANewVehicle_OnClick(object sender, RoutedEventArgs e)
        {
            AddNewVehicle addNewVehicle = new AddNewVehicle(EmpId,EmpName);
            NavigationService.Navigate(addNewVehicle);
        }

        private void ViewExistingVehicles(object sender, RoutedEventArgs e)
        {
            VehicleInvLookup vehicleInvLookup = new VehicleInvLookup(EmpId, EmpName);
            NavigationService.Navigate(vehicleInvLookup);
        }

    }
}
