using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class RunScan
    {
        public RunScan()
        {
            Objects = new HashSet<Objects>();
        }

        public int RunKey { get; set; }
        public DateTime RunDate { get; set; }
        public string RunCommand { get; set; }

        public virtual ICollection<Objects> Objects { get; set; }
    }
}
