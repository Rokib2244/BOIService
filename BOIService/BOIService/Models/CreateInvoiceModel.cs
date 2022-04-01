using AutoMapper;
using Autofac;
using System;
using BOIService.Training.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BOIService.Models
{
    public class CreateInvoiceModel
    {
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


        private IInvoiceService _invoiceService;
        private IMapper _mapper;
        public CreateInvoiceModel()
        {
            _invoiceService = Startup.AutofacContainer.Resolve<IInvoiceService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        public CreateInvoiceModel(IInvoiceService invoiceService, IMapper mapper)
        {
            _invoiceService = invoiceService;
            _mapper = mapper;
        }


    }
}
