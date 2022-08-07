using FluentValidation.Results;
using Furniture.BLL.Concrete;
using Furniture.BLL.ValidationRules;
using Furniture.DAL.EntityFramework;
using Furniture.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OzFurniture.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        UrunManager um = new UrunManager(new EfUrunDal());
        UrunValidator urunvalidator = new UrunValidator();

        [Authorize]
        public ActionResult Index()
        {
            var UrunValues = um.GetList();
            return View(UrunValues);
        }
        [HttpGet]
        public ActionResult AddUrun()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUrun(Urun p)
        {
            ValidationResult results = urunvalidator.Validate(p);
            if (results.IsValid)
            {
                um.UrunAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult EditUrun(int id)
        {
            var urunvalue = um.GetById(id);
            return View(urunvalue);
        }
        [HttpPost]
        public ActionResult EditUrun(Urun p)
        {
            ValidationResult results = urunvalidator.Validate(p);
            if (results.IsValid)
            {
                um.UrunUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}