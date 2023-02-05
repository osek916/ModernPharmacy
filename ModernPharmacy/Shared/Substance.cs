﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPharmacy.Shared
{
    public class Substance
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public virtual List<Drug> Drugs { get; set; } = new List<Drug>();
        public virtual List<Substance> Substances { get; set; } = new List<Substance>();
    }
}