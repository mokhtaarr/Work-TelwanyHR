﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HR.Tables.Tables
{
    public partial class CrmLeadsMembersJoin
    {
        public int LeadMemberJoin { get; set; }
        public int? LeadMemberId { get; set; }
        public int? LeadId { get; set; }

        public virtual CrmLeads Lead { get; set; }
        public virtual CrmLeadsMembers LeadMember { get; set; }
    }
}
