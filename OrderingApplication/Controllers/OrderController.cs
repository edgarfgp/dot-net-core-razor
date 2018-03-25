using Microsoft.AspNetCore.Mvc;
using OrderingApplication.Models;
using OrderingApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.Controllers
{
    public class OrderController : Controller
    {
        private IFormDataService _formDataService;

        public OrderController(IFormDataService formDataService)
        {
            _formDataService = formDataService;
        }
        // GET: /<controller>/
        public IActionResult NewOrder()
        {
            var newOrder = new Order();
            newOrder.Products = _formDataService.GetProducts();
            return View(newOrder);
        }

        [HttpPost]
        public IActionResult NewOrder(Order newOrder)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
