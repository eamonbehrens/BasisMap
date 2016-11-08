using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class OptionType
    {
        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid? DataSet { get; set; }

        public virtual DataSet DataSetNavigation { get; set; }
    }
}
