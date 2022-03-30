using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace CarRentalUI.Models
{
    class Payment
    {
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public int RentalNumber { get; set; }
        public double AmountDue { get; set; }

        public Payment(int paymentId, int customerId, int rentalNumber, double amountDue)
        {
            PaymentId = paymentId;
            CustomerId = customerId;
            RentalNumber = rentalNumber;
            AmountDue = amountDue;
        }

    }
}
