using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class XpobjectType
    {
        public XpobjectType()
        {
            Party = new HashSet<Party>();
            PermissionData = new HashSet<PermissionData>();
            PermissionsContainer = new HashSet<PermissionsContainer>();
            RoleBase = new HashSet<RoleBase>();
            SecurityUserBase = new HashSet<SecurityUserBase>();
            XpweakReferenceObjectTypeNavigation = new HashSet<XpweakReference>();
            XpweakReferenceTargetTypeNavigation = new HashSet<XpweakReference>();
        }

        public int Oid { get; set; }
        public string TypeName { get; set; }
        public string AssemblyName { get; set; }

        public virtual ICollection<Party> Party { get; set; }
        public virtual ICollection<PermissionData> PermissionData { get; set; }
        public virtual ICollection<PermissionsContainer> PermissionsContainer { get; set; }
        public virtual ICollection<RoleBase> RoleBase { get; set; }
        public virtual ICollection<SecurityUserBase> SecurityUserBase { get; set; }
        public virtual ICollection<XpweakReference> XpweakReferenceObjectTypeNavigation { get; set; }
        public virtual ICollection<XpweakReference> XpweakReferenceTargetTypeNavigation { get; set; }
    }
}
