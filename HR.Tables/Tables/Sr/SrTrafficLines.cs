﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class SrTrafficLines
    {
        public SrTrafficLines()
        {
            SrTrafficLinePriceList = new HashSet<SrTrafficLinePriceList>();
        }

        public int TrafficLineId { get; set; }
        public string TrafficCode { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string TrafficFrom { get; set; }
        public string TrafficTo { get; set; }
        public int? CityIdfrom { get; set; }
        public int? CityIdto { get; set; }
        public int? FromHarborId { get; set; }
        public int? ToHarborId { get; set; }
        public decimal? Km { get; set; }
        public decimal? Price { get; set; }
        public bool? PricebyContainer { get; set; }
        public bool? PricebyVehicl { get; set; }
        public decimal? EstimatCost { get; set; }
        public bool? CostbyContainer { get; set; }
        public bool? CostbyVehicl { get; set; }
        public string Remark { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<SrTrafficLinePriceList> SrTrafficLinePriceList { get; set; }
    }
}
