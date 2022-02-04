using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Claim : BaseEntity
    {
        
        public int MenuId { get; set; }
        public string ClaimValue { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
