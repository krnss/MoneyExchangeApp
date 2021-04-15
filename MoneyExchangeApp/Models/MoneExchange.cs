using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchangeApp.Models
{
    public class MoneExchange
    {
        public int Id { get; set; }
        public Currency FromCurrency { get; set; }
        public decimal FromAmount{ get; set; }
        public Currency ToCurrency { get; set; }
        public decimal ToAmount { get; set; }
        public DateTime Date{ get; set; }

    }

    public enum Currency
    {
        USD, EUR, GBP, CHF
    }
}
