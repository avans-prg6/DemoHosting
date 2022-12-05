using DemoHostingMNO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoHostingMNO.Controllers
{
    public class HomeController : Controller
    {
        private readonly MijnContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MijnContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var pakjes = _context.Pakjes.ToList();
            ViewBag.pakjes = pakjes;
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