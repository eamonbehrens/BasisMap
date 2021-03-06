﻿using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Event
    {
        public Event()
        {
            ResourceResourcesEventEvents = new HashSet<ResourceResourcesEventEvents>();
        }

        public Guid Oid { get; set; }
        public string ResourceIds { get; set; }
        public Guid? RecurrencePattern { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime? StartOn { get; set; }
        public DateTime? EndOn { get; set; }
        public bool? AllDay { get; set; }
        public string Location { get; set; }
        public int? Label { get; set; }
        public int? Status { get; set; }
        public int? Type { get; set; }
        public string RecurrenceInfoXml { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<ResourceResourcesEventEvents> ResourceResourcesEventEvents { get; set; }
        public virtual Event RecurrencePatternNavigation { get; set; }
        public virtual ICollection<Event> InverseRecurrencePatternNavigation { get; set; }
    }
}
