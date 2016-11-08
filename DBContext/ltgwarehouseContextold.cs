//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//using Lansing.BasisMap.Models;
//using BasisMap.ViewModels;

//namespace Lansing.BasisMap.DBContext
//{
//    public class ltgwarehouseContext : DbContext
//    {
//        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        //        {
//        //            try
//        //            {
//        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//        //                //  optionsBuilder.UseSqlServer("Server=.;Database=ltgwarehouse;Trusted_Connection=True;");
//        //                optionsBuilder.UseSqlServer("Server = .; Intial Catalog = ltgwarehouse; Integrated Security = True;");
//        //            }
//        //            catch { }

//        //        }
//        public DbSet<CommodityViewModel> CommoditiesDropDown { get; set; }
//        public DbSet<Commodity> Commodities { get; set; }
//        public ltgwarehouseContext(DbContextOptions<ltgwarehouseContext> options)
//        : base(options)
//        {

//        }




//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);
//            //modelBuilder.Entity<AccountPayable>(entity =>
//            //{
//            //    entity.HasKey(e => new { e.InvoiceNbr, e.LocationId })
//            //        .HasName("PK_AccountPayable_2");

//            //    entity.ToTable("AccountPayable", "SmartSoft");

//            //    entity.HasIndex(e => new { e.InvoiceNbr, e.LocationId, e.DataSource })
//            //        .HasName("ix_69_68");

//            //    entity.HasIndex(e => new { e.InvoiceNbr, e.LocationId, e.DataSourceSystemGroup })
//            //        .HasName("ix_44_43");

//            //    entity.HasIndex(e => new { e.Location, e.NameAddress, e.JournalSourceCode, e.InvoiceId, e.InvoiceDate, e.InvoiceStatus, e.DueDate, e.BalanceAmount, e.OriginalAmount, e.DataSource, e.DataSourceSystemGroup })
//            //        .HasName("ix_73_72");

//            //    entity.Property(e => e.InvoiceNbr).HasColumnName("invoice_nbr");

//            //    entity.Property(e => e.LocationId)
//            //        .HasColumnName("location_id")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.AddBy)
//            //        .IsRequired()
//            //        .HasColumnName("add_by")
//            //        .HasColumnType("varchar(40)");

//            //    entity.Property(e => e.AddDate)
//            //        .HasColumnName("add_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.BalanceAmount)
//            //        .HasColumnName("balance_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.BalanceForwardPrintFlag)
//            //        .IsRequired()
//            //        .HasColumnName("balance_forward_print_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.BankId)
//            //        .HasColumnName("bank_id")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.ChangeBy)
//            //        .IsRequired()
//            //        .HasColumnName("change_by")
//            //        .HasColumnType("varchar(40)");

//            //    entity.Property(e => e.ChangeDate)
//            //        .HasColumnName("change_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.CheckListDiscount)
//            //        .HasColumnName("check_list_discount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.CheckListId)
//            //        .HasColumnName("check_list_id")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.CheckListPayAmount)
//            //        .HasColumnName("check_list_pay_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.CommodityLoanInterestDate)
//            //        .HasColumnName("commodity_loan_interest_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.CommodityLoanInvoiceNbr).HasColumnName("commodity_loan_invoice_nbr");

//            //    entity.Property(e => e.ContraAmount)
//            //        .HasColumnName("contra_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.ControlAcctNbr)
//            //        .IsRequired()
//            //        .HasColumnName("control_acct_nbr")
//            //        .HasColumnType("varchar(75)");

//            //    entity.Property(e => e.CurrencyCode)
//            //        .IsRequired()
//            //        .HasColumnName("currency_code")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.CustVendExchangeRate)
//            //        .HasColumnName("cust_vend_exchange_rate")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.CustomerVendorId)
//            //        .IsRequired()
//            //        .HasColumnName("customer_vendor_id")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.Description)
//            //        .HasColumnName("description")
//            //        .HasColumnType("varchar(50)");

//            //    entity.Property(e => e.DiscountAmount)
//            //        .HasColumnName("discount_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.DiscountDate)
//            //        .HasColumnName("discount_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.DiscountPercent)
//            //        .HasColumnName("discount_percent")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.DiscountTakenAmount)
//            //        .HasColumnName("discount_taken_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.DpInterestFlag)
//            //        .IsRequired()
//            //        .HasColumnName("dp_interest_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.DueDate)
//            //        .HasColumnName("due_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.FinancialSource)
//            //        .IsRequired()
//            //        .HasColumnName("financial_source")
//            //        .HasColumnType("varchar(3)");

//            //    entity.Property(e => e.GlDate)
//            //        .HasColumnName("gl_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.GlExchangeRate)
//            //        .HasColumnName("gl_exchange_rate")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.HoldPaymentFlag)
//            //        .IsRequired()
//            //        .HasColumnName("hold_payment_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.InterestCalculationDate)
//            //        .HasColumnName("interest_calculation_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.InterestCalculationType)
//            //        .IsRequired()
//            //        .HasColumnName("interest_calculation_type")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.InterestGraceAmount)
//            //        .HasColumnName("interest_grace_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.InterestGraceDays).HasColumnName("interest_grace_days");

//            //    entity.Property(e => e.InterestInvoiceNbr).HasColumnName("interest_invoice_nbr");

//            //    entity.Property(e => e.InterestIoiFlag)
//            //        .IsRequired()
//            //        .HasColumnName("interest_ioi_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.InterestPercent)
//            //        .HasColumnName("interest_percent")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.InvoiceDate)
//            //        .HasColumnName("invoice_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.InvoiceId)
//            //        .IsRequired()
//            //        .HasColumnName("invoice_id")
//            //        .HasColumnType("varchar(15)");

//            //    entity.Property(e => e.InvoiceStatus)
//            //        .IsRequired()
//            //        .HasColumnName("invoice_status")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.JournalNbr).HasColumnName("journal_nbr");

//            //    entity.Property(e => e.JournalSourceCode)
//            //        .IsRequired()
//            //        .HasColumnName("journal_source_code")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.LastTransactionDate)
//            //        .HasColumnName("last_transaction_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.NgcId)
//            //        .HasColumnName("ngc_id")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.OriginalAmount)
//            //        .HasColumnName("original_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.PaymentEligibleFlag)
//            //        .IsRequired()
//            //        .HasColumnName("payment_eligible_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.PaymentMethodCode)
//            //        .HasColumnName("payment_method_code")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.PlcExchangeRate)
//            //        .HasColumnName("plc_exchange_rate")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.PrintFlag)
//            //        .IsRequired()
//            //        .HasColumnName("print_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.QcJournalNbr).HasColumnName("qc_journal_nbr");

//            //    entity.Property(e => e.QuickCheckAmount)
//            //        .HasColumnName("quick_check_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.QuickCheckDate)
//            //        .HasColumnName("quick_check_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.QuickCheckNbr)
//            //        .HasColumnName("quick_check_nbr")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.ReferenceId)
//            //        .HasColumnName("reference_id")
//            //        .HasColumnType("varchar(20)");

//            //    entity.Property(e => e.ReversedJournalNbr).HasColumnName("reversed_journal_nbr");

//            //    entity.Property(e => e.ReversedTransactionNbr).HasColumnName("reversed_transaction_nbr");

//            //    entity.Property(e => e.RowSource)
//            //        .HasColumnName("row_source")
//            //        .HasColumnType("varchar(2)");

//            //    entity.Property(e => e.RowSourceNbr).HasColumnName("row_source_nbr");

//            //    entity.Property(e => e.Tax1Code)
//            //        .HasColumnName("tax_1_code")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.Tax1Nbr).HasColumnName("tax_1_nbr");

//            //    entity.Property(e => e.Tax2Flag)
//            //        .IsRequired()
//            //        .HasColumnName("tax_2_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.Tax3Flag)
//            //        .IsRequired()
//            //        .HasColumnName("tax_3_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.TermCode)
//            //        .HasColumnName("term_code")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.TraderId)
//            //        .HasColumnName("trader_id")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.TransactionNbr).HasColumnName("transaction_nbr");
//            //});

//            //modelBuilder.Entity<AccountPayable2>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_AccountPayable");

//            //    entity.ToTable("AccountPayable");

//            //    entity.HasIndex(e => new { e.Oid, e.DataSet })
//            //        .HasName("ix_10047_10046");

//            //    entity.HasIndex(e => new { e.Oid, e.Location, e.NameAddress, e.Number, e.DocumentType, e.VoucherDate, e.DueDate, e.VoucherAmount, e.AmountApplied, e.DataSet, e.TransactionStatus })
//            //        .HasName("ix_10177_10176");

//            //    entity.HasIndex(e => new { e.Oid, e.CreatedOn, e.UpdatedOn, e.Location, e.NameAddress, e.Number, e.Description, e.DocumentType, e.VoucherDate, e.DueDate, e.VoucherAmount, e.AmountApplied, e.Status, e.VoucherStatus, e.TransactionStatus, e.VoucherType, e.UserOrderField1, e.UserOrderField2, e.DataSet })
//            //        .HasName("ix_10066_10065");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //    entity.Property(e => e.Description).HasMaxLength(100);

//            //    entity.Property(e => e.DocumentType).HasMaxLength(100);

//            //    entity.Property(e => e.DueDate).HasColumnType("datetime");

//            //    entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //    entity.Property(e => e.Number).HasMaxLength(100);

//            //    entity.Property(e => e.Status).HasMaxLength(100);

//            //    entity.Property(e => e.TransactionStatus).HasMaxLength(100);

//            //    entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //    entity.Property(e => e.UserOrderField1).HasMaxLength(50);

//            //    entity.Property(e => e.UserOrderField2).HasMaxLength(50);

//            //    entity.Property(e => e.VoucherDate).HasColumnType("datetime");

//            //    entity.Property(e => e.VoucherStatus).HasMaxLength(100);

//            //    entity.Property(e => e.VoucherType).HasMaxLength(50);

//            //    entity.HasOne(d => d.DataSetNavigation)
//            //        .WithMany(p => p.AccountPayable2)
//            //        .HasForeignKey(d => d.DataSet)
//            //        .HasConstraintName("FK_AccountPayable_Dataset");

//            //    entity.HasOne(d => d.LocationNavigation)
//            //        .WithMany(p => p.AccountPayable2)
//            //        .HasForeignKey(d => d.Location)
//            //        .HasConstraintName("FK_AccountPayable_Location");

//            //    entity.HasOne(d => d.NameAddressNavigation)
//            //        .WithMany(p => p.AccountPayable2)
//            //        .HasForeignKey(d => d.NameAddress)
//            //        .HasConstraintName("FK_AccountPayable_NameAddress");
//            //});

//            //modelBuilder.Entity<AccountPayableDetail>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_AccountPayableDetail");

//            //    entity.HasIndex(e => e.AccountPayable)
//            //        .HasName("ix_10049_10048");

//            //    entity.HasIndex(e => new { e.Oid, e.AccountPayable, e.LocationCommodity, e.ChartOfAccount, e.GllocationCode, e.GlaccountNumber, e.DistributionNumber, e.DistributionAmount, e.TransactionType, e.Description, e.OriginationDate, e.ActivationDate, e.VoucherNumber, e.DataSet })
//            //        .HasName("ix_10068_10067");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.ActivationDate).HasColumnType("datetime");

//            //    entity.Property(e => e.Description).HasMaxLength(100);

//            //    entity.Property(e => e.DistributionNumber).HasMaxLength(50);

//            //    entity.Property(e => e.GlaccountNumber)
//            //        .HasColumnName("GLAccountNumber")
//            //        .HasMaxLength(50);

//            //    entity.Property(e => e.GllocationCode)
//            //        .HasColumnName("GLLocationCode")
//            //        .HasMaxLength(50);

//            //    entity.Property(e => e.OriginationDate).HasColumnType("datetime");

//            //    entity.Property(e => e.TransactionType).HasMaxLength(50);

//            //    entity.Property(e => e.VoucherNumber).HasMaxLength(50);

//            //    entity.HasOne(d => d.AccountPayableNavigation)
//            //        .WithMany(p => p.AccountPayableDetail)
//            //        .HasForeignKey(d => d.AccountPayable)
//            //        .HasConstraintName("FK_AccountPayableDetail_AccountPayable");

//            //    entity.HasOne(d => d.ChartOfAccountNavigation)
//            //        .WithMany(p => p.AccountPayableDetail)
//            //        .HasForeignKey(d => d.ChartOfAccount)
//            //        .HasConstraintName("FK_AccountPayableDetail_ChartOfAccount");

//            //    entity.HasOne(d => d.DataSetNavigation)
//            //        .WithMany(p => p.AccountPayableDetail)
//            //        .HasForeignKey(d => d.DataSet)
//            //        .HasConstraintName("FK_AccountPayableDetail_DataSet");

//            //    entity.HasOne(d => d.LocationCommodityNavigation)
//            //        .WithMany(p => p.AccountPayableDetail)
//            //        .HasForeignKey(d => d.LocationCommodity)
//            //        .HasConstraintName("FK_AccountPayableDetail_LocationCommodity");
//            //});

//            //modelBuilder.Entity<AccountPrepayment1>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_AccountPrepayment");

//            //    entity.ToTable("AccountPrepayment");

//            //    entity.HasIndex(e => e.DataSet)
//            //        .HasName("ix_6745_6744");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //    entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //    entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //    entity.HasOne(d => d.DataSetNavigation)
//            //        .WithMany(p => p.AccountPrepayment1)
//            //        .HasForeignKey(d => d.DataSet)
//            //        .HasConstraintName("FK_AccountPrepayment_DataSet");

//            //    entity.HasOne(d => d.LocationNavigation)
//            //        .WithMany(p => p.AccountPrepayment1)
//            //        .HasForeignKey(d => d.Location)
//            //        .HasConstraintName("FK_AccountPrepayment_Location");

//            //    entity.HasOne(d => d.NameAddressNavigation)
//            //        .WithMany(p => p.AccountPrepayment1)
//            //        .HasForeignKey(d => d.NameAddress)
//            //        .HasConstraintName("FK_AccountPrepayment_NameAddress");
//            //});

//            //modelBuilder.Entity<AccountPrepaymentDetail1>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_AccountPrepaymentDetail");

//            //    entity.ToTable("AccountPrepaymentDetail");

//            //    entity.HasIndex(e => new { e.Oid, e.NameAddress, e.Location, e.InvoiceNumber, e.InvoiceDescription, e.InvoiceDate, e.DueDate, e.InvoiceAmount, e.IvcLocation, e.VoidPaymentCode, e.DataSet, e.CashSourceCode })
//            //        .HasName("ix_5950_5949");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.CashSourceCode).HasMaxLength(100);

//            //    entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //    entity.Property(e => e.DueDate).HasColumnType("datetime");

//            //    entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //    entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

//            //    entity.Property(e => e.InvoiceDescription).HasMaxLength(100);

//            //    entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

//            //    entity.Property(e => e.IvcLocation).HasMaxLength(100);

//            //    entity.Property(e => e.IvcNumber).HasMaxLength(100);

//            //    entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //    entity.Property(e => e.VoidPaymentCode).HasMaxLength(100);

//            //    entity.HasOne(d => d.DataSetNavigation)
//            //        .WithMany(p => p.AccountPrepaymentDetail1)
//            //        .HasForeignKey(d => d.DataSet)
//            //        .HasConstraintName("FK_AccountPrepaymentDetail_DataSet");

//            //    entity.HasOne(d => d.LocationNavigation)
//            //        .WithMany(p => p.AccountPrepaymentDetail1)
//            //        .HasForeignKey(d => d.Location)
//            //        .HasConstraintName("FK_AccountPrepaymentDetail_Location");

//            //    entity.HasOne(d => d.NameAddressNavigation)
//            //        .WithMany(p => p.AccountPrepaymentDetail1)
//            //        .HasForeignKey(d => d.NameAddress)
//            //        .HasConstraintName("FK_AccountPrepaymentDetail_NameAddress");
//            //});

//            //modelBuilder.Entity<AccountReceivable>(entity =>
//            //{
//            //    entity.HasKey(e => new { e.InvoiceNbr, e.LocationId })
//            //        .HasName("PK_AccountReceivable_2");

//            //    entity.ToTable("AccountReceivable", "SmartSoft");

//            //    entity.HasIndex(e => new { e.InvoiceNbr, e.LocationId, e.DataSource })
//            //        .HasName("ix_4474_4473");

//            //    entity.HasIndex(e => new { e.InvoiceNbr, e.LocationId, e.DataSourceSystemGroup })
//            //        .HasName("ix_16035_16034");

//            //    entity.HasIndex(e => new { e.Location, e.NameAddress, e.JournalSourceCode, e.InvoiceId, e.Description, e.InvoiceDate, e.DueDate, e.BalanceAmount, e.OriginalAmount, e.DataSource, e.DataSourceSystemGroup })
//            //        .HasName("ix_4478_4477");

//            //    entity.HasIndex(e => new { e.Location, e.NameAddress, e.JournalSourceCode, e.InvoiceId, e.Description, e.InvoiceDate, e.DueDate, e.BalanceAmount, e.OriginalAmount, e.DataSourceSystemGroup, e.DataSource })
//            //        .HasName("ix_4476_4475");

//            //    entity.Property(e => e.InvoiceNbr).HasColumnName("invoice_nbr");

//            //    entity.Property(e => e.LocationId)
//            //        .HasColumnName("location_id")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.AddBy)
//            //        .IsRequired()
//            //        .HasColumnName("add_by")
//            //        .HasColumnType("varchar(40)");

//            //    entity.Property(e => e.AddDate)
//            //        .HasColumnName("add_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.BalanceAmount)
//            //        .HasColumnName("balance_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.BalanceForwardPrintFlag)
//            //        .IsRequired()
//            //        .HasColumnName("balance_forward_print_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.BankId)
//            //        .HasColumnName("bank_id")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.ChangeBy)
//            //        .IsRequired()
//            //        .HasColumnName("change_by")
//            //        .HasColumnType("varchar(40)");

//            //    entity.Property(e => e.ChangeDate)
//            //        .HasColumnName("change_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.CheckListDiscount)
//            //        .HasColumnName("check_list_discount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.CheckListId)
//            //        .HasColumnName("check_list_id")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.CheckListPayAmount)
//            //        .HasColumnName("check_list_pay_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.CommodityLoanInterestDate)
//            //        .HasColumnName("commodity_loan_interest_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.CommodityLoanInvoiceNbr).HasColumnName("commodity_loan_invoice_nbr");

//            //    entity.Property(e => e.ContraAmount)
//            //        .HasColumnName("contra_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.ControlAcctNbr)
//            //        .IsRequired()
//            //        .HasColumnName("control_acct_nbr")
//            //        .HasColumnType("varchar(75)");

//            //    entity.Property(e => e.CurrencyCode)
//            //        .IsRequired()
//            //        .HasColumnName("currency_code")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.CustVendExchangeRate)
//            //        .HasColumnName("cust_vend_exchange_rate")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.CustomerVendorId)
//            //        .IsRequired()
//            //        .HasColumnName("customer_vendor_id")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.Description)
//            //        .HasColumnName("description")
//            //        .HasColumnType("varchar(50)");

//            //    entity.Property(e => e.DiscountAmount)
//            //        .HasColumnName("discount_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.DiscountDate)
//            //        .HasColumnName("discount_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.DiscountPercent)
//            //        .HasColumnName("discount_percent")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.DiscountTakenAmount)
//            //        .HasColumnName("discount_taken_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.DpInterestFlag)
//            //        .IsRequired()
//            //        .HasColumnName("dp_interest_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.DueDate)
//            //        .HasColumnName("due_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.FinancialSource)
//            //        .IsRequired()
//            //        .HasColumnName("financial_source")
//            //        .HasColumnType("varchar(3)");

//            //    entity.Property(e => e.GlDate)
//            //        .HasColumnName("gl_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.GlExchangeRate)
//            //        .HasColumnName("gl_exchange_rate")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.HoldPaymentFlag)
//            //        .IsRequired()
//            //        .HasColumnName("hold_payment_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.InterestCalculationDate)
//            //        .HasColumnName("interest_calculation_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.InterestCalculationType)
//            //        .IsRequired()
//            //        .HasColumnName("interest_calculation_type")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.InterestGraceAmount)
//            //        .HasColumnName("interest_grace_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.InterestGraceDays).HasColumnName("interest_grace_days");

//            //    entity.Property(e => e.InterestInvoiceNbr).HasColumnName("interest_invoice_nbr");

//            //    entity.Property(e => e.InterestIoiFlag)
//            //        .IsRequired()
//            //        .HasColumnName("interest_ioi_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.InterestPercent)
//            //        .HasColumnName("interest_percent")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.InvoiceDate)
//            //        .HasColumnName("invoice_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.InvoiceId)
//            //        .IsRequired()
//            //        .HasColumnName("invoice_id")
//            //        .HasColumnType("varchar(15)");

//            //    entity.Property(e => e.InvoiceStatus)
//            //        .IsRequired()
//            //        .HasColumnName("invoice_status")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.JournalNbr).HasColumnName("journal_nbr");

//            //    entity.Property(e => e.JournalSourceCode)
//            //        .IsRequired()
//            //        .HasColumnName("journal_source_code")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.LastTransactionDate)
//            //        .HasColumnName("last_transaction_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.NgcId)
//            //        .HasColumnName("ngc_id")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.OriginalAmount)
//            //        .HasColumnName("original_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.PaymentEligibleFlag)
//            //        .IsRequired()
//            //        .HasColumnName("payment_eligible_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.PaymentMethodCode)
//            //        .HasColumnName("payment_method_code")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.PlcExchangeRate)
//            //        .HasColumnName("plc_exchange_rate")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.PrintFlag)
//            //        .IsRequired()
//            //        .HasColumnName("print_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.QcJournalNbr).HasColumnName("qc_journal_nbr");

//            //    entity.Property(e => e.QuickCheckAmount)
//            //        .HasColumnName("quick_check_amount")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.QuickCheckDate)
//            //        .HasColumnName("quick_check_date")
//            //        .HasColumnType("datetime");

//            //    entity.Property(e => e.QuickCheckNbr)
//            //        .HasColumnName("quick_check_nbr")
//            //        .HasColumnType("numeric");

//            //    entity.Property(e => e.ReferenceId)
//            //        .HasColumnName("reference_id")
//            //        .HasColumnType("varchar(20)");

//            //    entity.Property(e => e.ReversedJournalNbr).HasColumnName("reversed_journal_nbr");

//            //    entity.Property(e => e.ReversedTransactionNbr).HasColumnName("reversed_transaction_nbr");

//            //    entity.Property(e => e.RowSource)
//            //        .HasColumnName("row_source")
//            //        .HasColumnType("varchar(2)");

//            //    entity.Property(e => e.RowSourceNbr).HasColumnName("row_source_nbr");

//            //    entity.Property(e => e.Tax1Code)
//            //        .HasColumnName("tax_1_code")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.Tax1Nbr).HasColumnName("tax_1_nbr");

//            //    entity.Property(e => e.Tax2Flag)
//            //        .IsRequired()
//            //        .HasColumnName("tax_2_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.Tax3Flag)
//            //        .IsRequired()
//            //        .HasColumnName("tax_3_flag")
//            //        .HasColumnType("varchar(1)");

//            //    entity.Property(e => e.TermCode)
//            //        .HasColumnName("term_code")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.TraderId)
//            //        .HasColumnName("trader_id")
//            //        .HasColumnType("varchar(10)");

//            //    entity.Property(e => e.TransactionNbr).HasColumnName("transaction_nbr");
//            //});

//            //modelBuilder.Entity<AccountReceivable1>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_AccountReceivable");

//            //    entity.ToTable("AccountReceivable");

//            //    entity.HasIndex(e => new { e.Oid, e.DataSet })
//            //        .HasName("ix_10051_10050");

//            //    entity.HasIndex(e => new { e.Oid, e.Location, e.NameAddress, e.Description, e.Amount, e.InvoiceDate, e.DueDate, e.ShipDate, e.AmountApplied, e.Number, e.DocumentType, e.AccountReceivablePaymentTerm, e.DataSet, e.Status })
//            //        .HasName("ix_10175_10174");

//            //    entity.HasIndex(e => new { e.Oid, e.CreatedOn, e.UpdatedOn, e.Location, e.NameAddress, e.Description, e.Amount, e.Status, e.InvoiceDate, e.DueDate, e.ShipDate, e.AmountApplied, e.Number, e.DocumentType, e.DataSet })
//            //        .HasName("ix_10064_10063");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //    entity.Property(e => e.Description).HasMaxLength(100);

//            //    entity.Property(e => e.DocumentType).HasMaxLength(100);

//            //    entity.Property(e => e.DueDate).HasColumnType("datetime");

//            //    entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //    entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

//            //    entity.Property(e => e.Number).HasMaxLength(100);

//            //    entity.Property(e => e.ShipDate).HasColumnType("datetime");

//            //    entity.Property(e => e.Status).HasMaxLength(100);

//            //    entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //    entity.HasOne(d => d.AccountReceivablePaymentTermNavigation)
//            //        .WithMany(p => p.AccountReceivable1)
//            //        .HasForeignKey(d => d.AccountReceivablePaymentTerm)
//            //        .HasConstraintName("FK_AccountReceivable_AccountReceivablePaymentTerm");

//            //    entity.HasOne(d => d.DataSetNavigation)
//            //        .WithMany(p => p.AccountReceivable1)
//            //        .HasForeignKey(d => d.DataSet)
//            //        .HasConstraintName("FK_AccountReceivable_DataSet");

//            //    entity.HasOne(d => d.LocationNavigation)
//            //        .WithMany(p => p.AccountReceivable1)
//            //        .HasForeignKey(d => d.Location)
//            //        .HasConstraintName("FK_AccountReceivable_Location");

//            //    entity.HasOne(d => d.NameAddressNavigation)
//            //        .WithMany(p => p.AccountReceivable1)
//            //        .HasForeignKey(d => d.NameAddress)
//            //        .HasConstraintName("FK_AccountReceivable_NameAddress");
//            //});

//            //modelBuilder.Entity<AccountReceivableDetail>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_AccountReceivableDetail");

