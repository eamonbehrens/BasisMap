using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class StateRegion
    {
        public StateRegion()
        {
            Contract = new HashSet<Contract>();
            DeliverySchedule1 = new HashSet<DeliverySchedule1>();
            MarketSituation = new HashSet<MarketSituation>();
            TicketCrossStockStorageStateRegionNavigation = new HashSet<Ticket>();
            TicketStockStorageStateRegionNavigation = new HashSet<Ticket>();
        }

        public Guid Oid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? DataSource { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string RegionType { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }

        public virtual ICollection<Contract> Contract { get; set; }
        public virtual ICollection<DeliverySchedule1> DeliverySchedule1 { get; set; }
        public virtual ICollection<MarketSituation> MarketSituation { get; set; }
        public virtual ICollection<Ticket> TicketCrossStockStorageStateRegionNavigation { get; set; }
        public virtual ICollection<Ticket> TicketStockStorageStateRegionNavigation { get; set; }
        public virtual DataSourceSystemGroup DataSourceSystemGroupNavigation { get; set; }
    }
}
