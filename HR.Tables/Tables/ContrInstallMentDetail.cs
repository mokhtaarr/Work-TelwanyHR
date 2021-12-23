﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class ContrInstallMentDetail
    {
        public int InstallDetailId { get; set; }
        public int? InstallId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? Serial { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public DateTime? PayDayDate { get; set; }
        public decimal? InstallValu { get; set; }
        public bool? IsPaid { get; set; }
        public DateTime? PaidDate { get; set; }
        public int? RectId { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }

        public virtual ContrInstallMent Install { get; set; }
    }
}
