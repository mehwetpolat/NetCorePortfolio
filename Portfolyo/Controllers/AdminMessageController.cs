using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            string p = "admin@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {
            string p = "admin@gmail.com";
            var values = writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }

        public IActionResult AdminMessageDetail(int id)
        {
            var values = writerMessageManager.TGetById(id);
            return View(values);
        }

        public IActionResult AdminMessageDelete(int id)
        {
            var value = writerMessageManager.TGetById(id);
            writerMessageManager.TDelete(value);

            if(value.Sender == "admin@gmail.com")
            {
                return RedirectToAction("SenderMessageList", "AdminMessage");
            }
            else
            {
                return RedirectToAction("ReceiverMessageList", "AdminMessage");
            }
           
        }


        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage wMessage)
        {
            wMessage.Sender = "admin@gmail.com";
            wMessage.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            wMessage.SenderName = "Admin";
            Context context = new Context();
            var userNameSurname = context.Users.Where(x => x.Email == wMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            wMessage.ReceiverName = userNameSurname;

            writerMessageManager.TAdd(wMessage);



            return RedirectToAction("SenderMessageList");
        }
    }
}
