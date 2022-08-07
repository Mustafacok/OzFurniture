using Furniture.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.BLL.Abstract
{
    public interface IUrunService
    {
        List<Urun> GetList();
        void UrunAdd(Urun urun);
        Urun GetById(int id);
        void UrunDelete(Urun urun);
        void UrunUpdate(Urun urun);
    }
}
