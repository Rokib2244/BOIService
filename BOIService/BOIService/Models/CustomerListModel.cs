using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using BOIService.Training.Services;
using BOIService.Training.BusinessObjects;

namespace BOIService.Models
{
    public class CustomerListModel
    {
        private ICustomerService _customerService;
        public IList<Customer> Customers { get; set; }
        public CustomerListModel()
        {
            _customerService = Startup.AutofacContainer.Resolve<ICustomerService>();
        }
        public CustomerListModel(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IList<Customer> GetAllCustomersForInvoice()
        {
            Customers = _customerService.GetAllCustomersForInvoice();
            return Customers;
        }

    }
}
