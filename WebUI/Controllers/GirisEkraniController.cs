using BusinessKatmani.Interfaces;
using EntityKatmani.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class GirisEkraniController : Controller
    {
        private readonly IUyeApiService _service;

        public GirisEkraniController(IUyeApiService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GirisYap()
        {
            return View(new KullaniciGirisDTO());
        }

        [HttpPost]
        public async Task<IActionResult> GirisYap(string kullaniciadi, string sifre)
        {
            var user = await _service.KullaniciGirisYap(kullaniciadi, sifre);
            if (user == null)
            {
                TempData["Hata"] = "Kullanıcı adı veya şifre hatalı!";
                return View();
            }
            return RedirectToAction("AnaPanel", "Anasayfa");
        }

        [HttpGet]
        public IActionResult KayitOl()
        {
            return View(new UyeOlusturmaDTO());
        }

        [HttpPost]
        public async Task<IActionResult> KayitOl(UyeOlusturmaDTO dto)
        {
            if (ModelState.IsValid)
            {
                if(await _service.UyeOlusturma(dto))
                {
                    TempData["başarılı"] = "Kayıt işlemi başarılı.";
                    return RedirectToAction("GirisYap");
                }
                return View(dto);
            }
            TempData["başarısız"] = "Kayıt işlemi sırasında bir hata oluştu. Tekrar deneyiniz";
            return View(dto);
        }
    }
}