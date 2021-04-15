using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchangeApp.Models
{
    public class Esr
    {
        public bool Success { get; set; }
        public double Timestamp { get; set; }
        public string Base { get; set; }
        public string Date { get; set; }
        public CurencyCost Rates { get; set; }        

    }
}
