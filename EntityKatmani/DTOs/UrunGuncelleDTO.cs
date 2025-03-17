using EntityKatmani.Entitys;
using EntityKatmani.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmani.DTOs
{
    public class UrunGuncelleDTO
    {
        public string Adi { get; set; }
        public int KategoriId { get; set; }
        public Kategoriler Kategori { get; set; }
        public int UreticiId { get; set; }
        public Uretici Uretici { get; set; }
        public string OlusturanUye { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public List<UrunIcerik> UrunIcerikler { get; set; }
    }
}
