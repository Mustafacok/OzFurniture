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
    public class AdminKategoriController : Controller
    {
        // GET: AdminKategori
        KategoriManager cm = new KategoriManager(new EfKategoriDal());

        [Authorize]
        public ActionResult Index()
        {
            var kategoriValues = cm.GetList();
            return View(kategoriValues);
        }
        [HttpGet]
        public ActionResult AddKategori()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult AddKategori(Kategori p)
        {
            KategoriValidator kategorivalidator = new KategoriValidator();
            ValidationResult results = kategorivalidator.Validate(p);
            if (results.IsValid)
            {
                cm.KategoriAdd(p);
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

        public ActionResult DeleteKategori(int id)
        {
            var kategorivalue = cm.GetById(id);
            cm.KategoriDelete(kategorivalue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditKategori(int id)
        {
            var kategorivalue = cm.GetById(id);
            return View(kategorivalue);
        }
        [HttpPost]
        public ActionResult EditKategori(Kategori p)
        {
            cm.KategoriUpdate(p);
            return RedirectToAction("Index");
        }
    }
}