using EntityKatmani.DTOs;
using EntityKatmani.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmani.Interfaces
{
    public interface IUyeApiService
    {
        Task<List<Uye>> TumUyeleriGetir();
        Task<KullaniciGirisDTO> KullaniciGirisYap(string kullaniciadi, string sifre);
        Task<bool> UyeOlusturma(UyeOlusturmaDTO dto);
    }
}