//            //    entity.HasIndex(e => e.AccountReceivable)
//            //        .HasName("ix_3081_3080");

//            //    entity.HasIndex(e => new { e.Oid, e.AccountReceivable, e.ChartOfAccount, e.LocationCommodity, e.DistributionNumber, e.DistrubutionAmount, e.OriginationDate, e.ActivationDate, e.GllocationCode, e.DataSet })
//            //        .HasName("ix_3312_3311");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.ActivationDate).HasColumnType("datetime");

//            //    entity.Property(e => e.DistributionNumber).HasMaxLength(50);

//            //    entity.Property(e => e.GllocationCode)
//            //        .HasColumnName("GLLocationCode")
//            //        .HasMaxLength(50);

//            //    entity.Property(e => e.OriginationDate).HasColumnType("datetime");

//            //    entity.HasOne(d => d.AccountReceivableNavigation)
//            //        .WithMany(p => p.AccountReceivableDetail)
//            //        .HasForeignKey(d => d.AccountReceivable)
//            //        .HasConstraintName("FK_AccountReceivableDetail_AccountReceivable");

//            //    entity.HasOne(d => d.ChartOfAccountNavigation)
//            //        .WithMany(p => p.AccountReceivableDetail)
//            //        .HasForeignKey(d => d.ChartOfAccount)
//            //        .HasConstraintName("FK_AccountReceivableDetail_ChartOfAccount");

//            //    entity.HasOne(d => d.DataSetNavigation)
//            //        .WithMany(p => p.AccountReceivableDetail)
//            //        .HasForeignKey(d => d.DataSet)
//            //        .HasConstraintName("FK_AccountReceivableDetail_DataSet");

//            //    entity.HasOne(d => d.LocationCommodityNavigation)
//            //        .WithMany(p => p.AccountReceivableDetail)
//            //        .HasForeignKey(d => d.LocationCommodity)
//            //        .HasConstraintName("FK_AccountReceivableDetail_LocationCommodity");
//            //});

//            //modelBuilder.Entity<AccountReceivablePaymentTerm>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_AccountReceivablePaymentTerm");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.Description).HasMaxLength(100);

//            //    entity.Property(e => e.SourceKey).HasMaxLength(25);
//            //});

//            //modelBuilder.Entity<Address>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_Address_1");

//            //    entity.ToTable("Address", "RightAngle");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.Address1).HasMaxLength(100);

//            //    entity.Property(e => e.Address2).HasMaxLength(100);

//            //    entity.Property(e => e.City).HasMaxLength(100);

//            //    entity.Property(e => e.CnctId).HasColumnName("CnctID");

//            //    entity.Property(e => e.Code).HasMaxLength(100);

//            //    entity.Property(e => e.Country).HasMaxLength(100);

//            //    entity.Property(e => e.Description).HasMaxLength(100);

//            //    entity.Property(e => e.Fax).HasMaxLength(100);

//            //    entity.Property(e => e.FirstName).HasMaxLength(100);

//            //    entity.Property(e => e.LastName).HasMaxLength(100);

//            //    entity.Property(e => e.LoadDate)
//            //        .HasColumnType("smalldatetime")
//            //        .HasDefaultValueSql("getdate()");

//            //    entity.Property(e => e.PhoneNumber).HasMaxLength(100);

//            //    entity.Property(e => e.Remarks1).HasMaxLength(100);

//            //    entity.Property(e => e.Remarks2).HasMaxLength(100);

//            //    entity.Property(e => e.State).HasDefaultValueSql("newid()");
//            //});

//            //modelBuilder.Entity<Address1>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_Address");

//            //    entity.ToTable("Address");

//            //    entity.HasIndex(e => e.Country)
//            //        .HasName("iCountry_Address");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.City).HasMaxLength(100);

//            //    entity.Property(e => e.FullAddress).HasMaxLength(100);

//            //    entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //    entity.Property(e => e.StateProvince).HasMaxLength(100);

//            //    entity.Property(e => e.Street).HasMaxLength(100);

//            //    entity.Property(e => e.ZipPostal).HasMaxLength(100);

//            //    entity.HasOne(d => d.CountryNavigation)
//            //        .WithMany(p => p.Address1)
//            //        .HasForeignKey(d => d.Country)
//            //        .HasConstraintName("FK_Address_Country");
//            //});

//            //modelBuilder.Entity<AllconExtract>(entity =>
//            //{
//            //    entity.HasKey(e => e.LineSequence)
//            //        .HasName("PK_ALLCON_EXTRACT");

//            //    entity.ToTable("ALLCON_EXTRACT", "AgrisStaging");

//            //    entity.HasIndex(e => e.RawData)
//            //        .HasName("ix_2850_2849");

//            //    entity.HasIndex(e => new { e.Commodity, e.RecordType, e.LineSequence })
//            //        .HasName("ix_2856_2855");

//            //    entity.HasIndex(e => new { e.IsSkipped, e.RecordType, e.LineSequence })
//            //        .HasName("ix_2860_2859");

//            //    entity.HasIndex(e => new { e.IsSummary, e.RecordType, e.LineSequence })
//            //        .HasName("ix_2858_2857");

//            //    entity.HasIndex(e => new { e.Location, e.RecordType, e.LineSequence })
//            //        .HasName("ix_2854_2853");

//            //    entity.Property(e => e.Amount).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.Code).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.Commodity).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.Description).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.FolderName).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.IsSkipped).HasDefaultValueSql("0");

//            //    entity.Property(e => e.IsSummary).HasDefaultValueSql("0");

//            //    entity.Property(e => e.Location).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.RawData).HasColumnType("varchar(150)");

//            //    entity.Property(e => e.RecordType).HasColumnType("char(1)");
//            //});

//            //modelBuilder.Entity<AllrsExtract>(entity =>
//            //{
//            //    entity.HasKey(e => e.LineSequence)
//            //        .HasName("PK_AgrisStaging.ALLRS_EXTRACT");

//            //    entity.ToTable("ALLRS_EXTRACT", "AgrisStaging");

//            //    entity.Property(e => e.Amount).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.Code).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.Commodity).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.Description).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.FolderName).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.IsSkipped).HasDefaultValueSql("0");

//            //    entity.Property(e => e.IsSummary).HasDefaultValueSql("0");

//            //    entity.Property(e => e.Location).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.RawData).HasColumnType("varchar(200)");

//            //    entity.Property(e => e.RecordType).HasColumnType("char(1)");
//            //});

//            //modelBuilder.Entity<AllstldExtract>(entity =>
//            //{
//            //    entity.HasKey(e => e.LineSequence)
//            //        .HasName("PK_AgrisStaging");

//            //    entity.ToTable("ALLSTLD_EXTRACT", "AgrisStaging");

//            //    entity.Property(e => e.Amount).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.Code).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.Commodity).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.Description).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.FolderName).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.IsSkipped).HasDefaultValueSql("0");

//            //    entity.Property(e => e.IsSummary).HasDefaultValueSql("0");

//            //    entity.Property(e => e.Location).HasColumnType("varchar(100)");

//            //    entity.Property(e => e.RawData).HasColumnType("varchar(200)");

//            //    entity.Property(e => e.RecordType).HasColumnType("char(1)");
//            //});

//            //modelBuilder.Entity<Analysis>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_Analysis");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //    entity.Property(e => e.Name).HasMaxLength(100);

//            //    entity.Property(e => e.ObjectTypeName).HasMaxLength(100);
//            //});

//            //modelBuilder.Entity<AuditDataItemPersistent>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_AuditDataItemPersistent");

//            //    entity.HasIndex(e => e.AuditedObject)
//            //        .HasName("iAuditedObject_AuditDataItemPersistent");

//            //    entity.HasIndex(e => e.ModifiedOn)
//            //        .HasName("iModifiedOn_AuditDataItemPersistent");

//            //    entity.HasIndex(e => e.NewObject)
//            //        .HasName("iNewObject_AuditDataItemPersistent");

//            //    entity.HasIndex(e => e.OldObject)
//            //        .HasName("iOldObject_AuditDataItemPersistent");

//            //    entity.HasIndex(e => e.OperationType)
//            //        .HasName("iOperationType_AuditDataItemPersistent");

//            //    entity.HasIndex(e => e.UserName)
//            //        .HasName("iUserName_AuditDataItemPersistent");

//            //    entity.Property(e => e.Oid).ValueGeneratedNever();

//            //    entity.Property(e => e.Description).HasMaxLength(2048);

//            //    entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //    entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

//            //    entity.Property(e => e.NewValue).HasMaxLength(1024);

//            //    entity.Property(e => e.OldValue).HasMaxLength(1024);

//            //    entity.Property(e => e.OperationType).HasMaxLength(100);

//            //    entity.Property(e => e.PropertyName).HasMaxLength(100);

//            //    entity.Property(e => e.UserName).HasMaxLength(100);

//            //    entity.HasOne(d => d.AuditedObjectNavigation)
//            //        .WithMany(p => p.AuditDataItemPersistent)
//            //        .HasForeignKey(d => d.AuditedObject)
//            //        .HasConstraintName("FK_AuditDataItemPersistent_AuditedObject");

//            //    entity.HasOne(d => d.NewObjectNavigation)
//            //        .WithMany(p => p.AuditDataItemPersistentNewObjectNavigation)
//            //        .HasForeignKey(d => d.NewObject)
//            //        .HasConstraintName("FK_AuditDataItemPersistent_NewObject");

//            //    entity.HasOne(d => d.OldObjectNavigation)
//            //        .WithMany(p => p.AuditDataItemPersistentOldObjectNavigation)
//            //        .HasForeignKey(d => d.OldObject)
//            //        .HasConstraintName("FK_AuditDataItemPersistent_OldObject");
//            //});

//            //modelBuilder.Entity<AuditedObjectWeakReference>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("iOid_AuditedObjectWeakReference");

//            //    entity.Property(e => e.Oid).ValueGeneratedNever();

//            //    entity.Property(e => e.DisplayName).HasMaxLength(250);

//            //    entity.HasOne(d => d.O)
//            //        .WithOne(p => p.AuditedObjectWeakReference)
//            //        .HasForeignKey<AuditedObjectWeakReference>(d => d.Oid)
//            //        .OnDelete(DeleteBehavior.Restrict)
//            //        .HasConstraintName("FK_AuditedObjectWeakReference_Oid");
//            //});

//            //modelBuilder.Entity<BasicUser>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_BasicUser");

//            //    entity.Property(e => e.Oid).HasColumnName("OID");

//            //    entity.Property(e => e.FullName).HasMaxLength(100);

//            //    entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //    entity.Property(e => e.Password).HasMaxLength(100);

//            //    entity.Property(e => e.UserName).HasMaxLength(100);
//            //});

//            //modelBuilder.Entity<BoardOfTrade>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_BoardOfTrade_1");

//            //    entity.ToTable("BoardOfTrade", "RightAngle");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.Code).HasMaxLength(100);

//            //    entity.Property(e => e.Description).HasMaxLength(100);

//            //    entity.Property(e => e.LoadDate).HasColumnType("smalldatetime");

//            //    entity.Property(e => e.RphdrId).HasColumnName("RPHdrID");
//            //});

//            //modelBuilder.Entity<BoardOfTrade1>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_BoardOfTrade");

//            //    entity.ToTable("BoardOfTrade");

//            //    entity.HasIndex(e => e.DataSource)
//            //        .HasName("iDataSource_BoardOfTrade");

//            //    entity.HasIndex(e => e.Gcrecord)
//            //        .HasName("iGCRecord_BoardOfTrade");

//            //    entity.HasIndex(e => e.ParentBoardOfTrade)
//            //        .HasName("iParentBoardOfTrade_BoardOfTrade");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.Code).HasMaxLength(100);

//            //    entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //    entity.Property(e => e.Description).HasMaxLength(100);

//            //    entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //    entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //    entity.HasOne(d => d.DataSourceNavigation)
//            //        .WithMany(p => p.BoardOfTrade1)
//            //        .HasForeignKey(d => d.DataSource)
//            //        .HasConstraintName("FK_BoardOfTrade_DataSource");

//            //    entity.HasOne(d => d.ParentBoardOfTradeNavigation)
//            //        .WithMany(p => p.InverseParentBoardOfTradeNavigation)
//            //        .HasForeignKey(d => d.ParentBoardOfTrade)
//            //        .HasConstraintName("FK_BoardOfTrade_BoardOfTrade");
//            //});

//            //modelBuilder.Entity<BuildBasis>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_BuildBasis");

//            //    entity.HasIndex(e => e.PriorBuildBasis)
//            //        .HasName("ix_10088_10087");

//            //    entity.HasIndex(e => new { e.Oid, e.PriorBuildBasis })
//            //        .HasName("ix_10086_10085");

//            //    entity.HasIndex(e => new { e.Basis, e.MarketSituation, e.DataSet })
//            //        .HasName("ix_9957_9956");

//            //    entity.HasIndex(e => new { e.MarketSituation, e.DataSet, e.Basis })
//            //        .HasName("ix_9962_9961");

//            //    entity.HasIndex(e => new { e.Oid, e.Basis, e.DataSet })
//            //        .HasName("ix_10054_10053");

//            //    entity.HasIndex(e => new { e.Oid, e.DataSet, e.MarketSituation })
//            //        .HasName("ix_9954_9953");

//            //    entity.HasIndex(e => new { e.Oid, e.MarketSituation, e.DataSet })
//            //        .HasName("ix_9948_9947");

//            //    entity.HasIndex(e => new { e.Oid, e.MarketSituation, e.Basis, e.DataSet })
//            //        .HasName("ix_10056_10055");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.Basis).HasColumnType("decimal");

//            //    entity.Property(e => e.CreatedOn)
//            //        .HasColumnType("datetime")
//            //        .HasDefaultValueSql("getdate()");

//            //    entity.Property(e => e.TargetDeliveryDate).HasColumnType("datetime");

//            //    entity.Property(e => e.UpdatedOn)
//            //        .HasColumnType("datetime")
//            //        .HasDefaultValueSql("getdate()");

//            //    entity.HasOne(d => d.DataSetNavigation)
//            //        .WithMany(p => p.BuildBasis)
//            //        .HasForeignKey(d => d.DataSet)
//            //        .HasConstraintName("FK_BuildBasis_DataSet");

//            //    entity.HasOne(d => d.MarketSituationNavigation)
//            //        .WithMany(p => p.BuildBasis)
//            //        .HasForeignKey(d => d.MarketSituation)
//            //        .HasConstraintName("FK_BuildBasis_MarketSituation");

//            //    entity.HasOne(d => d.PriorBuildBasisNavigation)
//            //        .WithMany(p => p.InversePriorBuildBasisNavigation)
//            //        .HasForeignKey(d => d.PriorBuildBasis)
//            //        .HasConstraintName("FK_BuildBasis_BuildBasis");
//            //});

//            //modelBuilder.Entity<BuildBasisImport>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_BuildBasisImport");

//            //    entity.HasIndex(e => new { e.Basis, e.Dataset, e.MarketSituation })
//            //        .HasName("ix_12710_12709");

//            //    entity.HasIndex(e => new { e.Oid, e.Location, e.Commodity, e.LocationCommodity, e.OptionMonth, e.MarketZone, e.TransportationMode, e.BoardOfTrade, e.MarketSituation, e.DeliveryDate, e.Basis, e.Dataset })
//            //        .HasName("ix_13565_13564");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

//            //    entity.Property(e => e.TargetDeliveryDate).HasColumnType("datetime");

//            //    entity.Property(e => e.TrueMonthEnd).HasColumnType("datetime");
//            //});

//            //modelBuilder.Entity<BusinessAssociateExternal>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_BusinessAssociateExternal_Oid");

//            //    entity.ToTable("BusinessAssociateExternal", "RightAngle");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.Baabbrvtn)
//            //        .HasColumnName("BAAbbrvtn")
//            //        .HasMaxLength(20);

//            //    entity.Property(e => e.BacrtnUserId).HasColumnName("BACrtnUserID");

//            //    entity.Property(e => e.Baid).HasColumnName("BAID");

//            //    entity.Property(e => e.Banme)
//            //        .HasColumnName("BANme")
//            //        .HasMaxLength(50);

//            //    entity.Property(e => e.BaprntBaid).HasColumnName("BAPrntBAID");

//            //    entity.Property(e => e.BarelationshipType)
//            //        .HasColumnName("BARelationshipType")
//            //        .HasMaxLength(80);

//            //    entity.Property(e => e.Batpe)
//            //        .HasColumnName("BATpe")
//            //        .HasColumnType("nchar(1)");
//            //});

//            //modelBuilder.Entity<BusinessAssociateInternal>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_BusinessAssociateInternal_Oid");

//            //    entity.ToTable("BusinessAssociateInternal", "RightAngle");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.Baabbrvtn)
//            //        .HasColumnName("BAAbbrvtn")
//            //        .HasMaxLength(20);

//            //    entity.Property(e => e.BacrtnUserId).HasColumnName("BACrtnUserID");

//            //    entity.Property(e => e.Baid).HasColumnName("BAID");

//            //    entity.Property(e => e.Banme)
//            //        .HasColumnName("BANme")
//            //        .HasMaxLength(50);

//            //    entity.Property(e => e.BaprntBaid).HasColumnName("BAPrntBAID");

//            //    entity.Property(e => e.BarelationshipType)
//            //        .HasColumnName("BARelationshipType")
//            //        .HasMaxLength(80);

//            //    entity.Property(e => e.Batpe)
//            //        .HasColumnName("BATpe")
//            //        .HasColumnType("nchar(1)");

//            //    entity.Property(e => e.DataSourceCode).HasMaxLength(20);
//            //});

//            //modelBuilder.Entity<ChartOfAccount>(entity =>
//            //{
//            //    entity.HasKey(e => e.Oid)
//            //        .HasName("PK_ChartOfAccount");

//            //    entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //    entity.Property(e => e.AccountCode).HasMaxLength(50);

//            //    entity.Property(e => e.Description).HasMaxLength(100);

//            //    entity.Property(e => e.DetailCode).HasMaxLength(50);

//            //    entity.Property(e => e.ProfitCenter).HasMaxLength(50);

//            //    entity.Property(e => e.SourceKey).HasMaxLength(50);

//            //    entity.HasOne(d => d.DataSourceNavigation)
//            //        .WithMany(p => p.ChartOfAccount)
//            //        .HasForeignKey(d => d.DataSource)
//            //        .HasConstraintName("FK_ChartOfAccount_DataSource");
//            //});

//            modelBuilder.Entity<Commodity>(entity =>
//            {
//                // entity.HasKey(e => e.ID);
//                entity.HasKey(e => e.Oid);
//                // .HasName("PK_Commodity");

//                //entity.HasIndex(e => e.DataSource)
//                //    .HasName("iDataSource_Commodity");

//                //entity.HasIndex(e => e.Gcrecord)
//                //    .HasName("iGCRecord_Commodity");

//                //entity.HasIndex(e => new { e.Description, e.Code, e.Oid })
//                //    .HasName("_dta_index_Commodity_26_564197060__K2_K1_4");

//                //entity.HasIndex(e => new { e.Oid, e.Code, e.Description })
//                //    .HasName("_dta_index_Commodity_26_564197060__K1_K2_K4");

//                //entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//                //entity.Property(e => e.Code).HasMaxLength(100);

//                //entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//                //entity.Property(e => e.Description).HasMaxLength(100);

//                //entity.Property(e => e.FuturesMonths).HasMaxLength(100);

//                //entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//                //entity.Property(e => e.PoundsPerBushel).HasColumnType("decimal");

//                //entity.Property(e => e.Status).HasMaxLength(100);

//                //entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//                //entity.HasOne(d => d.DataSourceNavigation)
//                //    .WithMany(p => p.Commodity)
//                //    .HasForeignKey(d => d.DataSource)
//                //    .HasConstraintName("FK_Commodity_DataSource");
//            });

//            //    modelBuilder.Entity<CommodityBoardOfTrade>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_CommodityExchange");

//            //        entity.HasIndex(e => e.Dtnfeed)
//            //            .HasName("iDTNFeed_CommodityBoardOfTrade");

//            //        entity.HasIndex(e => e.FromDtnfuture)
//            //            .HasName("iFromDTNFuture_CommodityBoardOfTrade");

//            //        entity.HasIndex(e => e.Gcrecord)
//            //            .HasName("iGCRecord_CommodityBoardOfTrade");

//            //        entity.HasIndex(e => e.ToDtnfuture)
//            //            .HasName("iToDTNFuture_CommodityBoardOfTrade");

//            //        entity.HasIndex(e => new { e.Commodity, e.BoardOfTrade })
//            //            .HasName("ixCommodityBoardOfTrade_Cm_BOT");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Dtnfeed).HasColumnName("DTNFeed");

//            //        entity.Property(e => e.FromDtnfuture).HasColumnName("FromDTNFuture");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.RollValue).HasColumnType("decimal");

//            //        entity.Property(e => e.TickerPriceConversionFactor)
//            //            .HasColumnType("decimal")
//            //            .HasDefaultValueSql("1");

//            //        entity.Property(e => e.ToDtnfuture).HasColumnName("ToDTNFuture");

//            //        entity.HasOne(d => d.BoardOfTradeNavigation)
//            //            .WithMany(p => p.CommodityBoardOfTrade)
//            //            .HasForeignKey(d => d.BoardOfTrade)
//            //            .HasConstraintName("FK_CommodityBoardOfTrade_BoardOfTrade");

//            //        entity.HasOne(d => d.CommodityNavigation)
//            //            .WithMany(p => p.CommodityBoardOfTrade)
//            //            .HasForeignKey(d => d.Commodity)
//            //            .HasConstraintName("FK_CommodityBoardOfTrade_Commodity");

//            //        entity.HasOne(d => d.DtnfeedNavigation)
//            //            .WithMany(p => p.CommodityBoardOfTrade)
//            //            .HasForeignKey(d => d.Dtnfeed)
//            //            .HasConstraintName("FK_CommodityBoardOfTrade_DTNFeed");

//            //        entity.HasOne(d => d.FromDtnfutureNavigation)
//            //            .WithMany(p => p.CommodityBoardOfTradeFromDtnfutureNavigation)
//            //            .HasForeignKey(d => d.FromDtnfuture)
//            //            .HasConstraintName("FK_CommodityBoardOfTrade_DTNFuture");

//            //        entity.HasOne(d => d.FromOptionMonthNavigation)
//            //            .WithMany(p => p.CommodityBoardOfTradeFromOptionMonthNavigation)
//            //            .HasForeignKey(d => d.FromOptionMonth)
//            //            .HasConstraintName("FK_CommodityBoardOfTrade_OptionMonth");

//            //        entity.HasOne(d => d.ToDtnfutureNavigation)
//            //            .WithMany(p => p.CommodityBoardOfTradeToDtnfutureNavigation)
//            //            .HasForeignKey(d => d.ToDtnfuture)
//            //            .HasConstraintName("FK_CommodityBoardOfTrade_DTNFuture1");

//            //        entity.HasOne(d => d.ToOptionMonthNavigation)
//            //            .WithMany(p => p.CommodityBoardOfTradeToOptionMonthNavigation)
//            //            .HasForeignKey(d => d.ToOptionMonth)
//            //            .HasConstraintName("FK_CommodityBoardOfTrade_OptionMonth1");
//            //    });

//            //    modelBuilder.Entity<Contact>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Contact");

//            //        entity.ToTable("Contact", "RightAngle");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.LoadDate)
//            //            .HasColumnType("smalldatetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.NameDescription).HasMaxLength(100);

//            //        entity.Property(e => e.NameId).HasColumnName("NameID");
//            //    });

//            //    modelBuilder.Entity<Contract>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Contract");

//            //        entity.HasIndex(e => e.DataSet)
//            //            .HasName("ix_10189_10188");

//            //        entity.HasIndex(e => new { e.Commodity, e.Oid })
//            //            .HasName("_dta_index_Contract_19_342292279__K1_10");

//            //        entity.HasIndex(e => new { e.ContractStatus, e.Customer })
//            //            .HasName("_dta_index_Contract_26_342292279__K11_K9");

//            //        entity.HasIndex(e => new { e.ContractStatus, e.DataSet })
//            //            .HasName("_dta_index_Contract_26_342292279__K11_K4");

//            //        entity.HasIndex(e => new { e.Oid, e.ContractStatus })
//            //            .HasName("_dta_index_Contract_26_342292279__K1_K11");

//            //        entity.HasIndex(e => new { e.Oid, e.Location })
//            //            .HasName("ix_9989_9988");

//            //        entity.HasIndex(e => new { e.Oid, e.PurchaseSalesCode })
//            //            .HasName("ix_9995_9994");

//            //        entity.HasIndex(e => new { e.Location, e.Commodity, e.ContractStatus })
//            //            .HasName("_dta_index_Contract_26_342292279__K5_K10_K11");

//            //        entity.HasIndex(e => new { e.Oid, e.Commodity, e.LocationCommodity })
//            //            .HasName("ix_8_7");

//            //        entity.HasIndex(e => new { e.Oid, e.Commodity, e.SourceKey })
//            //            .HasName("_dta_index_Contract_19_342292279__K1_K10_K6");

//            //        entity.HasIndex(e => new { e.PurchaseSalesCode, e.SourceKey, e.Oid })
//            //            .HasName("_dta_index_Contract_19_342292279__K6_K1_16");

//            //        entity.HasIndex(e => new { e.SourceKey, e.Location, e.Oid })
//            //            .HasName("_dta_index_Contract_19_342292279__K6_K5_K1");

//            //        entity.HasIndex(e => new { e.Location, e.PurchaseSalesCode, e.Oid, e.SourceKey })
//            //            .HasName("_dta_index_Contract_19_342292279__K1_K6_5_16");

//            //        entity.HasIndex(e => new { e.Oid, e.ContractNumber, e.LocationCommodity, e.PurchaseSalesCode })
//            //            .HasName("ix_229_228");

//            //        entity.HasIndex(e => new { e.Oid, e.SourceKey, e.Commodity, e.DataSet })
//            //            .HasName("ix_2650_2649");

