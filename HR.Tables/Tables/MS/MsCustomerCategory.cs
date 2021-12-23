﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class MsCustomerCategory
    {
        public MsCustomerCategory()
        {
            MsCustomer = new HashSet<MsCustomer>();
        }

        public int CustomerCatId { get; set; }
        public string CatCode { get; set; }
        public string CatDescA { get; set; }
        public string CatDescE { get; set; }
        public int? ParentCustomerCatId { get; set; }
        public int? CustomerCatParent { get; set; }
        public int? CustomerCatLevel { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<MsCustomer> MsCustomer { get; set; }
    }
}
