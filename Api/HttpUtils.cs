using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipApp.Api
{
    public static class HttpUtils
    {
        static string baseUrl = "https://stoktakip.kurall.com/api/v1/";
        static string _token;
        public static void SetToken(string token)
        {
            _token = token;
        }
        public async static Task<HttpResponseMessage> GetAsync(string method)
        {
            string url = baseUrl + method;
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };

            var client = new HttpClient(httpClientHandler);

            if(!string.IsNullOrEmpty(_token))
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _token);

            var resp = await client.GetAsync(url);

            return resp;
        }

        public async static Task<HttpResponseMessage> PostAsync(string method, string parameters=null)
        {
            string url = baseUrl + method;
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };

            var client = new HttpClient(httpClientHandler);

            if (!string.IsNullOrEmpty(_token))
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _token);

            string contentStr = null;

            if (!string.IsNullOrEmpty(parameters))
            {
                var p = JsonConvert.DeserializeObject<Dictionary<string, string>>(parameters);

                var content = new FormUrlEncodedContent(p);
                contentStr = await content.ReadAsStringAsync();
            }
            
            //kullaniciAdi=admin&parola=1234
            

            HttpResponseMessage resp = await client.PostAsync(url + "?" + contentStr, null);
            return resp;
        }
    }
}
