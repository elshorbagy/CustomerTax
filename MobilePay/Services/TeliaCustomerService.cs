namespace MobilePay
{
    public class TeliaCustomerService : CustomerService
    {
        public TeliaCustomerService(string customerName) : base(customerName)
        {
            Discount = 0.1;
        }
    }
}
