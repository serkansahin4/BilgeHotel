using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BilgeHotel.WebUI.APIHelper
{
    public class BankAPI
    {
        public HttpClient Inıtıal()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44319/");
            return client;
        }
    }
}
