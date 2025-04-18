﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke()
        {
            string p = "mehmet@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x => x.WriterId).Take(3).ToList();
            return View(values);
        }
    }
}
