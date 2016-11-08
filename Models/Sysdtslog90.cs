using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Sysdtslog90
    {
        public int Id { get; set; }
        public string Event { get; set; }
        public string Computer { get; set; }
        public string Operator { get; set; }
        public string Source { get; set; }
        public Guid Sourceid { get; set; }
        public Guid Executionid { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime Endtime { get; set; }
        public int Datacode { get; set; }
        public byte[] Databytes { get; set; }
        public string Message { get; set; }
    }
}
