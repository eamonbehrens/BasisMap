﻿using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class PhoneType
    {
        public Guid Oid { get; set; }
        public string TypeName { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
