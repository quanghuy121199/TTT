using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TTT_Practice.Models
{
    public partial class TblSwapTerminations
    {
        public int Id { get; set; }
        public int SwapsId { get; set; }
        public DateTime Effective { get; set; }
        public byte Reason { get; set; }
        public double Percentage { get; set; }
    }
}
