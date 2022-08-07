using Furniture.BLL.Concrete;
using Furniture.BLL.ValidationRules;
using Furniture.DAL.EntityFramework;
using Furniture.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentValidation.Results;

namespace OzFurniture.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        KategoriManager cm = new KategoriManager(new EfKategoriDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetKategoriList()
        {
            var kategorivalues = cm.GetList();
            return View(kategorivalues);
        }

        [HttpGet]
        public ActionResult AddKategori()
        {
            return View();
        } 

        [HttpPost]
        public ActionResult AddKategori(Kategori p)
        {
            //cm.KategoriAddBL(p);
            KategoriValidator kategoriValidator = new KategoriValidator();
            ValidationResult results = kategoriValidator.Validate(p);
            if (results.IsValid)
            {
                cm.KategoriAdd(p);
                return RedirectToAction("GetKategoriList");
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