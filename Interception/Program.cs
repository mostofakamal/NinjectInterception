using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Interception.Infrastructure.Language;

namespace Interception
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Bind<ICustomerService>().To<CustomerService>().Intercept().With<LoggingInterceptor>();

            var customerService = kernel.Get<ICustomerService>();
            customerService.GetCustomer(2);
            customerService.GetCustomers();
            customerService.GetCustomerByFilter(new FilterCriteria
            {
                Name = "Abu Hena",
                Id = 323
            });

        }
    }
}
