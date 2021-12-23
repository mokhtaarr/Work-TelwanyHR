﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class StockRecSearch
    {
        public string SourcTyp { get; set; }
        public int? StoreId { get; set; }
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerDescA { get; set; }
        public int? RetInvTrNo { get; set; }
        public string DocTrNo { get; set; }
        public string ManualTrNo { get; set; }
        public int StockRecId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public string TermCode { get; set; }
        public string TermName { get; set; }
        public bool? SystemIssuedOnly { get; set; }
        public byte? TermType { get; set; }
        public string RetSaleDocTrNo { get; set; }
        public byte? Status { get; set; }
        public bool? CostExecuted { get; set; }
    }
}
