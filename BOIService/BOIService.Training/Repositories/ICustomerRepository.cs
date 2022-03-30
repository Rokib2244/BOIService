using BOIService.Training.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOIService.Data;

namespace BOIService.Training.Repositories
{
   public interface ICustomerRepository : IRepository<Customer, int>
    {
    }
}
