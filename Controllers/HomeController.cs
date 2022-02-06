using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestTask_versta24.Data;
using TestTask_versta24.Models;

namespace TestTask_versta24.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MainDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, MainDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Order()
        {
            IEnumerable<Order> objList = _dbContext.Order;
            return View(objList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order obj)
        {
            Random rnd = new Random();
            obj.Number = rnd.Next(10000000, 20000000).ToString();
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return RedirectToAction("Order");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
