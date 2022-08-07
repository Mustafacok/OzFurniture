using Furniture.BLL.Concrete;
using Furniture.DAL.EntityFramework;
using Furniture.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OzFurniture.Controllers
{
    public class IletisimController : Controller
    {
        IletisimManager im = new IletisimManager(new EfIletisimDal());
        // GET: Iletisim
        public ActionResult Index()
        {
            var iletisimvalues = im.GetList();
            return View(iletisimvalues);
        }
        [HttpGet]
        public ActionResult AddIletisim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddIletisim(Iletisim p)
        {
            im.IletisimAdd(p);
            return RedirectToAction("Index");
        }
    }
}