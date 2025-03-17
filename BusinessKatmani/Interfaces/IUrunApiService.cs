using EntityKatmani.DTOs;
using EntityKatmani.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmani.Interfaces
{
    public interface IUrunApiService
    {
        Task<List<Urun>> TumUrunleriGetir();
        Task<bool> UrunOlustur(UrunOlusturDTO dto);
    }
}