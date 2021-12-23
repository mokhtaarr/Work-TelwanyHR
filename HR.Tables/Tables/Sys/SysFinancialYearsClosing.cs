﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class SysFinancialYearsClosing
    {
        public int ClosingId { get; set; }
        public int? ClosingCode { get; set; }
        public int FinancialYearsId { get; set; }
        public DateTime? ClosingDate { get; set; }
        public DateTime? ClosingDateHejri { get; set; }
        public int? CurrentYear { get; set; }
        public int? ClosingAccountId { get; set; }
        public string RemarksA { get; set; }
        public string RemarksE { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? IsCancel { get; set; }
        public bool? IsTransfer { get; set; }
    }
}
