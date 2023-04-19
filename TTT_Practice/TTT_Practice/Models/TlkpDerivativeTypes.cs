using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TTT_Practice.Models
{
    public partial class TlkpDerivativeTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SequenceNum { get; set; }
        public byte? RcbclassesId { get; set; }
        public byte? LSectorId { get; set; }
    }
}
