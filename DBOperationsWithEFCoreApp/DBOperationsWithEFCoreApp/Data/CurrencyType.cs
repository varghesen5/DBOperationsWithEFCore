using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBOperationsWithEFCoreApp.Data
{
    public class CurrencyType
    {
        public int Id { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }


        public ICollection<BookPrice> BookPrice { get; set; }
    }
}
