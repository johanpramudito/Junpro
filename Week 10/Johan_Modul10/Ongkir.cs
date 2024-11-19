using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johan_Modul10
{
    internal class Ongkir
    {
        public static List<string> GetKotaList()
        {
            List<string> returnlist = new List<string>();
            var client = new RestClient("https://api.rajaongkir.com/starter/city");
            var request = new RestRequest(Method.GET);
            request.AddHeader("key", "c31a7ac4eaed9d6d966f5af4cf2aa4b9");
            IRestResponse
        }
    }
}
