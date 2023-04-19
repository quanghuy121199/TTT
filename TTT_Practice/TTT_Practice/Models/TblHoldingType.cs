using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TTT_Practice.Models
{
    public partial class TblHoldingType
    {
        public int HtintHoldingTypeId { get; set; }
        public string HtstrRcbclass { get; set; }
        public string HtstrRcbsubType { get; set; }
        public string HtstrSecGroup { get; set; }
        public int HtintCode { get; set; }
        public string HtstrDescription { get; set; }
        public string HtstrFamily { get; set; }
        public string HtstrCouponType { get; set; }
        public bool? HtboolVisible { get; set; }
        public string HtstrPricingDeafultSourceId { get; set; }
        public bool HtboolUploadGroup { get; set; }
        public int HtintDelayInMaty { get; set; }
        public int HtintBloombergSectorId { get; set; }
        public int HtintSettlingAssetClass { get; set; }
        public int L3 { get; set; }
        public int L2 { get; set; }
        public int L1 { get; set; }
        public int LProcessorId { get; set; }
        public int LCountryId { get; set; }
        public int LSectorId { get; set; }
        public string SSector { get; set; }
        public string SDtcccode { get; set; }
    }
}
