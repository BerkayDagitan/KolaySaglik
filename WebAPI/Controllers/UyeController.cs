using AutoMapper;
using BusinessKatmani.Interfaces;
using DataAccessKatmani.Contexts;
using EntityKatmani.DTOs;
using EntityKatmani.Entitys;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UyeController : ControllerBase
    {
        private readonly Context _db;
        private readonly IMapper _mapper;
        private readonly IUyeApiService _service;

        public UyeController(Context db, IMapper mapper, IUyeApiService service)
        {
            _db = db;
            _mapper = mapper;
            _service = service;
        }

        [HttpPost("uyeOlustur")]
        public IActionResult PostUye([FromBody] UyeOlusturmaDTO dto)
        {
            Uye uye = new Uye()
            {
                Ad = dto.Ad,
                Soyad = dto.Soyad,
                KullaniciAdi = dto.KullaniciAdi,
                MailAdresi = dto.MailAdresi,
                UyelikTarihi = dto.UyelikTarihi,
                Sifre = dto.Sifre
            };
            _db.Uyeler.AddAsync(uye);
            return _db.SaveChanges() > 0 ? Ok("Üye başarıyla eklendi.") : BadRequest("Üye eklenirken bir hata oluştu.");
        }

        [HttpGet("uyelistele")]
        public IActionResult GetUye()
        {
            return Ok(_db.Uyeler.ToList());
        }

        [HttpPut("uyeguncelle")]
        public IActionResult PutUye([FromBody] UyeGuncellemeDTO dto)
        {
            _db.Uyeler.Update(_mapper.Map<Uye>(dto));
            return _db.SaveChanges() > 0 ? Ok("Güncelleme Başarılı") : BadRequest("Güncelleme yapılamadı.");
        }

        [HttpDelete("uyesil/{id}")]
        public IActionResult DeleteUye(int id)
        {
            Uye uye = _db.Uyeler.FirstOrDefault(a => a.Id == id);
            if (uye is null) return NotFound("Bulunamadı.");
            _db.Uyeler.Remove(uye);
            return _db.SaveChanges() > 0 ? Ok("Üye Silindi") : BadRequest("Üye silinemedi.");
        }

        [HttpPost("girisyap")]
        public async Task<IActionResult> GirisUye([FromBody] KullaniciGirisDTO dto)
        {
            if (dto == null)
            {
                return BadRequest("Geçersiz giriş bilgileri");
            }

            var kullanici = _db.Uyeler.Where(x => x.KullaniciAdi.ToLower() == dto.KullaniciAdi.ToLower() && x.Sifre == dto.Sifre).FirstOrDefault();

            if (kullanici == null)
            {
                return NotFound("Kullanıcı adı veya şifre hatalı");
            }
            return Ok(kullanici);
        }
    }
}