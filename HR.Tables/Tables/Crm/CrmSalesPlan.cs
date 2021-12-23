﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class CrmSalesPlan
    {
        public CrmSalesPlan()
        {
            CrmSalesPlanDetail = new HashSet<CrmSalesPlanDetail>();
        }

        public int SalesPlanId { get; set; }
        public int? StoreId { get; set; }
        public int? TeamMemberId { get; set; }
        public string PlanName1 { get; set; }
        public string PlanName2 { get; set; }
        public int TrNo { get; set; }
        public string ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<CrmSalesPlanDetail> CrmSalesPlanDetail { get; set; }
    }
}
