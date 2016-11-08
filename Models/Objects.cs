using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Objects
    {
        public Objects()
        {
            ObjectDependenciesObjects = new HashSet<ObjectDependencies>();
            ObjectDependenciesObjectsNavigation = new HashSet<ObjectDependencies>();
        }

        public int RunKey { get; set; }
        public int ObjectKey { get; set; }
        public string ObjectName { get; set; }
        public string ObjectTypeString { get; set; }
        public string ObjectDesc { get; set; }

        public virtual ICollection<ObjectDependencies> ObjectDependenciesObjects { get; set; }
        public virtual ICollection<ObjectDependencies> ObjectDependenciesObjectsNavigation { get; set; }
        public virtual RunScan RunKeyNavigation { get; set; }
    }
}
