using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TTT_Practice.Models
{
    public partial class TblDrvInstruments
    {
        public int LDrvInstrumentId { get; set; }
        public string TickerSymbol { get; set; }
        public int? LInstrumentGroupsId { get; set; }
        public string ContractDescription { get; set; }
        public int ExchangeId { get; set; }
        public int? TickId { get; set; }
        public int? ContractSizeId { get; set; }
        public int LContractUnitId { get; set; }
        public int LQuotedUnitsCurrencyId { get; set; }
        public double LQuotedUnitsPerUsdRatio { get; set; }
        public int HtintHoldingTypeId { get; set; }
        public double PricingMultiplierPerUnits { get; set; }
        public int InterestProjCrvId { get; set; }
        public int PresentValueCrvId { get; set; }
        public int Zelect { get; set; }
        public int? LGlgroupId { get; set; }
        public bool BlnUseInterestProjCrvDf { get; set; }
        public bool BlnUsePresentValueCrvDf { get; set; }
        public bool? BitSettleDate { get; set; }
        public int? LDerivativeTypesId { get; set; }
        public int? SettlementHolidayListId { get; set; }
        public int? LBuySellId { get; set; }
        public int? LFxcounterpartyCurrencyId { get; set; }
        public bool BlnFxuseLoadedFvonly { get; set; }
        public bool ResetNotional { get; set; }
    }
}
