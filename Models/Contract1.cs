﻿using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class Contract1
    {
        public Guid Oid { get; set; }
        public int ContractNbr { get; set; }
        public int ContractId { get; set; }
        public string PlcId { get; set; }
        public string ContractTypeCode { get; set; }
        public string ContractType1 { get; set; }
        public string PricingTypeCode { get; set; }
        public DateTime? ContractDate { get; set; }
        public Guid? Commodity { get; set; }
        public string CommodityId { get; set; }
        public string PricingStatus { get; set; }
        public Guid? ContractType { get; set; }
        public string PricingStatusCode { get; set; }
        public string ContractStatus { get; set; }
        public string ActivityStatusCode { get; set; }
        public string TraderId { get; set; }
        public Guid? NameAddress { get; set; }
        public string VendorCustomerId { get; set; }
        public string ContractReference { get; set; }
        public double? Quantity { get; set; }
        public string QuantityUom { get; set; }
        public decimal? PriceFuture { get; set; }
        public decimal? PriceBasis { get; set; }
        public decimal? ReleasePriceBasis { get; set; }
        public decimal? Price { get; set; }
        public string MarketMonth { get; set; }
        public Guid? MarketZone { get; set; }
        public string IvPricingPointCode { get; set; }
        public Guid? TransportationMode { get; set; }
        public string ShipModeCode { get; set; }
        public string ScheduleCode { get; set; }
        public string Remarks { get; set; }
        public string HoldFlag { get; set; }
        public string ExpediteFlag { get; set; }
        public string ConfirmPricingFlag { get; set; }
        public string WeightGovernNbr { get; set; }
        public string GradeGovernNbr { get; set; }
        public string ProteinGovernNbr { get; set; }
        public string GlAcctNbr { get; set; }
        public int? CommodityNoteCode { get; set; }
        public string AddBy { get; set; }
        public DateTime AddDate { get; set; }
        public string ChangeBy { get; set; }
        public DateTime ChangeDate { get; set; }
        public decimal? NumberOfLoads { get; set; }
        public string DeliveryVehicleCode { get; set; }
        public DateTime? SchedShipStartDate { get; set; }
        public DateTime? SchedShipEndDate { get; set; }
        public string ShipmentNote { get; set; }
        public Guid? ShipToNameAddress { get; set; }
        public string ShipToId { get; set; }
        public double? MarketZoneFrtAdj { get; set; }
        public string FobPoint { get; set; }
        public string SpecOrgFlag { get; set; }
        public string AdditionalNote { get; set; }
        public string TradeRuleNbr { get; set; }
        public string ContractSchedule { get; set; }
        public string BrokerId { get; set; }
        public decimal? BrokerRate { get; set; }
        public string BrokerUomCode { get; set; }
        public string BrokerCurrencyCode { get; set; }
        public string SignedFlag { get; set; }
        public string PrintedFlag { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? InitialPrice { get; set; }
        public short? ContractFormatNbr { get; set; }
        public string Grade { get; set; }
        public string BillToId { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public int? ProteinTableNbr { get; set; }
        public DateTime? ProteinDate { get; set; }
        public string ScheduleType { get; set; }
        public string ProteinType { get; set; }
        public string SettleSurplusFlag { get; set; }
        public double? ToleranceQuantity { get; set; }
        public string WeightGovernStatus { get; set; }
        public string GradeGovernStatus { get; set; }
        public string ManualCloseFlag { get; set; }
        public string WorkbackFlag { get; set; }
        public string AlternateShipModeCode { get; set; }
        public string LoadBasedFlag { get; set; }
        public string TermCode { get; set; }
        public string ContractFormatCode { get; set; }
        public decimal BuyExchangeRate { get; set; }
        public decimal SellExchangeRate { get; set; }
        public decimal OtherExchangeRate { get; set; }
        public string Storage { get; set; }
        public string CrcData { get; set; }
        public decimal? AltBasisPrice { get; set; }
        public decimal? AltFuturesPrice { get; set; }
        public decimal? AltPrice { get; set; }
        public double QtyPriceConvFactor { get; set; }
        public string AltPriceUom { get; set; }
        public decimal? AltSalesCarry { get; set; }
        public decimal? SalesCarry { get; set; }
        public short? SalesCarryMonth { get; set; }
        public string BrokerContract { get; set; }
        public string BrokerPaidByStatus { get; set; }
        public string BrokerContactId { get; set; }
        public decimal? FarmGateDeduction { get; set; }
        public DateTime? DpFromDate { get; set; }
        public DateTime? DpToDate { get; set; }
        public string SalesCarryString { get; set; }
        public string SettlementRelationship { get; set; }
        public string PickupFlag { get; set; }
        public string RolledFlag { get; set; }
        public string DpPrintedFlag { get; set; }
        public string PaidTicketFlag { get; set; }
        public string SettlementEligibleFlag { get; set; }
        public string AdditionalContractDesc { get; set; }
        public decimal? DeductionAdditionAmount { get; set; }
        public string VcContactId { get; set; }
        public string ProductDiscPremDateStatus { get; set; }
        public DateTime? ProductDiscPremDate { get; set; }
        public DateTime? LastPrintDate { get; set; }
        public decimal AltUnitValue { get; set; }
        public decimal UnitValue { get; set; }
        public string CrossApplicationFlag { get; set; }
        public string AreaUomCode { get; set; }
        public decimal? AreaUnitNbr { get; set; }
        public int? TaxScheduleId { get; set; }
        public string BotUom { get; set; }
        public int PsNbr { get; set; }
        public int? OriginalContractNbr { get; set; }
        public int? MirrorContractNbr { get; set; }
        public string RpaFlag { get; set; }
        public string RpaStatus { get; set; }
        public int? BackToBackContractNbr { get; set; }
        public string OdDescription { get; set; }
        public string HoldAdvanceSettlementFlag { get; set; }
        public int? MiscColumnItemNbr1 { get; set; }
        public int? MiscColumnItemNbr2 { get; set; }
        public int? MiscColumnItemNbr3 { get; set; }
        public int? MiscColumnItemNbr4 { get; set; }
        public int? MiscColumnItemNbr5 { get; set; }
        public int? MiscColumnItemNbr6 { get; set; }
        public string PrintFuturesFlag { get; set; }
        public decimal? SpeciesSerialNbr { get; set; }
        public int SpeciesCount { get; set; }
        public Guid? Location { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }
    }
}
