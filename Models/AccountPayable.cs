using System;
using System.Collections.Generic;

namespace BasisMap.Models
{
    public partial class AccountPayable
    {
        public int InvoiceNbr { get; set; }
        public string LocationId { get; set; }
        public Guid? Location { get; set; }
        public string CustomerVendorId { get; set; }
        public Guid? NameAddress { get; set; }
        public string FinancialSource { get; set; }
        public string JournalSourceCode { get; set; }
        public string InvoiceId { get; set; }
        public string TermCode { get; set; }
        public string Description { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int? JournalNbr { get; set; }
        public string CheckListId { get; set; }
        public string InvoiceStatus { get; set; }
        public DateTime? DiscountDate { get; set; }
        public DateTime DueDate { get; set; }
        public string BankId { get; set; }
        public decimal BalanceAmount { get; set; }
        public decimal OriginalAmount { get; set; }
        public int? TransactionNbr { get; set; }
        public int ReversedTransactionNbr { get; set; }
        public decimal? GlExchangeRate { get; set; }
        public decimal? PlcExchangeRate { get; set; }
        public decimal? CustVendExchangeRate { get; set; }
        public string PrintFlag { get; set; }
        public decimal? ContraAmount { get; set; }
        public string BalanceForwardPrintFlag { get; set; }
        public string ReferenceId { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? QuickCheckNbr { get; set; }
        public DateTime? QuickCheckDate { get; set; }
        public DateTime? GlDate { get; set; }
        public int? ReversedJournalNbr { get; set; }
        public decimal DiscountTakenAmount { get; set; }
        public decimal? CheckListDiscount { get; set; }
        public DateTime? InterestCalculationDate { get; set; }
        public int? InterestGraceDays { get; set; }
        public decimal? InterestGraceAmount { get; set; }
        public decimal? InterestPercent { get; set; }
        public string InterestIoiFlag { get; set; }
        public string ControlAcctNbr { get; set; }
        public string PaymentMethodCode { get; set; }
        public string RowSource { get; set; }
        public int? RowSourceNbr { get; set; }
        public decimal? QuickCheckAmount { get; set; }
        public string NgcId { get; set; }
        public string AddBy { get; set; }
        public DateTime AddDate { get; set; }
        public string ChangeBy { get; set; }
        public DateTime ChangeDate { get; set; }
        public decimal? CheckListPayAmount { get; set; }
        public DateTime LastTransactionDate { get; set; }
        public int? QcJournalNbr { get; set; }
        public string HoldPaymentFlag { get; set; }
        public string TraderId { get; set; }
        public string Tax1Code { get; set; }
        public short? Tax1Nbr { get; set; }
        public string Tax2Flag { get; set; }
        public string Tax3Flag { get; set; }
        public string DpInterestFlag { get; set; }
        public string PaymentEligibleFlag { get; set; }
        public int? InterestInvoiceNbr { get; set; }
        public DateTime? CommodityLoanInterestDate { get; set; }
        public int? CommodityLoanInvoiceNbr { get; set; }
        public string InterestCalculationType { get; set; }
        public Guid? DataSourceSystemGroup { get; set; }
        public Guid? DataSource { get; set; }
    }
}
