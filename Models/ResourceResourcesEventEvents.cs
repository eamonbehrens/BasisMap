﻿using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class ResourceResourcesEventEvents
    {
        public Guid? Events { get; set; }
        public Guid? Resources { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual Event EventsNavigation { get; set; }
        public virtual Resource ResourcesNavigation { get; set; }
    }
}
