using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
