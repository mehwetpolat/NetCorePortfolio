using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
