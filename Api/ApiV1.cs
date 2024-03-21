using Newtonsoft.Json;
using StokTakipApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipApp.Api
{
    public static class ApiV1
    {
        public static async Task<string> Test()
        {
            HttpResponseMessage resp = await HttpUtils.GetAsync("Test");
            return await resp.Content.ReadAsStringAsync();
        }

        public static async Task<ApiCevap> Login(string kullaniciAdi, string parola)
        {
            //string s = "{\"kullaniciAdi\":\""+kullaniciAdi+"\",\"parola\":\""+parola+"\"}";
            //string f = string.Format("{\"kullaniciAdi\":\"{0}\",\"parola\":\"{1}\"}",kullaniciAdi,parola);


            HttpResponseMessage resp = await HttpUtils.PostAsync("Login", $"{{'kullaniciAdi':'{kullaniciAdi}','parola':'{parola}'}}");
            string content = await resp.Content.ReadAsStringAsync();

            ApiCevap cevap = JsonConvert.DeserializeObject<ApiCevap>(content);
            return cevap;
        }

        public static async Task<ApiCevapData<List<Kullanici>>> KullanicilariGetir()
        {
            HttpResponseMessage resp = await HttpUtils.GetAsync("KullanicilariGetir");
            string content = await resp.Content.ReadAsStringAsync();

            ApiCevap cevap = JsonConvert.DeserializeObject<ApiCevap>(content);

            return new ApiCevapData<List<Kullanici>>(cevap);

        }
        public static async Task<ApiCevapData<List<Kategori>>> KategorileriGetir()
        {
            HttpResponseMessage resp = await HttpUtils.GetAsync("KategorileriGetir");
            string content = await resp.Content.ReadAsStringAsync();

            ApiCevap cevap = JsonConvert.DeserializeObject<ApiCevap>(content);

            return new ApiCevapData<List<Kategori>>(cevap);

        }
        public static async Task<ApiCevapData<Kategori>> KategoriEkle(string kategoriAd)
        {
            HttpResponseMessage resp = await HttpUtils.PostAsync("KategoriEkle",$"{{'kategoriAdi':'{kategoriAd}'}}");
            string content = await resp.Content.ReadAsStringAsync();

            ApiCevap cevap = JsonConvert.DeserializeObject<ApiCevap>(content);

            return new ApiCevapData<Kategori>(cevap);

        }
        public static async Task<ApiCevapData<object?>> KategoriSil(int kategoriId)
        {
            HttpResponseMessage resp = await HttpUtils.PostAsync("KategoriSil", $"{{'kategoriId':'{kategoriId}'}}");
            string content = await resp.Content.ReadAsStringAsync();

            ApiCevap cevap = JsonConvert.DeserializeObject<ApiCevap>(content);

            return new ApiCevapData<object?>(cevap);

        }

        public static async Task<ApiCevapData<List<Urun>>> UrunleriGetir()
        {
            HttpResponseMessage resp = await HttpUtils.GetAsync("UrunleriGetir");
            string content = await resp.Content.ReadAsStringAsync();

            ApiCevap cevap = JsonConvert.DeserializeObject<ApiCevap>(content);

            return new ApiCevapData<List<Urun>>(cevap);

        }
    }
}
