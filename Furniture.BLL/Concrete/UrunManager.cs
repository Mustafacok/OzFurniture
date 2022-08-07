using Furniture.BLL.Abstract;
using Furniture.DAL.Abstract;
using Furniture.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.BLL.Concrete
{
    public class UrunManager : IUrunService
    {
        IUrunDal _urunDal;
        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }
        public Urun GetById(int id)
        {
            return _urunDal.Get(x => x.UrunId == id);
        }

        public List<Urun> GetList()
        {
            return _urunDal.List();
        }

        public void UrunAdd(Urun urun)
        {
            _urunDal.Insert(urun);
        }

        public void UrunDelete(Urun urun)
        {
            _urunDal.Delete(urun);
        }

        public void UrunUpdate(Urun urun)
        {
            _urunDal.Update(urun);
        }
    }
}
