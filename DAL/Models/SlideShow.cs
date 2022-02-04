using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SlideShow : BaseEntity
    {
        
        public int CategoryId { get; set; }
        public string? Type { get; set; }
        public string? Url { get; set; }
        public string? Link { get; set; }
        public string? Description { get; set; }
        public string? Header1 { get; set; }
        public string? AnimHeader1 { get; set; }
        public string? Header2 { get; set; }
        public string? AnimHeader2 { get; set; }
        public bool IsHidden { get; set; }
        public int? OrderView { get; set; }
        public int? BrandId { get; set; }
        public int? ProductId { get; set; }
        public string UpdateUserId { get; set; } = null!;
        public DateTime UpdateDate { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual SlideShowCategory Category { get; set; } = null!;
        public virtual Product? Product { get; set; }
    }
}
