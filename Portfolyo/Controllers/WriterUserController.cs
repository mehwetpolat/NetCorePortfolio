using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Portfolyo.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager userManager = new WriterUserManager(new EfWriterUserDal());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(userManager.TGetList());
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddUser(WriterUser writerUser)
        {
            userManager.TAdd(writerUser);
            var values = JsonConvert.SerializeObject(writerUser);
            return Json(values);
        }
    }
}
