using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPractica.Models;

namespace WebAppPractica.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer> {
                new Customer{ id = 1, name = "Kevin" },
                new Customer{ id = 2, name = "Tita" },
                new Customer{ id = 3, name = "Rick" },
                new Customer{ id = 4, name = "Diabolic" }
            };

            return View(customers);
        }
    }
}