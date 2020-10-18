using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class ReportStockModel
    {
        public List<ApplicationUser> Users { get; set; }
        public List<Product> Products { get; set; }

        public List<Stock> Stocks { get; set; }
    }
}