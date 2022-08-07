using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.ENTITIES.Concrete
{
    public class Iletisim
    {
        [Key]
        public int IletisimId { get; set; }
        [StringLength(50)]
        public string Adi { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Baslik { get; set; }
        [StringLength(1000)]
        public string Aciklama { get; set; }
    }
}
