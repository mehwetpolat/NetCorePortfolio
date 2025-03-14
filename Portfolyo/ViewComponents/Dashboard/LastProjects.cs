using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Dashboard
{
    public class LastProjects: ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
