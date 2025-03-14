using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Dashboard";
            ViewBag.name1 = "İstatistikler";
            ViewBag.name2 = "İstatistik Listesi";
            return View();
        }
    }
}
