using Furniture.DAL.Abstract;
using Furniture.DAL.Concrete.Repositories;
using Furniture.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.DAL.EntityFramework
{
    public class EfYoneticiDal: GenericRepository<Yonetici>, IYoneticiDal
    {
    }
}
