using BusinessKatmani.Interfaces;
using EntityKatmani.DTOs;
using EntityKatmani.Entitys;
using Newtonsoft.Json;

namespace BusinessKatmani.Services.ApiServices
{
    public class UrunApiService : IUrunApiService
    {
        private readonly HttpClient _httpClient;

        public UrunApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Urun>> TumUrunleriGetir()
        {
            var result = await _httpClient.GetAsync("urun/urunGetir");
            if (result.IsSuccessStatusCode == false) return null;
            var resultString = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Urun>>(resultString);
        }

        public async Task<bool> UrunOlustur(UrunOlusturDTO dto)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(dto));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = await _httpClient.PostAsync("urun/urunEkle", content);

            if (result.IsSuccessStatusCode is true)
                return result.Content.ReadAsStringAsync().Result == "Ürün başarıyla eklendi." ? true : false;
            return false;
        }
    }
}