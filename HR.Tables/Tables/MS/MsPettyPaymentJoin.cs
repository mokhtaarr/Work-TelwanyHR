﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class MsPettyPaymentJoin
    {
        public int PetyPayId { get; set; }
        public int? PayId { get; set; }
        public int? PettycashId { get; set; }

        public virtual MsPaymentNote Pay { get; set; }
        public virtual MsPettycash Pettycash { get; set; }
    }
}
