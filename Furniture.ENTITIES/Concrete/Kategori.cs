using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.ENTITIES.Concrete
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        [StringLength(50)]
        public string KategoriAdi { get; set; }
        public int KateogoriSirasi { get; set; }
        public bool KategoriDurumu { get; set; }
        [StringLength(50)]
        public string Gorsel { get; set; }

        public ICollection<Urun> Uruns { get; set; }
    }
}
