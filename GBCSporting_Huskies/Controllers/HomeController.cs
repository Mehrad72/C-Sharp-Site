using GBCSporting_Huskies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GBCSporting_Huskies.Controllers
{
    public class HomeController : Controller
    {
        private SportingContext context { get; set; }
        public HomeController(SportingContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }


        public IActionResult Technician()
        {
            var technician = context.Technicians
                .OrderBy(cx => cx.Firstname).ToList();

            return View(technician);
        }

        public IActionResult Product()
        {
            var product = context.Products
                .OrderBy(cx => cx.Name).ToList();

            return View(product);
        }

        public IActionResult Customer()
        {
            var customer = context.Customers
                .Include(cx => cx.Country)
                .OrderBy(cx => cx.Firstname)
                .ToList();
            return View(customer);
        }

        public IActionResult Incident()
        {
            var incident = context.Incidents
                .OrderBy(cx => cx.Title).ToList();

            return View(incident);
        }
    }
}