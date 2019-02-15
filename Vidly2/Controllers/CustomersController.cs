using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.ViewModels;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class CustomersController : Controller
    {

        // GET: Customers
        public ActionResult Index()
        {
            var list = new CustomerViewModel();

            list.Customers.Add(new Customer { Name = "John Smith", Id = 1 });
            list.Customers.Add(new Customer { Name = "Mary Williams", Id = 2 });

            return View(list);
        }

        public ActionResult Details(int id)
        {
            var list = new CustomerViewModel();

            list.Customers.Add(new Customer { Name = "John Smith", Id = 1 });
            list.Customers.Add(new Customer { Name = "Mary Williams", Id = 2 });

            ViewBag.Id = id;

            return View(list);
        }
    }
}