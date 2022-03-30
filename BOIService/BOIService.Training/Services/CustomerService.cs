using AutoMapper;
using BOIService.Training.BusinessObjects;
using BOIService.Training.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOIService.Training.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;
        private readonly IMapper _mapper;
        public CustomerService(ITrainingUnitOfWork trainingUnitOfWork, IMapper mapper)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
            _mapper = mapper;

        }

        public void CreateCourse(Customer customer)
        {
            if (customer == null)
                throw new InvalidOperationException("Customer was not provided");

            //if (IsProductNameAlreadyUsed(product.ProductName))
            //    throw new DuplicateNameException("Product Name already Used");
            //if (!IsValidTimeSetup(product.Date))
            //    throw new InvalidOperationException("Date should not be Past");

            _trainingUnitOfWork.Customers.Add(
                _mapper.Map<Entities.Customer>(customer));
            _trainingUnitOfWork.Save();
        }
    }
}
