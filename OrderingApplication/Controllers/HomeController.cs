using Microsoft.AspNetCore.Mvc;
using OrderingApplication.Services;
using OrderingApplication.ViewModels;

namespace OrderingApplication.Controllers
{
    public class HomeController : Controller
    {
        private OrderService _orderService;

        public HomeController(OrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            var orders = _orderService.GetOrders();
            var homeViewModel = new HomeViewModel
            {
                Title = "Orders",
                Orders = orders

            };

            return View(homeViewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Vote(int id)
        {
            return ViewComponent("SurveyWidget", new { ProductId = id });
        }
    }
}

