using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalUI.Models
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }


        public Employee(int customerId, string firstName, string middleName, string lastName, string dateOfBirth,
            string phoneNumber, string emailAddress, string address, string city, string postalCode, string state)
        {
            EmployeeId = customerId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            Address = address;
            City = city;
            PostalCode = postalCode;
            State = state;
        }
    }

    
}
