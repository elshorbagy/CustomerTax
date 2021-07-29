namespace MobilePay
{
    public class CircleKCustomerService : CustomerService
    {
        public CircleKCustomerService(string customerName) : base(customerName)
        {
            Discount = 0.20;
        }
    }
}
