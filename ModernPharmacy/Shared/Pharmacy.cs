using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPharmacy.Shared
{
    public class Pharmacy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasPrescriptionDrugs { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}
