using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class ObjectDependencies
    {
        public int RunKey { get; set; }
        public int SrcObjectKey { get; set; }
        public int TgtObjectKey { get; set; }
        public string DependencyType { get; set; }

        public virtual Objects Objects { get; set; }
        public virtual Objects ObjectsNavigation { get; set; }
    }
}
