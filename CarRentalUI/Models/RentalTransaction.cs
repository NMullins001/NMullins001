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

        private void AgeProcessing()
        {
            DateTime today = DateTime.Today;

            AgeNeedsProcessing =  DateTime.Parse(EndDate) - DateTime.Parse(StartDate);
            if (AgeNeedsProcessing < TimeSpan.Zero)
            {
                AgeNeedsProcessing = TimeSpan.Zero;
            }

            Age = AgeNeedsProcessing.Days;

            AgeNeedsProcessing = today - DateTime.Parse(StartDate);
            if (AgeNeedsProcessing > TimeSpan.Zero)
            {
                Exception exception = new Exception("Date range cannot be before current date.");
                throw exception;
            }

        }
        public void FormatDates()
        {
            string startingdate=StartDate,endingdate=EndDate;
            DateTime inputStartingDate, inputEndingDate;

            inputStartingDate = DateTime.Parse(startingdate);
            inputEndingDate = DateTime.Parse(endingdate);
            StartDate = inputStartingDate.ToString("yyyy-M-d");
            EndDate = inputEndingDate.ToString("yyyy-M-d");

            AgeProcessing();
        }


        //public override string ToString()
        //{
        //    return String.Format(VinNumber + );
        //}
    }
}
