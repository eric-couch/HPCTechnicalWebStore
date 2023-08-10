using Microsoft.AspNetCore.Mvc;

namespace HPCTechnicalWebStore.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return Json(new { name = "Eric", age = 50, title = "senior dev/architect" });
        }
        [Route("simple")]
        public IActionResult SimpleContent()
        {
            return Content("this is just text in the test controller, SimpleContent method/action");
        }
    }
}
