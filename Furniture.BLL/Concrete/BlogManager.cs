﻿using Furniture.BLL.Abstract;
using Furniture.DAL.Abstract;
using Furniture.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.BLL.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal= blogDal;
        }

        public void BlogAdd(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void BlogDelete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public Blog GetById(int id)
        {
            return _blogDal.Get(x => x.BlogId == id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.List();
        }
    }
}
