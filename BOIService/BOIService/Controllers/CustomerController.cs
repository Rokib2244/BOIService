using Microsoft.AspNetCore.Mvc;
using BOIService.Training.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using BOIService.Models;

namespace BOIService.Controllers
{
    public class CustomerController : Controller
    {
        
        private readonly ILogger<CustomerController> _logger;
        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }
       public IActionResult Create()
        {
            var model = new CreateCustomerModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(CreateCustomerModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.CreateCustomer();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Failed to Create Customer");
                    _logger.LogError(ex, "Create Customer Failed.");
                }
            }

            return View();
        }
    }
}
