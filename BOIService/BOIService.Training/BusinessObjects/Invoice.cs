using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOIService.Training.BusinessObjects
{
    public class Invoice
    {
        public int Id { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public double PenaltyInterest { get; set; }
        public int InvoiceReference { get; set; }
        public double NetAmount { get; set; }
        public double VatAmount { get; set; }
        public double GrossTotal { get; set; }
        public double ServiceChargeAgreed { get; set; }
        public bool VatCondition { get; set; }
        public int CustomerId { get; set; }
      
    }
}
