using BOIService.Data;
using BOIService.Training.Contexts;
using BOIService.Training.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOIService.Training.Repositories
{
    public class InvoiceRepository : Repository<Invoice, int>, IInvoiceRepository
    {
        public InvoiceRepository( TrainingContext context):base((DbContext) context)
        {

        }
    }
}
