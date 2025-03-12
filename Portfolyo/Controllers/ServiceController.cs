using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.name = "Hizmet Listesi";
            ViewBag.name1 = "Hizmetler";
            ViewBag.name2 = "Hizmet Listesi";

            var values = serviceManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.name = "Hizmet Ekleme";
            ViewBag.name1 = "Hizmetler";
            ViewBag.name2 = "Hizmet Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var value = serviceManager.TGetById(id);
            serviceManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            ViewBag.name = "Güncelleme";
            ViewBag.name1 = "Hizmetler";
            ViewBag.name2 = "Güncelleme";
            var value = serviceManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");

        }

    }
}
