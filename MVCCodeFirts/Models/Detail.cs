using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirts.Models
{
    public class Detail
    {
        public int DetailID { get; set; }
        public int Price { get; set; }

        public int Amount { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int InvoiceID { get; set; }
        public Invoice Invoice { get; set; }
    }
}