using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalUI.Models
{
    class LoginInformation
    {
        public string UserName { get; set; }
        public int EmployeeId { get; set; }
        public string Password { get; set; }


        public LoginInformation(string userName, int employeeId, string password)
        {
            UserName=userName;
            EmployeeId=employeeId;
            Password=password;
        }

    }

    
}
