using EntityKatmani.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmani.Entitys
{
    public class Urun
    {
        [Key]
        public int Id { get; set; }
        public string Adi { get; set; }
        public int Kategori { get; set; }
        public int Uretici { get; set; }
        public string OlusturanUye { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public List<int> UrunIcerikler { get; set; }
    }
}