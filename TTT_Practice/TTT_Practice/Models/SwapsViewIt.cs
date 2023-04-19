using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TTT_Practice.Models
{
    public partial class SwapsViewIt
    {
        public int SwapId { get; set; }
        public string SwapName { get; set; }
        public int Id { get; set; }
        public string Account { get; set; }
        public string Name { get; set; }
        public int? DerivativeTypeId { get; set; }
        public string DerivativeType { get; set; }
        public int? HoldingTypeId { get; set; }
        public string HoldingType { get; set; }
        public int? InstrumentId { get; set; }
        public string Instrument { get; set; }
        public DateTime? LastProcessedDate { get; set; }
    }
}