//            //        entity.HasIndex(e => new { e.Oid, e.Location, e.ContractNumber, e.PurchaseSalesCode, e.DataSet })
//            //            .HasName("ix_10138_10137");

//            //        entity.HasIndex(e => new { e.ContractStatus, e.ContractType, e.Commodity, e.Location, e.Oid, e.DataSet, e.Customer, e.PurchaseSalesCode, e.ContractNumber, e.DateWritten })
//            //            .HasName("_dta_index_Contract_26_342292279__K11_K13_K10_K5_K1_K4_K9_K16_K7_K14");

//            //        entity.HasIndex(e => new { e.Oid, e.DataSet, e.Location, e.ContractNumber, e.Customer, e.Commodity, e.ContractType, e.DateWritten, e.PurchaseSalesCode, e.ContractStatus })
//            //            .HasName("ix_10183_10182");

//            //        entity.HasIndex(e => new { e.Oid, e.Location, e.ContractNumber, e.Customer, e.Commodity, e.ContractStatus, e.ContractType, e.DateWritten, e.PurchaseSalesCode, e.DataSet })
//            //            .HasName("ix_10181_10180");

//            //        entity.HasIndex(e => new { e.ContractNumber, e.LocationCommodity, e.Customer, e.ContractStatus, e.Quantity, e.ContractType, e.DateWritten, e.DeliveryTerms, e.PurchaseSalesCode, e.CustomerContractNumber, e.DataSet })
//            //            .HasName("ix_56_55");

//            //        entity.HasIndex(e => new { e.Oid, e.SourceKey, e.ContractNumber, e.LocationCommodity, e.Customer, e.ContractStatus, e.ContractType, e.DateWritten, e.DeliveryTerms, e.PurchaseSalesCode, e.QuantityBase, e.ShipToName, e.CustomerContractNumber, e.TransportationMode, e.Trader, e.DataSet })
//            //            .HasName("ix_10060_10059");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.AppliedCancelledUnits).HasColumnType("decimal");

//            //        entity.Property(e => e.BasisPrice).HasColumnType("decimal");

//            //        entity.Property(e => e.BuyConversionRate).HasColumnType("decimal");

//            //        entity.Property(e => e.CommodityCode).HasMaxLength(100);

//            //        entity.Property(e => e.ContractNumber).HasMaxLength(100);

//            //        entity.Property(e => e.ContractStatus).HasMaxLength(100);

//            //        entity.Property(e => e.CreatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.Currency).HasMaxLength(100);

//            //        entity.Property(e => e.CustomerContractNumber).HasMaxLength(100);

//            //        entity.Property(e => e.DateWritten).HasColumnType("datetime");

//            //        entity.Property(e => e.DeliveryTerms).HasMaxLength(100);

//            //        entity.Property(e => e.FuturesPrice).HasColumnType("decimal");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Price).HasColumnType("decimal");

//            //        entity.Property(e => e.PurchaseSalesCode).HasMaxLength(100);

//            //        entity.Property(e => e.QuantityBase).HasMaxLength(100);

//            //        entity.Property(e => e.ReleasePriceBasis).HasColumnType("decimal");

//            //        entity.Property(e => e.SellConversionRate).HasColumnType("decimal");

//            //        entity.Property(e => e.ShipToName).HasMaxLength(100);

//            //        entity.Property(e => e.SourceKey).HasMaxLength(100);

//            //        entity.Property(e => e.UpdatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.HasOne(d => d.ContractTypeNavigation)
//            //            .WithMany(p => p.Contract)
//            //            .HasForeignKey(d => d.ContractType)
//            //            .HasConstraintName("FK_Contract_ContractType");

//            //        entity.HasOne(d => d.CustomerNavigation)
//            //            .WithMany(p => p.Contract)
//            //            .HasForeignKey(d => d.Customer)
//            //            .HasConstraintName("FK_Contract_Customer");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.Contract)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_Contract_DataSet");

//            //        entity.HasOne(d => d.LocationNavigation)
//            //            .WithMany(p => p.Contract)
//            //            .HasForeignKey(d => d.Location)
//            //            .HasConstraintName("FK_Contract_Location");

//            //        entity.HasOne(d => d.LocationCommodityNavigation)
//            //            .WithMany(p => p.Contract)
//            //            .HasForeignKey(d => d.LocationCommodity)
//            //            .HasConstraintName("FK_Contract_Commodity");

//            //        entity.HasOne(d => d.MarketZoneNavigation)
//            //            .WithMany(p => p.Contract)
//            //            .HasForeignKey(d => d.MarketZone)
//            //            .HasConstraintName("FK_Contract_StateRegion");

//            //        entity.HasOne(d => d.TransportationModeNavigation)
//            //            .WithMany(p => p.Contract)
//            //            .HasForeignKey(d => d.TransportationMode)
//            //            .HasConstraintName("FK_Contract_TransportationMode");
//            //    });

//            //    modelBuilder.Entity<Contract1>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Contract_2");

//            //        entity.ToTable("Contract", "SmartSoft");

//            //        entity.HasIndex(e => new { e.Oid, e.DataSourceSystemGroup })
//            //            .HasName("ix_2644_2643");

//            //        entity.HasIndex(e => new { e.QuantityUom, e.ContractNbr })
//            //            .HasName("_dta_index_Contract_19_919674324__K21_K2");

//            //        entity.HasIndex(e => new { e.PlcId, e.DataSourceSystemGroup, e.ShipModeCode })
//            //            .HasName("ix_2655_2654");

//            //        entity.HasIndex(e => new { e.PlcId, e.PricingTypeCode, e.DataSourceSystemGroup })
//            //            .HasName("ix_2652_2651");

//            //        entity.HasIndex(e => new { e.MarketZoneFrtAdj, e.AltPriceUom, e.QuantityUom, e.ContractNbr })
//            //            .HasName("_dta_index_Contract_19_919674324__K92_K21_K2_51");

//            //        entity.HasIndex(e => new { e.Oid, e.Commodity, e.CommodityId, e.DataSourceSystemGroup })
//            //            .HasName("ix_9_8");

//            //        entity.HasIndex(e => new { e.Oid, e.MarketZone, e.IvPricingPointCode, e.DataSourceSystemGroup })
//            //            .HasName("ix_18_17");

//            //        entity.HasIndex(e => new { e.Oid, e.PlcId, e.Location, e.DataSourceSystemGroup })
//            //            .HasName("ix_6_5");

//            //        entity.HasIndex(e => new { e.Oid, e.PlcId, e.NameAddress, e.VendorCustomerId, e.DataSourceSystemGroup })
//            //            .HasName("ix_1720_1719");

//            //        entity.HasIndex(e => new { e.ContractType1, e.PriceFuture, e.PriceBasis, e.Price, e.MarketMonth, e.ChangeDate, e.MarketZoneFrtAdj, e.AltPriceUom, e.QuantityUom, e.ContractNbr })
//            //            .HasName("_dta_index_Contract_19_919674324__K92_K21_K2_6_22_23_24_25_43_51");

//            //        entity.HasIndex(e => new { e.Oid, e.ContractNbr, e.ContractId, e.ContractType1, e.ContractDate, e.Commodity, e.ContractType, e.ContractStatus, e.NameAddress, e.ContractReference, e.Quantity, e.TransportationMode, e.ShipToId, e.FobPoint, e.Location, e.PlcId })
//            //            .HasName("ix_2011_2010");

//            //        entity.Property(e => e.Oid)
//            //            .HasColumnName("oid")
//            //            .HasDefaultValueSql("newid()");

//            //        entity.Property(e => e.ActivityStatusCode)
//            //            .HasColumnName("activity_status_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.AddBy)
//            //            .IsRequired()
//            //            .HasColumnName("add_by")
//            //            .HasColumnType("varchar(40)");

//            //        entity.Property(e => e.AddDate)
//            //            .HasColumnName("add_date")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.AdditionalContractDesc)
//            //            .HasColumnName("additional_contract_desc")
//            //            .HasColumnType("varchar(250)");

//            //        entity.Property(e => e.AdditionalNote)
//            //            .HasColumnName("additional_note")
//            //            .HasColumnType("varchar(max)");

//            //        entity.Property(e => e.AltBasisPrice)
//            //            .HasColumnName("alt_basis_price")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.AltFuturesPrice)
//            //            .HasColumnName("alt_futures_price")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.AltPrice)
//            //            .HasColumnName("alt_price")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.AltPriceUom)
//            //            .HasColumnName("alt_price_uom")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.AltSalesCarry)
//            //            .HasColumnName("alt_sales_carry")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.AltUnitValue)
//            //            .HasColumnName("alt_unit_value")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.AlternateShipModeCode)
//            //            .HasColumnName("alternate_ship_mode_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.AreaUnitNbr)
//            //            .HasColumnName("area_unit_nbr")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.AreaUomCode)
//            //            .HasColumnName("area_uom_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.BackToBackContractNbr).HasColumnName("back_to_back_contract_nbr");

//            //        entity.Property(e => e.BillToId)
//            //            .HasColumnName("bill_to_id")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.BotUom)
//            //            .HasColumnName("bot_uom")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.BrokerContactId)
//            //            .HasColumnName("broker_contact_id")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.BrokerContract)
//            //            .HasColumnName("broker_contract")
//            //            .HasColumnType("varchar(20)");

//            //        entity.Property(e => e.BrokerCurrencyCode)
//            //            .HasColumnName("broker_currency_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.BrokerId)
//            //            .HasColumnName("broker_id")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.BrokerPaidByStatus)
//            //            .HasColumnName("broker_paid_by_status")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.BrokerRate)
//            //            .HasColumnName("broker_rate")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.BrokerUomCode)
//            //            .HasColumnName("broker_uom_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.BuyExchangeRate)
//            //            .HasColumnName("buy_exchange_rate")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.ChangeBy)
//            //            .IsRequired()
//            //            .HasColumnName("change_by")
//            //            .HasColumnType("varchar(40)");

//            //        entity.Property(e => e.ChangeDate)
//            //            .HasColumnName("change_date")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.CommodityId)
//            //            .IsRequired()
//            //            .HasColumnName("commodity_id")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.CommodityNoteCode).HasColumnName("commodity_note_code");

//            //        entity.Property(e => e.ConfirmPricingFlag)
//            //            .IsRequired()
//            //            .HasColumnName("confirm_pricing_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.ContractDate)
//            //            .HasColumnName("contract_date")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.ContractFormatCode)
//            //            .HasColumnName("contract_format_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.ContractFormatNbr).HasColumnName("contract_format_nbr");

//            //        entity.Property(e => e.ContractId).HasColumnName("contract_id");

//            //        entity.Property(e => e.ContractNbr).HasColumnName("contract_nbr");

//            //        entity.Property(e => e.ContractReference)
//            //            .HasColumnName("contract_reference")
//            //            .HasColumnType("varchar(50)");

//            //        entity.Property(e => e.ContractSchedule)
//            //            .HasColumnName("contract_schedule")
//            //            .HasColumnType("varchar(20)");

//            //        entity.Property(e => e.ContractStatus)
//            //            .HasColumnName("contract_status")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.ContractType1)
//            //            .HasColumnName("contract_type")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.ContractTypeCode).HasColumnType("varchar(10)");

//            //        entity.Property(e => e.CrcData)
//            //            .HasColumnName("crc_data")
//            //            .HasColumnType("varchar(106)");

//            //        entity.Property(e => e.CrossApplicationFlag)
//            //            .IsRequired()
//            //            .HasColumnName("cross_application_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.CurrencyCode)
//            //            .IsRequired()
//            //            .HasColumnName("currency_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.DeductionAdditionAmount)
//            //            .HasColumnName("deduction_addition_amount")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.DeliveryVehicleCode)
//            //            .HasColumnName("delivery_vehicle_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.DpFromDate)
//            //            .HasColumnName("dp_from_date")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.DpPrintedFlag)
//            //            .IsRequired()
//            //            .HasColumnName("dp_printed_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.DpToDate)
//            //            .HasColumnName("dp_to_date")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.ExpediteFlag)
//            //            .IsRequired()
//            //            .HasColumnName("expedite_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.FarmGateDeduction)
//            //            .HasColumnName("farm_gate_deduction")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.FobPoint)
//            //            .HasColumnName("fob_point")
//            //            .HasColumnType("varchar(50)");

//            //        entity.Property(e => e.GlAcctNbr)
//            //            .HasColumnName("gl_acct_nbr")
//            //            .HasColumnType("varchar(75)");

//            //        entity.Property(e => e.Grade)
//            //            .HasColumnName("grade")
//            //            .HasColumnType("varchar(4)");

//            //        entity.Property(e => e.GradeGovernNbr)
//            //            .HasColumnName("grade_govern_nbr")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.GradeGovernStatus)
//            //            .HasColumnName("grade_govern_status")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.HoldAdvanceSettlementFlag)
//            //            .IsRequired()
//            //            .HasColumnName("hold_advance_settlement_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.HoldFlag)
//            //            .IsRequired()
//            //            .HasColumnName("hold_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.InitialPrice)
//            //            .HasColumnName("initial_price")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.IvPricingPointCode)
//            //            .HasColumnName("iv_pricing_point_code")
//            //            .HasColumnType("varchar(20)");

//            //        entity.Property(e => e.LastPrintDate)
//            //            .HasColumnName("last_print_date")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.LoadBasedFlag)
//            //            .IsRequired()
//            //            .HasColumnName("load_based_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.ManualCloseFlag)
//            //            .IsRequired()
//            //            .HasColumnName("manual_close_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.MarketMonth)
//            //            .HasColumnName("market_month")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.MarketZoneFrtAdj).HasColumnName("market_zone_frt_adj");

//            //        entity.Property(e => e.MirrorContractNbr).HasColumnName("mirror_contract_nbr");

//            //        entity.Property(e => e.MiscColumnItemNbr1).HasColumnName("misc_column_item_nbr1");

//            //        entity.Property(e => e.MiscColumnItemNbr2).HasColumnName("misc_column_item_nbr2");

//            //        entity.Property(e => e.MiscColumnItemNbr3).HasColumnName("misc_column_item_nbr3");

//            //        entity.Property(e => e.MiscColumnItemNbr4).HasColumnName("misc_column_item_nbr4");

//            //        entity.Property(e => e.MiscColumnItemNbr5).HasColumnName("misc_column_item_nbr5");

//            //        entity.Property(e => e.MiscColumnItemNbr6).HasColumnName("misc_column_item_nbr6");

//            //        entity.Property(e => e.NumberOfLoads)
//            //            .HasColumnName("number_of_loads")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.OdDescription)
//            //            .HasColumnName("od_description")
//            //            .HasColumnType("varchar(50)");

//            //        entity.Property(e => e.OriginalContractNbr).HasColumnName("original_contract_nbr");

//            //        entity.Property(e => e.OtherExchangeRate)
//            //            .HasColumnName("other_exchange_rate")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.PaidTicketFlag)
//            //            .IsRequired()
//            //            .HasColumnName("paid_ticket_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.PickupFlag)
//            //            .IsRequired()
//            //            .HasColumnName("pickup_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.PlcId)
//            //            .IsRequired()
//            //            .HasColumnName("plc_id")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.Price)
//            //            .HasColumnName("price")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.PriceBasis)
//            //            .HasColumnName("price_basis")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.PriceFuture)
//            //            .HasColumnName("price_future")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.PricingStatus).HasColumnType("varchar(5)");

//            //        entity.Property(e => e.PricingStatusCode)
//            //            .HasColumnName("pricing_status_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.PricingTypeCode)
//            //            .IsRequired()
//            //            .HasColumnName("pricing_type_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.PrintFuturesFlag)
//            //            .IsRequired()
//            //            .HasColumnName("print_futures_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.PrintedFlag)
//            //            .IsRequired()
//            //            .HasColumnName("printed_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.ProductDiscPremDate)
//            //            .HasColumnName("product_disc_prem_date")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.ProductDiscPremDateStatus)
//            //            .IsRequired()
//            //            .HasColumnName("product_disc_prem_date_status")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.ProteinDate)
//            //            .HasColumnName("protein_date")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.ProteinGovernNbr)
//            //            .HasColumnName("protein_govern_nbr")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.ProteinTableNbr).HasColumnName("protein_table_nbr");

//            //        entity.Property(e => e.ProteinType)
//            //            .HasColumnName("protein_type")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.PsNbr).HasColumnName("ps_nbr");

//            //        entity.Property(e => e.QtyPriceConvFactor).HasColumnName("qty_price_conv_factor");

//            //        entity.Property(e => e.Quantity).HasColumnName("quantity");

//            //        entity.Property(e => e.QuantityUom)
//            //            .IsRequired()
//            //            .HasColumnName("quantity_uom")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.ReleasePriceBasis).HasColumnType("numeric");

//            //        entity.Property(e => e.Remarks)
//            //            .HasColumnName("remarks")
//            //            .HasColumnType("varchar(250)");

//            //        entity.Property(e => e.RolledFlag)
//            //            .IsRequired()
//            //            .HasColumnName("rolled_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.RpaFlag)
//            //            .IsRequired()
//            //            .HasColumnName("rpa_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.RpaStatus)
//            //            .IsRequired()
//            //            .HasColumnName("rpa_status")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.SalesCarry)
//            //            .HasColumnName("sales_carry")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.SalesCarryMonth).HasColumnName("sales_carry_month");

//            //        entity.Property(e => e.SalesCarryString)
//            //            .HasColumnName("sales_carry_string")
//            //            .HasColumnType("varchar(18)");

//            //        entity.Property(e => e.SchedShipEndDate)
//            //            .HasColumnName("sched_ship_end_date")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.SchedShipStartDate)
//            //            .HasColumnName("sched_ship_start_date")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.ScheduleCode)
//            //            .HasColumnName("schedule_code")
//            //            .HasColumnType("varchar(20)");

//            //        entity.Property(e => e.ScheduleDate)
//            //            .HasColumnName("schedule_date")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.ScheduleType)
//            //            .HasColumnName("schedule_type")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.SellExchangeRate)
//            //            .HasColumnName("sell_exchange_rate")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.SettleSurplusFlag)
//            //            .IsRequired()
//            //            .HasColumnName("settle_surplus_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.SettlementEligibleFlag)
//            //            .IsRequired()
//            //            .HasColumnName("settlement_eligible_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.SettlementRelationship)
//            //            .HasColumnName("settlement_relationship")
//            //            .HasColumnType("varchar(20)");

//            //        entity.Property(e => e.ShipModeCode)
//            //            .HasColumnName("ship_mode_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.ShipToId)
//            //            .HasColumnName("ship_to_id")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.ShipmentNote)
//            //            .HasColumnName("shipment_note")
//            //            .HasColumnType("varchar(20)");

//            //        entity.Property(e => e.SignedFlag)
//            //            .IsRequired()
//            //            .HasColumnName("signed_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.SpecOrgFlag)
//            //            .IsRequired()
//            //            .HasColumnName("spec_org_flag")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.SpeciesCount).HasColumnName("species_count");

//            //        entity.Property(e => e.SpeciesSerialNbr)
//            //            .HasColumnName("species_serial_nbr")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.Storage)
//            //            .HasColumnName("storage")
//            //            .HasColumnType("varchar(20)");

//            //        entity.Property(e => e.TaxScheduleId).HasColumnName("tax_schedule_id");

//            //        entity.Property(e => e.TermCode)
//            //            .HasColumnName("term_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.ToleranceQuantity).HasColumnName("tolerance_quantity");

//            //        entity.Property(e => e.TradeRuleNbr)
//            //            .HasColumnName("trade_rule_nbr")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.TraderId)
//            //            .IsRequired()
//            //            .HasColumnName("trader_id")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.UnitValue)
//            //            .HasColumnName("unit_value")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.VcContactId)
//            //            .IsRequired()
//            //            .HasColumnName("vc_contact_id")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.VendorCustomerId)
//            //            .IsRequired()
//            //            .HasColumnName("vendor_customer_id")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.WeightGovernNbr)
//            //            .HasColumnName("weight_govern_nbr")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.WeightGovernStatus)
//            //            .HasColumnName("weight_govern_status")
//            //            .HasColumnType("varchar(1)");

//            //        entity.Property(e => e.WorkbackFlag)
//            //            .IsRequired()
//            //            .HasColumnName("workback_flag")
//            //            .HasColumnType("varchar(1)");
//            //    });

//            //    modelBuilder.Entity<Contract3>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Contract");

//            //        entity.ToTable("Contract", "RightAngle");

//            //        entity.HasIndex(e => new { e.DataSet, e.DlHdrIntrnlBaid, e.DlDtlPrdctId })
//            //            .HasName("ix_287_286");

//            //        entity.HasIndex(e => new { e.DlHdrIntrnlNbr, e.DlDtlId, e.Uomabbv, e.DataSet })
//            //            .HasName("RightAngleContract_dltl");

//            //        entity.HasIndex(e => new { e.Oid, e.DataSet, e.DlHdrId, e.DlHdrIntrnlNbr, e.DlHdrExtrnlNbr, e.DlHdrExtrnlBaid, e.DlHdrExtrnlCntctId, e.DlHdrIntrnlBaid, e.DlHdrIntrnlUserId, e.DlHdrStat, e.DlHdrCrtnDte, e.DealDetailId, e.DlDtlId, e.DlDtlQntty, e.DlDtlPrdctId, e.DlDtlMthdTrnsprttn, e.Uomabbv, e.DeliveryTerm, e.RwPrceLcleId, e.CreatedOn, e.UpdatedOn, e.DlDtlSpplyDmnd, e.DlHdrTyp })
//            //            .HasName("ix_16041_16040");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.CreatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.DealDetailId).HasColumnName("DealDetailID");

//            //        entity.Property(e => e.DeliveryTerm).HasMaxLength(40);

//            //        entity.Property(e => e.DlDtlId).HasColumnName("DlDtlID");

//            //        entity.Property(e => e.DlDtlMthdTrnsprttn).HasColumnType("nchar(1)");

//            //        entity.Property(e => e.DlDtlPrdctId).HasColumnName("DlDtlPrdctID");

//            //        entity.Property(e => e.DlDtlSpplyDmnd).HasColumnType("nchar(1)");

//            //        entity.Property(e => e.DlHdrCrtnDte).HasColumnType("smalldatetime");

//            //        entity.Property(e => e.DlHdrExtrnlBaid).HasColumnName("DlHdrExtrnlBAID");

//            //        entity.Property(e => e.DlHdrExtrnlCntctId).HasColumnName("DlHdrExtrnlCntctID");

//            //        entity.Property(e => e.DlHdrExtrnlNbr).HasMaxLength(20);

//            //        entity.Property(e => e.DlHdrId).HasColumnName("DlHdrID");

//            //        entity.Property(e => e.DlHdrIntrnlBaid).HasColumnName("DlHdrIntrnlBAID");

//            //        entity.Property(e => e.DlHdrIntrnlNbr).HasMaxLength(20);

//            //        entity.Property(e => e.DlHdrIntrnlUserId).HasColumnName("DlHdrIntrnlUserID");

//            //        entity.Property(e => e.DlHdrStat).HasColumnType("nchar(1)");

//            //        entity.Property(e => e.RwPrceLcleId).HasColumnName("RwPrceLcleID");

//            //        entity.Property(e => e.Uomabbv)
//            //            .HasColumnName("UOMAbbv")
//            //            .HasMaxLength(20);

//            //        entity.Property(e => e.UpdatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.Contract3)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_Contract_DataSet");
//            //    });

//            //    modelBuilder.Entity<ContractPricingSummary>(entity =>
//            //    {
//            //        entity.HasKey(e => e.SequenceNbr)
//            //            .HasName("PK_ContractPricingSummary");

//            //        entity.ToTable("ContractPricingSummary", "SmartSoft");

//            //        entity.Property(e => e.SequenceNbr)
//            //            .HasColumnName("sequence_nbr")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.AverageBasis)
//            //            .HasColumnName("average_basis")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.AverageFuture)
//            //            .HasColumnName("average_future")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.AveragePrice)
//            //            .HasColumnName("average_price")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.BasisQuantity)
//            //            .HasColumnName("basis_quantity")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.BuyingSellingUomCode)
//            //            .IsRequired()
//            //            .HasColumnName("buying_selling_uom_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.CommodityId)
//            //            .IsRequired()
//            //            .HasColumnName("commodity_id")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.ContractNbr).HasColumnName("contract_nbr");

//            //        entity.Property(e => e.ContractType1)
//            //            .IsRequired()
//            //            .HasColumnName("contract_type")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.CurrencyCode)
//            //            .IsRequired()
//            //            .HasColumnName("currency_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.DeliveryMonth).HasColumnName("delivery_month");

//            //        entity.Property(e => e.DeliveryMonthName)
//            //            .IsRequired()
//            //            .HasColumnName("delivery_month_name")
//            //            .HasColumnType("varchar(20)");

//            //        entity.Property(e => e.DeliveryYear).HasColumnName("delivery_year");

//            //        entity.Property(e => e.Deliveryend)
//            //            .HasColumnName("deliveryend")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.Deliverystart)
//            //            .HasColumnName("deliverystart")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.ExtractionDatetime)
//            //            .HasColumnName("extraction_datetime")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.FuturesOnlyQuantity)
//            //            .HasColumnName("futures_only_quantity")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.MarketMonth)
//            //            .HasColumnName("market_month")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.Optionmonth)
//            //            .HasColumnName("optionmonth")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.PlcId)
//            //            .IsRequired()
//            //            .HasColumnName("plc_id")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.PricedQuantity)
//            //            .HasColumnName("priced_quantity")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.PricingUomCode)
//            //            .IsRequired()
//            //            .HasColumnName("pricing_uom_code")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.Reportdeliverydate)
//            //            .HasColumnName("reportdeliverydate")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.Reportoptionmonth)
//            //            .HasColumnName("reportoptionmonth")
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.TbdQuantity)
//            //            .HasColumnName("tbd_quantity")
//            //            .HasColumnType("numeric");
//            //    });

//            //    modelBuilder.Entity<ContractPricingSummary1>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_ContractPricingSummary_1");

//            //        entity.ToTable("ContractPricingSummary");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Basis).HasColumnType("numeric");

//            //        entity.Property(e => e.BasisQuantity).HasColumnType("numeric");

