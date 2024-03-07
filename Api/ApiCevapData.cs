using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipApp.Api
{
    public class ApiCevapData<T>
    {
        ApiCevap cevap;
        T data;
        public bool HataVarMi { get; private set; }
        public string HataMesaji { get; private set; }
        public ApiCevapData(ApiCevap cevap)
        {
            this.cevap = cevap;
            HataVarMi = !cevap.BasariliMi;
            HataMesaji = cevap.HataMesaji;

            if(cevap.BasariliMi)
                data = JsonConvert.DeserializeObject<T>(cevap.Data.ToString());
        }

        public T GetData()
        {
            return data;
        }


    }
}
