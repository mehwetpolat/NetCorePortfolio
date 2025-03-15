using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Dashboard
{
    public class VisitorMap: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
