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
    public class BlogController : Controller
    {
        // GET: Blog
        BlogManager bm = new BlogManager(new EfBlogDal());
        BlogValidator blogvalidator = new BlogValidator();
        [Authorize]
        public ActionResult Index()
        {
            var BlogValues = bm.GetList();
            return View(BlogValues);
        }
        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(Blog p)
        {
            ValidationResult results = blogvalidator.Validate(p);
            if (results.IsValid)
            {
                bm.BlogAdd(p);
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
        public ActionResult EditBlog(int id)
        {
            var blogvalue = bm.GetById(id);
            return View(blogvalue);
        }
        [HttpPost]
        public ActionResult EditBlog(Blog p)
        {
            ValidationResult results = blogvalidator.Validate(p);
            if (results.IsValid)
            {
                bm.BlogUpdate(p);
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