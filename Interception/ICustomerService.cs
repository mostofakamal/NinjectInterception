using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interception
{
    public interface ICustomerService
    {
        List<string> GetCustomers();

        string GetCustomer(int customerId);
        string GetCustomerByFilter(FilterCriteria criteria);
    }
}
