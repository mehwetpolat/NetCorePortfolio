using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Portfolyo.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.name = "Deneyim Listesi";
            ViewBag.name1 = "Deneyim";
            ViewBag.name2 = "Deneyim Listesi";

            var values = experienceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.name = "Deneyim Ekleme";
            ViewBag.name1 = "Deneyim";
            ViewBag.name2 = "Deneyim Ekleme";

            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = experienceManager.TGetById(id);
            experienceManager.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            ViewBag.name = "Deneyim Güncelleme";
            ViewBag.name1 = "Deneyim";
            ViewBag.name2 = "Deneyim Güncelleme";
            var value = experienceManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);

            return RedirectToAction("Index");
        }
    }
}