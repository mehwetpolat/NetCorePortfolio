using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
