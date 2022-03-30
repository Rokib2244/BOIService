using BOIService.Data;
using BOIService.Training.Entities;
using BOIService.Training.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BOIService.Training.Repositories
{
    public class CustomerRepository : Repository<Customer, int>, ICustomerRepository
    {
        public CustomerRepository(TrainingContext context ): base((DbContext)context)
        {

        }
    }
}
