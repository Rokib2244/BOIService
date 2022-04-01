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
            //string errorMessage = "";
            //return errorMessage;
            if (customer == null)
                throw new InvalidOperationException("Customer was not provided");

            if (IsCustomerNameAlreadyRegistered(customer.Name))
                throw new InvalidOperationException("This Customer Name Already Exist");
            if (IsCustomerEmailAlreadyRegistered(customer.Email))
                throw new InvalidOperationException("This Customer Email Address Already Exist");

            _trainingUnitOfWork.Customers.Add(
                _mapper.Map<Entities.Customer>(customer));
            _trainingUnitOfWork.Save();
        }
        public bool IsCustomerNameAlreadyRegistered(string customerName) =>
            _trainingUnitOfWork.Customers.GetCount(x => x.Name == customerName) > 0;
        public bool IsCustomerEmailAlreadyRegistered(string email) =>
            _trainingUnitOfWork.Customers.GetCount(x => x.Email == email) > 0;

        public IList<Customer> GetAllCustomersForInvoice()
        {
            var customerEntities = _trainingUnitOfWork.Customers.GetAll();
            var customers = new List<Customer>();
            foreach(var entity in customerEntities)
            {
                var customer = _mapper.Map<Customer>(entity);
                customers.Add(customer);
            }
            return customers;
        }
    }
}
