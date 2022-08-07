using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.ENTITIES.Concrete
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string AdiSoyadi { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string KullaniciAdi { get; set; }
        [StringLength(50)]
        public string Sifre { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
}
