﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class MsVwItemCardExcelExport
    {
        public string PartCode { get; set; }
        public string PartDescA { get; set; }
        public string StoreCode { get; set; }
        public string StoreDescA { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescA { get; set; }
        public string ItemDescE { get; set; }
        public string ItemCatCode { get; set; }
        public string ItemCatDescA { get; set; }
        public decimal? Quantity1 { get; set; }
        public decimal? Price1 { get; set; }
        public decimal? Quantity2 { get; set; }
        public decimal? Price2 { get; set; }
        public decimal? Quantity3 { get; set; }
        public decimal? Price3 { get; set; }
        public decimal? Quantity4 { get; set; }
        public decimal? Price4 { get; set; }
        public decimal? Price5 { get; set; }
        public decimal? Price6 { get; set; }
        public decimal? Price7 { get; set; }
        public decimal? Price8 { get; set; }
        public decimal? Price9 { get; set; }
        public decimal? Price10 { get; set; }
        public decimal? QtyInBox { get; set; }
        public decimal? PurchasePrice { get; set; }
        public string Remarks { get; set; }
        public decimal? QtyPartiation { get; set; }
        public decimal? QtyInNotebook { get; set; }
        public decimal? CoastAverage { get; set; }
        public int ItemCardId { get; set; }
        public int? ItemCategoryId { get; set; }
        public byte? ItemType { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnittRate { get; set; }
        public string BarCode1 { get; set; }
        public string BarCode2 { get; set; }
        public string BarCode3 { get; set; }
        public string BarCode4 { get; set; }
        public string BarCode5 { get; set; }
        public byte? DefaultBarCode { get; set; }
        public decimal? ManualPurchasePrice { get; set; }
        public decimal? LastSalePrice { get; set; }
        public bool? IsDefaultSale { get; set; }
        public bool? IsDefaultPurchas { get; set; }
        public string UnitCode { get; set; }
        public string UnitNam { get; set; }
        public string Symbol { get; set; }
        public bool? IsExpir { get; set; }
        public int? ExpirPeriod { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public string LotNumberExpiry { get; set; }
        public DateTime? ProdDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? Period { get; set; }
        public bool? Disabled { get; set; }
        public long? Tversion { get; set; }
        public string Ttype { get; set; }
        public long? MaxTversion { get; set; }
        public decimal? LastCost { get; set; }
        public decimal? BeforLastCost { get; set; }
        public decimal? ReservedQty { get; set; }
        public decimal? RequestedQty { get; set; }
        public decimal? SaleNotDelivered { get; set; }
        public decimal? PurNotReceived { get; set; }
        public decimal? QtyOutWithoutBalance { get; set; }
        public decimal? QtyInWithoutCost { get; set; }
        public decimal? SalesOrder { get; set; }
        public bool? IsCollection { get; set; }
        public bool? IsDimension { get; set; }
        public bool? IsAttributeItem { get; set; }
        public bool? IsSerialItem { get; set; }
        public string BarCode6 { get; set; }
        public string BarCode7 { get; set; }
        public string BarCode8 { get; set; }
        public string BarCode9 { get; set; }
        public string BarCode10 { get; set; }
        public string BarCode11 { get; set; }
        public string BarCode12 { get; set; }
        public string BarCode13 { get; set; }
        public string BarCode14 { get; set; }
        public string BarCode15 { get; set; }
    }
}
