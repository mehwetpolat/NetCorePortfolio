using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
