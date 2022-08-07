using Furniture.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.BLL.Abstract
{
    public interface IIletisimService
    {
        List<Iletisim> GetList();
        void IletisimAdd(Iletisim iletisim);
        void IletisimDelete(Iletisim iletisim);
        void IletisimUpdate(Iletisim iletisim);
        Iletisim GetById(int id);
    }
}
