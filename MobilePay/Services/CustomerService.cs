using MobilePay.Models;
using System;

namespace MobilePay
{
    public class CustomerService
    {
        public double Discount { get; set; }
        private readonly string _customerName;

        public CustomerService(string customerName)
        {
            _customerName = customerName;
        }

        public virtual Customer CalculateFees(double amount, DateTime transactionDate,bool deserveDiscount)
        {
            if (deserveDiscount)
            {
                Discount = 0.2;
            }

            var customer = new Customer()
            {
                ChargedAmount = 0,
                CustomerName = _customerName,
                TransactionDate = transactionDate.ToString("yyyy-MM-dd")
            };

            if (transactionDate.DayOfWeek == DayOfWeek.Saturday || transactionDate.DayOfWeek == DayOfWeek.Sunday)
            {
                return customer;
            }

            var totalFees = amount * 0.01;
            customer.ChargedAmount = totalFees - (totalFees * Discount);

            return customer;
        }
    }
}
