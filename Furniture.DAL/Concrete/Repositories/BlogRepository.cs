using Furniture.DAL.Abstract;
using Furniture.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.DAL.Concrete.Repositories
{
    public class BlogRepository : IBlogDal
    {
        Context c = new Context();
        DbSet<Blog> _object;

        public void Delete(Blog p)
        {
            throw new NotImplementedException();
        }

        public Blog Get(Expression<Func<Blog, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog p)
        {
            throw new NotImplementedException();
        }

        public List<Blog> List()
        {
            throw new NotImplementedException();
        }

        public List<Blog> List(Expression<Func<Blog, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog p)
        {
            throw new NotImplementedException();
        }
    }
}
