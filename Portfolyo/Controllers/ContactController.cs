using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = messageManager.TGetList();
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
            var value = messageManager.TGetById(id);
            messageManager.TDelete(value);
            return RedirectToAction("Index");
        }

        public IActionResult DetailContact(int id)
        {
            var value = messageManager.TGetById(id);
            return View(value);
        }
    }
}
