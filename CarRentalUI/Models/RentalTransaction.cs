using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalUI.Models
{
    public class RentalTransaction
    {
        public int RentalNumber { get; set; }
        public string VinNumber { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        private TimeSpan AgeNeedsProcessing { get; set; }
        public int Age { get; set; }
        
        
        public RentalTransaction(int rentalNumber, string vinNumber, int employeeId, string startDate, string endDate)
        {
            RentalNumber = rentalNumber;
            VinNumber = vinNumber;
            EmployeeId = employeeId;
            StartDate = startDate;
            EndDate = endDate;

            AgeProcessing();

        }

        public RentalTransaction()
        {
            
        }

        public void AgeProcessing()
        {
            AgeNeedsProcessing =  DateTime.Parse(EndDate) - DateTime.Parse(StartDate);
            Age = AgeNeedsProcessing.Days / 365;
        }
        public void FormatDates()
        {
            string startingdate=StartDate,endingdate=EndDate,middleman;
            DateTime inputStartingDate, inputEndingDate;
            inputStartingDate = DateTime.Parse(startingdate);
            inputEndingDate = DateTime.Parse(endingdate);
            middleman = inputStartingDate.ToString("yyyy-M-d");
            StartDate = middleman;
            middleman = inputEndingDate.ToString("yyyy-M-d");
            EndDate = middleman;
        }
    }
}
