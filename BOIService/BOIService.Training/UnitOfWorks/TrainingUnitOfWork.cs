using BOIService.Data;
using BOIService.Training.Contexts;
using BOIService.Training.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOIService.Training.UnitOfWorks
{
   public class TrainingUnitOfWork: UnitOfWork, ITrainingUnitOfWork
    {
        public ICustomerRepository Customers { get; private set; }
        public IInvoiceRepository Invoices { get; private set; }
        public TrainingUnitOfWork( TrainingContext context, ICustomerRepository customers,
            IInvoiceRepository invoices)
            :base((DbContext)context)
        {
            Customers = customers;
            Invoices = invoices;
        }

        
    }
}
