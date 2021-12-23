﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class MsStockRecript
    {
        public MsStockRecript()
        {
            MsStockReceiptItemCard = new HashSet<MsStockReceiptItemCard>();
            MsStockRecriptExpenses = new HashSet<MsStockRecriptExpenses>();
        }

        public int StockRecId { get; set; }
        public int? PurInvId { get; set; }
        public int? InvId { get; set; }
        public int? RetPurchId { get; set; }
        public int? JobOrderId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? RetSaleId { get; set; }
        public int? PurOrderId { get; set; }
        public int? PurOrderReqId { get; set; }
        public int? CustomerId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? VendorId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        public string ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? ReceiptrQty { get; set; }
        public decimal? PurchaseInvQty { get; set; }
        public bool? IsClosed { get; set; }
        public bool? CostExecuted { get; set; }
        public string StockRecDescA { get; set; }
        public string StockRecDescE { get; set; }
        public string Remarks { get; set; }
        public string AddField3 { get; set; }
        public string AddField4 { get; set; }
        public string AddField5 { get; set; }
        public string AddField6 { get; set; }
        public string AddField7 { get; set; }
        public byte? Status { get; set; }
        public bool? IsPrinted { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? Rate { get; set; }
        public decimal? NetPriceBeforCurr { get; set; }
        public decimal? ExpenValueBeforCurr { get; set; }
        public decimal? ExpenValueWithCurr { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsPosted { get; set; }
        public string Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool? Closed { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public bool? IsPaid { get; set; }
        public int? PaidDocId { get; set; }
        public decimal? NotPaid { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<MsStockReceiptItemCard> MsStockReceiptItemCard { get; set; }
        public virtual ICollection<MsStockRecriptExpenses> MsStockRecriptExpenses { get; set; }
    }
}
