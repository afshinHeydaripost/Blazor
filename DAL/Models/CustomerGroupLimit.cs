using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CustomerGroupLimit : BaseEntity
    {
        
        public int CustomerGroupId { get; set; }
        public int BrandId { get; set; }
        public int ProductId { get; set; }
        public int Limit { get; set; }
        public string? Description { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual CustomerGroup CustomerGroup { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
