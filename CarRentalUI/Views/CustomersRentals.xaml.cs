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
    /// Interaction logic for CustomersRentals.xaml
    /// </summary>
    public partial class CustomersRentals : Page
    {
        private int EmpId;
        private string EmpName;
        private Customer Customer;
        public CustomersRentals(int empId,string empName, Customer customer)
        {
            EmpId = empId;
            EmpName = empName;
            Customer = customer;
            InitializeComponent();
        }
    }
}
