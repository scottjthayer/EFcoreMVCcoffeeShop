using CoffeeShop2EFCORELab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop2EFCORELab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult CustomerList()
        {
            List<Customer> result = null;
            using (CoffeeShopDbContext context = new CoffeeShopDbContext())
            {
                result = context.Customers.ToList();
            }
            return View(result);
        }

        public IActionResult CreateCustomer(Customer c, string SeniorDiscount)
        {
            //grabbing bool from radio buttons
            if (SeniorDiscount == "1")
            {
                c.SeniorDiscount = true;
            }
            else
            {
                c.SeniorDiscount = false;
            }

            using (CoffeeShopDbContext context = new CoffeeShopDbContext())
            {
                context.Customers.Add(c);
                //save
                context.SaveChanges();
            }
            return Redirect("Registration");
        }

        public IActionResult ViewDetails(int id)
        {
            Customer result = null;
            using (CoffeeShopDbContext context = new CoffeeShopDbContext())
            {
                result = context.Customers.Find(id);
            }
            return View(result);
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
