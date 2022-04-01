using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOIService.Training.UnitOfWorks;
using AutoMapper;

namespace BOIService.Training.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;
        private readonly IMapper _mapper;
        public InvoiceService(ITrainingUnitOfWork trainingUnitOfWork, IMapper mapper)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
            _mapper = mapper;
        }
    }
}
