using EntityKatmani.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmani.Entitys
{
    public class KaraListe
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public Uye Uye { get; set; }
        public Urun Urun { get; set; }
        public List<UrunIcerik> UrunIcerigi { get; set; }
    }
}