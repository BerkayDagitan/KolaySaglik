using AutoMapper;
using DataAccessKatmani.Contexts;
using EntityKatmani.DTOs;
using EntityKatmani.Entitys;
using EntityKatmani.Enums;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunController : ControllerBase
    {
        private readonly Context _db;
        private readonly IMapper _mapper;

        public UrunController(Context db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpPost("urunEkle")]
        public IActionResult PostUrun([FromBody] UrunOlusturDTO dto)
        {
            Urun urun = new Urun()
            {
                Adi = dto.Adi,
                Kategori = (int)dto.Kategoriler, 
                Uretici = (int)dto.Uretici, 
                OlusturanUye = dto.OlusturanUye,
                UrunIcerikler = dto.UrunIcerikler.Select(a => (int)a).ToList()
            };
            _db.Urunler.AddAsync(urun);
            return _db.SaveChanges() > 0 ? Ok("Ürün başarıyla eklendi.") : BadRequest("Ürün eklenirken bir hata oluştu.");
        }

        [HttpGet("urunGetir")]
        public IActionResult GetUrunler()
        {
            return Ok(_db.Urunler.ToList());
        }

        [HttpPut("urunGuncelle")]
        public IActionResult PutUrun([FromBody]UrunGuncelleDTO dto)
        {
            _db.Urunler.Update(_mapper.Map<Urun>(dto));
            return _db.SaveChanges() > 0 ? Ok("Ürün başarıyla güncellendi.") : BadRequest("Ürün güncellenirken bir hata oluştu.");
        }

        [HttpDelete("urunSil/{id}")]
        public IActionResult DeleteUrun(int id)
        {
            Urun urun = _db.Urunler.FirstOrDefault(a => a.Id == id);
            if(urun is null) return NotFound("Bulunamadı.");
            _db.Urunler.Remove(urun);
            return _db.SaveChanges() > 0 ? Ok("Ürün silindi") : BadRequest("Ürün silinemedi");
        }
    }
}