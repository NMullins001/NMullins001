using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CarRentalUI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set;}
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }


        public Customer(string firstName, string middleName, string lastName, string dateOfBirth,
            string phoneNumber, string emailAddress, string address, string city, string postalCode, string state)
        {
                FirstName=firstName;
                MiddleName=middleName;
                LastName=lastName;
                PhoneNumber=phoneNumber;
                EmailAddress=emailAddress;
                Address=address;
                City=city;
                PostalCode=postalCode;
                State=state;

                string ending, start = dateOfBirth;
                DateTime input;
                input = DateTime.Parse(start);
                ending = input.ToString("yyyy-M-d");
                DateOfBirth = ending;
        }
        public Customer(string firstName, string lastName, string dateOfBirth,
            string phoneNumber, string emailAddress, string address, string city, string postalCode, string state)
        {
            FirstName = firstName;
            MiddleName = null;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            Address = address;
            City = city;
            PostalCode = postalCode;
            State = state;

            string ending, start=dateOfBirth;
            DateTime input;
            input = DateTime.Parse(start);
            ending = input.ToString("yyyy-M-d");
            DateOfBirth = ending;

        }
        public Customer()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} {1} -- {2}", FirstName, LastName, PhoneNumber);
        }
    }
}
