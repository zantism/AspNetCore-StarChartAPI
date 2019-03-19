﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarChart.Models
{
    public class CelestialObject
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int? OrbitedObject { get; set; }
        [NotMapped]
        public List<CelestialObject> Satellites { get; set;  }
        public TimeSpan OrbitalPeriod { get; set; }
    }
}
