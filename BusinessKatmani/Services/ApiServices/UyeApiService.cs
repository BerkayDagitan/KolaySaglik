using BusinessKatmani.Interfaces;
using EntityKatmani.DTOs;
using EntityKatmani.Entitys;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace BusinessKatmani.Services.ApiServices
{
    public class UyeApiService : IUyeApiService
    {
        private readonly HttpClient _httpClient;

        public UyeApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Uye>> TumUyeleriGetir()
        {
            var result = await _httpClient.GetAsync("uyelistele");
            if (result.IsSuccessStatusCode == false) return null;
            var resultString = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Uye>>(resultString);
        }

        public async Task<KullaniciGirisDTO> KullaniciGirisYap(string kullaniciadi, string sifre)
        {
            var girisBilgileri = new
            {
                KullaniciAdi = kullaniciadi,
                Sifre = sifre
            };

            var result = await _httpClient.PostAsJsonAsync("Uye/girisyap", girisBilgileri);

            if (result.IsSuccessStatusCode)
            {
                var resultString = await result.Content.ReadAsStringAsync();

                if (!string.IsNullOrEmpty(resultString))
                {
                    var user = JsonConvert.DeserializeObject<KullaniciGirisDTO>(resultString);

                    if (user != null && user.KullaniciAdi == kullaniciadi && user.Sifre == sifre)
                    {
                        return user;
                    }
                }
            }
            return null;
        }

        public async Task<bool> UyeOlusturma(UyeOlusturmaDTO dto)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(dto));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = await _httpClient.PostAsync("Uye/uyeolustur", content);

            if (result.IsSuccessStatusCode is true)
                return result.Content.ReadAsStringAsync().Result == "Üye başarıyla eklendi." ? true : false;
            return false;
        }
    }
}
