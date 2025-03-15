using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBOperationsWithEFCoreApp.Data
{
    public class BookPrice
    {
        public int id { get; set; }
        public int BookId { get; set; }
        public int Amount { get; set; }
        public int CurrencyId { get; set; }
        public CurrencyType CurrencyType { get; set; }


    }
}
