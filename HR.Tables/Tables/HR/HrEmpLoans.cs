﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class HrEmpLoans
    {
        public int EmpLoanId { get; set; }
        public int? EmpLoanReqId { get; set; }
        public int? DepartMentId { get; set; }
        public int? StoreId { get; set; }
        public int? BranchId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? Aid { get; set; }
        public int? EmpId { get; set; }
        public int? PeriodTableId { get; set; }
        public int? PeriodTablDetailId { get; set; }
        public int? SalaryTypId { get; set; }
        public string LoanCode { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public DateTime? StartPayDate { get; set; }
        public DateTime? LastPayDate { get; set; }
        public decimal? LoanValue { get; set; }
        public int? Installments { get; set; }
        public decimal? InstallmentValue { get; set; }
        public decimal? TotalPaid { get; set; }
        public decimal? LoanBalance { get; set; }
        public decimal? TotalExemption { get; set; }
        public int? PaidInstallmentCount { get; set; }
        public decimal? LastInstallmentValue { get; set; }
        public bool? IsInstallmentStopped { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }
        public string Remarks3 { get; set; }
        public bool? Closed { get; set; }
        public bool? IsPrinted { get; set; }
        public bool? IsDelivered { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsPosted { get; set; }
        public string Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        public DateTime? PermPrintedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
