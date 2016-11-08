using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class DataSource
    {
        public DataSource()
        {
            BoardOfTrade1 = new HashSet<BoardOfTrade1>();
            ChartOfAccount = new HashSet<ChartOfAccount>();
            Commodity = new HashSet<Commodity>();
            ContractType1 = new HashSet<ContractType1>();
            DataSet = new HashSet<DataSet>();
            DiscountCode = new HashSet<DiscountCode>();
            Locale = new HashSet<Locale>();
            Location = new HashSet<Location>();
            MarketZone = new HashSet<MarketZone>();
            NameAddress = new HashSet<NameAddress>();
            NameAddress1 = new HashSet<NameAddress1>();
            Office = new HashSet<Office>();
            RawPriceLocale = new HashSet<RawPriceLocale>();
            TransportationMode1 = new HashSet<TransportationMode1>();
        }

        public Guid Oid { get; set; }
        public Guid? DataSourceType { get; set; }
        public Guid? DataSourceSystem { get; set; }
        public string Name { get; set; }
        public string Dsnname { get; set; }
        public DateTime? EndingRange1 { get; set; }
        public DateTime? EndingRange2 { get; set; }
        public DateTime? EndingRange5 { get; set; }
        public DateTime? StartingRange1 { get; set; }
        public DateTime? StartingRange2 { get; set; }
        public DateTime? StartingRange5 { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsReadyToLoad { get; set; }
        public bool? IsReadyToExtract { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string Code { get; set; }
        public Guid? DataSourceState { get; set; }
        public Guid? CurrentDataSource { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsReady { get; set; }
        public string DatabaseName { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }
        public bool? UseDbcPackage { get; set; }
        public string DefaultDbcSchema { get; set; }
        public string DbcServer { get; set; }
        public string DbcDatabase { get; set; }

        public virtual ICollection<BoardOfTrade1> BoardOfTrade1 { get; set; }
        public virtual ICollection<ChartOfAccount> ChartOfAccount { get; set; }
        public virtual ICollection<Commodity> Commodity { get; set; }
        public virtual ICollection<ContractType1> ContractType1 { get; set; }
        public virtual ICollection<DataSet> DataSet { get; set; }
        public virtual ICollection<DiscountCode> DiscountCode { get; set; }
        public virtual ICollection<Locale> Locale { get; set; }
        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<MarketZone> MarketZone { get; set; }
        public virtual ICollection<NameAddress> NameAddress { get; set; }
        public virtual ICollection<NameAddress1> NameAddress1 { get; set; }
        public virtual ICollection<Office> Office { get; set; }
        public virtual ICollection<RawPriceLocale> RawPriceLocale { get; set; }
        public virtual ICollection<TransportationMode1> TransportationMode1 { get; set; }
        public virtual DataSource CurrentDataSourceNavigation { get; set; }
        public virtual ICollection<DataSource> InverseCurrentDataSourceNavigation { get; set; }
        public virtual DataSourceState DataSourceStateNavigation { get; set; }
        public virtual DataSourceSystem DataSourceSystemNavigation { get; set; }
        public virtual DataSourceSystemGroup DataSourceSystemGroupNavigation { get; set; }
        public virtual DataSourceType DataSourceTypeNavigation { get; set; }
    }
}
