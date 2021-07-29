namespace MobilePay
{
    public class CustomerFactory
    {
        public static CustomerService CreateService(string customerName)
        {
            if (string.IsNullOrEmpty(customerName))
            {
                return new UnknownCustomerService("Unknown");
            }

            switch (customerName)
            {
                case "TELIA":
                    return new TeliaCustomerService(customerName);
                case "CIRCLE_K":
                    return new CircleKCustomerService(customerName);
                default:
                    return new CustomerService(customerName);
            }
        }
    }
}