//            //        entity.Property(e => e.CurrencyCode)
//            //            .IsRequired()
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.Delivery).HasColumnType("varchar(6)");

//            //        entity.Property(e => e.DeliveryEnd).HasColumnType("datetime");

//            //        entity.Property(e => e.DeliveryStart).HasColumnType("datetime");

//            //        entity.Property(e => e.FuturesPrice).HasColumnType("numeric");

//            //        entity.Property(e => e.FuturesQuantity).HasColumnType("numeric");

//            //        entity.Property(e => e.OptionMonth).HasColumnType("varchar(10)");

//            //        entity.Property(e => e.Price).HasColumnType("numeric");

//            //        entity.Property(e => e.PricedQuantity).HasColumnType("numeric");

//            //        entity.Property(e => e.PricingUnitCode)
//            //            .IsRequired()
//            //            .HasColumnType("varchar(10)");

//            //        entity.Property(e => e.PurchaseSalesCode).HasColumnType("varchar(1)");

//            //        entity.Property(e => e.ReportDeliveryDate).HasColumnType("datetime");

//            //        entity.Property(e => e.ReportOptionMonth).HasColumnType("varchar(50)");

//            //        entity.Property(e => e.Tbdquantity)
//            //            .HasColumnName("TBDQuantity")
//            //            .HasColumnType("numeric");

//            //        entity.Property(e => e.Ticker).HasColumnType("varchar(10)");

//            //        entity.Property(e => e.UnitCode)
//            //            .IsRequired()
//            //            .HasColumnType("varchar(10)");
//            //    });

//            //    modelBuilder.Entity<ContractType>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_ContractType_1");

//            //        entity.ToTable("ContractType", "RightAngle");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Code).HasColumnType("char(100)");

//            //        entity.Property(e => e.Description).HasColumnType("char(100)");

//            //        entity.Property(e => e.DlTypId).HasColumnName("DlTypID");

//            //        entity.Property(e => e.LoadDate)
//            //            .HasColumnType("smalldatetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.PriorityLevel).HasMaxLength(100);
//            //    });

//            //    modelBuilder.Entity<ContractType1>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_ContractType");

//            //        entity.ToTable("ContractType");

//            //        entity.HasIndex(e => e.Code)
//            //            .HasName("iContractType_Code");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Code).HasMaxLength(100);

//            //        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.Description).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.PriorityLevel).HasMaxLength(100);

//            //        entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //        entity.HasOne(d => d.DataSourceNavigation)
//            //            .WithMany(p => p.ContractType1)
//            //            .HasForeignKey(d => d.DataSource)
//            //            .HasConstraintName("FK_ContractType_DataSource");
//            //    });

//            //    modelBuilder.Entity<Country>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Country");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Name).HasMaxLength(100);

//            //        entity.Property(e => e.PhoneCode).HasMaxLength(100);
//            //    });

//            //    modelBuilder.Entity<DailyPositionTotal>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DailyPositionTotal");

//            //        entity.HasIndex(e => new { e.Oid, e.LocationCommodity, e.Variety, e.Class, e.InTransitInboundIncrease, e.InTransitOutboundIncrease, e.TerminalStorageIncrease, e.StockIncrease, e.HoldIncrease, e.GrainBankIncrease, e.OpenStorageIncrease, e.CustomerWarehouseReceiptIncrease, e.CompanyWarehouseReceiptIncrease, e.CompanyOwnedPaidIncrease, e.CompanyOwnedUnPaidIncrease, e.DelayedPriceIncrease, e.CashPositionIncrease, e.BasisPositionIncrease, e.InTransitInboundTotal, e.InTransitOutboundTotal, e.TerminalStorageTotal, e.StockAdjustment, e.HoldTotal, e.GrainBankTotal, e.OpenStorageTotal, e.CustomerWarehouseReceiptTotal, e.CompanyWarehouseReceiptTotal, e.CompanyOwnedPaidTotal, e.CompanyOwnedUnPaidTotal, e.DelayedPriceTotal, e.CashPositionTotal, e.BasisPositionTotal, e.PositionDate })
//            //            .HasName("ix_20285_20284");

//            //        entity.HasIndex(e => new { e.Oid, e.Variety, e.Class, e.InTransitInboundIncrease, e.InTransitOutboundIncrease, e.TerminalStorageIncrease, e.StockIncrease, e.HoldIncrease, e.GrainBankIncrease, e.OpenStorageIncrease, e.CustomerWarehouseReceiptIncrease, e.CompanyWarehouseReceiptIncrease, e.CompanyOwnedPaidIncrease, e.CompanyOwnedUnPaidIncrease, e.DelayedPriceIncrease, e.CashPositionIncrease, e.BasisPositionIncrease, e.InTransitInboundTotal, e.InTransitOutboundTotal, e.TerminalStorageTotal, e.StockAdjustment, e.HoldTotal, e.GrainBankTotal, e.OpenStorageTotal, e.CustomerWarehouseReceiptTotal, e.CompanyWarehouseReceiptTotal, e.CompanyOwnedPaidTotal, e.CompanyOwnedUnPaidTotal, e.DelayedPriceTotal, e.CashPositionTotal, e.BasisPositionTotal, e.LocationCommodity, e.PositionDate })
//            //            .HasName("ix_20283_20282");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.BasisPositionIncrease).HasColumnType("decimal");

//            //        entity.Property(e => e.BasisPositionTotal).HasColumnType("decimal");

//            //        entity.Property(e => e.CashPositionIncrease).HasColumnType("decimal");

//            //        entity.Property(e => e.CashPositionTotal).HasColumnType("decimal");

//            //        entity.Property(e => e.Class).HasColumnType("varchar(2)");

//            //        entity.Property(e => e.CompanyOwnedPaidIncrease).HasColumnType("decimal");

//            //        entity.Property(e => e.CompanyOwnedPaidTotal).HasColumnType("decimal");

//            //        entity.Property(e => e.CompanyOwnedUnPaidIncrease).HasColumnType("decimal");

//            //        entity.Property(e => e.CompanyOwnedUnPaidTotal).HasColumnType("decimal");

//            //        entity.Property(e => e.CompanyWarehouseReceiptIncrease).HasColumnType("decimal");

//            //        entity.Property(e => e.CompanyWarehouseReceiptTotal).HasColumnType("decimal");

//            //        entity.Property(e => e.CustomerWarehouseReceiptIncrease).HasColumnType("decimal");

//            //        entity.Property(e => e.CustomerWarehouseReceiptTotal).HasColumnType("decimal");

//            //        entity.Property(e => e.DelayedPriceIncrease).HasColumnType("decimal");

//            //        entity.Property(e => e.DelayedPriceTotal).HasColumnType("decimal");

//            //        entity.Property(e => e.GrainBankIncrease).HasColumnType("decimal");

//            //        entity.Property(e => e.GrainBankTotal).HasColumnType("decimal");

//            //        entity.Property(e => e.HoldIncrease).HasColumnType("decimal");

//            //        entity.Property(e => e.HoldTotal).HasColumnType("decimal");

//            //        entity.Property(e => e.InTransitInboundIncrease).HasColumnType("decimal");

//            //        entity.Property(e => e.InTransitInboundTotal).HasColumnType("decimal");

//            //        entity.Property(e => e.InTransitOutboundIncrease).HasColumnType("decimal");

//            //        entity.Property(e => e.InTransitOutboundTotal).HasColumnType("decimal");

//            //        entity.Property(e => e.OpenStorageIncrease).HasColumnType("decimal");

//            //        entity.Property(e => e.OpenStorageTotal).HasColumnType("decimal");

//            //        entity.Property(e => e.PositionDate).HasColumnType("datetime");

//            //        entity.Property(e => e.StockAdjustment).HasColumnType("decimal");

//            //        entity.Property(e => e.StockIncrease).HasColumnType("decimal");

//            //        entity.Property(e => e.TerminalStorageIncrease).HasColumnType("decimal");

//            //        entity.Property(e => e.TerminalStorageTotal).HasColumnType("decimal");

//            //        entity.Property(e => e.Variety).HasColumnType("varchar(4)");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.DailyPositionTotal)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_DailyPositionTotal_DataSet");

//            //        entity.HasOne(d => d.LocationCommodityNavigation)
//            //            .WithMany(p => p.DailyPositionTotal)
//            //            .HasForeignKey(d => d.LocationCommodity)
//            //            .HasConstraintName("FK_DailyPositionTotal_LocationCommodity");
//            //    });

//            //    modelBuilder.Entity<DataSet>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DataSet");

//            //        entity.HasIndex(e => e.DataSource)
//            //            .HasName("iDataSet_DataSource");

//            //        entity.HasIndex(e => e.Gcrecord)
//            //            .HasName("iGCRecord_DataSet");

//            //        entity.HasIndex(e => e.ReportExtract)
//            //            .HasName("iDataSet_ReportExtract");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.IsActive).HasDefaultValueSql("1");

//            //        entity.Property(e => e.PeriodReportingEnd).HasColumnType("datetime");

//            //        entity.Property(e => e.PeriodReportingStart).HasColumnType("datetime");

//            //        entity.Property(e => e.SourceReportingEnd).HasColumnType("datetime");

//            //        entity.Property(e => e.SourceReportingStart).HasColumnType("datetime");

//            //        entity.HasOne(d => d.DataSourceNavigation)
//            //            .WithMany(p => p.DataSet)
//            //            .HasForeignKey(d => d.DataSource)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_DataSet_DataSource");

//            //        entity.HasOne(d => d.ReportExtractNavigation)
//            //            .WithMany(p => p.DataSet)
//            //            .HasForeignKey(d => d.ReportExtract)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_DataSet_ReportExtract");
//            //    });

//            //    modelBuilder.Entity<DataSource>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DataSource");

//            //        entity.HasIndex(e => e.Code)
//            //            .HasName("iDataSource_Code");

//            //        entity.HasIndex(e => e.CurrentDataSource)
//            //            .HasName("iCurrentDataSource_DataSource");

//            //        entity.HasIndex(e => e.DataSourceSystem)
//            //            .HasName("iDataSource_DataSourceSystem");

//            //        entity.HasIndex(e => e.DataSourceSystemGroup)
//            //            .HasName("iDataSourceSystemGroup_DataSource");

//            //        entity.HasIndex(e => e.DataSourceType)
//            //            .HasName("iDataSourceType_DataSource");

//            //        entity.HasIndex(e => e.Gcrecord)
//            //            .HasName("iGCRecord_DataSource");

//            //        entity.HasIndex(e => new { e.Name, e.Oid })
//            //            .HasName("_dta_index_DataSource_17_383340430__K4_K1");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Code).HasMaxLength(100);

//            //        entity.Property(e => e.CreatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.DatabaseName).HasColumnType("varchar(50)");

//            //        entity.Property(e => e.DbcDatabase).HasColumnType("varchar(100)");

//            //        entity.Property(e => e.DbcServer).HasColumnType("varchar(100)");

//            //        entity.Property(e => e.DefaultDbcSchema).HasColumnType("varchar(50)");

//            //        entity.Property(e => e.Dsnname)
//            //            .HasColumnName("DSNName")
//            //            .HasColumnType("varchar(50)");

//            //        entity.Property(e => e.EndingRange1).HasColumnType("datetime");

//            //        entity.Property(e => e.EndingRange2).HasColumnType("datetime");

//            //        entity.Property(e => e.EndingRange5).HasColumnType("datetime");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.IsReadyToExtract).HasDefaultValueSql("0");

//            //        entity.Property(e => e.IsReadyToLoad).HasDefaultValueSql("0");

//            //        entity.Property(e => e.Name).HasMaxLength(100);

//            //        entity.Property(e => e.StartingRange1).HasColumnType("datetime");

//            //        entity.Property(e => e.StartingRange2).HasColumnType("datetime");

//            //        entity.Property(e => e.StartingRange5).HasColumnType("datetime");

//            //        entity.Property(e => e.UpdatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.HasOne(d => d.CurrentDataSourceNavigation)
//            //            .WithMany(p => p.InverseCurrentDataSourceNavigation)
//            //            .HasForeignKey(d => d.CurrentDataSource)
//            //            .HasConstraintName("FK_DataSource_CurrentDataSource");

//            //        entity.HasOne(d => d.DataSourceStateNavigation)
//            //            .WithMany(p => p.DataSource)
//            //            .HasForeignKey(d => d.DataSourceState)
//            //            .HasConstraintName("FK_DataSource_DataSourceState");

//            //        entity.HasOne(d => d.DataSourceSystemNavigation)
//            //            .WithMany(p => p.DataSource)
//            //            .HasForeignKey(d => d.DataSourceSystem)
//            //            .HasConstraintName("FK_DataSource_DataSourceSystem");

//            //        entity.HasOne(d => d.DataSourceSystemGroupNavigation)
//            //            .WithMany(p => p.DataSource)
//            //            .HasForeignKey(d => d.DataSourceSystemGroup)
//            //            .HasConstraintName("FK_DataSource_DataSourceSystemGroup");

//            //        entity.HasOne(d => d.DataSourceTypeNavigation)
//            //            .WithMany(p => p.DataSource)
//            //            .HasForeignKey(d => d.DataSourceType)
//            //            .HasConstraintName("FK_DataSource_DataSourceType");
//            //    });

//            //    modelBuilder.Entity<DataSourceState>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DataSourceState");

//            //        entity.HasIndex(e => e.Gcrecord)
//            //            .HasName("iGCRecord_DataSourceState");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Description).HasColumnType("varchar(200)");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Name).HasColumnType("varchar(50)");
//            //    });

//            //    modelBuilder.Entity<DataSourceSystem>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DataSourceSystem");

//            //        entity.HasIndex(e => e.Gcrecord)
//            //            .HasName("iGCRecord_DataSourceSystem");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Description).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.SystemName).HasMaxLength(100);
//            //    });

//            //    modelBuilder.Entity<DataSourceSystemGroup>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DataSourceSystemGroup");

//            //        entity.HasIndex(e => e.DataSourceSystem)
//            //            .HasName("iDataSourceSystem_DataSourceSystemGroup");

//            //        entity.HasIndex(e => e.Gcrecord)
//            //            .HasName("iGCRecord_DataSourceSystemGroup");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Description).HasColumnType("varchar(100)");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Name).HasColumnType("varchar(100)");

//            //        entity.HasOne(d => d.DataSourceSystemNavigation)
//            //            .WithMany(p => p.DataSourceSystemGroup)
//            //            .HasForeignKey(d => d.DataSourceSystem)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_DataSourceSystemGroup_DataSourceSystem");
//            //    });

//            //    modelBuilder.Entity<DataSourceType>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DataSourceType");

//            //        entity.HasIndex(e => e.Gcrecord)
//            //            .HasName("iGCRecord_DataSourceType");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Description).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Name).HasMaxLength(100);
//            //    });

//            //    modelBuilder.Entity<DeliverySchedule1>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DeliverySchedule");

//            //        entity.ToTable("DeliverySchedule");

//            //        entity.HasIndex(e => e.DataSet)
//            //            .HasName("ixDeliverySchedule_Dataset");

//            //        entity.HasIndex(e => new { e.Oid, e.DataSet, e.CurrentDeliveryEnd })
//            //            .HasName("ix_38322_38321");

//            //        entity.HasIndex(e => new { e.Oid, e.DataSet, e.DeliveryEnd })
//            //            .HasName("ix_9928_9927");

//            //        entity.HasIndex(e => new { e.Oid, e.DataSet, e.PriorDeliveryEnd })
//            //            .HasName("ix_9932_9931");

//            //        entity.HasIndex(e => new { e.Oid, e.OriginalDeliveryEnd, e.DataSet })
//            //            .HasName("ix_9920_9919");

//            //        entity.HasIndex(e => new { e.Oid, e.OriginalDeliveryEnd, e.CurrentDeliveryEnd, e.DataSet })
//            //            .HasName("ix_6_5");

//            //        entity.HasIndex(e => new { e.Oid, e.OriginalDeliveryEnd, e.PriorDeliveryEnd, e.DataSet })
//            //            .HasName("ix_9922_9921");

//            //        entity.HasIndex(e => new { e.Oid, e.ReportDeliveryDate, e.DataSet, e.DeliveryEnd })
//            //            .HasName("ix_3760_3759");

//            //        entity.HasIndex(e => new { e.Oid, e.ScheduleNumber, e.Location, e.Contract })
//            //            .HasName("ix_9532_9531");

//            //        entity.HasIndex(e => new { e.BoardOfTrade, e.ReportOptionMonthDate, e.Contract, e.Ticker, e.ReportDeliveryDate })
//            //            .HasName("_dta_index_DeliverySchedule_19_646293362__K5_K52_K48_16_47");

//            //        entity.HasIndex(e => new { e.Oid, e.Contract, e.OriginalOptionMonth, e.PriorOptionMonth, e.DataSet })
//            //            .HasName("ix_9938_9937");

//            //        entity.HasIndex(e => new { e.Contract, e.BoardOfTrade, e.PriorOptionMonth, e.DataSet, e.MarketRegion, e.PriorDeliveryEnd })
//            //            .HasName("ix_746_745");

//            //        entity.HasIndex(e => new { e.OptionMonthDate, e.BasisPrice, e.SchedulePrice, e.FuturesPrice, e.PricingDate, e.Contract })
//            //            .HasName("_dta_index_DeliverySchedule_19_646293362__K5_12_18_21_31_43");

//            //        entity.HasIndex(e => new { e.Oid, e.Contract, e.ReportOptionMonth, e.ReportOptionMonthDate, e.DataSet, e.OptionMonthDate, e.OptionMonth })
//            //            .HasName("ix_3764_3763");

//            //        entity.HasIndex(e => new { e.Oid, e.DataSet, e.Contract, e.BoardOfTrade, e.PriorOptionMonth, e.PriorMarketSituation, e.MarketRegion, e.PriorDeliveryEnd })
//            //            .HasName("ix_7438_7437");

//            //        entity.HasIndex(e => new { e.Oid, e.DataSet, e.Contract, e.BoardOfTrade, e.PriorOptionMonth, e.CurrentOptionMonth, e.CurrentMarketSituation, e.MarketRegion, e.CurrentDeliveryEnd })
//            //            .HasName("ix_232_231");

//            //        entity.HasIndex(e => new { e.DataSet, e.Contract, e.DeliveryEnd, e.PriorityLevel, e.BasisPrice, e.SettledUnits, e.AppliedUnits, e.PricingStatus, e.FuturesPrice, e.ScheduledUnits, e.PricingDate, e.MarketSituation })
//            //            .HasName("ix_9946_9945");

//            //        entity.HasIndex(e => new { e.DeliveryStart, e.DeliveryEnd, e.OptionMonthDate, e.BasisPrice, e.MarketSpread, e.SchedulePrice, e.AppliedUnits, e.RemainingUnits, e.FuturesPrice, e.ScheduledUnits, e.PricingDate, e.ReportOptionMonth, e.ReportOptionMonthDate, e.ScheduledPounds, e.AppliedPounds, e.ScheduledBushels, e.AppliedBushels, e.RemainingBushels, e.IsFlatPriced, e.Contract, e.BoardOfTrade, e.MarketRegion, e.DataSet, e.ContractNumber, e.ScheduleNumber, e.ReportDeliveryDate, e.Oid })
//            //            .HasName("_dta_index_DeliverySchedule_26_646293362__K5_K16_K24_K2_K49_K6_K48_K1_9_10_12_18_20_21_26_27_31_40_43_46_47_54_56_58_60_61_71");

//            //        entity.HasIndex(e => new { e.DeliveryStart, e.DeliveryEnd, e.OptionMonthDate, e.BasisPrice, e.MarketSpread, e.SchedulePrice, e.AppliedUnits, e.RemainingUnits, e.FuturesPrice, e.ScheduledUnits, e.PricingDate, e.ReportOptionMonth, e.ReportOptionMonthDate, e.ScheduledPounds, e.AppliedPounds, e.ScheduledBushels, e.AppliedBushels, e.RemainingBushels, e.IsFlatPriced, e.DataSet, e.ScheduleNumber, e.Oid, e.ContractNumber, e.Contract, e.MarketRegion, e.BoardOfTrade, e.ReportDeliveryDate })
//            //            .HasName("_dta_index_DeliverySchedule_17_646293362__K2_K6_K1_K49_K5_K24_K16_K48_9_10_12_18_20_21_26_27_31_40_43_46_47_54_56_58_60_61_71");

//            //        entity.HasIndex(e => new { e.DeliveryStart, e.DeliveryEnd, e.OptionMonthDate, e.BasisPrice, e.MarketSpread, e.SchedulePrice, e.AppliedUnits, e.RemainingUnits, e.FuturesPrice, e.ScheduledUnits, e.PricingDate, e.ReportOptionMonth, e.ReportOptionMonthDate, e.ReportDeliveryDate, e.ScheduledPounds, e.AppliedPounds, e.ScheduledBushels, e.AppliedBushels, e.RemainingBushels, e.IsFlatPriced, e.Contract, e.DataSet, e.ContractNumber, e.ScheduleNumber, e.Location, e.MarketRegion, e.BoardOfTrade, e.Oid })
//            //            .HasName("_dta_index_DeliverySchedule_26_646293362__K5_K2_K49_K6_K7_K24_K16_K1_9_10_12_18_20_21_26_27_31_40_43_46_47_48_54_56_58_60_61_71");

//            //        entity.HasIndex(e => new { e.ScheduleNumber, e.DeliveryStart, e.DeliveryEnd, e.OptionMonthDate, e.BasisPrice, e.MarketSpread, e.SchedulePrice, e.AppliedUnits, e.RemainingUnits, e.FuturesPrice, e.ScheduledUnits, e.PricingDate, e.ReportOptionMonth, e.ReportOptionMonthDate, e.ReportDeliveryDate, e.ScheduledPounds, e.AppliedPounds, e.RemainingPounds, e.ScheduledBushels, e.AppliedBushels, e.RemainingBushels, e.Contract, e.Location, e.Oid, e.MarketRegion, e.BoardOfTrade, e.MarketSituation, e.DataSet })
//            //            .HasName("_dta_index_DeliverySchedule_26_646293362__K5_K7_K1_K24_K16_K62_K2_6_9_10_12_18_20_21_26_27_31_40_43_46_47_48_54_56_57_58_60_61");

//            //        entity.HasIndex(e => new { e.Oid, e.Contract, e.ScheduleNumber, e.AppliedStatus, e.DeliveryStart, e.DeliveryEnd, e.OptionMonth, e.BoardOfTrade, e.PriorityLevel, e.BasisPrice, e.MarketSpread, e.SchedulePrice, e.DestinationLocation, e.MarketRegion, e.SettledUnits, e.AppliedUnits, e.RemainingUnits, e.PricingStatus, e.StateRegion, e.FuturesPrice, e.FreightPrice, e.ShipperId, e.ShipmentDate, e.ScheduledLoads, e.Territory, e.ScheduledUnits, e.AppliedLoads, e.PricingDate, e.MarketSituation, e.PriorMarketSituation, e.DataSet })
//            //            .HasName("ix_10062_10061");

//            //        entity.HasIndex(e => new { e.Oid, e.Contract, e.ScheduleNumber, e.AppliedStatus, e.DeliveryStart, e.DeliveryEnd, e.OptionMonth, e.BoardOfTrade, e.PriorityLevel, e.BasisPrice, e.MarketSpread, e.SchedulePrice, e.DestinationLocation, e.MarketRegion, e.SettledUnits, e.AppliedUnits, e.RemainingUnits, e.PricingStatus, e.StateRegion, e.FuturesPrice, e.FreightPrice, e.ShipperId, e.ShipmentDate, e.ScheduledLoads, e.Territory, e.ScheduledUnits, e.AppliedLoads, e.PricingDate, e.MarketSituation, e.PriorMarketSituation, e.CurrentMarketSituation, e.BasisZone, e.DataSet })
//            //            .HasName("ix_2535_2534");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.AppliedBushels).HasColumnType("decimal");

//            //        entity.Property(e => e.AppliedPounds).HasColumnType("decimal");

//            //        entity.Property(e => e.AppliedStatus).HasMaxLength(100);

//            //        entity.Property(e => e.BrokerReferenceNumber).HasMaxLength(50);

//            //        entity.Property(e => e.ContractNumber).HasMaxLength(100);

//            //        entity.Property(e => e.Country).HasMaxLength(100);

//            //        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.CurrentDeliveryEnd).HasColumnType("datetime");

//            //        entity.Property(e => e.DeliveryEnd).HasColumnType("datetime");

//            //        entity.Property(e => e.DeliveryStart).HasColumnType("datetime");

//            //        entity.Property(e => e.DestinationLocation).HasMaxLength(100);

//            //        entity.Property(e => e.Dtnfuture).HasColumnName("DTNFuture");

//            //        entity.Property(e => e.Exchange).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.HistoryDate).HasColumnType("datetime");

//            //        entity.Property(e => e.MarketSpread).HasColumnType("decimal");

//            //        entity.Property(e => e.OptionMonthCode).HasColumnType("varchar(100)");

//            //        entity.Property(e => e.OptionMonthDate).HasColumnType("datetime");

//            //        entity.Property(e => e.OriginalDeliveryEnd).HasColumnType("datetime");

//            //        entity.Property(e => e.PricingDate).HasColumnType("datetime");

//            //        entity.Property(e => e.PricingStatus).HasMaxLength(100);

//            //        entity.Property(e => e.PriorDeliveryEnd).HasColumnType("datetime");

//            //        entity.Property(e => e.PriorityLevel).HasMaxLength(100);

//            //        entity.Property(e => e.PurchaseSalesCode).HasMaxLength(100);

//            //        entity.Property(e => e.ReleasePriceBasis).HasColumnType("decimal");

//            //        entity.Property(e => e.RemainingBushels).HasColumnType("decimal");

//            //        entity.Property(e => e.RemainingPounds).HasColumnType("decimal");

//            //        entity.Property(e => e.ReportDeliveryDate).HasColumnType("datetime");

//            //        entity.Property(e => e.ReportOptionMonth).HasColumnType("varchar(100)");

//            //        entity.Property(e => e.ReportOptionMonthDate).HasColumnType("datetime");

//            //        entity.Property(e => e.RolledDeliveryEnd).HasColumnType("datetime");

