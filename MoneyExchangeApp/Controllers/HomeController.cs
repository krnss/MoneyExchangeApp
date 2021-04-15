using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MoneyExchangeApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MoneyExchangeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString("http://api.exchangeratesapi.io/v1/latest?access_key=4b431d27e0def1d02bd789d2fbf45669&symbols=USD,GBP,CHF&format=1");
            var cost = JsonConvert.DeserializeObject<Esr>(json);

            return View(cost);
        }

        public string GetAmount(string fromCurency,string toCurency,string fromAmount)
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString("http://api.exchangeratesapi.io/v1/latest?access_key=4b431d27e0def1d02bd789d2fbf45669&symbols=USD,GBP,CHF&format=1");
            var cost = JsonConvert.DeserializeObject<Esr>(json);

            decimal toAmount=0;

            decimal k1 = cost.Rates.GetCost(fromCurency);
            decimal k2 = cost.Rates.GetCost(toCurency);

            toAmount = Convert.ToDecimal(fromAmount.Replace('.',',')) *( (1/k1)*k2);           

            return toAmount.ToString();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
