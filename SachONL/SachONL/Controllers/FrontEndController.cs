using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SachONL.Models;

namespace SachONL.Controllers
{
    public class FrontEndController : Controller
    {
        // GET: FrontEnd
        QLBanSachEntities1 db = new QLBanSachEntities1();
        public ActionResult Index()
        {
            return View(db.SACHes.ToList().Take(6));
        }
        public ActionResult subject()
        {
            return PartialView(db.CHUDEs.ToList());
        }
    }
}