//            //        entity.Property(e => e.SalesPerson).HasMaxLength(100);

//            //        entity.Property(e => e.ScheduleNumber).HasMaxLength(100);

//            //        entity.Property(e => e.ScheduledBushels).HasColumnType("decimal");

//            //        entity.Property(e => e.ScheduledPounds).HasColumnType("decimal");

//            //        entity.Property(e => e.SettledBushels).HasColumnType("decimal");

//            //        entity.Property(e => e.SettledPounds).HasColumnType("decimal");

//            //        entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

//            //        entity.Property(e => e.ShipperId).HasMaxLength(100);

//            //        entity.Property(e => e.StateCode).HasMaxLength(50);

//            //        entity.Property(e => e.Territory).HasMaxLength(100);

//            //        entity.Property(e => e.Ticker).HasColumnType("varchar(50)");

//            //        entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.VehicleType).HasColumnType("varchar(100)");

//            //        entity.HasOne(d => d.BasisZoneNavigation)
//            //            .WithMany(p => p.DeliverySchedule1)
//            //            .HasForeignKey(d => d.BasisZone)
//            //            .HasConstraintName("FK_DeliverySchedule_BasisZone");

//            //        entity.HasOne(d => d.LocationNavigation)
//            //            .WithMany(p => p.DeliverySchedule1)
//            //            .HasForeignKey(d => d.Location)
//            //            .HasConstraintName("FK_DeliverySchedule_Location");

//            //        entity.HasOne(d => d.OptionMonthNavigation)
//            //            .WithMany(p => p.DeliverySchedule1)
//            //            .HasForeignKey(d => d.OptionMonth)
//            //            .HasConstraintName("FK_DeliverySchedule_OptionMonth");
//            //    });

//            //    modelBuilder.Entity<DeliverySchedule2>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DeliverySchedule");

//            //        entity.ToTable("DeliverySchedule", "RightAngle");

//            //        entity.HasIndex(e => new { e.DlHdrId, e.DlHdrIntrnlNbr, e.DlDtlId, e.ObId, e.DataSet })
//            //            .HasName("_dta_index_DeliverySchedule_26_1809493575__K2_3_4_6_13");

//            //        entity.HasIndex(e => new { e.CurveName, e.RwPrceLcleId, e.DlHdrTyp, e.DlHdrId, e.DlDtlId, e.ObId, e.RphdrId, e.DataSet, e.DlHdrIntrnlNbr })
//            //            .HasName("_dta_index_DeliverySchedule_26_1809493575__K20_K19_K5_K3_K6_K13_K18_K2_K4");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.ContractType).HasMaxLength(50);

//            //        entity.Property(e => e.CreatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.CurveName).HasMaxLength(100);

//            //        entity.Property(e => e.DestinationLcleId).HasColumnName("DestinationLcleID");

//            //        entity.Property(e => e.DlDtlId).HasColumnName("DlDtlID");

//            //        entity.Property(e => e.DlDtlLcleId).HasColumnName("DlDtlLcleID");

//            //        entity.Property(e => e.DlDtlSpplyDmnd).HasColumnType("nchar(1)");

//            //        entity.Property(e => e.DlDtlTmplteId).HasColumnName("DlDtlTmplteID");

//            //        entity.Property(e => e.DlDtlTpe).HasColumnType("nchar(1)");

//            //        entity.Property(e => e.DlHdrId).HasColumnName("DlHdrID");

//            //        entity.Property(e => e.DlHdrIntrnlNbr).HasMaxLength(20);

//            //        entity.Property(e => e.ObFrmDte).HasColumnType("smalldatetime");

//            //        entity.Property(e => e.ObId).HasColumnName("ObID");

//            //        entity.Property(e => e.ObStts).HasColumnType("nchar(1)");

//            //        entity.Property(e => e.ObToDte).HasColumnType("smalldatetime");

//            //        entity.Property(e => e.OriginLcleId).HasColumnName("OriginLcleID");

//            //        entity.Property(e => e.PrvsnId).HasColumnName("PrvsnID");

//            //        entity.Property(e => e.RphdrId).HasColumnName("RPHdrID");

//            //        entity.Property(e => e.RwPrceLcleId).HasColumnName("RwPrceLcleID");

//            //        entity.Property(e => e.UpdatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.DeliverySchedule2)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_DeliverySchedule_DataSet");
//            //    });

//            //    modelBuilder.Entity<DiscountCode>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DiscountCode");

//            //        entity.HasIndex(e => e.DataSource)
//            //            .HasName("iDataSource_DiscountCode");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.AdvanceOnSettlement).HasMaxLength(100);

//            //        entity.Property(e => e.Code).HasMaxLength(100);

//            //        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.Description).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.IsByCommodity).HasMaxLength(100);

//            //        entity.Property(e => e.IsByLocation).HasMaxLength(100);

//            //        entity.Property(e => e.IsByState).HasMaxLength(100);

//            //        entity.Property(e => e.IsIncludedInValue).HasMaxLength(100);

//            //        entity.Property(e => e.IsRecalculatedFromStart).HasMaxLength(100);

//            //        entity.Property(e => e.IsTaxable).HasMaxLength(100);

//            //        entity.Property(e => e.RecordType).HasMaxLength(100);

//            //        entity.Property(e => e.SettlementPriorityGroup).HasMaxLength(100);

//            //        entity.Property(e => e.SettlementSequence).HasMaxLength(100);

//            //        entity.Property(e => e.TaxableField1).HasMaxLength(100);

//            //        entity.Property(e => e.TaxableField3).HasMaxLength(100);

//            //        entity.Property(e => e.TaxableField4).HasMaxLength(100);

//            //        entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //        entity.HasOne(d => d.DataSourceNavigation)
//            //            .WithMany(p => p.DiscountCode)
//            //            .HasForeignKey(d => d.DataSource)
//            //            .HasConstraintName("FK_DiscountCode_DataSource");

//            //        entity.HasOne(d => d.DiscountCodeTypeNavigation)
//            //            .WithMany(p => p.DiscountCode)
//            //            .HasForeignKey(d => d.DiscountCodeType)
//            //            .HasConstraintName("FK_DiscountCode_DiscountCodeType");
//            //    });

//            //    modelBuilder.Entity<DiscountCodeType>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DiscountCodeType");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.IsFreightCode).HasDefaultValueSql("0");

//            //        entity.Property(e => e.Name).HasColumnType("varchar(100)");
//            //    });

//            //    modelBuilder.Entity<DiscountEvent>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DiscountEvent");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Code).HasMaxLength(50);

//            //        entity.Property(e => e.Name).HasMaxLength(100);
//            //    });

//            //    modelBuilder.Entity<DiscountPremium>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DiscountPremium");

//            //        entity.HasIndex(e => new { e.Oid, e.LocationCommodity, e.DiscountCode, e.DiscountEvent, e.Description, e.Amount, e.DataSet })
//            //            .HasName("ix_2918_2917");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Amount).HasColumnType("decimal");

//            //        entity.Property(e => e.Description).HasMaxLength(150);

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.DiscountPremium)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_DiscountPremium_DataSet");

//            //        entity.HasOne(d => d.DiscountCodeNavigation)
//            //            .WithMany(p => p.DiscountPremium)
//            //            .HasForeignKey(d => d.DiscountCode)
//            //            .HasConstraintName("FK_DiscountPremium_DiscountCode");

//            //        entity.HasOne(d => d.DiscountEventNavigation)
//            //            .WithMany(p => p.DiscountPremium)
//            //            .HasForeignKey(d => d.DiscountEvent)
//            //            .HasConstraintName("FK_DiscountPremium_DiscountEvent");

//            //        entity.HasOne(d => d.LocationCommodityNavigation)
//            //            .WithMany(p => p.DiscountPremium)
//            //            .HasForeignKey(d => d.LocationCommodity)
//            //            .HasConstraintName("FK_DiscountPremium_LocationCommodity");
//            //    });

//            //    modelBuilder.Entity<Dtnfeed>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DTNFeed");

//            //        entity.ToTable("DTNFeed");

//            //        entity.HasIndex(e => e.Gcrecord)
//            //            .HasName("iGCRecord_DTNFeed");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.FeedName).HasMaxLength(100);

//            //        entity.Property(e => e.FuturesMonths).HasColumnType("char(12)");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Id)
//            //            .HasColumnName("ID")
//            //            .HasMaxLength(100);

//            //        entity.Property(e => e.IsHedgeable).HasDefaultValueSql("1");

//            //        entity.Property(e => e.Market).HasMaxLength(100);

//            //        entity.Property(e => e.Password).HasMaxLength(100);

//            //        entity.Property(e => e.PricingConversionFactor).HasColumnType("decimal");

//            //        entity.Property(e => e.Symbol).HasMaxLength(100);

//            //        entity.Property(e => e.TickerMultiplier)
//            //            .HasColumnType("decimal")
//            //            .HasDefaultValueSql("1");

//            //        entity.Property(e => e.TradePoundsPerUnit).HasColumnType("decimal");

//            //        entity.Property(e => e.Username).HasMaxLength(100);

//            //        entity.Property(e => e.WebServiceUrl).HasMaxLength(100);
//            //    });

//            //    modelBuilder.Entity<Dtnfuture>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DTNFuture");

//            //        entity.ToTable("DTNFuture");

//            //        entity.HasIndex(e => e.Dtnhistory)
//            //            .HasName("iDTNHistory_DTNFuture");

//            //        entity.HasIndex(e => new { e.Close, e.Dtnhistory, e.Ticker })
//            //            .HasName("_dta_index_DTNFuture_26_85575343__K14_K2_8");

//            //        entity.HasIndex(e => new { e.Close, e.Ticker, e.Dtnhistory })
//            //            .HasName("_dta_index_DTNFuture_19_85575343__K2_K14_8");

//            //        entity.HasIndex(e => new { e.Oid, e.Ticker, e.Vendor, e.Market, e.Status, e.Fraction, e.Description, e.Close, e.Open, e.High, e.Low, e.Volume, e.Oi, e.OptimisticLockField, e.Gcrecord, e.Dtnhistory })
//            //            .HasName("ix_7383_7382");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Close).HasColumnType("money");

//            //        entity.Property(e => e.Description).HasMaxLength(100);

//            //        entity.Property(e => e.Dtnhistory).HasColumnName("DTNHistory");

//            //        entity.Property(e => e.Fraction).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.High).HasColumnType("money");

//            //        entity.Property(e => e.Low).HasColumnType("money");

//            //        entity.Property(e => e.Market).HasMaxLength(100);

//            //        entity.Property(e => e.Oi)
//            //            .HasColumnName("OI")
//            //            .HasMaxLength(100);

//            //        entity.Property(e => e.Open).HasColumnType("money");

//            //        entity.Property(e => e.Status).HasMaxLength(100);

//            //        entity.Property(e => e.Ticker).HasMaxLength(100);

//            //        entity.Property(e => e.Vendor).HasMaxLength(100);

//            //        entity.Property(e => e.Volume).HasColumnType("money");

//            //        entity.HasOne(d => d.DtnhistoryNavigation)
//            //            .WithMany(p => p.Dtnfuture)
//            //            .HasForeignKey(d => d.Dtnhistory)
//            //            .HasConstraintName("FK_DTNFuture_DTNHistory");
//            //    });

//            //    modelBuilder.Entity<Dtnhistory>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_DTNHistory");

//            //        entity.ToTable("DTNHistory");

//            //        entity.HasIndex(e => new { e.HistoryDate, e.Oid })
//            //            .HasName("IX_HistoryDate_OID");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Dtnfeed).HasColumnName("DTNFeed");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.HistoryDate).HasColumnType("datetime");

//            //        entity.HasOne(d => d.DtnfeedNavigation)
//            //            .WithMany(p => p.Dtnhistory)
//            //            .HasForeignKey(d => d.Dtnfeed)
//            //            .HasConstraintName("FK_DTNHistory_DTNFeed");
//            //    });

//            //    modelBuilder.Entity<Event>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Event");

//            //        entity.HasIndex(e => e.EndOn)
//            //            .HasName("iEndOn_Event");

//            //        entity.HasIndex(e => e.RecurrencePattern)
//            //            .HasName("iRecurrencePattern_Event");

//            //        entity.HasIndex(e => e.StartOn)
//            //            .HasName("iStartOn_Event");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.EndOn).HasColumnType("datetime");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Location).HasMaxLength(100);

//            //        entity.Property(e => e.StartOn).HasColumnType("datetime");

//            //        entity.Property(e => e.Subject).HasMaxLength(250);

//            //        entity.HasOne(d => d.RecurrencePatternNavigation)
//            //            .WithMany(p => p.InverseRecurrencePatternNavigation)
//            //            .HasForeignKey(d => d.RecurrencePattern)
//            //            .HasConstraintName("FK_Event_RecurrencePattern");
//            //    });

//            //    modelBuilder.Entity<ExportCatalog>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_ExportCatalog");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.CreatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.ExportFile).HasMaxLength(50);

//            //        entity.Property(e => e.ExportPath).HasMaxLength(260);

//            //        entity.Property(e => e.ExtractDate).HasColumnType("datetime");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.ExportCatalog)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_ExportCatalog_DataSet");
//            //    });

//            //    modelBuilder.Entity<FileData>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_FileData");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.FileName).HasMaxLength(260);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Size).HasColumnName("size");
//            //    });

//            //    modelBuilder.Entity<GeneralLedgerDetail>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_GeneralLedgerDetail");

//            //        entity.HasIndex(e => e.Location)
//            //            .HasName("iLocation_GeneralLedgerDetail");

//            //        entity.HasIndex(e => e.NameAddress)
//            //            .HasName("iNameAddress_GeneralLedgerDetail");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Amount).HasColumnType("money");

//            //        entity.Property(e => e.AmountApplied).HasColumnType("money");

//            //        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.Description).HasMaxLength(100);

//            //        entity.Property(e => e.DocumentType).HasMaxLength(100);

//            //        entity.Property(e => e.DueDate).HasColumnType("datetime");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

//            //        entity.Property(e => e.Number).HasMaxLength(100);

//            //        entity.Property(e => e.ShipDate).HasColumnType("datetime");

//            //        entity.Property(e => e.Status).HasMaxLength(100);

//            //        entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //        entity.HasOne(d => d.LocationNavigation)
//            //            .WithMany(p => p.GeneralLedgerDetail)
//            //            .HasForeignKey(d => d.Location)
//            //            .HasConstraintName("FK_GeneralLedgerDetail_Location");

//            //        entity.HasOne(d => d.NameAddressNavigation)
//            //            .WithMany(p => p.GeneralLedgerDetail)
//            //            .HasForeignKey(d => d.NameAddress)
//            //            .HasConstraintName("FK_GeneralLedgerDetail_NameAddress");
//            //    });

//            //    modelBuilder.Entity<Hcategory>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_HCategory");

//            //        entity.ToTable("HCategory");

//            //        entity.HasIndex(e => e.Parent)
//            //            .HasName("iParent_HCategory");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Name).HasMaxLength(100);

//            //        entity.HasOne(d => d.ParentNavigation)
//            //            .WithMany(p => p.InverseParentNavigation)
//            //            .HasForeignKey(d => d.Parent)
//            //            .HasConstraintName("FK_HCategory_Parent");
//            //    });

//            //    modelBuilder.Entity<IdgeneratorTable>(entity =>
//            //    {
//            //        entity.ToTable("IDGeneratorTable");

//            //        entity.Property(e => e.Id)
//            //            .HasColumnName("ID")
//            //            .HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Prefix).HasMaxLength(100);

//            //        entity.Property(e => e.Type).HasMaxLength(254);
//            //    });

//            //    modelBuilder.Entity<JobArea>(entity =>
//            //    {
//            //        entity.Property(e => e.JobAreaId).ValueGeneratedNever();

//            //        entity.Property(e => e.Description)
//            //            .IsRequired()
//            //            .HasColumnType("varchar(80)");
//            //    });

//            //    modelBuilder.Entity<JobHistory>(entity =>
//            //    {
//            //        entity.HasIndex(e => new { e.Timestamp, e.ReportExtract, e.JobAreaId })
//            //            .HasName("ix_9926_9925");

//            //        entity.Property(e => e.ErrMsg).HasMaxLength(2048);

//            //        entity.Property(e => e.ReportExtract).HasDefaultValueSql("[dbo].[GetCurrentReportExtract]()");

//            //        entity.Property(e => e.StatusMsg).HasColumnType("varchar(1024)");

//            //        entity.Property(e => e.Timestamp)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");
//            //    });

//            //    modelBuilder.Entity<Locale>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Locale");

//            //        entity.ToTable("Locale", "RightAngle");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.LcleId).HasColumnName("LcleID");

//            //        entity.Property(e => e.LcleTpeDscrptn).HasMaxLength(80);

//            //        entity.Property(e => e.LoadDate)
//            //            .HasColumnType("smalldatetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.LongName).HasMaxLength(100);

//            //        entity.Property(e => e.ShortName).HasMaxLength(100);

//            //        entity.HasOne(d => d.DataSourceNavigation)
//            //            .WithMany(p => p.Locale)
//            //            .HasForeignKey(d => d.DataSource)
//            //            .HasConstraintName("FK_Locale_DataSource");
//            //    });

//            //    modelBuilder.Entity<Location>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Location");

//            //        entity.HasIndex(e => e.Code)
//            //            .HasName("iLocation_Code");

//            //        entity.HasIndex(e => e.DataSource)
//            //            .HasName("iDataSource_Location");

//            //        entity.HasIndex(e => e.ReportingLocation)
//            //            .HasName("iReportingLocation_Location");

//            //        entity.HasIndex(e => new { e.Code, e.Oid, e.DataSource })
//            //            .HasName("_dta_index_Location_17_1280723615__K1_K16_4");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Address1).HasMaxLength(100);

//            //        entity.Property(e => e.Address2).HasMaxLength(100);

//            //        entity.Property(e => e.Code).HasMaxLength(100);

//            //        entity.Property(e => e.Country).HasMaxLength(100);

//            //        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.Description).HasMaxLength(100);

//            //        entity.Property(e => e.Fax).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.LookupCode).HasColumnType("varchar(50)");

//            //        entity.Property(e => e.OverrideInventoryCode).HasMaxLength(50);

//            //        entity.Property(e => e.PhoneNumber).HasMaxLength(100);

//            //        entity.Property(e => e.Remarks1).HasMaxLength(100);

//            //        entity.Property(e => e.Remarks2).HasMaxLength(100);

//            //        entity.Property(e => e.State).HasMaxLength(50);

//            //        entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //        entity.HasOne(d => d.DataSourceNavigation)
//            //            .WithMany(p => p.Location)
//            //            .HasForeignKey(d => d.DataSource)
//            //            .HasConstraintName("FK_Location_DataSource");

//            //        entity.HasOne(d => d.ReportingLocationNavigation)
//            //            .WithMany(p => p.InverseReportingLocationNavigation)
//            //            .HasForeignKey(d => d.ReportingLocation)
//            //            .HasConstraintName("FK_Location_Location1");
//            //    });

//            //    modelBuilder.Entity<LocationCommodity>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_LocationCommodity");

//            //        entity.HasIndex(e => e.Commodity)
//            //            .HasName("iCommodity_LocationCommodity");

//            //        entity.HasIndex(e => e.Location)
//            //            .HasName("iLocation_LocationCommodity");

//            //        entity.HasIndex(e => new { e.FuturesConversionFactor, e.Commodity, e.Location })
//            //            .HasName("_dta_index_LocationCommodity_26_198291766__K3_K2_16");

//            //        entity.HasIndex(e => new { e.FuturesConversionFactor, e.Location, e.Commodity })
//            //            .HasName("_dta_index_LocationCommodity_26_198291766__K2_K3_16");

//            //        entity.HasIndex(e => new { e.Oid, e.Location, e.Commodity })
//            //            .HasName("_dta_index_LocationCommodity_26_198291766__K1_K2_K3");

//            //        entity.HasIndex(e => new { e.FuturesConversionFactor, e.DataSourceSystemGroup, e.Commodity, e.Location })
//            //            .HasName("_dta_index_LocationCommodity_26_198291766__K17_K3_K2_16");

//            //        entity.HasIndex(e => new { e.FuturesConversionFactor, e.Location, e.Commodity, e.Oid, e.DataSourceSystemGroup, e.TradePoundsPerUnit, e.PositionPoundsPerUnit })
//            //            .HasName("_dta_index_LocationCommodity_26_198291766__K2_K3_K1_K17_K10_K12_16");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.DefaultBoard).HasMaxLength(100);

//            //        entity.Property(e => e.FuturesConversionFactor).HasColumnType("decimal");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.LedgerUnitOfMeasure).HasMaxLength(100);

//            //        entity.Property(e => e.PositionUnitOfMeasure).HasMaxLength(100);

//            //        entity.Property(e => e.TradeUnitOfMeasure).HasMaxLength(100);

//            //        entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //        entity.HasOne(d => d.CommodityNavigation)
//            //            .WithMany(p => p.LocationCommodity)
//            //            .HasForeignKey(d => d.Commodity)
//            //            .HasConstraintName("FK_LocationCommodity_Commodity");

//            //        entity.HasOne(d => d.DataSourceSystemGroupNavigation)
//            //            .WithMany(p => p.LocationCommodity)
//            //            .HasForeignKey(d => d.DataSourceSystemGroup)
//            //            .HasConstraintName("FK_LocationCommodity_DataSourceSystemGroup");

//            //        entity.HasOne(d => d.LocationNavigation)
//            //            .WithMany(p => p.LocationCommodity)
//            //            .HasForeignKey(d => d.Location)
//            //            .HasConstraintName("FK_LocationCommodity_Location");
//            //    });

//            //    modelBuilder.Entity<MarketBasisPrice>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_MarketBasisPrice_2");

//            //        entity.ToTable("MarketBasisPrice", "RightAngle");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Basis).HasColumnType("decimal");

//            //        entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

//            //        entity.Property(e => e.LoadDate).HasColumnType("smalldatetime");

//            //        entity.Property(e => e.OptionMonth).HasColumnType("varchar(10)");

//            //        entity.Property(e => e.Product).HasColumnType("varchar(30)");

//            //        entity.Property(e => e.ProductLocaleId).HasColumnName("ProductLocaleID");

//            //        entity.Property(e => e.Protien).HasColumnType("varchar(10)");

//            //        entity.Property(e => e.RiskCurveId).HasColumnName("RiskCurveID");
//            //    });

//            //    modelBuilder.Entity<MarketBasisPrice2>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_MarketBasisPrice");

//            //        entity.ToTable("MarketBasisPrice", "LTAS");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Basis).HasColumnType("numeric");

//            //        entity.Property(e => e.CommodityCode).HasColumnType("char(2)");

//            //        entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

//            //        entity.Property(e => e.LocationCode).HasColumnType("varchar(5)");

//            //        entity.Property(e => e.MarketZoneCode).HasColumnType("char(3)");

//            //        entity.Property(e => e.OptionMonthSort).HasColumnType("varchar(10)");

//            //        entity.Property(e => e.Protein).HasColumnType("char(3)");

//            //        entity.Property(e => e.TradingBoard).HasColumnType("varchar(50)");
//            //    });

//            //    modelBuilder.Entity<MarketBasisPrice3>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_MarketBasisPrice_1");

//            //        entity.ToTable("MarketBasisPrice");

//            //        entity.HasIndex(e => new { e.Oid, e.Location })
//            //            .HasName("ix_2877_2876");

//            //        entity.HasIndex(e => new { e.Basis, e.Location, e.Commodity, e.DeliveryDate })
//            //            .HasName("ix_160804_160803");

//            //        entity.HasIndex(e => new { e.Commodity, e.OptionMonth, e.MarketZone, e.DeliveryDate, e.Location })
//            //            .HasName("ix_2879_2878");

//            //        entity.HasIndex(e => new { e.Basis, e.Location, e.CreatedOn, e.MarketZone, e.Commodity, e.Exchange, e.DeliveryDate })
//            //            .HasName("_dta_index_MarketBasisPrice_26_1533248517__K3_K11_K8_K4_K7_K9_2");

//            //        entity.HasIndex(e => new { e.Basis, e.MarketZone, e.Location, e.Commodity, e.Exchange, e.DeliveryDate, e.CreatedOn })
//            //            .HasName("_dta_index_MarketBasisPrice_26_1533248517__K8_K3_K4_K7_K9_K11_2");

//            //        entity.HasIndex(e => new { e.Basis, e.Commodity, e.OptionMonth, e.Exchange, e.MarketZone, e.DeliveryDate, e.Protein, e.Location })
//            //            .HasName("ix_2881_2880");

//            //        entity.HasIndex(e => new { e.Basis, e.CreatedOn, e.MarketZone, e.Location, e.Commodity, e.DeliveryDate, e.Oid, e.Exchange })
//            //            .HasName("_dta_index_MarketBasisPrice_26_1533248517__K11_K8_K3_K4_K9_K1_K7_2");

//            //        entity.HasIndex(e => new { e.Basis, e.MarketZone, e.Location, e.Commodity, e.DeliveryDate, e.Oid, e.OptionMonth, e.Exchange })
//            //            .HasName("_dta_index_MarketBasisPrice_26_1533248517__K8_K3_K4_K9_K1_K5_K7_2");

//            //        entity.HasIndex(e => new { e.Oid, e.Basis, e.Location, e.Commodity, e.Exchange, e.MarketZone, e.DeliveryDate, e.OptionMonthId })
//            //            .HasName("ix_187715_187714");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Basis).HasColumnType("numeric");

//            //        entity.Property(e => e.ContractNumber).HasColumnType("varchar(50)");

//            //        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.IsCurrent).HasDefaultValueSql("1");

//            //        entity.Property(e => e.OptionMonth).HasColumnType("varchar(10)");

//            //        entity.Property(e => e.OptionMonthId).HasColumnName("OptionMonthID");

//            //        entity.Property(e => e.Protein).HasColumnType("varchar(10)");

//            //        entity.Property(e => e.UnitOfMeasureCode).HasColumnType("varchar(50)");

//            //        entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
//            //    });

//            //    modelBuilder.Entity<MarketSituation>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_MarketSituation");

