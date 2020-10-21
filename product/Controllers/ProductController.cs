using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using product.Utilities;

namespace product.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add(int id,string brand,string name,int qty,int price)
        {
            Bill ob = new Bill();
            ob.GenerateBill(id,brand,name,qty,price);
            return View();
        }
    }
}
