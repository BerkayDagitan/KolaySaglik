using BusinessKatmani.Interfaces;
using EntityKatmani.DTOs;
using EntityKatmani.Entitys;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class UrunController : Controller
    {
        private readonly IUrunApiService _service;

        public UrunController(IUrunApiService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult UrunEkle()
        {
            return View(new UrunOlusturDTO());
        }

        [HttpPost]
        public async Task<IActionResult> UrunEkle(UrunOlusturDTO dto)
        {
            if (ModelState.IsValid)
            {
                if(await _service.UrunOlustur(dto))
                {
                    TempData["urunEklemeBasarili"] = "Ürün eklendi";
                    return RedirectToAction("UrunEkle");
                }
                return View(dto);
            }
            TempData["urunEklenemedi"] = "Ürün eklenemedi. Tekrar deneyiniz.";
            return View(dto);
        }

        [HttpGet]
        public async Task<IActionResult> UrunleriListele()
        {
            var urunler = await _service.TumUrunleriGetir();

            if (urunler == null)
            {
                urunler = new List<Urun>();
            }
            return View(urunler);
        }

        [HttpGet]
        public async Task<IActionResult> FavoriyeEkle()
        {

        }
    }
}