using MobilePay.Models;
using System;

namespace MobilePay
{
    public class UnknownCustomerService : CustomerService
    {
        public override Customer CalculateFees(double amount, DateTime transactionDate, bool deserveDiscount)
        {
            var customer = new Customer()
            {
                TransactionDate = transactionDate.ToShortDateString(),
                ChargedAmount = 0,
                CustomerName = "UnKnown"
            };
            return customer;
        }

        public UnknownCustomerService(string customerName) : base(customerName)
        {
        }
    }
}
