using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Portfolyo.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = values.Name + " " + values.Surname;


            // weatherapi
            string api = "97056c2a4eb94b030f2fa09da5a76d3a";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Sivas&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument documents = XDocument.Load(connection);
            ViewBag.temp = documents.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            // statistic
            Context context = new Context();
            ViewBag.userCount = context.Users.Count();
            ViewBag.messageCount = context.WriterMessages.Where(x => x.Receiver == values.Email).Count();
            ViewBag.announcementCount = context.Announcements.Count();
            ViewBag.skillCount = context.Skills.Count();


            return View();
        }
    }
}
