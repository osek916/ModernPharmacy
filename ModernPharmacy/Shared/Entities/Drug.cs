﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPharmacy.Shared.Entities
{
    public class Drug
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public virtual List<Substance> Substances { get; set; }
        public int? NumberOfTablets { get; set; }
        public int? MilligramsPerTablets { get; set; }
        public int? MilligramsForTheWholeDrug { get; set; }
        public bool LumpSumDrug { get; set; } = true;
        public bool PrescriptionRequired { get; set; } = true;
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
