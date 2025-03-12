using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.name = "Güncelleme";
            ViewBag.name1 = "Hakkımda";
            ViewBag.name2 = "Güncelleme";

            var value = aboutManager.TGetById(1);
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");
        }
    }
}
