using BusinessKatmani.Interfaces;
using DataAccessKatmani.Contexts;
using EntityKatmani.Entitys;
using System.Text.RegularExpressions;

namespace BusinessKatmani.Services.ControlService
{
    public class UyeService : IUyeService
    {
        private readonly Context _db;

        public UyeService(Context db)
        {
            _db = db;
        }

        public bool IsimKontrol(Uye uye)
        {
            if (uye.Ad.Length <= 2)
            {
                throw new Exception("İsim en az 3 karakter olmalıdır!");
            }
            return true;
        }

        public bool KullaniciAdiKontrol(Uye uye)
        {
            if (uye.KullaniciAdi.Length <= 2)
            {
                throw new Exception("Kullanıcı adı en az 3 karakter olmalıdır!");
            }
            return true;
        }

        public bool MailKontrol(Uye uye)
        {
            if (string.IsNullOrWhiteSpace(uye.MailAdresi))
            {
                throw new Exception("Mail adresi boş olamaz");
            }
            string email = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(uye.MailAdresi, email))
            {
                throw new Exception("Geçerli bir mail adresi giriniz.");
            }
            return true;
        }

        public bool SifreKontrol(Uye uye)
        {
            var sifreKontrol = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$";
            var regex = new Regex(sifreKontrol);
            if (!regex.IsMatch(uye.Sifre))
            {
                throw new Exception("Şifreniz en az bir büyük harf, bir küçük harf ve bir rakam içermelidir.");
            }
            return true;
        }

        public bool SoyisimKontrol(Uye uye)
        {
            if (uye.Soyad.Length <= 1)
            {
                throw new Exception("Soyisim en az 2 karakter olmalıdır.");
            }
            return true;
        }
    }
}