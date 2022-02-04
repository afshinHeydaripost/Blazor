using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProductReview : BaseEntity
    {
        
        public int ProductId { get; set; }
        public string UserId { get; set; } = null!;
        public string? Title { get; set; }
        public string? Comment { get; set; }
        public double Rate { get; set; }
        public bool Approve { get; set; }
        public string? Answer { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
    }
}
