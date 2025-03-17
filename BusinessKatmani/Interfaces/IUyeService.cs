using EntityKatmani.DTOs;
using EntityKatmani.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmani.Interfaces
{
    public interface IUyeService
    {
        public bool IsimKontrol(Uye uye);
        public bool SoyisimKontrol(Uye uye);
        public bool KullaniciAdiKontrol(Uye uye);
        public bool MailKontrol(Uye uye);
        public bool SifreKontrol(Uye uye);
    }
}
