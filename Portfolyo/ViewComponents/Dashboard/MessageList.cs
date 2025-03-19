using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Dashboard
{
    public class MessageList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
