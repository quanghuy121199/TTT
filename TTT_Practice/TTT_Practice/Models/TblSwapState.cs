using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TTT_Practice.Models
{
    public partial class TblSwapState
    {
        public int Id { get; set; }
        public int SwapsId { get; set; }
        public int? StatusCodesId { get; set; }
        public decimal? SoldOrigNotl { get; set; }
        public DateTime? NextCall { get; set; }
        public DateTime? Termination { get; set; }
        public decimal? NetMarketValue { get; set; }
        public DateTime? PxUpdated { get; set; }
        public DateTime? RunDate { get; set; }
        public double? Duration { get; set; }
        public decimal? RemainingNotional { get; set; }
        public double? Dv01 { get; set; }
        public double? Wal { get; set; }
        public decimal? TotalReturnSwapLife { get; set; }
        public double? DblMarginPercent { get; set; }
        public int? LMarginFormulaId { get; set; }
        public decimal? MarginRequired { get; set; }
        public decimal? TotalReturnInPeriod { get; set; }
    }
}
