﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class SearchLeavPermissionRequest
    {
        public int LeavPermReqId { get; set; }

        public string DocTrNo { get; set; }
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string ManualTrNo { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public decimal? HoursCount { get; set; }
        public string Remarks1 { get; set; }
        public string EmpCode { get; set; }
        public string EmpName1 { get; set; }
        public string EmpName2 { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? Jcode { get; set; }
        public string Jname1 { get; set; }
        public string Jname2 { get; set; }
        public string DepartCode { get; set; }
        public string DepartName1 { get; set; }
        public string DepartName2 { get; set; }
        public string StoreCode { get; set; }
        public string StoreDescA { get; set; }
        public string StoreDescE { get; set; }
        public int? BookId { get; set; }
        public string TermCode { get; set; }
        public string TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public string Remarks3 { get; set; }
        public bool? Closed { get; set; }
        public DateTime? CloseDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
