using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class BuildBasis
    {
        public Guid Oid { get; set; }
        public Guid? MarketSituation { get; set; }
        public decimal? Basis { get; set; }
        public Guid? DataSet { get; set; }
        public Guid? PriorBuildBasis { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? TargetOptionMonth { get; set; }
        public DateTime? TargetDeliveryDate { get; set; }
        public Guid? TargetMarketSituation { get; set; }

        public virtual DataSet DataSetNavigation { get; set; }
        public virtual MarketSituation MarketSituationNavigation { get; set; }
        public virtual BuildBasis PriorBuildBasisNavigation { get; set; }
        public virtual ICollection<BuildBasis> InversePriorBuildBasisNavigation { get; set; }
    }
}
