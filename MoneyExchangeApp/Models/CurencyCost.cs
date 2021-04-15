using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchangeApp.Models
{
    public class CurencyCost
    {
        public decimal EUR { get; set; } = 1;
        public decimal USD { get; set; }
        public decimal GBP { get; set; }
        public decimal CHF { get; set; }

        public override string ToString()
        {
            return $"EUR:{EUR}#USD:{USD}#GBP:{GBP}#CHF:{CHF}";
        }
        public decimal GetCost(string name)
        {
            switch (name)
            {
                case "USD":
                    return USD;
                case "GBP":
                    return GBP;
                case "CHF":
                    return CHF;
                case "EUR":
                    return EUR;
            }
            return 1;
        }
    }
}
