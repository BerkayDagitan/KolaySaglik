using BusinessKatmani.Interfaces;
using EntityKatmani.Entitys;
using EntityKatmani.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmani.Services.ControlService
{
    public class UrunService : IUrunService
    {
        public bool UrunAdiKontrol(Urun urun)
        {
            if (string.IsNullOrWhiteSpace(urun.Adi))
            {
                throw new Exception("Ürün adı boş olamaz");
            }
            return true;
        }

        public bool UrunIcerikKontrol(Urun urun)
        {
            if(urun.UrunIcerikler.Count < 10)
            {
                throw new Exception("Eklediğiniz üründe en az 10 içerik girmelisiniz.");
            }
            return true;
        }

        //public bool UrunKategoriKontrol(Urun urun)
        //{
        //    if(urun.Kategori == null || !Enum.IsDefined(typeof(EntityKatmani.Enums.Kategori), urun.Kategori.Kategoriler))
        //    {
        //        throw new Exception("Ürün kategorisi seçmelisiniz.");
        //    }
        //    return true;
        //}

        public bool UrunUreticiKontrol(Urun urun)
        {
            if(urun.Uretici == null)
            {
                throw new Exception("Ürün üreticisi yazmalısınız.");
            }
            return true;
        }
    }
}