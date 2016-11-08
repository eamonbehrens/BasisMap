using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class PermissionData
    {
        public Guid Oid { get; set; }
        public Guid? PermissionsContainer { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? ObjectType { get; set; }
        public string TargetType { get; set; }
        public bool? AllowRead { get; set; }
        public bool? AllowWrite { get; set; }
        public bool? AllowCreate { get; set; }
        public bool? AllowDelete { get; set; }
        public bool? AllowNavigate { get; set; }
        public string Members { get; set; }
        public string Criteria { get; set; }
        public bool? CanEditModel { get; set; }

        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual PermissionsContainer PermissionsContainerNavigation { get; set; }
    }
}
