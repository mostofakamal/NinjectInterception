using System.Collections.Generic;

namespace Interception
{
    public class CustomerService : ICustomerService
    {
        public List<string> GetCustomers()
        {
           return new List<string>()
           {
              "Sumon",
              "Kamal",
              "Mostofa"
           };

        }

        public string GetCustomer(int customerId)
        {
            return "sumon";
        }

        public string GetCustomerByFilter(FilterCriteria criteria)
        {
            return "Abu Hena";
        }
    }
}