//            //        entity.HasIndex(e => new { e.Oid, e.OptionMonth })
//            //            .HasName("_dta_index_MarketSituation_26_1081770911__K1_K7");

//            //        entity.HasIndex(e => new { e.Oid, e.Commodity, e.DeliveryDate })
//            //            .HasName("ix_160802_160801");

//            //        entity.HasIndex(e => new { e.Oid, e.StateRegion, e.DeliveryDate, e.BoardOfTrade, e.OptionMonth, e.LocationCommodity })
//            //            .HasName("ix_9959_9958");

//            //        entity.HasIndex(e => new { e.Oid, e.Location, e.Commodity, e.BoardOfTrade, e.OptionMonth, e.StateRegion, e.DeliveryDate })
//            //            .HasName("ix_106_105");

//            //        entity.HasIndex(e => new { e.Oid, e.Location, e.Commodity, e.StateRegion, e.DeliveryDate, e.BoardOfTrade, e.OptionMonth, e.CreatedOn, e.UpdatedOn, e.LocationCommodity })
//            //            .HasName("ix_1929_1928");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.CreatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

//            //        entity.Property(e => e.IsFromLtas).HasColumnName("IsFromLTAS");

//            //        entity.Property(e => e.UpdatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.HasOne(d => d.BoardOfTradeNavigation)
//            //            .WithMany(p => p.MarketSituation)
//            //            .HasForeignKey(d => d.BoardOfTrade)
//            //            .HasConstraintName("FK_MarketSituation_BoardOfTrade");

//            //        entity.HasOne(d => d.CommodityNavigation)
//            //            .WithMany(p => p.MarketSituation)
//            //            .HasForeignKey(d => d.Commodity)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_MarketSituation_Commodity");

//            //        entity.HasOne(d => d.LocationNavigation)
//            //            .WithMany(p => p.MarketSituation)
//            //            .HasForeignKey(d => d.Location)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_MarketSituation_Location");

//            //        entity.HasOne(d => d.LocationCommodityNavigation)
//            //            .WithMany(p => p.MarketSituation)
//            //            .HasForeignKey(d => d.LocationCommodity)
//            //            .HasConstraintName("FK_MarketSituation_LocationCommodity");

//            //        entity.HasOne(d => d.OptionMonthNavigation)
//            //            .WithMany(p => p.MarketSituation)
//            //            .HasForeignKey(d => d.OptionMonth)
//            //            .HasConstraintName("FK_MarketSituation_OptionMonth");

//            //        entity.HasOne(d => d.StateRegionNavigation)
//            //            .WithMany(p => p.MarketSituation)
//            //            .HasForeignKey(d => d.StateRegion)
//            //            .HasConstraintName("FK_MarketSituation_StateRegion");
//            //    });

//            //    modelBuilder.Entity<MarketZone>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_MarketZone");

//            //        entity.HasIndex(e => e.DataSet)
//            //            .HasName("iDataSource_MarketZone");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Code).HasMaxLength(100);

//            //        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.Description).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.RecordType).HasMaxLength(100);

//            //        entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.MarketZone)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_MarketZone_DataSource");
//            //    });

//            //    modelBuilder.Entity<ModuleInfo>(entity =>
//            //    {
//            //        entity.Property(e => e.Id).HasColumnName("ID");

//            //        entity.Property(e => e.AssemblyFileName).HasMaxLength(100);

//            //        entity.Property(e => e.Name).HasMaxLength(100);

//            //        entity.Property(e => e.Version).HasMaxLength(100);
//            //    });

//            //    modelBuilder.Entity<NameAddress>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_NameAddress");

//            //        entity.ToTable("NameAddress", "RightAngle");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.AddrssCntry).HasMaxLength(50);

//            //        entity.Property(e => e.AddrssCty).HasMaxLength(50);

//            //        entity.Property(e => e.AddrssLne1).HasMaxLength(50);

//            //        entity.Property(e => e.AddrssLne2).HasMaxLength(50);

//            //        entity.Property(e => e.AddrssPstlCde).HasMaxLength(20);

//            //        entity.Property(e => e.AddrssStte).HasMaxLength(50);

//            //        entity.Property(e => e.Baid).HasColumnName("BAID");

//            //        entity.Property(e => e.Banme)
//            //            .HasColumnName("BANme")
//            //            .HasMaxLength(50);

//            //        entity.Property(e => e.Batpe)
//            //            .HasColumnName("BATpe")
//            //            .HasColumnType("nchar(1)");

//            //        entity.Property(e => e.CreatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.OffceLcleId).HasColumnName("OffceLcleID");

//            //        entity.Property(e => e.OffceVcePhne).HasMaxLength(25);

//            //        entity.Property(e => e.UpdatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.HasOne(d => d.DataSourceNavigation)
//            //            .WithMany(p => p.NameAddress)
//            //            .HasForeignKey(d => d.DataSource)
//            //            .HasConstraintName("FK_NameAddress_DataSource");
//            //    });

//            //    modelBuilder.Entity<NameAddress1>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_NameAddress");

//            //        entity.ToTable("NameAddress");

//            //        entity.HasIndex(e => new { e.Oid, e.NameId })
//            //            .HasName("ix_10045_10044");

//            //        entity.HasIndex(e => new { e.DataSource, e.NameId, e.Oid })
//            //            .HasName("_dta_index_NameAddress_11_2041774331__K2_K18_K1");

//            //        entity.HasIndex(e => new { e.Description, e.NameDescription, e.Oid, e.NameId })
//            //            .HasName("_dta_index_NameAddress_26_2041774331__K1_K18_4_13");

//            //        entity.HasIndex(e => new { e.Description, e.NameDescription, e.Oid, e.NameId, e.NameIdtype })
//            //            .HasName("_dta_index_NameAddress_26_2041774331__K1_K18_K6_4_13");

//            //        entity.HasIndex(e => new { e.Oid, e.Address1, e.Description, e.NameIdtype, e.AccountTemp, e.Country, e.Address2, e.NameDescription, e.City, e.PhoneNumber, e.PostalCode, e.NameId, e.State, e.DataSource })
//            //            .HasName("ix_5948_5947");

//            //        entity.HasIndex(e => new { e.Oid, e.DataSource, e.Address1, e.Description, e.Remarks1, e.AccountTemp, e.OtherNameReference, e.Country, e.SalesCreditLimit, e.Address2, e.PurchaseCreditLimit, e.NameDescription, e.City, e.PhoneNumber, e.PostalCode, e.Remarks2, e.NameId, e.VoucherTermCode, e.State, e.StateLongCode, e.OptimisticLockField, e.Gcrecord, e.CreatedOn, e.UpdatedOn, e.NameIdtype })
//            //            .HasName("ix_301_300");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.AccountTemp).HasMaxLength(100);

//            //        entity.Property(e => e.AcreageLeased).HasColumnType("decimal");

//            //        entity.Property(e => e.AcreageOwned).HasColumnType("decimal");

//            //        entity.Property(e => e.Address1).HasMaxLength(100);

//            //        entity.Property(e => e.Address2).HasMaxLength(100);

//            //        entity.Property(e => e.City).HasMaxLength(100);

//            //        entity.Property(e => e.Country).HasMaxLength(100);

//            //        entity.Property(e => e.CreatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.Description).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.NameDescription).HasMaxLength(100);

//            //        entity.Property(e => e.NameId).HasMaxLength(100);

//            //        entity.Property(e => e.NameIdtype)
//            //            .HasColumnName("NameIDType")
//            //            .HasMaxLength(100);

//            //        entity.Property(e => e.OtherNameReference).HasMaxLength(100);

//            //        entity.Property(e => e.PhoneNumber).HasMaxLength(100);

//            //        entity.Property(e => e.PostalCode).HasMaxLength(100);

//            //        entity.Property(e => e.Remarks1).HasMaxLength(100);

//            //        entity.Property(e => e.Remarks2).HasMaxLength(100);

//            //        entity.Property(e => e.State).HasMaxLength(100);

//            //        entity.Property(e => e.StateLongCode).HasMaxLength(100);

//            //        entity.Property(e => e.Storage).HasColumnType("decimal");

//            //        entity.Property(e => e.UpdatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.HasOne(d => d.DataSourceNavigation)
//            //            .WithMany(p => p.NameAddress1)
//            //            .HasForeignKey(d => d.DataSource)
//            //            .HasConstraintName("FK_NameAddress_DataSource");
//            //    });

//            //    modelBuilder.Entity<Note>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Note");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Author).HasMaxLength(100);

//            //        entity.Property(e => e.DateTime).HasColumnType("datetime");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
//            //    });

//            //    modelBuilder.Entity<ObjectDependencies>(entity =>
//            //    {
//            //        entity.HasKey(e => new { e.RunKey, e.SrcObjectKey, e.TgtObjectKey, e.DependencyType })
//            //            .HasName("PK_ObjectDependencies");

//            //        entity.Property(e => e.DependencyType).HasMaxLength(50);

//            //        entity.HasOne(d => d.Objects)
//            //            .WithMany(p => p.ObjectDependenciesObjects)
//            //            .HasForeignKey(d => new { d.RunKey, d.SrcObjectKey })
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_ObjectDependencies_Objects");

//            //        entity.HasOne(d => d.ObjectsNavigation)
//            //            .WithMany(p => p.ObjectDependenciesObjectsNavigation)
//            //            .HasForeignKey(d => new { d.RunKey, d.TgtObjectKey })
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_ObjectDependencies_Objects1");
//            //    });

//            //    modelBuilder.Entity<Objects>(entity =>
//            //    {
//            //        entity.HasKey(e => new { e.RunKey, e.ObjectKey })
//            //            .HasName("PK_Objects");

//            //        entity.Property(e => e.ObjectDesc).HasMaxLength(1000);

//            //        entity.Property(e => e.ObjectName).HasMaxLength(1000);

//            //        entity.Property(e => e.ObjectTypeString)
//            //            .IsRequired()
//            //            .HasMaxLength(1000);

//            //        entity.HasOne(d => d.RunKeyNavigation)
//            //            .WithMany(p => p.Objects)
//            //            .HasForeignKey(d => d.RunKey)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_Objects_RunScan");
//            //    });

//            //    modelBuilder.Entity<Obligation>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Obligation");

//            //        entity.ToTable("Obligation", "RightAngle");

//            //        entity.HasIndex(e => new { e.ObDlDtlDlHdrId, e.ObDlDtlId, e.ObId, e.HasPrimaryInterimProvision, e.PricedBasis, e.Oid })
//            //            .HasName("_dta_index_Obligation_26_1310015798__K3_K4_K5_K24_K23_K1");

//            //        entity.HasIndex(e => new { e.ObDlDtlDlHdrId, e.ObDlDtlId, e.ObId, e.Price, e.PricedBasis, e.HasPrimaryInterimProvision, e.DataSet })
//            //            .HasName("_dta_index_Obligation_26_1310015798__K2_3_4_5_18_23_24");

//            //        entity.HasIndex(e => new { e.ObToDte, e.ObDlDtlDlHdrId, e.ObDlDtlId, e.ObId, e.HasPrimaryInterimProvision, e.PricedBasis, e.Oid, e.WorkBenchMarketPerUnitValue })
//            //            .HasName("_dta_index_Obligation_26_1310015798__K3_K4_K5_K24_K23_K1_K26_7");

//            //        entity.HasIndex(e => new { e.Price, e.Basis, e.PricedBasis, e.HasPrimaryInterimProvision, e.ObDlDtlDlHdrId, e.ObDlDtlId, e.ObId, e.DataSet })
//            //            .HasName("_dta_index_Obligation_17_1310015798__K3_K4_K5_K2_18_20_23_24");

//            //        entity.HasIndex(e => new { e.Price, e.Basis, e.PricedBasis, e.HasPrimaryInterimProvision, e.DataSet, e.Oid, e.ObDlDtlDlHdrId, e.ObDlDtlId, e.ObId })
//            //            .HasName("_dta_index_Obligation_17_1310015798__K2_K1_K3_K4_K5_18_20_23_24");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.CreatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.DlDtlSpplyDmnd).HasColumnType("nchar(1)");

//            //        entity.Property(e => e.HasPrimaryInterimProvision).HasColumnType("nchar(1)");

//            //        entity.Property(e => e.LcleAbbrvtn).HasMaxLength(20);

//            //        entity.Property(e => e.MarketPerUnitValue).HasColumnType("decimal");

//            //        entity.Property(e => e.ObDlDtlDlHdrId).HasColumnName("ObDlDtlDlHdrID");

//            //        entity.Property(e => e.ObDlDtlId).HasColumnName("ObDlDtlID");

//            //        entity.Property(e => e.ObFrmDte).HasColumnType("smalldatetime");

//            //        entity.Property(e => e.ObId).HasColumnName("ObID");

//            //        entity.Property(e => e.ObStts).HasColumnType("nchar(1)");

//            //        entity.Property(e => e.ObToDte).HasColumnType("smalldatetime");

//            //        entity.Property(e => e.PerUnitValue).HasColumnType("decimal");

//            //        entity.Property(e => e.PricedBasis).HasColumnType("nchar(1)");

//            //        entity.Property(e => e.RwPrceLcleId).HasColumnName("RwPrceLcleID");

//            //        entity.Property(e => e.UpdatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.WorkBenchMarketPerUnitValue).HasColumnType("decimal");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.Obligation)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_Obligation_DataSet");
//            //    });

//            //    modelBuilder.Entity<Office>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Office");

//            //        entity.ToTable("Office", "RightAngle");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.CreatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.OffceBaid).HasColumnName("OffceBAID");

//            //        entity.Property(e => e.OffceLcleId).HasColumnName("OffceLcleID");

//            //        entity.Property(e => e.UpdatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.HasOne(d => d.DataSourceNavigation)
//            //            .WithMany(p => p.Office)
//            //            .HasForeignKey(d => d.DataSource)
//            //            .HasConstraintName("FK_Office_DataSource");
//            //    });

//            //    modelBuilder.Entity<OptionMonth>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_OptionMonth");

//            //        entity.HasIndex(e => e.Gcrecord)
//            //            .HasName("iGCRecord_OptionMonth");

//            //        entity.HasIndex(e => e.Sort)
//            //            .HasName("iSort_OptionMonth")
//            //            .IsUnique();

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Display).HasColumnType("varchar(50)");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Sort)
//            //            .IsRequired()
//            //            .HasColumnType("varchar(50)");
//            //    });

//            //    modelBuilder.Entity<OptionType>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_OptionType");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Code).HasColumnType("varchar(50)");

//            //        entity.Property(e => e.Description).HasColumnType("varchar(500)");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.OptionType)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_OptionType_DataSet");
//            //    });

//            //    modelBuilder.Entity<OrderType>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_OrderType");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Code).HasColumnType("varchar(50)");

//            //        entity.Property(e => e.Description).HasColumnType("varchar(500)");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.OrderType)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_OrderType_DataSet");
//            //    });

//            //    modelBuilder.Entity<Organization>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("iOid_Organization");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Email).HasMaxLength(100);

//            //        entity.Property(e => e.FullName).HasMaxLength(100);

//            //        entity.Property(e => e.Name).HasMaxLength(100);

//            //        entity.Property(e => e.Profile).HasMaxLength(100);

//            //        entity.Property(e => e.WebSite).HasMaxLength(100);

//            //        entity.HasOne(d => d.O)
//            //            .WithOne(p => p.Organization)
//            //            .HasForeignKey<Organization>(d => d.Oid)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_Organization_Oid");
//            //    });

//            //    modelBuilder.Entity<Party>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Party");

//            //        entity.HasIndex(e => e.Address1)
//            //            .HasName("iAddress1_Party");

//            //        entity.HasIndex(e => e.Address2)
//            //            .HasName("iAddress2_Party");

//            //        entity.HasIndex(e => e.ObjectType)
//            //            .HasName("iObjectType_Party");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.HasOne(d => d.Address1Navigation)
//            //            .WithMany(p => p.PartyAddress1Navigation)
//            //            .HasForeignKey(d => d.Address1)
//            //            .HasConstraintName("FK_Party_Address1");

//            //        entity.HasOne(d => d.Address2Navigation)
//            //            .WithMany(p => p.PartyAddress2Navigation)
//            //            .HasForeignKey(d => d.Address2)
//            //            .HasConstraintName("FK_Party_Address2");

//            //        entity.HasOne(d => d.ObjectTypeNavigation)
//            //            .WithMany(p => p.Party)
//            //            .HasForeignKey(d => d.ObjectType)
//            //            .HasConstraintName("FK_Party_ObjectType");
//            //    });

//            //    modelBuilder.Entity<PermissionData>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_PermissionData");

//            //        entity.HasIndex(e => e.ObjectType)
//            //            .HasName("iObjectType_PermissionData");

//            //        entity.HasIndex(e => e.PermissionsContainer)
//            //            .HasName("iPermissionsContainer_PermissionData");

//            //        entity.Property(e => e.Oid).ValueGeneratedNever();

//            //        entity.Property(e => e.Members).HasMaxLength(100);

//            //        entity.HasOne(d => d.ObjectTypeNavigation)
//            //            .WithMany(p => p.PermissionData)
//            //            .HasForeignKey(d => d.ObjectType)
//            //            .HasConstraintName("FK_PermissionData_ObjectType");

//            //        entity.HasOne(d => d.PermissionsContainerNavigation)
//            //            .WithMany(p => p.PermissionData)
//            //            .HasForeignKey(d => d.PermissionsContainer)
//            //            .HasConstraintName("FK_PermissionData_PermissionsContainer");
//            //    });

//            //    modelBuilder.Entity<PermissionsContainer>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_PermissionsContainer");

//            //        entity.HasIndex(e => e.Gcrecord)
//            //            .HasName("iGCRecord_PermissionsContainer");

//            //        entity.HasIndex(e => e.ObjectType)
//            //            .HasName("iObjectType_PermissionsContainer");

//            //        entity.Property(e => e.Oid).ValueGeneratedNever();

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.HasOne(d => d.ObjectTypeNavigation)
//            //            .WithMany(p => p.PermissionsContainer)
//            //            .HasForeignKey(d => d.ObjectType)
//            //            .HasConstraintName("FK_PermissionsContainer_ObjectType");
//            //    });

//            //    modelBuilder.Entity<PersistentPermission>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_PersistentPermission");

//            //        entity.HasIndex(e => e.Role)
//            //            .HasName("iRole_PersistentPermission");

//            //        entity.Property(e => e.Oid).ValueGeneratedNever();

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.HasOne(d => d.RoleNavigation)
//            //            .WithMany(p => p.PersistentPermission)
//            //            .HasForeignKey(d => d.Role)
//            //            .HasConstraintName("FK_PersistentPermission_Role");
//            //    });

//            //    modelBuilder.Entity<Person>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("iOid_Person");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Birthday).HasColumnType("datetime");

//            //        entity.Property(e => e.Email).HasMaxLength(255);

//            //        entity.Property(e => e.FirstName).HasMaxLength(100);

//            //        entity.Property(e => e.LastName).HasMaxLength(100);

//            //        entity.Property(e => e.MiddleName).HasMaxLength(100);

//            //        entity.HasOne(d => d.O)
//            //            .WithOne(p => p.Person)
//            //            .HasForeignKey<Person>(d => d.Oid)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_Person_Oid");
//            //    });

//            //    modelBuilder.Entity<PhoneNumber>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_PhoneNumber");

//            //        entity.HasIndex(e => e.Party)
//            //            .HasName("iParty_PhoneNumber");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Number).HasMaxLength(100);

//            //        entity.Property(e => e.PhoneType).HasMaxLength(100);

//            //        entity.HasOne(d => d.PartyNavigation)
//            //            .WithMany(p => p.PhoneNumber)
//            //            .HasForeignKey(d => d.Party)
//            //            .HasConstraintName("FK_PhoneNumber_Party");
//            //    });

//            //    modelBuilder.Entity<PhoneType>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_PhoneType");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.TypeName).HasMaxLength(100);
//            //    });

//            //    modelBuilder.Entity<PositionType>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_PositionType");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Code).HasColumnType("varchar(50)");

//            //        entity.Property(e => e.Description).HasColumnType("varchar(500)");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.PositionType)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_PositionType_DataSet");
//            //    });

//            //    modelBuilder.Entity<Preference>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Code)
//            //            .HasName("PK_Preferences");

//            //        entity.Property(e => e.Code).HasColumnType("varchar(10)");

//            //        entity.Property(e => e.Value).HasColumnType("varchar(250)");
//            //    });

//            //    modelBuilder.Entity<Product>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Product");

//            //        entity.ToTable("Product", "RightAngle");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Code).HasMaxLength(100);

//            //        entity.Property(e => e.Description).HasMaxLength(100);

//            //        entity.Property(e => e.FutureMonths).HasMaxLength(100);

//            //        entity.Property(e => e.LoadDate)
//            //            .HasColumnType("smalldatetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.PrdctDensityPerUom).HasColumnName("PrdctDensityPerUOM");

//            //        entity.Property(e => e.PrdctId).HasColumnName("PrdctID");

//            //        entity.Property(e => e.Status).HasMaxLength(100);

//            //        entity.Property(e => e.Uomabbv)
//            //            .HasColumnName("UOMAbbv")
//            //            .HasMaxLength(20);
//            //    });

//            //    modelBuilder.Entity<PropertyBag>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_PropertyBag");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
//            //    });

//            //    modelBuilder.Entity<PropertyBagDescriptor>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_PropertyBagDescriptor");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
//            //    });

//            //    modelBuilder.Entity<PropertyDescriptor>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_PropertyDescriptor");

//            //        entity.HasIndex(e => e.Code)
//            //            .HasName("iCode_PropertyDescriptor")
//            //            .IsUnique();

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Code)
//            //            .IsRequired()
//            //            .HasMaxLength(4);

//            //        entity.Property(e => e.Description).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Name).HasMaxLength(100);

//            //        entity.Property(e => e.Type).HasMaxLength(100);
//            //    });

//            //    modelBuilder.Entity<PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags");

//            //        entity.ToTable("PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags");

//            //        entity.HasIndex(e => e.PropertyBags)
//            //            .HasName("iPropertyBags_PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags");

//            //        entity.HasIndex(e => e.PropertyDescriptors)
//            //            .HasName("iPropertyDescriptors_PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags");

//            //        entity.HasIndex(e => new { e.PropertyBags, e.PropertyDescriptors })
//            //            .HasName("iPropertyBagsPropertyDescriptors_PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags")
//            //            .IsUnique();

//            //        entity.Property(e => e.Oid)
//            //            .HasColumnName("OID")
//            //            .ValueGeneratedNever();

//            //        entity.Property(e => e.PropertyBags).IsRequired();

//            //        entity.Property(e => e.PropertyDescriptors).IsRequired();

//            //        entity.HasOne(d => d.PropertyBagsNavigation)
//            //            .WithMany(p => p.PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags)
//            //            .HasForeignKey(d => d.PropertyBags)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags_PropertyBags");

//            //        entity.HasOne(d => d.PropertyDescriptorsNavigation)
//            //            .WithMany(p => p.PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags)
//            //            .HasForeignKey(d => d.PropertyDescriptors)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_PropertyDescriptorPropertyDescriptors_PropertyBagDescriptorPropertyBags_PropertyDescriptors");
//            //    });

//            //    modelBuilder.Entity<PropertyValue>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_PropertyValue");

//            //        entity.HasIndex(e => e.Bag)
//            //            .HasName("iBag_PropertyValue");

//            //        entity.HasIndex(e => e.Descriptor)
//            //            .HasName("iDescriptor_PropertyValue");

//            //        entity.HasIndex(e => e.WeakReference)
//            //            .HasName("iWeakReference_PropertyValue");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.StrValue).HasMaxLength(100);

//            //        entity.HasOne(d => d.BagNavigation)
//            //            .WithMany(p => p.PropertyValue)
//            //            .HasForeignKey(d => d.Bag)
//            //            .HasConstraintName("FK_PropertyValue_Bag");

//            //        entity.HasOne(d => d.DescriptorNavigation)
//            //            .WithMany(p => p.PropertyValue)
//            //            .HasForeignKey(d => d.Descriptor)
//            //            .HasConstraintName("FK_PropertyValue_Descriptor");

//            //        entity.HasOne(d => d.WeakReferenceNavigation)
//            //            .WithMany(p => p.PropertyValue)
//            //            .HasForeignKey(d => d.WeakReference)
//            //            .HasConstraintName("FK_PropertyValue_WeakReference");
//            //    });

//            //    modelBuilder.Entity<RawPriceLocale>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_RawPriceLocale");

//            //        entity.ToTable("RawPriceLocale", "RightAngle");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.CurveName).HasColumnType("varchar(100)");

//            //        entity.Property(e => e.LcleAbbrvtn).HasColumnType("varchar(20)");

//            //        entity.Property(e => e.LcleNme).HasColumnType("varchar(50)");

//            //        entity.Property(e => e.RplcleLcleId).HasColumnName("RPLcleLcleID");

//            //        entity.Property(e => e.RplcleRphdrId).HasColumnName("RPLcleRPHdrID");

//            //        entity.Property(e => e.RwPrceLcleId).HasColumnName("RwPrceLcleID");

//            //        entity.HasOne(d => d.DataSourceNavigation)
//            //            .WithMany(p => p.RawPriceLocale)
//            //            .HasForeignKey(d => d.DataSource)
//            //            .HasConstraintName("FK_RawPriceLocale_DataSource");
//            //    });

//            //    modelBuilder.Entity<ReportExtract>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_ReportExtract");

//            //        entity.HasIndex(e => e.ExtractDate)
//            //            .HasName("iReportExtract_ExtractDate");

//            //        entity.HasIndex(e => e.ExtractNumber)
//            //            .HasName("iReportExtract_ExtractNumber");

//            //        entity.HasIndex(e => e.Gcrecord)
//            //            .HasName("iGCRecord_ReportExtract");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.CreatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.ExtractDate)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.ExtractNumber).ValueGeneratedOnAdd();

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.IsActive).HasDefaultValueSql("1");

//            //        entity.Property(e => e.IsDefault).HasDefaultValueSql("0");

//            //        entity.Property(e => e.ReadyToDelete).HasDefaultValueSql("0");

