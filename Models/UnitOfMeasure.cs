using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class UnitOfMeasure
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string MeasureType { get; set; }
        public decimal? PoundsPerUnit { get; set; }
        public decimal? BushelsPerUnit { get; set; }
        public string Notes { get; set; }
    }
}
