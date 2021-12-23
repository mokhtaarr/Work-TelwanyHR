﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class ProdItemAttributesBatche
    {
        public ProdItemAttributesBatche()
        {
            ProdItemAttributesBatchesDetails = new HashSet<ProdItemAttributesBatchesDetails>();
            ProdItemBatchPartition = new HashSet<ProdItemBatchPartition>();
            ProdJobOrderProducts = new HashSet<ProdJobOrderProducts>();
        }

        public int ItemAtrribBatchId { get; set; }
        public int? ItemCardId { get; set; }
        public string ItemBatchCode { get; set; }
        public string ItemBatchName1 { get; set; }
        public string ItemBatchName2 { get; set; }
        public string ItemBatchDesc { get; set; }
        public decimal? Tax { get; set; }
        public decimal? MultiplyValues { get; set; }
        public bool? UseBatchPrice { get; set; }
        public decimal? Price { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountValue { get; set; }
        public int? ParentBatchId { get; set; }
        public decimal? BatchLength { get; set; }
        public decimal? BatchWidth { get; set; }
        public decimal? BatchHieght { get; set; }
        public decimal? LengthMeter { get; set; }
        public decimal? LengthCentimeter { get; set; }
        public decimal? LengthMillimeters { get; set; }
        public decimal? WidthMeter { get; set; }
        public decimal? WidthCentimeter { get; set; }
        public decimal? WidthMillimeters { get; set; }
        public decimal? HeightMeter { get; set; }
        public decimal? HeightCentimeter { get; set; }
        public decimal? HeightMillimeters { get; set; }
        public bool? IsStandard { get; set; }
        public bool? IsOpened { get; set; }
        public bool? IsScrap { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal? QtyInBox { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? Wheight { get; set; }
        public bool? IsTempItem { get; set; }

        public virtual ICollection<ProdItemAttributesBatchesDetails> ProdItemAttributesBatchesDetails { get; set; }
        public virtual ICollection<ProdItemBatchPartition> ProdItemBatchPartition { get; set; }
        public virtual ICollection<ProdJobOrderProducts> ProdJobOrderProducts { get; set; }
    }
}