//            //        entity.HasOne(d => d.ReportExtractMonthNavigation)
//            //            .WithMany(p => p.ReportExtract)
//            //            .HasForeignKey(d => d.ReportExtractMonth)
//            //            .HasConstraintName("FK_ReportExtract_ReportExtractMonth");

//            //        entity.HasOne(d => d.ReportExtractPreviousNavigation)
//            //            .WithMany(p => p.InverseReportExtractPreviousNavigation)
//            //            .HasForeignKey(d => d.ReportExtractPrevious)
//            //            .HasConstraintName("FK_ReportExtract_ReportExtractPrevious");

//            //        entity.HasOne(d => d.ReportExtractTypeNavigation)
//            //            .WithMany(p => p.ReportExtract)
//            //            .HasForeignKey(d => d.ReportExtractType)
//            //            .HasConstraintName("FK_ReportExtract_ReportExtractType");
//            //    });

//            //    modelBuilder.Entity<ReportExtractLog>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_ReportExtractLog");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Activity).HasColumnType("varchar(50)");

//            //        entity.Property(e => e.CreatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.Notes).HasColumnType("varchar(2000)");
//            //    });

//            //    modelBuilder.Entity<ReportExtractMonth>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_ReportExtractMonth");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.ExtractMonth).HasColumnType("datetime");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
//            //    });

//            //    modelBuilder.Entity<ReportExtractType>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_ReportExtractType");

//            //        entity.HasIndex(e => e.Gcrecord)
//            //            .HasName("iGCRecord_ReportExtractType");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Name).HasColumnType("varchar(50)");
//            //    });

//            //    modelBuilder.Entity<Resource>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Resource");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Caption).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
//            //    });

//            //    modelBuilder.Entity<ResourceResourcesEventEvents>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_ResourceResources_EventEvents");

//            //        entity.ToTable("ResourceResources_EventEvents");

//            //        entity.HasIndex(e => e.Events)
//            //            .HasName("iEvents_ResourceResources_EventEvents");

//            //        entity.HasIndex(e => e.Resources)
//            //            .HasName("iResources_ResourceResources_EventEvents");

//            //        entity.HasIndex(e => new { e.Events, e.Resources })
//            //            .HasName("iEventsResources_ResourceResources_EventEvents")
//            //            .IsUnique();

//            //        entity.Property(e => e.Oid)
//            //            .HasColumnName("OID")
//            //            .ValueGeneratedNever();

//            //        entity.Property(e => e.Events).IsRequired();

//            //        entity.Property(e => e.Resources).IsRequired();

//            //        entity.HasOne(d => d.EventsNavigation)
//            //            .WithMany(p => p.ResourceResourcesEventEvents)
//            //            .HasForeignKey(d => d.Events)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_ResourceResources_EventEvents_Events");

//            //        entity.HasOne(d => d.ResourcesNavigation)
//            //            .WithMany(p => p.ResourceResourcesEventEvents)
//            //            .HasForeignKey(d => d.Resources)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_ResourceResources_EventEvents_Resources");
//            //    });

//            //    modelBuilder.Entity<Role>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("iOid_Role");

//            //        entity.Property(e => e.Oid).ValueGeneratedNever();

//            //        entity.HasOne(d => d.O)
//            //            .WithOne(p => p.Role)
//            //            .HasForeignKey<Role>(d => d.Oid)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_Role_Oid");
//            //    });

//            //    modelBuilder.Entity<RoleBase>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_RoleBase");

//            //        entity.HasIndex(e => e.ObjectType)
//            //            .HasName("iObjectType_RoleBase");

//            //        entity.Property(e => e.Oid).ValueGeneratedNever();

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Name).HasMaxLength(100);

//            //        entity.HasOne(d => d.ObjectTypeNavigation)
//            //            .WithMany(p => p.RoleBase)
//            //            .HasForeignKey(d => d.ObjectType)
//            //            .HasConstraintName("FK_RoleBase_ObjectType");
//            //    });

//            //    modelBuilder.Entity<RunScan>(entity =>
//            //    {
//            //        entity.HasKey(e => e.RunKey)
//            //            .HasName("PK_RunScan");

//            //        entity.Property(e => e.RunKey).ValueGeneratedNever();

//            //        entity.Property(e => e.RunCommand)
//            //            .IsRequired()
//            //            .HasMaxLength(512);

//            //        entity.Property(e => e.RunDate).HasColumnType("datetime");
//            //    });

//            //    modelBuilder.Entity<SecurityRole>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_SecurityRole");

//            //        entity.Property(e => e.Oid).ValueGeneratedNever();

//            //        entity.HasOne(d => d.O)
//            //            .WithOne(p => p.SecurityRole)
//            //            .HasForeignKey<SecurityRole>(d => d.Oid)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_SecurityRole_Oid");
//            //    });

//            //    modelBuilder.Entity<SecurityStrategyRole>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_SecurityStrategyRole");

//            //        entity.Property(e => e.Oid).ValueGeneratedNever();

//            //        entity.Property(e => e.Name).HasMaxLength(100);

//            //        entity.HasOne(d => d.O)
//            //            .WithOne(p => p.SecurityStrategyRole)
//            //            .HasForeignKey<SecurityStrategyRole>(d => d.Oid)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_SecurityStrategyRole_Oid");
//            //    });

//            //    modelBuilder.Entity<SecurityUser>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_SecurityUser");

//            //        entity.Property(e => e.Oid).ValueGeneratedNever();

//            //        entity.HasOne(d => d.O)
//            //            .WithOne(p => p.SecurityUser)
//            //            .HasForeignKey<SecurityUser>(d => d.Oid)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_SecurityUser_Oid");
//            //    });

//            //    modelBuilder.Entity<SecurityUserBase>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_SecurityUserBase");

//            //        entity.HasIndex(e => e.Gcrecord)
//            //            .HasName("iGCRecord_SecurityUserBase");

//            //        entity.HasIndex(e => e.ObjectType)
//            //            .HasName("iObjectType_SecurityUserBase");

//            //        entity.Property(e => e.Oid).ValueGeneratedNever();

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.UserName).HasMaxLength(100);

//            //        entity.HasOne(d => d.ObjectTypeNavigation)
//            //            .WithMany(p => p.SecurityUserBase)
//            //            .HasForeignKey(d => d.ObjectType)
//            //            .HasConstraintName("FK_SecurityUserBase_ObjectType");
//            //    });

//            //    modelBuilder.Entity<SecurityUserWithRolesBase>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_SecurityUserWithRolesBase");

//            //        entity.Property(e => e.Oid).ValueGeneratedNever();

//            //        entity.HasOne(d => d.O)
//            //            .WithOne(p => p.SecurityUserWithRolesBase)
//            //            .HasForeignKey<SecurityUserWithRolesBase>(d => d.Oid)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_SecurityUserWithRolesBase_Oid");
//            //    });

//            //    modelBuilder.Entity<SecurityUserWithRolesBaseUsersSecurityStrategyRoleRoles>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_SecurityUserWithRolesBaseUsers_SecurityStrategyRoleRoles");

//            //        entity.ToTable("SecurityUserWithRolesBaseUsers_SecurityStrategyRoleRoles");

//            //        entity.HasIndex(e => e.Roles)
//            //            .HasName("iRoles_SecurityUserWithRolesBaseUsers_SecurityStrategyRoleRoles");

//            //        entity.HasIndex(e => e.Users)
//            //            .HasName("iUsers_SecurityUserWithRolesBaseUsers_SecurityStrategyRoleRoles");

//            //        entity.HasIndex(e => new { e.Roles, e.Users })
//            //            .HasName("iRolesUsers_SecurityUserWithRolesBaseUsers_SecurityStrategyRoleRoles")
//            //            .IsUnique();

//            //        entity.Property(e => e.Oid)
//            //            .HasColumnName("OID")
//            //            .ValueGeneratedNever();

//            //        entity.Property(e => e.Roles).IsRequired();

//            //        entity.Property(e => e.Users).IsRequired();

//            //        entity.HasOne(d => d.RolesNavigation)
//            //            .WithMany(p => p.SecurityUserWithRolesBaseUsersSecurityStrategyRoleRoles)
//            //            .HasForeignKey(d => d.Roles)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_SecurityUserWithRolesBaseUsers_SecurityStrategyRoleRoles_Roles");

//            //        entity.HasOne(d => d.UsersNavigation)
//            //            .WithMany(p => p.SecurityUserWithRolesBaseUsersSecurityStrategyRoleRoles)
//            //            .HasForeignKey(d => d.Users)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_SecurityUserWithRolesBaseUsers_SecurityStrategyRoleRoles_Users");
//            //    });

//            //    modelBuilder.Entity<ServerPrefix>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_ServerPrefix");

//            //        entity.Property(e => e.Oid).HasColumnName("OID");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Prefix).HasMaxLength(100);
//            //    });

//            //    modelBuilder.Entity<SimpleUser>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_SimpleUser");

//            //        entity.HasIndex(e => e.Gcrecord)
//            //            .HasName("iGCRecord_SimpleUser");

//            //        entity.Property(e => e.Oid).ValueGeneratedNever();

//            //        entity.Property(e => e.FullName).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.Password).HasMaxLength(100);

//            //        entity.Property(e => e.UserName).HasMaxLength(100);
//            //    });

//            //    modelBuilder.Entity<State>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_State");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.LongName).HasMaxLength(100);

//            //        entity.Property(e => e.ShortName).HasMaxLength(100);
//            //    });

//            //    modelBuilder.Entity<StateRegion>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_StateRegion");

//            //        entity.HasIndex(e => new { e.Code, e.Oid })
//            //            .HasName("_dta_index_StateRegion_26_912722304__K1_5");

//            //        entity.HasIndex(e => new { e.DataSource, e.Description, e.Code, e.Oid })
//            //            .HasName("_dta_index_StateRegion_26_912722304__K4_K6_K5_K1");

//            //        entity.HasIndex(e => new { e.Oid, e.Code, e.DataSource, e.RegionType })
//            //            .HasName("ix_9985_9984");

//            //        entity.HasIndex(e => new { e.Oid, e.Code, e.DataSourceSystemGroup, e.RegionType })
//            //            .HasName("ix_7433_7432");

//            //        entity.HasIndex(e => new { e.Oid, e.Code, e.Description, e.RegionType, e.DataSourceSystemGroup })
//            //            .HasName("ix_16033_16032");

//            //        entity.HasIndex(e => new { e.Oid, e.Description, e.Code, e.RegionType, e.DataSourceSystemGroup })
//            //            .HasName("ix_485_484");

//            //        entity.HasIndex(e => new { e.Oid, e.Code, e.Description, e.DataSource, e.RegionType, e.DataSourceSystemGroup })
//            //            .HasName("ix_9987_9986");

//            //        entity.HasIndex(e => new { e.Oid, e.Description, e.DataSource, e.Code, e.RegionType, e.DataSourceSystemGroup })
//            //            .HasName("ix_4_3");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Code).HasMaxLength(100);

//            //        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.Description).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.RegionType).HasMaxLength(50);

//            //        entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //        entity.HasOne(d => d.DataSourceSystemGroupNavigation)
//            //            .WithMany(p => p.StateRegion)
//            //            .HasForeignKey(d => d.DataSourceSystemGroup)
//            //            .HasConstraintName("FK_StateRegion_DataSourceSystemGroup");
//            //    });

//            //    modelBuilder.Entity<Sysdtslog90>(entity =>
//            //    {
//            //        entity.ToTable("sysdtslog90");

//            //        entity.Property(e => e.Id).HasColumnName("id");

//            //        entity.Property(e => e.Computer)
//            //            .IsRequired()
//            //            .HasColumnName("computer")
//            //            .HasMaxLength(128);

//            //        entity.Property(e => e.Databytes)
//            //            .HasColumnName("databytes")
//            //            .HasColumnType("image");

//            //        entity.Property(e => e.Datacode).HasColumnName("datacode");

//            //        entity.Property(e => e.Endtime)
//            //            .HasColumnName("endtime")
//            //            .HasColumnType("datetime");

//            //        entity.Property(e => e.Event)
//            //            .IsRequired()
//            //            .HasColumnName("event")
//            //            .HasColumnType("sysname");

//            //        entity.Property(e => e.Executionid).HasColumnName("executionid");

//            //        entity.Property(e => e.Message)
//            //            .IsRequired()
//            //            .HasColumnName("message")
//            //            .HasMaxLength(2048);

//            //        entity.Property(e => e.Operator)
//            //            .IsRequired()
//            //            .HasColumnName("operator")
//            //            .HasMaxLength(128);

//            //        entity.Property(e => e.Source)
//            //            .IsRequired()
//            //            .HasColumnName("source")
//            //            .HasMaxLength(1024);

//            //        entity.Property(e => e.Sourceid).HasColumnName("sourceid");

//            //        entity.Property(e => e.Starttime)
//            //            .HasColumnName("starttime")
//            //            .HasColumnType("datetime");
//            //    });

//            //    modelBuilder.Entity<Task>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Task");

//            //        entity.HasIndex(e => e.AssignedTo)
//            //            .HasName("iAssignedTo_Task");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.DateCompleted).HasColumnType("datetime");

//            //        entity.Property(e => e.DueDate).HasColumnType("datetime");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.StartDate).HasColumnType("datetime");

//            //        entity.Property(e => e.Subject).HasMaxLength(100);

//            //        entity.HasOne(d => d.AssignedToNavigation)
//            //            .WithMany(p => p.Task)
//            //            .HasForeignKey(d => d.AssignedTo)
//            //            .HasConstraintName("FK_Task_AssignedTo");
//            //    });

//            //    modelBuilder.Entity<Ticket>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_Ticket");

//            //        entity.HasIndex(e => e.AccountPayable)
//            //            .HasName("ix_3079_3078");

//            //        entity.HasIndex(e => e.DataSet)
//            //            .HasName("ix_10192_10191");

//            //        entity.HasIndex(e => e.DeliverySchedule)
//            //            .HasName("ix_Ticket_DeliverySchedule");

//            //        entity.HasIndex(e => new { e.Oid, e.DataSet })
//            //            .HasName("ix_9944_9943");

//            //        entity.HasIndex(e => new { e.Oid, e.InOutCode, e.TotalNetUnits, e.DataSet })
//            //            .HasName("ix_9975_9974");

//            //        entity.HasIndex(e => new { e.Oid, e.Commodity, e.InOutCode, e.Location, e.Number, e.DataSet })
//            //            .HasName("ix_10244_10243");

//            //        entity.HasIndex(e => new { e.Oid, e.Commodity, e.Location, e.Number, e.VehicleId, e.InOutCode })
//            //            .HasName("ix_2492_2491");

//            //        entity.HasIndex(e => new { e.Oid, e.Commodity, e.Number, e.VehicleId, e.LocationCommodity, e.OtherReferenceNumber, e.InOutCode, e.TicketType })
//            //            .HasName("ix_2495_2494");

//            //        entity.HasIndex(e => new { e.Oid, e.AdditionalFreightAmount, e.DestinationLocationCode, e.EntryDate, e.FreightRate, e.FreightStatus, e.VoucherNumber, e.InOutCode, e.Location, e.SampleNumber, e.ShipmentDate, e.ShipperName, e.ShipToFreightId, e.Number, e.Status, e.TicketType, e.TotalNetUnits, e.TransportationMode, e.VehicleId, e.Fdisc, e.Ddisc, e.StockStorageStateRegion, e.CrossStockStorageStateRegion, e.AccountPayable, e.LocationCommodity, e.FreightWeight, e.DataSet })
//            //            .HasName("ix_10070_10069");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.CrossStockCode).HasMaxLength(50);

//            //        entity.Property(e => e.Ddisc).HasColumnName("DDisc");

//            //        entity.Property(e => e.DestinationLocationCode).HasMaxLength(100);

//            //        entity.Property(e => e.EntryDate).HasColumnType("datetime");

//            //        entity.Property(e => e.Fdisc).HasColumnName("FDisc");

//            //        entity.Property(e => e.FreightStatus).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.InOutCode).HasMaxLength(100);

//            //        entity.Property(e => e.Number).HasMaxLength(100);

//            //        entity.Property(e => e.OtherReferenceNumber).HasMaxLength(100);

//            //        entity.Property(e => e.PrimaryTicketNumber).HasMaxLength(100);

//            //        entity.Property(e => e.SampleNumber).HasMaxLength(100);

//            //        entity.Property(e => e.ShipToFreightId).HasMaxLength(100);

//            //        entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

//            //        entity.Property(e => e.Status).HasMaxLength(100);

//            //        entity.Property(e => e.StockStorageCode).HasMaxLength(50);

//            //        entity.Property(e => e.TicketType).HasMaxLength(100);

//            //        entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.VehicleId).HasMaxLength(100);

//            //        entity.Property(e => e.VoucherNumber).HasMaxLength(100);

//            //        entity.HasOne(d => d.AccountPayableNavigation)
//            //            .WithMany(p => p.Ticket)
//            //            .HasForeignKey(d => d.AccountPayable)
//            //            .HasConstraintName("FK_Ticket_AccountPayable");

//            //        entity.HasOne(d => d.CommodityNavigation)
//            //            .WithMany(p => p.Ticket)
//            //            .HasForeignKey(d => d.Commodity)
//            //            .HasConstraintName("FK_Ticket_Commodity");

//            //        entity.HasOne(d => d.CrossStockStorageStateRegionNavigation)
//            //            .WithMany(p => p.TicketCrossStockStorageStateRegionNavigation)
//            //            .HasForeignKey(d => d.CrossStockStorageStateRegion)
//            //            .HasConstraintName("FK_Ticket_StateRegion1");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.Ticket)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_Ticket_DataSet");

//            //        entity.HasOne(d => d.DeliveryScheduleNavigation)
//            //            .WithMany(p => p.Ticket)
//            //            .HasForeignKey(d => d.DeliverySchedule)
//            //            .HasConstraintName("FK_Ticket_DeliverySchedule");

//            //        entity.HasOne(d => d.LocationNavigation)
//            //            .WithMany(p => p.Ticket)
//            //            .HasForeignKey(d => d.Location)
//            //            .HasConstraintName("FK_Ticket_Location");

//            //        entity.HasOne(d => d.LocationCommodityNavigation)
//            //            .WithMany(p => p.Ticket)
//            //            .HasForeignKey(d => d.LocationCommodity)
//            //            .HasConstraintName("FK_Ticket_LocationCommodity");

//            //        entity.HasOne(d => d.ShipperNameNavigation)
//            //            .WithMany(p => p.Ticket)
//            //            .HasForeignKey(d => d.ShipperName)
//            //            .HasConstraintName("FK_Ticket_NameAddress");

//            //        entity.HasOne(d => d.StockStorageStateRegionNavigation)
//            //            .WithMany(p => p.TicketStockStorageStateRegionNavigation)
//            //            .HasForeignKey(d => d.StockStorageStateRegion)
//            //            .HasConstraintName("FK_Ticket_StateRegion");

//            //        entity.HasOne(d => d.TransportationModeNavigation)
//            //            .WithMany(p => p.Ticket)
//            //            .HasForeignKey(d => d.TransportationMode)
//            //            .HasConstraintName("FK_Ticket_TransportationMode");
//            //    });

//            //    modelBuilder.Entity<TicketApplication>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_TicketApplication");

//            //        entity.HasIndex(e => e.DeliverySchedule)
//            //            .HasName("ixTicketApplication_DeliverySchedule");

//            //        entity.HasIndex(e => new { e.Oid, e.Ticket, e.DataSet })
//            //            .HasName("ix_9970_9969");

//            //        entity.HasIndex(e => new { e.Oid, e.Number, e.InOutCode, e.DataSet, e.Ticket })
//            //            .HasName("ix_9534_9533");

//            //        entity.HasIndex(e => new { e.Oid, e.Ticket, e.DeliverySchedule, e.AdditionalDescription, e.ApplicationDate, e.Name, e.Number, e.ApplicationType, e.CalculationRate1, e.CalculationRate2, e.CalculationRate3, e.CalculationRate4, e.CalculationTypes, e.ContractLocationCode, e.ContractPricingNumber, e.CustomerNetUnits, e.DiscountCodes, e.DiscountHtnumber, e.DiscountPremiumTable, e.ExpectedApplicationType, e.GrossUnits, e.HeldIndicator, e.InOutCode, e.PosNetUnits, e.DataSet })
//            //            .HasName("ix_10072_10071");

//            //        entity.HasIndex(e => new { e.Oid, e.Ticket, e.DeliverySchedule, e.AdditionalDescription, e.ApplicationDate, e.Name, e.Number, e.ApplicationType, e.CalculationRate1, e.CalculationRate2, e.CalculationRate3, e.CalculationRate4, e.CalculationTypes, e.ContractLocationCode, e.ContractPricingNumber, e.CustomerNetUnits, e.DiscountCodes, e.DiscountHtnumber, e.DiscountPremiumTable, e.ExpectedApplicationType, e.GrossUnits, e.HeldIndicator, e.InOutCode, e.PosNetUnits, e.Fdisc, e.Ddisc, e.DataSet })
//            //            .HasName("ix_2537_2536");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.AdditionalDescription).HasMaxLength(100);

//            //        entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

//            //        entity.Property(e => e.ApplicationType).HasMaxLength(100);

//            //        entity.Property(e => e.CalculationTypes).HasMaxLength(100);

//            //        entity.Property(e => e.ContractLocationCode).HasMaxLength(100);

//            //        entity.Property(e => e.ContractPricingNumber).HasMaxLength(100);

//            //        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.Ddisc).HasColumnName("DDisc");

//            //        entity.Property(e => e.DiscountCodes).HasMaxLength(100);

//            //        entity.Property(e => e.DiscountHtnumber)
//            //            .HasColumnName("DiscountHTNumber")
//            //            .HasMaxLength(100);

//            //        entity.Property(e => e.DiscountPremiumTable).HasMaxLength(100);

//            //        entity.Property(e => e.ExpectedApplicationType).HasMaxLength(100);

//            //        entity.Property(e => e.Fdisc).HasColumnName("FDisc");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.HeldIndicator).HasMaxLength(100);

//            //        entity.Property(e => e.InOutCode).HasMaxLength(100);

//            //        entity.Property(e => e.IsInTransit).HasDefaultValueSql("0");

//            //        entity.Property(e => e.Number).HasMaxLength(100);

//            //        entity.Property(e => e.PurchaseSalesCode).HasMaxLength(100);

//            //        entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.TicketApplication)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_TicketApplication_DataSet");

//            //        entity.HasOne(d => d.DeliveryScheduleNavigation)
//            //            .WithMany(p => p.TicketApplication)
//            //            .HasForeignKey(d => d.DeliverySchedule)
//            //            .HasConstraintName("FK_TicketApplication_DeliverySchedule");

//            //        entity.HasOne(d => d.LocationNavigation)
//            //            .WithMany(p => p.TicketApplication)
//            //            .HasForeignKey(d => d.Location)
//            //            .HasConstraintName("FK_TicketApplication_Location");

//            //        entity.HasOne(d => d.NameNavigation)
//            //            .WithMany(p => p.TicketApplication)
//            //            .HasForeignKey(d => d.Name)
//            //            .HasConstraintName("FK_TicketApplication_NameAddress");

//            //        entity.HasOne(d => d.TicketNavigation)
//            //            .WithMany(p => p.TicketApplication)
//            //            .HasForeignKey(d => d.Ticket)
//            //            .HasConstraintName("FK_TicketApplication_Ticket");
//            //    });

//            //    modelBuilder.Entity<TicketApplicationHistory>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_TicketApplicationHistory");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.HasOne(d => d.DataSetCurrentNavigation)
//            //            .WithMany(p => p.TicketApplicationHistoryDataSetCurrentNavigation)
//            //            .HasForeignKey(d => d.DataSetCurrent)
//            //            .HasConstraintName("FK_TicketApplicationHistory_DataSetCurrent");

//            //        entity.HasOne(d => d.DataSetPriorNavigation)
//            //            .WithMany(p => p.TicketApplicationHistoryDataSetPriorNavigation)
//            //            .HasForeignKey(d => d.DataSetPrior)
//            //            .HasConstraintName("FK_TicketApplicationHistory_DataSetPrior");

//            //        entity.HasOne(d => d.TicketApplicationCurrentNavigation)
//            //            .WithMany(p => p.TicketApplicationHistoryTicketApplicationCurrentNavigation)
//            //            .HasForeignKey(d => d.TicketApplicationCurrent)
//            //            .HasConstraintName("FK_TicketApplicationHistory_TicketApplicationCurrent");

//            //        entity.HasOne(d => d.TicketApplicationPriorNavigation)
//            //            .WithMany(p => p.TicketApplicationHistoryTicketApplicationPriorNavigation)
//            //            .HasForeignKey(d => d.TicketApplicationPrior)
//            //            .HasConstraintName("FK_TicketApplicationHistory_TicketApplicationPrior");
//            //    });

//            //    modelBuilder.Entity<TicketApplicationRelationship>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_TicketRelationship");

//            //        entity.HasIndex(e => e.DataSet)
//            //            .HasName("ix_6747_6746");

//            //        entity.HasIndex(e => e.OutboundTicketApplication)
//            //            .HasName("ix_3543_3542");

//            //        entity.HasIndex(e => new { e.Oid, e.InboundTicketApplication, e.OutboundTicketApplication, e.DataSet })
//            //            .HasName("ix_38328_38327");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.TicketApplicationRelationship)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_TicketApplicationRelationship_DataSet");

//            //        entity.HasOne(d => d.InboundTicketApplicationNavigation)
//            //            .WithMany(p => p.TicketApplicationRelationshipInboundTicketApplicationNavigation)
//            //            .HasForeignKey(d => d.InboundTicketApplication)
//            //            .HasConstraintName("FK_TicketApplicationRelationship_TicketApplication");

//            //        entity.HasOne(d => d.OutboundTicketApplicationNavigation)
//            //            .WithMany(p => p.TicketApplicationRelationshipOutboundTicketApplicationNavigation)
//            //            .HasForeignKey(d => d.OutboundTicketApplication)
//            //            .HasConstraintName("FK_TicketApplicationRelationship_TicketApplication1");
//            //    });

