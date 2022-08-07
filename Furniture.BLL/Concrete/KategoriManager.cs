using Furniture.BLL.Abstract;
using Furniture.DAL.Abstract;
using Furniture.DAL.Concrete.Repositories;
using Furniture.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.BLL.Concrete
{
    public class KategoriManager : IKategoriService
    {

        IKategoriDal _kategoriDal;
        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public Kategori GetById(int id)
        {
            return _kategoriDal.Get(x => x.KategoriId == id);
        }

        public List<Kategori> GetList()
        {
            return _kategoriDal.List();
        }

        public void KategoriAdd(Kategori kategori)
        {
            _kategoriDal.Insert(kategori);
        }

        public void KategoriDelete(Kategori kategori)
        {
            _kategoriDal.Delete(kategori);
        }

        public void KategoriUpdate(Kategori kategori)
        {
            _kategoriDal.Update(kategori);
        }


        //public void KategoriAddBl(Kategori p)
        //{
        //    if (p.KategoriAdi =="" || p.KategoriDurumu==false || p.KategoriAdi.Length <=3)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        _kategoriDal.Insert(p);
        //    }
        //}
    }
}
