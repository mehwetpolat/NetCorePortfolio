using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Dashboard
{
    public class StatisticDashBoard: ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.projectCount = context.Portfolios.Count();
            ViewBag.serviceCount = context.Services.Count();
            ViewBag.messageCount = context.Messages.Count();
            return View();
        }
    }
}
