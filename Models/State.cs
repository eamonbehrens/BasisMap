﻿using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class State
    {
        public Guid Oid { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
