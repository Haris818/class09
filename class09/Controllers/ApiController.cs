using System;
using System.Collections.Generic;
using System.Web.Mvc;
using class09.Models;  // Ensure you include the model namespace

namespace class09.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        public JsonResult getapi()
        {
            // Sample data to return as JSON
            var products = new List<Product>
            {
                new Product{ Id = 1, Name = "Laptop", Price = 750.00M },
                new Product { Id = 2, Name = "Tablet", Price = 300.00M },
                new Product { Id = 3, Name = "Smartphone", Price = 500.00M }
            };

            // Return JSON data with GET method allowed
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}
