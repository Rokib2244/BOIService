using Autofac;
using AutoMapper;
using BOIService.Training.BusinessObjects;
using BOIService.Training.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOIService.Models
{
    public class CreateCustomerModel
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int PaymentTerm { get; set; }

        private  ICustomerService _customerService;
        private  IMapper _mapper;
        public CreateCustomerModel()
        {
            _customerService = Startup.AutofacContainer.Resolve<ICustomerService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        public CreateCustomerModel(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        internal void CreateCustomer()
        {
            var customer = _mapper.Map<Customer>(this);

            //var customer = new Customer
            //{
            //    Name = Name,
            //    Email = Email,
            //    Address = Address,
            //    PaymentTerm = PaymentTerm
            //};

            _customerService.CreateCourse(customer);
        }
    }
}
