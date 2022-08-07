using Furniture.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.BLL.Abstract
{
    public interface IKategoriService
    {
        List<Kategori> GetList();
        void KategoriAdd(Kategori kategori);
        Kategori GetById(int id);
        void KategoriDelete(Kategori kategori);
        void KategoriUpdate(Kategori kategori);
    }
}
