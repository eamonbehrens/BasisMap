using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class BoardOfTrade
    {
        public Guid Oid { get; set; }
        public Guid? DataSource { get; set; }
        public int? RphdrId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid? ParentBoardOfTrade { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
