using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Address
    {
        public Guid Oid { get; set; }
        public Guid? DataSource { get; set; }
        public int CnctId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public Guid? State { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
        public string PhoneNumber { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }
        public DateTime? LoadDate { get; set; }
        public string City { get; set; }
    }
}
