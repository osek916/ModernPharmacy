using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPharmacy.Shared.Entities
{
    public class ProductState
    {
        public int Id { get; set; }
        public int PharmacyId { get; set; }
        public Pharmacy Pharmacy { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int AmountOfProducts { get; set; }
        public int PriceForOne { get; set; }

    }
}
