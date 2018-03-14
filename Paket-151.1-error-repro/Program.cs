using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Paket_151._1_error_repro
{
    class Program
    {
        static void Main(string[] args)
        {
            var http = new HttpClient();
            var resp = http.GetAsync("https://google.com").Result;
        }
    }
}
