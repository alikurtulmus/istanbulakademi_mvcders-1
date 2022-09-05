using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using istanbulakademi_mvcders_1.Models;

namespace istanbulakademi_mvcders_1.Controllers
{
    public class DoktorController : Controller
    {
        HastaneDBEntities db=new HastaneDBEntities();

        // GET: Doktor
        public ActionResult Doktorlar()
        {
            var values = db.doktor_tbl.ToList();
            return View(values);
        }
        public ActionResult Branslar()
        {
            var values=db.brans_tbl.ToList();
            return View(values);
        }

    }
}