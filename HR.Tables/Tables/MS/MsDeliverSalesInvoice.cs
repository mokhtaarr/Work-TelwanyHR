﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class MsDeliverSalesInvoice
    {
        public MsDeliverSalesInvoice()
        {
            MsDeliverItemCard = new HashSet<MsDeliverItemCard>();
            MsDeliverSalesInvoiceExpenses = new HashSet<MsDeliverSalesInvoiceExpenses>();
        }

        public int DeliverId { get; set; }
        public int? InvId { get; set; }
        public int? CustomerId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? CurrencyId { get; set; }
        public int? RetPurchId { get; set; }
        public int? JobOrderId { get; set; }
        public int? VendorId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        public string ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? DeliverQtyOut { get; set; }
        public decimal? DeliverQty { get; set; }
        public bool? IsClosed { get; set; }
        public string StrCustm4 { get; set; }
        public string StrCustm5 { get; set; }
        public string Remarks { get; set; }
        public string AddField3 { get; set; }
        public string AddField4 { get; set; }
        public string AddField5 { get; set; }
        public string AddField6 { get; set; }
        public string AddField7 { get; set; }
        public byte? Status { get; set; }
        public bool? IsPrinted { get; set; }
        public decimal? NetPriceFromInv { get; set; }
        public decimal? TotalCostAverage { get; set; }
        public decimal? TotalLastCost { get; set; }
        public decimal? Rate { get; set; }
        public decimal? NetPricFromInvBeforCurr { get; set; }
        public decimal? TotalCostAveragBeforCurr { get; set; }
        public decimal? TotalLastCostBeforCurr { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsPosted { get; set; }
        public string Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool? IsPaid { get; set; }
        public int? PaidDocId { get; set; }
        public decimal? NotPaid { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<MsDeliverItemCard> MsDeliverItemCard { get; set; }
        public virtual ICollection<MsDeliverSalesInvoiceExpenses> MsDeliverSalesInvoiceExpenses { get; set; }
    }
}
