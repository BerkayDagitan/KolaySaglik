using EntityKatmani.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmani.Entitys
{
    public class Uye
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string MailAdresi { get; set; }
        public Rol Rol { get; set; } = Rol.Uye;
        public DateTime UyelikTarihi { get; set; } = DateTime.Now;
        public string Sifre { get; set; }
        public List<FavoriListesi> UyeFavoriListesi { get; set; } = new List<FavoriListesi>();
        public List<KaraListe> UyeKaraListe { get; set; } = new List<KaraListe>();
    }
}
