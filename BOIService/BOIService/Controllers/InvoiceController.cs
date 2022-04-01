using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using BOIService.Training.BusinessObjects;
using BOIService.Models;

namespace BOIService.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly ILogger<InvoiceController> _logger;
        public InvoiceController(ILogger<InvoiceController> logger)
        {
            _logger = logger;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult CreateInvoice()
        {
            List<Customer> customersList = new List<Customer>();
            var modelForCustomerList = new CustomerListModel();
            customersList = modelForCustomerList.GetAllCustomersForInvoice().ToList();
            customersList.Insert(0, new Customer { Id = 0, Name = "Select" });
            ViewBag.ListOfCustomer = customersList;

            var model = new CreateInvoiceModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateInvoice(CreateInvoiceModel model)
        {
            return View();
        }
    }
}
