﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class MsStockReceiptItemCard
    {
        public MsStockReceiptItemCard()
        {
            MsItemSerials = new HashSet<MsItemSerials>();
        }

        public int StockRecItemCardId { get; set; }
        public int? StockRecId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? InvItemCardId { get; set; }
        public int? RetPurchItemCardId { get; set; }
        public int? JobGoStockId { get; set; }
        public int? JobProductId { get; set; }
        public int? JobScrapId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? FollowCollectionId { get; set; }
        public int? ItemIdToFollow { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? ScaleCardId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public int? BillOfMaterialId { get; set; }
        public byte? ItemType { get; set; }
        public string BarCode { get; set; }
        public string BatchNumberFifoOrLifo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? QuantityIn { get; set; }
        public decimal? QtyInBeforRate { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceAfterRate { get; set; }
        public bool? IsBonus { get; set; }
        public bool FireTriger { get; set; }
        public bool? IsCollection { get; set; }
        public decimal? ExpenseShare { get; set; }
        public decimal? ExpenseShareUnit { get; set; }
        public decimal? PriceAfterExpense { get; set; }
        public decimal? PriceAfterExpenseUnit { get; set; }
        public decimal? PriceAfterCurr { get; set; }
        public decimal? PriceAfterCurrUnit { get; set; }
        public decimal? ExpenseShareAfterCurr { get; set; }
        public decimal? ExpenseShareAfterCurrUnit { get; set; }
        public decimal? PriceAfterExpenseAfterCurr { get; set; }
        public decimal? PriceAfterExpensAfterCurrUnit { get; set; }
        public byte? Satus { get; set; }
        public decimal? Fifocost { get; set; }
        public decimal? FifocostUnit { get; set; }
        public decimal? Lifocost { get; set; }
        public decimal? LifocostUnit { get; set; }
        public decimal? CoastAverage { get; set; }
        public decimal? CoastAverageUnit { get; set; }
        public string Remarks { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }
        public string Remarks3 { get; set; }
        public string ItemCardDesc { get; set; }
        public string ItemCardDescE { get; set; }
        public int? IsNoCostDeliver { get; set; }
        public bool? DeliverNoCostExecut { get; set; }

        public virtual MsItemCard ItemCard { get; set; }
        public virtual MsStockRecript StockRec { get; set; }
        public virtual MsItemUnit Unit { get; set; }
        public virtual ICollection<MsItemSerials> MsItemSerials { get; set; }
    }
}
