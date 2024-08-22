using ASPNetCoreOrnek.Entities;
using ASPNetCoreOrnek.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreOrnek.Controllers
{
    public class SessionDemoController: Controller
    {
        public string index1()
        {
            Customer customer = new Customer {Id=1,FirstName="Engin" }; 

            //HttpContext.Session.SetString("isim","Emo");
            HttpContext.Session.SetObject("Musteri",customer);
            //return HttpContext.Session.GetString(key: "isim");
            return "Sessin oluştu";
        }

        public string index2()
        {
            //HttpContext.Session.SetString("soyisim","Emo2");
            //return HttpContext.Session.GetString(key:"isim");
            var customer = HttpContext.Session.GetObject<Customer>(key: "Musteri");
            return customer.FirstName;
        }
    }
}
