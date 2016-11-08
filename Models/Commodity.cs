using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BasisMap.Models
{
    public partial class Commodity
    {
        //public Commodity(string _Code)
        //{
        //    Code = _Code;
        //}
        public Commodity()
        {
          
        }
        //      public IEnumerable<Commodity> Commodities { get; set; }
        //public IEnumerable<string> CommodityCodes { get; set; }
        //public IEnumerable<SelectListItem> CommodityCodes { get; set; }
        public SelectList CommodityCodes { get; set; }


        // public IEnumerable<SelectListItem> Commodities { get; set; }
        //public SelectList Commodities = new SelectList();
        //public List<Commodity> Commodities = new List<Commodity>();

        [Key]
        [Required]
        public Guid Oid { get; set; } = Guid.NewGuid();
        public string Code { get; set; }
        public Guid? DataSource { get; set; }
        public string Description { get; set; }
        public string FuturesMonths { get; set; }
        public string Status { get; set; }
        public decimal? PoundsPerBushel { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }

        //public virtual ICollection<CommodityBoardOfTrade> CommodityBoardOfTrade { get; set; }
        //public virtual ICollection<LocationCommodity> LocationCommodity { get; set; }
        //public virtual ICollection<MarketSituation> MarketSituation { get; set; }
        //public virtual ICollection<Ticket> Ticket { get; set; }
        //public virtual DataSource DataSourceNavigation { get; set; }
    }
}
