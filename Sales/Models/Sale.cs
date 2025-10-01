using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    internal class Sale
    {
        public int? SaleId { get; set; }
        public DateTime Date { get; set; }
        public string? Product { get; set; }
        public string ProductId { get; set; }
        public Product? products { get; set; }   
       



        public string? CustomerId { get; set; }
        public Customer? Customer { get; set; }


        public string? storeId { get; set; }
        public Store Stores { get; set; }


    }
}
