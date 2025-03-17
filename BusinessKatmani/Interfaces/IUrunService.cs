using EntityKatmani.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmani.Interfaces
{
    public interface IUrunService
    {
        public bool UrunAdiKontrol(Urun urun);
        //public bool UrunKategoriKontrol(Urun urun);
        public bool UrunUreticiKontrol(Urun urun);
        public bool UrunIcerikKontrol(Urun urun);
    }
}
