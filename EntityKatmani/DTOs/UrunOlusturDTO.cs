namespace EntityKatmani.DTOs
{
    public class UrunOlusturDTO
    {
        public string Adi { get; set; }
        public int KategoriId { get; set; }
        public int Uretici { get; set; }
        public string OlusturanUye { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public List<int> UrunIcerikler { get; set; }
        public int Kategoriler { get; set; }
    }
}