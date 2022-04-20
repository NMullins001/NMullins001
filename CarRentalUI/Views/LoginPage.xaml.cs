using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace CarRentalUI.Views
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void AttemptLogin(object sender, RoutedEventArgs e)
        {
            
            string loginName = UsernameBox.Text;
            string passwordLogin = PasswordBox.Password;
            

            LoginInformation loginInfo = new LoginInformation(null,-1,null);
            

            if (loginName == "" | passwordLogin == "")
            {
                MessageBox.Show("One or more empty fields.");
                MainLoginSplash failLoginSplash = new MainLoginSplash();
                NavigationService.Navigate(failLoginSplash);
            }
            else
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
                    query = String.Format("SELECT * FROM loginInformation WHERE username like '{0}';", loginName);

                    try
                    {
                        var cmd = new MySqlCommand(query, DBConnection.Connection);

                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            LoginInformation employeeTempInformation = new LoginInformation(reader.GetString(0),
                                Convert.ToInt32(reader.GetString(1)), reader.GetString(2));
                            loginInfo = employeeTempInformation;
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


                if (loginInfo.Password == passwordLogin)
                {

                    EmployeeSplashPage employeeSplashPage =
                        new EmployeeSplashPage(loginInfo.EmployeeId, loginInfo.UserName);
                    NavigationService.Navigate(employeeSplashPage);

                }
                else
                {
                    MessageBox.Show("Invalid Login");
                    NavigationService.GoBack();
                }
            }

        }

        private void PasswordBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == "Password")
                PasswordBox.Password = "";
        }

        private void UsernameBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if(UsernameBox.Text == "Username")
                UsernameBox.Text = "";
        }
        private void PasswordBox_OnLostFocus(object sender, RoutedEventArgs e)
        {
           if(PasswordBox.Password == "") 
               PasswordBox.Password = "Password";
        }

        private void UsernameBox_OnLostFocus(object sender, RoutedEventArgs e)
        {
            if(UsernameBox.Text == "")
                UsernameBox.Text = "Username";
        }


    }
}
