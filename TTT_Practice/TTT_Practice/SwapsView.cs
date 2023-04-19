using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT_Practice
{
    public class SwapsView
    {
        public int SwapId { get; set; }
        public string SwapName { get; set; }
        public int CusId { get; set; }
        public string CusName { get; set;}
        public string DerivativeTypeId { get; set; }
        public string DerivativeTypeName { get; set;}
        public string HoldingTypeId { get; set; }
        public string HoldingTypeName { get; set; }
        public string InstrumentId { get; set; }
        public string Instrument { get; set; }
        public DateTime LastProcessedDate { get; set; }
    }
}
