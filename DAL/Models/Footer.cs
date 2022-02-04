using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Footer : BaseEntity
    {
        
        public int CategoryId { get; set; }
        public string Title { get; set; } = null!;
        public string? Url { get; set; }
        public string Target { get; set; } = null!;
        public int? OrderView { get; set; }
        public bool IsHidden { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual FooterCategory Category { get; set; } = null!;
    }
}
