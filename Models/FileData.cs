﻿using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class FileData
    {
        public Guid Oid { get; set; }
        public int? Size { get; set; }
        public string FileName { get; set; }
        public byte[] Content { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
