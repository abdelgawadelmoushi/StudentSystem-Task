using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    internal class Customer
    {
        public int? CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int? CreaditCardNumber { get; set; }
        public decimal Sales { get; set; }
        public List<Sale> sales { get; set; }

    }
}
