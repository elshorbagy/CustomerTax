using System;

namespace MobilePay
{
    class Program
    {
        static void Main()
        {
            var transaction = "2018-09-25 7-ELEVEN 50";
            var deserveDiscount = false;
            int i = 0;
            while (i < 10 )
            {                
                if (string.IsNullOrEmpty(transaction)) continue;
                var customerName = transaction.Split(' ')[1].ToUpper();
                var amount = transaction.Split(' ')[2];
                var date = transaction.Split(' ')[0];
                if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(amount) || string.IsNullOrEmpty(date)) continue;
                var customerService= CustomerFactory.CreateService(customerName);
                if (i > 8) deserveDiscount = true;
                var customer= customerService.CalculateFees(double.Parse(amount), DateTime.Parse(date), deserveDiscount);
                Console.WriteLine(customer.TransactionDate + " " + customer.CustomerName + " " + customer.ChargedAmount);
                i += 1;
            }
        }
    }
}
