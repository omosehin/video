using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
       
        public ActionResult Index()
        {
            var customers = new List<Customer> { 
            new Customer{Name = "John Smith"},
            new Customer{Name = "Mary Williams"}
            };

            var viewCustomer = new ViewCustomerModel()
            {
                
                  Customers = customers
            };

            return View(viewCustomer);

        }
        public ActionResult Details(int id)
        {
            //var Id =  id;
            return Content(string.Format("{0}", id));
        }

        // mvcaction4  

        //mvcaction4      
    }
}