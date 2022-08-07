using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.ENTITIES.Concrete
{
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }
        [StringLength(50)]
        public string UrunAdi { get; set; }
        [StringLength(500)]
        public string UrunAciklama { get; set; }
        [StringLength(50)]
        public string UrunGorseli { get; set; }

        public bool UrunDurumu { get; set; }
        public int UrunSirasi { get; set; }

        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}
