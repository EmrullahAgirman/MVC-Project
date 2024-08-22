using ASPNetCoreOrnek.Entities;
using ASPNetCoreOrnek.Models;
using ASPNetCoreOrnek.Services.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreOrnek.Controllers
{
    [Route(template:"deneme")]
    public class CustomerController:Controller
    {

        private ILogger _logger;
        public CustomerController(ILogger logger)
        {
            _logger = logger;
        }

        //Http GET
        [Route(template: "index")]
        public IActionResult Index3()
        {
            //DatabaseLogger logger = new DatabaseLogger();
            //logger.Log("");

            _logger.Log("");
            List<Customer> customers = new List<Customer>
            {
            new Customer {Id = 1, FirstName="Emrullah",LastName="Ağırman",City="Bursa"},
            new Customer { Id = 2, FirstName = "Merve", LastName = "Ağırman", City = "Erzurum" },
            new Customer { Id = 3, FirstName = "Muhammet", LastName = "Ağırman", City = "İstanbul"}
            };
            List<string> shops = new List<string> { "İstanbul", "Bursa", "Erzurum" };

            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops
            };
            return View(model);
        }

        [HttpGet] //default olarak gettir bişey yazmaya gerek yok.
        [Route(template: "save")]
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel 
            {
                Cities = new List<SelectListItem>
                {
                    new SelectListItem {Text="Bursa",Value="16"},
                    new SelectListItem {Text="İstanbul",Value="34"},
                    new SelectListItem {Text="Erzurum",Value="25"}
                }
                
            });
        }

        [HttpPost]
        [Route(template: "save")]
        public string SaveCustomer(Customer customer)
        {
            return "Kaydedildi";
        }
    }
}
