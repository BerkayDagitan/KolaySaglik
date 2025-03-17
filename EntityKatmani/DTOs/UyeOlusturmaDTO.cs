using EntityKatmani.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmani.DTOs
{
    public class UyeOlusturmaDTO
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string MailAdresi { get; set; }
        public DateTime UyelikTarihi { get; set; } = DateTime.Now;
        public string Sifre { get; set; }
    }
}