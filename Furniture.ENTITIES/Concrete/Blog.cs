using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.ENTITIES.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        [StringLength(50)]
        public string BlogAdi { get; set; }
        [StringLength(500)]
        public string BlogIcerigi { get; set; }
        [StringLength(50)]
        public string BlogGorseli { get; set; }
        public int BlogSirasi { get; set; }
        public bool BlogDurumu { get; set; }

        public int UrunId { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
