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
    public class KategoriRepository : IKategoriDal
    {
        Context c = new Context();
        DbSet<Kategori> _object;

        public void Delete(Kategori p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public Kategori Get(Expression<Func<Kategori, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Kategori p)
        {
            _object.Add(p);
            c.SaveChanges();
            //throw new NotImplementedException(); // hata vermesin diye eklenmiş metot.
        }

        public List<Kategori> List()
        {
            return _object.ToList();
        }

        public List<Kategori> List(Expression<Func<Kategori, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Kategori p)
        {
            c.SaveChanges();
        }
    }
}
