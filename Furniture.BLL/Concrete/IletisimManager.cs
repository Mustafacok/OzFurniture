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
    public class IletisimManager : IIletisimService
    {
        IIletisimDal _iletisimDal;
        public IletisimManager(IIletisimDal iletisimDal)
        {
            _iletisimDal = iletisimDal;
        }
        public Iletisim GetById(int id)
        {
            return _iletisimDal.Get(x => x.IletisimId == id);
        }

        public List<Iletisim> GetList()
        {
            return _iletisimDal.List();
        }

        public void IletisimAdd(Iletisim iletisim)
        {
            _iletisimDal.Insert(iletisim);
        }

        public void IletisimDelete(Iletisim iletisim)
        {
            _iletisimDal.Delete(iletisim);
        }

        public void IletisimUpdate(Iletisim iletisim)
        {
            _iletisimDal.Update(iletisim);
        }
    }
}
