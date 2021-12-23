﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class SearchWeightCard
    {
        public int? StoreId { get; set; }
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? WeightQty1 { get; set; }
        public decimal? WeightQty2 { get; set; }
        public decimal? WeightQtyDiff { get; set; }
        public DateTime? Weight1Date { get; set; }
        public DateTime? Weight2Date { get; set; }
        public string DocTrNo { get; set; }
        public string ManualTrNo { get; set; }
        public int ScaleCardId { get; set; }
        public string Remarks1 { get; set; }
        public int? BookId { get; set; }
        public string TermCode { get; set; }
        public string TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
    }
}
