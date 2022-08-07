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
    public class UrunRepository : IUrunDal
    {
        Context c = new Context();
        DbSet<Urun> _object;
        public void Delete(Urun p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public Urun Get(Expression<Func<Urun, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Urun p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Urun> List()
        {
            return _object.ToList();
        }

        public List<Urun> List(Expression<Func<Urun, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Urun p)
        {
            c.SaveChanges();
        }
    }
}
