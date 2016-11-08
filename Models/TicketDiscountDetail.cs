using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class TicketDiscountDetail
    {
        public Guid Oid { get; set; }
        public Guid? Ticket { get; set; }
        public Guid? TicketApplication { get; set; }
        public string DiscountCode { get; set; }
        public double? CalculationRate { get; set; }
        public string CalculationType { get; set; }
        public double? CustomerNetUnits { get; set; }
        public double? GrossUnits { get; set; }
        public double? SchedulePrice { get; set; }
        public double? Discount { get; set; }
        public bool? IsFreightCode { get; set; }
        public double? Fdisc { get; set; }
        public double? Ddisc { get; set; }
        public Guid? DataSet { get; set; }

        public virtual DataSet DataSetNavigation { get; set; }
        public virtual Ticket TicketNavigation { get; set; }
        public virtual TicketApplication TicketApplicationNavigation { get; set; }
    }
}
