using BOIService.Data;
using BOIService.Training.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOIService.Training.Repositories
{
    public interface IInvoiceRepository : IRepository<Invoice, int>
    {
    }
}
