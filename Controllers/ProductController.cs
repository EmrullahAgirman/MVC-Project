using ASPNetCoreOrnek.Entities;
using ASPNetCoreOrnek.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreOrnek.Controllers
{
    public class ProductController : Controller

    {
        public IActionResult Index()
        {
            return View();
        }

        public string Index2(int id)
        {
            return id.ToString();
        }


    }
}
