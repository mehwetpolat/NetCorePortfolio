using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Dashboard
{
    public class FeatureStatistics: ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.skillCount = context.Skills.Count();
            ViewBag.unReadMessage = context.Messages.Where(x => x.Status == false).Count();
            ViewBag.readMessage = context.Messages.Where(x => x.Status == true).Count();
            ViewBag.experienceCount = context.Experiences.Count();
            return View();
        }
    }
}