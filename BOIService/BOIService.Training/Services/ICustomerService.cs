using BOIService.Training.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOIService.Training.Services
{
    public interface ICustomerService
    {
        void CreateCourse(Customer customer);
        IList<Customer> GetAllCustomersForInvoice();
    }
}