//            //    modelBuilder.Entity<TicketApplicationTranRelationship>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_TicketApplicationTranRelationship");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.TicketApplicationTranRelationship)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_TicketApplicationTranRelationship_DataSet");

//            //        entity.HasOne(d => d.InboundTicketApplicationNavigation)
//            //            .WithMany(p => p.TicketApplicationTranRelationshipInboundTicketApplicationNavigation)
//            //            .HasForeignKey(d => d.InboundTicketApplication)
//            //            .HasConstraintName("FK_TicketApplicationTranRelationship_InboundTicketApplication");

//            //        entity.HasOne(d => d.OutboundTicketApplicationNavigation)
//            //            .WithMany(p => p.TicketApplicationTranRelationshipOutboundTicketApplicationNavigation)
//            //            .HasForeignKey(d => d.OutboundTicketApplication)
//            //            .HasConstraintName("FK_TicketApplicationTranRelationship_OutboundTicketApplication");
//            //    });

//            //    modelBuilder.Entity<TicketDiscount>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_TicketDiscount");

//            //        entity.HasIndex(e => e.TicketApplication)
//            //            .HasName("ix_10091_10090");

//            //        entity.HasIndex(e => new { e.Oid, e.DataSet })
//            //            .HasName("ix_6740_6739");

//            //        entity.HasIndex(e => new { e.TicketApplication, e.DataSet })
//            //            .HasName("ix_7441_7440");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.ApplicationNumber).HasMaxLength(100);

//            //        entity.Property(e => e.CalculationTypes).HasMaxLength(100);

//            //        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.DiscountCode).HasMaxLength(100);

//            //        entity.Property(e => e.DiscountTable).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.InOutCode).HasMaxLength(100);

//            //        entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.TicketDiscount)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_TicketDiscount_DataSet");

//            //        entity.HasOne(d => d.TicketApplicationNavigation)
//            //            .WithMany(p => p.TicketDiscount)
//            //            .HasForeignKey(d => d.TicketApplication)
//            //            .HasConstraintName("FK_TicketDiscount_TicketApplication");
//            //    });

//            //    modelBuilder.Entity<TicketDiscountDetail>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_TicketDiscountDetail");

//            //        entity.HasIndex(e => e.Ticket)
//            //            .HasName("ixTicketDIscountDetail_Ticket");

//            //        entity.HasIndex(e => e.TicketApplication)
//            //            .HasName("ix_TicketDiscountDetail_TicketApplication");

//            //        entity.HasIndex(e => new { e.Oid, e.DataSet })
//            //            .HasName("ix_9977_9976");

//            //        entity.HasIndex(e => new { e.Ticket, e.Fdisc, e.Ddisc, e.DataSet })
//            //            .HasName("ix_9981_9980");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.CalculationType).HasMaxLength(1);

//            //        entity.Property(e => e.Ddisc).HasColumnName("DDisc");

//            //        entity.Property(e => e.DiscountCode).HasMaxLength(2);

//            //        entity.Property(e => e.Fdisc).HasColumnName("FDisc");

//            //        entity.HasOne(d => d.DataSetNavigation)
//            //            .WithMany(p => p.TicketDiscountDetail)
//            //            .HasForeignKey(d => d.DataSet)
//            //            .HasConstraintName("FK_TicketDiscountDetail_DataSet");

//            //        entity.HasOne(d => d.TicketNavigation)
//            //            .WithMany(p => p.TicketDiscountDetail)
//            //            .HasForeignKey(d => d.Ticket)
//            //            .HasConstraintName("FK_TicketDiscountDetail_Ticket");

//            //        entity.HasOne(d => d.TicketApplicationNavigation)
//            //            .WithMany(p => p.TicketDiscountDetail)
//            //            .HasForeignKey(d => d.TicketApplication)
//            //            .HasConstraintName("FK_TicketDiscountDetail_TicketApplication");
//            //    });

//            //    modelBuilder.Entity<TicketHistory>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_TicketHistory");

//            //        entity.HasIndex(e => new { e.Oid, e.TicketCurrent })
//            //            .HasName("ix_4426_4425");

//            //        entity.HasIndex(e => new { e.Oid, e.TicketPrior, e.TicketCurrent, e.DataSetPrior, e.DataSetCurrent, e.ReportExtract })
//            //            .HasName("ix_2539_2538");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
//            //    });

//            //    modelBuilder.Entity<TransportationMode>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_TransportationMode_1");

//            //        entity.ToTable("TransportationMode", "RightAngle");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.Description).HasMaxLength(100);

//            //        entity.Property(e => e.DynLstBxId).HasColumnName("DynLstBxID");

//            //        entity.Property(e => e.InboundFreightStatus).HasMaxLength(100);

//            //        entity.Property(e => e.InboundGradeCertificate).HasMaxLength(100);

//            //        entity.Property(e => e.InboundWeightCertificate).HasMaxLength(100);

//            //        entity.Property(e => e.LoadDate).HasColumnType("smalldatetime");

//            //        entity.Property(e => e.Mode).HasMaxLength(100);

//            //        entity.Property(e => e.OutboundFreightStatus).HasMaxLength(100);

//            //        entity.Property(e => e.OutboundGradeCertificate).HasMaxLength(100);

//            //        entity.Property(e => e.OutboundWeightCertificate).HasMaxLength(100);

//            //        entity.Property(e => e.UniqueNumberIndicator).HasMaxLength(100);
//            //    });

//            //    modelBuilder.Entity<TransportationMode1>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_TransportationMode");

//            //        entity.ToTable("TransportationMode");

//            //        entity.HasIndex(e => e.DataSource)
//            //            .HasName("iDataSource_TransportationMode");

//            //        entity.HasIndex(e => e.Mode)
//            //            .HasName("iTransportationMode_Mode");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//            //        entity.Property(e => e.Description).HasMaxLength(100);

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.InboundFreightStatus).HasMaxLength(100);

//            //        entity.Property(e => e.InboundGradeCertificate).HasMaxLength(100);

//            //        entity.Property(e => e.InboundWeightCertificate).HasMaxLength(100);

//            //        entity.Property(e => e.Mode).HasMaxLength(100);

//            //        entity.Property(e => e.OutboundFreightStatus).HasMaxLength(100);

//            //        entity.Property(e => e.OutboundGradeCertificate).HasMaxLength(100);

//            //        entity.Property(e => e.OutboundWeightCertificate).HasMaxLength(100);

//            //        entity.Property(e => e.UniqueNumberIndicator).HasMaxLength(100);

//            //        entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

//            //        entity.HasOne(d => d.DataSourceNavigation)
//            //            .WithMany(p => p.TransportationMode1)
//            //            .HasForeignKey(d => d.DataSource)
//            //            .HasConstraintName("FK_TransportationMode_DataSource");
//            //    });

//            //    modelBuilder.Entity<UnitOfMeasure>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_UnitOfMeasure");

//            //        entity.Property(e => e.Oid)
//            //            .HasColumnName("oid")
//            //            .HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.BushelsPerUnit).HasColumnType("decimal");

//            //        entity.Property(e => e.MeasureType)
//            //            .IsRequired()
//            //            .HasColumnType("char(1)")
//            //            .HasDefaultValueSql("'W'");

//            //        entity.Property(e => e.Name).HasColumnType("varchar(50)");

//            //        entity.Property(e => e.Notes).HasColumnType("varchar(100)");

//            //        entity.Property(e => e.PoundsPerUnit).HasColumnType("decimal");
//            //    });

//            //    modelBuilder.Entity<UnitOfMeasure2>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_UnitOfMeasure");

//            //        entity.ToTable("UnitOfMeasure", "RightAngle");

//            //        entity.Property(e => e.Oid).HasDefaultValueSql("newsequentialid()");

//            //        entity.Property(e => e.CreatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");

//            //        entity.Property(e => e.Uom).HasColumnName("UOM");

//            //        entity.Property(e => e.Uomabbv)
//            //            .HasColumnName("UOMAbbv")
//            //            .HasMaxLength(20);

//            //        entity.Property(e => e.Uomdesc)
//            //            .HasColumnName("UOMDesc")
//            //            .HasMaxLength(80);

//            //        entity.Property(e => e.Uomtpe)
//            //            .HasColumnName("UOMTpe")
//            //            .HasMaxLength(1);

//            //        entity.Property(e => e.UpdatedOn)
//            //            .HasColumnType("datetime")
//            //            .HasDefaultValueSql("getdate()");
//            //    });

//            //    modelBuilder.Entity<User>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("iOid_User");

//            //        entity.Property(e => e.Oid).ValueGeneratedNever();

//            //        entity.Property(e => e.StoredPassword).HasMaxLength(100);

//            //        entity.Property(e => e.UserName).HasMaxLength(100);

//            //        entity.HasOne(d => d.O)
//            //            .WithOne(p => p.User)
//            //            .HasForeignKey<User>(d => d.Oid)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_User_Oid");
//            //    });

//            //    modelBuilder.Entity<UserUsersRoleRoles>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_UserUsers_RoleRoles");

//            //        entity.ToTable("UserUsers_RoleRoles");

//            //        entity.HasIndex(e => e.Roles)
//            //            .HasName("iRoles_UserUsers_RoleRoles");

//            //        entity.HasIndex(e => e.Users)
//            //            .HasName("iUsers_UserUsers_RoleRoles");

//            //        entity.HasIndex(e => new { e.Roles, e.Users })
//            //            .HasName("iRolesUsers_UserUsers_RoleRoles")
//            //            .IsUnique();

//            //        entity.Property(e => e.Oid)
//            //            .HasColumnName("OID")
//            //            .ValueGeneratedNever();

//            //        entity.Property(e => e.Roles).IsRequired();

//            //        entity.Property(e => e.Users).IsRequired();

//            //        entity.HasOne(d => d.RolesNavigation)
//            //            .WithMany(p => p.UserUsersRoleRoles)
//            //            .HasForeignKey(d => d.Roles)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_UserUsers_RoleRoles_Roles");

//            //        entity.HasOne(d => d.UsersNavigation)
//            //            .WithMany(p => p.UserUsersRoleRoles)
//            //            .HasForeignKey(d => d.Users)
//            //            .OnDelete(DeleteBehavior.Restrict)
//            //            .HasConstraintName("FK_UserUsers_RoleRoles_Users");
//            //    });

//            //    modelBuilder.Entity<Models.Version>(entity =>
//            //    {
//            //        entity.Property(e => e.VersionId)
//            //            .HasColumnName("VersionID")
//            //            .ValueGeneratedNever();

//            //        entity.Property(e => e.InstallDate).HasColumnType("datetime");
//            //    });

//            //    modelBuilder.Entity<XpobjectType>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_XPObjectType");

//            //        entity.ToTable("XPObjectType");

//            //        entity.HasIndex(e => e.TypeName)
//            //            .HasName("iTypeName_XPObjectType")
//            //            .IsUnique();

//            //        entity.Property(e => e.Oid).HasColumnName("OID");

//            //        entity.Property(e => e.AssemblyName).HasMaxLength(254);

//            //        entity.Property(e => e.TypeName)
//            //            .IsRequired()
//            //            .HasMaxLength(254);
//            //    });

//            //    modelBuilder.Entity<XpweakReference>(entity =>
//            //    {
//            //        entity.HasKey(e => e.Oid)
//            //            .HasName("PK_XPWeakReference");

//            //        entity.ToTable("XPWeakReference");

//            //        entity.HasIndex(e => e.ObjectType)
//            //            .HasName("iObjectType_XPWeakReference");

//            //        entity.HasIndex(e => e.TargetType)
//            //            .HasName("iTargetType_XPWeakReference");

//            //        entity.Property(e => e.Oid).ValueGeneratedNever();

//            //        entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

//            //        entity.Property(e => e.TargetKey).HasMaxLength(100);

//            //        entity.HasOne(d => d.ObjectTypeNavigation)
//            //            .WithMany(p => p.XpweakReferenceObjectTypeNavigation)
//            //            .HasForeignKey(d => d.ObjectType)
//            //            .HasConstraintName("FK_XPWeakReference_ObjectType");

//            //        entity.HasOne(d => d.TargetTypeNavigation)
//            //            .WithMany(p => p.XpweakReferenceTargetTypeNavigation)
//            //            .HasForeignKey(d => d.TargetType)
//            //            .HasConstraintName("FK_XPWeakReference_TargetType");
//            //    });
//            //}

//            //public virtual DbSet<AccountPayable> AccountPayable { get; set; }
//            //public virtual DbSet<AccountPayable2> AccountPayable2 { get; set; }
//            //public virtual DbSet<AccountPayableDetail> AccountPayableDetail { get; set; }
//            //public virtual DbSet<AccountPrepayment1> AccountPrepayment1 { get; set; }
//            //public virtual DbSet<AccountPrepaymentDetail1> AccountPrepaymentDetail1 { get; set; }
//            //public virtual DbSet<AccountReceivable> AccountReceivable { get; set; }
//            //public virtual DbSet<AccountReceivable1> AccountReceivable1 { get; set; }
//            //public virtual DbSet<AccountReceivableDetail> AccountReceivableDetail { get; set; }
//            //public virtual DbSet<AccountReceivablePaymentTerm> AccountReceivablePaymentTerm { get; set; }
//            //public virtual DbSet<Address> Address { get; set; }
//            //public virtual DbSet<Address1> Address1 { get; set; }
//            //public virtual DbSet<AllconExtract> AllconExtract { get; set; }
//            //public virtual DbSet<AllrsExtract> AllrsExtract { get; set; }
//            //public virtual DbSet<AllstldExtract> AllstldExtract { get; set; }
//            //public virtual DbSet<Analysis> Analysis { get; set; }
//            //public virtual DbSet<AuditDataItemPersistent> AuditDataItemPersistent { get; set; }
//            //public virtual DbSet<AuditedObjectWeakReference> AuditedObjectWeakReference { get; set; }
//            //public virtual DbSet<BasicUser> BasicUser { get; set; }
//            //public virtual DbSet<BoardOfTrade> BoardOfTrade { get; set; }
//            //public virtual DbSet<BoardOfTrade1> BoardOfTrade1 { get; set; }
//            //public virtual DbSet<BuildBasis> BuildBasis { get; set; }
//            //public virtual DbSet<BuildBasisImport> BuildBasisImport { get; set; }
//            //public virtual DbSet<BusinessAssociateExternal> BusinessAssociateExternal { get; set; }
//            //public virtual DbSet<BusinessAssociateInternal> BusinessAssociateInternal { get; set; }
//            //public virtual DbSet<ChartOfAccount> ChartOfAccount { get; set; }
//            //public virtual DbSet<Commodity> Commodity { get; set; }
//            //public virtual DbSet<CommodityBoardOfTrade> CommodityBoardOfTrade { get; set; }
//            //public virtual DbSet<Contact> Contact { get; set; }
//            //public virtual DbSet<Contract> Contract { get; set; }
//            //public virtual DbSet<Contract1> Contract1 { get; set; }
//            //public virtual DbSet<Contract3> Contract3 { get; set; }
//            //public virtual DbSet<ContractPricingSummary> ContractPricingSummary { get; set; }
//            //public virtual DbSet<ContractPricingSummary1> ContractPricingSummary1 { get; set; }
//            //public virtual DbSet<ContractType> ContractType { get; set; }
//            //public virtual DbSet<ContractType1> ContractType1 { get; set; }
//            //public virtual DbSet<Country> Country { get; set; }
//            //public virtual DbSet<DailyPositionTotal> DailyPositionTotal { get; set; }
//            //public virtual DbSet<DataSet> DataSet { get; set; }
//            //public virtual DbSet<DataSource> DataSource { get; set; }
//            //public virtual DbSet<DataSourceState> DataSourceState { get; set; }
//            //public virtual DbSet<DataSourceSystem> DataSourceSystem { get; set; }
//            //public virtual DbSet<DataSourceSystemGroup> DataSourceSystemGroup { get; set; }
//            //public virtual DbSet<DataSourceType> DataSourceType { get; set; }
//            //public virtual DbSet<DeliverySchedule1> DeliverySchedule1 { get; set; }
//            //public virtual DbSet<DeliverySchedule2> DeliverySchedule2 { get; set; }
//            //public virtual DbSet<DiscountCode> DiscountCode { get; set; }
//            //public virtual DbSet<DiscountCodeType> DiscountCodeType { get; set; }
//            //public virtual DbSet<DiscountEvent> DiscountEvent { get; set; }
//            //public virtual DbSet<DiscountPremium> DiscountPremium { get; set; }
//            //public virtual DbSet<Dtnfeed> Dtnfeed { get; set; }
//            //public virtual DbSet<Dtnfuture> Dtnfuture { get; set; }
//            //public virtual DbSet<Dtnhistory> Dtnhistory { get; set; }
//            //public virtual DbSet<Event> Event { get; set; }
//            //public virtual DbSet<ExportCatalog> ExportCatalog { get; set; }
//            //public virtual DbSet<FileData> FileData { get; set; }
//            //public virtual DbSet<GeneralLedgerDetail> GeneralLedgerDetail { get; set; }
//            //public virtual DbSet<Hcategory> Hcategory { get; set; }
//            //public virtual DbSet<IdgeneratorTable> IdgeneratorTable { get; set; }
//            //public virtual DbSet<JobArea> JobArea { get; set; }
//            //public virtual DbSet<JobHistory> JobHistory { get; set; }
//            //public virtual DbSet<Locale> Locale { get; set; }
//            //public virtual DbSet<Location> Location { get; set; }
//            //public virtual DbSet<LocationCommodity> LocationCommodity { get; set; }
//            //public virtual DbSet<MarketBasisPrice> MarketBasisPrice { get; set; }
//            //public virtual DbSet<MarketBasisPrice2> MarketBasisPrice2 { get; set; }
//            //public virtual DbSet<MarketBasisPrice3> MarketBasisPrice3 { get; set; }
//            //public virtual DbSet<MarketSituation> MarketSituation { get; set; }
//            //public virtual DbSet<MarketZone> MarketZone { get; set; }
//            //public virtual DbSet<ModuleInfo> ModuleInfo { get; set; }
//            //public virtual DbSet<NameAddress> NameAddress { get; set; }
//            //public virtual DbSet<NameAddress1> NameAddress1 { get; set; }
//            //public virtual DbSet<Note> Note { get; set; }
//            //public virtual DbSet<ObjectDependencies> ObjectDependencies { get; set; }
//            //public virtual DbSet<Objects> Objects { get; set; }
//            //public virtual DbSet<Obligation> Obligation { get; set; }
//            //public virtual DbSet<Office> Office { get; set; }
//            //public virtual DbSet<OptionMonth> OptionMonth { get; set; }
//            //public virtual DbSet<OptionType> OptionType { get; set; }
//            //public virtual DbSet<OrderType> OrderType { get; set; }
//            //public virtual DbSet<Organization> Organization { get; set; }
//            //public virtual DbSet<Party> Party { get; set; }
//            //public virtual DbSet<PermissionData> PermissionData { get; set; }
//            //public virtual DbSet<PermissionsContainer> PermissionsContainer { get; set; }
//            //public virtual DbSet<PersistentPermission> PersistentPermission { get; set; }
//            //public virtual DbSet<Person> Person { get; set; }
//            //public virtual DbSet<PhoneNumber> PhoneNumber { get; set; }
//            //public virtual DbSet<PhoneType> PhoneType { get; set; }
//            //public virtual DbSet<PositionType> PositionType { get; set; }
//            //public virtual DbSet<Preference> Preference { get; set; }
//            //public virtual DbSet<Product> Product { get; set; }
//            //public virtual DbSet<PropertyBag> PropertyBag { get; set; }
//            //public virtual DbSet<PropertyBagDescriptor> PropertyBagDescriptor { get; set; }
//            //public virtual DbSet<PropertyDescriptor> PropertyDescriptor { get; set; }
//            //public virtual DbSet<PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags> PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags { get; set; }
//            //public virtual DbSet<PropertyValue> PropertyValue { get; set; }
//            //public virtual DbSet<RawPriceLocale> RawPriceLocale { get; set; }
//            //public virtual DbSet<ReportExtract> ReportExtract { get; set; }
//            //public virtual DbSet<ReportExtractLog> ReportExtractLog { get; set; }
//            //public virtual DbSet<ReportExtractMonth> ReportExtractMonth { get; set; }
//            //public virtual DbSet<ReportExtractType> ReportExtractType { get; set; }
//            //public virtual DbSet<Resource> Resource { get; set; }
//            //public virtual DbSet<ResourceResourcesEventEvents> ResourceResourcesEventEvents { get; set; }
//            //public virtual DbSet<Role> Role { get; set; }
//            //public virtual DbSet<RoleBase> RoleBase { get; set; }
//            //public virtual DbSet<RunScan> RunScan { get; set; }
//            //public virtual DbSet<SecurityRole> SecurityRole { get; set; }
//            //public virtual DbSet<SecurityStrategyRole> SecurityStrategyRole { get; set; }
//            //public virtual DbSet<SecurityUser> SecurityUser { get; set; }
//            //public virtual DbSet<SecurityUserBase> SecurityUserBase { get; set; }
//            //public virtual DbSet<SecurityUserWithRolesBase> SecurityUserWithRolesBase { get; set; }
//            //public virtual DbSet<SecurityUserWithRolesBaseUsersSecurityStrategyRoleRoles> SecurityUserWithRolesBaseUsersSecurityStrategyRoleRoles { get; set; }
//            //public virtual DbSet<ServerPrefix> ServerPrefix { get; set; }
//            //public virtual DbSet<SimpleUser> SimpleUser { get; set; }
//            //public virtual DbSet<State> State { get; set; }
//            //public virtual DbSet<StateRegion> StateRegion { get; set; }
//            //public virtual DbSet<Sysdtslog90> Sysdtslog90 { get; set; }
//            //public virtual DbSet<Task> Task { get; set; }
//            //public virtual DbSet<Ticket> Ticket { get; set; }
//            //public virtual DbSet<TicketApplication> TicketApplication { get; set; }
//            //public virtual DbSet<TicketApplicationHistory> TicketApplicationHistory { get; set; }
//            //public virtual DbSet<TicketApplicationRelationship> TicketApplicationRelationship { get; set; }
//            //public virtual DbSet<TicketApplicationTranRelationship> TicketApplicationTranRelationship { get; set; }
//            //public virtual DbSet<TicketDiscount> TicketDiscount { get; set; }
//            //public virtual DbSet<TicketDiscountDetail> TicketDiscountDetail { get; set; }
//            //public virtual DbSet<TicketHistory> TicketHistory { get; set; }
//            //public virtual DbSet<TransportationMode> TransportationMode { get; set; }
//            //public virtual DbSet<TransportationMode1> TransportationMode1 { get; set; }
//            //public virtual DbSet<UnitOfMeasure> UnitOfMeasure { get; set; }
//            //public virtual DbSet<UnitOfMeasure2> UnitOfMeasure2 { get; set; }
//            //public virtual DbSet<User> User { get; set; }
//            //public virtual DbSet<UserUsersRoleRoles> UserUsersRoleRoles { get; set; }
//            //public virtual DbSet<Models.Version> Version { get; set; }
//            //public virtual DbSet<XpobjectType> XpobjectType { get; set; }
//            //public virtual DbSet<XpweakReference> XpweakReference { get; set; }

//            // Unable to generate entity type for table 'SmartSoft.BTMQuote'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.BTMOptionMonth'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.DeliveryRelease'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.OutputTestContract'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.C10_DLY_POS_TOTALS'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.C05_COMMODITY_CODE'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.GASTLMST_Raw_old'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.Trader'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.Futures'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.AccountPrepayment'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.C06_CUST_CONTRACTS'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.MarketBasisPrice_20120208'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.GAEMDMST'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.AGCUSMST'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.GALOCMST'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.GACOMMST'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.GAMKTMST'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.GAEMDMST_Raw'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.AGCUSMST_Raw'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.GALOCMST_Raw'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.BuildBasis_130401_0940'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.GACOMMST_Raw'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.C16_PRC_DELIV_SCHD'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.GAMKTMST_Raw'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.GACNTMST_Raw'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.Contract'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.MarketBasisPrice'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.DeliverySchedule'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.R13_GL_DTL_TRAN'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.L01_CHART_OF_ACCTS'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.Numbers'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.C01_TKT_INF'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.Futures'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.sp_depends_xref'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.UnitOfMeasure'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.ContractPricingRelease'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.P13_GL_DTL_TRAN'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.C07_TICKET_APPLICS'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.BuildBasis_20110701_0200'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.BuildBasisImport_20110701_0210'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.C19_ADDL_TIK_DISC'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.R06_IVC_TRMS'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.R03_ACCTS_RECEIVBL'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.tblSSIS_ErrorRows'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.AccountReceivable'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.AccountPrepaymentDetail'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.AccountPayable'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.P06_ACCTS_PYBL'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.LookupConnectionID'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.Audit'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.Check if Commodity Exists'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.ObjectTypes'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.TempGASTLMST'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.R14_AR_TOTALS'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.DISCOUNT_EXTRACT'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.DTNFutureBAK07_06_15'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.DTNFutureBAK07_07_15'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.ObjectAttributes'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.N03_MSC_CD'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.R10_AR_PAYMENTS'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.C40_CON_TYPES'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.C39_TRNSP_MODES'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.BusinessUnit'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.C18_DISCOUNT_CODES'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.Commodity'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.Company'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.Holiday'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.ContractPricing'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.CustomerData'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.N01_NAM_ADR_INF'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.U09_LOC_CD'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.NOTON_EXTRACT'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.deliveryschedule_backup_090821'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.ManualLimitAllocations'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.MarketZone'. Please see the warning messages.
//            // Unable to generate entity type for table 'AgrisStaging.C22_MKT_BASIS_PRC'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.MarketPrice'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.MarketQuote'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.stateregion0915'. Please see the warning messages.
//            // Unable to generate entity type for table 'dbo.DiscountPremium_110208'. Please see the warning messages.
//            // Unable to generate entity type for table 'SmartSoft.BTMBasis'. Please see the warning messages.
//            // Unable to generate entity type for table 'Summit.GASTLMST_Raw'. Please see the warning messages.
//        }
//    }
//}