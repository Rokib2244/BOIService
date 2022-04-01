using BOIService.Data;
using BOIService.Training.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOIService.Training.UnitOfWorks
{
   public interface ITrainingUnitOfWork : IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        IInvoiceRepository Invoices { get; }
    }
}
