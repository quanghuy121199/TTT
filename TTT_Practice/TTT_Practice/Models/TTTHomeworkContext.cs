using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TTT_Practice.Models
{
    public partial class TTTHomeworkContext : DbContext
    {
        public TTTHomeworkContext()
        {
        }

        public TTTHomeworkContext(DbContextOptions<TTTHomeworkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<A> A { get; set; }
        public virtual DbSet<SwapsView> SwapsView { get; set; }
        public virtual DbSet<SwapsViewAc> SwapsViewAc { get; set; }
        public virtual DbSet<SwapsViewDt> SwapsViewDt { get; set; }
        public virtual DbSet<SwapsViewHt> SwapsViewHt { get; set; }
        public virtual DbSet<SwapsViewIt> SwapsViewIt { get; set; }
        public virtual DbSet<TblCusipMaster> TblCusipMaster { get; set; }
        public virtual DbSet<TblCustomerSetup> TblCustomerSetup { get; set; }
        public virtual DbSet<TblDrvInstruments> TblDrvInstruments { get; set; }
        public virtual DbSet<TblHoldingType> TblHoldingType { get; set; }
        public virtual DbSet<TblSwapState> TblSwapState { get; set; }
        public virtual DbSet<TblSwapTerminations> TblSwapTerminations { get; set; }
        public virtual DbSet<TblSwaps> TblSwaps { get; set; }
        public virtual DbSet<TlkpDerivativeTypes> TlkpDerivativeTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source= HUYLE; Initial Catalog=TTTHomework; User ID=sa; Password=huy121199");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<A>(entity =>
            {
                entity.Property(e => e.AId).HasColumnName("A_ID");
            });

            modelBuilder.Entity<SwapsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SwapsView");

                entity.Property(e => e.Account)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DerivativeType)
                    .HasColumnName("Derivative Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DerivativeTypeId).HasColumnName("Derivative Type ID");

                entity.Property(e => e.HoldingType)
                    .HasColumnName("Holding Type")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.HoldingTypeId).HasColumnName("Holding Type ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Instrument)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.InstrumentId).HasColumnName("Instrument ID");

                entity.Property(e => e.LastProcessedDate)
                    .HasColumnName("Last Processed Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SwapId).HasColumnName("Swap ID");

                entity.Property(e => e.SwapName)
                    .IsRequired()
                    .HasColumnName("Swap Name")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SwapsViewAc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SwapsViewAc");

                entity.Property(e => e.Account)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DerivativeType)
                    .HasColumnName("Derivative Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DerivativeTypeId).HasColumnName("Derivative Type ID");

                entity.Property(e => e.HoldingType)
                    .HasColumnName("Holding Type")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.HoldingTypeId).HasColumnName("Holding Type ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Instrument)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.InstrumentId).HasColumnName("Instrument ID");

                entity.Property(e => e.LastProcessedDate)
                    .HasColumnName("Last Processed Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SwapId).HasColumnName("Swap ID");

                entity.Property(e => e.SwapName)
                    .IsRequired()
                    .HasColumnName("Swap Name")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SwapsViewDt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SwapsViewDt");

                entity.Property(e => e.Account)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DerivativeType)
                    .HasColumnName("Derivative Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DerivativeTypeId).HasColumnName("Derivative Type ID");

                entity.Property(e => e.HoldingType)
                    .HasColumnName("Holding Type")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.HoldingTypeId).HasColumnName("Holding Type ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Instrument)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.InstrumentId).HasColumnName("Instrument ID");

                entity.Property(e => e.LastProcessedDate)
                    .HasColumnName("Last Processed Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SwapId).HasColumnName("Swap ID");

                entity.Property(e => e.SwapName)
                    .IsRequired()
                    .HasColumnName("Swap Name")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SwapsViewHt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SwapsViewHt");

                entity.Property(e => e.Account)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DerivativeType)
                    .HasColumnName("Derivative Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DerivativeTypeId).HasColumnName("Derivative Type ID");

                entity.Property(e => e.HoldingType)
                    .HasColumnName("Holding Type")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.HoldingTypeId).HasColumnName("Holding Type ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Instrument)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.InstrumentId).HasColumnName("Instrument ID");

                entity.Property(e => e.LastProcessedDate)
                    .HasColumnName("Last Processed Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SwapId).HasColumnName("Swap ID");

                entity.Property(e => e.SwapName)
                    .IsRequired()
                    .HasColumnName("Swap Name")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SwapsViewIt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SwapsViewIt");

                entity.Property(e => e.Account)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DerivativeType)
                    .HasColumnName("Derivative Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DerivativeTypeId).HasColumnName("Derivative Type ID");

                entity.Property(e => e.HoldingType)
                    .HasColumnName("Holding Type")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.HoldingTypeId).HasColumnName("Holding Type ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Instrument)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.InstrumentId).HasColumnName("Instrument ID");

                entity.Property(e => e.LastProcessedDate)
                    .HasColumnName("Last Processed Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SwapId).HasColumnName("Swap ID");

                entity.Property(e => e.SwapName)
                    .IsRequired()
                    .HasColumnName("Swap Name")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCusipMaster>(entity =>
            {
                entity.HasKey(e => e.CpintCusipMasterId)
                    .HasName("PK_tblCusipMaster_cpintCusipMasterID");

                entity.ToTable("tblCusipMaster");

                entity.Property(e => e.CpintCusipMasterId).HasColumnName("cpintCusipMasterID");

                entity.Property(e => e.Callability)
                    .HasColumnName("_CALLABILITY")
                    .HasComment("CALLABILITY SECTION");

                entity.Property(e => e.CpChargeOffBalance)
                    .HasColumnName("cpChargeOffBalance")
                    .HasColumnType("money");

                entity.Property(e => e.CpFaceAmount)
                    .HasColumnName("cpFaceAmount")
                    .HasColumnType("money");

                entity.Property(e => e.CpLoanCommitment)
                    .HasColumnName("cpLoanCommitment")
                    .HasColumnType("money");

                entity.Property(e => e.CpMargin)
                    .HasColumnName("cpMargin")
                    .HasColumnType("money");

                entity.Property(e => e.CpNetAmountPayable)
                    .HasColumnName("cpNetAmountPayable")
                    .HasColumnType("money");

                entity.Property(e => e.CpPayableBuyer)
                    .HasColumnName("cpPayableBuyer")
                    .HasColumnType("money");

                entity.Property(e => e.CpPayableSeller)
                    .HasColumnName("cpPayableSeller")
                    .HasColumnType("money");

                entity.Property(e => e.CpPrincipalSold)
                    .HasColumnName("cpPrincipalSold")
                    .HasColumnType("money");

                entity.Property(e => e.CpStubAmortInterestAmount)
                    .HasColumnName("cpStubAmortInterestAmount")
                    .HasColumnType("money");

                entity.Property(e => e.CpStubRateInterestAmount)
                    .HasColumnName("cpStubRateInterestAmount")
                    .HasColumnType("money");

                entity.Property(e => e.CpTransferFee)
                    .HasColumnName("cpTransferFee")
                    .HasColumnType("money");

                entity.Property(e => e.CpUnfundedLoanCommitment)
                    .HasColumnName("cpUnfundedLoanCommitment")
                    .HasColumnType("money");

                entity.Property(e => e.CpbitCallSchedule).HasColumnName("cpbitCallSchedule");

                entity.Property(e => e.CpblnFdichighSecuritization).HasColumnName("cpblnFDICHighSecuritization");

                entity.Property(e => e.CpblnFrontPay).HasColumnName("cpblnFrontPay");

                entity.Property(e => e.CpblnIncludeEnd).HasColumnName("cpblnIncludeEnd");

                entity.Property(e => e.CpblnIncludeStart).HasColumnName("cpblnIncludeStart");

                entity.Property(e => e.CpblnPayDatesOverridden).HasColumnName("cpblnPayDatesOverridden");

                entity.Property(e => e.CpboolAccrualonPar).HasColumnName("cpboolAccrualonPar");

                entity.Property(e => e.CpboolAmortSprdIncludeinMulti)
                    .HasColumnName("cpboolAmortSprdIncludeinMulti")
                    .HasComment("Amortization  Include Spread  in Multiply Formula");

                entity.Property(e => e.CpboolAmortStubInterest).HasColumnName("cpboolAmortStubInterest");

                entity.Property(e => e.CpboolApplyRateToEntirePeriod).HasColumnName("cpboolApplyRateToEntirePeriod");

                entity.Property(e => e.CpboolBalloon)
                    .HasColumnName("cpboolBalloon")
                    .HasComment("Balloon Payment Structure");

                entity.Property(e => e.CpboolDefaultedDsc)
                    .HasColumnName("cpboolDefaultedDsc")
                    .HasComment("Non-Accrual Status ( .t. ) DEFAULTED");

                entity.Property(e => e.CpboolEom)
                    .HasColumnName("cpboolEOM")
                    .HasComment("End-Of-Month vs Anniversary ( 2/28 - 8/28 - 8/31 )");

                entity.Property(e => e.CpboolEscrowedToMaturityMty)
                    .HasColumnName("cpboolEscrowedToMaturityMty")
                    .HasComment("Escrowed to Maturity  ESCR2MATY");

                entity.Property(e => e.CpboolFederallyTaxableTax)
                    .HasColumnName("cpboolFederallyTaxableTax")
                    .HasComment("Federally Taxable Issue  ( Yes / No )");

                entity.Property(e => e.CpboolFixedRate)
                    .IsRequired()
                    .HasColumnName("cpboolFixedRate")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Fixed vs Variable Rate");

                entity.Property(e => e.CpboolIncludePayDateInPaymentAmount).HasColumnName("cpboolIncludePayDateInPaymentAmount");

                entity.Property(e => e.CpboolIndex1MultiplySpread)
                    .HasColumnName("cpboolIndex1MultiplySpread")
                    .HasComment("Index 1 Include Spread in Multiplication");

                entity.Property(e => e.CpboolIndex2MultiplySpread)
                    .HasColumnName("cpboolIndex2MultiplySpread")
                    .HasComment("Index 2 Include Spread in Multiplication");

                entity.Property(e => e.CpboolMultiFamilyMbs)
                    .HasColumnName("cpboolMultiFamilyMBS")
                    .HasComment("MultiFamily Collateral");

                entity.Property(e => e.CpboolRateOverride)
                    .HasColumnName("cpboolRateOverride")
                    .HasComment("Rate Override ( Always set flag to override in tblRates_Values )");

                entity.Property(e => e.CpboolRateStubInterest).HasColumnName("cpboolRateStubInterest");

                entity.Property(e => e.CpboolRemicTax)
                    .HasColumnName("cpboolRemicTax")
                    .HasComment("Remic \"Classified as\"");

                entity.Property(e => e.CpboolStateTaxableTax)
                    .HasColumnName("cpboolStateTaxableTax")
                    .HasComment("State Taxable Issue  ( Yes / No )");

                entity.Property(e => e.CpcurLotsize)
                    .HasColumnName("cpcurLotsize")
                    .HasColumnType("money");

                entity.Property(e => e.CpcurParValuePerShare)
                    .HasColumnName("cpcurParValuePerShare")
                    .HasColumnType("money");

                entity.Property(e => e.CpdateAmortStubInterest)
                    .HasColumnName("cpdateAmortStubInterest")
                    .HasColumnType("datetime");

                entity.Property(e => e.CpdateAmortizeStart)
                    .HasColumnName("cpdateAmortizeStart")
                    .HasColumnType("datetime")
                    .HasComment("Amortization  Start Date");

                entity.Property(e => e.CpdateAmortizeStop)
                    .HasColumnName("cpdateAmortizeStop")
                    .HasColumnType("datetime")
                    .HasComment("Amortization  Stop  Date");

                entity.Property(e => e.CpdateBegLastAccrual)
                    .HasColumnName("cpdateBegLastAccrual")
                    .HasColumnType("datetime")
                    .HasComment("Beginning of Last  Accrual (optional )");

                entity.Property(e => e.CpdateCallNoticeGiven)
                    .HasColumnName("cpdateCallNoticeGiven")
                    .HasColumnType("datetime")
                    .HasComment("Date Call Notice was given");

                entity.Property(e => e.CpdateCpnFirstPmt)
                    .HasColumnName("cpdateCpnFirstPmt")
                    .HasColumnType("datetime")
                    .HasComment("First Coupon Date");

                entity.Property(e => e.CpdateFirstContinousCall)
                    .HasColumnName("cpdateFirstContinousCall")
                    .HasColumnType("datetime")
                    .HasComment("First call date for contiuously called F_CNT_CALL");

                entity.Property(e => e.CpdateFirstPrincipal)
                    .HasColumnName("cpdateFirstPrincipal")
                    .HasColumnType("datetime");

                entity.Property(e => e.CpdateFirstResetFlt)
                    .HasColumnName("cpdateFirstResetFlt")
                    .HasColumnType("datetime")
                    .HasComment("First Reset Date FIRSTRESET");

                entity.Property(e => e.CpdateIssuedDsc)
                    .HasColumnName("cpdateIssuedDsc")
                    .HasColumnType("datetime")
                    .HasComment("Issue Date IDATE");

                entity.Property(e => e.CpdateLastContinousCall)
                    .HasColumnName("cpdateLastContinousCall")
                    .HasColumnType("datetime")
                    .HasComment("Last call date for contiuously called");

                entity.Property(e => e.CpdateLastUpdated)
                    .HasColumnName("cpdateLastUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Last Update to the record");

                entity.Property(e => e.CpdateModifiedFundingDate)
                    .HasColumnName("cpdateModifiedFundingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CpdateOriginalFundingDate)
                    .HasColumnName("cpdateOriginalFundingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CpdatePreRefundedMty)
                    .HasColumnName("cpdatePreRefundedMty")
                    .HasColumnType("datetime")
                    .HasComment("Date Pre-Refunded To PREREF");

                entity.Property(e => e.CpdateRateStubInterest)
                    .HasColumnName("cpdateRateStubInterest")
                    .HasColumnType("datetime");

                entity.Property(e => e.CpdateStatedMaturityMty)
                    .HasColumnName("cpdateStatedMaturityMty")
                    .HasColumnType("datetime")
                    .HasComment("Stated Maturity MDATE");

                entity.Property(e => e.CpdateTdr)
                    .HasColumnName("cpdateTDR")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cpdatemtgadjdate)
                    .HasColumnName("cpdatemtgadjdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CpdblAmortIndexMultiplier)
                    .HasColumnName("cpdblAmortIndexMultiplier")
                    .HasComment("Amortization  Multiplier");

                entity.Property(e => e.CpdblAmortSpread)
                    .HasColumnName("cpdblAmortSpread")
                    .HasComment("Amortization  Spread in Basis Points ( Margin )");

                entity.Property(e => e.CpdblCleanupCallPct)
                    .HasColumnName("cpdblCleanupCallPct")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Cleanup Call Percent");

                entity.Property(e => e.CpdblCollateralCpn).HasColumnName("cpdblCollateralCpn");

                entity.Property(e => e.CpdblGrossMgn).HasColumnName("cpdblGrossMGN");

                entity.Property(e => e.CpdblIndex1Multiplier)
                    .HasColumnName("cpdblIndex1Multiplier")
                    .HasComment("Index 1 Multiplier");

                entity.Property(e => e.CpdblIndex1Spread)
                    .HasColumnName("cpdblIndex1Spread")
                    .HasComment("Index 1 Spread");

                entity.Property(e => e.CpdblIndex2Multiplier)
                    .HasColumnName("cpdblIndex2Multiplier")
                    .HasComment("Index 2 Multiplier");

                entity.Property(e => e.CpdblIndex2Spread)
                    .HasColumnName("cpdblIndex2Spread")
                    .HasComment("Index 2 Spread");

                entity.Property(e => e.CpdblLifeCapFlt)
                    .HasColumnName("cpdblLifeCapFlt")
                    .HasComment("Life Cap");

                entity.Property(e => e.CpdblLifeFloorFlt)
                    .HasColumnName("cpdblLifeFloorFlt")
                    .HasComment("Life Floor");

                entity.Property(e => e.CpdblNetWghtdAveCpnPmt)
                    .HasColumnName("cpdblNetWghtdAveCpnPmt")
                    .HasComment("Net WAC ( Weighted Average Coupon ) NWAC");

                entity.Property(e => e.CpdblOriginalIssueDiscountTax)
                    .HasColumnName("cpdblOriginalIssueDiscountTax")
                    .HasComment("Original Issue Discount");

                entity.Property(e => e.CpdblPeriodicCapFlt)
                    .HasColumnName("cpdblPeriodicCapFlt")
                    .HasComment("Periodic Cap   P_CAP");

                entity.Property(e => e.CpdblPeriodicFloorFlt)
                    .HasColumnName("cpdblPeriodicFloorFlt")
                    .HasComment("Periodic Floor");

                entity.Property(e => e.CpdblPreRefundedPriceMty)
                    .HasColumnName("cpdblPreRefundedPriceMty")
                    .HasComment("Price Pre-Refunded To  PREREFAMT");

                entity.Property(e => e.CpdblRefinanceFee)
                    .HasColumnName("cpdblRefinanceFee")
                    .HasComment("Refinance Fee");

                entity.Property(e => e.CpdblServicingPctPmt)
                    .HasColumnName("cpdblServicingPctPmt")
                    .HasDefaultValueSql("((0.5))")
                    .HasComment("Servicing Pct  SERVICING");

                entity.Property(e => e.CpdblTeaserFlt)
                    .HasColumnName("cpdblTeaserFlt")
                    .HasComment("Initial Teaser Rate VRM MBS  TEASER");

                entity.Property(e => e.CpdtFirstPrincipalPayment)
                    .HasColumnName("cpdtFirstPrincipalPayment")
                    .HasColumnType("datetime");

                entity.Property(e => e.CpdtFirstSettlement)
                    .HasColumnName("cpdtFirstSettlement")
                    .HasColumnType("date");

                entity.Property(e => e.CpiDelayDayConventionId).HasColumnName("cpiDelayDayConvention_ID");

                entity.Property(e => e.CpintAccrBusDayConv).HasColumnName("cpintAccrBusDayConv");

                entity.Property(e => e.CpintAccrHolidaysListId).HasColumnName("cpintAccrHolidaysListID");

                entity.Property(e => e.CpintAccrualStatus).HasColumnName("cpintAccrualStatus");

                entity.Property(e => e.CpintActualDelay)
                    .HasColumnName("cpintActualDelay")
                    .HasComment("Actual Delay Days");

                entity.Property(e => e.CpintAlmgroupId)
                    .HasColumnName("cpintALMGroupID")
                    .HasComment("ALM Group");

                entity.Property(e => e.CpintAmortFreq)
                    .HasColumnName("cpintAmortFreq")
                    .HasComment("Amortization  Frequency");

                entity.Property(e => e.CpintAmortIndexId)
                    .HasColumnName("cpintAmortIndexID")
                    .HasComment("Amortization  Index  Name ( Id )");

                entity.Property(e => e.CpintAmortIndexRoundAt)
                    .HasColumnName("cpintAmortIndexRoundAt")
                    .HasComment("Amortization  Round or Truncate at Character on Output");

                entity.Property(e => e.CpintAmortIndexRoundId)
                    .HasColumnName("cpintAmortIndexRoundID")
                    .HasComment("Amortization  Index (R)ound , (T)runcate,(N)");

                entity.Property(e => e.CpintAmortLookbackDays)
                    .HasColumnName("cpintAmortLookbackDays")
                    .HasComment("Amortization  Lookback in days");

                entity.Property(e => e.CpintAmortTerm).HasColumnName("cpintAmortTerm");

                entity.Property(e => e.CpintAmortType).HasColumnName("cpintAmortType");

                entity.Property(e => e.CpintAmortlkbDbusDayConv)
                    .HasColumnName("cpintAmortlkbDBusDayConv")
                    .HasComment("Amortization  Business Day Convention for Lookback (only if Actual Days selected in the above field)");

                entity.Property(e => e.CpintAmortlkbDconvention)
                    .HasColumnName("cpintAmortlkbDConvention")
                    .HasComment("Amortization Convention - Actual / Business Days");

                entity.Property(e => e.CpintAmortlkbDholidays)
                    .HasColumnName("cpintAmortlkbDHolidays")
                    .HasComment("Amortization  Lookback  according to Holiday list");

                entity.Property(e => e.CpintBloombergKeysId)
                    .HasColumnName("cpintBloombergKeysID")
                    .HasDefaultValueSql("((6))")
                    .HasComment("Bloomberg \"Yellow\"  Key");

                entity.Property(e => e.CpintCallTypeId)
                    .HasColumnName("cpintCallTypeID")
                    .HasComment("Call Type ID ( Continously / Discreetly / Scheduled )");

                entity.Property(e => e.CpintChargeOffStatus).HasColumnName("cpintChargeOffStatus");

                entity.Property(e => e.CpintCleanupCallPct)
                    .HasColumnName("cpintCleanupCallPct")
                    .HasColumnType("numeric(10, 6)")
                    .HasComment("Cleanup Call Pct");

                entity.Property(e => e.CpintCompoundTypesId)
                    .HasColumnName("cpintCompoundTypesID")
                    .HasComment("Compounding \"Flat\" / \"Regular\"");

                entity.Property(e => e.CpintCountriesId)
                    .HasColumnName("cpintCountriesID")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Country of Issuance");

                entity.Property(e => e.CpintCountriesIdofDomicile).HasColumnName("cpintCountriesIDOfDomicile");

                entity.Property(e => e.CpintCountriesIdofRisk).HasColumnName("cpintCountriesIDOfRisk");

                entity.Property(e => e.CpintCurrenciesId)
                    .HasColumnName("cpintCurrenciesID")
                    .HasDefaultValueSql("((3))")
                    .HasComment("Currency  ID ( Currency Reference )");

                entity.Property(e => e.CpintCusipCollateralId).HasColumnName("cpintCusipCollateralID");

                entity.Property(e => e.CpintDayCountId)
                    .HasColumnName("cpintDayCountID")
                    .HasComment("Day Count Type ( Convention )");

                entity.Property(e => e.CpintDelayInMaty)
                    .HasColumnName("cpintDelayInMaty")
                    .HasComment("Actual Delay Days Inclued in Stated Maturity");

                entity.Property(e => e.CpintEstimatedAccrued).HasColumnName("cpintEstimatedAccrued");

                entity.Property(e => e.CpintFixingBusDayConvId).HasColumnName("cpintFixingBusDayConvID");

                entity.Property(e => e.CpintFixingHolidayListId).HasColumnName("cpintFixingHolidayListID");

                entity.Property(e => e.CpintFixingLag).HasColumnName("cpintFixingLag");

                entity.Property(e => e.CpintFormulaId)
                    .HasColumnName("cpintFormulaID")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Formula ID Points to tblRateFormula");

                entity.Property(e => e.CpintFqcyCompound)
                    .HasColumnName("cpintFqcyCompound")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Instrument Compounds Par / Book Frequency of Compounding ( per annum )");

                entity.Property(e => e.CpintGlgroupId).HasColumnName("cpintGLGroupID");

                entity.Property(e => e.CpintHoldingTypeId)
                    .HasColumnName("cpintHoldingTypeID")
                    .HasComment("Holding Type ID ( From Holding Types Table )");

                entity.Property(e => e.CpintImpairmentStatus).HasColumnName("cpintImpairmentStatus");

                entity.Property(e => e.CpintIncludePayDateInPaymentAmount).HasColumnName("cpintIncludePayDateInPaymentAmount");

                entity.Property(e => e.CpintIndex1IndicesId)
                    .HasColumnName("cpintIndex1IndicesID")
                    .HasComment("Index 1 Name ( Id )");

                entity.Property(e => e.CpintIndex1RoundDecimal)
                    .HasColumnName("cpintIndex1RoundDecimal")
                    .HasComment("Index Round or Truncate at Character on Output");

                entity.Property(e => e.CpintIndex1RoundId)
                    .HasColumnName("cpintIndex1RoundID")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Index (R)ound , (T)runcate,(N)");

                entity.Property(e => e.CpintIndex2IndicesId)
                    .HasColumnName("cpintIndex2IndicesID")
                    .HasComment("Index 2 Name ( Id )");

                entity.Property(e => e.CpintIndex2RoundDecimal)
                    .HasColumnName("cpintIndex2RoundDecimal")
                    .HasComment("Index Round or Truncate at Character on Output");

                entity.Property(e => e.CpintIndex2RoundId)
                    .HasColumnName("cpintIndex2RoundID")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Index (R)ound , (T)runcate,(N)");

                entity.Property(e => e.CpintInflationIndexId).HasColumnName("cpintInflationIndexID");

                entity.Property(e => e.CpintIntFrequency).HasColumnName("cpintIntFrequency");

                entity.Property(e => e.CpintIoperiod).HasColumnName("cpintIOPeriod");

                entity.Property(e => e.CpintLoanTerm).HasColumnName("cpintLoanTerm");

                entity.Property(e => e.CpintLookBackBusCalendarId)
                    .HasColumnName("cpintLookBackBusCalendarID")
                    .HasComment("Look Back Bus CalendarID");

                entity.Property(e => e.CpintLookBackBusDayConvId)
                    .HasColumnName("cpintLookBackBusDayConvID")
                    .HasComment("Look Back Bus Day Convention ID");

                entity.Property(e => e.CpintLookBackDays)
                    .HasColumnName("cpintLookBackDays")
                    .HasComment("Look Back Days");

                entity.Property(e => e.CpintLookBackHolidayListId)
                    .HasColumnName("cpintLookBackHolidayListID")
                    .HasComment("Look Back Holiday List ID");

                entity.Property(e => e.CpintNoticeDaysCall)
                    .HasColumnName("cpintNoticeDaysCall")
                    .HasComment("Call Notice in days");

                entity.Property(e => e.CpintObligorId).HasColumnName("cpintObligorID");

                entity.Property(e => e.CpintOccupancy).HasColumnName("cpintOccupancy");

                entity.Property(e => e.CpintOptionCalendarConvId)
                    .HasColumnName("cpintOptionCalendarConvID")
                    .HasComment("Calendar Convention for Option");

                entity.Property(e => e.CpintOptionFrequency)
                    .HasColumnName("cpintOptionFrequency")
                    .HasComment("Option Frequency");

                entity.Property(e => e.CpintPaysInterestPerYearId)
                    .HasColumnName("cpintPaysInterestPerYearID")
                    .HasDefaultValueSql("((9))")
                    .HasComment("Pays Interest Per Year ID");

                entity.Property(e => e.CpintPerformanceStatus).HasColumnName("cpintPerformanceStatus");

                entity.Property(e => e.CpintPmtBusDayConv)
                    .HasColumnName("cpintPmtBusDayConv")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Business Day Convention for Payments Accrual  Direction Rules");

                entity.Property(e => e.CpintPmtEopadjustId)
                    .HasColumnName("cpintPmtEOPAdjustID")
                    .HasComment("Adjust Accrual Period End to Payment Date");

                entity.Property(e => e.CpintPricingFamilyId)
                    .HasColumnName("cpintPricingFamilyID")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Pricing Family");

                entity.Property(e => e.CpintPrincFrequency).HasColumnName("cpintPrincFrequency");

                entity.Property(e => e.CpintPrincipalInterestScheduleId)
                    .HasColumnName("cpintPrincipalInterestScheduleID")
                    .HasComment("Principal Interest Schedule ID");

                entity.Property(e => e.CpintPrincipalInterestTypeId)
                    .HasColumnName("cpintPrincipalInterestTypeID")
                    .HasDefaultValueSql("((3))")
                    .HasComment("Principal Interest Type ID");

                entity.Property(e => e.CpintPrincipalPaymentDelay).HasColumnName("cpintPrincipalPaymentDelay");

                entity.Property(e => e.CpintPrincipalPaymentFreq).HasColumnName("cpintPrincipalPaymentFreq");

                entity.Property(e => e.CpintPropertyType).HasColumnName("cpintPropertyType");

                entity.Property(e => e.CpintRateLockBusCalendarId)
                    .HasColumnName("cpintRateLockBusCalendarID")
                    .HasComment("Rate Locked Business Calendar");

                entity.Property(e => e.CpintRateLockDays)
                    .HasColumnName("cpintRateLockDays")
                    .HasComment("Rate  Days \"Locked in\"");

                entity.Property(e => e.CpintRateLockHolidayListId)
                    .HasColumnName("cpintRateLockHolidayListID")
                    .HasComment("Rate Lock Holidays");

                entity.Property(e => e.CpintRateRoundDecimal)
                    .HasColumnName("cpintRateRoundDecimal")
                    .HasComment("Rate Round or Truncate at Character on Output");

                entity.Property(e => e.CpintRateRoundId)
                    .HasColumnName("cpintRateRoundID")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Rate (R)ound , (T)runcate,(N)");

                entity.Property(e => e.CpintRateTypeId)
                    .HasColumnName("cpintRateTypeID")
                    .HasComment("Rate Type ID ( lookup in tlkpRatesTypes )");

                entity.Property(e => e.CpintRcbclassId).HasColumnName("cpintRCBClassID");

                entity.Property(e => e.CpintRefiNew).HasColumnName("cpintRefiNew");

                entity.Property(e => e.CpintResetBusDayConvId)
                    .HasColumnName("cpintResetBusDayConvID")
                    .HasComment("Reset According to a Business Day Convention");

                entity.Property(e => e.CpintResetEomadjustId)
                    .HasColumnName("cpintResetEOMAdjustID")
                    .HasComment("Reset at  \"True\" end of Month ( 30th vs 31st )");

                entity.Property(e => e.CpintResetFreqFlt)
                    .HasColumnName("cpintResetFreqFlt")
                    .HasComment("Reset Freqency ( Per Year )  RE_FREQ");

                entity.Property(e => e.CpintResetHolidayListId)
                    .HasColumnName("cpintResetHolidayListID")
                    .HasComment("Reset According to a Holiday List");

                entity.Property(e => e.CpintRiskWeightId)
                    .HasColumnName("cpintRiskWeightID")
                    .HasDefaultValueSql("((2))")
                    .HasComment("Regulatory Report Risk Weight RCR Schedule");

                entity.Property(e => e.CpintServicingStatus).HasColumnName("cpintServicingStatus");

                entity.Property(e => e.CpintStressTypeId)
                    .HasColumnName("cpintStressTypeID")
                    .HasComment("Stress Method ID");

                entity.Property(e => e.CpintStructuredId)
                    .HasColumnName("cpintStructuredID")
                    .HasComment("Structured Instruments RCB Classification");

                entity.Property(e => e.CpintUploadToBloomberg)
                    .HasColumnName("cpintUploadToBloomberg")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CpintpmtHolidaysListId)
                    .HasColumnName("cpintpmtHolidaysListID")
                    .HasDefaultValueSql("((2))")
                    .HasComment("Holiday  Settle Payments according to Calendar");

                entity.Property(e => e.CplGuarantorCountryId).HasColumnName("cplGuarantorCountryID");

                entity.Property(e => e.CpsdtIssuedDate)
                    .HasColumnName("cpsdtIssuedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CpsngIssueAmt)
                    .HasColumnName("cpsngIssueAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Issued Amount ( Originally )");

                entity.Property(e => e.CpstrAbsRefId)
                    .HasColumnName("cpstrAbsRefID")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Absolute Reference for this Security Type ABS_RF");

                entity.Property(e => e.CpstrAdjustedLtv)
                    .HasColumnName("cpstrAdjustedLTV")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrAgent)
                    .HasColumnName("cpstrAgent")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrAmortOper)
                    .HasColumnName("cpstrAmortOper")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Amortization  Operator Type");

                entity.Property(e => e.CpstrAmortizingWith)
                    .HasColumnName("cpstrAmortizingWith")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Amortizing with a (S)chedule  or (F)ormula  Empty or (N)  does not amortize");

                entity.Property(e => e.CpstrBankQualified)
                    .HasColumnName("cpstrBankQualified")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasComment("Bank Qualified Acronym");

                entity.Property(e => e.CpstrBbgid)
                    .HasColumnName("cpstrBBGID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrBookrunners)
                    .HasColumnName("cpstrBookrunners")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrBorrower)
                    .HasColumnName("cpstrBorrower")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrCmoAcronym1Id)
                    .HasColumnName("cpstrCmoAcronym1ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("Cmo Acronym 1");

                entity.Property(e => e.CpstrCmoAcronym2Id)
                    .HasColumnName("cpstrCmoAcronym2ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("Cmo Acronym 2");

                entity.Property(e => e.CpstrCmoAcronym3Id)
                    .HasColumnName("cpstrCmoAcronym3ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("Cmo Acronym 3");

                entity.Property(e => e.CpstrCoLeadArranger)
                    .HasColumnName("cpstrCoLeadArranger")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrCurrentRatio)
                    .HasColumnName("cpstrCurrentRatio")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrCusip)
                    .IsRequired()
                    .HasColumnName("cpstrCusip")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CpstrCusipCheckDsc)
                    .HasColumnName("cpstrCusipCheckDsc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Good Cusip Check ( O.K.on Entry or Batch ) CUSIPCHK");

                entity.Property(e => e.CpstrDefaultPxSourceId)
                    .HasColumnName("cpstrDefaultPxSourceID")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.CpstrDesc1)
                    .HasColumnName("cpstrDesc1")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasComment("Description 1");

                entity.Property(e => e.CpstrDesc2)
                    .HasColumnName("cpstrDesc2")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasComment("Description 2");

                entity.Property(e => e.CpstrDscr)
                    .HasColumnName("cpstrDSCR")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrDssrexpRatio)
                    .HasColumnName("cpstrDSSRExpRatio")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrFamilyPrepayment)
                    .HasColumnName("cpstrFamilyPrepayment")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Family - Prepayment");

                entity.Property(e => e.CpstrGuarantor)
                    .HasColumnName("cpstrGuarantor")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrIndex1Operator)
                    .HasColumnName("cpstrIndex1Operator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Index 1 Operator");

                entity.Property(e => e.CpstrIndex2Operator)
                    .HasColumnName("cpstrIndex2Operator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Index 2 Operator");

                entity.Property(e => e.CpstrIndexBetweenOperator)
                    .HasColumnName("cpstrIndexBetweenOperator")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Between Two Indexes in Formula Operator");

                entity.Property(e => e.CpstrInfoLine1Dsc)
                    .HasColumnName("cpstrInfoLine1Dsc")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasComment("Long Description of security DESCRIPTION");

                entity.Property(e => e.CpstrInfoLine2Dsc)
                    .HasColumnName("cpstrInfoLine2Dsc")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasComment("Additional Information on Security Line 1 SEC_INFO");

                entity.Property(e => e.CpstrInvestCode)
                    .HasColumnName("cpstrInvestCode")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasComment("Generic Commonly used Investment Code  ( lookup )    ( TPG Sets Up )");

                entity.Property(e => e.CpstrIsin)
                    .HasColumnName("cpstrISIN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrIssuerId)
                    .HasColumnName("cpstrIssuerID")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("Issuer   ID ISSUER");

                entity.Property(e => e.CpstrLegalAdvisor)
                    .HasColumnName("cpstrLegalAdvisor")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrLender)
                    .HasColumnName("cpstrLender")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrOptionType)
                    .HasColumnName("cpstrOptionType")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('No')")
                    .HasComment("Option Type ( Call / Put / Optional / Mandatory )");

                entity.Property(e => e.CpstrOriginalLtv)
                    .HasColumnName("cpstrOriginalLTV")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrPoolDsc)
                    .HasColumnName("cpstrPoolDsc")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Pool Number for MBS POOL");

                entity.Property(e => e.CpstrPrefix)
                    .HasColumnName("cpstrPrefix")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Prefix ( Suffix ) on MBS, Muni ( GO/RV )  PREFIX");

                entity.Property(e => e.CpstrPrefixDsc)
                    .HasColumnName("cpstrPrefixDsc")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Prefix ( Suffix ) on MBS, Muni ( GO/RV )  PREFIX");

                entity.Property(e => e.CpstrProjectSponsor)
                    .HasColumnName("cpstrProjectSponsor")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrPurpose)
                    .HasColumnName("cpstrPurpose")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrRetainedEarnings)
                    .HasColumnName("cpstrRetainedEarnings")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrSector)
                    .HasColumnName("cpstrSector")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("SECTOR ( lookup )    User subgrouping for  Reports");

                entity.Property(e => e.CpstrSedol)
                    .HasColumnName("cpstrSEDOL")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrServicerId)
                    .HasColumnName("cpstrServicerID")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasComment("Servicer ID  SERVICER");

                entity.Property(e => e.CpstrShortDsc)
                    .HasColumnName("cpstrShortDsc")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasComment("Short Description");

                entity.Property(e => e.CpstrStateIssuedInId)
                    .HasColumnName("cpstrStateIssuedInID")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("State ( Muni ) Bond Issued in STATE");

                entity.Property(e => e.CpstrType)
                    .HasColumnName("cpstrType")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CpstrUserDef01)
                    .HasColumnName("cpstrUserDef01")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasComment("User Defined");

                entity.Property(e => e.CpszArmSubType)
                    .HasColumnName("cpszArmSubType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpszCollatType)
                    .HasColumnName("cpszCollatType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpszConvertible)
                    .HasColumnName("cpszConvertible")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpszCreditEnhancements)
                    .HasColumnName("cpszCreditEnhancements")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CpszGuarantor)
                    .HasColumnName("cpszGuarantor")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CpszIssuerIndustry)
                    .HasColumnName("cpszIssuerIndustry")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CpszNextResetMonths)
                    .HasColumnName("cpszNextResetMonths")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpszOriginatorServicer)
                    .HasColumnName("cpszOriginatorServicer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CpszTrancheType)
                    .HasColumnName("cpszTrancheType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtLastUpdateDt)
                    .HasColumnName("dtLastUpdate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DvboolAmount).HasColumnName("dvboolAmount");

                entity.Property(e => e.Floater)
                    .HasColumnName("_FLOATER")
                    .HasComment("FLOATER- Variable Rate");

                entity.Property(e => e.FloaterRateDtrm)
                    .HasColumnName("FLOATER_RATE_DTRM")
                    .HasComment("Floater Rate Determinants ( Formula builder ) @ Reset Point");

                entity.Property(e => e.IConcurrencyId).HasColumnName("iConcurrency_id");

                entity.Property(e => e.InstrumentsSettings)
                    .HasColumnName("_INSTRUMENTS_SETTINGS")
                    .HasComment("_INSTRUMENTS_SETTINGS");

                entity.Property(e => e.Maturity)
                    .HasColumnName("_MATURITY")
                    .HasComment("Maturity Section ) Mty ");

                entity.Property(e => e.Need2stress)
                    .HasColumnName("NEED2STRESS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.OriginalAmortizeDtrm)
                    .HasColumnName("ORIGINAL_AMORTIZE_DTRM")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("INDEX AMORTIZING Notes  DETERMINANTS ( Amortizing Original Issued Amount )");

                entity.Property(e => e.Payment)
                    .HasColumnName("_PAYMENT")
                    .HasComment("PAYMENT SECTION");

                entity.Property(e => e.ProcessableId)
                    .HasColumnName("Processable_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportableId)
                    .HasColumnName("Reportable_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SLastUpdateId)
                    .HasColumnName("sLastUpdate_id")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SzExchangeCode)
                    .HasColumnName("szExchangeCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tax)
                    .HasColumnName("_TAX")
                    .HasComment("_TAX SECTION");

                entity.Property(e => e.UseEnteredRate).HasComment("Use Entered Rate (Ignore Formula for a Floater ) Cur_Rate_Value_CC");

                entity.Property(e => e.VisibleId)
                    .HasColumnName("Visible_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Zelect).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblCustomerSetup>(entity =>
            {
                entity.HasKey(e => e.CtintCustomerSetupId)
                    .IsClustered(false);

                entity.ToTable("tblCustomerSetup");

                entity.HasIndex(e => e.CtstrCustomerAccount)
                    .HasName("IX_tblCustomerSetup")
                    .IsUnique();

                entity.Property(e => e.CtintCustomerSetupId).HasColumnName("ctintCustomerSetupID");

                entity.Property(e => e.AccountingDefaults).HasColumnName("_ACCOUNTING_DEFAULTS");

                entity.Property(e => e.BuyingHabits).HasColumnName("_BUYING_HABITS");

                entity.Property(e => e.Compliance).HasColumnName("_COMPLIANCE");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("Create_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasColumnName("Create_User")
                    .HasMaxLength(30);

                entity.Property(e => e.CreditRating).HasColumnName("_CREDIT_RATING");

                entity.Property(e => e.CreditRisk).HasColumnName("_CREDIT_RISK");

                entity.Property(e => e.CtDayStartMonthlyProcessing).HasColumnName("ctDayStartMonthlyProcessing");

                entity.Property(e => e.CtDepositAgreementDt)
                    .HasColumnName("ctDepositAgreement_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtDerivativeAgreementDt)
                    .HasColumnName("ctDerivativeAgreement_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtSweepAgreementDt)
                    .HasColumnName("ctSweepAgreement_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtbitGainOnCalls)
                    .HasColumnName("ctbitGainOnCalls")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CtbitLossOnCalls)
                    .HasColumnName("ctbitLossOnCalls")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CtbitUseCallNotice).HasColumnName("ctbitUseCallNotice");

                entity.Property(e => e.CtblnAccountForms).HasColumnName("ctblnAccountForms");

                entity.Property(e => e.CtblnDepositAgreement).HasColumnName("ctblnDepositAgreement");

                entity.Property(e => e.CtblnDerivateiveBalanceCalc).HasColumnName("ctblnDerivateiveBalanceCalc");

                entity.Property(e => e.CtblnDerivativeAgreement).HasColumnName("ctblnDerivativeAgreement");

                entity.Property(e => e.CtblnExcludeMonthlyProcess).HasColumnName("ctblnExcludeMonthlyProcess");

                entity.Property(e => e.CtblnIfema).HasColumnName("ctblnIFEMA");

                entity.Property(e => e.CtblnInactive).HasColumnName("ctblnInactive");

                entity.Property(e => e.CtblnProcessAccountingMonthly).HasColumnName("ctblnProcessAccountingMonthly");

                entity.Property(e => e.CtblnRepoSweepBalanceCalc).HasColumnName("ctblnRepoSweepBalanceCalc");

                entity.Property(e => e.CtblnSweepAgreement).HasColumnName("ctblnSweepAgreement");

                entity.Property(e => e.CtblnUseDiscountCrvDf).HasColumnName("ctblnUseDiscountCrvDF");

                entity.Property(e => e.CtblnUseFwdRateCrvDf).HasColumnName("ctblnUseFwdRateCrvDF");

                entity.Property(e => e.Ctbool1099Exempt).HasColumnName("ctbool1099Exempt");

                entity.Property(e => e.Ctbool1099HardCopy).HasColumnName("ctbool1099HardCopy");

                entity.Property(e => e.CtboolAlternateMinTaxMthd).HasColumnName("ctboolAlternateMinTaxMthd");

                entity.Property(e => e.CtboolBillingByHoldingCompany)
                    .HasColumnName("ctboolBillingByHoldingCompany")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolCallablesGen).HasColumnName("ctboolCallablesGEN");

                entity.Property(e => e.CtboolCashMethod).HasColumnName("ctboolCashMethod");

                entity.Property(e => e.CtboolClassBsecurities).HasColumnName("ctboolClassBSecurities");

                entity.Property(e => e.CtboolCorporateResolutionOnFile).HasColumnName("ctboolCorporateResolutionOnFile");

                entity.Property(e => e.CtboolCreateConfirmations).HasColumnName("ctboolCreateConfirmations");

                entity.Property(e => e.CtboolCreateCustStatements).HasColumnName("ctboolCreateCustStatements");

                entity.Property(e => e.CtboolCreatePmtAdvice).HasColumnName("ctboolCreatePmtAdvice");

                entity.Property(e => e.CtboolCustomerAdviceEmail)
                    .HasColumnName("ctboolCustomerAdviceEmail")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolCustomerAdviceFax)
                    .HasColumnName("ctboolCustomerAdviceFax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolCustomerAdviceMail)
                    .HasColumnName("ctboolCustomerAdviceMail")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolDealer475).HasColumnName("ctboolDealer475");

                entity.Property(e => e.CtboolDeferredBilling).HasColumnName("ctboolDeferredBilling");

                entity.Property(e => e.CtboolDiscountGen).HasColumnName("ctboolDiscountGEN");

                entity.Property(e => e.CtboolDiscountNoteFeedInto).HasColumnName("ctboolDiscountNoteFeedInto");

                entity.Property(e => e.CtboolDonotRepriceInPurchaseMonth).HasColumnName("ctboolDonotRepriceInPurchaseMonth");

                entity.Property(e => e.CtboolDurationMatch).HasColumnName("ctboolDurationMatch");

                entity.Property(e => e.CtboolEle1278b1).HasColumnName("ctboolELE1278B1");

                entity.Property(e => e.CtboolEle171c).HasColumnName("ctboolELE171C");

                entity.Property(e => e.CtboolExport1099).HasColumnName("ctboolExport1099");

                entity.Property(e => e.CtboolFinancialInstitution).HasColumnName("ctboolFinancialInstitution");

                entity.Property(e => e.CtboolFloaterGen).HasColumnName("ctboolFloaterGEN");

                entity.Property(e => e.CtboolHabitAgencyCmo).HasColumnName("ctboolHabitAgencyCMO");

                entity.Property(e => e.CtboolHabitBuyAbs).HasColumnName("ctboolHabitBuyABS");

                entity.Property(e => e.CtboolHabitCmo).HasColumnName("ctboolHabitCMO");

                entity.Property(e => e.CtboolHabitCurCpnMbs).HasColumnName("ctboolHabitCurCpnMBS");

                entity.Property(e => e.CtboolHabitDiscountMbs).HasColumnName("ctboolHabitDiscountMBS");

                entity.Property(e => e.CtboolHabitDiscountsCmo).HasColumnName("ctboolHabitDiscountsCMO");

                entity.Property(e => e.CtboolHabitMbs).HasColumnName("ctboolHabitMBS");

                entity.Property(e => e.CtboolHabitMidAgeMbs).HasColumnName("ctboolHabitMidAgeMBS");

                entity.Property(e => e.CtboolHabitNewProductionMbs).HasColumnName("ctboolHabitNewProductionMBS");

                entity.Property(e => e.CtboolHabitPremiumCmo).HasColumnName("ctboolHabitPremiumCMO");

                entity.Property(e => e.CtboolHabitPremiumMbs).HasColumnName("ctboolHabitPremiumMBS");

                entity.Property(e => e.CtboolHabitSeasonedMbs).HasColumnName("ctboolHabitSeasonedMBS");

                entity.Property(e => e.CtboolHasForeignOffice).HasColumnName("ctboolHasForeignOffice");

                entity.Property(e => e.CtboolIoincome)
                    .HasColumnName("ctboolIOIncome")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolIolongTerm)
                    .HasColumnName("ctboolIOLongTerm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolIoshortTerm)
                    .HasColumnName("ctboolIOShortTerm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolIsda).HasColumnName("ctboolISDA");

                entity.Property(e => e.CtboolMonitorLimit).HasColumnName("ctboolMonitorLimit");

                entity.Property(e => e.CtboolNationallyChartered).HasColumnName("ctboolNationallyChartered");

                entity.Property(e => e.CtboolPremiumGen).HasColumnName("ctboolPremiumGEN");

                entity.Property(e => e.CtboolPrintHardcopyOnly).HasColumnName("ctboolPrintHardcopyOnly");

                entity.Property(e => e.CtboolProcessAccounting)
                    .IsRequired()
                    .HasColumnName("ctboolProcessAccounting")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.CtboolProcessSafekeeping).HasColumnName("ctboolProcessSafekeeping");

                entity.Property(e => e.CtboolProprietary).HasColumnName("ctboolProprietary");

                entity.Property(e => e.CtboolRepoAgreement).HasColumnName("ctboolRepoAgreement");

                entity.Property(e => e.CtboolReqdByLaw1099Flag)
                    .HasColumnName("ctboolReqdByLaw1099Flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolRfconservative)
                    .HasColumnName("ctboolRFConservative")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolRfhighRisk)
                    .HasColumnName("ctboolRFHighRisk")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolRflow)
                    .HasColumnName("ctboolRFLow")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolRfmoderate)
                    .HasColumnName("ctboolRFModerate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolRfspeculation)
                    .HasColumnName("ctboolRFSpeculation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolRollover).HasColumnName("ctboolRollover");

                entity.Property(e => e.CtboolStateChartered).HasColumnName("ctboolStateChartered");

                entity.Property(e => e.CtboolStructuredGen).HasColumnName("ctboolStructuredGEN");

                entity.Property(e => e.CtboolSwapLiability)
                    .HasColumnName("ctboolSwapLiability")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolSweepDaily).HasColumnName("ctboolSweepDaily");

                entity.Property(e => e.CtboolTrading).HasColumnName("ctboolTrading");

                entity.Property(e => e.CtboolUseBulletCashflow).HasColumnName("ctboolUseBulletCashflow");

                entity.Property(e => e.CtboolUseCleanUpCall).HasColumnName("ctboolUseCleanUpCall");

                entity.Property(e => e.CtboolUseCpcurve).HasColumnName("ctboolUseCPCurve");

                entity.Property(e => e.CtboolUseMarketProjection).HasColumnName("ctboolUseMarketProjection");

                entity.Property(e => e.CtboolUseRepoBalanceCalc).HasColumnName("ctboolUseRepoBalanceCalc");

                entity.Property(e => e.CtboolVrmmbs).HasColumnName("ctboolVRMMBS");

                entity.Property(e => e.CtboolW8reqd)
                    .HasColumnName("ctboolW8Reqd")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolW9exempt).HasColumnName("ctboolW9Exempt");

                entity.Property(e => e.CtboolW9onFile).HasColumnName("ctboolW9OnFile");

                entity.Property(e => e.CtboolemployeeofBbtorI)
                    .HasColumnName("ctboolemployeeofBBTorI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtboolemployeeofBf)
                    .HasColumnName("ctboolemployeeofBF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtcurAssetSize)
                    .HasColumnName("ctcurAssetSize")
                    .HasColumnType("money");

                entity.Property(e => e.CtcurCapitalAmount)
                    .HasColumnName("ctcurCapitalAmount")
                    .HasColumnType("money");

                entity.Property(e => e.CtcurCreditLimit)
                    .HasColumnName("ctcurCreditLimit")
                    .HasColumnType("money");

                entity.Property(e => e.CtcurExposureLimit)
                    .HasColumnName("ctcurExposureLimit")
                    .HasColumnType("money");

                entity.Property(e => e.CtcurIbtfee)
                    .HasColumnName("ctcurIBTFee")
                    .HasColumnType("money");

                entity.Property(e => e.CtcurTier1Capital)
                    .HasColumnName("ctcurTier1Capital")
                    .HasColumnType("money");

                entity.Property(e => e.CtcurTradeLimit)
                    .HasColumnName("ctcurTradeLimit")
                    .HasColumnType("money");

                entity.Property(e => e.CtdateEld1278b1)
                    .HasColumnName("ctdateELD1278B1")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtdateEld171c)
                    .HasColumnName("ctdateELD171C")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtdateLastCreditRatingUpdate)
                    .HasColumnName("ctdateLastCreditRatingUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtdateOpened)
                    .HasColumnName("ctdateOpened")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtdateStartFas133)
                    .HasColumnName("ctdateStartFAS133")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtdateSwapAsOf)
                    .HasColumnName("ctdateSwapAsOf")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtdateSwapHorizon)
                    .HasColumnName("ctdateSwapHorizon")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtdateSwapSettlement)
                    .HasColumnName("ctdateSwapSettlement")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtdateUpdated)
                    .HasColumnName("ctdateUpdated")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtdblAdjPercentage).HasColumnName("ctdblAdjPercentage");

                entity.Property(e => e.CtdblCostOfFunds).HasColumnName("ctdblCostOfFunds");

                entity.Property(e => e.CtdblCreditSpread).HasColumnName("ctdblCreditSpread");

                entity.Property(e => e.CtdblDiscCrvFixedSpread).HasColumnName("ctdblDiscCrvFixedSpread");

                entity.Property(e => e.CtdblFederalTaxRate)
                    .HasColumnName("ctdblFederalTaxRate")
                    .HasDefaultValueSql("((0.34))");

                entity.Property(e => e.CtdblFwdRtCrvFixedSpread).HasColumnName("ctdblFwdRtCrvFixedSpread");

                entity.Property(e => e.CtdblReInvestRate)
                    .HasColumnName("ctdblReInvestRate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtdblSpeedValueCmo)
                    .HasColumnName("ctdblSpeedValueCMO")
                    .HasDefaultValueSql("((800))");

                entity.Property(e => e.CtdblSpeedValueMbs)
                    .HasColumnName("ctdblSpeedValueMBS")
                    .HasDefaultValueSql("((24))");

                entity.Property(e => e.CtdblStateTax)
                    .HasColumnName("ctdblStateTax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtdblSwapMargin).HasColumnName("ctdblSwapMargin");

                entity.Property(e => e.CtdtIfemaonFile)
                    .HasColumnName("ctdtIFEMAOnFile")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtdtInactive)
                    .HasColumnName("ctdtInactive")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtdtIsdaonFile)
                    .HasColumnName("ctdtISDAOnFile")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtintAccountingArmmethodId)
                    .HasColumnName("ctintAccountingARMMethodID")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.CtintAccountingMethodBul)
                    .HasColumnName("ctintAccountingMethodBUL")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.CtintAccountingMethodCmo)
                    .HasColumnName("ctintAccountingMethodCMO")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.CtintAccountingMethodMbs)
                    .HasColumnName("ctintAccountingMethodMBS")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.CtintAccountingSpeedCmo)
                    .HasColumnName("ctintAccountingSpeedCMO")
                    .HasDefaultValueSql("((12))");

                entity.Property(e => e.CtintAccountingSpeedMbs)
                    .HasColumnName("ctintAccountingSpeedMBS")
                    .HasDefaultValueSql("((12))");

                entity.Property(e => e.CtintAmortizeToDateId).HasColumnName("ctintAmortizeToDateID");

                entity.Property(e => e.CtintBankCostCenterId)
                    .HasColumnName("ctintBankCostCenter_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtintBankRelationshipManagerId)
                    .HasColumnName("ctintBankRelationshipManager_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtintBillingId).HasColumnName("ctintBillingID");

                entity.Property(e => e.CtintBranchId)
                    .HasColumnName("ctintBranch_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtintBranchResidencyId).HasColumnName("ctintBranchResidency_id");

                entity.Property(e => e.CtintChartOfAccountId).HasColumnName("ctintChartOfAccountID");

                entity.Property(e => e.CtintChartOfAccountIddg).HasColumnName("ctintChartOfAccountIDDG");

                entity.Property(e => e.CtintClearingAccountTypeId)
                    .HasColumnName("ctintClearingAccountType_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CtintCollateralBucketId).HasColumnName("ctintCollateralBucket_id");

                entity.Property(e => e.CtintComissionId).HasColumnName("ctintComissionID");

                entity.Property(e => e.CtintConstraintBookPrice)
                    .HasColumnName("ctintConstraintBookPrice")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CtintConstraintBookPriceCmo)
                    .HasColumnName("ctintConstraintBookPriceCMO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CtintConstraintBookPriceMbs)
                    .HasColumnName("ctintConstraintBookPriceMBS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CtintConstraintBookPricePortfolio)
                    .HasColumnName("ctintConstraintBookPricePortfolio")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CtintCountriesId).HasColumnName("ctintCountriesID");

                entity.Property(e => e.CtintCountryId)
                    .HasColumnName("ctintCountry_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CtintCreditCurveId).HasColumnName("ctintCreditCurveID");

                entity.Property(e => e.CtintCurrencyId)
                    .HasColumnName("ctintCurrencyID")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.CtintDerivativeBucketId).HasColumnName("ctintDerivativeBucket_id");

                entity.Property(e => e.CtintDerivativeMarginMatrix).HasColumnName("ctintDerivativeMarginMatrix");

                entity.Property(e => e.CtintDiscSpreadCrvId).HasColumnName("ctintDiscSpreadCrvID");

                entity.Property(e => e.CtintDiscountCurveId).HasColumnName("ctintDiscountCurveID");

                entity.Property(e => e.CtintDivisionId)
                    .HasColumnName("ctintDivision_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtintFeeAmortEndDateId).HasColumnName("ctintFeeAmortEndDateID");

                entity.Property(e => e.CtintFeeAmortizationMethod).HasColumnName("ctintFeeAmortizationMethod");

                entity.Property(e => e.CtintFeeAmortizationMethodId)
                    .HasColumnName("ctintFeeAmortizationMethodID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CtintFeeGroupId).HasColumnName("ctintFeeGroup_ID");

                entity.Property(e => e.CtintFwdCurveId).HasColumnName("ctintFwdCurveID");

                entity.Property(e => e.CtintFwdRtSpreadCrvId).HasColumnName("ctintFwdRtSpreadCrvID");

                entity.Property(e => e.CtintHoldingCompanyId).HasColumnName("ctintHoldingCompanyID");

                entity.Property(e => e.CtintHoldingFeeId).HasColumnName("ctintHoldingFee_id");

                entity.Property(e => e.CtintHolidayListIdfas133).HasColumnName("ctintHolidayListIDFAS133");

                entity.Property(e => e.CtintInstitutionType)
                    .HasColumnName("ctintInstitutionType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CtintMarginMatrix).HasColumnName("ctintMarginMatrix");

                entity.Property(e => e.CtintMarginNotlPeriodFreq).HasColumnName("ctintMarginNotlPeriodFreq");

                entity.Property(e => e.CtintMonthOfFiscalYearEnd)
                    .HasColumnName("ctintMonthOfFiscalYearEnd")
                    .HasDefaultValueSql("((12))");

                entity.Property(e => e.CtintNonTransFeeGroup).HasColumnName("ctintNonTransFeeGroup");

                entity.Property(e => e.CtintPledgeBucketId).HasColumnName("ctintPledgeBucket_id");

                entity.Property(e => e.CtintPledgeMarginMatrix).HasColumnName("ctintPledgeMarginMatrix");

                entity.Property(e => e.CtintPledgeMatrix).HasColumnName("ctintPledgeMatrix");

                entity.Property(e => e.CtintPostFrequencyFas133).HasColumnName("ctintPostFrequencyFAS133");

                entity.Property(e => e.CtintPricingDay).HasColumnName("ctintPricingDay");

                entity.Property(e => e.CtintRegionId)
                    .HasColumnName("ctintRegion_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtintRepoSweepBucketId).HasColumnName("ctintRepoSweepBucket_id");

                entity.Property(e => e.CtintRepoSweepMarginMatrix).HasColumnName("ctintRepoSweepMarginMatrix");

                entity.Property(e => e.CtintSpeedUnitCmo)
                    .HasColumnName("ctintSpeedUnitCMO")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.CtintSpeedUnitMbs)
                    .HasColumnName("ctintSpeedUnitMBS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CtintSwapMarginFormulaId).HasColumnName("ctintSwapMarginFormula_ID");

                entity.Property(e => e.CtintTradeActivityTypeId).HasColumnName("ctintTradeActivityTypeID");

                entity.Property(e => e.CtlBillingCycle).HasColumnName("ctlBillingCycle");

                entity.Property(e => e.CtlCommissionTierId).HasColumnName("ctlCommissionTier_id");

                entity.Property(e => e.CtlInitialFundsSourceId)
                    .HasColumnName("ctlInitialFundsSource_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtlRepoAgreementDt)
                    .HasColumnName("ctlRepoAgreement_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtlTaxStatusId)
                    .HasColumnName("ctlTaxStatus_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtmnyAccountFee)
                    .HasColumnName("ctmnyAccountFee")
                    .HasColumnType("money");

                entity.Property(e => e.CtmnyActualCollateral)
                    .HasColumnName("ctmnyActualCollateral")
                    .HasColumnType("money");

                entity.Property(e => e.CtmnyAmountPurchased)
                    .HasColumnName("ctmnyAmountPurchased")
                    .HasColumnType("money");

                entity.Property(e => e.CtmnyAnnualIncomeMax)
                    .HasColumnName("ctmnyAnnualIncomeMax")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtmnyAnnualIncomeMin)
                    .HasColumnName("ctmnyAnnualIncomeMin")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtmnyExposure)
                    .HasColumnName("ctmnyExposure")
                    .HasColumnType("money");

                entity.Property(e => e.CtmnyMinFee)
                    .HasColumnName("ctmnyMinFee")
                    .HasColumnType("money");

                entity.Property(e => e.CtmnyNetWorthMax)
                    .HasColumnName("ctmnyNetWorthMax")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtmnyNetWorthMin)
                    .HasColumnName("ctmnyNetWorthMin")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtmnySecuredLimit)
                    .HasColumnName("ctmnySecuredLimit")
                    .HasColumnType("money");

                entity.Property(e => e.CtmnyStatementFee)
                    .HasColumnName("ctmnyStatementFee")
                    .HasColumnType("money");

                entity.Property(e => e.CtsdtBillingStartDate)
                    .HasColumnName("ctsdtBillingStartDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CtsngAvailableBalanceDda)
                    .HasColumnName("ctsngAvailableBalanceDDA")
                    .HasColumnType("money");

                entity.Property(e => e.CtsngCapitalCost).HasColumnName("ctsngCapitalCost");

                entity.Property(e => e.CtsngCurrentBalanceDda)
                    .HasColumnName("ctsngCurrentBalanceDDA")
                    .HasColumnType("money");

                entity.Property(e => e.CtsngDurMax).HasColumnName("ctsngDurMax");

                entity.Property(e => e.CtsngDurMin).HasColumnName("ctsngDurMin");

                entity.Property(e => e.CtsngMinMaturity).HasColumnName("ctsngMinMaturity");

                entity.Property(e => e.CtsngReturnOnMbs).HasColumnName("ctsngReturnOnMBS");

                entity.Property(e => e.CtsrtCustomerSort1)
                    .HasColumnName("ctsrtCustomerSort1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CtsrtCustomerSort2)
                    .HasColumnName("ctsrtCustomerSort2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CtsrtCustomerType)
                    .HasColumnName("ctsrtCustomerType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrAbanumber)
                    .HasColumnName("ctstrABANumber")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrBankRep)
                    .HasColumnName("ctstrBankRep")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrBankRepCostCenter)
                    .HasColumnName("ctstrBankRepCostCenter")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrBicCd)
                    .HasColumnName("ctstr_BIC_cd")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtstrCertificateNumber)
                    .HasColumnName("ctstrCertificateNumber")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrChipsCd)
                    .HasColumnName("ctstr_CHIPS_cd")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtstrCity)
                    .HasColumnName("ctstrCity")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrClearingAccount)
                    .HasColumnName("ctstrClearingAccount")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrCompanyNumber)
                    .HasColumnName("ctstrCompanyNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrCreditRatingOofid)
                    .HasColumnName("ctstrCreditRatingOOFID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrCustomerAccount)
                    .IsRequired()
                    .HasColumnName("ctstrCustomerAccount")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrCustomerAlternateAcct)
                    .HasColumnName("ctstrCustomerAlternateAcct")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrCustomerId)
                    .HasColumnName("ctstrCustomerID")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrCustomerName1)
                    .HasColumnName("ctstrCustomerName1")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrCustomerName2)
                    .HasColumnName("ctstrCustomerName2")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrDdaaccount)
                    .HasColumnName("ctstrDDAAccount")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrDefaultCostCenter)
                    .HasColumnName("ctstrDefaultCostCenter")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrDefaultCostCenterDg)
                    .HasColumnName("ctstrDefaultCostCenterDG")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrDefaultFas115)
                    .HasColumnName("ctstrDefaultFAS115")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrDtcAgentBankNumber)
                    .HasColumnName("ctstr_DTC_AgentBankNumber")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtstrDtcInstitutionalNumber)
                    .HasColumnName("ctstr_DTC_InstitutionalNumber")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtstrDtcParticipantNumber)
                    .HasColumnName("ctstr_DTC_ParticipantNumber")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtstrElectronicFundsTransfer)
                    .HasColumnName("ctstrElectronicFundsTransfer")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrEmail)
                    .HasColumnName("ctstrEMail")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrFax)
                    .HasColumnName("ctstrFax")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrFdicnumber)
                    .HasColumnName("ctstrFDICNumber")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrFhlbnumber)
                    .HasColumnName("ctstrFHLBNumber")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrIbcacountryRating)
                    .HasColumnName("ctstrIBCACountryRating")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrIbcaindividualRating)
                    .HasColumnName("ctstrIBCAIndividualRating")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrIdcrating)
                    .HasColumnName("ctstrIDCRating")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtstrModem)
                    .HasColumnName("ctstrModem")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrMoodyComercialPaper)
                    .HasColumnName("ctstrMoodyComercialPaper")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrMoodyDepositsLongTerm)
                    .HasColumnName("ctstrMoodyDepositsLongTerm")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrMoodyDepositsShortTerm)
                    .HasColumnName("ctstrMoodyDepositsShortTerm")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrMoodyFmplongTerm)
                    .HasColumnName("ctstrMoodyFMPLongTerm")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrMoodyFmpshortTerm)
                    .HasColumnName("ctstrMoodyFMPShortTerm")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrMoodySeniorDebt)
                    .HasColumnName("ctstrMoodySeniorDebt")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrNaicnumber)
                    .HasColumnName("ctstrNAICNumber")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrNcuanumber)
                    .HasColumnName("ctstrNCUANumber")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrNotes)
                    .HasColumnName("ctstrNotes")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrOccnumber)
                    .HasColumnName("ctstrOCCNumber")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrOfficeOfFinanceNumber)
                    .HasColumnName("ctstrOfficeOfFinanceNumber")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrPaymentDelivery)
                    .HasColumnName("ctstrPaymentDelivery")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrPricingDefaultSourceBulid)
                    .HasColumnName("ctstrPricingDefaultSourceBULID")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtstrPricingDefaultSourceCmoid)
                    .HasColumnName("ctstrPricingDefaultSourceCMOID")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtstrPricingDefaultSourceMbsid)
                    .HasColumnName("ctstrPricingDefaultSourceMBSID")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtstrProfitabilityId)
                    .HasColumnName("ctstrProfitabilityID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrPurchPmtInstructionsId)
                    .HasColumnName("ctstrPurchPmtInstructionsID")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrPurchSafekeepingLocationId)
                    .HasColumnName("ctstrPurchSafekeepingLocationID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrReferredBy)
                    .HasColumnName("ctstrReferredBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrRegisteredRep)
                    .HasColumnName("ctstrRegisteredRep")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrResponsibleCostCenter)
                    .HasColumnName("ctstrResponsibleCostCenter")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrSavingsAcct)
                    .HasColumnName("ctstrSavingsAcct")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrState)
                    .HasColumnName("ctstrState")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrStdPoorDepositsLongTerm)
                    .HasColumnName("ctstrStdPoorDepositsLongTerm")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrStdPoorDepositsShortTerm)
                    .HasColumnName("ctstrStdPoorDepositsShortTerm")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrStdPoorFmplongTerm)
                    .HasColumnName("ctstrStdPoorFMPLongTerm")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrStdPoorFmpshortTerm)
                    .HasColumnName("ctstrStdPoorFMPShortTerm")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrStdPoorSeniorDebt)
                    .HasColumnName("ctstrStdPoorSeniorDebt")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrStdPoorShortTermRating)
                    .HasColumnName("ctstrStdPoorShortTermRating")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrStreetAddress1)
                    .HasColumnName("ctstrStreetAddress1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrStreetAddress2)
                    .HasColumnName("ctstrStreetAddress2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrStreetAddress3)
                    .HasColumnName("ctstrStreetAddress3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrSubAccount)
                    .HasColumnName("ctstrSubAccount")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrSwiftCd)
                    .HasColumnName("ctstr_SWIFT_cd")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtstrTaxBook)
                    .HasColumnName("ctstrTaxBook")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrTaxId)
                    .HasColumnName("ctstrTaxID")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrTaxId1)
                    .HasColumnName("ctstrTaxID1")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrTaxId2)
                    .HasColumnName("ctstrTaxID2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrTelephone)
                    .HasColumnName("ctstrTelephone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrThomsonBankWatch)
                    .HasColumnName("ctstrThomsonBankWatch")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrUidCd)
                    .HasColumnName("ctstr_UID_cd")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtstrUserDef01)
                    .HasColumnName("ctstrUserDef01")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrVrmindexId)
                    .HasColumnName("ctstrVRMIndexID")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CtstrZipCode)
                    .HasColumnName("ctstrZipCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CttnyAccountingPeriodStartDay).HasColumnName("cttnyAccountingPeriodStartDay");

                entity.Property(e => e.DataFeeds)
                    .HasColumnName("_DATA_FEEDS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Delivery).HasColumnName("_DELIVERY");

                entity.Property(e => e.DtLastUpdateDt)
                    .HasColumnName("dtLastUpdate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.GeneralInfo).HasColumnName("_GENERAL_INFO");

                entity.Property(e => e.IConcurrencyId).HasColumnName("iConcurrency_id");

                entity.Property(e => e.ModifyDt)
                    .HasColumnName("Modify_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifyUser)
                    .HasColumnName("Modify_User")
                    .HasMaxLength(30);

                entity.Property(e => e.PaymentDeliveryDefault)
                    .HasColumnName("PAYMENT_DELIVERY_DEFAULT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PricingVendorDefaults).HasColumnName("_PRICING_VENDOR_DEFAULTS");

                entity.Property(e => e.ProcessableId)
                    .HasColumnName("Processable_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessingRequired).HasColumnName("_PROCESSING_REQUIRED");

                entity.Property(e => e.Regulatory).HasColumnName("_REGULATORY");

                entity.Property(e => e.ReportableId)
                    .HasColumnName("Reportable_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SLastUpdateId)
                    .HasColumnName("sLastUpdate_id")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SQueryKey)
                    .HasColumnName("sQueryKey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SwapsDefaults).HasColumnName("_SWAPS_DEFAULTS");

                entity.Property(e => e.SzGlobalIdentifier)
                    .HasColumnName("szGlobalIdentifier")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.TaxationInformation).HasColumnName("_TAXATION_INFORMATION");

                entity.Property(e => e.TermDt)
                    .HasColumnName("Term_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.VisibleId)
                    .HasColumnName("Visible_id")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblDrvInstruments>(entity =>
            {
                entity.HasKey(e => e.LDrvInstrumentId);

                entity.ToTable("tbl_DRV_Instruments");

                entity.Property(e => e.LDrvInstrumentId).HasColumnName("lDRV_Instrument_id");

                entity.Property(e => e.BitSettleDate).HasColumnName("bitSettleDate");

                entity.Property(e => e.BlnFxuseLoadedFvonly).HasColumnName("blnFXUseLoadedFVOnly");

                entity.Property(e => e.BlnUseInterestProjCrvDf).HasColumnName("blnUseInterestProjCrvDF");

                entity.Property(e => e.BlnUsePresentValueCrvDf).HasColumnName("blnUsePresentValueCrvDF");

                entity.Property(e => e.ContractDescription)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ContractSizeId)
                    .HasColumnName("ContractSizeID")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.ExchangeId)
                    .HasColumnName("ExchangeID")
                    .HasDefaultValueSql("((85))");

                entity.Property(e => e.HtintHoldingTypeId).HasColumnName("htintHoldingTypeID");

                entity.Property(e => e.InterestProjCrvId)
                    .HasColumnName("InterestProjCrvID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LBuySellId).HasColumnName("lBuySellID");

                entity.Property(e => e.LContractUnitId)
                    .HasColumnName("lContractUnit_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LDerivativeTypesId).HasColumnName("lDerivativeTypesID");

                entity.Property(e => e.LFxcounterpartyCurrencyId).HasColumnName("lFXCounterpartyCurrencyID");

                entity.Property(e => e.LGlgroupId).HasColumnName("lGLGroupID");

                entity.Property(e => e.LInstrumentGroupsId)
                    .HasColumnName("lInstrumentGroups_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LQuotedUnitsCurrencyId)
                    .HasColumnName("lQuotedUnitsCurrency_id")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.LQuotedUnitsPerUsdRatio)
                    .HasColumnName("lQuotedUnitsPerUSD_ratio")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.PresentValueCrvId)
                    .HasColumnName("PresentValueCrvID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PricingMultiplierPerUnits)
                    .HasColumnName("PricingMultiplier_Per_Units")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SettlementHolidayListId).HasColumnName("SettlementHolidayListID");

                entity.Property(e => e.TickId)
                    .HasColumnName("TickID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TickerSymbol)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblHoldingType>(entity =>
            {
                entity.HasKey(e => new { e.HtstrRcbclass, e.HtstrRcbsubType, e.HtstrSecGroup, e.HtintCode })
                    .HasName("PK_tblHoldingTypeNew");

                entity.ToTable("tblHoldingType");

                entity.HasIndex(e => e.HtintHoldingTypeId)
                    .HasName("IX_tblHoldingType")
                    .IsUnique();

                entity.Property(e => e.HtstrRcbclass)
                    .HasColumnName("htstrRCBClass")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.HtstrRcbsubType)
                    .HasColumnName("htstrRCBSubType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.HtstrSecGroup)
                    .HasColumnName("htstrSecGroup")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HtintCode).HasColumnName("htintCode");

                entity.Property(e => e.HtboolUploadGroup).HasColumnName("htboolUploadGroup");

                entity.Property(e => e.HtboolVisible)
                    .IsRequired()
                    .HasColumnName("htboolVisible")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HtintBloombergSectorId)
                    .HasColumnName("htintBloombergSectorID")
                    .HasDefaultValueSql("((11))");

                entity.Property(e => e.HtintDelayInMaty).HasColumnName("htintDelayInMaty");

                entity.Property(e => e.HtintHoldingTypeId).HasColumnName("htintHoldingTypeID");

                entity.Property(e => e.HtintSettlingAssetClass)
                    .HasColumnName("htintSettlingAssetClass")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.HtstrCouponType)
                    .IsRequired()
                    .HasColumnName("htstrCouponType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('F')");

                entity.Property(e => e.HtstrDescription)
                    .IsRequired()
                    .HasColumnName("htstrDescription")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.HtstrFamily)
                    .IsRequired()
                    .HasColumnName("htstrFamily")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HtstrPricingDeafultSourceId)
                    .HasColumnName("htstrPricingDeafultSourceID")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LCountryId)
                    .HasColumnName("lCountry_ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LProcessorId)
                    .HasColumnName("lProcessor_ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LSectorId)
                    .HasColumnName("lSector_ID")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.SDtcccode)
                    .HasColumnName("sDTCCCode")
                    .HasMaxLength(3);

                entity.Property(e => e.SSector)
                    .IsRequired()
                    .HasColumnName("sSector")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('xxx')");
            });

            modelBuilder.Entity<TblSwapState>(entity =>
            {
                entity.ToTable("tblSwapState");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DblMarginPercent).HasColumnName("dblMarginPercent");

                entity.Property(e => e.Dv01).HasColumnName("DV01");

                entity.Property(e => e.LMarginFormulaId).HasColumnName("lMarginFormula_id");

                entity.Property(e => e.MarginRequired).HasColumnType("money");

                entity.Property(e => e.NetMarketValue).HasColumnType("money");

                entity.Property(e => e.NextCall).HasColumnType("smalldatetime");

                entity.Property(e => e.PxUpdated).HasColumnType("smalldatetime");

                entity.Property(e => e.RemainingNotional).HasColumnType("money");

                entity.Property(e => e.RunDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SoldOrigNotl).HasColumnType("money");

                entity.Property(e => e.StatusCodesId).HasColumnName("StatusCodesID");

                entity.Property(e => e.SwapsId).HasColumnName("SwapsID");

                entity.Property(e => e.Termination).HasColumnType("smalldatetime");

                entity.Property(e => e.TotalReturnInPeriod)
                    .HasColumnName("TotalReturn_InPeriod")
                    .HasColumnType("money");

                entity.Property(e => e.TotalReturnSwapLife)
                    .HasColumnName("TotalReturn_SwapLife")
                    .HasColumnType("money");

                entity.Property(e => e.Wal).HasColumnName("WAL");
            });

            modelBuilder.Entity<TblSwapTerminations>(entity =>
            {
                entity.ToTable("tblSwapTerminations");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Effective).HasColumnType("datetime");

                entity.Property(e => e.SwapsId).HasColumnName("SwapsID");
            });

            modelBuilder.Entity<TblSwaps>(entity =>
            {
                entity.ToTable("tblSwaps");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountingNumber)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.BitCancelDate).HasColumnName("bitCancelDate");

                entity.Property(e => e.BitSettleDate).HasColumnName("bitSettleDate");

                entity.Property(e => e.BlnAtm).HasColumnName("blnATM");

                entity.Property(e => e.BlnCallArrearsReset).HasColumnName("blnCallArrearsReset");

                entity.Property(e => e.BlnCallFrontPay).HasColumnName("blnCallFrontPay");

                entity.Property(e => e.BlnCallFrontStub).HasColumnName("blnCallFrontStub");

                entity.Property(e => e.BlnCallIncludeEnd).HasColumnName("blnCallIncludeEnd");

                entity.Property(e => e.BlnCallIncludeStart).HasColumnName("blnCallIncludeStart");

                entity.Property(e => e.BlnCallLongStub).HasColumnName("blnCallLongStub");

                entity.Property(e => e.BlnDgtmp).HasColumnName("blnDGtmp");

                entity.Property(e => e.BlnExcludeFromProcessing).HasColumnName("blnExcludeFromProcessing");

                entity.Property(e => e.BlnOptionNormalVol).HasColumnName("blnOptionNormalVol");

                entity.Property(e => e.BlnTraderPending).HasColumnName("blnTraderPending");

                entity.Property(e => e.BoolMargin).HasColumnName("boolMargin");

                entity.Property(e => e.CallBusDayConvId).HasColumnName("CallBusDayConvID");

                entity.Property(e => e.CallEomadjust).HasColumnName("CallEOMAdjust");

                entity.Property(e => e.CallFrequenciesId).HasColumnName("CallFrequenciesID");

                entity.Property(e => e.CallNotificationId).HasColumnName("CallNotificationID");

                entity.Property(e => e.ChrCreateUser)
                    .HasColumnName("chrCreateUser")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ChrModifyUser)
                    .HasColumnName("chrModifyUser")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CleanupCallPct).HasColumnType("numeric(10, 6)");

                entity.Property(e => e.CntrprtysSwapId)
                    .HasColumnName("CntrprtysSwapID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId).HasColumnName("contactID");

                entity.Property(e => e.CounterPartyId).HasColumnName("CounterPartyID");

                entity.Property(e => e.CurCommisionAmount)
                    .HasColumnName("curCommisionAmount")
                    .HasColumnType("money");

                entity.Property(e => e.CustomerSetupId)
                    .HasColumnName("CustomerSetupID")
                    .HasDefaultValueSql("((422))");

                entity.Property(e => e.DblBarrierRate).HasColumnName("dblBarrierRate");

                entity.Property(e => e.DblCommisionPerContract).HasColumnName("dblCommisionPerContract");

                entity.Property(e => e.DblDiscCrvFixedSpread).HasColumnName("dblDiscCrvFixedSpread");

                entity.Property(e => e.DblFwdRtCrvFixedSpread).HasColumnName("dblFwdRtCrvFixedSpread");

                entity.Property(e => e.DblMarginPercent).HasColumnName("dblMarginPercent");

                entity.Property(e => e.DblParticipationRate)
                    .HasColumnName("dblParticipationRate")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.DblPrice).HasColumnName("dblPrice");

                entity.Property(e => e.DblShare).HasColumnName("dblShare");

                entity.Property(e => e.DblSigma).HasColumnName("dblSigma");

                entity.Property(e => e.DblStrikePx).HasColumnName("dblStrikePx");

                entity.Property(e => e.DerivativeTypesId).HasColumnName("DerivativeTypesID");

                entity.Property(e => e.Description)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DtBarrierFirstResetDate)
                    .HasColumnName("dtBarrierFirstResetDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtCancelDate)
                    .HasColumnName("dtCancelDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtEnteredAsOf)
                    .HasColumnName("dtEnteredAsOf")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtLastUpdateDt)
                    .HasColumnName("dtLastUpdate_dt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtOptionEnd)
                    .HasColumnName("dtOptionEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtOptionStart)
                    .HasColumnName("dtOptionStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtmCreateDt)
                    .HasColumnName("dtmCreateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtmModifyDt)
                    .HasColumnName("dtmModifyDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtmOptionExcerciseDate)
                    .HasColumnName("dtmOptionExcerciseDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtmOptionSettlement)
                    .HasColumnName("dtmOptionSettlement")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtmTermDt)
                    .HasColumnName("dtmTermDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Effective).HasColumnType("datetime");

                entity.Property(e => e.FarFxswapTransId).HasColumnName("FarFXSwapTransID");

                entity.Property(e => e.FirstCall).HasColumnType("smalldatetime");

                entity.Property(e => e.Futures).HasColumnName("FUTURES");

                entity.Property(e => e.Fxrate).HasColumnName("FXRate");

                entity.Property(e => e.ICcp).HasColumnName("iCCP");

                entity.Property(e => e.IConcurrencyId).HasColumnName("iConcurrency_id");

                entity.Property(e => e.IFcm).HasColumnName("iFCM");

                entity.Property(e => e.IMultiTradeId).HasColumnName("iMultiTradeID");

                entity.Property(e => e.ITransactionCode).HasColumnName("iTransactionCode");

                entity.Property(e => e.IntAmortMethodId).HasColumnName("intAmortMethodID");

                entity.Property(e => e.IntDefaultAmortizationType).HasColumnName("intDefaultAmortizationType");

                entity.Property(e => e.IntDefaultSetting).HasColumnName("intDefaultSetting");

                entity.Property(e => e.IntDiscCrvSpreadId).HasColumnName("intDiscCrvSpreadID");

                entity.Property(e => e.IntFwdRtCrvSpreadId).HasColumnName("intFwdRtCrvSpreadID");

                entity.Property(e => e.IntStatus).HasColumnName("intStatus");

                entity.Property(e => e.LApprovalId).HasColumnName("lApproval_id");

                entity.Property(e => e.LBarrierResetBusDayConvId).HasColumnName("lBarrierResetBusDayConvID");

                entity.Property(e => e.LBarrierResetEomadjustId).HasColumnName("lBarrierResetEOMAdjustID");

                entity.Property(e => e.LBarrierResetFrequenciesId).HasColumnName("lBarrierResetFrequenciesID");

                entity.Property(e => e.LBarrierResetHolidayListId).HasColumnName("lBarrierResetHolidayListID");

                entity.Property(e => e.LCallAccrualCalendar).HasColumnName("lCallAccrualCalendar");

                entity.Property(e => e.LCallAccrualConvention).HasColumnName("lCallAccrualConvention");

                entity.Property(e => e.LCallFixCalendar).HasColumnName("lCallFixCalendar");

                entity.Property(e => e.LCallFixConvention).HasColumnName("lCallFixConvention");

                entity.Property(e => e.LCallPayCalendar).HasColumnName("lCallPayCalendar");

                entity.Property(e => e.LCallPayConvention).HasColumnName("lCallPayConvention");

                entity.Property(e => e.LCallPutId).HasColumnName("lCallPut_id");

                entity.Property(e => e.LCapVolBusDayConv).HasColumnName("lCapVolBusDayConv");

                entity.Property(e => e.LCapVolCapBasis).HasColumnName("lCapVolCapBasis");

                entity.Property(e => e.LCapVolExtrapMethod).HasColumnName("lCapVolExtrapMethod");

                entity.Property(e => e.LCapVolFixCalendar).HasColumnName("lCapVolFixCalendar");

                entity.Property(e => e.LCapVolInterpMethod).HasColumnName("lCapVolInterpMethod");

                entity.Property(e => e.LCapVolInterpVariable).HasColumnName("lCapVolInterpVariable");

                entity.Property(e => e.LCapVolNoticePeriod).HasColumnName("lCapVolNoticePeriod");

                entity.Property(e => e.LCapVolPayCalendar).HasColumnName("lCapVolPayCalendar");

                entity.Property(e => e.LCapVolVolatilityBasis).HasColumnName("lCapVolVolatilityBasis");

                entity.Property(e => e.LContractsQty)
                    .HasColumnName("lContracts_qty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LDrvInstrumentId)
                    .HasColumnName("lDrv_Instrument_id")
                    .HasDefaultValueSql("((19031))");

                entity.Property(e => e.LExchangeId).HasColumnName("lExchange_id");

                entity.Property(e => e.LFxswapTransId).HasColumnName("lFXSwapTransID");

                entity.Property(e => e.LHoldingTypeId).HasColumnName("lHoldingType_id");

                entity.Property(e => e.LInstrumentGroupsMajor).HasColumnName("lInstrumentGroupsMajor");

                entity.Property(e => e.LLongShortId).HasColumnName("lLongShort_id");

                entity.Property(e => e.LMarginFormulaId).HasColumnName("lMarginFormula_id");

                entity.Property(e => e.LMarginNotlPeriodFreq).HasColumnName("lMarginNotlPeriodFreq");

                entity.Property(e => e.LMonthContractId)
                    .HasColumnName("lMonthContract_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LMonthYearCodeId).HasColumnName("lMonthYearCodeID");

                entity.Property(e => e.LOptionAccrualCalendar).HasColumnName("lOptionAccrualCalendar");

                entity.Property(e => e.LOptionAccrualConvention).HasColumnName("lOptionAccrualConvention");

                entity.Property(e => e.LOptionBasis).HasColumnName("lOptionBasis");

                entity.Property(e => e.LOptionFrequency).HasColumnName("lOptionFrequency");

                entity.Property(e => e.LOptionSpotCalendar).HasColumnName("lOptionSpotCalendar");

                entity.Property(e => e.LOptionSpotLag).HasColumnName("lOptionSpotLag");

                entity.Property(e => e.LOptionStyleId).HasColumnName("lOptionStyle_id");

                entity.Property(e => e.LPrincipalExchangedId).HasColumnName("lPrincipal_Exchanged_id");

                entity.Property(e => e.LRepoPositionId).HasColumnName("lRepoPosition_ID");

                entity.Property(e => e.LRevRepoPositionId).HasColumnName("lRevRepoPosition_ID");

                entity.Property(e => e.LTraderId).HasColumnName("lTraderID");

                entity.Property(e => e.LastCall).HasColumnType("smalldatetime");

                entity.Property(e => e.Maturity).HasColumnType("smalldatetime");

                entity.Property(e => e.MnyPremium)
                    .HasColumnName("mnyPremium")
                    .HasColumnType("money");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NotionalOrigAmt).HasColumnType("money");

                entity.Property(e => e.OffsetSwapId).HasColumnName("OffsetSwapID");

                entity.Property(e => e.Options).HasColumnName("OPTIONS");

                entity.Property(e => e.ProcessableId)
                    .HasColumnName("Processable_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReportableId).HasColumnName("Reportable_id");

                entity.Property(e => e.SLastUpdateId)
                    .HasColumnName("sLastUpdate_id")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Settlement)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SettlementHolidayListId)
                    .HasColumnName("SettlementHolidayListID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.StrAcctDesignation).HasColumnName("strAcctDesignation");

                entity.Property(e => e.StrDefaultPxSourceId)
                    .HasColumnName("strDefaultPxSourceID")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StrMonthYearCode)
                    .HasColumnName("strMonthYearCode")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StrOptionSwapTenor)
                    .HasColumnName("strOptionSwapTenor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrOptionTransType)
                    .HasColumnName("strOptionTransType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StrReasonToTrade)
                    .HasColumnName("strReasonToTrade")
                    .HasMaxLength(500);

                entity.Property(e => e.StrUserDefined1)
                    .HasColumnName("strUserDefined1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrUserDefined2)
                    .HasColumnName("strUserDefined2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrUserDefined3)
                    .HasColumnName("strUserDefined3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrUserDefined4)
                    .HasColumnName("strUserDefined4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrUserDefined5)
                    .HasColumnName("strUserDefined5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrUserDefined6)
                    .HasColumnName("strUserDefined6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrategyId).HasColumnName("StrategyID");

                entity.Property(e => e.SzSwapGlobalIdentifier)
                    .HasColumnName("szSwapGlobalIdentifier")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Trade).HasColumnType("datetime");

                entity.Property(e => e.UseBlack76PricingModel).HasDefaultValueSql("((0))");

                entity.Property(e => e.ValuationNotional).HasColumnType("money");

                entity.Property(e => e.VisibleId)
                    .HasColumnName("Visible_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WiringInstructionsId).HasColumnName("WiringInstructionsID");

                entity.Property(e => e.Zelect).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TlkpDerivativeTypes>(entity =>
            {
                entity.ToTable("tlkpDerivativeTypes");

                entity.HasIndex(e => e.Name)
                    .HasName("ConstraintDescription")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LSectorId)
                    .HasColumnName("lSector_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RcbclassesId).HasColumnName("RCBClassesID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
