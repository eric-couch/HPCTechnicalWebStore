using HPCTechnicalWebStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HPCTechnicalWebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Eric()
        {
            return Json(new { name = "Eric", age = 50, title = "senior dev/architect" });
        }

        public IActionResult JustText()
        {
            //return Content("This is just some text");
            return Ok("We're all good here.");
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