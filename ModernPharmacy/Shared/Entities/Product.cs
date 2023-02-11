using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPharmacy.Shared.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int? DifferentProductId { get; set; }
        public DifferentProduct? DifferentProduct { get; set; }
        public int? DrugId { get; set; }
        public Drug? Drug { get; set; }
        public decimal? ProposedPrice { get; set; }
        public virtual List<ProductState> ProductStates { get; set; }
    }
}
